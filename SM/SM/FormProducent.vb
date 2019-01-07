Public Class FormProducent
    Private Sub Tbl_producentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_producentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_producentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MotoDBDataSet)

    End Sub

    Private Sub FormProducent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MotoDBDataSet.tbl_producent' table. You can move, or remove it, as needed.
        Me.Tbl_producentTableAdapter.Fill(Me.MotoDBDataSet.tbl_producent)

    End Sub
End Class