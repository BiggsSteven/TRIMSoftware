Imports System.Configuration
Public Class FormHome



    Private Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Sub to Initialize the Technician list
        BuildTechList()


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
            LstBoxTech.Items.Add(TechArray(counter, 0) & "  \  " & TechArray(counter, 1))
            counter += 1
        End While
    End Sub

    Private Sub BuildQuery()

        Dim TechSelected As String = LstBoxTech.SelectedItem
        Dim bgnDate As Date = DTPkrFrom.Value
        Dim endDate As Date = DTPkrEnd.Value

    End Sub

    Private Sub BtnGtInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGtInfo.Click
        BuildQuery()

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
