Option Strict On
'Logan Silva and Cole Eddy
Public Class frmGetBalances

    Private Sub frmMakeDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCheckingBalance.Text = Convert.ToString(13546.84)
        lblSavingsBalance.Text = Convert.ToString(52843.29)
        lblCreditBalance.Text = Convert.ToString(1200.86)
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btnTransferFunds_Click(sender As Object, e As EventArgs) Handles btnAnotherTransactions.Click
        frmNavigator.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckingBalance_Click(sender As Object, e As EventArgs) Handles btnCheckingBalance.Click

        Dim cab As Double
        cab = GlobalSettings.CurrentChecking.GetBalance
        lblCheckingBalance.Text = Convert.ToString(cab)
    End Sub

    Private Sub btnSavingsBalance_Click(sender As Object, e As EventArgs) Handles btnSavingsBalance.Click
        Dim sab As Double
        sab = GlobalSettings.CurrentSaving.GetBalance
        lblSavingsBalance.Text = Convert.ToString(sab)

    End Sub

    Public Sub btnCreditCardBalance_Click(sender As Object, e As EventArgs) Handles btnCreditCardBalance.Click
        Dim ccab As Double
        ccab = GlobalSettings.CurrentCredit.GetBalance
        lblCreditBalance.Text = Convert.ToString(ccab)
        lblCreditBalance.Text = frmPayment.lblOutBalance.Text
    End Sub
End Class