Public Class frm_vendas

    '    Private Sub frm_vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        conecta_banco_access()
    '        carregar_vendas()
    '        'carregar_tipo()
    '        'carregar_tipos_relatorio()
    '    End Sub

    '    Private Sub btn_efetuar_compra_Click(sender As Object, e As EventArgs) Handles btn_efetuar_compra.Click
    '        Try
    '            sql = "select * from tb_vendas where codigo = '" & txt_codigo.Text & "'"
    '            rs = db.Execute(sql)

    '            If rs.EOF = False Then
    '                sql = "update tb_vendas set produto = '" & txt_produto.Text & "'," & _
    '                      "data_venda = '" & cmb_data_venda.Text & "', " &
    '                      "tamanho = '" & txt_tamanho.Text & "', " &
    '                      "preco = '" & txt_preco.Text & "', " &
    '                      "qtde = '" & txt_qtde.Text & "', " &
    '                      "cpf = '" & txt_cpf.Text & "',  " &
    '                      "nome = '" & txt_nome.Text & "' where codigo = '" & txt_codigo.Text & "'"

    '                rs = db.Execute(UCase(sql))
    '                MsgBox("Dados da venda alterados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

    '            Else
    '                sql = "insert into tb_vendas values ( '" & txt_codigo.Text & "', '" & txt_produto.Text & "', " &
    '                                                       "'" & cmb_data_venda.Text & "', '" & txt_tamanho.Text & "', " &
    '                                                       "'" & txt_preco.Text & "', '" & txt_qtde.Text & "', " &
    '                                                       "'" & txt_cpf.Text & "', '" & txt_nome.Text & "')"
    '                rs = db.Execute(UCase(sql))
    '                MsgBox("Dados da venda gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    '            End If
    '            limpar_vendas()
    '            carregar_vendas()
    '        Catch ex As Exception
    '            MsgBox("Erro ao cadastrar venda!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '        End Try
    '    End Sub

    '    Private Sub txt_codigo_LostFocus(sender As Object, e As EventArgs) Handles txt_codigo.LostFocus
    '        Try
    '            sql = "select * from tb_vendas where codigo = '" & txt_codigo.Text & "'"
    '            rs = db.Execute(sql)
    '            If rs.EOF = False Then
    '                txt_produto.Text = rs.Fields(1).Value
    '                cmb_data_venda.Text = rs.Fields(2).Value
    '                txt_tamanho.Text = rs.Fields(3).Value
    '                txt_preco.Text = rs.Fields(4).Value
    '                txt_qtde.Text = rs.Fields(5).Value
    '                txt_cpf.Text = rs.Fields(6).Value
    '                txt_nome.Text = rs.Fields(7).Value
    '            Else
    '                txt_codigo.Focus()
    '            End If
    '        Catch ex As Exception
    '            'MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '        End Try
    '    End Sub

    '    Private Sub txt_codigo_DoubleClick(sender As Object, e As EventArgs) Handles txt_codigo.DoubleClick
    '        limpar_vendas()
    '    End Sub

    '    Private Sub dgv_vendas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vendas.CellContentClick
    '        Try
    '            With dgv_vendas
    '                If .CurrentRow.Cells(8).Selected = True Then 'se selecionar a coluna 8 (Alterar) do dgv
    '                    aux_vendas = .CurrentRow.Cells(0).Value 'pega dados da coluna 0 (codigo) do dgv
    '                    sql = "select * from tb_vendas where codigo = '" & aux_vendas & "'"
    '                    rs = db.Execute(sql)
    '                    If rs.EOF = False Then
    '                        tab_vendas.SelectTab(0) 'explora a tab(0): Cadastrar Venda  tab(1): Lista de Vendas
    '                        txt_codigo.Text = rs.Fields(0).Value
    '                        txt_produto.Text = rs.Fields(1).Value
    '                        cmb_data_venda.Text = rs.Fields(2).Value
    '                        txt_tamanho.Text = rs.Fields(3).Value
    '                        txt_preco.Text = rs.Fields(4).Value
    '                        txt_qtde.Text = rs.Fields(5).Value
    '                        txt_cpf.Text = rs.Fields(6).Value
    '                        txt_nome.Text = rs.Fields(7).Value
    '                    End If
    '                ElseIf .CurrentRow.Cells(9).Selected = True Then 'se selecionar a coluna 9 (Excluir) do dgv
    '                    aux_vendas = .CurrentRow.Cells(0).Value
    '                    resp = MsgBox("Deseja realmente remover a venda?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
    '                    If resp = MsgBoxResult.Yes Then
    '                        sql = "delete * from tb_vendas where codigo = '" & aux_vendas & "'"
    '                        rs = db.Execute(sql)
    '                        carregar_vendas()
    '                    End If
    '                Else 'se selecionar uma coluna de 0 a 7 do dgv
    '                    Exit Sub
    '                End If
    '            End With
    '        Catch ex As Exception
    '            'MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '        End Try
    '    End Sub

    'Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        With dgv_vendas
    '            cont = 1
    '            sql = "select * from tb_clientes where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%' "
    '            'like: faz filtragem dinamica com a 1a letra do nome ou 1o num do cpf
    '            rs = db.Execute(sql)
    '            .Rows.Clear()
    '            Do While rs.EOF = False
    '                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
    '                cont = cont + 1
    '                rs.MoveNext()
    '            Loop
    '        End With
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub

    'Private Sub btn_gerar_relatorio_Click(sender As Object, e As EventArgs)
    '    Try
    '        If cmb_relatorios.Text = "Relatório de Clientes" Then
    '            frm_relat_clientes.ShowDialog()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '    End Try
    'End Sub


    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    lbl_usuario.Text = UCase(frm_login.txt_usuario.Text)
    '    lbl_data.Text = Date.Today
    '    Timer1.Start()
    'End Sub


    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    lbl_hora.Text = TimeOfDay
    'End Sub

End Class