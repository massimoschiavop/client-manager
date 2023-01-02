Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Public Class DatiAccettazione
    Dim collegamentoTabella As adoNet
    Public bdsTabella As New BindingSource()
    Dim ExApp As New Excel.Application
    Dim ExWb As Excel.Workbook
    Dim ExWorkSheet As Excel.Worksheet
    Dim srNumeroScheda As StreamReader
    Dim swNumeroScheda As StreamWriter
    Dim SceltaStampa As Integer
    Dim modificaOn As Boolean = False
    Dim path As String = preventivoDoppioFile
    Dim path2 As String = preventivoDoppioTmp
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'durante la chiusura del programma controllo che non ci siano più processi excel aperti
        Dim PrcProcesso As System.Diagnostics.Process()
        Do
            PrcProcesso = Process.GetProcessesByName("EXCEL")
            If (PrcProcesso.Length > 0) Then
                PrcProcesso(0).Kill()
                System.Threading.Thread.Sleep(300)
            End If
        Loop While (PrcProcesso.Length > 0)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim valoreScheda As Integer = 1

        'disattiva filtro e imposta la data di oggi nella casella data in
        txtDataIn.Text = Date.Today
        txtFiltro.Enabled = False
        txtFiltro2.Enabled = False
        btnInserisci.Enabled = False

        'riempo la combo per Ricerca in elaborazione dati
        With cmbFiltro.Items
            .Add("Nome")
            .Add("Matricola")
            .Add("RipN")
            .Add("CodCliente")
            .Add("Modello")
            .Add("Marca")
            .Add("BoxNote")
            .Add("Telefono")
            .Add("Cellulare")
            .Add("Indirizzo")
        End With

        'riempo la combo per Ricerca in accettazione
        With cmbRicerca2.Items
            .Add("Nome")
            .Add("Matricola")
            .Add("RipN")
            .Add("CodCliente")
            .Add("Modello")
            .Add("Marca")
            .Add("BoxNote")
            .Add("Telefono")
            .Add("Cellulare")
            .Add("Indirizzo")
        End With

        'imposto il primo campo 
        cmbFiltro.SelectedIndex = 0
        cmbRicerca2.SelectedIndex = 0

        'inizializzo le cartelle per il salvataggio di Preventivi e fatture
        If Not Directory.Exists(documentSaveFolder) Then
            Directory.CreateDirectory(documentSaveFolder)
        End If
        If Not Directory.Exists(preventiviFolder) Then
            Directory.CreateDirectory(preventiviFolder)
        End If
        If Not Directory.Exists(fattureFolder) Then
            Directory.CreateDirectory(fattureFolder)
        End If

        'istruzioni per visualizzare i vari campi del database nelle apposite textbox
        Me.txtRipN2.DataBindings.Add("text", bdsTabella, "RipN")
        Me.txtNome2.DataBindings.Add("text", bdsTabella, "Nome")
        Me.txtCodCliente2.DataBindings.Add("text", bdsTabella, "CodCliente")
        Me.txtIndirizzo2.DataBindings.Add("text", bdsTabella, "Indirizzo")
        Me.txtCitta2.DataBindings.Add("text", bdsTabella, "Citta")
        Me.txtProvincia2.DataBindings.Add("text", bdsTabella, "Provincia")
        Me.txtCAP2.DataBindings.Add("text", bdsTabella, "CAP")
        Me.txtPIva2.DataBindings.Add("text", bdsTabella, "PartitaIva")
        Me.txtTelefono12.DataBindings.Add("text", bdsTabella, "Telefono")
        Me.txtTelefono22.DataBindings.Add("text", bdsTabella, "Cellulare")
        Me.txtMarca2.DataBindings.Add("text", bdsTabella, "Marca")
        Me.txtModello2.DataBindings.Add("text", bdsTabella, "Modello")
        Me.txtMatricola2.DataBindings.Add("text", bdsTabella, "Matricola")
        Me.txtDataIn2.DataBindings.Add("text", bdsTabella, "DataIn")
        Me.txtDataRip2.DataBindings.Add("text", bdsTabella, "DataRip")
        Me.txtDataOut2.DataBindings.Add("text", bdsTabella, "DataOut")
        Me.txtDC2.DataBindings.Add("text", bdsTabella, "DocFiscale")
        Me.RicNote2.DataBindings.Add("text", bdsTabella, "BoxNote")
        Me.ricGuasto2.DataBindings.Add("text", bdsTabella, "Guasto")
        Me.ricRipEs2.DataBindings.Add("text", bdsTabella, "RiparazioneEseguita")
        Me.txtPrevEs2.DataBindings.Add("text", bdsTabella, "PrevPerEs")
        Me.txtPRic2.DataBindings.Add("text", bdsTabella, "PrezzoRicambi")
        Me.txtPMan2.DataBindings.Add("text", bdsTabella, "PrezzoManodopera")
        Me.txtPTot2.DataBindings.Add("text", bdsTabella, "PrezzoTotale")

        'creo connessione adoNet
        adoNet.CreaConnessione(elencoClientiDBPath)

        'creo i vari componenti per il collegamento al database
        collegamentoTabella = New adoNet("Clienti")
        collegamentoTabella.LeggiTabella()
        bdsTabella.DataSource = collegamentoTabella.daTable
        bdsTabella.Sort = "RipN ASC"

        'assegno come valore al datagrid quello del database
        DgvClienti.DataSource = bdsTabella
        dgv1.DataSource = bdsTabella

        ' valorizzo campi numero scheda e matricola con quelli letti dal file
        If (dgv1.RowCount >= 1) Then
            valoreScheda = (From T In dgv1.Rows.Cast(Of DataGridViewRow)() Select CInt(T.Cells("RipN").Value)).Max + 1
        End If
        Me.txtRipN.Text = valoreScheda
        Me.txtMatricola.Text = valoreScheda

    End Sub

    Private Sub btnInserisci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserisci.Click
        If MsgBox("Vuoi confermare i dati?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Client Manager") = MsgBoxResult.Yes Then

            'inserimento con try per le eccezioni
            Try
                'creo e imposto il nuovo record
                With bdsTabella
                    .AddNew()
                    .Current("RipN") = Me.txtRipN.Text
                    .Current("Nome") = Me.txtNome.Text
                    .Current("CodCliente") = Me.TxtCodCliente.Text
                    .Current("Indirizzo") = Me.txtIndirizzo.Text
                    .Current("Citta") = Me.txtCitta.Text
                    .Current("Provincia") = Me.txtProvincia.Text
                    .Current("CAP") = Me.txtCap.Text
                    .Current("PartitaIva") = Me.txtPIva.Text
                    .Current("Telefono") = Me.txtTelefono1.Text
                    .Current("Cellulare") = Me.txtTelefono2.Text
                    .Current("Marca") = Me.txtMarca.Text
                    .Current("Modello") = Me.txtModello.Text
                    .Current("Matricola") = Me.txtMatricola.Text
                    .Current("DataIn") = Me.txtDataIn.Text
                    .Current("DataRip") = Me.txtDataRip.Text
                    .Current("DataOut") = Me.txtDataOut.Text
                    .Current("DocFiscale") = Me.txtDC.Text
                    .Current("Guasto") = Me.ricGuasto.Text
                    .Current("RiparazioneEseguita") = Me.ricRipEs.Text
                    .Current("PrevPerEs") = Me.txtPrevEs.Text
                    .Current("BoxNote") = Me.ricNote.Text
                    .Current("PrezzoRicambi") = Me.txtPRic.Text
                    .Current("PrezzoManodopera") = Me.txtPMan.Text
                    .Current("PrezzoTotale") = Me.txtPTot.Text
                    .EndEdit()
                End With

                'refresh dgv e salvo su db
                DgvClienti.Refresh()
                collegamentoTabella.Salva()
                MsgBox("Inserimento avvenuto correttamente.", MsgBoxStyle.Information, "Client Manager")

                If (MsgBox("Stampare scheda?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes) Then
                    Try
                        Kill(path2)
                    Catch ex1 As Exception
                    End Try
                    Foglio_Stampa.Show()
                End If

            Catch ex As Exception
                'se provoco eccezione gestita da try
                'ControllaCampi()
                MsgBox("Errore inserimento dati.", MsgBoxStyle.Critical, "Client Manager")
                'rifaccio il salvataggio delle tabelle per evitare di visualizzare due record uguali
                collegamentoTabella.LeggiTabella()
                bdsTabella.DataSource = collegamentoTabella.daTable
                Me.DgvClienti.Refresh()  'aggiorno dgv
            End Try
        End If
    End Sub

    Private Sub Pulisci()
        Dim valoreScheda As Integer = 1

        'metto data oggi
        Me.txtDataIn.Text = Date.Today

        Me.txtNome.Text = ""
        Me.TxtCodCliente.Text = ""
        Me.txtIndirizzo.Text = ""
        Me.txtCitta.Text = ""
        Me.txtProvincia.Text = ""
        Me.txtCap.Text = ""
        Me.txtPIva.Text = ""
        Me.txtTelefono1.Text = ""
        Me.txtTelefono2.Text = ""
        Me.txtMarca.Text = ""
        Me.txtModello.Text = ""
        Me.txtDataRip.Text = ""
        Me.txtDataOut.Text = ""
        Me.txtDC.Text = ""
        Me.ricNote.Text = ""
        Me.txtPrevEs.Text = ""
        Me.ricGuasto.Text = ""
        Me.ricRipEs.Text = ""
        Me.txtPRic.Text = ""
        Me.txtPMan.Text = ""
        Me.txtPTot.Text = ""

        ' valorizzo campi numero scheda e matricola con quelli letti dal file
        If (dgv1.RowCount >= 1) Then
            valoreScheda = (From T In dgv1.Rows.Cast(Of DataGridViewRow)() Select CInt(T.Cells("RipN").Value)).Max + 1
        End If
        Me.txtRipN.Text = valoreScheda
        Me.txtMatricola.Text = valoreScheda
    End Sub

    Private Sub btnCancella2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancella2.Click
        'cancellazione record con if per chiedere conferma
        If MsgBox("Eliminare ?", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "Client Manager") = MsgBoxResult.Yes Then
            Try
                bdsTabella.RemoveCurrent()
            Catch ex As Exception
                MsgBox("Errore durante la cancellazione. Controllare di aver selezionato un record o che sia presente nel database.", MsgBoxStyle.Critical, "Client Manager")
            End Try
        End If
        Me.DgvClienti.Refresh()  'aggiorno dgv
        collegamentoTabella.Salva()   'aggiorno il db
    End Sub

    Private Sub btnModifica2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica2.Click
        'tasto modifica che mette read only a true appena schiaccio e a false appena ho finito cambiando il testo del bottone 
        Try
            If btnModifica2.Text = "Modifica" Then
                btnModifica2.Text = "Conferma"
                Me.txtRipN2.ReadOnly = False
                Me.txtNome2.ReadOnly = False
                Me.txtCodCliente2.ReadOnly = False
                Me.txtIndirizzo2.ReadOnly = False
                Me.txtCitta2.ReadOnly = False
                Me.txtProvincia2.ReadOnly = False
                Me.txtCAP2.ReadOnly = False
                Me.txtPIva2.ReadOnly = False
                Me.txtTelefono12.ReadOnly = False
                Me.txtTelefono22.ReadOnly = False
                Me.txtMarca2.ReadOnly = False
                Me.txtModello2.ReadOnly = False
                Me.txtMatricola2.ReadOnly = False
                Me.txtDataIn2.ReadOnly = False
                Me.txtDataRip2.ReadOnly = False
                Me.txtDataOut2.ReadOnly = False
                Me.txtDC2.ReadOnly = False
                Me.txtPrevEs2.ReadOnly = False
                Me.RicNote2.ReadOnly = False
                Me.ricGuasto2.ReadOnly = False
                Me.ricRipEs2.ReadOnly = False
                Me.txtPRic2.ReadOnly = False
                Me.txtPMan2.ReadOnly = False
                Me.txtPTot2.ReadOnly = False

                btnAccettazione.Enabled = False
                btnAnteprima.Enabled = False
                btnCancella2.Enabled = False
                btnSalvaPrev.Enabled = False
                btnFattura.Enabled = False

                modificaOn = True

            Else
                btnModifica2.Text = "Modifica"
                Me.txtRipN2.ReadOnly = True
                Me.txtNome2.ReadOnly = True
                Me.txtCodCliente2.ReadOnly = True
                Me.txtIndirizzo2.ReadOnly = True
                Me.txtCitta2.ReadOnly = True
                Me.txtProvincia2.ReadOnly = True
                Me.txtCAP2.ReadOnly = True
                Me.txtPIva2.ReadOnly = True
                Me.txtTelefono12.ReadOnly = True
                Me.txtTelefono22.ReadOnly = True
                Me.txtMarca2.ReadOnly = True
                Me.txtModello2.ReadOnly = True
                Me.txtMatricola2.ReadOnly = True
                Me.txtDataIn2.ReadOnly = True
                Me.txtDataRip2.ReadOnly = True
                Me.txtDataOut2.ReadOnly = True
                Me.txtDC2.ReadOnly = True
                Me.txtPrevEs2.ReadOnly = True
                Me.RicNote2.ReadOnly = True
                Me.ricGuasto2.ReadOnly = True
                Me.ricRipEs2.ReadOnly = True
                Me.txtPRic2.ReadOnly = True
                Me.txtPMan2.ReadOnly = True
                Me.txtPTot2.ReadOnly = True

                btnAccettazione.Enabled = True
                btnAnteprima.Enabled = True
                btnCancella2.Enabled = True
                btnSalvaPrev.Enabled = True
                btnFattura.Enabled = True

                modificaOn = False

                'salvo i dati modificati nel db e refresh del dgv
                With bdsTabella
                    .Current("RipN") = Me.txtRipN2.Text
                    .Current("Nome") = Me.txtNome2.Text
                    .Current("CodCliente") = Me.txtCodCliente2.Text
                    .Current("Indirizzo") = Me.txtIndirizzo2.Text
                    .Current("Citta") = Me.txtCitta2.Text
                    .Current("Provincia") = Me.txtProvincia2.Text
                    .Current("CAP") = Me.txtCAP2.Text
                    .Current("PartitaIva") = Me.txtPIva2.Text
                    .Current("Telefono") = Me.txtTelefono12.Text
                    .Current("Cellulare") = Me.txtTelefono22.Text
                    .Current("Marca") = Me.txtMarca2.Text
                    .Current("Modello") = Me.txtModello2.Text
                    .Current("Matricola") = Me.txtMatricola2.Text
                    .Current("DataIn") = Me.txtDataIn2.Text
                    .Current("DataRip") = Me.txtDataRip2.Text
                    .Current("DataOut") = Me.txtDataOut2.Text
                    .Current("DocFiscale") = Me.txtDC2.Text
                    .Current("Guasto") = Me.ricGuasto2.Text
                    .Current("PrevPerEs") = Me.txtPrevEs2.Text
                    .Current("BoxNote") = Me.RicNote2.Text
                    .Current("RiparazioneEseguita") = Me.ricRipEs2.Text
                    .Current("PrezzoRicambi") = Me.txtPRic2.Text
                    .Current("PrezzoManodopera") = Me.txtPMan2.Text
                    .Current("PrezzoTotale") = Me.txtPTot2.Text
                    .EndEdit()
                End With

                DgvClienti.Refresh()
                collegamentoTabella.Salva()
                MsgBox("Modifica avvenuta correttamente.", MsgBoxStyle.Information, "Client Manager")
            End If
        Catch ex As Exception
            MsgBox("Errore durante la modifica dei dati controllare tutti i campi.", MsgBoxStyle.Critical, "Client Manager")
        End Try
    End Sub

    Private Sub btnFiltro2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro2.Click
        If Me.btnFiltro2.Text = "Ricerca" Then
            'attivo ricerca abilitando la textbox filtro che al cambiamento richiamerà la funzione filtro
            'e in oltre cambio il nome del pulsante in finito
            btnFiltro2.Text = "Finito"
            txtFiltro.Enabled = True
        Else
            'disattivo la ricerca, rinomino pulsante, disabilito txtfiltro e la pulisco
            'e inoltre rimuovo il filtro fatto con la funzione ricerca
            Me.btnFiltro2.Text = "Ricerca"
            txtFiltro.Enabled = False
            txtFiltro.Text = ""
            bdsTabella.RemoveFilter()
        End If
    End Sub

    Private Sub ricerca()
        Dim filtro As String

        'filtro con il LIKE per fare modo che non debba scrivere il nome completo ma anche solo la prima lettera e lui filtra in base
        'alla prima lettera 
        Try
            filtro = cmbFiltro.Text & " Like '%" & txtFiltro.Text & "%'"
            bdsTabella.Filter = filtro
        Catch ex As Exception
            MsgBox("Errore durante la ricerca.", MsgBoxStyle.Critical, "Client Manager")
        End Try
    End Sub

    Private Sub ricerca2()
        Dim filtro As String

        'filtro con il LIKE per fare modo che non debba scrivere il nome completo ma anche solo la prima lettera e lui filtra in base
        'alla prima lettera 
        Try
            filtro = cmbRicerca2.Text & " LIKE '%" & txtFiltro2.Text & "%'"
            bdsTabella.Filter = filtro
        Catch ex As Exception
            MsgBox("Errore durante la ricerca.", MsgBoxStyle.Critical, "Client Manager")
        End Try
    End Sub

    Private Sub ricerca3()
        Dim filtro As String

        'filtro con il LIKE per fare modo che non debba scrivere il nome completo ma anche solo la prima lettera e lui filtra in base
        'alla prima lettera 
        Try
            filtro = "Nome LIKE '%" & Me.txtNome.Text & "%'"
            bdsTabella.Filter = filtro
        Catch ex As Exception
            MsgBox("Errore durante la ricerca.", MsgBoxStyle.Critical, "Client Manager")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaPrev.Click
        'pulsante per salvare i preventivi
        Dim stringa As String

        'con questo apro il modello e lo salvo como modello temporaneo che se l'utente vorrà
        'potrà salvare nella cartella preventivi
        ExWb = ExApp.Workbooks.Open(path)
        ExWorkSheet = ExWb.Worksheets(1)
        ExWb.SaveAs(path2)
        ExWb.Close()
        ExApp.Quit()

        'apro preventivo temporaneo per copiare i dai delle textbox
        ExWb = ExApp.Workbooks.Open(path2)
        ExWorkSheet = ExWb.Worksheets(1)

        'copio dati in foglio excel
        ExWorkSheet.Cells.Range("G2").Value = txtRipN2.Text
        ExWorkSheet.Cells.Range("G3").Value = txtDataIn2.Text
        ExWorkSheet.Cells.Range("G6").Value = txtNome2.Text
        ExWorkSheet.Cells.Range("G5").Value = txtCodCliente2.Text
        ExWorkSheet.Cells.Range("G7").Value = txtIndirizzo2.Text
        ExWorkSheet.Cells.Range("G8").Value = txtCitta2.Text
        ExWorkSheet.Cells.Range("G9").Value = txtProvincia2.Text
        ExWorkSheet.Cells.Range("G10").Value = txtTelefono12.Text
        ExWorkSheet.Cells.Range("G11").Value = txtTelefono22.Text
        ExWorkSheet.Cells.Range("A14").Value = txtMarca2.Text
        ExWorkSheet.Cells.Range("B14").Value = txtModello2.Text
        ExWorkSheet.Cells.Range("C14").Value = txtDataRip2.Text
        ExWorkSheet.Cells.Range("G14").Value = txtMatricola2.Text
        ExWorkSheet.Cells.Range("D17").Value = ricGuasto2.Text
        ExWorkSheet.Cells.Range("A17").Value = ricRipEs2.Text
        ExWorkSheet.Cells.Range("D28").Value = RicNote2.Text
        ExWorkSheet.Cells.Range("A28").Value = txtPRic2.Text & " €"
        ExWorkSheet.Cells.Range("A30").Value = txtDataOut2.Text
        ExWorkSheet.Cells.Range("B28").Value = txtPrevEs2.Text & " €"
        ExWorkSheet.Cells.Range("A32").Value = txtDC2.Text
        ExWorkSheet.Cells.Range("B30").Value = txtPMan2.Text & " €"
        ExWorkSheet.Cells.Range("B32").Value = txtPTot2.Text & " €"

        'chiudo excel
        ExWb.Save()
        ExWb.Close()
        ExApp.Quit()

        'nome di default
        stringa = Me.txtRipN2.Text

        'controlli per i caratteri non accettati
        If stringa.Contains("/") = True Then
            MsgBox("Attenzione carattere non consentito.", MsgBoxStyle.Critical, "Client Manager")
        Else
            If stringa.Contains("\") = True Then
                MsgBox("Attenzione carattere non consentito.", MsgBoxStyle.Critical, "Client Manager")
            Else
                'apro file excel e save dialog
                ExWb = ExApp.Workbooks.Open(path2)
                ExWorkSheet = ExWb.Worksheets(1)

                With SFD
                    .FileName = "Preventivo N° " & Me.txtRipN2.Text & ".xls"
                    .Filter = "File Excel|*.xls"
                    .FilterIndex = 1
                    .InitialDirectory = preventiviFolder
                    If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                        ExWb.SaveAs(SFD.FileName)
                    End If
                End With
            End If
        End If
        'chiudo tutto e cancello il file temporaneo
        ExWb.Save()
        ExWb.Close()
        ExApp.Quit()
        Kill(path2)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFattura.Click
        'apro la form fattura
        Fattura.Show()
    End Sub

    Private Sub InserimentoDatiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'visualizzo la prima scheda 
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub ElaborazioneDatiToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'visualizzo la seconda scheda
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub txtPTot_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPTot.Enter
        'questa funzione si attiva appena si entra nella textbox
        Dim fatt1 As Single = Val(Me.txtPRic.Text)
        Dim fatt2 As Single = Val(Me.txtPMan.Text)
        Dim fatt3 As Single = Val(Me.txtPrevEs.Text)
        Dim ris As Single
        Dim pattern As String

        'con la regex controllo che siano immessi solo numeri indicando i caratteri non ammessi
        pattern = "[a-zA-Zàòèéùì’\-\+\\\*\,]"
        Dim mat As Match = Regex.Match(CStr(Me.txtPRic.Text), pattern)
        Dim mat2 As Match = Regex.Match(CStr(Me.txtPMan.Text), pattern)
        Dim mat3 As Match = Regex.Match(CStr(Me.txtPrevEs.Text), pattern)
        If mat.Success Then
            If mat2.Success Then
                If mat3.Success Then
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPMan.Text = "0.0"
                    Me.txtPRic.Text = "0.0"
                    Me.txtPrevEs.Text = "0.0"
                    Me.txtPTot.Text = CSng(fatt1 + fatt2 + fatt3)
                Else
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPMan.Text = "0.0"
                    Me.txtPRic.Text = "0.0"
                    Me.txtPTot.Text = CSng(fatt1 + fatt2 + fatt3)
                End If
            Else
                If mat3.Success Then
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPRic.Text = "0.0"
                    Me.txtPrevEs.Text = "0.0"
                    Me.txtPTot.Text = CSng(fatt1 + fatt2 + fatt3)
                Else
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPRic.Text = "0.0"
                    Me.txtPTot.Text = CSng(fatt1 + fatt2 + fatt3)
                End If
            End If
        Else
            If mat2.Success Then
                If mat3.Success Then
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPMan.Text = "0.0"
                    Me.txtPrevEs.Text = "0.0"
                    Me.txtPTot.Text = CSng(fatt1 + fatt2 + fatt3)
                Else
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPMan.Text = "0.0"
                    Me.txtPTot.Text = CSng(fatt1 + fatt2 + fatt3)
                End If
            Else
                If mat3.Success Then
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPrevEs.Text = "0.0"
                    Me.txtPTot.Text = CSng(fatt1 + fatt2 + fatt3)
                Else
                    Try
                        fatt1 = CSng(Val(Me.txtPMan.Text))
                        fatt2 = CSng(Val(Me.txtPRic.Text))
                        fatt3 = CSng(Val(Me.txtPrevEs.Text))
                    Catch ex As Exception
                        If Me.txtPRic.Text <> "" Then
                            If Me.txtPMan.Text <> "" Then
                                Me.txtPMan.Text = "0.0"
                            Else
                                Me.txtPrevEs.Text = "0.0"
                            End If
                        Else
                            Me.txtPRic.Text = "0.0"
                        End If
                    End Try
                    ris = fatt1 + fatt2 + fatt3
                    Me.txtPTot.Text = CSng(ris)

                    'faccio 2 volte per far calcolare di nuovo
                    Try
                        fatt1 = CSng(Val(Me.txtPMan.Text))
                        fatt2 = CSng(Val(Me.txtPRic.Text))
                        fatt3 = CSng(Val(Me.txtPrevEs.Text))
                    Catch ex As Exception
                        If Me.txtPRic.Text <> "" Then
                            If Me.txtPMan.Text <> "" Then
                                Me.txtPMan.Text = "0.0"
                            Else
                                Me.txtPrevEs.Text = "0.0"
                            End If
                        Else
                            Me.txtPRic.Text = "0.0"
                        End If
                    End Try
                    ris = fatt1 + fatt2 + fatt3
                    Me.btnInserisci.Enabled = True
                    Me.txtPTot.Text = CSng(ris)
                End If
            End If
        End If
    End Sub

    Private Sub txtFattura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPulisci.Click
        Pulisci()
        btnInserisci.Enabled = False
        bdsTabella.RemoveFilter()
    End Sub

    Private Sub txtPTot2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPTot2.Enter
        'identico all'altro calcolo del totale
        Dim fatt1 As Single = Val(Me.txtPRic2.Text)
        Dim fatt2 As Single = Val(Me.txtPMan2.Text)
        Dim fatt3 As Single = Val(Me.txtPrevEs2.Text)
        Dim ris As Single
        Dim pattern As String
        pattern = "[a-zA-Zàòèéùì’\-\+\\\*\,]"
        Dim mat As Match = Regex.Match(CStr(Me.txtPRic2.Text), pattern)
        Dim mat2 As Match = Regex.Match(CStr(Me.txtPMan2.Text), pattern)
        Dim mat3 As Match = Regex.Match(CStr(Me.txtPrevEs2.Text), pattern)
        If mat.Success Then
            If mat2.Success Then
                If mat3.Success Then
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPMan2.Text = "0.0"
                    Me.txtPRic2.Text = "0.0"
                    Me.txtPrevEs2.Text = "0.0"
                    Me.txtPTot2.Text = CSng(fatt1 + fatt2 + fatt3)
                Else
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPMan2.Text = "0.0"
                    Me.txtPRic2.Text = "0.0"
                    Me.txtPTot2.Text = CSng(fatt1 + fatt2 + fatt3)
                End If
            Else
                If mat3.Success Then
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPRic2.Text = "0.0"
                    Me.txtPrevEs2.Text = "0.0"
                    Me.txtPTot2.Text = CSng(fatt1 + fatt2 + fatt3)
                Else
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPRic2.Text = "0.0"
                    Me.txtPTot2.Text = CSng(fatt1 + fatt2 + fatt3)
                End If
            End If
        Else
            If mat2.Success Then
                If mat3.Success Then
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPMan2.Text = "0.0"
                    Me.txtPrevEs2.Text = "0.0"
                    Me.txtPTot2.Text = CSng(fatt1 + fatt2 + fatt3)
                Else
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPMan2.Text = "0.0"
                    Me.txtPTot2.Text = CSng(fatt1 + fatt2 + fatt3)
                End If
            Else
                If mat3.Success Then
                    MsgBox("Devi inserire solo valori numerici.", MsgBoxStyle.Critical, "Client Manager")
                    Me.txtPrevEs2.Text = "0.0"
                    Me.txtPTot2.Text = CSng(fatt1 + fatt2 + fatt3)
                Else
                    Try
                        fatt1 = CSng(Val(Me.txtPMan2.Text))
                        fatt2 = CSng(Val(Me.txtPRic2.Text))
                        fatt3 = CSng(Val(Me.txtPrevEs2.Text))
                    Catch ex As Exception
                        If Me.txtPRic2.Text <> "" Then
                            If Me.txtPMan2.Text <> "" Then
                                Me.txtPMan2.Text = "0.0"
                            Else
                                Me.txtPrevEs2.Text = "0.0"
                            End If
                        Else
                            Me.txtPRic2.Text = "0.0"
                        End If
                    End Try
                    ris = fatt1 + fatt2 + fatt3
                    Me.txtPTot2.Text = CSng(ris)

                    'faccio 2 volte per far calcolare di nuovo
                    Try
                        fatt1 = CSng(Val(Me.txtPMan2.Text))
                        fatt2 = CSng(Val(Me.txtPRic2.Text))
                        fatt3 = CSng(Val(Me.txtPrevEs2.Text))
                    Catch ex As Exception
                        If Me.txtPRic2.Text <> "" Then
                            If Me.txtPMan2.Text <> "" Then
                                Me.txtPMan2.Text = "0.0"
                            Else
                                Me.txtPrevEs2.Text = "0.0"
                            End If
                        Else
                            Me.txtPRic2.Text = "0.0"
                        End If
                    End Try
                    ris = fatt1 + fatt2 + fatt3
                    Me.btnAnteprima.Enabled = True
                    Me.btnSalvaPrev.Enabled = True
                    Me.btnModifica2.Enabled = True
                    Me.txtPTot2.Text = CSng(ris)
                End If
            End If
        End If
    End Sub


    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Foglio_Stampa.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnteprima.Click
        Try
            Kill(path2)
        Catch ex As Exception
        End Try
        Foglio_Stampa.Show()
    End Sub


    Private Sub txtPRic_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPRic.TextChanged
        Me.btnInserisci.Enabled = False
    End Sub

    Private Sub txtPMan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPMan.TextChanged
        Me.btnInserisci.Enabled = False
    End Sub


    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Magazzino.Show()
        bdsTabella.RemoveFilter()
    End Sub

    Private Sub txtPrevEs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevEs.TextChanged
        Me.btnInserisci.Enabled = False
    End Sub


    Private Sub txtPrevEs2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevEs2.TextChanged
        If modificaOn = True Then
            Me.btnAnteprima.Enabled = False
            Me.btnSalvaPrev.Enabled = False
            Me.btnModifica2.Enabled = False
        End If
    End Sub
    Private Sub txtPMan2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPMan2.TextChanged
        If modificaOn = True Then
            Me.btnAnteprima.Enabled = False
            Me.btnSalvaPrev.Enabled = False
            Me.btnModifica2.Enabled = False
        End If
    End Sub
    Private Sub txtPRic2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPRic2.TextChanged
        If modificaOn = True Then
            Me.btnAnteprima.Enabled = False
            Me.btnSalvaPrev.Enabled = False
            Me.btnModifica2.Enabled = False
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged
        ricerca()
    End Sub

    Private Sub btnElaborazione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElaborazione.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnAccettazione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccettazione.Click
        'pulsante per ricopiare dati cliente in accettazione
        TabControl1.SelectedIndex = 0
        Me.TxtCodCliente.Text = Me.txtCodCliente2.Text
        Me.txtNome.Text = Me.txtNome2.Text
        Me.txtIndirizzo.Text = Me.txtIndirizzo2.Text
        Me.txtTelefono1.Text = Me.txtTelefono12.Text
        Me.txtTelefono2.Text = Me.txtTelefono22.Text
        Me.txtCitta.Text = Me.txtCitta2.Text
        Me.txtProvincia.Text = Me.txtProvincia2.Text
        Me.txtCap.Text = Me.txtCAP2.Text
        Me.txtPIva.Text = Me.txtPIva2.Text
        Me.txtDataIn.Text = Date.Today
    End Sub

    Private Sub btnRicerca2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicerca2.Click
        If Me.btnRicerca2.Text = "Ricerca" Then
            'attivo ricerca abilitando la textbox filtro che al cambiamento richiamerà la funzione filtro
            'e in oltre cambio il nome del pulsante in finito
            btnRicerca2.Text = "Finito"
            txtFiltro2.Enabled = True
        Else
            'disattivo la ricerca, rinomino pulsante, disabilito txtfiltro e la pulisco
            'e inoltre rimuovo il filtro fatto con la funzione ricerca
            Me.btnRicerca2.Text = "Ricerca"
            txtFiltro2.Enabled = False
            txtFiltro2.Text = ""
            bdsTabella.RemoveFilter()
        End If
    End Sub

    Private Sub txtFiltro2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro2.TextChanged
        ricerca2()
    End Sub

    Private Sub btnCopiaDati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiaDati.Click
        Try
            Me.txtNome.Text = bdsTabella.Current("Nome")
            Me.txtIndirizzo.Text = bdsTabella.Current("Indirizzo")
            Me.txtCitta.Text = bdsTabella.Current("Citta")
            Me.txtProvincia.Text = bdsTabella.Current("Provincia")
            Me.txtCap.Text = bdsTabella.Current("CAP")
            Me.txtPIva.Text = bdsTabella.Current("PartitaIva")
            Me.txtTelefono1.Text = bdsTabella.Current("Telefono")
            Me.txtTelefono2.Text = bdsTabella.Current("Cellulare")
            Me.btnInserisci.Enabled = True

        Catch ex As Exception
            MsgBox("Il nome non accetta spazio finale.", MsgBoxStyle.Critical)
            Pulisci()
        End Try

    End Sub

    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        ricerca3()
    End Sub

    Private Sub stampaAccettazzione()
        Try
            ExWb = ExApp.Workbooks.Open(path)
            ExWorkSheet = ExWb.Worksheets(1)
            ExWb.SaveAs(path2)
            ExWb.Close()
            ExApp.Quit()

            ExWb = ExApp.Workbooks.Open(path2)
            ExApp.Visible = True
            ExWorkSheet = ExWb.Worksheets(1)
            ExWorkSheet.Cells.Range("G2").Value = txtRipN.Text
            ExWorkSheet.Cells.Range("G3").Value = txtDataIn.Text
            ExWorkSheet.Cells.Range("G6").Value = txtNome.Text
            ExWorkSheet.Cells.Range("G5").Value = TxtCodCliente.Text
            ExWorkSheet.Cells.Range("G7").Value = txtIndirizzo.Text
            ExWorkSheet.Cells.Range("G8").Value = txtCitta.Text
            ExWorkSheet.Cells.Range("G9").Value = txtProvincia.Text
            ExWorkSheet.Cells.Range("G10").Value = txtTelefono1.Text
            ExWorkSheet.Cells.Range("G11").Value = txtTelefono2.Text
            ExWorkSheet.Cells.Range("A14").Value = txtMarca.Text
            ExWorkSheet.Cells.Range("B14").Value = txtModello.Text
            ExWorkSheet.Cells.Range("C14").Value = txtDataRip.Text
            ExWorkSheet.Cells.Range("G14").Value = txtMatricola.Text
            ExWorkSheet.Cells.Range("D17").Value = ricGuasto.Text
            ExWorkSheet.Cells.Range("A17").Value = ricRipEs.Text
            ExWorkSheet.Cells.Range("D28").Value = ricNote.Text
            ExWorkSheet.Cells.Range("A28").Value = txtPRic.Text & " €"
            ExWorkSheet.Cells.Range("A30").Value = txtDataOut.Text
            ExWorkSheet.Cells.Range("B28").Value = txtPrevEs.Text & " €"
            ExWorkSheet.Cells.Range("A32").Value = txtDC.Text
            ExWorkSheet.Cells.Range("B30").Value = txtPMan.Text & " €"
            ExWorkSheet.Cells.Range("B32").Value = txtPTot.Text & " €"

            ExWb.Save()
            Me.Hide()
            ExWorkSheet.PrintPreview()
            ExApp.Quit()
        Catch ex As Exception
            MsgBox("Errore di stampa. Controllare che la stampante sia collegata e funzioni correttamente.", MsgBoxStyle.Critical)
            Try
                ExWb.Close()
                ExApp.Quit()
            Catch ex1 As Exception
            End Try
            Kill(path2)
        End Try
    End Sub

End Class


