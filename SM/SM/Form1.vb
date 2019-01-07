Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_motocyklTableAdapter.Fill(Me.MotoDBDataSet.tbl_motocykl)
    End Sub

    Private Sub ZapiszToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZapiszToolStripMenuItem.Click
        Me.Validate()
        Me.Tbl_motocyklBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MotoDBDataSet)
    End Sub

    Private Sub DodajToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodajToolStripMenuItem.Click
        FormDodaj.ShowDialog()
    End Sub

    Private Sub ProducenciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProducenciToolStripMenuItem.Click
        FormProducent.ShowDialog()
    End Sub

    Private Sub EdytujToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdytujToolStripMenuItem.Click
        FormEdytuj.ShowDialog()
    End Sub
End Class
