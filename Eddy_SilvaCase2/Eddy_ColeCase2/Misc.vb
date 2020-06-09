Public Class Misc
    Public Shared Function CreateKeypad(p As Panel) As frmKeypad

        Dim fKey As New frmKeypad()

        fKey.TopLevel = False
        fKey.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        fKey.Size = New System.Drawing.Size(500, 500)
        fKey.Location = New System.Drawing.Point(10, 10)
        fKey.WindowState = FormWindowState.Normal
        fKey.Visible = True
        p.Controls.Add(fKey)
        Return fKey
    End Function

    Private Sub Misc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class