<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStripHome = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItmActive = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlFilter = New System.Windows.Forms.Panel()
        Me.LstBoxTech = New System.Windows.Forms.ListBox()
        Me.PnlDate = New System.Windows.Forms.Panel()
        Me.LblDtFrm = New System.Windows.Forms.Label()
        Me.DTPkrFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTPkrEnd = New System.Windows.Forms.DateTimePicker()
        Me.LblDtEnd = New System.Windows.Forms.Label()
        Me.TxtBoxSearch = New System.Windows.Forms.TextBox()
        Me.GrpSearchStyle = New System.Windows.Forms.GroupBox()
        Me.RBAll = New System.Windows.Forms.RadioButton()
        Me.RBStrucSearch = New System.Windows.Forms.RadioButton()
        Me.RBTextSearch = New System.Windows.Forms.RadioButton()
        Me.BtnGtInfo = New System.Windows.Forms.Button()
        Me.BtnPayTch = New System.Windows.Forms.Button()
        Me.ActivitiesDataGridView = New System.Windows.Forms.DataGridView()
        Me.TechIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TechPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paid = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ActivitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiverInstallationDataSet = New TRIMsoftware.ReceiverInstallationDataSet()
        Me.LblBalanceHdr = New System.Windows.Forms.Label()
        Me.LblBalanceField = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ActivitiesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActivitiesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TabCtrlDGV = New System.Windows.Forms.TabControl()
        Me.TabAct = New System.Windows.Forms.TabPage()
        Me.PnlPay = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxChkNum = New System.Windows.Forms.TextBox()
        Me.TabInv = New System.Windows.Forms.TabPage()
        Me.ReceiverInvDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiverInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabTrans = New System.Windows.Forms.TabPage()
        Me.ReceiverTransferDataGridView = New System.Windows.Forms.DataGridView()
        Me.AccessCard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiverTransferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPayLog = New System.Windows.Forms.TabPage()
        Me.PayStubsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayStubsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ActivitiesTableAdapter = New TRIMsoftware.ReceiverInstallationDataSetTableAdapters.ActivitiesTableAdapter()
        Me.TableAdapterManager = New TRIMsoftware.ReceiverInstallationDataSetTableAdapters.TableAdapterManager()
        Me.PayStubsTableAdapter = New TRIMsoftware.ReceiverInstallationDataSetTableAdapters.PayStubsTableAdapter()
        Me.ReceiverInvTableAdapter = New TRIMsoftware.ReceiverInstallationDataSetTableAdapters.ReceiverInvTableAdapter()
        Me.ReceiverTransferTableAdapter = New TRIMsoftware.ReceiverInstallationDataSetTableAdapters.ReceiverTransferTableAdapter()
        Me.ActivitiesTableAdapter1 = New TRIMsoftware.ReceiverInstallationDataSetTableAdapters.ActivitiesTableAdapter()
        Me.ReceiverInvTableAdapter1 = New TRIMsoftware.ReceiverInstallationDataSetTableAdapters.ReceiverInvTableAdapter()
        Me.ReceiverTransferTableAdapter1 = New TRIMsoftware.ReceiverInstallationDataSetTableAdapters.ReceiverTransferTableAdapter()
        Me.PayStubsTableAdapter1 = New TRIMsoftware.ReceiverInstallationDataSetTableAdapters.PayStubsTableAdapter()
        Me.MenuStripHome.SuspendLayout()
        Me.PnlFilter.SuspendLayout()
        Me.PnlDate.SuspendLayout()
        Me.GrpSearchStyle.SuspendLayout()
        CType(Me.ActivitiesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverInstallationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActivitiesBindingNavigator.SuspendLayout()
        Me.TabCtrlDGV.SuspendLayout()
        Me.TabAct.SuspendLayout()
        Me.PnlPay.SuspendLayout()
        Me.TabInv.SuspendLayout()
        CType(Me.ReceiverInvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTrans.SuspendLayout()
        CType(Me.ReceiverTransferDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverTransferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPayLog.SuspendLayout()
        CType(Me.PayStubsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayStubsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStripHome
        '
        Me.MenuStripHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStripHome.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripHome.Name = "MenuStripHome"
        Me.MenuStripHome.Size = New System.Drawing.Size(1193, 24)
        Me.MenuStripHome.TabIndex = 0
        Me.MenuStripHome.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMLogin, Me.TSMItmActive, Me.ReceiverToolStripMenuItem, Me.PrintToolStripMenuItem, Me.TSMSettings})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TSMLogin
        '
        Me.TSMLogin.Name = "TSMLogin"
        Me.TSMLogin.Size = New System.Drawing.Size(182, 22)
        Me.TSMLogin.Text = "Login"
        '
        'TSMItmActive
        '
        Me.TSMItmActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMItmActive.Name = "TSMItmActive"
        Me.TSMItmActive.Size = New System.Drawing.Size(182, 22)
        Me.TSMItmActive.Text = "Import Activities"
        '
        'ReceiverToolStripMenuItem
        '
        Me.ReceiverToolStripMenuItem.Name = "ReceiverToolStripMenuItem"
        Me.ReceiverToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ReceiverToolStripMenuItem.Text = "Transfer Receivers"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'TSMSettings
        '
        Me.TSMSettings.Name = "TSMSettings"
        Me.TSMSettings.Size = New System.Drawing.Size(182, 22)
        Me.TSMSettings.Text = "Settings"
        '
        'PnlFilter
        '
        Me.PnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlFilter.Controls.Add(Me.LstBoxTech)
        Me.PnlFilter.Controls.Add(Me.PnlDate)
        Me.PnlFilter.Controls.Add(Me.TxtBoxSearch)
        Me.PnlFilter.Controls.Add(Me.GrpSearchStyle)
        Me.PnlFilter.Controls.Add(Me.BtnGtInfo)
        Me.PnlFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlFilter.Location = New System.Drawing.Point(0, 24)
        Me.PnlFilter.Name = "PnlFilter"
        Me.PnlFilter.Size = New System.Drawing.Size(229, 633)
        Me.PnlFilter.TabIndex = 1
        '
        'LstBoxTech
        '
        Me.LstBoxTech.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstBoxTech.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBoxTech.FormattingEnabled = True
        Me.LstBoxTech.Location = New System.Drawing.Point(0, 118)
        Me.LstBoxTech.Name = "LstBoxTech"
        Me.LstBoxTech.ScrollAlwaysVisible = True
        Me.LstBoxTech.Size = New System.Drawing.Size(227, 315)
        Me.LstBoxTech.TabIndex = 0
        '
        'PnlDate
        '
        Me.PnlDate.Controls.Add(Me.LblDtFrm)
        Me.PnlDate.Controls.Add(Me.DTPkrFrom)
        Me.PnlDate.Controls.Add(Me.DTPkrEnd)
        Me.PnlDate.Controls.Add(Me.LblDtEnd)
        Me.PnlDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlDate.Location = New System.Drawing.Point(0, 433)
        Me.PnlDate.Name = "PnlDate"
        Me.PnlDate.Size = New System.Drawing.Size(227, 145)
        Me.PnlDate.TabIndex = 10
        '
        'LblDtFrm
        '
        Me.LblDtFrm.AutoSize = True
        Me.LblDtFrm.Location = New System.Drawing.Point(14, 13)
        Me.LblDtFrm.Name = "LblDtFrm"
        Me.LblDtFrm.Size = New System.Drawing.Size(74, 13)
        Me.LblDtFrm.TabIndex = 5
        Me.LblDtFrm.Text = "Begin Date:"
        '
        'DTPkrFrom
        '
        Me.DTPkrFrom.Location = New System.Drawing.Point(6, 29)
        Me.DTPkrFrom.Name = "DTPkrFrom"
        Me.DTPkrFrom.Size = New System.Drawing.Size(219, 20)
        Me.DTPkrFrom.TabIndex = 0
        '
        'DTPkrEnd
        '
        Me.DTPkrEnd.Location = New System.Drawing.Point(6, 100)
        Me.DTPkrEnd.Name = "DTPkrEnd"
        Me.DTPkrEnd.Size = New System.Drawing.Size(219, 20)
        Me.DTPkrEnd.TabIndex = 4
        '
        'LblDtEnd
        '
        Me.LblDtEnd.AutoSize = True
        Me.LblDtEnd.Location = New System.Drawing.Point(14, 84)
        Me.LblDtEnd.Name = "LblDtEnd"
        Me.LblDtEnd.Size = New System.Drawing.Size(64, 13)
        Me.LblDtEnd.TabIndex = 6
        Me.LblDtEnd.Text = "End Date:"
        '
        'TxtBoxSearch
        '
        Me.TxtBoxSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtBoxSearch.Location = New System.Drawing.Point(0, 98)
        Me.TxtBoxSearch.Name = "TxtBoxSearch"
        Me.TxtBoxSearch.Size = New System.Drawing.Size(227, 20)
        Me.TxtBoxSearch.TabIndex = 8
        '
        'GrpSearchStyle
        '
        Me.GrpSearchStyle.Controls.Add(Me.RBAll)
        Me.GrpSearchStyle.Controls.Add(Me.RBStrucSearch)
        Me.GrpSearchStyle.Controls.Add(Me.RBTextSearch)
        Me.GrpSearchStyle.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpSearchStyle.Location = New System.Drawing.Point(0, 0)
        Me.GrpSearchStyle.Name = "GrpSearchStyle"
        Me.GrpSearchStyle.Size = New System.Drawing.Size(227, 98)
        Me.GrpSearchStyle.TabIndex = 7
        Me.GrpSearchStyle.TabStop = False
        '
        'RBAll
        '
        Me.RBAll.AutoSize = True
        Me.RBAll.Location = New System.Drawing.Point(11, 44)
        Me.RBAll.Name = "RBAll"
        Me.RBAll.Size = New System.Drawing.Size(112, 17)
        Me.RBAll.TabIndex = 2
        Me.RBAll.TabStop = True
        Me.RBAll.Text = "All Technicians"
        Me.RBAll.UseVisualStyleBackColor = True
        '
        'RBStrucSearch
        '
        Me.RBStrucSearch.AutoSize = True
        Me.RBStrucSearch.Location = New System.Drawing.Point(11, 21)
        Me.RBStrucSearch.Name = "RBStrucSearch"
        Me.RBStrucSearch.Size = New System.Drawing.Size(128, 17)
        Me.RBStrucSearch.TabIndex = 1
        Me.RBStrucSearch.TabStop = True
        Me.RBStrucSearch.Text = "Structured Search"
        Me.RBStrucSearch.UseVisualStyleBackColor = True
        '
        'RBTextSearch
        '
        Me.RBTextSearch.AutoSize = True
        Me.RBTextSearch.Location = New System.Drawing.Point(11, 67)
        Me.RBTextSearch.Name = "RBTextSearch"
        Me.RBTextSearch.Size = New System.Drawing.Size(94, 17)
        Me.RBTextSearch.TabIndex = 0
        Me.RBTextSearch.TabStop = True
        Me.RBTextSearch.Text = "Text Search"
        Me.RBTextSearch.UseVisualStyleBackColor = True
        '
        'BtnGtInfo
        '
        Me.BtnGtInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnGtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGtInfo.Location = New System.Drawing.Point(0, 578)
        Me.BtnGtInfo.Name = "BtnGtInfo"
        Me.BtnGtInfo.Size = New System.Drawing.Size(227, 53)
        Me.BtnGtInfo.TabIndex = 3
        Me.BtnGtInfo.Text = "Get Records"
        Me.BtnGtInfo.UseVisualStyleBackColor = True
        '
        'BtnPayTch
        '
        Me.BtnPayTch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayTch.Location = New System.Drawing.Point(270, 33)
        Me.BtnPayTch.Name = "BtnPayTch"
        Me.BtnPayTch.Size = New System.Drawing.Size(122, 25)
        Me.BtnPayTch.TabIndex = 3
        Me.BtnPayTch.Text = "Pay Live Activities"
        Me.BtnPayTch.UseVisualStyleBackColor = True
        '
        'ActivitiesDataGridView
        '
        Me.ActivitiesDataGridView.AllowUserToAddRows = False
        Me.ActivitiesDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ActivitiesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ActivitiesDataGridView.AutoGenerateColumns = False
        Me.ActivitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ActivitiesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TechIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.TechPayDataGridViewTextBoxColumn, Me.Paid})
        Me.ActivitiesDataGridView.DataSource = Me.ActivitiesBindingSource
        Me.ActivitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActivitiesDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ActivitiesDataGridView.Name = "ActivitiesDataGridView"
        Me.ActivitiesDataGridView.ReadOnly = True
        Me.ActivitiesDataGridView.Size = New System.Drawing.Size(950, 527)
        Me.ActivitiesDataGridView.TabIndex = 0
        '
        'TechIDDataGridViewTextBoxColumn
        '
        Me.TechIDDataGridViewTextBoxColumn.DataPropertyName = "TechID"
        Me.TechIDDataGridViewTextBoxColumn.HeaderText = "TechID"
        Me.TechIDDataGridViewTextBoxColumn.Name = "TechIDDataGridViewTextBoxColumn"
        Me.TechIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TechPayDataGridViewTextBoxColumn
        '
        Me.TechPayDataGridViewTextBoxColumn.DataPropertyName = "TechPay"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TechPayDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TechPayDataGridViewTextBoxColumn.HeaderText = "TechPay"
        Me.TechPayDataGridViewTextBoxColumn.Name = "TechPayDataGridViewTextBoxColumn"
        Me.TechPayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Paid
        '
        Me.Paid.DataPropertyName = "Paid"
        Me.Paid.HeaderText = "Paid"
        Me.Paid.Name = "Paid"
        Me.Paid.ReadOnly = True
        '
        'ActivitiesBindingSource
        '
        Me.ActivitiesBindingSource.DataMember = "Activities"
        Me.ActivitiesBindingSource.DataSource = Me.ReceiverInstallationDataSet
        '
        'ReceiverInstallationDataSet
        '
        Me.ReceiverInstallationDataSet.DataSetName = "ReceiverInstallationDataSet"
        Me.ReceiverInstallationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblBalanceHdr
        '
        Me.LblBalanceHdr.AutoSize = True
        Me.LblBalanceHdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalanceHdr.Location = New System.Drawing.Point(7, 5)
        Me.LblBalanceHdr.Name = "LblBalanceHdr"
        Me.LblBalanceHdr.Size = New System.Drawing.Size(90, 13)
        Me.LblBalanceHdr.TabIndex = 5
        Me.LblBalanceHdr.Text = "Tech Balance:"
        '
        'LblBalanceField
        '
        Me.LblBalanceField.AutoSize = True
        Me.LblBalanceField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalanceField.Location = New System.Drawing.Point(103, 5)
        Me.LblBalanceField.Name = "LblBalanceField"
        Me.LblBalanceField.Size = New System.Drawing.Size(32, 13)
        Me.LblBalanceField.TabIndex = 6
        Me.LblBalanceField.Text = "0.00"
        '
        'ActivitiesBindingNavigator
        '
        Me.ActivitiesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ActivitiesBindingNavigator.BindingSource = Me.ActivitiesBindingSource
        Me.ActivitiesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ActivitiesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ActivitiesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ActivitiesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ActivitiesBindingNavigatorSaveItem})
        Me.ActivitiesBindingNavigator.Location = New System.Drawing.Point(229, 671)
        Me.ActivitiesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ActivitiesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ActivitiesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ActivitiesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ActivitiesBindingNavigator.Name = "ActivitiesBindingNavigator"
        Me.ActivitiesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ActivitiesBindingNavigator.Size = New System.Drawing.Size(278, 25)
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
        'TabCtrlDGV
        '
        Me.TabCtrlDGV.Controls.Add(Me.TabAct)
        Me.TabCtrlDGV.Controls.Add(Me.TabInv)
        Me.TabCtrlDGV.Controls.Add(Me.TabTrans)
        Me.TabCtrlDGV.Controls.Add(Me.TabPayLog)
        Me.TabCtrlDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCtrlDGV.Location = New System.Drawing.Point(229, 24)
        Me.TabCtrlDGV.Name = "TabCtrlDGV"
        Me.TabCtrlDGV.SelectedIndex = 0
        Me.TabCtrlDGV.Size = New System.Drawing.Size(964, 633)
        Me.TabCtrlDGV.TabIndex = 8
        '
        'TabAct
        '
        Me.TabAct.Controls.Add(Me.ActivitiesDataGridView)
        Me.TabAct.Controls.Add(Me.PnlPay)
        Me.TabAct.Location = New System.Drawing.Point(4, 22)
        Me.TabAct.Name = "TabAct"
        Me.TabAct.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAct.Size = New System.Drawing.Size(956, 607)
        Me.TabAct.TabIndex = 0
        Me.TabAct.Text = "Technician Activities"
        Me.TabAct.UseVisualStyleBackColor = True
        '
        'PnlPay
        '
        Me.PnlPay.Controls.Add(Me.Label1)
        Me.PnlPay.Controls.Add(Me.txtboxChkNum)
        Me.PnlPay.Controls.Add(Me.BtnPayTch)
        Me.PnlPay.Controls.Add(Me.LblBalanceField)
        Me.PnlPay.Controls.Add(Me.LblBalanceHdr)
        Me.PnlPay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlPay.Location = New System.Drawing.Point(3, 530)
        Me.PnlPay.Name = "PnlPay"
        Me.PnlPay.Size = New System.Drawing.Size(950, 74)
        Me.PnlPay.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Check Number:"
        '
        'txtboxChkNum
        '
        Me.txtboxChkNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxChkNum.Location = New System.Drawing.Point(119, 36)
        Me.txtboxChkNum.Name = "txtboxChkNum"
        Me.txtboxChkNum.Size = New System.Drawing.Size(145, 20)
        Me.txtboxChkNum.TabIndex = 7
        '
        'TabInv
        '
        Me.TabInv.Controls.Add(Me.ReceiverInvDataGridView)
        Me.TabInv.Location = New System.Drawing.Point(4, 22)
        Me.TabInv.Name = "TabInv"
        Me.TabInv.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInv.Size = New System.Drawing.Size(956, 607)
        Me.TabInv.TabIndex = 1
        Me.TabInv.Text = "Reciever Inventory"
        Me.TabInv.UseVisualStyleBackColor = True
        '
        'ReceiverInvDataGridView
        '
        Me.ReceiverInvDataGridView.AllowUserToAddRows = False
        Me.ReceiverInvDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ReceiverInvDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ReceiverInvDataGridView.AutoGenerateColumns = False
        Me.ReceiverInvDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReceiverInvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceiverInvDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ReceiverInvDataGridView.DataSource = Me.ReceiverInvBindingSource
        Me.ReceiverInvDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiverInvDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ReceiverInvDataGridView.Name = "ReceiverInvDataGridView"
        Me.ReceiverInvDataGridView.Size = New System.Drawing.Size(950, 601)
        Me.ReceiverInvDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AccessCard"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AccessCard"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TechID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TechID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DateIn"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DateIn"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateOut"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DateOut"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ReceiverInvBindingSource
        '
        Me.ReceiverInvBindingSource.DataMember = "ReceiverInv"
        Me.ReceiverInvBindingSource.DataSource = Me.ReceiverInstallationDataSet
        '
        'TabTrans
        '
        Me.TabTrans.Controls.Add(Me.ReceiverTransferDataGridView)
        Me.TabTrans.Location = New System.Drawing.Point(4, 22)
        Me.TabTrans.Name = "TabTrans"
        Me.TabTrans.Size = New System.Drawing.Size(956, 607)
        Me.TabTrans.TabIndex = 2
        Me.TabTrans.Text = "Reciever History"
        Me.TabTrans.UseVisualStyleBackColor = True
        '
        'ReceiverTransferDataGridView
        '
        Me.ReceiverTransferDataGridView.AllowUserToAddRows = False
        Me.ReceiverTransferDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ReceiverTransferDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ReceiverTransferDataGridView.AutoGenerateColumns = False
        Me.ReceiverTransferDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReceiverTransferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceiverTransferDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccessCard, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ReceiverTransferDataGridView.DataSource = Me.ReceiverTransferBindingSource
        Me.ReceiverTransferDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiverTransferDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ReceiverTransferDataGridView.Name = "ReceiverTransferDataGridView"
        Me.ReceiverTransferDataGridView.Size = New System.Drawing.Size(956, 607)
        Me.ReceiverTransferDataGridView.TabIndex = 0
        '
        'AccessCard
        '
        Me.AccessCard.DataPropertyName = "AccessCard"
        Me.AccessCard.HeaderText = "AccessCard"
        Me.AccessCard.Name = "AccessCard"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FromTechID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FromTechID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ToTechID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ToTechID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'ReceiverTransferBindingSource
        '
        Me.ReceiverTransferBindingSource.DataMember = "ReceiverTransfer"
        Me.ReceiverTransferBindingSource.DataSource = Me.ReceiverInstallationDataSet
        '
        'TabPayLog
        '
        Me.TabPayLog.Controls.Add(Me.PayStubsDataGridView)
        Me.TabPayLog.Location = New System.Drawing.Point(4, 22)
        Me.TabPayLog.Name = "TabPayLog"
        Me.TabPayLog.Size = New System.Drawing.Size(956, 607)
        Me.TabPayLog.TabIndex = 3
        Me.TabPayLog.Text = "Payment Log"
        Me.TabPayLog.UseVisualStyleBackColor = True
        '
        'PayStubsDataGridView
        '
        Me.PayStubsDataGridView.AllowUserToAddRows = False
        Me.PayStubsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PayStubsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.PayStubsDataGridView.AutoGenerateColumns = False
        Me.PayStubsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PayStubsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayStubsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.PayStubsDataGridView.DataSource = Me.PayStubsBindingSource
        Me.PayStubsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PayStubsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PayStubsDataGridView.Name = "PayStubsDataGridView"
        Me.PayStubsDataGridView.Size = New System.Drawing.Size(956, 607)
        Me.PayStubsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CheckNumber"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CheckNumber"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TechID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TechID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Amount"
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn13.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'PayStubsBindingSource
        '
        Me.PayStubsBindingSource.DataMember = "PayStubs"
        Me.PayStubsBindingSource.DataSource = Me.ReceiverInstallationDataSet
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ActivitiesTableAdapter
        '
        Me.ActivitiesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivitiesTableAdapter = Me.ActivitiesTableAdapter
        Me.TableAdapterManager.AdminTableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PayStubsTableAdapter = Me.PayStubsTableAdapter
        Me.TableAdapterManager.ReceiverInvTableAdapter = Me.ReceiverInvTableAdapter
        Me.TableAdapterManager.ReceiverTransferTableAdapter = Me.ReceiverTransferTableAdapter
        Me.TableAdapterManager.TechniciansTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TRIMsoftware.ReceiverInstallationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PayStubsTableAdapter
        '
        Me.PayStubsTableAdapter.ClearBeforeFill = True
        '
        'ReceiverInvTableAdapter
        '
        Me.ReceiverInvTableAdapter.ClearBeforeFill = True
        '
        'ReceiverTransferTableAdapter
        '
        Me.ReceiverTransferTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesTableAdapter1
        '
        Me.ActivitiesTableAdapter1.ClearBeforeFill = True
        '
        'ReceiverInvTableAdapter1
        '
        Me.ReceiverInvTableAdapter1.ClearBeforeFill = True
        '
        'ReceiverTransferTableAdapter1
        '
        Me.ReceiverTransferTableAdapter1.ClearBeforeFill = True
        '
        'PayStubsTableAdapter1
        '
        Me.PayStubsTableAdapter1.ClearBeforeFill = True
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 657)
        Me.Controls.Add(Me.TabCtrlDGV)
        Me.Controls.Add(Me.ActivitiesBindingNavigator)
        Me.Controls.Add(Me.PnlFilter)
        Me.Controls.Add(Me.MenuStripHome)
        Me.MainMenuStrip = Me.MenuStripHome
        Me.Name = "FormHome"
        Me.Text = "T.R.I.M."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripHome.ResumeLayout(False)
        Me.MenuStripHome.PerformLayout()
        Me.PnlFilter.ResumeLayout(False)
        Me.PnlFilter.PerformLayout()
        Me.PnlDate.ResumeLayout(False)
        Me.PnlDate.PerformLayout()
        Me.GrpSearchStyle.ResumeLayout(False)
        Me.GrpSearchStyle.PerformLayout()
        CType(Me.ActivitiesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverInstallationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActivitiesBindingNavigator.ResumeLayout(False)
        Me.ActivitiesBindingNavigator.PerformLayout()
        Me.TabCtrlDGV.ResumeLayout(False)
        Me.TabAct.ResumeLayout(False)
        Me.PnlPay.ResumeLayout(False)
        Me.PnlPay.PerformLayout()
        Me.TabInv.ResumeLayout(False)
        CType(Me.ReceiverInvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTrans.ResumeLayout(False)
        CType(Me.ReceiverTransferDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverTransferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPayLog.ResumeLayout(False)
        CType(Me.PayStubsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayStubsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripHome As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PnlFilter As System.Windows.Forms.Panel
    Friend WithEvents LstBoxTech As System.Windows.Forms.ListBox
    Friend WithEvents BtnGtInfo As System.Windows.Forms.Button
    Friend WithEvents BtnPayTch As System.Windows.Forms.Button
    Friend WithEvents LblBalanceHdr As System.Windows.Forms.Label
    Friend WithEvents LblBalanceField As System.Windows.Forms.Label
    Friend WithEvents DTPkrFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPkrEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDtFrm As System.Windows.Forms.Label
    Friend WithEvents LblDtEnd As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ActivitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesTableAdapter As ReceiverInstallationDataSetTableAdapters.ActivitiesTableAdapter
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
    Friend WithEvents TableAdapterManager As ReceiverInstallationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabCtrlDGV As System.Windows.Forms.TabControl
    Friend WithEvents TabAct As System.Windows.Forms.TabPage
    Friend WithEvents TabInv As System.Windows.Forms.TabPage
    Friend WithEvents ReceiverTransferTableAdapter As ReceiverInstallationDataSetTableAdapters.ReceiverTransferTableAdapter
    Friend WithEvents ReceiverTransferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiverInvTableAdapter As ReceiverInstallationDataSetTableAdapters.ReceiverInvTableAdapter
    Friend WithEvents ReceiverInvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiverInvDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GrpSearchStyle As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents RBStrucSearch As System.Windows.Forms.RadioButton
    Friend WithEvents RBTextSearch As System.Windows.Forms.RadioButton
    Friend WithEvents TabTrans As System.Windows.Forms.TabPage
    Friend WithEvents TabPayLog As System.Windows.Forms.TabPage
    Friend WithEvents ReceiverTransferDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayStubsTableAdapter As ReceiverInstallationDataSetTableAdapters.PayStubsTableAdapter
    Friend WithEvents PayStubsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PayStubsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtboxChkNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RBAll As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TechIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TechPayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paid As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents AccessCard As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents TSMLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiverInstallationDataSet As TRIMsoftware.ReceiverInstallationDataSet
    Friend WithEvents ActivitiesTableAdapter1 As TRIMsoftware.ReceiverInstallationDataSetTableAdapters.ActivitiesTableAdapter
    Friend WithEvents ReceiverInvTableAdapter1 As TRIMsoftware.ReceiverInstallationDataSetTableAdapters.ReceiverInvTableAdapter
    Friend WithEvents ReceiverTransferTableAdapter1 As TRIMsoftware.ReceiverInstallationDataSetTableAdapters.ReceiverTransferTableAdapter
    Friend WithEvents PayStubsTableAdapter1 As TRIMsoftware.ReceiverInstallationDataSetTableAdapters.PayStubsTableAdapter
    Friend WithEvents PnlDate As System.Windows.Forms.Panel
    Friend WithEvents PnlPay As System.Windows.Forms.Panel
    Friend WithEvents TSMItmActive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
