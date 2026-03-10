Imports GGeral
Imports TratamentoDeErros
Imports xAlimento

Public Class FrmIncluirPessoa

#Region "Unica Instância"

    Private Sub New()

1:      Try

2:          InitializeComponent()

3:      Catch ex As Exception
4:          Erro.Tratar(ex, Erl.ToString)
5:      End Try

    End Sub

    Private Shared _Instance As FrmIncluirPessoa = Nothing
    Public Shared Function Instance() As FrmIncluirPessoa

6:      Try

7:          If _Instance Is Nothing OrElse _Instance.IsDisposed Then
8:              _Instance = New FrmIncluirPessoa
9:          End If
10:         _Instance.BringToFront()

11:     Catch ex As Exception
12:         Erro.Tratar(ex, Erl.ToString)
13:     End Try
14:     Return _Instance

    End Function

    Private Sub InstanciaDispose(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

15:     Try

16:         _Instance = Instance()

17:     Catch ex As Exception
18:         Erro.Tratar(ex, Erl.ToString)
19:     End Try
    End Sub

#End Region

#Region "Declarações"

    Public IdPessoaSelecionada As Integer

    Public Enum EnModo

        Inclusao
        Alteracao
        Nenhum

    End Enum

    Public ModoAtual As EnModo

    Private CaminhoFoto As String = ""

    Private ListaIdTipo As New List(Of Integer)

#End Region

#Region "Funções"

    Public Sub BindPessoa(dt As DataTable)

20:     Try

21:         TxtNome.DataBindings.Clear()
22:         TxtCpf.DataBindings.Clear()
23:         TxtTelefone.DataBindings.Clear()
24:         TxtEmail.DataBindings.Clear()
25:         TxtEndereco.DataBindings.Clear()
26:         TxtDataNascimento.DataBindings.Clear()
27:         TxtEntrada.DataBindings.Clear()
28:         CmbTipo.DataBindings.Clear()

29:         TxtNome.DataBindings.Add("Text", dt, "Nome")
30:         TxtCpf.DataBindings.Add("Text", dt, "Cpf")
31:         TxtTelefone.DataBindings.Add("Text", dt, "Telefone")
32:         TxtEmail.DataBindings.Add("Text", dt, "Email")
33:         TxtEndereco.DataBindings.Add("Text", dt, "Endereco")

34:         TxtDataNascimento.DataBindings.Add("Value", dt, "DataNascimento")
35:         TxtEntrada.DataBindings.Add("Value", dt, "DataEntrada")

            'aqui abaixo está a funcao que puxa o id e mostra la na tela de alteracao junto com a outra cmbtipo
            '==================================================================================================
36:         Dim idTipo As Integer = Convert.ToInt32(dt.Rows(0)("IdTipo"))

37:         Dim index As Integer = ListaIdTipo.IndexOf(idTipo)

38:         If index >= 0 Then
39:             CmbTipo.SelectedIndex = index
40:         End If
            '===================================================================================================
            'Logica para puxar a situacao quando clica em alterar
41:         Dim situacao As Integer
42:         situacao = dt.Rows(0)("Situacao")

43:         If situacao = 1 Then
44:             CmbSituacao.Text = "ATIVO"
45:         Else
46:             CmbSituacao.Text = "INATIVO"
47:         End If

            'Logica para puxar a foto quando clica em alterar
48:         If Not String.IsNullOrEmpty(dt.Rows(0)("Foto").ToString()) Then
49:             CaminhoFoto = dt.Rows(0)("Foto").ToString
50:             PctFotoPerfil.Image = Image.FromFile(dt.Rows(0)("Foto").ToString)
51:         Else
52:             PctFotoPerfil.Image = Nothing
53:         End If



54:     Catch ex As Exception
55:         Erro.Tratar(ex, Erl.ToString)
56:     End Try

    End Sub

    Public Sub CarregarDados()

57:     Try

58:         Dim SelectPessoa As String
59:         Dim Conexao As New ConexaoSQL
60:         Dim drdSQL As DataTable

            SelectPessoa = "SELECT IdPessoa, Nome, Cpf, DataNascimento, Telefone, Email, DataCadastro, IdTipo, Endereco, DataEntrada, DataSaida, IdLiberacao, Observacao, Situacao, Foto
                            FROM IvanControleDeAcesso.dbo.Pessoa
                            WHERE IdPessoa = " & IdPessoaSelecionada

61:         drdSQL = Conexao.RetornaDT(SelectPessoa, ConexaoSQL.EnBanco.Azul)

62:         TxtDataNascimento.Value = Convert.ToDateTime(drdSQL.Rows(0)("DataNascimento"))

63:         If ModoAtual = EnModo.Alteracao Then

64:             If drdSQL.Rows.Count > 0 Then

65:                 BindPessoa(drdSQL)

                    'VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV
66:                 If IsDBNull(drdSQL.Rows(0)("DataSaida")) Then
67:                     TxtSaida.Value = Nothing
68:                 Else
69:                     TxtSaida.Value = Convert.ToDateTime(drdSQL.Rows(0)("DataSaida"))
70:                 End If


71:             End If
72:         End If

73:     Catch ex As Exception
74:         Erro.Tratar(ex, Erl.ToString)
75:     End Try

    End Sub

    Private Sub InserirDados()

76:     Try

77:         If String.IsNullOrWhiteSpace(TxtNome.Text) OrElse
                String.IsNullOrWhiteSpace(TxtCpf.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtDataNascimento.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtTelefone.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtEntrada.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbTipo.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbLiberacao.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbSituacao.Text) Then

78:             LblNomePessoa.ForeColor = Color.Red
79:             LblCpf.ForeColor = Color.Red
80:             LblDataNascimento.ForeColor = Color.Red
81:             LblTelefone.ForeColor = Color.Red
82:             LblDataEntrada.ForeColor = Color.Red
83:             LblTipo.ForeColor = Color.Red
84:             LblLiberacao.ForeColor = Color.Red
85:             LblSituacao.ForeColor = Color.Red
86:             LblSituacao.ForeColor = Color.Red
87:             MsgBox("Preencha todos os campos obrigatórios.", MsgBoxStyle.Exclamation, "Atenção")
88:         Else

89:             Dim StrSQL As String
90:             Dim Conexao As New ConexaoSQL

91:             Dim Situacao As Integer

92:             If CmbSituacao.Text = "ATIVO" Then
93:                 Situacao = 1
94:             End If

95:             If CmbSituacao.Text = "INATIVO" Then
96:                 Situacao = 0
97:             End If

98:             If CmbLiberacao.Text = "LIBERADO" Then
99:                 CmbLiberacao.Text = "1"
100:            End If

101:            If CmbLiberacao.Text = "BLOQUEADO" Then
102:                CmbLiberacao.Text = "0"
103:            End If

                'Validar essa função abaixo '
104:            Dim DataSaidaSQL As String

105:            If TxtSaida.Value Is Nothing OrElse IsDBNull(TxtSaida.Value) Then
106:                DataSaidaSQL = "NULL"
107:            Else
108:                DataSaidaSQL = "'" & CDate(TxtSaida.Value).ToString("dd-MM-yyyy") & "'"
109:            End If



110:            StrSQL = "INSERT INTO IvanControleDeAcesso.dbo.Pessoa (Nome, Cpf, DataNascimento, Telefone, Email, DataCadastro, IdTipo, 
                                      Endereco, DataEntrada, DataSaida, IdLiberacao, Situacao, Observacao, Foto)
                  VALUES ('" & TxtNome.Text & "', '" & TxtCpf.Text & "', '" & TxtDataNascimento.Text & "', '" & TxtTelefone.Text & "' ,'" & TxtEmail.Text & "', 
                  GETDATE(),'" & ListaIdTipo(CmbTipo.SelectedIndex) & "', '" & TxtEndereco.Text & "', '" & TxtEntrada.Text & "', " & DataSaidaSQL & ", '" & CmbLiberacao.Text & "',
                  '" & Situacao & "', '" & TxtObservacao.Text & "', '" & CaminhoFoto & "')"

