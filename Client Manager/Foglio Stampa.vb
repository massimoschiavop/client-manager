Imports Microsoft.Office.Interop

Public Class Foglio_Stampa
    Dim ExApp As New Excel.Application
    Dim ExWb As Excel.Workbook
    Dim ExWorkSheet As Excel.Worksheet
    Dim pathSingolo As String = preventivoSingoloFile
    Dim pathSingolo2 As String = preventivoSingoloTmp
    Dim pathDoppio As String = preventivoDoppioFile
    Dim pathDoppio2 As String = preventivoDoppioTmp
    Dim CancellazioneSingolo As Boolean = False
    Dim CancellazioneDoppio As Boolean = False
    Dim procedi As Boolean = False

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ExWb = ExApp.Workbooks.Open(pathDoppio)
        ExWorkSheet = ExWb.Worksheets(1)
        ExWb.SaveAs(pathDoppio2)
        ExWb.Close()
        ExApp.Quit()

        ExWb = ExApp.Workbooks.Open(pathDoppio2)
        ExApp.Visible = True
        ExWorkSheet = ExWb.Worksheets(1)
        ExWorkSheet.Cells.Range("G2").Value = DatiAccettazione.txtRipN2.Text
        ExWorkSheet.Cells.Range("G3").Value = DatiAccettazione.txtDataIn2.Text
        ExWorkSheet.Cells.Range("G6").Value = DatiAccettazione.txtNome2.Text
        ExWorkSheet.Cells.Range("G5").Value = DatiAccettazione.txtCodCliente2.Text
        ExWorkSheet.Cells.Range("G7").Value = DatiAccettazione.txtIndirizzo2.Text
        ExWorkSheet.Cells.Range("G8").Value = DatiAccettazione.txtCitta2.Text
        ExWorkSheet.Cells.Range("G9").Value = DatiAccettazione.txtProvincia2.Text
        ExWorkSheet.Cells.Range("G10").Value = DatiAccettazione.txtTelefono12.Text
        ExWorkSheet.Cells.Range("G11").Value = DatiAccettazione.txtTelefono22.Text
        ExWorkSheet.Cells.Range("A14").Value = DatiAccettazione.txtMarca2.Text
        ExWorkSheet.Cells.Range("B14").Value = DatiAccettazione.txtModello2.Text
        ExWorkSheet.Cells.Range("C14").Value = DatiAccettazione.txtDataOut2.Text
        ExWorkSheet.Cells.Range("G14").Value = DatiAccettazione.txtMatricola2.Text
        ExWorkSheet.Cells.Range("A17").Value = DatiAccettazione.ricGuasto2.Text
        ExWorkSheet.Cells.Range("D17").Value = DatiAccettazione.ricRipEs2.Text
        ExWorkSheet.Cells.Range("D28").Value = DatiAccettazione.RicNote2.Text
        ExWorkSheet.Cells.Range("A28").Value = DatiAccettazione.txtPRic2.Text & " €"
        ExWorkSheet.Cells.Range("A30").Value = DatiAccettazione.txtPrevEs2.Text & " €"
        ExWorkSheet.Cells.Range("B28").Value = DatiAccettazione.txtPMan2.Text & " €"
        ExWorkSheet.Cells.Range("A32").Value = DatiAccettazione.txtPTot2.Text & " €"

        'seconda scheda
        ExWorkSheet.Cells.Range("G35").Value = DatiAccettazione.txtRipN2.Text
        ExWorkSheet.Cells.Range("G36").Value = DatiAccettazione.txtDataIn2.Text
        ExWorkSheet.Cells.Range("G39").Value = DatiAccettazione.txtNome2.Text
        ExWorkSheet.Cells.Range("G38").Value = DatiAccettazione.txtCodCliente2.Text
        ExWorkSheet.Cells.Range("G40").Value = DatiAccettazione.txtIndirizzo2.Text
        ExWorkSheet.Cells.Range("G41").Value = DatiAccettazione.txtCitta2.Text
        ExWorkSheet.Cells.Range("G42").Value = DatiAccettazione.txtProvincia2.Text
        ExWorkSheet.Cells.Range("G43").Value = DatiAccettazione.txtTelefono12.Text
        ExWorkSheet.Cells.Range("G44").Value = DatiAccettazione.txtTelefono22.Text
        ExWorkSheet.Cells.Range("A47").Value = DatiAccettazione.txtMarca2.Text
        ExWorkSheet.Cells.Range("B47").Value = DatiAccettazione.txtModello2.Text
        ExWorkSheet.Cells.Range("C47").Value = DatiAccettazione.txtDataOut2.Text
        ExWorkSheet.Cells.Range("G47").Value = DatiAccettazione.txtMatricola2.Text
        ExWorkSheet.Cells.Range("A50").Value = DatiAccettazione.ricGuasto2.Text
        ExWorkSheet.Cells.Range("D50").Value = DatiAccettazione.ricRipEs2.Text
        ExWorkSheet.Cells.Range("A61").Value = DatiAccettazione.txtPRic2.Text & " €"
        ExWorkSheet.Cells.Range("A63").Value = DatiAccettazione.txtPrevEs2.Text & " €"
        ExWorkSheet.Cells.Range("B61").Value = DatiAccettazione.txtPMan2.Text & " €"
        ExWorkSheet.Cells.Range("A65").Value = DatiAccettazione.txtPTot2.Text & " €"
        ExWorkSheet.Cells.Range("D61").Value = DatiAccettazione.RicNote2.Text

        ExWb.Save()

        Me.Hide()

        Try
            ExWorkSheet.PrintPreview()
        Catch ex As Exception
            MsgBox("Errore durante la stampa.", MsgBoxStyle.Critical)
        End Try

        CancellazioneDoppio = True

        Me.Close()

    End Sub

    Private Sub Foglio_Stampa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        ExApp.Quit()

        Do
            Try
                If CancellazioneSingolo = True Then
                    If CancellazioneDoppio = True Then
                        Kill(pathSingolo2)
                        Kill(pathDoppio2)
                        procedi = True
                    Else
                        Kill(pathSingolo2)
                        procedi = True
                    End If
                Else
                    If CancellazioneDoppio = True Then
                        Kill(pathDoppio2)
                        procedi = True
                    Else
                        procedi = True
                    End If
                End If
            Catch ex As Exception
                procedi = False
            End Try
        Loop While (procedi = False)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ExWb = ExApp.Workbooks.Open(pathSingolo)
            ExWorkSheet = ExWb.Worksheets(1)
            ExWb.SaveAs(pathSingolo2)
            ExWb.Close()
            ExApp.Quit()

            ExWb = ExApp.Workbooks.Open(pathSingolo2)
            ExApp.Visible = True
            ExWorkSheet = ExWb.Worksheets(1)
            ExWorkSheet.Cells.Range("G2").Value = DatiAccettazione.txtRipN2.Text
            ExWorkSheet.Cells.Range("G3").Value = DatiAccettazione.txtDataIn2.Text
            ExWorkSheet.Cells.Range("G6").Value = DatiAccettazione.txtNome2.Text
            ExWorkSheet.Cells.Range("G5").Value = DatiAccettazione.txtCodCliente2.Text
            ExWorkSheet.Cells.Range("G7").Value = DatiAccettazione.txtIndirizzo2.Text
            ExWorkSheet.Cells.Range("G8").Value = DatiAccettazione.txtCitta2.Text
            ExWorkSheet.Cells.Range("G9").Value = DatiAccettazione.txtProvincia2.Text
            ExWorkSheet.Cells.Range("G10").Value = DatiAccettazione.txtTelefono12.Text
            ExWorkSheet.Cells.Range("G11").Value = DatiAccettazione.txtTelefono22.Text
            ExWorkSheet.Cells.Range("A14").Value = DatiAccettazione.txtMarca2.Text
            ExWorkSheet.Cells.Range("B14").Value = DatiAccettazione.txtModello2.Text
            ExWorkSheet.Cells.Range("C14").Value = DatiAccettazione.txtDataRip2.Text
            ExWorkSheet.Cells.Range("G14").Value = DatiAccettazione.txtMatricola2.Text
            ExWorkSheet.Cells.Range("D17").Value = DatiAccettazione.ricGuasto2.Text
            ExWorkSheet.Cells.Range("A17").Value = DatiAccettazione.ricRipEs2.Text
            ExWorkSheet.Cells.Range("D28").Value = DatiAccettazione.RicNote2.Text
            ExWorkSheet.Cells.Range("A28").Value = DatiAccettazione.txtPRic2.Text & " €"
            ExWorkSheet.Cells.Range("A30").Value = DatiAccettazione.txtDataOut2.Text
            ExWorkSheet.Cells.Range("B28").Value = DatiAccettazione.txtPrevEs2.Text & " €"
            ExWorkSheet.Cells.Range("A32").Value = DatiAccettazione.txtDC2.Text
            ExWorkSheet.Cells.Range("B30").Value = DatiAccettazione.txtPMan2.Text & " €"
            ExWorkSheet.Cells.Range("B32").Value = DatiAccettazione.txtPTot2.Text & " €"


            ExWb.Save()

            Me.Hide()

            ExWorkSheet.PrintPreview()

            CancellazioneSingolo = True

            Me.Close()
        Catch ex As Exception
            MsgBox("Errore di stampa. Controllare che la stampante sia collegata e funzioni correttamente.", MsgBoxStyle.Critical)
            Try
                ExWb.Close()
                ExApp.Quit()
            Catch ex1 As Exception
            End Try
            Kill(pathSingolo2)
        End Try
    End Sub

    Private Sub Foglio_Stampa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CancellazioneSingolo = False
        CancellazioneDoppio = False
    End Sub
End Class