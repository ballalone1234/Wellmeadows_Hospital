<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bedlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bedlist))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Back = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ward = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBox1.Image = Global.Wellmeadows_Hospital_1101173.My.Resources.Resources.im1age5
        Me.PictureBox1.Location = New System.Drawing.Point(4, 321)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 126)
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
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Back, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.25113!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.92259!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.481998!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.344284!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1225, 838)
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
        Me.Back.Location = New System.Drawing.Point(1111, 739)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(48, 49)
        Me.Back.TabIndex = 11
        Me.Back.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ward, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox2, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(586, 4)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(573, 79)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'ward
        '
        Me.ward.FormattingEnabled = True
        Me.ward.Location = New System.Drawing.Point(290, 27)
        Me.ward.Margin = New System.Windows.Forms.Padding(4)
        Me.ward.Name = "ward"
        Me.ward.Size = New System.Drawing.Size(277, 24)
        Me.ward.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Wellmeadows_Hospital_1101173.My.Resources.Resources.im1age3
        Me.PictureBox2.Location = New System.Drawing.Point(4, 27)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(278, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(65, 98)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1094, 628)
        Me.DataGridView1.TabIndex = 13
        '
        'Bedlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 838)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Bedlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Menu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel

    Private Sub patienticon_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Patienticon_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

    Friend WithEvents Home As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Back As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ward As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
