Imports MySql.Data.MySqlClient

Public Class formUtama
    Sub RefreshGrid()
        Dim i
        i = 0
        dgvKendaraanParkir.Rows.Clear()
        Dim sql As String = "select * from tblparkir where DATE(`waktu_masuk`) = CURDATE()"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                dgvKendaraanParkir.Rows.Add()
                dgvKendaraanParkir.Item(0, i).Value = myDataReader("no_plat")
                dgvKendaraanParkir.Item(1, i).Value = myDataReader("waktu_masuk")
                dgvKendaraanParkir.Item(2, i).Value = myDataReader("waktu_keluar")
                dgvKendaraanParkir.Item(3, i).Value = myDataReader("harga")
                dgvKendaraanParkir.Item(4, i).Value = myDataReader("jenis")
                dgvKendaraanParkir.Item(5, i).Value = myDataReader("id")
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Sub HitungJumlah()
        Dim sql As String = "select jenis,count(*) as jml," & bts & "-count(*) as sisa from tblparkir where DATE(`waktu_masuk`) = CURDATE() and waktu_keluar is null group by(jenis)"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        Dim hsl As String = "Jumlah "
        If myDataReader.HasRows Then
            While myDataReader.Read()
                hsl = hsl & myDataReader("jenis").ToString & " = " & myDataReader("jml").ToString & ", "
            End While
            lblJmlKendaraan.Text = hsl
        Else
            lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub ProfilToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfilToolStripMenuItem1.Click
        frmProfil.ShowDialog()
    End Sub


    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        frmLogin.txtUsername.Clear()
        frmLogin.txtPassword.Clear()
        frmLogin.txtUsername.Focus()
        frmLogin.ShowDialog()
    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        langganan.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim sql As String = "select sum(harga) from tblparkir where DATE(waktu_masuk) = CURDATE() and DATE(waktu_keluar) = CURDATE()"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        Dim hasil As Object = myCommand.ExecuteScalar
        Dim total As String = ""
        If hasil.Equals(DBNull.Value) Then
            total = "0"
        Else
            total = hasil.ToString
        End If
        MsgBox("Total Pendapatan hari ini: Rp. " & total)
    End Sub

    Private Sub formUtama_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim sql As String
        Dim harga As Integer = 0
        Dim nomor As String = String.Empty
        If e.KeyCode = Keys.F1 Then
            jns = "Motor"
            harga = 2000
            lblHarga.Text = "Rp2000"
        ElseIf e.KeyCode = Keys.F2 Then
            jns = "Mobil"
            harga = 3000
            lblHarga.Text = "Rp3000"
        ElseIf e.KeyCode = Keys.F3 Then
            jns = "Taksi/Umum"
            harga = 3000
            lblHarga.Text = "Rp1000"
        ElseIf e.KeyCode = Keys.F4 Then
            jns = "Sepeda"
            harga = 1000
            lblHarga.Text = "Rp1000"
        ElseIf e.KeyCode = Keys.F5 Then
            jns = "Bus/Truk"
            harga = 4000
            lblHarga.Text = "Rp4000"
        End If
        lblInfoJenis.Text = jns
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If e.KeyCode = Keys.Return Then
            sql = "select * from tblparkir where no_plat='" & txtNoPlat.Text.ToUpper & "' and waktu_keluar is null and DATE(`waktu_masuk`) = CURDATE()"
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            Dim hasil1 As MySqlDataReader = myCommand.ExecuteReader()
            If hasil1.HasRows Then 'kalau sudah ada, update jadi keluar
                If MessageBox.Show("Keluar dari Parkir?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    hasil1.Read()
                    jns = hasil1("jenis").ToString
                    nomor = hasil1("id").ToString
                    If jns = "Motor" Then
                        harga = 2000
                        lblHarga.Text = "Rp2000"
                    ElseIf jns = "Mobil" Or jns = "Taksi/Umum" Then
                        harga = 3000
                        lblHarga.Text = "Rp3000"
                    ElseIf jns = "Sepeda" Then
                        harga = 1000
                        lblHarga.Text = "Rp1000"
                    ElseIf jns = "Bus/Truk" Then
                        harga = 4000
                        lblHarga.Text = "Rp4000"
                    End If

                    If hasil1.IsClosed = False Then
                        hasil1.Close()
                    End If

                    sql = "update tblparkir set waktu_keluar = CURRENT_TIMESTAMP(), harga = IF(ceil((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk))/60/60)>1,ceil((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk))/60/60)*" & Str(harga) & "," & Str(harga) & ") where id = " & nomor
                    myCommand.CommandText = sql
                    myCommand.ExecuteNonQuery()

                    sql = "select * from tblparkir where id = " & nomor
                    myCommand.CommandText = sql
                    hasil1 = myCommand.ExecuteReader
                    hasil1.Read()
                    lblHarga.Text = "Rp. " & hasil1("harga").ToString
                    If hasil1.IsClosed = False Then
                        hasil1.Close()
                    End If

                    MsgBox("Sukses Keluar!")
                    jns = String.Empty
                End If
            Else 'kalau belum ada masukkan baru
                If jns = String.Empty Then
                    MsgBox("Masukan jenis kendaraan berikut:" & vbCrLf & lblJenis.Text)
                    hasil1.Close()
                    Exit Sub
                End If
                sql = "insert into tblparkir(no_plat,jenis,user) values ('" & txtNoPlat.Text.ToUpper & "','" & lblInfoJenis.Text & "','" & pengguna & "')"
                If hasil1.IsClosed = False Then
                    hasil1.Close()
                End If
                myCommand.CommandText = sql
                myCommand.ExecuteNonQuery()
                jns = String.Empty
            End If
            labelPlat.Text = txtNoPlat.Text.ToUpper
        End If
        RefreshGrid()
        HitungJumlah()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
    End Sub

    Private Sub formUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        lblTanggal.Text = "Tanggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim sql As String = "delete from tblparkir where id=" & dgvKendaraanParkir.CurrentRow.Cells(5).Value.ToString
            MsgBox(sql)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            Dim hasil As Integer = myCommand.ExecuteNonQuery
            If hasil = 1 Then
                MsgBox("Delete success!")
                RefreshGrid()
                HitungJumlah()
            End If
        Else
        End If
    End Sub

    Private Sub dgvKendaraanParkir_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKendaraanParkir.CellEnter
        labelPlat.Text = dgvKendaraanParkir.Rows(e.RowIndex).Cells(0).Value
    End Sub
End Class