Public Class frm_gerenciamento


    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick
        Try
            With dgv_contas
                If .CurrentRow.Cells(4).Selected = True Then 'se selecionar a coluna 4 (Bloquear) do dgv
                    aux_usuario = .CurrentRow.Cells(1).Value 'pega dados da coluna 1 (usuario) do dgv
                    sql = "select * from tb_login where usuario = '" & aux_usuario & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        sql = "update tb_login set status_conta = 'Bloqueada' where usuario = '" & aux_usuario & "'"
                        rs = db.Execute(sql)
                    End If

                ElseIf .CurrentRow.Cells(5).Selected = True Then 'se selecionar a coluna 5 (Alterar) do dgv
                    aux_usuario = .CurrentRow.Cells(1).Value 'pega dados da coluna 1 (usuario) do dgv
                    sql = "select * from tb_login where usuario = '" & aux_usuario & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        sql = "update tb_login set status_conta = 'Ativada' where usuario = '" & aux_usuario & "'"
                        rs = db.Execute(sql)
                    End If

                ElseIf .CurrentRow.Cells(6).Selected = True Then 'se selecionar a coluna 6 (Excluir) do dgv
                    aux_usuario = .CurrentRow.Cells(1).Value 'pega dados da coluna 1 (usuario) do dgv
                    resp = MsgBox("Deseja realmente excluir?" + vbNewLine &
                    "Usuario: " & aux_usuario & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_login where usuario = '" & aux_usuario & "'"
                        rs = db.Execute(sql)
                    End If
                Else
                    Exit Sub
                End If
                carregar_contas()
            End With
        Catch ex As Exception
            'MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


End Class