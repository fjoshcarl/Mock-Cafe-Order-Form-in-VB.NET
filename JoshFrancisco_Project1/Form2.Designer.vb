<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbfood = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltotalitems = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbcost = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblbill = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.lbltotalbill = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.txtpayment = New System.Windows.Forms.TextBox()
        Me.btnorderfrm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(153, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Bill"
        '
        'lbfood
        '
        Me.lbfood.FormattingEnabled = True
        Me.lbfood.Location = New System.Drawing.Point(58, 101)
        Me.lbfood.Name = "lbfood"
        Me.lbfood.Size = New System.Drawing.Size(134, 147)
        Me.lbfood.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Items:"
        '
        'lbltotalitems
        '
        Me.lbltotalitems.AutoSize = True
        Me.lbltotalitems.BackColor = System.Drawing.Color.Transparent
        Me.lbltotalitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalitems.ForeColor = System.Drawing.Color.White
        Me.lbltotalitems.Location = New System.Drawing.Point(150, 278)
        Me.lbltotalitems.Name = "lbltotalitems"
        Me.lbltotalitems.Size = New System.Drawing.Size(16, 16)
        Me.lbltotalitems.TabIndex = 4
        Me.lbltotalitems.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(233, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Bill:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(229, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(193, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total Bill:"
        '
        'lbcost
        '
        Me.lbcost.FormattingEnabled = True
        Me.lbcost.Location = New System.Drawing.Point(215, 101)
        Me.lbcost.Name = "lbcost"
        Me.lbcost.Size = New System.Drawing.Size(134, 147)
        Me.lbcost.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(195, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Payment:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(202, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Change:"
        '
        'lblbill
        '
        Me.lblbill.AutoSize = True
        Me.lblbill.BackColor = System.Drawing.Color.Transparent
        Me.lblbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbill.ForeColor = System.Drawing.Color.White
        Me.lblbill.Location = New System.Drawing.Point(273, 278)
        Me.lblbill.Name = "lblbill"
        Me.lblbill.Size = New System.Drawing.Size(16, 16)
        Me.lblbill.TabIndex = 11
        Me.lblbill.Text = "0"
        '
        'lbltax
        '
        Me.lbltax.AutoSize = True
        Me.lbltax.BackColor = System.Drawing.Color.Transparent
        Me.lbltax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltax.ForeColor = System.Drawing.Color.White
        Me.lbltax.Location = New System.Drawing.Point(273, 307)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(16, 16)
        Me.lbltax.TabIndex = 12
        Me.lbltax.Text = "0"
        '
        'lbltotalbill
        '
        Me.lbltotalbill.AutoSize = True
        Me.lbltotalbill.BackColor = System.Drawing.Color.Transparent
        Me.lbltotalbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalbill.ForeColor = System.Drawing.Color.White
        Me.lbltotalbill.Location = New System.Drawing.Point(273, 338)
        Me.lbltotalbill.Name = "lbltotalbill"
        Me.lbltotalbill.Size = New System.Drawing.Size(16, 16)
        Me.lbltotalbill.TabIndex = 13
        Me.lbltotalbill.Text = "0"
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.BackColor = System.Drawing.Color.Transparent
        Me.lblchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.White
        Me.lblchange.Location = New System.Drawing.Point(273, 428)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(16, 16)
        Me.lblchange.TabIndex = 15
        Me.lblchange.Text = "0"
        '
        'txtpayment
        '
        Me.txtpayment.Location = New System.Drawing.Point(276, 395)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.Size = New System.Drawing.Size(73, 20)
        Me.txtpayment.TabIndex = 16
        '
        'btnorderfrm
        '
        Me.btnorderfrm.Location = New System.Drawing.Point(58, 323)
        Me.btnorderfrm.Name = "btnorderfrm"
        Me.btnorderfrm.Size = New System.Drawing.Size(75, 79)
        Me.btnorderfrm.TabIndex = 17
        Me.btnorderfrm.Text = "Order Form"
        Me.btnorderfrm.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(404, 515)
        Me.Controls.Add(Me.btnorderfrm)
        Me.Controls.Add(Me.txtpayment)
        Me.Controls.Add(Me.lblchange)
        Me.Controls.Add(Me.lbltotalbill)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.lblbill)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbcost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbltotalitems)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbfood)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbfood As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltotalitems As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbcost As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblbill As Label
    Friend WithEvents lbltax As Label
    Friend WithEvents lbltotalbill As Label
    Friend WithEvents lblchange As Label
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents btnorderfrm As Button
End Class
