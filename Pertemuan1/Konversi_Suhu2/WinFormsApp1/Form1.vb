Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtCelcius.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273

        lblFahrenheit.Text = CStr(fahrenheit)
        lblReamur.Text = CStr(reamur)
        lblKelvin.Text = CStr(kelvin)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCelcius_TextChanged(sender As Object, e As EventArgs) Handles txtCelcius.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblKelvin.Click

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click

    End Sub
End Class
