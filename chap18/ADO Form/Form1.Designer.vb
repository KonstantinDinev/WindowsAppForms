<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim InstructorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.InstructorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.InstructorTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.SortInstructorsToolStrip = New System.Windows.Forms.ToolStrip
        Me.SortInstructorsToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.InstructorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsDataSet = New ADO_Form.StudentsDataSet
        Me.InstructorsTableAdapter = New ADO_Form.StudentsDataSetTableAdapters.InstructorsTableAdapter
        InstructorLabel = New System.Windows.Forms.Label
        CType(Me.InstructorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InstructorsBindingNavigator.SuspendLayout()
        Me.SortInstructorsToolStrip.SuspendLayout()
        CType(Me.InstructorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InstructorLabel
        '
        InstructorLabel.AutoSize = True
        InstructorLabel.Location = New System.Drawing.Point(98, 83)
        InstructorLabel.Name = "InstructorLabel"
        InstructorLabel.Size = New System.Drawing.Size(50, 13)
        InstructorLabel.TabIndex = 1
        InstructorLabel.Text = "Instructor:"
        '
        'InstructorsBindingNavigator
        '
        Me.InstructorsBindingNavigator.AddNewItem = Me.bindingNavigatorAddNewItem
        Me.InstructorsBindingNavigator.BindingSource = Me.InstructorsBindingSource
        Me.InstructorsBindingNavigator.CountItem = Me.bindingNavigatorCountItem
        Me.InstructorsBindingNavigator.CountItemFormat = "of {0}"
        Me.InstructorsBindingNavigator.DeleteItem = Me.bindingNavigatorDeleteItem
        Me.InstructorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem, Me.bindingNavigatorSaveItem})
        Me.InstructorsBindingNavigator.Location = New System.Drawing.Point(0, 25)
        Me.InstructorsBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.InstructorsBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.InstructorsBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.InstructorsBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.InstructorsBindingNavigator.Name = "InstructorsBindingNavigator"
        Me.InstructorsBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
        Me.InstructorsBindingNavigator.Size = New System.Drawing.Size(434, 25)
        Me.InstructorsBindingNavigator.TabIndex = 0
        Me.InstructorsBindingNavigator.Text = "BindingNavigator1"
        '
        'bindingNavigatorAddNewItem
        '
        Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorAddNewItem.Image = CType(resources.GetObject("bindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
        Me.bindingNavigatorAddNewItem.Text = "Add new"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorDeleteItem
        '
        Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorDeleteItem.Image = CType(resources.GetObject("bindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
        Me.bindingNavigatorDeleteItem.Text = "Delete"
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'bindingNavigatorSeparator
        '
        Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.bindingNavigatorPositionItem.Text = "0"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        '
        'bindingNavigatorSaveItem
        '
        Me.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorSaveItem.Image = CType(resources.GetObject("bindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem"
        Me.bindingNavigatorSaveItem.Text = "Save Data"
        '
        'InstructorTextBox
        '
        Me.InstructorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorsBindingSource, "Instructor", True))
        Me.InstructorTextBox.Location = New System.Drawing.Point(179, 80)
        Me.InstructorTextBox.Name = "InstructorTextBox"
        Me.InstructorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InstructorTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Phone number:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorsBindingSource, "PhoneNumber", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(179, 132)
        Me.MaskedTextBox1.Mask = "(999) 000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(125, 20)
        Me.MaskedTextBox1.TabIndex = 4
        '
        'SortInstructorsToolStrip
        '
        Me.SortInstructorsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortInstructorsToolStripButton})
        Me.SortInstructorsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SortInstructorsToolStrip.Name = "SortInstructorsToolStrip"
        Me.SortInstructorsToolStrip.Size = New System.Drawing.Size(434, 25)
        Me.SortInstructorsToolStrip.TabIndex = 5
        Me.SortInstructorsToolStrip.Text = "ToolStrip1"
        '
        'SortInstructorsToolStripButton
        '
        Me.SortInstructorsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SortInstructorsToolStripButton.Name = "SortInstructorsToolStripButton"
        Me.SortInstructorsToolStripButton.Text = "SortInstructors"
        '
        'InstructorsBindingSource
        '
        Me.InstructorsBindingSource.DataMember = "Instructors"
        Me.InstructorsBindingSource.DataSource = Me.StudentsDataSet
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "StudentsDataSet"
        '
        'InstructorsTableAdapter
        '
        Me.InstructorsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 266)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(InstructorLabel)
        Me.Controls.Add(Me.InstructorTextBox)
        Me.Controls.Add(Me.InstructorsBindingNavigator)
        Me.Controls.Add(Me.SortInstructorsToolStrip)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.InstructorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InstructorsBindingNavigator.ResumeLayout(False)
        Me.InstructorsBindingNavigator.PerformLayout()
        Me.SortInstructorsToolStrip.ResumeLayout(False)
        CType(Me.InstructorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InstructorsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents bindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InstructorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents SortInstructorsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents SortInstructorsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents InstructorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsDataSet As ADO_Form.StudentsDataSet
    Friend WithEvents InstructorsTableAdapter As ADO_Form.StudentsDataSetTableAdapters.InstructorsTableAdapter

End Class
