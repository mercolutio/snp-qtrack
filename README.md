# SNP QTrack - Labor Tracking System

Eine VB.NET Windows Forms Anwendung für Quality Management und Laborverwaltung mit dynamischen Formularen.

## Features

- **🔐 Sichere Datenbankverbindung**: Credentials werden verschlüsselt mit DPAPI gespeichert
- **📋 Prüfauftrag erfassen**: Dynamische Eingabemasken basierend auf Datenbankschema
- **🎨 Formular Designer**: Drag & Drop Editor für eigene Formulare
- **🔄 Auto-Generierung**: Formulare automatisch aus Datenbanktabellen generieren
- **💾 XML-Konfiguration**: Formulare als XML speichern und laden
- **🔧 Schweißnahtprüfung**: Spezialisiertes Modul für Schweißnahtdokumentation
- **📊 Datenvisualisierung**: Alle Daten in einem DataGridView darstellen
- **🔍 Auto-ID-Generierung**: Automatische Timestamp-basierte IDs für Prüfaufträge

## Voraussetzungen

- Visual Studio 2017 oder höher
- .NET Framework 4.7.2 oder höher
- MySQL Server (lokal oder remote)
- MySql.Data NuGet Package (wird automatisch installiert)

## Installation

1. **Projekt in Visual Studio öffnen**:
   - Öffne `MySQLDataViewer.vbproj` mit Visual Studio

2. **NuGet Pakete wiederherstellen**:
   - Visual Studio macht das automatisch beim ersten Build
   - Oder manuell: Rechtsklick auf Projekt → "NuGet-Pakete verwalten" → "Wiederherstellen"

3. **Projekt kompilieren**:
   - Drücke F5 oder klicke auf "Start"

## Verwendung

### Erste Schritte

1. **Anwendung starten**
2. **Datenbankeinstellungen konfigurieren**:
   - Beim ersten Start öffnet sich automatisch der Einstellungsdialog
   - Oder manuell über "Einstellungen..." Button

3. **Verbindungsdaten eingeben**:
   - **Server**: z.B. `localhost` oder IP-Adresse
   - **Port**: Standard ist `3306`
   - **Datenbank**: Name der MySQL-Datenbank
   - **Benutzer**: MySQL-Benutzername
   - **Passwort**: MySQL-Passwort (wird verschlüsselt gespeichert!)

4. **Verbindung testen**:
   - Klicke auf "Verbindung testen" um die Verbindung zu prüfen
   - Bei Erfolg wird die MySQL-Version angezeigt

5. **Einstellungen speichern**:
   - Klicke auf "Speichern"

### Daten anzeigen

1. **Tabellen laden**:
   - Klicke auf "Tabellen laden" um alle Tabellen aus der Datenbank zu laden

2. **Tabelle auswählen**:
   - Wähle eine Tabelle aus der Dropdown-Liste
   - Bei aktiviertem "Automatisch laden" werden die Daten sofort geladen

3. **Daten manuell laden**:
   - Klicke auf "Daten laden" um die Tabelle manuell zu laden

4. **Daten aktualisieren**:
   - Klicke auf den "↻" Button um die aktuellen Daten neu zu laden

### Daten exportieren

1. Lade eine Tabelle
2. Klicke auf "Nach CSV exportieren"
3. Wähle einen Speicherort
4. Die Daten werden als CSV-Datei (Semikolon-getrennt) gespeichert

## Sicherheit

### Verschlüsselung

- **DPAPI**: Das Passwort wird mit der Windows Data Protection API verschlüsselt
- **User-spezifisch**: Nur der aktuelle Windows-User kann das Passwort entschlüsseln
- **Maschinen-spezifisch**: Die Verschlüsselung funktioniert nur auf diesem PC

### Speicherort der Einstellungen

Die Credentials werden hier gespeichert:
```
C:\Users\[Benutzername]\AppData\Local\MySQLDataViewer\user.config
```

**Wichtig**: Das Passwort ist dort verschlüsselt, z.B.:
```xml
<setting name="DBPassword" serializeAs="String">
  <value>AQAAANCMnd8BFdERjHoAwE/Cl+sB...</value>
</setting>
```

## Projektstruktur

```
labtracking/
├── FormHauptmenu.vb                     # Hauptmenü
├── FormMain.vb                          # Datenvisualisierung
├── FormDatenEingabe.vb                  # Dynamische Eingabemaske
├── FormDatenbankEinstellungen.vb        # Einstellungsdialog
├── FormDesigner.vb                      # Drag & Drop Formular Designer
├── FormRenderer.vb                      # XML-basierte Formularanzeige
├── FormSchweissnahtpruefung.vb          # Schweißnahtprüfungs-Modul
├── FormularKonfiguration.vb             # XML-Serialisierung für Formulare
├── PasswordEncryption.vb                # DPAPI Verschlüsselung
├── MySQLDataViewer.vbproj               # Projektdatei
├── packages.config                      # NuGet Pakete
├── App.config                           # Konfiguration
└── My Project/
    ├── Application.myapp                # Application Settings
    ├── Settings.settings                # User Settings Definition
    └── AssemblyInfo.vb                  # Assembly Informationen
```

## Fehlerbehebung

### "MySql.Data nicht gefunden"
- Lösung: NuGet-Pakete wiederherstellen
- In Visual Studio: Tools → NuGet-Paket-Manager → Paket-Manager-Konsole
- Eingeben: `Install-Package MySql.Data`

### "Verbindung fehlgeschlagen"
- Prüfe ob MySQL Server läuft
- Prüfe Firewall-Einstellungen
- Prüfe ob der Benutzer Zugriffsrechte hat
- Prüfe ob die Datenbank existiert

### "Entschlüsselung fehlgeschlagen"
- Tritt auf, wenn die user.config von einem anderen User/PC kopiert wurde
- Lösung: Einstellungen neu eingeben

## Technische Details

- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms
- **Datenbank**: MySQL via MySql.Data
- **Verschlüsselung**: DPAPI (System.Security.Cryptography.ProtectedData)
- **Encoding**: UTF-8 für CSV Export

## Erweiterungsmöglichkeiten

Mögliche zukünftige Features:
- [ ] Suchfunktion im DataGridView
- [ ] Filterung von Spalten
- [ ] Bearbeiten von Daten (INSERT, UPDATE, DELETE)
- [ ] SQL-Query Editor
- [ ] Export in andere Formate (Excel, JSON)
- [ ] Mehrere Datenbankverbindungen verwalten
- [ ] Datenbank-Schema anzeigen

## Lizenz

Freie Verwendung für private und kommerzielle Zwecke.

## Support

Bei Fragen oder Problemen siehe Visual Studio Output Window für detaillierte Fehlermeldungen.
