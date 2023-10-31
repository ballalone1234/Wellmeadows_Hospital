<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Treatment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Treatment))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Diagnosis = New System.Windows.Forms.TextBox()
        Me.ptno = New System.Windows.Forms.TextBox()
        Me.p8 = New System.Windows.Forms.Label()
        Me.DrugAllergies = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tdate = New System.Windows.Forms.DateTimePicker()
        Me.his_id = New System.Windows.Forms.TextBox()
        Me.ward = New System.Windows.Forms.TextBox()
        Me.tel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DrugStatus = New System.Windows.Forms.Label()
        Me.Med = New System.Windows.Forms.Button()
        Me.SumitButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.appref = New System.Windows.Forms.Button()
        Me.Appbut = New System.Windows.Forms.Button()
        Me.AppointStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
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
        Me.PictureBox1.Location = New System.Drawing.Point(8, 333)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 107)
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
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.12405!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.81992!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.18008!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1225, 838)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.00885!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.99115!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 559.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Diagnosis, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ptno, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.p8, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DrugAllergies, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Tdate, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.his_id, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ward, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tel, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 176)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1217, 463)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(4, 189)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(341, 30)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Treatment Date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(648, 189)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(3, 26)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Marital status"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(648, 129)
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
        Me.Label6.Location = New System.Drawing.Point(648, 99)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(3, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Marital status"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 99)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 30)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Diagnosis"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(648, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(3, 28)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Marital status"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(648, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(3, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Patients No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Diagnosis
        '
        Me.Diagnosis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Diagnosis.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Diagnosis.Location = New System.Drawing.Point(131, 131)
        Me.Diagnosis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Diagnosis.Multiline = True
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.Size = New System.Drawing.Size(381, 56)
        Me.Diagnosis.TabIndex = 8
        '
        'ptno
        '
        Me.ptno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptno.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ptno.Location = New System.Drawing.Point(131, 36)
        Me.ptno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptno.Multiline = True
        Me.ptno.Name = "ptno"
        Me.ptno.Size = New System.Drawing.Size(381, 54)
        Me.ptno.TabIndex = 5
        '
        'p8
        '
        Me.p8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.p8.ForeColor = System.Drawing.Color.White
        Me.p8.Location = New System.Drawing.Point(4, 0)
        Me.p8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.p8.Name = "p8"
        Me.p8.Size = New System.Drawing.Size(317, 23)
        Me.p8.TabIndex = 16
        Me.p8.Text = "Patient num"
        Me.p8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DrugAllergies
        '
        Me.DrugAllergies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DrugAllergies.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DrugAllergies.Location = New System.Drawing.Point(131, 328)
        Me.DrugAllergies.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DrugAllergies.Multiline = True
        Me.DrugAllergies.Name = "DrugAllergies"
        Me.DrugAllergies.Size = New System.Drawing.Size(381, 58)
        Me.DrugAllergies.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 294)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(326, 29)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Drug Allergies"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Tdate
        '
        Me.Tdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tdate.Location = New System.Drawing.Point(133, 239)
        Me.Tdate.Name = "Tdate"
        Me.Tdate.Size = New System.Drawing.Size(378, 34)
        Me.Tdate.TabIndex = 33
        '
        'his_id
        '
        Me.his_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.his_id.BackColor = System.Drawing.SystemColors.ControlDark
        Me.his_id.Enabled = False
        Me.his_id.Location = New System.Drawing.Point(746, 35)
        Me.his_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.his_id.Multiline = True
        Me.his_id.Name = "his_id"
        Me.his_id.Size = New System.Drawing.Size(381, 56)
        Me.his_id.TabIndex = 35
        '
        'ward
        '
        Me.ward.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ward.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ward.Location = New System.Drawing.Point(746, 132)
        Me.ward.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ward.Multiline = True
        Me.ward.Name = "ward"
        Me.ward.Size = New System.Drawing.Size(381, 54)
        Me.ward.TabIndex = 7
        '
        'tel
        '
        Me.tel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tel.Location = New System.Drawing.Point(746, 228)
        Me.tel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tel.Multiline = True
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(381, 56)
        Me.tel.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(661, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Ward num"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(661, 189)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(348, 23)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Treatment Received"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(661, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "History id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.65053!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.34947!))
        Me.TableLayoutPanel3.Controls.Add(Me.DrugStatus, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Med, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.SumitButton, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 646)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1219, 138)
        Me.TableLayoutPanel3.TabIndex = 11
        '
        'DrugStatus
        '
        Me.DrugStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DrugStatus.AutoSize = True
        Me.DrugStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DrugStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DrugStatus.Location = New System.Drawing.Point(225, 1)
        Me.DrugStatus.Name = "DrugStatus"
        Me.DrugStatus.Size = New System.Drawing.Size(204, 22)
        Me.DrugStatus.TabIndex = 12
        Me.DrugStatus.Text = "There is no medicine list"
        '
        'Med
        '
        Me.Med.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Med.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Med.BackgroundImage = CType(resources.GetObject("Med.BackgroundImage"), System.Drawing.Image)
        Me.Med.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Med.FlatAppearance.BorderSize = 0
        Me.Med.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Med.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Med.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Med.Location = New System.Drawing.Point(107, 48)
        Me.Med.Margin = New System.Windows.Forms.Padding(4)
        Me.Med.Name = "Med"
        Me.Med.Size = New System.Drawing.Size(439, 66)
        Me.Med.TabIndex = 8
        Me.Med.UseVisualStyleBackColor = False
        '
        'SumitButton
        '
        Me.SumitButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SumitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SumitButton.BackgroundImage = CType(resources.GetObject("SumitButton.BackgroundImage"), System.Drawing.Image)
        Me.SumitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SumitButton.FlatAppearance.BorderSize = 0
        Me.SumitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SumitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SumitButton.Location = New System.Drawing.Point(717, 45)
        Me.SumitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SumitButton.Name = "SumitButton"
        Me.SumitButton.Size = New System.Drawing.Size(439, 72)
        Me.SumitButton.TabIndex = 7
        Me.SumitButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.48647!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.51353!))
        Me.TableLayoutPanel4.Controls.Add(Me.PictureBox2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1219, 166)
        Me.TableLayoutPanel4.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(230, 19)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(191, 127)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.74101!))
        Me.TableLayoutPanel5.Controls.Add(Me.appref, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Appbut, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.AppointStatus, 0, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(655, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(561, 160)
        Me.TableLayoutPanel5.TabIndex = 11
        '
        'appref
        '
        Me.appref.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.appref.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.appref.BackgroundImage = CType(resources.GetObject("appref.BackgroundImage"), System.Drawing.Image)
        Me.appref.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.appref.FlatAppearance.BorderSize = 0
        Me.appref.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.appref.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.appref.Location = New System.Drawing.Point(74, 5)
        Me.appref.Margin = New System.Windows.Forms.Padding(4)
        Me.appref.Name = "appref"
        Me.appref.Size = New System.Drawing.Size(413, 57)
        Me.appref.TabIndex = 12
        Me.appref.UseVisualStyleBackColor = False
        '
        'Appbut
        '
        Me.Appbut.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Appbut.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appbut.BackgroundImage = CType(resources.GetObject("Appbut.BackgroundImage"), System.Drawing.Image)
        Me.Appbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Appbut.FlatAppearance.BorderSize = 0
        Me.Appbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Appbut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Appbut.Location = New System.Drawing.Point(74, 74)
        Me.Appbut.Margin = New System.Windows.Forms.Padding(4)
        Me.Appbut.Name = "Appbut"
        Me.Appbut.Size = New System.Drawing.Size(413, 57)
        Me.Appbut.TabIndex = 10
        Me.Appbut.UseVisualStyleBackColor = False
        '
        'AppointStatus
        '
        Me.AppointStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AppointStatus.AutoSize = True
        Me.AppointStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AppointStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AppointStatus.Location = New System.Drawing.Point(156, 136)
        Me.AppointStatus.Name = "AppointStatus"
        Me.AppointStatus.Size = New System.Drawing.Size(248, 22)
        Me.AppointStatus.TabIndex = 11
        Me.AppointStatus.Text = "Haven't made an appointment"
        '
        'Treatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 838)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Treatment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Menu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
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
    Friend WithEvents SumitButton As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents tel As TextBox
    Friend WithEvents Diagnosis As TextBox
    Friend WithEvents ward As TextBox
    Friend WithEvents ptno As TextBox
    Friend WithEvents p8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DrugAllergies As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Tdate As DateTimePicker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Med As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DrugStatus As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Appbut As Button
    Friend WithEvents AppointStatus As Label
    Friend WithEvents appref As Button
    Friend WithEvents his_id As TextBox
    Friend WithEvents Label1 As Label
End Class
