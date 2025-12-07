<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHauptmenu
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.lblUntertitel = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnDatenAnzeigen = New System.Windows.Forms.Button()
        Me.btnSchweissnahtpruefung = New System.Windows.Forms.Button()
        Me.btnFormDesigner = New System.Windows.Forms.Button()
        Me.btnEinstellungen = New System.Windows.Forms.Button()
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.PanelHeader.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.lblTitel)
        Me.PanelHeader.Controls.Add(Me.lblUntertitel)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(900, 150)
        Me.PanelHeader.TabIndex = 0
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.ForeColor = System.Drawing.Color.White
        Me.lblTitel.Location = New System.Drawing.Point(40, 40)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(420, 51)
        Me.lblTitel.TabIndex = 0
        Me.lblTitel.Text = "Labor Tracking System"
        '
        'lblUntertitel
        '
        Me.lblUntertitel.AutoSize = True
        Me.lblUntertitel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUntertitel.ForeColor = System.Drawing.Color.White
        Me.lblUntertitel.Location = New System.Drawing.Point(45, 100)
        Me.lblUntertitel.Name = "lblUntertitel"
        Me.lblUntertitel.Size = New System.Drawing.Size(286, 21)
        Me.lblUntertitel.TabIndex = 1
        Me.lblUntertitel.Text = "Datenbankverwaltung und Monitoring"
        '
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.btnDatenAnzeigen)
        Me.PanelMenu.Controls.Add(Me.btnSchweissnahtpruefung)
        Me.PanelMenu.Controls.Add(Me.btnFormDesigner)
        Me.PanelMenu.Controls.Add(Me.btnEinstellungen)
        Me.PanelMenu.Controls.Add(Me.btnBeenden)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMenu.Location = New System.Drawing.Point(0, 150)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Padding = New System.Windows.Forms.Padding(50)
        Me.PanelMenu.Size = New System.Drawing.Size(900, 510)
        Me.PanelMenu.TabIndex = 1
        '
        'btnDatenAnzeigen
        '
        Me.btnDatenAnzeigen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDatenAnzeigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnDatenAnzeigen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDatenAnzeigen.FlatAppearance.BorderSize = 0
        Me.btnDatenAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatenAnzeigen.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatenAnzeigen.ForeColor = System.Drawing.Color.White
        Me.btnDatenAnzeigen.Location = New System.Drawing.Point(175, 60)
        Me.btnDatenAnzeigen.Name = "btnDatenAnzeigen"
        Me.btnDatenAnzeigen.Size = New System.Drawing.Size(550, 70)
        Me.btnDatenAnzeigen.TabIndex = 0
        Me.btnDatenAnzeigen.Text = "📋 Prüfauftrag erfassen"
        Me.btnDatenAnzeigen.UseVisualStyleBackColor = False
        '
        'btnSchweissnahtpruefung
        '
        Me.btnSchweissnahtpruefung.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSchweissnahtpruefung.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSchweissnahtpruefung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchweissnahtpruefung.FlatAppearance.BorderSize = 0
        Me.btnSchweissnahtpruefung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchweissnahtpruefung.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchweissnahtpruefung.ForeColor = System.Drawing.Color.White
        Me.btnSchweissnahtpruefung.Location = New System.Drawing.Point(175, 145)
        Me.btnSchweissnahtpruefung.Name = "btnSchweissnahtpruefung"
        Me.btnSchweissnahtpruefung.Size = New System.Drawing.Size(550, 70)
        Me.btnSchweissnahtpruefung.TabIndex = 1
        Me.btnSchweissnahtpruefung.Text = "🔧 Schweißnahtprüfung"
        Me.btnSchweissnahtpruefung.UseVisualStyleBackColor = False
        '
        'btnFormDesigner
        '
        Me.btnFormDesigner.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFormDesigner.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnFormDesigner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormDesigner.FlatAppearance.BorderSize = 0
        Me.btnFormDesigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormDesigner.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormDesigner.ForeColor = System.Drawing.Color.White
        Me.btnFormDesigner.Location = New System.Drawing.Point(175, 230)
        Me.btnFormDesigner.Name = "btnFormDesigner"
        Me.btnFormDesigner.Size = New System.Drawing.Size(550, 70)
        Me.btnFormDesigner.TabIndex = 2
        Me.btnFormDesigner.Text = "🎨 Formular Designer"
        Me.btnFormDesigner.UseVisualStyleBackColor = False
        '
        'btnEinstellungen
        '
        Me.btnEinstellungen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEinstellungen.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnEinstellungen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEinstellungen.FlatAppearance.BorderSize = 0
        Me.btnEinstellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEinstellungen.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEinstellungen.ForeColor = System.Drawing.Color.White
        Me.btnEinstellungen.Location = New System.Drawing.Point(175, 315)
        Me.btnEinstellungen.Name = "btnEinstellungen"
        Me.btnEinstellungen.Size = New System.Drawing.Size(550, 70)
        Me.btnEinstellungen.TabIndex = 3
        Me.btnEinstellungen.Text = "⚙️ Datenbankeinstellungen"
        Me.btnEinstellungen.UseVisualStyleBackColor = False
        '
        'btnBeenden
        '
        Me.btnBeenden.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBeenden.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBeenden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBeenden.FlatAppearance.BorderSize = 0
        Me.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeenden.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeenden.ForeColor = System.Drawing.Color.White
        Me.btnBeenden.Location = New System.Drawing.Point(175, 400)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(550, 70)
        Me.btnBeenden.TabIndex = 4
        Me.btnBeenden.Text = "🚪 Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = False
        '
        'PanelFooter
        '
        Me.PanelFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelFooter.Controls.Add(Me.lblVersion)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 660)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(900, 40)
        Me.PanelFooter.TabIndex = 2
        '
        'lblVersion
        '
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(0, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(900, 40)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Version 1.0 © 2024"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormHauptmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelFooter)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormHauptmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Labor Tracking System - Hauptmenü"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitel As Label
    Friend WithEvents lblUntertitel As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnDatenAnzeigen As Button
    Friend WithEvents btnSchweissnahtpruefung As Button
    Friend WithEvents btnFormDesigner As Button
    Friend WithEvents btnEinstellungen As Button
    Friend WithEvents btnBeenden As Button
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents lblVersion As Label
End Class
