Public Class Form1
    Dim fd1, fd2, fd3, fd4, fd5, cost, total As Double

    Private Sub Cbmenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmenu.SelectedIndexChanged
        If cbmenu.SelectedIndex = 0 Then
            Button1.Text = "Pancake"
            Label1.Text = "Php 110.00"
            fd1 = 110
            Button2.Text = "Hotdog"
            Label2.Text = "Php 40.00"
            fd2 = 40
            Button3.Text = "Bread"
            Label3.Text = "Php 45.00"
            fd3 = 45
            Button4.Text = "Cake"
            Label4.Text = "Php 75.00"
            fd4 = 75
            Button5.Text = "Egg"
            Label5.Text = "Php 20.00"
            fd5 = 20
        ElseIf cbmenu.SelectedIndex = 1 Then
            Button1.Text = "Chicken"
            Label1.Text = "Php 150.00"
            fd1 = 150
            Button2.Text = "Beef and Mushroom"
            Label2.Text = "Php 170.00"
            fd2 = 170
            Button3.Text = "Pork Steak"
            Label3.Text = "Php 120.00"
            fd3 = 120
            Button4.Text = "Spaghetti"
            Label4.Text = "Php 90.00"
            fd4 = 90
            Button5.Text = "Rice"
            Label5.Text = "Php 30.00"
            fd5 = 30
        ElseIf cbmenu.SelectedIndex = 2 Then
            Button1.Text = "Chicken"
            Label1.Text = "Php 150.00"
            fd1 = 150
            Button2.Text = "Beef and Mushroom"
            Label2.Text = "Php 170.00"
            fd2 = 170
            Button3.Text = "Pork Adobo"
            Label3.Text = "Php 130.00"
            fd3 = 130
            Button4.Text = "Rice"
            Label4.Text = "Php 30.00"
            fd4 = 30
            Button5.Text = "Chocolate"
            Label5.Text = "Php 250.00"
            fd5 = 250
        End If
        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        TextBox4.Show()
        TextBox5.Show()
        txttotal.Show()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        btnvoid.Show()
        btncheckout.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label7.Show()
        Label8.Show()
        lbcost.Show()
        lbfood.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Btnvoid_Click(sender As Object, e As EventArgs) Handles btnvoid.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        lbcost.Items.Clear()
        lbfood.Items.Clear()
        txttotal.Clear()
        total = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbfood.Items.Add(Val(TextBox1.Text) & " " & Button1.Text)
        cost = Val(TextBox1.Text) * fd1
        lbcost.Items.Add(cost)
        total = total + cost
        txttotal.Text = total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbfood.Items.Add(Val(TextBox2.Text) & " " & Button2.Text)
        cost = Val(TextBox2.Text) * fd2
        lbcost.Items.Add(cost)
        total = total + cost
        txttotal.Text = total
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lbfood.Items.Add(Val(TextBox3.Text) & " " & Button3.Text)
        cost = Val(TextBox3.Text) * fd3
        lbcost.Items.Add(cost)
        total = total + cost
        txttotal.Text = total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lbfood.Items.Add(Val(TextBox4.Text) & " " & Button4.Text)
        cost = Val(TextBox4.Text) * fd4
        lbcost.Items.Add(cost)
        total = total + cost
        txttotal.Text = total
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lbfood.Items.Add(Val(TextBox5.Text) & " " & Button5.Text)
        cost = Val(TextBox5.Text) * fd5
        lbcost.Items.Add(cost)
        total = total + cost
        txttotal.Text = total
    End Sub


End Class
