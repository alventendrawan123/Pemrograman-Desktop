Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decimalValue As Integer

        ' Validasi input
        If Integer.TryParse(txtBilangan.Text, decimalValue) Then
            txtBasis2.Text = Convert.ToString(decimalValue, 2)
            txtBasis8.Text = Convert.ToString(decimalValue, 8)
            txtBasis10.Text = decimalValue.ToString()
            txtBasis16.Text = Convert.ToString(decimalValue, 16).ToUpper()
        Else
            MessageBox.Show("Masukkan bilangan bulat yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
