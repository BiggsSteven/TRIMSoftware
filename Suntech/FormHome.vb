Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormHome

    Private Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.PayStubs' table. You can move, or remove it, as needed.
        Me.PayStubsTableAdapter.Fill(Me.DataSet1.PayStubs)
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

    Private Sub BtnGtInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGtInfo.Click
        Dim data As DatabaseClass = New DatabaseClass

        If RBTextSearch.Checked = True Then
            BuildTextQuery()
        ElseIf RBStrucSearch.Checked = True Then
            BuildStrucQuery()
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
            LblBalanceField.Text = total

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
            LblBalanceField.Text = total

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

    Private Sub TechniciansToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmTech.Click
        Dim ImportItem As ImportClass = New ImportClass
        ImportItem.selectFile(0, "Import Technician")
    End Sub

    Private Sub TSMItmActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmActive.Click
        Dim ImportItem As ImportClass = New ImportClass
        ImportItem.selectFile(1, "Import Activity")
    End Sub

    Private Sub TSMItmRecList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmRecList.Click
        Dim ImportItem As ImportClass = New ImportClass
        ImportItem.selectFile(2, "Import Receivers")
    End Sub

    Private Sub TSMItmRecRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmRecRet.Click
        'Dim ImportItem As ImportClass = New ImportClass
        'ImportItem.selectFile(2, "Import Receivers")
    End Sub

    Private Sub BtnPayTch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPayTch.Click
        Dim data As DatabaseClass = New DatabaseClass

        Dim CheckNumber As String = txtboxChkNum.Text
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



        LblBalanceField.Text = total




    End Sub

    Private Sub TransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferToolStripMenuItem.Click
        TransferForm.Show()
    End Sub

    Private Sub LstBoxTech_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstBoxTech.SelectedIndexChanged

    End Sub

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

    Private Sub TxtBoxSearch_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBoxSearch.KeyUp
        'Barcode Scanner is set to press "ENTER" after scanning
        'This will run after scanning
        If e.KeyCode = Keys.Enter Then
            BuildTextQuery()
        End If
    End Sub


End Class
