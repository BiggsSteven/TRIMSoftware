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
        Dim XLRow As Integer = 3
        Dim XLColumn As Integer = 4


        MsgBox(XLWorkSheet.Cells(XLRow, XLColumn).value)

        'Dim lineArray() As String
        'Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        'MyReader.TextFieldType = FileIO.FieldType.Delimited
        'MyReader.SetDelimiters(",")

        ''read in line -> if activity exist ->Update 
        ''else                              ->Insert

        'While Not MyReader.EndOfData
        '    lineArray = MyReader.ReadFields()

        '    Dim tables As String = ConfigurationSettings.AppSettings("Act")
        '    Dim fieldsString As String = "[ID],[DATE],[TECHID],[TYPE],[ACCOUNT],[TOTAL],[TECHPAY]"
        '    Dim condition As String = " [ID] = '" & lineArray(2) & "'"
        '    Dim fields(,) As String
        '    data.RunDynamicSelect(tables, fieldsString, condition, fields)

        '    If fields.Length = 0 Then
        '        'Dim tempArray() As String = {}
        '    End If

        'End While

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
