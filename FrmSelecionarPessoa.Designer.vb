<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelecionarPessoa
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
        Me.BtnVoltar = New C1.Win.C1Input.C1Button()
        Me.CmbAtivo = New C1.Win.C1Input.C1ComboBox()
        Me.TxtCpf = New C1.Win.C1Input.C1TextBox()
        Me.LblCodigoPessoa = New C1.Win.C1Input.C1TextBox()
        Me.TxtNome = New C1.Win.C1Input.C1TextBox()
        Me.LblAtivo = New C1.Win.C1Input.C1Label()
        Me.C1Label2 = New C1.Win.C1Input.C1Label()
        Me.LblCodigo = New C1.Win.C1Input.C1Label()
        Me.C1FlexGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.LblNomePessoa = New C1.Win.C1Input.C1Label()
        Me.C1Button3 = New C1.Win.C1Input.C1Button()
        Me.C1Button2 = New C1.Win.C1Input.C1Button()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.BtnIncluir = New C1.Win.C1Input.C1Button()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCodigoPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(706, 413)
        Me.BtnVoltar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(81, 25)
        Me.BtnVoltar.TabIndex = 54
        Me.BtnVoltar.Text = "&Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        Me.BtnVoltar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnVoltar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'CmbAtivo
        '
        Me.CmbAtivo.AllowSpinLoop = False
        Me.CmbAtivo.GapHeight = 0
        Me.CmbAtivo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CmbAtivo.ItemsDisplayMember = ""
        Me.CmbAtivo.ItemsValueMember = ""
        Me.CmbAtivo.Location = New System.Drawing.Point(448, 22)
        Me.CmbAtivo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbAtivo.Name = "CmbAtivo"
        Me.CmbAtivo.Size = New System.Drawing.Size(94, 18)
        Me.CmbAtivo.TabIndex = 50
        Me.CmbAtivo.Tag = Nothing
        '
        'TxtCpf
        '
        Me.TxtCpf.EditMask = "000.000.000-00"
        Me.TxtCpf.Location = New System.Drawing.Point(317, 22)
        Me.TxtCpf.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(125, 18)
        Me.TxtCpf.TabIndex = 43
        Me.TxtCpf.Tag = Nothing
        '
        'LblCodigoPessoa
        '
        Me.LblCodigoPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCodigoPessoa.Location = New System.Drawing.Point(9, 23)
        Me.LblCodigoPessoa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblCodigoPessoa.Name = "LblCodigoPessoa"
        Me.LblCodigoPessoa.Size = New System.Drawing.Size(46, 18)
        Me.LblCodigoPessoa.TabIndex = 42
        Me.LblCodigoPessoa.Tag = Nothing
        Me.LblCodigoPessoa.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.LblCodigoPessoa.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TxtNome
        '
        Me.TxtNome.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TxtNome.Location = New System.Drawing.Point(62, 22)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(251, 19)
        Me.TxtNome.TabIndex = 41
        Me.TxtNome.Tag = Nothing
        Me.TxtNome.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'LblAtivo
        '
        Me.LblAtivo.AutoSize = True
        Me.LblAtivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblAtivo.Location = New System.Drawing.Point(448, 7)
        Me.LblAtivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAtivo.Name = "LblAtivo"
        Me.LblAtivo.Size = New System.Drawing.Size(34, 13)
        Me.LblAtivo.TabIndex = 39
        Me.LblAtivo.Tag = Nothing
        Me.LblAtivo.Text = "Ativo:"
        Me.LblAtivo.TextDetached = True
        '
        'C1Label2
        '
        Me.C1Label2.AutoSize = True
        Me.C1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label2.Location = New System.Drawing.Point(317, 7)
        Me.C1Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.C1Label2.Name = "C1Label2"
        Me.C1Label2.Size = New System.Drawing.Size(30, 13)
        Me.C1Label2.TabIndex = 31
        Me.C1Label2.Tag = Nothing
        Me.C1Label2.Text = "CPF:"
        Me.C1Label2.TextDetached = True
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblCodigo.Location = New System.Drawing.Point(9, 7)
        Me.LblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.LblCodigo.TabIndex = 29
        Me.LblCodigo.Tag = Nothing
        Me.LblCodigo.Text = "Código:"
        Me.LblCodigo.TextDetached = True
        '
        'C1FlexGrid
        '
        Me.C1FlexGrid.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.C1FlexGrid.Location = New System.Drawing.Point(8, 85)
        Me.C1FlexGrid.Name = "C1FlexGrid"
        Me.C1FlexGrid.Rows.DefaultSize = 19
        Me.C1FlexGrid.Size = New System.Drawing.Size(775, 321)
        Me.C1FlexGrid.TabIndex = 55
        '
        'LblNomePessoa
        '
        Me.LblNomePessoa.AutoSize = True
        Me.LblNomePessoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblNomePessoa.Location = New System.Drawing.Point(62, 7)
        Me.LblNomePessoa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNomePessoa.Name = "LblNomePessoa"
        Me.LblNomePessoa.Size = New System.Drawing.Size(38, 13)
        Me.LblNomePessoa.TabIndex = 58
        Me.LblNomePessoa.Tag = Nothing
        Me.LblNomePessoa.Text = "Nome:"
        Me.LblNomePessoa.TextDetached = True
        '
        'C1Button3
        '
        Me.C1Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.C1Button3.Location = New System.Drawing.Point(9, 412)
        Me.C1Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.C1Button3.Name = "C1Button3"
        Me.C1Button3.Size = New System.Drawing.Size(94, 24)
        Me.C1Button3.TabIndex = 374
        Me.C1Button3.Text = "&Selecionar"
        Me.C1Button3.UseVisualStyleBackColor = True
        Me.C1Button3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Button3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Button2
        '
        Me.C1Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.C1Button2.Location = New System.Drawing.Point(313, 412)
        Me.C1Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.C1Button2.Name = "C1Button2"
        Me.C1Button2.Size = New System.Drawing.Size(94, 24)
        Me.C1Button2.TabIndex = 373
        Me.C1Button2.Text = "&Excluir"
        Me.C1Button2.UseVisualStyleBackColor = True
        Me.C1Button2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Button2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Button1
        '
        Me.C1Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.C1Button1.Location = New System.Drawing.Point(211, 412)
        Me.C1Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(94, 24)
        Me.C1Button1.TabIndex = 372
        Me.C1Button1.Text = "&Alterar"
        Me.C1Button1.UseVisualStyleBackColor = True
        Me.C1Button1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnIncluir.Location = New System.Drawing.Point(109, 412)
        Me.BtnIncluir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(94, 24)
        Me.BtnIncluir.TabIndex = 371
        Me.BtnIncluir.Text = "&Incluir"
        Me.BtnIncluir.UseVisualStyleBackColor = True
        Me.BtnIncluir.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnIncluir.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'FrmSelecionarPessoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1Button3)
        Me.Controls.Add(Me.C1Button2)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me.BtnIncluir)
        Me.Controls.Add(Me.LblNomePessoa)
        Me.Controls.Add(Me.C1FlexGrid)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.CmbAtivo)
        Me.Controls.Add(Me.TxtCpf)
        Me.Controls.Add(Me.LblCodigoPessoa)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblAtivo)
        Me.Controls.Add(Me.C1Label2)
        Me.Controls.Add(Me.LblCodigo)
        Me.Name = "FrmSelecionarPessoa"
        Me.Text = "FrmSelecionarPessoa"
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCpf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCodigoPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblNomePessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVoltar As C1.Win.C1Input.C1Button
    Friend WithEvents CmbAtivo As C1.Win.C1Input.C1ComboBox
    Friend WithEvents TxtCpf As C1.Win.C1Input.C1TextBox
    Friend WithEvents LblCodigoPessoa As C1.Win.C1Input.C1TextBox
    Friend WithEvents TxtNome As C1.Win.C1Input.C1TextBox
    Friend WithEvents LblAtivo As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label2 As C1.Win.C1Input.C1Label
    Friend WithEvents LblCodigo As C1.Win.C1Input.C1Label
    Friend WithEvents C1FlexGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents LblNomePessoa As C1.Win.C1Input.C1Label
    Friend WithEvents C1Button3 As C1.Win.C1Input.C1Button
    Friend WithEvents C1Button2 As C1.Win.C1Input.C1Button
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents BtnIncluir As C1.Win.C1Input.C1Button
End Class
