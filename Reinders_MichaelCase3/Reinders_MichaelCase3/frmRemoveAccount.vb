Public Class frmRemoveAccount
    Private CurrentCustomer As Customer
    Private CurrentCheckingAccount As CheckingAccount
    Private CurrentSavingsAccount As SavingsAccount
    Private CurrentCreditCardAccount As CreditCardAccount
    Private Sub btnCloseAccount_Click(sender As Object, e As EventArgs) Handles btnCloseAccount.Click

        Dim result As DialogResult
        If rbTypeChecking.Checked = True Then
            result = MessageBox.Show("Are you sure you want to close this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
            If result = DialogResult.Yes Then
                CurrentCheckingAccount.HiddenClosed = True
                MessageBox.Show("This Account has been Closed.", "Account Closed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Please review the account information to ensure it is the account you wish to close and try again.", "Review information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'close messgebox and return to remove account form. ppossibly clear
            End If

        ElseIf rbTypeSavings.Checked = True Then
            result = MessageBox.Show("Are you sure you want to close this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
            If result = DialogResult.Yes Then
                CurrentSavingsAccount.HiddenClosed = True
                MessageBox.Show("This Account has been Closed.", "Account Closed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Please review the account information to ensure it is the account you wish to close and try again.", "Review information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'close messgebox and return to remove account form. ppossibly clear
            End If

        ElseIf rbTypeCredit.Checked = True Then
            result = MessageBox.Show("Are you sure you want to close this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
            If result = DialogResult.Yes Then
                CurrentCreditCardAccount.HiddenClosed = True
                MessageBox.Show("This Account has been Closed.", "Account Closed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Please review the account information to ensure it is the account you wish to close and try again.", "Review information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'close messgebox and return to remove account form. ppossibly clear
            End If
        End If
    End Sub

    Private Sub btnCloseCancel_Click(sender As Object, e As EventArgs) Handles btnCloseCancel.Click
        Me.Close()
    End Sub

    Private Sub frmRemoveAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        'Dim c As List(Of Customer) = Customers.CustomerList
        For i = 0 To Customers.CustomerList.Count - 1
            lstRemoveCustomerSelect.Items.Add((Customers.CustomerList(i).CurrentCustomerID) & " (" & (Customers.CustomerList(i).CustomerFirstName) & " " & (Customers.CustomerList(i).CustomerLastName) & ")")
        Next i
    End Sub

    Private Sub lstRemoveCustomerSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRemoveCustomerSelect.SelectedIndexChanged
        lstRemoveAccountSelect.Items.Clear()
        Dim selected As Integer = lstRemoveCustomerSelect.SelectedIndex
        CurrentCustomer = Customers.CustomerList(selected)
    End Sub

    Private Sub rbTypeChecking_CheckedChanged(sender As Object, e As EventArgs) Handles rbTypeChecking.CheckedChanged
        lstRemoveAccountSelect.Items.Clear()
        Dim i As Integer
        Dim C As List(Of CheckingAccount) = CurrentCustomer.CheckingAccountsCurrent.UserCheckingAccountList
        For i = 0 To (C.Count - 1)
            lstRemoveAccountSelect.Items.Add("Checking Acct: " & C(i).HiddenCheckingAccountID & " (" & C(i).HiddenAccountBalance & ")")
        Next i
    End Sub

    Private Sub rbTypeSavings_CheckedChanged(sender As Object, e As EventArgs) Handles rbTypeSavings.CheckedChanged
        lstRemoveAccountSelect.Items.Clear()
        Dim i As Integer
        Dim S As List(Of SavingsAccount) = CurrentCustomer.SavingsAccountsCurrent.UserSavingsAccountList
        For i = 0 To (S.Count - 1)
            lstRemoveAccountSelect.Items.Add("Savings Acct: " & S(i).HiddenSavingsAccountID & " (" & S(i).HiddenAccountBalance & ")")
        Next i
    End Sub

    Private Sub rbTypeCredit_CheckedChanged(sender As Object, e As EventArgs) Handles rbTypeCredit.CheckedChanged
        lstRemoveAccountSelect.Items.Clear()
        Dim i As Integer
        Dim CC As List(Of CreditCardAccount) = CurrentCustomer.CreditCardAccountsCurrent.UserCreditCardAccountList
        For i = 0 To (CC.Count - 1)
            lstRemoveAccountSelect.Items.Add("CreditCard Acct: " & CC(i).CreditCardNumber & " (" & CC(i).AvailibleCredit & ")")
        Next i
    End Sub

    Private Sub lstRemoveAccountSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRemoveAccountSelect.SelectedIndexChanged
        If rbTypeChecking.Checked = True Then
            Dim selected As Integer = lstRemoveAccountSelect.SelectedIndex
            CurrentCheckingAccount = CurrentCustomer.CheckingAccountsCurrent.UserCheckingAccountList(selected)
        ElseIf rbTypeSavings.Checked = True Then
            Dim selected As Integer = lstRemoveAccountSelect.SelectedIndex
            CurrentSavingsAccount = CurrentCustomer.SavingsAccountsCurrent.UserSavingsAccountList(selected)
        ElseIf rbTypeCredit.Checked = True Then
            Dim selected As Integer = lstRemoveAccountSelect.SelectedIndex
            CurrentCreditCardAccount = CurrentCustomer.CreditCardAccountsCurrent.UserCreditCardAccountList(selected)
        End If
    End Sub
End Class