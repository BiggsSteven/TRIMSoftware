<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferForm
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
        Me.LblTrans = New System.Windows.Forms.Label
        Me.TxtBoxAccessCard = New System.Windows.Forms.TextBox
        Me.BtnTransfer = New System.Windows.Forms.Button
        Me.CmboTo = New System.Windows.Forms.ComboBox
        Me.CmboFrom = New System.Windows.Forms.ComboBox
        Me.LblOutput = New System.Windows.Forms.Label
        Me.ReceiverTransferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Suntech.DataSet1
        Me.ReceiverTransferTableAdapter = New Suntech.DataSet1TableAdapters.ReceiverTransferTableAdapter
        Me.TableAdapterManager = New Suntech.DataSet1TableAdapters.TableAdapterManager
        Me.lblTechFrom = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblSerial = New System.Windows.Forms.Label
        Me.TxtboxSerial = New System.Windows.Forms.TextBox
        CType(Me.ReceiverTransferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTrans
        '
        Me.LblTrans.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTrans.AutoSize = True
        Me.LblTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrans.Location = New System.Drawing.Point(12, 49)
        Me.LblTrans.Name = "LblTrans"
        Me.LblTrans.Size = New System.Drawing.Size(101, 13)
        Me.LblTrans.TabIndex = 21
        Me.LblTrans.Text = "Technician (To):"
        '
        'TxtBoxAccessCard
        '
        Me.TxtBoxAccessCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxAccessCard.Location = New System.Drawing.Point(130, 100)
        Me.TxtBoxAccessCard.Name = "TxtBoxAccessCard"
        Me.TxtBoxAccessCard.Size = New System.Drawing.Size(238, 20)
        Me.TxtBoxAccessCard.TabIndex = 0
        '
        'BtnTransfer
        '
        Me.BtnTransfer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer.Location = New System.Drawing.Point(12, 200)
        Me.BtnTransfer.Name = "BtnTransfer"
        Me.BtnTransfer.Size = New System.Drawing.Size(353, 50)
        Me.BtnTransfer.TabIndex = 17
        Me.BtnTransfer.Text = "Make Transfer"
        Me.BtnTransfer.UseVisualStyleBackColor = True
        '
        'CmboTo
        '
        Me.CmboTo.FormattingEnabled = True
        Me.CmboTo.Location = New System.Drawing.Point(131, 46)
        Me.CmboTo.Name = "CmboTo"
        Me.CmboTo.Size = New System.Drawing.Size(237, 21)
        Me.CmboTo.TabIndex = 22
        '
        'CmboFrom
        '
        Me.CmboFrom.Enabled = False
        Me.CmboFrom.FormattingEnabled = True
        Me.CmboFrom.Location = New System.Drawing.Point(131, 73)
        Me.CmboFrom.Name = "CmboFrom"
        Me.CmboFrom.Size = New System.Drawing.Size(237, 21)
        Me.CmboFrom.TabIndex = 23
        '
        'LblOutput
        '
        Me.LblOutput.AutoSize = True
        Me.LblOutput.Location = New System.Drawing.Point(12, 154)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(0, 13)
        Me.LblOutput.TabIndex = 24
        '
        'ReceiverTransferBindingSource
        '
        Me.ReceiverTransferBindingSource.DataMember = "ReceiverTransfer"
        Me.ReceiverTransferBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiverTransferTableAdapter
        '
        Me.ReceiverTransferTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivitiesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PayStubsTableAdapter = Nothing
        Me.TableAdapterManager.ReceiverInvTableAdapter = Nothing
        Me.TableAdapterManager.ReceiverTransferTableAdapter = Me.ReceiverTransferTableAdapter
        Me.TableAdapterManager.TechniciansTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Suntech.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblTechFrom
        '
        Me.lblTechFrom.AutoSize = True
        Me.lblTechFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTechFrom.Location = New System.Drawing.Point(12, 76)
        Me.lblTechFrom.Name = "lblTechFrom"
        Me.lblTechFrom.Size = New System.Drawing.Size(113, 13)
        Me.lblTechFrom.TabIndex = 25
        Me.lblTechFrom.Text = "Technician (From):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Access Card #:"
        '
        'LblSerial
        '
        Me.LblSerial.AutoSize = True
        Me.LblSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerial.Location = New System.Drawing.Point(12, 131)
        Me.LblSerial.Name = "LblSerial"
        Me.LblSerial.Size = New System.Drawing.Size(55, 13)
        Me.LblSerial.TabIndex = 27
        Me.LblSerial.Text = "Serial #:"
        '
        'TxtboxSerial
        '
        Me.TxtboxSerial.Location = New System.Drawing.Point(131, 128)
        Me.TxtboxSerial.Name = "TxtboxSerial"
        Me.TxtboxSerial.Size = New System.Drawing.Size(238, 20)
        Me.TxtboxSerial.TabIndex = 28
        '
        'TransferForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 262)
        Me.Controls.Add(Me.TxtboxSerial)
        Me.Controls.Add(Me.LblSerial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTechFrom)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.CmboFrom)
        Me.Controls.Add(Me.CmboTo)
        Me.Controls.Add(Me.LblTrans)
        Me.Controls.Add(Me.TxtBoxAccessCard)
        Me.Controls.Add(Me.BtnTransfer)
        Me.Name = "TransferForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransferForm"
        CType(Me.ReceiverTransferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As Suntech.DataSet1
    Friend WithEvents ReceiverTransferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiverTransferTableAdapter As Suntech.DataSet1TableAdapters.ReceiverTransferTableAdapter
    Friend WithEvents TableAdapterManager As Suntech.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents LblTrans As System.Windows.Forms.Label
    Friend WithEvents TxtBoxAccessCard As System.Windows.Forms.TextBox
    Friend WithEvents BtnTransfer As System.Windows.Forms.Button
    Friend WithEvents CmboTo As System.Windows.Forms.ComboBox
    Friend WithEvents CmboFrom As System.Windows.Forms.ComboBox
    Friend WithEvents LblOutput As System.Windows.Forms.Label
    Friend WithEvents lblTechFrom As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblSerial As System.Windows.Forms.Label
    Friend WithEvents TxtboxSerial As System.Windows.Forms.TextBox
End Class
