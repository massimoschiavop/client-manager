<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Magazzino
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNuovo = New System.Windows.Forms.Button()
        Me.btnCancella = New System.Windows.Forms.Button()
        Me.btnModifica = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvMagazzino = New System.Windows.Forms.DataGridView()
        Me.txtPosizione = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotale = New System.Windows.Forms.TextBox()
        Me.ricNote = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlternativo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPrezzo1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodice = New System.Windows.Forms.TextBox()
        Me.ricDescrizione = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtQuantita = New System.Windows.Forms.TextBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRicerca = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMagazzino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnNuovo)
        Me.GroupBox1.Controls.Add(Me.btnCancella)
        Me.GroupBox1.Controls.Add(Me.btnModifica)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dgvMagazzino)
        Me.GroupBox1.Controls.Add(Me.txtPosizione)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTotale)
        Me.GroupBox1.Controls.Add(Me.ricNote)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAlternativo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtPrezzo1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCodice)
        Me.GroupBox1.Controls.Add(Me.ricDescrizione)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtQuantita)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 105)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(556, 445)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnNuovo
        '
        Me.btnNuovo.Location = New System.Drawing.Point(6, 208)
        Me.btnNuovo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNuovo.Name = "btnNuovo"
        Me.btnNuovo.Size = New System.Drawing.Size(113, 27)
        Me.btnNuovo.TabIndex = 9
        Me.btnNuovo.Text = "Inserisci"
        Me.btnNuovo.UseVisualStyleBackColor = True
        '
        'btnCancella
        '
        Me.btnCancella.Location = New System.Drawing.Point(248, 208)
        Me.btnCancella.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancella.Name = "btnCancella"
        Me.btnCancella.Size = New System.Drawing.Size(113, 27)
        Me.btnCancella.TabIndex = 11
        Me.btnCancella.Text = "Cancella"
        Me.btnCancella.UseVisualStyleBackColor = True
        '
        'btnModifica
        '
        Me.btnModifica.Location = New System.Drawing.Point(127, 208)
        Me.btnModifica.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(113, 27)
        Me.btnModifica.TabIndex = 10
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(417, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Posizione"
        '
        'dgvMagazzino
        '
        Me.dgvMagazzino.AllowUserToAddRows = False
        Me.dgvMagazzino.AllowUserToDeleteRows = False
        Me.dgvMagazzino.AllowUserToOrderColumns = True
        Me.dgvMagazzino.AllowUserToResizeRows = False
        Me.dgvMagazzino.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMagazzino.Location = New System.Drawing.Point(4, 244)
        Me.dgvMagazzino.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvMagazzino.Name = "dgvMagazzino"
        Me.dgvMagazzino.ReadOnly = True
        Me.dgvMagazzino.RowHeadersVisible = False
        Me.dgvMagazzino.Size = New System.Drawing.Size(548, 198)
        Me.dgvMagazzino.TabIndex = 14
        '
        'txtPosizione
        '
        Me.txtPosizione.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPosizione.Location = New System.Drawing.Point(482, 22)
        Me.txtPosizione.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPosizione.Name = "txtPosizione"
        Me.txtPosizione.Size = New System.Drawing.Size(65, 23)
        Me.txtPosizione.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(436, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Totale"
        '
        'txtTotale
        '
        Me.txtTotale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotale.Location = New System.Drawing.Point(482, 82)
        Me.txtTotale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTotale.Name = "txtTotale"
        Me.txtTotale.Size = New System.Drawing.Size(65, 23)
        Me.txtTotale.TabIndex = 7
        '
        'ricNote
        '
        Me.ricNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ricNote.Location = New System.Drawing.Point(76, 112)
        Me.ricNote.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ricNote.Name = "ricNote"
        Me.ricNote.Size = New System.Drawing.Size(472, 90)
        Me.ricNote.TabIndex = 8
        Me.ricNote.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Note"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Alternativo"
        '
        'txtAlternativo
        '
        Me.txtAlternativo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlternativo.Location = New System.Drawing.Point(76, 82)
        Me.txtAlternativo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAlternativo.Name = "txtAlternativo"
        Me.txtAlternativo.Size = New System.Drawing.Size(326, 23)
        Me.txtAlternativo.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(433, 55)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 15)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Prezzo"
        '
        'txtPrezzo1
        '
        Me.txtPrezzo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrezzo1.Location = New System.Drawing.Point(482, 52)
        Me.txtPrezzo1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPrezzo1.Name = "txtPrezzo1"
        Me.txtPrezzo1.Size = New System.Drawing.Size(65, 23)
        Me.txtPrezzo1.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 55)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Codice"
        '
        'txtCodice
        '
        Me.txtCodice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodice.Location = New System.Drawing.Point(76, 52)
        Me.txtCodice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(326, 23)
        Me.txtCodice.TabIndex = 4
        '
        'ricDescrizione
        '
        Me.ricDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ricDescrizione.Location = New System.Drawing.Point(214, 22)
        Me.ricDescrizione.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ricDescrizione.Name = "ricDescrizione"
        Me.ricDescrizione.Size = New System.Drawing.Size(188, 23)
        Me.ricDescrizione.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(139, 25)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 15)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Descrizione"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 25)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Quantità"
        '
        'txtQuantita
        '
        Me.txtQuantita.Location = New System.Drawing.Point(76, 22)
        Me.txtQuantita.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtQuantita.Name = "txtQuantita"
        Me.txtQuantita.Size = New System.Drawing.Size(48, 23)
        Me.txtQuantita.TabIndex = 1
        '
        'txtFiltro
        '
        Me.txtFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltro.Location = New System.Drawing.Point(410, 45)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(160, 23)
        Me.txtFiltro.TabIndex = 2
        '
        'cmbFiltro
        '
        Me.cmbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(410, 14)
        Me.cmbFiltro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(160, 23)
        Me.cmbFiltro.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Client_Manager.My.Resources.Resources.Magazzino
        Me.PictureBox1.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(388, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnRicerca
        '
        Me.btnRicerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRicerca.Location = New System.Drawing.Point(410, 74)
        Me.btnRicerca.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRicerca.Name = "btnRicerca"
        Me.btnRicerca.Size = New System.Drawing.Size(160, 27)
        Me.btnRicerca.TabIndex = 3
        Me.btnRicerca.Text = "Ricerca"
        Me.btnRicerca.UseVisualStyleBackColor = True
        '
        'Magazzino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 564)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.btnRicerca)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(600, 603)
        Me.Name = "Magazzino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazzino"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMagazzino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtQuantita As System.Windows.Forms.TextBox
    Friend WithEvents ricDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCodice As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPrezzo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAlternativo As System.Windows.Forms.TextBox
    Friend WithEvents ricNote As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvMagazzino As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotale As System.Windows.Forms.TextBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPosizione As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents btnCancella As System.Windows.Forms.Button
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents btnNuovo As System.Windows.Forms.Button
    Friend WithEvents btnRicerca As System.Windows.Forms.Button
End Class
