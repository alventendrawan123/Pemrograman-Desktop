' Form3 - Atur Parkir Langganan
' TextBox1 = Nama Pelanggan, TextBox2 = Nomor Plat, TextBox3 = Tarif Langganan
' ComboBox1 = Jenis, DateTimePicker1 = Berlaku hingga
' Label6 = ID Pelanggan (display)
' Button1 = Tambah, Button2 = Edit, Button3 = Hapus, Button4 = Tutup

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox jenis kendaraan sesuai modul
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi/Umum", "Sepeda", "Bus/Truk"})
        ComboBox1.SelectedIndex = 0

        ' Setup kolom DataGridView
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("id", "ID")
        DataGridView1.Columns.Add("nama", "Nama Pelanggan")
        DataGridView1.Columns.Add("no_plat", "Nomor Plat")
        DataGridView1.Columns.Add("jenis", "Jenis")
        DataGridView1.Columns.Add("biaya", "Tarif Langganan")
        DataGridView1.Columns.Add("expired", "Berlaku Hingga")
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        BersihkanForm()
    End Sub

    Private Sub BersihkanForm()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = 0
        DateTimePicker1.Value = Now.AddMonths(1)
        Label6.Text = "ID Pelanggan: -"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Tambah data langganan
        If TextBox1.Text.Trim() = "" OrElse TextBox2.Text.Trim() = "" OrElse TextBox3.Text.Trim() = "" Then
            MessageBox.Show("Semua field harus diisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim id As Integer = DataGridView1.Rows.Count + 1
        DataGridView1.Rows.Add(id, TextBox1.Text, TextBox2.Text.ToUpper(),
                               ComboBox1.Text, TextBox3.Text, DateTimePicker1.Value.ToString("dd/MM/yyyy"))
        MessageBox.Show("Data langganan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BersihkanForm()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Edit data langganan yang dipilih
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang akan diedit!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        TextBox1.Text = row.Cells("nama").Value.ToString()
        TextBox2.Text = row.Cells("no_plat").Value.ToString()
        TextBox3.Text = row.Cells("biaya").Value.ToString()
        ComboBox1.Text = row.Cells("jenis").Value.ToString()
        Label6.Text = "ID Pelanggan: " & row.Cells("id").Value.ToString()
        DataGridView1.Rows.Remove(row)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Hapus data langganan yang dipilih
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang akan dihapus!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim konfirmasi As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            BersihkanForm()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

End Class
