Public Class Form1

    Private Sub FormPesanMeja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbMeja.Items.Clear()
        OpsiJmlTamu.Maximum = 8
        cbMeja.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(163, 200, 229)
    End Sub

    ' Update pilihan meja saat jumlah tamu diubah
    Private Sub OpsiJmlTamu_ValueChanged(sender As Object, e As EventArgs) Handles OpsiJmlTamu.ValueChanged
        cbMeja.Items.Clear()
        Dim jumlahTamu As Integer = CInt(OpsiJmlTamu.Value)

        If jumlahTamu > 8 Then
            MessageBox.Show("Jumlah tamu tidak boleh lebih dari 8.")
            OpsiJmlTamu.Value = 8
        End If

        Select Case jumlahTamu
            Case 1 To 2
                cbMeja.Items.Add("Meja 1 (2 Kursi)")
            Case 3 To 4
                cbMeja.Items.Add("Meja 2 (4 Kursi)")
            Case 5 To 6
                cbMeja.Items.Add("Meja 3 (6 Kursi)")
            Case 7 To 8
                cbMeja.Items.Add("Meja 4 (8 Kursi)")
        End Select

        If cbMeja.Items.Count > 0 Then
            cbMeja.SelectedIndex = 0
        End If
    End Sub

    ' Tombol Next untuk berpindah ke Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btNext.Click
        If cbMeja.SelectedItem Is Nothing Then
            MessageBox.Show("Silakan pilih meja terlebih dahulu.")
            Return
        End If

        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub lbNama_Click(sender As Object, e As EventArgs) Handles lbNama.Click

    End Sub
End Class
