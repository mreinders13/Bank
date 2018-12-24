Option Strict On
Public Class CheckingAccount
    'Public Shared CheckingAccountList As New List(Of CheckingAccount)

    'Public HiddenCustomerID As Integer
    Public HiddenCheckingAccountID As Integer
    Public HiddenAccountBalance As Double
    Public HiddenClosed As Boolean


    Public Sub New(argAccountID As Integer, argBeginningBalance As Double)
        HiddenCheckingAccountID = argAccountID
        HiddenAccountBalance = argBeginningBalance
    End Sub

    Public ReadOnly Property GetID As Integer
        Get
            Return HiddenCheckingAccountID
        End Get
    End Property

    Public ReadOnly Property GetBalance As Double
        Get
            Return HiddenAccountBalance
        End Get
    End Property

    Public Function MakeWithdrawal(ByVal amount As Double) As Double
        HiddenAccountBalance = HiddenAccountBalance - amount
        Return HiddenAccountBalance
    End Function

    Public Function MakeDeposit(ByVal amount As Double) As Double
        HiddenAccountBalance = HiddenAccountBalance + amount
        Return HiddenAccountBalance
    End Function
    Public Sub CloseAccount()
        HiddenClosed = True
    End Sub
End Class
