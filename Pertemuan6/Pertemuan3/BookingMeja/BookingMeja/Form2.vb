Public Class Form2

    Dim hargaMenuFavorit As Integer = 0
    Dim hargaPaketHemat As Integer = 0
    Dim hargaMenuPilihan As Integer = 0
    Dim totalHarga As Integer = 0

    Private Sub HitungTotalHarga()
        If cbNasgorSpesial.Checked Then
            hargaMenuFavorit = 35000
        ElseIf cbAyamGeprek.Checked Then
            hargaMenuFavorit = 25000
        ElseIf cbSotoBetawi.Checked Then
            hargaMenuFavorit = 40000
        End If

        If CheckBox4.Checked Then
            hargaPaketHemat = 70000
        ElseIf CheckBox5.Checked Then
            hargaPaketHemat = 85000
        End If

        If cbNasgorAyam.Checked Then
            hargaMenuPilihan += 30000 * NumericUpDown3.Value
        End If
        If cbAyamKremes.Checked Then
            hargaMenuPilihan += 25000 * NumericUpDown4.Value
        End If
        If cbEsJeruk.Checked Then
            hargaMenuPilihan += 10000 * NumericUpDown5.Value
        End If
        If cbSotoAyam.Checked Then
            hargaMenuPilihan += 25000 * NumericUpDown6.Value
        End If

        totalHarga = hargaMenuFavorit + hargaPaketHemat + hargaMenuPilihan

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        HitungTotalHarga()

        Dim result As DialogResult = MessageBox.Show("Total harga pesanan: Rp " & totalHarga.ToString() & ". Silakan bayar ke kasir. Ketik OK untuk melanjutkan.", "Pembayaran", MessageBoxButtons.OK)

        If result = DialogResult.OK Then
            MessageBox.Show("Terima kasih atas pesanan Anda!", "Konfirmasi", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(163, 200, 229)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.FromArgb(163, 200, 229)
    End Sub

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub


End Class