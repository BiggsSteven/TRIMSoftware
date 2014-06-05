<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Ok = New System.Windows.Forms.Button
        Me.LblInstruct = New System.Windows.Forms.Label
        Me.TxtBoxPass = New System.Windows.Forms.TextBox
        Me.Btn_Cancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Location = New System.Drawing.Point(116, 72)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Ok.TabIndex = 2
        Me.Btn_Ok.Text = "&OK"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'LblInstruct
        '
        Me.LblInstruct.AutoSize = True
        Me.LblInstruct.Location = New System.Drawing.Point(12, 9)
        Me.LblInstruct.Name = "LblInstruct"
        Me.LblInstruct.Size = New System.Drawing.Size(106, 13)
        Me.LblInstruct.TabIndex = 4
        Me.LblInstruct.Text = "Enter new password:"
        '
        'TxtBoxPass
        '
        Me.TxtBoxPass.Location = New System.Drawing.Point(12, 37)
        Me.TxtBoxPass.Name = "TxtBoxPass"
        Me.TxtBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBoxPass.Size = New System.Drawing.Size(260, 20)
        Me.TxtBoxPass.TabIndex = 1
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Location = New System.Drawing.Point(197, 72)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancel.TabIndex = 3
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'FrmEditPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 107)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.TxtBoxPass)
        Me.Controls.Add(Me.LblInstruct)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Name = "FrmEditPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Ok As System.Windows.Forms.Button
    Friend WithEvents LblInstruct As System.Windows.Forms.Label
    Friend WithEvents TxtBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
End Class
