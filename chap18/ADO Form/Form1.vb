Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Load, MyBase.Load, MyBase.Load, MyBase.Load, MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.Instructors' table. You can move, or remove it, as needed.
        Me.InstructorsTableAdapter.Fill(Me.StudentsDataSet.Instructors)

    End Sub

    Private Sub SortInstructorsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortInstructorsToolStripButton.Click
        Try
            Me.InstructorsTableAdapter.SortInstructors(Me.StudentsDataSet.Instructors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
