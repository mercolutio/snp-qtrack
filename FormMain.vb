Imports MySql.Data.MySqlClient

Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Beim Start prüfen ob Datenbankeinstellungen vorhanden sind
        If String.IsNullOrEmpty(My.Settings.DBServer) OrElse
           String.IsNullOrEmpty(My.Settings.DBName) Then

            MessageBox.Show("Bitte konfigurieren Sie zuerst die Datenbankverbindung.",
                          "Einstellungen erforderlich",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information)
            EinstellungenAnzeigen()
        End If

        ' Status initialisieren
        lblStatus.Text = "Bereit"
    End Sub

    Private Sub btnEinstellungen_Click(sender As Object, e As EventArgs) Handles btnEinstellungen.Click
        EinstellungenAnzeigen()
    End Sub

    Private Sub EinstellungenAnzeigen()
        Dim formEinstellungen As New FormDatenbankEinstellungen()
        If formEinstellungen.ShowDialog() = DialogResult.OK Then
            lblStatus.Text = "Einstellungen gespeichert - Bereit zum Laden"
        End If
    End Sub

    Private Function GetConnectionString() As String
        Try
            ' Passwort beim Verwenden entschlüsseln
            Dim decryptedPassword As String = String.Empty
            If Not String.IsNullOrEmpty(My.Settings.DBPassword) Then
                decryptedPassword = PasswordEncryption.Decrypt(My.Settings.DBPassword)
            End If

            Return String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};",
                               My.Settings.DBServer,
                               My.Settings.DBPort,
                               My.Settings.DBName,
                               My.Settings.DBUser,
                               decryptedPassword)

        Catch ex As Exception
            Throw New Exception("Fehler beim Erstellen der Verbindung: " & ex.Message, ex)
        End Try
    End Function

    Private Sub btnDatenLaden_Click(sender As Object, e As EventArgs) Handles btnDatenLaden.Click
        ' Prüfen ob Tabelle ausgewählt wurde
        If cboTabellen.SelectedItem Is Nothing Then
            MessageBox.Show("Bitte wählen Sie zuerst eine Tabelle aus!",
                          "Tabelle auswählen",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
            Return
        End If

        DatenLaden(cboTabellen.SelectedItem.ToString())
    End Sub

    Private Sub btnTabellenLaden_Click(sender As Object, e As EventArgs) Handles btnTabellenLaden.Click
        TabellenLaden()
    End Sub

    Private Sub TabellenLaden()
        lblStatus.Text = "Lade Tabellen..."
        Me.Cursor = Cursors.WaitCursor
        btnTabellenLaden.Enabled = False

        Try
            Using connection As New MySqlConnection(GetConnectionString())
                connection.Open()

                ' Tabellennamen aus der Datenbank abrufen
                Dim query As String = "SHOW TABLES"
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                cboTabellen.Items.Clear()

                While reader.Read()
                    cboTabellen.Items.Add(reader(0).ToString())
                End While

                reader.Close()

                If cboTabellen.Items.Count > 0 Then
                    cboTabellen.SelectedIndex = 0
                    lblStatus.Text = cboTabellen.Items.Count & " Tabellen gefunden"
                Else
                    lblStatus.Text = "Keine Tabellen gefunden"
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Fehler beim Laden der Tabellen:" & vbCrLf & vbCrLf &
                          "Fehler: " & ex.Message & vbCrLf &
                          "Code: " & ex.Number,
                          "Datenbankfehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            lblStatus.Text = "Fehler beim Laden"

        Catch ex As Exception
            MessageBox.Show("Fehler beim Laden der Tabellen:" & vbCrLf & vbCrLf & ex.Message,
                          "Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            lblStatus.Text = "Fehler"

        Finally
            Me.Cursor = Cursors.Default
            btnTabellenLaden.Enabled = True
        End Try
    End Sub

    Private Sub DatenLaden(tabellenname As String)
        lblStatus.Text = "Lade Daten aus " & tabellenname & "..."
        Me.Cursor = Cursors.WaitCursor
        btnDatenLaden.Enabled = False

        Try
            Using connection As New MySqlConnection(GetConnectionString())
                connection.Open()

                ' Sichere Query mit Backticks für Tabellennamen
                Dim query As String = String.Format("SELECT * FROM `{0}`", tabellenname)
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                ' DataGridView befüllen
                dgvDaten.DataSource = dataTable

                ' Spalten formatieren
                For Each column As DataGridViewColumn In dgvDaten.Columns
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next

                ' Status aktualisieren
                lblAnzahl.Text = "Zeilen: " & dataTable.Rows.Count.ToString()
                lblStatus.Text = dataTable.Rows.Count & " Datensätze geladen"

            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Fehler beim Laden der Daten:" & vbCrLf & vbCrLf &
                          "Fehler: " & ex.Message & vbCrLf &
                          "Code: " & ex.Number,
                          "Datenbankfehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            lblStatus.Text = "Fehler beim Laden"

        Catch ex As Exception
            MessageBox.Show("Fehler beim Laden der Daten:" & vbCrLf & vbCrLf & ex.Message,
                          "Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            lblStatus.Text = "Fehler"

        Finally
            Me.Cursor = Cursors.Default
            btnDatenLaden.Enabled = True
        End Try
    End Sub

    Private Sub cboTabellen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTabellen.SelectedIndexChanged
        ' Automatisch Daten laden wenn Checkbox aktiviert ist
        If chkAutoLaden.Checked AndAlso cboTabellen.SelectedItem IsNot Nothing Then
            DatenLaden(cboTabellen.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnExportieren_Click(sender As Object, e As EventArgs) Handles btnExportieren.Click
        If dgvDaten.Rows.Count = 0 Then
            MessageBox.Show("Keine Daten zum Exportieren vorhanden!",
                          "Export",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
            Return
        End If

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "CSV Datei (*.csv)|*.csv|Alle Dateien (*.*)|*.*"
        saveDialog.DefaultExt = "csv"
        saveDialog.FileName = "export_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            ExportierenNachCSV(saveDialog.FileName)
        End If
    End Sub

    Private Sub ExportierenNachCSV(dateipfad As String)
        Try
            Using writer As New System.IO.StreamWriter(dateipfad, False, System.Text.Encoding.UTF8)
                ' Spaltenüberschriften
                Dim headers As New List(Of String)
                For Each column As DataGridViewColumn In dgvDaten.Columns
                    headers.Add(column.HeaderText)
                Next
                writer.WriteLine(String.Join(";", headers))

                ' Datenzeilen
                For Each row As DataGridViewRow In dgvDaten.Rows
                    If Not row.IsNewRow Then
                        Dim values As New List(Of String)
                        For Each cell As DataGridViewCell In row.Cells
                            Dim value As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                            ' Escapen wenn Semikolon enthalten
                            If value.Contains(";") Then
                                value = """" & value & """"
                            End If
                            values.Add(value)
                        Next
                        writer.WriteLine(String.Join(";", values))
                    End If
                Next
            End Using

            MessageBox.Show("Daten erfolgreich nach CSV exportiert!" & vbCrLf & vbCrLf & dateipfad,
                          "Export erfolgreich",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Fehler beim Exportieren:" & vbCrLf & vbCrLf & ex.Message,
                          "Export-Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAktualisieren_Click(sender As Object, e As EventArgs) Handles btnAktualisieren.Click
        If cboTabellen.SelectedItem IsNot Nothing Then
            DatenLaden(cboTabellen.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnNeuerEintrag_Click(sender As Object, e As EventArgs) Handles btnNeuerEintrag.Click
        ' Prüfen ob Tabelle ausgewählt wurde
        If cboTabellen.SelectedItem Is Nothing Then
            MessageBox.Show("Bitte wählen Sie zuerst eine Tabelle aus!",
                          "Tabelle auswählen",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
            Return
        End If

        ' Eingabemaske öffnen
        Try
            Dim formEingabe As New FormDatenEingabe(GetConnectionString(), cboTabellen.SelectedItem.ToString())
            If formEingabe.ShowDialog() = DialogResult.OK Then
                ' Nach erfolgreichem Speichern Daten neu laden
                DatenLaden(cboTabellen.SelectedItem.ToString())
            End If

        Catch ex As Exception
            MessageBox.Show("Fehler beim Öffnen der Eingabemaske:" & vbCrLf & vbCrLf & ex.Message,
                          "Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===== Menü Event Handler =====

    Private Sub mnuEinstellungen_Click(sender As Object, e As EventArgs) Handles mnuEinstellungen.Click
        btnEinstellungen.PerformClick()
    End Sub

    Private Sub mnuBeenden_Click(sender As Object, e As EventArgs) Handles mnuBeenden.Click
        Me.Close()
    End Sub

    Private Sub mnuTabellenLaden_Click(sender As Object, e As EventArgs) Handles mnuTabellenLaden.Click
        btnTabellenLaden.PerformClick()
    End Sub

    Private Sub mnuDatenLaden_Click(sender As Object, e As EventArgs) Handles mnuDatenLaden.Click
        btnDatenLaden.PerformClick()
    End Sub

    Private Sub mnuNeuerEintrag_Click(sender As Object, e As EventArgs) Handles mnuNeuerEintrag.Click
        btnNeuerEintrag.PerformClick()
    End Sub

    Private Sub mnuAktualisieren_Click(sender As Object, e As EventArgs) Handles mnuAktualisieren.Click
        btnAktualisieren.PerformClick()
    End Sub

    Private Sub mnuNachCSV_Click(sender As Object, e As EventArgs) Handles mnuNachCSV.Click
        btnExportieren.PerformClick()
    End Sub

    Private Sub mnuUeber_Click(sender As Object, e As EventArgs) Handles mnuUeber.Click
        Dim version As String = Application.ProductVersion
        Dim info As String = "MySQL Data Viewer" & vbCrLf & vbCrLf &
                           "Version: " & version & vbCrLf & vbCrLf &
                           "Eine VB.NET Windows Forms Anwendung" & vbCrLf &
                           "zum sicheren Anzeigen und Bearbeiten" & vbCrLf &
                           "von MySQL-Datenbanken." & vbCrLf & vbCrLf &
                           "© 2024"

        MessageBox.Show(info, "Über MySQL Data Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
