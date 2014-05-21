Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormHome



    Private Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Activities' table. You can move, or remove it, as needed.
        
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

        BuildQuery()

        ActivitiesDataGridView.Visible = True
    End Sub

    Private Sub BuildQuery()
        Dim data As DatabaseClass = New DatabaseClass
        'set query
        Dim TechSelected As String = LstBoxTech.SelectedItem
        TechSelected = TechSelected.Substring(0, 10)
        Dim bgnDate As String = DTPkrFrom.Value.Date
        Dim endDate As String = DTPkrEnd.Value.Date

        'reset datasource
        Dim tables As String = ConfigurationSettings.AppSettings("Act")
        Dim fieldsString As String = "[ID],[DATE],[TECHID],[TYPE],[TOTAL],[TECHPAY]"
        Dim condition As String = "[TECHID] = '" & TechSelected & "' AND [DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
        Dim fields(,) As String
        data.RunDynamicSelect(tables, fieldsString, condition, fields)
        ActivitiesDataGridView.DataSource = data.dt
        ActivitiesDataGridView.Sort(ActivitiesDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        'Calculate pay for Tech
        Dim rowsCount As Integer = 0
        Dim total As Double = 0
        While rowsCount < ActivitiesDataGridView.Rows.Count
            total += ActivitiesDataGridView.Rows(rowsCount).Cells(5).Value
            rowsCount += 1
        End While

        LblBalanceField.Text = total
    End Sub


    Private Sub BtnSwchPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSwchData.Click

    End Sub

    Private Sub TechniciansToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmTech.Click
        callImports(0)
    End Sub

    Private Sub ActivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmActive.Click
        callImports(1)
    End Sub

    Private Sub TSMItmRecList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmRecList.Click
        callImports(2)
    End Sub

    Private Sub TSMItmRecRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmRecRet.Click
        callImports(3)
    End Sub

    Private Sub callImports(ByVal TypeSelect As Integer)
        Dim ImportItem As ImportClass = New ImportClass
        ImportItem.selectFile(TypeSelect)

    End Sub
    
End Class
