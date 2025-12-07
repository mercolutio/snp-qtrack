<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRenderer
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
        Me.PanelFormular = New System.Windows.Forms.Panel()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.PanelHeader.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.lblTitel)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Padding = New System.Windows.Forms.Padding(15)
        Me.PanelHeader.Size = New System.Drawing.Size(600, 60)
        Me.PanelHeader.TabIndex = 0
        '
        'lblTitel
        '
        Me.lblTitel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitel.ForeColor = System.Drawing.Color.White
        Me.lblTitel.Location = New System.Drawing.Point(15, 15)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(570, 30)
        Me.lblTitel.TabIndex = 0
        Me.lblTitel.Text = "Formular"
        Me.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelFormular
        '
        Me.PanelFormular.AutoScroll = True
        Me.PanelFormular.BackColor = System.Drawing.Color.White
        Me.PanelFormular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormular.Location = New System.Drawing.Point(0, 60)
        Me.PanelFormular.Name = "PanelFormular"
        Me.PanelFormular.Padding = New System.Windows.Forms.Padding(20)
        Me.PanelFormular.Size = New System.Drawing.Size(600, 390)
        Me.PanelFormular.TabIndex = 1
        '
        'PanelButtons
        '
        Me.PanelButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelButtons.Controls.Add(Me.btnSpeichern)
        Me.PanelButtons.Controls.Add(Me.btnAbbrechen)
        Me.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelButtons.Location = New System.Drawing.Point(0, 450)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.PanelButtons.Size = New System.Drawing.Size(600, 60)
        Me.PanelButtons.TabIndex = 2
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpeichern.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeichern.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSpeichern.ForeColor = System.Drawing.Color.White
        Me.btnSpeichern.Location = New System.Drawing.Point(375, 10)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(100, 35)
        Me.btnSpeichern.TabIndex = 0
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = False
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbbrechen.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbbrechen.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnAbbrechen.ForeColor = System.Drawing.Color.White
        Me.btnAbbrechen.Location = New System.Drawing.Point(485, 10)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(100, 35)
        Me.btnAbbrechen.TabIndex = 1
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = False
        '
        'FormRenderer
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(600, 510)
        Me.Controls.Add(Me.PanelFormular)
        Me.Controls.Add(Me.PanelButtons)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRenderer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Formular"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitel As Label
    Friend WithEvents PanelFormular As Panel
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnAbbrechen As Button
End Class
