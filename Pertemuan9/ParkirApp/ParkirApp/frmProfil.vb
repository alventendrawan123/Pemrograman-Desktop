Imports MySql.Data.MySqlClient

Public Class frmProfil

    Private Sub frmProfil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtUsername.Text = pengguna
        txtPassword.Text = ppassword
    End Sub

    Private Sub frmProfil_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If txtPassword.Text = txtRetype.Text Then
            Dim sql As String = "update " & tbluser & " set password='" & txtPassword.Text & "' where username='" & pengguna & "'"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            If myCommand.ExecuteNonQuery = 1 Then
                MsgBox("Password berhasil diganti, silahkan login ulang!")
                frmLogin.txtPassword.Clear()
                frmLogin.txtUsername.Clear()
                Me.Close()
                frmUtama.Close()
                frmLogin.txtUsername.Focus()
                frmLogin.ShowDialog()
            End If
        ElseIf txtRetype.Text <> "" Then
            MsgBox("Password tidak sama!")
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class