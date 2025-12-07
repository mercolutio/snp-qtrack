Imports MySql.Data.MySqlClient

Public Class FormDatenEingabe

    Private _connectionString As String
    Private _tabellenname As String
    Private _eingabeControls As New Dictionary(Of String, Control)
    Private _spaltenInfos As New List(Of SpaltenInfo)

    ' Struktur für Spalteninformationen
    Private Structure SpaltenInfo
        Public Name As String
        Public Typ As String
        Public IstNullbar As Boolean
        Public IstAutoIncrement As Boolean
        Public IstPrimaryKey As Boolean
        Public DefaultWert As String
    End Structure

    Public Sub New(connectionString As String, tabellenname As String)
        InitializeComponent()

        _connectionString = connectionString
        _tabellenname = tabellenname

        ' Titel anpassen basierend auf Tabelle
        Select Case tabellenname.ToLower()
            Case "messauftragsverwaltung"
                lblTabelle.Text = "Prüfauftrag erfassen"
                Me.Text = "Prüfauftrag erfassen"
            Case Else
                lblTabelle.Text = "Neuer Eintrag in Tabelle: " & tabellenname
                Me.Text = "Neuer Datensatz"
        End Select
    End Sub

    Private Sub FormDatenEingabe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpaltenLaden()
        EingabefelderErstellen()
    End Sub

    Private Sub SpaltenLaden()
        Try
            Using connection As New MySqlConnection(_connectionString)
                connection.Open()

                ' Spalteninformationen aus Information Schema laden
                Dim query As String = "SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, COLUMN_DEFAULT, EXTRA, COLUMN_KEY " &
                                    "FROM INFORMATION_SCHEMA.COLUMNS " &
                                    "WHERE TABLE_SCHEMA = @dbname AND TABLE_NAME = @tablename " &
                                    "ORDER BY ORDINAL_POSITION"

                Using command As New MySqlCommand(query, connection)
                    ' Datenbanknamen aus Connection String extrahieren
                    Dim builder As New MySqlConnectionStringBuilder(_connectionString)
                    command.Parameters.AddWithValue("@dbname", builder.Database)
                    command.Parameters.AddWithValue("@tablename", _tabellenname)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim spalte As New SpaltenInfo With {
                                .Name = reader("COLUMN_NAME").ToString(),
                                .Typ = reader("DATA_TYPE").ToString().ToLower(),
                                .IstNullbar = reader("IS_NULLABLE").ToString() = "YES",
                                .IstAutoIncrement = reader("EXTRA").ToString().ToLower().Contains("auto_increment"),
                                .IstPrimaryKey = reader("COLUMN_KEY").ToString() = "PRI",
                                .DefaultWert = If(IsDBNull(reader("COLUMN_DEFAULT")), Nothing, reader("COLUMN_DEFAULT").ToString())
                            }
                            _spaltenInfos.Add(spalte)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Fehler beim Laden der Spalteninformationen:" & vbCrLf & vbCrLf & ex.Message,
                          "Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub EingabefelderErstellen()
        pnlEingabefelder.SuspendLayout()

        Dim yPosition As Integer = 10
        Dim labelBreite As Integer = 150
        Dim eingabeBreite As Integer = 350
        Dim zeilenHoehe As Integer = 35

        For Each spalte As SpaltenInfo In _spaltenInfos
            ' Spezielle Behandlung für ID in messAuftragsVerwaltung (wird automatisch generiert)
            If _tabellenname.ToLower() = "messauftragsverwaltung" AndAlso spalte.Name.ToLower() = "id" Then
                Continue For
            End If

            ' AUTO_INCREMENT und PRIMARY KEY Spalten überspringen
            If spalte.IstAutoIncrement OrElse spalte.IstPrimaryKey Then
                Continue For
            End If

            ' Label erstellen
            Dim lbl As New Label()
            lbl.Text = spalte.Name & If(spalte.IstNullbar, ":", ": *")
            lbl.Location = New Point(10, yPosition + 3)
            lbl.Width = labelBreite
            lbl.TextAlign = ContentAlignment.MiddleLeft
            pnlEingabefelder.Controls.Add(lbl)

            ' Eingabefeld erstellen (abhängig vom Datentyp)
            Dim eingabe As Control = EingabefeldErstellen(spalte)
            eingabe.Name = "txt_" & spalte.Name
            eingabe.Location = New Point(labelBreite + 20, yPosition)
            eingabe.Width = eingabeBreite
            pnlEingabefelder.Controls.Add(eingabe)

            ' In Dictionary speichern für späteren Zugriff
            _eingabeControls.Add(spalte.Name, eingabe)

            yPosition += zeilenHoehe
        Next

        ' Hinweis für Pflichtfelder
        Dim lblHinweis As New Label()
        lblHinweis.Text = "* Pflichtfeld"
        lblHinweis.Location = New Point(10, yPosition + 10)
        lblHinweis.ForeColor = Color.Gray
        lblHinweis.Font = New Font(lblHinweis.Font, FontStyle.Italic)
        pnlEingabefelder.Controls.Add(lblHinweis)

        pnlEingabefelder.ResumeLayout()
    End Sub

    Private Function EingabefeldErstellen(spalte As SpaltenInfo) As Control
        ' Abhängig vom Datentyp unterschiedliche Controls erstellen
        Select Case spalte.Typ
            Case "date", "datetime", "timestamp"
                Dim dtp As New DateTimePicker()
                dtp.Format = DateTimePickerFormat.Custom
                If spalte.Typ = "date" Then
                    dtp.CustomFormat = "dd.MM.yyyy"
                Else
                    dtp.CustomFormat = "dd.MM.yyyy HH:mm:ss"
                    dtp.ShowUpDown = False
                End If
                Return dtp

            Case "text", "longtext", "mediumtext"
                Dim txt As New TextBox()
                txt.Multiline = True
                txt.Height = 80
                txt.ScrollBars = ScrollBars.Vertical
                Return txt

            Case "tinyint"
                ' Checkbox für TINYINT (oft für Boolean verwendet)
                Dim chk As New CheckBox()
                chk.Text = ""
                Return chk

            Case Else
                ' Standard TextBox
                Dim txt As New TextBox()
                Return txt
        End Select
    End Function

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        ' Validierung
        If Not Validieren() Then
            Return
        End If

        ' Daten speichern
        If DatenSpeichern() Then
            ' Erfolgsmeldung anpassen basierend auf Tabelle
            Dim meldung As String = "Datensatz erfolgreich gespeichert!"
            If _tabellenname.ToLower() = "messauftragsverwaltung" Then
                meldung = "Prüfauftrag erfolgreich erfasst!"
            End If

            MessageBox.Show(meldung,
                          "Erfolg",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function Validieren() As Boolean
        For Each spalte As SpaltenInfo In _spaltenInfos
            ' Spezielle Behandlung für ID in messAuftragsVerwaltung (wird automatisch generiert)
            If _tabellenname.ToLower() = "messauftragsverwaltung" AndAlso spalte.Name.ToLower() = "id" Then
                Continue For
            End If

            ' AUTO_INCREMENT und PRIMARY KEY Spalten überspringen
            If spalte.IstAutoIncrement OrElse spalte.IstPrimaryKey Then
                Continue For
            End If

            ' Nur Pflichtfelder prüfen
            If Not spalte.IstNullbar AndAlso spalte.DefaultWert Is Nothing Then
                Dim control As Control = _eingabeControls(spalte.Name)

                ' Je nach Control-Typ prüfen
                If TypeOf control Is TextBox Then
                    Dim txt As TextBox = DirectCast(control, TextBox)
                    If String.IsNullOrWhiteSpace(txt.Text) Then
                        MessageBox.Show("Bitte füllen Sie das Pflichtfeld '" & spalte.Name & "' aus!",
                                      "Validierung",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning)
                        txt.Focus()
                        Return False
                    End If
                End If
            End If
        Next

        Return True
    End Function

    Private Function DatenSpeichern() As Boolean
        Try
            Using connection As New MySqlConnection(_connectionString)
                connection.Open()

                ' INSERT Query dynamisch erstellen
                Dim spalten As New List(Of String)
                Dim parameter As New List(Of String)
                Dim values As New Dictionary(Of String, Object)

                For Each spalte As SpaltenInfo In _spaltenInfos
                    Dim wert As Object = Nothing

                    ' Spezielle Behandlung für ID in messAuftragsVerwaltung
                    If _tabellenname.ToLower() = "messauftragsverwaltung" AndAlso spalte.Name.ToLower() = "id" Then
                        ' ID als Timestamp generieren: TTMMJJHHMMSS + Millisekunden
                        wert = DateTime.Now.ToString("ddMMyyHHmmssfff")
                        spalten.Add("`" & spalte.Name & "`")
                        parameter.Add("@" & spalte.Name)
                        values.Add("@" & spalte.Name, wert)
                        Continue For
                    End If

                    ' AUTO_INCREMENT und PRIMARY KEY Spalten überspringen
                    If spalte.IstAutoIncrement OrElse spalte.IstPrimaryKey Then
                        Continue For
                    End If

                    Dim control As Control = _eingabeControls(spalte.Name)

                    ' Wert aus Control lesen
                    If TypeOf control Is TextBox Then
                        Dim txt As TextBox = DirectCast(control, TextBox)
                        If String.IsNullOrWhiteSpace(txt.Text) Then
                            wert = DBNull.Value
                        Else
                            wert = txt.Text
                        End If

                    ElseIf TypeOf control Is DateTimePicker Then
                        Dim dtp As DateTimePicker = DirectCast(control, DateTimePicker)
                        wert = dtp.Value

                    ElseIf TypeOf control Is CheckBox Then
                        Dim chk As CheckBox = DirectCast(control, CheckBox)
                        wert = If(chk.Checked, 1, 0)
                    End If

                    ' Zur Liste hinzufügen
                    spalten.Add("`" & spalte.Name & "`")
                    parameter.Add("@" & spalte.Name)
                    values.Add("@" & spalte.Name, wert)
                Next

                ' Query zusammenbauen
                Dim query As String = String.Format("INSERT INTO `{0}` ({1}) VALUES ({2})",
                                                   _tabellenname,
                                                   String.Join(", ", spalten),
                                                   String.Join(", ", parameter))

                Using command As New MySqlCommand(query, connection)
                    ' Parameter hinzufügen
                    For Each kvp As KeyValuePair(Of String, Object) In values
                        command.Parameters.AddWithValue(kvp.Key, kvp.Value)
                    Next

                    ' Ausführen
                    command.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As MySqlException
            MessageBox.Show("MySQL Fehler beim Speichern:" & vbCrLf & vbCrLf &
                          "Fehler: " & ex.Message & vbCrLf &
                          "Code: " & ex.Number,
                          "Datenbankfehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            Return False

        Catch ex As Exception
            MessageBox.Show("Fehler beim Speichern:" & vbCrLf & vbCrLf & ex.Message,
                          "Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
