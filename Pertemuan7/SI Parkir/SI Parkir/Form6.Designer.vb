<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class langganan
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
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.Jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPemilik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLangganan = New System.Windows.Forms.DataGridView()
        Me.Expired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDaftarLangganan = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.cbJenisLangganan = New System.Windows.Forms.ComboBox()
        Me.lblJenisLangganan = New System.Windows.Forms.Label()
        Me.lblIDPelanggan = New System.Windows.Forms.Label()
        Me.tglExpiredDate = New System.Windows.Forms.DateTimePicker()
        Me.lblExpiredDate = New System.Windows.Forms.Label()
        Me.txtNoPlatLangganan = New System.Windows.Forms.TextBox()
        Me.lblNoPlatLangganan = New System.Windows.Forms.Label()
        Me.txtTarifLangganan = New System.Windows.Forms.TextBox()
        Me.lblTarifLangganan = New System.Windows.Forms.Label()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        CType(Me.dgvLangganan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(639, 392)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(82, 30)
        Me.btnTutup.TabIndex = 37
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Jenis
        '
        Me.Jenis.HeaderText = "Jenis"
        Me.Jenis.MinimumWidth = 8
        Me.Jenis.Name = "Jenis"
        Me.Jenis.Width = 150
        '
        'Biaya
        '
        Me.Biaya.HeaderText = "Biaya"
        Me.Biaya.MinimumWidth = 8
        Me.Biaya.Name = "Biaya"
        Me.Biaya.Width = 150
        '
        'NamaPemilik
        '
        Me.NamaPemilik.HeaderText = "Nama Pemilik"
        Me.NamaPemilik.MinimumWidth = 8
        Me.NamaPemilik.Name = "NamaPemilik"
        Me.NamaPemilik.Width = 150
        '
        'NoPlat
        '
        Me.NoPlat.HeaderText = "No Plat"
        Me.NoPlat.MinimumWidth = 8
        Me.NoPlat.Name = "NoPlat"
        Me.NoPlat.Width = 150
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.Width = 150
        '
        'dgvLangganan
        '
        Me.dgvLangganan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLangganan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.NoPlat, Me.NamaPemilik, Me.Biaya, Me.Jenis, Me.Expired})
        Me.dgvLangganan.Location = New System.Drawing.Point(83, 215)
        Me.dgvLangganan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvLangganan.Name = "dgvLangganan"
        Me.dgvLangganan.RowHeadersWidth = 62
        Me.dgvLangganan.RowTemplate.Height = 28
        Me.dgvLangganan.Size = New System.Drawing.Size(638, 173)
        Me.dgvLangganan.TabIndex = 36
        '
        'Expired
        '
        Me.Expired.HeaderText = "Expired"
        Me.Expired.MinimumWidth = 8
        Me.Expired.Name = "Expired"
        Me.Expired.Width = 150
        '
        'lblDaftarLangganan
        '
        Me.lblDaftarLangganan.AutoSize = True
        Me.lblDaftarLangganan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaftarLangganan.Location = New System.Drawing.Point(79, 192)
        Me.lblDaftarLangganan.Name = "lblDaftarLangganan"
        Me.lblDaftarLangganan.Size = New System.Drawing.Size(243, 20)
        Me.lblDaftarLangganan.TabIndex = 35
        Me.lblDaftarLangganan.Text = "Kendaraan terdaftar langganan:"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(639, 148)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(82, 30)
        Me.btnHapus.TabIndex = 34
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(543, 148)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(82, 30)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(447, 148)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(82, 30)
        Me.btnTambah.TabIndex = 32
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'cbJenisLangganan
        '
        Me.cbJenisLangganan.FormattingEnabled = True
        Me.cbJenisLangganan.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi/Umum", "Sepeda", "Bus/Truk"})
        Me.cbJenisLangganan.Location = New System.Drawing.Point(518, 68)
        Me.cbJenisLangganan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbJenisLangganan.Name = "cbJenisLangganan"
        Me.cbJenisLangganan.Size = New System.Drawing.Size(204, 24)
        Me.cbJenisLangganan.TabIndex = 31
        '
        'lblJenisLangganan
        '
        Me.lblJenisLangganan.AutoSize = True
        Me.lblJenisLangganan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenisLangganan.Location = New System.Drawing.Point(442, 69)
        Me.lblJenisLangganan.Name = "lblJenisLangganan"
        Me.lblJenisLangganan.Size = New System.Drawing.Size(49, 20)
        Me.lblJenisLangganan.TabIndex = 30
        Me.lblJenisLangganan.Text = "Jenis"
        '
        'lblIDPelanggan
        '
        Me.lblIDPelanggan.AutoSize = True
        Me.lblIDPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDPelanggan.Location = New System.Drawing.Point(513, 30)
        Me.lblIDPelanggan.Name = "lblIDPelanggan"
        Me.lblIDPelanggan.Size = New System.Drawing.Size(114, 20)
        Me.lblIDPelanggan.TabIndex = 29
        Me.lblIDPelanggan.Text = "ID Pelanggan:"
        '
        'tglExpiredDate
        '
        Me.tglExpiredDate.Location = New System.Drawing.Point(238, 153)
        Me.tglExpiredDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tglExpiredDate.Name = "tglExpiredDate"
        Me.tglExpiredDate.Size = New System.Drawing.Size(176, 22)
        Me.tglExpiredDate.TabIndex = 28
        '
        'lblExpiredDate
        '
        Me.lblExpiredDate.AutoSize = True
        Me.lblExpiredDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiredDate.Location = New System.Drawing.Point(79, 152)
        Me.lblExpiredDate.Name = "lblExpiredDate"
        Me.lblExpiredDate.Size = New System.Drawing.Size(120, 20)
        Me.lblExpiredDate.TabIndex = 27
        Me.lblExpiredDate.Text = "Berlaku hingga"
        '
        'txtNoPlatLangganan
        '
        Me.txtNoPlatLangganan.Location = New System.Drawing.Point(238, 68)
        Me.txtNoPlatLangganan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNoPlatLangganan.Name = "txtNoPlatLangganan"
        Me.txtNoPlatLangganan.Size = New System.Drawing.Size(176, 22)
        Me.txtNoPlatLangganan.TabIndex = 26
        '
        'lblNoPlatLangganan
        '
        Me.lblNoPlatLangganan.AutoSize = True
        Me.lblNoPlatLangganan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPlatLangganan.Location = New System.Drawing.Point(79, 69)
        Me.lblNoPlatLangganan.Name = "lblNoPlatLangganan"
        Me.lblNoPlatLangganan.Size = New System.Drawing.Size(93, 20)
        Me.lblNoPlatLangganan.TabIndex = 25
        Me.lblNoPlatLangganan.Text = "Nomor Plat"
        '
        'txtTarifLangganan
        '
        Me.txtTarifLangganan.Location = New System.Drawing.Point(238, 111)
        Me.txtTarifLangganan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTarifLangganan.Name = "txtTarifLangganan"
        Me.txtTarifLangganan.Size = New System.Drawing.Size(176, 22)
        Me.txtTarifLangganan.TabIndex = 24
        '
        'lblTarifLangganan
        '
        Me.lblTarifLangganan.AutoSize = True
        Me.lblTarifLangganan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarifLangganan.Location = New System.Drawing.Point(79, 110)
        Me.lblTarifLangganan.Name = "lblTarifLangganan"
        Me.lblTarifLangganan.Size = New System.Drawing.Size(130, 20)
        Me.lblTarifLangganan.TabIndex = 23
        Me.lblTarifLangganan.Text = "Tarif Langganan"
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(238, 29)
        Me.txtNamaPelanggan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(257, 22)
        Me.txtNamaPelanggan.TabIndex = 22
        '
        'lblNamaPelanggan
        '
        Me.lblNamaPelanggan.AutoSize = True
        Me.lblNamaPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPelanggan.Location = New System.Drawing.Point(79, 30)
        Me.lblNamaPelanggan.Name = "lblNamaPelanggan"
        Me.lblNamaPelanggan.Size = New System.Drawing.Size(136, 20)
        Me.lblNamaPelanggan.TabIndex = 21
        Me.lblNamaPelanggan.Text = "Nama Pelanggan"
        '
        'langganan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.dgvLangganan)
        Me.Controls.Add(Me.lblDaftarLangganan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.cbJenisLangganan)
        Me.Controls.Add(Me.lblJenisLangganan)
        Me.Controls.Add(Me.lblIDPelanggan)
        Me.Controls.Add(Me.tglExpiredDate)
        Me.Controls.Add(Me.lblExpiredDate)
        Me.Controls.Add(Me.txtNoPlatLangganan)
        Me.Controls.Add(Me.lblNoPlatLangganan)
        Me.Controls.Add(Me.txtTarifLangganan)
        Me.Controls.Add(Me.lblTarifLangganan)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.Controls.Add(Me.lblNamaPelanggan)
        Me.Name = "langganan"
        Me.Text = "Form6"
        CType(Me.dgvLangganan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTutup As Button
    Friend WithEvents Jenis As DataGridViewTextBoxColumn
    Friend WithEvents Biaya As DataGridViewTextBoxColumn
    Friend WithEvents NamaPemilik As DataGridViewTextBoxColumn
    Friend WithEvents NoPlat As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents dgvLangganan As DataGridView
    Friend WithEvents Expired As DataGridViewTextBoxColumn
    Friend WithEvents lblDaftarLangganan As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents cbJenisLangganan As ComboBox
    Friend WithEvents lblJenisLangganan As Label
    Friend WithEvents lblIDPelanggan As Label
    Friend WithEvents tglExpiredDate As DateTimePicker
    Friend WithEvents lblExpiredDate As Label
    Friend WithEvents txtNoPlatLangganan As TextBox
    Friend WithEvents lblNoPlatLangganan As Label
    Friend WithEvents txtTarifLangganan As TextBox
    Friend WithEvents lblTarifLangganan As Label
    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents lblNamaPelanggan As Label
End Class
