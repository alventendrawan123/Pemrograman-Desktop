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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.lblOri = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.lvOri = New System.Windows.Forms.ListView()
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttribute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvPreview = New System.Windows.Forms.ListView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpFilename = New System.Windows.Forms.TabPage()
        Me.txtRightCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtLeftCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtWithThisF = New System.Windows.Forms.TextBox()
        Me.cbCaseF = New System.Windows.Forms.ComboBox()
        Me.txtInsertAfterF = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeF = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisF = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithF = New System.Windows.Forms.TextBox()
        Me.lblCaseF = New System.Windows.Forms.Label()
        Me.lblWithThisF = New System.Windows.Forms.Label()
        Me.rbRightCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterF = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWith = New System.Windows.Forms.RadioButton()
        Me.TpExtension = New System.Windows.Forms.TabPage()
        Me.txtRightCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtLeftCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtWithThisE = New System.Windows.Forms.TextBox()
        Me.cbCaseE = New System.Windows.Forms.ComboBox()
        Me.txtInsertAfterE = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeE = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisE = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithE = New System.Windows.Forms.TextBox()
        Me.lblCaseE = New System.Windows.Forms.Label()
        Me.lblWithThisE = New System.Windows.Forms.Label()
        Me.rbRightCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterE = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithE = New System.Windows.Forms.RadioButton()
        Me.TpAutoNumber = New System.Windows.Forms.TabPage()
        Me.gbWith = New System.Windows.Forms.GroupBox()
        Me.nudIncrementBy = New System.Windows.Forms.NumericUpDown()
        Me.nudStartWithNumber = New System.Windows.Forms.NumericUpDown()
        Me.lblIncrementBy = New System.Windows.Forms.Label()
        Me.lblStartWithNumber = New System.Windows.Forms.Label()
        Me.gbPlace = New System.Windows.Forms.GroupBox()
        Me.rbBeforeFileName = New System.Windows.Forms.RadioButton()
        Me.rbAfterFileName = New System.Windows.Forms.RadioButton()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TpFilename.SuspendLayout()
        Me.TpExtension.SuspendLayout()
        Me.TpAutoNumber.SuspendLayout()
        Me.gbWith.SuspendLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlace.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(12, 18)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(37, 16)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Path:"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(55, 15)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(545, 22)
        Me.txtPath.TabIndex = 1
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(606, 14)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(75, 23)
        Me.btnPath.TabIndex = 2
        Me.btnPath.Text = "..."
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(687, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "lblExt"
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(732, 14)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(56, 22)
        Me.txtExt.TabIndex = 4
        Me.txtExt.Text = "*.*"
        '
        'lblOri
        '
        Me.lblOri.AutoSize = True
        Me.lblOri.Location = New System.Drawing.Point(12, 56)
        Me.lblOri.Name = "lblOri"
        Me.lblOri.Size = New System.Drawing.Size(78, 16)
        Me.lblOri.TabIndex = 5
        Me.lblOri.Text = "Original File"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(422, 56)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(80, 16)
        Me.lblPreview.TabIndex = 6
        Me.lblPreview.Text = "Preview File"
        '
        'lvOri
        '
        Me.lvOri.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName, Me.chExtension, Me.chAttribute, Me.chCreated, Me.chAccessed, Me.chModified})
        Me.lvOri.GridLines = True
        Me.lvOri.HideSelection = False
        Me.lvOri.Location = New System.Drawing.Point(12, 75)
        Me.lvOri.Name = "lvOri"
        Me.lvOri.Size = New System.Drawing.Size(407, 219)
        Me.lvOri.TabIndex = 7
        Me.lvOri.UseCompatibleStateImageBehavior = False
        Me.lvOri.View = System.Windows.Forms.View.Details
        '
        'chFileName
        '
        Me.chFileName.Text = "File Name"
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        '
        'chAttribute
        '
        Me.chAttribute.Text = "Attributes"
        '
        'chCreated
        '
        Me.chCreated.Text = "Date Created"
        '
        'chAccessed
        '
        Me.chAccessed.Text = "Date Accessed"
        '
        'chModified
        '
        Me.chModified.Text = "Date Modified"
        '
        'lvPreview
        '
        Me.lvPreview.HideSelection = False
        Me.lvPreview.Location = New System.Drawing.Point(425, 75)
        Me.lvPreview.Name = "lvPreview"
        Me.lvPreview.Size = New System.Drawing.Size(392, 219)
        Me.lvPreview.TabIndex = 8
        Me.lvPreview.UseCompatibleStateImageBehavior = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpFilename)
        Me.TabControl1.Controls.Add(Me.TpExtension)
        Me.TabControl1.Controls.Add(Me.TpAutoNumber)
        Me.TabControl1.Location = New System.Drawing.Point(12, 311)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(724, 164)
        Me.TabControl1.TabIndex = 9
        '
        'TpFilename
        '
        Me.TpFilename.Controls.Add(Me.txtRightCropNCharF)
        Me.TpFilename.Controls.Add(Me.txtLeftCropNCharF)
        Me.TpFilename.Controls.Add(Me.txtWithThisF)
        Me.TpFilename.Controls.Add(Me.cbCaseF)
        Me.TpFilename.Controls.Add(Me.txtInsertAfterF)
        Me.TpFilename.Controls.Add(Me.txtInsertBeforeF)
        Me.TpFilename.Controls.Add(Me.txtReplaceThisF)
        Me.TpFilename.Controls.Add(Me.txtReplaceWithF)
        Me.TpFilename.Controls.Add(Me.lblCaseF)
        Me.TpFilename.Controls.Add(Me.lblWithThisF)
        Me.TpFilename.Controls.Add(Me.rbRightCropNCharF)
        Me.TpFilename.Controls.Add(Me.rbLeftCropNCharF)
        Me.TpFilename.Controls.Add(Me.rbInsertAfterF)
        Me.TpFilename.Controls.Add(Me.rbInsertBeforeF)
        Me.TpFilename.Controls.Add(Me.rbReplaceThisF)
        Me.TpFilename.Controls.Add(Me.rbReplaceWith)
        Me.TpFilename.Location = New System.Drawing.Point(4, 25)
        Me.TpFilename.Name = "TpFilename"
        Me.TpFilename.Padding = New System.Windows.Forms.Padding(3)
        Me.TpFilename.Size = New System.Drawing.Size(716, 135)
        Me.TpFilename.TabIndex = 0
        Me.TpFilename.Text = "Filename"
        Me.TpFilename.UseVisualStyleBackColor = True
        '
        'txtRightCropNCharF
        '
        Me.txtRightCropNCharF.Location = New System.Drawing.Point(538, 102)
        Me.txtRightCropNCharF.Name = "txtRightCropNCharF"
        Me.txtRightCropNCharF.ReadOnly = True
        Me.txtRightCropNCharF.Size = New System.Drawing.Size(156, 22)
        Me.txtRightCropNCharF.TabIndex = 19
        '
        'txtLeftCropNCharF
        '
        Me.txtLeftCropNCharF.Location = New System.Drawing.Point(512, 74)
        Me.txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        Me.txtLeftCropNCharF.ReadOnly = True
        Me.txtLeftCropNCharF.Size = New System.Drawing.Size(198, 22)
        Me.txtLeftCropNCharF.TabIndex = 18
        '
        'txtWithThisF
        '
        Me.txtWithThisF.Location = New System.Drawing.Point(512, 43)
        Me.txtWithThisF.Name = "txtWithThisF"
        Me.txtWithThisF.ReadOnly = True
        Me.txtWithThisF.Size = New System.Drawing.Size(198, 22)
        Me.txtWithThisF.TabIndex = 17
        '
        'cbCaseF
        '
        Me.cbCaseF.FormattingEnabled = True
        Me.cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseF.Location = New System.Drawing.Point(538, 13)
        Me.cbCaseF.Name = "cbCaseF"
        Me.cbCaseF.Size = New System.Drawing.Size(172, 24)
        Me.cbCaseF.TabIndex = 16
        '
        'txtInsertAfterF
        '
        Me.txtInsertAfterF.Location = New System.Drawing.Point(139, 99)
        Me.txtInsertAfterF.Name = "txtInsertAfterF"
        Me.txtInsertAfterF.ReadOnly = True
        Me.txtInsertAfterF.Size = New System.Drawing.Size(121, 22)
        Me.txtInsertAfterF.TabIndex = 14
        '
        'txtInsertBeforeF
        '
        Me.txtInsertBeforeF.Location = New System.Drawing.Point(139, 68)
        Me.txtInsertBeforeF.Name = "txtInsertBeforeF"
        Me.txtInsertBeforeF.ReadOnly = True
        Me.txtInsertBeforeF.Size = New System.Drawing.Size(224, 22)
        Me.txtInsertBeforeF.TabIndex = 15
        '
        'txtReplaceThisF
        '
        Me.txtReplaceThisF.Location = New System.Drawing.Point(139, 40)
        Me.txtReplaceThisF.Name = "txtReplaceThisF"
        Me.txtReplaceThisF.ReadOnly = True
        Me.txtReplaceThisF.Size = New System.Drawing.Size(302, 22)
        Me.txtReplaceThisF.TabIndex = 13
        '
        'txtReplaceWithF
        '
        Me.txtReplaceWithF.Location = New System.Drawing.Point(139, 10)
        Me.txtReplaceWithF.Name = "txtReplaceWithF"
        Me.txtReplaceWithF.ReadOnly = True
        Me.txtReplaceWithF.Size = New System.Drawing.Size(345, 22)
        Me.txtReplaceWithF.TabIndex = 13
        '
        'lblCaseF
        '
        Me.lblCaseF.AutoSize = True
        Me.lblCaseF.Location = New System.Drawing.Point(490, 14)
        Me.lblCaseF.Name = "lblCaseF"
        Me.lblCaseF.Size = New System.Drawing.Size(42, 16)
        Me.lblCaseF.TabIndex = 14
        Me.lblCaseF.Text = "Case:"
        '
        'lblWithThisF
        '
        Me.lblWithThisF.AutoSize = True
        Me.lblWithThisF.Location = New System.Drawing.Point(447, 44)
        Me.lblWithThisF.Name = "lblWithThisF"
        Me.lblWithThisF.Size = New System.Drawing.Size(59, 16)
        Me.lblWithThisF.TabIndex = 13
        Me.lblWithThisF.Text = "WithThis"
        '
        'rbRightCropNCharF
        '
        Me.rbRightCropNCharF.AutoSize = True
        Me.rbRightCropNCharF.Location = New System.Drawing.Point(384, 101)
        Me.rbRightCropNCharF.Name = "rbRightCropNCharF"
        Me.rbRightCropNCharF.Size = New System.Drawing.Size(132, 20)
        Me.rbRightCropNCharF.TabIndex = 5
        Me.rbRightCropNCharF.TabStop = True
        Me.rbRightCropNCharF.Text = "Right Crop n Char"
        Me.rbRightCropNCharF.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharF
        '
        Me.rbLeftCropNCharF.AutoSize = True
        Me.rbLeftCropNCharF.Location = New System.Drawing.Point(384, 74)
        Me.rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        Me.rbLeftCropNCharF.Size = New System.Drawing.Size(122, 20)
        Me.rbLeftCropNCharF.TabIndex = 4
        Me.rbLeftCropNCharF.TabStop = True
        Me.rbLeftCropNCharF.Text = "Left Crop n Char"
        Me.rbLeftCropNCharF.UseVisualStyleBackColor = True
        '
        'rbInsertAfterF
        '
        Me.rbInsertAfterF.AutoSize = True
        Me.rbInsertAfterF.Location = New System.Drawing.Point(12, 100)
        Me.rbInsertAfterF.Name = "rbInsertAfterF"
        Me.rbInsertAfterF.Size = New System.Drawing.Size(90, 20)
        Me.rbInsertAfterF.TabIndex = 3
        Me.rbInsertAfterF.TabStop = True
        Me.rbInsertAfterF.Text = "Insert After"
        Me.rbInsertAfterF.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeF
        '
        Me.rbInsertBeforeF.AutoSize = True
        Me.rbInsertBeforeF.Location = New System.Drawing.Point(12, 70)
        Me.rbInsertBeforeF.Name = "rbInsertBeforeF"
        Me.rbInsertBeforeF.Size = New System.Drawing.Size(103, 20)
        Me.rbInsertBeforeF.TabIndex = 2
        Me.rbInsertBeforeF.TabStop = True
        Me.rbInsertBeforeF.Text = "Insert Before"
        Me.rbInsertBeforeF.UseVisualStyleBackColor = True
        '
        'rbReplaceThisF
        '
        Me.rbReplaceThisF.AutoSize = True
        Me.rbReplaceThisF.Location = New System.Drawing.Point(12, 40)
        Me.rbReplaceThisF.Name = "rbReplaceThisF"
        Me.rbReplaceThisF.Size = New System.Drawing.Size(106, 20)
        Me.rbReplaceThisF.TabIndex = 1
        Me.rbReplaceThisF.TabStop = True
        Me.rbReplaceThisF.Text = "ReplaceThis"
        Me.rbReplaceThisF.UseVisualStyleBackColor = True
        '
        'rbReplaceWith
        '
        Me.rbReplaceWith.AutoSize = True
        Me.rbReplaceWith.Location = New System.Drawing.Point(12, 10)
        Me.rbReplaceWith.Name = "rbReplaceWith"
        Me.rbReplaceWith.Size = New System.Drawing.Size(109, 20)
        Me.rbReplaceWith.TabIndex = 0
        Me.rbReplaceWith.TabStop = True
        Me.rbReplaceWith.Text = "Replace With"
        Me.rbReplaceWith.UseVisualStyleBackColor = True
        '
        'TpExtension
        '
        Me.TpExtension.Controls.Add(Me.txtRightCropNCharE)
        Me.TpExtension.Controls.Add(Me.txtLeftCropNCharE)
        Me.TpExtension.Controls.Add(Me.txtWithThisE)
        Me.TpExtension.Controls.Add(Me.cbCaseE)
        Me.TpExtension.Controls.Add(Me.txtInsertAfterE)
        Me.TpExtension.Controls.Add(Me.txtInsertBeforeE)
        Me.TpExtension.Controls.Add(Me.txtReplaceThisE)
        Me.TpExtension.Controls.Add(Me.txtReplaceWithE)
        Me.TpExtension.Controls.Add(Me.lblCaseE)
        Me.TpExtension.Controls.Add(Me.lblWithThisE)
        Me.TpExtension.Controls.Add(Me.rbRightCropNCharE)
        Me.TpExtension.Controls.Add(Me.rbLeftCropNCharE)
        Me.TpExtension.Controls.Add(Me.rbInsertAfterE)
        Me.TpExtension.Controls.Add(Me.rbInsertBeforeE)
        Me.TpExtension.Controls.Add(Me.rbReplaceThisE)
        Me.TpExtension.Controls.Add(Me.rbReplaceWithE)
        Me.TpExtension.Location = New System.Drawing.Point(4, 25)
        Me.TpExtension.Name = "TpExtension"
        Me.TpExtension.Padding = New System.Windows.Forms.Padding(3)
        Me.TpExtension.Size = New System.Drawing.Size(716, 135)
        Me.TpExtension.TabIndex = 1
        Me.TpExtension.Text = "Extension"
        Me.TpExtension.UseVisualStyleBackColor = True
        '
        'txtRightCropNCharE
        '
        Me.txtRightCropNCharE.Location = New System.Drawing.Point(535, 102)
        Me.txtRightCropNCharE.Name = "txtRightCropNCharE"
        Me.txtRightCropNCharE.ReadOnly = True
        Me.txtRightCropNCharE.Size = New System.Drawing.Size(156, 22)
        Me.txtRightCropNCharE.TabIndex = 35
        '
        'txtLeftCropNCharE
        '
        Me.txtLeftCropNCharE.Location = New System.Drawing.Point(509, 74)
        Me.txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        Me.txtLeftCropNCharE.ReadOnly = True
        Me.txtLeftCropNCharE.Size = New System.Drawing.Size(198, 22)
        Me.txtLeftCropNCharE.TabIndex = 34
        '
        'txtWithThisE
        '
        Me.txtWithThisE.Location = New System.Drawing.Point(509, 43)
        Me.txtWithThisE.Name = "txtWithThisE"
        Me.txtWithThisE.ReadOnly = True
        Me.txtWithThisE.Size = New System.Drawing.Size(198, 22)
        Me.txtWithThisE.TabIndex = 33
        '
        'cbCaseE
        '
        Me.cbCaseE.FormattingEnabled = True
        Me.cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseE.Location = New System.Drawing.Point(535, 13)
        Me.cbCaseE.Name = "cbCaseE"
        Me.cbCaseE.Size = New System.Drawing.Size(172, 24)
        Me.cbCaseE.TabIndex = 32
        '
        'txtInsertAfterE
        '
        Me.txtInsertAfterE.Location = New System.Drawing.Point(136, 99)
        Me.txtInsertAfterE.Name = "txtInsertAfterE"
        Me.txtInsertAfterE.ReadOnly = True
        Me.txtInsertAfterE.Size = New System.Drawing.Size(121, 22)
        Me.txtInsertAfterE.TabIndex = 29
        '
        'txtInsertBeforeE
        '
        Me.txtInsertBeforeE.Location = New System.Drawing.Point(136, 68)
        Me.txtInsertBeforeE.Name = "txtInsertBeforeE"
        Me.txtInsertBeforeE.ReadOnly = True
        Me.txtInsertBeforeE.Size = New System.Drawing.Size(224, 22)
        Me.txtInsertBeforeE.TabIndex = 31
        '
        'txtReplaceThisE
        '
        Me.txtReplaceThisE.Location = New System.Drawing.Point(136, 40)
        Me.txtReplaceThisE.Name = "txtReplaceThisE"
        Me.txtReplaceThisE.ReadOnly = True
        Me.txtReplaceThisE.Size = New System.Drawing.Size(302, 22)
        Me.txtReplaceThisE.TabIndex = 26
        '
        'txtReplaceWithE
        '
        Me.txtReplaceWithE.Location = New System.Drawing.Point(136, 10)
        Me.txtReplaceWithE.Name = "txtReplaceWithE"
        Me.txtReplaceWithE.ReadOnly = True
        Me.txtReplaceWithE.Size = New System.Drawing.Size(345, 22)
        Me.txtReplaceWithE.TabIndex = 27
        '
        'lblCaseE
        '
        Me.lblCaseE.AutoSize = True
        Me.lblCaseE.Location = New System.Drawing.Point(487, 14)
        Me.lblCaseE.Name = "lblCaseE"
        Me.lblCaseE.Size = New System.Drawing.Size(42, 16)
        Me.lblCaseE.TabIndex = 30
        Me.lblCaseE.Text = "Case:"
        '
        'lblWithThisE
        '
        Me.lblWithThisE.AutoSize = True
        Me.lblWithThisE.Location = New System.Drawing.Point(444, 44)
        Me.lblWithThisE.Name = "lblWithThisE"
        Me.lblWithThisE.Size = New System.Drawing.Size(59, 16)
        Me.lblWithThisE.TabIndex = 28
        Me.lblWithThisE.Text = "WithThis"
        '
        'rbRightCropNCharE
        '
        Me.rbRightCropNCharE.AutoSize = True
        Me.rbRightCropNCharE.Location = New System.Drawing.Point(381, 101)
        Me.rbRightCropNCharE.Name = "rbRightCropNCharE"
        Me.rbRightCropNCharE.Size = New System.Drawing.Size(132, 20)
        Me.rbRightCropNCharE.TabIndex = 25
        Me.rbRightCropNCharE.TabStop = True
        Me.rbRightCropNCharE.Text = "Right Crop n Char"
        Me.rbRightCropNCharE.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharE
        '
        Me.rbLeftCropNCharE.AutoSize = True
        Me.rbLeftCropNCharE.Location = New System.Drawing.Point(381, 74)
        Me.rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        Me.rbLeftCropNCharE.Size = New System.Drawing.Size(122, 20)
        Me.rbLeftCropNCharE.TabIndex = 24
        Me.rbLeftCropNCharE.TabStop = True
        Me.rbLeftCropNCharE.Text = "Left Crop n Char"
        Me.rbLeftCropNCharE.UseVisualStyleBackColor = True
        '
        'rbInsertAfterE
        '
        Me.rbInsertAfterE.AutoSize = True
        Me.rbInsertAfterE.Location = New System.Drawing.Point(9, 100)
        Me.rbInsertAfterE.Name = "rbInsertAfterE"
        Me.rbInsertAfterE.Size = New System.Drawing.Size(90, 20)
        Me.rbInsertAfterE.TabIndex = 23
        Me.rbInsertAfterE.TabStop = True
        Me.rbInsertAfterE.Text = "Insert After"
        Me.rbInsertAfterE.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeE
        '
        Me.rbInsertBeforeE.AutoSize = True
        Me.rbInsertBeforeE.Location = New System.Drawing.Point(9, 70)
        Me.rbInsertBeforeE.Name = "rbInsertBeforeE"
        Me.rbInsertBeforeE.Size = New System.Drawing.Size(103, 20)
        Me.rbInsertBeforeE.TabIndex = 22
        Me.rbInsertBeforeE.TabStop = True
        Me.rbInsertBeforeE.Text = "Insert Before"
        Me.rbInsertBeforeE.UseVisualStyleBackColor = True
        '
        'rbReplaceThisE
        '
        Me.rbReplaceThisE.AutoSize = True
        Me.rbReplaceThisE.Location = New System.Drawing.Point(9, 40)
        Me.rbReplaceThisE.Name = "rbReplaceThisE"
        Me.rbReplaceThisE.Size = New System.Drawing.Size(106, 20)
        Me.rbReplaceThisE.TabIndex = 21
        Me.rbReplaceThisE.TabStop = True
        Me.rbReplaceThisE.Text = "ReplaceThis"
        Me.rbReplaceThisE.UseVisualStyleBackColor = True
        '
        'rbReplaceWithE
        '
        Me.rbReplaceWithE.AutoSize = True
        Me.rbReplaceWithE.Location = New System.Drawing.Point(9, 10)
        Me.rbReplaceWithE.Name = "rbReplaceWithE"
        Me.rbReplaceWithE.Size = New System.Drawing.Size(109, 20)
        Me.rbReplaceWithE.TabIndex = 20
        Me.rbReplaceWithE.TabStop = True
        Me.rbReplaceWithE.Text = "Replace With"
        Me.rbReplaceWithE.UseVisualStyleBackColor = True
        '
        'TpAutoNumber
        '
        Me.TpAutoNumber.Controls.Add(Me.gbWith)
        Me.TpAutoNumber.Controls.Add(Me.gbPlace)
        Me.TpAutoNumber.Location = New System.Drawing.Point(4, 25)
        Me.TpAutoNumber.Name = "TpAutoNumber"
        Me.TpAutoNumber.Size = New System.Drawing.Size(716, 135)
        Me.TpAutoNumber.TabIndex = 2
        Me.TpAutoNumber.Text = "AutoNumber"
        Me.TpAutoNumber.UseVisualStyleBackColor = True
        '
        'gbWith
        '
        Me.gbWith.Controls.Add(Me.nudIncrementBy)
        Me.gbWith.Controls.Add(Me.nudStartWithNumber)
        Me.gbWith.Controls.Add(Me.lblIncrementBy)
        Me.gbWith.Controls.Add(Me.lblStartWithNumber)
        Me.gbWith.Location = New System.Drawing.Point(242, 14)
        Me.gbWith.Name = "gbWith"
        Me.gbWith.Size = New System.Drawing.Size(312, 107)
        Me.gbWith.TabIndex = 1
        Me.gbWith.TabStop = False
        Me.gbWith.Text = "With:"
        '
        'nudIncrementBy
        '
        Me.nudIncrementBy.Location = New System.Drawing.Point(144, 60)
        Me.nudIncrementBy.Name = "nudIncrementBy"
        Me.nudIncrementBy.Size = New System.Drawing.Size(120, 22)
        Me.nudIncrementBy.TabIndex = 3
        Me.nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudStartWithNumber
        '
        Me.nudStartWithNumber.Location = New System.Drawing.Point(144, 32)
        Me.nudStartWithNumber.Name = "nudStartWithNumber"
        Me.nudStartWithNumber.Size = New System.Drawing.Size(120, 22)
        Me.nudStartWithNumber.TabIndex = 2
        Me.nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblIncrementBy
        '
        Me.lblIncrementBy.AutoSize = True
        Me.lblIncrementBy.Location = New System.Drawing.Point(28, 60)
        Me.lblIncrementBy.Name = "lblIncrementBy"
        Me.lblIncrementBy.Size = New System.Drawing.Size(86, 16)
        Me.lblIncrementBy.TabIndex = 1
        Me.lblIncrementBy.Text = "Increment by:"
        '
        'lblStartWithNumber
        '
        Me.lblStartWithNumber.AutoSize = True
        Me.lblStartWithNumber.Location = New System.Drawing.Point(28, 34)
        Me.lblStartWithNumber.Name = "lblStartWithNumber"
        Me.lblStartWithNumber.Size = New System.Drawing.Size(110, 16)
        Me.lblStartWithNumber.TabIndex = 0
        Me.lblStartWithNumber.Text = "Start with number:"
        '
        'gbPlace
        '
        Me.gbPlace.Controls.Add(Me.rbBeforeFileName)
        Me.gbPlace.Controls.Add(Me.rbAfterFileName)
        Me.gbPlace.Location = New System.Drawing.Point(12, 14)
        Me.gbPlace.Name = "gbPlace"
        Me.gbPlace.Size = New System.Drawing.Size(211, 107)
        Me.gbPlace.TabIndex = 0
        Me.gbPlace.TabStop = False
        Me.gbPlace.Text = "Place:"
        '
        'rbBeforeFileName
        '
        Me.rbBeforeFileName.AutoSize = True
        Me.rbBeforeFileName.Location = New System.Drawing.Point(27, 56)
        Me.rbBeforeFileName.Name = "rbBeforeFileName"
        Me.rbBeforeFileName.Size = New System.Drawing.Size(122, 20)
        Me.rbBeforeFileName.TabIndex = 1
        Me.rbBeforeFileName.TabStop = True
        Me.rbBeforeFileName.Text = "Before filename"
        Me.rbBeforeFileName.UseVisualStyleBackColor = True
        '
        'rbAfterFileName
        '
        Me.rbAfterFileName.AutoSize = True
        Me.rbAfterFileName.Location = New System.Drawing.Point(27, 30)
        Me.rbAfterFileName.Name = "rbAfterFileName"
        Me.rbAfterFileName.Size = New System.Drawing.Size(109, 20)
        Me.rbAfterFileName.TabIndex = 0
        Me.rbAfterFileName.TabStop = True
        Me.rbAfterFileName.Text = "After filename"
        Me.rbAfterFileName.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(742, 322)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 10
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(742, 350)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(75, 23)
        Me.btnRename.TabIndex = 11
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(742, 379)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 12
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 479)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lvPreview)
        Me.Controls.Add(Me.lvOri)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.lblOri)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblPath)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mass Renamer"
        Me.TabControl1.ResumeLayout(False)
        Me.TpFilename.ResumeLayout(False)
        Me.TpFilename.PerformLayout()
        Me.TpExtension.ResumeLayout(False)
        Me.TpExtension.PerformLayout()
        Me.TpAutoNumber.ResumeLayout(False)
        Me.gbWith.ResumeLayout(False)
        Me.gbWith.PerformLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlace.ResumeLayout(False)
        Me.gbPlace.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpFilename As TabPage
    Friend WithEvents TpExtension As TabPage
    Friend WithEvents TpAutoNumber As TabPage
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWith As RadioButton
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents lblCaseF As Label
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblCaseE As Label
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
End Class
