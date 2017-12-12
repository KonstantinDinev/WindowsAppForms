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
                Loop
                lblNote.Text = OpenFileDialog1.FileName  'update label
                txtNote.Text = AllText 'display file
                txtNote.Enabled = True 'allow text cursor
                CloseToolStripMenuItem.Enabled = True  'enable Close command
                OpenToolStripMenuItem.Enabled = False  'disable Open command
            Catch
                MsgBox("Error opening file.")
            Finally
                FileClose(1) 'close file
            End Try
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        txtNote.Text = ""             'clear text box
        lblNote.Text = "Load a text file with the Open command."
        CloseToolStripMenuItem.Enabled = False  'disable Close command
        OpenToolStripMenuItem.Enabled = True    'enable Open command
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
