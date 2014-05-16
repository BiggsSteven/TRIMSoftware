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
        Dim data As DatabaseClass = New DatabaseClass

        Dim XLApp As Excel.Application = New Excel.ApplicationClass
        Dim xlWorkBook As Excel.Workbook = XLApp.Workbooks.Open(selectedFile)
        Dim XLWorkSheet As Excel.Worksheet = xlWorkBook.Worksheets("sheet3")
        Dim XLRow As Integer = 4
        Dim XLColumn As Integer = 0
        Dim ImpColumns() As Integer = {11, 12, 9, 8, 16}


        Dim tempArray(4) As String
        While XLWorkSheet.Cells(XLRow, 1).Value IsNot Nothing
            While XLColumn < ImpColumns.Length()
                tempArray(XLColumn) = XLWorkSheet.Cells(XLRow, ImpColumns(XLColumn)).value
                XLColumn += 1
            End While
            XLColumn = 0
            Dim tables As String = ConfigurationSettings.AppSettings("Act")
            Dim fieldsString As String = "[ID],[DATE],[TECHID],[TYPE],[TOTAL]"
            Dim condition As String = " [ID] = '" & tempArray(0) & "' AND [TECHID] = '" & tempArray(2) & "'"
            Dim fields(,) As String
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            'If Activity + Tech# is not existing -> Create
            If fields.Length = 0 Then
                data.RunDynamicInsert(tables, fieldsString, tempArray)
            Else
                Dim editFields() As String = {"[TYPE]"}
                Dim values() As String = {tempArray(3)}
                If tempArray(3) = "New Install" Or tempArray(3) = "Upgrade" Or tempArray(3) = "Former Install" Or tempArray(3) = "Service" Then
                    If fields(0, 3) <> "New Install" And fields(0, 3) <> "Upgrade" And fields(0, 3) <> "Former Install" And fields(0, 3) <> "Service" Then
                        data.RunDynamicUpdate(tables, condition, editFields, values)
                    End If
                End If
                editFields(0) = "[TOTAL]"
                values(0) = tempArray(4)
                data.RunDynamicUpdate(tables, condition, editFields, values)
            End If
                XLRow += 1
        End While

        MessageBox.Show("Your files have finished being imported")

    End Sub
    Private Sub importRec(ByVal selectedFile As String)

        Dim lineArray() As String
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")


        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()

            'call function to add to database

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
