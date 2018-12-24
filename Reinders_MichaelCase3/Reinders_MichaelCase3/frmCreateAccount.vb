Public Class frmCreateAccount

    Public currentCustomer As Customer
    Public currentChecking As CheckingAccount
    Public currentSavings As SavingsAccount
    Public currentCreditCardAccount As CreditCardAccount

    'UI Appearance
    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlNewCustomerName.Hide()
        pnlExistingCustomer.Hide()
        pnlCSAcctCreate.Hide()
        btnCreateAccount.Hide()
        pnlCreditInfo.Hide()
        pnlAccountType.Enabled = False
    End Sub

    Private Sub rbNewCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles rbNewCustomer.CheckedChanged
        pnlExistingCustomer.Hide()
        pnlNewCustomerName.Show()
        pnlAccountType.Enabled = False
        btnCreateAccount.Enabled = False
    End Sub

    Private Sub rbExistingCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles rbExistingCustomer.CheckedChanged
        lstExistingCustomers.Items.Clear()
        pnlExistingCustomer.Show()
        pnlNewCustomerName.Hide()
        pnlAccountType.Enabled = False
        btnCreateAccount.Enabled = True
        'populate list of customers 
        Dim i As Integer
        Dim c As List(Of Customer) = Customers.CustomerList
        For i = 0 To Customers.CustomerList.Count - 1
            lstExistingCustomers.Items.Add((Customers.CustomerList(i).CurrentCustomerID) & " (" & (Customers.CustomerList(i).CustomerFirstName) & " " & (Customers.CustomerList(i).CustomerLastName) & ")")
        Next i
    End Sub

    Private Sub rbChecking_CheckedChanged(sender As Object, e As EventArgs) Handles rbChecking.CheckedChanged
        pnlCreditInfo.Hide()
        pnlCSAcctCreate.Show()
        btnCreateAccount.Show()
        txtCSAcctNumber.Clear()
        txtIntlCashDeposit.Clear()
    End Sub

    Private Sub rbSavings_CheckedChanged(sender As Object, e As EventArgs) Handles rbSavings.CheckedChanged
        pnlCreditInfo.Hide()
        pnlCSAcctCreate.Show()
        btnCreateAccount.Show()
        txtCSAcctNumber.Clear()
        txtIntlCashDeposit.Clear()
    End Sub

    Private Sub rbCredit_CheckedChanged(sender As Object, e As EventArgs) Handles rbCredit.CheckedChanged
        pnlCSAcctCreate.Hide()
        pnlCreditInfo.Show()
        btnCreateAccount.Show()
        txtCreditAcctNumber.Clear()
        txtIntlCredit.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '******************************Create Accounts**********************
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If rbNewCustomer.Checked = True Then
            Dim firstName As String = txtNewCustomerFirst.Text
            Dim lastName As String = txtNewCustomerLast.Text
            Dim CustomerID As Integer = txtCustomerID.Text

            If rbChecking.Checked = True Then
                currentChecking = currentCustomer.CheckingAccountsCurrent.CreateCheckingAccount(Convert.ToInt32(txtCSAcctNumber.Text), Convert.ToDouble(txtIntlCashDeposit.Text))

                MessageBox.Show("The Checking account (" + txtCSAcctNumber.Text & ") was created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf rbSavings.Checked = True Then
                currentSavings = currentCustomer.SavingsAccountsCurrent.CreateSavingsAccount(Convert.ToInt32(txtCSAcctNumber.Text), Convert.ToDouble(txtIntlCashDeposit.Text))

                MessageBox.Show("The Savings account (" + txtCSAcctNumber.Text & ") was created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            ElseIf rbCredit.Checked = True Then
                currentCreditCardAccount = currentCustomer.CreditCardAccountsCurrent.CreateCreditCardAccount(Convert.ToInt32(txtCreditAcctNumber.Text), Convert.ToDouble(txtIntlCredit.Text))

                MessageBox.Show("The Credit Card account (" + txtCreditAcctNumber.Text & ") was created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Please select which account to create and fill out the information fields", "Please select an account type", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf rbExistingCustomer.Checked = True Then
            If rbChecking.Checked = True Then
                currentChecking = currentCustomer.CheckingAccountsCurrent.CreateCheckingAccount(Convert.ToInt32(txtCSAcctNumber.Text), Convert.ToDouble(txtIntlCashDeposit.Text))

                MessageBox.Show("The Checking account (" + txtCSAcctNumber.Text & ") was created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf rbSavings.Checked = True Then
                currentSavings = currentCustomer.SavingsAccountsCurrent.CreateSavingsAccount(Convert.ToInt32(txtCSAcctNumber.Text), Convert.ToDouble(txtIntlCashDeposit.Text))

                MessageBox.Show("The Savings account (" + txtCSAcctNumber.Text & ") was created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            ElseIf rbCredit.Checked = True Then
                currentCreditCardAccount = currentCustomer.CreditCardAccountsCurrent.CreateCreditCardAccount(Convert.ToInt32(txtCreditAcctNumber.Text), Convert.ToDouble(txtIntlCredit.Text))

                MessageBox.Show("The Credit Card account (" + txtCreditAcctNumber.Text & ") was created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Please select which account to create and fill out the information fields", "Please select an account type", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

            MessageBox.Show("Please select either 'New Customer' or 'Existing Customer'", "Invalid customer designation",
                     MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Close()
    End Sub

    Public firstName As String
    Public lastName As String
    Public CustomerID As Integer

    Private Sub btnCreateCustomer_Click(sender As Object, e As EventArgs) Handles btnCreateCustomer.Click
        firstName = txtNewCustomerFirst.Text
        lastName = txtNewCustomerLast.Text
        CustomerID = txtCustomerID.Text
        currentCustomer = New Customer(CustomerID, firstName, lastName)
        Customers.CustomerList.Add(currentCustomer)
        'display that the customer was created 
        MessageBox.Show("Account creation was successful", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'dsiable controls to continue
        pnlNewCustomerName.Enabled = False
        rbNewCustomer.Enabled = False
        rbExistingCustomer.Enabled = False
        pnlAccountType.Enabled = True
        btnCreateAccount.Enabled = true 
    End Sub

    Private Sub txtCustomerID_Leave(sender As Object, e As EventArgs) Handles txtCustomerID.Leave
        Dim id As Integer = Convert.ToInt32(txtCustomerID.Text)
        If ValidateNumbers.IsCustomerIDNumber(id) = False Then
            MessageBox.Show("Please enter a customer number with 5 digits.", "Invalid Customr ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lstExistingCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstExistingCustomers.SelectedIndexChanged
        Dim selected As Integer = lstExistingCustomers.SelectedIndex
        currentCustomer = Customers.CustomerList(selected)
        pnlAccountType.Enabled = True
    End Sub
End Class