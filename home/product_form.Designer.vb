<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class product_form
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HealthCareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkinCareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HealthCareToolStripMenuItem, Me.SkinCareToolStripMenuItem, Me.OpenCartToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1110, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HealthCareToolStripMenuItem
        '
        Me.HealthCareToolStripMenuItem.Name = "HealthCareToolStripMenuItem"
        Me.HealthCareToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.HealthCareToolStripMenuItem.Text = "Health care"
        '
        'SkinCareToolStripMenuItem
        '
        Me.SkinCareToolStripMenuItem.Name = "SkinCareToolStripMenuItem"
        Me.SkinCareToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.SkinCareToolStripMenuItem.Text = "Skin Care"
        '
        'OpenCartToolStripMenuItem
        '
        Me.OpenCartToolStripMenuItem.Name = "OpenCartToolStripMenuItem"
        Me.OpenCartToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.OpenCartToolStripMenuItem.Text = "Open Cart"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1110, 608)
        Me.Panel1.TabIndex = 1
        '
        'product_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1110, 632)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "product_form"
        Me.Text = "Products"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HealthCareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SkinCareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenCartToolStripMenuItem As ToolStripMenuItem
End Class
