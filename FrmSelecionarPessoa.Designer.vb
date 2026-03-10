<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSelecionarPessoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelecionarPessoa))
        Me.BtnVoltar = New C1.Win.C1Input.C1Button()
        Me.TxtCpf = New C1.Win.C1Input.C1TextBox()
        Me.TxtCodigoPessoa = New C1.Win.C1Input.C1TextBox()
        Me.LblSituacao = New C1.Win.C1Input.C1Label()
        Me.C1Label2 = New C1.Win.C1Input.C1Label()
        Me.LblCodigo = New C1.Win.C1Input.C1Label()
        Me.LblNomePessoa = New C1.Win.C1Input.C1Label()
        Me.BtnSelecionar = New C1.Win.C1Input.C1Button()
        Me.BtnExcluir = New C1.Win.C1Input.C1Button()
        Me.BtnAlterar = New C1.Win.C1Input.C1Button()
        Me.BtnIncluir = New C1.Win.C1Input.C1Button()
        Me.OptAtivo = New System.Windows.Forms.RadioButton()
        Me.OptInativo = New System.Windows.Forms.RadioButton()
        Me.C1RadialMenu1 = New C1.Win.C1Command.C1RadialMenu()
        Me.OptTodos = New System.Windows.Forms.RadioButton()
        Me.FlxTabelaSelecao = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TxtNome = New C1.Win.C1Input.C1TextBox()
        Me.PctFotoPerfil = New C1.Win.C1Input.C1PictureBox()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigoPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblSituacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSelecionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnExcluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlxTabelaSelecao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctFotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(1301, 368)
        Me.BtnVoltar.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(94, 25)
        Me.BtnVoltar.TabIndex = 11
        Me.BtnVoltar.Text = "&Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        Me.BtnVoltar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnVoltar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TxtCpf
        '
        Me.TxtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCpf.EmptyAsNull = True
        Me.TxtCpf.Location = New System.Drawing.Point(370, 12)
        Me.TxtCpf.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(146, 19)
        Me.TxtCpf.TabIndex = 3
        Me.TxtCpf.Tag = Nothing
        Me.TxtCpf.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TxtCodigoPessoa
        '
        Me.TxtCodigoPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigoPessoa.Location = New System.Drawing.Point(4, 12)
        Me.TxtCodigoPessoa.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TxtCodigoPessoa.Name = "TxtCodigoPessoa"
        Me.TxtCodigoPessoa.Size = New System.Drawing.Size(54, 19)
        Me.TxtCodigoPessoa.TabIndex = 1
        Me.TxtCodigoPessoa.Tag = Nothing
        Me.TxtCodigoPessoa.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.TxtCodigoPessoa.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'LblSituacao
        '
        Me.LblSituacao.AutoSize = True
        Me.LblSituacao.BackColor = System.Drawing.Color.Transparent
        Me.LblSituacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblSituacao.ForeColor = System.Drawing.Color.Black
        Me.LblSituacao.Location = New System.Drawing.Point(528, -2)
        Me.LblSituacao.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblSituacao.Name = "LblSituacao"
        Me.LblSituacao.Size = New System.Drawing.Size(61, 13)
        Me.LblSituacao.TabIndex = 39
        Me.LblSituacao.Tag = Nothing
        Me.LblSituacao.Text = "Situação:"
        Me.LblSituacao.TextDetached = True
        '
        'C1Label2
        '
        Me.C1Label2.AutoSize = True
        Me.C1Label2.BackColor = System.Drawing.Color.Transparent
        Me.C1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label2.ForeColor = System.Drawing.Color.Black
        Me.C1Label2.Location = New System.Drawing.Point(370, -2)
        Me.C1Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.C1Label2.Name = "C1Label2"
        Me.C1Label2.Size = New System.Drawing.Size(34, 13)
        Me.C1Label2.TabIndex = 31
        Me.C1Label2.Tag = Nothing
        Me.C1Label2.Text = "CPF:"
        Me.C1Label2.TextDetached = True
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblCodigo.ForeColor = System.Drawing.Color.Black
        Me.LblCodigo.Location = New System.Drawing.Point(4, -2)
        Me.LblCodigo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(52, 13)
        Me.LblCodigo.TabIndex = 29
        Me.LblCodigo.Tag = Nothing
        Me.LblCodigo.Text = "Código:"
        Me.LblCodigo.TextDetached = True
        '
        'LblNomePessoa
        '
        Me.LblNomePessoa.AutoSize = True
        Me.LblNomePessoa.BackColor = System.Drawing.Color.Transparent
        Me.LblNomePessoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblNomePessoa.ForeColor = System.Drawing.Color.Black
        Me.LblNomePessoa.Location = New System.Drawing.Point(59, -2)
        Me.LblNomePessoa.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblNomePessoa.Name = "LblNomePessoa"
        Me.LblNomePessoa.Size = New System.Drawing.Size(45, 13)
        Me.LblNomePessoa.TabIndex = 58
        Me.LblNomePessoa.Tag = Nothing
        Me.LblNomePessoa.Text = "Nome:"
        Me.LblNomePessoa.TextDetached = True
        '
        'BtnSelecionar
        '
        Me.BtnSelecionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSelecionar.Location = New System.Drawing.Point(4, 369)
        Me.BtnSelecionar.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnSelecionar.Name = "BtnSelecionar"
        Me.BtnSelecionar.Size = New System.Drawing.Size(93, 24)
        Me.BtnSelecionar.TabIndex = 7
        Me.BtnSelecionar.Text = "&Selecionar"
        Me.BtnSelecionar.UseVisualStyleBackColor = True
        Me.BtnSelecionar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnSelecionar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExcluir.Location = New System.Drawing.Point(287, 369)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(93, 24)
        Me.BtnExcluir.TabIndex = 10
        Me.BtnExcluir.Text = "&Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        Me.BtnExcluir.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnExcluir.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAlterar.Location = New System.Drawing.Point(192, 369)
        Me.BtnAlterar.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(93, 24)
        Me.BtnAlterar.TabIndex = 9
        Me.BtnAlterar.Text = "&Alterar"
        Me.BtnAlterar.UseVisualStyleBackColor = True
        Me.BtnAlterar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnAlterar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnIncluir.Location = New System.Drawing.Point(98, 369)
        Me.BtnIncluir.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(93, 24)
        Me.BtnIncluir.TabIndex = 8
        Me.BtnIncluir.Text = "&Incluir"
        Me.BtnIncluir.UseVisualStyleBackColor = True
        Me.BtnIncluir.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnIncluir.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'OptAtivo
        '
        Me.OptAtivo.AutoSize = True
        Me.OptAtivo.Location = New System.Drawing.Point(532, 13)
        Me.OptAtivo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OptAtivo.Name = "OptAtivo"
        Me.OptAtivo.Size = New System.Drawing.Size(54, 17)
        Me.OptAtivo.TabIndex = 4
        Me.OptAtivo.TabStop = True
        Me.OptAtivo.Text = "Ativo"
        Me.OptAtivo.UseVisualStyleBackColor = True
        '
        'OptInativo
        '
        Me.OptInativo.AutoSize = True
        Me.OptInativo.Location = New System.Drawing.Point(596, 13)
        Me.OptInativo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OptInativo.Name = "OptInativo"
        Me.OptInativo.Size = New System.Drawing.Size(65, 17)
        Me.OptInativo.TabIndex = 5
        Me.OptInativo.TabStop = True
        Me.OptInativo.Text = "Inativo"
        Me.OptInativo.UseVisualStyleBackColor = True
        '
        'OptTodos
        '
        Me.OptTodos.AutoSize = True
        Me.OptTodos.Checked = True
        Me.OptTodos.Location = New System.Drawing.Point(670, 13)
        Me.OptTodos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OptTodos.Name = "OptTodos"
        Me.OptTodos.Size = New System.Drawing.Size(58, 17)
        Me.OptTodos.TabIndex = 6
        Me.OptTodos.TabStop = True
        Me.OptTodos.Text = "Todos"
        Me.OptTodos.UseVisualStyleBackColor = True
        '
        'FlxTabelaSelecao
        '
        Me.FlxTabelaSelecao.AllowEditing = False
        Me.FlxTabelaSelecao.ColumnInfo = resources.GetString("FlxTabelaSelecao.ColumnInfo")
        Me.FlxTabelaSelecao.ExtendLastCol = True
        Me.FlxTabelaSelecao.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FlxTabelaSelecao.Location = New System.Drawing.Point(4, 32)
        Me.FlxTabelaSelecao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FlxTabelaSelecao.Name = "FlxTabelaSelecao"
        Me.FlxTabelaSelecao.Rows.DefaultSize = 20
        Me.FlxTabelaSelecao.Size = New System.Drawing.Size(1119, 335)
        Me.FlxTabelaSelecao.StyleInfo = resources.GetString("FlxTabelaSelecao.StyleInfo")
        Me.FlxTabelaSelecao.TabIndex = 379
        '
        'TxtNome
        '
        Me.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNome.Location = New System.Drawing.Point(61, 12)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(306, 19)
        Me.TxtNome.TabIndex = 2
        Me.TxtNome.Tag = Nothing
        Me.TxtNome.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'PctFotoPerfil
        '
        Me.PctFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PctFotoPerfil.Location = New System.Drawing.Point(1126, 32)
        Me.PctFotoPerfil.Name = "PctFotoPerfil"
        Me.PctFotoPerfil.Size = New System.Drawing.Size(269, 335)
        Me.PctFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctFotoPerfil.TabIndex = 381
        Me.PctFotoPerfil.TabStop = False
        '
        'FrmSelecionarPessoa
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1404, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.PctFotoPerfil)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.FlxTabelaSelecao)
        Me.Controls.Add(Me.OptTodos)
        Me.Controls.Add(Me.OptInativo)
        Me.Controls.Add(Me.OptAtivo)
        Me.Controls.Add(Me.BtnSelecionar)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.BtnIncluir)
        Me.Controls.Add(Me.LblNomePessoa)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.TxtCpf)
        Me.Controls.Add(Me.TxtCodigoPessoa)
        Me.Controls.Add(Me.LblSituacao)
        Me.Controls.Add(Me.C1Label2)
        Me.Controls.Add(Me.LblCodigo)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSelecionarPessoa"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pessoa"
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigoPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblSituacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSelecionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnExcluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlxTabelaSelecao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctFotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVoltar As C1.Win.C1Input.C1Button
    Friend WithEvents TxtCpf As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtCodigoPessoa As C1.Win.C1Input.C1TextBox
    Friend WithEvents LblSituacao As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label2 As C1.Win.C1Input.C1Label
    Friend WithEvents LblCodigo As C1.Win.C1Input.C1Label
    Friend WithEvents LblNomePessoa As C1.Win.C1Input.C1Label
    Friend WithEvents BtnSelecionar As C1.Win.C1Input.C1Button
    Friend WithEvents BtnExcluir As C1.Win.C1Input.C1Button
    Friend WithEvents BtnAlterar As C1.Win.C1Input.C1Button
    Friend WithEvents BtnIncluir As C1.Win.C1Input.C1Button
    Friend WithEvents OptAtivo As RadioButton
    Friend WithEvents OptInativo As RadioButton
    Friend WithEvents C1RadialMenu1 As C1.Win.C1Command.C1RadialMenu
    Friend WithEvents OptTodos As RadioButton
    Friend WithEvents FlxTabelaSelecao As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TxtNome As C1.Win.C1Input.C1TextBox
    Friend WithEvents PctFotoPerfil As C1.Win.C1Input.C1PictureBox
End Class
