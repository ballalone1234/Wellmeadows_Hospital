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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Back = New System.Windows.Forms.Button()
        Me.STAFFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital = New Wellmeadows_Hospital_1101173.Hospital()
        Me.STAFFTableAdapter = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.STAFFTableAdapter()
        Me.TableAdapterManager = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.TableAdapterManager()
        Me.LIST_STAFFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIST_STAFFTableAdapter = New Wellmeadows_Hospital_1101173.HospitalTableAdapters.LIST_STAFFTableAdapter()
        Me.LIST_STAFFDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ptno = New System.Windows.Forms.TextBox()
        Me.Fillter = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_STAFFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_STAFFDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
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
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Controls.Add(Me.LIST_STAFFDataGridView)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 93)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1759, 1009)
        Me.Panel2.TabIndex = 1
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.6327!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.367301!))
        Me.TableLayoutPanel1.Controls.Add(Me.Back, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 846)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497621!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.50238!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1191, 1236)
        Me.TableLayoutPanel1.TabIndex = 1
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
        Me.Back.Location = New System.Drawing.Point(1168, 1180)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(19, 52)
        Me.Back.TabIndex = 10
        Me.Back.UseVisualStyleBackColor = False
        '
        'STAFFBindingSource
        '
        Me.STAFFBindingSource.DataMember = "STAFF"
        Me.STAFFBindingSource.DataSource = Me.Hospital
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.LOCALDOCTORTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTAPPOINTMENTTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTSNEXTOFKINTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTSTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTTTableAdapter = Nothing
        Me.TableAdapterManager.QUALIFICATIONTableAdapter = Nothing
        Me.TableAdapterManager.STAFFTableAdapter = Me.STAFFTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wellmeadows_Hospital_1101173.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WARDTableAdapter = Nothing
        Me.TableAdapterManager.WORK_INTableAdapter = Nothing
        Me.TableAdapterManager.WORKEXPTableAdapter = Nothing
        '
        'LIST_STAFFBindingSource
        '
        Me.LIST_STAFFBindingSource.DataMember = "LIST_STAFF"
        Me.LIST_STAFFBindingSource.DataSource = Me.Hospital
        '
        'LIST_STAFFTableAdapter
        '
        Me.LIST_STAFFTableAdapter.ClearBeforeFill = True
        '
        'LIST_STAFFDataGridView
        '
        Me.LIST_STAFFDataGridView.AutoGenerateColumns = False
        Me.LIST_STAFFDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LIST_STAFFDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15})
        Me.LIST_STAFFDataGridView.DataSource = Me.LIST_STAFFBindingSource
        Me.LIST_STAFFDataGridView.Location = New System.Drawing.Point(0, 110)
        Me.LIST_STAFFDataGridView.Name = "LIST_STAFFDataGridView"
        Me.LIST_STAFFDataGridView.RowHeadersWidth = 51
        Me.LIST_STAFFDataGridView.RowTemplate.Height = 24
        Me.LIST_STAFFDataGridView.Size = New System.Drawing.Size(1828, 615)
        Me.LIST_STAFFDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "STAFF_NUM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "STAFF_NUM"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "STAFF_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "STAFF_NAME"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SALARY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SALARY"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "WORK_LOCATION"
        Me.DataGridViewTextBoxColumn5.HeaderText = "WORK_LOCATION"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TELL"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TELL"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NIN"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NIN"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SEX"
        Me.DataGridViewTextBoxColumn8.HeaderText = "SEX"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "POSITION"
        Me.DataGridViewTextBoxColumn9.HeaderText = "POSITION"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "POSITION_HISTORY"
        Me.DataGridViewTextBoxColumn16.HeaderText = "POSITION_HISTORY"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "WORKED_PER_WEEK"
        Me.DataGridViewTextBoxColumn11.HeaderText = "WORKED_PER_WEEK"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "WORK_TYPE"
        Me.DataGridViewTextBoxColumn12.HeaderText = "WORK_TYPE"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PAYMENT_TYPE"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PAYMENT_TYPE"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SALARY_LEVEL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "SALARY_LEVEL"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ptno, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Fillter, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(16, 28)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(593, 65)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'ptno
        '
        Me.ptno.Location = New System.Drawing.Point(3, 35)
        Me.ptno.Name = "ptno"
        Me.ptno.Size = New System.Drawing.Size(94, 22)
        Me.ptno.TabIndex = 0
        '
        'Fillter
        '
        Me.Fillter.Location = New System.Drawing.Point(113, 35)
        Me.Fillter.Name = "Fillter"
        Me.Fillter.Size = New System.Drawing.Size(75, 23)
        Me.Fillter.TabIndex = 1
        Me.Fillter.Text = "Search"
        Me.Fillter.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_STAFFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_STAFFDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub patienticon_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Patienticon_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Home As Button
    Friend WithEvents Back As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Hospital As Hospital
    Friend WithEvents STAFFBindingSource As BindingSource
    Friend WithEvents STAFFTableAdapter As HospitalTableAdapters.STAFFTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents LIST_STAFFBindingSource As BindingSource
    Friend WithEvents LIST_STAFFTableAdapter As HospitalTableAdapters.LIST_STAFFTableAdapter
    Friend WithEvents LIST_STAFFDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ptno As TextBox
    Friend WithEvents Fillter As Button
End Class
