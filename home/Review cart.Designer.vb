<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMReview_Cart
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Grand_Total = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Total_BV = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(87, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(173, 20)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone No."
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(87, 62)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(173, 20)
        Me.txtNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(889, 568)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grand Total :"
        '
        'Grand_Total
        '
        Me.Grand_Total.AutoSize = True
        Me.Grand_Total.Location = New System.Drawing.Point(964, 568)
        Me.Grand_Total.Name = "Grand_Total"
        Me.Grand_Total.Size = New System.Drawing.Size(0, 13)
        Me.Grand_Total.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODE, Me.PRDNAME, Me.DP, Me.QUANTITY, Me.BV, Me.TBV, Me.TOTAL})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1086, 429)
        Me.DataGridView1.TabIndex = 0
        '
        'Total_BV
        '
        Me.Total_BV.AutoSize = True
        Me.Total_BV.Location = New System.Drawing.Point(813, 568)
        Me.Total_BV.Name = "Total_BV"
        Me.Total_BV.Size = New System.Drawing.Size(0, 13)
        Me.Total_BV.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(738, 568)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total BV:"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(408, 568)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'CODE
        '
        Me.CODE.HeaderText = "Code"
        Me.CODE.Name = "CODE"
        '
        'PRDNAME
        '
        Me.PRDNAME.HeaderText = "Name"
        Me.PRDNAME.Name = "PRDNAME"
        '
        'DP
        '
        Me.DP.HeaderText = "Price"
        Me.DP.Name = "DP"
        '
        'QUANTITY
        '
        Me.QUANTITY.HeaderText = "Quantity"
        Me.QUANTITY.Name = "QUANTITY"
        '
        'BV
        '
        Me.BV.HeaderText = "BV"
        Me.BV.Name = "BV"
        '
        'TBV
        '
        Me.TBV.HeaderText = "Total BV"
        Me.TBV.Name = "TBV"
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "Total"
        Me.TOTAL.Name = "TOTAL"
        '
        'FRMReview_Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 632)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Total_BV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Grand_Total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FRMReview_Cart"
        Me.Text = "Review cart"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Grand_Total As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Total_BV As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents CODE As DataGridViewTextBoxColumn
    Friend WithEvents PRDNAME As DataGridViewTextBoxColumn
    Friend WithEvents DP As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents BV As DataGridViewTextBoxColumn
    Friend WithEvents TBV As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
End Class
