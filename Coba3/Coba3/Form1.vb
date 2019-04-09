Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Text1.Text = “” Then
            MsgBox(“Isi dulu Nama anda”)
        Else
            MsgBox(“Nama Saya ” + Text1.Text + “ dan saya sedang belajar Visual Studio”)
        End If
    End Sub
End Class
