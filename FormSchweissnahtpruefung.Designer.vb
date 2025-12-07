<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSchweissnahtpruefung
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
        Me.dgvDaten = New System.Windows.Forms.DataGridView()
        Me.btnEinstellungen = New System.Windows.Forms.Button()
        Me.btnTabellenLaden = New System.Windows.Forms.Button()
        Me.cboTabellen = New System.Windows.Forms.ComboBox()
        Me.lblTabelle = New System.Windows.Forms.Label()
        Me.btnDatenLaden = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblAnzahl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkAutoLaden = New System.Windows.Forms.CheckBox()
        Me.btnExportieren = New System.Windows.Forms.Button()
        Me.btnAktualisieren = New System.Windows.Forms.Button()
        Me.btnNeuerEintrag = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuDatei = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEinstellungen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrenner1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBeenden = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDaten = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTabellenLaden = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatenLaden = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNeuerEintrag = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrenner2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAktualisieren = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNachCSV = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHilfe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUeber = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvDaten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDatei, Me.mnuDaten, Me.mnuExport, Me.mnuHilfe})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuDatei
        '
        Me.mnuDatei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEinstellungen, Me.mnuTrenner1, Me.mnuBeenden})
        Me.mnuDatei.Name = "mnuDatei"
        Me.mnuDatei.Size = New System.Drawing.Size(46, 20)
        Me.mnuDatei.Text = "&Datei"
        '
        'mnuEinstellungen
        '
        Me.mnuEinstellungen.Name = "mnuEinstellungen"
        Me.mnuEinstellungen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuEinstellungen.Size = New System.Drawing.Size(191, 22)
        Me.mnuEinstellungen.Text = "&Einstellungen..."
        '
        'mnuTrenner1
        '
        Me.mnuTrenner1.Name = "mnuTrenner1"
        Me.mnuTrenner1.Size = New System.Drawing.Size(188, 6)
        '
        'mnuBeenden
        '
        Me.mnuBeenden.Name = "mnuBeenden"
        Me.mnuBeenden.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuBeenden.Size = New System.Drawing.Size(191, 22)
        Me.mnuBeenden.Text = "&Beenden"
        '
        'mnuDaten
        '
        Me.mnuDaten.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTabellenLaden, Me.mnuDatenLaden, Me.mnuNeuerEintrag, Me.mnuTrenner2, Me.mnuAktualisieren})
        Me.mnuDaten.Name = "mnuDaten"
        Me.mnuDaten.Size = New System.Drawing.Size(49, 20)
        Me.mnuDaten.Text = "D&aten"
        '
        'mnuTabellenLaden
        '
        Me.mnuTabellenLaden.Name = "mnuTabellenLaden"
        Me.mnuTabellenLaden.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuTabellenLaden.Size = New System.Drawing.Size(197, 22)
        Me.mnuTabellenLaden.Text = "&Tabellen laden"
        '
        'mnuDatenLaden
        '
        Me.mnuDatenLaden.Name = "mnuDatenLaden"
        Me.mnuDatenLaden.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuDatenLaden.Size = New System.Drawing.Size(197, 22)
        Me.mnuDatenLaden.Text = "&Daten laden"
        '
        'mnuNeuerEintrag
        '
        Me.mnuNeuerEintrag.Name = "mnuNeuerEintrag"
        Me.mnuNeuerEintrag.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNeuerEintrag.Size = New System.Drawing.Size(197, 22)
        Me.mnuNeuerEintrag.Text = "&Neuer Eintrag"
        '
        'mnuTrenner2
        '
        Me.mnuTrenner2.Name = "mnuTrenner2"
        Me.mnuTrenner2.Size = New System.Drawing.Size(194, 6)
        '
        'mnuAktualisieren
        '
        Me.mnuAktualisieren.Name = "mnuAktualisieren"
        Me.mnuAktualisieren.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuAktualisieren.Size = New System.Drawing.Size(197, 22)
        Me.mnuAktualisieren.Text = "&Aktualisieren"
        '
        'mnuExport
        '
        Me.mnuExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNachCSV})
        Me.mnuExport.Name = "mnuExport"
        Me.mnuExport.Size = New System.Drawing.Size(52, 20)
        Me.mnuExport.Text = "&Export"
        '
        'mnuNachCSV
        '
        Me.mnuNachCSV.Name = "mnuNachCSV"
        Me.mnuNachCSV.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuNachCSV.Size = New System.Drawing.Size(190, 22)
        Me.mnuNachCSV.Text = "Nach &CSV..."
        '
        'mnuHilfe
        '
        Me.mnuHilfe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUeber})
        Me.mnuHilfe.Name = "mnuHilfe"
        Me.mnuHilfe.Size = New System.Drawing.Size(44, 20)
        Me.mnuHilfe.Text = "&Hilfe"
        '
        'mnuUeber
        '
        Me.mnuUeber.Name = "mnuUeber"
        Me.mnuUeber.Size = New System.Drawing.Size(107, 22)
        Me.mnuUeber.Text = "Ü&ber..."
        '
        'dgvDaten
        '
        Me.dgvDaten.AllowUserToAddRows = False
        Me.dgvDaten.AllowUserToDeleteRows = False
        Me.dgvDaten.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDaten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaten.Location = New System.Drawing.Point(12, 94)
        Me.dgvDaten.Name = "dgvDaten"
        Me.dgvDaten.ReadOnly = True
        Me.dgvDaten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDaten.Size = New System.Drawing.Size(960, 444)
        Me.dgvDaten.TabIndex = 0
        '
        'btnEinstellungen
        '
        Me.btnEinstellungen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEinstellungen.Location = New System.Drawing.Point(872, 10)
        Me.btnEinstellungen.Name = "btnEinstellungen"
        Me.btnEinstellungen.Size = New System.Drawing.Size(100, 25)
        Me.btnEinstellungen.TabIndex = 1
        Me.btnEinstellungen.Text = "Einstellungen..."
        Me.btnEinstellungen.UseVisualStyleBackColor = True
        '
        'btnTabellenLaden
        '
        Me.btnTabellenLaden.Location = New System.Drawing.Point(10, 10)
        Me.btnTabellenLaden.Name = "btnTabellenLaden"
        Me.btnTabellenLaden.Size = New System.Drawing.Size(110, 25)
        Me.btnTabellenLaden.TabIndex = 2
        Me.btnTabellenLaden.Text = "Tabellen laden"
        Me.btnTabellenLaden.UseVisualStyleBackColor = True
        '
        'cboTabellen
        '
        Me.cboTabellen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTabellen.FormattingEnabled = True
        Me.cboTabellen.Location = New System.Drawing.Point(192, 12)
        Me.cboTabellen.Name = "cboTabellen"
        Me.cboTabellen.Size = New System.Drawing.Size(250, 21)
        Me.cboTabellen.TabIndex = 3
        '
        'lblTabelle
        '
        Me.lblTabelle.AutoSize = True
        Me.lblTabelle.Location = New System.Drawing.Point(135, 15)
        Me.lblTabelle.Name = "lblTabelle"
        Me.lblTabelle.Size = New System.Drawing.Size(46, 13)
        Me.lblTabelle.TabIndex = 4
        Me.lblTabelle.Text = "Tabelle:"
        '
        'btnDatenLaden
        '
        Me.btnDatenLaden.Location = New System.Drawing.Point(448, 10)
        Me.btnDatenLaden.Name = "btnDatenLaden"
        Me.btnDatenLaden.Size = New System.Drawing.Size(90, 25)
        Me.btnDatenLaden.TabIndex = 5
        Me.btnDatenLaden.Text = "Daten laden"
        Me.btnDatenLaden.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblAnzahl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 549)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(36, 17)
        Me.lblStatus.Text = "Bereit"
        '
        'lblAnzahl
        '
        Me.lblAnzahl.Name = "lblAnzahl"
        Me.lblAnzahl.Size = New System.Drawing.Size(933, 17)
        Me.lblAnzahl.Spring = True
        Me.lblAnzahl.Text = "Zeilen: 0"
        Me.lblAnzahl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkAutoLaden)
        Me.Panel1.Controls.Add(Me.btnExportieren)
        Me.Panel1.Controls.Add(Me.btnAktualisieren)
        Me.Panel1.Controls.Add(Me.btnNeuerEintrag)
        Me.Panel1.Controls.Add(Me.btnTabellenLaden)
        Me.Panel1.Controls.Add(Me.lblTabelle)
        Me.Panel1.Controls.Add(Me.btnDatenLaden)
        Me.Panel1.Controls.Add(Me.cboTabellen)
        Me.Panel1.Controls.Add(Me.btnEinstellungen)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 47)
        Me.Panel1.TabIndex = 7
        '
        'chkAutoLaden
        '
        Me.chkAutoLaden.AutoSize = True
        Me.chkAutoLaden.Checked = True
        Me.chkAutoLaden.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoLaden.Location = New System.Drawing.Point(544, 14)
        Me.chkAutoLaden.Name = "chkAutoLaden"
        Me.chkAutoLaden.Size = New System.Drawing.Size(123, 17)
        Me.chkAutoLaden.TabIndex = 8
        Me.chkAutoLaden.Text = "Automatisch laden"
        Me.chkAutoLaden.UseVisualStyleBackColor = True
        '
        'btnExportieren
        '
        Me.btnExportieren.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportieren.Location = New System.Drawing.Point(741, 10)
        Me.btnExportieren.Name = "btnExportieren"
        Me.btnExportieren.Size = New System.Drawing.Size(120, 25)
        Me.btnExportieren.TabIndex = 7
        Me.btnExportieren.Text = "Nach CSV exportieren"
        Me.btnExportieren.UseVisualStyleBackColor = True
        '
        'btnAktualisieren
        '
        Me.btnAktualisieren.Location = New System.Drawing.Point(673, 10)
        Me.btnAktualisieren.Name = "btnAktualisieren"
        Me.btnAktualisieren.Size = New System.Drawing.Size(62, 25)
        Me.btnAktualisieren.TabIndex = 6
        Me.btnAktualisieren.Text = "↻"
        Me.btnAktualisieren.UseVisualStyleBackColor = True
        '
        'btnNeuerEintrag
        '
        Me.btnNeuerEintrag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNeuerEintrag.Location = New System.Drawing.Point(635, 10)
        Me.btnNeuerEintrag.Name = "btnNeuerEintrag"
        Me.btnNeuerEintrag.Size = New System.Drawing.Size(32, 25)
        Me.btnNeuerEintrag.TabIndex = 9
        Me.btnNeuerEintrag.Text = "+"
        Me.btnNeuerEintrag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNeuerEintrag.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 571)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvDaten)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schweißnahtprüfung - Datenbank Viewer"
        CType(Me.dgvDaten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDaten As DataGridView
    Friend WithEvents btnEinstellungen As Button
    Friend WithEvents btnTabellenLaden As Button
    Friend WithEvents cboTabellen As ComboBox
    Friend WithEvents lblTabelle As Label
    Friend WithEvents btnDatenLaden As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblAnzahl As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAktualisieren As Button
    Friend WithEvents btnExportieren As Button
    Friend WithEvents chkAutoLaden As CheckBox
    Friend WithEvents btnNeuerEintrag As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuDatei As ToolStripMenuItem
    Friend WithEvents mnuEinstellungen As ToolStripMenuItem
    Friend WithEvents mnuTrenner1 As ToolStripSeparator
    Friend WithEvents mnuBeenden As ToolStripMenuItem
    Friend WithEvents mnuDaten As ToolStripMenuItem
    Friend WithEvents mnuTabellenLaden As ToolStripMenuItem
    Friend WithEvents mnuDatenLaden As ToolStripMenuItem
    Friend WithEvents mnuNeuerEintrag As ToolStripMenuItem
    Friend WithEvents mnuTrenner2 As ToolStripSeparator
    Friend WithEvents mnuAktualisieren As ToolStripMenuItem
    Friend WithEvents mnuExport As ToolStripMenuItem
    Friend WithEvents mnuNachCSV As ToolStripMenuItem
    Friend WithEvents mnuHilfe As ToolStripMenuItem
    Friend WithEvents mnuUeber As ToolStripMenuItem
End Class