111:            Conexao.ExecutaStr(StrSQL, ConexaoSQL.EnBanco.Azul)

112:            FrmSelecionarPessoa.Instance().CarregarDados()

113:            LimparCampos()
114:            CaminhoFoto = ""
115:            Me.Close()

116:        End If

117:    Catch ex As Exception
118:        Erro.Tratar(ex, Erl.ToString)
119:    End Try

    End Sub

    Private Sub AtualizarDados()

120:    Try
121:        If String.IsNullOrWhiteSpace(TxtNome.Text) OrElse
                String.IsNullOrWhiteSpace(TxtCpf.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtDataNascimento.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtTelefone.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtEntrada.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbTipo.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbLiberacao.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbSituacao.Text) Then

122:            LblNomePessoa.ForeColor = Color.Red
123:            LblCpf.ForeColor = Color.Red
124:            LblDataNascimento.ForeColor = Color.Red
125:            LblTelefone.ForeColor = Color.Red
126:            LblDataEntrada.ForeColor = Color.Red
127:            LblTipo.ForeColor = Color.Red
128:            LblLiberacao.ForeColor = Color.Red
129:            LblSituacao.ForeColor = Color.Red
130:            LblSituacao.ForeColor = Color.Red
131:            MsgBox("Preencha todos os campos obrigatórios.", MsgBoxStyle.Exclamation, "Atenção")
132:        Else
133:            Dim StrSQL As String
134:            Dim Conexao As New ConexaoSQL
135:            Dim situacao As Integer

