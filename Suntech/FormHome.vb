Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormHome



    Private Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sub to Initialize the Technician list
        BuildTechList()
        '   ActivitiesDataGridView.Visible = False


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

        BuildActQuery()
        BuildRecQuery()
    End Sub

    Private Sub BuildActQuery()
        Dim data As DatabaseClass = New DatabaseClass
        'set query
        Dim TechSelected As String = LstBoxTech.SelectedItem
        TechSelected = TechSelected.Substring(0, 10)
        Dim bgnDate As String = DTPkrFrom.Value.Date
        Dim endDate As String = DTPkrEnd.Value.Date

        'reset datasource
        Dim tables As String = ConfigurationSettings.AppSettings("Act")
        Dim fieldsString As String = "[ID],[DATE],[TECHID],[TYPE],[TOTAL],[TECHPAY],[PAID]"
        Dim condition As String = "[TECHID] = '" & TechSelected & "' AND [DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
        Dim fields(,) As String
        data.RunDynamicSelect(tables, fieldsString, condition, fields)
        ActivitiesDataGridView.DataSource = data.dt
        ActivitiesDataGridView.Sort(ActivitiesDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        'Calculate pay for Tech
        Dim rowsCount As Integer = 0
        Dim total As Double = 0
        While rowsCount < ActivitiesDataGridView.Rows.Count
            If ActivitiesDataGridView.Rows(rowsCount).Cells(6).Value = 0 Then
                total += ActivitiesDataGridView.Rows(rowsCount).Cells(5).Value
            End If
            rowsCount += 1
        End While

        LblBalanceField.Text = total
    End Sub

    Private Sub BuildRecQuery()
        Dim data As DatabaseClass = New DatabaseClass
        'set query
        Dim TechSelected As String = LstBoxTech.SelectedItem
        TechSelected = TechSelected.Substring(0, 10)
        Dim bgnDate As String = DTPkrFrom.Value.Date
        Dim endDate As String = DTPkrEnd.Value.Date

        'reset datasource
        Dim tables As String = ConfigurationSettings.AppSettings("RecInv")
        Dim fieldsString As String = "[SERIAL], [ACCESSCARD], [TECHID], [DATEIN], [DATEOUT] "
        Dim condition As String = "[TECHID] = '" & TechSelected & "' AND ([DATEIN] BETWEEN '" & bgnDate & "' AND '" & endDate _
                                    & "' OR [DATEOUT] BETWEEN '" & bgnDate & "' AND '" & endDate & "')"

        Dim fields(,) As String
        data.RunDynamicSelect(tables, fieldsString, condition, fields)
        ReceiverInvDataGridView.DataSource = data.dt
        ReceiverInvDataGridView.Sort(ActivitiesDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub BtnSwchPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TechniciansToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmTech.Click
        Dim ImportItem As ImportClass = New ImportClass
        ImportItem.selectFile(0, "Import Technician")
    End Sub

    Private Sub ActivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmActive.Click
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
        Dim tables As String = ConfigurationSettings.AppSettings("Act")
        Dim fieldsString As String = "[ID],[DATE],[TECHID],[TYPE],[TOTAL],[TECHPAY],[PAID]"
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

End Class
