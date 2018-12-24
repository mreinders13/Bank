Public Class frmProcessSelect
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        frmCreateAccount.Show()
    End Sub

    Private Sub btnRemoveAccount_Click(sender As Object, e As EventArgs) Handles btnRemoveAccount.Click
        frmRemoveAccount.Show()
    End Sub

    Private Sub btnProcessTransactions_Click(sender As Object, e As EventArgs) Handles btnProcessTransactions.Click
        frmChooseAccount.Show()
    End Sub
End Class
