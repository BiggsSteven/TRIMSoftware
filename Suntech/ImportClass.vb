Imports System.IO
Imports System.Configuration

Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office

Imports System.Threading
Imports System.ComponentModel

Public Class ImportClass
    Private TypeSelected As Integer
    Private FileSelected As String
    Private WithEvents bgwkr As BackgroundWorker

    Public Sub selectFile(ByVal TypeSelect As Integer, ByVal titleStr As String)
        TypeSelected = TypeSelect
        'OpenFileDialog created and function chosen based off which menu option was chosen
        FormHome.OpenFileDialog1.Title = titleStr
        If TypeSelected = 1 Then
            FormHome.OpenFileDialog1.Filter = "Microsoft Excel 97-2003 Worksheet(.xls)|*.xls"
        Else
            FormHome.OpenFileDialog1.Filter = "Comma Separated Files(*.csv)|*.csv"
        End If
        'Get File from OFD
        FileSelected = String.Empty
        If FormHome.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Fileselected = FormHome.OpenFileDialog1.FileName
        End If

        'If it wasn't cancelled then start threading
        If FileSelected <> String.Empty Then
            If DuplicateCheck(TypeSelect) Then
                FormHome.Cursor = Cursors.WaitCursor
                FormLoading.Cursor = Cursors.WaitCursor
                FormLoading.Show()
                FormHome.BtnGtInfo.Enabled = False
                FormHome.BtnPayTch.Enabled = False

                bgwkr = New BackgroundWorker
                bgwkr.WorkerReportsProgress = True

                bgwkr.RunWorkerAsync()
            End If
        End If
    End Sub

    Public Function DuplicateCheck(ByRef TypeSelect As Integer)
        Dim data As DatabaseClass = New DatabaseClass
        Dim abridgeFile() As String = FileSelected.Split("\")
        Dim condition As String = " [FILEIMPORTED] = '" & abridgeFile(abridgeFile.Length() - 1) & "'"

        Dim fieldsString As String = "[FILEIMPORTED]"
        Dim fields(,) As String


        Dim table As String = String.Empty
        Dim editFields() As String
        Dim values() As String
        Dim proceed As Boolean = True
        Select Case TypeSelect
            Case 0

            Case 1
                table = ConfigurationManager.AppSettings("Act")
                ReDim editFields(2)
                editFields(0) = "[TOTAL]"
                editFields(1) = "[TECHPAY]"
                editFields(2) = "[PAID]"
                ReDim values(2)
                values(0) = 0
                values(1) = 0
                values(2) = 0
                data.RunDynamicSelect(table, fieldsString, condition, fields)

                If fields.Length <> 0 Then
                    proceed = False
                    AddDupe.ShowDialog()
                    If AddDupe.Choice Then
                        data.RunDynamicUpdate(table, condition, editFields, values)
                        proceed = True
                        AddDupe.Choice = False
                    End If
                End If

            Case 2
                table = ConfigurationManager.AppSettings("RecInv")
                ReDim editFields(0)
                editFields(0) = "[TECHID]"
                ReDim values(0)
                values(0) = "0000000000"
                data.RunDynamicSelect(table, fieldsString, condition, fields)


                If fields.Length <> 0 Then
                    proceed = False
                    AddDupe.ShowDialog()
                    If AddDupe.Choice Then

                        data.RunDynamicUpdate(table, condition, editFields, values)
                        proceed = True
                        AddDupe.Choice = False
                    End If
                End If

        End Select

        Return proceed

    End Function

    Private Sub bgwkr_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles bgwkr.DoWork

        Select Case TypeSelected
            Case 0
                importTech(FileSelected)
            Case 1
                importAct(FileSelected)
            Case 2
                importRec(FileSelected)
            Case 3
                'importRecRet(FileSelected)
        End Select

    End Sub

    Private Sub bgwkrProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwkr.ProgressChanged
        FormLoading.ProgBarImport.Value = e.ProgressPercentage
    End Sub

    Private Sub bgwkrRunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwkr.RunWorkerCompleted
        FormHome.BtnGtInfo.Enabled = True
        FormHome.BtnPayTch.Enabled = True
        FormHome.OpenFileDialog1.Title = String.Empty
        FormHome.Cursor = Cursors.Default
        FormLoading.Cursor = Cursors.Default
        FormLoading.Hide()
        FormLoading.ProgBarImport.Value = 0

        MessageBox.Show("Your files have been successfully imported.")

    End Sub

    Private Sub importTech(ByVal selectedFile As String)
        Dim data As DatabaseClass = New DatabaseClass
        '------------------------------------
        'Created parser
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")


        Dim tables As String = ConfigurationManager.AppSettings("Tech")
        Dim fieldsString As String = "[ID],[NAME],[LOCATION]"
        Dim condition As String
        Dim fields(,) As String
        Dim lineArray() As String = {"0000000000", "Employer", "Default"}
        '------------------------------------
        'Parse line
        While Not MyReader.EndOfData

            '------------------------
            'Check table if Tech is present
            condition = " [ID] = '" & lineArray(0) & "'"
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            '------------------------
            'If there is not one already by that Techid
            If fields.Length = 0 Then
                data.RunDynamicInsert(tables, fieldsString, lineArray)
            End If

            lineArray = MyReader.ReadFields()
        End While
        '------------------------
        'After importing Technicians listbox needs to be updated
        condition = String.Empty
        data.RunDynamicSelect(tables, fieldsString, condition, fields)
        FormHome.BuildTechList()

    End Sub

    Private Sub importAct(ByVal selectedFile As String)


        '-------------------------------------------------
        'Created Excel Reference to access cells within it.
        Dim data As DatabaseClass = New DatabaseClass
        Dim XLApp As Excel.Application = New Excel.ApplicationClass
        Dim xlWorkBook As Excel.Workbook = XLApp.Workbooks.Open(selectedFile)
        Dim XLWorkSheet As Excel.Worksheet = xlWorkBook.Worksheets("sheet3")
        Dim XLRow As Integer = 4
        Dim XLColumn As Integer = 0
        Dim ImpColumns() As Integer = {11, 12, 9, 8, 16}   'These are the Columns we care about reading in.
        Dim tempArray(ImpColumns.Length + 2) As String 'The Array that hold the values retrieved from the excel document
        '-------------------------------------------------
        'these are the variables that hold the query parts
        Dim tables As String
        Dim fieldsString As String
        Dim condition As String
        Dim fields(,) As String
        Dim XLSheetBounds As Integer = XLWorkSheet.Rows.Count()
        Dim XLastRow As Integer = 0

        Dim abridgeFile() As String = selectedFile.Split("\")


        'Finding the number of rows in file so that the progress bar may accurately portray progress
        While XLSheetBounds - XLastRow >= 2
            Dim temp As Integer = (((XLSheetBounds - XLastRow) / 2) + XLastRow)
            If XLWorkSheet.Cells(temp, 1).Value IsNot Nothing Then
                XLastRow = temp
            Else
                XLSheetBounds = temp
            End If
        End While

        '------------------------------------------------------------------------------------------
        'While the worksheet still has rows to be read
        While XLWorkSheet.Cells(XLRow, 1).Value IsNot Nothing

            '---------------------------------------
            'Loop through important array that saves the column number for the columns we care about
            While XLColumn < ImpColumns.Length()
                tempArray(XLColumn) = XLWorkSheet.Cells(XLRow, ImpColumns(XLColumn)).value 'save value from row to array
                XLColumn += 1
            End While
            XLColumn = 0

            '---------------------------------------
            'If technician did work correctly he gets 70% of the income or 30 dollars from a service call
            'If technician did work incorrectly he gets 100% of the negative value
            If tempArray(ImpColumns.Length - 1) = 37 Then
                tempArray(ImpColumns.Length) = 30
            ElseIf tempArray(ImpColumns.Length - 1) >= 0 Then
                tempArray(ImpColumns.Length) = tempArray(ImpColumns.Length - 1) * 0.7
            Else
                tempArray(ImpColumns.Length) = tempArray(ImpColumns.Length - 1)
            End If

            '---------------------------------------
            'set paid to be not paid yet
            tempArray(tempArray.Length - 2) = 0
            tempArray(tempArray.Length - 1) = abridgeFile(abridgeFile.Length() - 1)
            '---------------------------------------
            'Search Activities for if Activity and Tech has already been entered
            tables = ConfigurationManager.AppSettings("Act")
            fieldsString = "[ID],[DATE],[TECHID],[TYPE],[TOTAL],[TECHPAY],[PAID],[FILEIMPORTED]"
            condition = " [ID] = '" & tempArray(0) & "' AND [TECHID] = '" & tempArray(2) & "'"
            ReDim fields(0, 0)
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            '---------------------------------------
            'If there is no copy of this activity, Insert one
            'Else update old one (this will combine all parts of an activity into one
            If fields.Length = 0 Then
                data.RunDynamicInsert(tables, fieldsString, tempArray)
            Else
                '-------------------------
                'Updating the type if it is one of the four
                Dim editFields() As String = {"[TYPE]"}
                Dim values() As String = {tempArray(3)}
                If values(0) = "New Install" Or values(0) = "Upgrade" Or values(0) = "Former Install" Or values(0) = "Service" Then
                    data.RunDynamicUpdate(tables, condition, editFields, values)
                End If

                '-------------------------
                'Update price
                ReDim editFields(1)
                ReDim values(1)
                editFields(0) = "[TOTAL]"
                editFields(1) = "[TECHPAY]"
                values(0) = Math.Round(CDbl(tempArray(4)) + CDbl(fields(0, 4)), 2)
                values(1) = Math.Round(CDbl(tempArray(5)) + CDbl(fields(0, 5)), 2)
                data.RunDynamicUpdate(tables, condition, editFields, values)
                '-------------------------
            End If


            bgwkr.ReportProgress(CInt(100 * (XLRow / XLastRow)))
            XLRow += 1
        End While
        '------------------------------------------------------------------------------------------

    End Sub

    Private Sub importRec(ByVal selectedFile As String)
        Dim data As DatabaseClass = New DatabaseClass
        '------------------------------------
        'Created parser
        Dim lineArray() As String
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")
        Dim abridgeFile() As String = selectedFile.Split("\")

        '------------------------------------
        'Parse line
        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()
            '------------------------
            'Check table if Reciever is present
            Dim tables As String = ConfigurationManager.AppSettings("RecInv")
            Dim fieldsString As String = "[SERIALNUM], [ACCESSCARD], [TECHID], [DATEIN], [DATEOUT], [FILEIMPORTED]"
            Dim condition As String = " [SERIALNUM] = '" & lineArray(2) & "'"
            Dim fields(,) As String = {{}, {}}
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            '------------------------
            'If there is not one already by that serialNumber we need to create and insert one
            If fields.Length = 0 And lineArray(2) <> "" Then
                Dim dateEnd As Date = DateAdd(DateInterval.Day, 13, CDate(lineArray(11)))
                Dim MVField() As String = {lineArray(2), lineArray(3), "0000000000", CDate(lineArray(11)), dateEnd, abridgeFile(abridgeFile.Length() - 1)}
                data.RunDynamicInsert(tables, fieldsString, MVField)
            End If
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
