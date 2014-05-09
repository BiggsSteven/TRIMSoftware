<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TechniciansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReceiversToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PnlFilter = New System.Windows.Forms.Panel
        Me.LstBoxTech = New System.Windows.Forms.ListBox
        Me.ClndrFrom = New System.Windows.Forms.MonthCalendar
        Me.ClndrTo = New System.Windows.Forms.MonthCalendar
        Me.BtnGtInfo = New System.Windows.Forms.Button
        Me.BtnSwchPay = New System.Windows.Forms.Button
        Me.BtnSwchInv = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.PnlFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1179, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechniciansToolStripMenuItem, Me.ReceiversToolStripMenuItem, Me.AcToolStripMenuItem})
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'TechniciansToolStripMenuItem
        '
        Me.TechniciansToolStripMenuItem.Name = "TechniciansToolStripMenuItem"
        Me.TechniciansToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TechniciansToolStripMenuItem.Text = "Technicians"
        '
        'ReceiversToolStripMenuItem
        '
        Me.ReceiversToolStripMenuItem.Name = "ReceiversToolStripMenuItem"
        Me.ReceiversToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ReceiversToolStripMenuItem.Text = "Receiver Inventory"
        '
        'AcToolStripMenuItem
        '
        Me.AcToolStripMenuItem.Name = "AcToolStripMenuItem"
        Me.AcToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AcToolStripMenuItem.Text = "Activities"
        '
        'PnlFilter
        '
        Me.PnlFilter.Controls.Add(Me.BtnGtInfo)
        Me.PnlFilter.Controls.Add(Me.ClndrTo)
        Me.PnlFilter.Controls.Add(Me.ClndrFrom)
        Me.PnlFilter.Controls.Add(Me.LstBoxTech)
        Me.PnlFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlFilter.Location = New System.Drawing.Point(0, 24)
        Me.PnlFilter.Name = "PnlFilter"
        Me.PnlFilter.Size = New System.Drawing.Size(251, 708)
        Me.PnlFilter.TabIndex = 1
        '
        'LstBoxTech
        '
        Me.LstBoxTech.Dock = System.Windows.Forms.DockStyle.Top
        Me.LstBoxTech.FormattingEnabled = True
        Me.LstBoxTech.Location = New System.Drawing.Point(0, 0)
        Me.LstBoxTech.Name = "LstBoxTech"
        Me.LstBoxTech.ScrollAlwaysVisible = True
        Me.LstBoxTech.Size = New System.Drawing.Size(251, 264)
        Me.LstBoxTech.TabIndex = 0
        '
        'ClndrFrom
        '
        Me.ClndrFrom.Location = New System.Drawing.Point(9, 276)
        Me.ClndrFrom.Name = "ClndrFrom"
        Me.ClndrFrom.TabIndex = 1
        '
        'ClndrTo
        '
        Me.ClndrTo.Location = New System.Drawing.Point(9, 456)
        Me.ClndrTo.Name = "ClndrTo"
        Me.ClndrTo.TabIndex = 2
        '
        'BtnGtInfo
        '
        Me.BtnGtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGtInfo.Location = New System.Drawing.Point(9, 643)
        Me.BtnGtInfo.Name = "BtnGtInfo"
        Me.BtnGtInfo.Size = New System.Drawing.Size(227, 53)
        Me.BtnGtInfo.TabIndex = 3
        Me.BtnGtInfo.Text = "Get Technition"
        Me.BtnGtInfo.UseVisualStyleBackColor = True
        '
        'BtnSwchPay
        '
        Me.BtnSwchPay.Location = New System.Drawing.Point(961, 670)
        Me.BtnSwchPay.Name = "BtnSwchPay"
        Me.BtnSwchPay.Size = New System.Drawing.Size(100, 50)
        Me.BtnSwchPay.TabIndex = 2
        Me.BtnSwchPay.Text = "Button1"
        Me.BtnSwchPay.UseVisualStyleBackColor = True
        '
        'BtnSwchInv
        '
        Me.BtnSwchInv.Location = New System.Drawing.Point(1067, 670)
        Me.BtnSwchInv.Name = "BtnSwchInv"
        Me.BtnSwchInv.Size = New System.Drawing.Size(100, 50)
        Me.BtnSwchInv.TabIndex = 3
        Me.BtnSwchInv.Text = "Button2"
        Me.BtnSwchInv.UseVisualStyleBackColor = True
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 732)
        Me.Controls.Add(Me.BtnSwchInv)
        Me.Controls.Add(Me.BtnSwchPay)
        Me.Controls.Add(Me.PnlFilter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmHome"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PnlFilter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TechniciansToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiversToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PnlFilter As System.Windows.Forms.Panel
    Friend WithEvents ClndrFrom As System.Windows.Forms.MonthCalendar
    Friend WithEvents LstBoxTech As System.Windows.Forms.ListBox
    Friend WithEvents BtnGtInfo As System.Windows.Forms.Button
    Friend WithEvents ClndrTo As System.Windows.Forms.MonthCalendar
    Friend WithEvents BtnSwchPay As System.Windows.Forms.Button
    Friend WithEvents BtnSwchInv As System.Windows.Forms.Button

End Class
