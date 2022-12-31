<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fattura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fattura))
        Me.Label63 = New System.Windows.Forms.Label
        Me.txtPIva = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.txtCap = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.txtProvincia = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.txtCitta = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTelefono1 = New System.Windows.Forms.TextBox
        Me.txtIndirizzo = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFattN = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPorto = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtProtocollo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOrdine = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDataOut = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.ricDescrizione = New System.Windows.Forms.TextBox
        Me.ricModPag = New System.Windows.Forms.RichTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPrezzo = New System.Windows.Forms.TextBox
        Me.btnSalvaRiga = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbRiga = New System.Windows.Forms.ComboBox
        Me.txtQuantità = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCodice = New System.Windows.Forms.TextBox
        Me.btnAnteprima = New System.Windows.Forms.Button
        Me.btnSalvaFattura = New System.Windows.Forms.Button
        Me.btnEsci = New System.Windows.Forms.Button
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(5, 126)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(61, 13)
        Me.Label63.TabIndex = 39
        Me.Label63.Text = "C. f./P. IVA"
        '
        'txtPIva
        '
        Me.txtPIva.Location = New System.Drawing.Point(71, 123)
        Me.txtPIva.Name = "txtPIva"
        Me.txtPIva.Size = New System.Drawing.Size(322, 20)
        Me.txtPIva.TabIndex = 12
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(17, 74)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(37, 13)
        Me.Label62.TabIndex = 37
        Me.Label62.Text = "C.A.P."
        '
        'txtCap
        '
        Me.txtCap.Location = New System.Drawing.Point(71, 71)
        Me.txtCap.Name = "txtCap"
        Me.txtCap.Size = New System.Drawing.Size(89, 20)
        Me.txtCap.TabIndex = 8
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(216, 100)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(51, 13)
        Me.Label53.TabIndex = 35
        Me.Label53.Text = "Provincia"
        '
        'txtProvincia
        '
        Me.txtProvincia.Location = New System.Drawing.Point(273, 97)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(120, 20)
        Me.txtProvincia.TabIndex = 11
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(169, 74)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(28, 13)
        Me.Label52.TabIndex = 34
        Me.Label52.Text = "Città"
        '
        'txtCitta
        '
        Me.txtCitta.Location = New System.Drawing.Point(206, 71)
        Me.txtCitta.Name = "txtCitta"
        Me.txtCitta.Size = New System.Drawing.Size(187, 20)
        Me.txtCitta.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Indirizzo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nome"
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(71, 97)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(139, 20)
        Me.txtTelefono1.TabIndex = 10
        '
        'txtIndirizzo
        '
        Me.txtIndirizzo.Location = New System.Drawing.Point(71, 45)
        Me.txtIndirizzo.Name = "txtIndirizzo"
        Me.txtIndirizzo.Size = New System.Drawing.Size(322, 20)
        Me.txtIndirizzo.TabIndex = 7
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(71, 19)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(322, 20)
        Me.txtNome.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Fattura N°"
        '
        'txtFattN
        '
        Me.txtFattN.Location = New System.Drawing.Point(81, 19)
        Me.txtFattN.Name = "txtFattN"
        Me.txtFattN.Size = New System.Drawing.Size(70, 20)
        Me.txtFattN.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label63)
        Me.GroupBox1.Controls.Add(Me.txtPIva)
        Me.GroupBox1.Controls.Add(Me.txtIndirizzo)
        Me.GroupBox1.Controls.Add(Me.Label53)
        Me.GroupBox1.Controls.Add(Me.Label62)
        Me.GroupBox1.Controls.Add(Me.txtProvincia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label52)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCap)
        Me.GroupBox1.Controls.Add(Me.txtCitta)
        Me.GroupBox1.Controls.Add(Me.txtTelefono1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 157)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFattN)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(518, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 52)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Numero Fattura"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtPorto)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtProtocollo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtOrdine)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtDataOut)
        Me.GroupBox3.Location = New System.Drawing.Point(456, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 157)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Porto"
        '
        'txtPorto
        '
        Me.txtPorto.Location = New System.Drawing.Point(87, 123)
        Me.txtPorto.Name = "txtPorto"
        Me.txtPorto.Size = New System.Drawing.Size(129, 20)
        Me.txtPorto.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Protocollo"
        '
        'txtProtocollo
        '
        Me.txtProtocollo.Location = New System.Drawing.Point(87, 88)
        Me.txtProtocollo.Name = "txtProtocollo"
        Me.txtProtocollo.Size = New System.Drawing.Size(129, 20)
        Me.txtProtocollo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Ordine N°"
        '
        'txtOrdine
        '
        Me.txtOrdine.Location = New System.Drawing.Point(87, 53)
        Me.txtOrdine.Name = "txtOrdine"
        Me.txtOrdine.Size = New System.Drawing.Size(129, 20)
        Me.txtOrdine.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Data"
        '
        'txtDataOut
        '
        Me.txtDataOut.Location = New System.Drawing.Point(87, 18)
        Me.txtDataOut.Name = "txtDataOut"
        Me.txtDataOut.Size = New System.Drawing.Size(129, 20)
        Me.txtDataOut.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEsci)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.btnSalvaFattura)
        Me.GroupBox4.Controls.Add(Me.ricDescrizione)
        Me.GroupBox4.Controls.Add(Me.btnAnteprima)
        Me.GroupBox4.Controls.Add(Me.ricModPag)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.btnSalvaRiga)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtPrezzo)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cmbRiga)
        Me.GroupBox4.Controls.Add(Me.txtQuantità)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtIVA)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtCodice)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 287)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(692, 171)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dati Fattura"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(382, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 26)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Modalità di " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pagamento"
        '
        'ricDescrizione
        '
        Me.ricDescrizione.Location = New System.Drawing.Point(188, 19)
        Me.ricDescrizione.Name = "ricDescrizione"
        Me.ricDescrizione.Size = New System.Drawing.Size(227, 20)
        Me.ricDescrizione.TabIndex = 1
        '
        'ricModPag
        '
        Me.ricModPag.Location = New System.Drawing.Point(449, 57)
        Me.ricModPag.Name = "ricModPag"
        Me.ricModPag.Size = New System.Drawing.Size(227, 26)
        Me.ricModPag.TabIndex = 7
        Me.ricModPag.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(126, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Descrizione"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(584, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Prezzo"
        '
        'txtPrezzo
        '
        Me.txtPrezzo.Location = New System.Drawing.Point(628, 19)
        Me.txtPrezzo.Name = "txtPrezzo"
        Me.txtPrezzo.Size = New System.Drawing.Size(51, 20)
        Me.txtPrezzo.TabIndex = 4
        '
        'btnSalvaRiga
        '
        Me.btnSalvaRiga.Location = New System.Drawing.Point(188, 54)
        Me.btnSalvaRiga.Name = "btnSalvaRiga"
        Me.btnSalvaRiga.Size = New System.Drawing.Size(171, 24)
        Me.btnSalvaRiga.TabIndex = 6
        Me.btnSalvaRiga.Text = "Salva riga fattura"
        Me.btnSalvaRiga.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Riga N°"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(416, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Quantità"
        '
        'cmbRiga
        '
        Me.cmbRiga.FormattingEnabled = True
        Me.cmbRiga.Location = New System.Drawing.Point(56, 57)
        Me.cmbRiga.Name = "cmbRiga"
        Me.cmbRiga.Size = New System.Drawing.Size(68, 21)
        Me.cmbRiga.TabIndex = 5
        '
        'txtQuantità
        '
        Me.txtQuantità.Location = New System.Drawing.Point(463, 19)
        Me.txtQuantità.Name = "txtQuantità"
        Me.txtQuantità.Size = New System.Drawing.Size(43, 20)
        Me.txtQuantità.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(513, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "IVA"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(539, 19)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(39, 20)
        Me.txtIVA.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Codice"
        '
        'txtCodice
        '
        Me.txtCodice.Location = New System.Drawing.Point(56, 19)
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(68, 20)
        Me.txtCodice.TabIndex = 0
        '
        'btnAnteprima
        '
        Me.btnAnteprima.Enabled = False
        Me.btnAnteprima.Location = New System.Drawing.Point(105, 114)
        Me.btnAnteprima.Name = "btnAnteprima"
        Me.btnAnteprima.Size = New System.Drawing.Size(124, 36)
        Me.btnAnteprima.TabIndex = 8
        Me.btnAnteprima.Text = "Anteprima e Stampa"
        Me.btnAnteprima.UseVisualStyleBackColor = True
        '
        'btnSalvaFattura
        '
        Me.btnSalvaFattura.Enabled = False
        Me.btnSalvaFattura.Location = New System.Drawing.Point(272, 114)
        Me.btnSalvaFattura.Name = "btnSalvaFattura"
        Me.btnSalvaFattura.Size = New System.Drawing.Size(124, 36)
        Me.btnSalvaFattura.TabIndex = 9
        Me.btnSalvaFattura.Text = "Salva Fattura"
        Me.btnSalvaFattura.UseVisualStyleBackColor = True
        '
        'btnEsci
        '
        Me.btnEsci.Location = New System.Drawing.Point(438, 114)
        Me.btnEsci.Name = "btnEsci"
        Me.btnEsci.Size = New System.Drawing.Size(124, 36)
        Me.btnEsci.TabIndex = 10
        Me.btnEsci.Text = "Esci"
        Me.btnEsci.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Client_Manager.My.Resources.Resources.Fattura
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(423, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Fattura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 473)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fattura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fattura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txtPIva As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txtCap As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtCitta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents txtIndirizzo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFattN As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDataOut As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPorto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProtocollo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOrdine As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCodice As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPrezzo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtQuantità As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents ricModPag As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAnteprima As System.Windows.Forms.Button
    Friend WithEvents cmbRiga As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnSalvaRiga As System.Windows.Forms.Button
    Friend WithEvents btnSalvaFattura As System.Windows.Forms.Button
    Friend WithEvents btnEsci As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ricDescrizione As System.Windows.Forms.TextBox
End Class
