Imports MySql.Data.MySqlClient

Public Class FormDatenbankEinstellungen

    Private Sub FormDatenbankEinstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Vorhandene Einstellungen laden
        txtServer.Text = My.Settings.DBServer
        txtDatenbank.Text = My.Settings.DBName
        txtBenutzer.Text = My.Settings.DBUser
        txtPort.Text = My.Settings.DBPort

        ' Passwort entschlüsseln und anzeigen
        Try
            If Not String.IsNullOrEmpty(My.Settings.DBPassword) Then
                txtPasswort.Text = PasswordEncryption.Decrypt(My.Settings.DBPassword)
            End If
        Catch ex As Exception
            MessageBox.Show("Passwort konnte nicht geladen werden: " & ex.Message,
                          "Warnung",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
        End Try

        ' Passwort-Feld maskieren
        txtPasswort.PasswordChar = "*"c
        txtPasswort.UseSystemPasswordChar = True
    End Sub

    Private Sub btnTesten_Click(sender As Object, e As EventArgs) Handles btnTesten.Click
        ' Validierung
        If String.IsNullOrWhiteSpace(txtServer.Text) Then
            MessageBox.Show("Bitte Server eingeben!", "Validierung", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtServer.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtDatenbank.Text) Then
            MessageBox.Show("Bitte Datenbank eingeben!", "Validierung", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDatenbank.Focus()
            Return
        End If

        Dim testConnString As String = BuildConnectionString(
            txtServer.Text,
            txtDatenbank.Text,
            txtBenutzer.Text,
            txtPasswort.Text,
            txtPort.Text
        )

        ' Cursor auf Warten setzen
        Me.Cursor = Cursors.WaitCursor
        btnTesten.Enabled = False

        Try
            Using conn As New MySqlConnection(testConnString)
                conn.Open()
                MessageBox.Show("Verbindung erfolgreich!" & vbCrLf &
                              "Server: " & conn.ServerVersion,
                              "Test erfolgreich",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information)
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Verbindung fehlgeschlagen:" & vbCrLf & vbCrLf &
                          "Fehler: " & ex.Message & vbCrLf &
                          "Code: " & ex.Number,
                          "Verbindungsfehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Verbindung fehlgeschlagen:" & vbCrLf & vbCrLf & ex.Message,
                          "Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
            btnTesten.Enabled = True
        End Try
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        ' Validierung
        If String.IsNullOrWhiteSpace(txtServer.Text) Then
            MessageBox.Show("Bitte Server eingeben!", "Validierung", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtServer.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtDatenbank.Text) Then
            MessageBox.Show("Bitte Datenbank eingeben!", "Validierung", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDatenbank.Focus()
            Return
        End If

        Try
            ' Einstellungen speichern
            My.Settings.DBServer = txtServer.Text.Trim()
            My.Settings.DBName = txtDatenbank.Text.Trim()
            My.Settings.DBUser = txtBenutzer.Text.Trim()
            My.Settings.DBPort = txtPort.Text.Trim()

            ' Passwort VERSCHLÜSSELT speichern
            If Not String.IsNullOrEmpty(txtPasswort.Text) Then
                My.Settings.DBPassword = PasswordEncryption.Encrypt(txtPasswort.Text)
            Else
                My.Settings.DBPassword = String.Empty
            End If

            My.Settings.Save()

            MessageBox.Show("Einstellungen erfolgreich gespeichert!",
                          "Erfolg",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Fehler beim Speichern der Einstellungen:" & vbCrLf & vbCrLf & ex.Message,
                          "Fehler",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function BuildConnectionString(server As String, database As String, user As String, password As String, port As String) As String
        Return String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};",
                           server, port, database, user, password)
    End Function

End Class
