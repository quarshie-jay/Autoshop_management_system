Imports MySqlConnector

Public Class Shop
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=semvb")

    Dim loggedInUsername As String
    Dim previousForm As Form

    ' Constructor that accepts the customer's name
    Public Sub New(ByVal username As String)
        InitializeComponent()
        loggedInUsername = username
    End Sub


    Public Sub New(ByVal username As String, ByVal previousFormInstance As Form)
        InitializeComponent()
        loggedInUsername = username
        previousForm = previousFormInstance
    End Sub

    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the Product Name and Cost columns to the DataGridView if they don't already exist

        If dgvCart.Columns.Count = 0 Then
            Dim dgvColumnProductName As New DataGridViewTextBoxColumn()
            dgvColumnProductName.HeaderText = "Product Name"
            dgvCart.Columns.Add(dgvColumnProductName)

            Dim dgvColumnCost As New DataGridViewTextBoxColumn()
            dgvColumnCost.HeaderText = "Cost"
            dgvCart.Columns.Add(dgvColumnCost)
        End If


        ' Populate combo boxes on form load
        PopulateComboBox("Tools & Equipment", cboTools)
        PopulateComboBox("Automotive Parts", cboAutomotive)
        PopulateComboBox("Car Care Products", cboCarCare)
        PopulateComboBox("Accessories", cboAccessories)
        PopulateComboBox("Safety Equipment", cboSafety)


        lbl_name.Text = "WELCOME BACK " & loggedInUsername & " !"
    End Sub

    Private Sub PopulateComboBox(category As String, comboBox As ComboBox)
        Try
            conn.Open()

            ' SQL query to fetch product names based on category
            Dim query As String = "SELECT productName FROM commproduct WHERE category = @category"
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@category", category)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing items
                    comboBox.Items.Clear()
                    ' Populate combo box with product names
                    While reader.Read()
                        comboBox.Items.Add(reader("productName").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        ' Get the selected item from each combo box
        Dim selectedTool As String = cboTools.SelectedItem?.ToString()
        Dim selectedAutomotive As String = cboAutomotive.SelectedItem?.ToString()
        Dim selectedCarCare As String = cboCarCare.SelectedItem?.ToString()
        Dim selectedAccessories As String = cboAccessories.SelectedItem?.ToString()
        Dim selectedSafety As String = cboSafety.SelectedItem?.ToString()

        ' Add selected items to the DataGridView if they are not Nothing
        If selectedTool IsNot Nothing Then
            AddProductToCart(selectedTool)
        End If
        If selectedAutomotive IsNot Nothing Then
            AddProductToCart(selectedAutomotive)
        End If
        If selectedCarCare IsNot Nothing Then
            AddProductToCart(selectedCarCare)
        End If
        If selectedAccessories IsNot Nothing Then
            AddProductToCart(selectedAccessories)
        End If
        If selectedSafety IsNot Nothing Then
            AddProductToCart(selectedSafety)
        End If

        ' Reset the combo boxes to their initial state
        ResetComboBox(cboTools)
        ResetComboBox(cboAutomotive)
        ResetComboBox(cboCarCare)
        ResetComboBox(cboAccessories)
        ResetComboBox(cboSafety)
    End Sub

    Private Sub AddProductToCart(productName As String)
        Try
            conn.Open()

            ' SQL query to fetch product cost based on product name
            Dim query As String = "SELECT cost FROM commproduct WHERE productName = @productName"
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@productName", productName)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim cost As Decimal = reader("cost")
                        dgvCart.Rows.Add(productName, cost)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ResetComboBox(comboBox As ComboBox)
        comboBox.SelectedIndex = -1
    End Sub

    Private Sub btnRemoveFromCart_Click(sender As Object, e As EventArgs) Handles btnRemoveFromCart.Click
        ' Check if a row is selected in the DataGridView
        If dgvCart.SelectedRows.Count > 0 Then
            ' Remove the selected row
            For Each row As DataGridViewRow In dgvCart.SelectedRows
                dgvCart.Rows.Remove(row)
            Next
        Else
            MessageBox.Show("Please select a row to remove.")
        End If
    End Sub

    Private Sub btnProceedToCheckout_Click(sender As Object, e As EventArgs) Handles btnProceedToCheckout.Click
        Dim totalCost As Decimal = 0
        Dim costColumnIndex As Integer = -1
        Dim productNameColumnIndex As Integer = -1
        Dim products As New List(Of Dictionary(Of String, Object))()

        ' Find the index of the column named "Cost"
        For Each column As DataGridViewColumn In dgvCart.Columns
            If column.HeaderText = "Cost" Then
                costColumnIndex = column.Index
            ElseIf column.HeaderText = "Product Name" Then
                productNameColumnIndex = column.Index
            End If
        Next

        ' Check if both columns are found
        If costColumnIndex = -1 OrElse productNameColumnIndex = -1 Then
            MessageBox.Show("One or both columns named 'Cost' and 'Product Name' cannot be found.")
            Return
        End If

        ' Sum up the costs and gather product details
        For Each row As DataGridViewRow In dgvCart.Rows
            ' Check if the row is not a new row and if the cost column is not null
            If Not row.IsNewRow AndAlso row.Cells.Count > costColumnIndex AndAlso row.Cells(costColumnIndex).Value IsNot Nothing Then
                Dim productName As String = row.Cells(productNameColumnIndex).Value.ToString()
                Dim cellValue As String = row.Cells(costColumnIndex).Value.ToString()
                Dim cost As Decimal
                If Decimal.TryParse(cellValue, cost) Then
                    totalCost += cost
                    ' Add product details to the list
                    products.Add(New Dictionary(Of String, Object) From {
                    {"productName", productName},
                    {"cost", cost}
                })
                End If
            End If
        Next

        ' Display the total cost in the lblTotal label
        lblTotal.Text = "Total Cost: $" & totalCost.ToString()

        ' Convert products list to JSON
        Dim productsJson As String = Newtonsoft.Json.JsonConvert.SerializeObject(products)

        ' Insert order into the database
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO orders (customer_username, order_date, products, total_cost) VALUES (@username, @date, @products, @totalCost)", conn)
            cmd.Parameters.AddWithValue("@username", loggedInUsername)
            cmd.Parameters.AddWithValue("@date", DateTime.Now)
            cmd.Parameters.AddWithValue("@products", productsJson)
            cmd.Parameters.AddWithValue("@totalCost", totalCost)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error placing order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        previousForm.Show()
    End Sub

End Class
