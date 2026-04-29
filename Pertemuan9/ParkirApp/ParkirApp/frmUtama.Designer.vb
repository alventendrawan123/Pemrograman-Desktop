<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlPlat = New System.Windows.Forms.Panel()
        Me.lblPlat = New System.Windows.Forms.Label()
        Me.lblInputPlat = New System.Windows.Forms.Label()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarKendaraanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPendapatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.pnlHarga = New System.Windows.Forms.Panel()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblTekan = New System.Windows.Forms.Label()
        Me.lblInfoJenis = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKeluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInfoUser = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.lblJmlKendaraan = New System.Windows.Forms.Label()
        Me.pnlPlat.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlHarga.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPlat
        '
        Me.pnlPlat.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlPlat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPlat.Controls.Add(Me.lblPlat)
        Me.pnlPlat.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPlat.Location = New System.Drawing.Point(0, 30)
        Me.pnlPlat.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlPlat.Name = "pnlPlat"
        Me.pnlPlat.Size = New System.Drawing.Size(1153, 154)
        Me.pnlPlat.TabIndex = 0
        '
        'lblPlat
        '
        Me.lblPlat.AutoSize = True
        Me.lblPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlat.Location = New System.Drawing.Point(151, 11)
        Me.lblPlat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlat.Name = "lblPlat"
        Me.lblPlat.Size = New System.Drawing.Size(719, 135)
        Me.lblPlat.TabIndex = 1
        Me.lblPlat.Text = "AB 1234 XY"
        '
        'lblInputPlat
        '
        Me.lblInputPlat.AutoSize = True
        Me.lblInputPlat.Location = New System.Drawing.Point(13, 22)
        Me.lblInputPlat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInputPlat.Name = "lblInputPlat"
        Me.lblInputPlat.Size = New System.Drawing.Size(64, 16)
        Me.lblInputPlat.TabIndex = 1
        Me.lblInputPlat.Text = "Input Plat:"
        '
        'txtPlat
        '
        Me.txtPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlat.Location = New System.Drawing.Point(95, 16)
        Me.txtPlat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.Size = New System.Drawing.Size(196, 30)
        Me.txtPlat.TabIndex = 1
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(13, 58)
        Me.lblJenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(356, 16)
        Me.lblJenis.TabIndex = 3
        Me.lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 - Taksi, F4 - Sepeda, F5 - Bis/Truk"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemToolStripMenuItem, Me.AdminToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1153, 30)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemToolStripMenuItem
        '
        Me.SistemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilToolStripMenuItem1, Me.LogoutToolStripMenuItem})
        Me.SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        Me.SistemToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.SistemToolStripMenuItem.Text = "Sistem"
        '
        'ProfilToolStripMenuItem1
        '
        Me.ProfilToolStripMenuItem1.Name = "ProfilToolStripMenuItem1"
        Me.ProfilToolStripMenuItem1.Size = New System.Drawing.Size(139, 26)
        Me.ProfilToolStripMenuItem1.Text = "Profil"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarKendaraanToolStripMenuItem, Me.LaporanPendapatanToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'DaftarKendaraanToolStripMenuItem
        '
        Me.DaftarKendaraanToolStripMenuItem.Name = "DaftarKendaraanToolStripMenuItem"
        Me.DaftarKendaraanToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.DaftarKendaraanToolStripMenuItem.Text = "Kendaraan Langganan"
        '
        'LaporanPendapatanToolStripMenuItem
        '
        Me.LaporanPendapatanToolStripMenuItem.Name = "LaporanPendapatanToolStripMenuItem"
        Me.LaporanPendapatanToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.LaporanPendapatanToolStripMenuItem.Text = "Laporan Pendapatan"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem1, Me.TentangToolStripMenuItem})
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'BantuanToolStripMenuItem1
        '
        Me.BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        Me.BantuanToolStripMenuItem1.Size = New System.Drawing.Size(146, 26)
        Me.BantuanToolStripMenuItem1.Text = "Bantuan"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(16, 17)
        Me.lblHarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(90, 42)
        Me.lblHarga.TabIndex = 9
        Me.lblHarga.Text = "Rp. "
        '
        'pnlHarga
        '
        Me.pnlHarga.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHarga.Controls.Add(Me.lblHarga)
        Me.pnlHarga.Location = New System.Drawing.Point(0, 193)
        Me.pnlHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHarga.Name = "pnlHarga"
        Me.pnlHarga.Size = New System.Drawing.Size(412, 78)
        Me.pnlHarga.TabIndex = 10
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInput.Controls.Add(Me.lblTekan)
        Me.pnlInput.Controls.Add(Me.lblInfoJenis)
        Me.pnlInput.Controls.Add(Me.txtPlat)
        Me.pnlInput.Controls.Add(Me.lblInputPlat)
        Me.pnlInput.Controls.Add(Me.lblJenis)
        Me.pnlInput.Location = New System.Drawing.Point(0, 281)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(412, 125)
        Me.pnlInput.TabIndex = 11
        '
        'lblTekan
        '
        Me.lblTekan.AutoSize = True
        Me.lblTekan.Location = New System.Drawing.Point(13, 85)
        Me.lblTekan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTekan.Name = "lblTekan"
        Me.lblTekan.Size = New System.Drawing.Size(205, 16)
        Me.lblTekan.TabIndex = 5
        Me.lblTekan.Text = "Tekan Enter untuk Masuk / Keluar"
        '
        'lblInfoJenis
        '
        Me.lblInfoJenis.AutoSize = True
        Me.lblInfoJenis.Location = New System.Drawing.Point(300, 22)
        Me.lblInfoJenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfoJenis.Name = "lblInfoJenis"
        Me.lblInfoJenis.Size = New System.Drawing.Size(0, 16)
        Me.lblInfoJenis.TabIndex = 4
        '
        'pnlGrid
        '
        Me.pnlGrid.AutoScroll = True
        Me.pnlGrid.Controls.Add(Me.DataGridView1)
        Me.pnlGrid.Location = New System.Drawing.Point(421, 193)
        Me.pnlGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(725, 334)
        Me.pnlGrid.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColPlat, Me.ColMasuk, Me.ColKeluar, Me.ColHarga, Me.ColJenis, Me.ColId})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(725, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'ColPlat
        '
        Me.ColPlat.Frozen = True
        Me.ColPlat.HeaderText = "No. Plat"
        Me.ColPlat.MinimumWidth = 6
        Me.ColPlat.Name = "ColPlat"
        Me.ColPlat.Width = 125
        '
        'ColMasuk
        '
        Me.ColMasuk.HeaderText = "Masuk"
        Me.ColMasuk.MinimumWidth = 6
        Me.ColMasuk.Name = "ColMasuk"
        Me.ColMasuk.Width = 125
        '
        'ColKeluar
        '
        Me.ColKeluar.HeaderText = "Keluar"
        Me.ColKeluar.MinimumWidth = 6
        Me.ColKeluar.Name = "ColKeluar"
        Me.ColKeluar.Width = 125
        '
        'ColHarga
        '
        Me.ColHarga.HeaderText = "Harga"
        Me.ColHarga.MinimumWidth = 6
        Me.ColHarga.Name = "ColHarga"
        Me.ColHarga.Width = 125
        '
        'ColJenis
        '
        Me.ColJenis.HeaderText = "Jenis"
        Me.ColJenis.MinimumWidth = 6
        Me.ColJenis.Name = "ColJenis"
        Me.ColJenis.Width = 125
        '
        'ColId
        '
        Me.ColId.HeaderText = "id"
        Me.ColId.MinimumWidth = 6
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.Visible = False
        Me.ColId.Width = 125
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 28)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'lblInfoUser
        '
        Me.lblInfoUser.AutoSize = True
        Me.lblInfoUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoUser.Location = New System.Drawing.Point(15, 421)
        Me.lblInfoUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfoUser.Name = "lblInfoUser"
        Me.lblInfoUser.Size = New System.Drawing.Size(106, 20)
        Me.lblInfoUser.TabIndex = 13
        Me.lblInfoUser.Text = "Informasi - "
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(13, 448)
        Me.lblTgl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(67, 16)
        Me.lblTgl.TabIndex = 14
        Me.lblTgl.Text = "Tanggal : "
        '
        'lblJmlKendaraan
        '
        Me.lblJmlKendaraan.AutoSize = True
        Me.lblJmlKendaraan.Location = New System.Drawing.Point(13, 475)
        Me.lblJmlKendaraan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJmlKendaraan.Name = "lblJmlKendaraan"
        Me.lblJmlKendaraan.Size = New System.Drawing.Size(281, 16)
        Me.lblJmlKendaraan.TabIndex = 15
        Me.lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1153, 534)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.lblJmlKendaraan)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.lblInfoUser)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlHarga)
        Me.Controls.Add(Me.pnlPlat)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parking System v1"
        Me.pnlPlat.ResumeLayout(False)
        Me.pnlPlat.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlHarga.ResumeLayout(False)
        Me.pnlHarga.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlPlat As System.Windows.Forms.Panel
    Friend WithEvents lblPlat As System.Windows.Forms.Label
    Friend WithEvents lblInputPlat As System.Windows.Forms.Label
    Friend WithEvents txtPlat As System.Windows.Forms.TextBox
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SistemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarKendaraanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPendapatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents pnlHarga As System.Windows.Forms.Panel
    Friend WithEvents pnlInput As System.Windows.Forms.Panel
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblInfoUser As System.Windows.Forms.Label
    Friend WithEvents ProfilToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTgl As System.Windows.Forms.Label
    Friend WithEvents lblJmlKendaraan As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblInfoJenis As System.Windows.Forms.Label
    Friend WithEvents lblTekan As System.Windows.Forms.Label
    Friend WithEvents ColPlat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColId As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
