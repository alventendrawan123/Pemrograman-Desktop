Public Class Form1
    Private valHolder1 As Double
    Private valHolder2 As Double
    Private tmpValue As Double
    Private hasDecimal As Boolean
    Private inputStatus As Boolean = True
    Private clearText As Boolean
    Private calcFunc As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles cmdCE.Click
        txtInput.Text = String.Empty
        hasDecimal = False
    End Sub

    Private Sub Cmd1_Click(sender As Object, e As EventArgs) Handles Cmd1.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd1.Text
        Else
            txtInput.Text = Cmd1.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Cmd2_Click(sender As Object, e As EventArgs) Handles Cmd2.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd2.Text
        Else
            txtInput.Text = Cmd2.Text
            inputStatus = False
        End If

    End Sub

    Private Sub Cmd3_Click(sender As Object, e As EventArgs) Handles Cmd3.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd3.Text
        Else
            txtInput.Text = Cmd3.Text
            inputStatus = False
        End If

    End Sub

    Private Sub Cmd4_Click(sender As Object, e As EventArgs) Handles Cmd4.Click
        If inputStatus = False Then
            txtInput.Text += Cmd4.Text
        Else
            txtInput.Text = Cmd4.Text
            inputStatus = False
        End If

    End Sub

    Private Sub Cmd5_Click(sender As Object, e As EventArgs) Handles Cmd5.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd5.Text
        Else
            txtInput.Text = Cmd5.Text
            inputStatus = False
        End If

    End Sub

    Private Sub Cmd6_Click(sender As Object, e As EventArgs) Handles Cmd6.Click
        If inputStatus = False Then
            txtInput.Text += Cmd6.Text
        Else
            txtInput.Text = Cmd6.Text
            inputStatus = False
        End If

    End Sub

    Private Sub Cmd7_Click(sender As Object, e As EventArgs) Handles Cmd7.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd7.Text
        Else
            txtInput.Text = Cmd7.Text
            inputStatus = False
        End If

    End Sub

    Private Sub Cmd8_Click(sender As Object, e As EventArgs) Handles Cmd8.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd8.Text
        Else
            txtInput.Text = Cmd8.Text
            inputStatus = False
        End If

    End Sub

    Private Sub Cmd9_Click(sender As Object, e As EventArgs) Handles Cmd9.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd9.Text
        Else
            txtInput.Text = Cmd9.Text
            inputStatus = False
        End If

    End Sub

    Private Sub Cmd0_Click(sender As Object, e As EventArgs) Handles Cmd0.Click
        If inputStatus = False Then
            If txtInput.Text.Length >= 1 Then
                txtInput.Text &= Cmd0.Text
            End If
        End If

    End Sub

    Private Sub CmdDecimal_Click(sender As Object, e As EventArgs) Handles CmdDecimal.Click
        If inputStatus Then
            If Not hasDecimal Then
                If txtInput.Text.Length > 1 Then
                    If Not txtInput.Text = "0" Then
                        txtInput.Text &= CmdDecimal.Text
                        hasDecimal = True
                    End If
                Else
                    txtInput.Text = "0."
                End If
            End If
        End If

    End Sub

    Private Sub CalculateTotals()
        valHolder2 = CType(txtInput.Text, Double)
        Select Case calcFunc
            Case "Add"
                valHolder1 = valHolder1 + valHolder2
            Case "Subtract"
                valHolder1 = valHolder1 - valHolder2
            Case "Divide"
                valHolder1 = valHolder1 / valHolder2
            Case "Multiply"
                valHolder1 = valHolder1 * valHolder2
            Case "PowerOf"
                valHolder1 = System.Math.Pow(valHolder1, valHolder2)
        End Select
        txtInput.Text = CType(valHolder1, String)
        inputStatus = True
    End Sub

    Private Sub cmdC_Click(sender As Object, e As EventArgs) Handles cmdC.Click
        txtInput.Text = String.Empty
        valHolder1 = 0
        valHolder2 = 0
        calcFunc = String.Empty
        hasDecimal = False
    End Sub

    Private Sub cmdBackspace_Click(sender As Object, e As EventArgs) Handles cmdBackspace.Click
        Dim str As String
        Dim loc As Integer
        If txtInput.Text.Length > 0 Then
            str = txtInput.Text.Chars(txtInput.Text.Length - 1)
            'Jika karakter terakhir adalah , (decimal)
            If str = "." Then
                hasDecimal = False
            End If
            loc = txtInput.Text.Length
            txtInput.Text = txtInput.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub CmdAddition_Click(sender As Object, e As EventArgs) Handles CmdAddition.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(txtInput.Text)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Add"
            hasDecimal = False
        End If
    End Sub

    Private Sub CmdSubtract_Click(sender As Object, e As EventArgs) Handles CmdSubtract.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(txtInput.Text, Double)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Subtract"
            hasDecimal = False
        End If
    End Sub

    Private Sub CmdMultiply_Click(sender As Object, e As EventArgs) Handles CmdMultiply.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(txtInput.Text)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Multiply"
            hasDecimal = False
        End If
    End Sub

    Private Sub CmdDivision_Click(sender As Object, e As EventArgs) Handles CmdDivision.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(txtInput.Text, Double)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Divide"
            hasDecimal = False
        End If
    End Sub

    Private Sub CmdSqrt_Click(sender As Object, e As EventArgs) Handles CmdSqrt.Click
        If txtInput.Text.Length <> 0 Then
            tmpValue = CType(txtInput.Text, Double)
            tmpValue = System.Math.Sqrt(tmpValue)
            txtInput.Text = CType(tmpValue, String)
            hasDecimal = False
        End If
    End Sub

    Private Sub CmdPowerOf_Click(sender As Object, e As EventArgs) Handles CmdPowerOf.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(txtInput.Text, Double)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "PowerOf"
            hasDecimal = False
        End If
    End Sub

    Private Sub CmdEqual_Click(sender As Object, e As EventArgs) Handles CmdEqual.Click
        If txtInput.Text.Length <> 0 AndAlso valHolder1 <> 0 Then
            CalculateTotals()
            calcFunc = ""
            hasDecimal = False
        End If
    End Sub

    Private Sub CmdSign_Click(sender As Object, e As EventArgs) Handles CmdSign.Click
        If inputStatus = False Then
            If txtInput.Text.Length > 0 Then
                valHolder1 = -1 * CDbl(txtInput.Text)
                txtInput.Text = CStr(valHolder1)
            End If
        End If
    End Sub

    Private Sub CmdInverse_Click(sender As Object, e As EventArgs) Handles CmdInverse.Click
        If txtInput.Text.Length <> 0 Then
            tmpValue = CDbl(txtInput.Text)
            tmpValue = 1 / tmpValue
            txtInput.Text = CStr(tmpValue)
            hasDecimal = False
        End If
    End Sub
End Class
