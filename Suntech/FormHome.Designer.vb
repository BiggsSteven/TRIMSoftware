﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Me.TSMItmImport = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMItmTech = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMItmActive = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMItmRecList = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMItmRecRet = New System.Windows.Forms.ToolStripMenuItem
        Me.PnlFilter = New System.Windows.Forms.Panel
        Me.LblDtEnd = New System.Windows.Forms.Label
        Me.LblDtFrm = New System.Windows.Forms.Label
        Me.DTPkrEnd = New System.Windows.Forms.DateTimePicker
        Me.DTPkrFrom = New System.Windows.Forms.DateTimePicker
        Me.BtnGtInfo = New System.Windows.Forms.Button
        Me.LstBoxTech = New System.Windows.Forms.ListBox
        Me.BtnSwchData = New System.Windows.Forms.Button
        Me.BtnPayTch = New System.Windows.Forms.Button
        Me.GrpDtaView = New System.Windows.Forms.GroupBox
        Me.LblBalanceHdr = New System.Windows.Forms.Label
        Me.LblBalanceField = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MenuStripHome.SuspendLayout()
        Me.PnlFilter.SuspendLayout()
        Me.GrpDtaView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMItmImport})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TSMItmImport
        '
        Me.TSMItmImport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMItmTech, Me.TSMItmActive, Me.TSMItmRecList, Me.TSMItmRecRet})
        Me.TSMItmImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMItmImport.Name = "TSMItmImport"
        Me.TSMItmImport.Size = New System.Drawing.Size(109, 22)
        Me.TSMItmImport.Text = "Import"
        '
        'TSMItmTech
        '
        Me.TSMItmTech.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMItmTech.Name = "TSMItmTech"
        Me.TSMItmTech.Size = New System.Drawing.Size(173, 22)
        Me.TSMItmTech.Text = "Technicians"
        '
        'TSMItmActive
        '
        Me.TSMItmActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMItmActive.Name = "TSMItmActive"
        Me.TSMItmActive.Size = New System.Drawing.Size(173, 22)
        Me.TSMItmActive.Text = "Activities"
        '
        'TSMItmRecList
        '
        Me.TSMItmRecList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMItmRecList.Name = "TSMItmRecList"
        Me.TSMItmRecList.Size = New System.Drawing.Size(173, 22)
        Me.TSMItmRecList.Text = "Receiver List"
        '
        'TSMItmRecRet
        '
        Me.TSMItmRecRet.Name = "TSMItmRecRet"
        Me.TSMItmRecRet.Size = New System.Drawing.Size(173, 22)
        Me.TSMItmRecRet.Text = "Receiver Returns"
        '
        'PnlFilter
        '
        Me.PnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlFilter.Controls.Add(Me.LblDtEnd)
        Me.PnlFilter.Controls.Add(Me.LblDtFrm)
        Me.PnlFilter.Controls.Add(Me.DTPkrEnd)
        Me.PnlFilter.Controls.Add(Me.DTPkrFrom)
        Me.PnlFilter.Controls.Add(Me.BtnGtInfo)
        Me.PnlFilter.Controls.Add(Me.LstBoxTech)
        Me.PnlFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlFilter.Location = New System.Drawing.Point(0, 24)
        Me.PnlFilter.Name = "PnlFilter"
        Me.PnlFilter.Size = New System.Drawing.Size(229, 757)
        Me.PnlFilter.TabIndex = 1
        '
        'LblDtEnd
        '
        Me.LblDtEnd.AutoSize = True
        Me.LblDtEnd.Location = New System.Drawing.Point(11, 610)
        Me.LblDtEnd.Name = "LblDtEnd"
        Me.LblDtEnd.Size = New System.Drawing.Size(64, 13)
        Me.LblDtEnd.TabIndex = 6
        Me.LblDtEnd.Text = "End Date:"
        '
        'LblDtFrm
        '
        Me.LblDtFrm.AutoSize = True
        Me.LblDtFrm.Location = New System.Drawing.Point(11, 539)
        Me.LblDtFrm.Name = "LblDtFrm"
        Me.LblDtFrm.Size = New System.Drawing.Size(74, 13)
        Me.LblDtFrm.TabIndex = 5
        Me.LblDtFrm.Text = "Begin Date:"
        '
        'DTPkrEnd
        '
        Me.DTPkrEnd.Location = New System.Drawing.Point(3, 626)
        Me.DTPkrEnd.Name = "DTPkrEnd"
        Me.DTPkrEnd.Size = New System.Drawing.Size(219, 20)
        Me.DTPkrEnd.TabIndex = 4
        '
        'DTPkrFrom
        '
        Me.DTPkrFrom.Location = New System.Drawing.Point(3, 555)
        Me.DTPkrFrom.Name = "DTPkrFrom"
        Me.DTPkrFrom.Size = New System.Drawing.Size(219, 20)
        Me.DTPkrFrom.TabIndex = 0
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
        'LstBoxTech
        '
        Me.LstBoxTech.Dock = System.Windows.Forms.DockStyle.Top
        Me.LstBoxTech.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBoxTech.FormattingEnabled = True
        Me.LstBoxTech.Location = New System.Drawing.Point(0, 0)
        Me.LstBoxTech.Name = "LstBoxTech"
        Me.LstBoxTech.ScrollAlwaysVisible = True
        Me.LstBoxTech.Size = New System.Drawing.Size(227, 524)
        Me.LstBoxTech.TabIndex = 0
        '
        'BtnSwchData
        '
        Me.BtnSwchData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSwchData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSwchData.Location = New System.Drawing.Point(235, 728)
        Me.BtnSwchData.Name = "BtnSwchData"
        Me.BtnSwchData.Size = New System.Drawing.Size(100, 50)
        Me.BtnSwchData.TabIndex = 2
        Me.BtnSwchData.Text = "Inventory"
        Me.BtnSwchData.UseVisualStyleBackColor = True
        '
        'BtnPayTch
        '
        Me.BtnPayTch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPayTch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayTch.Location = New System.Drawing.Point(790, 728)
        Me.BtnPayTch.Name = "BtnPayTch"
        Me.BtnPayTch.Size = New System.Drawing.Size(100, 50)
        Me.BtnPayTch.TabIndex = 3
        Me.BtnPayTch.Text = "Pay Live Activities"
        Me.BtnPayTch.UseVisualStyleBackColor = True
        '
        'GrpDtaView
        '
        Me.GrpDtaView.Controls.Add(Me.DataGridView1)
        Me.GrpDtaView.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpDtaView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDtaView.Location = New System.Drawing.Point(229, 24)
        Me.GrpDtaView.Name = "GrpDtaView"
        Me.GrpDtaView.Size = New System.Drawing.Size(950, 647)
        Me.GrpDtaView.TabIndex = 4
        Me.GrpDtaView.TabStop = False
        Me.GrpDtaView.Text = "Technician ID / Technician Name (Date Range: MM/DD/YYYY - MM/DD/ YYYY)"
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(944, 628)
        Me.DataGridView1.TabIndex = 0
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 781)
        Me.Controls.Add(Me.LblBalanceField)
        Me.Controls.Add(Me.LblBalanceHdr)
        Me.Controls.Add(Me.GrpDtaView)
        Me.Controls.Add(Me.BtnPayTch)
        Me.Controls.Add(Me.BtnSwchData)
        Me.Controls.Add(Me.PnlFilter)
        Me.Controls.Add(Me.MenuStripHome)
        Me.MainMenuStrip = Me.MenuStripHome
        Me.Name = "FormHome"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripHome.ResumeLayout(False)
        Me.MenuStripHome.PerformLayout()
        Me.PnlFilter.ResumeLayout(False)
        Me.PnlFilter.PerformLayout()
        Me.GrpDtaView.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripHome As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMItmImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMItmTech As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMItmActive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMItmRecList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PnlFilter As System.Windows.Forms.Panel
    Friend WithEvents LstBoxTech As System.Windows.Forms.ListBox
    Friend WithEvents BtnGtInfo As System.Windows.Forms.Button
    Friend WithEvents BtnSwchData As System.Windows.Forms.Button
    Friend WithEvents BtnPayTch As System.Windows.Forms.Button
    Friend WithEvents GrpDtaView As System.Windows.Forms.GroupBox
    Friend WithEvents LblBalanceHdr As System.Windows.Forms.Label
    Friend WithEvents LblBalanceField As System.Windows.Forms.Label
    Friend WithEvents DTPkrFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPkrEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDtFrm As System.Windows.Forms.Label
    Friend WithEvents LblDtEnd As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TSMItmRecRet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
