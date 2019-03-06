Public Class frm_payment

    Private Sub frm_payment_confirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Verify that your total is $" & frm_vending_main.txtbox_total.Text & " and input the amount of bill."
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_make_payment_Click(sender As Object, e As EventArgs) Handles btn_make_payment.Click
        Dim input_bill As Double
        Dim change

        input_bill = CDbl(txtbox_input_bill.Text)

        'this if will check that the input money is greater than due or not
        If (input_bill < frm_vending_main.txtbox_total.Text) Then

            MessageBox.Show("Input the sufficient money")
        Else
            'this is the total change
            change = input_bill - frm_vending_main.txtbox_total.Text

            'it is just showing the change in the label
            lbl_show_change.Text = "Your change is $ " & change

            'this is the just bill amount excluding the decimal part
            Dim bill_change = Math.Truncate(change)

            'this is the decimal part of the change amount and is multiplied by 100 for the easiness of calculation. 
            Dim coin_change = (change - bill_change) * 100


            'the below algorithm is for just the bill part not the coins
            Dim bills() As Integer = {50, 20, 10, 5, 1}

            For i = 0 To 4
                'i am checking that which note will fit first
                Dim countbill = bill_change / bills(i)
                'here it checks if the change amount is greater than the bill or not
                If (countbill >= 1) Then
                    Dim first_bill As Integer = bills(i)
                    Dim no_of_first_bill = (bill_change \ bills(i))
                    Dim remaining = bill_change - no_of_first_bill * bills(i)

                    bill_change = remaining
                    txtbox_output_no_of_bills.Text += "$ " & bills(i) & vbTab & no_of_first_bill & vbCrLf

                End If
            Next

            'the below algorithm is for the coins or decimal part
            Dim coins() As Integer = {25, 10, 5, 1}

            For i = 0 To 3
                Dim countcoin = coin_change / coins(i)
                If (countcoin >= 1) Then
                    Dim first_coin As Integer = coins(i)
                    Dim no_of_first_coin = (coin_change \ coins(i))
                    Dim remaining = coin_change - no_of_first_coin * coins(i)

                    coin_change = remaining
                    txt_box_output_coins.Text += coins(i) & ChrW(&HA2) & vbTab & no_of_first_coin & vbCrLf

                End If
            Next
        End If
    End Sub
End Class