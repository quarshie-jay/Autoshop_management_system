Imports MySqlConnector

Public Class Work_Tracking
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=semvb")

    Private Sub Work_Tracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the counts of services and customers when the form loads
        UpdateCounts()
    End Sub

    Private Sub UpdateCounts()
        Try
            ' Open the connection
            conn.Open()

            ' Get the count of services
            Dim serviceCountCmd As New MySqlCommand("SELECT COUNT(*) FROM service", conn)
            Dim serviceCount As Integer = Convert.ToInt32(serviceCountCmd.ExecuteScalar())
            lbl_pending.Text = serviceCount.ToString()

            ' Get the count of customers
            Dim customerCountCmd As New MySqlCommand("SELECT COUNT(*) FROM customer", conn)
            Dim customerCount As Integer = Convert.ToInt32(customerCountCmd.ExecuteScalar())
            lbl_numClient.Text = customerCount.ToString()


            Dim empcountcmd As New MySqlCommand("SELECT COUNT(*) FROM employee", conn)
            Dim empcount As Integer = Convert.ToInt32(empcountcmd.ExecuteScalar())
            lbl_mech.Text = empcount.ToString()

            ' Get the count of available workers
            Dim availableWorkersCmd As New MySqlCommand("SELECT COUNT(*) FROM employee WHERE status = 'available'", conn)
            Dim availableWorkersCount As Integer = Convert.ToInt32(availableWorkersCmd.ExecuteScalar())
            lbl_numEmp.Text = availableWorkersCount.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

End Class
