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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.StudentsDataSet = New DataGridView_Sample.StudentsDataSet
        Me.InstructorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstructorsTableAdapter = New DataGridView_Sample.StudentsDataSetTableAdapters.InstructorsTableAdapter
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
        Me.InstructorsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassesTableAdapter = New DataGridView_Sample.StudentsDataSetTableAdapters.ClassesTableAdapter
        Me.ClassesDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox
        Me.bindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel
        Me.bindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InstructorsBindingNavigator.SuspendLayout()
        CType(Me.InstructorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClassesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "StudentsDataSet"
        '
        'InstructorsBindingSource
        '
        Me.InstructorsBindingSource.DataMember = "Instructors"
        Me.InstructorsBindingSource.DataSource = Me.StudentsDataSet
        '
        'InstructorsTableAdapter
        '
        Me.InstructorsTableAdapter.ClearBeforeFill = True
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
        Me.InstructorsBindingNavigator.Size = New System.Drawing.Size(804, 25)
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
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(100, 25)
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
        'InstructorsDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.FormatProvider = New System.Globalization.CultureInfo("en-US")
        Me.InstructorsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.InstructorsDataGridView.AutoGenerateColumns = False
        Me.InstructorsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.InstructorsDataGridView.ColumnHeadersVisible = False
        Me.InstructorsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn1)
        Me.InstructorsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn2)
        Me.InstructorsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn3)
        Me.InstructorsDataGridView.DataSource = Me.InstructorsBindingSource
        Me.InstructorsDataGridView.GridColor = System.Drawing.Color.Navy
        Me.InstructorsDataGridView.Location = New System.Drawing.Point(12, 50)
        Me.InstructorsDataGridView.Name = "InstructorsDataGridView"
        Me.InstructorsDataGridView.Size = New System.Drawing.Size(330, 220)
        Me.InstructorsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InstructorID"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.FormatProvider = New System.Globalization.CultureInfo("en-US")
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "InstructorID"
        Me.DataGridViewTextBoxColumn1.Name = "InstructorID"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Instructor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Instructor"
        Me.DataGridViewTextBoxColumn2.Name = "Instructor"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber"
        DataGridViewCellStyle3.Format = "(999) 000-0000"
        DataGridViewCellStyle3.FormatProvider = New System.Globalization.CultureInfo("en-US")
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn3.Name = "PhoneNumber"
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.StudentsDataSet
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'ClassesDataGridView
        '
        Me.ClassesDataGridView.AutoGenerateColumns = False
        Me.ClassesDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn5)
        Me.ClassesDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn6)
        Me.ClassesDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn7)
        Me.ClassesDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn13)
        Me.ClassesDataGridView.DataSource = Me.ClassesBindingSource
        Me.ClassesDataGridView.Location = New System.Drawing.Point(361, 50)
        Me.ClassesDataGridView.Name = "ClassesDataGridView"
        Me.ClassesDataGridView.Size = New System.Drawing.Size(431, 220)
        Me.ClassesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ClassName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ClassName"
        Me.DataGridViewTextBoxColumn5.Name = "ClassName"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn6.Name = "Department"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Prof"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Prof"
        Me.DataGridViewTextBoxColumn7.Name = "Prof"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "DaysAndTimes"
        Me.DataGridViewTextBoxColumn13.HeaderText = "DaysAndTimes"
        Me.DataGridViewTextBoxColumn13.Name = "DaysAndTimes"
        '
        'ClassesBindingNavigator
        '
        Me.ClassesBindingNavigator.AddNewItem = Me.bindingNavigatorAddNewItem1
        Me.ClassesBindingNavigator.BindingSource = Me.ClassesBindingSource
        Me.ClassesBindingNavigator.CountItem = Me.bindingNavigatorCountItem1
        Me.ClassesBindingNavigator.CountItemFormat = "of {0}"
        Me.ClassesBindingNavigator.DeleteItem = Me.bindingNavigatorDeleteItem1
        Me.ClassesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem1, Me.bindingNavigatorMovePreviousItem1, Me.bindingNavigatorSeparator3, Me.bindingNavigatorPositionItem1, Me.bindingNavigatorCountItem1, Me.bindingNavigatorSeparator4, Me.bindingNavigatorMoveNextItem1, Me.bindingNavigatorMoveLastItem1, Me.bindingNavigatorSeparator5, Me.bindingNavigatorAddNewItem1, Me.bindingNavigatorDeleteItem1})
        Me.ClassesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClassesBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem1
        Me.ClassesBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem1
        Me.ClassesBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem1
        Me.ClassesBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem1
        Me.ClassesBindingNavigator.Name = "ClassesBindingNavigator"
        Me.ClassesBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem1
        Me.ClassesBindingNavigator.Size = New System.Drawing.Size(804, 25)
        Me.ClassesBindingNavigator.TabIndex = 3
        Me.ClassesBindingNavigator.Text = "BindingNavigator1"
        '
        'bindingNavigatorMoveFirstItem1
        '
        Me.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem1
        '
        Me.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'bindingNavigatorSeparator3
        '
        Me.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator"
        '
        'bindingNavigatorPositionItem1
        '
        Me.bindingNavigatorPositionItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Me.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 25)
        Me.bindingNavigatorPositionItem1.Text = "0"
        Me.bindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'bindingNavigatorCountItem1
        '
        Me.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem1.Text = "of {0}"
        Me.bindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'bindingNavigatorSeparator4
        '
        Me.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator"
        '
        'bindingNavigatorMoveNextItem1
        '
        Me.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem1
        '
        Me.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'bindingNavigatorSeparator5
        '
        Me.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator"
        '
        'bindingNavigatorAddNewItem1
        '
        Me.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorAddNewItem1.Image = CType(resources.GetObject("bindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem"
        Me.bindingNavigatorAddNewItem1.Text = "Add new"
        '
        'bindingNavigatorDeleteItem1
        '
        Me.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorDeleteItem1.Image = CType(resources.GetObject("bindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem"
        Me.bindingNavigatorDeleteItem1.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(804, 354)
        Me.Controls.Add(Me.ClassesDataGridView)
        Me.Controls.Add(Me.InstructorsDataGridView)
        Me.Controls.Add(Me.InstructorsBindingNavigator)
        Me.Controls.Add(Me.ClassesBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "The Instructors and Classes Tables"
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InstructorsBindingNavigator.ResumeLayout(False)
        Me.InstructorsBindingNavigator.PerformLayout()
        CType(Me.InstructorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClassesBindingNavigator.ResumeLayout(False)
        Me.ClassesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentsDataSet As DataGridView_Sample.StudentsDataSet
    Friend WithEvents InstructorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InstructorsTableAdapter As DataGridView_Sample.StudentsDataSetTableAdapters.InstructorsTableAdapter
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
    Friend WithEvents InstructorsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassesTableAdapter As DataGridView_Sample.StudentsDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents ClassesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents bindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator

End Class
