Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class report
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=semvb")

    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the data and calculate salaries
        CalculateAndDisplaySalaries()
        CalculateAndDisplayDiscounts()
    End Sub

    Private Function CalculateSalary(ByVal totalWorkHours As Integer) As Decimal
        ' Base salary
        Dim baseSalary As Decimal = 500

        ' Check if total work hours exceed 45 hours in a week
        If totalWorkHours > 45 Then
            ' Increase base salary by 20%
            baseSalary += (baseSalary * 0.2)
        End If

        ' Return the calculated salary
        Return baseSalary
    End Function

    Private Sub CalculateAndDisplaySalaries()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Username", GetType(String))
        dataTable.Columns.Add("Surname", GetType(String))
        dataTable.Columns.Add("TotalWorkHours", GetType(Integer))
        dataTable.Columns.Add("BaseSalary", GetType(Decimal))
        dataTable.Columns.Add("CalculatedSalary", GetType(Decimal))

        Try
            conn.Open()

            ' Fetch the employee username, surname, and total work hours for the current week
            Dim query As String = "SELECT e.username, e.esurname, SUM(ec.work_hours) AS totalWorkHours
                                   FROM employee e
                                   INNER JOIN employee_clockin ec ON e.employeeID = ec.employeeID
                                   WHERE WEEK(ec.date) = WEEK(NOW())
                                   GROUP BY e.username, e.esurname"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim username As String = reader.GetString("username")
                Dim surname As String = reader.GetString("esurname")
                Dim totalWorkHours As Integer = reader.GetInt32("totalWorkHours")

                ' Calculate the base salary
                Dim baseSalary As Decimal = If(totalWorkHours < 40, 500, CalculateSalary(totalWorkHours))

                ' Add the data to the DataTable
                dataTable.Rows.Add(username, surname, totalWorkHours, baseSalary, baseSalary)
            End While

            ' Bind the DataTable to the DataGridView or any other control for display
            ' For example:
            data1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error calculating and displaying salaries: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub data1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Function CalculateDiscount(ByVal visitCount As Integer, ByVal totalBill As Decimal) As Decimal
        Dim discountPercentage As Decimal = 0

        ' Check if the visit count is greater than 10
        If visitCount > 10 Then
            ' Apply a 10% discount
            discountPercentage = 0.1
        End If

        ' Calculate the discount amount
        Dim discountAmount As Decimal = totalBill * discountPercentage

        ' Return the discount amount
        Return discountAmount
    End Function

    Private Sub CalculateAndDisplayDiscounts()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("CustomerID", GetType(Integer))
        dataTable.Columns.Add("Firstname", GetType(String))
        dataTable.Columns.Add("Surname", GetType(String))
        dataTable.Columns.Add("VisitCount", GetType(Integer))
        dataTable.Columns.Add("TotalBill", GetType(Decimal))
        dataTable.Columns.Add("Discount", GetType(Decimal))
        dataTable.Columns.Add("AmountToPay", GetType(Decimal))

        Try
            conn.Open()

            ' Fetch customer information and total bill from the service table
            Dim query As String = "SELECT c.customerID, c.cfirstname, c.csurname, c.visit_count, s.total_bill
                               FROM customer c
                               INNER JOIN service s ON c.username = s.customer_username"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim customerID As Integer = reader.GetInt32("customerID")
                Dim firstname As String = reader.GetString("cfirstname")
                Dim surname As String = reader.GetString("csurname")
                Dim visitCount As Integer = reader.GetInt32("visit_count")
                Dim totalBill As Decimal = reader.GetDecimal("total_bill")

                ' Calculate the discount for the customer
                Dim discount As Decimal = CalculateDiscount(visitCount, totalBill)

                ' Calculate the amount to pay after applying the discount
                Dim amountToPay As Decimal = totalBill - discount

                ' Add the data to the DataTable
                dataTable.Rows.Add(customerID, firstname, surname, visitCount, totalBill, discount, amountToPay)
            End While

            ' Bind the DataTable to the DataGridView
            ' For example:
            data2.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error calculating and displaying discounts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
