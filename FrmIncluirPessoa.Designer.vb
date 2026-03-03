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
        Me.C1Label2 = New C1.Win.C1Input.C1Label()
        Me.LblDataNascimento = New C1.Win.C1Input.C1Label()
        Me.LblTelefone = New C1.Win.C1Input.C1Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblDataCadastro = New C1.Win.C1Input.C1Label()
        Me.LblEndereco = New System.Windows.Forms.Label()
        Me.LblDataEntrada = New C1.Win.C1Input.C1Label()
        Me.LblDataSaida = New C1.Win.C1Input.C1Label()
        Me.LblAtivo = New C1.Win.C1Input.C1Label()
        Me.LblObservacao = New C1.Win.C1Input.C1Label()
        Me.TxtNome = New C1.Win.C1Input.C1TextBox()
        Me.LblCodigoPessoa = New C1.Win.C1Input.C1TextBox()
        Me.TxtCpf = New C1.Win.C1Input.C1TextBox()
        Me.TxtTelefone = New C1.Win.C1Input.C1TextBox()
        Me.TxtEmail = New C1.Win.C1Input.C1TextBox()
        Me.TxtEndereco = New C1.Win.C1Input.C1TextBox()
        Me.TxtEntrada = New C1.Win.C1Input.C1TextBox()
        Me.TxtSaida = New C1.Win.C1Input.C1TextBox()
        Me.TxtDataNascimento = New C1.Win.C1Input.C1TextBox()
        Me.CmbAtivo = New C1.Win.C1Input.C1ComboBox()
        Me.TxtDataCadastro = New C1.Win.C1Input.C1TextBox()
        Me.TxtObservacao = New C1.Win.C1Input.C1TextBox()
        Me.BtnIncluir = New C1.Win.C1Input.C1Button()
        Me.BtnVoltar = New C1.Win.C1Input.C1Button()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.C1Label1 = New C1.Win.C1Input.C1Label()
        Me.C1ComboBox1 = New C1.Win.C1Input.C1ComboBox()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataNascimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblTelefone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCodigoPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelefone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDataNascimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDataCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblCodigo.Location = New System.Drawing.Point(4, 3)
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
        Me.LblNomePessoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblNomePessoa.Location = New System.Drawing.Point(57, 3)
        Me.LblNomePessoa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNomePessoa.Name = "LblNomePessoa"
        Me.LblNomePessoa.Size = New System.Drawing.Size(104, 13)
        Me.LblNomePessoa.TabIndex = 1
        Me.LblNomePessoa.Tag = Nothing
        Me.LblNomePessoa.Text = "Nome Completo:"
        Me.LblNomePessoa.TextDetached = True
        '
        'C1Label2
        '
        Me.C1Label2.AutoSize = True
        Me.C1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label2.Location = New System.Drawing.Point(312, 3)
        Me.C1Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.C1Label2.Name = "C1Label2"
        Me.C1Label2.Size = New System.Drawing.Size(34, 13)
        Me.C1Label2.TabIndex = 3
        Me.C1Label2.Tag = Nothing
        Me.C1Label2.Text = "CPF:"
        Me.C1Label2.TextDetached = True
        '
        'LblDataNascimento
        '
        Me.LblDataNascimento.AutoSize = True
        Me.LblDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataNascimento.Location = New System.Drawing.Point(4, 78)
        Me.LblDataNascimento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataNascimento.Name = "LblDataNascimento"
        Me.LblDataNascimento.Size = New System.Drawing.Size(127, 13)
        Me.LblDataNascimento.TabIndex = 4
        Me.LblDataNascimento.Tag = Nothing
        Me.LblDataNascimento.Text = "Data de Nascimento:"
        Me.LblDataNascimento.TextDetached = True
        '
        'LblTelefone
        '
        Me.LblTelefone.AutoSize = True
        Me.LblTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblTelefone.Location = New System.Drawing.Point(440, 3)
        Me.LblTelefone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTelefone.Name = "LblTelefone"
        Me.LblTelefone.Size = New System.Drawing.Size(60, 13)
        Me.LblTelefone.TabIndex = 5
        Me.LblTelefone.Tag = Nothing
        Me.LblTelefone.Text = "Telefone:"
        Me.LblTelefone.TextDetached = True
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(567, 3)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(48, 13)
        Me.LblEmail.TabIndex = 7
        Me.LblEmail.Text = "E-mail:"
        '
        'LblDataCadastro
        '
        Me.LblDataCadastro.AutoSize = True
        Me.LblDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataCadastro.Location = New System.Drawing.Point(444, 78)
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
        Me.LblEndereco.Location = New System.Drawing.Point(0, 40)
        Me.LblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEndereco.Name = "LblEndereco"
        Me.LblEndereco.Size = New System.Drawing.Size(65, 13)
        Me.LblEndereco.TabIndex = 9
        Me.LblEndereco.Text = "Endereço:"
        '
        'LblDataEntrada
        '
        Me.LblDataEntrada.AutoSize = True
        Me.LblDataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataEntrada.Location = New System.Drawing.Point(440, 41)
        Me.LblDataEntrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataEntrada.Name = "LblDataEntrada"
        Me.LblDataEntrada.Size = New System.Drawing.Size(105, 13)
        Me.LblDataEntrada.TabIndex = 10
        Me.LblDataEntrada.Tag = Nothing
        Me.LblDataEntrada.Text = "Data de Entrada:"
        Me.LblDataEntrada.TextDetached = True
        '
        'LblDataSaida
        '
        Me.LblDataSaida.AutoSize = True
        Me.LblDataSaida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataSaida.Location = New System.Drawing.Point(570, 41)
        Me.LblDataSaida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataSaida.Name = "LblDataSaida"
        Me.LblDataSaida.Size = New System.Drawing.Size(93, 13)
        Me.LblDataSaida.TabIndex = 11
        Me.LblDataSaida.Tag = Nothing
        Me.LblDataSaida.Text = "Data de Saída:"
        Me.LblDataSaida.TextDetached = True
        '
        'LblAtivo
        '
        Me.LblAtivo.AutoSize = True
        Me.LblAtivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblAtivo.Location = New System.Drawing.Point(570, 79)
        Me.LblAtivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAtivo.Name = "LblAtivo"
        Me.LblAtivo.Size = New System.Drawing.Size(41, 13)
        Me.LblAtivo.TabIndex = 12
        Me.LblAtivo.Tag = Nothing
        Me.LblAtivo.Text = "Ativo:"
        Me.LblAtivo.TextDetached = True
        '
        'LblObservacao
        '
        Me.LblObservacao.AutoSize = True
        Me.LblObservacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblObservacao.Location = New System.Drawing.Point(4, 117)
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
        Me.TxtNome.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TxtNome.Location = New System.Drawing.Point(57, 18)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(251, 19)
        Me.TxtNome.TabIndex = 14
        Me.TxtNome.Tag = Nothing
        Me.TxtNome.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'LblCodigoPessoa
        '
        Me.LblCodigoPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCodigoPessoa.Location = New System.Drawing.Point(4, 19)
        Me.LblCodigoPessoa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblCodigoPessoa.Name = "LblCodigoPessoa"
        Me.LblCodigoPessoa.Size = New System.Drawing.Size(46, 19)
        Me.LblCodigoPessoa.TabIndex = 15
        Me.LblCodigoPessoa.Tag = Nothing
        Me.LblCodigoPessoa.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.LblCodigoPessoa.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TxtCpf
        '
        Me.TxtCpf.EditMask = "000.000.000-00"
        Me.TxtCpf.Location = New System.Drawing.Point(312, 18)
        Me.TxtCpf.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(125, 19)
        Me.TxtCpf.TabIndex = 16
        Me.TxtCpf.Tag = Nothing
        '
        'TxtTelefone
        '
        Me.TxtTelefone.EditMask = "00 0 0000-0000"
        Me.TxtTelefone.Location = New System.Drawing.Point(444, 18)
        Me.TxtTelefone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(116, 19)
        Me.TxtTelefone.TabIndex = 17
        Me.TxtTelefone.Tag = Nothing
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(570, 18)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(116, 19)
        Me.TxtEmail.TabIndex = 18
        Me.TxtEmail.Tag = Nothing
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Location = New System.Drawing.Point(4, 57)
        Me.TxtEndereco.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(433, 19)
        Me.TxtEndereco.TabIndex = 19
        Me.TxtEndereco.Tag = Nothing
        '
        'TxtEntrada
        '
        Me.TxtEntrada.EditMask = "00/00/0000"
        Me.TxtEntrada.Location = New System.Drawing.Point(444, 57)
        Me.TxtEntrada.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.Size = New System.Drawing.Size(116, 19)
        Me.TxtEntrada.TabIndex = 20
        Me.TxtEntrada.Tag = Nothing
        '
        'TxtSaida
        '
        Me.TxtSaida.EditMask = "00/00/0000"
        Me.TxtSaida.Location = New System.Drawing.Point(570, 57)
        Me.TxtSaida.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSaida.Name = "TxtSaida"
        Me.TxtSaida.Size = New System.Drawing.Size(116, 19)
        Me.TxtSaida.TabIndex = 21
        Me.TxtSaida.Tag = Nothing
        '
        'TxtDataNascimento
        '
        Me.TxtDataNascimento.EditMask = "00/00/0000"
        Me.TxtDataNascimento.Location = New System.Drawing.Point(4, 95)
        Me.TxtDataNascimento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtDataNascimento.Name = "TxtDataNascimento"
        Me.TxtDataNascimento.Size = New System.Drawing.Size(125, 19)
        Me.TxtDataNascimento.TabIndex = 22
        Me.TxtDataNascimento.Tag = Nothing
        '
        'CmbAtivo
        '
        Me.CmbAtivo.AllowSpinLoop = False
        Me.CmbAtivo.GapHeight = 0
        Me.CmbAtivo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CmbAtivo.ItemsDisplayMember = ""
        Me.CmbAtivo.ItemsValueMember = ""
        Me.CmbAtivo.Location = New System.Drawing.Point(570, 95)
        Me.CmbAtivo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbAtivo.Name = "CmbAtivo"
        Me.CmbAtivo.Size = New System.Drawing.Size(114, 19)
        Me.CmbAtivo.TabIndex = 24
        Me.CmbAtivo.Tag = Nothing
        '
        'TxtDataCadastro
        '
        Me.TxtDataCadastro.Location = New System.Drawing.Point(445, 94)
        Me.TxtDataCadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtDataCadastro.Name = "TxtDataCadastro"
        Me.TxtDataCadastro.Size = New System.Drawing.Size(116, 19)
        Me.TxtDataCadastro.TabIndex = 25
        Me.TxtDataCadastro.Tag = Nothing
        '
        'TxtObservacao
        '
        Me.TxtObservacao.Location = New System.Drawing.Point(3, 133)
        Me.TxtObservacao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtObservacao.Name = "TxtObservacao"
        Me.TxtObservacao.Size = New System.Drawing.Size(683, 19)
        Me.TxtObservacao.TabIndex = 26
        Me.TxtObservacao.Tag = Nothing
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnIncluir.Location = New System.Drawing.Point(3, 158)
        Me.BtnIncluir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(81, 24)
        Me.BtnIncluir.TabIndex = 27
        Me.BtnIncluir.Text = "&Gravar"
        Me.BtnIncluir.UseVisualStyleBackColor = True
        Me.BtnIncluir.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnIncluir.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(605, 158)
        Me.BtnVoltar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(81, 25)
        Me.BtnVoltar.TabIndex = 28
        Me.BtnVoltar.Text = "&Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        Me.BtnVoltar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnVoltar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Button1
        '
        Me.C1Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.C1Button1.Location = New System.Drawing.Point(96, 158)
        Me.C1Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(81, 24)
        Me.C1Button1.TabIndex = 29
        Me.C1Button1.Text = "&Editar"
        Me.C1Button1.UseVisualStyleBackColor = True
        Me.C1Button1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Label1
        '
        Me.C1Label1.AutoSize = True
        Me.C1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label1.Location = New System.Drawing.Point(139, 79)
        Me.C1Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.C1Label1.Name = "C1Label1"
        Me.C1Label1.Size = New System.Drawing.Size(36, 13)
        Me.C1Label1.TabIndex = 30
        Me.C1Label1.Tag = Nothing
        Me.C1Label1.Text = "Tipo:"
        Me.C1Label1.TextDetached = True
        '
        'C1ComboBox1
        '
        Me.C1ComboBox1.AllowSpinLoop = False
        Me.C1ComboBox1.GapHeight = 0
        Me.C1ComboBox1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox1.ItemsDisplayMember = ""
        Me.C1ComboBox1.ItemsValueMember = ""
        Me.C1ComboBox1.Location = New System.Drawing.Point(139, 94)
        Me.C1ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.C1ComboBox1.Name = "C1ComboBox1"
        Me.C1ComboBox1.Size = New System.Drawing.Size(298, 19)
        Me.C1ComboBox1.TabIndex = 31
        Me.C1ComboBox1.Tag = Nothing
        '
        'FrmIncluirPessoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(697, 190)
        Me.Controls.Add(Me.C1ComboBox1)
        Me.Controls.Add(Me.C1Label1)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.BtnIncluir)
        Me.Controls.Add(Me.TxtObservacao)
        Me.Controls.Add(Me.TxtDataCadastro)
        Me.Controls.Add(Me.CmbAtivo)
        Me.Controls.Add(Me.TxtDataNascimento)
        Me.Controls.Add(Me.TxtSaida)
        Me.Controls.Add(Me.TxtEntrada)
        Me.Controls.Add(Me.TxtEndereco)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtTelefone)
        Me.Controls.Add(Me.TxtCpf)
        Me.Controls.Add(Me.LblCodigoPessoa)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblObservacao)
        Me.Controls.Add(Me.LblAtivo)
        Me.Controls.Add(Me.LblDataSaida)
        Me.Controls.Add(Me.LblDataEntrada)
        Me.Controls.Add(Me.LblEndereco)
        Me.Controls.Add(Me.LblDataCadastro)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblTelefone)
        Me.Controls.Add(Me.LblDataNascimento)
        Me.Controls.Add(Me.C1Label2)
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
        Me.Text = "FrmIncluirPessoa"
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataNascimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblTelefone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCodigoPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelefone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDataNascimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDataCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCodigo As C1.Win.C1Input.C1Label
    Friend WithEvents LblNomePessoa As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label2 As C1.Win.C1Input.C1Label
    Friend WithEvents LblDataNascimento As C1.Win.C1Input.C1Label
    Friend WithEvents LblTelefone As C1.Win.C1Input.C1Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblDataCadastro As C1.Win.C1Input.C1Label
    Friend WithEvents LblEndereco As Label
    Friend WithEvents LblDataEntrada As C1.Win.C1Input.C1Label
    Friend WithEvents LblDataSaida As C1.Win.C1Input.C1Label
    Friend WithEvents LblAtivo As C1.Win.C1Input.C1Label
    Friend WithEvents LblObservacao As C1.Win.C1Input.C1Label
    Friend WithEvents TxtNome As C1.Win.C1Input.C1TextBox
    Friend WithEvents LblCodigoPessoa As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents TxtEmail As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtTelefone As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtCpf As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtEntrada As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtEndereco As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtSaida As C1.Win.C1Input.C1TextBox
    Friend WithEvents CmbAtivo As C1.Win.C1Input.C1ComboBox
    Friend WithEvents TxtDataNascimento As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtObservacao As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtDataCadastro As C1.Win.C1Input.C1TextBox
    Friend WithEvents BtnVoltar As C1.Win.C1Input.C1Button
    Friend WithEvents BtnIncluir As C1.Win.C1Input.C1Button
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents C1ComboBox1 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents C1Label1 As C1.Win.C1Input.C1Label
End Class
