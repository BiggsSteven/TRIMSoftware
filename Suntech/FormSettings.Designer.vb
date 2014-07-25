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
        Me.components = New System.ComponentModel.Container()
        Dim LblEmailAddress As System.Windows.Forms.Label
        Dim LblPhoneNum As System.Windows.Forms.Label
        Dim LblFedIDNum As System.Windows.Forms.Label
        Dim LblSSN As System.Windows.Forms.Label
        Dim LblPayPercentage As System.Windows.Forms.Label
        Dim LblLastName As System.Windows.Forms.Label
        Dim LblMiddleInitial As System.Windows.Forms.Label
        Dim LblFirstName As System.Windows.Forms.Label
        Dim LblHomeAddress As System.Windows.Forms.Label
        Dim LblLocation As System.Windows.Forms.Label
        Dim LblID As System.Windows.Forms.Label
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.LblNewPass = New System.Windows.Forms.Label()
        Me.TxtBoxPass = New System.Windows.Forms.TextBox()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.TabCtrlSttng = New System.Windows.Forms.TabControl()
        Me.TabGeneral = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblComp = New System.Windows.Forms.Label()
        Me.LblDistro = New System.Windows.Forms.Label()
        Me.TxtboxComp = New System.Windows.Forms.TextBox()
        Me.TxtboxDistro = New System.Windows.Forms.TextBox()
        Me.BtnGenSave = New System.Windows.Forms.Button()
        Me.BtnGenCncl = New System.Windows.Forms.Button()
        Me.GrpBoxPay = New System.Windows.Forms.GroupBox()
        Me.ChkboxSvcPay = New System.Windows.Forms.CheckBox()
        Me.LblSvcPay = New System.Windows.Forms.Label()
        Me.TxtBoxSvcPay = New System.Windows.Forms.TextBox()
        Me.TabEditTech = New System.Windows.Forms.TabPage()
        Me.PnlEditTech = New System.Windows.Forms.Panel()
        Me.RBAddTech = New System.Windows.Forms.RadioButton()
        Me.BtnEditTechCncl = New System.Windows.Forms.Button()
        Me.TxtboxEmail = New System.Windows.Forms.TextBox()
        Me.TechniciansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiverInstallationDataSet = New Suntech.ReceiverInstallationDataSet()
        Me.BtnEditTechSave = New System.Windows.Forms.Button()
        Me.CmboBoxTechs = New System.Windows.Forms.ComboBox()
        Me.TxtboxPhone = New System.Windows.Forms.TextBox()
        Me.RBEditTech = New System.Windows.Forms.RadioButton()
        Me.TxtBoxFedID = New System.Windows.Forms.TextBox()
        Me.TxtboxID = New System.Windows.Forms.TextBox()
        Me.TxtBoxSSN = New System.Windows.Forms.TextBox()
        Me.TxtboxLoc = New System.Windows.Forms.TextBox()
        Me.TxtboxPayPerc = New System.Windows.Forms.TextBox()
        Me.TxtboxAddr = New System.Windows.Forms.TextBox()
        Me.TxtBoxLast = New System.Windows.Forms.TextBox()
        Me.txtBoxFirst = New System.Windows.Forms.TextBox()
        Me.TxtBoxMI = New System.Windows.Forms.TextBox()
        Me.TabEditPword = New System.Windows.Forms.TabPage()
        Me.GrpBoxPass = New System.Windows.Forms.GroupBox()
        Me.LblOldPass = New System.Windows.Forms.Label()
        Me.LblConfirmPass = New System.Windows.Forms.Label()
        Me.TxtBoxConfirmPass = New System.Windows.Forms.TextBox()
        Me.TxtBoxCurrentPass = New System.Windows.Forms.TextBox()
        Me.BtnEditPassCncl = New System.Windows.Forms.Button()
        Me.BtnEditPassOK = New System.Windows.Forms.Button()
        Me.TechniciansTableAdapter = New Suntech.ReceiverInstallationDataSetTableAdapters.TechniciansTableAdapter()
        Me.TableAdapterManager = New Suntech.ReceiverInstallationDataSetTableAdapters.TableAdapterManager()
        LblEmailAddress = New System.Windows.Forms.Label()
        LblPhoneNum = New System.Windows.Forms.Label()
        LblFedIDNum = New System.Windows.Forms.Label()
        LblSSN = New System.Windows.Forms.Label()
        LblPayPercentage = New System.Windows.Forms.Label()
        LblLastName = New System.Windows.Forms.Label()
        LblMiddleInitial = New System.Windows.Forms.Label()
        LblFirstName = New System.Windows.Forms.Label()
        LblHomeAddress = New System.Windows.Forms.Label()
        LblLocation = New System.Windows.Forms.Label()
        LblID = New System.Windows.Forms.Label()
        Me.TabCtrlSttng.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxPay.SuspendLayout()
        Me.TabEditTech.SuspendLayout()
        Me.PnlEditTech.SuspendLayout()
        CType(Me.TechniciansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverInstallationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEditPword.SuspendLayout()
        Me.GrpBoxPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblEmailAddress
        '
        LblEmailAddress.AutoSize = True
        LblEmailAddress.Location = New System.Drawing.Point(5, 339)
        LblEmailAddress.Name = "LblEmailAddress"
        LblEmailAddress.Size = New System.Drawing.Size(76, 13)
        LblEmailAddress.TabIndex = 22
        LblEmailAddress.Text = "Email Address:"
        '
        'LblPhoneNum
        '
        LblPhoneNum.AutoSize = True
        LblPhoneNum.Location = New System.Drawing.Point(5, 313)
        LblPhoneNum.Name = "LblPhoneNum"
        LblPhoneNum.Size = New System.Drawing.Size(81, 13)
        LblPhoneNum.TabIndex = 20
        LblPhoneNum.Text = "Phone Number:"
        '
        'LblFedIDNum
        '
        LblFedIDNum.AutoSize = True
        LblFedIDNum.Location = New System.Drawing.Point(5, 226)
        LblFedIDNum.Name = "LblFedIDNum"
        LblFedIDNum.Size = New System.Drawing.Size(82, 13)
        LblFedIDNum.TabIndex = 18
        LblFedIDNum.Text = "Fed ID Number:"
        '
        'LblSSN
        '
        LblSSN.AutoSize = True
        LblSSN.Location = New System.Drawing.Point(5, 200)
        LblSSN.Name = "LblSSN"
        LblSSN.Size = New System.Drawing.Size(32, 13)
        LblSSN.TabIndex = 16
        LblSSN.Text = "SSN:"
        '
        'LblPayPercentage
        '
        LblPayPercentage.AutoSize = True
        LblPayPercentage.Location = New System.Drawing.Point(5, 421)
        LblPayPercentage.Name = "LblPayPercentage"
        LblPayPercentage.Size = New System.Drawing.Size(86, 13)
        LblPayPercentage.TabIndex = 14
        LblPayPercentage.Text = "Pay Percentage:"
        '
        'LblLastName
        '
        LblLastName.AutoSize = True
        LblLastName.Location = New System.Drawing.Point(473, 160)
        LblLastName.Name = "LblLastName"
        LblLastName.Size = New System.Drawing.Size(61, 13)
        LblLastName.TabIndex = 12
        LblLastName.Text = "Last Name:"
        '
        'LblMiddleInitial
        '
        LblMiddleInitial.AutoSize = True
        LblMiddleInitial.Location = New System.Drawing.Point(324, 160)
        LblMiddleInitial.Name = "LblMiddleInitial"
        LblMiddleInitial.Size = New System.Drawing.Size(68, 13)
        LblMiddleInitial.TabIndex = 10
        LblMiddleInitial.Text = "Middle Initial:"
        '
        'LblFirstName
        '
        LblFirstName.AutoSize = True
        LblFirstName.Location = New System.Drawing.Point(5, 160)
        LblFirstName.Name = "LblFirstName"
        LblFirstName.Size = New System.Drawing.Size(60, 13)
        LblFirstName.TabIndex = 8
        LblFirstName.Text = "First Name:"
        '
        'LblHomeAddress
        '
        LblHomeAddress.AutoSize = True
        LblHomeAddress.Location = New System.Drawing.Point(5, 287)
        LblHomeAddress.Name = "LblHomeAddress"
        LblHomeAddress.Size = New System.Drawing.Size(79, 13)
        LblHomeAddress.TabIndex = 6
        LblHomeAddress.Text = "Home Address:"
        '
        'LblLocation
        '
        LblLocation.AutoSize = True
        LblLocation.Location = New System.Drawing.Point(3, 395)
        LblLocation.Name = "LblLocation"
        LblLocation.Size = New System.Drawing.Size(64, 13)
        LblLocation.TabIndex = 4
        LblLocation.Text = "Subdivision:"
        '
        'LblID
        '
        LblID.AutoSize = True
        LblID.Location = New System.Drawing.Point(5, 127)
        LblID.Name = "LblID"
        LblID.Size = New System.Drawing.Size(77, 13)
        LblID.TabIndex = 0
        LblID.Text = "Technician ID:"
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
        'LblNewPass
        '
        Me.LblNewPass.AutoSize = True
        Me.LblNewPass.Location = New System.Drawing.Point(34, 88)
        Me.LblNewPass.Name = "LblNewPass"
        Me.LblNewPass.Size = New System.Drawing.Size(106, 13)
        Me.LblNewPass.TabIndex = 4
        Me.LblNewPass.Text = "Enter new password:"
        '
        'TxtBoxPass
        '
        Me.TxtBoxPass.Location = New System.Drawing.Point(165, 85)
        Me.TxtBoxPass.Name = "TxtBoxPass"
        Me.TxtBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBoxPass.Size = New System.Drawing.Size(234, 20)
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
        Me.TabCtrlSttng.Controls.Add(Me.TabEditTech)
        Me.TabCtrlSttng.Controls.Add(Me.TabEditPword)
        Me.TabCtrlSttng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCtrlSttng.Location = New System.Drawing.Point(0, 0)
        Me.TabCtrlSttng.Name = "TabCtrlSttng"
        Me.TabCtrlSttng.SelectedIndex = 0
        Me.TabCtrlSttng.Size = New System.Drawing.Size(766, 530)
        Me.TabCtrlSttng.TabIndex = 5
        '
        'TabGeneral
        '
        Me.TabGeneral.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabGeneral.Controls.Add(Me.GroupBox1)
        Me.TabGeneral.Controls.Add(Me.BtnGenSave)
        Me.TabGeneral.Controls.Add(Me.BtnGenCncl)
        Me.TabGeneral.Controls.Add(Me.GrpBoxPay)
        Me.TabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Size = New System.Drawing.Size(758, 504)
        Me.TabGeneral.TabIndex = 2
        Me.TabGeneral.Text = "General"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblComp)
        Me.GroupBox1.Controls.Add(Me.LblDistro)
        Me.GroupBox1.Controls.Add(Me.TxtboxComp)
        Me.GroupBox1.Controls.Add(Me.TxtboxDistro)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 174)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Titles"
        '
        'LblComp
        '
        Me.LblComp.AutoSize = True
        Me.LblComp.Location = New System.Drawing.Point(26, 99)
        Me.LblComp.Name = "LblComp"
        Me.LblComp.Size = New System.Drawing.Size(118, 13)
        Me.LblComp.TabIndex = 3
        Me.LblComp.Text = "Enter Company's name:"
        '
        'LblDistro
        '
        Me.LblDistro.AutoSize = True
        Me.LblDistro.Location = New System.Drawing.Point(26, 42)
        Me.LblDistro.Name = "LblDistro"
        Me.LblDistro.Size = New System.Drawing.Size(123, 13)
        Me.LblDistro.TabIndex = 2
        Me.LblDistro.Text = "Enter Distributor's Name:"
        '
        'TxtboxComp
        '
        Me.TxtboxComp.Location = New System.Drawing.Point(295, 96)
        Me.TxtboxComp.Name = "TxtboxComp"
        Me.TxtboxComp.Size = New System.Drawing.Size(266, 20)
        Me.TxtboxComp.TabIndex = 1
        '
        'TxtboxDistro
        '
        Me.TxtboxDistro.Location = New System.Drawing.Point(295, 39)
        Me.TxtboxDistro.Name = "TxtboxDistro"
        Me.TxtboxDistro.Size = New System.Drawing.Size(266, 20)
        Me.TxtboxDistro.TabIndex = 0
        '
        'BtnGenSave
        '
        Me.BtnGenSave.Location = New System.Drawing.Point(594, 473)
        Me.BtnGenSave.Name = "BtnGenSave"
        Me.BtnGenSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenSave.TabIndex = 7
        Me.BtnGenSave.Text = "Save"
        Me.BtnGenSave.UseVisualStyleBackColor = True
        '
        'BtnGenCncl
        '
        Me.BtnGenCncl.Location = New System.Drawing.Point(675, 473)
        Me.BtnGenCncl.Name = "BtnGenCncl"
        Me.BtnGenCncl.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenCncl.TabIndex = 8
        Me.BtnGenCncl.Text = "Close"
        Me.BtnGenCncl.UseVisualStyleBackColor = True
        '
        'GrpBoxPay
        '
        Me.GrpBoxPay.Controls.Add(Me.ChkboxSvcPay)
        Me.GrpBoxPay.Controls.Add(Me.LblSvcPay)
        Me.GrpBoxPay.Controls.Add(Me.TxtBoxSvcPay)
        Me.GrpBoxPay.Location = New System.Drawing.Point(44, 235)
        Me.GrpBoxPay.Name = "GrpBoxPay"
        Me.GrpBoxPay.Size = New System.Drawing.Size(670, 174)
        Me.GrpBoxPay.TabIndex = 0
        Me.GrpBoxPay.TabStop = False
        Me.GrpBoxPay.Text = "Pay Style Settings"
        '
        'ChkboxSvcPay
        '
        Me.ChkboxSvcPay.AutoSize = True
        Me.ChkboxSvcPay.Location = New System.Drawing.Point(29, 41)
        Me.ChkboxSvcPay.Name = "ChkboxSvcPay"
        Me.ChkboxSvcPay.Size = New System.Drawing.Size(130, 17)
        Me.ChkboxSvcPay.TabIndex = 6
        Me.ChkboxSvcPay.Text = "Use static service pay"
        Me.ChkboxSvcPay.UseVisualStyleBackColor = True
        '
        'LblSvcPay
        '
        Me.LblSvcPay.AutoSize = True
        Me.LblSvcPay.Location = New System.Drawing.Point(49, 85)
        Me.LblSvcPay.Name = "LblSvcPay"
        Me.LblSvcPay.Size = New System.Drawing.Size(73, 13)
        Me.LblSvcPay.TabIndex = 5
        Me.LblSvcPay.Text = "Enter amount:"
        '
        'TxtBoxSvcPay
        '
        Me.TxtBoxSvcPay.Location = New System.Drawing.Point(140, 82)
        Me.TxtBoxSvcPay.Name = "TxtBoxSvcPay"
        Me.TxtBoxSvcPay.Size = New System.Drawing.Size(80, 20)
        Me.TxtBoxSvcPay.TabIndex = 3
        '
        'TabEditTech
        '
        Me.TabEditTech.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabEditTech.Controls.Add(Me.PnlEditTech)
        Me.TabEditTech.Location = New System.Drawing.Point(4, 22)
        Me.TabEditTech.Name = "TabEditTech"
        Me.TabEditTech.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEditTech.Size = New System.Drawing.Size(758, 504)
        Me.TabEditTech.TabIndex = 1
        Me.TabEditTech.Text = "Add/EditTech"
        '
        'PnlEditTech
        '
        Me.PnlEditTech.Controls.Add(Me.RBAddTech)
        Me.PnlEditTech.Controls.Add(Me.BtnEditTechCncl)
        Me.PnlEditTech.Controls.Add(Me.TxtboxEmail)
        Me.PnlEditTech.Controls.Add(Me.BtnEditTechSave)
        Me.PnlEditTech.Controls.Add(LblEmailAddress)
        Me.PnlEditTech.Controls.Add(Me.CmboBoxTechs)
        Me.PnlEditTech.Controls.Add(Me.TxtboxPhone)
        Me.PnlEditTech.Controls.Add(Me.RBEditTech)
        Me.PnlEditTech.Controls.Add(LblPhoneNum)
        Me.PnlEditTech.Controls.Add(Me.TxtBoxFedID)
        Me.PnlEditTech.Controls.Add(LblID)
        Me.PnlEditTech.Controls.Add(LblFedIDNum)
        Me.PnlEditTech.Controls.Add(Me.TxtboxID)
        Me.PnlEditTech.Controls.Add(Me.TxtBoxSSN)
        Me.PnlEditTech.Controls.Add(LblLocation)
        Me.PnlEditTech.Controls.Add(LblSSN)
        Me.PnlEditTech.Controls.Add(Me.TxtboxLoc)
        Me.PnlEditTech.Controls.Add(Me.TxtboxPayPerc)
        Me.PnlEditTech.Controls.Add(LblHomeAddress)
        Me.PnlEditTech.Controls.Add(LblPayPercentage)
        Me.PnlEditTech.Controls.Add(Me.TxtboxAddr)
        Me.PnlEditTech.Controls.Add(Me.TxtBoxLast)
        Me.PnlEditTech.Controls.Add(LblFirstName)
        Me.PnlEditTech.Controls.Add(LblLastName)
        Me.PnlEditTech.Controls.Add(Me.txtBoxFirst)
        Me.PnlEditTech.Controls.Add(Me.TxtBoxMI)
        Me.PnlEditTech.Controls.Add(LblMiddleInitial)
        Me.PnlEditTech.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlEditTech.Location = New System.Drawing.Point(3, 3)
        Me.PnlEditTech.Name = "PnlEditTech"
        Me.PnlEditTech.Size = New System.Drawing.Size(752, 498)
        Me.PnlEditTech.TabIndex = 29
        '
        'RBAddTech
        '
        Me.RBAddTech.AutoSize = True
        Me.RBAddTech.Location = New System.Drawing.Point(5, 13)
        Me.RBAddTech.Name = "RBAddTech"
        Me.RBAddTech.Size = New System.Drawing.Size(109, 17)
        Me.RBAddTech.TabIndex = 24
        Me.RBAddTech.TabStop = True
        Me.RBAddTech.Text = "Add a Technician"
        Me.RBAddTech.UseVisualStyleBackColor = True
        '
        'BtnEditTechCncl
        '
        Me.BtnEditTechCncl.Location = New System.Drawing.Point(672, 470)
        Me.BtnEditTechCncl.Name = "BtnEditTechCncl"
        Me.BtnEditTechCncl.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditTechCncl.TabIndex = 13
        Me.BtnEditTechCncl.Text = "Close"
        Me.BtnEditTechCncl.UseVisualStyleBackColor = True
        '
        'TxtboxEmail
        '
        Me.TxtboxEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "EmailAdd", True))
        Me.TxtboxEmail.Location = New System.Drawing.Point(97, 336)
        Me.TxtboxEmail.Name = "TxtboxEmail"
        Me.TxtboxEmail.Size = New System.Drawing.Size(331, 20)
        Me.TxtboxEmail.TabIndex = 9
        '
        'TechniciansBindingSource
        '
        Me.TechniciansBindingSource.DataMember = "Technicians"
        Me.TechniciansBindingSource.DataSource = Me.ReceiverInstallationDataSet
        '
        'ReceiverInstallationDataSet
        '
        Me.ReceiverInstallationDataSet.DataSetName = "ReceiverInstallationDataSet"
        Me.ReceiverInstallationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnEditTechSave
        '
        Me.BtnEditTechSave.Location = New System.Drawing.Point(591, 470)
        Me.BtnEditTechSave.Name = "BtnEditTechSave"
        Me.BtnEditTechSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditTechSave.TabIndex = 12
        Me.BtnEditTechSave.Text = "Save"
        Me.BtnEditTechSave.UseVisualStyleBackColor = True
        '
        'CmboBoxTechs
        '
        Me.CmboBoxTechs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboBoxTechs.FormattingEnabled = True
        Me.CmboBoxTechs.Location = New System.Drawing.Point(5, 48)
        Me.CmboBoxTechs.Name = "CmboBoxTechs"
        Me.CmboBoxTechs.Size = New System.Drawing.Size(368, 21)
        Me.CmboBoxTechs.TabIndex = 26
        '
        'TxtboxPhone
        '
        Me.TxtboxPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "PhoneNum", True))
        Me.TxtboxPhone.Location = New System.Drawing.Point(97, 310)
        Me.TxtboxPhone.Name = "TxtboxPhone"
        Me.TxtboxPhone.Size = New System.Drawing.Size(149, 20)
        Me.TxtboxPhone.TabIndex = 8
        '
        'RBEditTech
        '
        Me.RBEditTech.AutoSize = True
        Me.RBEditTech.Location = New System.Drawing.Point(129, 13)
        Me.RBEditTech.Name = "RBEditTech"
        Me.RBEditTech.Size = New System.Drawing.Size(99, 17)
        Me.RBEditTech.TabIndex = 25
        Me.RBEditTech.TabStop = True
        Me.RBEditTech.Text = "Edit Technician"
        Me.RBEditTech.UseVisualStyleBackColor = True
        '
        'TxtBoxFedID
        '
        Me.TxtBoxFedID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "FedIDNum", True))
        Me.TxtBoxFedID.Location = New System.Drawing.Point(97, 223)
        Me.TxtBoxFedID.Name = "TxtBoxFedID"
        Me.TxtBoxFedID.Size = New System.Drawing.Size(149, 20)
        Me.TxtBoxFedID.TabIndex = 6
        '
        'TxtboxID
        '
        Me.TxtboxID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "ID", True))
        Me.TxtboxID.Location = New System.Drawing.Point(97, 124)
        Me.TxtboxID.Name = "TxtboxID"
        Me.TxtboxID.Size = New System.Drawing.Size(278, 20)
        Me.TxtboxID.TabIndex = 1
        '
        'TxtBoxSSN
        '
        Me.TxtBoxSSN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "SSN", True))
        Me.TxtBoxSSN.Location = New System.Drawing.Point(97, 197)
        Me.TxtBoxSSN.Name = "TxtBoxSSN"
        Me.TxtBoxSSN.Size = New System.Drawing.Size(149, 20)
        Me.TxtBoxSSN.TabIndex = 5
        '
        'TxtboxLoc
        '
        Me.TxtboxLoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "Location", True))
        Me.TxtboxLoc.Location = New System.Drawing.Point(95, 392)
        Me.TxtboxLoc.Name = "TxtboxLoc"
        Me.TxtboxLoc.Size = New System.Drawing.Size(278, 20)
        Me.TxtboxLoc.TabIndex = 10
        '
        'TxtboxPayPerc
        '
        Me.TxtboxPayPerc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "PayPercentage", True))
        Me.TxtboxPayPerc.Location = New System.Drawing.Point(97, 418)
        Me.TxtboxPayPerc.Name = "TxtboxPayPerc"
        Me.TxtboxPayPerc.Size = New System.Drawing.Size(78, 20)
        Me.TxtboxPayPerc.TabIndex = 11
        '
        'TxtboxAddr
        '
        Me.TxtboxAddr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "HomeAddress", True))
        Me.TxtboxAddr.Location = New System.Drawing.Point(97, 284)
        Me.TxtboxAddr.Name = "TxtboxAddr"
        Me.TxtboxAddr.Size = New System.Drawing.Size(644, 20)
        Me.TxtboxAddr.TabIndex = 7
        '
        'TxtBoxLast
        '
        Me.TxtBoxLast.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "LastName", True))
        Me.TxtBoxLast.Location = New System.Drawing.Point(540, 157)
        Me.TxtBoxLast.Name = "TxtBoxLast"
        Me.TxtBoxLast.Size = New System.Drawing.Size(201, 20)
        Me.TxtBoxLast.TabIndex = 4
        '
        'txtBoxFirst
        '
        Me.txtBoxFirst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "FirstName", True))
        Me.txtBoxFirst.Location = New System.Drawing.Point(97, 157)
        Me.txtBoxFirst.Name = "txtBoxFirst"
        Me.txtBoxFirst.Size = New System.Drawing.Size(201, 20)
        Me.txtBoxFirst.TabIndex = 2
        '
        'TxtBoxMI
        '
        Me.TxtBoxMI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "MiddleInitial", True))
        Me.TxtBoxMI.Location = New System.Drawing.Point(398, 157)
        Me.TxtBoxMI.Name = "TxtBoxMI"
        Me.TxtBoxMI.Size = New System.Drawing.Size(40, 20)
        Me.TxtBoxMI.TabIndex = 3
        '
        'TabEditPword
        '
        Me.TabEditPword.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabEditPword.Controls.Add(Me.GrpBoxPass)
        Me.TabEditPword.Controls.Add(Me.BtnEditPassCncl)
        Me.TabEditPword.Controls.Add(Me.BtnEditPassOK)
        Me.TabEditPword.Controls.Add(Me.Btn_Cancel)
        Me.TabEditPword.Controls.Add(Me.Btn_Ok)
        Me.TabEditPword.Location = New System.Drawing.Point(4, 22)
        Me.TabEditPword.Name = "TabEditPword"
        Me.TabEditPword.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEditPword.Size = New System.Drawing.Size(758, 504)
        Me.TabEditPword.TabIndex = 0
        Me.TabEditPword.Text = "Edit Password"
        '
        'GrpBoxPass
        '
        Me.GrpBoxPass.Controls.Add(Me.LblOldPass)
        Me.GrpBoxPass.Controls.Add(Me.TxtBoxPass)
        Me.GrpBoxPass.Controls.Add(Me.LblConfirmPass)
        Me.GrpBoxPass.Controls.Add(Me.LblNewPass)
        Me.GrpBoxPass.Controls.Add(Me.TxtBoxConfirmPass)
        Me.GrpBoxPass.Controls.Add(Me.TxtBoxCurrentPass)
        Me.GrpBoxPass.Location = New System.Drawing.Point(36, 36)
        Me.GrpBoxPass.Name = "GrpBoxPass"
        Me.GrpBoxPass.Size = New System.Drawing.Size(670, 174)
        Me.GrpBoxPass.TabIndex = 11
        Me.GrpBoxPass.TabStop = False
        Me.GrpBoxPass.Text = "Change Password"
        '
        'LblOldPass
        '
        Me.LblOldPass.AutoSize = True
        Me.LblOldPass.Location = New System.Drawing.Point(34, 48)
        Me.LblOldPass.Name = "LblOldPass"
        Me.LblOldPass.Size = New System.Drawing.Size(120, 13)
        Me.LblOldPass.TabIndex = 10
        Me.LblOldPass.Text = "Enter current Password:"
        '
        'LblConfirmPass
        '
        Me.LblConfirmPass.AutoSize = True
        Me.LblConfirmPass.Location = New System.Drawing.Point(34, 128)
        Me.LblConfirmPass.Name = "LblConfirmPass"
        Me.LblConfirmPass.Size = New System.Drawing.Size(123, 13)
        Me.LblConfirmPass.TabIndex = 9
        Me.LblConfirmPass.Text = "Re-Enter new password:"
        '
        'TxtBoxConfirmPass
        '
        Me.TxtBoxConfirmPass.Location = New System.Drawing.Point(165, 125)
        Me.TxtBoxConfirmPass.Name = "TxtBoxConfirmPass"
        Me.TxtBoxConfirmPass.Size = New System.Drawing.Size(234, 20)
        Me.TxtBoxConfirmPass.TabIndex = 8
        '
        'TxtBoxCurrentPass
        '
        Me.TxtBoxCurrentPass.Location = New System.Drawing.Point(165, 45)
        Me.TxtBoxCurrentPass.Name = "TxtBoxCurrentPass"
        Me.TxtBoxCurrentPass.Size = New System.Drawing.Size(234, 20)
        Me.TxtBoxCurrentPass.TabIndex = 7
        '
        'BtnEditPassCncl
        '
        Me.BtnEditPassCncl.Location = New System.Drawing.Point(675, 473)
        Me.BtnEditPassCncl.Name = "BtnEditPassCncl"
        Me.BtnEditPassCncl.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditPassCncl.TabIndex = 6
        Me.BtnEditPassCncl.Text = "Close"
        Me.BtnEditPassCncl.UseVisualStyleBackColor = True
        '
        'BtnEditPassOK
        '
        Me.BtnEditPassOK.Location = New System.Drawing.Point(594, 473)
        Me.BtnEditPassOK.Name = "BtnEditPassOK"
        Me.BtnEditPassOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditPassOK.TabIndex = 5
        Me.BtnEditPassOK.Text = "OK"
        Me.BtnEditPassOK.UseVisualStyleBackColor = True
        '
        'TechniciansTableAdapter
        '
        Me.TechniciansTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivitiesTableAdapter = Nothing
        Me.TableAdapterManager.AdminTableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PayStubsTableAdapter = Nothing
        Me.TableAdapterManager.ReceiverInvTableAdapter = Nothing
        Me.TableAdapterManager.ReceiverTransferTableAdapter = Nothing
        Me.TableAdapterManager.TechniciansTableAdapter = Me.TechniciansTableAdapter
        Me.TableAdapterManager.UpdateOrder = Suntech.ReceiverInstallationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 530)
        Me.Controls.Add(Me.TabCtrlSttng)
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TabCtrlSttng.ResumeLayout(False)
        Me.TabGeneral.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpBoxPay.ResumeLayout(False)
        Me.GrpBoxPay.PerformLayout()
        Me.TabEditTech.ResumeLayout(False)
        Me.PnlEditTech.ResumeLayout(False)
        Me.PnlEditTech.PerformLayout()
        CType(Me.TechniciansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverInstallationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEditPword.ResumeLayout(False)
        Me.GrpBoxPass.ResumeLayout(False)
        Me.GrpBoxPass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Ok As System.Windows.Forms.Button
    Friend WithEvents LblNewPass As System.Windows.Forms.Label
    Friend WithEvents TxtBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents TabCtrlSttng As System.Windows.Forms.TabControl
    Friend WithEvents TabEditPword As System.Windows.Forms.TabPage
    Friend WithEvents TabEditTech As System.Windows.Forms.TabPage
    Friend WithEvents ReceiverInstallationDataSet As Suntech.ReceiverInstallationDataSet
    Friend WithEvents TechniciansBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TechniciansTableAdapter As Suntech.ReceiverInstallationDataSetTableAdapters.TechniciansTableAdapter
    Friend WithEvents TableAdapterManager As Suntech.ReceiverInstallationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RBEditTech As System.Windows.Forms.RadioButton
    Friend WithEvents RBAddTech As System.Windows.Forms.RadioButton
    Friend WithEvents TxtboxID As System.Windows.Forms.TextBox
    Friend WithEvents TxtboxLoc As System.Windows.Forms.TextBox
    Friend WithEvents TxtboxAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxFirst As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxMI As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxLast As System.Windows.Forms.TextBox
    Friend WithEvents TxtboxPayPerc As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxSSN As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxFedID As System.Windows.Forms.TextBox
    Friend WithEvents TxtboxPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtboxEmail As System.Windows.Forms.TextBox
    Friend WithEvents TabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents CmboBoxTechs As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBoxConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxCurrentPass As System.Windows.Forms.TextBox
    Friend WithEvents BtnEditPassCncl As System.Windows.Forms.Button
    Friend WithEvents BtnEditPassOK As System.Windows.Forms.Button
    Friend WithEvents LblOldPass As System.Windows.Forms.Label
    Friend WithEvents LblConfirmPass As System.Windows.Forms.Label
    Friend WithEvents BtnEditTechCncl As System.Windows.Forms.Button
    Friend WithEvents BtnEditTechSave As System.Windows.Forms.Button
    Friend WithEvents PnlEditTech As System.Windows.Forms.Panel
    Friend WithEvents GrpBoxPay As System.Windows.Forms.GroupBox
    Friend WithEvents ChkboxSvcPay As System.Windows.Forms.CheckBox
    Friend WithEvents LblSvcPay As System.Windows.Forms.Label
    Friend WithEvents TxtBoxSvcPay As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenSave As System.Windows.Forms.Button
    Friend WithEvents BtnGenCncl As System.Windows.Forms.Button
    Friend WithEvents GrpBoxPass As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblComp As System.Windows.Forms.Label
    Friend WithEvents LblDistro As System.Windows.Forms.Label
    Friend WithEvents TxtboxComp As System.Windows.Forms.TextBox
    Friend WithEvents TxtboxDistro As System.Windows.Forms.TextBox
End Class
