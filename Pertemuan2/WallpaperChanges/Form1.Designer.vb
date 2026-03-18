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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        txtFolderPath = New Label()
        btnBrowser = New Button()
        txtPath = New TextBox()
        lblSelectPictures = New Label()
        clbWallpaper = New CheckedListBox()
        cbPreview = New CheckBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        lblInterval = New Label()
        btnRun = New Button()
        cbInterval = New ComboBox()
        TimerWall = New Timer(components)
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusCurrent = New ToolStripStatusLabel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        timerElapsed = New Timer(components)
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(122, 26)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(122, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(133, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' txtFolderPath
        ' 
        txtFolderPath.AutoSize = True
        txtFolderPath.Location = New Point(12, 36)
        txtFolderPath.Name = "txtFolderPath"
        txtFolderPath.Size = New Size(94, 20)
        txtFolderPath.TabIndex = 1
        txtFolderPath.Text = "Folder paths:"
        ' 
        ' btnBrowser
        ' 
        btnBrowser.Location = New Point(584, 31)
        btnBrowser.Name = "btnBrowser"
        btnBrowser.Size = New Size(94, 29)
        btnBrowser.TabIndex = 2
        btnBrowser.Text = "..."
        btnBrowser.UseVisualStyleBackColor = True
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(131, 31)
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(447, 27)
        txtPath.TabIndex = 4
        ' 
        ' lblSelectPictures
        ' 
        lblSelectPictures.AutoSize = True
        lblSelectPictures.Location = New Point(12, 72)
        lblSelectPictures.Name = "lblSelectPictures"
        lblSelectPictures.Size = New Size(280, 20)
        lblSelectPictures.TabIndex = 5
        lblSelectPictures.Text = "Please select one or more pictures below"
        ' 
        ' clbWallpaper
        ' 
        clbWallpaper.FormattingEnabled = True
        clbWallpaper.Location = New Point(12, 95)
        clbWallpaper.Name = "clbWallpaper"
        clbWallpaper.Size = New Size(327, 290)
        clbWallpaper.TabIndex = 6
        ' 
        ' cbPreview
        ' 
        cbPreview.AutoSize = True
        cbPreview.Checked = True
        cbPreview.CheckState = CheckState.Checked
        cbPreview.Location = New Point(378, 72)
        cbPreview.Name = "cbPreview"
        cbPreview.Size = New Size(128, 24)
        cbPreview.TabIndex = 7
        cbPreview.Text = "Preview Image"
        cbPreview.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(378, 102)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(394, 248)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(31, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(338, 208)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' lblInterval
        ' 
        lblInterval.AutoSize = True
        lblInterval.Location = New Point(381, 360)
        lblInterval.Name = "lblInterval"
        lblInterval.Size = New Size(58, 20)
        lblInterval.TabIndex = 9
        lblInterval.Text = "Interval"
        ' 
        ' btnRun
        ' 
        btnRun.Location = New Point(678, 360)
        btnRun.Name = "btnRun"
        btnRun.Size = New Size(94, 29)
        btnRun.TabIndex = 10
        btnRun.Text = "Run!"
        btnRun.UseVisualStyleBackColor = True
        ' 
        ' cbInterval
        ' 
        cbInterval.FormattingEnabled = True
        cbInterval.Items.AddRange(New Object() {"10 secs ", "30 secs", "1 minutes"})
        cbInterval.Location = New Point(454, 357)
        cbInterval.Name = "cbInterval"
        cbInterval.Size = New Size(151, 28)
        cbInterval.TabIndex = 11
        cbInterval.Text = "Select First"
        ' 
        ' TimerWall
        ' 
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusCurrent})
        StatusStrip1.Location = New Point(0, 424)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 26)
        StatusStrip1.TabIndex = 12
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(50, 20)
        ToolStripStatusReady.Text = "Ready"
        ' 
        ' ToolStripStatusCurrent
        ' 
        ToolStripStatusCurrent.Name = "ToolStripStatusCurrent"
        ToolStripStatusCurrent.Size = New Size(172, 20)
        ToolStripStatusCurrent.Text = ":Current Wallpaper: none"
        ' 
        ' timerElapsed
        ' 
        timerElapsed.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(cbInterval)
        Controls.Add(btnRun)
        Controls.Add(lblInterval)
        Controls.Add(Panel1)
        Controls.Add(cbPreview)
        Controls.Add(clbWallpaper)
        Controls.Add(lblSelectPictures)
        Controls.Add(txtPath)
        Controls.Add(btnBrowser)
        Controls.Add(txtFolderPath)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Wallpaper Changer"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtFolderPath As Label
    Friend WithEvents btnBrowser As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblSelectPictures As Label
    Friend WithEvents clbWallpaper As CheckedListBox
    Friend WithEvents cbPreview As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblInterval As Label
    Friend WithEvents btnRun As Button
    Friend WithEvents cbInterval As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerWall As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents timerElapsed As Timer
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusCurrent As ToolStripStatusLabel

End Class
