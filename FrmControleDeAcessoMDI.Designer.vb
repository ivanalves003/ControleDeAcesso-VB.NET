<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmControleDeAcessoMDI
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MnuTipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.PessoaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiberaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncluirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelecionarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleDeAcessosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelecionarHistoricoDeAcessosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuTipo, Me.PessoaToolStripMenuItem, Me.LiberaçãoToolStripMenuItem, Me.ControleDeAcessosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(933, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MnuTipo
        '
        Me.MnuTipo.Name = "MnuTipo"
        Me.MnuTipo.Size = New System.Drawing.Size(43, 20)
        Me.MnuTipo.Text = "Tipo"
        '
        'PessoaToolStripMenuItem
        '
        Me.PessoaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncluirToolStripMenuItem, Me.ListarToolStripMenuItem})
        Me.PessoaToolStripMenuItem.Name = "PessoaToolStripMenuItem"
        Me.PessoaToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.PessoaToolStripMenuItem.Text = "Pessoa"
        '
        'IncluirToolStripMenuItem
        '
        Me.IncluirToolStripMenuItem.Name = "IncluirToolStripMenuItem"
        Me.IncluirToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.IncluirToolStripMenuItem.Text = "Incluir"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'LiberaçãoToolStripMenuItem
        '
        Me.LiberaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncluirToolStripMenuItem1, Me.SelecionarToolStripMenuItem1})
        Me.LiberaçãoToolStripMenuItem.Name = "LiberaçãoToolStripMenuItem"
        Me.LiberaçãoToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.LiberaçãoToolStripMenuItem.Text = "Liberação"
        '
        'IncluirToolStripMenuItem1
        '
        Me.IncluirToolStripMenuItem1.Name = "IncluirToolStripMenuItem1"
        Me.IncluirToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.IncluirToolStripMenuItem1.Text = "Incluir"
        '
        'SelecionarToolStripMenuItem1
        '
        Me.SelecionarToolStripMenuItem1.Name = "SelecionarToolStripMenuItem1"
        Me.SelecionarToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.SelecionarToolStripMenuItem1.Text = "Selecionar "
        '
        'ControleDeAcessosToolStripMenuItem
        '
        Me.ControleDeAcessosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcessoToolStripMenuItem, Me.SelecionarHistoricoDeAcessosToolStripMenuItem})
        Me.ControleDeAcessosToolStripMenuItem.Name = "ControleDeAcessosToolStripMenuItem"
        Me.ControleDeAcessosToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.ControleDeAcessosToolStripMenuItem.Text = "Controle De Acessos"
        '
        'AcessoToolStripMenuItem
        '
        Me.AcessoToolStripMenuItem.Name = "AcessoToolStripMenuItem"
        Me.AcessoToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.AcessoToolStripMenuItem.Text = "Acesso"
        '
        'SelecionarHistoricoDeAcessosToolStripMenuItem
        '
        Me.SelecionarHistoricoDeAcessosToolStripMenuItem.Name = "SelecionarHistoricoDeAcessosToolStripMenuItem"
        Me.SelecionarHistoricoDeAcessosToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.SelecionarHistoricoDeAcessosToolStripMenuItem.Text = "Selecionar Historico de Acessos"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'FrmControleDeAcessoMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.Controls.Add(Me.MenuStrip)
        Me.ForeColor = System.Drawing.Color.Black
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmControleDeAcessoMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle De Acesso"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MnuTipo As ToolStripMenuItem
    Friend WithEvents PessoaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiberaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncluirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelecionarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ControleDeAcessosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcessoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarHistoricoDeAcessosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
