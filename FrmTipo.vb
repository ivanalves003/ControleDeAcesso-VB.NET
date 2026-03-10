Imports GGeral
Imports TratamentoDeErros
Imports xAlimento

Public Class FrmTipo

#Region "Unica Instância"
    Private Sub New()
1:      InitializeComponent()
    End Sub
    Private Shared _Instance As FrmTipo = Nothing
    Public Shared Function Instance() As FrmTipo
2:      If _Instance Is Nothing OrElse _Instance.IsDisposed Then
3:          _Instance = New FrmTipo
4:      End If
5:      _Instance.BringToFront()
6:      Return _Instance
    End Function
    Private Sub InstanciaDispose(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

7:      _Instance.Dispose()

    End Sub

#End Region

#Region "Declarações"


#End Region

#Region "Funções"

    Private Enum EnModo
        Nenhum
        Inclusao
        Alteracao
        Exclusao
    End Enum

    Private ModoAtual As EnModo = EnModo.Nenhum

    Private Sub ConfigurarGrid()

        FlxTabelaSelecao.Cols(1).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        FlxTabelaSelecao.Cols(2).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
        FlxTabelaSelecao.Cols(3).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
        FlxTabelaSelecao.Rows(0).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter

        FlxTabelaSelecao.Cols(1).Caption = "Código"
        FlxTabelaSelecao.Cols(2).Caption = "Tipo Pessoa"
        FlxTabelaSelecao.Cols(3).Caption = "Observação"

        'FlxTabelaSelecao.Cols(1).Width = 35
        'FlxTabelaSelecao.Cols(2).Width = 200
        'FlxTabelaSelecao.Cols(3).Width = 200

        FlxTabelaSelecao.AllowEditing = False
        FlxTabelaSelecao.AutoSizeCols()

    End Sub

    Private Sub CarregarDados()
8:      Dim conexao As New ConexaoSQL
9:      Dim strSQL As String
10:     Dim drdSQL As DataTable
11:     Dim strFiltro1 As String = ""
12:     Dim strFiltro2 As String = ""

13:     Try
14:         If TxtTipoPessoa.Text <> "" Then
15:             strFiltro1 = " AND Tipo LIKE '" & TxtTipoPessoa.Text & "%'"
16:         End If

17:         If TxtCodigoTipo.Text <> "" Then
18:             strFiltro2 = " AND IdTipo LIKE '" & TxtCodigoTipo.Text & "%'"
19:         End If

20:         strSQL = "SELECT IdTipo, Tipo, Observacao FROM IvanControleDeAcesso.dbo.TipoPessoa Where IdTipo > 0" & strFiltro1 & strFiltro2
21:         drdSQL = conexao.RetornaDT(strSQL, ConexaoSQL.EnBanco.Azul)

22:         If drdSQL IsNot Nothing Then

23:             FlxTabelaSelecao.DataSource = drdSQL
                ConfigurarGrid()
24:             FlxTabelaSelecao.ExtendLastCol = True   'Faz as colunas serem esticadas ate o final

25:         Else
26:             MessageBox.Show("Nenhum dado retornado.")
27:         End If

28:     Catch ex As Exception
29:         Windows.Forms.Cursor.Current = Cursors.Default
30:         Erro.Log(ConexaoSQL.VersaoAplicacao, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name(), ex.Message & " " & ex.StackTrace, Me.Name, System.Reflection.MethodBase.GetCurrentMethod().Name, True, CStr(Erl()))
31:     Finally
32:     End Try

    End Sub

    Private Sub InserirDados()

33:     Try
34:         Dim strSQL As String
35:         Dim Conexao As New ConexaoSQL

36:         ModoAtual = EnModo.Inclusao

37:         If TxtTipoPessoa.Text <> "" And TxtObservacao.Text <> "" Then

38:             strSQL = "INSERT INTO IvanControleDeAcesso.dbo.TipoPessoa (Tipo, Observacao) " &
                         "VALUES ('" & TxtTipoPessoa.Text & "', '" & TxtObservacao.Text & "')"
39:             Conexao.ExecutaStr(strSQL, ConexaoSQL.EnBanco.Azul)

41:             DesabilitarCampos()
42:             LimparCampos()
43:             HabilitarBotoes()
44:             CarregarDados()
45:             BtnGravar.Visible = False
46:             TxtCodigoTipo.Text = ""
47:             ModoAtual = EnModo.Nenhum

48:         Else
49:             If TxtTipoPessoa.Text = "" Then
50:                 TxtTipoPessoa.Focus()
51:             ElseIf TxtObservacao.Text = "" Then
52:                 TxtObservacao.Focus()
53:             End If
54:             MsgBox("Por favor, preencha os campos 'Tipo Pessoa' e 'Observação' antes de continuar.", MsgBoxStyle.Exclamation, "Campos obrigatórios")
55:         End If

56:     Catch ex As Exception
57:         Erro.Tratar(ex, Erl.ToString)
58:     End Try

    End Sub

    Private Sub AlterarDados()

59:     Try
60:         ModoAtual = EnModo.Alteracao

61:         If TxtTipoPessoa.Text <> "" And TxtObservacao.Text <> "" Then

62:             Dim strSQL As String
63:             Dim Conexao As New ConexaoSQL

64:             strSQL = " UPDATE IvanControleDeAcesso.dbo.TipoPessoa SET tipo = '" & TxtTipoPessoa.Text & "', Observacao = '" & TxtObservacao.Text & "' WHERE Idtipo = ' " & TxtCodigoTipo.Text & "'"
65:             Conexao.ExecutaStr(strSQL, ConexaoSQL.EnBanco.Azul)


67:             DesabilitarCampos()
68:             LimparCampos()
69:             HabilitarBotoes()
70:             BtnGravar.Visible = False
71:             TxtCodigoTipo.Text = ""
72:             CarregarDados()
73:             ModoAtual = EnModo.Nenhum

74:         Else
75:             If TxtTipoPessoa.Text = "" Then
76:                 TxtTipoPessoa.Focus()
77:             ElseIf TxtObservacao.Text = "" Then
78:                 TxtObservacao.Focus()
79:             End If
81:         End If

82:     Catch ex As Exception
83:         Erro.Tratar(ex, Erl.ToString)
84:     End Try

    End Sub

    Private Sub ExcluirDados()

85:     Try
86:         Dim strSQL As String
87:         Dim Conexao As New ConexaoSQL
88:         Dim resposta As DialogResult

89:         resposta = MessageBox.Show("Deseja exluir o registro selecionado?",
                                       "Confirmação",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question)
90:         If resposta = DialogResult.Yes Then

91:             strSQL = "DELETE IvanControleDeAcesso.dbo.TipoPessoa WHERE Idtipo = '" & TxtCodigoTipo.Text & "'"
92:             Conexao.ExecutaStr(strSQL, ConexaoSQL.EnBanco.Azul)
93:             EstadoInicial()

94:         End If

95:     Catch ex As Exception
96:         Erro.Tratar(ex, Erl.ToString)
97:     End Try

    End Sub

    Private Sub LimparCampos()

98:     Try

99:         TxtTipoPessoa.Text = ""
100:        TxtObservacao.Text = ""
101:        TxtCodigoTipo.Text = ""

102:    Catch ex As Exception
103:        Erro.Tratar(ex, Erl.ToString)
104:    End Try

    End Sub

    Private Sub HabilitarBotoes()

105:    Try

106:        BtnSelecionar.Enabled = True
107:        BtnIncluir.Enabled = True

108:    Catch ex As Exception
109:        Erro.Tratar(ex, Erl.ToString)
110:    End Try

    End Sub

    Private Sub DesabilitarCampos()

111:    Try

112:        TxtCodigoTipo.Enabled = False
113:        TxtTipoPessoa.Enabled = False
114:        TxtObservacao.Enabled = False

115:    Catch ex As Exception
116:        Erro.Tratar(ex, Erl.ToString)
117:    End Try

    End Sub

    Private Sub EstadoInicial()

118:    Try

119:        ModoAtual = EnModo.Nenhum

120:        TxtTipoPessoa.Enabled = True
121:        TxtCodigoTipo.Enabled = True
122:        TxtObservacao.Enabled = False

123:        BtnGravar.Visible = False
124:        BtnAlterar.Enabled = False
125:        BtnExcluir.Enabled = False

126:        HabilitarBotoes()
127:        LimparCampos()
128:        CarregarDados()

129:    Catch ex As Exception
130:        Erro.Tratar(ex, Erl.ToString)
131:    End Try

    End Sub



#End Region


#Region "Formulários"

    Private Sub FrmTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

132:    Try

133:        EstadoInicial()
134:        CarregarDados()

135:        If FlxTabelaSelecao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row = True Then
136:            BtnExcluir.Enabled = True
137:            BtnAlterar.Enabled = True
138:        End If
139:        TxtTipoPessoa.Enabled = True
140:        TxtCodigoTipo.Enabled = True
141:        TxtObservacao.Enabled = False
142:        BtnGravar.Visible = False

143:        FlxTabelaSelecao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
144:        FlxTabelaSelecao.Row = -1
145:        FlxTabelaSelecao.Col = -1
146:        Me.ActiveControl = TxtTipoPessoa
147:        TxtTipoPessoa.Focus()

148:    Catch ex As Exception
149:        Erro.Tratar(ex, Erl.ToString)
150:    End Try

    End Sub

    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click

151:    Try

152:        TxtCodigoTipo.Enabled = True
153:        TxtTipoPessoa.Enabled = True
154:        TxtObservacao.Enabled = False
155:        TxtCodigoTipo.Focus()
156:        CarregarDados()

157:    Catch ex As Exception
158:        Erro.Tratar(ex, Erl.ToString)
159:    End Try

    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click

160:    Try

161:        Dim SelectCodigo As String
162:        Dim drdSQL As DataTable
163:        Dim Conexao As New ConexaoSQL

164:        ModoAtual = EnModo.Inclusao

165:        TxtCodigoTipo.Enabled = False
166:        TxtTipoPessoa.Enabled = True
167:        TxtObservacao.Enabled = True

168:        BtnAlterar.Enabled = False
169:        BtnExcluir.Enabled = False
170:        BtnSelecionar.Enabled = False
171:        BtnIncluir.Enabled = False
172:        BtnGravar.Visible = True

173:        LimparCampos()
174:        TxtTipoPessoa.Focus()

            SelectCodigo = "SELECT top 1 IdTipo + 1 FROM IvanControleDeAcesso.dbo.TipoPessoa order by idtipo desc"
175:        drdSQL = Conexao.RetornaDT(SelectCodigo, ConexaoSQL.EnBanco.Azul)

176:        If drdSQL.Rows.Count > 0 Then
177:            TxtCodigoTipo.Text = drdSQL.Rows(0)(0).ToString()
178:        End If

179:    Catch ex As Exception
180:        Erro.Tratar(ex, Erl.ToString)
181:    End Try

    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click

182:    Try

183:        If ModoAtual = EnModo.Inclusao Then

184:            InserirDados()

185:        End If
186:        If ModoAtual = EnModo.Alteracao Then

187:            AlterarDados()

188:        End If

189:    Catch ex As Exception
190:        Erro.Tratar(ex, Erl.ToString)
191:    End Try

    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click

192:    Try

193:        ModoAtual = EnModo.Alteracao

194:        If FlxTabelaSelecao.Row < 1 And FlxTabelaSelecao.Col < 1 Then

195:            FlxTabelaSelecao.Row = 1
196:            FlxTabelaSelecao.Col = 1

197:        End If

198:        TxtCodigoTipo.Text = Convert.ToString(FlxTabelaSelecao(FlxTabelaSelecao.Row, 1))
199:        TxtTipoPessoa.Text = Convert.ToString(FlxTabelaSelecao(FlxTabelaSelecao.Row, 2))
200:        TxtObservacao.Text = Convert.ToString(FlxTabelaSelecao(FlxTabelaSelecao.Row, 3))

201:        TxtTipoPessoa.Enabled = True
202:        TxtObservacao.Enabled = True
203:        TxtCodigoTipo.Enabled = False

204:        BtnSelecionar.Enabled = False
205:        BtnIncluir.Enabled = False
206:        BtnExcluir.Enabled = False
207:        BtnGravar.Visible = True

208:    Catch ex As Exception
209:        Erro.Tratar(ex, Erl.ToString)
210:    End Try

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

211:    Try

            'If FlxTabelaSelecao.Row = 0 And FlxTabelaSelecao.Col = 0 Then

            '    FlxTabelaSelecao.Row = 1
            '    FlxTabelaSelecao.Col = 1

            'End If

212:        TxtCodigoTipo.Text = Convert.ToString(FlxTabelaSelecao(FlxTabelaSelecao.Row, 1))

213:        ExcluirDados()

214:    Catch ex As Exception
215:        Erro.Tratar(ex, Erl.ToString)
216:    End Try

    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click

217:    Try
218:        If ModoAtual = EnModo.Nenhum Then

219:            Me.Close()

220:        Else
221:            Dim resposta As DialogResult

222:            resposta = MessageBox.Show("Deseja cancelar a operação?",
                                   "Confirmação",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)

223:            If resposta = DialogResult.Yes Then

224:                EstadoInicial()

225:            End If
226:        End If

227:    Catch ex As Exception
228:        Erro.Tratar(ex, Erl.ToString)
229:    End Try

    End Sub

    Private Sub FlxTabelaSelecao_AfterSelChange(sender As Object, e As C1.Win.C1FlexGrid.RangeEventArgs) Handles FlxTabelaSelecao.AfterSelChange

230:    Try

            ' "A quantidade total de linhas é menor ou igual à quantidade de linhas fixas?"
231:        If FlxTabelaSelecao.Rows.Count <= FlxTabelaSelecao.Rows.Fixed Then
232:            BtnAlterar.Enabled = False
233:            BtnExcluir.Enabled = False
234:            Exit Sub
235:        End If

            ' Se a linha selecionada for válida 
            If ModoAtual = EnModo.Inclusao Or ModoAtual = EnModo.Alteracao Then

            ElseIf FlxTabelaSelecao.Row >= FlxTabelaSelecao.Rows.Fixed Then

237:            BtnAlterar.Enabled = True
238:            BtnExcluir.Enabled = True
239:        Else
240:            BtnAlterar.Enabled = False
241:            BtnExcluir.Enabled = False
242:        End If

243:    Catch ex As Exception
244:        Erro.Tratar(ex, Erl.ToString)
245:    End Try

    End Sub

    Private Sub TxtTipoPessoa_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTipoPessoa.KeyDown

        If e.KeyCode = Keys.Enter Then
            TxtObservacao.Focus()
        End If

    End Sub

    Private Sub TxtObservacao_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtObservacao.KeyDown

        If e.KeyCode = Keys.Enter Then

            If TxtTipoPessoa.Text = "" Then
                MsgBox("Preencha o campo Tipo Pessoa.")
                TxtTipoPessoa.Focus()
                Exit Sub
            End If

            BtnGravar.PerformClick()

        End If

    End Sub

#End Region

End Class