136:            If CmbSituacao.Text = "ATIVO" Then

137:                situacao = 1

138:            ElseIf CmbSituacao.Text = "INATIVO" Then

139:                situacao = 0

140:            End If


                'validar essa funcao abaixo

141:            Dim DataSaidaSQL As String

142:            If TxtSaida.Value Is Nothing OrElse IsDBNull(TxtSaida.Value) Then
143:                DataSaidaSQL = "NULL"
144:            Else
145:                DataSaidaSQL = "'" & CDate(TxtSaida.Value).ToString("dd-MM-yyyy") & "'"
146:            End If

147:            StrSQL = "UPDATE IvanControleDeAcesso.dbo.Pessoa SET Nome = '" & TxtNome.Text & "', Cpf = '" & TxtCpf.Text & "', DataNascimento = '" & TxtDataNascimento.Text & "',
                  Telefone = '" & TxtTelefone.Text & "', Email = '" & TxtEmail.Text & "', IdTipo = '" & ListaIdTipo(CmbTipo.SelectedIndex) & "', Endereco = '" & TxtEndereco.Text & "',
                  DataEntrada = '" & TxtEntrada.Text & "', DataSaida = " & DataSaidaSQL & ", IdLiberacao = '" & CmbLiberacao.Text & "',
                  Situacao = " & situacao & ", Observacao = '" & TxtObservacao.Text & "', Foto = '" & CaminhoFoto & "'  WHERE IdPessoa = " & IdPessoaSelecionada

                Conexao.ExecutaStr(StrSQL, ConexaoSQL.EnBanco.Azul)

                FrmSelecionarPessoa.Instance().CarregarDados()

                LimparCampos()
                CaminhoFoto = ""

148:            Me.Close()
149:        End If
150:    Catch ex As Exception
151:        Erro.Tratar(ex, Erl.ToString)
152:    End Try
    End Sub

    Private Sub LimparCampos()

153:    Try

154:        TxtNome.Text = String.Empty
155:        TxtCpf.Text = String.Empty
156:        TxtDataNascimento.Value = Nothing
157:        TxtTelefone.Text = String.Empty
158:        TxtEmail.Text = String.Empty
159:        CmbTipo.Text = ""
160:        TxtEndereco.Text = String.Empty
161:        TxtEntrada.Value = Nothing
162:        TxtSaida.Value = Nothing
163:        CmbLiberacao.Text = ""
164:        CmbSituacao.Text = ""
165:        TxtObservacao.Text = String.Empty

166:    Catch ex As Exception
167:        Erro.Tratar(ex, Erl.ToString)
168:    End Try

    End Sub

    Private Sub SelectCampos()

169:    Try

