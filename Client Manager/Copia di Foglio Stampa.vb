Imports Microsoft.Office.Interop

Public Class Foglio_Stampa2
    Dim ExApp As New Excel.Application
    Dim ExWb As Excel.Workbook
    Dim ExWorkSheet As Excel.Worksheet
    Dim pathSingolo As String = "C:\Programmi\Max\Client Manager\Modelli\PreventivoSingolo.xls"
    Dim pathSingolo2 As String = "C:\Programmi\Max\Client Manager\Modelli\tmpPreventivoSingolo.xls"
    Dim pathDoppio As String = "C:\Programmi\Max\Client Manager\Modelli\PreventivoDoppio.xls"
    Dim pathDoppio2 As String = "C:\Programmi\Max\Client Manager\Modelli\tmpPreventivoDoppio.xls"
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
        ExWorkSheet.Cells.Range("G2").Value = Form1.txtRipN2.Text
        ExWorkSheet.Cells.Range("G3").Value = Form1.txtDataIn2.Text
        ExWorkSheet.Cells.Range("G6").Value = Form1.txtNome2.Text
        ExWorkSheet.Cells.Range("G5").Value = Form1.txtCodCliente2.Text
        ExWorkSheet.Cells.Range("G7").Value = Form1.txtIndirizzo2.Text
        ExWorkSheet.Cells.Range("G8").Value = Form1.txtCitta2.Text
        ExWorkSheet.Cells.Range("G9").Value = Form1.txtProvincia2.Text
        ExWorkSheet.Cells.Range("G10").Value = Form1.txtTelefono12.Text
        ExWorkSheet.Cells.Range("G11").Value = Form1.txtTelefono22.Text
        ExWorkSheet.Cells.Range("A14").Value = Form1.txtMarca2.Text
        ExWorkSheet.Cells.Range("B14").Value = Form1.txtModello2.Text
        ExWorkSheet.Cells.Range("C14").Value = Form1.txtDataOut2.Text
        ExWorkSheet.Cells.Range("G14").Value = Form1.txtMatricola2.Text
        ExWorkSheet.Cells.Range("A17").Value = Form1.ricGuasto2.Text
        ExWorkSheet.Cells.Range("D17").Value = Form1.ricRipEs2.Text
        ExWorkSheet.Cells.Range("D28").Value = Form1.RicNote2.Text
        ExWorkSheet.Cells.Range("A28").Value = Form1.txtPRic2.Text & " €"
        ExWorkSheet.Cells.Range("A30").Value = Form1.txtPrevEs2.Text & " €"
        ExWorkSheet.Cells.Range("B28").Value = Form1.txtPMan2.Text & " €"
        ExWorkSheet.Cells.Range("A32").Value = Form1.txtPTot2.Text & " €"

        'seconda scheda
        ExWorkSheet.Cells.Range("G35").Value = Form1.txtRipN2.Text
        ExWorkSheet.Cells.Range("G36").Value = Form1.txtDataIn2.Text
        ExWorkSheet.Cells.Range("G39").Value = Form1.txtNome2.Text
        ExWorkSheet.Cells.Range("G38").Value = Form1.txtCodCliente2.Text
        ExWorkSheet.Cells.Range("G40").Value = Form1.txtIndirizzo2.Text
        ExWorkSheet.Cells.Range("G41").Value = Form1.txtCitta2.Text
        ExWorkSheet.Cells.Range("G42").Value = Form1.txtProvincia2.Text
        ExWorkSheet.Cells.Range("G43").Value = Form1.txtTelefono12.Text
        ExWorkSheet.Cells.Range("G44").Value = Form1.txtTelefono22.Text
        ExWorkSheet.Cells.Range("A47").Value = Form1.txtMarca2.Text
        ExWorkSheet.Cells.Range("B47").Value = Form1.txtModello2.Text
        ExWorkSheet.Cells.Range("C47").Value = Form1.txtDataOut2.Text
        ExWorkSheet.Cells.Range("G47").Value = Form1.txtMatricola2.Text
        ExWorkSheet.Cells.Range("A50").Value = Form1.ricGuasto2.Text
        ExWorkSheet.Cells.Range("D50").Value = Form1.ricRipEs2.Text
        ExWorkSheet.Cells.Range("A61").Value = Form1.txtPRic2.Text & " €"
        ExWorkSheet.Cells.Range("A63").Value = Form1.txtPrevEs2.Text & " €"
        ExWorkSheet.Cells.Range("B61").Value = Form1.txtPMan2.Text & " €"
        ExWorkSheet.Cells.Range("A65").Value = Form1.txtPTot2.Text & " €"
        ExWorkSheet.Cells.Range("D61").Value = Form1.RicNote2.Text

        ExWb.Save()

        Me.Hide()

        ExWorkSheet.PrintPreview()

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
                    End If
                End If
            Catch ex As Exception
                procedi = False
            End Try
        Loop While (procedi = False)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ExWb = ExApp.Workbooks.Open(pathSingolo)
        ExWorkSheet = ExWb.Worksheets(1)
        ExWb.SaveAs(pathSingolo2)
        ExWb.Close()
        ExApp.Quit()

        ExWb = ExApp.Workbooks.Open(pathSingolo2)
        ExApp.Visible = True
        ExWorkSheet = ExWb.Worksheets(1)
        ExWorkSheet.Cells.Range("G2").Value = Form1.txtRipN2.Text
        ExWorkSheet.Cells.Range("G3").Value = Form1.txtDataIn2.Text
        ExWorkSheet.Cells.Range("G6").Value = Form1.txtNome2.Text
        ExWorkSheet.Cells.Range("G5").Value = Form1.txtCodCliente2.Text
        ExWorkSheet.Cells.Range("G7").Value = Form1.txtIndirizzo2.Text
        ExWorkSheet.Cells.Range("G8").Value = Form1.txtCitta2.Text
        ExWorkSheet.Cells.Range("G9").Value = Form1.txtProvincia2.Text
        ExWorkSheet.Cells.Range("G10").Value = Form1.txtTelefono12.Text
        ExWorkSheet.Cells.Range("G11").Value = Form1.txtTelefono22.Text
        ExWorkSheet.Cells.Range("A14").Value = Form1.txtMarca2.Text
        ExWorkSheet.Cells.Range("B14").Value = Form1.txtModello2.Text
        ExWorkSheet.Cells.Range("C14").Value = Form1.txtDataOut2.Text
        ExWorkSheet.Cells.Range("G14").Value = Form1.txtMatricola2.Text
        ExWorkSheet.Cells.Range("A17").Value = Form1.ricGuasto2.Text
        ExWorkSheet.Cells.Range("D17").Value = Form1.ricRipEs2.Text
        ExWorkSheet.Cells.Range("D28").Value = Form1.RicNote2.Text
        ExWorkSheet.Cells.Range("A28").Value = Form1.txtPRic2.Text & " €"
        ExWorkSheet.Cells.Range("A30").Value = Form1.txtPrevEs2.Text & " €"
        ExWorkSheet.Cells.Range("B28").Value = Form1.txtPMan2.Text & " €"
        ExWorkSheet.Cells.Range("A32").Value = Form1.txtPTot2.Text & " €"

        ExWb.Save()

        Me.Hide()

        ExWorkSheet.PrintPreview()

        CancellazioneSingolo = True

        Me.Close()

    End Sub



    Private Sub Foglio_Stampa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CancellazioneSingolo = False
        CancellazioneDoppio = False
    End Sub
End Class