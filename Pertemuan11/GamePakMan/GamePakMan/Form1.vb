Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    'map (peta papan permainan)
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}

    'kumpulan variabel
    Dim tsz = 40 'tile size (ukuran grid/tilenya)
    Dim pacx = 1 'pakman itu di petak x mana sekarang
    Dim pacy = 1 'pakman itu di petak y mana sekarang

    Dim enmx = 9 'musuh 1 di petak x berapa
    Dim enmy = 7 'musuh 1 di petak y berapa
    Dim enmx1 = 2 'musuh 2 di petak x berapa
    Dim enmy1 = 3 'musuh 2 di petak y berapa
    Dim enmx2 = 3 'musuh 3 di petak x berapa
    Dim enmy2 = 5 'musuh 3 di petak y berapa

    Dim goalx = 1 'goal (pintu keluar pakman di petak x brp
    Dim goaly = 7 'goal di petak y berapa
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0

    'deklarasi sprite citra yang digunakan
    Dim wall As Image = My.Resources.bata
    Dim way As Image = My.Resources.rumput

    Dim arahPakman As String
    Dim pac As Image = My.Resources.pakman
    Dim pacbawah As Image = My.Resources.pakman2
    Dim packiri As Image = My.Resources.pakman3
    Dim pacatas As Image = My.Resources.pakman4

    Dim enm As Image = My.Resources.hantu1
    Dim enm1 As Image = My.Resources.hantu2
    Dim enm2 As Image = My.Resources.hantu3

    Dim nyawa = 3
    Dim hati As Image = My.Resources.nyawa

    Dim goal As Image = My.Resources.omah

    Private Sub resetDefault()
        tsz = 40 'tile size (ukuran grid/tilenya)

        pacx = 1 'pakman itu di petak x mana sekarang
        pacy = 1 'pakman itu di petak y mana sekarang

        enmx = 9 'musuh itu di petak x berapa
        enmy = 7 'musuh itu di petak y berapa

        enmx1 = 2 'musuh itu di petak x berapa
        enmy1 = 3 'musuh itu di petak y berapa

        enmx2 = 3 'musuh itu di petak x berapa
        enmy2 = 5 'musuh itu di petak y berapa

        goalx = 1 'goal (pintu keluar pakman di petak x brp
        goaly = 7 'goal di petak y berapa

        oldpacx = 0
        oldpacy = 0
        Redraw()
        Timer1.Enabled = True
    End Sub

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)

        'gambarkan background (jalan dan tembok)
        For y = 0 To (map.GetUpperBound(0)) '0 to tinggi map
            For x = 0 To map.GetUpperBound(1) '0 to lebar map
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        'gambarkan nyawa
        For i As Integer = 0 To nyawa - 1
            g.DrawImage(hati, i * tsz, PictureBox1.Height - tsz, tsz, tsz)
        Next

        'gambarkan pacman
        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        Select Case arahPakman
            Case "atas"
                g.DrawImage(pacatas, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "bawah"
                g.DrawImage(pacbawah, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "kiri"
                g.DrawImage(packiri, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "kanan"
                g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        End Select

        'gambarkan musuh
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        g.DrawImage(enm1, enmx1 * tsz, enmy1 * tsz, tsz, tsz)
        g.DrawImage(enm2, enmx2 * tsz, enmy2 * tsz, tsz, tsz)

        'gambarkan goal
        g.DrawImage(goal, goalx * tsz, (map.GetUpperBound(0) - 1) * tsz, tsz, tsz)

        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                End If
                arahPakman = "atas"
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                End If
                arahPakman = "bawah"
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                End If
                arahPakman = "kanan"
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                End If
                arahPakman = "kiri"
        End Select
        Redraw()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form
        PictureBox1.Width = map.GetLength(1) * tsz
        PictureBox1.Height = map.GetLength(0) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz + tsz
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'engine untuk musuh
        Dim jarakx, jaraky As Integer
        Dim arah As Integer 'arah musuh, 0 atas, 1 kanan, 2 bawah, 3 kiri

        'cek jarak pakman dg musuh. kalau lebih jauh di sb x, kejar di x dulu
        'kalau lebih dekat di sb y, kejar ke sb y dulu
        jarakx = Math.Abs(pacx - enmx)
        jaraky = Math.Abs(pacy - enmy)
        If jarakx > jaraky Then 'jika lebih jauh jarak kejar di x
            If (pacx - enmx > 0) Then 'jika pakman di kanan
                arah = 1 'arah kanan
            Else 'jika tidak
                arah = 3 'arah kiri
            End If
        End If

        If jarakx < jaraky Then
            If (pacy - enmy > 0) Then 'jika pakman di bawah
                arah = 2 'arah bawah
            Else 'jika tidak
                arah = 0 'arah atas
            End If
        End If

        If (oldpacx = pacx) And (oldpacy = pacy) Then 'jika stop
            arah = Math.Floor(Rnd() * 4)
        End If

        Select Case arah
            Case 0
                If map(enmy - 1, enmx) = 1 Then
                    enmy = enmy - 1
                End If
            Case 2
                If map(enmy + 1, enmx) = 1 Then
                    enmy = enmy + 1
                End If
            Case 1
                If map(enmy, enmx + 1) = 1 Then
                    enmx = enmx + 1
                End If
            Case 3
                If map(enmy, enmx - 1) = 1 Then
                    enmx = enmx - 1
                End If
        End Select

        Dim arah2 As Integer = Math.Floor(Rnd() * 4)
        Select Case arah2
            Case 0
                If map(enmy1 - 1, enmx1) = 1 Then
                    enmy1 = enmy1 - 1
                End If
            Case 2
                If map(enmy1 + 1, enmx1) = 1 Then
                    enmy1 = enmy1 + 1
                End If
            Case 1
                If map(enmy1, enmx1 + 1) = 1 Then
                    enmx1 = enmx1 + 1
                End If
            Case 3
                If map(enmy1, enmx1 - 1) = 1 Then
                    enmx1 = enmx1 - 1
                End If
        End Select

        Dim arah3 As Integer = Math.Floor(Rnd() * 4)
        Select Case arah3
            Case 0
                If map(enmy2 - 1, enmx2) = 1 Then
                    enmy2 = enmy2 - 1
                End If
            Case 2
                If map(enmy2 + 1, enmx2) = 1 Then
                    enmy2 = enmy2 + 1
                End If
            Case 1
                If map(enmy2, enmx2 + 1) = 1 Then
                    enmx2 = enmx2 + 1
                End If
            Case 3
                If map(enmy2, enmx2 - 1) = 1 Then
                    enmx2 = enmx2 - 1
                End If
        End Select

        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        'cek apakah posisi pakman sama dg musuh
        If (pacx = enmx) And (pacy = enmy) Then
            Timer1.Enabled = False
            nyawa -= 1
            resetDefault()
        ElseIf (pacx = enmx1) And (pacy = enmy1) Then
            Timer1.Enabled = False
            nyawa -= 1
            resetDefault()
        ElseIf (pacx = enmx2) And (pacy = enmy2) Then
            Timer1.Enabled = False
            nyawa -= 1
            resetDefault()
        End If

        If nyawa = 0 Then
            Timer1.Enabled = False
            MsgBox("Nyawa habis! Game Over!")
        End If

        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = (map.GetUpperBound(0) - 1)) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub
End Class
