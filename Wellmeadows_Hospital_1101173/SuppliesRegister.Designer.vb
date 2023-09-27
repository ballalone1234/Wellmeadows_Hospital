<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SuppliesRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuppliesRegister))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.suppliesreg = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.methodofadmin = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.suppliernum = New System.Windows.Forms.TextBox()
        Me.costperunit = New System.Windows.Forms.TextBox()
        Me.description = New System.Windows.Forms.TextBox()
        Me.itemname = New System.Windows.Forms.TextBox()
        Me.itemno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dosage = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 681)
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
        Me.Home.Location = New System.Drawing.Point(12, 12)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(48, 53)
        Me.Home.TabIndex = 6
        Me.Home.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-38, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(416, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(345, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(919, 681)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.12405!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.875952!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.suppliesreg, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Back, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.81992!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.18008!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(919, 681)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(361, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 103)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'suppliesreg
        '
        Me.suppliesreg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.suppliesreg.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.suppliesreg.BackgroundImage = CType(resources.GetObject("suppliesreg.BackgroundImage"), System.Drawing.Image)
        Me.suppliesreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.suppliesreg.FlatAppearance.BorderSize = 0
        Me.suppliesreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.suppliesreg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.suppliesreg.Location = New System.Drawing.Point(268, 525)
        Me.suppliesreg.Name = "suppliesreg"
        Me.suppliesreg.Size = New System.Drawing.Size(329, 59)
        Me.suppliesreg.TabIndex = 7
        Me.suppliesreg.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.00885!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.99115!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.suppliernum, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.costperunit, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.description, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.itemname, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.itemno, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 143)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.67568!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.32433!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(859, 376)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.methodofadmin)
        Me.Panel4.Location = New System.Drawing.Point(451, 235)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(404, 138)
        Me.Panel4.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(342, 21)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Method of Admin (Drugs Only)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'methodofadmin
        '
        Me.methodofadmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.methodofadmin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.methodofadmin.Location = New System.Drawing.Point(59, 23)
        Me.methodofadmin.Margin = New System.Windows.Forms.Padding(2)
        Me.methodofadmin.Multiline = True
        Me.methodofadmin.Name = "methodofadmin"
        Me.methodofadmin.Size = New System.Drawing.Size(287, 48)
        Me.methodofadmin.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(451, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 21)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Cost per Unit"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(443, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(2, 21)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Marital status"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(254, 21)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Supplier Num"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(443, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(2, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Marital status"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(451, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Description"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(443, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(2, 19)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Marital status"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Item Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(443, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(2, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Marital status"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(443, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Patients No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'suppliernum
        '
        Me.suppliernum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.suppliernum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.suppliernum.Location = New System.Drawing.Point(76, 179)
        Me.suppliernum.Margin = New System.Windows.Forms.Padding(2)
        Me.suppliernum.Multiline = True
        Me.suppliernum.Name = "suppliernum"
        Me.suppliernum.Size = New System.Drawing.Size(287, 48)
        Me.suppliernum.TabIndex = 11
        '
        'costperunit
        '
        Me.costperunit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.costperunit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.costperunit.Location = New System.Drawing.Point(510, 179)
        Me.costperunit.Margin = New System.Windows.Forms.Padding(2)
        Me.costperunit.Multiline = True
        Me.costperunit.Name = "costperunit"
        Me.costperunit.Size = New System.Drawing.Size(287, 48)
        Me.costperunit.TabIndex = 15
        '
        'description
        '
        Me.description.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.description.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.description.Location = New System.Drawing.Point(510, 100)
        Me.description.Margin = New System.Windows.Forms.Padding(2)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(287, 48)
        Me.description.TabIndex = 10
        '
        'itemname
        '
        Me.itemname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.itemname.Location = New System.Drawing.Point(76, 100)
        Me.itemname.Margin = New System.Windows.Forms.Padding(2)
        Me.itemname.Multiline = True
        Me.itemname.Name = "itemname"
        Me.itemname.Size = New System.Drawing.Size(287, 48)
        Me.itemname.TabIndex = 8
        '
        'itemno
        '
        Me.itemno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemno.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.itemno.Location = New System.Drawing.Point(76, 25)
        Me.itemno.Margin = New System.Windows.Forms.Padding(2)
        Me.itemno.Multiline = True
        Me.itemno.Name = "itemno"
        Me.itemno.Size = New System.Drawing.Size(287, 45)
        Me.itemno.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Item/Drug No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.dosage)
        Me.Panel3.Location = New System.Drawing.Point(3, 235)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(434, 138)
        Me.Panel3.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 21)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Dosage (Drugs Only)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dosage
        '
        Me.dosage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dosage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dosage.Location = New System.Drawing.Point(74, 23)
        Me.dosage.Margin = New System.Windows.Forms.Padding(2)
        Me.dosage.Multiline = True
        Me.dosage.Name = "dosage"
        Me.dosage.Size = New System.Drawing.Size(287, 48)
        Me.dosage.TabIndex = 12
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
        Me.Back.Location = New System.Drawing.Point(883, 636)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(33, 42)
        Me.Back.TabIndex = 10
        Me.Back.UseVisualStyleBackColor = False
        '
        'SuppliesRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuppliesRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Menu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents costperunit As TextBox
    Friend WithEvents suppliernum As TextBox
    Friend WithEvents description As TextBox
    Friend WithEvents itemname As TextBox
    Friend WithEvents itemno As TextBox
    Friend WithEvents Back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents suppliesreg As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents methodofadmin As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dosage As TextBox
End Class
