<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class shopping
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(shopping))
        Me.Categorybox = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnhc = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Cart = New System.Windows.Forms.Button()
        Me.Categorybox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Categorybox
        '
        Me.Categorybox.Controls.Add(Me.Button10)
        Me.Categorybox.Controls.Add(Me.Label2)
        Me.Categorybox.Controls.Add(Me.Button2)
        Me.Categorybox.Controls.Add(Me.Label1)
        Me.Categorybox.Controls.Add(Me.btnhc)
        Me.Categorybox.Location = New System.Drawing.Point(12, 28)
        Me.Categorybox.Name = "Categorybox"
        Me.Categorybox.Size = New System.Drawing.Size(1099, 624)
        Me.Categorybox.TabIndex = 0
        Me.Categorybox.TabStop = False
        Me.Categorybox.Text = "Product Category "
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Location = New System.Drawing.Point(440, 348)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(91, 53)
        Me.Button10.TabIndex = 18
        Me.Button10.Text = "Exit"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(544, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Skin Care"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(510, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 205)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Health Care"
        '
        'btnhc
        '
        Me.btnhc.Image = CType(resources.GetObject("btnhc.Image"), System.Drawing.Image)
        Me.btnhc.Location = New System.Drawing.Point(280, 38)
        Me.btnhc.Name = "btnhc"
        Me.btnhc.Size = New System.Drawing.Size(184, 205)
        Me.btnhc.TabIndex = 0
        Me.btnhc.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(879, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(926, 11)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(179, 20)
        Me.txt_search.TabIndex = 19
        '
        'Cart
        '
        Me.Cart.Location = New System.Drawing.Point(766, 4)
        Me.Cart.Name = "Cart"
        Me.Cart.Size = New System.Drawing.Size(75, 23)
        Me.Cart.TabIndex = 21
        Me.Cart.Text = "Open Cart"
        Me.Cart.UseVisualStyleBackColor = True
        '
        'shopping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 671)
        Me.Controls.Add(Me.Cart)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Categorybox)
        Me.Name = "shopping"
        Me.Text = "Shopping cart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Categorybox.ResumeLayout(False)
        Me.Categorybox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Categorybox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnhc As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Cart As Button
End Class
