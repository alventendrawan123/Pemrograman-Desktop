Public Class Form1
    Private Sub btnFaktorial_Click(sender As Object, e As EventArgs) Handles btnFaktorial.Click
        Dim n As Integer
        Dim hasil As Long = 1

        If Integer.TryParse(txtInput.Text, n) AndAlso n >= 0 Then
            For i As Integer = 1 To n
                hasil *= i
            Next
            txtHasil.Text = hasil.ToString()
        Else
            MessageBox.Show("Masukkan bilangan bulat positif!", "Error")
        End If
    End Sub

End Class
