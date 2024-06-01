Imports MySqlConnector
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Customer_info

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=semvb")

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        Dim searchValue As String = txt_search.Text.Trim()
        If String.IsNullOrEmpty(searchValue) Then
            MessageBox.Show("Please enter a surname or username to search.")
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM customer WHERE csurname = @searchValue OR cfirstname = @searchValue"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchValue", searchValue)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        lbl_id.Text = reader("customerID").ToString()
                        txt_surname.Text = reader("csurname").ToString()
                        txt_firstname.Text = reader("cfirstname").ToString()
                        txt_address.Text = reader("address").ToString()
                        lbl_telephone.Text = reader("telephoneNo").ToString()
                        txt_telephone.Text = reader("telephoneNo").ToString()

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
                        MessageBox.Show("Customer not found.")
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
            Dim query As String = "UPDATE customer SET csurname = @surname, cfirstname = @firstname, address = @address, telephoneNo = @telephone WHERE customerID = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@surname", txt_surname.Text.Trim())
                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim())
                cmd.Parameters.AddWithValue("@address", txt_address.Text.Trim())
                cmd.Parameters.AddWithValue("@telephone", txt_telephone.Text.Trim())
                cmd.Parameters.AddWithValue("@id", lbl_id.Text.Trim())

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Record saved successfully", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh DataGridView and clear labels
                    LoadCustomerData()
                    ClearCustomerDetails()
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

    Private Sub ClearCustomerDetails()
        lbl_id.Text = ""
        txt_surname.Clear()
        txt_firstname.Clear()
        txt_address.Clear()
        lbl_telephone.Text = ""
        txt_telephone.Clear()
        'user_pic.Image = Nothing
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As String = lbl_id.Text.Trim()
        If String.IsNullOrEmpty(id) Then
            MessageBox.Show("Please search for a customer to delete first.")
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "DELETE FROM customer WHERE customerID = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Customer deleted successfully", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear the form fields after deletion
                    lbl_id.Text = ""
                    txt_surname.Clear()
                    txt_firstname.Clear()
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

    Private Sub LoadCustomerData()
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "SELECT customerID, csurname, cfirstname, address, telephoneNo FROM customer"
            Using adapter As New MySqlDataAdapter(query, conn)
                Dim customerTable As New DataTable()
                adapter.Fill(customerTable)
                data_grid.DataSource = customerTable

                ' Set column headers to uppercase
                For Each column As DataGridViewColumn In data_grid.Columns
                    column.HeaderText = column.HeaderText.ToUpper()
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading customer data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub Customer_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load customer data when the form loads
        LoadCustomerData()
    End Sub

End Class
