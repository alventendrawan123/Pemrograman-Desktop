<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLaporan = New System.Windows.Forms.Label()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.cbPeriode = New System.Windows.Forms.ComboBox()
        Me.lblPeriode = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblLaporan
        '
        Me.lblLaporan.AutoSize = True
        Me.lblLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaporan.Location = New System.Drawing.Point(30, 71)
        Me.lblLaporan.Name = "lblLaporan"
        Me.lblLaporan.Size = New System.Drawing.Size(75, 20)
        Me.lblLaporan.TabIndex = 22
        Me.lblLaporan.Text = "Laporan:"
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Location = New System.Drawing.Point(425, 22)
        Me.btnTampilkan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(109, 30)
        Me.btnTampilkan.TabIndex = 21
        Me.btnTampilkan.Text = "Tampilkan!"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'txtTahun
        '
        Me.txtTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTahun.Location = New System.Drawing.Point(291, 24)
        Me.txtTahun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(114, 26)
        Me.txtTahun.TabIndex = 20
        Me.txtTahun.Text = "Tahun"
        '
        'cbPeriode
        '
        Me.cbPeriode.FormattingEnabled = True
        Me.cbPeriode.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cbPeriode.Location = New System.Drawing.Point(106, 26)
        Me.cbPeriode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPeriode.Name = "cbPeriode"
        Me.cbPeriode.Size = New System.Drawing.Size(168, 24)
        Me.cbPeriode.TabIndex = 19
        Me.cbPeriode.Text = "Bulan"
        '
        'lblPeriode
        '
        Me.lblPeriode.AutoSize = True
        Me.lblPeriode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriode.Location = New System.Drawing.Point(30, 25)
        Me.lblPeriode.Name = "lblPeriode"
        Me.lblPeriode.Size = New System.Drawing.Size(66, 20)
        Me.lblPeriode.TabIndex = 18
        Me.lblPeriode.Text = "Periode"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(582, 386)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(82, 30)
        Me.btnTutup.TabIndex = 23
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(34, 110)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(641, 257)
        Me.TextBox1.TabIndex = 24
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.lblLaporan)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.cbPeriode)
        Me.Controls.Add(Me.lblPeriode)
        Me.Name = "Form5"
        Me.Text = "SIParkir-Laporan Pendapatan Parkir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLaporan As Label
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents cbPeriode As ComboBox
    Friend WithEvents lblPeriode As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents TextBox1 As TextBox
End Class
