Imports C1.Win.C1FlexGrid
Imports TratamentoDeErros
Imports xAlimento
Imports GGeral
Imports System.Data.SqlClient
Public Class FrmSelecionarPessoa

#Region "Unica Instância"

    Private Sub New()

1:      Try
2:          InitializeComponent()
3:      Catch ex As Exception
4:          Erro.Tratar(ex, Erl.ToString)
5:      End Try

    End Sub

    Private Shared _Instance As FrmSelecionarPessoa = Nothing

    Public Shared Function Instance() As FrmSelecionarPessoa

6:      Try

7:          If _Instance Is Nothing OrElse _Instance.IsDisposed Then
8:              _Instance = New FrmSelecionarPessoa
9:          End If
10:         _Instance.BringToFront()

11:     Catch ex As Exception
12:         Erro.Tratar(ex, Erl.ToString)
13:     End Try
14:     Return _Instance

    End Function

    Private Sub InstanciaDispose(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

15:     Try

16:         _Instance.Dispose()

17:     Catch ex As Exception
18:         Erro.Tratar(ex, Erl.ToString)
19:     End Try

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

20:     Try

21:         Dim StrSQL As String
22:         Dim DrdSQL As SqlDataReader
23:         Dim Conexao As New ConexaoSQL
24:         Dim StrFiltro As String = ""

            'Filtro de situação
25:         If SituacaoAtual = Situacao.Ativo Then
26:             StrFiltro &= " AND Situacao = 1"
27:         ElseIf SituacaoAtual = Situacao.Inativo Then
28:             StrFiltro &= " AND Situacao = 0"
29:         End If

            'Filtros de busca
30:         If TxtCodigoPessoa.Text <> "" Then
31:             StrFiltro &= " AND IdPessoa LIKE '" & TxtCodigoPessoa.Text & "%'"
32:         End If

33:         If TxtNome.Text <> "" Then
34:             StrFiltro &= " AND Nome LIKE '" & TxtNome.Text & "%'"
35:         End If

36:         If TxtCpf.Text <> "" Then
37:             StrFiltro &= " AND Cpf LIKE '" & TxtCpf.Text & "%'"
38:         End If

39:         StrSQL = "SELECT 
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

40:         DrdSQL = Conexao.RetornaDR(StrSQL, ConexaoSQL.EnBanco.Azul)
41:         FlxTabelaSelecao.RemoveRows()

42:         If DrdSQL IsNot Nothing Then

43:             Do While DrdSQL.Read()

44:                 FlxTabelaSelecao.AddItem(
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

45:             Loop

46:         End If
47:         FlxTabelaSelecao.Row = -1

48:     Catch ex As Exception
49:         Erro.Tratar(ex, Erl.ToString)
50:     End Try

    End Sub

    'Realiza exclusão lógica no banco
    Private Sub ExcluirPessoa()

51:     Try

52:         Dim Conexao As New ConexaoSQL
53:         Dim StrSQL As String
54:         Dim Resposta As DialogResult

55:         If FlxTabelaSelecao.Row > 0 Then

56:             Resposta = MessageBox.Show("Deseja excluir a pessoa selecionada?",
                                       "Confirmação",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question)


57:             If Resposta = DialogResult.Yes Then

58:                 StrSQL = "DELETE FROM IvanControleDeAcesso.dbo.Pessoa WHERE IdPessoa = " & FlxTabelaSelecao(FlxTabelaSelecao.RowSel, 0) & ";"
59:                 Conexao.RetornaDR(StrSQL, ConexaoSQL.EnBanco.Azul)
60:                 CarregarDados()

61:             End If
62:         Else MsgBox("Selecione um item para poder excluir.")
63:         End If


64:     Catch ex As Exception
65:         Erro.Tratar(ex, Erl.ToString)
66:     End Try
    End Sub

#End Region

#Region "Formulários"

    Private Sub FrmSelecionarPessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

67:     Try

68:         CarregarDados()

69:     Catch ex As Exception
70:         Erro.Tratar(ex, Erl.ToString)
71:     End Try
    End Sub

    'SELECIONAR
    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click

72:     Try

73:         CarregarDados()

74:     Catch ex As Exception
75:         Erro.Tratar(ex, Erl.ToString)
76:     End Try
    End Sub

    'INCLUIR
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click

77:     Try

78:         FrmIncluirPessoa.Instance().ModoAtual = FrmIncluirPessoa.EnModo.Inclusao
79:         FrmIncluirPessoa.Instance.Show()

80:     Catch ex As Exception
81:         Erro.Tratar(ex, Erl.ToString)
82:     End Try

    End Sub

    'ALTERAR
    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click

83:     Try

84:         If FlxTabelaSelecao.Row <= 0 Then

85:             MsgBox("Selecione um item para poder alterar.")

86:         Else
87:             Dim ID As Integer = FlxTabelaSelecao(FlxTabelaSelecao.RowSel, 0)
88:             FrmIncluirPessoa.Instance().IdPessoaSelecionada = ID
89:             FrmIncluirPessoa.Instance().ModoAtual = FrmIncluirPessoa.EnModo.Alteracao
                'FrmIncluirPessoa.Instance.Show()
                'FrmIncluirPessoa.Instance.CarregarDados()
90:             Dim frm = FrmIncluirPessoa.Instance()
91:             frm.Show()
92:             frm.CarregarDados()
93:         End If


94:     Catch ex As Exception
95:         Erro.Tratar(ex, Erl.ToString)
96:     End Try

    End Sub

    'EXCLUIR
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

97:     Try

98:         ExcluirPessoa()

99:     Catch ex As Exception
100:        Erro.Tratar(ex, Erl.ToString)
101:    End Try

    End Sub

    'VOLTAR
    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click

102:    Try
103:        If ModoAtual = EnModo.Nenhum Then

104:            Me.Close()

105:        Else

106:            Dim resposta As DialogResult

107:            resposta = MessageBox.Show("Deseja cancelar a operação?",
                                   "Confirmação",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)

108:            If resposta = DialogResult.Yes Then

109:                Me.Close()

110:            End If
111:        End If

112:    Catch ex As Exception
113:        Erro.Tratar(ex, Erl.ToString)
114:    End Try

    End Sub

    'Filtro de situação ATIVO
    Private Sub OptSituacao_CheckedChanged(sender As Object, e As EventArgs) Handles OptAtivo.CheckedChanged

115:    Try

116:        SituacaoAtual = Situacao.Ativo
117:        CarregarDados()


118:    Catch ex As Exception
119:        Erro.Tratar(ex, Erl.ToString)
120:    End Try

    End Sub

    'Filtro de situação INATIVO
    Private Sub OptInativo_CheckedChanged(sender As Object, e As EventArgs) Handles OptInativo.CheckedChanged

121:    Try

122:        SituacaoAtual = Situacao.Inativo
123:        CarregarDados()


124:    Catch ex As Exception
125:        Erro.Tratar(ex, Erl.ToString)
126:    End Try

    End Sub

    'Filtro de situação TODOS
    Private Sub OptTodos_CheckedChanged(sender As Object, e As EventArgs) Handles OptTodos.CheckedChanged

127:    Try

128:        SituacaoAtual = Situacao.Todos
129:        CarregarDados()


130:    Catch ex As Exception
131:        Erro.Tratar(ex, Erl.ToString)
132:    End Try

    End Sub

    'Filtro que puxa as fotos quando clica no Grid
    Public Sub FlxTabelaSelecao_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles FlxTabelaSelecao.AfterRowColChange

133:    Try
134:        FlxTabelaSelecao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
135:        FlxTabelaSelecao.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
            'Estudar essa funcao aqui
136:        If FlxTabelaSelecao.Row <= 0 Then
137:            PctFotoPerfil.Image = Nothing

138:        Else

139:            Dim StrSQL As String
140:            Dim Conexao As New ConexaoSQL
141:            Dim DtSQL As DataTable
142:            Dim CaminhoFoto As String
143:            Dim IdPessoa As Integer = FlxTabelaSelecao(FlxTabelaSelecao.RowSel, 0)

144:            StrSQL = "SELECT Foto FROM IvanControleDeAcesso.dbo.Pessoa WHERE IdPessoa = " & IdPessoa

145:            DtSQL = Conexao.RetornaDT(StrSQL, ConexaoSQL.EnBanco.Azul)

146:            If DtSQL IsNot Nothing AndAlso DtSQL.Rows.Count > 0 Then

147:                CaminhoFoto = DtSQL.Rows(0)("Foto").ToString

                    'Libera a imagem anterior da memória
148:                If PctFotoPerfil.Image IsNot Nothing Then
149:                    PctFotoPerfil.Image.Dispose()
150:                    PctFotoPerfil.Image = Nothing
151:                End If

152:                If CaminhoFoto <> "" AndAlso IO.File.Exists(CaminhoFoto) Then

                        'Carrega imagem sem travar o arquivo
153:                    Using fs As New IO.FileStream(CaminhoFoto, IO.FileMode.Open, IO.FileAccess.Read)
154:                        PctFotoPerfil.Image = Image.FromStream(fs)
155:                    End Using

156:                End If

157:            End If

158:        End If

159:    Catch ex As Exception
160:        Erro.Tratar(ex, Erl.ToString)
161:    End Try

    End Sub

#End Region

End Class
