<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.supilericon = New System.Windows.Forms.Button()
        Me.supileicon = New System.Windows.Forms.Button()
        Me.wardicon = New System.Windows.Forms.Button()
        Me.patienticon = New System.Windows.Forms.Button()
        Me.stafficon = New System.Windows.Forms.Button()
        Me.requisionicon = New System.Windows.Forms.Button()
        Me.dashboardicon = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 681)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 296)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.62786!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.86243!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.supilericon, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.supileicon, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.wardicon, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.patienticon, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.stafficon, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.requisionicon, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dashboardicon, 2, 0)
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
        'supilericon
        '
        Me.supilericon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.supilericon.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.supilericon.BackgroundImage = CType(resources.GetObject("supilericon.BackgroundImage"), System.Drawing.Image)
        Me.supilericon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.supilericon.FlatAppearance.BorderSize = 0
        Me.supilericon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supilericon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.supilericon.Location = New System.Drawing.Point(85, 501)
        Me.supilericon.Name = "supilericon"
        Me.supilericon.Size = New System.Drawing.Size(130, 133)
        Me.supilericon.TabIndex = 6
        Me.supilericon.UseVisualStyleBackColor = False
        '
        'supileicon
        '
        Me.supileicon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.supileicon.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.supileicon.BackgroundImage = CType(resources.GetObject("supileicon.BackgroundImage"), System.Drawing.Image)
        Me.supileicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.supileicon.FlatAppearance.BorderSize = 0
        Me.supileicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supileicon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.supileicon.Location = New System.Drawing.Point(390, 274)
        Me.supileicon.Name = "supileicon"
        Me.supileicon.Size = New System.Drawing.Size(130, 133)
        Me.supileicon.TabIndex = 4
        Me.supileicon.UseVisualStyleBackColor = False
        '
        'wardicon
        '
        Me.wardicon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.wardicon.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.wardicon.BackgroundImage = CType(resources.GetObject("wardicon.BackgroundImage"), System.Drawing.Image)
        Me.wardicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.wardicon.FlatAppearance.BorderSize = 0
        Me.wardicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.wardicon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.wardicon.Location = New System.Drawing.Point(85, 274)
        Me.wardicon.Name = "wardicon"
        Me.wardicon.Size = New System.Drawing.Size(130, 133)
        Me.wardicon.TabIndex = 3
        Me.wardicon.UseVisualStyleBackColor = False
        '
        'patienticon
        '
        Me.patienticon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.patienticon.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.patienticon.BackgroundImage = CType(resources.GetObject("patienticon.BackgroundImage"), System.Drawing.Image)
        Me.patienticon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.patienticon.FlatAppearance.BorderSize = 0
        Me.patienticon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.patienticon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.patienticon.Location = New System.Drawing.Point(85, 47)
        Me.patienticon.Name = "patienticon"
        Me.patienticon.Size = New System.Drawing.Size(130, 133)
        Me.patienticon.TabIndex = 0
        Me.patienticon.UseVisualStyleBackColor = False
        '
        'stafficon
        '
        Me.stafficon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.stafficon.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.stafficon.BackgroundImage = CType(resources.GetObject("stafficon.BackgroundImage"), System.Drawing.Image)
        Me.stafficon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.stafficon.FlatAppearance.BorderSize = 0
        Me.stafficon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stafficon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.stafficon.Location = New System.Drawing.Point(390, 47)
        Me.stafficon.Name = "stafficon"
        Me.stafficon.Size = New System.Drawing.Size(130, 133)
        Me.stafficon.TabIndex = 1
        Me.stafficon.UseVisualStyleBackColor = False
        '
        'requisionicon
        '
        Me.requisionicon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.requisionicon.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.requisionicon.BackgroundImage = CType(resources.GetObject("requisionicon.BackgroundImage"), System.Drawing.Image)
        Me.requisionicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.requisionicon.FlatAppearance.BorderSize = 0
        Me.requisionicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.requisionicon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.requisionicon.Location = New System.Drawing.Point(390, 501)
        Me.requisionicon.Name = "requisionicon"
        Me.requisionicon.Size = New System.Drawing.Size(130, 133)
        Me.requisionicon.TabIndex = 7
        Me.requisionicon.UseVisualStyleBackColor = False
        '
        'dashboardicon
        '
        Me.dashboardicon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dashboardicon.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dashboardicon.BackgroundImage = CType(resources.GetObject("dashboardicon.BackgroundImage"), System.Drawing.Image)
        Me.dashboardicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.dashboardicon.FlatAppearance.BorderSize = 0
        Me.dashboardicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardicon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dashboardicon.Location = New System.Drawing.Point(700, 47)
        Me.dashboardicon.Name = "dashboardicon"
        Me.dashboardicon.Size = New System.Drawing.Size(130, 133)
        Me.dashboardicon.TabIndex = 2
        Me.dashboardicon.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main menu"
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
    Friend WithEvents patienticon As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents stafficon As Button

    Private Sub stafficon_Click(sender As Object, e As EventArgs) Handles stafficon.Click

    End Sub
    Friend WithEvents requisionicon As Button
    Friend WithEvents supilericon As Button
    Friend WithEvents supileicon As Button
    Friend WithEvents wardicon As Button
    Friend WithEvents dashboardicon As Button
End Class
