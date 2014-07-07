Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmSettings

    '
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmboBoxTechs.Enabled = False
        RBAddTech.Checked = True

    End Sub

    'Add/Edit Tech Section
    Private Sub RBAddTech_CheckedChanged(sender As Object, e As EventArgs) Handles RBAddTech.CheckedChanged
        CmboBoxTechs.Enabled = False
    End Sub

    Private Sub RBEditTech_CheckedChanged(sender As Object, e As EventArgs) Handles RBEditTech.CheckedChanged
        CmboBoxTechs.Enabled = True
    End Sub

    Private Sub BtnEditTechSave_Click(sender As Object, e As EventArgs) Handles BtnEditTechSave.Click

    End Sub

    Private Sub BtnEditTechCncl_Click(sender As Object, e As EventArgs) Handles BtnEditTechCncl.Click

    End Sub

    'Password Edit Section
    Private Sub changePass()
        Dim data As DatabaseClass = New DatabaseClass
        Dim tables As String = ConfigurationManager.AppSettings("Login")
        Dim editFields() As String = {"[PASSWORD]"}
        Dim values() As String = {TxtBoxPass.Text}
        Dim condition As String = " [USERNAME] = '" & FormHome.Permissions & "'"

        data.RunDynamicUpdate(tables, condition, editFields, values)
        Me.Close()
    End Sub

    Private Sub BtnEditPassOK_Click(sender As Object, e As EventArgs) Handles BtnEditPassOK.Click


        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Login")
        Dim fieldsString As String = "[USERNAME],[PASSWORD]"
        Dim condition As String = " [USERNAME] = '" & FormHome.Permissions & "' AND [PASSWORD] = '" & TxtBoxCurrentPass.Text & "'"
        Dim fields(,) As String

        data.RunDynamicSelect(table, fieldsString, condition, fields)

        'Check Security
        If fields.Length <> 0 Then
            'Check new password is same
            If TxtBoxPass.Text = TxtBoxConfirmPass.Text Then
                MessageBox.Show("Your password has been successfully changed.")
                changePass()
                TxtBoxCurrentPass.Text = String.Empty
            Else
                MessageBox.Show("The two new passwords do not match please re-enter each.")
            End If
            TxtBoxPass.Text = String.Empty
            TxtBoxConfirmPass.Text = String.Empty
        Else
            MessageBox.Show("The current password entered was not recognized.")
        End If
    End Sub

    Private Sub BtnEditPassCncl_Click(sender As Object, e As EventArgs) Handles BtnEditPassCncl.Click
        Me.Close()
    End Sub
End Class