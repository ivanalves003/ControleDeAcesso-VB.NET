<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAcesso
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
        Me.LblCodigoPessoa = New C1.Win.C1Input.C1TextBox()
        Me.LblCodigo = New C1.Win.C1Input.C1Label()
        Me.BtnIncluir = New C1.Win.C1Input.C1Button()
        Me.C1SuperLabel = New C1.Win.C1SuperTooltip.C1SuperLabel()
        Me.C1Label1 = New C1.Win.C1Input.C1Label()
        Me.C1Label2 = New C1.Win.C1Input.C1Label()
        CType(Me.C1Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCodigoPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Button3
        '
        Me.C1Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.C1Button3.Location = New System.Drawing.Point(26, 106)
        Me.C1Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.C1Button3.Name = "C1Button3"
        Me.C1Button3.Size = New System.Drawing.Size(109, 36)
        Me.C1Button3.TabIndex = 384
        Me.C1Button3.Text = "&Entrada"
        Me.C1Button3.UseVisualStyleBackColor = True
        Me.C1Button3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Button3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'LblCodigoPessoa
        '
        Me.LblCodigoPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCodigoPessoa.Location = New System.Drawing.Point(109, 54)
        Me.LblCodigoPessoa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblCodigoPessoa.Name = "LblCodigoPessoa"
        Me.LblCodigoPessoa.Size = New System.Drawing.Size(66, 18)
        Me.LblCodigoPessoa.TabIndex = 376
        Me.LblCodigoPessoa.Tag = Nothing
        Me.LblCodigoPessoa.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.LblCodigoPessoa.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblCodigo.Location = New System.Drawing.Point(123, 38)
        Me.LblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.LblCodigo.TabIndex = 375
        Me.LblCodigo.Tag = Nothing
        Me.LblCodigo.Text = "Código"
        Me.LblCodigo.TextDetached = True
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnIncluir.Location = New System.Drawing.Point(152, 106)
        Me.BtnIncluir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(109, 36)
        Me.BtnIncluir.TabIndex = 373
        Me.BtnIncluir.Text = "&Saída"
        Me.BtnIncluir.UseVisualStyleBackColor = True
        Me.BtnIncluir.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.BtnIncluir.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1SuperLabel
        '
        Me.C1SuperLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1SuperLabel.Location = New System.Drawing.Point(41, 0)
        Me.C1SuperLabel.Name = "C1SuperLabel"
        Me.C1SuperLabel.Size = New System.Drawing.Size(202, 35)
        Me.C1SuperLabel.TabIndex = 385
        Me.C1SuperLabel.Text = "Controle De Acesso"
        Me.C1SuperLabel.UseMnemonic = True
        '
        'C1Label1
        '
        Me.C1Label1.AutoSize = True
        Me.C1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label1.Location = New System.Drawing.Point(53, 90)
        Me.C1Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.C1Label1.Name = "C1Label1"
        Me.C1Label1.Size = New System.Drawing.Size(39, 13)
        Me.C1Label1.TabIndex = 386
        Me.C1Label1.Tag = Nothing
        Me.C1Label1.Text = "Liberar"
        Me.C1Label1.TextDetached = True
        '
        'C1Label2
        '
        Me.C1Label2.AutoSize = True
        Me.C1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label2.Location = New System.Drawing.Point(189, 90)
        Me.C1Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.C1Label2.Name = "C1Label2"
        Me.C1Label2.Size = New System.Drawing.Size(39, 13)
        Me.C1Label2.TabIndex = 387
        Me.C1Label2.Tag = Nothing
        Me.C1Label2.Text = "Liberar"
        Me.C1Label2.TextDetached = True
        '
        'FrmAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 178)
        Me.Controls.Add(Me.C1Label2)
        Me.Controls.Add(Me.C1Label1)
        Me.Controls.Add(Me.C1SuperLabel)
        Me.Controls.Add(Me.C1Button3)
        Me.Controls.Add(Me.LblCodigoPessoa)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.BtnIncluir)
        Me.Name = "FrmAcesso"
        Me.Text = "FrmAcesso"
        CType(Me.C1Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCodigoPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnIncluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Button3 As C1.Win.C1Input.C1Button
    Friend WithEvents LblCodigoPessoa As C1.Win.C1Input.C1TextBox
    Friend WithEvents LblCodigo As C1.Win.C1Input.C1Label
    Friend WithEvents BtnIncluir As C1.Win.C1Input.C1Button
    Friend WithEvents C1SuperLabel As C1.Win.C1SuperTooltip.C1SuperLabel
    Friend WithEvents C1Label1 As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label2 As C1.Win.C1Input.C1Label
End Class
