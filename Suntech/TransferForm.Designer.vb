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
        Me.ReceiverTransferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Suntech.DataSet1
        Me.ReceiverTransferTableAdapter = New Suntech.DataSet1TableAdapters.ReceiverTransferTableAdapter
        Me.TableAdapterManager = New Suntech.DataSet1TableAdapters.TableAdapterManager
        Me.LblTrans = New System.Windows.Forms.Label
        Me.TxtBoxSerial = New System.Windows.Forms.TextBox
        Me.BtnTransfer = New System.Windows.Forms.Button
        Me.CmboTo = New System.Windows.Forms.ComboBox
        Me.CmboFrom = New System.Windows.Forms.ComboBox
        Me.LblOutput = New System.Windows.Forms.Label
        CType(Me.ReceiverTransferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.ReceiverInvTableAdapter = Nothing
        Me.TableAdapterManager.ReceiverTransferTableAdapter = Me.ReceiverTransferTableAdapter
        Me.TableAdapterManager.TechniciansTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Suntech.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LblTrans
        '
        Me.LblTrans.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTrans.AutoSize = True
        Me.LblTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrans.Location = New System.Drawing.Point(12, 42)
        Me.LblTrans.Name = "LblTrans"
        Me.LblTrans.Size = New System.Drawing.Size(113, 65)
        Me.LblTrans.TabIndex = 21
        Me.LblTrans.Text = "Technician (From):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Serial #:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Technician (To):"
        '
        'TxtBoxSerial
        '
        Me.TxtBoxSerial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxSerial.Location = New System.Drawing.Point(131, 65)
        Me.TxtBoxSerial.Name = "TxtBoxSerial"
        Me.TxtBoxSerial.Size = New System.Drawing.Size(238, 20)
        Me.TxtBoxSerial.TabIndex = 0
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
        Me.CmboTo.Location = New System.Drawing.Point(132, 92)
        Me.CmboTo.Name = "CmboTo"
        Me.CmboTo.Size = New System.Drawing.Size(237, 21)
        Me.CmboTo.TabIndex = 22
        '
        'CmboFrom
        '
        Me.CmboFrom.Enabled = False
        Me.CmboFrom.FormattingEnabled = True
        Me.CmboFrom.Location = New System.Drawing.Point(132, 38)
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
        'TransferForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 262)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.CmboFrom)
        Me.Controls.Add(Me.CmboTo)
        Me.Controls.Add(Me.LblTrans)
        Me.Controls.Add(Me.TxtBoxSerial)
        Me.Controls.Add(Me.BtnTransfer)
        Me.Name = "TransferForm"
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
    Friend WithEvents TxtBoxSerial As System.Windows.Forms.TextBox
    Friend WithEvents BtnTransfer As System.Windows.Forms.Button
    Friend WithEvents CmboTo As System.Windows.Forms.ComboBox
    Friend WithEvents CmboFrom As System.Windows.Forms.ComboBox
    Friend WithEvents LblOutput As System.Windows.Forms.Label
End Class
