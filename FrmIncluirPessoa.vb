Imports GGeral
Imports TratamentoDeErros
Imports xAlimento

Public Class FrmIncluirPessoa

#Region "Unica Instância"

    Private Sub New()

        Try

            InitializeComponent()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    Private Shared _Instance As FrmIncluirPessoa = Nothing
    Public Shared Function Instance() As FrmIncluirPessoa

        Try

            If _Instance Is Nothing OrElse _Instance.IsDisposed Then
                _Instance = New FrmIncluirPessoa
            End If
            _Instance.BringToFront()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try
        Return _Instance

    End Function

    Private Sub InstanciaDispose(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Try

7:          _Instance.Dispose()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try
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

        TxtNome.DataBindings.Clear()
        TxtCpf.DataBindings.Clear()
        TxtTelefone.DataBindings.Clear()
        TxtEmail.DataBindings.Clear()
        TxtEndereco.DataBindings.Clear()

        TxtNome.DataBindings.Add("Text", dt, "Nome")
        TxtCpf.DataBindings.Add("Text", dt, "Cpf")
        TxtTelefone.DataBindings.Add("Text", dt, "Telefone")
        TxtEmail.DataBindings.Add("Text", dt, "Email")
        TxtEndereco.DataBindings.Add("Text", dt, "Endereco")

        TxtDataNascimento.DataBindings.Add("Value", dt, "DataNascimento")
        TxtEntrada.DataBindings.Add("Value", dt, "DataEntrada")

        'aqui abaixo está a funcao que puxa o id e mostra la na tela de alteracao junto com a outra cmbtipo
        '==================================================================================================
        Dim idTipo As Integer = Convert.ToInt32(dt.Rows(0)("IdTipo"))

        Dim index As Integer = ListaIdTipo.IndexOf(idTipo)

        If index >= 0 Then
            CmbTipo.SelectedIndex = index
        End If
        '===================================================================================================
        'Logica para puxar a situacao quando clica em alterar
        Dim situacao As Integer
        situacao = dt.Rows(0)("Situacao")

        If situacao = 1 Then
            CmbSituacao.Text = "Ativo"
        Else
            CmbSituacao.Text = "Inativo"
        End If

        'Logica para puxar a foto quando clica em alterar
        If Not String.IsNullOrEmpty(dt.Rows(0)("Foto").ToString()) Then
            CaminhoFoto = dt.Rows(0)("Foto").ToString
            PctFotoPerfil.Image = Image.FromFile(dt.Rows(0)("Foto").ToString)
        Else
            PctFotoPerfil.Image = Nothing
        End If

    End Sub

    Public Sub CarregarDados()

        Try

            Dim SelectPessoa As String
            Dim Conexao As New ConexaoSQL
            Dim drdSQL As DataTable

            SelectPessoa = "SELECT IdPessoa, Nome, Cpf, DataNascimento, Telefone, Email, DataCadastro, IdTipo, Endereco, DataEntrada, DataSaida, IdLiberacao, Observacao, Situacao, Foto
                            FROM IvanControleDeAcesso.dbo.Pessoa
                            WHERE IdPessoa = " & IdPessoaSelecionada

            drdSQL = Conexao.RetornaDT(SelectPessoa, ConexaoSQL.EnBanco.Azul)

            TxtDataNascimento.Value = Convert.ToDateTime(drdSQL.Rows(0)("DataNascimento"))

            If ModoAtual = EnModo.Alteracao Then

                If drdSQL.Rows.Count > 0 Then

                    BindPessoa(drdSQL)

                    'VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV
                    If IsDBNull(drdSQL.Rows(0)("DataSaida")) Then
                        TxtSaida.Value = Nothing
                    Else
                        TxtSaida.Value = Convert.ToDateTime(drdSQL.Rows(0)("DataSaida"))
                    End If


                End If
            End If

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    Private Sub InserirDados()

        Try

            If String.IsNullOrWhiteSpace(TxtNome.Text) OrElse
                String.IsNullOrWhiteSpace(TxtCpf.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtDataNascimento.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtTelefone.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtEntrada.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbTipo.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbLiberacao.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbSituacao.Text) Then

                LblNomePessoa.ForeColor = Color.Red
                LblCpf.ForeColor = Color.Red
                LblDataNascimento.ForeColor = Color.Red
                LblTelefone.ForeColor = Color.Red
                LblDataEntrada.ForeColor = Color.Red
                LblTipo.ForeColor = Color.Red
                LblLiberacao.ForeColor = Color.Red
                LblSituacao.ForeColor = Color.Red
                LblSituacao.ForeColor = Color.Red
                MsgBox("Preencha todos os campos obrigatórios.", MsgBoxStyle.Exclamation, "Atenção")
            Else

                Dim StrSQL As String
                Dim Conexao As New ConexaoSQL

                If CmbSituacao.Text = "ATIVO" Then
                    CmbSituacao.Text = "1"
                End If

                If CmbSituacao.Text = "INATIVO" Then
                    CmbSituacao.Text = "0"
                End If

                If CmbLiberacao.Text = "LIBERADO" Then
                    CmbLiberacao.Text = "1"
                End If

                If CmbLiberacao.Text = "BLOQUEADO" Then
                    CmbLiberacao.Text = "0"
                End If


                'Validar essa função abaixo '
                Dim DataSaidaSQL As String

                If TxtSaida.Value Is Nothing OrElse IsDBNull(TxtSaida.Value) Then
                    DataSaidaSQL = "NULL"
                Else
                    DataSaidaSQL = "'" & CDate(TxtSaida.Value).ToString("dd-MM-yyyy") & "'"
                End If



                StrSQL = "INSERT INTO IvanControleDeAcesso.dbo.Pessoa (Nome, Cpf, DataNascimento, Telefone, Email, DataCadastro, IdTipo, 
                                      Endereco, DataEntrada, DataSaida, IdLiberacao, Situacao, Observacao, Foto)
                  VALUES ('" & TxtNome.Text & "', '" & TxtCpf.Text & "', '" & TxtDataNascimento.Text & "', '" & TxtTelefone.Text & "' ,'" & TxtEmail.Text & "', 
                  GETDATE(),'" & ListaIdTipo(CmbTipo.SelectedIndex) & "', '" & TxtEndereco.Text & "', '" & TxtEntrada.Text & "', " & DataSaidaSQL & ", '" & CmbLiberacao.Text & "',
                  '" & CmbSituacao.Text & "', '" & TxtObservacao.Text & "', '" & CaminhoFoto & "')"

                Conexao.ExecutaStr(StrSQL, ConexaoSQL.EnBanco.Azul)

                FrmSelecionarPessoa.Instance().CarregarDados()

                LimparCampos()
                CaminhoFoto = ""
                Me.Close()

            End If

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    Private Sub AtualizarDados()

        Try
            If String.IsNullOrWhiteSpace(TxtNome.Text) OrElse
                String.IsNullOrWhiteSpace(TxtCpf.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtDataNascimento.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtTelefone.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtEntrada.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbTipo.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbLiberacao.Text) OrElse
                    String.IsNullOrWhiteSpace(CmbSituacao.Text) Then

                LblNomePessoa.ForeColor = Color.Red
                LblCpf.ForeColor = Color.Red
                LblDataNascimento.ForeColor = Color.Red
                LblTelefone.ForeColor = Color.Red
                LblDataEntrada.ForeColor = Color.Red
                LblTipo.ForeColor = Color.Red
                LblLiberacao.ForeColor = Color.Red
                LblSituacao.ForeColor = Color.Red
                LblSituacao.ForeColor = Color.Red
                MsgBox("Preencha todos os campos obrigatórios.", MsgBoxStyle.Exclamation, "Atenção")
            Else
                Dim StrSQL As String
                Dim Conexao As New ConexaoSQL
                Dim situacao As Integer

                If CmbSituacao.Text = "ATIVO" Then

                    situacao = 1

                ElseIf CmbSituacao.Text = "INATIVO" Then

                    situacao = 0

                End If


                'validar essa funcao abaixo

                Dim DataSaidaSQL As String

                If TxtSaida.Value Is Nothing OrElse IsDBNull(TxtSaida.Value) Then
                    DataSaidaSQL = "NULL"
                Else
                    DataSaidaSQL = "'" & CDate(TxtSaida.Value).ToString("dd-MM-yyyy") & "'"
                End If

                StrSQL = "UPDATE IvanControleDeAcesso.dbo.Pessoa SET Nome = '" & TxtNome.Text & "', Cpf = '" & TxtCpf.Text & "', DataNascimento = '" & TxtDataNascimento.Text & "',
                  Telefone = '" & TxtTelefone.Text & "', Email = '" & TxtEmail.Text & "', IdTipo = '" & ListaIdTipo(CmbTipo.SelectedIndex) & "', Endereco = '" & TxtEndereco.Text & "',
                  DataEntrada = '" & TxtEntrada.Text & "', DataSaida = " & DataSaidaSQL & ", IdLiberacao = '" & CmbLiberacao.Text & "',
                  Situacao = " & situacao & ", Observacao = '" & TxtObservacao.Text & "', Foto = '" & CaminhoFoto & "'  WHERE IdPessoa = " & IdPessoaSelecionada

                Conexao.ExecutaStr(StrSQL, ConexaoSQL.EnBanco.Azul)

                FrmSelecionarPessoa.Instance().CarregarDados()

                LimparCampos()
                CaminhoFoto = ""

                Me.Close()
            End If
        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try
    End Sub

    Private Sub LimparCampos()

        Try

            TxtNome.Text = String.Empty
            TxtCpf.Text = String.Empty
            TxtDataNascimento.Value = Nothing
            TxtTelefone.Text = String.Empty
            TxtEmail.Text = String.Empty
            CmbTipo.Text = ""
            TxtEndereco.Text = String.Empty
            TxtEntrada.Value = Nothing
            TxtSaida.Value = Nothing
            CmbLiberacao.Text = ""
            CmbSituacao.Text = ""
            TxtObservacao.Text = String.Empty

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    Private Sub SelectCampos()

        Try

            Dim SelectCodigo As String
            Dim Conexao As New ConexaoSQL
            Dim drdSQL As DataTable

            SelectCodigo = "SELECT top 1 IdPessoa + 1 FROM IvanControleDeAcesso.dbo.Pessoa order by IdPessoa desc"
            drdSQL = Conexao.RetornaDT(SelectCodigo, ConexaoSQL.EnBanco.Azul)


            If drdSQL.Rows.Count > 0 Then
                TxtCodigoPessoa.Text = drdSQL.Rows(0)(0).ToString
            End If

            Dim SelectDataCadastro As String
            Dim drdDataCadastro As DataTable

            SelectDataCadastro = "SELECT GETDATE()"
            drdDataCadastro = Conexao.RetornaDT(SelectDataCadastro, ConexaoSQL.EnBanco.Azul)

            TxtDataCadastro.Text = drdDataCadastro.Rows(0)(0).ToString

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub


    'FUNCAO IMPORTANTE - REVISAR PARA ENTENDER - ELA ESTÁ FAZENDO A RELACAO ENTRE TIPO ()
    Private Sub CarregarTipo()

        Dim Conexao As New ConexaoSQL
        Dim Dt As DataTable

        Dt = Conexao.RetornaDT("SELECT IdTipo, Tipo FROM IvanControleDeAcesso.dbo.TipoPessoa", ConexaoSQL.EnBanco.Azul)

        CmbTipo.Items.Clear()
        ListaIdTipo.Clear()

        For Each linha As DataRow In Dt.Rows

            CmbTipo.Items.Add(linha("Tipo").ToString)
            ListaIdTipo.Add(Convert.ToInt32(linha("IdTipo")))

        Next

    End Sub

    Private Sub ValidarCampos()

        'If TxtCodigoPessoa

    End Sub

