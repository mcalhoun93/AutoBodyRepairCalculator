<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobInfo
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cusnamtxtbox = New System.Windows.Forms.TextBox()
        Me.partchantxtbox = New System.Windows.Forms.TextBox()
        Me.laborhourstxtbox = New System.Windows.Forms.TextBox()
        Me.jobnumtxtbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.partscost = New System.Windows.Forms.TextBox()
        Me.laborcost = New System.Windows.Forms.TextBox()
        Me.subtotal = New System.Windows.Forms.TextBox()
        Me.taxtxtbox = New System.Windows.Forms.TextBox()
        Me.tottxtbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Labor Hours:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Parts Charges:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Customer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Job Number:"
        '
        'cusnamtxtbox
        '
        Me.cusnamtxtbox.Location = New System.Drawing.Point(130, 61)
        Me.cusnamtxtbox.Name = "cusnamtxtbox"
        Me.cusnamtxtbox.Size = New System.Drawing.Size(133, 20)
        Me.cusnamtxtbox.TabIndex = 1
        '
        'partchantxtbox
        '
        Me.partchantxtbox.Location = New System.Drawing.Point(130, 87)
        Me.partchantxtbox.Name = "partchantxtbox"
        Me.partchantxtbox.Size = New System.Drawing.Size(133, 20)
        Me.partchantxtbox.TabIndex = 2
        '
        'laborhourstxtbox
        '
        Me.laborhourstxtbox.Location = New System.Drawing.Point(130, 113)
        Me.laborhourstxtbox.Name = "laborhourstxtbox"
        Me.laborhourstxtbox.Size = New System.Drawing.Size(133, 20)
        Me.laborhourstxtbox.TabIndex = 3
        '
        'jobnumtxtbox
        '
        Me.jobnumtxtbox.Location = New System.Drawing.Point(130, 35)
        Me.jobnumtxtbox.Name = "jobnumtxtbox"
        Me.jobnumtxtbox.Size = New System.Drawing.Size(133, 20)
        Me.jobnumtxtbox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.partscost)
        Me.GroupBox1.Controls.Add(Me.laborcost)
        Me.GroupBox1.Controls.Add(Me.subtotal)
        Me.GroupBox1.Controls.Add(Me.taxtxtbox)
        Me.GroupBox1.Controls.Add(Me.tottxtbox)
        Me.GroupBox1.Location = New System.Drawing.Point(307, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 179)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Parts:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Labor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Subtotal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Sales Tax:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total"
        '
        'partscost
        '
        Me.partscost.Location = New System.Drawing.Point(107, 23)
        Me.partscost.Name = "partscost"
        Me.partscost.ReadOnly = True
        Me.partscost.Size = New System.Drawing.Size(100, 20)
        Me.partscost.TabIndex = 4
        '
        'laborcost
        '
        Me.laborcost.Location = New System.Drawing.Point(107, 49)
        Me.laborcost.Name = "laborcost"
        Me.laborcost.ReadOnly = True
        Me.laborcost.Size = New System.Drawing.Size(100, 20)
        Me.laborcost.TabIndex = 5
        '
        'subtotal
        '
        Me.subtotal.Location = New System.Drawing.Point(107, 75)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Size = New System.Drawing.Size(100, 20)
        Me.subtotal.TabIndex = 6
        '
        'taxtxtbox
        '
        Me.taxtxtbox.Location = New System.Drawing.Point(107, 101)
        Me.taxtxtbox.Name = "taxtxtbox"
        Me.taxtxtbox.ReadOnly = True
        Me.taxtxtbox.Size = New System.Drawing.Size(100, 20)
        Me.taxtxtbox.TabIndex = 7
        '
        'tottxtbox
        '
        Me.tottxtbox.Location = New System.Drawing.Point(107, 127)
        Me.tottxtbox.Name = "tottxtbox"
        Me.tottxtbox.ReadOnly = True
        Me.tottxtbox.Size = New System.Drawing.Size(100, 20)
        Me.tottxtbox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(199, 168)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'JobInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 228)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cusnamtxtbox)
        Me.Controls.Add(Me.partchantxtbox)
        Me.Controls.Add(Me.laborhourstxtbox)
        Me.Controls.Add(Me.jobnumtxtbox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "JobInfo"
        Me.Text = "JobInfo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cusnamtxtbox As System.Windows.Forms.TextBox
    Friend WithEvents partchantxtbox As System.Windows.Forms.TextBox
    Friend WithEvents laborhourstxtbox As System.Windows.Forms.TextBox
    Friend WithEvents jobnumtxtbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents partscost As System.Windows.Forms.TextBox
    Friend WithEvents laborcost As System.Windows.Forms.TextBox
    Friend WithEvents subtotal As System.Windows.Forms.TextBox
    Friend WithEvents taxtxtbox As System.Windows.Forms.TextBox
    Friend WithEvents tottxtbox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
