Public Class Coba
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Operasi.SelectedIndexChanged

    End Sub

    Private Sub Hasil_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Angka1.Text = ""
        Angka2.Text = ""
        Hasil.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Jam.Text = TimeOfDay
        If Me.TeksJalan.Left < 930 Then
            Me.TeksJalan.Left = Me.TeksJalan.Left + 15
        Else
            Me.TeksJalan.Left = Me.TeksJalan.Left - 100
        End If
    End Sub
End Class