Public Class frm_estoque

    Private Sub frm_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_estoque()
        carregar_tipo_estoque()
        carregar_tipos_relat_estoque()

    End Sub

    Private Sub btn_cadastrar_produto_Click_1(sender As Object, e As EventArgs) Handles btn_cadastrar_produto.Click
        Try
            sql = "select * from tb_estoque where codigo = '" & txt_codigo.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                sql = "update tb_estoque set produto = '" & txt_produto.Text & "', " &
                      "tamanho = '" & txt_tamanho.Text & "', " &
                      "preco = '" & txt_preco.Text & "', " &
                      "qtde = '" & txt_qtde.Text & "' where codigo = '" & txt_codigo.Text & "'"

                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                sql = "insert into tb_estoque values ( '" & txt_codigo.Text & "', '" & txt_produto.Text & "', " &
                                                      "'" & txt_tamanho.Text & "', '" & txt_preco.Text & "', '" & txt_qtde.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_estoque()
            carregar_estoque()
        Catch ex As Exception
            MsgBox("Favor preencher todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    'Private Sub img_produto_Click(sender As Object, e As EventArgs) Handles img_produto.Click
    '    Try
    '        With abrir_produto
    '            .Title = "SELECIONE UM PRODUTO"
    '            .InitialDirectory = Application.StartupPath & "\Fotos"
    '            .ShowDialog()
    '            diretorio = .FileName
    '            img_produto.Load(diretorio)
    '        End With
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub

    Private Sub txt_codigo_LostFocus(sender As Object, e As EventArgs) Handles txt_codigo.LostFocus
        Try
            sql = "select * from tb_estoque where codigo = '" & txt_codigo.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_produto.Text = rs.Fields(1).Value
                txt_tamanho.Text = rs.Fields(2).Value
                txt_preco.Text = rs.Fields(3).Value
                txt_qtde.Text = rs.Fields(4).Value
                txt_preco.Focus()
            Else
                'MsgBox("Codigo não localizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_codigo_DoubleClick(sender As Object, e As EventArgs) Handles txt_codigo.DoubleClick
        limpar_estoque()
    End Sub

    Private Sub dgv_estoque_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_estoque.CellContentClick
        Try
            With dgv_estoque
                If .CurrentRow.Cells(6).Selected = True Then 'se selecionar a coluna 6 (Alterar) do dgv
                    aux_estoque = .CurrentRow.Cells(1).Value 'pega dados da coluna 1 (codigo) do dgv
                    sql = "select * from tb_estoque where codigo = '" & aux_estoque & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        tab_estoque.SelectTab(0)
                        txt_codigo.Text = rs.Fields(0).Value
                        txt_produto.Text = rs.Fields(1).Value
                        txt_tamanho.Text = rs.Fields(2).Value
                        txt_preco.Text = rs.Fields(3).Value
                        txt_qtde.Text = rs.Fields(4).Value
                    End If
                ElseIf .CurrentRow.Cells(7).Selected = True Then 'se selecionar a coluna 7 (Excluir) do dgv
                    aux_estoque = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir?" + vbNewLine &
                    "CODIGO: " & aux_estoque & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_estoque where codigo = '" & aux_estoque & "'"
                        rs = db.Execute(sql)
                        carregar_estoque()
                    End If
                Else 'se selecionar colunas de 0 a 5 do dgv
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            'MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    'FILTRO DE BUSCA POR CODIGO OU PRODUTO
    Private Sub txt_busca_produto_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_produto.TextChanged
        Try
            With dgv_estoque
                cont = 1
                sql = "select * from tb_estoque where " & cmb_tipo_produto.Text & " like '" & txt_busca_produto.Text & "%' "
                'like: faz filtragem dinamica com a 1a letra do produto ou 1o num do codigo
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gera_relatorio_Click(sender As Object, e As EventArgs) Handles btn_gera_relatorio.Click
        Try
            If cmb_relatorio.Text = "Relatório de Estoque" Then
                frm_relatorio_estoque.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    'Private Sub frm_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    lbl_usuario.Text = UCase(frm_login.txt_usuario.Text)
    '    lbl_data.Text = Date.Today
    '    Timer1.Start()
    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    lbl_hora.Text = TimeOfDay
    'End Sub

End Class