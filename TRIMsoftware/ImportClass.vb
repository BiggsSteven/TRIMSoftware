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
            FileSelected = FormHome.OpenFileDialog1.FileName
        End If

        'If it wasn't cancelled then start threading
        If FileSelected <> String.Empty Then
            FormHome.Cursor = Cursors.WaitCursor
            FormLoading.Cursor = Cursors.WaitCursor
            FormLoading.Show()
            'FormHome.BtnGtInfo.Enabled = False
            'FormHome.BtnPayTch.Enabled = False
            FormHome.Enabled = False

            bgwkr = New BackgroundWorker
            bgwkr.WorkerReportsProgress = True

            bgwkr.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgwkr_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles bgwkr.DoWork

        Select Case TypeSelected
            Case 1
                importAct(FileSelected)
        End Select

    End Sub

    Private Sub bgwkrProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwkr.ProgressChanged
        FormLoading.ProgBarImport.Value = e.ProgressPercentage
    End Sub

    Private Sub bgwkrRunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwkr.RunWorkerCompleted
        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("ImpHist")
        Dim fieldsString As String = "[FILEIMPORT],[DATE]"
        Dim abridgeFile() As String = FileSelected.Split("\")
        Dim fields() As String = {abridgeFile(abridgeFile.Length() - 1), DateTime.Now.Date}
        data.RunDynamicInsert(table, fieldsString, fields)
        FormHome.Enabled = True
        FormHome.OpenFileDialog1.Title = String.Empty
        FormHome.Cursor = Cursors.Default
        FormLoading.Close()
        FormLoading.Dispose()
    End Sub

    Private Sub importAct(ByVal selectedFile As String)

        '-------------------------------------------------
        'Created Excel Reference to access cells within it.
        Dim data As DatabaseClass = New DatabaseClass
        Dim XLApp As Excel.Application = New Excel.ApplicationClass
        Dim xlWorkBook As Excel.Workbook = XLApp.Workbooks.Open(selectedFile)
        Dim XLWorkSheet As Excel.Worksheet = xlWorkBook.Worksheets("sheet3")
        Dim XLRow As Integer = 0
        Dim XLColumn As Integer = 0
        
        '-------------------------------------------------
        'these are the variables that hold the query parts
        Dim tables As String
        Dim fieldsString As String
        Dim condition As String
        Dim fields(,) As String
        Dim values() As String
        Dim XLSheetBounds As Integer = XLWorkSheet.Rows.Count()
        Dim XLastRow As Integer = 0
        Dim proceed As Boolean = True
        Dim abridgeFile() As String = selectedFile.Split("\")

        Dim SvcSettings As Boolean = False
        Dim StaticSvcPay As Double = 0
        Dim DefaultPay As Double = 0

        'Get the settings for if the service call is paid with a static value and what that static value is
        tables = ConfigurationManager.AppSettings("Options")
        fieldsString = ("[UseStaticSrvc],[SrvcPay],[DefaultPay]")
        condition = ""
        ReDim fields(0, 0)
        data.RunDynamicSelect(tables, fieldsString, condition, fields)

        If fields.Length <> 0 Then
            SvcSettings = fields(0, 0)
            If SvcSettings = True Then
                StaticSvcPay = fields(0, 1)
            End If
            DefaultPay = fields(0, 2)
        End If

        'Finding the number of rows in file so that the progress bar may accurately portray progress
        While XLSheetBounds - XLastRow >= 2
            Dim temp As Integer = (((XLSheetBounds - XLastRow) / 2) + XLastRow)
            If XLWorkSheet.Cells(temp, 1).Value IsNot Nothing Then
                XLastRow = temp
            Else
                XLSheetBounds = temp
            End If
        End While




        Dim ImpColumns() As Integer 'These are the Columns we care about reading in.
        Dim startRow As Integer
        readRecordStart(ImpColumns, startRow) 'This is where we Save the location of the important columns
        Dim tempArray(ImpColumns.Length + 2) As String 'The Array that hold the values retrieved from the excel document
        XLRow = startRow
        '------------------------------------------------------------------------------------------
        'While the worksheet still has rows to be read
        While XLWorkSheet.Cells(XLRow, 1).Value <> String.Empty And proceed = True


            '---------------------------------------
            'Loop through important array that saves the column number for the columns we care about
            While XLColumn < ImpColumns.Length()
                tempArray(XLColumn) = XLWorkSheet.Cells(XLRow, ImpColumns(XLColumn)).value 'save value from row to array
                XLColumn += 1
            End While


            'Check the first activity for previous appearances
            If XLRow = startRow Then
                tables = ConfigurationManager.AppSettings("Act")
                fieldsString = "[ID],[FILEIMPORTED],[TYPE]"
                'Since the same activity ID may be present as long as Type is Service and non service
                If tempArray(3) = "Service" Then
                    condition = " [ID] = '" & tempArray(0) & "' AND [TYPE] = 'Service' "
                Else
                    condition = " [ID] = '" & tempArray(0) & "' AND [TYPE] <> 'Service' "
                End If
                data.RunDynamicSelect(tables, fieldsString, condition, fields)

                If fields.Length <> 0 Then
                    'The activity is present
                    Dim oldFile As String = fields(0, 1) 'This is the file that is currently on record for this activity
                    AddDupe.ShowDialog()
                    If AddDupe.Choice Then
                        'Chosen to Reimport File
                        'Update all files with the old filename to have values of 0, 0, and new filename
                        condition = " [FILEIMPORTED] = '" & oldFile & "' "
                        Dim editfields() As String = {"[TOTAL]", "[TECHPAY]", "[FILEIMPORTED]"}
                        ReDim values(2)
                        values(0) = 0
                        values(1) = 0
                        values(2) = abridgeFile(abridgeFile.Length() - 1)
                        data.RunDynamicUpdate(tables, condition, editfields, values)
                        AddDupe.Choice = False
                        proceed = True
                    Else
                        'Do not proceed
                        proceed = False
                    End If
                End If
            End If

            If proceed = True Then
                'Proceeds
                XLColumn = 0

                '---------------------------------------------------------------
                'Get the Technicians paypercentage
                Dim techPayPercent As Double = 0
                tables = ConfigurationManager.AppSettings("Tech")
                fieldsString = "[ID],[PayPercentage]"
                condition = " [ID] = '" & tempArray(2) & "' "
                ReDim fields(0, 0)
                data.RunDynamicSelect(tables, fieldsString, condition, fields)

                If fields.Length <> 0 Then
                    techPayPercent = fields(0, 1)
                Else
                    techPayPercent = DefaultPay
                End If

                '---------------------------------------------------------------
                'If setting is checked, successful service calls receives a static amount
                'If technician did work correctly he gets a % of the income
                'If technician did work incorrectly he gets 100% of the negative value
                If tempArray(ImpColumns.Length - 1) = 37 And SvcSettings = True Then
                    tempArray(ImpColumns.Length) = StaticSvcPay
                ElseIf tempArray(ImpColumns.Length - 1) >= 0 Then
                    tempArray(ImpColumns.Length) = tempArray(ImpColumns.Length - 1) * techPayPercent
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


                If tempArray(3) = "Service" Then
                    condition = " [ID] = '" & tempArray(0) & "' AND [TYPE] = 'Service' "
                Else
                    condition = " [ID] = '" & tempArray(0) & "' AND [TYPE] <> 'Service' "
                End If

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
                    ReDim values(0)
                    values(0) = tempArray(3)

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

                'Display progress
                bgwkr.ReportProgress(CInt(100 * (XLRow / XLastRow)))
                XLRow += 1

            End If
        End While
        '------------------------------------------------------------------------------------------
        If proceed = True Then
            MessageBox.Show("Your files have been successfully imported.")
        Else
            MessageBox.Show("File Import was cancelled.")
        End If


        XLWorkSheet = Nothing
        xlWorkBook = Nothing
        XLApp.Quit()
        XLApp = Nothing


    End Sub

    Public Sub readRecordStart(ByRef importantColumns() As Integer, ByRef startRow As Integer)
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Program Files\TRIM\ImAcInfo.csv")
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")

        Dim temparray As String()
        While Not MyReader.EndOfData
            Try
                temparray = MyReader.ReadFields()


            Catch ex As Microsoft.VisualBasic.
                        FileIO.MalformedLineException
                MsgBox("Line " & ex.Message &
                "is not valid and will be skipped.")
            End Try
        End While

        Dim parser As Integer = 0
        ReDim importantColumns(temparray.Length - 2)
        While parser < temparray.Length() - 1
            importantColumns(parser) = temparray(parser)
            parser += 1
        End While

        startRow = temparray(temparray.Length() - 1)


    End Sub

End Class
