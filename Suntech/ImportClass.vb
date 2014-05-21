Imports System.IO
Imports System.Configuration
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office

Public Class ImportClass

    Public inLine As String

    Public Sub selectFile(ByVal TypeSelect As Integer)
        'OpenFileDialog created and function chosen based off which menu option was chosen

        If TypeSelect = 1 Then
            FormHome.OpenFileDialog1.Filter = "Microsoft Excel 97-2003 Worksheet(.xls)|*.xls"
        Else
            FormHome.OpenFileDialog1.Filter = "Comma Separated Files(*.csv)|*.csv"
        End If

        Dim selectedFile As String = String.Empty
        If FormHome.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            selectedFile = FormHome.OpenFileDialog1.FileName
        End If
        If selectedFile <> String.Empty Then
            FormHome.Cursor = Cursors.WaitCursor

            Select Case TypeSelect
                Case 0
                    importTech(selectedFile)
                Case 1
                    importAct(selectedFile)
                Case 2
                    importRec(selectedFile)
                Case 3
                    importRecRet(selectedFile)
            End Select

            FormHome.Cursor = Cursors.Default
            MessageBox.Show("Your files have been successfully imported.")

        End If

    End Sub

    Private Sub importTech(ByVal selectedFile As String)
        Dim data As DatabaseClass = New DatabaseClass

        'Created parser
        Dim lineArray() As String
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")

        'Parse line
        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()

            'Check table if Tech is present
            Dim tables As String = ConfigurationSettings.AppSettings("Tech")
            Dim fieldsString As String = "[ID],[NAME],[LOCATION]"
            Dim condition As String = " [ID] = '" & lineArray(0) & "'"
            Dim fields(,) As String
            Data.RunDynamicSelect(tables, fieldsString, condition, fields)

            If fields.Length = 0 Then
                data.RunDynamicInsert(tables, fieldsString, lineArray)
                'MessageBox.Show("Tech: """ & lineArray(1) & """ not found, adding technician now")
            End If

            FormHome.BuildTechList()
        End While

    End Sub

    Private Sub importAct(ByVal selectedFile As String)
        'Item,Tech#,Activity,Date,Amount
        'ID,Date,TechID,Type,Account,Total,TechPay

        'Created Excel Reference to access cells within it.
        Dim data As DatabaseClass = New DatabaseClass

        Dim XLApp As Excel.Application = New Excel.ApplicationClass
        Dim xlWorkBook As Excel.Workbook = XLApp.Workbooks.Open(selectedFile)
        Dim XLWorkSheet As Excel.Worksheet = xlWorkBook.Worksheets("sheet3")
        Dim XLRow As Integer = 4
        Dim XLColumn As Integer = 0
        Dim ImpColumns() As Integer = {11, 12, 9, 8, 16}   'These are the Columns we care about reading in.
        Dim tempArray(ImpColumns.Length) As String 'The Array that hold the values retrieved from the excel document

        Dim tables As String
        Dim fieldsString As String
        Dim condition As String
        Dim fields(,) As String

        'Loop through rows
        While XLWorkSheet.Cells(XLRow, 1).Value IsNot Nothing
            'Loop through important columns
            While XLColumn < ImpColumns.Length()
                tempArray(XLColumn) = XLWorkSheet.Cells(XLRow, ImpColumns(XLColumn)).value
                XLColumn += 1
            End While
            XLColumn = 0
            If tempArray(ImpColumns.Length - 1) >= 0 Then
                tempArray(ImpColumns.Length) = tempArray(ImpColumns.Length - 1) * 0.7
            Else
                tempArray(ImpColumns.Length) = tempArray(ImpColumns.Length - 1)
            End If

            'Search Activities for if Activity and Tech has already been entered
            tables = ConfigurationSettings.AppSettings("Act")
            fieldsString = "[ID],[DATE],[TECHID],[TYPE],[TOTAL],[TECHPAY]"
            condition = " [ID] = '" & tempArray(0) & "' AND [TECHID] = '" & tempArray(2) & "'"
            ReDim fields(0, 0)
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            'If there is a return on that 
            If fields.Length = 0 Then
                data.RunDynamicInsert(tables, fieldsString, tempArray)
            Else
                'Updating the type if it is one of the 4
                Dim editFields() As String = {"[TYPE]"}
                Dim values() As String = {tempArray(3)}
                If tempArray(3) = "New Install" Or tempArray(3) = "Upgrade" Or tempArray(3) = "Former Install" Or tempArray(3) = "Service" Then
                    If fields(0, 3) <> "New Install" And fields(0, 3) <> "Upgrade" And fields(0, 3) <> "Former Install" And fields(0, 3) <> "Service" Then
                        data.RunDynamicUpdate(tables, condition, editFields, values)
                    End If
                End If
                'Update price
                ReDim editFields(1)
                ReDim values(1)
                editFields(0) = "[TOTAL]"
                editFields(1) = "[TECHPAY]"
                values(0) = Math.Round(CDbl(tempArray(4)) + CDbl(fields(0, 4)), 2)
                values(1) = Math.Round(CDbl(tempArray(5)) + CDbl(fields(0, 5)), 2)
                data.RunDynamicUpdate(tables, condition, editFields, values)

            End If
            XLRow += 1
        End While


    End Sub

    Private Sub importRec(ByVal selectedFile As String)

        Dim data As DatabaseClass = New DatabaseClass

        'Created parser
        Dim lineArray() As String
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")

        'Parse line
        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()

            'Check table if Reciever is present
            Dim tables As String = ConfigurationSettings.AppSettings("RecInv")
            Dim fieldsString As String = "[SERIALNUM],[FROMTECHID],[TOTECHID],[DATE]"
            Dim condition As String = " [SERIAL] = '" & lineArray(0) & "'"
            Dim fields(,) As String
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            If fields.Length = 0 Then
                data.RunDynamicInsert(tables, fieldsString, lineArray)
                'MessageBox.Show("Tech: """ & lineArray(1) & """ not found, adding technician now")
            End If

            FormHome.BuildTechList()
        End While

    End Sub

    Private Sub importRecRet(ByVal selectedFile As String)


        Dim lineArray() As String
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")


        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()

        End While

    End Sub

End Class
