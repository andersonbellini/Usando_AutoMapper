<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGerarMapeamento = New System.Windows.Forms.Button()
        Me.lbDados = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGerarMapeamento
        '
        Me.btnGerarMapeamento.Location = New System.Drawing.Point(28, 256)
        Me.btnGerarMapeamento.Name = "btnGerarMapeamento"
        Me.btnGerarMapeamento.Size = New System.Drawing.Size(354, 37)
        Me.btnGerarMapeamento.TabIndex = 0
        Me.btnGerarMapeamento.Text = "Gerar Mapeamento com o AutoMapper"
        Me.btnGerarMapeamento.UseVisualStyleBackColor = True
        '
        'lbDados
        '
        Me.lbDados.FormattingEnabled = True
        Me.lbDados.Location = New System.Drawing.Point(28, 41)
        Me.lbDados.Name = "lbDados"
        Me.lbDados.Size = New System.Drawing.Size(354, 199)
        Me.lbDados.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 305)
        Me.Controls.Add(Me.lbDados)
        Me.Controls.Add(Me.btnGerarMapeamento)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGerarMapeamento As System.Windows.Forms.Button
    Friend WithEvents lbDados As System.Windows.Forms.ListBox

End Class
