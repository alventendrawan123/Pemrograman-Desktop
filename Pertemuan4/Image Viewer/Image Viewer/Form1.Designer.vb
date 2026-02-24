<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusReady = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusDimension = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusBits = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusResolution = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusRawFormat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainerUtama = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerBawah = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerBawah2 = New System.Windows.Forms.SplitContainer()
        Me.tvDrive = New System.Windows.Forms.TreeView()
        Me.lvImage = New System.Windows.Forms.ListView()
        Me.ChName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFileSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreatedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttributes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvExif = New System.Windows.Forms.ListView()
        Me.chProperty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tcProperties = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainerUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerUtama.Panel1.SuspendLayout()
        Me.SplitContainerUtama.Panel2.SuspendLayout()
        Me.SplitContainerUtama.SuspendLayout()
        CType(Me.SplitContainerBawah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBawah.Panel1.SuspendLayout()
        Me.SplitContainerBawah.Panel2.SuspendLayout()
        Me.SplitContainerBawah.SuspendLayout()
        CType(Me.SplitContainerBawah2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBawah2.Panel1.SuspendLayout()
        Me.SplitContainerBawah2.Panel2.SuspendLayout()
        Me.SplitContainerBawah2.SuspendLayout()
        Me.tcProperties.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusReady, Me.toolStripStatusDimension, Me.toolStripStatusBits, Me.toolStripStatusResolution, Me.toolStripStatusRawFormat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 30)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'toolStripStatusReady
        '
        Me.toolStripStatusReady.Name = "toolStripStatusReady"
        Me.toolStripStatusReady.Size = New System.Drawing.Size(53, 24)
        Me.toolStripStatusReady.Text = "Ready."
        '
        'toolStripStatusDimension
        '
        Me.toolStripStatusDimension.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.toolStripStatusDimension.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.toolStripStatusDimension.Name = "toolStripStatusDimension"
        Me.toolStripStatusDimension.Size = New System.Drawing.Size(90, 24)
        Me.toolStripStatusDimension.Text = "Dimensions"
        '
        'toolStripStatusBits
        '
        Me.toolStripStatusBits.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.toolStripStatusBits.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.toolStripStatusBits.Name = "toolStripStatusBits"
        Me.toolStripStatusBits.Size = New System.Drawing.Size(68, 24)
        Me.toolStripStatusBits.Text = "# of bits"
        '
        'toolStripStatusResolution
        '
        Me.toolStripStatusResolution.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.toolStripStatusResolution.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.toolStripStatusResolution.Name = "toolStripStatusResolution"
        Me.toolStripStatusResolution.Size = New System.Drawing.Size(83, 24)
        Me.toolStripStatusResolution.Text = "Resolution"
        '
        'toolStripStatusRawFormat
        '
        Me.toolStripStatusRawFormat.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.toolStripStatusRawFormat.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.toolStripStatusRawFormat.Name = "toolStripStatusRawFormat"
        Me.toolStripStatusRawFormat.Size = New System.Drawing.Size(92, 24)
        Me.toolStripStatusRawFormat.Text = "Raw Format"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "ImageViewer Tip:"
        '
        'SplitContainerUtama
        '
        Me.SplitContainerUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerUtama.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerUtama.Name = "SplitContainerUtama"
        '
        'SplitContainerUtama.Panel1
        '
        Me.SplitContainerUtama.Panel1.Controls.Add(Me.tvDrive)
        '
        'SplitContainerUtama.Panel2
        '
        Me.SplitContainerUtama.Panel2.Controls.Add(Me.SplitContainerBawah)
        Me.SplitContainerUtama.Size = New System.Drawing.Size(800, 420)
        Me.SplitContainerUtama.SplitterDistance = 161
        Me.SplitContainerUtama.TabIndex = 1
        '
        'SplitContainerBawah
        '
        Me.SplitContainerBawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBawah.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBawah.Name = "SplitContainerBawah"
        Me.SplitContainerBawah.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerBawah.Panel1
        '
        Me.SplitContainerBawah.Panel1.Controls.Add(Me.lvImage)
        '
        'SplitContainerBawah.Panel2
        '
        Me.SplitContainerBawah.Panel2.Controls.Add(Me.SplitContainerBawah2)
        Me.SplitContainerBawah.Size = New System.Drawing.Size(635, 420)
        Me.SplitContainerBawah.SplitterDistance = 250
        Me.SplitContainerBawah.TabIndex = 0
        '
        'SplitContainerBawah2
        '
        Me.SplitContainerBawah2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBawah2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBawah2.Name = "SplitContainerBawah2"
        '
        'SplitContainerBawah2.Panel1
        '
        Me.SplitContainerBawah2.Panel1.Controls.Add(Me.tcProperties)
        '
        'SplitContainerBawah2.Panel2
        '
        Me.SplitContainerBawah2.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainerBawah2.Size = New System.Drawing.Size(635, 166)
        Me.SplitContainerBawah2.SplitterDistance = 211
        Me.SplitContainerBawah2.TabIndex = 0
        '
        'tvDrive
        '
        Me.tvDrive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvDrive.ImageIndex = 0
        Me.tvDrive.ImageList = Me.ImageList1
        Me.tvDrive.Location = New System.Drawing.Point(0, 0)
        Me.tvDrive.Name = "tvDrive"
        Me.tvDrive.SelectedImageIndex = 0
        Me.tvDrive.Size = New System.Drawing.Size(161, 420)
        Me.tvDrive.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tvDrive, "Please select drive/folder that contain")
        '
        'lvImage
        '
        Me.lvImage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChName, Me.chExtension, Me.chFileSize, Me.chLastModified, Me.chLastAccessed, Me.chCreatedDate, Me.chAttributes})
        Me.lvImage.GridLines = True
        Me.lvImage.HideSelection = False
        Me.lvImage.Location = New System.Drawing.Point(2, 0)
        Me.lvImage.Name = "lvImage"
        Me.lvImage.Size = New System.Drawing.Size(630, 248)
        Me.lvImage.SmallImageList = Me.ImageList1
        Me.lvImage.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lvImage, "Image file(s)")
        Me.lvImage.UseCompatibleStateImageBehavior = False
        Me.lvImage.View = System.Windows.Forms.View.Details
        '
        'ChName
        '
        Me.ChName.Text = "Name"
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        '
        'chFileSize
        '
        Me.chFileSize.Text = "File Size"
        '
        'chLastModified
        '
        Me.chLastModified.Text = "Modified Date"
        '
        'chLastAccessed
        '
        Me.chLastAccessed.Text = "Last Accessed"
        '
        'chCreatedDate
        '
        Me.chCreatedDate.Text = "Created Date"
        '
        'chAttributes
        '
        Me.chAttributes.Text = "Attributes"
        '
        'lvExif
        '
        Me.lvExif.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chProperty, Me.chValue})
        Me.lvExif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvExif.GridLines = True
        Me.lvExif.HideSelection = False
        Me.lvExif.Location = New System.Drawing.Point(3, 3)
        Me.lvExif.Name = "lvExif"
        Me.lvExif.Size = New System.Drawing.Size(197, 131)
        Me.lvExif.TabIndex = 1
        Me.lvExif.UseCompatibleStateImageBehavior = False
        Me.lvExif.View = System.Windows.Forms.View.Details
        '
        'chProperty
        '
        Me.chProperty.Text = "Property"
        '
        'chValue
        '
        Me.chValue.Text = "Value"
        '
        'tcProperties
        '
        Me.tcProperties.Controls.Add(Me.TabPage1)
        Me.tcProperties.Controls.Add(Me.TabPage2)
        Me.tcProperties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcProperties.Location = New System.Drawing.Point(0, 0)
        Me.tcProperties.Name = "tcProperties"
        Me.tcProperties.SelectedIndex = 0
        Me.tcProperties.Size = New System.Drawing.Size(211, 166)
        Me.tcProperties.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertyGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(203, 137)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Image Properties"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvExif)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(203, 137)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "EXIF Metadata"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(414, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Double click to view this image in auto")
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(3, 3)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(197, 131)
        Me.PropertyGrid1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainerUtama)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainerUtama.Panel1.ResumeLayout(False)
        Me.SplitContainerUtama.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerUtama.ResumeLayout(False)
        Me.SplitContainerBawah.Panel1.ResumeLayout(False)
        Me.SplitContainerBawah.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerBawah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBawah.ResumeLayout(False)
        Me.SplitContainerBawah2.Panel1.ResumeLayout(False)
        Me.SplitContainerBawah2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerBawah2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBawah2.ResumeLayout(False)
        Me.tcProperties.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents toolStripStatusDimension As ToolStripStatusLabel
    Friend WithEvents toolStripStatusBits As ToolStripStatusLabel
    Friend WithEvents toolStripStatusResolution As ToolStripStatusLabel
    Friend WithEvents toolStripStatusRawFormat As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainerUtama As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents SplitContainerBawah As SplitContainer
    Friend WithEvents lvImage As ListView
    Friend WithEvents SplitContainerBawah2 As SplitContainer
    Friend WithEvents ChName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents lvExif As ListView
    Friend WithEvents chProperty As ColumnHeader
    Friend WithEvents chValue As ColumnHeader
    Friend WithEvents tcProperties As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PropertyGrid1 As PropertyGrid
End Class
