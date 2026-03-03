Imports System.Windows.Forms
Imports GGeral
Imports TratamentoDeErros
Imports xAlimento

Public Class FrmControleDeAcessoMDI

    Private Sub MnuTipo_Click_1(sender As Object, e As EventArgs) Handles MnuTipo.Click
        Try

            CfgForm.AbrirFormulario(FrmTipo.Instance, Me, False, 0)

        Catch ex As Exception

            Windows.Forms.Cursor.Current = Cursors.Default
            Erro.Log(ConexaoSQL.VersaoAplicacao, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name(), ex.Message & " " & ex.StackTrace, Me.Name, System.Reflection.MethodBase.GetCurrentMethod().Name, True, CStr(Erl()))

        Finally
        End Try

    End Sub
End Class
