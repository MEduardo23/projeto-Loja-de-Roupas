Public Class frm_home

    Private Sub CLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTESToolStripMenuItem.Click
        frm_clientes.ShowDialog()
    End Sub

    Private Sub VENDASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDASToolStripMenuItem.Click
        frm_vendas.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_usuario.Text = UCase(frm_login.txt_usuario.Text)
        lbl_data.Text = Date.Today
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
    End Sub

End Class
