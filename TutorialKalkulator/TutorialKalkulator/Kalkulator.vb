Public Class Kalkulator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Operasi.Text = "+" Then
            Hasil.Text = Val(Angka1.Text) + Val(Angka2.Text)
        End If
        If Operasi.Text = "-" Then
            Hasil.Text = Angka1.Text - Angka2.Text
        End If
        If Operasi.Text = "x" Then
            Hasil.Text = Angka1.Text * Angka2.Text
        End If
        If Operasi.Text = ":" Then
            Hasil.Text = Angka1.Text / Angka2.Text
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Angka1.Text = ""
        Angka2.Text = ""
        Operasi.Text = ""
        Hasil.Text = ""
    End Sub
End Class