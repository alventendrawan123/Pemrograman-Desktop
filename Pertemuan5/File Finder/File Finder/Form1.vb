Imports System.IO
Imports System.Net.WebRequestMethods

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
        Return Len.ToString & " " & sizeTypes(sizeType)
    End Function

    Private Sub GetFiles(ByVal PathName As String)
        Dim LItem As ListViewItem
        lvFile.Items.Clear()
        lvFile.BeginUpdate()
        For Each nFile As String In Directory.GetFiles(PathName, txtExtension.Text.Trim)
            Dim sExtension As String = Path.GetExtension(nFile).ToLower
            Dim f As FileInfo = New FileInfo(nFile)
            If (f.Attributes And FileAttributes.Hidden) = False Then
                LItem = New ListViewItem()
                If Not (ImageList1.Images.ContainsKey(sExtension)) Then
                    ImageList1.Images.Add(sExtension, System.Drawing.Icon.ExtractAssociatedIcon(nFile))
                End If
                With LItem
                    .SubItems(0).Text = Path.GetFileNameWithoutExtension(nFile)
                    .SubItems.Add(sExtension)
                    .SubItems.Add(FormatFileSize(f.Length))
                    .SubItems.Add(f.LastWriteTime.ToString)
                    .SubItems.Add(f.LastAccessTime.ToString)
                    .SubItems.Add(f.CreationTime.ToString)
                    .SubItems.Add(f.Attributes.ToString)
                    .SubItems.Add(nFile)
                    .ImageKey = sExtension
                    .Tag = nFile
                End With
                lvFile.Items.Add(LItem)
            End If
        Next
        lvFile.EndUpdate()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
    End Sub

    Private Sub GetFiles2(ByVal PathName As String)
        Dim LItem As ListViewItem
        lvFile.Items.Clear()
        lvFile.BeginUpdate()
        Try
            ToolStripProgressBar1.Maximum = My.Computer.FileSystem.GetFiles(PathName).Count
            ToolStripProgressBar1.Minimum = 0
            ToolStripProgressBar1.Step = 1
            ToolStripProgressBar1.Value = 1
        Catch
        End Try
        Try
            For Each nFile As String In Directory.GetFiles(PathName, txtExtension.Text, SearchOption.AllDirectories)
                If nFile.ToLower.Contains(cbFind.Text.ToLower) Then
                    ToolStripProgressBar1.PerformStep()
                    Dim sExtension As String = Path.GetExtension(nFile).ToLower
                    Dim f As FileInfo = New FileInfo(nFile)
                    If (f.Attributes And FileAttributes.Hidden) = False Then
                        LItem = New ListViewItem()
                        If Not (ImageList1.Images.ContainsKey(sExtension)) Then
                            ImageList1.Images.Add(sExtension, System.Drawing.Icon.ExtractAssociatedIcon(nFile))
                        End If
                        With LItem
                            .SubItems(0).Text = Path.GetFileNameWithoutExtension(nFile)
                            .SubItems.Add(sExtension)
                            .SubItems.Add(FormatFileSize(f.Length))
                            .SubItems.Add(f.LastWriteTime.ToString)
                            .SubItems.Add(f.LastAccessTime.ToString)
                            .SubItems.Add(f.CreationTime.ToString)
                            .SubItems.Add(f.Attributes.ToString)
                            .SubItems.Add(nFile)
                            .ImageKey = sExtension
                            .Tag = nFile
                        End With
                        lvFile.Items.Add(LItem)
                    End If
                End If
            Next
        Catch
        End Try
        lvFile.EndUpdate()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
    End Sub

    Private Sub GetFolders(ByVal PathName As TreeNode)
        PathName.Nodes.Clear()
        Try
            For Each nFolder As DirectoryInfo In New DirectoryInfo(PathName.Tag).GetDirectories()
                If (nFolder.Attributes And FileAttributes.Hidden) = False Then
                    Dim tNode As New TreeNode() With {.ImageIndex = 1, .SelectedImageIndex = 1, .Tag = nFolder.FullName, .Text = nFolder.Name}
                    tNode.Nodes.Add("")
                    PathName.Nodes.Add(tNode)
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub GetDrives()
        tvDrive.Nodes.Clear()
        For Each Drive In DriveInfo.GetDrives
            If Drive.IsReady Then
                Dim dName As String = If(String.IsNullOrEmpty(Drive.VolumeLabel), Drive.Name, Drive.VolumeLabel)
                Dim tNode As New TreeNode() With {.ImageIndex = 0, .SelectedImageIndex = 0, .Text = dName, .Tag = Drive.Name}
                tNode.Nodes.Add("")
                tvDrive.Nodes.Add(tNode)
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDrives()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next

        For Each curDrive As DriveInfo In My.Computer.FileSystem.Drives
            If curDrive.DriveType = DriveType.Fixed Then
                Dim theFreeSpace As Long = curDrive.AvailableFreeSpace
                Label3.Text &= curDrive.VolumeLabel & " (" & curDrive.Name & ") Free " & FormatFileSize(theFreeSpace) & " - " & curDrive.DriveFormat & vbCrLf
            End If
        Next
    End Sub

    Private Sub tvDrive_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles tvDrive.BeforeExpand
        GetFolders(e.Node)
    End Sub

    Private Sub tvDrive_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvDrive.AfterSelect
        GetFiles(e.Node.Tag)
        ToolStripProgressBar1.Value = 0
        ToolStripStatusLabel1.Text = e.Node.Tag
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If ToolStripStatusLabel1.Text <> "Ready" And My.Computer.FileSystem.DirectoryExists(ToolStripStatusLabel1.Text) Then
            GetFiles2(ToolStripStatusLabel1.Text)
            ToolStripProgressBar1.Value = ToolStripProgressBar1.Maximum
        Else
            MsgBox("Please select a drive/directory first from Tree View on the left side")
        End If
    End Sub

    Private Sub lvFile_DoubleClick(sender As Object, e As EventArgs) Handles lvFile.DoubleClick
        If lvFile.SelectedItems.Count = 1 Then
            Process.Start(lvFile.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Process.Start(lvFile.SelectedItems(0).Tag)
        End If
    End Sub

    'Private Sub CopyPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyPathToolStripMenuItem.Click
    '    If LlvFile.SelectedItems.Count = 1 Then
    '        Clipboard.SetText(LlvFile.SelectedItems(0).Tag)
    '        MsgBox("Copied Successfully!")
    '    End If
    'End Sub


    Private Sub CopyPathToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyPathToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Clipboard.SetText(lvFile.SelectedItems(0).Tag)
            MsgBox("Copied Successfully!")
        End If
    End Sub

    Private Sub CopyFolderPathToClipboardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyFolderPathToClipboardToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Clipboard.SetText(Path.GetDirectoryName(lvFile.SelectedItems(0).Tag))
            MsgBox("Copied Successfully!")
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        GetDrives()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        sfd.DefaultExt = "*.txt"
        sfd.FileName = "Export.txt"
        sfd.Filter = "Text File (*.txt) | *.txt"

        If sfd.ShowDialog = DialogResult.OK Then
            Using writer As New StreamWriter(sfd.FileName)
                writer.WriteLine("Name,Extension,File Size,Last Modified,Last Accessed,File Created,Attributes,Full Path")

                For Each item As ListViewItem In lvFile.Items
                    For index = 0 To item.SubItems.Count - 1
                        If index > 0 Then writer.Write(",")
                        writer.Write(item.SubItems(index).Text)
                    Next
                    writer.WriteLine()
                Next
            End Using
        End If
    End Sub

    Private Sub txtExtension_Leave(sender As System.Object, e As System.EventArgs) Handles txtExtension.Leave
        If ToolStripStatusLabel1.Text <> "Ready" Then
            GetFiles(ToolStripStatusLabel1.Text)
            ToolStripProgressBar1.Value = 0
        End If
    End Sub

    Private Sub CopyPathToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CopyPathToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Clipboard.SetText(lvFile.SelectedItems(0).Tag)
            MsgBox("Copied Successfully!")
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub
End Class