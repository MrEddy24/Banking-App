Option Strict On
'Logan Silva and Cole Eddy
Public Class frmKeypad

    Public buffer As String

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub btnPeriod_Click(sender As Object, e As EventArgs) Handles btnPeriod.Click
        buffer += "."
        txtValue.Text = buffer
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        buffer += "1"
        txtValue.Text = buffer
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        buffer += "2"
        txtValue.Text = buffer
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        buffer += "3"
        txtValue.Text = buffer
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        buffer += "4"
        txtValue.Text = buffer
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        buffer += "5"
        txtValue.Text = buffer
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        buffer += "6"
        txtValue.Text = buffer
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        buffer += "7"
        txtValue.Text = buffer
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        buffer += "8"
        txtValue.Text = buffer
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        buffer += "9"
        txtValue.Text = buffer
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        buffer += "0"
        txtValue.Text = buffer
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            buffer = buffer.Substring(0, buffer.Length - 2)
        Catch Ex As Exception
            ' Do NOthing. Just let the error go away.
        End Try
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        buffer = ""
        txtValue.Text = buffer
    End Sub

    Private Sub frmKeypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


