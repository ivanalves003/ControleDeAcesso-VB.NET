Imports System.Windows.Forms
Imports GGeral
Imports TratamentoDeErros
Imports xAlimento

Public Class FrmControleDeAcessoMDI

    Private Sub MnuTipo_Click_1(sender As Object, e As EventArgs) Handles MnuTipo.Click
1:      Try

2:          CfgForm.AbrirFormulario(FrmTipo.Instance, Me, False, 0)

3:      Catch ex As Exception

4:          Windows.Forms.Cursor.Current = Cursors.Default
5:          Erro.Log(ConexaoSQL.VersaoAplicacao, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name(), ex.Message & " " & ex.StackTrace, Me.Name, System.Reflection.MethodBase.GetCurrentMethod().Name, True, CStr(Erl()))

6:      Finally
7:      End Try

    End Sub

    Private Sub MnuPessoaSeleciona_Click(sender As Object, e As EventArgs) Handles MnuPessoaSeleciona.Click

8:      Try

9:          CfgForm.AbrirFormulario(FrmSelecionarPessoa.Instance, Me, False, 0)

10:     Catch ex As Exception

11:         Windows.Forms.Cursor.Current = Cursors.Default
12:         Erro.Log(ConexaoSQL.VersaoAplicacao, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name(), ex.Message & " " & ex.StackTrace, Me.Name, System.Reflection.MethodBase.GetCurrentMethod().Name, True, CStr(Erl()))

13:     Finally
14:     End Try

    End Sub

    Private Sub MnuPessoaIncluir_Click(sender As Object, e As EventArgs) Handles MnuPessoaIncluir.Click

15:     Try

16:         CfgForm.AbrirFormulario(FrmIncluirPessoa.Instance, Me, False, 0)

17:     Catch ex As Exception

18:         Windows.Forms.Cursor.Current = Cursors.Default
19:         Erro.Log(ConexaoSQL.VersaoAplicacao, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name(), ex.Message & " " & ex.StackTrace, Me.Name, System.Reflection.MethodBase.GetCurrentMethod().Name, True, CStr(Erl()))

20:     Finally
21:     End Try

    End Sub

    Private Sub SelecionarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelecionarToolStripMenuItem1.Click

22:     Try

23:         CfgForm.AbrirFormulario(FrmLiberacao.Instance, Me, False, 0)

24:     Catch ex As Exception
25:         Erro.Tratar(ex, Erl.ToString)
26:     End Try

    End Sub
End Class
