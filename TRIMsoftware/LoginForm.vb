Imports System.Configuration
Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckSecurity()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        CheckSecurity()
        Me.Close()
    End Sub

    Public Sub CheckSecurity()
        Dim data As DatabaseClass = New DatabaseClass

        'Searches the database for information matching the data entered
        Dim table As String = ConfigurationManager.AppSettings("Login")
        Dim fieldsString As String = "[USERNAME],[PASSWORD]"
        Dim condition As String = " [USERNAME] = '" & UsernameTextBox.Text & "' AND [PASSWORD] = '" & PasswordTextBox.Text & "'"
        Dim fields(,) As String
        data.RunDynamicSelect(table, fieldsString, condition, fields)


        If fields.Length = 0 Then
            'This locks the Activity tabs controls if the credintials are not correct
            For Each ctrl As Control In FormHome.TabAct.Controls
                ctrl.Visible = False
            Next ctrl
            FormHome.PayStubsDataGridView.Visible = False
            FormHome.TSMSettings.Visible = False
            FormHome.Permissions = ""
        Else
            'This unlocks them in case they were previously locked
            For Each ctrl As Control In FormHome.TabAct.Controls
                ctrl.Visible = True
            Next ctrl
            FormHome.PayStubsDataGridView.Visible = True
            FormHome.TSMSettings.Visible = True
            FormHome.Permissions = fields(0, 0)
        End If

    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
