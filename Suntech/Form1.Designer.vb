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
        Me.MenuStripHome = New System.Windows.Forms.MenuStrip
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
        Me.PnlClndr = New System.Windows.Forms.Panel
        Me.GrpDtaView = New System.Windows.Forms.GroupBox
        Me.LblBalanceHdr = New System.Windows.Forms.Label
        Me.LblBalanceField = New System.Windows.Forms.Label
        Me.MenuStripHome.SuspendLayout()
        Me.PnlFilter.SuspendLayout()
        Me.PnlClndr.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripHome
        '
        Me.MenuStripHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStripHome.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripHome.Name = "MenuStripHome"
        Me.MenuStripHome.Size = New System.Drawing.Size(1179, 24)
        Me.MenuStripHome.TabIndex = 0
        Me.MenuStripHome.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechniciansToolStripMenuItem, Me.ReceiversToolStripMenuItem, Me.AcToolStripMenuItem})
        Me.ImportToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'TechniciansToolStripMenuItem
        '
        Me.TechniciansToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechniciansToolStripMenuItem.Name = "TechniciansToolStripMenuItem"
        Me.TechniciansToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TechniciansToolStripMenuItem.Text = "Technicians"
        '
        'ReceiversToolStripMenuItem
        '
        Me.ReceiversToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiversToolStripMenuItem.Name = "ReceiversToolStripMenuItem"
        Me.ReceiversToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ReceiversToolStripMenuItem.Text = "Receiver Inventory"
        '
        'AcToolStripMenuItem
        '
        Me.AcToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcToolStripMenuItem.Name = "AcToolStripMenuItem"
        Me.AcToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AcToolStripMenuItem.Text = "Activities"
        '
        'PnlFilter
        '
        Me.PnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlFilter.Controls.Add(Me.PnlClndr)
        Me.PnlFilter.Controls.Add(Me.BtnGtInfo)
        Me.PnlFilter.Controls.Add(Me.LstBoxTech)
        Me.PnlFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlFilter.Location = New System.Drawing.Point(0, 24)
        Me.PnlFilter.Name = "PnlFilter"
        Me.PnlFilter.Size = New System.Drawing.Size(229, 757)
        Me.PnlFilter.TabIndex = 1
        '
        'LstBoxTech
        '
        Me.LstBoxTech.Dock = System.Windows.Forms.DockStyle.Top
        Me.LstBoxTech.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBoxTech.FormattingEnabled = True
        Me.LstBoxTech.Location = New System.Drawing.Point(0, 0)
        Me.LstBoxTech.Name = "LstBoxTech"
        Me.LstBoxTech.ScrollAlwaysVisible = True
        Me.LstBoxTech.Size = New System.Drawing.Size(227, 303)
        Me.LstBoxTech.TabIndex = 0
        '
        'ClndrFrom
        '
        Me.ClndrFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClndrFrom.Location = New System.Drawing.Point(0, 9)
        Me.ClndrFrom.Name = "ClndrFrom"
        Me.ClndrFrom.TabIndex = 1
        '
        'ClndrTo
        '
        Me.ClndrTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClndrTo.Location = New System.Drawing.Point(0, 181)
        Me.ClndrTo.Name = "ClndrTo"
        Me.ClndrTo.TabIndex = 2
        '
        'BtnGtInfo
        '
        Me.BtnGtInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnGtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGtInfo.Location = New System.Drawing.Point(0, 702)
        Me.BtnGtInfo.Name = "BtnGtInfo"
        Me.BtnGtInfo.Size = New System.Drawing.Size(227, 53)
        Me.BtnGtInfo.TabIndex = 3
        Me.BtnGtInfo.Text = "Get Technition"
        Me.BtnGtInfo.UseVisualStyleBackColor = True
        '
        'BtnSwchPay
        '
        Me.BtnSwchPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSwchPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSwchPay.Location = New System.Drawing.Point(235, 728)
        Me.BtnSwchPay.Name = "BtnSwchPay"
        Me.BtnSwchPay.Size = New System.Drawing.Size(100, 50)
        Me.BtnSwchPay.TabIndex = 2
        Me.BtnSwchPay.Text = "Payment"
        Me.BtnSwchPay.UseVisualStyleBackColor = True
        '
        'BtnSwchInv
        '
        Me.BtnSwchInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSwchInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSwchInv.Location = New System.Drawing.Point(341, 728)
        Me.BtnSwchInv.Name = "BtnSwchInv"
        Me.BtnSwchInv.Size = New System.Drawing.Size(100, 50)
        Me.BtnSwchInv.TabIndex = 3
        Me.BtnSwchInv.Text = "Inventory"
        Me.BtnSwchInv.UseVisualStyleBackColor = True
        '
        'PnlClndr
        '
        Me.PnlClndr.Controls.Add(Me.ClndrTo)
        Me.PnlClndr.Controls.Add(Me.ClndrFrom)
        Me.PnlClndr.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlClndr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlClndr.Location = New System.Drawing.Point(0, 303)
        Me.PnlClndr.Name = "PnlClndr"
        Me.PnlClndr.Size = New System.Drawing.Size(227, 355)
        Me.PnlClndr.TabIndex = 4
        '
        'GrpDtaView
        '
        Me.GrpDtaView.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpDtaView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDtaView.Location = New System.Drawing.Point(229, 24)
        Me.GrpDtaView.Name = "GrpDtaView"
        Me.GrpDtaView.Size = New System.Drawing.Size(950, 647)
        Me.GrpDtaView.TabIndex = 4
        Me.GrpDtaView.TabStop = False
        Me.GrpDtaView.Text = "Technition Name/ Technition ID (Date Range: MM/DD/YYYY - MM/DD/ YYYY)"
        '
        'LblBalanceHdr
        '
        Me.LblBalanceHdr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBalanceHdr.AutoSize = True
        Me.LblBalanceHdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalanceHdr.Location = New System.Drawing.Point(896, 747)
        Me.LblBalanceHdr.Name = "LblBalanceHdr"
        Me.LblBalanceHdr.Size = New System.Drawing.Size(90, 13)
        Me.LblBalanceHdr.TabIndex = 5
        Me.LblBalanceHdr.Text = "Tech Balance:"
        '
        'LblBalanceField
        '
        Me.LblBalanceField.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBalanceField.AutoSize = True
        Me.LblBalanceField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalanceField.Location = New System.Drawing.Point(992, 747)
        Me.LblBalanceField.Name = "LblBalanceField"
        Me.LblBalanceField.Size = New System.Drawing.Size(175, 13)
        Me.LblBalanceField.TabIndex = 6
        Me.LblBalanceField.Text = "________________________"
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 781)
        Me.Controls.Add(Me.LblBalanceField)
        Me.Controls.Add(Me.LblBalanceHdr)
        Me.Controls.Add(Me.GrpDtaView)
        Me.Controls.Add(Me.BtnSwchInv)
        Me.Controls.Add(Me.BtnSwchPay)
        Me.Controls.Add(Me.PnlFilter)
        Me.Controls.Add(Me.MenuStripHome)
        Me.MainMenuStrip = Me.MenuStripHome
        Me.Name = "FrmHome"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripHome.ResumeLayout(False)
        Me.MenuStripHome.PerformLayout()
        Me.PnlFilter.ResumeLayout(False)
        Me.PnlClndr.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripHome As System.Windows.Forms.MenuStrip
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
    Friend WithEvents PnlClndr As System.Windows.Forms.Panel
    Friend WithEvents GrpDtaView As System.Windows.Forms.GroupBox
    Friend WithEvents LblBalanceHdr As System.Windows.Forms.Label
    Friend WithEvents LblBalanceField As System.Windows.Forms.Label

End Class
