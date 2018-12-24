Public Class frmChooseAccount
    Private CurrentCustomer As Customer
    Private CurrentCheckingAccount As CheckingAccount
    Private CurrentSavingsAccount As SavingsAccount
    Private CurrentCreditCardAccount As CreditCardAccount

    Private CurrentCheckingAccount2 As CheckingAccount
    Private CurrentSavingsAccount2 As SavingsAccount
    Private CurrentCreditCardAccount2 As CreditCardAccount

    Private Sub frmChooseAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UI Load Buttons 
        btnTransfer.Enabled = False
        btnDeposit.Enabled = False
        btnWithdrawl.Enabled = False
        btnViewBalances.Enabled = False
        pnlAcctType.Enabled = False
        lstAccountSelect.Enabled = False
        pnlTransfer.Hide()
        pnlWithdrawlDeposit.Hide()
        'Load customer List 
        Dim i As Integer
        For i = 0 To Customers.CustomerList.Count - 1
            lstCustomerSelect.Items.Add((Customers.CustomerList(i).CurrentCustomerID) & " (" & (Customers.CustomerList(i).CustomerFirstName) & " " & (Customers.CustomerList(i).CustomerLastName) & ")")
        Next i




    End Sub

    Private Sub lstCustomerSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomerSelect.SelectedIndexChanged
        lstAccountSelect.Items.Clear()
        Dim selected As Integer = lstCustomerSelect.SelectedIndex
        CurrentCustomer = Customers.CustomerList(selected)
        'UI DEsign 
        pnlAcctType.Enabled = True
        btnViewBalances.Show()

    End Sub

    Private Sub rbTypeChecking_CheckedChanged(sender As Object, e As EventArgs) Handles rbTypeChecking.CheckedChanged
        'UI Design
        lstAccountSelect.Items.Clear()
        lstAccountSelect.Enabled = True
        Dim i As Integer
        Dim C As List(Of CheckingAccount) = CurrentCustomer.CheckingAccountsCurrent.UserCheckingAccountList
        For i = 0 To (C.Count - 1)
            lstAccountSelect.Items.Add("Checking Acct: " & C(i).HiddenCheckingAccountID & " (" & C(i).HiddenAccountBalance & ")")
        Next i
    End Sub

    Private Sub rbTypeSavings_CheckedChanged(sender As Object, e As EventArgs) Handles rbTypeSavings.CheckedChanged
        'UI Design
        lstAccountSelect.Items.Clear()
        lstAccountSelect.Enabled = True
        Dim i As Integer
        Dim S As List(Of SavingsAccount) = CurrentCustomer.SavingsAccountsCurrent.UserSavingsAccountList
        For i = 0 To (S.Count - 1)
            lstAccountSelect.Items.Add("Savings Acct: " & S(i).HiddenSavingsAccountID & " (" & S(i).HiddenAccountBalance & ")")
        Next i
    End Sub

    Private Sub rbTypeCredit_CheckedChanged(sender As Object, e As EventArgs) Handles rbTypeCredit.CheckedChanged
        'UI Design
        lstAccountSelect.Items.Clear()
        lstAccountSelect.Enabled = True
        Dim i As Integer
        Dim CC As List(Of CreditCardAccount) = CurrentCustomer.CreditCardAccountsCurrent.UserCreditCardAccountList
        For i = 0 To (CC.Count - 1)
            lstAccountSelect.Items.Add("CreditCard Acct: " & CC(i).CreditCardNumber & " (" & CC(i).AvailibleCredit & ")")
        Next i
    End Sub

    Private Sub lstAccountSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAccountSelect.SelectedIndexChanged
        If rbTypeChecking.Checked = True Then
            Dim selected As Integer = lstAccountSelect.SelectedIndex
            CurrentCheckingAccount = CurrentCustomer.CheckingAccountsCurrent.UserCheckingAccountList(selected)
        ElseIf rbTypeSavings.Checked = True Then
            Dim selected As Integer = lstAccountSelect.SelectedIndex
            CurrentSavingsAccount = CurrentCustomer.SavingsAccountsCurrent.UserSavingsAccountList(selected)
        ElseIf rbTypeCredit.Checked = True Then
            Dim selected As Integer = lstAccountSelect.SelectedIndex
            CurrentCreditCardAccount = CurrentCustomer.CreditCardAccountsCurrent.UserCreditCardAccountList(selected)
        End If
        'UI Load Buttons 
        lstCustomerSelect.Enabled = False
        lstAccountSelect.Enabled = False
        pnlAcctType.Enabled = False
        btnTransfer.Enabled = True
        btnDeposit.Enabled = True
        btnWithdrawl.Enabled = True
        btnViewBalances.Enabled = True
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        'UI Design
        lstAccount2Select.Enabled = False
        pnlAccountType2.Enabled = True
        txtTransferAmount.Enabled = False
        btnMakeTransfer.Enabled = False
        pnlTransfer.Show()

    End Sub

    Private Sub rbChecking2_CheckedChanged(sender As Object, e As EventArgs) Handles rbChecking2.CheckedChanged
        lstAccount2Select.Items.Clear()
        Dim i As Integer
        Dim C As List(Of CheckingAccount) = CurrentCustomer.CheckingAccountsCurrent.UserCheckingAccountList
        For i = 0 To (C.Count - 1)
            lstAccount2Select.Items.Add("Checking Acct: " & C(i).HiddenCheckingAccountID & " (" & C(i).HiddenAccountBalance & ")")
        Next i
        lstAccount2Select.Enabled = True
    End Sub

    Private Sub rbSavings2_CheckedChanged(sender As Object, e As EventArgs) Handles rbSavings2.CheckedChanged
        lstAccount2Select.Items.Clear()
        Dim i As Integer
        Dim S As List(Of SavingsAccount) = CurrentCustomer.SavingsAccountsCurrent.UserSavingsAccountList
        For i = 0 To (S.Count - 1)
            lstAccount2Select.Items.Add("Savings Acct: " & S(i).HiddenSavingsAccountID & " (" & S(i).HiddenAccountBalance & ")")
        Next i
        lstAccount2Select.Enabled = True
    End Sub

    Private Sub rbCreditCard2_CheckedChanged(sender As Object, e As EventArgs) Handles rbCreditCard2.CheckedChanged
        lstAccount2Select.Items.Clear()
        Dim i As Integer
        Dim CC As List(Of CreditCardAccount) = CurrentCustomer.CreditCardAccountsCurrent.UserCreditCardAccountList
        For i = 0 To (CC.Count - 1)
            lstAccount2Select.Items.Add("CreditCard Acct: " & CC(i).CreditCardNumber & " (" & CC(i).AvailibleCredit & ")")
        Next i
        lstAccount2Select.Enabled = True
    End Sub

    Private Sub lstAccount2Select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAccount2Select.SelectedIndexChanged
        If rbChecking2.Checked = True Then
            Dim selected As Integer = lstAccount2Select.SelectedIndex
            CurrentCheckingAccount2 = CurrentCustomer.CheckingAccountsCurrent.UserCheckingAccountList(selected)
        ElseIf rbSavings2.Checked = True Then
            Dim selected As Integer = lstAccount2Select.SelectedIndex
            CurrentSavingsAccount2 = CurrentCustomer.SavingsAccountsCurrent.UserSavingsAccountList(selected)
        ElseIf rbCreditCard2.Checked = True Then
            Dim selected As Integer = lstAccount2Select.SelectedIndex
            CurrentCreditCardAccount2 = CurrentCustomer.CreditCardAccountsCurrent.UserCreditCardAccountList(selected)
        End If
        txtTransferAmount.Enabled = True

    End Sub
    'Transfers**********************************************************************************************
    Private Sub btnMakeTransfer_Click(sender As Object, e As EventArgs) Handles btnMakeTransfer.Click
        If rbTypeChecking.Checked = True Then
            If rbChecking2.Checked = True Then
                If txtTransferAmount.Text <= CurrentCheckingAccount.HiddenAccountBalance Then
                    CurrentCheckingAccount.MakeWithdrawal(txtTransferAmount.Text)
                    CurrentCheckingAccount2.MakeDeposit(txtTransferAmount.Text)
                    MessageBox.Show("Your Transfer between Accounts was Successful!", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Insufficient Funds for Transfer.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            ElseIf rbSavings2.Checked = True Then
                If txtTransferAmount.Text <= CurrentCheckingAccount.HiddenAccountBalance Then
                    CurrentCheckingAccount.MakeWithdrawal(txtTransferAmount.Text)
                    CurrentSavingsAccount2.MakeDeposit(txtTransferAmount.Text)
                    MessageBox.Show("Your Transfer between Accounts was Successful!", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Insufficient Funds for Transfer.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            ElseIf rbCreditCard2.Checked = True Then
                If txtTransferAmount.Text <= CurrentCheckingAccount.HiddenAccountBalance Then
                    If (CurrentCreditCardAccount2.AvailibleCredit + txtTransferAmount.Text) <= CurrentCreditCardAccount2.InitialCreditLimit Then
                        CurrentCheckingAccount.MakeWithdrawal(txtTransferAmount.Text)
                        CurrentCreditCardAccount2.CreditPayment(txtTransferAmount.Text)
                        MessageBox.Show("Your Credit Card Payment was Successful!", "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("Your payment amount exceeded what you owe on your credit card. Please enter smaller payment amount.", "Payment Exceeds Amount Owed")
                        Me.Close()
                    End If
                Else
                        MessageBox.Show("Insufficient Funds for Transfer.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            End If
        ElseIf rbTypeSavings.Checked = True Then
            If rbChecking2.Checked = True Then
                If txtTransferAmount.Text <= CurrentSavingsAccount.HiddenAccountBalance Then
                    CurrentSavingsAccount.MakeWithdrawal(txtTransferAmount.Text)
                    CurrentCheckingAccount2.MakeDeposit(txtTransferAmount.Text)
                    MessageBox.Show("Your Transfer between Accounts was Successful!", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Insufficient Funds for Transfer.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            ElseIf rbSavings2.Checked = True Then
                If txtTransferAmount.Text <= CurrentSavingsAccount.HiddenAccountBalance Then
                    CurrentSavingsAccount.MakeWithdrawal(txtTransferAmount.Text)
                    CurrentSavingsAccount2.MakeDeposit(txtTransferAmount.Text)
                    MessageBox.Show("Your Transfer between Accounts was Successful!", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Insufficient Funds for Transfer.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            ElseIf rbCreditCard2.Checked = True Then
                If txtTransferAmount.Text <= CurrentSavingsAccount.HiddenAccountBalance Then
                    If (CurrentCreditCardAccount2.AvailibleCredit + txtTransferAmount.Text) <= CurrentCreditCardAccount2.InitialCreditLimit Then
                        CurrentSavingsAccount.MakeWithdrawal(txtTransferAmount.Text)
                        CurrentCreditCardAccount2.CreditPayment(txtTransferAmount.Text)
                        MessageBox.Show("Your Credit Card Payment was Successful!", "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("Your payment amount exceeded what you owe on your credit card. Please enter smaller payment amount.", "Payment Exceeds Amount Owed")
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Insufficient Funds for Transfer.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            End If
        ElseIf rbTypeCredit.Checked = True Then
            If rbChecking2.Checked = True Then
                If txtTransferAmount.Text <= CurrentCreditCardAccount.AvailibleCredit Then
                    CurrentCreditCardAccount.CreditCharge(txtTransferAmount.Text)
                    CurrentCheckingAccount2.MakeDeposit(txtTransferAmount.Text)
                    MessageBox.Show("Your Transfer between Accounts was Successful!", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Insufficient Funds for Transfer.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            ElseIf rbSavings2.Checked = True Then
                If txtTransferAmount.Text <= CurrentCreditCardAccount.AvailibleCredit Then
                    CurrentCreditCardAccount.CreditCharge(txtTransferAmount.Text)
                    CurrentSavingsAccount2.MakeDeposit(txtTransferAmount.Text)
                    MessageBox.Show("Your Transfer between Accounts was Successful!", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Insufficient Funds for Transfer.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            ElseIf rbCreditCard2.Checked = True Then
                If txtTransferAmount.Text <= CurrentCreditCardAccount.AvailibleCredit Then
                    CurrentCreditCardAccount.CreditCharge(txtTransferAmount.Text)
                    CurrentCreditCardAccount2.CreditPayment(txtTransferAmount.Text)
                    MessageBox.Show("Your Transfer between Accounts was Successful!", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Insufficient Funds for Transfer.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub txtTransferAmount_Leave(sender As Object, e As EventArgs) Handles txtTransferAmount.Leave
        If ValidateNumbers.IsPositiveDouble(txtTransferAmount.Text) = False Then
            MessageBox.Show("Please enter a positive number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransferAmount.Clear()
        End If
        btnMakeDeposit.Enabled = True
    End Sub
    Private Sub txtWithdrawlAmount_Leave(sender As Object, e As EventArgs) Handles txtWithdrawlAmount.Leave
        If ValidateNumbers.IsPositiveDouble(txtWithdrawlAmount.Text) = False Then
            MessageBox.Show("Please enter a positive number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransferAmount.Clear()
        End If
    End Sub
    Private Sub txtDepositAmount_Leave(sender As Object, e As EventArgs) Handles txtDepositAmount.Leave
        If ValidateNumbers.IsPositiveDouble(txtDepositAmount.Text) = False Then
            MessageBox.Show("Please enter a positive number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransferAmount.Clear()
        End If
    End Sub
    Private Sub btnWithdrawl_Click(sender As Object, e As EventArgs) Handles btnWithdrawl.Click
        'UI Design 
        lstCustomerSelect.Enabled = False
        pnlAcctType.Enabled = False
        lstAccountSelect.Enabled = False
        pnlWithdrawlDeposit.Show()
        lblWithdrawlAmount.Show()
        txtWithdrawlAmount.Show()
        btnMakeWithdrawl.Show()
        lblDepositAmount.Hide()
        txtDepositAmount.Hide()
        btnMakeDeposit.Hide()
    End Sub
    Private Sub btnMakeWithdrawl_Click(sender As Object, e As EventArgs) Handles btnMakeWithdrawl.Click

        'Make Withdrawl 
        Dim withdrawlAmount As Double = Convert.ToDouble(txtWithdrawlAmount.Text)
        If rbTypeChecking.Checked = True Then
            If withdrawlAmount <= CurrentCheckingAccount.HiddenAccountBalance Then
                CurrentCheckingAccount.MakeWithdrawal(withdrawlAmount)
                MessageBox.Show("Your Withdrawl was Successful!", "Withdrawl Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Your Withdrawl could not be completed due to insufficient funds.", "Withdrrawl Unsuccessful")
                Me.Close()
            End If
        ElseIf rbTypeSavings.Checked = True Then
            If withdrawlAmount <= CurrentSavingsAccount.HiddenAccountBalance Then
                CurrentSavingsAccount.MakeWithdrawal(withdrawlAmount)
                MessageBox.Show("Your Withdrawl was Successful!", "Withdrawl Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Your Withdrawl could not be completed due to insufficient funds.", "Withdrrawl Unsuccessful")
                Me.Close()
            End If
        ElseIf rbTypeCredit.Checked = True Then
            If withdrawlAmount <= CurrentCreditCardAccount.AvailibleCredit Then
                CurrentCreditCardAccount.CreditCharge(withdrawlAmount)
                MessageBox.Show("Your Withdrawl was Successful!", "Withdrawl Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Your Withdrawl could not be completed due to insufficient funds.", "Withdrrawl Unsuccessful")
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        'UI Design 
        lstCustomerSelect.Enabled = False
        pnlAcctType.Enabled = False
        lstAccountSelect.Enabled = False
        pnlWithdrawlDeposit.Show()
        lblDepositAmount.Show()
        txtDepositAmount.Show()
        btnMakeDeposit.Show()
        txtWithdrawlAmount.Hide()
        lblWithdrawlAmount.Hide()
        btnMakeWithdrawl.Hide()
    End Sub
    Private Sub btnMakeDeposit_Click(sender As Object, e As EventArgs) Handles btnMakeDeposit.Click

        'Make Deposit 
        Dim depositAmount As Double = Convert.ToDouble(txtDepositAmount.Text)
        If rbTypeChecking.Checked = True Then
            CurrentCheckingAccount.MakeDeposit(depositAmount)
            MessageBox.Show("Your Deposit was Successful!", "Deposit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        ElseIf rbTypeSavings.Checked = True Then
            CurrentSavingsAccount.MakeDeposit(depositAmount)
            MessageBox.Show("Your Deposit was Successful!", "Deposit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        ElseIf rbTypeCredit.Checked = True Then
            If (depositAmount + CurrentCreditCardAccount.AvailibleCredit) <= CurrentCreditCardAccount.InitialCreditLimit Then
                CurrentCreditCardAccount.CreditPayment(depositAmount)
                MessageBox.Show("Your Credit Card Payment was Successful!", "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Your payment amount exceeded what you owe on your credit card. Please enter smaller payment amount.", "Payment Exceeds Amount Owed")
                Me.Close()
            End If
        End If
    End Sub
    'View Balance of the selected customer's selected account 
    Private Sub btnViewBalances_Click(sender As Object, e As EventArgs) Handles btnViewBalances.Click
        If rbTypeChecking.Checked = True Then
            MessageBox.Show("The account balance of Checking Account #" & CurrentCheckingAccount.GetID.ToString & " is $" &
                            CurrentCheckingAccount.HiddenAccountBalance.ToString, "Checking Account #" &
                            CurrentCheckingAccount.HiddenCheckingAccountID.ToString & " Balance", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        ElseIf rbTypeSavings.Checked = True Then
            MessageBox.Show("The account balance of Savings Account #" & CurrentSavingsAccount.GetID.ToString &
                            " Is $" & CurrentSavingsAccount.HiddenAccountBalance.ToString, "Savings Account #" &
                            CurrentSavingsAccount.HiddenSavingsAccountID.ToString & " Balance",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        ElseIf rbTypeCredit.Checked = True Then
            MessageBox.Show("The account balance of CreditCard Account #" & CurrentCreditCardAccount.CreditCardNumber.ToString & " is $(" _
                            & CurrentCreditCardAccount.CreditBalance.ToString & "). You have $" & CurrentCreditCardAccount.AvailibleCredit.ToString &
                            " of availible credit remaining on this account.", "Credit Card Account #" & CurrentCreditCardAccount.CreditCardNumber.ToString &
                            " Balance", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Please Select which account balance your wish to view.", "Please Select an Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtTransferAmount_TextChanged(sender As Object, e As EventArgs) Handles txtTransferAmount.TextChanged
        btnMakeTransfer.Enabled = True
    End Sub
End Class