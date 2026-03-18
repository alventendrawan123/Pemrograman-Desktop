Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Deklarasi variabel
        Dim celcius As Double
        Dim fahrenheit As Double
        Dim reamur As Double
        Dim kelvin As Double

        ' Ambil nilai dari input teks
        celcius = Val(txtCelcius.Text)

        ' Konversi suhu
        fahrenheit = (9 / 5 * celcius) + 32
        reamur = (4 / 5 * celcius)
        kelvin = celcius + 273

        ' Tampilkan hasil konversi
        MsgBox("Fahrenheit = " & fahrenheit & vbCrLf &
               "Reamur = " & reamur & vbCrLf &
               "Kelvin = " & kelvin)

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
