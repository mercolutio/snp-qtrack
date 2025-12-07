Imports MySql.Data.MySqlClient

Public Class FormRenderer

    Private _konfiguration As FormularKonfiguration
    Private _connectionString As String
    Private _feldControls As New Dictionary(Of String, Control)
    Private _istVorschau As Boolean

    Public Sub New(konfiguration As FormularKonfiguration, connectionString As String)
        InitializeComponent()

        _konfiguration = konfiguration
        _connectionString = connectionString
        _istVorschau = String.IsNullOrEmpty(connectionString)
    End Sub

    Private Sub FormRenderer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Titel setzen
        lblTitel.Text = _konfiguration.FormularName
        Me.Text = _konfiguration.FormularName

        ' Formular-Größe anpassen
        If _konfiguration.Breite > 0 Then
            Me.Width = _konfiguration.Breite
        End If
        If _konfiguration.Hoehe > 0 Then
            Me.Height = _konfiguration.Hoehe + 120 ' +120 für Header und Buttons
        End If

        ' Felder generieren
        FormularGenerieren()

        ' Buttons anpassen
        If _istVorschau Then
            btnSpeichern.Text = "Schließen"
            btnAbbrechen.Visible = False
        End If
    End Sub

    Private Sub FormularGenerieren()
        Dim yPos As Integer = 20

        For Each feldConfig As FeldKonfiguration In _konfiguration.Felder.OrderBy(Function(f) f.Y)
            Dim label As Label = Nothing
            Dim ctrl As Control = Nothing

            ' Label erstellen (außer bei CheckBox und Label-Typ)
            If feldConfig.FeldTyp <> "CheckBox" AndAlso feldConfig.FeldTyp <> "Label" Then
                label = New Label() With {
                    .Text = feldConfig.LabelText & If(feldConfig.IstPflichtfeld, " *", ":"),
                    .Location = New Point(20, yPos + 3),
                    .Width = 150,
                    .Font = New Font("Segoe UI", 9),
                    .TextAlign = ContentAlignment.MiddleLeft
                }
                PanelFormular.Controls.Add(label)
            End If

            ' Control erstellen
            Select Case feldConfig.FeldTyp
                Case "TextBox"
                    ctrl = New TextBox() With {
                        .Name = "ctrl_" & feldConfig.FeldName,
                        .Location = New Point(180, yPos),
                        .Width = feldConfig.Breite,
                        .Text = feldConfig.Standardwert
                    }

                Case "DateTimePicker"
                    ctrl = New DateTimePicker() With {
                        .Name = "ctrl_" & feldConfig.FeldName,
                        .Location = New Point(180, yPos),
                        .Width = feldConfig.Breite,
                        .Format = DateTimePickerFormat.Custom,
                        .CustomFormat = "dd.MM.yyyy HH:mm:ss"
                    }

                Case "ComboBox"
                    Dim cmb As New ComboBox() With {
                        .Name = "ctrl_" & feldConfig.FeldName,
                        .Location = New Point(180, yPos),
                        .Width = feldConfig.Breite,
                        .DropDownStyle = ComboBoxStyle.DropDownList
                    }
                    If feldConfig.ComboBoxItems IsNot Nothing Then
                        cmb.Items.AddRange(feldConfig.ComboBoxItems.ToArray())
                    End If
                    ctrl = cmb

                Case "CheckBox"
                    ctrl = New CheckBox() With {
                        .Name = "ctrl_" & feldConfig.FeldName,
                        .Location = New Point(20, yPos),
                        .Text = feldConfig.LabelText,
                        .AutoSize = True
                    }

                Case "Label"
                    ctrl = New Label() With {
                        .Name = "ctrl_" & feldConfig.FeldName,
                        .Location = New Point(20, yPos),
                        .Width = 500,
                        .Text = feldConfig.LabelText,
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                        .ForeColor = Color.FromArgb(52, 73, 94)
                    }
            End Select

            If ctrl IsNot Nothing Then
                PanelFormular.Controls.Add(ctrl)
                _feldControls.Add(feldConfig.FeldName, ctrl)
            End If

            yPos += 40
        Next

        ' Pflichtfeld-Hinweis
        Dim lblHinweis As New Label() With {
            .Text = "* Pflichtfeld",
            .Location = New Point(20, yPos + 10),
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 8, FontStyle.Italic),
            .AutoSize = True
        }
        PanelFormular.Controls.Add(lblHinweis)
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        If _istVorschau Then
            Me.Close()
            Return
        End If

        ' Validierung
        If Not Validieren() Then
            Return
        End If

        ' Daten speichern
        If DatenSpeichern() Then
            MessageBox.Show("Prüfauftrag erfolgreich erfasst!",
                          "Erfolg",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function Validieren() As Boolean
        For Each feldConfig As FeldKonfiguration In _konfiguration.Felder
            If feldConfig.IstPflichtfeld AndAlso _feldControls.ContainsKey(feldConfig.FeldName) Then
                Dim ctrl As Control = _feldControls(feldConfig.FeldName)

                If TypeOf ctrl Is TextBox Then
                    Dim txt As TextBox = DirectCast(ctrl, TextBox)
                    If String.IsNullOrWhiteSpace(txt.Text) Then
                        MessageBox.Show("Bitte füllen Sie das Pflichtfeld '" & feldConfig.LabelText & "' aus!",
                                      "Validierung",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning)
                        txt.Focus()
                        Return False
                    End If
                ElseIf TypeOf ctrl Is ComboBox Then
                    Dim cmb As ComboBox = DirectCast(ctrl, ComboBox)
                    If cmb.SelectedIndex = -1 Then
                        MessageBox.Show("Bitte wählen Sie einen Wert für '" & feldConfig.LabelText & "' aus!",
                                      "Validierung",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning)
                        cmb.Focus()
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

                Dim spalten As New List(Of String)
                Dim parameter As New List(Of String)
                Dim values As New Dictionary(Of String, Object)

                ' ID automatisch generieren
                spalten.Add("`id`")
                parameter.Add("@id")
                values.Add("@id", DateTime.Now.ToString("ddMMyyHHmmssfff"))

                ' Alle Felder durchgehen
                For Each feldConfig As FeldKonfiguration In _konfiguration.Felder
                    If String.IsNullOrEmpty(feldConfig.DatenbankSpalte) Then
                        Continue For
                    End If

                    If Not _feldControls.ContainsKey(feldConfig.FeldName) Then
                        Continue For
                    End If

                    Dim ctrl As Control = _feldControls(feldConfig.FeldName)
                    Dim wert As Object = Nothing

                    ' Wert aus Control extrahieren
                    If TypeOf ctrl Is TextBox Then
                        Dim txt As TextBox = DirectCast(ctrl, TextBox)
                        wert = If(String.IsNullOrWhiteSpace(txt.Text), DBNull.Value, DirectCast(txt.Text, Object))

                    ElseIf TypeOf ctrl Is DateTimePicker Then
                        Dim dtp As DateTimePicker = DirectCast(ctrl, DateTimePicker)
                        wert = dtp.Value

                    ElseIf TypeOf ctrl Is ComboBox Then
                        Dim cmb As ComboBox = DirectCast(ctrl, ComboBox)
                        wert = If(cmb.SelectedItem Is Nothing, DBNull.Value, cmb.SelectedItem)

                    ElseIf TypeOf ctrl Is CheckBox Then
                        Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                        wert = If(chk.Checked, 1, 0)

                    End If

                    spalten.Add("`" & feldConfig.DatenbankSpalte & "`")
                    parameter.Add("@" & feldConfig.FeldName)
                    values.Add("@" & feldConfig.FeldName, wert)
                Next

                ' Query zusammenbauen
                Dim query As String = String.Format("INSERT INTO `{0}` ({1}) VALUES ({2})",
                                                   _konfiguration.Tabelle,
                                                   String.Join(", ", spalten),
                                                   String.Join(", ", parameter))

                Using command As New MySqlCommand(query, connection)
                    For Each kvp As KeyValuePair(Of String, Object) In values
                        command.Parameters.AddWithValue(kvp.Key, kvp.Value)
                    Next

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
