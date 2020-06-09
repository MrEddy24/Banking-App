Option Strict On
'Logan Silva and Cole Eddy
Public Class frmTransferFunds
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btnAnotherTransactions_Click(sender As Object, e As EventArgs) Handles btnAnotherTransaction.Click
        frmNavigator.Show()
        Me.Hide()
    End Sub

    Public Buffer As String
    Private Sub btnPeriod_Click(sender As Object, e As EventArgs) Handles btnPeriod.Click
        Buffer += "."
        txtValue.Text = Buffer
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Buffer += "1"
        txtValue.Text = Buffer
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Buffer += "2"
        txtValue.Text = Buffer
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Buffer += "3"
        txtValue.Text = Buffer
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Buffer += "4"
        txtValue.Text = Buffer
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Buffer += "5"
        txtValue.Text = Buffer
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Buffer += "6"
        txtValue.Text = Buffer
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Buffer += "7"
        txtValue.Text = Buffer
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Buffer += "8"
        txtValue.Text = Buffer
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Buffer += "9"
        txtValue.Text = Buffer
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Buffer += "0"
        txtValue.Text = Buffer
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Try
            Buffer = Buffer.Substring(0, Buffer.Length - 2)
        Catch Ex As Exception
            ' Do NOthing. Just let the error go away.
        End Try
    End Sub
    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        Buffer = ""
        txtValue.Text = Buffer
    End Sub

    Private Sub btnToChecking_Click(sender As Object, e As EventArgs) Handles btnToChecking.Click
        Dim NB As Double
        NB = GlobalSettings.CurrentChecking.MakeWithdrawal(Convert.ToDouble(txtValue.Text))
        NB = GlobalSettings.CurrentSaving.MakeDeposit(Convert.ToDouble(txtValue.Text))
    End Sub

    Private Sub btnToSavings_Click(sender As Object, e As EventArgs) Handles btnToSavings.Click
        Dim NB As Double
        NB = GlobalSettings.CurrentChecking.MakeDeposit(Convert.ToDouble(txtValue.Text))
        NB = GlobalSettings.CurrentSaving.MakeWithdrawal(Convert.ToDouble(txtValue.Text))
    End Sub
End Class