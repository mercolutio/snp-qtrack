<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDatenbankEinstellungen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.lblDatenbank = New System.Windows.Forms.Label()
        Me.txtDatenbank = New System.Windows.Forms.TextBox()
        Me.lblBenutzer = New System.Windows.Forms.Label()
        Me.txtBenutzer = New System.Windows.Forms.TextBox()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.btnTesten = New System.Windows.Forms.Button()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(15, 30)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(41, 13)
        Me.lblServer.TabIndex = 0
        Me.lblServer.Text = "Server:"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(100, 27)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(250, 20)
        Me.txtServer.TabIndex = 1
        Me.txtServer.Text = "localhost"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(15, 56)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "Port:"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(100, 53)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 20)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "3306"
        '
        'lblDatenbank
        '
        Me.lblDatenbank.AutoSize = True
        Me.lblDatenbank.Location = New System.Drawing.Point(15, 82)
        Me.lblDatenbank.Name = "lblDatenbank"
        Me.lblDatenbank.Size = New System.Drawing.Size(62, 13)
        Me.lblDatenbank.TabIndex = 4
        Me.lblDatenbank.Text = "Datenbank:"
        '
        'txtDatenbank
        '
        Me.txtDatenbank.Location = New System.Drawing.Point(100, 79)
        Me.txtDatenbank.Name = "txtDatenbank"
        Me.txtDatenbank.Size = New System.Drawing.Size(250, 20)
        Me.txtDatenbank.TabIndex = 5
        '
        'lblBenutzer
        '
        Me.lblBenutzer.AutoSize = True
        Me.lblBenutzer.Location = New System.Drawing.Point(15, 108)
        Me.lblBenutzer.Name = "lblBenutzer"
        Me.lblBenutzer.Size = New System.Drawing.Size(55, 13)
        Me.lblBenutzer.TabIndex = 6
        Me.lblBenutzer.Text = "Benutzer:"
        '
        'txtBenutzer
        '
        Me.txtBenutzer.Location = New System.Drawing.Point(100, 105)
        Me.txtBenutzer.Name = "txtBenutzer"
        Me.txtBenutzer.Size = New System.Drawing.Size(250, 20)
        Me.txtBenutzer.TabIndex = 7
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(15, 134)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(53, 13)
        Me.lblPasswort.TabIndex = 8
        Me.lblPasswort.Text = "Passwort:"
        '
        'txtPasswort
        '
        Me.txtPasswort.Location = New System.Drawing.Point(100, 131)
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswort.Size = New System.Drawing.Size(250, 20)
        Me.txtPasswort.TabIndex = 9
        Me.txtPasswort.UseSystemPasswordChar = True
        '
        'btnTesten
        '
        Me.btnTesten.Location = New System.Drawing.Point(18, 190)
        Me.btnTesten.Name = "btnTesten"
        Me.btnTesten.Size = New System.Drawing.Size(110, 30)
        Me.btnTesten.TabIndex = 10
        Me.btnTesten.Text = "Verbindung testen"
        Me.btnTesten.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(194, 190)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(90, 30)
        Me.btnSpeichern.TabIndex = 11
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(290, 190)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(90, 30)
        Me.btnAbbrechen.TabIndex = 12
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblServer)
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Controls.Add(Me.lblPort)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.lblDatenbank)
        Me.GroupBox1.Controls.Add(Me.txtPasswort)
        Me.GroupBox1.Controls.Add(Me.txtDatenbank)
        Me.GroupBox1.Controls.Add(Me.lblPasswort)
        Me.GroupBox1.Controls.Add(Me.lblBenutzer)
        Me.GroupBox1.Controls.Add(Me.txtBenutzer)
        Me.GroupBox1.Controls.Add(Me.lblBenutzer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 165)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datenbankverbindung"
        '
        'FormDatenbankEinstellungen
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 232)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnTesten)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDatenbankEinstellungen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datenbank-Einstellungen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblServer As Label
    Friend WithEvents txtServer As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents lblDatenbank As Label
    Friend WithEvents txtDatenbank As TextBox
    Friend WithEvents lblBenutzer As Label
    Friend WithEvents txtBenutzer As TextBox
    Friend WithEvents lblPasswort As Label
    Friend WithEvents txtPasswort As TextBox
    Friend WithEvents btnTesten As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
