Imports MySql.Data.MySqlClient

Public Class langganan
    Private Sub RefreshGrid()
        Dim i
        i = 0
        dgvLangganan.Rows.Clear()
        Dim sql As String = "select * from tbllangganan"
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
                dgvLangganan.Rows.Add()
                dgvLangganan.Item(0, i).Value = myDataReader("id")
                dgvLangganan.Item(1, i).Value = myDataReader("no_plat")
                dgvLangganan.Item(2, i).Value = myDataReader("nama")
                dgvLangganan.Item(3, i).Value = myDataReader("biaya")
                dgvLangganan.Item(4, i).Value = myDataReader("jenis")
                dgvLangganan.Item(5, i).Value = myDataReader("expired")
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        If btnTambah.Text = "Simpan" Then
            btnTambah.Text = "Tambah"
            txtNoPlatLangganan.Enabled = False
            txtNamaPelanggan.Enabled = False
            txtTarifLangganan.Enabled = False
            cbJenisLangganan.Enabled = False
            tglExpiredDate.Enabled = False
            btnTutup.Visible = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
        ElseIf btnEdit.Text = "Simpan" Then
            btnEdit.Text = "Edit"
            txtNoPlatLangganan.Enabled = False
            txtNamaPelanggan.Enabled = False
            txtTarifLangganan.Enabled = False
            cbJenisLangganan.Enabled = False
            tglExpiredDate.Enabled = False
            btnTutup.Visible = False
            btnTambah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub langganan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub dgvLangganan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLangganan.CellClick
        Dim idx As String = dgvLangganan.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim sql As String = "select * from tbllangganan where id=" & idx
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
                lblIDPelanggan.Text = myDataReader("id")
                txtNoPlatLangganan.Text = myDataReader("no_plat")
                txtNamaPelanggan.Text = myDataReader("nama")
                txtTarifLangganan.Text = myDataReader("biaya")
                cbJenisLangganan.Text = myDataReader("jenis")
                tglExpiredDate.Text = myDataReader("expired")
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            btnTambah.Text = "Simpan"
            txtNoPlatLangganan.Enabled = True
            txtNamaPelanggan.Enabled = True
            txtTarifLangganan.Enabled = True
            cbJenisLangganan.Enabled = True
            tglExpiredDate.Enabled = True
            btnTutup.Visible = True
            btnEdit.Enabled = False
            btnHapus.Enabled = False
            txtNoPlatLangganan.Clear()
            txtNamaPelanggan.Clear()
            txtTarifLangganan.Clear()
            cbJenisLangganan.Text = ""
        ElseIf btnTambah.Text = "Simpan" Then
            Dim hasil As DateTime = tglExpiredDate.Value
            Dim waktu As String = hasil.Year & "-" & hasil.Month & "-" & hasil.Day & " 16:00:00"
            Dim sql As String = "insert into tbllangganan(no_plat,nama,jenis,biaya,expired) values ('" & txtNoPlatLangganan.Text & "','" & txtNamaPelanggan.Text & "','" & cbJenisLangganan.Text & "','" & txtTarifLangganan.Text & "','" & waktu & "')"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            myCommand.ExecuteNonQuery()
            btnTambah.Text = "Tambah"
            txtNoPlatLangganan.Enabled = False
            txtNamaPelanggan.Enabled = False
            txtTarifLangganan.Enabled = False
            cbJenisLangganan.Enabled = False
            tglExpiredDate.Enabled = False
            btnTutup.Visible = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
            RefreshGrid()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvLangganan.CurrentRow.Cells(0).Value.ToString <> "" Then
            If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim sql As String = "delete from tbllangganan where id=" & dgvLangganan.CurrentRow.Cells(0).Value.ToString
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
                End If
            Else
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            btnEdit.Text = "Simpan"
            txtNoPlatLangganan.Enabled = True
            txtNamaPelanggan.Enabled = True
            txtTarifLangganan.Enabled = True
            cbJenisLangganan.Enabled = True
            tglExpiredDate.Enabled = True
            btnTutup.Visible = True
            btnTambah.Enabled = False
            btnHapus.Enabled = False
        ElseIf btnEdit.Text = "Simpan" Then
            Dim hasil As DateTime = tglExpiredDate.Value
            Dim waktu As String = hasil.Year & "-" & hasil.Month & "-" & hasil.Day & " 00:00:00"
            Dim sql As String = "update tbllangganan set no_plat = '" & txtNoPlatLangganan.Text & "',nama = '" & txtNamaPelanggan.Text & "',jenis = '" & cbJenisLangganan.Text & "',biaya = '" & txtTarifLangganan.Text & "',expired = '" & waktu & "' where id = " & lblIDPelanggan.Text
            MsgBox(sql)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            Dim hsl As Integer = myCommand.ExecuteNonQuery
            If hsl = 1 Then
                MsgBox("Update success!")
                RefreshGrid()
            End If
            btnEdit.Text = "Edit"
            txtNoPlatLangganan.Enabled = False
            txtNamaPelanggan.Enabled = False
            txtTarifLangganan.Enabled = False
            cbJenisLangganan.Enabled = False
            tglExpiredDate.Enabled = False
            btnTutup.Visible = False
            btnTambah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub


End Class