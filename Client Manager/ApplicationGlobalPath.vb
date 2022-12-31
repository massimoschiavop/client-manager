Imports System.IO

Module ApplicationGlobalPath

    'main path
    Public applicationFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Client Manager")
    Public databaseFolder As String = Path.Combine(applicationFolder, "Database")
    Public templatesFolder As String = Path.Combine(applicationFolder, "Modelli")
    Public documentSaveFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Client Manager")

    'templates path
    Public preventivoSingoloFile As String = Path.Combine(templatesFolder, "PreventivoSingolo.xls")
    Public preventivoSingoloTmp As String = Path.Combine(templatesFolder, "tmpPreventivoSingolo.xls")
    Public preventivoDoppioFile As String = Path.Combine(templatesFolder, "PreventivoDoppio.xls")
    Public preventivoDoppioTmp As String = Path.Combine(templatesFolder, "tmpPreventivoDoppio.xls")
    Public fatturaFile As String = Path.Combine(templatesFolder, "Fattura.xls")
    Public fatturaTmp As String = Path.Combine(templatesFolder, "TmpFattura.xls")

    'docs save path
    Public preventiviFolder As String = Path.Combine(documentSaveFolder, "Preventivi")
    Public fattureFolder As String = Path.Combine(documentSaveFolder, "Fatture")

    'databases
    Public elencoClientiDBPath As String = Path.Combine(databaseFolder, "ElencoClienti.mdb")
    Public magazzinoDBPath As String = Path.Combine(databaseFolder, "Magazzino.mdb")

End Module
