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
        Me.PnlAddReceivers = New System.Windows.Forms.Panel
        Me.ChkListTransfers = New System.Windows.Forms.CheckedListBox
        CType(Me.ReceiverTransferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlAddReceivers.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTrans
        '
        Me.LblTrans.AutoSize = True
        Me.LblTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrans.Location = New System.Drawing.Point(12, 9)
        Me.LblTrans.Name = "LblTrans"
        Me.LblTrans.Size = New System.Drawing.Size(101, 13)
        Me.LblTrans.TabIndex = 21
        Me.LblTrans.Text = "Technician (To):"
        '
        'TxtBoxAccessCard
        '
        Me.TxtBoxAccessCard.Location = New System.Drawing.Point(132, 60)
        Me.TxtBoxAccessCard.Name = "TxtBoxAccessCard"
        Me.TxtBoxAccessCard.Size = New System.Drawing.Size(237, 20)
        Me.TxtBoxAccessCard.TabIndex = 0
        '
        'BtnTransfer
        '
        Me.BtnTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer.Location = New System.Drawing.Point(12, 390)
        Me.BtnTransfer.Name = "BtnTransfer"
        Me.BtnTransfer.Size = New System.Drawing.Size(353, 50)
        Me.BtnTransfer.TabIndex = 17
        Me.BtnTransfer.Text = "Make Transfer"
        Me.BtnTransfer.UseVisualStyleBackColor = True
        '
        'CmboTo
        '
        Me.CmboTo.FormattingEnabled = True
        Me.CmboTo.Location = New System.Drawing.Point(131, 6)
        Me.CmboTo.Name = "CmboTo"
        Me.CmboTo.Size = New System.Drawing.Size(237, 21)
        Me.CmboTo.TabIndex = 22
        '
        'CmboFrom
        '
        Me.CmboFrom.Enabled = False
        Me.CmboFrom.FormattingEnabled = True
        Me.CmboFrom.Location = New System.Drawing.Point(131, 33)
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
        Me.lblTechFrom.Location = New System.Drawing.Point(12, 36)
        Me.lblTechFrom.Name = "lblTechFrom"
        Me.lblTechFrom.Size = New System.Drawing.Size(113, 13)
        Me.lblTechFrom.TabIndex = 25
        Me.lblTechFrom.Text = "Technician (From):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Access Card #:"
        '
        'PnlAddReceivers
        '
        Me.PnlAddReceivers.Controls.Add(Me.ChkListTransfers)
        Me.PnlAddReceivers.Location = New System.Drawing.Point(15, 86)
        Me.PnlAddReceivers.Name = "PnlAddReceivers"
        Me.PnlAddReceivers.Size = New System.Drawing.Size(354, 298)
        Me.PnlAddReceivers.TabIndex = 27
        '
        'ChkListTransfers
        '
        Me.ChkListTransfers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkListTransfers.FormattingEnabled = True
        Me.ChkListTransfers.Location = New System.Drawing.Point(0, 0)
        Me.ChkListTransfers.Name = "ChkListTransfers"
        Me.ChkListTransfers.Size = New System.Drawing.Size(354, 289)
        Me.ChkListTransfers.TabIndex = 0
        '
        'TransferForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 452)
        Me.Controls.Add(Me.PnlAddReceivers)
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
        Me.Text = "Transfer Form"
        CType(Me.ReceiverTransferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlAddReceivers.ResumeLayout(False)
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
    Friend WithEvents PnlAddReceivers As System.Windows.Forms.Panel
    Friend WithEvents ChkListTransfers As System.Windows.Forms.CheckedListBox
End Class
