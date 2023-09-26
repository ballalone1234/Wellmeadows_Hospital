<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.prescribept = New System.Windows.Forms.Button()
        Me.registerpt = New System.Windows.Forms.Button()
        Me.assignpt = New System.Windows.Forms.Button()
        Me.allocatept = New System.Windows.Forms.Button()
        Me.listpt = New System.Windows.Forms.Button()
        Me.waitingpt = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
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
        Me.PictureBox1.Location = New System.Drawing.Point(-14, 265)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 103)
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
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.71441!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.56148!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.79434!))
        Me.TableLayoutPanel1.Controls.Add(Me.prescribept, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.registerpt, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.assignpt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.allocatept, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.listpt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.waitingpt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Back, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(919, 681)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'prescribept
        '
        Me.prescribept.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prescribept.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.prescribept.BackgroundImage = CType(resources.GetObject("prescribept.BackgroundImage"), System.Drawing.Image)
        Me.prescribept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.prescribept.FlatAppearance.BorderSize = 0
        Me.prescribept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prescribept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.prescribept.Location = New System.Drawing.Point(67, 488)
        Me.prescribept.Name = "prescribept"
        Me.prescribept.Size = New System.Drawing.Size(165, 158)
        Me.prescribept.TabIndex = 5
        Me.prescribept.UseVisualStyleBackColor = False
        '
        'registerpt
        '
        Me.registerpt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.registerpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.registerpt.BackgroundImage = CType(resources.GetObject("registerpt.BackgroundImage"), System.Drawing.Image)
        Me.registerpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.registerpt.FlatAppearance.BorderSize = 0
        Me.registerpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerpt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.registerpt.Location = New System.Drawing.Point(62, 34)
        Me.registerpt.Name = "registerpt"
        Me.registerpt.Size = New System.Drawing.Size(176, 158)
        Me.registerpt.TabIndex = 0
        Me.registerpt.UseVisualStyleBackColor = False
        '
        'assignpt
        '
        Me.assignpt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.assignpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.assignpt.BackgroundImage = CType(resources.GetObject("assignpt.BackgroundImage"), System.Drawing.Image)
        Me.assignpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.assignpt.FlatAppearance.BorderSize = 0
        Me.assignpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.assignpt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.assignpt.Location = New System.Drawing.Point(385, 34)
        Me.assignpt.Name = "assignpt"
        Me.assignpt.Size = New System.Drawing.Size(165, 158)
        Me.assignpt.TabIndex = 2
        Me.assignpt.UseVisualStyleBackColor = False
        '
        'allocatept
        '
        Me.allocatept.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.allocatept.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.allocatept.BackgroundImage = CType(resources.GetObject("allocatept.BackgroundImage"), System.Drawing.Image)
        Me.allocatept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.allocatept.FlatAppearance.BorderSize = 0
        Me.allocatept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.allocatept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.allocatept.Location = New System.Drawing.Point(67, 261)
        Me.allocatept.Name = "allocatept"
        Me.allocatept.Size = New System.Drawing.Size(165, 158)
        Me.allocatept.TabIndex = 1
        Me.allocatept.UseVisualStyleBackColor = False
        '
        'listpt
        '
        Me.listpt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.listpt.BackgroundImage = CType(resources.GetObject("listpt.BackgroundImage"), System.Drawing.Image)
        Me.listpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.listpt.FlatAppearance.BorderSize = 0
        Me.listpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.listpt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.listpt.Location = New System.Drawing.Point(401, 269)
        Me.listpt.Name = "listpt"
        Me.listpt.Size = New System.Drawing.Size(133, 142)
        Me.listpt.TabIndex = 3
        Me.listpt.UseVisualStyleBackColor = False
        '
        'waitingpt
        '
        Me.waitingpt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.waitingpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.waitingpt.BackgroundImage = CType(resources.GetObject("waitingpt.BackgroundImage"), System.Drawing.Image)
        Me.waitingpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.waitingpt.FlatAppearance.BorderSize = 0
        Me.waitingpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.waitingpt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.waitingpt.Location = New System.Drawing.Point(393, 494)
        Me.waitingpt.Name = "waitingpt"
        Me.waitingpt.Size = New System.Drawing.Size(149, 146)
        Me.waitingpt.TabIndex = 4
        Me.waitingpt.UseVisualStyleBackColor = False
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
        Me.Back.TabIndex = 7
        Me.Back.UseVisualStyleBackColor = False
        '
        'PatientMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PatientMenu"
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
    Friend WithEvents registerpt As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel



    Friend WithEvents prescribept As Button
    Friend WithEvents assignpt As Button
    Friend WithEvents allocatept As Button
    Friend WithEvents listpt As Button
    Friend WithEvents waitingpt As Button
    Friend WithEvents Home As Button
    Friend WithEvents Back As Button
End Class
