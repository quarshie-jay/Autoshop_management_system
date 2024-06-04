Imports MySqlConnector
Imports System.IO

Public Class Customer_form
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=semvb")
    Dim loggedInUsername As String

    Public Sub New(ByVal username As String)
        InitializeComponent()
        loggedInUsername = username
    End Sub

    Private Sub btn_proceed_Click(sender As Object, e As EventArgs) Handles btn_proceed.Click
        ' Display the selected services and total bill
        DisplaySelectedServicesAndTotalBill()
    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click
        ' Calculate the total bill based on the selected services
        Dim totalBill As Decimal = CalculateTotalBill()

        ' Insert data into the database and update visit count
        Try
            conn.Open()
            Dim transaction = conn.BeginTransaction()

            ' Insert service details
            Dim cmd As New MySqlCommand("INSERT INTO service (customer_username, service_date, oil_change, battery_service, general_service, tyre_service, engine_service, body_works, total_bill) VALUES (@username, @date, @oil, @battery, @general, @tyre, @engine, @body, @bill)", conn)
            cmd.Parameters.AddWithValue("@username", loggedInUsername)
            cmd.Parameters.AddWithValue("@date", date_picker.Value)
            cmd.Parameters.AddWithValue("@oil", chk_oil.Checked)
            cmd.Parameters.AddWithValue("@battery", chk_battery.Checked)
            cmd.Parameters.AddWithValue("@general", chk_general.Checked)
            cmd.Parameters.AddWithValue("@tyre", chk_tyre.Checked)
            cmd.Parameters.AddWithValue("@engine", chk_engine.Checked)
            cmd.Parameters.AddWithValue("@body", chk_body.Checked)
            cmd.Parameters.AddWithValue("@bill", totalBill)
            cmd.Transaction = transaction
            cmd.ExecuteNonQuery()

            ' Update visit count
            Dim updateVisitCmd As New MySqlCommand("UPDATE customer SET visit_count = visit_count + 1 WHERE username = @username", conn)
            updateVisitCmd.Parameters.AddWithValue("@username", loggedInUsername)
            updateVisitCmd.Transaction = transaction
            updateVisitCmd.ExecuteNonQuery()

            transaction.Commit()
            MsgBox("Service details saved successfully!", vbInformation)
        Catch ex As Exception
            MsgBox("Error saving service details: " & ex.Message, vbCritical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function CalculateTotalBill() As Decimal

        Dim totalBill As Decimal = 0
        If chk_oil.Checked Then
            totalBill += 150
        End If
        If chk_battery.Checked Then
            totalBill += 70
        End If
        If chk_general.Checked Then
            totalBill += 1000
        End If
        If chk_tyre.Checked Then
            totalBill += 50
        End If
        If chk_engine.Checked Then
            totalBill += 250
        End If
        If chk_body.Checked Then
            totalBill += 400
        End If
        Return totalBill
    End Function

    Private Sub DisplaySelectedServicesAndTotalBill()
        ' Set the text of the labels based on the selected services
        lbl_oil.Text = If(chk_oil.Checked, "Oil Change: $150", "")
        lbl_battery.Text = If(chk_battery.Checked, "Battery Service: $70", "")
        lbl_general.Text = If(chk_general.Checked, "General Service: $1000", "")
        lbl_tyre.Text = If(chk_tyre.Checked, "Tyre Service: $50", "")
        lbl_engine.Text = If(chk_engine.Checked, "Engine Service: $250", "")
        lbl_body.Text = If(chk_body.Checked, "Body Works: $400", "")

        ' Display the total bill in the lbl_total
        Dim totalBill As Decimal = CalculateTotalBill()
        lbl_total.Text = "Total Bill: $" & totalBill.ToString("F2")
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim loginForm As New Form1()
        loginForm.Show()

        ' Hide the current form
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Create an instance of the Shop form and pass the customer's name and the current form as the previous form
        Dim shopForm As New Shop(loggedInUsername, Me)

        ' Show the shop form
        shopForm.Show()

        ' Hide the current form
        Me.Hide()
    End Sub
End Class
