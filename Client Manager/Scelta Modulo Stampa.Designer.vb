<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Foglio_Stampa_Accettazione
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 13)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Personalizzato"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 53)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Accettazione"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Foglio_Stampa_Accettazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(173, 97)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimizeBox = False
        Me.Name = "Foglio_Stampa_Accettazione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stampa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
