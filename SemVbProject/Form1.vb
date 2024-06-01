Imports MySqlConnector
Imports System.IO

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=semvb")
    Dim dr As MySqlDataReader
    Private loggedInUsername As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usercomboload()
        ' Add KeyDown event handlers
        AddHandler Me.KeyDown, AddressOf Form1_KeyDown
        AddHandler combo_username.KeyDown, AddressOf Form1_KeyDown
        AddHandler log_password.KeyDown, AddressOf Form1_KeyDown
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        pn_login.Visible = False
        Guna2Transition1.HideSync(pn_login)
    End Sub

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click
        pn_login.Visible = True
        Guna2Transition1.ShowSync(pn_login) ' Use ShowSync to make the control visible with a transition
    End Sub

    Sub usercomboload()
        conn.Open()
        combo_username.Items.Clear()
        Dim cmd As New MySqlCommand("SELECT * FROM login", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            combo_username.Items.Add(dr.GetString("username"))
        End While
        dr.Close()
        conn.Close()
    End Sub

    Private Sub Guna2ToggleSwitch2_CheckedChanged(sender As Object, e As EventArgs) Handles show_pass.CheckedChanged
        log_password.UseSystemPasswordChar = Not show_pass.Checked
        log_password.PasswordChar = If(show_pass.Checked, ControlChars.NullChar, "*"c)
    End Sub

    Private Sub Btn_browse_Click(sender As Object, e As EventArgs) Handles Btn_browse.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog() <> DialogResult.Cancel Then
            user_picture.Image = Image.FromFile(pop.FileName)
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = ""
        Dim password As String = ""
        Dim role As String = ""
        Dim employeeId As Integer

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM login WHERE username=@username AND password=@password", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", combo_username.Text)
            cmd.Parameters.AddWithValue("@password", log_password.Text)

            dr = cmd.ExecuteReader
            If (dr.Read() = True) Then
                username = dr.GetString(dr.GetOrdinal("username"))
                password = dr.GetString(dr.GetOrdinal("password"))
                role = dr.GetString(dr.GetOrdinal("role"))
                MsgBox("Login Successful!", vbInformation)

                ' Retrieve employeeID if the user is a Mechanic
                If role = "Mechanic" Then
                    dr.Close() ' Close the previous reader before executing a new command
                    Dim employeeCmd As New MySqlCommand("SELECT employeeID FROM employee WHERE username = @username", conn)
                    employeeCmd.Parameters.AddWithValue("@username", username)
                    dr = employeeCmd.ExecuteReader()
                    If dr.Read() Then
                        employeeId = dr.GetInt32(dr.GetOrdinal("employeeID"))
                    End If
                End If
            Else
                MsgBox("Invalid username or password!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        If username = "admin" AndAlso password = "admin" Then
            ' Admin login successful
            MsgBox("Admin Login Successful!", MsgBoxStyle.Information)
            ' Open Admin Dashboard Form
            Dim adminDashboardForm As New adminDashboard()
            adminDashboardForm.Show()
            Me.Hide()
        ElseIf role = "Mechanic" Then
            'Mechanic login successful
            MsgBox("Mechanic Login Successful!", MsgBoxStyle.Information)
            ' Open Mechanic Page Form and pass employeeId
            Dim mechanicPageForm As New Mechanic_Form(username, employeeId)
            mechanicPageForm.Show()
            Me.Hide()
        ElseIf role = "Customer" Then
            ' Set loggedInUsername when role is "Customer"
            loggedInUsername = username
            ' Open Customer Form and pass username
            Dim customerPageForm As New Customer_form(loggedInUsername)
            customerPageForm.Show()
            Me.Hide()
        Else

            ' Perform regular user authentication
            ' ...
        End If
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        save()
        usercomboload()
    End Sub

    Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `login` (`firstname`, `lastname`, `username`, `password`, `dob`, `role`, `pic`) VALUES (@firstname, @lastname, @username, @password, @dob, @role, @pic)", conn)
            cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@dob", CDate(dob_picker.Text))
            cmd.Parameters.AddWithValue("@role", combo_role.Text)

            ' Save user's profile picture
            Dim mstream As New MemoryStream()
            user_picture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.ToArray()
            cmd.Parameters.AddWithValue("@pic", picture)

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("New user registered successfully!", vbInformation)

                If combo_role.Text = "Mechanic" Then
                    Dim insertEmployeeCmd As New MySqlCommand("INSERT INTO `employee` (`esurname`, `efirstname`, `gender`, `address`, `telephone`, `dateofbirth`, `basesalary`, `username`, `pic`) VALUES (@esurname, @efirstname, @gender, @address, @telephone, @dateofbirth, @basesalary, @username, @pic)", conn)
                    insertEmployeeCmd.Parameters.AddWithValue("@esurname", txt_lastname.Text)
                    insertEmployeeCmd.Parameters.AddWithValue("@efirstname", txt_firstname.Text)
                    insertEmployeeCmd.Parameters.AddWithValue("@gender", combo_gender.Text)
                    insertEmployeeCmd.Parameters.AddWithValue("@address", txt_address.Text)
                    insertEmployeeCmd.Parameters.AddWithValue("@telephone", txt_telephone.Text)
                    insertEmployeeCmd.Parameters.AddWithValue("@dateofbirth", CDate(dob_picker.Text))
                    insertEmployeeCmd.Parameters.AddWithValue("@basesalary", 0)
                    insertEmployeeCmd.Parameters.AddWithValue("@username", txt_username.Text)
                    insertEmployeeCmd.Parameters.AddWithValue("@pic", picture)

                    Dim j As Integer = insertEmployeeCmd.ExecuteNonQuery()
                    If j > 0 Then
                        MsgBox("Employee data inserted successfully!", vbInformation)
                    Else
                        MsgBox("Failed to insert employee data!", vbCritical)
                    End If
                ElseIf combo_role.Text = "Customer" Then
                    Dim insertCustomerCmd As New MySqlCommand("INSERT INTO `customer` (`csurname`, `cfirstname`, `username`, `address`, `telephoneno`, `pic`) VALUES (@csurname, @cfirstname, @username, @address, @telephoneno, @pic)", conn)
                    insertCustomerCmd.Parameters.AddWithValue("@csurname", txt_lastname.Text)
                    insertCustomerCmd.Parameters.AddWithValue("@cfirstname", txt_firstname.Text)
                    insertCustomerCmd.Parameters.AddWithValue("@username", txt_username.Text) ' Include username
                    insertCustomerCmd.Parameters.AddWithValue("@address", txt_address.Text)
                    insertCustomerCmd.Parameters.AddWithValue("@telephoneno", txt_telephone.Text)
                    insertCustomerCmd.Parameters.AddWithValue("@pic", picture)

                    Dim k As Integer = insertCustomerCmd.ExecuteNonQuery()
                    If k > 0 Then
                        MsgBox("Customer data inserted successfully!", vbInformation)
                    Else
                        MsgBox("Failed to insert customer data!", vbCritical)
                    End If
                End If
            Else
                MsgBox("New user registration failed!", vbCritical)
            End If

            txt_firstname.Clear()
            txt_lastname.Clear()
            txt_username.Clear()
            txt_password.Clear()
            combo_role.SelectedIndex = -1
            combo_gender.SelectedIndex = -1
            txt_address.Clear()
            txt_telephone.Clear()
            user_picture.Image = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
