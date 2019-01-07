<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdytuj
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
        Dim ProducentLabel As System.Windows.Forms.Label
        Dim Kraj_ProdukcjiLabel As System.Windows.Forms.Label
        Dim Ilość_sztukLabel As System.Windows.Forms.Label
        Dim Cena_nettoLabel As System.Windows.Forms.Label
        Dim Cena_bruttoLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEdytuj))
        Me.MotoDBDataSet = New SM.motoDBDataSet()
        Me.Tbl_motocyklBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_motocyklTableAdapter = New SM.motoDBDataSetTableAdapters.tbl_motocyklTableAdapter()
        Me.TableAdapterManager = New SM.motoDBDataSetTableAdapters.TableAdapterManager()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox_Producent = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Kraj = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown_Sztuki = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Netto = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Brutto = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox_Typ = New System.Windows.Forms.ComboBox()
        Me.Button_Edytuj = New System.Windows.Forms.Button()
        ProducentLabel = New System.Windows.Forms.Label()
        Kraj_ProdukcjiLabel = New System.Windows.Forms.Label()
        Ilość_sztukLabel = New System.Windows.Forms.Label()
        Cena_nettoLabel = New System.Windows.Forms.Label()
        Cena_bruttoLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        CType(Me.MotoDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_motocyklBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Sztuki, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Netto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Brutto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProducentLabel
        '
        ProducentLabel.AutoSize = True
        ProducentLabel.Location = New System.Drawing.Point(12, 9)
        ProducentLabel.Name = "ProducentLabel"
        ProducentLabel.Size = New System.Drawing.Size(59, 13)
        ProducentLabel.TabIndex = 3
        ProducentLabel.Text = "Producent:"
        '
        'Kraj_ProdukcjiLabel
        '
        Kraj_ProdukcjiLabel.AutoSize = True
        Kraj_ProdukcjiLabel.Location = New System.Drawing.Point(12, 35)
        Kraj_ProdukcjiLabel.Name = "Kraj_ProdukcjiLabel"
        Kraj_ProdukcjiLabel.Size = New System.Drawing.Size(75, 13)
        Kraj_ProdukcjiLabel.TabIndex = 5
        Kraj_ProdukcjiLabel.Text = "Kraj Produkcji:"
        '
        'Ilość_sztukLabel
        '
        Ilość_sztukLabel.AutoSize = True
        Ilość_sztukLabel.Location = New System.Drawing.Point(12, 61)
        Ilość_sztukLabel.Name = "Ilość_sztukLabel"
        Ilość_sztukLabel.Size = New System.Drawing.Size(60, 13)
        Ilość_sztukLabel.TabIndex = 7
        Ilość_sztukLabel.Text = "Ilość sztuk:"
        '
        'Cena_nettoLabel
        '
        Cena_nettoLabel.AutoSize = True
        Cena_nettoLabel.Location = New System.Drawing.Point(12, 87)
        Cena_nettoLabel.Name = "Cena_nettoLabel"
        Cena_nettoLabel.Size = New System.Drawing.Size(62, 13)
        Cena_nettoLabel.TabIndex = 9
        Cena_nettoLabel.Text = "Cena netto:"
        '
        'Cena_bruttoLabel
        '
        Cena_bruttoLabel.AutoSize = True
        Cena_bruttoLabel.Location = New System.Drawing.Point(12, 113)
        Cena_bruttoLabel.Name = "Cena_bruttoLabel"
        Cena_bruttoLabel.Size = New System.Drawing.Size(65, 13)
        Cena_bruttoLabel.TabIndex = 11
        Cena_bruttoLabel.Text = "Cena brutto:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(12, 139)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(28, 13)
        TypLabel.TabIndex = 13
        TypLabel.Text = "Typ:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(12, 165)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 15
        ModelLabel.Text = "Model:"
        '
        'MotoDBDataSet
        '
        Me.MotoDBDataSet.DataSetName = "motoDBDataSet"
        Me.MotoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_motocyklBindingSource
        '
        Me.Tbl_motocyklBindingSource.DataMember = "tbl_motocykl"
        Me.Tbl_motocyklBindingSource.DataSource = Me.MotoDBDataSet
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
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_motocyklBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(93, 162)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelTextBox.TabIndex = 16
        '
        'ComboBox_Producent
        '
        Me.ComboBox_Producent.FormattingEnabled = True
        Me.ComboBox_Producent.Location = New System.Drawing.Point(93, 6)
        Me.ComboBox_Producent.Name = "ComboBox_Producent"
        Me.ComboBox_Producent.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_Producent.TabIndex = 17
        '
        'ComboBox_Kraj
        '
        Me.ComboBox_Kraj.FormattingEnabled = True
        Me.ComboBox_Kraj.Location = New System.Drawing.Point(93, 32)
        Me.ComboBox_Kraj.Name = "ComboBox_Kraj"
        Me.ComboBox_Kraj.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_Kraj.TabIndex = 18
        '
        'NumericUpDown_Sztuki
        '
        Me.NumericUpDown_Sztuki.Location = New System.Drawing.Point(93, 59)
        Me.NumericUpDown_Sztuki.Name = "NumericUpDown_Sztuki"
        Me.NumericUpDown_Sztuki.Size = New System.Drawing.Size(100, 20)
        Me.NumericUpDown_Sztuki.TabIndex = 19
        '
        'NumericUpDown_Netto
        '
        Me.NumericUpDown_Netto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown_Netto.Location = New System.Drawing.Point(93, 85)
        Me.NumericUpDown_Netto.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown_Netto.Name = "NumericUpDown_Netto"
        Me.NumericUpDown_Netto.Size = New System.Drawing.Size(100, 20)
        Me.NumericUpDown_Netto.TabIndex = 20
        '
        'NumericUpDown_Brutto
        '
        Me.NumericUpDown_Brutto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown_Brutto.Location = New System.Drawing.Point(93, 111)
        Me.NumericUpDown_Brutto.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown_Brutto.Name = "NumericUpDown_Brutto"
        Me.NumericUpDown_Brutto.Size = New System.Drawing.Size(100, 20)
        Me.NumericUpDown_Brutto.TabIndex = 21
        '
        'ComboBox_Typ
        '
        Me.ComboBox_Typ.FormattingEnabled = True
        Me.ComboBox_Typ.Location = New System.Drawing.Point(93, 136)
        Me.ComboBox_Typ.Name = "ComboBox_Typ"
        Me.ComboBox_Typ.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_Typ.TabIndex = 22
        '
        'Button_Edytuj
        '
        Me.Button_Edytuj.Location = New System.Drawing.Point(15, 211)
        Me.Button_Edytuj.Name = "Button_Edytuj"
        Me.Button_Edytuj.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edytuj.TabIndex = 23
        Me.Button_Edytuj.Text = "Edytuj"
        Me.Button_Edytuj.UseVisualStyleBackColor = True
        '
        'FormEdytuj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 311)
        Me.Controls.Add(Me.Button_Edytuj)
        Me.Controls.Add(Me.ComboBox_Typ)
        Me.Controls.Add(Me.NumericUpDown_Brutto)
        Me.Controls.Add(Me.NumericUpDown_Netto)
        Me.Controls.Add(Me.NumericUpDown_Sztuki)
        Me.Controls.Add(Me.ComboBox_Kraj)
        Me.Controls.Add(Me.ComboBox_Producent)
        Me.Controls.Add(ProducentLabel)
        Me.Controls.Add(Kraj_ProdukcjiLabel)
        Me.Controls.Add(Ilość_sztukLabel)
        Me.Controls.Add(Cena_nettoLabel)
        Me.Controls.Add(Cena_bruttoLabel)
        Me.Controls.Add(TypLabel)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEdytuj"
        Me.Text = "Edycja Motocykla"
        CType(Me.MotoDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_motocyklBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Sztuki, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Netto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Brutto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MotoDBDataSet As motoDBDataSet
    Friend WithEvents Tbl_motocyklBindingSource As BindingSource
    Friend WithEvents Tbl_motocyklTableAdapter As motoDBDataSetTableAdapters.tbl_motocyklTableAdapter
    Friend WithEvents TableAdapterManager As motoDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents ComboBox_Producent As ComboBox
    Friend WithEvents ComboBox_Kraj As ComboBox
    Friend WithEvents NumericUpDown_Sztuki As NumericUpDown
    Friend WithEvents NumericUpDown_Netto As NumericUpDown
    Friend WithEvents NumericUpDown_Brutto As NumericUpDown
    Friend WithEvents ComboBox_Typ As ComboBox
    Friend WithEvents Button_Edytuj As Button
End Class
