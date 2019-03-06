Public Class frm_vending_main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btn_ordered_item_Click(sender As Object, e As EventArgs) Handles btn_ordered_item.Click
        'price of the given items
        Dim greentea = 0.97
        Dim muffine = 1.71
        Dim sprouts = 2.04
        Dim oatmeal = 1.11

        'no of ordered items
        Dim no_of_ordered_item As String
        no_of_ordered_item = "You have ordered " & txtbox_greentea.Text & " greentea, " & txtbox_muffin.Text & " muffin, " & txtbox_sprouts.Text & " sprouts, and " & txtbox_oatmeal.Text & " oatmeal."

        'total amount of the ordered item
        Dim total_amount As Double = CDbl(txtbox_greentea.Text) * greentea + CDbl(txtbox_muffin.Text) * muffine + CDbl(txtbox_sprouts.Text) * sprouts + CDbl(txtbox_oatmeal.Text) * oatmeal

        'this textbox(txtbox_total) is hidden in form. it is just there to store the value 
        txtbox_total.Text = total_amount

        'these below textbox shows the output in form
        txtbox_total_show.Text = "Your total is $" & txtbox_total.Text
        TextBox1.Text = no_of_ordered_item

        'this button is only shown when you put the input
        btn_proceed_payment.Show()

    End Sub

    Private Sub btn_proceed_payment_Click(sender As Object, e As EventArgs) Handles btn_proceed_payment.Click
        frm_payment.Show()

    End Sub

    Private Sub txtbox_total_TextChanged(sender As Object, e As EventArgs) Handles txtbox_total.TextChanged

    End Sub

    Private Sub txtbox_oatmeal_TextChanged(sender As Object, e As EventArgs) Handles txtbox_oatmeal.TextChanged

    End Sub

    Private Sub txtbox_sprouts_TextChanged(sender As Object, e As EventArgs) Handles txtbox_sprouts.TextChanged

    End Sub

    Private Sub txtbox_muffin_TextChanged(sender As Object, e As EventArgs) Handles txtbox_muffin.TextChanged

    End Sub

    Private Sub txtbox_greentea_TextChanged(sender As Object, e As EventArgs) Handles txtbox_greentea.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
