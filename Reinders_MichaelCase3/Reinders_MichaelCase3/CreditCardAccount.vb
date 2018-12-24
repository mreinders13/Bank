Option Strict On
Public Class CreditCardAccount
    Public CreditCardAccountList As New List(Of CreditCardAccount)



    Private HiddenCreditCardID As Integer
    Private HiddenInitialCreditLimit As Double
    Public HiddenClosed As Boolean
    Private HiddenCreditCardBalance As Double

    Public Sub New(argCreditID As Integer, argCreditLimit As Double)
        HiddenCreditCardID = argCreditID
        HiddenInitialCreditLimit = argCreditLimit
    End Sub
    '*********************************ReadOnly Properties for Credit Cards********
    Public ReadOnly Property CreditCardNumber As String
        Get
            Return HiddenCreditCardID.ToString
        End Get
    End Property
    Public ReadOnly Property InitialCreditLimit As Double
        Get
            Return HiddenInitialCreditLimit
        End Get
    End Property
    Public ReadOnly Property CurrentCreditLimit As Double
        Get
            Return HiddenInitialCreditLimit
        End Get
    End Property
    Public ReadOnly Property CreditBalance As Double
        Get
            Return HiddenCreditCardBalance
        End Get
    End Property
    Public ReadOnly Property AvailibleCredit As Double
        Get
            Return HiddenInitialCreditLimit - HiddenCreditCardBalance
        End Get
    End Property
    '*******************Methods for Credit Cards***********************
    Public Function CreditPayment(argPayment As Double) As Double
        HiddenCreditCardBalance = HiddenCreditCardBalance - argPayment
        Return HiddenCreditCardBalance
    End Function
    Public Function CreditCharge(argCharge As Double) As Double
        HiddenCreditCardBalance = HiddenCreditCardBalance + argCharge
        Return HiddenCreditCardBalance
    End Function
End Class
