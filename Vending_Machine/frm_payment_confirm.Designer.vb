<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_payment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_input_bill = New System.Windows.Forms.TextBox()
        Me.btn_make_payment = New System.Windows.Forms.Button()
        Me.txtbox_output_no_of_bills = New System.Windows.Forms.TextBox()
        Me.txt_box_output_coins = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_show_change = New System.Windows.Forms.Label()
        Me.Coins = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the amount of the bill"
        '
        'txtbox_input_bill
        '
        Me.txtbox_input_bill.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_input_bill.Location = New System.Drawing.Point(200, 93)
        Me.txtbox_input_bill.Name = "txtbox_input_bill"
        Me.txtbox_input_bill.Size = New System.Drawing.Size(100, 23)
        Me.txtbox_input_bill.TabIndex = 2
        '
        'btn_make_payment
        '
        Me.btn_make_payment.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_make_payment.Location = New System.Drawing.Point(179, 141)
        Me.btn_make_payment.Name = "btn_make_payment"
        Me.btn_make_payment.Size = New System.Drawing.Size(139, 38)
        Me.btn_make_payment.TabIndex = 3
        Me.btn_make_payment.Text = "Make Payment"
        Me.btn_make_payment.UseVisualStyleBackColor = True
        '
        'txtbox_output_no_of_bills
        '
        Me.txtbox_output_no_of_bills.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_output_no_of_bills.Location = New System.Drawing.Point(18, 287)
        Me.txtbox_output_no_of_bills.Multiline = True
        Me.txtbox_output_no_of_bills.Name = "txtbox_output_no_of_bills"
        Me.txtbox_output_no_of_bills.Size = New System.Drawing.Size(160, 127)
        Me.txtbox_output_no_of_bills.TabIndex = 4
        '
        'txt_box_output_coins
        '
        Me.txt_box_output_coins.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_box_output_coins.Location = New System.Drawing.Point(200, 287)
        Me.txt_box_output_coins.Multiline = True
        Me.txt_box_output_coins.Name = "txt_box_output_coins"
        Me.txt_box_output_coins.Size = New System.Drawing.Size(160, 127)
        Me.txt_box_output_coins.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bill"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Number"
        '
        'lbl_show_change
        '
        Me.lbl_show_change.AutoSize = True
        Me.lbl_show_change.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_show_change.Location = New System.Drawing.Point(21, 217)
        Me.lbl_show_change.Name = "lbl_show_change"
        Me.lbl_show_change.Size = New System.Drawing.Size(0, 25)
        Me.lbl_show_change.TabIndex = 8
        '
        'Coins
        '
        Me.Coins.AutoSize = True
        Me.Coins.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coins.Location = New System.Drawing.Point(197, 268)
        Me.Coins.Name = "Coins"
        Me.Coins.Size = New System.Drawing.Size(43, 19)
        Me.Coins.TabIndex = 9
        Me.Coins.Text = "Coins"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(262, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Number"
        '
        'frm_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 426)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Coins)
        Me.Controls.Add(Me.lbl_show_change)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_box_output_coins)
        Me.Controls.Add(Me.txtbox_output_no_of_bills)
        Me.Controls.Add(Me.btn_make_payment)
        Me.Controls.Add(Me.txtbox_input_bill)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_payment"
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbox_input_bill As System.Windows.Forms.TextBox
    Friend WithEvents btn_make_payment As System.Windows.Forms.Button
    Friend WithEvents txtbox_output_no_of_bills As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_output_coins As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_show_change As System.Windows.Forms.Label
    Friend WithEvents Coins As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
