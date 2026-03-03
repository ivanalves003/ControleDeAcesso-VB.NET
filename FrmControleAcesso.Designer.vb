<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControleAcesso
    Inherits C1.Win.C1Ribbon.C1RibbonForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.C1Button3 = New C1.Win.C1Input.C1Button()
        Me.LblNomePessoa = New C1.Win.C1Input.C1Label()
        Me.C1FlexGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.BtnVoltar = New C1.Win.C1Input.C1Button()
        Me.TxtDataCadastro = New C1.Win.C1Input.C1TextBox()
        Me.CmbAtivo = New C1.Win.C1Input.C1ComboBox()
        Me.TxtSaida = New C1.Win.C1Input.C1TextBox()
        Me.TxtEntrada = New C1.Win.C1Input.C1TextBox()
        Me.TxtCpf = New C1.Win.C1Input.C1TextBox()
        Me.LblCodigoPessoa = New C1.Win.C1Input.C1TextBox()
        Me.TxtNome = New C1.Win.C1Input.C1TextBox()
        Me.LblAtivo = New C1.Win.C1Input.C1Label()
        Me.LblDataSaida = New C1.Win.C1Input.C1Label()
        Me.LblDataEntrada = New C1.Win.C1Input.C1Label()
        Me.LblDataCadastro = New C1.Win.C1Input.C1Label()
        Me.C1Label2 = New C1.Win.C1Input.C1Label()
        Me.LblCodigo = New C1.Win.C1Input.C1Label()
        Me.C1Label = New C1.Win.C1Input.C1Label()
        CType(Me.C1Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDataCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCodigoPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDataCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Button3
        '
        Me.C1Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.C1Button3.Location = New System.Drawing.Point(12, 415)
        Me.C1Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.C1Button3.Name = "C1Button3"
        Me.C1Button3.Size = New System.Drawing.Size(94, 24)
        Me.C1Button3.TabIndex = 398
        Me.C1Button3.Text = "&Selecionar"
        Me.C1Button3.UseVisualStyleBackColor = True
        Me.C1Button3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Button3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'LblNomePessoa
        '
        Me.LblNomePessoa.AutoSize = True
        Me.LblNomePessoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblNomePessoa.Location = New System.Drawing.Point(65, 10)
        Me.LblNomePessoa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNomePessoa.Name = "LblNomePessoa"
        Me.LblNomePessoa.Size = New System.Drawing.Size(38, 13)
        Me.LblNomePessoa.TabIndex = 394
        Me.LblNomePessoa.Tag = Nothing
        Me.LblNomePessoa.Text = "Nome:"
        Me.LblNomePessoa.TextDetached = True
        '
        'C1FlexGrid
        '
        Me.C1FlexGrid.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.C1FlexGrid.Location = New System.Drawing.Point(11, 88)
        Me.C1FlexGrid.Name = "C1FlexGrid"
        Me.C1FlexGrid.Rows.DefaultSize = 19
        Me.C1FlexGrid.Size = New System.Drawing.Size(775, 321)
        Me.C1FlexGrid.TabIndex = 393
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(709, 416)
        Me.BtnVoltar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(81, 25)
        Me.BtnVoltar.TabIndex = 392
        Me.BtnVoltar.Text = "&Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        Me.BtnVoltar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnVoltar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TxtDataCadastro
        '
        Me.TxtDataCadastro.Location = New System.Drawing.Point(453, 25)
        Me.TxtDataCadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtDataCadastro.Name = "TxtDataCadastro"
        Me.TxtDataCadastro.Size = New System.Drawing.Size(116, 18)
        Me.TxtDataCadastro.TabIndex = 391
        Me.TxtDataCadastro.Tag = Nothing
        '
        'CmbAtivo
        '
        Me.CmbAtivo.AllowSpinLoop = False
        Me.CmbAtivo.GapHeight = 0
        Me.CmbAtivo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CmbAtivo.ItemsDisplayMember = ""
        Me.CmbAtivo.ItemsValueMember = ""
        Me.CmbAtivo.Location = New System.Drawing.Point(576, 25)
        Me.CmbAtivo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbAtivo.Name = "CmbAtivo"
        Me.CmbAtivo.Size = New System.Drawing.Size(94, 18)
        Me.CmbAtivo.TabIndex = 390
        Me.CmbAtivo.Tag = Nothing
        '
        'TxtSaida
        '
        Me.TxtSaida.EditMask = "00/00/0000"
        Me.TxtSaida.Location = New System.Drawing.Point(200, 63)
        Me.TxtSaida.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSaida.Name = "TxtSaida"
        Me.TxtSaida.Size = New System.Drawing.Size(116, 18)
        Me.TxtSaida.TabIndex = 389
        Me.TxtSaida.Tag = Nothing
        '
        'TxtEntrada
        '
        Me.TxtEntrada.EditMask = "00/00/0000"
        Me.TxtEntrada.Location = New System.Drawing.Point(11, 64)
        Me.TxtEntrada.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.Size = New System.Drawing.Size(116, 18)
        Me.TxtEntrada.TabIndex = 388
        Me.TxtEntrada.Tag = Nothing
        '
        'TxtCpf
        '
        Me.TxtCpf.EditMask = "000.000.000-00"
        Me.TxtCpf.Location = New System.Drawing.Point(320, 25)
        Me.TxtCpf.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(125, 18)
        Me.TxtCpf.TabIndex = 385
        Me.TxtCpf.Tag = Nothing
        '
        'LblCodigoPessoa
        '
        Me.LblCodigoPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCodigoPessoa.Location = New System.Drawing.Point(12, 26)
        Me.LblCodigoPessoa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblCodigoPessoa.Name = "LblCodigoPessoa"
        Me.LblCodigoPessoa.Size = New System.Drawing.Size(46, 19)
        Me.LblCodigoPessoa.TabIndex = 384
        Me.LblCodigoPessoa.Tag = Nothing
        Me.LblCodigoPessoa.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.LblCodigoPessoa.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TxtNome
        '
        Me.TxtNome.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TxtNome.Location = New System.Drawing.Point(65, 25)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(251, 19)
        Me.TxtNome.TabIndex = 383
        Me.TxtNome.Tag = Nothing
        Me.TxtNome.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'LblAtivo
        '
        Me.LblAtivo.AutoSize = True
        Me.LblAtivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblAtivo.Location = New System.Drawing.Point(576, 10)
        Me.LblAtivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAtivo.Name = "LblAtivo"
        Me.LblAtivo.Size = New System.Drawing.Size(34, 13)
        Me.LblAtivo.TabIndex = 382
        Me.LblAtivo.Tag = Nothing
        Me.LblAtivo.Text = "Ativo:"
        Me.LblAtivo.TextDetached = True
        '
        'LblDataSaida
        '
        Me.LblDataSaida.AutoSize = True
        Me.LblDataSaida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataSaida.Location = New System.Drawing.Point(200, 47)
        Me.LblDataSaida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataSaida.Name = "LblDataSaida"
        Me.LblDataSaida.Size = New System.Drawing.Size(80, 13)
        Me.LblDataSaida.TabIndex = 381
        Me.LblDataSaida.Tag = Nothing
        Me.LblDataSaida.Text = "Data de Saída:"
        Me.LblDataSaida.TextDetached = True
        '
        'LblDataEntrada
        '
        Me.LblDataEntrada.AutoSize = True
        Me.LblDataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataEntrada.Location = New System.Drawing.Point(12, 48)
        Me.LblDataEntrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataEntrada.Name = "LblDataEntrada"
        Me.LblDataEntrada.Size = New System.Drawing.Size(88, 13)
        Me.LblDataEntrada.TabIndex = 380
        Me.LblDataEntrada.Tag = Nothing
        Me.LblDataEntrada.Text = "Data de Entrada:"
        Me.LblDataEntrada.TextDetached = True
        '
        'LblDataCadastro
        '
        Me.LblDataCadastro.AutoSize = True
        Me.LblDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblDataCadastro.Location = New System.Drawing.Point(453, 10)
        Me.LblDataCadastro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataCadastro.Name = "LblDataCadastro"
        Me.LblDataCadastro.Size = New System.Drawing.Size(90, 13)
        Me.LblDataCadastro.TabIndex = 379
        Me.LblDataCadastro.Tag = Nothing
        Me.LblDataCadastro.Text = "Data do Cadastro"
        Me.LblDataCadastro.TextDetached = True
        '
        'C1Label2
        '
        Me.C1Label2.AutoSize = True
        Me.C1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label2.Location = New System.Drawing.Point(320, 10)
        Me.C1Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.C1Label2.Name = "C1Label2"
        Me.C1Label2.Size = New System.Drawing.Size(30, 13)
        Me.C1Label2.TabIndex = 376
        Me.C1Label2.Tag = Nothing
        Me.C1Label2.Text = "CPF:"
        Me.C1Label2.TextDetached = True
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblCodigo.Location = New System.Drawing.Point(12, 10)
        Me.LblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.LblCodigo.TabIndex = 375
        Me.LblCodigo.Tag = Nothing
        Me.LblCodigo.Text = "Código:"
        Me.LblCodigo.TextDetached = True
        '
        'C1Label
        '
        Me.C1Label.AutoSize = True
        Me.C1Label.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label.Location = New System.Drawing.Point(154, 66)
        Me.C1Label.Name = "C1Label"
        Me.C1Label.Size = New System.Drawing.Size(23, 13)
        Me.C1Label.TabIndex = 399
        Me.C1Label.Tag = Nothing
        '
        'FrmControleAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1Label)
        Me.Controls.Add(Me.C1Button3)
        Me.Controls.Add(Me.LblNomePessoa)
        Me.Controls.Add(Me.C1FlexGrid)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.TxtDataCadastro)
        Me.Controls.Add(Me.CmbAtivo)
        Me.Controls.Add(Me.TxtSaida)
        Me.Controls.Add(Me.TxtEntrada)
        Me.Controls.Add(Me.TxtCpf)
        Me.Controls.Add(Me.LblCodigoPessoa)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblAtivo)
        Me.Controls.Add(Me.LblDataSaida)
        Me.Controls.Add(Me.LblDataEntrada)
        Me.Controls.Add(Me.LblDataCadastro)
        Me.Controls.Add(Me.C1Label2)
        Me.Controls.Add(Me.LblCodigo)
        Me.Name = "FrmControleAcesso"
        Me.Text = "FrmControleAcesso"
        CType(Me.C1Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDataCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCodigoPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDataCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1Button3 As C1.Win.C1Input.C1Button
    Friend WithEvents LblNomePessoa As C1.Win.C1Input.C1Label
    Friend WithEvents C1FlexGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents BtnVoltar As C1.Win.C1Input.C1Button
    Friend WithEvents TxtDataCadastro As C1.Win.C1Input.C1TextBox
    Friend WithEvents CmbAtivo As C1.Win.C1Input.C1ComboBox
    Friend WithEvents TxtSaida As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtEntrada As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtCpf As C1.Win.C1Input.C1TextBox
    Friend WithEvents LblCodigoPessoa As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtNome As C1.Win.C1Input.C1TextBox
    Friend WithEvents LblAtivo As C1.Win.C1Input.C1Label
    Friend WithEvents LblDataSaida As C1.Win.C1Input.C1Label
    Friend WithEvents LblDataEntrada As C1.Win.C1Input.C1Label
    Friend WithEvents LblDataCadastro As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label2 As C1.Win.C1Input.C1Label
    Friend WithEvents LblCodigo As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label As C1.Win.C1Input.C1Label
End Class
