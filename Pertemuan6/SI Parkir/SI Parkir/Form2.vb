' Form2 - Ubah Profil
' TextBox1 = Username (read-only)
' TextBox3 = Password Baru
' TextBox2 = Ketik Lagi
' Button1 = Simpan, Button2 = Tutup

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = CurrentUser
        TextBox1.ReadOnly = True
        TextBox1.BackColor = System.Drawing.SystemColors.Control
        TextBox3.PasswordChar = "*"c
        TextBox2.PasswordChar = "*"c
        TextBox3.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text = "" Then
            MessageBox.Show("Password baru tidak boleh kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Focus()
            Return
        End If
        If TextBox3.Text <> TextBox2.Text Then
            MessageBox.Show("Password baru tidak cocok! Silakan coba lagi.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Clear()
            TextBox2.Clear()
            TextBox3.Focus()
            Return
        End If
        CurrentPassword = TextBox3.Text
        MessageBox.Show("Password berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
