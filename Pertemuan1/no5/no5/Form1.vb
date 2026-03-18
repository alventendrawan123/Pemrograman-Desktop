Public Class Form1
    Private Sub btnAkar3_Click(sender As Object, e As EventArgs) Handles btnAkar3.Click
        Dim nilai As Double

        If Double.TryParse(txtInput.Text, nilai) Then
            Dim hasil As Double = Math.Pow(nilai, 1 / 3)
            txtHasil.Text = hasil.ToString("F4") ' 4 angka di belakang koma
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error")
        End If
    End Sub

End Class
