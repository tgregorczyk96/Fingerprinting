<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuDatei = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNeu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBildOeffnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBildSpeichern = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEigenschaften = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnueAnsicht = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuZoomen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHorizontalSpiegeln = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVertikalSpiegeln = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrginalGroesse = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAnsFensterAnpassen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuZeichnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPixelZeichnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLinieZeichnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRechteckZeichnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHilfe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsMain = New System.Windows.Forms.StatusStrip()
        Me.sslZoom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslX = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslPixelwert = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslModus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.pnlImageHost = New System.Windows.Forms.Panel()
        Me.pbImage2 = New System.Windows.Forms.PictureBox()
        Me.lblDropHint = New System.Windows.Forms.Label()
        Me.pbImage1 = New System.Windows.Forms.PictureBox()
        Me.tabSide = New System.Windows.Forms.TabControl()
        Me.tbDetails = New System.Windows.Forms.TabPage()
        Me.lblGrauwertWert = New System.Windows.Forms.Label()
        Me.lblYWert = New System.Windows.Forms.Label()
        Me.lblXWert = New System.Windows.Forms.Label()
        Me.lblMaxGrauwertWert = New System.Windows.Forms.Label()
        Me.lblBildgroesseWert = New System.Windows.Forms.Label()
        Me.lblFormatWert = New System.Windows.Forms.Label()
        Me.lblDateiNameWert = New System.Windows.Forms.Label()
        Me.lblGrauwert = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblMaxGrauwert = New System.Windows.Forms.Label()
        Me.lblBildgroesse = New System.Windows.Forms.Label()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.lblDateiName = New System.Windows.Forms.Label()
        Me.tpAnsicht = New System.Windows.Forms.TabPage()
        Me.btnZoomIn = New System.Windows.Forms.Button()
        Me.btnZoomOut = New System.Windows.Forms.Button()
        Me.lblZoomWert = New System.Windows.Forms.Label()
        Me.lblZoomTitel = New System.Windows.Forms.Label()
        Me.btnOrginalGroesse = New System.Windows.Forms.Button()
        Me.btnHorizontalSpiegeln = New System.Windows.Forms.Button()
        Me.btnVertikalSpiegeln = New System.Windows.Forms.Button()
        Me.btnAnsFensterAnpassen = New System.Windows.Forms.Button()
        Me.tpZeichnen = New System.Windows.Forms.TabPage()
        Me.grpWerkzeug = New System.Windows.Forms.GroupBox()
        Me.rdoRechteck = New System.Windows.Forms.Button()
        Me.rdoLinie = New System.Windows.Forms.Button()
        Me.rdoPixel = New System.Windows.Forms.Button()
        Me.rdoPanning = New System.Windows.Forms.Button()
        Me.rdoZeiger = New System.Windows.Forms.Button()
        Me.grpWerkzeugWerte = New System.Windows.Forms.GroupBox()
        Me.nudPixeldicke = New System.Windows.Forms.NumericUpDown()
        Me.nudGrauwert = New System.Windows.Forms.NumericUpDown()
        Me.lblPixeldickeTitel = New System.Windows.Forms.Label()
        Me.lblGrauwertTitel = New System.Windows.Forms.Label()
        Me.grpWerkzeugart = New System.Windows.Forms.GroupBox()
        Me.lblWerkzeugTitelWert = New System.Windows.Forms.Label()
        Me.lblWerkzeugTitel = New System.Windows.Forms.Label()
        Me.tpFingerprinting = New System.Windows.Forms.TabPage()
        Me.lblErgebnis = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtBoxHashB = New System.Windows.Forms.TextBox()
        Me.txtBoxHashA = New System.Windows.Forms.TextBox()
        Me.lblHashB = New System.Windows.Forms.Label()
        Me.lblHashA = New System.Windows.Forms.Label()
        Me.btnVergleichen = New System.Windows.Forms.Button()
        Me.btnFingerprintBerechnen = New System.Windows.Forms.Button()
        Me.btnBildBLaden = New System.Windows.Forms.Button()
        Me.btnBildALaden = New System.Windows.Forms.Button()
        Me.mnuMain.SuspendLayout()
        Me.stsMain.SuspendLayout()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        Me.pnlImageHost.SuspendLayout()
        CType(Me.pbImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSide.SuspendLayout()
        Me.tbDetails.SuspendLayout()
        Me.tpAnsicht.SuspendLayout()
        Me.tpZeichnen.SuspendLayout()
        Me.grpWerkzeug.SuspendLayout()
        Me.grpWerkzeugWerte.SuspendLayout()
        CType(Me.nudPixeldicke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGrauwert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWerkzeugart.SuspendLayout()
        Me.tpFingerprinting.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDatei, Me.mnueAnsicht, Me.mnuZeichnen, Me.mnuHilfe})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.mnuMain.Size = New System.Drawing.Size(875, 24)
        Me.mnuMain.TabIndex = 1
        '
        'mnuDatei
        '
        Me.mnuDatei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNeu, Me.mnuBildOeffnen, Me.mnuBildSpeichern, Me.mnuEigenschaften})
        Me.mnuDatei.Name = "mnuDatei"
        Me.mnuDatei.Size = New System.Drawing.Size(46, 22)
        Me.mnuDatei.Text = "Datei"
        '
        'mnuNeu
        '
        Me.mnuNeu.Name = "mnuNeu"
        Me.mnuNeu.Size = New System.Drawing.Size(148, 22)
        Me.mnuNeu.Text = "Neu"
        '
        'mnuBildOeffnen
        '
        Me.mnuBildOeffnen.Name = "mnuBildOeffnen"
        Me.mnuBildOeffnen.Size = New System.Drawing.Size(148, 22)
        Me.mnuBildOeffnen.Text = "Bild öffnen"
        '
        'mnuBildSpeichern
        '
        Me.mnuBildSpeichern.Name = "mnuBildSpeichern"
        Me.mnuBildSpeichern.Size = New System.Drawing.Size(148, 22)
        Me.mnuBildSpeichern.Text = "Bild speichern"
        '
        'mnuEigenschaften
        '
        Me.mnuEigenschaften.Name = "mnuEigenschaften"
        Me.mnuEigenschaften.Size = New System.Drawing.Size(148, 22)
        Me.mnuEigenschaften.Text = "Eigenschaften"
        '
        'mnueAnsicht
        '
        Me.mnueAnsicht.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuZoomen, Me.mnuHorizontalSpiegeln, Me.mnuVertikalSpiegeln, Me.mnuOrginalGroesse, Me.mnuAnsFensterAnpassen})
        Me.mnueAnsicht.Name = "mnueAnsicht"
        Me.mnueAnsicht.Size = New System.Drawing.Size(59, 22)
        Me.mnueAnsicht.Text = "Ansicht"
        '
        'mnuZoomen
        '
        Me.mnuZoomen.Name = "mnuZoomen"
        Me.mnuZoomen.Size = New System.Drawing.Size(187, 22)
        Me.mnuZoomen.Text = "Zoomen"
        '
        'mnuHorizontalSpiegeln
        '
        Me.mnuHorizontalSpiegeln.Name = "mnuHorizontalSpiegeln"
        Me.mnuHorizontalSpiegeln.Size = New System.Drawing.Size(187, 22)
        Me.mnuHorizontalSpiegeln.Text = "Horizontal spiegeln"
        '
        'mnuVertikalSpiegeln
        '
        Me.mnuVertikalSpiegeln.Name = "mnuVertikalSpiegeln"
        Me.mnuVertikalSpiegeln.Size = New System.Drawing.Size(187, 22)
        Me.mnuVertikalSpiegeln.Text = "Vertikal spiegeln"
        '
        'mnuOrginalGroesse
        '
        Me.mnuOrginalGroesse.Name = "mnuOrginalGroesse"
        Me.mnuOrginalGroesse.Size = New System.Drawing.Size(187, 22)
        Me.mnuOrginalGroesse.Text = "Original Größe"
        '
        'mnuAnsFensterAnpassen
        '
        Me.mnuAnsFensterAnpassen.Name = "mnuAnsFensterAnpassen"
        Me.mnuAnsFensterAnpassen.Size = New System.Drawing.Size(187, 22)
        Me.mnuAnsFensterAnpassen.Text = "Ans Fenster anpassen"
        '
        'mnuZeichnen
        '
        Me.mnuZeichnen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPixelZeichnen, Me.mnuLinieZeichnen, Me.mnuRechteckZeichnen})
        Me.mnuZeichnen.Name = "mnuZeichnen"
        Me.mnuZeichnen.Size = New System.Drawing.Size(68, 22)
        Me.mnuZeichnen.Text = "Zeichnen"
        '
        'mnuPixelZeichnen
        '
        Me.mnuPixelZeichnen.Name = "mnuPixelZeichnen"
        Me.mnuPixelZeichnen.Size = New System.Drawing.Size(172, 22)
        Me.mnuPixelZeichnen.Text = "Pixel zeichnen"
        '
        'mnuLinieZeichnen
        '
        Me.mnuLinieZeichnen.Name = "mnuLinieZeichnen"
        Me.mnuLinieZeichnen.Size = New System.Drawing.Size(172, 22)
        Me.mnuLinieZeichnen.Text = "Linie Zeichnen"
        '
        'mnuRechteckZeichnen
        '
        Me.mnuRechteckZeichnen.Name = "mnuRechteckZeichnen"
        Me.mnuRechteckZeichnen.Size = New System.Drawing.Size(172, 22)
        Me.mnuRechteckZeichnen.Text = "Rechteck zeichnen"
        '
        'mnuHilfe
        '
        Me.mnuHilfe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInfo})
        Me.mnuHilfe.Name = "mnuHilfe"
        Me.mnuHilfe.Size = New System.Drawing.Size(44, 22)
        Me.mnuHilfe.Text = "Hilfe"
        '
        'mnuInfo
        '
        Me.mnuInfo.Name = "mnuInfo"
        Me.mnuInfo.Size = New System.Drawing.Size(95, 22)
        Me.mnuInfo.Text = "Info"
        '
        'stsMain
        '
        Me.stsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslZoom, Me.sslX, Me.sslY, Me.sslPixelwert, Me.sslModus})
        Me.stsMain.Location = New System.Drawing.Point(0, 505)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.stsMain.Size = New System.Drawing.Size(875, 22)
        Me.stsMain.TabIndex = 2
        Me.stsMain.Text = "StatusStrip1"
        '
        'sslZoom
        '
        Me.sslZoom.Name = "sslZoom"
        Me.sslZoom.Size = New System.Drawing.Size(73, 17)
        Me.sslZoom.Text = "Zoom: 100%"
        '
        'sslX
        '
        Me.sslX.Name = "sslX"
        Me.sslX.Size = New System.Drawing.Size(25, 17)
        Me.sslX.Text = "X: -"
        '
        'sslY
        '
        Me.sslY.Name = "sslY"
        Me.sslY.Size = New System.Drawing.Size(25, 17)
        Me.sslY.Text = "Y: -"
        '
        'sslPixelwert
        '
        Me.sslPixelwert.Name = "sslPixelwert"
        Me.sslPixelwert.Size = New System.Drawing.Size(43, 17)
        Me.sslPixelwert.Text = "Pixel: -"
        '
        'sslModus
        '
        Me.sslModus.Name = "sslModus"
        Me.sslModus.Size = New System.Drawing.Size(90, 17)
        Me.sslModus.Text = "Modus: Ansicht"
        '
        'spcMain
        '
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.Location = New System.Drawing.Point(0, 24)
        Me.spcMain.Margin = New System.Windows.Forms.Padding(1)
        Me.spcMain.Name = "spcMain"
        '
        'spcMain.Panel1
        '
        Me.spcMain.Panel1.AutoScroll = True
        Me.spcMain.Panel1.Controls.Add(Me.pnlImageHost)
        '
        'spcMain.Panel2
        '
        Me.spcMain.Panel2.Controls.Add(Me.tabSide)
        Me.spcMain.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.spcMain.Size = New System.Drawing.Size(875, 481)
        Me.spcMain.SplitterDistance = 593
        Me.spcMain.SplitterWidth = 2
        Me.spcMain.TabIndex = 3
        '
        'pnlImageHost
        '
        Me.pnlImageHost.AutoScroll = True
        Me.pnlImageHost.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlImageHost.Controls.Add(Me.pbImage2)
        Me.pnlImageHost.Controls.Add(Me.lblDropHint)
        Me.pnlImageHost.Controls.Add(Me.pbImage1)
        Me.pnlImageHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlImageHost.Location = New System.Drawing.Point(0, 0)
        Me.pnlImageHost.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlImageHost.Name = "pnlImageHost"
        Me.pnlImageHost.Size = New System.Drawing.Size(593, 481)
        Me.pnlImageHost.TabIndex = 0
        '
        'pbImage2
        '
        Me.pbImage2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbImage2.Location = New System.Drawing.Point(295, 0)
        Me.pbImage2.Name = "pbImage2"
        Me.pbImage2.Size = New System.Drawing.Size(304, 464)
        Me.pbImage2.TabIndex = 2
        Me.pbImage2.TabStop = False
        '
        'lblDropHint
        '
        Me.lblDropHint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDropHint.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblDropHint.Location = New System.Drawing.Point(295, 0)
        Me.lblDropHint.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDropHint.Name = "lblDropHint"
        Me.lblDropHint.Size = New System.Drawing.Size(304, 464)
        Me.lblDropHint.TabIndex = 1
        Me.lblDropHint.Text = "Bild per Datei > Bild öffnen laden oder per Drag and Drop hier ablegen"
        Me.lblDropHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbImage1
        '
        Me.pbImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbImage1.Location = New System.Drawing.Point(0, 0)
        Me.pbImage1.Margin = New System.Windows.Forms.Padding(1)
        Me.pbImage1.Name = "pbImage1"
        Me.pbImage1.Size = New System.Drawing.Size(295, 464)
        Me.pbImage1.TabIndex = 0
        Me.pbImage1.TabStop = False
        '
        'tabSide
        '
        Me.tabSide.Controls.Add(Me.tbDetails)
        Me.tabSide.Controls.Add(Me.tpAnsicht)
        Me.tabSide.Controls.Add(Me.tpZeichnen)
        Me.tabSide.Controls.Add(Me.tpFingerprinting)
        Me.tabSide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSide.Location = New System.Drawing.Point(0, 0)
        Me.tabSide.Margin = New System.Windows.Forms.Padding(1)
        Me.tabSide.Name = "tabSide"
        Me.tabSide.SelectedIndex = 0
        Me.tabSide.Size = New System.Drawing.Size(280, 481)
        Me.tabSide.TabIndex = 0
        '
        'tbDetails
        '
        Me.tbDetails.Controls.Add(Me.lblGrauwertWert)
        Me.tbDetails.Controls.Add(Me.lblYWert)
        Me.tbDetails.Controls.Add(Me.lblXWert)
        Me.tbDetails.Controls.Add(Me.lblMaxGrauwertWert)
        Me.tbDetails.Controls.Add(Me.lblBildgroesseWert)
        Me.tbDetails.Controls.Add(Me.lblFormatWert)
        Me.tbDetails.Controls.Add(Me.lblDateiNameWert)
        Me.tbDetails.Controls.Add(Me.lblGrauwert)
        Me.tbDetails.Controls.Add(Me.lblY)
        Me.tbDetails.Controls.Add(Me.lblX)
        Me.tbDetails.Controls.Add(Me.lblMaxGrauwert)
        Me.tbDetails.Controls.Add(Me.lblBildgroesse)
        Me.tbDetails.Controls.Add(Me.lblFormat)
        Me.tbDetails.Controls.Add(Me.lblDateiName)
        Me.tbDetails.Location = New System.Drawing.Point(4, 22)
        Me.tbDetails.Margin = New System.Windows.Forms.Padding(1)
        Me.tbDetails.Name = "tbDetails"
        Me.tbDetails.Padding = New System.Windows.Forms.Padding(1)
        Me.tbDetails.Size = New System.Drawing.Size(272, 455)
        Me.tbDetails.TabIndex = 0
        Me.tbDetails.Text = "Details"
        Me.tbDetails.UseVisualStyleBackColor = True
        '
        'lblGrauwertWert
        '
        Me.lblGrauwertWert.AutoSize = True
        Me.lblGrauwertWert.Location = New System.Drawing.Point(103, 135)
        Me.lblGrauwertWert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGrauwertWert.Name = "lblGrauwertWert"
        Me.lblGrauwertWert.Size = New System.Drawing.Size(10, 13)
        Me.lblGrauwertWert.TabIndex = 13
        Me.lblGrauwertWert.Text = "-"
        '
        'lblYWert
        '
        Me.lblYWert.AutoSize = True
        Me.lblYWert.Location = New System.Drawing.Point(103, 116)
        Me.lblYWert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblYWert.Name = "lblYWert"
        Me.lblYWert.Size = New System.Drawing.Size(10, 13)
        Me.lblYWert.TabIndex = 12
        Me.lblYWert.Text = "-"
        '
        'lblXWert
        '
        Me.lblXWert.AutoSize = True
        Me.lblXWert.Location = New System.Drawing.Point(103, 96)
        Me.lblXWert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblXWert.Name = "lblXWert"
        Me.lblXWert.Size = New System.Drawing.Size(10, 13)
        Me.lblXWert.TabIndex = 11
        Me.lblXWert.Text = "-"
        '
        'lblMaxGrauwertWert
        '
        Me.lblMaxGrauwertWert.AutoSize = True
        Me.lblMaxGrauwertWert.Location = New System.Drawing.Point(103, 74)
        Me.lblMaxGrauwertWert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMaxGrauwertWert.Name = "lblMaxGrauwertWert"
        Me.lblMaxGrauwertWert.Size = New System.Drawing.Size(10, 13)
        Me.lblMaxGrauwertWert.TabIndex = 10
        Me.lblMaxGrauwertWert.Text = "-"
        '
        'lblBildgroesseWert
        '
        Me.lblBildgroesseWert.AutoSize = True
        Me.lblBildgroesseWert.Location = New System.Drawing.Point(103, 55)
        Me.lblBildgroesseWert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBildgroesseWert.Name = "lblBildgroesseWert"
        Me.lblBildgroesseWert.Size = New System.Drawing.Size(10, 13)
        Me.lblBildgroesseWert.TabIndex = 9
        Me.lblBildgroesseWert.Text = "-"
        '
        'lblFormatWert
        '
        Me.lblFormatWert.AutoSize = True
        Me.lblFormatWert.Location = New System.Drawing.Point(103, 35)
        Me.lblFormatWert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFormatWert.Name = "lblFormatWert"
        Me.lblFormatWert.Size = New System.Drawing.Size(10, 13)
        Me.lblFormatWert.TabIndex = 8
        Me.lblFormatWert.Text = "-"
        '
        'lblDateiNameWert
        '
        Me.lblDateiNameWert.AutoSize = True
        Me.lblDateiNameWert.Location = New System.Drawing.Point(103, 16)
        Me.lblDateiNameWert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDateiNameWert.Name = "lblDateiNameWert"
        Me.lblDateiNameWert.Size = New System.Drawing.Size(10, 13)
        Me.lblDateiNameWert.TabIndex = 7
        Me.lblDateiNameWert.Text = "-"
        '
        'lblGrauwert
        '
        Me.lblGrauwert.AutoSize = True
        Me.lblGrauwert.Location = New System.Drawing.Point(10, 135)
        Me.lblGrauwert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGrauwert.Name = "lblGrauwert"
        Me.lblGrauwert.Size = New System.Drawing.Size(56, 13)
        Me.lblGrauwert.TabIndex = 6
        Me.lblGrauwert.Text = "Grauwert: "
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(10, 116)
        Me.lblY.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(20, 13)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y: "
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(10, 96)
        Me.lblX.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(20, 13)
        Me.lblX.TabIndex = 4
        Me.lblX.Text = "X: "
        '
        'lblMaxGrauwert
        '
        Me.lblMaxGrauwert.AutoSize = True
        Me.lblMaxGrauwert.Location = New System.Drawing.Point(10, 74)
        Me.lblMaxGrauwert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMaxGrauwert.Name = "lblMaxGrauwert"
        Me.lblMaxGrauwert.Size = New System.Drawing.Size(79, 13)
        Me.lblMaxGrauwert.TabIndex = 3
        Me.lblMaxGrauwert.Text = "Max. Grauwert:"
        '
        'lblBildgroesse
        '
        Me.lblBildgroesse.AutoSize = True
        Me.lblBildgroesse.Location = New System.Drawing.Point(10, 55)
        Me.lblBildgroesse.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBildgroesse.Name = "lblBildgroesse"
        Me.lblBildgroesse.Size = New System.Drawing.Size(57, 13)
        Me.lblBildgroesse.TabIndex = 2
        Me.lblBildgroesse.Text = "Bildgröße: "
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(10, 35)
        Me.lblFormat.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(45, 13)
        Me.lblFormat.TabIndex = 1
        Me.lblFormat.Text = "Format: "
        '
        'lblDateiName
        '
        Me.lblDateiName.AutoSize = True
        Me.lblDateiName.Location = New System.Drawing.Point(10, 16)
        Me.lblDateiName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDateiName.Name = "lblDateiName"
        Me.lblDateiName.Size = New System.Drawing.Size(64, 13)
        Me.lblDateiName.TabIndex = 0
        Me.lblDateiName.Text = "Dateiname: "
        '
        'tpAnsicht
        '
        Me.tpAnsicht.Controls.Add(Me.btnZoomIn)
        Me.tpAnsicht.Controls.Add(Me.btnZoomOut)
        Me.tpAnsicht.Controls.Add(Me.lblZoomWert)
        Me.tpAnsicht.Controls.Add(Me.lblZoomTitel)
        Me.tpAnsicht.Controls.Add(Me.btnOrginalGroesse)
        Me.tpAnsicht.Controls.Add(Me.btnHorizontalSpiegeln)
        Me.tpAnsicht.Controls.Add(Me.btnVertikalSpiegeln)
        Me.tpAnsicht.Controls.Add(Me.btnAnsFensterAnpassen)
        Me.tpAnsicht.Location = New System.Drawing.Point(4, 22)
        Me.tpAnsicht.Margin = New System.Windows.Forms.Padding(1)
        Me.tpAnsicht.Name = "tpAnsicht"
        Me.tpAnsicht.Padding = New System.Windows.Forms.Padding(1)
        Me.tpAnsicht.Size = New System.Drawing.Size(272, 455)
        Me.tpAnsicht.TabIndex = 1
        Me.tpAnsicht.Text = "Ansicht"
        Me.tpAnsicht.UseVisualStyleBackColor = True
        '
        'btnZoomIn
        '
        Me.btnZoomIn.Location = New System.Drawing.Point(89, 178)
        Me.btnZoomIn.Margin = New System.Windows.Forms.Padding(1)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(62, 19)
        Me.btnZoomIn.TabIndex = 15
        Me.btnZoomIn.Text = "+"
        Me.btnZoomIn.UseVisualStyleBackColor = True
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Location = New System.Drawing.Point(28, 178)
        Me.btnZoomOut.Margin = New System.Windows.Forms.Padding(1)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(62, 19)
        Me.btnZoomOut.TabIndex = 13
        Me.btnZoomOut.Text = "-"
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'lblZoomWert
        '
        Me.lblZoomWert.AutoSize = True
        Me.lblZoomWert.Location = New System.Drawing.Point(114, 156)
        Me.lblZoomWert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblZoomWert.Name = "lblZoomWert"
        Me.lblZoomWert.Size = New System.Drawing.Size(33, 13)
        Me.lblZoomWert.TabIndex = 12
        Me.lblZoomWert.Text = "100%"
        '
        'lblZoomTitel
        '
        Me.lblZoomTitel.AutoSize = True
        Me.lblZoomTitel.Location = New System.Drawing.Point(26, 156)
        Me.lblZoomTitel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblZoomTitel.Name = "lblZoomTitel"
        Me.lblZoomTitel.Size = New System.Drawing.Size(37, 13)
        Me.lblZoomTitel.TabIndex = 11
        Me.lblZoomTitel.Text = "Zoom:"
        '
        'btnOrginalGroesse
        '
        Me.btnOrginalGroesse.Location = New System.Drawing.Point(24, 24)
        Me.btnOrginalGroesse.Margin = New System.Windows.Forms.Padding(1)
        Me.btnOrginalGroesse.Name = "btnOrginalGroesse"
        Me.btnOrginalGroesse.Size = New System.Drawing.Size(123, 19)
        Me.btnOrginalGroesse.TabIndex = 10
        Me.btnOrginalGroesse.Text = "Orginalgröße"
        Me.btnOrginalGroesse.UseVisualStyleBackColor = True
        '
        'btnHorizontalSpiegeln
        '
        Me.btnHorizontalSpiegeln.Location = New System.Drawing.Point(24, 87)
        Me.btnHorizontalSpiegeln.Margin = New System.Windows.Forms.Padding(1)
        Me.btnHorizontalSpiegeln.Name = "btnHorizontalSpiegeln"
        Me.btnHorizontalSpiegeln.Size = New System.Drawing.Size(123, 19)
        Me.btnHorizontalSpiegeln.TabIndex = 9
        Me.btnHorizontalSpiegeln.Text = "Horizontal spiegeln"
        Me.btnHorizontalSpiegeln.UseVisualStyleBackColor = True
        '
        'btnVertikalSpiegeln
        '
        Me.btnVertikalSpiegeln.Location = New System.Drawing.Point(24, 120)
        Me.btnVertikalSpiegeln.Margin = New System.Windows.Forms.Padding(1)
        Me.btnVertikalSpiegeln.Name = "btnVertikalSpiegeln"
        Me.btnVertikalSpiegeln.Size = New System.Drawing.Size(123, 19)
        Me.btnVertikalSpiegeln.TabIndex = 8
        Me.btnVertikalSpiegeln.Text = "Vertikal spiegeln"
        Me.btnVertikalSpiegeln.UseVisualStyleBackColor = True
        '
        'btnAnsFensterAnpassen
        '
        Me.btnAnsFensterAnpassen.Location = New System.Drawing.Point(24, 54)
        Me.btnAnsFensterAnpassen.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnsFensterAnpassen.Name = "btnAnsFensterAnpassen"
        Me.btnAnsFensterAnpassen.Size = New System.Drawing.Size(123, 19)
        Me.btnAnsFensterAnpassen.TabIndex = 5
        Me.btnAnsFensterAnpassen.Text = "Ans Fenster Anpassen"
        Me.btnAnsFensterAnpassen.UseVisualStyleBackColor = True
        '
        'tpZeichnen
        '
        Me.tpZeichnen.Controls.Add(Me.grpWerkzeug)
        Me.tpZeichnen.Controls.Add(Me.grpWerkzeugWerte)
        Me.tpZeichnen.Controls.Add(Me.grpWerkzeugart)
        Me.tpZeichnen.Location = New System.Drawing.Point(4, 22)
        Me.tpZeichnen.Margin = New System.Windows.Forms.Padding(1)
        Me.tpZeichnen.Name = "tpZeichnen"
        Me.tpZeichnen.Padding = New System.Windows.Forms.Padding(1)
        Me.tpZeichnen.Size = New System.Drawing.Size(272, 455)
        Me.tpZeichnen.TabIndex = 2
        Me.tpZeichnen.Text = "Zeichnen"
        Me.tpZeichnen.UseVisualStyleBackColor = True
        '
        'grpWerkzeug
        '
        Me.grpWerkzeug.Controls.Add(Me.rdoRechteck)
        Me.grpWerkzeug.Controls.Add(Me.rdoLinie)
        Me.grpWerkzeug.Controls.Add(Me.rdoPixel)
        Me.grpWerkzeug.Controls.Add(Me.rdoPanning)
        Me.grpWerkzeug.Controls.Add(Me.rdoZeiger)
        Me.grpWerkzeug.Location = New System.Drawing.Point(15, 193)
        Me.grpWerkzeug.Margin = New System.Windows.Forms.Padding(1)
        Me.grpWerkzeug.Name = "grpWerkzeug"
        Me.grpWerkzeug.Padding = New System.Windows.Forms.Padding(1)
        Me.grpWerkzeug.Size = New System.Drawing.Size(153, 118)
        Me.grpWerkzeug.TabIndex = 2
        Me.grpWerkzeug.TabStop = False
        Me.grpWerkzeug.Text = "Werkzeuge"
        '
        'rdoRechteck
        '
        Me.rdoRechteck.Location = New System.Drawing.Point(82, 54)
        Me.rdoRechteck.Margin = New System.Windows.Forms.Padding(1)
        Me.rdoRechteck.Name = "rdoRechteck"
        Me.rdoRechteck.Size = New System.Drawing.Size(62, 20)
        Me.rdoRechteck.TabIndex = 4
        Me.rdoRechteck.Text = "Rechteck"
        Me.rdoRechteck.UseVisualStyleBackColor = True
        '
        'rdoLinie
        '
        Me.rdoLinie.Location = New System.Drawing.Point(82, 23)
        Me.rdoLinie.Margin = New System.Windows.Forms.Padding(1)
        Me.rdoLinie.Name = "rdoLinie"
        Me.rdoLinie.Size = New System.Drawing.Size(62, 20)
        Me.rdoLinie.TabIndex = 3
        Me.rdoLinie.Text = "Linie"
        Me.rdoLinie.UseVisualStyleBackColor = True
        '
        'rdoPixel
        '
        Me.rdoPixel.Location = New System.Drawing.Point(10, 84)
        Me.rdoPixel.Margin = New System.Windows.Forms.Padding(1)
        Me.rdoPixel.Name = "rdoPixel"
        Me.rdoPixel.Size = New System.Drawing.Size(62, 20)
        Me.rdoPixel.TabIndex = 2
        Me.rdoPixel.Text = "Pixel"
        Me.rdoPixel.UseVisualStyleBackColor = True
        '
        'rdoPanning
        '
        Me.rdoPanning.Location = New System.Drawing.Point(10, 54)
        Me.rdoPanning.Margin = New System.Windows.Forms.Padding(1)
        Me.rdoPanning.Name = "rdoPanning"
        Me.rdoPanning.Size = New System.Drawing.Size(62, 20)
        Me.rdoPanning.TabIndex = 1
        Me.rdoPanning.Text = "Panning"
        Me.rdoPanning.UseVisualStyleBackColor = True
        '
        'rdoZeiger
        '
        Me.rdoZeiger.Location = New System.Drawing.Point(10, 23)
        Me.rdoZeiger.Margin = New System.Windows.Forms.Padding(1)
        Me.rdoZeiger.Name = "rdoZeiger"
        Me.rdoZeiger.Size = New System.Drawing.Size(62, 20)
        Me.rdoZeiger.TabIndex = 0
        Me.rdoZeiger.Text = "Zeiger"
        Me.rdoZeiger.UseVisualStyleBackColor = True
        '
        'grpWerkzeugWerte
        '
        Me.grpWerkzeugWerte.Controls.Add(Me.nudPixeldicke)
        Me.grpWerkzeugWerte.Controls.Add(Me.nudGrauwert)
        Me.grpWerkzeugWerte.Controls.Add(Me.lblPixeldickeTitel)
        Me.grpWerkzeugWerte.Controls.Add(Me.lblGrauwertTitel)
        Me.grpWerkzeugWerte.Location = New System.Drawing.Point(13, 88)
        Me.grpWerkzeugWerte.Margin = New System.Windows.Forms.Padding(1)
        Me.grpWerkzeugWerte.Name = "grpWerkzeugWerte"
        Me.grpWerkzeugWerte.Padding = New System.Windows.Forms.Padding(1)
        Me.grpWerkzeugWerte.Size = New System.Drawing.Size(155, 88)
        Me.grpWerkzeugWerte.TabIndex = 1
        Me.grpWerkzeugWerte.TabStop = False
        Me.grpWerkzeugWerte.Text = "Werkzeugwerte"
        '
        'nudPixeldicke
        '
        Me.nudPixeldicke.Location = New System.Drawing.Point(84, 53)
        Me.nudPixeldicke.Margin = New System.Windows.Forms.Padding(1)
        Me.nudPixeldicke.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudPixeldicke.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPixeldicke.Name = "nudPixeldicke"
        Me.nudPixeldicke.Size = New System.Drawing.Size(45, 20)
        Me.nudPixeldicke.TabIndex = 5
        Me.nudPixeldicke.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudGrauwert
        '
        Me.nudGrauwert.Location = New System.Drawing.Point(84, 29)
        Me.nudGrauwert.Margin = New System.Windows.Forms.Padding(1)
        Me.nudGrauwert.Name = "nudGrauwert"
        Me.nudGrauwert.Size = New System.Drawing.Size(45, 20)
        Me.nudGrauwert.TabIndex = 4
        '
        'lblPixeldickeTitel
        '
        Me.lblPixeldickeTitel.AutoSize = True
        Me.lblPixeldickeTitel.Location = New System.Drawing.Point(8, 53)
        Me.lblPixeldickeTitel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPixeldickeTitel.Name = "lblPixeldickeTitel"
        Me.lblPixeldickeTitel.Size = New System.Drawing.Size(58, 13)
        Me.lblPixeldickeTitel.TabIndex = 3
        Me.lblPixeldickeTitel.Text = "Pixeldicke:"
        '
        'lblGrauwertTitel
        '
        Me.lblGrauwertTitel.AutoSize = True
        Me.lblGrauwertTitel.Location = New System.Drawing.Point(8, 29)
        Me.lblGrauwertTitel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGrauwertTitel.Name = "lblGrauwertTitel"
        Me.lblGrauwertTitel.Size = New System.Drawing.Size(53, 13)
        Me.lblGrauwertTitel.TabIndex = 2
        Me.lblGrauwertTitel.Text = "Grauwert:"
        '
        'grpWerkzeugart
        '
        Me.grpWerkzeugart.Controls.Add(Me.lblWerkzeugTitelWert)
        Me.grpWerkzeugart.Controls.Add(Me.lblWerkzeugTitel)
        Me.grpWerkzeugart.Location = New System.Drawing.Point(13, 16)
        Me.grpWerkzeugart.Margin = New System.Windows.Forms.Padding(1)
        Me.grpWerkzeugart.Name = "grpWerkzeugart"
        Me.grpWerkzeugart.Padding = New System.Windows.Forms.Padding(1)
        Me.grpWerkzeugart.Size = New System.Drawing.Size(155, 48)
        Me.grpWerkzeugart.TabIndex = 0
        Me.grpWerkzeugart.TabStop = False
        Me.grpWerkzeugart.Text = "Werkzeugart"
        '
        'lblWerkzeugTitelWert
        '
        Me.lblWerkzeugTitelWert.AutoSize = True
        Me.lblWerkzeugTitelWert.Location = New System.Drawing.Point(82, 26)
        Me.lblWerkzeugTitelWert.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblWerkzeugTitelWert.Name = "lblWerkzeugTitelWert"
        Me.lblWerkzeugTitelWert.Size = New System.Drawing.Size(37, 13)
        Me.lblWerkzeugTitelWert.TabIndex = 1
        Me.lblWerkzeugTitelWert.Text = "Zeiger"
        '
        'lblWerkzeugTitel
        '
        Me.lblWerkzeugTitel.AutoSize = True
        Me.lblWerkzeugTitel.Location = New System.Drawing.Point(8, 26)
        Me.lblWerkzeugTitel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblWerkzeugTitel.Name = "lblWerkzeugTitel"
        Me.lblWerkzeugTitel.Size = New System.Drawing.Size(52, 13)
        Me.lblWerkzeugTitel.TabIndex = 0
        Me.lblWerkzeugTitel.Text = "Gewählt: "
        '
        'tpFingerprinting
        '
        Me.tpFingerprinting.Controls.Add(Me.lblErgebnis)
        Me.tpFingerprinting.Controls.Add(Me.TextBox2)
        Me.tpFingerprinting.Controls.Add(Me.txtBoxHashB)
        Me.tpFingerprinting.Controls.Add(Me.txtBoxHashA)
        Me.tpFingerprinting.Controls.Add(Me.lblHashB)
        Me.tpFingerprinting.Controls.Add(Me.lblHashA)
        Me.tpFingerprinting.Controls.Add(Me.btnVergleichen)
        Me.tpFingerprinting.Controls.Add(Me.btnFingerprintBerechnen)
        Me.tpFingerprinting.Controls.Add(Me.btnBildBLaden)
        Me.tpFingerprinting.Controls.Add(Me.btnBildALaden)
        Me.tpFingerprinting.Location = New System.Drawing.Point(4, 22)
        Me.tpFingerprinting.Name = "tpFingerprinting"
        Me.tpFingerprinting.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFingerprinting.Size = New System.Drawing.Size(272, 455)
        Me.tpFingerprinting.TabIndex = 3
        Me.tpFingerprinting.Text = "Fingerprinting"
        Me.tpFingerprinting.UseVisualStyleBackColor = True
        '
        'lblErgebnis
        '
        Me.lblErgebnis.AutoSize = True
        Me.lblErgebnis.Location = New System.Drawing.Point(17, 400)
        Me.lblErgebnis.Name = "lblErgebnis"
        Me.lblErgebnis.Size = New System.Drawing.Size(51, 13)
        Me.lblErgebnis.TabIndex = 10
        Me.lblErgebnis.Text = "Ergebnis:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 421)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(229, 20)
        Me.TextBox2.TabIndex = 9
        '
        'txtBoxHashB
        '
        Me.txtBoxHashB.Location = New System.Drawing.Point(14, 270)
        Me.txtBoxHashB.Multiline = True
        Me.txtBoxHashB.Name = "txtBoxHashB"
        Me.txtBoxHashB.Size = New System.Drawing.Size(232, 90)
        Me.txtBoxHashB.TabIndex = 8
        Me.txtBoxHashB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxHashA
        '
        Me.txtBoxHashA.Location = New System.Drawing.Point(14, 151)
        Me.txtBoxHashA.Multiline = True
        Me.txtBoxHashA.Name = "txtBoxHashA"
        Me.txtBoxHashA.Size = New System.Drawing.Size(232, 90)
        Me.txtBoxHashA.TabIndex = 6
        Me.txtBoxHashA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHashB
        '
        Me.lblHashB.AutoSize = True
        Me.lblHashB.Location = New System.Drawing.Point(11, 254)
        Me.lblHashB.Name = "lblHashB"
        Me.lblHashB.Size = New System.Drawing.Size(42, 13)
        Me.lblHashB.TabIndex = 5
        Me.lblHashB.Text = "Hash B"
        '
        'lblHashA
        '
        Me.lblHashA.AutoSize = True
        Me.lblHashA.Location = New System.Drawing.Point(14, 135)
        Me.lblHashA.Name = "lblHashA"
        Me.lblHashA.Size = New System.Drawing.Size(42, 13)
        Me.lblHashA.TabIndex = 4
        Me.lblHashA.Text = "Hash A"
        '
        'btnVergleichen
        '
        Me.btnVergleichen.Location = New System.Drawing.Point(14, 366)
        Me.btnVergleichen.Name = "btnVergleichen"
        Me.btnVergleichen.Size = New System.Drawing.Size(232, 27)
        Me.btnVergleichen.TabIndex = 3
        Me.btnVergleichen.Text = "Vergleichen"
        Me.btnVergleichen.UseVisualStyleBackColor = True
        '
        'btnFingerprintBerechnen
        '
        Me.btnFingerprintBerechnen.Location = New System.Drawing.Point(17, 92)
        Me.btnFingerprintBerechnen.Name = "btnFingerprintBerechnen"
        Me.btnFingerprintBerechnen.Size = New System.Drawing.Size(229, 27)
        Me.btnFingerprintBerechnen.TabIndex = 2
        Me.btnFingerprintBerechnen.Text = "Fingerprint berechnen"
        Me.btnFingerprintBerechnen.UseVisualStyleBackColor = True
        '
        'btnBildBLaden
        '
        Me.btnBildBLaden.Location = New System.Drawing.Point(17, 59)
        Me.btnBildBLaden.Name = "btnBildBLaden"
        Me.btnBildBLaden.Size = New System.Drawing.Size(229, 27)
        Me.btnBildBLaden.TabIndex = 1
        Me.btnBildBLaden.Text = "Bild B laden"
        Me.btnBildBLaden.UseVisualStyleBackColor = True
        '
        'btnBildALaden
        '
        Me.btnBildALaden.Location = New System.Drawing.Point(17, 26)
        Me.btnBildALaden.Name = "btnBildALaden"
        Me.btnBildALaden.Size = New System.Drawing.Size(229, 27)
        Me.btnBildALaden.TabIndex = 0
        Me.btnBildALaden.Text = "Bild A laden"
        Me.btnBildALaden.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 527)
        Me.Controls.Add(Me.spcMain)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.mnuMain)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MinimumSize = New System.Drawing.Size(635, 445)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GraustufenViewer"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.stsMain.ResumeLayout(False)
        Me.stsMain.PerformLayout()
        Me.spcMain.Panel1.ResumeLayout(False)
        Me.spcMain.Panel2.ResumeLayout(False)
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        Me.pnlImageHost.ResumeLayout(False)
        CType(Me.pbImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSide.ResumeLayout(False)
        Me.tbDetails.ResumeLayout(False)
        Me.tbDetails.PerformLayout()
        Me.tpAnsicht.ResumeLayout(False)
        Me.tpAnsicht.PerformLayout()
        Me.tpZeichnen.ResumeLayout(False)
        Me.grpWerkzeug.ResumeLayout(False)
        Me.grpWerkzeugWerte.ResumeLayout(False)
        Me.grpWerkzeugWerte.PerformLayout()
        CType(Me.nudPixeldicke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGrauwert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWerkzeugart.ResumeLayout(False)
        Me.grpWerkzeugart.PerformLayout()
        Me.tpFingerprinting.ResumeLayout(False)
        Me.tpFingerprinting.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDatei As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBildOeffnen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBildSpeichern As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEigenschaften As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnueAnsicht As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuZoomen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHorizontalSpiegeln As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVertikalSpiegeln As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOrginalGroesse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAnsFensterAnpassen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuZeichnen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPixelZeichnen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLinieZeichnen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRechteckZeichnen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHilfe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stsMain As System.Windows.Forms.StatusStrip
    Friend WithEvents sslZoom As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslX As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslY As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslPixelwert As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslModus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents spcMain As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlImageHost As System.Windows.Forms.Panel
    Friend WithEvents pbImage1 As System.Windows.Forms.PictureBox
    Friend WithEvents tabSide As System.Windows.Forms.TabControl
    Friend WithEvents tbDetails As System.Windows.Forms.TabPage
    Friend WithEvents lblGrauwert As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblMaxGrauwert As System.Windows.Forms.Label
    Friend WithEvents lblBildgroesse As System.Windows.Forms.Label
    Friend WithEvents lblFormat As System.Windows.Forms.Label
    Friend WithEvents lblDateiName As System.Windows.Forms.Label
    Friend WithEvents tpAnsicht As System.Windows.Forms.TabPage
    Friend WithEvents tpZeichnen As System.Windows.Forms.TabPage
    Friend WithEvents lblGrauwertWert As System.Windows.Forms.Label
    Friend WithEvents lblYWert As System.Windows.Forms.Label
    Friend WithEvents lblXWert As System.Windows.Forms.Label
    Friend WithEvents lblMaxGrauwertWert As System.Windows.Forms.Label
    Friend WithEvents lblBildgroesseWert As System.Windows.Forms.Label
    Friend WithEvents lblFormatWert As System.Windows.Forms.Label
    Friend WithEvents lblDateiNameWert As System.Windows.Forms.Label

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGrauwertWert.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDateiName.Click

    End Sub
    Friend WithEvents lblDropHint As System.Windows.Forms.Label
    Friend WithEvents btnAnsFensterAnpassen As System.Windows.Forms.Button
    Friend WithEvents btnOrginalGroesse As System.Windows.Forms.Button
    Friend WithEvents btnHorizontalSpiegeln As System.Windows.Forms.Button
    Friend WithEvents btnVertikalSpiegeln As System.Windows.Forms.Button
    Friend WithEvents lblZoomTitel As System.Windows.Forms.Label
    Friend WithEvents btnZoomIn As System.Windows.Forms.Button
    Friend WithEvents btnZoomOut As System.Windows.Forms.Button
    Friend WithEvents lblZoomWert As System.Windows.Forms.Label
    Friend WithEvents grpWerkzeugart As System.Windows.Forms.GroupBox
    Friend WithEvents lblWerkzeugTitelWert As System.Windows.Forms.Label
    Friend WithEvents lblWerkzeugTitel As System.Windows.Forms.Label
    Friend WithEvents grpWerkzeugWerte As System.Windows.Forms.GroupBox
    Friend WithEvents lblPixeldickeTitel As System.Windows.Forms.Label
    Friend WithEvents lblGrauwertTitel As System.Windows.Forms.Label
    Friend WithEvents grpWerkzeug As System.Windows.Forms.GroupBox
    Friend WithEvents rdoRechteck As System.Windows.Forms.Button
    Friend WithEvents rdoLinie As System.Windows.Forms.Button
    Friend WithEvents rdoPixel As System.Windows.Forms.Button
    Friend WithEvents rdoPanning As System.Windows.Forms.Button
    Friend WithEvents rdoZeiger As System.Windows.Forms.Button
    Friend WithEvents nudPixeldicke As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudGrauwert As System.Windows.Forms.NumericUpDown
    Friend WithEvents mnuNeu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tpFingerprinting As System.Windows.Forms.TabPage
    Friend WithEvents txtBoxHashA As System.Windows.Forms.TextBox
    Friend WithEvents lblHashB As System.Windows.Forms.Label
    Friend WithEvents lblHashA As System.Windows.Forms.Label
    Friend WithEvents btnVergleichen As System.Windows.Forms.Button
    Friend WithEvents btnFingerprintBerechnen As System.Windows.Forms.Button
    Friend WithEvents btnBildBLaden As System.Windows.Forms.Button
    Friend WithEvents btnBildALaden As System.Windows.Forms.Button
    Friend WithEvents lblErgebnis As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxHashB As System.Windows.Forms.TextBox
    Friend WithEvents pbImage2 As System.Windows.Forms.PictureBox
End Class
