Public Class frm_login


    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_tipo_conta()
        carregar_contas()
    End Sub


    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        Try
            sql = "select * from tb_login where usuario = '" & txt_nome_usuario.Text & "' or email = '" & txt_email_usuario.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Conta já cadastrada!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf txt_senha_usuario.Text <> txt_rsenha_usuario.Text Then
                    MsgBox("Senhas não conferem!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            gerar_id_conta()
            sql = "insert into tb_login values ( '" & id_conta & "', " & _
                                                "'" & txt_nome_usuario.Text & "', '" & txt_email_usuario.Text & "', " & _
                                                "'" & txt_senha_usuario.Text & "', 'Ativada', '" & cmb_tipo_conta.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Conta criada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            txt_nome_usuario.Clear()
            txt_email_usuario.Clear()
            txt_senha_usuario.Clear()
            txt_rsenha_usuario.Clear()
            txt_nome_usuario.Focus()

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub chk_visualizar_Click(sender As Object, e As EventArgs) Handles chk_visualizar.Click
        Try
            If txt_senha_usuario.PasswordChar = "*" Or txt_rsenha_usuario.PasswordChar = "*" Then
                txt_senha_usuario.PasswordChar = ""
                txt_rsenha_usuario.PasswordChar = ""
            Else
                txt_senha_usuario.PasswordChar = "*"
                txt_rsenha_usuario.PasswordChar = "*"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            Timer1.Start()
            sql = "select * from tb_login where (usuario = '" & txt_usuario.Text & "' or email = '" & txt_usuario.Text & "') and senha = '" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                status_login = 1
            ElseIf txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then
                status_login = 2
            Else
                status_login = 0
            End If
        Catch ex As Exception
            MsgBox("Erro ao logar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If ProgressBar1.Value() < 100 Then
                ProgressBar1.Value = ProgressBar1.Value + 1
            Else
                Timer1.Stop()
                ProgressBar1.Value = 0
                If status_login = 1 Then
                    MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()
                    frm_home.ShowDialog()
                ElseIf status_login = 2 Then
                    MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()
                    frm_admin.ShowDialog()
                Else
                    MsgBox("Usuário ou senha inválidos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_usuario.Clear()
                    txt_senha.Clear()
                    txt_usuario.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub chk_visualizar2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visualizar2.CheckedChanged
        Try
            If txt_senha.PasswordChar = "*" Then
                txt_senha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "*"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    'Private Sub cmb_tipo_conta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_conta.SelectedIndexChanged
    '    Try
    '        If cmb_tipo_conta.SelectedIndex = 0 Then
    '            MsgBox("Conta Usuário logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    '            Me.Hide()
    '            Form1.ShowDialog()
    '        ElseIf cmb_tipo_conta.SelectedIndex = 1 Then
    '            MsgBox("Conta Administrador logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    '            Me.Hide()
    '            frm_admin.ShowDialog()
    '        End If
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub
End Class