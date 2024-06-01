Public Class adminDashboard
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Sub childform(ByVal panel As Form)
        admin_panel.Controls.Clear()
        panel.TopLevel = False
        admin_panel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        childform(Employee_info)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btn_client.Click
        childform(Customer_info)
    End Sub

    Private Sub btn_objectives_Click(sender As Object, e As EventArgs) Handles btn_objectives.Click
        childform(Work_Tracking)
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
        Dim loginForm As New Form1()
        loginForm.Show()
    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        childform(report)
    End Sub
End Class