Imports C1.Win.C1FlexGrid
Imports TratamentoDeErros
Imports xAlimento
Imports GGeral
Imports System.Data.SqlClient
Public Class FrmSelecionarPessoa

#Region "Unica Instância"

    Private Sub New()

        Try
            InitializeComponent()
        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    Private Shared _Instance As FrmSelecionarPessoa = Nothing

    Public Shared Function Instance() As FrmSelecionarPessoa

        Try

            If _Instance Is Nothing OrElse _Instance.IsDisposed Then
                _Instance = New FrmSelecionarPessoa
            End If
            _Instance.BringToFront()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try
        Return _Instance

    End Function

    Private Sub InstanciaDispose(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Try

            _Instance.Dispose()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

#End Region

#Region "Declarações"

    'Modo do formulário para controlar as ações de inclusão, alteração e exclusão
    Public Enum EnModo

        Nenhum
        Inclusao
        Alteracao
        Exclusao
        Ativo
        Inativo

    End Enum

    'Modo atual do formulário
    Private ModoAtual As EnModo = EnModo.Nenhum

    'Situação atual do formulário
    Public Enum Situacao

        Ativo
        Inativo
        Todos
        Nenhum

    End Enum

    'Definir a situação atual para filtrar os dados exibidos
    Private SituacaoAtual As Situacao = Situacao.Nenhum

#End Region

#Region "Funções"

    'Realiza Consulta no banco
    Public Sub CarregarDados()

        Try

            Dim StrSQL As String
            Dim DrdSQL As SqlDataReader
            Dim Conexao As New ConexaoSQL
            Dim StrFiltro As String = ""

            'Filtro de situação
            If SituacaoAtual = Situacao.Ativo Then
                StrFiltro &= " AND Situacao = 1"
            ElseIf SituacaoAtual = Situacao.Inativo Then
                StrFiltro &= " AND Situacao = 0"
            End If

            'Filtros de busca
            If TxtCodigoPessoa.Text <> "" Then
                StrFiltro &= " AND IdPessoa LIKE '" & TxtCodigoPessoa.Text & "%'"
            End If

            If TxtNome.Text <> "" Then
                StrFiltro &= " AND Nome LIKE '" & TxtNome.Text & "%'"
            End If

            If TxtCpf.Text <> "" Then
                StrFiltro &= " AND Cpf LIKE '" & TxtCpf.Text & "%'"
            End If

            StrSQL = "SELECT 
                    P.IdPessoa,
                    P.Nome,
                    P.Cpf,
                    P.DataNascimento,
                    P.Telefone,
                    P.Email,
                    P.DataCadastro,
                    T.Tipo,
                    P.Endereco,
                    P.DataEntrada,
                    P.DataSaida,
                    P.IdLiberacao,
                    CASE 
                        WHEN P.Situacao = 1 THEN 'ATIVO'
                        ELSE 'INATIVO'
                    END AS Situacao,
                    P.Observacao
                    FROM IvanControleDeAcesso.dbo.Pessoa P
                    INNER JOIN IvanControleDeAcesso.dbo.TipoPessoa T
                    ON P.IdTipo = T.IdTipo
                    WHERE P.IdPessoa > 0 " & StrFiltro

            DrdSQL = Conexao.RetornaDR(StrSQL, ConexaoSQL.EnBanco.Azul)
            FlxTabelaSelecao.RemoveRows()

            If DrdSQL IsNot Nothing Then

                Do While DrdSQL.Read()

                    FlxTabelaSelecao.AddItem(
                    DrdSQL("IdPessoa") & vbTab &
                    DrdSQL("Nome") & vbTab &
                    DrdSQL("Cpf") & vbTab &
                    DrdSQL("DataNascimento") & vbTab &
                    DrdSQL("Telefone") & vbTab &
                    DrdSQL("Email") & vbTab &
                    DrdSQL("DataCadastro") & vbTab &
                    DrdSQL("Tipo") & vbTab &
                    DrdSQL("Endereco") & vbTab &
                    DrdSQL("DataEntrada") & vbTab &
                    DrdSQL("DataSaida") & vbTab &
                    DrdSQL("IdLiberacao") & vbTab &
                    DrdSQL("Situacao") & vbTab &
                    DrdSQL("Observacao")
                )

                Loop

            End If
            FlxTabelaSelecao.Row = -1

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    'Realiza exclusão lógica no banco
    Private Sub ExcluirPessoa()

        Try

            Dim Conexao As New ConexaoSQL
            Dim StrSQL As String
            Dim Resposta As DialogResult

            If FlxTabelaSelecao.Row > 0 Then

                Resposta = MessageBox.Show("Deseja excluir a pessoa selecionada?",
                                       "Confirmação",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question)


                If Resposta = DialogResult.Yes Then

                    StrSQL = "DELETE FROM IvanControleDeAcesso.dbo.Pessoa WHERE IdPessoa = " & FlxTabelaSelecao(FlxTabelaSelecao.RowSel, 0) & ";"
                    Conexao.RetornaDR(StrSQL, ConexaoSQL.EnBanco.Azul)
                    CarregarDados()

                End If
            Else MsgBox("Selecione um item para poder excluir.")
            End If


        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try
    End Sub

#End Region

#Region "Formulários"

    Private Sub FrmSelecionarPessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            CarregarDados()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try
    End Sub

    'SELECIONAR
    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click

        Try

            CarregarDados()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try
    End Sub

    'INCLUIR
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click

        Try

            FrmIncluirPessoa.Instance().ModoAtual = FrmIncluirPessoa.EnModo.Inclusao
            FrmIncluirPessoa.Instance.Show()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    'ALTERAR
    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click

        Try

            If FlxTabelaSelecao.Row <= 0 Then

                MsgBox("Selecione um item para poder alterar.")

            Else
                Dim ID As Integer = FlxTabelaSelecao(FlxTabelaSelecao.RowSel, 0)
                FrmIncluirPessoa.Instance().IdPessoaSelecionada = ID
                FrmIncluirPessoa.Instance().ModoAtual = FrmIncluirPessoa.EnModo.Alteracao
                FrmIncluirPessoa.Instance.Show()
                FrmIncluirPessoa.Instance.CarregarDados()
            End If


        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    'EXCLUIR
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        Try

            ExcluirPessoa()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    'VOLTAR
    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click

        Try
            If ModoAtual = EnModo.Nenhum Then

                Me.Close()

            Else

                Dim resposta As DialogResult

                resposta = MessageBox.Show("Deseja cancelar a operação?",
                                   "Confirmação",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)

                If resposta = DialogResult.Yes Then

                    Me.Close()

                End If
            End If

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    'Filtro de situação ATIVO
    Private Sub OptSituacao_CheckedChanged(sender As Object, e As EventArgs) Handles OptAtivo.CheckedChanged

        Try

            SituacaoAtual = Situacao.Ativo
            CarregarDados()


        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    'Filtro de situação INATIVO
    Private Sub OptInativo_CheckedChanged(sender As Object, e As EventArgs) Handles OptInativo.CheckedChanged

        Try

            SituacaoAtual = Situacao.Inativo
            CarregarDados()


        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    'Filtro de situação TODOS
    Private Sub OptTodos_CheckedChanged(sender As Object, e As EventArgs) Handles OptTodos.CheckedChanged

        Try

            SituacaoAtual = Situacao.Todos
            CarregarDados()


        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    'Filtro que puxa as fotos quando clica no Grid
    Public Sub FlxTabelaSelecao_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles FlxTabelaSelecao.AfterRowColChange

        FlxTabelaSelecao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        FlxTabelaSelecao.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Try
            'Estudar essa funcao aqui
            If FlxTabelaSelecao.Row <= 0 Then
                PctFotoPerfil.Image = Nothing

            Else

                Dim StrSQL As String
                Dim Conexao As New ConexaoSQL
                Dim DtSQL As DataTable
                Dim CaminhoFoto As String
                Dim IdPessoa As Integer = FlxTabelaSelecao(FlxTabelaSelecao.RowSel, 0)

                StrSQL = "SELECT Foto FROM IvanControleDeAcesso.dbo.Pessoa WHERE IdPessoa = " & IdPessoa

                DtSQL = Conexao.RetornaDT(StrSQL, ConexaoSQL.EnBanco.Azul)

                If DtSQL IsNot Nothing AndAlso DtSQL.Rows.Count > 0 Then

                    CaminhoFoto = DtSQL.Rows(0)("Foto").ToString

                    'Libera a imagem anterior da memória
                    If PctFotoPerfil.Image IsNot Nothing Then
                        PctFotoPerfil.Image.Dispose()
                        PctFotoPerfil.Image = Nothing
                    End If

                    If CaminhoFoto <> "" AndAlso IO.File.Exists(CaminhoFoto) Then

                        'Carrega imagem sem travar o arquivo
                        Using fs As New IO.FileStream(CaminhoFoto, IO.FileMode.Open, IO.FileAccess.Read)
                            PctFotoPerfil.Image = Image.FromStream(fs)
                        End Using

                    End If

                End If

            End If

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

#End Region

End Class
