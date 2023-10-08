<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientOPD_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientOPD_report))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Back = New System.Windows.Forms.Button()
        Me.PATIENTTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital = New Wellmeadows_Hospital_1101173.Hospital()
        Me.PATIENTTTableAdapter = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.PATIENTTTableAdapter()
        Me.TableAdapterManager = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.TableAdapterManager()
        Me.LOCALDOCTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCALDOCTORTableAdapter = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.LOCALDOCTORTableAdapter()
        Me.DETAIL_ALLOCATE_OPDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PATIENTTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCALDOCTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETAIL_ALLOCATE_OPDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1685, 838)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.34694!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.6530612!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Back, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.747127!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.25288!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1685, 838)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.00885!))
        Me.TableLayoutPanel2.Controls.Add(Me.ReportViewer1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 50)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.23183!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.768166!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 754.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 754.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1665, 754)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Wellmeadows_Hospital_1101173.OPD Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1659, 748)
        Me.ReportViewer1.TabIndex = 0
        '
        'Back
        '
        Me.Back.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Back.BackgroundImage = CType(resources.GetObject("Back.BackgroundImage"), System.Drawing.Image)
        Me.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Back.FlatAppearance.BorderSize = 0
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Back.Location = New System.Drawing.Point(1677, 822)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(4, 12)
        Me.Back.TabIndex = 10
        Me.Back.UseVisualStyleBackColor = False
        '
        'PATIENTTBindingSource
        '
        Me.PATIENTTBindingSource.DataMember = "PATIENTT"
        Me.PATIENTTBindingSource.DataSource = Me.Hospital
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PATIENTTTableAdapter
        '
        Me.PATIENTTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALLOCATEDTO_OPDTableAdapter = Nothing
        Me.TableAdapterManager.ALLOCATEDTOTableAdapter = Nothing
        Me.TableAdapterManager.ASSIGNEDTOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BEDTableAdapter = Nothing
        Me.TableAdapterManager.LOCALDOCTORTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTAPPOINTMENTTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTSNEXTOFKINTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTSTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTTTableAdapter = Me.PATIENTTTableAdapter
        Me.TableAdapterManager.QUALIFICATIONTableAdapter = Nothing
        Me.TableAdapterManager.STAFFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wellmeadows_Hospital_1101173.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WARDTableAdapter = Nothing
        Me.TableAdapterManager.WORK_INTableAdapter = Nothing
        Me.TableAdapterManager.WORKEXPTableAdapter = Nothing
        '
        'LOCALDOCTORBindingSource
        '
        Me.LOCALDOCTORBindingSource.DataMember = "LOCALDOCTOR"
        Me.LOCALDOCTORBindingSource.DataSource = Me.Hospital
        '
        'LOCALDOCTORTableAdapter
        '
        Me.LOCALDOCTORTableAdapter.ClearBeforeFill = True
        '
        'DETAIL_ALLOCATE_OPDBindingSource
        '
        Me.DETAIL_ALLOCATE_OPDBindingSource.DataMember = "DETAIL_ALLOCATE_OPD"
        Me.DETAIL_ALLOCATE_OPDBindingSource.DataSource = Me.Hospital
        '
        'PatientOPD_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 838)
        Me.Controls.Add(Me.Panel2)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PatientOPD_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Menu"
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PATIENTTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCALDOCTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETAIL_ALLOCATE_OPDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub patienticon_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Patienticon_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Back As Button
    Friend WithEvents Hospital As Hospital
    Friend WithEvents PATIENTTBindingSource As BindingSource
    Friend WithEvents PATIENTTTableAdapter As HospitalTableAdapters.PATIENTTTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents LOCALDOCTORBindingSource As BindingSource
    Friend WithEvents LOCALDOCTORTableAdapter As HospitalTableAdapters.LOCALDOCTORTableAdapter
    Friend WithEvents DETAIL_ALLOCATE_OPDBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
