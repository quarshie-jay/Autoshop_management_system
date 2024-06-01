Imports MySqlConnector
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Employee_info

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=semvb")

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        Dim searchValue As String = txt_search.Text.Trim()
        If String.IsNullOrEmpty(searchValue) Then
            MessageBox.Show("Please enter a surname or username to search.")
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM employee WHERE esurname = @searchValue OR username = @searchValue"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchValue", searchValue)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        lbl_id.Text = reader("employeeID").ToString()
                        txt_surname.Text = reader("esurname").ToString()
                        txt_firstname.Text = reader("efirstname").ToString()
                        lbl_username.Text = reader("username").ToString()
                        txt_username.Text = reader("username").ToString()
                        cbo_gender.Text = reader("gender").ToString()
                        txt_address.Text = reader("address").ToString()
                        lbl_telephone.Text = reader("telephone").ToString()
                        txt_telephone.Text = reader("telephone").ToString()

                        ' Retrieve the picture data from the database
                        Dim picData As Byte() = CType(reader("pic"), Byte())
                        If picData IsNot Nothing AndAlso picData.Length > 0 Then
                            Using ms As New MemoryStream(picData)
                                user_pic.Image = Image.FromStream(ms)
                            End Using
                        Else
                            user_pic.Image = Nothing ' Or set a default image
                        End If

                    Else
                        MessageBox.Show("Employee not found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            conn.Open()
            Dim query As String = "UPDATE employee SET esurname = @surname, efirstname = @firstname, gender = @gender, address = @address, telephone = @telephone WHERE username = @username"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@surname", txt_surname.Text.Trim())
                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim())
                cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim())
                cmd.Parameters.AddWithValue("@gender", cbo_gender.Text.Trim())
                cmd.Parameters.AddWithValue("@address", txt_address.Text.Trim())
                cmd.Parameters.AddWithValue("@telephone", txt_telephone.Text.Trim())

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Record saved successfully", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record save failed!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim username As String = txt_username.Text.Trim()
        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please search for an employee to delete first.")
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "DELETE FROM employee WHERE username = @username"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Employee deleted successfully", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear the form fields after deletion
                    lbl_id.Text = ""
                    txt_surname.Clear()
                    txt_firstname.Clear()
                    lbl_username.Text = ""
                    txt_username.Clear()
                    cbo_gender.SelectedIndex = -1
                    txt_address.Clear()
                    lbl_telephone.Text = ""
                    txt_telephone.Clear()
                    user_pic.Image = Nothing
                Else
                    MessageBox.Show("Delete operation failed!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadEmployeeData()
        Try
            conn.Open()
            Dim query As String = "SELECT employeeID, esurname, efirstname, username, gender, address, telephone FROM employee"
            Using adapter As New MySqlDataAdapter(query, conn)
                Dim employeeTable As New DataTable()
                adapter.Fill(employeeTable)
                data_grid.DataSource = employeeTable

                ' Set column headers to uppercase
                For Each column As DataGridViewColumn In data_grid.Columns
                    column.HeaderText = column.HeaderText.ToUpper()
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading employee data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Employee_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load employee data when the form loads
        LoadEmployeeData()
    End Sub

End Class
