<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Tbl_motocyklDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_motocyklBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MotoDBDataSet = New SM.motoDBDataSet()
        Me.PasekNarzedzi = New System.Windows.Forms.MenuStrip()
        Me.PlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZapiszToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WyjdzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotocyklToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProducenciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_motocyklTableAdapter = New SM.motoDBDataSetTableAdapters.tbl_motocyklTableAdapter()
        Me.TableAdapterManager = New SM.motoDBDataSetTableAdapters.TableAdapterManager()
        CType(Me.Tbl_motocyklDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_motocyklBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotoDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PasekNarzedzi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tbl_motocyklDataGridView
        '
        Me.Tbl_motocyklDataGridView.AllowUserToResizeColumns = False
        Me.Tbl_motocyklDataGridView.AllowUserToResizeRows = False
        Me.Tbl_motocyklDataGridView.AutoGenerateColumns = False
        Me.Tbl_motocyklDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Tbl_motocyklDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Tbl_motocyklDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_motocyklDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_motocyklDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Tbl_motocyklDataGridView.DataSource = Me.Tbl_motocyklBindingSource
        Me.Tbl_motocyklDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_motocyklDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Tbl_motocyklDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.Tbl_motocyklDataGridView.Name = "Tbl_motocyklDataGridView"
        Me.Tbl_motocyklDataGridView.RowHeadersVisible = False
        Me.Tbl_motocyklDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.Tbl_motocyklDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tbl_motocyklDataGridView.Size = New System.Drawing.Size(544, 309)
        Me.Tbl_motocyklDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 24
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Producent"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producent"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 81
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Kraj Produkcji"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kraj Produkcji"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 97
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ilość sztuk"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ilość sztuk"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 82
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cena netto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cena netto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 84
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cena brutto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cena brutto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 87
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Typ"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Typ"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 61
        '
        'Tbl_motocyklBindingSource
        '
        Me.Tbl_motocyklBindingSource.DataMember = "tbl_motocykl"
        Me.Tbl_motocyklBindingSource.DataSource = Me.MotoDBDataSet
        '
        'MotoDBDataSet
        '
        Me.MotoDBDataSet.DataSetName = "motoDBDataSet"
        Me.MotoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PasekNarzedzi
        '
        Me.PasekNarzedzi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlikToolStripMenuItem, Me.MotocyklToolStripMenuItem, Me.InneToolStripMenuItem})
        Me.PasekNarzedzi.Location = New System.Drawing.Point(0, 0)
        Me.PasekNarzedzi.Name = "PasekNarzedzi"
        Me.PasekNarzedzi.Size = New System.Drawing.Size(544, 24)
        Me.PasekNarzedzi.TabIndex = 2
        Me.PasekNarzedzi.Text = "MenuStrip1"
        '
        'PlikToolStripMenuItem
        '
        Me.PlikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZapiszToolStripMenuItem, Me.WyjdzToolStripMenuItem})
        Me.PlikToolStripMenuItem.Name = "PlikToolStripMenuItem"
        Me.PlikToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.PlikToolStripMenuItem.Text = "Plik"
        '
        'ZapiszToolStripMenuItem
        '
        Me.ZapiszToolStripMenuItem.Name = "ZapiszToolStripMenuItem"
        Me.ZapiszToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ZapiszToolStripMenuItem.Text = "Zapisz"
        '
        'WyjdzToolStripMenuItem
        '
        Me.WyjdzToolStripMenuItem.Name = "WyjdzToolStripMenuItem"
        Me.WyjdzToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.WyjdzToolStripMenuItem.Text = "Wyjdz"
        '
        'MotocyklToolStripMenuItem
        '
        Me.MotocyklToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajToolStripMenuItem, Me.EdytujToolStripMenuItem})
        Me.MotocyklToolStripMenuItem.Name = "MotocyklToolStripMenuItem"
        Me.MotocyklToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MotocyklToolStripMenuItem.Text = "Motocykl"
        '
        'DodajToolStripMenuItem
        '
        Me.DodajToolStripMenuItem.Name = "DodajToolStripMenuItem"
        Me.DodajToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DodajToolStripMenuItem.Text = "Dodaj"
        '
        'EdytujToolStripMenuItem
        '
        Me.EdytujToolStripMenuItem.Name = "EdytujToolStripMenuItem"
        Me.EdytujToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EdytujToolStripMenuItem.Text = "Edytuj"
        '
        'InneToolStripMenuItem
        '
        Me.InneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProducenciToolStripMenuItem})
        Me.InneToolStripMenuItem.Name = "InneToolStripMenuItem"
        Me.InneToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.InneToolStripMenuItem.Text = "Inne"
        '
        'ProducenciToolStripMenuItem
        '
        Me.ProducenciToolStripMenuItem.Name = "ProducenciToolStripMenuItem"
        Me.ProducenciToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ProducenciToolStripMenuItem.Text = "Producenci"
        '
        'Tbl_motocyklTableAdapter
        '
        Me.Tbl_motocyklTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_historia_zakupowTableAdapter = Nothing
        Me.TableAdapterManager.tbl_kraj_produkcjiTableAdapter = Nothing
        Me.TableAdapterManager.tbl_motocyklTableAdapter = Me.Tbl_motocyklTableAdapter
        Me.TableAdapterManager.tbl_producentTableAdapter = Nothing
        Me.TableAdapterManager.tbl_typTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SM.motoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 333)
        Me.Controls.Add(Me.Tbl_motocyklDataGridView)
        Me.Controls.Add(Me.PasekNarzedzi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.PasekNarzedzi
        Me.Name = "Form1"
        Me.Text = "Sklep Motocyklowy"
        CType(Me.Tbl_motocyklDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_motocyklBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotoDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PasekNarzedzi.ResumeLayout(False)
        Me.PasekNarzedzi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MotoDBDataSet As motoDBDataSet
    Friend WithEvents Tbl_motocyklBindingSource As BindingSource
    Friend WithEvents Tbl_motocyklTableAdapter As motoDBDataSetTableAdapters.tbl_motocyklTableAdapter
    Friend WithEvents TableAdapterManager As motoDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_motocyklDataGridView As DataGridView
    Friend WithEvents PasekNarzedzi As MenuStrip
    Friend WithEvents PlikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZapiszToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WyjdzToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents MotocyklToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DodajToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProducenciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdytujToolStripMenuItem As ToolStripMenuItem
End Class
