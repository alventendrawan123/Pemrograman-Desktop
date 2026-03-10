Public Class Form1
    Dim namafile As String
    Dim ygdicari As String
    Dim posisihasilcari As Integer
    Dim StringToPrint As String

    Private Sub newToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NEwToolStripMenuItem.Click
        Dim dr As DialogResult
        If txtNotepad.Modified Then
            dr = MessageBox.Show("Do you want to save the changes?", "NotepadKu",
MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If (dr = DialogResult.No) Or (dr = DialogResult.Cancel) Then
                'do nothing 
            ElseIf dr = DialogResult.Yes Then
                saveToolStripMenuItem_Click(sender, e)
            End If
        End If
        Me.Text = "NotepadKu"
        namafile = String.Empty
        txtNotepad.Clear()
        txtNotepad.SelectionStart = 0
    End Sub


    Private Sub openStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles openStripMenuItem1.Click
        Dim dr As DialogResult
        If txtNotepad.Modified Then
            dr = MessageBox.Show("Do you want to save the changes?", "NotepadKu",
MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If dr = DialogResult.No Then 'langsung buka file baru 
                dr = openFileDialog1.ShowDialog()
                If dr = DialogResult.OK Then
                    txtNotepad.Text =
System.IO.File.ReadAllText(openFileDialog1.FileName)
                    namafile = openFileDialog1.FileName
                End If
            ElseIf dr = DialogResult.Cancel Then
                'do nothing
            ElseIf dr = DialogResult.Yes Then 'save 
                saveToolStripMenuItem_Click(sender, e)
            End If
        Else
            dr = openFileDialog1.ShowDialog() 'langsung buka file baru 
            If dr = DialogResult.OK Then
                txtNotepad.Text = System.IO.File.ReadAllText(openFileDialog1.FileName)
                namafile = openFileDialog1.FileName
            End If
        End If
        Me.Text = "NotepadKu - (" & namafile & ")"
        txtNotepad.SelectionStart = 0

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim dr As DialogResult
        If namafile = String.Empty Then
            dr = saveFileDialog1.ShowDialog()
            If dr = DialogResult.OK Then
                System.IO.File.WriteAllText(saveFileDialog1.FileName, txtNotepad.Text)
                namafile = saveFileDialog1.FileName
            End If
        Else
            System.IO.File.WriteAllText(namafile, txtNotepad.Text)
        End If
        Me.Text = "NotepadKu - (" & namafile & ")"
        txtNotepad.SelectionStart = 0
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim dr As DialogResult
        dr = saveFileDialog1.ShowDialog()
        If dr = DialogResult.OK Then
            System.IO.File.WriteAllText(saveFileDialog1.FileName, txtNotepad.Text)
            namafile = saveFileDialog1.FileName
        End If
        Me.Text = "NotepadKu - (" & namafile & ")"
        txtNotepad.SelectionStart = 0
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        Dim dr As DialogResult
        pageSetupDialog1.Document = PrintDocument1
        pageSetupDialog1.Document.DefaultPageSettings.Color = False
        dr = pageSetupDialog1.ShowDialog
        If dr = DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Dim dr As DialogResult
        StringToPrint = txtNotepad.Text
        PrintDocument1.DocumentName = "NotepadKu"
        printDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        printDialog1.Document = PrintDocument1
        dr = printDialog1.ShowDialog()
        If dr = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        newToolStripMenuItem_Click(sender, e)
        txtNotepad.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim dr As DialogResult
        If txtNotepad.Modified Then
            dr = MessageBox.Show("Do you want to save the changes?", "NotepadKu",
MessageBoxButtons.YesNoCancel)
            If dr = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(sender, e)
                Application.Exit()
            ElseIf dr = DialogResult.Cancel Then
                'do nothing 
            ElseIf dr = DialogResult.No Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If txtNotepad.CanUndo Then
            txtNotepad.Undo()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.Clear()
        If txtNotepad.SelectionLength > 0 Then
            txtNotepad.Cut()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.Clear()
        If txtNotepad.SelectionLength > 0 Then
            txtNotepad.Copy()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If Clipboard.ContainsText() Then
            txtNotepad.Paste()
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        ygdicari = InputBox("Enter text to be found: ", "Find", "", 100, 100)
        posisihasilcari = InStr(1, txtNotepad.Text, ygdicari, CompareMethod.Text)
        If posisihasilcari > 0 Then
            txtNotepad.Focus()
            txtNotepad.SelectionStart = posisihasilcari - 1
            txtNotepad.SelectionLength = ygdicari.Length
        Else
            MessageBox.Show("Text is not found.")
        End If
    End Sub

    Private Sub FindNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindNextToolStripMenuItem.Click
        posisihasilcari = InStr(posisihasilcari + 1, txtNotepad.Text, ygdicari,
CompareMethod.Text)
        If posisihasilcari > 0 Then
            txtNotepad.Focus()
            txtNotepad.SelectionStart = posisihasilcari - 1
            txtNotepad.SelectionLength = ygdicari.Length
        Else
            MessageBox.Show("Text is not found.")
        End If
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        ygdicari = InputBox("Enter text to be replaced: ", "Find", "", 100, 100)
        Dim digantijadi As String = InputBox("Replace with: ", "Replace", "", 100,
        100)
        posisihasilcari = InStr(1, txtNotepad.Text, ygdicari, CompareMethod.Text)
        If posisihasilcari > 0 Then
            txtNotepad.Focus()
            txtNotepad.SelectionStart = posisihasilcari - 1
            txtNotepad.SelectionLength = ygdicari.Length
            txtNotepad.SelectedText = ""
            txtNotepad.SelectedText = digantijadi
        Else
            MessageBox.Show("Text is not found.")
        End If
    End Sub

    Private Declare Function SendMessage _
        Lib "user32.dll" Alias "SendMessageA" (
            ByVal hWnd As Long,
            ByVal wMsg As Long,
            ByVal wParam As Long,
            ByRef lParam As Long
) As Long

    Private Const EM_LINEINDEX As Long = &HBB

    Public Sub GotoLine(txtBox As TextBox, ByVal nLineNumber As Long)
        If nLineNumber > 0 Then
            txtBox.SelectionStart = SendMessage(txtBox.Handle, EM_LINEINDEX, nLineNumber - 1, 0)
        End If
    End Sub

    Private Sub GoToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToToolStripMenuItem.Click
        Dim baris As String = InputBox("Go to line: ", "Go to Line", "", 100, 100)
        GotoLine(txtNotepad, CInt(baris))
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtNotepad.SelectAll()
    End Sub

    Private Sub InsertDataTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertDataTimeToolStripMenuItem.Click
        txtNotepad.SelectedText = Convert.ToString(Now())
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        txtNotepad.WordWrap = Not txtNotepad.WordWrap
        WordWrapToolStripMenuItem.Checked = Not WordWrapToolStripMenuItem.Checked
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim dr As DialogResult
        dr = fontDialog1.ShowDialog()
        If dr = DialogResult.OK Then
            txtNotepad.Font = fontDialog1.Font
        End If
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        StatusStrip1.Visible = Not StatusStrip1.Visible
        StatusBarToolStripMenuItem.Checked = Not StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Help goes here")
    End Sub

    Private Sub AboutNotepadKuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutNotepadKuToolStripMenuItem.Click
        MessageBox.Show("NotepadKu dibuat oleh Antonius RC (C) 2014")
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.CapsLock Then
            capsStripStatus.Enabled = Not capsStripStatus.Enabled
        End If

        If e.KeyCode = Keys.NumLock Then
            numStripStatus.Enabled = Not numStripStatus.Enabled
        End If

        If (e.KeyCode = Keys.Insert) AndAlso (insertStripStatus.Text = "INS") Then
            insertStripStatus.Text = "OVR"
        Else
            insertStripStatus.Text = "INS"
        End If
    End Sub

    Private Sub txtNotepad_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNotepad.KeyUp
        Dim line As Integer = txtNotepad.GetLineFromCharIndex(txtNotepad.SelectionStart) + 1
        toolStripStatusLine.Text = "Line: " & line
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim numChars As Integer 'untuk jumlah karakter
        Dim numLines As Integer 'untuk jumlah baris
        Dim stringForPage As String
        Dim strFormat As New StringFormat()
        Dim PrintFont As Font
        PrintFont = txtNotepad.Font

        Dim rectDraw As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))

        strFormat.Trimming = StringTrimming.Word
        e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, numChars, numLines)

        stringForPage = StringToPrint.Substring(0, numChars)
        e.Graphics.DrawString(stringForPage, PrintFont, Brushes.Black, rectDraw, strFormat)

        If numChars < StringToPrint.Length Then
            StringToPrint = StringToPrint.Substring(numChars)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNotepad.WordWrap = False
        txtNotepad.Font = New Font("Lucida Console", 10, FontStyle.Regular)
        txtNotepad.WordWrap = False
    End Sub


End Class
