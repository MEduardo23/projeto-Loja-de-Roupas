Public Class frm_admin

    Private Sub ESTOQUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTOQUEToolStripMenuItem.Click
        frm_estoque.ShowDialog()
    End Sub


    Private Sub GERENCIAMENTOCONTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GERENCIAMENTOCONTASToolStripMenuItem.Click
        frm_gerenciamento.ShowDialog()
    End Sub


    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        frm_relatorio_clientes.ShowDialog()
    End Sub

    Private Sub ListaDeEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeEstoqueToolStripMenuItem.Click
        frm_relatorio_estoque.ShowDialog()
    End Sub
End Class