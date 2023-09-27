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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(326, 681)
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
        Me.Home.Size = New System.Drawing.Size(29, 53)
        Me.Home.TabIndex = 6
        Me.Home.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 277)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(326, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 681)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.6327!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.367301!))
        Me.TableLayoutPanel1.Controls.Add(Me.Back, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 21)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497621!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.50238!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(893, 1004)
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
        Me.Back.Location = New System.Drawing.Point(876, 959)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(14, 42)
        Me.Back.TabIndex = 10
        Me.Back.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(902, 636)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 42)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StaffList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Menu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
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
End Class
