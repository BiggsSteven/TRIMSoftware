<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoading
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
        Me.ProgBarImport = New System.Windows.Forms.ProgressBar
        Me.LblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ProgBarImport
        '
        Me.ProgBarImport.Location = New System.Drawing.Point(12, 190)
        Me.ProgBarImport.Name = "ProgBarImport"
        Me.ProgBarImport.Size = New System.Drawing.Size(260, 23)
        Me.ProgBarImport.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgBarImport.TabIndex = 0
        '
        'LblMessage
        '
        Me.LblMessage.Location = New System.Drawing.Point(13, 13)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(259, 129)
        Me.LblMessage.TabIndex = 1
        Me.LblMessage.Text = "Please wait while the file you selected is imported. This may take a few minutes." & _
            ""
        Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.LblMessage)
        Me.Controls.Add(Me.ProgBarImport)
        Me.Name = "FormLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading in Progress"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgBarImport As System.Windows.Forms.ProgressBar
    Friend WithEvents LblMessage As System.Windows.Forms.Label
End Class