170:        Dim SelectCodigo As String
171:        Dim Conexao As New ConexaoSQL
172:        Dim drdSQL As DataTable

            SelectCodigo = "SELECT top 1 IdPessoa + 1 FROM IvanControleDeAcesso.dbo.Pessoa order by IdPessoa desc"
173:        drdSQL = Conexao.RetornaDT(SelectCodigo, ConexaoSQL.EnBanco.Azul)


174:        If drdSQL.Rows.Count > 0 Then
175:            TxtCodigoPessoa.Text = drdSQL.Rows(0)(0).ToString
176:        End If

177:        Dim SelectDataCadastro As String
178:        Dim drdDataCadastro As DataTable

            SelectDataCadastro = "SELECT GETDATE()"
179:        drdDataCadastro = Conexao.RetornaDT(SelectDataCadastro, ConexaoSQL.EnBanco.Azul)

180:        TxtDataCadastro.Text = drdDataCadastro.Rows(0)(0).ToString

181:    Catch ex As Exception
182:        Erro.Tratar(ex, Erl.ToString)
183:    End Try

    End Sub


    'FUNCAO IMPORTANTE - REVISAR PARA ENTENDER - ELA ESTÁ FAZENDO A RELACAO ENTRE TIPO ()
    Private Sub CarregarTipo()

184:    Try

185:        Dim Conexao As New ConexaoSQL
186:        Dim Dt As DataTable

187:        Dt = Conexao.RetornaDT("SELECT IdTipo, Tipo FROM IvanControleDeAcesso.dbo.TipoPessoa", ConexaoSQL.EnBanco.Azul)

188:        CmbTipo.Items.Clear()
189:        ListaIdTipo.Clear()

190:        For Each linha As DataRow In Dt.Rows

191:            CmbTipo.Items.Add(linha("Tipo").ToString)
192:            ListaIdTipo.Add(Convert.ToInt32(linha("IdTipo")))

193:        Next



194:    Catch ex As Exception
195:        Erro.Tratar(ex, Erl.ToString)
196:    End Try

    End Sub


#End Region

#Region "Formulários"

    Private Sub FrmIncluirPessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

197:    Try
198:        If ModoAtual = EnModo.Alteracao Then
199:            Me.Text = "Alterar Pessoa"
200:        End If

201:        CmbSituacao.Items.Add("ATIVO")
202:        CmbSituacao.Items.Add("INATIVO")
203:        CmbLiberacao.Items.Add("LIBERADO")
204:        CmbLiberacao.Items.Add("BLOQUEADO")

            SelectCampos()
205:        CarregarTipo()

206:        CmbTipo.SelectedIndex = -1
207:        CmbSituacao.SelectedIndex = -1

208:        If ModoAtual = EnModo.Alteracao Then
209:            TxtCodigoPessoa.Text = IdPessoaSelecionada.ToString
210:        End If


211:    Catch ex As Exception
212:        Erro.Tratar(ex, Erl.ToString)
213:    End Try

    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click

214:    Try

215:        If ModoAtual = EnModo.Alteracao Then

216:            AtualizarDados()

217:        End If

218:        If ModoAtual = EnModo.Inclusao Then

219:            InserirDados()

220:        End If

221:    Catch ex As Exception
222:        Erro.Tratar(ex, Erl.ToString)
223:    End Try

    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click

224:    Try

225:        Me.Close()

226:    Catch ex As Exception
227:        Erro.Tratar(ex, Erl.ToString)
228:    End Try

    End Sub

    Private Sub BtnSelecionarFoto_Click_1(sender As Object, e As EventArgs) Handles BtnSelecionarFoto.Click

229:    Try

230:        Dim dialogo As New OpenFileDialog

231:        dialogo.Filter = "Imagens|*.jpg;*.png;*.jpeg"

232:        If dialogo.ShowDialog = DialogResult.OK Then

233:            CaminhoFoto = dialogo.FileName
234:            PctFotoPerfil.Image = Image.FromFile(CaminhoFoto)

235:        End If

236:    Catch ex As Exception
237:        Erro.Tratar(ex, Erl.ToString)
238:    End Try

    End Sub

#End Region


End Class
