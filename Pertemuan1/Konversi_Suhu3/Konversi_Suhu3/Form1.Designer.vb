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
        lblCelcius = New Label()
        txtCelcius = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        txtFahrenheit = New TextBox()
        txtReamur = New TextBox()
        txtKelvin = New TextBox()
        SuspendLayout()
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(97, 138)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(66, 25)
        lblCelcius.TabIndex = 0
        lblCelcius.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(215, 138)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(150, 31)
        txtCelcius.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(420, 138)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(587, 138)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 3
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(191, 271)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(150, 31)
        txtFahrenheit.TabIndex = 4
        ' 
        ' txtReamur
        ' 
        txtReamur.Location = New Point(382, 271)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(150, 31)
        txtReamur.TabIndex = 5
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Location = New Point(568, 271)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(150, 31)
        txtKelvin.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtKelvin)
        Controls.Add(txtReamur)
        Controls.Add(txtFahrenheit)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtCelcius)
        Controls.Add(lblCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtKelvin As TextBox

End Class
