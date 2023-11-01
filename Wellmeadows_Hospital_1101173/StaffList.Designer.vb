<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ptno = New System.Windows.Forms.TextBox()
        Me.Fillter = New System.Windows.Forms.Button()
        Me.ReporyByWard = New System.Windows.Forms.Button()
        Me.LIST_STAFFDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LIST_STAFFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital = New Wellmeadows_Hospital_1101173.Hospital()
        Me.STAFFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STAFFTableAdapter = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.STAFFTableAdapter()
        Me.TableAdapterManager = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.TableAdapterManager()
        Me.LIST_STAFFTableAdapter = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.LIST_STAFFTableAdapter()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.LIST_STAFFDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_STAFFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1759, 93)
        Me.Panel1.TabIndex = 0
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.White
        Me.Home.BackgroundImage = CType(resources.GetObject("Home.BackgroundImage"), System.Drawing.Image)
        Me.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Home.FlatAppearance.BorderSize = 0
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Home.Location = New System.Drawing.Point(16, 15)
        Me.Home.Margin = New System.Windows.Forms.Padding(4)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(39, 65)
        Me.Home.TabIndex = 6
        Me.Home.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(106, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 93)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1759, 1009)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.85484!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.14516!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ptno, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Fillter, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ReporyByWard, 2, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(16, 28)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(760, 65)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'ptno
        '
        Me.ptno.Location = New System.Drawing.Point(3, 35)
        Me.ptno.Name = "ptno"
        Me.ptno.Size = New System.Drawing.Size(124, 22)
        Me.ptno.TabIndex = 0
        '
        'Fillter
        '
        Me.Fillter.Location = New System.Drawing.Point(133, 35)
        Me.Fillter.Name = "Fillter"
        Me.Fillter.Size = New System.Drawing.Size(75, 23)
        Me.Fillter.TabIndex = 1
        Me.Fillter.Text = "Search"
        Me.Fillter.UseVisualStyleBackColor = True
        '
        'ReporyByWard
        '
        Me.ReporyByWard.Location = New System.Drawing.Point(231, 35)
        Me.ReporyByWard.Name = "ReporyByWard"
        Me.ReporyByWard.Size = New System.Drawing.Size(142, 23)
        Me.ReporyByWard.TabIndex = 4
        Me.ReporyByWard.Text = "Report by ward"
        Me.ReporyByWard.UseVisualStyleBackColor = True
        '
        'LIST_STAFFDataGridView
        '
        Me.LIST_STAFFDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LIST_STAFFDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.LIST_STAFFDataGridView.Name = "LIST_STAFFDataGridView"
        Me.LIST_STAFFDataGridView.RowHeadersWidth = 51
        Me.LIST_STAFFDataGridView.RowTemplate.Height = 24
        Me.LIST_STAFFDataGridView.Size = New System.Drawing.Size(1403, 619)
        Me.LIST_STAFFDataGridView.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(1711, 954)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 52)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LIST_STAFFBindingSource
        '
        Me.LIST_STAFFBindingSource.DataMember = "LIST_STAFF"
        Me.LIST_STAFFBindingSource.DataSource = Me.Hospital
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
        Me.TableAdapterManager.ALLOCATEDTO_OPDTableAdapter = Nothing
        Me.TableAdapterManager.ALLOCATEDTOTableAdapter = Nothing
        Me.TableAdapterManager.ASSIGNEDTOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BEDTableAdapter = Nothing
        Me.TableAdapterManager.DRUGTableAdapter = Nothing
        Me.TableAdapterManager.LOCALDOCTORTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_HISTORYTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTAPPOINTMENTTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTSNEXTOFKINTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTSTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTTTableAdapter = Nothing
        Me.TableAdapterManager.PRESCRIBEDTableAdapter = Nothing
        Me.TableAdapterManager.QUALIFICATIONTableAdapter = Nothing
        Me.TableAdapterManager.STAFFTableAdapter = Me.STAFFTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wellmeadows_Hospital_1101173.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WARDTableAdapter = Nothing
        Me.TableAdapterManager.WORK_INTableAdapter = Nothing
        Me.TableAdapterManager.WORKEXPTableAdapter = Nothing
        '
        'LIST_STAFFTableAdapter
        '
        Me.LIST_STAFFTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LIST_STAFFDataGridView, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(16, 99)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1409, 625)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'StaffList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1759, 1102)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StaffList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Menu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.LIST_STAFFDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_STAFFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub patienticon_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Patienticon_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Home As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Hospital As Hospital
    Friend WithEvents STAFFBindingSource As BindingSource
    Friend WithEvents STAFFTableAdapter As HospitalTableAdapters.STAFFTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents LIST_STAFFBindingSource As BindingSource
    Friend WithEvents LIST_STAFFTableAdapter As HospitalTableAdapters.LIST_STAFFTableAdapter
    Friend WithEvents LIST_STAFFDataGridView As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ptno As TextBox
    Friend WithEvents Fillter As Button
    Friend WithEvents ReporyByWard As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
