Public Class AddDupe
    Public Choice As Boolean = False
    Private Sub AddDupe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Choice = False
    End Sub

    Private Sub BtnDupeY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDupeY.Click
        Choice = True
        Me.Hide()
    End Sub

    Private Sub BtnDupeN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDupeN.Click
        Choice = False
        Me.Hide()
    End Sub
End Class