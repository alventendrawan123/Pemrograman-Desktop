Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCelcius.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFahrenheit.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtKelvin.TextChanged

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtCelcius.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273

        txtFahrenheit.Text = CStr(fahrenheit)
        txtReamur.Text = CStr(reamur)
        txtKelvin.Text = CStr(kelvin)

    End Sub
End Class
