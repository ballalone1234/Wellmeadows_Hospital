﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataSearch = New System.Windows.Forms.DataGridView()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderBTN = New System.Windows.Forms.Button()
        CType(Me.DataSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSearch
        '
        Me.DataSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataSearch.Location = New System.Drawing.Point(12, 75)
        Me.DataSearch.Name = "DataSearch"
        Me.DataSearch.RowHeadersWidth = 51
        Me.DataSearch.RowTemplate.Height = 24
        Me.DataSearch.Size = New System.Drawing.Size(1878, 568)
        Me.DataSearch.TabIndex = 0
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.search.Location = New System.Drawing.Point(68, 26)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(131, 30)
        Me.search.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'OrderBTN
        '
        Me.OrderBTN.Location = New System.Drawing.Point(240, 26)
        Me.OrderBTN.Name = "OrderBTN"
        Me.OrderBTN.Size = New System.Drawing.Size(108, 23)
        Me.OrderBTN.TabIndex = 3
        Me.OrderBTN.Text = "Order"
        Me.OrderBTN.UseVisualStyleBackColor = True
        '
        'FormSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 665)
        Me.Controls.Add(Me.OrderBTN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.DataSearch)
        Me.Name = "FormSearch"
        Me.Text = "FormSearch"
        CType(Me.DataSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSearch As DataGridView
    Friend WithEvents search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderBTN As Button
End Class
