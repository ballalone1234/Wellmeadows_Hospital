<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Hospital = New Wellmeadows_Hospital_1101173.Hospital()
        Me.STAFFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STAFFTableAdapter = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.STAFFTableAdapter()
        Me.TableAdapterManager = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.TableAdapterManager()
        Me.DataSet1 = New Wellmeadows_Hospital_1101173.DataSet1()
        Me.EMPLOYEESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEESTableAdapter = New Wellmeadows_Hospital_1101173.DataSet1TableAdapters.EMPLOYEESTableAdapter()
        Me.TableAdapterManager1 = New Wellmeadows_Hospital_1101173.DataSet1TableAdapters.TableAdapterManager()
        Me.LoginBTN = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STAFFBindingSource
        '
        Me.STAFFBindingSource.DataMember = "STAFF"
        Me.STAFFBindingSource.DataSource = Me.Hospital
        '
        'STAFFTableAdapter
        '
        Me.STAFFTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.STAFFTableAdapter = Me.STAFFTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wellmeadows_Hospital_1101173.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLOYEESBindingSource
        '
        Me.EMPLOYEESBindingSource.DataMember = "EMPLOYEES"
        Me.EMPLOYEESBindingSource.DataSource = Me.DataSet1
        '
        'EMPLOYEESTableAdapter
        '
        Me.EMPLOYEESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.EMPLOYEESTableAdapter = Me.EMPLOYEESTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Wellmeadows_Hospital_1101173.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoginBTN
        '
        Me.LoginBTN.Location = New System.Drawing.Point(422, 292)
        Me.LoginBTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(120, 32)
        Me.LoginBTN.TabIndex = 3
        Me.LoginBTN.Text = "Button1"
        Me.LoginBTN.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUsername.Location = New System.Drawing.Point(396, 219)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(176, 34)
        Me.txtUsername.TabIndex = 4
        '
        'LoginForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(946, 547)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.LoginBTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hospital As Hospital
    Friend WithEvents STAFFBindingSource As BindingSource
    Friend WithEvents STAFFTableAdapter As HospitalTableAdapters.STAFFTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents EMPLOYEESBindingSource As BindingSource
    Friend WithEvents EMPLOYEESTableAdapter As DataSet1TableAdapters.EMPLOYEESTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents LoginBTN As Button
    Friend WithEvents txtUsername As TextBox
End Class
