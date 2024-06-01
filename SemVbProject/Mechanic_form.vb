Imports MySqlConnector
Imports System.IO

Public Class Mechanic_Form
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=semvb")
    Private username As String
    Private employeeId As Integer

    Public Sub New(ByVal user As String, ByVal empId As Integer)
        InitializeComponent()
        username = user
        employeeId = empId
    End Sub

    Private Sub MechanicPageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMechanicData()
        LoadClockRecords()
        UpdateWorkHours() ' Update the total work hours on form load
    End Sub

    Private Sub LoadMechanicData()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT employeeID, efirstname, esurname, pic FROM employee WHERE username = @username", conn)
            cmd.Parameters.AddWithValue("@username", username)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                employeeId = reader("employeeID")
                lbl_name.Text = $"{reader("efirstname")} {reader("esurname")}"
                Dim picture() As Byte = CType(reader("pic"), Byte())
                If picture IsNot Nothing Then
                    Dim mstream As New MemoryStream(picture)
                    Guna2PictureBox1.Image = Image.FromStream(mstream)
                End If
            Else
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading mechanic data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub LoadClockRecords()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT clockin_time, clockout_time FROM employee_clockin WHERE employeeID = @employee_id", conn)
            cmd.Parameters.AddWithValue("@employee_id", employeeId)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvClockRecords.DataSource = table
            dgvClockRecords.Columns("clockin_time").HeaderText = "Clock In Time"
            dgvClockRecords.Columns("clockout_time").HeaderText = "Clock Out Time"
        Catch ex As Exception
            MessageBox.Show("Error loading clock records: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub UpdateWorkHours()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT SUM(work_hours) FROM employee_clockin WHERE employeeID = @employee_id", conn)
            cmd.Parameters.AddWithValue("@employee_id", employeeId)
            Dim totalHours As Object = cmd.ExecuteScalar()

            If totalHours IsNot DBNull.Value Then
                lbl_hours.Text = $"{Convert.ToDecimal(totalHours):F2}"
            Else
                lbl_hours.Text = " 0.00"
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating work hours: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        Dim loginForm As New Form1()
        loginForm.Show()
    End Sub

    Private Sub btn_clockin_Click(sender As Object, e As EventArgs) Handles btn_clockin.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO employee_clockin (employeeID, clockin_time, date, status) VALUES (@employeeID, @clockin_time, @date, 'pending')", conn)
            cmd.Parameters.AddWithValue("@employeeID", employeeId)
            cmd.Parameters.AddWithValue("@clockin_time", DateTime.Now)
            cmd.Parameters.AddWithValue("@date", DateTime.Now.Date)
            cmd.ExecuteNonQuery()

            ' Update employee status to 'available'
            UpdateEmployeeStatus("available")

            MessageBox.Show("Clock-in recorded successfully!")
            LoadClockRecords() ' Refresh the DataGridView
            UpdateWorkHours() ' Update the total work hours
        Catch ex As Exception
            MessageBox.Show("Error recording clock-in: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_clockout_Click(sender As Object, e As EventArgs) Handles btn_clockout.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE employee_clockin SET clockout_time = @clockout_time, work_hours = TIMESTAMPDIFF(SECOND, clockin_time, @clockout_time) / 3600, status = 'completed' WHERE employeeID = @employee_id AND date = @date AND clockout_time IS NULL", conn)
            cmd.Parameters.AddWithValue("@employee_id", employeeId)
            cmd.Parameters.AddWithValue("@clockout_time", DateTime.Now)
            cmd.Parameters.AddWithValue("@date", DateTime.Now.Date)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                ' Update employee status to 'unavailable'
                UpdateEmployeeStatus("unavailable")

                MessageBox.Show("Clock-out recorded successfully!")
                LoadClockRecords() ' Refresh the DataGridView
                UpdateWorkHours() ' Update the total work hours
            Else
                MessageBox.Show("Error: No matching clock-in record found for today.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error recording clock-out: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub UpdateEmployeeStatus(status As String)
        Dim cmd As New MySqlCommand("UPDATE employee SET status = @status WHERE employeeID = @employee_id", conn)
        cmd.Parameters.AddWithValue("@status", status)
        cmd.Parameters.AddWithValue("@employee_id", employeeId)
        cmd.ExecuteNonQuery()
    End Sub

End Class
