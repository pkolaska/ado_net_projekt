<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProducent))
        Dim IDLabel As System.Windows.Forms.Label
        Dim ProducentLabel As System.Windows.Forms.Label
        Me.MotoDBDataSet = New SM.motoDBDataSet()
        Me.Tbl_producentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_producentTableAdapter = New SM.motoDBDataSetTableAdapters.tbl_producentTableAdapter()
        Me.TableAdapterManager = New SM.motoDBDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_producentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_producentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_producentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ProducentTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        ProducentLabel = New System.Windows.Forms.Label()
        CType(Me.MotoDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_producentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_producentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_producentBindingNavigator.SuspendLayout()
        CType(Me.Tbl_producentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MotoDBDataSet
        '
        Me.MotoDBDataSet.DataSetName = "motoDBDataSet"
        Me.MotoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_producentBindingSource
        '
        Me.Tbl_producentBindingSource.DataMember = "tbl_producent"
        Me.Tbl_producentBindingSource.DataSource = Me.MotoDBDataSet
        '
        'Tbl_producentTableAdapter
        '
        Me.Tbl_producentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_historia_zakupowTableAdapter = Nothing
        Me.TableAdapterManager.tbl_kraj_produkcjiTableAdapter = Nothing
        Me.TableAdapterManager.tbl_motocyklTableAdapter = Nothing
        Me.TableAdapterManager.tbl_producentTableAdapter = Me.Tbl_producentTableAdapter
        Me.TableAdapterManager.tbl_typTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SM.motoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_producentBindingNavigator
        '
        Me.Tbl_producentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_producentBindingNavigator.BindingSource = Me.Tbl_producentBindingSource
        Me.Tbl_producentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_producentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_producentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_producentBindingNavigatorSaveItem})
        Me.Tbl_producentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_producentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_producentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_producentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_producentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_producentBindingNavigator.Name = "Tbl_producentBindingNavigator"
        Me.Tbl_producentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_producentBindingNavigator.Size = New System.Drawing.Size(583, 25)
        Me.Tbl_producentBindingNavigator.TabIndex = 0
        Me.Tbl_producentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Tbl_producentBindingNavigatorSaveItem
        '
        Me.Tbl_producentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_producentBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_producentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_producentBindingNavigatorSaveItem.Name = "Tbl_producentBindingNavigatorSaveItem"
        Me.Tbl_producentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Tbl_producentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_producentDataGridView
        '
        Me.Tbl_producentDataGridView.AutoGenerateColumns = False
        Me.Tbl_producentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_producentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_producentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_producentDataGridView.DataSource = Me.Tbl_producentBindingSource
        Me.Tbl_producentDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.Tbl_producentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Tbl_producentDataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.Tbl_producentDataGridView.Location = New System.Drawing.Point(283, 25)
        Me.Tbl_producentDataGridView.Name = "Tbl_producentDataGridView"
        Me.Tbl_producentDataGridView.RowHeadersVisible = False
        Me.Tbl_producentDataGridView.Size = New System.Drawing.Size(300, 330)
        Me.Tbl_producentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Producent"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producent"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(18, 70)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_producentBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(83, 67)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'ProducentLabel
        '
        ProducentLabel.AutoSize = True
        ProducentLabel.Location = New System.Drawing.Point(18, 96)
        ProducentLabel.Name = "ProducentLabel"
        ProducentLabel.Size = New System.Drawing.Size(59, 13)
        ProducentLabel.TabIndex = 4
        ProducentLabel.Text = "Producent:"
        '
        'ProducentTextBox
        '
        Me.ProducentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_producentBindingSource, "Producent", True))
        Me.ProducentTextBox.Location = New System.Drawing.Point(83, 93)
        Me.ProducentTextBox.Name = "ProducentTextBox"
        Me.ProducentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProducentTextBox.TabIndex = 5
        '
        'FormProducent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 355)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(ProducentLabel)
        Me.Controls.Add(Me.ProducentTextBox)
        Me.Controls.Add(Me.Tbl_producentDataGridView)
        Me.Controls.Add(Me.Tbl_producentBindingNavigator)
        Me.Name = "FormProducent"
        Me.Text = "FormProducent"
        CType(Me.MotoDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_producentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_producentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_producentBindingNavigator.ResumeLayout(False)
        Me.Tbl_producentBindingNavigator.PerformLayout()
        CType(Me.Tbl_producentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MotoDBDataSet As motoDBDataSet
    Friend WithEvents Tbl_producentBindingSource As BindingSource
    Friend WithEvents Tbl_producentTableAdapter As motoDBDataSetTableAdapters.tbl_producentTableAdapter
    Friend WithEvents TableAdapterManager As motoDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_producentBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_producentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_producentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ProducentTextBox As TextBox
End Class
