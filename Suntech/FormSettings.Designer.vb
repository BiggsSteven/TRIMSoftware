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
        Me.TabEditTech = New System.Windows.Forms.TabPage()
        Me.BtnEditTechCncl = New System.Windows.Forms.Button()
        Me.BtnEditTechSave = New System.Windows.Forms.Button()
        Me.CmboBoxTechs = New System.Windows.Forms.ComboBox()
        Me.RBEditTech = New System.Windows.Forms.RadioButton()
        Me.RBAddTech = New System.Windows.Forms.RadioButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TechniciansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiverInstallationDataSet = New Suntech.ReceiverInstallationDataSet()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.HomeAddressTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleInitialTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PayPercentageTextBox = New System.Windows.Forms.TextBox()
        Me.SSNTextBox = New System.Windows.Forms.TextBox()
        Me.FedIDNumTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddTextBox = New System.Windows.Forms.TextBox()
        Me.TabEditPword = New System.Windows.Forms.TabPage()
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
        Me.TabEditTech.SuspendLayout()
        CType(Me.TechniciansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverInstallationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEditPword.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblEmailAddress
        '
        LblEmailAddress.AutoSize = True
        LblEmailAddress.Location = New System.Drawing.Point(8, 356)
        LblEmailAddress.Name = "LblEmailAddress"
        LblEmailAddress.Size = New System.Drawing.Size(76, 13)
        LblEmailAddress.TabIndex = 22
        LblEmailAddress.Text = "Email Address:"
        '
        'LblPhoneNum
        '
        LblPhoneNum.AutoSize = True
        LblPhoneNum.Location = New System.Drawing.Point(8, 330)
        LblPhoneNum.Name = "LblPhoneNum"
        LblPhoneNum.Size = New System.Drawing.Size(81, 13)
        LblPhoneNum.TabIndex = 20
        LblPhoneNum.Text = "Phone Number:"
        '
        'LblFedIDNum
        '
        LblFedIDNum.AutoSize = True
        LblFedIDNum.Location = New System.Drawing.Point(8, 243)
        LblFedIDNum.Name = "LblFedIDNum"
        LblFedIDNum.Size = New System.Drawing.Size(82, 13)
        LblFedIDNum.TabIndex = 18
        LblFedIDNum.Text = "Fed ID Number:"
        '
        'LblSSN
        '
        LblSSN.AutoSize = True
        LblSSN.Location = New System.Drawing.Point(8, 217)
        LblSSN.Name = "LblSSN"
        LblSSN.Size = New System.Drawing.Size(32, 13)
        LblSSN.TabIndex = 16
        LblSSN.Text = "SSN:"
        '
        'LblPayPercentage
        '
        LblPayPercentage.AutoSize = True
        LblPayPercentage.Location = New System.Drawing.Point(8, 438)
        LblPayPercentage.Name = "LblPayPercentage"
        LblPayPercentage.Size = New System.Drawing.Size(86, 13)
        LblPayPercentage.TabIndex = 14
        LblPayPercentage.Text = "Pay Percentage:"
        '
        'LblLastName
        '
        LblLastName.AutoSize = True
        LblLastName.Location = New System.Drawing.Point(476, 177)
        LblLastName.Name = "LblLastName"
        LblLastName.Size = New System.Drawing.Size(61, 13)
        LblLastName.TabIndex = 12
        LblLastName.Text = "Last Name:"
        '
        'LblMiddleInitial
        '
        LblMiddleInitial.AutoSize = True
        LblMiddleInitial.Location = New System.Drawing.Point(327, 177)
        LblMiddleInitial.Name = "LblMiddleInitial"
        LblMiddleInitial.Size = New System.Drawing.Size(68, 13)
        LblMiddleInitial.TabIndex = 10
        LblMiddleInitial.Text = "Middle Initial:"
        '
        'LblFirstName
        '
        LblFirstName.AutoSize = True
        LblFirstName.Location = New System.Drawing.Point(8, 177)
        LblFirstName.Name = "LblFirstName"
        LblFirstName.Size = New System.Drawing.Size(60, 13)
        LblFirstName.TabIndex = 8
        LblFirstName.Text = "First Name:"
        '
        'LblHomeAddress
        '
        LblHomeAddress.AutoSize = True
        LblHomeAddress.Location = New System.Drawing.Point(8, 304)
        LblHomeAddress.Name = "LblHomeAddress"
        LblHomeAddress.Size = New System.Drawing.Size(79, 13)
        LblHomeAddress.TabIndex = 6
        LblHomeAddress.Text = "Home Address:"
        '
        'LblLocation
        '
        LblLocation.AutoSize = True
        LblLocation.Location = New System.Drawing.Point(6, 412)
        LblLocation.Name = "LblLocation"
        LblLocation.Size = New System.Drawing.Size(64, 13)
        LblLocation.TabIndex = 4
        LblLocation.Text = "Subdivision:"
        '
        'LblID
        '
        LblID.AutoSize = True
        LblID.Location = New System.Drawing.Point(8, 144)
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
        Me.LblNewPass.Location = New System.Drawing.Point(167, 186)
        Me.LblNewPass.Name = "LblNewPass"
        Me.LblNewPass.Size = New System.Drawing.Size(106, 13)
        Me.LblNewPass.TabIndex = 4
        Me.LblNewPass.Text = "Enter new password:"
        '
        'TxtBoxPass
        '
        Me.TxtBoxPass.Location = New System.Drawing.Point(298, 183)
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
        Me.TabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Size = New System.Drawing.Size(758, 504)
        Me.TabGeneral.TabIndex = 2
        Me.TabGeneral.Text = "General"
        '
        'TabEditTech
        '
        Me.TabEditTech.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabEditTech.Controls.Add(Me.BtnEditTechCncl)
        Me.TabEditTech.Controls.Add(Me.BtnEditTechSave)
        Me.TabEditTech.Controls.Add(Me.CmboBoxTechs)
        Me.TabEditTech.Controls.Add(Me.RBEditTech)
        Me.TabEditTech.Controls.Add(Me.RBAddTech)
        Me.TabEditTech.Controls.Add(LblID)
        Me.TabEditTech.Controls.Add(Me.IDTextBox)
        Me.TabEditTech.Controls.Add(LblLocation)
        Me.TabEditTech.Controls.Add(Me.LocationTextBox)
        Me.TabEditTech.Controls.Add(LblHomeAddress)
        Me.TabEditTech.Controls.Add(Me.HomeAddressTextBox)
        Me.TabEditTech.Controls.Add(LblFirstName)
        Me.TabEditTech.Controls.Add(Me.FirstNameTextBox)
        Me.TabEditTech.Controls.Add(LblMiddleInitial)
        Me.TabEditTech.Controls.Add(Me.MiddleInitialTextBox)
        Me.TabEditTech.Controls.Add(LblLastName)
        Me.TabEditTech.Controls.Add(Me.LastNameTextBox)
        Me.TabEditTech.Controls.Add(LblPayPercentage)
        Me.TabEditTech.Controls.Add(Me.PayPercentageTextBox)
        Me.TabEditTech.Controls.Add(LblSSN)
        Me.TabEditTech.Controls.Add(Me.SSNTextBox)
        Me.TabEditTech.Controls.Add(LblFedIDNum)
        Me.TabEditTech.Controls.Add(Me.FedIDNumTextBox)
        Me.TabEditTech.Controls.Add(LblPhoneNum)
        Me.TabEditTech.Controls.Add(Me.PhoneNumTextBox)
        Me.TabEditTech.Controls.Add(LblEmailAddress)
        Me.TabEditTech.Controls.Add(Me.EmailAddTextBox)
        Me.TabEditTech.Location = New System.Drawing.Point(4, 22)
        Me.TabEditTech.Name = "TabEditTech"
        Me.TabEditTech.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEditTech.Size = New System.Drawing.Size(758, 504)
        Me.TabEditTech.TabIndex = 1
        Me.TabEditTech.Text = "Add/EditTech"
        '
        'BtnEditTechCncl
        '
        Me.BtnEditTechCncl.Location = New System.Drawing.Point(675, 473)
        Me.BtnEditTechCncl.Name = "BtnEditTechCncl"
        Me.BtnEditTechCncl.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditTechCncl.TabIndex = 28
        Me.BtnEditTechCncl.Text = "Cancel"
        Me.BtnEditTechCncl.UseVisualStyleBackColor = True
        '
        'BtnEditTechSave
        '
        Me.BtnEditTechSave.Location = New System.Drawing.Point(594, 473)
        Me.BtnEditTechSave.Name = "BtnEditTechSave"
        Me.BtnEditTechSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditTechSave.TabIndex = 27
        Me.BtnEditTechSave.Text = "Save"
        Me.BtnEditTechSave.UseVisualStyleBackColor = True
        '
        'CmboBoxTechs
        '
        Me.CmboBoxTechs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboBoxTechs.FormattingEnabled = True
        Me.CmboBoxTechs.Location = New System.Drawing.Point(8, 65)
        Me.CmboBoxTechs.Name = "CmboBoxTechs"
        Me.CmboBoxTechs.Size = New System.Drawing.Size(368, 21)
        Me.CmboBoxTechs.TabIndex = 26
        '
        'RBEditTech
        '
        Me.RBEditTech.AutoSize = True
        Me.RBEditTech.Location = New System.Drawing.Point(132, 30)
        Me.RBEditTech.Name = "RBEditTech"
        Me.RBEditTech.Size = New System.Drawing.Size(99, 17)
        Me.RBEditTech.TabIndex = 25
        Me.RBEditTech.TabStop = True
        Me.RBEditTech.Text = "Edit Technician"
        Me.RBEditTech.UseVisualStyleBackColor = True
        '
        'RBAddTech
        '
        Me.RBAddTech.AutoSize = True
        Me.RBAddTech.Location = New System.Drawing.Point(8, 30)
        Me.RBAddTech.Name = "RBAddTech"
        Me.RBAddTech.Size = New System.Drawing.Size(109, 17)
        Me.RBAddTech.TabIndex = 24
        Me.RBAddTech.TabStop = True
        Me.RBAddTech.Text = "Add a Technician"
        Me.RBAddTech.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(100, 141)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(278, 20)
        Me.IDTextBox.TabIndex = 1
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
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(98, 409)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(278, 20)
        Me.LocationTextBox.TabIndex = 5
        '
        'HomeAddressTextBox
        '
        Me.HomeAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "HomeAddress", True))
        Me.HomeAddressTextBox.Location = New System.Drawing.Point(100, 301)
        Me.HomeAddressTextBox.Name = "HomeAddressTextBox"
        Me.HomeAddressTextBox.Size = New System.Drawing.Size(644, 20)
        Me.HomeAddressTextBox.TabIndex = 7
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(100, 174)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.FirstNameTextBox.TabIndex = 9
        '
        'MiddleInitialTextBox
        '
        Me.MiddleInitialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "MiddleInitial", True))
        Me.MiddleInitialTextBox.Location = New System.Drawing.Point(401, 174)
        Me.MiddleInitialTextBox.Name = "MiddleInitialTextBox"
        Me.MiddleInitialTextBox.Size = New System.Drawing.Size(40, 20)
        Me.MiddleInitialTextBox.TabIndex = 11
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(543, 174)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.LastNameTextBox.TabIndex = 13
        '
        'PayPercentageTextBox
        '
        Me.PayPercentageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "PayPercentage", True))
        Me.PayPercentageTextBox.Location = New System.Drawing.Point(100, 435)
        Me.PayPercentageTextBox.Name = "PayPercentageTextBox"
        Me.PayPercentageTextBox.Size = New System.Drawing.Size(78, 20)
        Me.PayPercentageTextBox.TabIndex = 15
        '
        'SSNTextBox
        '
        Me.SSNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "SSN", True))
        Me.SSNTextBox.Location = New System.Drawing.Point(100, 214)
        Me.SSNTextBox.Name = "SSNTextBox"
        Me.SSNTextBox.Size = New System.Drawing.Size(149, 20)
        Me.SSNTextBox.TabIndex = 17
        '
        'FedIDNumTextBox
        '
        Me.FedIDNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "FedIDNum", True))
        Me.FedIDNumTextBox.Location = New System.Drawing.Point(100, 240)
        Me.FedIDNumTextBox.Name = "FedIDNumTextBox"
        Me.FedIDNumTextBox.Size = New System.Drawing.Size(149, 20)
        Me.FedIDNumTextBox.TabIndex = 19
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(100, 327)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(149, 20)
        Me.PhoneNumTextBox.TabIndex = 21
        '
        'EmailAddTextBox
        '
        Me.EmailAddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechniciansBindingSource, "EmailAdd", True))
        Me.EmailAddTextBox.Location = New System.Drawing.Point(100, 353)
        Me.EmailAddTextBox.Name = "EmailAddTextBox"
        Me.EmailAddTextBox.Size = New System.Drawing.Size(331, 20)
        Me.EmailAddTextBox.TabIndex = 23
        '
        'TabEditPword
        '
        Me.TabEditPword.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabEditPword.Controls.Add(Me.LblOldPass)
        Me.TabEditPword.Controls.Add(Me.LblConfirmPass)
        Me.TabEditPword.Controls.Add(Me.TxtBoxConfirmPass)
        Me.TabEditPword.Controls.Add(Me.TxtBoxCurrentPass)
        Me.TabEditPword.Controls.Add(Me.BtnEditPassCncl)
        Me.TabEditPword.Controls.Add(Me.BtnEditPassOK)
        Me.TabEditPword.Controls.Add(Me.LblNewPass)
        Me.TabEditPword.Controls.Add(Me.Btn_Cancel)
        Me.TabEditPword.Controls.Add(Me.Btn_Ok)
        Me.TabEditPword.Controls.Add(Me.TxtBoxPass)
        Me.TabEditPword.Location = New System.Drawing.Point(4, 22)
        Me.TabEditPword.Name = "TabEditPword"
        Me.TabEditPword.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEditPword.Size = New System.Drawing.Size(758, 504)
        Me.TabEditPword.TabIndex = 0
        Me.TabEditPword.Text = "Edit Password"
        '
        'LblOldPass
        '
        Me.LblOldPass.AutoSize = True
        Me.LblOldPass.Location = New System.Drawing.Point(167, 146)
        Me.LblOldPass.Name = "LblOldPass"
        Me.LblOldPass.Size = New System.Drawing.Size(120, 13)
        Me.LblOldPass.TabIndex = 10
        Me.LblOldPass.Text = "Enter current Password:"
        '
        'LblConfirmPass
        '
        Me.LblConfirmPass.AutoSize = True
        Me.LblConfirmPass.Location = New System.Drawing.Point(167, 226)
        Me.LblConfirmPass.Name = "LblConfirmPass"
        Me.LblConfirmPass.Size = New System.Drawing.Size(123, 13)
        Me.LblConfirmPass.TabIndex = 9
        Me.LblConfirmPass.Text = "Re-Enter new password:"
        '
        'TxtBoxConfirmPass
        '
        Me.TxtBoxConfirmPass.Location = New System.Drawing.Point(298, 223)
        Me.TxtBoxConfirmPass.Name = "TxtBoxConfirmPass"
        Me.TxtBoxConfirmPass.Size = New System.Drawing.Size(234, 20)
        Me.TxtBoxConfirmPass.TabIndex = 8
        '
        'TxtBoxCurrentPass
        '
        Me.TxtBoxCurrentPass.Location = New System.Drawing.Point(298, 143)
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
        Me.BtnEditPassCncl.Text = "Cancel"
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
        Me.TabEditTech.ResumeLayout(False)
        Me.TabEditTech.PerformLayout()
        CType(Me.TechniciansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverInstallationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEditPword.ResumeLayout(False)
        Me.TabEditPword.PerformLayout()
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
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomeAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleInitialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PayPercentageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SSNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FedIDNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddTextBox As System.Windows.Forms.TextBox
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
End Class
