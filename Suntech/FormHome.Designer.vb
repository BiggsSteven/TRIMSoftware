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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
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
        Me.ActivitiesDataGridView = New System.Windows.Forms.DataGridView
        Me.ActivitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Suntech.DataSet1
        Me.LblBalanceHdr = New System.Windows.Forms.Label
        Me.LblBalanceField = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ActivitiesTableAdapter = New Suntech.DataSet1TableAdapters.ActivitiesTableAdapter
        Me.TableAdapterManager = New Suntech.DataSet1TableAdapters.TableAdapterManager
        Me.ActivitiesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ActivitiesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStripHome.SuspendLayout()
        Me.PnlFilter.SuspendLayout()
        Me.GrpDtaView.SuspendLayout()
        CType(Me.ActivitiesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActivitiesBindingNavigator.SuspendLayout()
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
        Me.TSMItmImport.Size = New System.Drawing.Size(152, 22)
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
        Me.GrpDtaView.Controls.Add(Me.ActivitiesDataGridView)
        Me.GrpDtaView.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpDtaView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDtaView.Location = New System.Drawing.Point(229, 24)
        Me.GrpDtaView.Name = "GrpDtaView"
        Me.GrpDtaView.Size = New System.Drawing.Size(950, 647)
        Me.GrpDtaView.TabIndex = 4
        Me.GrpDtaView.TabStop = False
        Me.GrpDtaView.Text = "Technician ID / Technician Name (Date Range: MM/DD/YYYY - MM/DD/ YYYY)"
        '
        'ActivitiesDataGridView
        '
        Me.ActivitiesDataGridView.AllowUserToAddRows = False
        Me.ActivitiesDataGridView.AllowUserToDeleteRows = False
        Me.ActivitiesDataGridView.AutoGenerateColumns = False
        Me.ActivitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ActivitiesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.ActivitiesDataGridView.DataSource = Me.ActivitiesBindingSource
        Me.ActivitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.ActivitiesDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.ActivitiesDataGridView.Name = "ActivitiesDataGridView"
        Me.ActivitiesDataGridView.ReadOnly = True
        Me.ActivitiesDataGridView.Size = New System.Drawing.Size(944, 537)
        Me.ActivitiesDataGridView.TabIndex = 0
        '
        'ActivitiesBindingSource
        '
        Me.ActivitiesBindingSource.DataMember = "Activities"
        Me.ActivitiesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ActivitiesTableAdapter
        '
        Me.ActivitiesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivitiesTableAdapter = Me.ActivitiesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PaidActivitiesTableAdapter = Nothing
        Me.TableAdapterManager.ReceiverTransferTableAdapter = Nothing
        Me.TableAdapterManager.RecInvTableAdapter = Nothing
        Me.TableAdapterManager.TechniciansTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Suntech.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActivitiesBindingNavigator
        '
        Me.ActivitiesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ActivitiesBindingNavigator.BindingSource = Me.ActivitiesBindingSource
        Me.ActivitiesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ActivitiesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ActivitiesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ActivitiesBindingNavigatorSaveItem})
        Me.ActivitiesBindingNavigator.Location = New System.Drawing.Point(229, 671)
        Me.ActivitiesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ActivitiesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ActivitiesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ActivitiesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ActivitiesBindingNavigator.Name = "ActivitiesBindingNavigator"
        Me.ActivitiesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ActivitiesBindingNavigator.Size = New System.Drawing.Size(950, 25)
        Me.ActivitiesBindingNavigator.TabIndex = 7
        Me.ActivitiesBindingNavigator.Text = "BindingNavigator1"
        Me.ActivitiesBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ActivitiesBindingNavigatorSaveItem
        '
        Me.ActivitiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActivitiesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActivitiesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActivitiesBindingNavigatorSaveItem.Name = "ActivitiesBindingNavigatorSaveItem"
        Me.ActivitiesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ActivitiesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(229, 671)
        Me.ProgressBar1.MarqueeAnimationSpeed = 20
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar1.Size = New System.Drawing.Size(950, 23)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Value = 10
        Me.ProgressBar1.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TechID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TechID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 781)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ActivitiesBindingNavigator)
        Me.Controls.Add(Me.LblBalanceField)
        Me.Controls.Add(Me.LblBalanceHdr)
        Me.Controls.Add(Me.GrpDtaView)
        Me.Controls.Add(Me.BtnPayTch)
        Me.Controls.Add(Me.BtnSwchData)
        Me.Controls.Add(Me.PnlFilter)
        Me.Controls.Add(Me.MenuStripHome)
        Me.MainMenuStrip = Me.MenuStripHome
        Me.Name = "FormHome"
        Me.Text = "SunTech Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripHome.ResumeLayout(False)
        Me.MenuStripHome.PerformLayout()
        Me.PnlFilter.ResumeLayout(False)
        Me.PnlFilter.PerformLayout()
        Me.GrpDtaView.ResumeLayout(False)
        CType(Me.ActivitiesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActivitiesBindingNavigator.ResumeLayout(False)
        Me.ActivitiesBindingNavigator.PerformLayout()
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
    Friend WithEvents DataSet1 As Suntech.DataSet1
    Friend WithEvents ActivitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesTableAdapter As Suntech.DataSet1TableAdapters.ActivitiesTableAdapter
    Friend WithEvents ActivitiesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ActivitiesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActivitiesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableAdapterManager As Suntech.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
