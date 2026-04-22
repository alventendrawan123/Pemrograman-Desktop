Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1

    Dim interval As Integer = 1000 * 60
    Dim indeks As Integer = 0
    Dim counter As Integer = 0
    Dim arrayGambar As List(Of String) = New List(Of String)
    Private Const SPI_SETDESKWALLPAPER As Integer = &H14
    Private Const SPIF_UPDATEINIFILE As Integer = &H1
    Private Const SPIF_SENDWININICHANGE As Integer = &H2
    Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtPath.Text = FolderBrowserDialog1.SelectedPath
            Dim folderInfo As New IO.DirectoryInfo(txtPath.Text)
            clbWallpaper.Items.Clear()
            clbWallpaper.Items.AddRange(folderInfo.GetFiles("*.jpg"))
            clbWallpaper.Items.AddRange(folderInfo.GetFiles("*.jpeg"))
            clbWallpaper.Items.AddRange(folderInfo.GetFiles("*.bmp"))
            clbWallpaper.Items.AddRange(folderInfo.GetFiles("*.png"))
        End If
    End Sub

    Private Sub cbPreview_Click(sender As Object, e As EventArgs) Handles cbInterval.Click
        If cbPreview.Checked Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub clbWallpaper_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbWallpaper.SelectedIndexChanged
        Dim imageLocation As String
        If cbPreview.Checked Then
            PictureBox1.Image = New Bitmap(clbWallpaper.SelectedItem.ToString)
        End If
        arrayGambar.Clear()
        For x As Integer = 0 To clbWallpaper.CheckedItems.Count - 1
            imageLocation = clbWallpaper.CheckedItems(x).ToString
            arrayGambar.Add(imageLocation)
        Next
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        If cbInterval.SelectedIndex > -1 Then
            If btnRun.Text = "Run!" Then
                btnRun.Text = "Stop!"
                Select Case cbInterval.SelectedIndex
                    Case 0
                        interval = 10 * 1000
                    Case 1
                        interval = 60 * 1000
                    Case 2
                        interval = 3 * 60 * 1000
                    Case 3
                        interval = 5 * 60 * 1000
                    Case 4
                        interval = 10 * 60 * 1000
                    Case 5
                        interval = 15 * 60 * 1000
                    Case 6
                        interval = 30 * 60 * 1000
                    Case 7
                        interval = 60 * 60 * 1000
                End Select
                TimerWall.Interval = interval
                TimerWall.Enabled = True
                timerElapsed.Enabled = True
            Else
                btnRun.Text = "Run!"
                TimerWall.Enabled = False
                indeks = 0
                counter = 0
                ToolStripStatusReady.Text = "Ready."
                timerElapsed.Enabled = False
            End If
        End If
    End Sub

    Private Sub TimerWall_Tick(sender As Object, e As EventArgs) Handles TimerWall.Tick
        Try
            Dim imageLocation As String = arrayGambar(indeks)
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imageLocation,
        SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
            ToolStripStatusCurrent.Text = "Current wallpaper: " & imageLocation
            If indeks < clbWallpaper.CheckedItems.Count - 1 Then
                indeks = indeks + 1
            Else
                indeks = 0
            End If
        Catch Ex As Exception
            MsgBox("Error setting Wallpaper: " & Ex.Message)
        End Try
    End Sub

    Private Sub TImerElapsed_Tick(sender As Object, e As EventArgs) Handles timerElapsed.Tick
        counter = counter + 1
        ToolStripStatusReady.Text = "Time elapsed: " & CInt(counter) & " secs"
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        indeks = 0
        counter = 0
        arrayGambar = New List(Of String)
        txtPath.Clear()
        clbWallpaper.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Wallpaper Changer v1.0 " & vbCrLf & "Created by Andi Putrayana" & vbCrLf & "andi.putrayana@ti.ukdw.ac.id")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cbPreview.Checked Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub cbInterval_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbInterval.SelectedIndexChanged

    End Sub
End Class
