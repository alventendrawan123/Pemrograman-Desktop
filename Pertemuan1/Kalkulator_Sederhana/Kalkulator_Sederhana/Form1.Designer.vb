<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        txtInput = New TextBox()
        Panel2 = New Panel()
        CmdSubtract = New Button()
        CmdAddition = New Button()
        CmdEqual = New Button()
        CmdInverse = New Button()
        CmdSqrt = New Button()
        CmdMultiply = New Button()
        Cmd3 = New Button()
        CmdDecimal = New Button()
        Cmd8 = New Button()
        Cmd9 = New Button()
        Cmd4 = New Button()
        Cmd5 = New Button()
        Cmd1 = New Button()
        Cmd0 = New Button()
        Cmd2 = New Button()
        CmdSign = New Button()
        cmdCE = New Button()
        cmdC = New Button()
        CmdDivision = New Button()
        CmdPowerOf = New Button()
        Cmd6 = New Button()
        Cmd7 = New Button()
        cmdBackspace = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtInput)
        Panel1.Location = New Point(12, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(407, 87)
        Panel1.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 18F)
        txtInput.Location = New Point(20, 18)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(378, 54)
        txtInput.TabIndex = 0
        txtInput.Text = "0"
        txtInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CmdSubtract)
        Panel2.Controls.Add(CmdAddition)
        Panel2.Controls.Add(CmdEqual)
        Panel2.Controls.Add(CmdInverse)
        Panel2.Controls.Add(CmdSqrt)
        Panel2.Controls.Add(CmdMultiply)
        Panel2.Controls.Add(Cmd3)
        Panel2.Controls.Add(CmdDecimal)
        Panel2.Controls.Add(Cmd8)
        Panel2.Controls.Add(Cmd9)
        Panel2.Controls.Add(Cmd4)
        Panel2.Controls.Add(Cmd5)
        Panel2.Controls.Add(Cmd1)
        Panel2.Controls.Add(Cmd0)
        Panel2.Controls.Add(Cmd2)
        Panel2.Controls.Add(CmdSign)
        Panel2.Controls.Add(cmdCE)
        Panel2.Controls.Add(cmdC)
        Panel2.Controls.Add(CmdDivision)
        Panel2.Controls.Add(CmdPowerOf)
        Panel2.Controls.Add(Cmd6)
        Panel2.Controls.Add(Cmd7)
        Panel2.Controls.Add(cmdBackspace)
        Panel2.Location = New Point(12, 151)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(407, 340)
        Panel2.TabIndex = 1
        ' 
        ' CmdSubtract
        ' 
        CmdSubtract.Location = New Point(250, 185)
        CmdSubtract.Name = "CmdSubtract"
        CmdSubtract.Size = New Size(59, 50)
        CmdSubtract.TabIndex = 22
        CmdSubtract.Text = "-"
        CmdSubtract.UseVisualStyleBackColor = True
        ' 
        ' CmdAddition
        ' 
        CmdAddition.Location = New Point(250, 241)
        CmdAddition.Name = "CmdAddition"
        CmdAddition.Size = New Size(59, 50)
        CmdAddition.TabIndex = 21
        CmdAddition.Text = "+"
        CmdAddition.UseVisualStyleBackColor = True
        ' 
        ' CmdEqual
        ' 
        CmdEqual.Location = New Point(318, 241)
        CmdEqual.Name = "CmdEqual"
        CmdEqual.Size = New Size(59, 50)
        CmdEqual.TabIndex = 20
        CmdEqual.Text = "="
        CmdEqual.UseVisualStyleBackColor = True
        ' 
        ' CmdInverse
        ' 
        CmdInverse.Location = New Point(318, 185)
        CmdInverse.Name = "CmdInverse"
        CmdInverse.Size = New Size(59, 50)
        CmdInverse.TabIndex = 19
        CmdInverse.Text = "1/X"
        CmdInverse.UseVisualStyleBackColor = True
        ' 
        ' CmdSqrt
        ' 
        CmdSqrt.Location = New Point(318, 127)
        CmdSqrt.Name = "CmdSqrt"
        CmdSqrt.Size = New Size(86, 50)
        CmdSqrt.TabIndex = 18
        CmdSqrt.Text = "SQRT"
        CmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' CmdMultiply
        ' 
        CmdMultiply.Location = New Point(250, 129)
        CmdMultiply.Name = "CmdMultiply"
        CmdMultiply.Size = New Size(59, 50)
        CmdMultiply.TabIndex = 17
        CmdMultiply.Text = "*"
        CmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' Cmd3
        ' 
        Cmd3.Location = New Point(150, 185)
        Cmd3.Name = "Cmd3"
        Cmd3.Size = New Size(59, 50)
        Cmd3.TabIndex = 16
        Cmd3.Text = "3"
        Cmd3.UseVisualStyleBackColor = True
        ' 
        ' CmdDecimal
        ' 
        CmdDecimal.Location = New Point(150, 241)
        CmdDecimal.Name = "CmdDecimal"
        CmdDecimal.Size = New Size(59, 50)
        CmdDecimal.TabIndex = 15
        CmdDecimal.Text = "."
        CmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' Cmd8
        ' 
        Cmd8.Location = New Point(85, 71)
        Cmd8.Name = "Cmd8"
        Cmd8.Size = New Size(59, 50)
        Cmd8.TabIndex = 14
        Cmd8.Text = "8"
        Cmd8.UseVisualStyleBackColor = True
        ' 
        ' Cmd9
        ' 
        Cmd9.Location = New Point(150, 71)
        Cmd9.Name = "Cmd9"
        Cmd9.Size = New Size(59, 50)
        Cmd9.TabIndex = 13
        Cmd9.Text = "9"
        Cmd9.UseVisualStyleBackColor = True
        ' 
        ' Cmd4
        ' 
        Cmd4.Location = New Point(20, 127)
        Cmd4.Name = "Cmd4"
        Cmd4.Size = New Size(59, 50)
        Cmd4.TabIndex = 12
        Cmd4.Text = "4"
        Cmd4.UseVisualStyleBackColor = True
        ' 
        ' Cmd5
        ' 
        Cmd5.Location = New Point(85, 127)
        Cmd5.Name = "Cmd5"
        Cmd5.Size = New Size(59, 50)
        Cmd5.TabIndex = 11
        Cmd5.Text = "5"
        Cmd5.UseVisualStyleBackColor = True
        ' 
        ' Cmd1
        ' 
        Cmd1.Location = New Point(20, 185)
        Cmd1.Name = "Cmd1"
        Cmd1.Size = New Size(59, 50)
        Cmd1.TabIndex = 10
        Cmd1.Text = "1"
        Cmd1.UseVisualStyleBackColor = True
        ' 
        ' Cmd0
        ' 
        Cmd0.Location = New Point(20, 241)
        Cmd0.Name = "Cmd0"
        Cmd0.Size = New Size(59, 50)
        Cmd0.TabIndex = 9
        Cmd0.Text = "0"
        Cmd0.UseVisualStyleBackColor = True
        ' 
        ' Cmd2
        ' 
        Cmd2.Location = New Point(85, 185)
        Cmd2.Name = "Cmd2"
        Cmd2.Size = New Size(59, 50)
        Cmd2.TabIndex = 8
        Cmd2.Text = "2"
        Cmd2.UseVisualStyleBackColor = True
        ' 
        ' CmdSign
        ' 
        CmdSign.Location = New Point(85, 241)
        CmdSign.Name = "CmdSign"
        CmdSign.Size = New Size(59, 50)
        CmdSign.TabIndex = 7
        CmdSign.Text = "+/-"
        CmdSign.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(250, 18)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(59, 50)
        cmdCE.TabIndex = 6
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(318, 18)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(59, 50)
        cmdC.TabIndex = 5
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' CmdDivision
        ' 
        CmdDivision.Location = New Point(250, 74)
        CmdDivision.Name = "CmdDivision"
        CmdDivision.Size = New Size(59, 50)
        CmdDivision.TabIndex = 4
        CmdDivision.Text = "/"
        CmdDivision.UseVisualStyleBackColor = True
        ' 
        ' CmdPowerOf
        ' 
        CmdPowerOf.Location = New Point(318, 74)
        CmdPowerOf.Name = "CmdPowerOf"
        CmdPowerOf.Size = New Size(59, 50)
        CmdPowerOf.TabIndex = 3
        CmdPowerOf.Text = "X^"
        CmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' Cmd6
        ' 
        Cmd6.Location = New Point(150, 127)
        Cmd6.Name = "Cmd6"
        Cmd6.Size = New Size(59, 50)
        Cmd6.TabIndex = 2
        Cmd6.Text = "6"
        Cmd6.UseVisualStyleBackColor = True
        ' 
        ' Cmd7
        ' 
        Cmd7.Location = New Point(20, 71)
        Cmd7.Name = "Cmd7"
        Cmd7.Size = New Size(59, 50)
        Cmd7.TabIndex = 1
        Cmd7.Text = "7"
        Cmd7.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(15, 18)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(112, 47)
        cmdBackspace.TabIndex = 0
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 517)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents CmdSubtract As Button
    Friend WithEvents CmdAddition As Button
    Friend WithEvents CmdEqual As Button
    Friend WithEvents CmdInverse As Button
    Friend WithEvents CmdSqrt As Button
    Friend WithEvents CmdMultiply As Button
    Friend WithEvents Cmd3 As Button
    Friend WithEvents CmdDecimal As Button
    Friend WithEvents Cmd8 As Button
    Friend WithEvents Cmd9 As Button
    Friend WithEvents Cmd4 As Button
    Friend WithEvents Cmd5 As Button
    Friend WithEvents Cmd1 As Button
    Friend WithEvents Cmd0 As Button
    Friend WithEvents Cmd2 As Button
    Friend WithEvents CmdSign As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents CmdDivision As Button
    Friend WithEvents CmdPowerOf As Button
    Friend WithEvents Cmd6 As Button
    Friend WithEvents Cmd7 As Button

End Class
