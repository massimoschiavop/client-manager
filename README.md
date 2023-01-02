## Client Manager
Scarica l'ultima versione:
- [Installer MSI - Client Manager 1.0.0](https://github.com/massimoschiavop/client-manager/blob/master/Installer/version-1.0.0/client-manager-1.0.0-setup.msi)
- [Installer EXE - Client Manager 1.0.0](https://github.com/massimoschiavop/client-manager/blob/master/Installer/version-1.0.0/client-manager-1.0.0-setup.exe)

## Installazione / Aggiornamento
1. Backup dei file "ElencoClienti.mdb" e "Magazzino.mdb" presenti sotto la cartella nascosta: "C:\Users\<utente>\AppData\Roaming\Client Manager\Database"
2. Lanciare l'eseguibile.

## Ripristino Database
Nel caso in cui fosse necessario ripristinare i Database precedenti, copiare i file "ElencoClienti.mdb" e "Magazzino.mdb" sotto la cartella nascosta "C:\Users\<utente>\AppData\Roaming\Client Manager\Database".

## Change Log
### Versione 1.0.0
- Rivista configurazione per generazione file di SETUP in modo da mantenere DB se già presenti
- Risolto BUG di assegnazione valore scheda se DB Vuoto
- Svuotati Database di Default
- Risolti bug visualizzazione Dialog per Windows 10
- Aggiunta compatibilità con Windows 10
- Aggiunto progetto creazione Setup
- Migrazione a Visual Studio 2022
