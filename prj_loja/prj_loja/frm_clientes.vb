Public Class frm_clientes

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_dados()
        carregar_tipo()
        carregar_tipos_relatorio()
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With abrir_foto
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gravar_Click_1(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            sql = "select * from tb_clientes where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                diretorio = rs.Fields(11).Value
                sql = "update tb_clientes set data_nascimento = '" & txt_data_nasc.Text & "'," & _
                      "nome = '" & txt_nome.Text & "', " &
                      "cep = '" & txt_cep.Text & "', " &
                      "endereco = '" & txt_endereco.Text & "', " &
                      "complemento = '" & txt_comp.Text & "', " &
                      "bairro = '" & txt_bairro.Text & "',  " &
                      "cidade = '" & txt_cidade.Text & "', " &
                      "uf = '" & txt_uf.Text & "', " &
                      "celular = '" & txt_celular.Text & "', " &
                      "email = '" & txt_email.Text & "', " &
                      "foto = '" & diretorio & "' where cpf = '" & txt_cpf.Text & "'"

                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                sql = "insert into tb_clientes values ( '" & txt_cpf.Text & "', '" & txt_data_nasc.Text & "', " &
                                                       "'" & txt_nome.Text & "', '" & txt_cep.Text & "', " &
                                                       "'" & txt_endereco.Text & "', '" & txt_comp.Text & "', " &
                                                       "'" & txt_cidade.Text & "', '" & txt_bairro.Text & "' , " &
                                                       "'" & txt_uf.Text & "', '" & txt_celular.Text & "', " &
                                                       "'" & txt_email.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_dados()
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao gravar no Banco de Dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "select * from tb_cep where cep = '" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_comp.Focus()
            Else
                'MsgBox("CEP não localizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from tb_clientes where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_data_nasc.Text = rs.Fields(1).Value
                txt_nome.Text = rs.Fields(2).Value
                txt_cep.Text = rs.Fields(3).Value
                txt_endereco.Text = rs.Fields(4).Value
                txt_comp.Text = rs.Fields(5).Value
                txt_cidade.Text = rs.Fields(6).Value
                txt_bairro.Text = rs.Fields(7).Value
                txt_uf.Text = rs.Fields(8).Value
                txt_celular.Text = rs.Fields(9).Value
                txt_email.Text = rs.Fields(10).Value
                img_foto.Load(rs.Fields(11).Value)
            Else
                txt_nome.Focus()
            End If
        Catch ex As Exception
            'MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_dados()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(3).Selected = True Then 'se selecionar a coluna 3 (Alterar) do dgv
                    aux_cpf = .CurrentRow.Cells(1).Value 'pega dados da coluna 1 (produto) do dgv
                    sql = "select * from tb_clientes where cpf = '" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        tab_clientes.SelectTab(0) 'explora a tab (0) Dados Pessoais, tab (1) é Busca Avançada
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_data_nasc.Text = rs.Fields(2).Value
                        txt_cep.Text = rs.Fields(3).Value
                        txt_endereco.Text = rs.Fields(4).Value
                        txt_comp.Text = rs.Fields(5).Value
                        txt_cidade.Text = rs.Fields(6).Value
                        txt_bairro.Text = rs.Fields(7).Value
                        txt_uf.Text = rs.Fields(8).Value
                        txt_celular.Text = rs.Fields(9).Value
                        txt_email.Text = rs.Fields(10).Value
                        img_foto.Load(rs.Fields(11).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then 'se selecionar a coluna 4 (Excluir) do dgv
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir?" + vbNewLine &
                    "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_clientes where cpf = '" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_dados()
                    End If
                Else 'se selecionar colunas 0, 1 ou 2 do dgv
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            'MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            With dgv_dados
                cont = 1
                sql = "select * from tb_clientes where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%' "
                'like: faz filtragem dinamica com a 1a letra do nome ou 1o num do cpf
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gerar_relatorio_Click(sender As Object, e As EventArgs) Handles btn_gerar_relatorio.Click
        Try
            If cmb_relatorios.Text = "Relatório de Clientes" Then
                frm_relatorio_clientes.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_usuario.Text = UCase(frm_login.txt_usuario.Text)
        lbl_data.Text = Date.Today
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
    End Sub

    Private Sub cmb_relatorios_Click(sender As Object, e As EventArgs) Handles cmb_relatorios.Click

    End Sub

End Class