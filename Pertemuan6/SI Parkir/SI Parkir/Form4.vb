' Form4 - Form Utama (Kelola Parkir)
' Menu: Sistem > Atur Profil, Logout | Admin > Langganan, Laporan | Bantuan > Bantuan, Tentang
' Panel1 > lblPlat (nomor plat besar)
' TextBox1 = input nomor plat, ComboBox1 = jenis kendaraan
' Button1 = Masuk, Button2 = Keluar
' Panel2 > Label6 = biaya parkir
' DataGridView1 = daftar kendaraan parkir
' lblTanggal, lblJam, lblTotalKendaraan = info bawah

Public Class Form4

    Private WithEvents ClockTimer As New System.Windows.Forms.Timer()

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox jenis kendaraan
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi/Umum", "Sepeda", "Bus/Truk"})
        ComboBox1.SelectedIndex = 0

        ' Setup kolom DataGridView kendaraan parkir
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("no_plat", "Nomor Plat")
        DataGridView1.Columns.Add("jenis", "Jenis")
        DataGridView1.Columns.Add("jam_masuk", "Jam Masuk")
        DataGridView1.Columns.Add("harga", "Tarif")
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Jalankan timer untuk jam
        ClockTimer.Interval = 1000
        ClockTimer.Start()
        UpdateInfo()

        lblPlat.Text = "-"
        Label6.Text = "Rp 0"
        TextBox1.Focus()
    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        UpdateInfo()
    End Sub

    Private Sub UpdateInfo()
        lblTanggal.Text = "Tanggal: " & Now.ToString("dd-MM-yyyy")
        lblJam.Text = "Jam: " & Now.ToString("HH:mm:ss")
        HitungTotalKendaraan()
    End Sub

    Private Sub HitungTotalKendaraan()
        Dim motor, mobil, taksi, sepeda, bus As Integer
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For
            Select Case row.Cells("jenis").Value.ToString()
                Case "Motor" : motor += 1
                Case "Mobil" : mobil += 1
                Case "Taksi/Umum" : taksi += 1
                Case "Sepeda" : sepeda += 1
                Case "Bus/Truk" : bus += 1
            End Select
        Next
        lblTotalKendaraan.Text = motor & " Motor, " & mobil & " Mobil, " & taksi & " Taksi, " & sepeda & " Sepeda, " & bus & " Bus/Truk"
    End Sub

    Private Function HitungTarif(jenis As String) As Integer
        Select Case jenis
            Case "Motor" : Return 2000
            Case "Mobil" : Return 5000
            Case "Taksi/Umum" : Return 3000
            Case "Sepeda" : Return 1000
            Case "Bus/Truk" : Return 10000
            Case Else : Return 2000
        End Select
    End Function

    ' --- Tombol Masuk ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Masukkan nomor plat kendaraan!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Return
        End If

        Dim noPlat As String = TextBox1.Text.Trim().ToUpper()
        Dim jenis As String = ComboBox1.Text
        Dim tarif As Integer = HitungTarif(jenis)
        Dim jamMasuk As String = Now.ToString("HH:mm:ss")

        DataGridView1.Rows.Add(noPlat, jenis, jamMasuk, "Rp " & tarif.ToString("N0"))
        lblPlat.Text = noPlat
        Label6.Text = "Rp " & tarif.ToString("N0")

        MessageBox.Show("Kendaraan " & noPlat & " (" & jenis & ") berhasil masuk!" & vbNewLine &
                        "Tarif: Rp " & tarif.ToString("N0"), "Kendaraan Masuk",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        TextBox1.Clear()
        TextBox1.Focus()
        HitungTotalKendaraan()
    End Sub

    ' --- Tombol Keluar ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Masukkan nomor plat kendaraan!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Return
        End If

        Dim noPlat As String = TextBox1.Text.Trim().ToUpper()

        ' Cari kendaraan di grid
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For
            If row.Cells("no_plat").Value.ToString() = noPlat Then
                lblPlat.Text = noPlat
                Label6.Text = row.Cells("harga").Value.ToString()
                MessageBox.Show("Kendaraan " & noPlat & " keluar." & vbNewLine &
                                "Total biaya: " & row.Cells("harga").Value.ToString(),
                                "Kendaraan Keluar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.Rows.Remove(row)
                TextBox1.Clear()
                TextBox1.Focus()
                HitungTotalKendaraan()
                Return
            End If
        Next

        MessageBox.Show("Kendaraan " & noPlat & " tidak ditemukan dalam daftar parkir!",
                        "Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        TextBox1.Focus()
    End Sub

    ' --- Menu Sistem ---
    Private Sub AturProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfilToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Yakin ingin logout?", "Konfirmasi Logout",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            ClockTimer.Stop()
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    ' --- Menu Admin ---
    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub

    ' --- Menu Bantuan ---
    Private Sub BantuanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BantuanToolStripMenuItem1.Click
        MessageBox.Show("SI Parkir - Sistem Informasi Parkir" & vbNewLine &
                        "Tekan F1-Motor, F2-Mobil, F3-Taksi, F4-Sepeda, F5-Bus/Truk" & vbNewLine &
                        "Tekan Enter untuk Masuk / Keluar kendaraan",
                        "Bantuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TentangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangToolStripMenuItem.Click
        MessageBox.Show("SI Parkir v1.0" & vbNewLine & "Aplikasi Sistem Informasi Parkir" & vbNewLine &
                        "Pemrograman Desktop - Pertemuan VI",
                        "Tentang", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' --- Shortcut keyboard untuk jenis kendaraan ---
    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1 : ComboBox1.SelectedIndex = 0  ' Motor
            Case Keys.F2 : ComboBox1.SelectedIndex = 1  ' Mobil
            Case Keys.F3 : ComboBox1.SelectedIndex = 2  ' Taksi/Umum
            Case Keys.F4 : ComboBox1.SelectedIndex = 3  ' Sepeda
            Case Keys.F5 : ComboBox1.SelectedIndex = 4  ' Bus/Truk
        End Select
    End Sub

End Class
