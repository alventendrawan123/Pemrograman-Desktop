Imports System.IO
Imports System.Drawing.Imaging
Imports gma.Drawing.ImageInfo

Public Class Form1
    Private Function FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop
        Dim Resp As String = Len.ToString & " " & sizeTypes(sizeType)
        Return Resp
    End Function

    Private Sub GetFiles(ByVal PathName As String)
        Dim LItem As ListViewItem
        lvImage.Items.Clear()
        lvImage.BeginUpdate()
        For Each nFile As String In Directory.GetFiles(PathName)
            Dim sExtension As String = Path.GetExtension(nFile)
            sExtension = sExtension.ToLower
            Dim f As FileInfo = New FileInfo(nFile)
            Dim att As String = f.Attributes.ToString
            Dim size As String = f.Length.ToString
            Dim dibuat As String = f.CreationTime.ToString
            Dim akses As String = f.LastAccessTime.ToString
            Dim modi As String = f.LastWriteTime.ToString
            If (Trim(sExtension) = ".bmp" Or Trim(sExtension) = ".jpg" Or Trim(sExtension) = ".jpeg" Or Trim(sExtension) = ".gif" Or Trim(sExtension) = ".png") = True Then
                LItem = New ListViewItem()
                Dim iconForFile As Icon = SystemIcons.WinLogo
                If Not (ImageList1.Images.ContainsKey(sExtension)) Then
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(nFile)
                    ImageList1.Images.Add(sExtension, iconForFile)
                End If
                With LItem
                    .SubItems(0).Text = Path.GetFileNameWithoutExtension(nFile)
                    .SubItems.Add(sExtension)
                    .SubItems.Add(FormatFileSize(size))
                    .SubItems.Add(modi)
                    .SubItems.Add(akses)
                    .SubItems.Add(dibuat)
                    .SubItems.Add(att)
                    .ImageKey = sExtension
                    .Tag = Path.Combine(PathName, nFile)
                End With
                lvImage.Items.Add(LItem)
            End If
        Next
        lvImage.EndUpdate()
        lvImage.Columns(0).Width = -2
    End Sub

    Private Sub GetFolders(ByVal PathName As TreeNode)
        Dim di As DirectoryInfo
        PathName.Nodes.Clear()
        di = New DirectoryInfo(PathName.Tag)
        Try
            For Each nFolder In di.GetDirectories()
                Dim tNode As New TreeNode()
                With tNode
                    .ImageIndex = 1
                    .SelectedImageIndex = 1
                    .Tag = nFolder.FullName
                    .Text = nFolder.Name.ToString()
                    .Nodes.Add("")
                End With
                di = New DirectoryInfo(tNode.Tag)
                If (di.Attributes And FileAttributes.Hidden) = False Then
                    PathName.Nodes.Add(tNode)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GetDrives()
        For Each Drive In DriveInfo.GetDrives
            If (Drive.IsReady) Then
                Dim dName As String = Drive.VolumeLabel
                If String.IsNullOrEmpty(dName) Then
                    dName = Drive.Name
                End If
                Dim tNode As New TreeNode()
                With tNode
                    .ImageIndex = 0
                    .SelectedImageIndex = 0
                    .Text = dName
                    .Nodes.Add("")
                    .Tag = Drive.Name
                End With
                Call tvDrive.Nodes.Add(tNode)
            End If
        Next
    End Sub

    Function GetRaw(ByVal imgf As ImageFormat)
        If imgf.Equals(ImageFormat.Bmp) Then
            Return "Bitmap"
        ElseIf imgf.Equals(ImageFormat.Jpeg) Then
            Return "Jpeg"
        ElseIf imgf.Equals(ImageFormat.Png) Then
            Return ("PNG")
        ElseIf imgf.Equals(ImageFormat.Tiff) Then
            Return "TIFF"
        ElseIf imgf.Equals(ImageFormat.Gif) Then
            Return "GIF"
        ElseIf imgf.Equals(ImageFormat.Icon) Then
            Return "ICON"
        End If
        Return "Unknown"
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDrives()
        lvImage.Columns(0).Width = -2
        SplitContainerBawah2.Panel2.VerticalScroll.Visible = True
        SplitContainerBawah2.Panel2.HorizontalScroll.Visible = True
    End Sub

    Private Sub tvDrive_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles tvDrive.BeforeExpand
        GetFolders(e.Node)
    End Sub

    Private Sub tvDrive_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvDrive.AfterSelect
        GetFiles(e.Node.Tag)
    End Sub

    Private Sub lvImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvImage.SelectedIndexChanged
        Dim _exif As Info
        lvExif.Items.Clear()
        If lvImage.SelectedItems.Count > 0 Then
            PictureBox1.Image = Bitmap.FromFile(lvImage.SelectedItems(0).Tag.ToString)
            toolStripStatusReady.Text = lvImage.SelectedItems(0).Tag.ToString
            toolStripStatusDimension.Text = "Dimension: " & PictureBox1.Image.Size.Width.ToString & " px X " & PictureBox1.Image.Size.Height.ToString & " px"
            toolStripStatusBits.Text = "Depth: " & PictureBox1.Image.PixelFormat.ToString
            toolStripStatusResolution.Text = "Resolution: " & PictureBox1.Image.HorizontalResolution.ToString & " dpi X " & PictureBox1.Image.VerticalResolution.ToString & " dpi"
            toolStripStatusRawFormat.Text = "Compression: " & GetRaw(PictureBox1.Image.RawFormat)
            _exif = New Info(lvImage.SelectedItems(0).Tag.ToString)
            PropertyGrid1.SelectedObject = _exif
            For Each propertyName As String In _exif.PropertyItems.Keys
                Try
                    Dim LItem As ListViewItem = New ListViewItem()
                    LItem.SubItems(0).Text = propertyName
                    LItem.SubItems.Add(_exif.PropertyItems(propertyName).ToString)
                    lvExif.Items.Add(LItem)
                Catch eks As Exception
                End Try
            Next
        End If
        lvImage.Columns(0).Width = -2
        lvExif.Columns(0).Width = -2
    End Sub

    Private Sub lvImage_DoubleClick(sender As Object, e As EventArgs) Handles lvImage.DoubleClick
        Process.Start(lvImage.SelectedItems(0).Tag)
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Dim pb As PictureBox = New PictureBox
        pb.Image = Image.FromFile(toolStripStatusReady.Text)
        pb.SizeMode = PictureBoxSizeMode.AutoSize
        Dim pnl As Panel = New Panel
        pnl.AutoScroll = True
        pnl.Dock = DockStyle.Fill
        pnl.Controls.Add(pb)
        Dim f As Form = New Form
        f.WindowState = FormWindowState.Maximized
        f.Controls.Add(pnl)
        f.Show()
    End Sub
End Class
