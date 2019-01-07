Imports System.Data.OleDb

Public Class FormEdytuj
    Public i As Integer = Form1.Tbl_motocyklDataGridView.CurrentCell.RowIndex
    Private Sub FormEdytuj_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox_Producent.Text = Form1.Tbl_motocyklDataGridView.Rows(i).Cells(1).Value
        ComboBox_Kraj.Text = Form1.Tbl_motocyklDataGridView.Rows(i).Cells(2).Value
        NumericUpDown_Sztuki.Value = Form1.Tbl_motocyklDataGridView.Rows(i).Cells(3).Value
        NumericUpDown_Netto.Value = Form1.Tbl_motocyklDataGridView.Rows(i).Cells(4).Value
        NumericUpDown_Brutto.Value = Form1.Tbl_motocyklDataGridView.Rows(i).Cells(5).Value
        ComboBox_Typ.Text = Form1.Tbl_motocyklDataGridView.Rows(i).Cells(6).Value
        ModelTextBox.Text = Form1.Tbl_motocyklDataGridView.Rows(i).Cells(7).Value
    End Sub

    Private Sub ComboBox_Producent_Click(sender As Object, e As EventArgs) Handles ComboBox_Producent.Click
        Dim cmd As New OleDbCommand
        Dim odp As New OleDbDataAdapter
        Dim ds As New DataSet
        Text = ComboBox_Producent.Text
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider = Microsoft.Jet.OleDB.4.0 ; Data Source = motoDB.mdb" 'w /bin/debug

        odp = New OleDbDataAdapter("SELECT * FROM tbl_producent", con)
        odp.Fill(ds)
        con.Close()

        ComboBox_Producent.DataSource = ds.Tables(0)
        ComboBox_Producent.ValueMember = "ID"
        ComboBox_Producent.DisplayMember = "Producent"
        ComboBox_Producent.Text = Text
    End Sub

    Private Sub ComboBox_Kraj_Click(sender As Object, e As EventArgs) Handles ComboBox_Kraj.Click
        Dim cmd As New OleDbCommand
        Dim odp As New OleDbDataAdapter
        Dim ds As New DataSet
        Text = ComboBox_Kraj.Text
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider = Microsoft.Jet.OleDB.4.0 ; Data Source = motoDB.mdb" 'w /bin/debug

        odp = New OleDbDataAdapter("SELECT * FROM tbl_kraj_produkcji", con)
        odp.Fill(ds)
        con.Close()

        ComboBox_Kraj.DataSource = ds.Tables(0)
        ComboBox_Kraj.ValueMember = "ID"
        ComboBox_Kraj.DisplayMember = "Kraj"
        ComboBox_Kraj.Text = Text
    End Sub

    Private Sub ComboBox_Typ_Click(sender As Object, e As EventArgs) Handles ComboBox_Typ.Click
        Dim cmd As New OleDbCommand
        Dim odp As New OleDbDataAdapter
        Dim ds As New DataSet

        Dim con As New OleDbConnection
        Text = ComboBox_Typ.Text
        con.ConnectionString = "Provider = Microsoft.Jet.OleDB.4.0 ; Data Source = motoDB.mdb" 'w /bin/debug

        odp = New OleDbDataAdapter("SELECT * FROM tbl_typ", con)
        odp.Fill(ds)
        con.Close()

        ComboBox_Typ.DataSource = ds.Tables(0)
        ComboBox_Typ.ValueMember = "ID"
        ComboBox_Typ.DisplayMember = "Typ motocykla"
        ComboBox_Typ.Text = Text
    End Sub

    Private Sub NumericUpDown_Netto_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Netto.ValueChanged
        NumericUpDown_Brutto.Value = NumericUpDown_Netto.Value * 1.23
    End Sub

    Private Sub NumericUpDown_Brutto_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Brutto.ValueChanged
        NumericUpDown_Netto.Value = NumericUpDown_Brutto.Value / 1.23
    End Sub

    Private Sub Button_Edytuj_Click(sender As Object, e As EventArgs) Handles Button_Edytuj.Click
        Try
            Tbl_motocyklTableAdapter.UpdateQuery(ComboBox_Producent.Text, ComboBox_Kraj.Text, NumericUpDown_Sztuki.Value, NumericUpDown_Netto.Value, NumericUpDown_Brutto.Value, ComboBox_Typ.Text, ModelTextBox.Text, i)
            Me.Validate()
            Me.Tbl_motocyklBindingSource.EndEdit()
            Me.Tbl_motocyklTableAdapter.Update(Me.MotoDBDataSet.tbl_motocykl)
            Me.Tbl_motocyklTableAdapter.Fill(Me.MotoDBDataSet.tbl_motocykl)
            Form1.Tbl_motocyklDataGridView.DataSource = Me.MotoDBDataSet.tbl_motocykl
            Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub
End Class