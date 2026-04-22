' Form5 - Laporan Pendapatan Parkir
' cbPeriode = ComboBox bulan, txtTahun = textbox tahun
' btnTampilkan = tampilkan laporan, TextBox1 = placeholder laporan
' btnTutup = tutup form

Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTahun.Text = Now.Year.ToString()
        If cbPeriode.SelectedIndex < 0 Then
            cbPeriode.SelectedIndex = Now.Month - 1
        End If
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        If cbPeriode.SelectedIndex < 0 Then
            MessageBox.Show("Pilih bulan terlebih dahulu!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtTahun.Text.Trim() = "" Then
            MessageBox.Show("Masukkan tahun terlebih dahulu!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TextBox1.Text = "[Laporan parkir periode " & cbPeriode.Text & " " & txtTahun.Text & "]" & vbNewLine &
                        "Laporan akan ditampilkan setelah koneksi database tersambung."
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class
