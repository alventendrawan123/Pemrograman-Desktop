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
        NEwToolStripMenuItem = New ToolStripMenuItem()
        openStripMenuItem1 = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        PageSetupToolStripMenuItem = New ToolStripMenuItem()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        FindToolStripMenuItem = New ToolStripMenuItem()
        FindNextToolStripMenuItem = New ToolStripMenuItem()
        ReplaceToolStripMenuItem = New ToolStripMenuItem()
        GoToToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        InsertDataTimeToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        WordWrapToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        AboutNotepadKuToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        toolStripStatusReady = New ToolStripStatusLabel()
        toolStripStatusLine = New ToolStripStatusLabel()
        insertStripStatus = New ToolStripStatusLabel()
        capsStripStatus = New ToolStripStatusLabel()
        numStripStatus = New ToolStripStatusLabel()
        openFileDialog1 = New OpenFileDialog()
        fontDialog1 = New FontDialog()
        printDialog1 = New PrintDialog()
        pageSetupDialog1 = New PageSetupDialog()
        saveFileDialog1 = New SaveFileDialog()
        PrintDocument1 = New Printing.PrintDocument()
        txtNotepad = New TextBox()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, FormatToolStripMenuItem, ViewToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "menuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NEwToolStripMenuItem, openStripMenuItem1, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator1, PageSetupToolStripMenuItem, PrintToolStripMenuItem, ToolStripSeparator2, CloseToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NEwToolStripMenuItem
        ' 
        NEwToolStripMenuItem.Name = "NEwToolStripMenuItem"
        NEwToolStripMenuItem.Size = New Size(203, 34)
        NEwToolStripMenuItem.Text = "New"
        ' 
        ' openStripMenuItem1
        ' 
        openStripMenuItem1.Name = "openStripMenuItem1"
        openStripMenuItem1.Size = New Size(203, 34)
        openStripMenuItem1.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(203, 34)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(203, 34)
        SaveAsToolStripMenuItem.Text = "Save as..."
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(200, 6)
        ' 
        ' PageSetupToolStripMenuItem
        ' 
        PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        PageSetupToolStripMenuItem.Size = New Size(203, 34)
        PageSetupToolStripMenuItem.Text = "Page Setup"
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.Size = New Size(203, 34)
        PrintToolStripMenuItem.Text = "Print"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(200, 6)
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(203, 34)
        CloseToolStripMenuItem.Text = "Close"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(203, 34)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, ToolStripSeparator3, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator4, FindToolStripMenuItem, FindNextToolStripMenuItem, ReplaceToolStripMenuItem, GoToToolStripMenuItem, ToolStripSeparator5, SelectAllToolStripMenuItem, InsertDataTimeToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(58, 29)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.Size = New Size(243, 34)
        UndoToolStripMenuItem.Text = "Undo"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(240, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(243, 34)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(243, 34)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(243, 34)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(240, 6)
        ' 
        ' FindToolStripMenuItem
        ' 
        FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        FindToolStripMenuItem.Size = New Size(243, 34)
        FindToolStripMenuItem.Text = "Find..."
        ' 
        ' FindNextToolStripMenuItem
        ' 
        FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem"
        FindNextToolStripMenuItem.Size = New Size(243, 34)
        FindNextToolStripMenuItem.Text = "Find Next"
        ' 
        ' ReplaceToolStripMenuItem
        ' 
        ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        ReplaceToolStripMenuItem.Size = New Size(243, 34)
        ReplaceToolStripMenuItem.Text = "Replace..."
        ' 
        ' GoToToolStripMenuItem
        ' 
        GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        GoToToolStripMenuItem.Size = New Size(243, 34)
        GoToToolStripMenuItem.Text = "Go To..."
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(240, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(243, 34)
        SelectAllToolStripMenuItem.Text = "Select All"
        ' 
        ' InsertDataTimeToolStripMenuItem
        ' 
        InsertDataTimeToolStripMenuItem.Name = "InsertDataTimeToolStripMenuItem"
        InsertDataTimeToolStripMenuItem.Size = New Size(243, 34)
        InsertDataTimeToolStripMenuItem.Text = "Insert Data Time"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {WordWrapToolStripMenuItem, FontToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(85, 29)
        FormatToolStripMenuItem.Text = "Format"
        ' 
        ' WordWrapToolStripMenuItem
        ' 
        WordWrapToolStripMenuItem.Checked = True
        WordWrapToolStripMenuItem.CheckState = CheckState.Checked
        WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        WordWrapToolStripMenuItem.Size = New Size(202, 34)
        WordWrapToolStripMenuItem.Text = "Word wrap"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(202, 34)
        FontToolStripMenuItem.Text = "Font"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StatusBarToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(65, 29)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.Checked = True
        StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(193, 34)
        StatusBarToolStripMenuItem.Text = "Status bar"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem, ToolStripSeparator6, AboutNotepadKuToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(78, 29)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(270, 34)
        HelpToolStripMenuItem.Text = "Help..."
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(267, 6)
        ' 
        ' AboutNotepadKuToolStripMenuItem
        ' 
        AboutNotepadKuToolStripMenuItem.Name = "AboutNotepadKuToolStripMenuItem"
        AboutNotepadKuToolStripMenuItem.Size = New Size(270, 34)
        AboutNotepadKuToolStripMenuItem.Text = "About NotepadKu"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {toolStripStatusReady, toolStripStatusLine, insertStripStatus, capsStripStatus, numStripStatus})
        StatusStrip1.Location = New Point(0, 414)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 36)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "statusStrip1"
        ' 
        ' toolStripStatusReady
        ' 
        toolStripStatusReady.Name = "toolStripStatusReady"
        toolStripStatusReady.Size = New Size(179, 29)
        toolStripStatusReady.Text = "Ready.                       "
        ' 
        ' toolStripStatusLine
        ' 
        toolStripStatusLine.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Right
        toolStripStatusLine.BorderStyle = Border3DStyle.Etched
        toolStripStatusLine.Name = "toolStripStatusLine"
        toolStripStatusLine.Size = New Size(71, 29)
        toolStripStatusLine.Text = "Line: 1 "
        ' 
        ' insertStripStatus
        ' 
        insertStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        insertStripStatus.BorderStyle = Border3DStyle.Etched
        insertStripStatus.Enabled = False
        insertStripStatus.Name = "insertStripStatus"
        insertStripStatus.Size = New Size(44, 29)
        insertStripStatus.Text = "INS"
        ' 
        ' capsStripStatus
        ' 
        capsStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        capsStripStatus.BorderStyle = Border3DStyle.Etched
        capsStripStatus.Enabled = False
        capsStripStatus.Name = "capsStripStatus"
        capsStripStatus.Size = New Size(59, 29)
        capsStripStatus.Text = "CAPS"
        ' 
        ' numStripStatus
        ' 
        numStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        numStripStatus.BorderStyle = Border3DStyle.Etched
        numStripStatus.Enabled = False
        numStripStatus.Name = "numStripStatus"
        numStripStatus.Size = New Size(57, 29)
        numStripStatus.Text = "NUM"
        ' 
        ' openFileDialog1
        ' 
        openFileDialog1.DefaultExt = "*.txt"
        openFileDialog1.FileName = "Untitled"
        openFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        openFileDialog1.Title = "Open File Text"
        ' 
        ' printDialog1
        ' 
        printDialog1.UseEXDialog = True
        ' 
        ' pageSetupDialog1
        ' 
        pageSetupDialog1.EnableMetric = True
        ' 
        ' saveFileDialog1
        ' 
        saveFileDialog1.DefaultExt = "*.txt"
        saveFileDialog1.FileName = "Untitled.txt"
        saveFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        saveFileDialog1.Title = "Save File Text as"
        ' 
        ' txtNotepad
        ' 
        txtNotepad.AcceptsReturn = True
        txtNotepad.AcceptsTab = True
        txtNotepad.AllowDrop = True
        txtNotepad.Dock = DockStyle.Fill
        txtNotepad.Location = New Point(0, 33)
        txtNotepad.Multiline = True
        txtNotepad.Name = "txtNotepad"
        txtNotepad.ScrollBars = ScrollBars.Both
        txtNotepad.Size = New Size(800, 381)
        txtNotepad.TabIndex = 1
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNotepad)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "NotepadKu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents toolStripStatusLine As ToolStripStatusLabel
    Friend WithEvents insertStripStatus As ToolStripStatusLabel
    Friend WithEvents capsStripStatus As ToolStripStatusLabel
    Friend WithEvents numStripStatus As ToolStripStatusLabel
    Friend WithEvents NEwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents openStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertDataTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents AboutNotepadKuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents openFileDialog1 As OpenFileDialog
    Friend WithEvents fontDialog1 As FontDialog
    Friend WithEvents printDialog1 As PrintDialog
    Friend WithEvents pageSetupDialog1 As PageSetupDialog
    Friend WithEvents saveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtNotepad As TextBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher

End Class
