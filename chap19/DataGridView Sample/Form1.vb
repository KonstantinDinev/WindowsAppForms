Public Class Form1

    Private Sub bindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bindingNavigatorSaveItem.Click
        If Me.Validate Then
            Me.InstructorsBindingSource.EndEdit()
            Me.InstructorsTableAdapter.Update(Me.StudentsDataSet.Instructors)
        Else
            System.Windows.Forms.MessageBox.Show(Me, "Validation errors occurred.", "Save", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.StudentsDataSet.Classes)
        'TODO: This line of code loads data into the 'StudentsDataSet.Instructors' table. You can move, or remove it, as needed.
        Me.InstructorsTableAdapter.Fill(Me.StudentsDataSet.Instructors)

    End Sub

End Class
