Option Strict On
Public Class ValidateNumbers
    Public Shared Function IsPositiveDouble(argValue As String) As Boolean
        Dim Result As Double
        If (System.Double.TryParse(argValue, Result)) Then
            If (Result > 0.00) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Public Shared Function IsCustomerIDNumber(argValue As Integer) As Boolean
        If argValue >= 10000 And argValue < 100000 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