#End Region

#Region "Formulários"

    Private Sub FrmIncluirPessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If ModoAtual = EnModo.Alteracao Then
                Me.Text = "Alterar Pessoa"
            End If

            CmbSituacao.Items.Add("ATIVO")
            CmbSituacao.Items.Add("INATIVO")
            CmbLiberacao.Items.Add("LIBERADO")
            CmbLiberacao.Items.Add("BLOQUEADO")

            SelectCampos()
            CarregarTipo()

            CmbTipo.SelectedIndex = -1
            CmbSituacao.SelectedIndex = -1

            If ModoAtual = EnModo.Alteracao Then
                TxtCodigoPessoa.Text = IdPessoaSelecionada.ToString
            End If


        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click

        Try

            If ModoAtual = EnModo.Alteracao Then

                AtualizarDados()

            End If

            If ModoAtual = EnModo.Inclusao Then

                InserirDados()

            End If

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click

        Try

            Me.Close()

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

    Private Sub BtnSelecionarFoto_Click_1(sender As Object, e As EventArgs) Handles BtnSelecionarFoto.Click

        Try

            Dim dialogo As New OpenFileDialog

            dialogo.Filter = "Imagens|*.jpg;*.png;*.jpeg"

            If dialogo.ShowDialog = DialogResult.OK Then

                CaminhoFoto = dialogo.FileName
                PctFotoPerfil.Image = Image.FromFile(CaminhoFoto)

            End If

        Catch ex As Exception
            Erro.Tratar(ex, Erl.ToString)
        End Try

    End Sub

#End Region


End Class
