Option Strict On
'Logan Silva and Cole Eddy
Public Class frmNavigator
    Private Sub btnMakeWithdrawal_Click(sender As Object, e As EventArgs) Handles btnMakeWithdrawal.Click
        frmMakeWithdrawal.Show()
        Me.Hide()
    End Sub

    Private Sub btnMakeDeposit_Click(sender As Object, e As EventArgs) Handles btnMakeDeposit.Click
        frmDeposit.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransferFunds_Click(sender As Object, e As EventArgs) Handles btnTransferFunds.Click
        frmTransferFunds.Show()
        Me.Hide()
    End Sub

    Private Sub btnGetBalances_Click(sender As Object, e As EventArgs) Handles btnGetBalances.Click
        frmGetBalances.Show()
        Me.Hide()
    End Sub

    Private Sub btnCreditCardPayment_Click(sender As Object, e As EventArgs) Handles btnCreditCardPayment.Click
        frmPayment.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class


