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
        btnAkar3 = New Button()
        txtInput = New TextBox()
        txtHasil = New TextBox()
        SuspendLayout()
        ' 
        ' btnAkar3
        ' 
        btnAkar3.Location = New Point(88, 139)
        btnAkar3.Name = "btnAkar3"
        btnAkar3.Size = New Size(112, 34)
        btnAkar3.TabIndex = 0
        btnAkar3.Text = "(∛x)"
        btnAkar3.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(248, 141)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(150, 31)
        txtInput.TabIndex = 1
        ' 
        ' txtHasil
        ' 
        txtHasil.Location = New Point(421, 142)
        txtHasil.Name = "txtHasil"
        txtHasil.Size = New Size(150, 31)
        txtHasil.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtHasil)
        Controls.Add(txtInput)
        Controls.Add(btnAkar3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAkar3 As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtHasil As TextBox

End Class
