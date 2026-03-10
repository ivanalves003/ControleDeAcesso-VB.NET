<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIncluirPessoa
    Inherits C1.Win.C1Ribbon.C1RibbonForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblCodigo = New C1.Win.C1Input.C1Label()
        Me.LblNomePessoa = New C1.Win.C1Input.C1Label()
        Me.LblCpf = New C1.Win.C1Input.C1Label()
        Me.LblDataNascimento = New C1.Win.C1Input.C1Label()
        Me.LblTelefone = New C1.Win.C1Input.C1Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblDataCadastro = New C1.Win.C1Input.C1Label()
        Me.LblEndereco = New System.Windows.Forms.Label()
        Me.LblDataEntrada = New C1.Win.C1Input.C1Label()
        Me.LblDataSaida = New C1.Win.C1Input.C1Label()
        Me.LblSituacao = New C1.Win.C1Input.C1Label()
        Me.LblObservacao = New C1.Win.C1Input.C1Label()
        Me.TxtNome = New C1.Win.C1Input.C1TextBox()
        Me.TxtCodigoPessoa = New C1.Win.C1Input.C1TextBox()
        Me.TxtCpf = New C1.Win.C1Input.C1TextBox()
        Me.TxtTelefone = New C1.Win.C1Input.C1TextBox()
        Me.TxtEmail = New C1.Win.C1Input.C1TextBox()
        Me.TxtEndereco = New C1.Win.C1Input.C1TextBox()
        Me.CmbSituacao = New C1.Win.C1Input.C1ComboBox()
        Me.TxtDataCadastro = New C1.Win.C1Input.C1TextBox()
        Me.TxtObservacao = New C1.Win.C1Input.C1TextBox()
        Me.BtnGravar = New C1.Win.C1Input.C1Button()
        Me.BtnVoltar = New C1.Win.C1Input.C1Button()
        Me.LblTipo = New C1.Win.C1Input.C1Label()
        Me.CmbLiberacao = New C1.Win.C1Input.C1ComboBox()
        Me.LblLiberacao = New C1.Win.C1Input.C1Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.PctFotoPerfil = New C1.Win.C1Input.C1PictureBox()
        Me.BtnSelecionarFoto = New C1.Win.C1Input.C1Button()
        Me.TxtEntrada = New C1.Win.C1Input.C1DateEdit()
        Me.TxtSaida = New C1.Win.C1Input.C1DateEdit()
        Me.TxtDataNascimento = New C1.Win.C1Input.C1DateEdit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCpf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataNascimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblTelefone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblSituacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigoPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelefone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbSituacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDataCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnGravar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbLiberacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblLiberacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctFotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSelecionarFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDataNascimento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblCodigo.ForeColor = System.Drawing.Color.Black
        Me.LblCodigo.Location = New System.Drawing.Point(274, 2)
        Me.LblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(47, 13)
        Me.LblCodigo.TabIndex = 0
        Me.LblCodigo.Tag = Nothing
        Me.LblCodigo.Text = "Código"
        Me.LblCodigo.TextDetached = True
        '
        'LblNomePessoa
        '
        Me.LblNomePessoa.AutoSize = True
        Me.LblNomePessoa.BackColor = System.Drawing.Color.Transparent
        Me.LblNomePessoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblNomePessoa.ForeColor = System.Drawing.Color.Black
        Me.LblNomePessoa.Location = New System.Drawing.Point(329, 2)
        Me.LblNomePessoa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNomePessoa.Name = "LblNomePessoa"
        Me.LblNomePessoa.Size = New System.Drawing.Size(111, 13)
        Me.LblNomePessoa.TabIndex = 1
        Me.LblNomePessoa.Tag = Nothing
        Me.LblNomePessoa.Text = "Nome Completo:*"
        Me.LblNomePessoa.TextDetached = True
        '
        'LblCpf
        '
        Me.LblCpf.AutoSize = True
        Me.LblCpf.BackColor = System.Drawing.Color.Transparent
        Me.LblCpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblCpf.ForeColor = System.Drawing.Color.Black
        Me.LblCpf.Location = New System.Drawing.Point(276, 37)
        Me.LblCpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCpf.Name = "LblCpf"
        Me.LblCpf.Size = New System.Drawing.Size(41, 13)
        Me.LblCpf.TabIndex = 3
        Me.LblCpf.Tag = Nothing
        Me.LblCpf.Text = "CPF:*"
        Me.LblCpf.TextDetached = True
        '
        'LblDataNascimento
        '
        Me.LblDataNascimento.AutoSize = True
        Me.LblDataNascimento.BackColor = System.Drawing.Color.Transparent
        Me.LblDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataNascimento.ForeColor = System.Drawing.Color.Black
        Me.LblDataNascimento.Location = New System.Drawing.Point(276, 74)
        Me.LblDataNascimento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataNascimento.Name = "LblDataNascimento"
        Me.LblDataNascimento.Size = New System.Drawing.Size(134, 26)
        Me.LblDataNascimento.TabIndex = 4
        Me.LblDataNascimento.Tag = Nothing
        Me.LblDataNascimento.Text = "Data de Nascimento:*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblDataNascimento.TextDetached = True
        '
        'LblTelefone
        '
        Me.LblTelefone.AutoSize = True
        Me.LblTelefone.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblTelefone.ForeColor = System.Drawing.Color.Black
        Me.LblTelefone.Location = New System.Drawing.Point(413, 74)
        Me.LblTelefone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTelefone.Name = "LblTelefone"
        Me.LblTelefone.Size = New System.Drawing.Size(67, 13)
        Me.LblTelefone.TabIndex = 5
        Me.LblTelefone.Tag = Nothing
        Me.LblTelefone.Text = "Telefone:*"
        Me.LblTelefone.TextDetached = True
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(278, 110)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(48, 13)
        Me.LblEmail.TabIndex = 7
        Me.LblEmail.Text = "E-mail:"
        '
        'LblDataCadastro
        '
        Me.LblDataCadastro.AutoSize = True
        Me.LblDataCadastro.BackColor = System.Drawing.Color.Transparent
        Me.LblDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataCadastro.ForeColor = System.Drawing.Color.Black
        Me.LblDataCadastro.Location = New System.Drawing.Point(456, 146)
        Me.LblDataCadastro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataCadastro.Name = "LblDataCadastro"
        Me.LblDataCadastro.Size = New System.Drawing.Size(108, 13)
        Me.LblDataCadastro.TabIndex = 8
        Me.LblDataCadastro.Tag = Nothing
        Me.LblDataCadastro.Text = "Data do Cadastro"
        Me.LblDataCadastro.TextDetached = True
        '
        'LblEndereco
        '
        Me.LblEndereco.AutoSize = True
        Me.LblEndereco.Location = New System.Drawing.Point(277, 181)
        Me.LblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEndereco.Name = "LblEndereco"
        Me.LblEndereco.Size = New System.Drawing.Size(65, 13)
        Me.LblEndereco.TabIndex = 9
        Me.LblEndereco.Text = "Endereço:"
        '
        'LblDataEntrada
        '
        Me.LblDataEntrada.AutoSize = True
        Me.LblDataEntrada.BackColor = System.Drawing.Color.Transparent
        Me.LblDataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataEntrada.ForeColor = System.Drawing.Color.Black
        Me.LblDataEntrada.Location = New System.Drawing.Point(509, 75)
        Me.LblDataEntrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataEntrada.Name = "LblDataEntrada"
        Me.LblDataEntrada.Size = New System.Drawing.Size(112, 13)
        Me.LblDataEntrada.TabIndex = 10
        Me.LblDataEntrada.Tag = Nothing
        Me.LblDataEntrada.Text = "Data de Entrada:*"
        Me.LblDataEntrada.TextDetached = True
        '
        'LblDataSaida
        '
        Me.LblDataSaida.AutoSize = True
        Me.LblDataSaida.BackColor = System.Drawing.Color.Transparent
        Me.LblDataSaida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataSaida.ForeColor = System.Drawing.Color.Black
        Me.LblDataSaida.Location = New System.Drawing.Point(667, 74)
        Me.LblDataSaida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataSaida.Name = "LblDataSaida"
        Me.LblDataSaida.Size = New System.Drawing.Size(93, 13)
        Me.LblDataSaida.TabIndex = 11
        Me.LblDataSaida.Tag = Nothing
        Me.LblDataSaida.Text = "Data de Saída:"
        Me.LblDataSaida.TextDetached = True
        '
        'LblSituacao
        '
        Me.LblSituacao.AutoSize = True
        Me.LblSituacao.BackColor = System.Drawing.Color.Transparent
        Me.LblSituacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblSituacao.ForeColor = System.Drawing.Color.Black
        Me.LblSituacao.Location = New System.Drawing.Point(667, 38)
        Me.LblSituacao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSituacao.Name = "LblSituacao"
        Me.LblSituacao.Size = New System.Drawing.Size(68, 13)
        Me.LblSituacao.TabIndex = 12
        Me.LblSituacao.Tag = Nothing
        Me.LblSituacao.Text = "Situação:*"
        Me.LblSituacao.TextDetached = True
        '
        'LblObservacao
        '
        Me.LblObservacao.AutoSize = True
        Me.LblObservacao.BackColor = System.Drawing.Color.Transparent
        Me.LblObservacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblObservacao.ForeColor = System.Drawing.Color.Black
        Me.LblObservacao.Location = New System.Drawing.Point(276, 217)
        Me.LblObservacao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblObservacao.Name = "LblObservacao"
        Me.LblObservacao.Size = New System.Drawing.Size(80, 13)
        Me.LblObservacao.TabIndex = 13
        Me.LblObservacao.Tag = Nothing
        Me.LblObservacao.Text = "Observação:"
        Me.LblObservacao.TextDetached = True
        '
        'TxtNome
        '
        Me.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNome.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TxtNome.Location = New System.Drawing.Point(329, 16)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(456, 19)
        Me.TxtNome.TabIndex = 2
        Me.TxtNome.Tag = Nothing
        Me.TxtNome.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'TxtCodigoPessoa
        '
        Me.TxtCodigoPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigoPessoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigoPessoa.Enabled = False
        Me.TxtCodigoPessoa.Location = New System.Drawing.Point(276, 16)
        Me.TxtCodigoPessoa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCodigoPessoa.Name = "TxtCodigoPessoa"
        Me.TxtCodigoPessoa.Size = New System.Drawing.Size(46, 19)
        Me.TxtCodigoPessoa.TabIndex = 1
        Me.TxtCodigoPessoa.Tag = Nothing
        Me.TxtCodigoPessoa.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.TxtCodigoPessoa.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TxtCpf
        '
        Me.TxtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCpf.EditMask = "00000000000"
        Me.TxtCpf.Location = New System.Drawing.Point(276, 52)
        Me.TxtCpf.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(207, 19)
        Me.TxtCpf.TabIndex = 3
        Me.TxtCpf.Tag = Nothing
        '
        'TxtTelefone
        '
        Me.TxtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefone.EditMask = "00000000000"
        Me.TxtTelefone.Location = New System.Drawing.Point(388, 91)
        Me.TxtTelefone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(96, 19)
        Me.TxtTelefone.TabIndex = 7
        Me.TxtTelefone.Tag = Nothing
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmail.Location = New System.Drawing.Point(276, 126)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(509, 19)
        Me.TxtEmail.TabIndex = 10
        Me.TxtEmail.Tag = Nothing
        '
        'TxtEndereco
        '
        Me.TxtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEndereco.Location = New System.Drawing.Point(276, 196)
        Me.TxtEndereco.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(509, 19)
        Me.TxtEndereco.TabIndex = 13
        Me.TxtEndereco.Tag = Nothing
        '
        'CmbSituacao
        '
        Me.CmbSituacao.AllowSpinLoop = False
        Me.CmbSituacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CmbSituacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CmbSituacao.GapHeight = 0
        Me.CmbSituacao.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CmbSituacao.ItemsDisplayMember = ""
        Me.CmbSituacao.ItemsValueMember = ""
        Me.CmbSituacao.Location = New System.Drawing.Point(662, 52)
        Me.CmbSituacao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbSituacao.Name = "CmbSituacao"
        Me.CmbSituacao.Size = New System.Drawing.Size(123, 19)
        Me.CmbSituacao.TabIndex = 5
        Me.CmbSituacao.Tag = Nothing
        '
        'TxtDataCadastro
        '
        Me.TxtDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDataCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDataCadastro.Enabled = False
        Me.TxtDataCadastro.Location = New System.Drawing.Point(456, 162)
        Me.TxtDataCadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtDataCadastro.Name = "TxtDataCadastro"
        Me.TxtDataCadastro.Size = New System.Drawing.Size(329, 19)
        Me.TxtDataCadastro.TabIndex = 12
        Me.TxtDataCadastro.Tag = Nothing
        '
        'TxtObservacao
        '
        Me.TxtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservacao.Location = New System.Drawing.Point(276, 233)
        Me.TxtObservacao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtObservacao.Multiline = True
        Me.TxtObservacao.Name = "TxtObservacao"
        Me.TxtObservacao.Size = New System.Drawing.Size(509, 105)
        Me.TxtObservacao.TabIndex = 14
        Me.TxtObservacao.Tag = Nothing
        '
        'BtnGravar
        '
        Me.BtnGravar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnGravar.Location = New System.Drawing.Point(5, 341)
        Me.BtnGravar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(81, 24)
        Me.BtnGravar.TabIndex = 15
        Me.BtnGravar.Text = "&Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = True
        Me.BtnGravar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnGravar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(704, 341)
        Me.BtnVoltar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(81, 25)
        Me.BtnVoltar.TabIndex = 17
        Me.BtnVoltar.Text = "&Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        Me.BtnVoltar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnVoltar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.BackColor = System.Drawing.Color.Transparent
        Me.LblTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblTipo.ForeColor = System.Drawing.Color.Black
        Me.LblTipo.Location = New System.Drawing.Point(485, 37)
        Me.LblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(43, 13)
        Me.LblTipo.TabIndex = 30
        Me.LblTipo.Tag = Nothing
        Me.LblTipo.Text = "Tipo:*"
        Me.LblTipo.TextDetached = True
        '
        'CmbLiberacao
        '
        Me.CmbLiberacao.AllowSpinLoop = False
        Me.CmbLiberacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CmbLiberacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CmbLiberacao.GapHeight = 0
        Me.CmbLiberacao.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CmbLiberacao.ItemsDisplayMember = ""
        Me.CmbLiberacao.ItemsValueMember = ""
        Me.CmbLiberacao.Location = New System.Drawing.Point(276, 162)
        Me.CmbLiberacao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbLiberacao.Name = "CmbLiberacao"
        Me.CmbLiberacao.Size = New System.Drawing.Size(172, 19)
        Me.CmbLiberacao.TabIndex = 11
        Me.CmbLiberacao.Tag = Nothing
        '
        'LblLiberacao
        '
        Me.LblLiberacao.AutoSize = True
        Me.LblLiberacao.BackColor = System.Drawing.Color.Transparent
        Me.LblLiberacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblLiberacao.ForeColor = System.Drawing.Color.Black
        Me.LblLiberacao.Location = New System.Drawing.Point(276, 146)
        Me.LblLiberacao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLiberacao.Name = "LblLiberacao"
        Me.LblLiberacao.Size = New System.Drawing.Size(74, 13)
        Me.LblLiberacao.TabIndex = 32
        Me.LblLiberacao.Tag = Nothing
        Me.LblLiberacao.Text = "Liberação:*"
        Me.LblLiberacao.TextDetached = True
        '
        'CmbTipo
        '
        Me.CmbTipo.BackColor = System.Drawing.Color.White
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(485, 51)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(175, 21)
        Me.CmbTipo.TabIndex = 4
        '
        'PctFotoPerfil
        '
        Me.PctFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PctFotoPerfil.Location = New System.Drawing.Point(5, 3)
        Me.PctFotoPerfil.Name = "PctFotoPerfil"
        Me.PctFotoPerfil.Size = New System.Drawing.Size(269, 335)
        Me.PctFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctFotoPerfil.TabIndex = 35
        Me.PctFotoPerfil.TabStop = False
        '
        'BtnSelecionarFoto
        '
        Me.BtnSelecionarFoto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSelecionarFoto.Location = New System.Drawing.Point(193, 341)
        Me.BtnSelecionarFoto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSelecionarFoto.Name = "BtnSelecionarFoto"
        Me.BtnSelecionarFoto.Size = New System.Drawing.Size(81, 24)
        Me.BtnSelecionarFoto.TabIndex = 16
        Me.BtnSelecionarFoto.Text = "&Foto"
        Me.BtnSelecionarFoto.UseVisualStyleBackColor = True
        Me.BtnSelecionarFoto.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnSelecionarFoto.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TxtEntrada
        '
        Me.TxtEntrada.AllowSpinLoop = False
        Me.TxtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.TxtEntrada.Calendar.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
        Me.TxtEntrada.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TxtEntrada.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.TxtEntrada.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.TxtEntrada.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.TxtEntrada.Location = New System.Drawing.Point(486, 91)
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.Size = New System.Drawing.Size(149, 19)
        Me.TxtEntrada.TabIndex = 8
        Me.TxtEntrada.Tag = Nothing
        '
        'TxtSaida
        '
        Me.TxtSaida.AllowSpinLoop = False
        Me.TxtSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.TxtSaida.Calendar.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
        Me.TxtSaida.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TxtSaida.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.TxtSaida.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.TxtSaida.EmptyAsNull = True
        Me.TxtSaida.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.TxtSaida.Location = New System.Drawing.Point(638, 91)
        Me.TxtSaida.Name = "TxtSaida"
        Me.TxtSaida.Size = New System.Drawing.Size(147, 19)
        Me.TxtSaida.TabIndex = 9
        Me.TxtSaida.Tag = Nothing
        '
        'TxtDataNascimento
        '
        Me.TxtDataNascimento.AllowSpinLoop = False
        Me.TxtDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.TxtDataNascimento.Calendar.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
        Me.TxtDataNascimento.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TxtDataNascimento.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.TxtDataNascimento.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.TxtDataNascimento.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.TxtDataNascimento.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.TxtDataNascimento.Location = New System.Drawing.Point(276, 91)
        Me.TxtDataNascimento.Name = "TxtDataNascimento"
        Me.TxtDataNascimento.Size = New System.Drawing.Size(109, 19)
        Me.TxtDataNascimento.TabIndex = 6
        Me.TxtDataNascimento.Tag = Nothing
        '
        'FrmIncluirPessoa
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 370)
        Me.Controls.Add(Me.TxtDataNascimento)
        Me.Controls.Add(Me.TxtSaida)
        Me.Controls.Add(Me.TxtEntrada)
        Me.Controls.Add(Me.BtnSelecionarFoto)
        Me.Controls.Add(Me.PctFotoPerfil)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.LblLiberacao)
        Me.Controls.Add(Me.CmbLiberacao)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.BtnGravar)
        Me.Controls.Add(Me.TxtObservacao)
        Me.Controls.Add(Me.TxtDataCadastro)
        Me.Controls.Add(Me.CmbSituacao)
        Me.Controls.Add(Me.TxtEndereco)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtTelefone)
        Me.Controls.Add(Me.TxtCpf)
        Me.Controls.Add(Me.TxtCodigoPessoa)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblObservacao)
        Me.Controls.Add(Me.LblSituacao)
        Me.Controls.Add(Me.LblDataSaida)
        Me.Controls.Add(Me.LblDataEntrada)
        Me.Controls.Add(Me.LblEndereco)
        Me.Controls.Add(Me.LblDataCadastro)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblTelefone)
        Me.Controls.Add(Me.LblDataNascimento)
        Me.Controls.Add(Me.LblCpf)
        Me.Controls.Add(Me.LblNomePessoa)
        Me.Controls.Add(Me.LblCodigo)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIncluirPessoa"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir Pessoa"
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCpf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataNascimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblTelefone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblSituacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigoPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelefone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbSituacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDataCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnGravar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbLiberacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblLiberacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctFotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSelecionarFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDataNascimento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCodigo As C1.Win.C1Input.C1Label
    Friend WithEvents LblNomePessoa As C1.Win.C1Input.C1Label
    Friend WithEvents LblCpf As C1.Win.C1Input.C1Label
    Friend WithEvents LblDataNascimento As C1.Win.C1Input.C1Label
    Friend WithEvents LblTelefone As C1.Win.C1Input.C1Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblDataCadastro As C1.Win.C1Input.C1Label
    Friend WithEvents LblEndereco As Label
    Friend WithEvents LblDataEntrada As C1.Win.C1Input.C1Label
    Friend WithEvents LblDataSaida As C1.Win.C1Input.C1Label
    Friend WithEvents LblSituacao As C1.Win.C1Input.C1Label
    Friend WithEvents LblObservacao As C1.Win.C1Input.C1Label
    Friend WithEvents TxtNome As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtCodigoPessoa As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents TxtEmail As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtTelefone As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtCpf As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtEndereco As C1.Win.C1Input.C1TextBox
    Friend WithEvents CmbSituacao As C1.Win.C1Input.C1ComboBox
    Friend WithEvents TxtObservacao As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtDataCadastro As C1.Win.C1Input.C1TextBox
    Friend WithEvents BtnVoltar As C1.Win.C1Input.C1Button
    Friend WithEvents BtnGravar As C1.Win.C1Input.C1Button
    Friend WithEvents LblTipo As C1.Win.C1Input.C1Label
    Friend WithEvents CmbLiberacao As C1.Win.C1Input.C1ComboBox
    Friend WithEvents LblLiberacao As C1.Win.C1Input.C1Label
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents PctFotoPerfil As C1.Win.C1Input.C1PictureBox
    Friend WithEvents BtnSelecionarFoto As C1.Win.C1Input.C1Button
    Friend WithEvents TxtEntrada As C1.Win.C1Input.C1DateEdit
    Friend WithEvents TxtSaida As C1.Win.C1Input.C1DateEdit
    Friend WithEvents TxtDataNascimento As C1.Win.C1Input.C1DateEdit
End Class
