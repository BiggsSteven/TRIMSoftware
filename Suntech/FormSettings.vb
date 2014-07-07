Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmSettings

    Private Sub Btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ok.Click
        Dim data As DatabaseClass = New DatabaseClass

        Dim tables As String = ConfigurationManager.AppSettings("Login")
        Dim editFields() As String = {"[PASSWORD]"}
        Dim values() As String = {TxtBoxPass.Text}
        Dim condition As String = " [USERNAME] = '" & FormHome.Permissions & "'"

        data.RunDynamicUpdate(tables, condition, editFields, values)
        Me.Close()
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub
End Class