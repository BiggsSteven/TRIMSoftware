Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports System.Threading
Imports System.ComponentModel

Public Class FormHome

    Private Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sub to Initialize the Technician list
        BuildTechList()
        RBStrucSearch.Checked = True


    End Sub

    Public Sub BuildTechList()
        Dim data As DatabaseClass = New DatabaseClass
        LstBoxTech.Items.Clear()

        'runs a select Query to retrieve list of Techs
        Dim table As String = ConfigurationSettings.AppSettings("Tech")
        Dim fieldString As String = "[ID], [NAME]"
        Dim TechArray(,) As String
        data.RunDynamicSelect(table, fieldString, "", TechArray)

        'Populate listbox with Technicians
        Dim counter As Integer = 0
        While (counter < TechArray.GetLength(0))
            LstBoxTech.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 1))
            counter += 1
        End While

        LstBoxTech.SelectedItem = LstBoxTech.Items.Item(0)

    End Sub
    '-----------------------------------------------------------
    Private Sub RBTextSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBTextSearch.CheckedChanged
        If RBTextSearch.Checked = True Then
            TxtBoxSearch.Enabled = True
            TxtBoxSearch.Select()
            LstBoxTech.Enabled = False
            DTPkrFrom.Enabled = False
            DTPkrEnd.Enabled = False
            LblDtFrm.Enabled = False
            LblDtEnd.Enabled = False
        End If
    End Sub

    Private Sub RBStrucSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBStrucSearch.CheckedChanged
        If RBStrucSearch.Checked = True Then
            TxtBoxSearch.Enabled = False
            TxtBoxSearch.Text = String.Empty
            LstBoxTech.Enabled = True
            DTPkrFrom.Enabled = True
            DTPkrEnd.Enabled = True
            LblDtFrm.Enabled = True
            LblDtEnd.Enabled = True
        End If
    End Sub

    Private Sub RBAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBAll.CheckedChanged
        If RBAll.Checked = True Then
            TxtBoxSearch.Enabled = False
            TxtBoxSearch.Text = String.Empty
            LstBoxTech.Enabled = False
            DTPkrFrom.Enabled = True
            DTPkrEnd.Enabled = True
            LblDtFrm.Enabled = True
            LblDtEnd.Enabled = True
        End If
    End Sub

    '-----------------------------------------------------------
    Private Sub BtnGtInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGtInfo.Click
        Dim data As DatabaseClass = New DatabaseClass

        If RBTextSearch.Checked = True Then
            BuildTextQuery()
        ElseIf RBStrucSearch.Checked = True Then
            BuildStrucQuery()
        ElseIf RBAll.Checked = True Then
            BuildUnfilteredQuery()
        End If
    End Sub

    Private Sub BuildUnfilteredQuery()
        Dim data As DatabaseClass = New DatabaseClass
        'set query
        Dim bgnDate As String = DTPkrFrom.Value.Date
        Dim endDate As String = DTPkrEnd.Value.Date

        'reset datasource
        Dim fieldsString As String = "*"

        Dim tables() As String = {ConfigurationSettings.AppSettings("Act"), ConfigurationSettings.AppSettings("RecInv"), _
                                 ConfigurationSettings.AppSettings("RecTrans"), ConfigurationSettings.AppSettings("Pay")}
        Dim LiveTable As Integer = TabCtrlDGV.SelectedIndex()
        Dim fields(,) As String
        Dim condition As String

        If LiveTable = 0 Then
            condition = "[DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ActivitiesDataGridView.DataSource = data.dt
            Dim rowsCount As Integer = 0
            Dim total As Double = 0
            While rowsCount < ActivitiesDataGridView.Rows.Count
                If ActivitiesDataGridView.Rows(rowsCount).Cells(6).Value = 0 Then
                    total += ActivitiesDataGridView.Rows(rowsCount).Cells(5).Value
                End If
                rowsCount += 1
            End While
            LblBalanceField.Text = Format(total, "c2")

        ElseIf LiveTable = 1 Then
            condition = "([DATEIN] BETWEEN '" & bgnDate & "' AND '" _
            & endDate & "' OR [DATEOUT] BETWEEN '" & bgnDate & "' AND '" & endDate & "')"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverInvDataGridView.DataSource = data.dt

        ElseIf LiveTable = 2 Then
            condition = "[DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverTransferDataGridView.DataSource = data.dt

        ElseIf LiveTable = 3 Then
            condition = "[DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            PayStubsDataGridView.DataSource = data.dt
        End If


    End Sub

    Private Sub BuildStrucQuery()
        Dim data As DatabaseClass = New DatabaseClass
        'set query
        Dim TechSelected As String = LstBoxTech.SelectedItem
        TechSelected = TechSelected.Substring(0, 10)
        Dim bgnDate As String = DTPkrFrom.Value.Date
        Dim endDate As String = DTPkrEnd.Value.Date

        'reset datasource
        Dim fieldsString As String = "*"

        Dim tables() As String = {ConfigurationSettings.AppSettings("Act"), ConfigurationSettings.AppSettings("RecInv"), _
                                 ConfigurationSettings.AppSettings("RecTrans"), ConfigurationSettings.AppSettings("Pay")}
        Dim LiveTable As Integer = TabCtrlDGV.SelectedIndex()
        Dim fields(,) As String
        Dim condition As String

        If LiveTable = 0 Then
            condition = "[TECHID] = '" & TechSelected & "' AND [DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ActivitiesDataGridView.DataSource = data.dt
            Dim rowsCount As Integer = 0
            Dim total As Double = 0
            While rowsCount < ActivitiesDataGridView.Rows.Count
                If ActivitiesDataGridView.Rows(rowsCount).Cells(6).Value = 0 Then
                    total += ActivitiesDataGridView.Rows(rowsCount).Cells(5).Value
                End If
                rowsCount += 1
            End While
            LblBalanceField.Text = Format(total, "c2")

        ElseIf LiveTable = 1 Then
            condition = "[TECHID] = '" & TechSelected & "' AND ([DATEIN] BETWEEN '" & bgnDate & "' AND '" _
            & endDate & "' OR [DATEOUT] BETWEEN '" & bgnDate & "' AND '" & endDate & "')"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverInvDataGridView.DataSource = data.dt

        ElseIf LiveTable = 2 Then
            condition = "([FROMTECHID] = '" & TechSelected & "' OR [TOTECHID] = '" & TechSelected _
                        & "') AND [DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverTransferDataGridView.DataSource = data.dt

        ElseIf LiveTable = 3 Then
            condition = "[TECHID] = '" & TechSelected & "' AND [DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            PayStubsDataGridView.DataSource = data.dt
        End If


    End Sub

    Private Sub BuildTextQuery()
        Dim data As DatabaseClass = New DatabaseClass
        Dim fieldsString As String = "*"
        Dim FieldInput As String = TxtBoxSearch.Text

        Dim tables() As String = {ConfigurationSettings.AppSettings("Act"), ConfigurationSettings.AppSettings("RecInv"), _
                                 ConfigurationSettings.AppSettings("RecTrans"), ConfigurationSettings.AppSettings("Pay")}
        Dim LiveTable As Integer = TabCtrlDGV.SelectedIndex()
        Dim fields(,) As String
        Dim condition As String

        If LiveTable = 0 Then
            condition = "[ID] = '" & FieldInput & "' OR [TECHID] = '" & FieldInput & "'"
            Data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ActivitiesDataGridView.DataSource = Data.dt
            Dim rowsCount As Integer = 0
            Dim total As Double = 0
            While rowsCount < ActivitiesDataGridView.Rows.Count
                If ActivitiesDataGridView.Rows(rowsCount).Cells(6).Value = 0 Then
                    total += ActivitiesDataGridView.Rows(rowsCount).Cells(5).Value
                End If
                rowsCount += 1
            End While
            LblBalanceField.Text = Format(total, "c2")

        ElseIf LiveTable = 1 Then
            condition = "[SERIALNUM] = '" & FieldInput & "' OR [ACCESSCARD] = '" & FieldInput _
                        & "' OR [TECHID] = '" & FieldInput & "'"
            Data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverInvDataGridView.DataSource = Data.dt

        ElseIf LiveTable = 2 Then
            condition = "[SERIALNUM] = '" & FieldInput & "' OR [FROMTECHID] = '" & FieldInput _
                        & "' OR [TOTECHID] = '" & FieldInput & "'"
            Data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverTransferDataGridView.DataSource = Data.dt

        ElseIf LiveTable = 3 Then
            condition = "[CHECKNUMBER] = '" & FieldInput & "' OR [TECHID] = '" & FieldInput & "'"
            Data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            PayStubsDataGridView.DataSource = Data.dt
        End If

    End Sub

    Private Sub TxtBoxSearch_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBoxSearch.KeyUp
        'Barcode Scanner is set to press "ENTER" after scanning
        'This will run after scanning
        If e.KeyCode = Keys.Enter Then
            BuildTextQuery()
        End If
    End Sub

    '-----------------------------------------------------------
    Private Sub TSMItemTech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmTech.Click
        selectFile(0, "Import Technician")
    End Sub

    Private Sub TSMItmActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmActive.Click
        selectFile(1, "Import Activity")
    End Sub

    Private Sub TSMItmRecList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmRecList.Click
        selectFile(2, "Import Receivers")
    End Sub

    Private Sub TSMItmRecRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim ImportItem As ImportClass = New ImportClass
        'ImportItem.selectFile(2, "Import Receivers")
    End Sub

    Private Sub ReceiverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiverToolStripMenuItem.Click
        TransferForm.Show()
    End Sub

    '-----------------------------------------------------------
    Private Sub BtnPayTch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPayTch.Click
        Dim data As DatabaseClass = New DatabaseClass

        Dim CheckNumber As String = txtboxChkNum.Text

        If CheckNumber <> String.Empty And CDbl(LblBalanceField.Text) <> 0 Then

            Dim tables As String = ConfigurationSettings.AppSettings("Pay")
            Dim fieldString As String = "[CHECKNUMBER], [DATE], [TECHID], [AMOUNT]"
            Dim fields() As String = {CheckNumber, DateTime.Now.Date, ActivitiesDataGridView.Rows(0).Cells(0).Value, CDbl(LblBalanceField.Text)}
            data.RunDynamicInsert(tables, fieldString, fields)


            tables = ConfigurationSettings.AppSettings("Act")
            fieldString = "[ID],[DATE],[TECHID],[TYPE],[TOTAL],[TECHPAY],[PAID]"
            Dim condition As String
            'Calculate pay for Tech
            Dim rowsCount As Integer = 0
            Dim total As Double = 0
            While rowsCount < ActivitiesDataGridView.Rows.Count
                Dim editFields() As String = {"[PAID]"}
                Dim values() As String = {1}
                condition = " [ID] = '" & ActivitiesDataGridView.Rows(rowsCount).Cells(3).Value & "' " _
                    & "AND [TECHID] = '" & ActivitiesDataGridView.Rows(rowsCount).Cells(0).Value & "'"
                data.RunDynamicUpdate(tables, condition, editFields, values)
                ActivitiesDataGridView.Rows(rowsCount).Cells(6).Value = 1
                rowsCount += 1
            End While


            LblBalanceField.Text = Format(total, "c2")

        ElseIf CDbl(LblBalanceField.Text) <> 0 Then
            MessageBox.Show("The current balance is for $0." & Environment.NewLine _
                            & "Please Search for a Technician with live activities " & Environment.NewLine _
                            & " before attemping to settle the balance.")

        ElseIf CheckNumber = String.Empty Then
            MessageBox.Show("The check number field was left blank." & Environment.NewLine _
                            & "Please enter the check number into the textbox and try again.")

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'OpenFileDialog created and function chosen based off which menu option was chosen
        OpenFileDialog1.Title = titleStr
        If TypeSelect = 1 Then
            OpenFileDialog1.Filter = "Microsoft Excel 97-2003 Worksheet(.xls)|*.xls"
        Else
            OpenFileDialog1.Filter = "Comma Separated Files(*.csv)|*.csv"
        End If
        'Get File from OFD
        Dim selectedFile As String = String.Empty
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            selectedFile = OpenFileDialog1.FileName
        End If
        'If it wasn't cancelled then start threading
        If selectedFile <> String.Empty Then
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
            OpenFileDialog1.Title = String.Empty
            Cursor = Cursors.Default
            FormLoading.Hide()
            MessageBox.Show("Your files have been successfully imported.")
        End If

    End Sub

    Public Sub selectFile(ByVal TypeSelect As Integer, ByVal titleStr As String)


        End If
    End Sub

    Private Sub importTech(ByVal selectedFile As String)
        Dim data As DatabaseClass = New DatabaseClass
        '------------------------------------
        'Created parser
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")


        Dim tables As String = ConfigurationSettings.AppSettings("Tech")
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
            ReDim fields(0, 0)
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
        BuildTechList()


    End Sub

    Private Sub importAct(ByVal selectedFile As String)
        'Item,Tech#,Activity,Date,Amount
        'ID,Date,TechID,Type,Account,Total,TechPay
        '-------------------------------------------------
        'Created Excel Reference to access cells within it.
        Dim data As DatabaseClass = New DatabaseClass
        Dim XLApp As Excel.Application = New Excel.ApplicationClass
        Dim xlWorkBook As Excel.Workbook = XLApp.Workbooks.Open(selectedFile)
        Dim XLWorkSheet As Excel.Worksheet = xlWorkBook.Worksheets("sheet3")
        Dim XLRow As Integer = 4
        Dim XLColumn As Integer = 0
        Dim ImpColumns() As Integer = {11, 12, 9, 8, 16}   'These are the Columns we care about reading in.
        Dim tempArray(ImpColumns.Length + 1) As String 'The Array that hold the values retrieved from the excel document
        '-------------------------------------------------
        'these are the variables that hold the query parts
        Dim tables As String
        Dim fieldsString As String
        Dim condition As String
        Dim fields(,) As String

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
            tempArray(tempArray.Length - 1) = 0

            '---------------------------------------
            'Search Activities for if Activity and Tech has already been entered
            tables = ConfigurationSettings.AppSettings("Act")
            fieldsString = "[ID],[DATE],[TECHID],[TYPE],[TOTAL],[TECHPAY],[PAID]"
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


        '------------------------------------
        'Parse line
        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()
            '------------------------
            'Check table if Reciever is present
            Dim tables As String = ConfigurationSettings.AppSettings("RecInv")
            Dim fieldsString As String = "[SERIALNUM], [ACCESSCARD], [TECHID], [DATEIN], [DATEOUT]"
            Dim condition As String = " [SERIALNUM] = '" & lineArray(2) & "'"
            Dim fields(,) As String
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            '------------------------
            'If there is not one already by that serialNumber we need to create and insert one
            If fields.Length = 0 And lineArray(2) <> "" Then
                Dim dateEnd As Date = DateAdd(DateInterval.Day, 13, CDate(lineArray(11)))
                Dim MVField() As String = {lineArray(2), lineArray(3), "0000000000", CDate(lineArray(11)), dateEnd}
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
