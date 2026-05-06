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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        BukaToolStripMenuItem = New ToolStripMenuItem()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        ShapeIsian = New Panel()
        ShapeTepi = New Panel()
        NumericUpDown1 = New NumericUpDown()
        lblukuran = New Label()
        RadioElipsIsi = New RadioButton()
        RadioGaris = New RadioButton()
        RadioKotak = New RadioButton()
        RadioKotakIsi = New RadioButton()
        RadioElips = New RadioButton()
        RadioBebas = New RadioButton()
        GroupBox2 = New GroupBox()
        Warna6 = New Panel()
        Warna4 = New Panel()
        Warna5 = New Panel()
        Warna3 = New Panel()
        Warna2 = New Panel()
        Warna1 = New Panel()
        btnGbrUlang = New Button()
        btnBersihkan = New Button()
        btnUndo = New Button()
        GroupBox3 = New GroupBox()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1030, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BukaToolStripMenuItem, SimpanToolStripMenuItem, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(174, 34)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(174, 34)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(174, 34)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ShapeIsian)
        GroupBox1.Controls.Add(ShapeTepi)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(lblukuran)
        GroupBox1.Controls.Add(RadioElipsIsi)
        GroupBox1.Controls.Add(RadioGaris)
        GroupBox1.Controls.Add(RadioKotak)
        GroupBox1.Controls.Add(RadioKotakIsi)
        GroupBox1.Controls.Add(RadioElips)
        GroupBox1.Controls.Add(RadioBebas)
        GroupBox1.Dock = DockStyle.Left
        GroupBox1.Location = New Point(0, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(188, 533)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tools"
        ' 
        ' ShapeIsian
        ' 
        ShapeIsian.BackColor = Color.White
        ShapeIsian.Location = New Point(99, 438)
        ShapeIsian.Name = "ShapeIsian"
        ShapeIsian.Size = New Size(43, 49)
        ShapeIsian.TabIndex = 8
        ' 
        ' ShapeTepi
        ' 
        ShapeTepi.BackColor = Color.Black
        ShapeTepi.Location = New Point(27, 438)
        ShapeTepi.Name = "ShapeTepi"
        ShapeTepi.Size = New Size(43, 49)
        ShapeTepi.TabIndex = 9
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(15, 379)
        NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(148, 31)
        NumericUpDown1.TabIndex = 7
        NumericUpDown1.Value = New Decimal(New Integer() {3, 0, 0, 0})
        ' 
        ' lblukuran
        ' 
        lblukuran.AutoSize = True
        lblukuran.Location = New Point(15, 351)
        lblukuran.Name = "lblukuran"
        lblukuran.Size = New Size(148, 25)
        lblukuran.TabIndex = 6
        lblukuran.Text = "Ukuran Garis Tepi"
        ' 
        ' RadioElipsIsi
        ' 
        RadioElipsIsi.AutoSize = True
        RadioElipsIsi.Location = New Point(15, 264)
        RadioElipsIsi.Name = "RadioElipsIsi"
        RadioElipsIsi.Size = New Size(95, 29)
        RadioElipsIsi.TabIndex = 5
        RadioElipsIsi.TabStop = True
        RadioElipsIsi.Text = "Elips Isi"
        RadioElipsIsi.UseVisualStyleBackColor = True
        ' 
        ' RadioGaris
        ' 
        RadioGaris.AutoSize = True
        RadioGaris.Location = New Point(15, 88)
        RadioGaris.Name = "RadioGaris"
        RadioGaris.Size = New Size(76, 29)
        RadioGaris.TabIndex = 4
        RadioGaris.TabStop = True
        RadioGaris.Text = "Garis"
        RadioGaris.UseVisualStyleBackColor = True
        ' 
        ' RadioKotak
        ' 
        RadioKotak.AutoSize = True
        RadioKotak.Location = New Point(15, 132)
        RadioKotak.Name = "RadioKotak"
        RadioKotak.Size = New Size(82, 29)
        RadioKotak.TabIndex = 3
        RadioKotak.TabStop = True
        RadioKotak.Text = "Kotak"
        RadioKotak.UseVisualStyleBackColor = True
        ' 
        ' RadioKotakIsi
        ' 
        RadioKotakIsi.AutoSize = True
        RadioKotakIsi.Location = New Point(15, 220)
        RadioKotakIsi.Name = "RadioKotakIsi"
        RadioKotakIsi.Size = New Size(103, 29)
        RadioKotakIsi.TabIndex = 2
        RadioKotakIsi.TabStop = True
        RadioKotakIsi.Text = "Kotak isi"
        RadioKotakIsi.UseVisualStyleBackColor = True
        ' 
        ' RadioElips
        ' 
        RadioElips.AutoSize = True
        RadioElips.Location = New Point(15, 176)
        RadioElips.Name = "RadioElips"
        RadioElips.Size = New Size(73, 29)
        RadioElips.TabIndex = 1
        RadioElips.TabStop = True
        RadioElips.Text = "elips"
        RadioElips.UseVisualStyleBackColor = True
        ' 
        ' RadioBebas
        ' 
        RadioBebas.AutoSize = True
        RadioBebas.Location = New Point(15, 44)
        RadioBebas.Name = "RadioBebas"
        RadioBebas.Size = New Size(84, 29)
        RadioBebas.TabIndex = 0
        RadioBebas.TabStop = True
        RadioBebas.Text = "Bebas"
        RadioBebas.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Warna6)
        GroupBox2.Controls.Add(Warna4)
        GroupBox2.Controls.Add(Warna5)
        GroupBox2.Controls.Add(Warna3)
        GroupBox2.Controls.Add(Warna2)
        GroupBox2.Controls.Add(Warna1)
        GroupBox2.Controls.Add(btnGbrUlang)
        GroupBox2.Controls.Add(btnBersihkan)
        GroupBox2.Controls.Add(btnUndo)
        GroupBox2.Dock = DockStyle.Bottom
        GroupBox2.Location = New Point(188, 471)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(842, 95)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Warna"
        ' 
        ' Warna6
        ' 
        Warna6.BackColor = Color.Black
        Warna6.Location = New Point(330, 34)
        Warna6.Name = "Warna6"
        Warna6.Size = New Size(43, 49)
        Warna6.TabIndex = 9
        ' 
        ' Warna4
        ' 
        Warna4.BackColor = Color.Blue
        Warna4.Location = New Point(206, 34)
        Warna4.Name = "Warna4"
        Warna4.Size = New Size(43, 49)
        Warna4.TabIndex = 9
        ' 
        ' Warna5
        ' 
        Warna5.BackColor = Color.White
        Warna5.Location = New Point(268, 34)
        Warna5.Name = "Warna5"
        Warna5.Size = New Size(43, 49)
        Warna5.TabIndex = 9
        ' 
        ' Warna3
        ' 
        Warna3.BackColor = Color.Lime
        Warna3.Location = New Point(144, 34)
        Warna3.Name = "Warna3"
        Warna3.Size = New Size(43, 49)
        Warna3.TabIndex = 9
        ' 
        ' Warna2
        ' 
        Warna2.BackColor = Color.Yellow
        Warna2.Location = New Point(82, 34)
        Warna2.Name = "Warna2"
        Warna2.Size = New Size(43, 49)
        Warna2.TabIndex = 9
        ' 
        ' Warna1
        ' 
        Warna1.BackColor = Color.Red
        Warna1.Location = New Point(20, 34)
        Warna1.Name = "Warna1"
        Warna1.Size = New Size(43, 49)
        Warna1.TabIndex = 9
        ' 
        ' btnGbrUlang
        ' 
        btnGbrUlang.Location = New Point(654, 49)
        btnGbrUlang.Name = "btnGbrUlang"
        btnGbrUlang.Size = New Size(112, 34)
        btnGbrUlang.TabIndex = 19
        btnGbrUlang.Text = "Gambarkan Ulang"
        btnGbrUlang.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(523, 49)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(112, 34)
        btnBersihkan.TabIndex = 18
        btnBersihkan.Text = "Bersihkan Canvas"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(392, 49)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(112, 34)
        btnUndo.TabIndex = 17
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Dock = DockStyle.Right
        GroupBox3.Location = New Point(790, 33)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(240, 438)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Object"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(24, 30)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(190, 417)
        TextBox1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(188, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(602, 438)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1030, 566)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioElipsIsi As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblukuran As Label
    Friend WithEvents btnGbrUlang As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents Warna6 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna5 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents Warna2 As Panel
    Friend WithEvents Warna1 As Panel
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
