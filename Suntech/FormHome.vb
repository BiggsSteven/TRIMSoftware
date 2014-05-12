Public Class FormHome

    Private Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim data As DatabaseClass = New DatabaseClass



    End Sub

    Private Sub BuildQuery()

        Dim Query As String = ""

        Dim TechSelected As String = LstBoxTech.SelectedItem
        Dim bgnDate As Date = DTPkrFrom.Value
        Dim endDate As Date = DTPkrEnd.Value
        Label1.Text = TechSelected





    End Sub

    Private Sub BtnGtInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGtInfo.Click

        BuildQuery()

    End Sub
End Class
