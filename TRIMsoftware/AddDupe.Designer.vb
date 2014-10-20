<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDupe
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
        Me.lblDupe = New System.Windows.Forms.Label
        Me.BtnDupeY = New System.Windows.Forms.Button
        Me.BtnDupeN = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblDupe
        '
        Me.lblDupe.Location = New System.Drawing.Point(12, 9)
        Me.lblDupe.Name = "lblDupe"
        Me.lblDupe.Size = New System.Drawing.Size(300, 69)
        Me.lblDupe.TabIndex = 0
        Me.lblDupe.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The file you are tring to add is already present in your records." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          " & _
            "Would you like to replace it now? "
        '
        'BtnDupeY
        '
        Me.BtnDupeY.Location = New System.Drawing.Point(156, 77)
        Me.BtnDupeY.Name = "BtnDupeY"
        Me.BtnDupeY.Size = New System.Drawing.Size(75, 23)
        Me.BtnDupeY.TabIndex = 1
        Me.BtnDupeY.Text = "Continue"
        Me.BtnDupeY.UseVisualStyleBackColor = True
        '
        'BtnDupeN
        '
        Me.BtnDupeN.Location = New System.Drawing.Point(237, 77)
        Me.BtnDupeN.Name = "BtnDupeN"
        Me.BtnDupeN.Size = New System.Drawing.Size(75, 23)
        Me.BtnDupeN.TabIndex = 2
        Me.BtnDupeN.Text = "Cancel"
        Me.BtnDupeN.UseVisualStyleBackColor = True
        '
        'AddDupe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 112)
        Me.Controls.Add(Me.BtnDupeN)
        Me.Controls.Add(Me.BtnDupeY)
        Me.Controls.Add(Me.lblDupe)
        Me.Name = "AddDupe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicate Records Found"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDupe As System.Windows.Forms.Label
    Friend WithEvents BtnDupeY As System.Windows.Forms.Button
    Friend WithEvents BtnDupeN As System.Windows.Forms.Button
End Class
