<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrescribeMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrescribeMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EndD = New System.Windows.Forms.DateTimePicker()
        Me.St = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DrugNo = New System.Windows.Forms.TextBox()
        Me.ptno = New System.Windows.Forms.TextBox()
        Me.Summit2Button = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.UnitPer = New System.Windows.Forms.NumericUpDown()
        Me.DataDrug = New System.Windows.Forms.DataGridView()
        Me.Drug_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drug_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Method = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DetailC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.UnitPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDrug, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 838)
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
        Me.Home.Size = New System.Drawing.Size(64, 65)
        Me.Home.TabIndex = 6
        Me.Home.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-19, 326)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(460, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1225, 838)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.714286!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Summit2Button, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Back, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DataDrug, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.01945!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.98055!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1225, 838)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(482, 26)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(191, 127)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.00885!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.99115!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 556.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.EndD, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.St, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ptno, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.UnitPer, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.AddButton, 2, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Detail, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.DrugNo, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 184)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.22951!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.77049!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1147, 326)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(4, 183)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(298, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Finish Date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(583, 183)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(3, 20)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Marital status"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(583, 119)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(3, 28)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Marital status"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(583, 93)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(3, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Marital status"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 23)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Unit per date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(583, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(3, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Patients No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Patients No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EndD
        '
        Me.EndD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EndD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.EndD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndD.Location = New System.Drawing.Point(98, 214)
        Me.EndD.Margin = New System.Windows.Forms.Padding(4)
        Me.EndD.Name = "EndD"
        Me.EndD.Size = New System.Drawing.Size(383, 34)
        Me.EndD.TabIndex = 26
        '
        'St
        '
        Me.St.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.St.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.St.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.St.Location = New System.Drawing.Point(676, 134)
        Me.St.Margin = New System.Windows.Forms.Padding(4)
        Me.St.Name = "St"
        Me.St.Size = New System.Drawing.Size(384, 34)
        Me.St.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(594, 93)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(268, 23)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Start Date"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AddButton
        '
        Me.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddButton.BackgroundImage = CType(resources.GetObject("AddButton.BackgroundImage"), System.Drawing.Image)
        Me.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddButton.FlatAppearance.BorderSize = 0
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddButton.Location = New System.Drawing.Point(636, 273)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(464, 48)
        Me.AddButton.TabIndex = 12
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(594, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Drug No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DrugNo
        '
        Me.DrugNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DrugNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DrugNo.Location = New System.Drawing.Point(678, 41)
        Me.DrugNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DrugNo.Multiline = True
        Me.DrugNo.Name = "DrugNo"
        Me.DrugNo.Size = New System.Drawing.Size(381, 35)
        Me.DrugNo.TabIndex = 7
        '
        'ptno
        '
        Me.ptno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptno.Location = New System.Drawing.Point(99, 40)
        Me.ptno.Multiline = True
        Me.ptno.Name = "ptno"
        Me.ptno.Size = New System.Drawing.Size(381, 36)
        Me.ptno.TabIndex = 52
        '
        'Summit2Button
        '
        Me.Summit2Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Summit2Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Summit2Button.BackgroundImage = CType(resources.GetObject("Summit2Button.BackgroundImage"), System.Drawing.Image)
        Me.Summit2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Summit2Button.FlatAppearance.BorderSize = 0
        Me.Summit2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Summit2Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Summit2Button.Location = New System.Drawing.Point(345, 738)
        Me.Summit2Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Summit2Button.Name = "Summit2Button"
        Me.Summit2Button.Size = New System.Drawing.Size(464, 62)
        Me.Summit2Button.TabIndex = 11
        Me.Summit2Button.UseVisualStyleBackColor = False
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
        Me.Back.Location = New System.Drawing.Point(1177, 742)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(44, 66)
        Me.Back.TabIndex = 10
        Me.Back.UseVisualStyleBackColor = False
        '
        'UnitPer
        '
        Me.UnitPer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UnitPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UnitPer.Location = New System.Drawing.Point(98, 134)
        Me.UnitPer.Name = "UnitPer"
        Me.UnitPer.Size = New System.Drawing.Size(382, 34)
        Me.UnitPer.TabIndex = 53
        '
        'DataDrug
        '
        Me.DataDrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDrug.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Drug_No, Me.Drug_name, Me.Method, Me.StartDate, Me.FinishDate, Me.DetailC})
        Me.DataDrug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataDrug.Location = New System.Drawing.Point(3, 517)
        Me.DataDrug.Name = "DataDrug"
        Me.DataDrug.RowHeadersWidth = 51
        Me.DataDrug.RowTemplate.Height = 24
        Me.DataDrug.Size = New System.Drawing.Size(1149, 207)
        Me.DataDrug.TabIndex = 12
        '
        'Drug_No
        '
        Me.Drug_No.HeaderText = "Drug No"
        Me.Drug_No.MinimumWidth = 6
        Me.Drug_No.Name = "Drug_No"
        '
        'Drug_name
        '
        Me.Drug_name.HeaderText = "Drug_Name"
        Me.Drug_name.MinimumWidth = 6
        Me.Drug_name.Name = "Drug_name"
        '
        'Method
        '
        Me.Method.HeaderText = "Method"
        Me.Method.MinimumWidth = 6
        Me.Method.Name = "Method"
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "Start Date"
        Me.StartDate.MinimumWidth = 6
        Me.StartDate.Name = "StartDate"
        '
        'FinishDate
        '
        Me.FinishDate.HeaderText = "Finish Date"
        Me.FinishDate.MinimumWidth = 6
        Me.FinishDate.Name = "FinishDate"
        '
        'Detail
        '
        Me.Detail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Detail.Location = New System.Drawing.Point(678, 213)
        Me.Detail.Multiline = True
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(381, 36)
        Me.Detail.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(594, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Detail"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DetailC
        '
        Me.DetailC.HeaderText = "Detail"
        Me.DetailC.MinimumWidth = 6
        Me.DetailC.Name = "DetailC"
        '
        'PrescribeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 838)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PrescribeMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Menu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.UnitPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDrug, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EndD As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Summit2Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents St As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents DrugNo As TextBox
    Friend WithEvents ptno As TextBox
    Friend WithEvents UnitPer As NumericUpDown
    Friend WithEvents DataDrug As DataGridView
    Friend WithEvents Drug_No As DataGridViewTextBoxColumn
    Friend WithEvents Drug_name As DataGridViewTextBoxColumn
    Friend WithEvents Method As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents FinishDate As DataGridViewTextBoxColumn
    Friend WithEvents Detail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DetailC As DataGridViewTextBoxColumn
End Class
