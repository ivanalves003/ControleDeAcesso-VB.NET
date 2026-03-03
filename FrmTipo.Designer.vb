<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipo))
        Me.BtnIncluir = New C1.Win.C1Input.C1Button()
        Me.BtnVoltar = New C1.Win.C1Input.C1Button()
        Me.LblCodigo = New C1.Win.C1Input.C1Label()
        Me.TxtCodigoTipo = New C1.Win.C1Input.C1TextBox()
        Me.LblTipoPessoa = New C1.Win.C1Input.C1Label()
        Me.TxtTipoPessoa = New C1.Win.C1Input.C1TextBox()
        Me.BtnAlterar = New C1.Win.C1Input.C1Button()
        Me.BtnExcluir = New C1.Win.C1Input.C1Button()
        Me.BtnSelecionar = New C1.Win.C1Input.C1Button()
        Me.LblObservacao = New C1.Win.C1Input.C1Label()
        Me.BtnGravar = New C1.Win.C1Input.C1Button()
        Me.FlxTabelaSelecao = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TxtObservacao = New C1.Win.C1Input.C1TextBox()
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigoTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblTipoPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTipoPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnExcluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSelecionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnGravar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlxTabelaSelecao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnIncluir.Location = New System.Drawing.Point(84, 355)
        Me.BtnIncluir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(75, 24)
        Me.BtnIncluir.TabIndex = 5
        Me.BtnIncluir.Text = "&Incluir"
        Me.BtnIncluir.UseVisualStyleBackColor = True
        Me.BtnIncluir.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnIncluir.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(484, 355)
        Me.BtnVoltar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 25)
        Me.BtnVoltar.TabIndex = 15
        Me.BtnVoltar.Text = "&Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        Me.BtnVoltar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnVoltar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblCodigo.ForeColor = System.Drawing.Color.Black
        Me.LblCodigo.Location = New System.Drawing.Point(2, 2)
        Me.LblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(52, 13)
        Me.LblCodigo.TabIndex = 30
        Me.LblCodigo.Tag = Nothing
        Me.LblCodigo.Text = "Código:"
        Me.LblCodigo.TextDetached = True
        '
        'TxtCodigoTipo
        '
        Me.TxtCodigoTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigoTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigoTipo.Location = New System.Drawing.Point(3, 17)
        Me.TxtCodigoTipo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCodigoTipo.Name = "TxtCodigoTipo"
        Me.TxtCodigoTipo.Size = New System.Drawing.Size(54, 19)
        Me.TxtCodigoTipo.TabIndex = 0
        Me.TxtCodigoTipo.Tag = Nothing
        Me.TxtCodigoTipo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.TxtCodigoTipo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'LblTipoPessoa
        '
        Me.LblTipoPessoa.AutoSize = True
        Me.LblTipoPessoa.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoPessoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblTipoPessoa.ForeColor = System.Drawing.Color.Black
        Me.LblTipoPessoa.Location = New System.Drawing.Point(74, 2)
        Me.LblTipoPessoa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoPessoa.Name = "LblTipoPessoa"
        Me.LblTipoPessoa.Size = New System.Drawing.Size(205, 13)
        Me.LblTipoPessoa.TabIndex = 32
        Me.LblTipoPessoa.Tag = Nothing
        Me.LblTipoPessoa.Text = "Tipo/Pessoa (Morador, Visitante..):"
        Me.LblTipoPessoa.TextDetached = True
        '
        'TxtTipoPessoa
        '
        Me.TxtTipoPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTipoPessoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTipoPessoa.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TxtTipoPessoa.Location = New System.Drawing.Point(69, 17)
        Me.TxtTipoPessoa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtTipoPessoa.Name = "TxtTipoPessoa"
        Me.TxtTipoPessoa.Size = New System.Drawing.Size(484, 19)
        Me.TxtTipoPessoa.TabIndex = 1
        Me.TxtTipoPessoa.Tag = Nothing
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAlterar.Location = New System.Drawing.Point(160, 355)
        Me.BtnAlterar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(75, 24)
        Me.BtnAlterar.TabIndex = 6
        Me.BtnAlterar.Text = "&Alterar"
        Me.BtnAlterar.UseVisualStyleBackColor = True
        Me.BtnAlterar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnAlterar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExcluir.Location = New System.Drawing.Point(236, 355)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(75, 24)
        Me.BtnExcluir.TabIndex = 7
        Me.BtnExcluir.Text = "&Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        Me.BtnExcluir.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnExcluir.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'BtnSelecionar
        '
        Me.BtnSelecionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSelecionar.Location = New System.Drawing.Point(3, 355)
        Me.BtnSelecionar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSelecionar.Name = "BtnSelecionar"
        Me.BtnSelecionar.Size = New System.Drawing.Size(80, 24)
        Me.BtnSelecionar.TabIndex = 4
        Me.BtnSelecionar.Text = "&Selecionar"
        Me.BtnSelecionar.UseVisualStyleBackColor = True
        Me.BtnSelecionar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnSelecionar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'LblObservacao
        '
        Me.LblObservacao.AutoSize = True
        Me.LblObservacao.BackColor = System.Drawing.Color.Transparent
        Me.LblObservacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblObservacao.ForeColor = System.Drawing.Color.Black
        Me.LblObservacao.Location = New System.Drawing.Point(2, 36)
        Me.LblObservacao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblObservacao.Name = "LblObservacao"
        Me.LblObservacao.Size = New System.Drawing.Size(80, 13)
        Me.LblObservacao.TabIndex = 34
        Me.LblObservacao.Tag = Nothing
        Me.LblObservacao.Text = "Observacao:"
        Me.LblObservacao.TextDetached = True
        '
        'BtnGravar
        '
        Me.BtnGravar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnGravar.Location = New System.Drawing.Point(475, 17)
        Me.BtnGravar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(84, 19)
        Me.BtnGravar.TabIndex = 3
        Me.BtnGravar.Text = "&Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = True
        Me.BtnGravar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnGravar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'FlxTabelaSelecao
        '
        Me.FlxTabelaSelecao.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.FlxTabelaSelecao.AllowEditing = False
        Me.FlxTabelaSelecao.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.FlxTabelaSelecao.BackColor = System.Drawing.Color.White
        Me.FlxTabelaSelecao.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.FlxTabelaSelecao.ClipboardCopyMode = C1.Win.C1FlexGrid.ClipboardCopyModeEnum.Disabled
        Me.FlxTabelaSelecao.ColumnInfo = resources.GetString("FlxTabelaSelecao.ColumnInfo")
        Me.FlxTabelaSelecao.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.FlxTabelaSelecao.ExtendLastCol = True
        Me.FlxTabelaSelecao.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FlxTabelaSelecao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FlxTabelaSelecao.Language = C1.Util.Localization.Language.Portuguese
        Me.FlxTabelaSelecao.Location = New System.Drawing.Point(3, 70)
        Me.FlxTabelaSelecao.Name = "FlxTabelaSelecao"
        Me.FlxTabelaSelecao.Rows.DefaultSize = 20
        Me.FlxTabelaSelecao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.FlxTabelaSelecao.Size = New System.Drawing.Size(556, 283)
        Me.FlxTabelaSelecao.StyleInfo = resources.GetString("FlxTabelaSelecao.StyleInfo")
        Me.FlxTabelaSelecao.TabIndex = 3
        '
        'TxtObservacao
        '
        Me.TxtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservacao.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TxtObservacao.Location = New System.Drawing.Point(3, 49)
        Me.TxtObservacao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtObservacao.Name = "TxtObservacao"
        Me.TxtObservacao.Size = New System.Drawing.Size(648, 19)
        Me.TxtObservacao.TabIndex = 2
        Me.TxtObservacao.Tag = Nothing
        '
        'FrmTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(563, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnGravar)
        Me.Controls.Add(Me.BtnSelecionar)
        Me.Controls.Add(Me.FlxTabelaSelecao)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.TxtObservacao)
        Me.Controls.Add(Me.LblObservacao)
        Me.Controls.Add(Me.TxtTipoPessoa)
        Me.Controls.Add(Me.LblTipoPessoa)
        Me.Controls.Add(Me.TxtCodigoTipo)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.BtnIncluir)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTipo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "FrmTipo"
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigoTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblTipoPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTipoPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnExcluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSelecionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnGravar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlxTabelaSelecao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnIncluir As C1.Win.C1Input.C1Button
    Friend WithEvents BtnVoltar As C1.Win.C1Input.C1Button
    Friend WithEvents LblCodigo As C1.Win.C1Input.C1Label
    Friend WithEvents TxtCodigoTipo As C1.Win.C1Input.C1TextBox
    Friend WithEvents LblTipoPessoa As C1.Win.C1Input.C1Label
    Friend WithEvents TxtTipoPessoa As C1.Win.C1Input.C1TextBox
    Friend WithEvents BtnAlterar As C1.Win.C1Input.C1Button
    Friend WithEvents BtnExcluir As C1.Win.C1Input.C1Button
    Friend WithEvents BtnSelecionar As C1.Win.C1Input.C1Button
    Friend WithEvents LblObservacao As C1.Win.C1Input.C1Label
    Friend WithEvents BtnGravar As C1.Win.C1Input.C1Button
    Friend WithEvents FlxTabelaSelecao As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TxtObservacao As C1.Win.C1Input.C1TextBox
End Class
