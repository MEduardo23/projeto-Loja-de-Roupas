Module Module1
    Public diretorio, sql, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public banco_access = Application.StartupPath & "\banco_dados\cadastro.accdb"
    Public aux_cpf, aux_usuario, aux_codigo, aux_estoque, aux_vendas As String
    Public cont, id_conta, status_login As Integer


    'CONEXAO - BANCO ACCESS **************************************************************
    Sub conecta_banco_access() 'Sub de conexão Access
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & banco_access)
            MsgBox("Conexão realizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    'LOGIN **************************************************************
    Sub gerar_id_conta()
        sql = "select * from tb_login order by id_conta desc"
        rs = db.Execute(sql)
        If rs.BOF = True Then 'BOF - Begin of File
            id_conta = 1
        Else
            id_conta = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub carregar_contas()
        Try
            With frm_gerenciamento.dgv_contas
                cont = 1
                sql = "select * from tb_login order by usuario asc" 'classifica nomes em ordem alfabetica
                rs = db.Execute(sql) 'executa a query
                .Rows.Clear() 'limpa linhas do DataGrid
                Do While rs.EOF = False 'faça enquanto existir registros na tabela
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing, Nothing) 'alimenta dgv com itens das colunas usuario(1), senha (2) e tipo_conta(4) da tabela Login do Access
                    cont = cont + 1 'da uma sequencia numerica
                    rs.MoveNext() 'move para o próximo registro
                Loop
            End With
        Catch ex As Exception
            'MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_conta()
        Try
            With frm_login.cmb_tipo_conta.Items
                .Add("Usuario")
                .Add("Administrador")
            End With
            frm_login.cmb_tipo_conta.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    'CLIENTES **************************************************************
    Sub limpar_dados()
        With frm_clientes
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_data_nasc.Clear()
            .txt_cep.Clear()
            .txt_endereco.Clear()
            .txt_comp.Clear()
            .txt_cidade.Clear()
            .txt_bairro.Clear()
            .txt_uf.Clear()
            .txt_celular.Clear()
            .txt_email.Clear()
            .img_foto.Load(Application.StartupPath & "\Fotos\foto_em_branco.png")
            .txt_cpf.Focus()
        End With
    End Sub

    Sub carregar_dados()
        Try
            With frm_clientes.dgv_dados
                cont = 1
                sql = "select * from tb_clientes order by nome asc" 'classifica nomes em ordem alfabetica
                rs = db.Execute(sql) 'executa a query
                .Rows.Clear() 'limpa linhas do DataGrid
                Do While rs.EOF = False 'faça enquanto existir registros na tabela
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing) 'alimenta dgv com itens das colunas cpf(0) e nome(2) da tabela do Access
                    cont = cont + 1 'da uma sequencia numerica
                    rs.MoveNext() 'move para o próximo registro
                Loop
            End With
        Catch ex As Exception
            'MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo()
        Try
            With frm_clientes.cmb_tipo.Items
                .Add("CPF")
                .Add("NOME")
            End With
            frm_clientes.cmb_tipo.SelectedIndex = 1 'aparece como padrao na ComboBox a coluna 1 (NOME)
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipos_relatorio()
        Try
            With frm_clientes.cmb_relatorios.Items
                .Add("Relatório de Clientes")
            End With
            frm_clientes.cmb_relatorios.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    'ESTOQUE *****************************************
    Sub limpar_estoque()
        With frm_estoque
            .txt_codigo.Clear()
            .txt_produto.Clear()
            .txt_tamanho.Clear()
            .txt_preco.Clear()
            .txt_qtde.Clear()
            .txt_codigo.Focus()
        End With
    End Sub

    Sub carregar_estoque()
        Try
            With frm_estoque.dgv_estoque
                cont = 1
                sql = "select * from tb_estoque order by codigo asc" 'classifica produtos em ordem de codigo
                rs = db.Execute(sql) 'executa a query
                .Rows.Clear() 'limpa linhas do DataGrid
                Do While rs.EOF = False 'faça enquanto existir registros na tabela
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    cont = cont + 1 'da uma sequencia numerica
                    rs.MoveNext() 'move para o próximo registro
                Loop
            End With
        Catch ex As Exception
            'MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_estoque()
        Try
            With frm_estoque.cmb_tipo_produto.Items
                .Add("CODIGO")
                .Add("PRODUTO")
            End With
            frm_estoque.cmb_tipo_produto.SelectedIndex = 1 'aparece como padrao na ComboBox a coluna 1 (PRODUTO)
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipos_relat_estoque()
        Try
            With frm_estoque.cmb_relatorio.Items
                .Add("Relatório de Estoque")
            End With
            frm_estoque.cmb_relatorio.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    ''VENDAS **************************************************************
    'Sub limpar_vendas()
    '    With frm_vendas
    '        .txt_codigo.Clear()
    '        .txt_produto.Clear()
    '        '.cmb_data_venda
    '        .txt_tamanho.Clear()
    '        .txt_preco.Clear()
    '        .txt_qtde.Clear()
    '        .txt_cpf.Clear()
    '        .txt_nome.Clear()
    '        .txt_codigo.Focus()
    '    End With
    'End Sub

    'Sub carregar_vendas()
    '    Try
    '        With frm_vendas.dgv_vendas
    '            cont = 1
    '            sql = "select * from tb_vendas order by codigo asc" 'classifica produtos em ordem de codigo
    '            rs = db.Execute(sql)
    '            .Rows.Clear()
    '            Do While rs.EOF = False
    '                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing, Nothing)
    '                cont = cont + 1
    '                rs.MoveNext()
    '            Loop
    '        End With
    '    Catch ex As Exception
    '        'MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '    End Try
    'End Sub

End Module
