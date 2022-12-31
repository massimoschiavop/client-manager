Public Class Magazzino

    Dim collegamentoTabella2 As adoNet
    Public bdsTabella2 As New BindingSource()
    Dim nuovoRecord As Boolean = False
    Dim messaggioDati As String
    Dim messaggioErrore As String

    Private Sub Magazzino_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'creo connessione adoNet
        adoNet.CreaConnessione(magazzinoDBPath)

        'creo i vari componenti per il collegamento al database
        collegamentoTabella2 = New adoNet("Tabella")
        collegamentoTabella2.LeggiTabella()
        bdsTabella2.DataSource = collegamentoTabella2.daTable

        'riempo la combo per Ricerca
        With Me.cmbFiltro.Items
            .Add("Descrizione")
            .Add("Codice")
            .Add("Alternativo")
            .Add("BoxNote")
        End With

        'imposto il primo campo 
        cmbFiltro.SelectedIndex = 0

        txtFiltro.Enabled = False

        Me.txtQuantita.DataBindings.Add("text", bdsTabella2, "Quantita")
        Me.ricDescrizione.DataBindings.Add("text", bdsTabella2, "Descrizione")
        Me.txtPosizione.DataBindings.Add("text", bdsTabella2, "Posizione")
        Me.txtCodice.DataBindings.Add("text", bdsTabella2, "Codice")
        Me.txtAlternativo.DataBindings.Add("text", bdsTabella2, "Alternativo")
        Me.txtPrezzo1.DataBindings.Add("text", bdsTabella2, "Prezzo1")
        Me.ricNote.DataBindings.Add("text", bdsTabella2, "BoxNote")
        Me.txtTotale.DataBindings.Add("text", bdsTabella2, "Totale")

        Me.txtQuantita.ReadOnly = True
        Me.ricDescrizione.ReadOnly = True
        Me.txtPosizione.ReadOnly = True
        Me.txtCodice.ReadOnly = True
        Me.txtAlternativo.ReadOnly = True
        Me.txtPrezzo1.ReadOnly = True
        Me.ricNote.ReadOnly = True
        Me.txtTotale.ReadOnly = True

        ' assegno come valore al datagrid quello del database
        dgvMagazzino.DataSource = bdsTabella2
    End Sub

    Private Sub pulisci()

        Me.txtQuantita.Text = ""
        Me.ricDescrizione.Text = ""
        Me.txtPosizione.Text = ""
        Me.txtCodice.Text = ""
        Me.txtAlternativo.Text = ""
        Me.txtPrezzo1.Text = ""
        Me.ricNote.Text = ""
        Me.txtTotale.Text = ""

    End Sub

    Private Sub btnNuovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovo.Click
        bdsTabella2.AddNew()
        btnNuovo.Enabled = False
        pulisci()
        nuovoRecord = True
        bottoneModifica()
    End Sub

    Private Sub btnCancella_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancella.Click
        'cancellazione record con if per chiedere conferma
        If MsgBox("Eliminare ?", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "Client Manager") = MsgBoxResult.Yes Then
            Try
                bdsTabella2.RemoveCurrent()
            Catch ex As Exception
                MsgBox("Errore durante la cancellazione. Controllare di aver selezionato un record o che sia presente nel database.", MsgBoxStyle.Critical, "Client Manager")
            End Try
        End If
        Me.dgvMagazzino.Refresh()  'aggiorno dgv
        collegamentoTabella2.Salva()   'aggiorno il db
    End Sub

    Private Sub bottoneModifica()
        'faccio la funzione per poretla eseguire subito dopo che faccio aggiungi record
        'almeno riesco a mettere scritta giusta
        If btnModifica.Text = "Modifica" Then
            If nuovoRecord = True Then
                btnModifica.Text = "Conferma"
                messaggioDati = "Dati inseriti correttamente."
                messaggioErrore = "Errore durante l'inserimento Dati"
                nuovoRecord = False
            Else
                messaggioDati = "Modifica eseguita correttamente."
                messaggioErrore = "Errore durante la modifica Dati."
                btnModifica.Text = "Conferma"
            End If

            Me.txtQuantita.ReadOnly = False
            Me.ricDescrizione.ReadOnly = False
            Me.txtPosizione.ReadOnly = False
            Me.txtCodice.ReadOnly = False
            Me.txtAlternativo.ReadOnly = False
            Me.txtPrezzo1.ReadOnly = False
            Me.ricNote.ReadOnly = False
            Me.txtTotale.ReadOnly = False
            btnNuovo.Enabled = False
            btnCancella.Enabled = False
        Else
            btnModifica.Text = "Modifica"
            Me.txtQuantita.ReadOnly = True
            Me.ricDescrizione.ReadOnly = True
            Me.txtPosizione.ReadOnly = True
            Me.txtCodice.ReadOnly = True
            Me.txtAlternativo.ReadOnly = True
            Me.txtPrezzo1.ReadOnly = True
            Me.ricNote.ReadOnly = True
            Me.txtTotale.ReadOnly = True
            Try
                With bdsTabella2
                    .Current("Quantita") = Me.txtQuantita.Text
                    .Current("Descrizione") = Me.ricDescrizione.Text
                    .Current("Posizione") = Me.txtPosizione.Text
                    .Current("Codice") = Me.txtCodice.Text
                    .Current("Alternativo") = Me.txtAlternativo.Text
                    .Current("Prezzo1") = Me.txtPrezzo1.Text
                    .Current("BoxNote") = Me.ricNote.Text
                    .Current("Totale") = Me.txtTotale.Text
                    .EndEdit()
                End With

                'refresh dgv e salvo su db
                dgvMagazzino.Refresh()
                collegamentoTabella2.Salva()
                MsgBox(messaggioDati, MsgBoxStyle.Information, "Client Manager")
                btnNuovo.Enabled = True
                btnCancella.Enabled = True
            Catch ex As Exception
                MsgBox(messaggioErrore, MsgBoxStyle.Critical, "Client Manager")
                collegamentoTabella2.LeggiTabella()
                bdsTabella2.DataSource = collegamentoTabella2.daTable
                btnNuovo.Enabled = True
                btnCancella.Enabled = True
            End Try
        End If
    End Sub

    Private Sub btnModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        bottoneModifica()
    End Sub

    Private Sub ricerca()
        Dim filtro As String

        'filtro con il LIKE per fare modo che non debba scrivere il nome completo ma anche solo la prima lettera e lui filtra in base
        'alla prima lettera 
        Try
            filtro = cmbFiltro.Text & " LIKE '%" & txtFiltro.Text & "%'"
            bdsTabella2.Filter = filtro
        Catch ex As Exception
            MsgBox("Errore durante la ricerca.", MsgBoxStyle.Critical, "Client Manager")
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged
        ricerca()
    End Sub

    Private Sub btnRicerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicerca.Click
        If Me.btnRicerca.Text = "Ricerca" Then
            btnRicerca.Text = "Finito"
            txtFiltro.Enabled = True
        Else
            Me.btnRicerca.Text = "Ricerca"
            txtFiltro.Enabled = False
            txtFiltro.Text = ""
            bdsTabella2.RemoveFilter()
        End If
    End Sub

    Private Sub txtTotale_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotale.Enter
        Dim quantita As Single
        Dim prezzo As Single
        Dim ris As Single

        quantita = CSng(Val(Me.txtQuantita.Text))
        prezzo = CSng(Val(Me.txtPrezzo1.Text))

        ris = CSng(prezzo * quantita)

        Me.txtTotale.Text = ris
    End Sub
End Class