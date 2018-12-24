Option Strict On
Public Class SavingsAccount
    Public SavingsAccountsList As New List(Of SavingsAccount)



    Public HiddenSavingsAccountID As Integer
    Public HiddenAccountBalance As Double
    Public HiddenClosed As Boolean

    Public Sub New(argID As Integer, argBeginningBalance As Double)
        HiddenSavingsAccountID = argID
        HiddenAccountBalance = argBeginningBalance

    End Sub

    Public ReadOnly Property GetID As Integer
        Get
            Return HiddenSavingsAccountID
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
End Class
