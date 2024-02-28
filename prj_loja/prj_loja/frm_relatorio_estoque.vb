Public Class frm_relatorio_estoque

    Private Sub frm_relatorio_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CadastroDataSet1.tb_estoque' table. You can move, or remove it, as needed.
        Me.Tb_estoqueTableAdapter.query_produtos(Me.CadastroDataSet1.tb_estoque)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class