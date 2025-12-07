Public Class FormHauptmenu

    Private Sub FormHauptmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Version anzeigen
        lblVersion.Text = "Version " & Application.ProductVersion & " © 2024"
    End Sub

    Private Sub btnDatenAnzeigen_Click(sender As Object, e As EventArgs) Handles btnDatenAnzeigen.Click
        ' Prüfen ob Datenbankeinstellungen vorhanden sind
        If String.IsNullOrEmpty(My.Settings.DBServer) OrElse
           String.IsNullOrEmpty(My.Settings.DBName) Then

            Dim result As DialogResult = MessageBox.Show("Es sind noch keine Datenbankeinstellungen konfiguriert." & vbCrLf & vbCrLf &
                                       "Möchten Sie jetzt die Einstellungen konfigurieren?",
                                       "Einstellungen erforderlich",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                EinstellungenOeffnen()
            End If
            Return
        End If

        ' Prüfauftrag Eingabemaske öffnen
        Try
            Dim connectionString As String = GetConnectionString()
            Dim formularPfad As String = System.IO.Path.Combine(Application.StartupPath, "Formulare", "Prüfauftrag.xml")

            ' Prüfen ob eigenes Formular existiert
            If System.IO.File.Exists(formularPfad) Then
                ' Eigenes Formular laden und anzeigen
                Dim konfiguration As FormularKonfiguration = FormularKonfiguration.LadenVonXml(formularPfad)
                Dim formRenderer As New FormRenderer(konfiguration, connectionString)
                formRenderer.ShowDialog()
            Else
                ' Fallback auf Standard-Eingabemaske
                Dim formEingabe As New FormDatenEingabe(connectionString, "messAuftragsVerwaltung")
                formEingabe.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show("Fehler beim Öffnen der Eingabemaske:" & vbCrLf & vbCrLf & ex.Message,
                          "Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try
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

    Private Sub btnSchweissnahtpruefung_Click(sender As Object, e As EventArgs) Handles btnSchweissnahtpruefung.Click
        ' Prüfen ob Datenbankeinstellungen vorhanden sind
        If String.IsNullOrEmpty(My.Settings.DBServer) OrElse
           String.IsNullOrEmpty(My.Settings.DBName) Then

            Dim result As DialogResult = MessageBox.Show("Es sind noch keine Datenbankeinstellungen konfiguriert." & vbCrLf & vbCrLf &
                                       "Möchten Sie jetzt die Einstellungen konfigurieren?",
                                       "Einstellungen erforderlich",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                EinstellungenOeffnen()
            End If
            Return
        End If

        ' FormSchweissnahtpruefung öffnen
        Dim formSchweiss As New FormSchweissnahtpruefung()
        formSchweiss.ShowDialog()
    End Sub

    Private Sub btnFormDesigner_Click(sender As Object, e As EventArgs) Handles btnFormDesigner.Click
        ' Formular Designer öffnen
        Dim formDesigner As New FormDesigner()
        formDesigner.ShowDialog()
    End Sub

    Private Sub btnEinstellungen_Click(sender As Object, e As EventArgs) Handles btnEinstellungen.Click
        EinstellungenOeffnen()
    End Sub

    Private Sub EinstellungenOeffnen()
        Dim formEinstellungen As New FormDatenbankEinstellungen()
        formEinstellungen.ShowDialog()
    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        Dim result As DialogResult = MessageBox.Show("Möchten Sie das Programm wirklich beenden?",
                                    "Beenden",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' Hover-Effekte für bessere UX
    Private Sub btnDatenAnzeigen_MouseEnter(sender As Object, e As EventArgs) Handles btnDatenAnzeigen.MouseEnter
        btnDatenAnzeigen.BackColor = Color.FromArgb(41, 128, 185)
    End Sub

    Private Sub btnDatenAnzeigen_MouseLeave(sender As Object, e As EventArgs) Handles btnDatenAnzeigen.MouseLeave
        btnDatenAnzeigen.BackColor = Color.FromArgb(52, 152, 219)
    End Sub

    Private Sub btnSchweissnahtpruefung_MouseEnter(sender As Object, e As EventArgs) Handles btnSchweissnahtpruefung.MouseEnter
        btnSchweissnahtpruefung.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub btnSchweissnahtpruefung_MouseLeave(sender As Object, e As EventArgs) Handles btnSchweissnahtpruefung.MouseLeave
        btnSchweissnahtpruefung.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub btnFormDesigner_MouseEnter(sender As Object, e As EventArgs) Handles btnFormDesigner.MouseEnter
        btnFormDesigner.BackColor = Color.FromArgb(142, 68, 173)
    End Sub

    Private Sub btnFormDesigner_MouseLeave(sender As Object, e As EventArgs) Handles btnFormDesigner.MouseLeave
        btnFormDesigner.BackColor = Color.FromArgb(155, 89, 182)
    End Sub

    Private Sub btnEinstellungen_MouseEnter(sender As Object, e As EventArgs) Handles btnEinstellungen.MouseEnter
        btnEinstellungen.BackColor = Color.FromArgb(127, 140, 141)
    End Sub

    Private Sub btnEinstellungen_MouseLeave(sender As Object, e As EventArgs) Handles btnEinstellungen.MouseLeave
        btnEinstellungen.BackColor = Color.FromArgb(149, 165, 166)
    End Sub

    Private Sub btnBeenden_MouseEnter(sender As Object, e As EventArgs) Handles btnBeenden.MouseEnter
        btnBeenden.BackColor = Color.FromArgb(192, 57, 43)
    End Sub

    Private Sub btnBeenden_MouseLeave(sender As Object, e As EventArgs) Handles btnBeenden.MouseLeave
        btnBeenden.BackColor = Color.FromArgb(231, 76, 60)
    End Sub

End Class
