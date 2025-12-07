# Schnellstart-Anleitung

## Projekt in Visual Studio öffnen und kompilieren

### Variante 1: Mit Visual Studio (empfohlen)

1. **Visual Studio öffnen**
   - Starte Visual Studio 2017 oder höher

2. **Projekt öffnen**
   - Datei → Öffnen → Projekt/Projektmappe
   - Navigiere zu: `MySQLDataViewer.vbproj`
   - Klicke auf "Öffnen"

3. **NuGet Pakete wiederherstellen**
   - Visual Studio macht dies automatisch
   - Falls nicht: Rechtsklick auf Projekt → "NuGet-Pakete wiederherstellen"

4. **Kompilieren und Starten**
   - Drücke **F5** (oder klicke auf den grünen "Start"-Button)
   - Das Programm wird kompiliert und startet automatisch

5. **Executable finden**
   - Nach erfolgreichem Build findest du die EXE hier:
   - `bin\Debug\MySQLDataViewer.exe` (Debug-Version)
   - `bin\Release\MySQLDataViewer.exe` (Release-Version)

### Variante 2: Kommandozeile (ohne Visual Studio)

Wenn du Visual Studio installiert hast, kannst du auch per Kommandozeile kompilieren:

```bash
# Developer Command Prompt for VS öffnen, dann:
cd "C:\Pfad\zum\Projekt\MySQLDataViewer"

# NuGet Pakete wiederherstellen
nuget restore MySQLDataViewer.vbproj

# Projekt kompilieren
msbuild MySQLDataViewer.vbproj /p:Configuration=Release

# Programm starten
bin\Release\MySQLDataViewer.exe
```

## Erste Schritte nach dem Start

### 1. Datenbank-Verbindung einrichten

Beim ersten Start öffnet sich automatisch der Einstellungsdialog:

```
┌─────────────────────────────────────┐
│  Datenbank-Einstellungen            │
├─────────────────────────────────────┤
│  Server:     [localhost        ]    │
│  Port:       [3306]                 │
│  Datenbank:  [meine_db         ]    │
│  Benutzer:   [root             ]    │
│  Passwort:   [**********       ]    │
├─────────────────────────────────────┤
│  [Verbindung testen] [Speichern]    │
│                      [Abbrechen]    │
└─────────────────────────────────────┘
```

**Eingeben**:
- **Server**: `localhost` (oder IP deines MySQL-Servers)
- **Port**: `3306` (Standard MySQL-Port)
- **Datenbank**: Name deiner Datenbank
- **Benutzer**: Dein MySQL-Benutzername (z.B. `root`)
- **Passwort**: Dein MySQL-Passwort

**Wichtig**: Klicke auf "Verbindung testen" vor dem Speichern!

### 2. Daten anzeigen

Nach erfolgreicher Einrichtung:

1. **Tabellen laden**
   - Klicke auf "Tabellen laden"
   - Alle Tabellen deiner Datenbank werden geladen

2. **Tabelle auswählen**
   - Wähle eine Tabelle aus dem Dropdown
   - Daten werden automatisch angezeigt (wenn "Automatisch laden" aktiviert)

3. **Daten exportieren** (optional)
   - Klicke auf "Nach CSV exportieren"
   - Wähle Speicherort
   - Fertig!

## Häufige Probleme

### Problem: "MySql.Data konnte nicht gefunden werden"

**Lösung**:
```bash
# In Package Manager Console (Tools → NuGet-Paket-Manager → Paket-Manager-Konsole):
Install-Package MySql.Data -Version 8.0.33
```

### Problem: "Verbindung zur Datenbank fehlgeschlagen"

**Prüfe**:
1. Läuft MySQL Server?
   ```bash
   # Windows Services öffnen und "MySQL" suchen
   services.msc
   ```

2. Sind die Credentials korrekt?
   - Teste im MySQL Workbench oder Terminal

3. Hat der Benutzer Zugriffsrechte?
   ```sql
   -- In MySQL Terminal:
   SHOW GRANTS FOR 'dein_benutzer'@'localhost';
   ```

### Problem: Programm startet nicht

**Debug-Informationen anzeigen**:
- Kompiliere im Debug-Modus (F5 in Visual Studio)
- Schaue ins "Output"-Fenster (View → Output)

## Release-Version erstellen

Für die Produktiv-Nutzung erstelle eine Release-Version:

1. In Visual Studio: Build → Konfigurationsmanager
2. Aktive Projektmappenkonfiguration: **Release** auswählen
3. Build → Projektmappe erstellen
4. EXE findest du in: `bin\Release\MySQLDataViewer.exe`

**Diese EXE kannst du kopieren und auf anderen PCs verwenden!**

### Deployment-Hinweise

Die EXE benötigt:
- ✅ .NET Framework 4.7.2 (meist schon auf Windows installiert)
- ✅ MySql.Data.dll (wird mit der EXE kopiert)
- ✅ Zugriff auf den MySQL Server (Netzwerk/Firewall)

## Beispiel MySQL-Datenbank zum Testen

Falls du keine Datenbank hast, erstelle eine Testdatenbank:

```sql
-- MySQL Terminal oder Workbench:

CREATE DATABASE testdb;
USE testdb;

CREATE TABLE mitarbeiter (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100),
    abteilung VARCHAR(50),
    gehalt DECIMAL(10,2),
    eintrittsdatum DATE
);

INSERT INTO mitarbeiter (name, abteilung, gehalt, eintrittsdatum) VALUES
('Max Mustermann', 'IT', 4500.00, '2020-01-15'),
('Anna Schmidt', 'Marketing', 3800.00, '2019-05-20'),
('Tom Mueller', 'Vertrieb', 4200.00, '2021-03-10'),
('Lisa Wagner', 'IT', 5000.00, '2018-11-01');
```

Dann in der App:
- **Datenbank**: `testdb`
- **Benutzer**: `root` (oder dein MySQL-User)
- **Passwort**: dein MySQL-Passwort

Viel Erfolg! 🚀
