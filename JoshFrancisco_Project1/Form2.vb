Public Class Form2
    Dim change As Double
    Private Sub Btnorderfrm_Click(sender As Object, e As EventArgs) Handles btnorderfrm.Click
        lbfood.Items.Clear()
        lbcost.Items.Clear()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtpayment.TextChanged
        change = Val(txtpayment.Text) - Val(lbltotalbill.Text)
        lblchange.Text = change
    End Sub
End Class