Public Class Form1

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim AllText As String = "", LineOfText As String = ""
        OpenFileDialog1.Filter = "Text files (*.TXT)|*.TXT"
        OpenFileDialog1.ShowDialog() 'display Open dialog box
        If OpenFileDialog1.FileName <> "" Then
            Try 'open file and trap any errors using handler
                FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
                Do Until EOF(1) 'read lines from file
                    LineOfText = LineInput(1)
                    'add each line to the AllText variable
                    AllText = AllText & LineOfText & vbCrLf
                Loop                   'update label
                lblNote.Text = OpenFileDialog1.FileName
                txtNote.Text = AllText 'display file
                txtNote.Enabled = True 'allow text cursor
                CloseToolStripMenuItem.Enabled = True  'enable Close command
                OpenToolStripMenuItem.Enabled = False  'disable Open command
            Catch
                MsgBox("Error opening file. It might be too big.")
            Finally
                FileClose(1) 'close file
            End Try
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        txtNote.Text = ""             'clear text box
        lblNote.Text = "Load a text file with the Open command."
        CloseToolStripMenuItem.Enabled = False  'disable Close command
        OpenToolStripMenuItem.Enabled = True    'enable Open command
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
            PrintLine(1, txtNote.Text) 'copy text to disk
            FileClose(1)
        End If
    End Sub

    Private Sub InsertDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertDateToolStripMenuItem.Click
        txtNote.Text = My.Computer.Clock.LocalTime & vbCrLf & txtNote.Text
        txtNote.Select(1, 0)  'remove selection
    End Sub

    Private Sub SortTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortTextToolStripMenuItem.Click
        Dim ln, curline, letter As String
        Dim i, charsInFile, lineCount As Short

        'determine number of lines in text box object (txtNote)
        lineCount = 0 'this variable holds total number of lines
        charsInFile = txtNote.Text.Length 'get total characters
        For i = 0 To charsInFile - 1 'move one char at a time
            letter = txtNote.Text.Substring(i, 1) 'get letter
            If letter = Chr(13) Then 'if carriage ret found
                lineCount += 1 'go to next line (add to count)
                i += 1 'skip linefeed char (typically follows cr on PC)
            End If
        Next i

        'build an array to hold the text in the text box
        ReDim strArray(lineCount) 'create array of proper size
        curline = 1
        ln = "" 'use ln to build lines one character at a time
        For i = 0 To charsInFile - 1 'loop through text again
            letter = txtNote.Text.Substring(i, 1) 'get letter
            If letter = Chr(13) Then 'if carriage return found
                curline = curline + 1 'increment line count
                i += 1 'skip linefeed char
                ln = "" 'clear line and go to next
            Else
                ln = ln & letter 'add letter to line
                strArray(curline) = ln 'and put in array
            End If
        Next i

        'sort array
        ShellSort(strArray, lineCount)

        'then display sorted array in text box
        txtNote.Text = ""
        curline = 1
        For i = 1 To lineCount
            txtNote.Text = txtNote.Text & _
              strArray(curline) & vbCrLf
            curline += 1
        Next i
        txtNote.Select(1, 0)   'remove text selection
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
