Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormDesigner

    Private _konfiguration As FormularKonfiguration
    Private _ausgewaehltesFeld As Panel
    Private _ausgewaehlteFeldConfig As FeldKonfiguration
    Private _istDragging As Boolean = False
    Private _dragStartPunkt As Point
    Private _formularPfad As String = Path.Combine(Application.StartupPath, "Formulare")

    Private Sub FormDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _konfiguration = New FormularKonfiguration()
        _konfiguration.FormularName = "Prüfauftrag"
        _konfiguration.Tabelle = "messAuftragsVerwaltung"

        txtFormName.Text = _konfiguration.FormularName
        txtTabelle.Text = _konfiguration.Tabelle

        ' Formular-Ordner erstellen falls nicht vorhanden
        If Not Directory.Exists(_formularPfad) Then
            Directory.CreateDirectory(_formularPfad)
        End If

        EigenschaftenPanelAktualisieren(False)
    End Sub

    ' ===== TOOLBOX BUTTONS =====
    Private Sub btnAddTextBox_Click(sender As Object, e As EventArgs) Handles btnAddTextBox.Click
        FeldHinzufuegen("TextBox")
    End Sub

    Private Sub btnAddDatePicker_Click(sender As Object, e As EventArgs) Handles btnAddDatePicker.Click
        FeldHinzufuegen("DateTimePicker")
    End Sub

    Private Sub btnAddComboBox_Click(sender As Object, e As EventArgs) Handles btnAddComboBox.Click
        FeldHinzufuegen("ComboBox")
    End Sub

    Private Sub btnAddCheckBox_Click(sender As Object, e As EventArgs) Handles btnAddCheckBox.Click
        FeldHinzufuegen("CheckBox")
    End Sub

    Private Sub btnAddLabel_Click(sender As Object, e As EventArgs) Handles btnAddLabel.Click
        FeldHinzufuegen("Label")
    End Sub

    Private Sub FeldHinzufuegen(feldTyp As String)
        Dim feldConfig As New FeldKonfiguration With {
            .FeldTyp = feldTyp,
            .LabelText = "Neues Feld",
            .FeldName = "feld_" & (_konfiguration.Felder.Count + 1).ToString(),
            .X = 20,
            .Y = 20 + (_konfiguration.Felder.Count * 40),
            .Breite = 300,
            .Hoehe = 25
        }

        _konfiguration.Felder.Add(feldConfig)
        FeldZeichnen(feldConfig)
        lblDesignHint.Visible = False
    End Sub

    Private Sub FeldZeichnen(feldConfig As FeldKonfiguration)
        ' Container Panel für das Feld
        Dim feldPanel As New Panel() With {
            .Name = "panel_" & feldConfig.Id,
            .Location = New Point(feldConfig.X, feldConfig.Y),
            .Size = New Size(feldConfig.Breite + 150, feldConfig.Hoehe + 10),
            .BorderStyle = BorderStyle.FixedSingle,
            .BackColor = Color.LightBlue,
            .Cursor = Cursors.Hand,
            .Tag = feldConfig
        }

        ' Label
        Dim lbl As New Label() With {
            .Text = feldConfig.LabelText & If(feldConfig.IstPflichtfeld, " *", ""),
            .Location = New Point(5, 7),
            .Width = 140,
            .TextAlign = ContentAlignment.MiddleLeft
        }

        ' Control je nach Typ
        Dim ctrl As Control = Nothing
        Select Case feldConfig.FeldTyp
            Case "TextBox"
                ctrl = New TextBox() With {
                    .Location = New Point(150, 5),
                    .Width = feldConfig.Breite,
                    .Text = "[" & feldConfig.FeldName & "]",
                    .Enabled = False
                }
            Case "DateTimePicker"
                ctrl = New DateTimePicker() With {
                    .Location = New Point(150, 5),
                    .Width = feldConfig.Breite,
                    .Enabled = False
                }
            Case "ComboBox"
                ctrl = New ComboBox() With {
                    .Location = New Point(150, 5),
                    .Width = feldConfig.Breite,
                    .Enabled = False
                }
            Case "CheckBox"
                ctrl = New CheckBox() With {
                    .Location = New Point(150, 5),
                    .Text = feldConfig.LabelText,
                    .Enabled = False
                }
            Case "Label"
                ctrl = New Label() With {
                    .Location = New Point(150, 5),
                    .Width = feldConfig.Breite,
                    .Text = feldConfig.LabelText,
                    .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                }
        End Select

        feldPanel.Controls.Add(lbl)
        If ctrl IsNot Nothing Then
            feldPanel.Controls.Add(ctrl)
        End If

        ' Events für Drag & Drop und Auswahl
        AddHandler feldPanel.MouseDown, AddressOf FeldPanel_MouseDown
        AddHandler feldPanel.MouseMove, AddressOf FeldPanel_MouseMove
        AddHandler feldPanel.MouseUp, AddressOf FeldPanel_MouseUp
        AddHandler feldPanel.Click, AddressOf FeldPanel_Click

        PanelDesignSurface.Controls.Add(feldPanel)
        feldPanel.BringToFront()
    End Sub

    ' ===== DRAG & DROP =====
    Private Sub FeldPanel_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            _istDragging = True
            _dragStartPunkt = e.Location
            Dim panel As Panel = DirectCast(sender, Panel)
            panel.Cursor = Cursors.SizeAll
        End If
    End Sub

    Private Sub FeldPanel_MouseMove(sender As Object, e As MouseEventArgs)
        If _istDragging Then
            Dim panel As Panel = DirectCast(sender, Panel)
            Dim newLocation As New Point(
                panel.Left + (e.X - _dragStartPunkt.X),
                panel.Top + (e.Y - _dragStartPunkt.Y)
            )

            ' In Grenzen halten
            If newLocation.X >= 0 AndAlso newLocation.Y >= 0 AndAlso
               newLocation.X + panel.Width <= PanelDesignSurface.Width AndAlso
               newLocation.Y + panel.Height <= PanelDesignSurface.Height Then
                panel.Location = newLocation

                ' Konfiguration aktualisieren
                Dim config As FeldKonfiguration = DirectCast(panel.Tag, FeldKonfiguration)
                config.X = panel.Left
                config.Y = panel.Top
            End If
        End If
    End Sub

    Private Sub FeldPanel_MouseUp(sender As Object, e As MouseEventArgs)
        _istDragging = False
        Dim panel As Panel = DirectCast(sender, Panel)
        panel.Cursor = Cursors.Hand
    End Sub

    Private Sub FeldPanel_Click(sender As Object, e As EventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        FeldAuswaehlen(panel)
    End Sub

    Private Sub FeldAuswaehlen(panel As Panel)
        ' Alte Auswahl zurücksetzen
        If _ausgewaehltesFeld IsNot Nothing Then
            _ausgewaehltesFeld.BackColor = Color.LightBlue
        End If

        ' Neue Auswahl
        _ausgewaehltesFeld = panel
        _ausgewaehlteFeldConfig = DirectCast(panel.Tag, FeldKonfiguration)
        _ausgewaehltesFeld.BackColor = Color.LightGreen

        ' Eigenschaften laden
        EigenschaftenPanelAktualisieren(True)
        txtPropLabelText.Text = _ausgewaehlteFeldConfig.LabelText
        txtPropFeldName.Text = _ausgewaehlteFeldConfig.FeldName
        txtPropDBSpalte.Text = _ausgewaehlteFeldConfig.DatenbankSpalte
        chkPropPflichtfeld.Checked = _ausgewaehlteFeldConfig.IstPflichtfeld
    End Sub

    Private Sub EigenschaftenPanelAktualisieren(aktiviert As Boolean)
        txtPropLabelText.Enabled = aktiviert
        txtPropFeldName.Enabled = aktiviert
        txtPropDBSpalte.Enabled = aktiviert
        chkPropPflichtfeld.Enabled = aktiviert
        btnPropLoeschen.Enabled = aktiviert
    End Sub

    ' ===== EIGENSCHAFTEN ÄNDERN =====
    Private Sub txtPropLabelText_TextChanged(sender As Object, e As EventArgs) Handles txtPropLabelText.TextChanged
        If _ausgewaehlteFeldConfig IsNot Nothing Then
            _ausgewaehlteFeldConfig.LabelText = txtPropLabelText.Text
            DesignSurfaceAktualisieren()
        End If
    End Sub

    Private Sub txtPropFeldName_TextChanged(sender As Object, e As EventArgs) Handles txtPropFeldName.TextChanged
        If _ausgewaehlteFeldConfig IsNot Nothing Then
            _ausgewaehlteFeldConfig.FeldName = txtPropFeldName.Text
            DesignSurfaceAktualisieren()
        End If
    End Sub

    Private Sub txtPropDBSpalte_TextChanged(sender As Object, e As EventArgs) Handles txtPropDBSpalte.TextChanged
        If _ausgewaehlteFeldConfig IsNot Nothing Then
            _ausgewaehlteFeldConfig.DatenbankSpalte = txtPropDBSpalte.Text
        End If
    End Sub

    Private Sub chkPropPflichtfeld_CheckedChanged(sender As Object, e As EventArgs) Handles chkPropPflichtfeld.CheckedChanged
        If _ausgewaehlteFeldConfig IsNot Nothing Then
            _ausgewaehlteFeldConfig.IstPflichtfeld = chkPropPflichtfeld.Checked
            DesignSurfaceAktualisieren()
        End If
    End Sub

    Private Sub btnPropLoeschen_Click(sender As Object, e As EventArgs) Handles btnPropLoeschen.Click
        If _ausgewaehlteFeldConfig IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show("Möchten Sie dieses Feld wirklich löschen?",
                                        "Feld löschen",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                _konfiguration.Felder.Remove(_ausgewaehlteFeldConfig)
                PanelDesignSurface.Controls.Remove(_ausgewaehltesFeld)
                _ausgewaehltesFeld = Nothing
                _ausgewaehlteFeldConfig = Nothing
                EigenschaftenPanelAktualisieren(False)

                If _konfiguration.Felder.Count = 0 Then
                    lblDesignHint.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub DesignSurfaceAktualisieren()
        ' Alle Panels löschen und neu zeichnen
        For Each ctrl As Control In PanelDesignSurface.Controls.OfType(Of Panel).ToList()
            PanelDesignSurface.Controls.Remove(ctrl)
        Next

        For Each feldConfig As FeldKonfiguration In _konfiguration.Felder
            FeldZeichnen(feldConfig)
        Next

        lblDesignHint.Visible = _konfiguration.Felder.Count = 0
    End Sub

    ' ===== SPEICHERN & LADEN =====
    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        If String.IsNullOrWhiteSpace(txtFormName.Text) Then
            MessageBox.Show("Bitte geben Sie einen Formular-Namen ein!",
                          "Validierung",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
            Return
        End If

        _konfiguration.FormularName = txtFormName.Text
        _konfiguration.Tabelle = txtTabelle.Text

        Dim saveDialog As New SaveFileDialog() With {
            .Filter = "XML Datei (*.xml)|*.xml",
            .DefaultExt = "xml",
            .FileName = txtFormName.Text & ".xml",
            .InitialDirectory = _formularPfad
        }

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Try
                _konfiguration.SpeichernAlsXml(saveDialog.FileName)
                MessageBox.Show("Formular erfolgreich gespeichert!",
                              "Erfolg",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Fehler beim Speichern:" & vbCrLf & ex.Message,
                              "Fehler",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnLaden_Click(sender As Object, e As EventArgs) Handles btnLaden.Click
        Dim openDialog As New OpenFileDialog() With {
            .Filter = "XML Datei (*.xml)|*.xml",
            .InitialDirectory = _formularPfad
        }

        If openDialog.ShowDialog() = DialogResult.OK Then
            Try
                _konfiguration = FormularKonfiguration.LadenVonXml(openDialog.FileName)
                txtFormName.Text = _konfiguration.FormularName
                txtTabelle.Text = _konfiguration.Tabelle
                DesignSurfaceAktualisieren()

                MessageBox.Show("Formular erfolgreich geladen!",
                              "Erfolg",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Fehler beim Laden:" & vbCrLf & ex.Message,
                              "Fehler",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnVorschau_Click(sender As Object, e As EventArgs) Handles btnVorschau.Click
        If _konfiguration.Felder.Count = 0 Then
            MessageBox.Show("Bitte fügen Sie zuerst Felder hinzu!",
                          "Vorschau",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information)
            Return
        End If

        ' Vorschau öffnen
        Dim renderer As New FormRenderer(_konfiguration, Nothing)
        renderer.ShowDialog()
    End Sub

    Private Sub btnSchliessen_Click(sender As Object, e As EventArgs) Handles btnSchliessen.Click
        Me.Close()
    End Sub

    Private Sub btnGenerieren_Click(sender As Object, e As EventArgs) Handles btnGenerieren.Click
        If String.IsNullOrWhiteSpace(txtTabelle.Text) Then
            MessageBox.Show("Bitte geben Sie einen Tabellennamen ein!",
                          "Validierung",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Datenbankverbindung herstellen
            Dim connectionString As String = GetConnectionString()
            VonDatenbankGenerieren(connectionString, txtTabelle.Text)

            MessageBox.Show("Formular erfolgreich aus Datenbank generiert!",
                          "Erfolg",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Fehler beim Generieren:" & vbCrLf & vbCrLf & ex.Message,
                          "Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetConnectionString() As String
        Try
            ' Passwort entschlüsseln
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

    Private Sub VonDatenbankGenerieren(connectionString As String, tabellenname As String)
        ' Alte Felder löschen
        _konfiguration.Felder.Clear()
        PanelDesignSurface.Controls.Clear()
        lblDesignHint.Visible = False

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Tabellenschema abrufen
            Dim query As String = String.Format("SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, COLUMN_KEY, EXTRA " &
                                              "FROM INFORMATION_SCHEMA.COLUMNS " &
                                              "WHERE TABLE_SCHEMA = '{0}' AND TABLE_NAME = '{1}' " &
                                              "ORDER BY ORDINAL_POSITION",
                                              My.Settings.DBName, tabellenname)

            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    Dim yPos As Integer = 20

                    While reader.Read()
                        Dim spaltenName As String = reader("COLUMN_NAME").ToString()
                        Dim datenTyp As String = reader("DATA_TYPE").ToString()
                        Dim istNullable As String = reader("IS_NULLABLE").ToString()
                        Dim spaltenKey As String = reader("COLUMN_KEY").ToString()
                        Dim extra As String = reader("EXTRA").ToString()

                        ' ID-Spalte für messAuftragsVerwaltung überspringen
                        If tabellenname.ToLower() = "messauftragsverwaltung" AndAlso spaltenName.ToLower() = "id" Then
                            Continue While
                        End If

                        ' AUTO_INCREMENT und PRIMARY KEY Felder überspringen
                        If extra.ToUpper().Contains("AUTO_INCREMENT") OrElse spaltenKey = "PRI" Then
                            Continue While
                        End If

                        ' Feldtyp basierend auf Datentyp bestimmen
                        Dim feldTyp As String = "TextBox"
                        Select Case datenTyp.ToLower()
                            Case "date", "datetime", "timestamp"
                                feldTyp = "DateTimePicker"
                            Case "tinyint"
                                feldTyp = "CheckBox"
                        End Select

                        ' Feld erstellen
                        Dim feldConfig As New FeldKonfiguration With {
                            .FeldTyp = feldTyp,
                            .LabelText = spaltenName,
                            .FeldName = spaltenName,
                            .DatenbankSpalte = spaltenName,
                            .X = 20,
                            .Y = yPos,
                            .Breite = 300,
                            .Hoehe = 25,
                            .IstPflichtfeld = (istNullable = "NO")
                        }

                        _konfiguration.Felder.Add(feldConfig)
                        FeldZeichnen(feldConfig)

                        yPos += 40
                    End While
                End Using
            End Using
        End Using
    End Sub

End Class
