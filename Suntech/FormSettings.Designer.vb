<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.LblInstruct = New System.Windows.Forms.Label()
        Me.TxtBoxPass = New System.Windows.Forms.TextBox()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.TabCtrlSttng = New System.Windows.Forms.TabControl()
        Me.TabEditPword = New System.Windows.Forms.TabPage()
        Me.TabGeneral = New System.Windows.Forms.TabPage()
        Me.TabCtrlSttng.SuspendLayout()
        Me.TabEditPword.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Location = New System.Drawing.Point(645, 516)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Ok.TabIndex = 2
        Me.Btn_Ok.Text = "&OK"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'LblInstruct
        '
        Me.LblInstruct.AutoSize = True
        Me.LblInstruct.Location = New System.Drawing.Point(110, 182)
        Me.LblInstruct.Name = "LblInstruct"
        Me.LblInstruct.Size = New System.Drawing.Size(106, 13)
        Me.LblInstruct.TabIndex = 4
        Me.LblInstruct.Text = "Enter new password:"
        '
        'TxtBoxPass
        '
        Me.TxtBoxPass.Location = New System.Drawing.Point(192, 272)
        Me.TxtBoxPass.Name = "TxtBoxPass"
        Me.TxtBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBoxPass.Size = New System.Drawing.Size(433, 20)
        Me.TxtBoxPass.TabIndex = 1
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Location = New System.Drawing.Point(726, 516)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancel.TabIndex = 3
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'TabCtrlSttng
        '
        Me.TabCtrlSttng.Controls.Add(Me.TabGeneral)
        Me.TabCtrlSttng.Controls.Add(Me.TabEditPword)
        Me.TabCtrlSttng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCtrlSttng.Location = New System.Drawing.Point(0, 0)
        Me.TabCtrlSttng.Name = "TabCtrlSttng"
        Me.TabCtrlSttng.SelectedIndex = 0
        Me.TabCtrlSttng.Size = New System.Drawing.Size(838, 592)
        Me.TabCtrlSttng.TabIndex = 5
        '
        'TabEditPword
        '
        Me.TabEditPword.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabEditPword.Controls.Add(Me.LblInstruct)
        Me.TabEditPword.Controls.Add(Me.Btn_Cancel)
        Me.TabEditPword.Controls.Add(Me.Btn_Ok)
        Me.TabEditPword.Controls.Add(Me.TxtBoxPass)
        Me.TabEditPword.Location = New System.Drawing.Point(4, 22)
        Me.TabEditPword.Name = "TabEditPword"
        Me.TabEditPword.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEditPword.Size = New System.Drawing.Size(830, 566)
        Me.TabEditPword.TabIndex = 0
        Me.TabEditPword.Text = "Edit Password"
        '
        'TabGeneral
        '
        Me.TabGeneral.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGeneral.Size = New System.Drawing.Size(830, 566)
        Me.TabGeneral.TabIndex = 1
        Me.TabGeneral.Text = "General"
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 592)
        Me.Controls.Add(Me.TabCtrlSttng)
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TabCtrlSttng.ResumeLayout(False)
        Me.TabEditPword.ResumeLayout(False)
        Me.TabEditPword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Ok As System.Windows.Forms.Button
    Friend WithEvents LblInstruct As System.Windows.Forms.Label
    Friend WithEvents TxtBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents TabCtrlSttng As System.Windows.Forms.TabControl
    Friend WithEvents TabEditPword As System.Windows.Forms.TabPage
    Friend WithEvents TabGeneral As System.Windows.Forms.TabPage
End Class
