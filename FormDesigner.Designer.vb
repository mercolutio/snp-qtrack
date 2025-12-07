<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDesigner
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
        Me.PanelToolbox = New System.Windows.Forms.Panel()
        Me.lblToolbox = New System.Windows.Forms.Label()
        Me.btnAddTextBox = New System.Windows.Forms.Button()
        Me.btnAddDatePicker = New System.Windows.Forms.Button()
        Me.btnAddComboBox = New System.Windows.Forms.Button()
        Me.btnAddCheckBox = New System.Windows.Forms.Button()
        Me.btnAddLabel = New System.Windows.Forms.Button()
        Me.PanelDesignSurface = New System.Windows.Forms.Panel()
        Me.lblDesignHint = New System.Windows.Forms.Label()
        Me.PanelProperties = New System.Windows.Forms.Panel()
        Me.lblProperties = New System.Windows.Forms.Label()
        Me.lblPropLabelText = New System.Windows.Forms.Label()
        Me.txtPropLabelText = New System.Windows.Forms.TextBox()
        Me.lblPropFeldName = New System.Windows.Forms.Label()
        Me.txtPropFeldName = New System.Windows.Forms.TextBox()
        Me.lblPropDBSpalte = New System.Windows.Forms.Label()
        Me.txtPropDBSpalte = New System.Windows.Forms.TextBox()
        Me.chkPropPflichtfeld = New System.Windows.Forms.CheckBox()
        Me.btnPropLoeschen = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblFormName = New System.Windows.Forms.Label()
        Me.txtFormName = New System.Windows.Forms.TextBox()
        Me.lblTabelle = New System.Windows.Forms.Label()
        Me.txtTabelle = New System.Windows.Forms.TextBox()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnLaden = New System.Windows.Forms.Button()
        Me.btnVorschau = New System.Windows.Forms.Button()
        Me.btnGenerieren = New System.Windows.Forms.Button()
        Me.btnSchliessen = New System.Windows.Forms.Button()
        Me.PanelToolbox.SuspendLayout()
        Me.PanelDesignSurface.SuspendLayout()
        Me.PanelProperties.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelToolbox
        '
        Me.PanelToolbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelToolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelToolbox.Controls.Add(Me.lblToolbox)
        Me.PanelToolbox.Controls.Add(Me.btnAddTextBox)
        Me.PanelToolbox.Controls.Add(Me.btnAddDatePicker)
        Me.PanelToolbox.Controls.Add(Me.btnAddComboBox)
        Me.PanelToolbox.Controls.Add(Me.btnAddCheckBox)
        Me.PanelToolbox.Controls.Add(Me.btnAddLabel)
        Me.PanelToolbox.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelToolbox.Location = New System.Drawing.Point(0, 80)
        Me.PanelToolbox.Name = "PanelToolbox"
        Me.PanelToolbox.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelToolbox.Size = New System.Drawing.Size(180, 570)
        Me.PanelToolbox.TabIndex = 0
        '
        'lblToolbox
        '
        Me.lblToolbox.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblToolbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblToolbox.Location = New System.Drawing.Point(10, 10)
        Me.lblToolbox.Name = "lblToolbox"
        Me.lblToolbox.Size = New System.Drawing.Size(158, 30)
        Me.lblToolbox.TabIndex = 0
        Me.lblToolbox.Text = "Toolbox"
        Me.lblToolbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddTextBox
        '
        Me.btnAddTextBox.BackColor = System.Drawing.Color.White
        Me.btnAddTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTextBox.Location = New System.Drawing.Point(10, 50)
        Me.btnAddTextBox.Name = "btnAddTextBox"
        Me.btnAddTextBox.Size = New System.Drawing.Size(158, 35)
        Me.btnAddTextBox.TabIndex = 1
        Me.btnAddTextBox.Text = "📝 Textfeld"
        Me.btnAddTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddTextBox.UseVisualStyleBackColor = False
        '
        'btnAddDatePicker
        '
        Me.btnAddDatePicker.BackColor = System.Drawing.Color.White
        Me.btnAddDatePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDatePicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDatePicker.Location = New System.Drawing.Point(10, 90)
        Me.btnAddDatePicker.Name = "btnAddDatePicker"
        Me.btnAddDatePicker.Size = New System.Drawing.Size(158, 35)
        Me.btnAddDatePicker.TabIndex = 2
        Me.btnAddDatePicker.Text = "📅 Datum"
        Me.btnAddDatePicker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDatePicker.UseVisualStyleBackColor = False
        '
        'btnAddComboBox
        '
        Me.btnAddComboBox.BackColor = System.Drawing.Color.White
        Me.btnAddComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddComboBox.Location = New System.Drawing.Point(10, 130)
        Me.btnAddComboBox.Name = "btnAddComboBox"
        Me.btnAddComboBox.Size = New System.Drawing.Size(158, 35)
        Me.btnAddComboBox.TabIndex = 3
        Me.btnAddComboBox.Text = "📋 Auswahl"
        Me.btnAddComboBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddComboBox.UseVisualStyleBackColor = False
        '
        'btnAddCheckBox
        '
        Me.btnAddCheckBox.BackColor = System.Drawing.Color.White
        Me.btnAddCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCheckBox.Location = New System.Drawing.Point(10, 170)
        Me.btnAddCheckBox.Name = "btnAddCheckBox"
        Me.btnAddCheckBox.Size = New System.Drawing.Size(158, 35)
        Me.btnAddCheckBox.TabIndex = 4
        Me.btnAddCheckBox.Text = "☑️ Checkbox"
        Me.btnAddCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddCheckBox.UseVisualStyleBackColor = False
        '
        'btnAddLabel
        '
        Me.btnAddLabel.BackColor = System.Drawing.Color.White
        Me.btnAddLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLabel.Location = New System.Drawing.Point(10, 210)
        Me.btnAddLabel.Name = "btnAddLabel"
        Me.btnAddLabel.Size = New System.Drawing.Size(158, 35)
        Me.btnAddLabel.TabIndex = 5
        Me.btnAddLabel.Text = "🏷️ Überschrift"
        Me.btnAddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddLabel.UseVisualStyleBackColor = False
        '
        'PanelDesignSurface
        '
        Me.PanelDesignSurface.AllowDrop = True
        Me.PanelDesignSurface.BackColor = System.Drawing.Color.White
        Me.PanelDesignSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDesignSurface.Controls.Add(Me.lblDesignHint)
        Me.PanelDesignSurface.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesignSurface.Location = New System.Drawing.Point(180, 80)
        Me.PanelDesignSurface.Name = "PanelDesignSurface"
        Me.PanelDesignSurface.Size = New System.Drawing.Size(620, 570)
        Me.PanelDesignSurface.TabIndex = 1
        '
        'lblDesignHint
        '
        Me.lblDesignHint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDesignHint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblDesignHint.ForeColor = System.Drawing.Color.Gray
        Me.lblDesignHint.Location = New System.Drawing.Point(0, 0)
        Me.lblDesignHint.Name = "lblDesignHint"
        Me.lblDesignHint.Size = New System.Drawing.Size(618, 568)
        Me.lblDesignHint.TabIndex = 0
        Me.lblDesignHint.Text = "Ziehen Sie Felder aus der Toolbox hierher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Klicken Sie auf ein Feld um es zu bearbeiten"
        Me.lblDesignHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelProperties
        '
        Me.PanelProperties.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelProperties.Controls.Add(Me.lblProperties)
        Me.PanelProperties.Controls.Add(Me.lblPropLabelText)
        Me.PanelProperties.Controls.Add(Me.txtPropLabelText)
        Me.PanelProperties.Controls.Add(Me.lblPropFeldName)
        Me.PanelProperties.Controls.Add(Me.txtPropFeldName)
        Me.PanelProperties.Controls.Add(Me.lblPropDBSpalte)
        Me.PanelProperties.Controls.Add(Me.txtPropDBSpalte)
        Me.PanelProperties.Controls.Add(Me.chkPropPflichtfeld)
        Me.PanelProperties.Controls.Add(Me.btnPropLoeschen)
        Me.PanelProperties.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelProperties.Location = New System.Drawing.Point(800, 80)
        Me.PanelProperties.Name = "PanelProperties"
        Me.PanelProperties.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelProperties.Size = New System.Drawing.Size(250, 570)
        Me.PanelProperties.TabIndex = 2
        '
        'lblProperties
        '
        Me.lblProperties.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProperties.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProperties.Location = New System.Drawing.Point(10, 10)
        Me.lblProperties.Name = "lblProperties"
        Me.lblProperties.Size = New System.Drawing.Size(228, 30)
        Me.lblProperties.TabIndex = 0
        Me.lblProperties.Text = "Eigenschaften"
        Me.lblProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPropLabelText
        '
        Me.lblPropLabelText.AutoSize = True
        Me.lblPropLabelText.Location = New System.Drawing.Point(10, 55)
        Me.lblPropLabelText.Name = "lblPropLabelText"
        Me.lblPropLabelText.Size = New System.Drawing.Size(67, 13)
        Me.lblPropLabelText.TabIndex = 1
        Me.lblPropLabelText.Text = "Beschriftung:"
        '
        'txtPropLabelText
        '
        Me.txtPropLabelText.Location = New System.Drawing.Point(10, 71)
        Me.txtPropLabelText.Name = "txtPropLabelText"
        Me.txtPropLabelText.Size = New System.Drawing.Size(228, 20)
        Me.txtPropLabelText.TabIndex = 2
        '
        'lblPropFeldName
        '
        Me.lblPropFeldName.AutoSize = True
        Me.lblPropFeldName.Location = New System.Drawing.Point(10, 105)
        Me.lblPropFeldName.Name = "lblPropFeldName"
        Me.lblPropFeldName.Size = New System.Drawing.Size(60, 13)
        Me.lblPropFeldName.TabIndex = 3
        Me.lblPropFeldName.Text = "Feldname:"
        '
        'txtPropFeldName
        '
        Me.txtPropFeldName.Location = New System.Drawing.Point(10, 121)
        Me.txtPropFeldName.Name = "txtPropFeldName"
        Me.txtPropFeldName.Size = New System.Drawing.Size(228, 20)
        Me.txtPropFeldName.TabIndex = 4
        '
        'lblPropDBSpalte
        '
        Me.lblPropDBSpalte.AutoSize = True
        Me.lblPropDBSpalte.Location = New System.Drawing.Point(10, 155)
        Me.lblPropDBSpalte.Name = "lblPropDBSpalte"
        Me.lblPropDBSpalte.Size = New System.Drawing.Size(95, 13)
        Me.lblPropDBSpalte.TabIndex = 5
        Me.lblPropDBSpalte.Text = "Datenbank-Spalte:"
        '
        'txtPropDBSpalte
        '
        Me.txtPropDBSpalte.Location = New System.Drawing.Point(10, 171)
        Me.txtPropDBSpalte.Name = "txtPropDBSpalte"
        Me.txtPropDBSpalte.Size = New System.Drawing.Size(228, 20)
        Me.txtPropDBSpalte.TabIndex = 6
        '
        'chkPropPflichtfeld
        '
        Me.chkPropPflichtfeld.AutoSize = True
        Me.chkPropPflichtfeld.Location = New System.Drawing.Point(10, 205)
        Me.chkPropPflichtfeld.Name = "chkPropPflichtfeld"
        Me.chkPropPflichtfeld.Size = New System.Drawing.Size(74, 17)
        Me.chkPropPflichtfeld.TabIndex = 7
        Me.chkPropPflichtfeld.Text = "Pflichtfeld"
        Me.chkPropPflichtfeld.UseVisualStyleBackColor = True
        '
        'btnPropLoeschen
        '
        Me.btnPropLoeschen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPropLoeschen.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnPropLoeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPropLoeschen.ForeColor = System.Drawing.Color.White
        Me.btnPropLoeschen.Location = New System.Drawing.Point(10, 520)
        Me.btnPropLoeschen.Name = "btnPropLoeschen"
        Me.btnPropLoeschen.Size = New System.Drawing.Size(228, 30)
        Me.btnPropLoeschen.TabIndex = 8
        Me.btnPropLoeschen.Text = "Feld löschen"
        Me.btnPropLoeschen.UseVisualStyleBackColor = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.lblFormName)
        Me.PanelTop.Controls.Add(Me.txtFormName)
        Me.PanelTop.Controls.Add(Me.lblTabelle)
        Me.PanelTop.Controls.Add(Me.txtTabelle)
        Me.PanelTop.Controls.Add(Me.btnSpeichern)
        Me.PanelTop.Controls.Add(Me.btnLaden)
        Me.PanelTop.Controls.Add(Me.btnVorschau)
        Me.PanelTop.Controls.Add(Me.btnGenerieren)
        Me.PanelTop.Controls.Add(Me.btnSchliessen)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelTop.Size = New System.Drawing.Size(1050, 80)
        Me.PanelTop.TabIndex = 3
        '
        'lblFormName
        '
        Me.lblFormName.AutoSize = True
        Me.lblFormName.ForeColor = System.Drawing.Color.White
        Me.lblFormName.Location = New System.Drawing.Point(10, 15)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(80, 13)
        Me.lblFormName.TabIndex = 0
        Me.lblFormName.Text = "Formular-Name:"
        '
        'txtFormName
        '
        Me.txtFormName.Location = New System.Drawing.Point(100, 12)
        Me.txtFormName.Name = "txtFormName"
        Me.txtFormName.Size = New System.Drawing.Size(200, 20)
        Me.txtFormName.TabIndex = 1
        '
        'lblTabelle
        '
        Me.lblTabelle.AutoSize = True
        Me.lblTabelle.ForeColor = System.Drawing.Color.White
        Me.lblTabelle.Location = New System.Drawing.Point(320, 15)
        Me.lblTabelle.Name = "lblTabelle"
        Me.lblTabelle.Size = New System.Drawing.Size(45, 13)
        Me.lblTabelle.TabIndex = 2
        Me.lblTabelle.Text = "Tabelle:"
        '
        'txtTabelle
        '
        Me.txtTabelle.Location = New System.Drawing.Point(375, 12)
        Me.txtTabelle.Name = "txtTabelle"
        Me.txtTabelle.Size = New System.Drawing.Size(200, 20)
        Me.txtTabelle.TabIndex = 3
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpeichern.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeichern.ForeColor = System.Drawing.Color.White
        Me.btnSpeichern.Location = New System.Drawing.Point(10, 45)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(120, 25)
        Me.btnSpeichern.TabIndex = 4
        Me.btnSpeichern.Text = "💾 Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = False
        '
        'btnLaden
        '
        Me.btnLaden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLaden.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLaden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaden.ForeColor = System.Drawing.Color.White
        Me.btnLaden.Location = New System.Drawing.Point(136, 45)
        Me.btnLaden.Name = "btnLaden"
        Me.btnLaden.Size = New System.Drawing.Size(120, 25)
        Me.btnLaden.TabIndex = 5
        Me.btnLaden.Text = "📂 Laden"
        Me.btnLaden.UseVisualStyleBackColor = False
        '
        'btnVorschau
        '
        Me.btnVorschau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVorschau.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnVorschau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVorschau.ForeColor = System.Drawing.Color.White
        Me.btnVorschau.Location = New System.Drawing.Point(262, 45)
        Me.btnVorschau.Name = "btnVorschau"
        Me.btnVorschau.Size = New System.Drawing.Size(120, 25)
        Me.btnVorschau.TabIndex = 6
        Me.btnVorschau.Text = "👁️ Vorschau"
        Me.btnVorschau.UseVisualStyleBackColor = False
        '
        'btnGenerieren
        '
        Me.btnGenerieren.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerieren.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnGenerieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerieren.ForeColor = System.Drawing.Color.White
        Me.btnGenerieren.Location = New System.Drawing.Point(388, 45)
        Me.btnGenerieren.Name = "btnGenerieren"
        Me.btnGenerieren.Size = New System.Drawing.Size(180, 25)
        Me.btnGenerieren.TabIndex = 7
        Me.btnGenerieren.Text = "🔄 Aus DB generieren"
        Me.btnGenerieren.UseVisualStyleBackColor = False
        '
        'btnSchliessen
        '
        Me.btnSchliessen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSchliessen.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSchliessen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchliessen.ForeColor = System.Drawing.Color.White
        Me.btnSchliessen.Location = New System.Drawing.Point(920, 45)
        Me.btnSchliessen.Name = "btnSchliessen"
        Me.btnSchliessen.Size = New System.Drawing.Size(120, 25)
        Me.btnSchliessen.TabIndex = 7
        Me.btnSchliessen.Text = "Schließen"
        Me.btnSchliessen.UseVisualStyleBackColor = False
        '
        'FormDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 650)
        Me.Controls.Add(Me.PanelDesignSurface)
        Me.Controls.Add(Me.PanelProperties)
        Me.Controls.Add(Me.PanelToolbox)
        Me.Controls.Add(Me.PanelTop)
        Me.MinimumSize = New System.Drawing.Size(1066, 689)
        Me.Name = "FormDesigner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formular Designer - Prüfauftrag konfigurieren"
        Me.PanelToolbox.ResumeLayout(False)
        Me.PanelDesignSurface.ResumeLayout(False)
        Me.PanelProperties.ResumeLayout(False)
        Me.PanelProperties.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelToolbox As Panel
    Friend WithEvents lblToolbox As Label
    Friend WithEvents btnAddTextBox As Button
    Friend WithEvents btnAddDatePicker As Button
    Friend WithEvents btnAddComboBox As Button
    Friend WithEvents btnAddCheckBox As Button
    Friend WithEvents PanelDesignSurface As Panel
    Friend WithEvents lblDesignHint As Label
    Friend WithEvents PanelProperties As Panel
    Friend WithEvents lblProperties As Label
    Friend WithEvents lblPropLabelText As Label
    Friend WithEvents txtPropLabelText As TextBox
    Friend WithEvents lblPropFeldName As Label
    Friend WithEvents txtPropFeldName As TextBox
    Friend WithEvents lblPropDBSpalte As Label
    Friend WithEvents txtPropDBSpalte As TextBox
    Friend WithEvents chkPropPflichtfeld As CheckBox
    Friend WithEvents btnPropLoeschen As Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblFormName As Label
    Friend WithEvents txtFormName As TextBox
    Friend WithEvents lblTabelle As Label
    Friend WithEvents txtTabelle As TextBox
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnLaden As Button
    Friend WithEvents btnVorschau As Button
    Friend WithEvents btnGenerieren As Button
    Friend WithEvents btnSchliessen As Button
    Friend WithEvents btnAddLabel As Button
End Class
