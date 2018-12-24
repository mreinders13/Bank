Option Strict On
Public Class Customer
    Public CheckingAccountsCurrent As New CheckingAccounts()
    Public SavingsAccountsCurrent As New SavingsAccounts()
    Public CreditCardAccountsCurrent As New CreditCardAccounts()
    'Public CurrentCustomer As Customer

    Public CurrentCustomerID As Integer
    Public CustomerFirstName As String
    Public CustomerLastName As String
    Public CurrentSavingsID As Integer
    Public CurrentCheckingID As Integer
    Public CurrentCreditID As Integer
    Public Sub New(ByVal customerID As Integer, ByVal FirstName As String, ByVal LastName As String)
        CurrentCustomerID = customerID
        CustomerFirstName = FirstName
        CustomerLastName = LastName
    End Sub
    Public Shared Function GetCustomerByID(ByRef customerID As Integer) As Customer
        Dim c As Customer
        For Each c In Customers.CustomerList
            If c.CurrentCustomerID = customerID Then
                Return Customers.CustomerList(customerID)
            End If
        Next c
        'Return Customers.CustomerList(CurrentCustomerID(customerID))
        Return Nothing
    End Function

    Public Class CheckingAccounts
        Public UserCheckingAccountList As New List(Of CheckingAccount)
        Public Function CreateCheckingAccount(argID As Integer, argBeginningBalance As Double) As CheckingAccount
            Dim C As New CheckingAccount(argID, argBeginningBalance)
            UserCheckingAccountList.Add(C)
            Return C
        End Function
        Public Function GetCheckingAccountById(ardId As Integer) As CheckingAccount
            Return Nothing
        End Function
    End Class
    Public Class SavingsAccounts
        Public UserSavingsAccountList As New List(Of SavingsAccount)
        Public Function CreateSavingsAccount(argID As Integer, argBeginningBalance As Double) As SavingsAccount
            Dim S As New SavingsAccount(argID, argBeginningBalance)
            UserSavingsAccountList.Add(S)
            Return S
        End Function
        Public Shared Function GetSavingsAccountById(argId As Integer) As SavingsAccount
            Return Nothing
        End Function
    End Class
    Public Class CreditCardAccounts
        Public UserCreditCardAccountList As New List(Of CreditCardAccount)
        Public Function CreateCreditCardAccount(argID As Integer, argInitialCredit As Double) As CreditCardAccount
            Dim C As New CreditCardAccount(argID, argInitialCredit)
            UserCreditCardAccountList.Add(C)
            Return C
        End Function
        Public Shared Function GetCreditCardAccountById(argId As Integer) As CreditCardAccount
            Return Nothing
        End Function
    End Class
End Class
