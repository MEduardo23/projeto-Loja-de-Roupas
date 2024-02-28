Public Class frm_relatorio_clientes

    Private Sub frm_relatorio_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CadastroDataSet1.tb_clientes' table. You can move, or remove it, as needed.
        Me.Tb_clientesTableAdapter.query_clientes(Me.CadastroDataSet1.tb_clientes)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class