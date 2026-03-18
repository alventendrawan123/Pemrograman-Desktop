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
        txtBilangan = New TextBox()
        txtBasis8 = New TextBox()
        txtBasis2 = New TextBox()
        txtBasis10 = New TextBox()
        txtBasis16 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnConvert = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' txtBilangan
        ' 
        txtBilangan.Location = New Point(166, 67)
        txtBilangan.Name = "txtBilangan"
        txtBilangan.Size = New Size(150, 31)
        txtBilangan.TabIndex = 0
        txtBilangan.TabStop = False
        ' 
        ' txtBasis8
        ' 
        txtBasis8.Location = New Point(166, 166)
        txtBasis8.Name = "txtBasis8"
        txtBasis8.Size = New Size(150, 31)
        txtBasis8.TabIndex = 1
        ' 
        ' txtBasis2
        ' 
        txtBasis2.Location = New Point(166, 129)
        txtBasis2.Name = "txtBasis2"
        txtBasis2.Size = New Size(150, 31)
        txtBasis2.TabIndex = 2
        ' 
        ' txtBasis10
        ' 
        txtBasis10.Location = New Point(166, 203)
        txtBasis10.Name = "txtBasis10"
        txtBasis10.Size = New Size(150, 31)
        txtBasis10.TabIndex = 3
        ' 
        ' txtBasis16
        ' 
        txtBasis16.Location = New Point(166, 240)
        txtBasis16.Name = "txtBasis16"
        txtBasis16.Size = New Size(150, 31)
        txtBasis16.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(81, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 25)
        Label1.TabIndex = 5
        Label1.Text = "Bilangan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(81, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 25)
        Label2.TabIndex = 6
        Label2.Text = "Basis 16"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(81, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 25)
        Label3.TabIndex = 7
        Label3.Text = "Basis 8"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(81, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 25)
        Label4.TabIndex = 8
        Label4.Text = "Basis 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(81, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 25)
        Label5.TabIndex = 9
        Label5.Text = "Basis 10"
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(393, 65)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 10
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(542, 64)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 11
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtBasis16)
        Controls.Add(txtBasis10)
        Controls.Add(txtBasis2)
        Controls.Add(txtBasis8)
        Controls.Add(txtBilangan)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBilangan As TextBox
    Friend WithEvents txtBasis8 As TextBox
    Friend WithEvents txtBasis2 As TextBox
    Friend WithEvents txtBasis10 As TextBox
    Friend WithEvents txtBasis16 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button

End Class
