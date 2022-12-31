Imports Microsoft.Office.Interop
Public Class Fattura
    Dim ExApp2 As New Excel.Application
    Dim ExWb2 As Excel.Workbook
    Dim ExWorkSheet2 As Excel.Worksheet
    Dim path As String = fatturaFile
    Dim path2 As String = fatturaTmp

    Private Sub Fattura_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Kill(path2)
    End Sub

    Private Sub Fattura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        Me.txtDataOut.Text = Date.Today
        ExWb2 = ExApp2.Workbooks.Open(path)
        ExWorkSheet2 = ExWb2.Worksheets(1)
        ExWb2.SaveAs(fatturaTmp)
        ExWb2.Close()
        ExApp2.Quit()

        Me.btnAnteprima.Enabled = False
        Me.btnSalvaFattura.Enabled = False

        Me.txtNome.Text = DatiAccettazione.txtNome2.Text
        Me.txtIndirizzo.Text = DatiAccettazione.txtIndirizzo2.Text
        Me.txtCap.Text = DatiAccettazione.txtCAP2.Text
        Me.txtCitta.Text = DatiAccettazione.txtCitta2.Text
        Me.txtProvincia.Text = DatiAccettazione.txtProvincia2.Text
        Me.txtTelefono1.Text = DatiAccettazione.txtTelefono12.Text
        Me.txtPIva.Text = DatiAccettazione.txtPIva2.Text
        Me.txtPrezzo.Text = DatiAccettazione.txtPTot2.Text
        Me.txtFattN.Text = DatiAccettazione.txtDC2.Text
        Me.txtFattN.Text = DatiAccettazione.txtDC2.Text

        With cmbRiga.Items
            For i = 1 To 17
                .Add(i)
            Next
        End With
        cmbRiga.SelectedIndex() = 0

    End Sub

    Private Sub btnAnteprima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnteprima.Click
        ExWb2 = ExApp2.Workbooks.Open(path2)
        ExApp2.Visible = True
        ExWorkSheet2 = ExWb2.Worksheets(1)
        ExWorkSheet2.PrintPreview()
        ExWb2.Close()
        ExApp2.Quit()
    End Sub

    Private Sub SalvaRiga()
        Dim riga As Integer
        riga = cmbRiga.Text

        ExWb2 = ExApp2.Workbooks.Open(path2)
        ExWorkSheet2 = ExWb2.Worksheets(1)

        ExWorkSheet2.Cells.Range("J2").Value = Me.txtFattN.Text
        ExWorkSheet2.Cells.Range("B11").Value = Me.txtNome.Text
        ExWorkSheet2.Cells.Range("B12").Value = Me.txtIndirizzo.Text
        ExWorkSheet2.Cells.Range("B13").Value = Me.txtCap.Text
        ExWorkSheet2.Cells.Range("E13").Value = Me.txtCitta.Text
        ExWorkSheet2.Cells.Range("B14").Value = Me.txtTelefono1.Text
        ExWorkSheet2.Cells.Range("E14").Value = Me.txtProvincia.Text
        ExWorkSheet2.Cells.Range("B15").Value = Me.txtPIva.Text
        ExWorkSheet2.Cells.Range("A37").Value = Me.ricModPag.Text
        ExWorkSheet2.Cells.Range("J11").Value = Me.txtDataOut.Text
        ExWorkSheet2.Cells.Range("J12").Value = Me.txtOrdine.Text
        ExWorkSheet2.Cells.Range("J13").Value = Me.txtProtocollo.Text
        ExWorkSheet2.Cells.Range("J14").Value = Me.txtPorto.Text

        Select Case riga
            Case 1
                ExWorkSheet2.Cells.Range("A18").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B18").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G18").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H18").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I18").Value = Me.txtPrezzo.Text
            Case 2
                ExWorkSheet2.Cells.Range("A19").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B19").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G19").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H19").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I19").Value = Me.txtPrezzo.Text
            Case 3
                ExWorkSheet2.Cells.Range("A20").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B20").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G20").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H20").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I20").Value = Me.txtPrezzo.Text
            Case 4
                ExWorkSheet2.Cells.Range("A21").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B21").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G21").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H21").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I21").Value = Me.txtPrezzo.Text
            Case 5
                ExWorkSheet2.Cells.Range("A22").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B22").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G22").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H22").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I22").Value = Me.txtPrezzo.Text
            Case 6
                ExWorkSheet2.Cells.Range("A23").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B23").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G23").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H23").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I23").Value = Me.txtPrezzo.Text
            Case 7
                ExWorkSheet2.Cells.Range("A24").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B24").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G24").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H24").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I24").Value = Me.txtPrezzo.Text
            Case 8
                ExWorkSheet2.Cells.Range("A25").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B25").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G25").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H25").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I25").Value = Me.txtPrezzo.Text
            Case 9
                ExWorkSheet2.Cells.Range("A26").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B26").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G26").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H26").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I26").Value = Me.txtPrezzo.Text
            Case 10
                ExWorkSheet2.Cells.Range("A27").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B27").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G27").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H27").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I27").Value = Me.txtPrezzo.Text
            Case 11
                ExWorkSheet2.Cells.Range("A28").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B28").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G28").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H28").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I28").Value = Me.txtPrezzo.Text
            Case 12
                ExWorkSheet2.Cells.Range("A29").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B29").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G29").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H29").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I29").Value = Me.txtPrezzo.Text
            Case 13
                ExWorkSheet2.Cells.Range("A30").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B30").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G30").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H30").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I30").Value = Me.txtPrezzo.Text
            Case 14
                ExWorkSheet2.Cells.Range("A31").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B31").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G31").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H31").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I31").Value = Me.txtPrezzo.Text
            Case 15
                ExWorkSheet2.Cells.Range("A32").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B32").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G32").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H32").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I32").Value = Me.txtPrezzo.Text
            Case 16
                ExWorkSheet2.Cells.Range("A33").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B33").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G33").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H33").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I33").Value = Me.txtPrezzo.Text
            Case 17
                ExWorkSheet2.Cells.Range("A34").Value = Me.txtCodice.Text
                ExWorkSheet2.Cells.Range("B34").Value = Me.ricDescrizione.Text
                ExWorkSheet2.Cells.Range("G34").Value = Me.txtQuantità.Text
                ExWorkSheet2.Cells.Range("H34").Value = Me.txtIVA.Text
                ExWorkSheet2.Cells.Range("I34").Value = Me.txtPrezzo.Text
        End Select

        ExWb2.Save()
        ExWb2.Close()
        ExApp2.Quit()

    End Sub

    Private Sub btnSalvaRiga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaRiga.Click
        If Me.txtQuantità.Text <> "" Then
            If Me.txtPrezzo.Text <> "" Then
                If Me.txtIVA.Text <> "" Then
                    SalvaRiga()
                    If cmbRiga.SelectedIndex = 16 Then
                        cmbRiga.SelectedIndex = 0
                    Else
                        cmbRiga.SelectedIndex = cmbRiga.SelectedIndex + 1
                    End If
                    Me.btnAnteprima.Enabled = True
                    Me.btnSalvaFattura.Enabled = True
                Else
                    MsgBox("Devi completare anche il campo Iva.", MsgBoxStyle.Critical, "Client Manager")
                End If
            Else
                If Me.txtIVA.Text <> "" Then
                    MsgBox("Devi completare anche il campo Prezzo.", MsgBoxStyle.Critical, "Client Manager")
                Else
                    MsgBox("Devi completare anche i campi Prezzo e Iva.", MsgBoxStyle.Critical, "Client Manager")
                End If
            End If
        Else
            If Me.txtPrezzo.Text <> "" Then
                If txtIVA.Text <> "" Then
                    MsgBox("Devi completare anche i campi Quantità", MsgBoxStyle.Critical, "Client Manager")
                Else
                    MsgBox("Devi completare anche i campi Quantità e Iva", MsgBoxStyle.Critical, "Client Manager")
                End If
            Else
                If Me.txtIVA.Text <> "" Then
                    MsgBox("Devi completare anche i campi Quantità e Prezzo", MsgBoxStyle.Critical, "Client Manager")
                Else
                    SalvaRiga()
                    If cmbRiga.SelectedIndex = 16 Then
                        cmbRiga.SelectedIndex = 0
                    Else
                        cmbRiga.SelectedIndex = cmbRiga.SelectedIndex + 1
                    End If
                    Me.btnAnteprima.Enabled = True
                    Me.btnSalvaFattura.Enabled = True
                End If
            End If
        End If

    End Sub

    Private Sub cmbRiga_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRiga.SelectedIndexChanged
        Dim nRiga As Integer

        ricDescrizione.ReadOnly = False
        txtCodice.ReadOnly = False

        nRiga = cmbRiga.Text

        ExWb2 = ExApp2.Workbooks.Open(path2)
        ExWorkSheet2 = ExWb2.Worksheets(1)


        Select Case nRiga
            Case 1
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A18").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B18").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G18").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H18").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I18").Value
            Case 2
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A19").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B19").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G19").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H19").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I19").Value
            Case 3
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A20").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B20").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G20").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H20").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I20").Value
            Case 4
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A21").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B21").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G21").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H21").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I21").Value
            Case 5
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A22").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B22").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G22").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H22").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I22").Value
            Case 6
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A23").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B23").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G23").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H23").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I23").Value
            Case 7
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A24").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B24").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G24").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H24").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I24").Value
            Case 8
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A25").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B25").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G25").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H25").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I25").Value
            Case 9
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A26").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B26").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G26").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H26").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I26").Value
            Case 10
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A26").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B26").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G26").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H26").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I26").Value
            Case 11
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A27").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B27").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G27").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H27").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I27").Value
            Case 12
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A28").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B28").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G28").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H28").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I28").Value
            Case 13
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A29").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B29").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G29").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H29").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I29").Value
            Case 14
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A30").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B30").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G30").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H30").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I30").Value
            Case 15
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A31").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B31").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G31").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H31").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I31").Value
            Case 16
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A32").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B32").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G32").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H32").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I32").Value
            Case 17
                Me.txtCodice.Text = ExWorkSheet2.Cells.Range("A33").Value
                Me.ricDescrizione.Text = ExWorkSheet2.Cells.Range("B33").Value
                Me.txtQuantità.Text = ExWorkSheet2.Cells.Range("G33").Value
                Me.txtIVA.Text = ExWorkSheet2.Cells.Range("H33").Value
                Me.txtPrezzo.Text = ExWorkSheet2.Cells.Range("I33").Value
        End Select

        ExWb2.Save()
        ExWb2.Close()
        ExApp2.Quit()
    End Sub

    Private Sub btnEsci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEsci.Click
        Me.Close()
    End Sub

    Private Sub btnSalvaFattura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaFattura.Click
        Dim stringa As String
        stringa = Me.txtFattN.Text
        If stringa.Contains("/") = True Then
            MsgBox("Attenzione carattere non consentito in Fattura N°.", MsgBoxStyle.Critical, "Client Manager")
        Else
            If stringa.Contains("\") = True Then
                MsgBox("Attenzione carattere non consentito Fattura N°.", MsgBoxStyle.Critical, "Client Manager")
            Else
                ExWb2 = ExApp2.Workbooks.Open(path2)
                ExWorkSheet2 = ExWb2.Worksheets(1)
                With SFD
                    .FileName = "Fattura N° " & Me.txtFattN.Text & ".xls"
                    .Filter = "File Excel|*.xls"
                    .FilterIndex = 1
                    .InitialDirectory = fattureFolder
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        ExWb2.SaveAs(SFD.FileName)
                    End If
                End With
                ExWb2.Close()
                ExApp2.Quit()
            End If
        End If
    End Sub

    Private Sub ricDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ricDescrizione.TextChanged
        Dim i As Integer
        Dim stringa As String
        i = 51


        If ricDescrizione.TextLength >= i Then
            MsgBox("Spazio sulla prima riga terminato. Schiacciare tasto Salva Riga o premere semplicemente Invio sulla tastiera.", MsgBoxStyle.Exclamation, "Client Manager")
            stringa = ricDescrizione.Text
            stringa = stringa.Remove(stringa.Length - 1)
            ricDescrizione.Text = stringa
            ricDescrizione.ReadOnly = True
            Me.AcceptButton = btnSalvaRiga
        End If
    End Sub

   
    Private Sub txtCodice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodice.TextChanged
        Dim i As Integer
        Dim stringa As String
        i = 15

        If txtCodice.TextLength >= i Then
            MsgBox("Spazio sulla prima riga terminato. Schiacciare tasto Salva Riga o premere semplicemente Invio sulla tastiera.", MsgBoxStyle.Exclamation, "Client Manager")
            stringa = txtCodice.Text
            stringa = stringa.Remove(stringa.Length - 1)
            txtCodice.Text = stringa
            txtCodice.ReadOnly = True
            Me.AcceptButton = btnSalvaRiga
        End If
    End Sub

End Class