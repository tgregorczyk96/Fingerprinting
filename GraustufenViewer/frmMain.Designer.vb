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
        Me.lblDropHint = New System.Windows.Forms.Label()
        Me.pbImage = New System.Windows.Forms.PictureBox()
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
        Me.mnuNeu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.stsMain.SuspendLayout()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        Me.pnlImageHost.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSide.SuspendLayout()
        Me.tbDetails.SuspendLayout()
        Me.tpAnsicht.SuspendLayout()
        Me.tpZeichnen.SuspendLayout()
        Me.grpWerkzeug.SuspendLayout()
        Me.grpWerkzeugWerte.SuspendLayout()
        CType(Me.nudPixeldicke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGrauwert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWerkzeugart.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDatei, Me.mnueAnsicht, Me.mnuZeichnen, Me.mnuHilfe})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1634, 49)
        Me.mnuMain.TabIndex = 1
        '
        'mnuDatei
        '
        Me.mnuDatei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNeu, Me.mnuBildOeffnen, Me.mnuBildSpeichern, Me.mnuEigenschaften})
        Me.mnuDatei.Name = "mnuDatei"
        Me.mnuDatei.Size = New System.Drawing.Size(99, 45)
        Me.mnuDatei.Text = "Datei"
        '
        'mnuBildOeffnen
        '
        Me.mnuBildOeffnen.Name = "mnuBildOeffnen"
        Me.mnuBildOeffnen.Size = New System.Drawing.Size(281, 46)
        Me.mnuBildOeffnen.Text = "Bild öffnen"
        '
        'mnuBildSpeichern
        '
        Me.mnuBildSpeichern.Name = "mnuBildSpeichern"
        Me.mnuBildSpeichern.Size = New System.Drawing.Size(281, 46)
        Me.mnuBildSpeichern.Text = "Bild speichern"
        '
        'mnuEigenschaften
        '
        Me.mnuEigenschaften.Name = "mnuEigenschaften"
        Me.mnuEigenschaften.Size = New System.Drawing.Size(281, 46)
        Me.mnuEigenschaften.Text = "Eigenschaften"
        '
        'mnueAnsicht
        '
        Me.mnueAnsicht.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuZoomen, Me.mnuHorizontalSpiegeln, Me.mnuVertikalSpiegeln, Me.mnuOrginalGroesse, Me.mnuAnsFensterAnpassen})
        Me.mnueAnsicht.Name = "mnueAnsicht"
        Me.mnueAnsicht.Size = New System.Drawing.Size(127, 45)
        Me.mnueAnsicht.Text = "Ansicht"
        '
        'mnuZoomen
        '
        Me.mnuZoomen.Name = "mnuZoomen"
        Me.mnuZoomen.Size = New System.Drawing.Size(382, 46)
        Me.mnuZoomen.Text = "Zoomen"
        '
        'mnuHorizontalSpiegeln
        '
        Me.mnuHorizontalSpiegeln.Name = "mnuHorizontalSpiegeln"
        Me.mnuHorizontalSpiegeln.Size = New System.Drawing.Size(382, 46)
        Me.mnuHorizontalSpiegeln.Text = "Horizontal spiegeln"
        '
        'mnuVertikalSpiegeln
        '
        Me.mnuVertikalSpiegeln.Name = "mnuVertikalSpiegeln"
        Me.mnuVertikalSpiegeln.Size = New System.Drawing.Size(382, 46)
        Me.mnuVertikalSpiegeln.Text = "Vertikal spiegeln"
        '
        'mnuOrginalGroesse
        '
        Me.mnuOrginalGroesse.Name = "mnuOrginalGroesse"
        Me.mnuOrginalGroesse.Size = New System.Drawing.Size(382, 46)
        Me.mnuOrginalGroesse.Text = "Original Größe"
        '
        'mnuAnsFensterAnpassen
        '
        Me.mnuAnsFensterAnpassen.Name = "mnuAnsFensterAnpassen"
        Me.mnuAnsFensterAnpassen.Size = New System.Drawing.Size(382, 46)
        Me.mnuAnsFensterAnpassen.Text = "Ans Fenster anpassen"
        '
        'mnuZeichnen
        '
        Me.mnuZeichnen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPixelZeichnen, Me.mnuLinieZeichnen, Me.mnuRechteckZeichnen})
        Me.mnuZeichnen.Name = "mnuZeichnen"
        Me.mnuZeichnen.Size = New System.Drawing.Size(151, 45)
        Me.mnuZeichnen.Text = "Zeichnen"
        '
        'mnuPixelZeichnen
        '
        Me.mnuPixelZeichnen.Name = "mnuPixelZeichnen"
        Me.mnuPixelZeichnen.Size = New System.Drawing.Size(341, 46)
        Me.mnuPixelZeichnen.Text = "Pixel zeichnen"
        '
        'mnuLinieZeichnen
        '
        Me.mnuLinieZeichnen.Name = "mnuLinieZeichnen"
        Me.mnuLinieZeichnen.Size = New System.Drawing.Size(341, 46)
        Me.mnuLinieZeichnen.Text = "Linie Zeichnen"
        '
        'mnuRechteckZeichnen
        '
        Me.mnuRechteckZeichnen.Name = "mnuRechteckZeichnen"
        Me.mnuRechteckZeichnen.Size = New System.Drawing.Size(341, 46)
        Me.mnuRechteckZeichnen.Text = "Rechteck zeichnen"
        '
        'mnuHilfe
        '
        Me.mnuHilfe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInfo})
        Me.mnuHilfe.Name = "mnuHilfe"
        Me.mnuHilfe.Size = New System.Drawing.Size(90, 45)
        Me.mnuHilfe.Text = "Hilfe"
        '
        'mnuInfo
        '
        Me.mnuInfo.Name = "mnuInfo"
        Me.mnuInfo.Size = New System.Drawing.Size(148, 46)
        Me.mnuInfo.Text = "Info"
        '
        'stsMain
        '
        Me.stsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslZoom, Me.sslX, Me.sslY, Me.sslPixelwert, Me.sslModus})
        Me.stsMain.Location = New System.Drawing.Point(0, 966)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Size = New System.Drawing.Size(1634, 46)
        Me.stsMain.TabIndex = 2
        Me.stsMain.Text = "StatusStrip1"
        '
        'sslZoom
        '
        Me.sslZoom.Name = "sslZoom"
        Me.sslZoom.Size = New System.Drawing.Size(185, 41)
        Me.sslZoom.Text = "Zoom: 100%"
        '
        'sslX
        '
        Me.sslX.Name = "sslX"
        Me.sslX.Size = New System.Drawing.Size(63, 41)
        Me.sslX.Text = "X: -"
        '
        'sslY
        '
        Me.sslY.Name = "sslY"
        Me.sslY.Size = New System.Drawing.Size(62, 41)
        Me.sslY.Text = "Y: -"
        '
        'sslPixelwert
        '
        Me.sslPixelwert.Name = "sslPixelwert"
        Me.sslPixelwert.Size = New System.Drawing.Size(106, 41)
        Me.sslPixelwert.Text = "Pixel: -"
        '
        'sslModus
        '
        Me.sslModus.Name = "sslModus"
        Me.sslModus.Size = New System.Drawing.Size(223, 41)
        Me.sslModus.Text = "Modus: Ansicht"
        '
        'spcMain
        '
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.Location = New System.Drawing.Point(0, 49)
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
        Me.spcMain.Size = New System.Drawing.Size(1634, 917)
        Me.spcMain.SplitterDistance = 1108
        Me.spcMain.TabIndex = 3
        '
        'pnlImageHost
        '
        Me.pnlImageHost.AutoScroll = True
        Me.pnlImageHost.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlImageHost.Controls.Add(Me.lblDropHint)
        Me.pnlImageHost.Controls.Add(Me.pbImage)
        Me.pnlImageHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlImageHost.Location = New System.Drawing.Point(0, 0)
        Me.pnlImageHost.Name = "pnlImageHost"
        Me.pnlImageHost.Size = New System.Drawing.Size(1108, 917)
        Me.pnlImageHost.TabIndex = 0
        '
        'lblDropHint
        '
        Me.lblDropHint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDropHint.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblDropHint.Location = New System.Drawing.Point(0, 0)
        Me.lblDropHint.Name = "lblDropHint"
        Me.lblDropHint.Size = New System.Drawing.Size(1108, 917)
        Me.lblDropHint.TabIndex = 1
        Me.lblDropHint.Text = "Bild per Datei > Bild öffnen laden oder per Drag and Drop hier ablegen"
        Me.lblDropHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbImage
        '
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Location = New System.Drawing.Point(20, 20)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(400, 300)
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'tabSide
        '
        Me.tabSide.Controls.Add(Me.tbDetails)
        Me.tabSide.Controls.Add(Me.tpAnsicht)
        Me.tabSide.Controls.Add(Me.tpZeichnen)
        Me.tabSide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSide.Location = New System.Drawing.Point(0, 0)
        Me.tabSide.Name = "tabSide"
        Me.tabSide.SelectedIndex = 0
        Me.tabSide.Size = New System.Drawing.Size(522, 917)
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
        Me.tbDetails.Location = New System.Drawing.Point(10, 48)
        Me.tbDetails.Name = "tbDetails"
        Me.tbDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDetails.Size = New System.Drawing.Size(502, 859)
        Me.tbDetails.TabIndex = 0
        Me.tbDetails.Text = "Details"
        Me.tbDetails.UseVisualStyleBackColor = True
        '
        'lblGrauwertWert
        '
        Me.lblGrauwertWert.AutoSize = True
        Me.lblGrauwertWert.Location = New System.Drawing.Point(274, 322)
        Me.lblGrauwertWert.Name = "lblGrauwertWert"
        Me.lblGrauwertWert.Size = New System.Drawing.Size(24, 32)
        Me.lblGrauwertWert.TabIndex = 13
        Me.lblGrauwertWert.Text = "-"
        '
        'lblYWert
        '
        Me.lblYWert.AutoSize = True
        Me.lblYWert.Location = New System.Drawing.Point(274, 277)
        Me.lblYWert.Name = "lblYWert"
        Me.lblYWert.Size = New System.Drawing.Size(24, 32)
        Me.lblYWert.TabIndex = 12
        Me.lblYWert.Text = "-"
        '
        'lblXWert
        '
        Me.lblXWert.AutoSize = True
        Me.lblXWert.Location = New System.Drawing.Point(274, 228)
        Me.lblXWert.Name = "lblXWert"
        Me.lblXWert.Size = New System.Drawing.Size(24, 32)
        Me.lblXWert.TabIndex = 11
        Me.lblXWert.Text = "-"
        '
        'lblMaxGrauwertWert
        '
        Me.lblMaxGrauwertWert.AutoSize = True
        Me.lblMaxGrauwertWert.Location = New System.Drawing.Point(274, 177)
        Me.lblMaxGrauwertWert.Name = "lblMaxGrauwertWert"
        Me.lblMaxGrauwertWert.Size = New System.Drawing.Size(24, 32)
        Me.lblMaxGrauwertWert.TabIndex = 10
        Me.lblMaxGrauwertWert.Text = "-"
        '
        'lblBildgroesseWert
        '
        Me.lblBildgroesseWert.AutoSize = True
        Me.lblBildgroesseWert.Location = New System.Drawing.Point(274, 130)
        Me.lblBildgroesseWert.Name = "lblBildgroesseWert"
        Me.lblBildgroesseWert.Size = New System.Drawing.Size(24, 32)
        Me.lblBildgroesseWert.TabIndex = 9
        Me.lblBildgroesseWert.Text = "-"
        '
        'lblFormatWert
        '
        Me.lblFormatWert.AutoSize = True
        Me.lblFormatWert.Location = New System.Drawing.Point(274, 84)
        Me.lblFormatWert.Name = "lblFormatWert"
        Me.lblFormatWert.Size = New System.Drawing.Size(24, 32)
        Me.lblFormatWert.TabIndex = 8
        Me.lblFormatWert.Text = "-"
        '
        'lblDateiNameWert
        '
        Me.lblDateiNameWert.AutoSize = True
        Me.lblDateiNameWert.Location = New System.Drawing.Point(274, 38)
        Me.lblDateiNameWert.Name = "lblDateiNameWert"
        Me.lblDateiNameWert.Size = New System.Drawing.Size(24, 32)
        Me.lblDateiNameWert.TabIndex = 7
        Me.lblDateiNameWert.Text = "-"
        '
        'lblGrauwert
        '
        Me.lblGrauwert.AutoSize = True
        Me.lblGrauwert.Location = New System.Drawing.Point(26, 322)
        Me.lblGrauwert.Name = "lblGrauwert"
        Me.lblGrauwert.Size = New System.Drawing.Size(146, 32)
        Me.lblGrauwert.TabIndex = 6
        Me.lblGrauwert.Text = "Grauwert: "
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(26, 277)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(49, 32)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y: "
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(26, 228)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(49, 32)
        Me.lblX.TabIndex = 4
        Me.lblX.Text = "X: "
        '
        'lblMaxGrauwert
        '
        Me.lblMaxGrauwert.AutoSize = True
        Me.lblMaxGrauwert.Location = New System.Drawing.Point(26, 177)
        Me.lblMaxGrauwert.Name = "lblMaxGrauwert"
        Me.lblMaxGrauwert.Size = New System.Drawing.Size(207, 32)
        Me.lblMaxGrauwert.TabIndex = 3
        Me.lblMaxGrauwert.Text = "Max. Grauwert:"
        '
        'lblBildgroesse
        '
        Me.lblBildgroesse.AutoSize = True
        Me.lblBildgroesse.Location = New System.Drawing.Point(26, 130)
        Me.lblBildgroesse.Name = "lblBildgroesse"
        Me.lblBildgroesse.Size = New System.Drawing.Size(153, 32)
        Me.lblBildgroesse.TabIndex = 2
        Me.lblBildgroesse.Text = "Bildgröße: "
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(26, 84)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(119, 32)
        Me.lblFormat.TabIndex = 1
        Me.lblFormat.Text = "Format: "
        '
        'lblDateiName
        '
        Me.lblDateiName.AutoSize = True
        Me.lblDateiName.Location = New System.Drawing.Point(26, 38)
        Me.lblDateiName.Name = "lblDateiName"
        Me.lblDateiName.Size = New System.Drawing.Size(168, 32)
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
        Me.tpAnsicht.Location = New System.Drawing.Point(10, 48)
        Me.tpAnsicht.Name = "tpAnsicht"
        Me.tpAnsicht.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAnsicht.Size = New System.Drawing.Size(502, 859)
        Me.tpAnsicht.TabIndex = 1
        Me.tpAnsicht.Text = "Ansicht"
        Me.tpAnsicht.UseVisualStyleBackColor = True
        '
        'btnZoomIn
        '
        Me.btnZoomIn.Location = New System.Drawing.Point(238, 424)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(166, 45)
        Me.btnZoomIn.TabIndex = 15
        Me.btnZoomIn.Text = "+"
        Me.btnZoomIn.UseVisualStyleBackColor = True
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Location = New System.Drawing.Point(76, 424)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(166, 45)
        Me.btnZoomOut.TabIndex = 13
        Me.btnZoomOut.Text = "-"
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'lblZoomWert
        '
        Me.lblZoomWert.AutoSize = True
        Me.lblZoomWert.Location = New System.Drawing.Point(305, 372)
        Me.lblZoomWert.Name = "lblZoomWert"
        Me.lblZoomWert.Size = New System.Drawing.Size(88, 32)
        Me.lblZoomWert.TabIndex = 12
        Me.lblZoomWert.Text = "100%"
        '
        'lblZoomTitel
        '
        Me.lblZoomTitel.AutoSize = True
        Me.lblZoomTitel.Location = New System.Drawing.Point(70, 372)
        Me.lblZoomTitel.Name = "lblZoomTitel"
        Me.lblZoomTitel.Size = New System.Drawing.Size(95, 32)
        Me.lblZoomTitel.TabIndex = 11
        Me.lblZoomTitel.Text = "Zoom:"
        '
        'btnOrginalGroesse
        '
        Me.btnOrginalGroesse.Location = New System.Drawing.Point(65, 57)
        Me.btnOrginalGroesse.Name = "btnOrginalGroesse"
        Me.btnOrginalGroesse.Size = New System.Drawing.Size(328, 45)
        Me.btnOrginalGroesse.TabIndex = 10
        Me.btnOrginalGroesse.Text = "Orginalgröße"
        Me.btnOrginalGroesse.UseVisualStyleBackColor = True
        '
        'btnHorizontalSpiegeln
        '
        Me.btnHorizontalSpiegeln.Location = New System.Drawing.Point(65, 208)
        Me.btnHorizontalSpiegeln.Name = "btnHorizontalSpiegeln"
        Me.btnHorizontalSpiegeln.Size = New System.Drawing.Size(328, 45)
        Me.btnHorizontalSpiegeln.TabIndex = 9
        Me.btnHorizontalSpiegeln.Text = "Horizontal spiegeln"
        Me.btnHorizontalSpiegeln.UseVisualStyleBackColor = True
        '
        'btnVertikalSpiegeln
        '
        Me.btnVertikalSpiegeln.Location = New System.Drawing.Point(65, 286)
        Me.btnVertikalSpiegeln.Name = "btnVertikalSpiegeln"
        Me.btnVertikalSpiegeln.Size = New System.Drawing.Size(328, 45)
        Me.btnVertikalSpiegeln.TabIndex = 8
        Me.btnVertikalSpiegeln.Text = "Vertikal spiegeln"
        Me.btnVertikalSpiegeln.UseVisualStyleBackColor = True
        '
        'btnAnsFensterAnpassen
        '
        Me.btnAnsFensterAnpassen.Location = New System.Drawing.Point(65, 129)
        Me.btnAnsFensterAnpassen.Name = "btnAnsFensterAnpassen"
        Me.btnAnsFensterAnpassen.Size = New System.Drawing.Size(328, 45)
        Me.btnAnsFensterAnpassen.TabIndex = 5
        Me.btnAnsFensterAnpassen.Text = "Ans Fenster Anpassen"
        Me.btnAnsFensterAnpassen.UseVisualStyleBackColor = True
        '
        'tpZeichnen
        '
        Me.tpZeichnen.Controls.Add(Me.grpWerkzeug)
        Me.tpZeichnen.Controls.Add(Me.grpWerkzeugWerte)
        Me.tpZeichnen.Controls.Add(Me.grpWerkzeugart)
        Me.tpZeichnen.Location = New System.Drawing.Point(10, 48)
        Me.tpZeichnen.Name = "tpZeichnen"
        Me.tpZeichnen.Padding = New System.Windows.Forms.Padding(3)
        Me.tpZeichnen.Size = New System.Drawing.Size(502, 859)
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
        Me.grpWerkzeug.Location = New System.Drawing.Point(41, 460)
        Me.grpWerkzeug.Name = "grpWerkzeug"
        Me.grpWerkzeug.Size = New System.Drawing.Size(407, 282)
        Me.grpWerkzeug.TabIndex = 2
        Me.grpWerkzeug.TabStop = False
        Me.grpWerkzeug.Text = "Werkzeuge"
        '
        'rdoRechteck
        '
        Me.rdoRechteck.Location = New System.Drawing.Point(219, 128)
        Me.rdoRechteck.Name = "rdoRechteck"
        Me.rdoRechteck.Size = New System.Drawing.Size(164, 48)
        Me.rdoRechteck.TabIndex = 4
        Me.rdoRechteck.Text = "Rechteck"
        Me.rdoRechteck.UseVisualStyleBackColor = True
        '
        'rdoLinie
        '
        Me.rdoLinie.Location = New System.Drawing.Point(219, 56)
        Me.rdoLinie.Name = "rdoLinie"
        Me.rdoLinie.Size = New System.Drawing.Size(164, 48)
        Me.rdoLinie.TabIndex = 3
        Me.rdoLinie.Text = "Linie"
        Me.rdoLinie.UseVisualStyleBackColor = True
        '
        'rdoPixel
        '
        Me.rdoPixel.Location = New System.Drawing.Point(26, 200)
        Me.rdoPixel.Name = "rdoPixel"
        Me.rdoPixel.Size = New System.Drawing.Size(164, 48)
        Me.rdoPixel.TabIndex = 2
        Me.rdoPixel.Text = "Pixel"
        Me.rdoPixel.UseVisualStyleBackColor = True
        '
        'rdoPanning
        '
        Me.rdoPanning.Location = New System.Drawing.Point(26, 128)
        Me.rdoPanning.Name = "rdoPanning"
        Me.rdoPanning.Size = New System.Drawing.Size(164, 48)
        Me.rdoPanning.TabIndex = 1
        Me.rdoPanning.Text = "Panning"
        Me.rdoPanning.UseVisualStyleBackColor = True
        '
        'rdoZeiger
        '
        Me.rdoZeiger.Location = New System.Drawing.Point(26, 56)
        Me.rdoZeiger.Name = "rdoZeiger"
        Me.rdoZeiger.Size = New System.Drawing.Size(164, 48)
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
        Me.grpWerkzeugWerte.Location = New System.Drawing.Point(35, 211)
        Me.grpWerkzeugWerte.Name = "grpWerkzeugWerte"
        Me.grpWerkzeugWerte.Size = New System.Drawing.Size(413, 211)
        Me.grpWerkzeugWerte.TabIndex = 1
        Me.grpWerkzeugWerte.TabStop = False
        Me.grpWerkzeugWerte.Text = "Werkzeugwerte"
        '
        'nudPixeldicke
        '
        Me.nudPixeldicke.Location = New System.Drawing.Point(225, 127)
        Me.nudPixeldicke.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudPixeldicke.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPixeldicke.Name = "nudPixeldicke"
        Me.nudPixeldicke.Size = New System.Drawing.Size(120, 38)
        Me.nudPixeldicke.TabIndex = 5
        Me.nudPixeldicke.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudGrauwert
        '
        Me.nudGrauwert.Location = New System.Drawing.Point(225, 68)
        Me.nudGrauwert.Name = "nudGrauwert"
        Me.nudGrauwert.Size = New System.Drawing.Size(120, 38)
        Me.nudGrauwert.TabIndex = 4
        '
        'lblPixeldickeTitel
        '
        Me.lblPixeldickeTitel.AutoSize = True
        Me.lblPixeldickeTitel.Location = New System.Drawing.Point(22, 127)
        Me.lblPixeldickeTitel.Name = "lblPixeldickeTitel"
        Me.lblPixeldickeTitel.Size = New System.Drawing.Size(153, 32)
        Me.lblPixeldickeTitel.TabIndex = 3
        Me.lblPixeldickeTitel.Text = "Pixeldicke:"
        '
        'lblGrauwertTitel
        '
        Me.lblGrauwertTitel.AutoSize = True
        Me.lblGrauwertTitel.Location = New System.Drawing.Point(22, 68)
        Me.lblGrauwertTitel.Name = "lblGrauwertTitel"
        Me.lblGrauwertTitel.Size = New System.Drawing.Size(139, 32)
        Me.lblGrauwertTitel.TabIndex = 2
        Me.lblGrauwertTitel.Text = "Grauwert:"
        '
        'grpWerkzeugart
        '
        Me.grpWerkzeugart.Controls.Add(Me.lblWerkzeugTitelWert)
        Me.grpWerkzeugart.Controls.Add(Me.lblWerkzeugTitel)
        Me.grpWerkzeugart.Location = New System.Drawing.Point(35, 39)
        Me.grpWerkzeugart.Name = "grpWerkzeugart"
        Me.grpWerkzeugart.Size = New System.Drawing.Size(414, 115)
        Me.grpWerkzeugart.TabIndex = 0
        Me.grpWerkzeugart.TabStop = False
        Me.grpWerkzeugart.Text = "Werkzeugart"
        '
        'lblWerkzeugTitelWert
        '
        Me.lblWerkzeugTitelWert.AutoSize = True
        Me.lblWerkzeugTitelWert.Location = New System.Drawing.Point(219, 62)
        Me.lblWerkzeugTitelWert.Name = "lblWerkzeugTitelWert"
        Me.lblWerkzeugTitelWert.Size = New System.Drawing.Size(96, 32)
        Me.lblWerkzeugTitelWert.TabIndex = 1
        Me.lblWerkzeugTitelWert.Text = "Zeiger"
        '
        'lblWerkzeugTitel
        '
        Me.lblWerkzeugTitel.AutoSize = True
        Me.lblWerkzeugTitel.Location = New System.Drawing.Point(22, 62)
        Me.lblWerkzeugTitel.Name = "lblWerkzeugTitel"
        Me.lblWerkzeugTitel.Size = New System.Drawing.Size(135, 32)
        Me.lblWerkzeugTitel.TabIndex = 0
        Me.lblWerkzeugTitel.Text = "Gewählt: "
        '
        'mnuNeu
        '
        Me.mnuNeu.Name = "mnuNeu"
        Me.mnuNeu.Size = New System.Drawing.Size(281, 46)
        Me.mnuNeu.Text = "Neu"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1634, 1012)
        Me.Controls.Add(Me.spcMain)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.mnuMain)
        Me.MinimumSize = New System.Drawing.Size(1666, 1100)
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
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
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
End Class
