Imports System.IO
Imports System.Drawing

Public Class frmMain

    Private Enum ToolMode
        Zeiger
        Panning
        Pixel
        Linie
        Rechteck
    End Enum

    Private _originalPgm As PgmImage = Nothing
    Private _workingPgm As PgmImage = Nothing
    Private _displayBitmap As Bitmap = Nothing

    Private _zoomFactor As Double = 1.0
    Private _fitToWindow As Boolean = False

    Private _istPanning As Boolean = False
    Private _panStartMaus As Point
    Private _panStartScroll As Point

    Private _aktuellesWerkzeug As ToolMode = ToolMode.Zeiger
    Private _istZeichnenAktiv As Boolean = False
    Private _zeichnenStartpunkt As Point
    Private _letzterPixelPunkt As Point = New Point(-1, -1)

    Private Const IMAGE_MARGIN As Integer = 20
    Private Const MIN_ZOOM_PERCENT As Integer = 10
    Private Const MAX_ZOOM_PERCENT As Integer = 400
    Private Const ZOOM_STEP_PERCENT As Integer = 10

    Private ofdBildOeffnen As New OpenFileDialog()
    Private sfdBildSpeichern As New SaveFileDialog()

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ofdBildOeffnen.Filter = "PGM-Dateien (*.pgm)|*.pgm"
        ofdBildOeffnen.Title = "PGM-Bild öffnen"

        sfdBildSpeichern.Filter = "PGM-Dateien (*.pgm)|*.pgm"
        sfdBildSpeichern.Title = "PGM-Bild speichern"
        sfdBildSpeichern.FileName = "bild_bearbeitet.pgm"

        Me.KeyPreview = True

        pbImage.SizeMode = PictureBoxSizeMode.StretchImage

        Me.AllowDrop = True
        pnlImageHost.AllowDrop = True
        pbImage.AllowDrop = True
        lblDropHint.AllowDrop = True

        nudGrauwert.Minimum = 0
        nudGrauwert.Maximum = 255
        nudGrauwert.Value = 128

        nudPixeldicke.Minimum = 1
        nudPixeldicke.Maximum = 20
        nudPixeldicke.Value = 1

        ResetDetails()
        AktualisiereDropHint()
        AktualisiereZoomAnzeige()
        SetzeWerkzeug(ToolMode.Zeiger)
        AktualisierePanningCursor()
        AktualisiereModusAnzeige()
    End Sub

    Private Function IstPgmDatei(ByVal dateipfad As String) As Boolean
        Return Path.GetExtension(dateipfad).ToLower() = ".pgm"
    End Function

    Private Function HoleWerkzeugText(ByVal werkzeug As ToolMode) As String
        Select Case werkzeug
            Case ToolMode.Zeiger
                Return "Zeiger"
            Case ToolMode.Panning
                Return "Panning"
            Case ToolMode.Pixel
                Return "Pixel"
            Case ToolMode.Linie
                Return "Linie"
            Case ToolMode.Rechteck
                Return "Rechteck"
            Case Else
                Return "Zeiger"
        End Select
    End Function

    Private Sub SetzeWerkzeugButtonStyle(ByVal btn As Button, ByVal istAktiv As Boolean)
        If istAktiv Then
            btn.UseVisualStyleBackColor = False
            btn.BackColor = Color.LightSteelBlue
        Else
            btn.UseVisualStyleBackColor = True
        End If
    End Sub

    Private Sub BeendeAlleInteraktionen()
        _istPanning = False
        _istZeichnenAktiv = False
        _letzterPixelPunkt = New Point(-1, -1)

        pbImage.Capture = False
        pnlImageHost.Capture = False
    End Sub

    Private Sub SetzeWerkzeug(ByVal werkzeug As ToolMode)
        BeendeAlleInteraktionen()

        _aktuellesWerkzeug = werkzeug

        lblWerkzeugTitelWert.Text = HoleWerkzeugText(_aktuellesWerkzeug)

        SetzeWerkzeugButtonStyle(rdoZeiger, _aktuellesWerkzeug = ToolMode.Zeiger)
        SetzeWerkzeugButtonStyle(rdoPanning, _aktuellesWerkzeug = ToolMode.Panning)
        SetzeWerkzeugButtonStyle(rdoPixel, _aktuellesWerkzeug = ToolMode.Pixel)
        SetzeWerkzeugButtonStyle(rdoLinie, _aktuellesWerkzeug = ToolMode.Linie)
        SetzeWerkzeugButtonStyle(rdoRechteck, _aktuellesWerkzeug = ToolMode.Rechteck)

        AktualisierePanningCursor()
        AktualisiereModusAnzeige()
    End Sub

    Private Function IstAnsichtPanningModusAktiv() As Boolean
        Return _workingPgm IsNot Nothing AndAlso tabSide.SelectedTab Is tpAnsicht
    End Function

    Private Function IstZeichnenPanningModusAktiv() As Boolean
        Return _workingPgm IsNot Nothing AndAlso tabSide.SelectedTab Is tpZeichnen AndAlso _aktuellesWerkzeug = ToolMode.Panning
    End Function

    Private Function IstPanningModusAktiv() As Boolean
        Return IstAnsichtPanningModusAktiv() OrElse IstZeichnenPanningModusAktiv()
    End Function

    Private Function IstZeichenWerkzeugAktiv() As Boolean
        If _workingPgm Is Nothing Then
            Return False
        End If

        If tabSide.SelectedTab IsNot tpZeichnen Then
            Return False
        End If

        Return _aktuellesWerkzeug = ToolMode.Pixel OrElse
               _aktuellesWerkzeug = ToolMode.Linie OrElse
               _aktuellesWerkzeug = ToolMode.Rechteck
    End Function

    Private Sub AktualisiereDropHint()
        lblDropHint.Visible = (_workingPgm Is Nothing)
    End Sub

    Private Sub AktualisiereModusAnzeige()
        If _istPanning Then
            sslModus.Text = "Modus: Panning"
        ElseIf tabSide.SelectedTab Is tpAnsicht Then
            sslModus.Text = "Modus: Ansicht"
        ElseIf tabSide.SelectedTab Is tpZeichnen Then
            sslModus.Text = "Modus: Zeichnen (" & HoleWerkzeugText(_aktuellesWerkzeug) & ")"
        Else
            sslModus.Text = "Modus: Details"
        End If
    End Sub

    Private Sub AktualisierePanningCursor()
        Dim aktuellerCursor As Cursor = Cursors.Default

        If _istPanning Then
            aktuellerCursor = Cursors.SizeAll
        ElseIf IstPanningModusAktiv() Then
            aktuellerCursor = Cursors.Hand
        ElseIf tabSide.SelectedTab Is tpZeichnen Then
            Select Case _aktuellesWerkzeug
                Case ToolMode.Pixel, ToolMode.Linie, ToolMode.Rechteck
                    aktuellerCursor = Cursors.Cross
                Case Else
                    aktuellerCursor = Cursors.Default
            End Select
        End If

        pbImage.Cursor = aktuellerCursor
        pnlImageHost.Cursor = aktuellerCursor
        lblDropHint.Cursor = aktuellerCursor
    End Sub

    Private Sub StartePanning()
        _istPanning = True

        _panStartMaus = pnlImageHost.PointToClient(Control.MousePosition)

        Dim startScrollPos As Point = pnlImageHost.AutoScrollPosition
        _panStartScroll = New Point(-startScrollPos.X, -startScrollPos.Y)

        pbImage.Capture = True
        pnlImageHost.Capture = True

        AktualisierePanningCursor()
        AktualisiereModusAnzeige()
    End Sub

    Private Sub FuehrePanningAus()
        Dim aktuelleMaus As Point = pnlImageHost.PointToClient(Control.MousePosition)

        Dim dx As Integer = aktuelleMaus.X - _panStartMaus.X
        Dim dy As Integer = aktuelleMaus.Y - _panStartMaus.Y

        pnlImageHost.AutoScrollPosition = New Point(_panStartScroll.X - dx, _panStartScroll.Y - dy)
    End Sub

    Private Sub BeendePanning()
        If Not _istPanning Then
            Exit Sub
        End If

        _istPanning = False

        pbImage.Capture = False
        pnlImageHost.Capture = False

        AktualisierePanningCursor()
        AktualisiereModusAnzeige()
    End Sub

    Private Sub VerwerfeDisplayBitmap()
        If _displayBitmap IsNot Nothing Then
            _displayBitmap.Dispose()
            _displayBitmap = Nothing
        End If

        pbImage.Image = Nothing
    End Sub

    Private Function HoleAktuellenZoomProzent() As Integer
        Return CInt(Math.Round(_zoomFactor * 100.0))
    End Function

    Private Sub AktualisiereZoomAnzeige()
        Dim zoomProzent As Integer = HoleAktuellenZoomProzent()

        If zoomProzent < MIN_ZOOM_PERCENT Then zoomProzent = MIN_ZOOM_PERCENT
        If zoomProzent > MAX_ZOOM_PERCENT Then zoomProzent = MAX_ZOOM_PERCENT

        lblZoomWert.Text = zoomProzent.ToString() & "%"
        sslZoom.Text = "Zoom: " & zoomProzent.ToString() & "%"

        If _workingPgm Is Nothing Then
            btnZoomIn.Enabled = False
            btnZoomOut.Enabled = False
        Else
            btnZoomIn.Enabled = (zoomProzent < MAX_ZOOM_PERCENT)
            btnZoomOut.Enabled = (zoomProzent > MIN_ZOOM_PERCENT)
        End If
    End Sub

    Private Sub AktualisiereBildAnzeige()
        VerwerfeDisplayBitmap()

        If _workingPgm Is Nothing Then
            pbImage.Width = 400
            pbImage.Height = 300
            pbImage.Left = IMAGE_MARGIN
            pbImage.Top = IMAGE_MARGIN
            AktualisiereDropHint()
            AktualisiereZoomAnzeige()
            AktualisierePanningCursor()
            Exit Sub
        End If

        If _fitToWindow Then
            BerechneZoomFuerFenster()
        End If

        _displayBitmap = _workingPgm.ToBitmap()
        pbImage.Image = _displayBitmap

        Dim neueBreite As Integer = CInt(Math.Round(_workingPgm.Width * _zoomFactor))
        Dim neueHoehe As Integer = CInt(Math.Round(_workingPgm.Height * _zoomFactor))

        If neueBreite < 1 Then neueBreite = 1
        If neueHoehe < 1 Then neueHoehe = 1

        pbImage.Width = neueBreite
        pbImage.Height = neueHoehe
        pbImage.Left = IMAGE_MARGIN
        pbImage.Top = IMAGE_MARGIN

        AktualisiereDropHint()
        AktualisiereZoomAnzeige()
        AktualisierePanningCursor()
    End Sub

    Private Sub LadeBild(ByVal dateipfad As String)
        Try
            If Not IstPgmDatei(dateipfad) Then
                Throw New Exception("In dieser Version werden nur PGM-Dateien unterstützt.")
            End If

            _originalPgm = PgmImage.LoadFromFile(dateipfad)
            _workingPgm = _originalPgm.CloneImage()

            _fitToWindow = False
            _zoomFactor = 1.0
            BeendeAlleInteraktionen()

            Dim basisname As String = Path.GetFileNameWithoutExtension(dateipfad)
            sfdBildSpeichern.FileName = basisname & "_bearbeitet.pgm"

            AktualisiereBildAnzeige()
            AktualisiereDetails()
            AktualisiereStatusNachBildLaden()

        Catch ex As Exception
            MessageBox.Show("Fehler beim Laden des Bildes:" & Environment.NewLine & ex.Message,
                            "Fehler",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AktualisiereDetails()
        If _workingPgm Is Nothing Then
            ResetDetails()
            Exit Sub
        End If

        lblDateiNameWert.Text = Path.GetFileName(_workingPgm.FilePath)
        lblFormatWert.Text = _workingPgm.MagicNumber
        lblBildgroesseWert.Text = _workingPgm.Width.ToString() & " x " & _workingPgm.Height.ToString()
        lblMaxGrauwertWert.Text = _workingPgm.MaxGrayValue.ToString()

        lblXWert.Text = "-"
        lblYWert.Text = "-"
        lblGrauwertWert.Text = "-"
    End Sub

    Private Sub AktualisiereStatusNachBildLaden()
        AktualisiereZoomAnzeige()
        sslX.Text = "X: -"
        sslY.Text = "Y: -"
        sslPixelwert.Text = "Pixel: -"
        AktualisiereModusAnzeige()
    End Sub

    Private Sub ResetDetails()
        lblDateiNameWert.Text = "-"
        lblFormatWert.Text = "-"
        lblBildgroesseWert.Text = "-"
        lblMaxGrauwertWert.Text = "-"
        lblXWert.Text = "-"
        lblYWert.Text = "-"
        lblGrauwertWert.Text = "-"

        _zoomFactor = 1.0
        _fitToWindow = False
        BeendeAlleInteraktionen()

        lblZoomWert.Text = "100%"
        sslZoom.Text = "Zoom: 100%"
        sslX.Text = "X: -"
        sslY.Text = "Y: -"
        sslPixelwert.Text = "Pixel: -"

        AktualisierePanningCursor()
        AktualisiereModusAnzeige()
    End Sub

    Private Sub BerechneZoomFuerFenster()
        If _workingPgm Is Nothing Then
            Exit Sub
        End If

        Dim verfuegbareBreite As Integer = pnlImageHost.ClientSize.Width - (IMAGE_MARGIN * 2)
        Dim verfuegbareHoehe As Integer = pnlImageHost.ClientSize.Height - (IMAGE_MARGIN * 2)

        If verfuegbareBreite < 1 Then verfuegbareBreite = 1
        If verfuegbareHoehe < 1 Then verfuegbareHoehe = 1

        Dim zoomX As Double = verfuegbareBreite / CDbl(_workingPgm.Width)
        Dim zoomY As Double = verfuegbareHoehe / CDbl(_workingPgm.Height)

        _zoomFactor = Math.Min(zoomX, zoomY)

        Dim minZoom As Double = MIN_ZOOM_PERCENT / 100.0
        Dim maxZoom As Double = MAX_ZOOM_PERCENT / 100.0

        If _zoomFactor < minZoom Then _zoomFactor = minZoom
        If _zoomFactor > maxZoom Then _zoomFactor = maxZoom
    End Sub

    Private Sub SetzeOriginalgroesse()
        If _workingPgm Is Nothing Then
            Exit Sub
        End If

        _fitToWindow = False
        _zoomFactor = 1.0
        AktualisiereBildAnzeige()
    End Sub

    Private Sub SetzeAnsFensterAnpassen()
        If _workingPgm Is Nothing Then
            Exit Sub
        End If

        _fitToWindow = True
        BerechneZoomFuerFenster()
        AktualisiereBildAnzeige()
    End Sub

    Private Sub SetzeZoomProzent(ByVal zoomProzent As Integer)
        If _workingPgm Is Nothing Then
            Exit Sub
        End If

        If zoomProzent < MIN_ZOOM_PERCENT Then zoomProzent = MIN_ZOOM_PERCENT
        If zoomProzent > MAX_ZOOM_PERCENT Then zoomProzent = MAX_ZOOM_PERCENT

        _fitToWindow = False
        _zoomFactor = zoomProzent / 100.0

        AktualisiereBildAnzeige()
    End Sub

    Private Sub ZoomIn()
        SetzeZoomProzent(HoleAktuellenZoomProzent() + ZOOM_STEP_PERCENT)
    End Sub

    Private Sub ZoomOut()
        SetzeZoomProzent(HoleAktuellenZoomProzent() - ZOOM_STEP_PERCENT)
    End Sub

    Private Sub ZeigeAnsichtTab()
        tabSide.SelectedTab = tpAnsicht
    End Sub

    Private Sub ZeigeZeichnenTab()
        tabSide.SelectedTab = tpZeichnen
    End Sub

    Private Sub AktiviereFormFokus()
        If Not Me.Focused Then
            Me.Focus()
        End If
    End Sub

    Private Function ZeigeNeuBildDialog(ByRef breite As Integer,
                                    ByRef hoehe As Integer,
                                    ByRef dateiname As String,
                                    ByRef kommentar As String) As Boolean
        Using dlg As New Form()
            dlg.Text = "Neues Bild"
            dlg.FormBorderStyle = FormBorderStyle.FixedDialog
            dlg.StartPosition = FormStartPosition.CenterParent
            dlg.MinimizeBox = False
            dlg.MaximizeBox = False
            dlg.ShowInTaskbar = False
            dlg.ClientSize = New Size(460, 320)

            Dim lblName As New Label()
            lblName.Text = "Name:"
            lblName.AutoSize = True
            lblName.Location = New Point(20, 20)

            Dim txtName As New TextBox()
            txtName.Location = New Point(180, 18)
            txtName.Size = New Size(240, 30)
            txtName.Text = dateiname

            Dim lblBreite As New Label()
            lblBreite.Text = "Breite:"
            lblBreite.AutoSize = True
            lblBreite.Location = New Point(20, 65)

            Dim nudBreite As New NumericUpDown()
            nudBreite.Location = New Point(180, 63)
            nudBreite.Size = New Size(120, 30)
            nudBreite.Minimum = 1
            nudBreite.Maximum = 10000
            nudBreite.Value = breite

            Dim lblHoehe As New Label()
            lblHoehe.Text = "Höhe:"
            lblHoehe.AutoSize = True
            lblHoehe.Location = New Point(20, 110)

            Dim nudHoehe As New NumericUpDown()
            nudHoehe.Location = New Point(180, 108)
            nudHoehe.Size = New Size(120, 30)
            nudHoehe.Minimum = 1
            nudHoehe.Maximum = 10000
            nudHoehe.Value = hoehe

            Dim lblKommentar As New Label()
            lblKommentar.Text = "Kommentar:"
            lblKommentar.AutoSize = True
            lblKommentar.Location = New Point(20, 155)

            Dim txtKommentar As New TextBox()
            txtKommentar.Location = New Point(180, 153)
            txtKommentar.Size = New Size(240, 90)
            txtKommentar.Multiline = True
            txtKommentar.ScrollBars = ScrollBars.Vertical
            txtKommentar.Text = kommentar

            Dim btnOk As New Button()
            btnOk.Text = "OK"
            btnOk.DialogResult = DialogResult.OK
            btnOk.Location = New Point(264, 265)
            btnOk.Size = New Size(75, 30)

            Dim btnAbbrechen As New Button()
            btnAbbrechen.Text = "Abbrechen"
            btnAbbrechen.DialogResult = DialogResult.Cancel
            btnAbbrechen.Location = New Point(345, 265)
            btnAbbrechen.Size = New Size(75, 30)

            dlg.Controls.Add(lblName)
            dlg.Controls.Add(txtName)
            dlg.Controls.Add(lblBreite)
            dlg.Controls.Add(nudBreite)
            dlg.Controls.Add(lblHoehe)
            dlg.Controls.Add(nudHoehe)
            dlg.Controls.Add(lblKommentar)
            dlg.Controls.Add(txtKommentar)
            dlg.Controls.Add(btnOk)
            dlg.Controls.Add(btnAbbrechen)

            dlg.AcceptButton = btnOk
            dlg.CancelButton = btnAbbrechen

            If dlg.ShowDialog(Me) <> DialogResult.OK Then
                Return False
            End If

            dateiname = txtName.Text.Trim()
            If dateiname = "" Then
                dateiname = "neues_bild"
            End If

            breite = CInt(nudBreite.Value)
            hoehe = CInt(nudHoehe.Value)
            kommentar = txtKommentar.Text.Trim()

            Return True
        End Using
    End Function

    Private Function VersucheBildKoordinateAusMouseEvent(ByVal e As MouseEventArgs, ByRef bildPunkt As Point) As Boolean
        bildPunkt = New Point(0, 0)

        If _workingPgm Is Nothing Then
            Return False
        End If

        If pbImage.Width <= 0 OrElse pbImage.Height <= 0 Then
            Return False
        End If

        If e.X < 0 OrElse e.Y < 0 OrElse e.X >= pbImage.Width OrElse e.Y >= pbImage.Height Then
            Return False
        End If

        Dim bildX As Integer = CInt(Math.Floor(e.X * (_workingPgm.Width / CDbl(pbImage.Width))))
        Dim bildY As Integer = CInt(Math.Floor(e.Y * (_workingPgm.Height / CDbl(pbImage.Height))))

        If bildX < 0 Then bildX = 0
        If bildY < 0 Then bildY = 0
        If bildX >= _workingPgm.Width Then bildX = _workingPgm.Width - 1
        If bildY >= _workingPgm.Height Then bildY = _workingPgm.Height - 1

        bildPunkt = New Point(bildX, bildY)
        Return True
    End Function

    Private Function HoleBildpunktAusAktuellerMausposition(ByRef bildPunkt As Point) As Boolean
        bildPunkt = New Point(0, 0)

        If _workingPgm Is Nothing Then
            Return False
        End If

        If pbImage.Width <= 0 OrElse pbImage.Height <= 0 Then
            Return False
        End If

        Dim clientPunkt As Point = pbImage.PointToClient(Control.MousePosition)

        Dim x As Integer = clientPunkt.X
        Dim y As Integer = clientPunkt.Y

        If x < 0 Then x = 0
        If y < 0 Then y = 0
        If x >= pbImage.Width Then x = pbImage.Width - 1
        If y >= pbImage.Height Then y = pbImage.Height - 1

        Dim bildX As Integer = CInt(Math.Floor(x * (_workingPgm.Width / CDbl(pbImage.Width))))
        Dim bildY As Integer = CInt(Math.Floor(y * (_workingPgm.Height / CDbl(pbImage.Height))))

        If bildX < 0 Then bildX = 0
        If bildY < 0 Then bildY = 0
        If bildX >= _workingPgm.Width Then bildX = _workingPgm.Width - 1
        If bildY >= _workingPgm.Height Then bildY = _workingPgm.Height - 1

        bildPunkt = New Point(bildX, bildY)
        Return True
    End Function

    Private Function HoleAktuellenGrauwert() As Integer
        Return CInt(nudGrauwert.Value)
    End Function

    Private Function HoleAktuellePixeldicke() As Integer
        Return CInt(nudPixeldicke.Value)
    End Function

    Private Sub SetzePixelWennGueltig(ByVal x As Integer, ByVal y As Integer, ByVal grayValue As Integer)
        If _workingPgm Is Nothing Then
            Exit Sub
        End If

        If x < 0 OrElse y < 0 OrElse x >= _workingPgm.Width OrElse y >= _workingPgm.Height Then
            Exit Sub
        End If

        _workingPgm.SetPixel(x, y, grayValue)
    End Sub

    Private Sub ZeichnePunktMitDicke(ByVal centerX As Integer, ByVal centerY As Integer, ByVal grayValue As Integer, ByVal thickness As Integer)
        Dim startX As Integer = centerX - ((thickness - 1) \ 2)
        Dim endX As Integer = centerX + (thickness \ 2)
        Dim startY As Integer = centerY - ((thickness - 1) \ 2)
        Dim endY As Integer = centerY + (thickness \ 2)

        Dim x As Integer
        Dim y As Integer

        For y = startY To endY
            For x = startX To endX
                SetzePixelWennGueltig(x, y, grayValue)
            Next
        Next
    End Sub

    Private Sub ZeichnePixelWerkzeug(ByVal punkt As Point)
        ZeichnePunktMitDicke(punkt.X, punkt.Y, HoleAktuellenGrauwert(), HoleAktuellePixeldicke())
        AktualisiereBildAnzeige()
    End Sub

    Private Sub ZeichneLinie(ByVal startPunkt As Point, ByVal endPunkt As Point)
        Dim x0 As Integer = startPunkt.X
        Dim y0 As Integer = startPunkt.Y
        Dim x1 As Integer = endPunkt.X
        Dim y1 As Integer = endPunkt.Y

        Dim dx As Integer = Math.Abs(x1 - x0)
        Dim dy As Integer = Math.Abs(y1 - y0)
        Dim sx As Integer = If(x0 < x1, 1, -1)
        Dim sy As Integer = If(y0 < y1, 1, -1)
        Dim err As Integer = dx - dy

        Dim grayValue As Integer = HoleAktuellenGrauwert()
        Dim thickness As Integer = HoleAktuellePixeldicke()

        Do
            ZeichnePunktMitDicke(x0, y0, grayValue, thickness)

            If x0 = x1 AndAlso y0 = y1 Then
                Exit Do
            End If

            Dim e2 As Integer = err * 2

            If e2 > -dy Then
                err -= dy
                x0 += sx
            End If

            If e2 < dx Then
                err += dx
                y0 += sy
            End If
        Loop

        AktualisiereBildAnzeige()
    End Sub

    Private Sub ZeichneRechteck(ByVal startPunkt As Point, ByVal endPunkt As Point)
        Dim left As Integer = Math.Min(startPunkt.X, endPunkt.X)
        Dim right As Integer = Math.Max(startPunkt.X, endPunkt.X)
        Dim top As Integer = Math.Min(startPunkt.Y, endPunkt.Y)
        Dim bottom As Integer = Math.Max(startPunkt.Y, endPunkt.Y)

        Dim grayValue As Integer = HoleAktuellenGrauwert()
        Dim thickness As Integer = HoleAktuellePixeldicke()
        Dim i As Integer
        Dim x As Integer
        Dim y As Integer

        For i = 0 To thickness - 1
            For x = left To right
                SetzePixelWennGueltig(x, top + i, grayValue)
                SetzePixelWennGueltig(x, bottom - i, grayValue)
            Next

            For y = top To bottom
                SetzePixelWennGueltig(left + i, y, grayValue)
                SetzePixelWennGueltig(right - i, y, grayValue)
            Next
        Next

        AktualisiereBildAnzeige()
    End Sub

    Private Sub StarteZeichnen(ByVal punkt As Point)
        _istZeichnenAktiv = True
        _zeichnenStartpunkt = punkt
        _letzterPixelPunkt = punkt
        pbImage.Capture = True

        Select Case _aktuellesWerkzeug
            Case ToolMode.Pixel
                ZeichnePixelWerkzeug(punkt)
        End Select
    End Sub

    Private Sub BeendeZeichnen()
        _istZeichnenAktiv = False
        _letzterPixelPunkt = New Point(-1, -1)
        pbImage.Capture = False
    End Sub

    Private Sub mnuNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNeu.Click
        Dim breite As Integer = 256
        Dim hoehe As Integer = 256
        Dim dateiname As String = "neues_bild"
        Dim kommentar As String = ""

        If Not ZeigeNeuBildDialog(breite, hoehe, dateiname, kommentar) Then
            Exit Sub
        End If

        ErstelleNeuesBild(breite, hoehe, dateiname, kommentar)
    End Sub

    Private Sub mnuBildOeffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBildOeffnen.Click
        If ofdBildOeffnen.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        LadeBild(ofdBildOeffnen.FileName)
    End Sub

    Private Sub mnuBildSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBildSpeichern.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Speichern",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        If sfdBildSpeichern.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Try
            _workingPgm.SaveAsP2(sfdBildSpeichern.FileName)

            MessageBox.Show("Bild wurde erfolgreich gespeichert.",
                            "Speichern",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Fehler beim Speichern:" & Environment.NewLine & ex.Message,
                            "Fehler",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mnuEigenschaften_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEigenschaften.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Eigenschaften",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim info As String = ""
        info &= "Dateiname: " & lblDateiNameWert.Text & Environment.NewLine
        info &= "Format: " & lblFormatWert.Text & Environment.NewLine
        info &= "Bildgröße: " & lblBildgroesseWert.Text & Environment.NewLine
        info &= "Max. Grauwert: " & lblMaxGrauwertWert.Text

        MessageBox.Show(info,
                        "Bildeigenschaften",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub mnuZoomen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuZoomen.Click
        ZeigeAnsichtTab()
    End Sub

    Private Sub mnuOrginalGroesse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrginalGroesse.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Originalgröße",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        SetzeOriginalgroesse()
        ZeigeAnsichtTab()
    End Sub

    Private Sub btnOrginalGroesse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrginalGroesse.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Originalgröße",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        SetzeOriginalgroesse()
    End Sub

    Private Sub mnuAnsFensterAnpassen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnsFensterAnpassen.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Ans Fenster anpassen",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        SetzeAnsFensterAnpassen()
        ZeigeAnsichtTab()
    End Sub

    Private Sub btnAnsFensterAnpassen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnsFensterAnpassen.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Ans Fenster anpassen",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        SetzeAnsFensterAnpassen()
    End Sub

    Private Sub mnuHorizontalSpiegeln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHorizontalSpiegeln.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Horizontal spiegeln",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        _workingPgm.FlipHorizontal()
        AktualisiereBildAnzeige()
        ZeigeAnsichtTab()
    End Sub

    Private Sub btnHorizontalSpiegeln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHorizontalSpiegeln.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Horizontal spiegeln",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        _workingPgm.FlipHorizontal()
        AktualisiereBildAnzeige()
    End Sub

    Private Sub mnuVertikalSpiegeln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVertikalSpiegeln.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Vertikal spiegeln",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        _workingPgm.FlipVertical()
        AktualisiereBildAnzeige()
        ZeigeAnsichtTab()
    End Sub

    Private Sub btnVertikalSpiegeln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVertikalSpiegeln.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Vertikal spiegeln",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        _workingPgm.FlipVertical()
        AktualisiereBildAnzeige()
    End Sub

    Private Sub btnZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomIn.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Zoom",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        ZoomIn()
    End Sub

    Private Sub btnZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomOut.Click
        If _workingPgm Is Nothing Then
            MessageBox.Show("Es ist noch kein Bild geladen.",
                            "Zoom",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        ZoomOut()
    End Sub

    Private Sub mnuPixelZeichnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPixelZeichnen.Click
        ZeigeZeichnenTab()
        SetzeWerkzeug(ToolMode.Pixel)
    End Sub

    Private Sub mnuLinieZeichnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLinieZeichnen.Click
        ZeigeZeichnenTab()
        SetzeWerkzeug(ToolMode.Linie)
    End Sub

    Private Sub mnuRechteckZeichnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRechteckZeichnen.Click
        ZeigeZeichnenTab()
        SetzeWerkzeug(ToolMode.Rechteck)
    End Sub

    Private Sub rdoZeiger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoZeiger.Click
        SetzeWerkzeug(ToolMode.Zeiger)
    End Sub

    Private Sub rdoPanning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPanning.Click
        SetzeWerkzeug(ToolMode.Panning)
    End Sub

    Private Sub rdoPixel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPixel.Click
        SetzeWerkzeug(ToolMode.Pixel)
    End Sub

    Private Sub rdoLinie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoLinie.Click
        SetzeWerkzeug(ToolMode.Linie)
    End Sub

    Private Sub rdoRechteck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoRechteck.Click
        SetzeWerkzeug(ToolMode.Rechteck)
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If _workingPgm Is Nothing Then
            Exit Sub
        End If

        If e.Control Then
            Select Case e.KeyCode
                Case Keys.Add, Keys.Oemplus
                    ZoomIn()
                    e.SuppressKeyPress = True

                Case Keys.Subtract, Keys.OemMinus
                    ZoomOut()
                    e.SuppressKeyPress = True
            End Select
        End If
    End Sub

    Private Sub frmMain_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseWheel
        If _workingPgm Is Nothing Then
            Exit Sub
        End If

        If (Control.ModifierKeys And Keys.Control) <> Keys.Control Then
            Exit Sub
        End If

        If e.Delta > 0 Then
            ZoomIn()
        ElseIf e.Delta < 0 Then
            ZoomOut()
        End If
    End Sub

    Private Sub pbImage_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbImage.MouseDown
        If _workingPgm Is Nothing Then
            Exit Sub
        End If

        AktiviereFormFokus()

        If e.Button <> Windows.Forms.MouseButtons.Left Then
            Exit Sub
        End If

        If IstPanningModusAktiv() Then
            StartePanning()
            Exit Sub
        End If

        If Not IstZeichenWerkzeugAktiv() Then
            Exit Sub
        End If

        Dim bildPunkt As Point
        If Not HoleBildpunktAusAktuellerMausposition(bildPunkt) Then
            Exit Sub
        End If

        StarteZeichnen(bildPunkt)
    End Sub

    Private Sub pnlImageHost_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlImageHost.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then
            Exit Sub
        End If

        If IstPanningModusAktiv() Then
            StartePanning()
        End If
    End Sub

    Private Sub pbImage_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbImage.MouseMove
        If _workingPgm Is Nothing Then
            Exit Sub
        End If

        AktiviereFormFokus()

        If _istPanning Then
            FuehrePanningAus()
            Exit Sub
        End If

        Dim bildPunkt As Point
        If Not VersucheBildKoordinateAusMouseEvent(e, bildPunkt) Then
            Exit Sub
        End If

        lblXWert.Text = bildPunkt.X.ToString()
        lblYWert.Text = bildPunkt.Y.ToString()
        lblGrauwertWert.Text = _workingPgm.GetPixel(bildPunkt.X, bildPunkt.Y).ToString()

        sslX.Text = "X: " & bildPunkt.X.ToString()
        sslY.Text = "Y: " & bildPunkt.Y.ToString()
        sslPixelwert.Text = "Pixel: " & _workingPgm.GetPixel(bildPunkt.X, bildPunkt.Y).ToString()

        If _istZeichnenAktiv AndAlso _aktuellesWerkzeug = ToolMode.Pixel AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
            Dim aktuellerPunkt As Point
            If HoleBildpunktAusAktuellerMausposition(aktuellerPunkt) Then
                If aktuellerPunkt <> _letzterPixelPunkt Then
                    ZeichnePixelWerkzeug(aktuellerPunkt)
                    _letzterPixelPunkt = aktuellerPunkt
                End If
            End If
        End If
    End Sub

    Private Sub pnlImageHost_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlImageHost.MouseMove
        If _istPanning Then
            FuehrePanningAus()
        End If
    End Sub

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If _istPanning Then
            FuehrePanningAus()
        End If
    End Sub

    Private Sub pbImage_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbImage.MouseUp
        If _istPanning Then
            BeendePanning()
            Exit Sub
        End If

        If Not _istZeichnenAktiv Then
            Exit Sub
        End If

        Dim bildPunkt As Point
        If Not HoleBildpunktAusAktuellerMausposition(bildPunkt) Then
            BeendeZeichnen()
            Exit Sub
        End If

        Select Case _aktuellesWerkzeug
            Case ToolMode.Linie
                ZeichneLinie(_zeichnenStartpunkt, bildPunkt)

            Case ToolMode.Rechteck
                ZeichneRechteck(_zeichnenStartpunkt, bildPunkt)
        End Select

        BeendeZeichnen()
    End Sub

    Private Sub pnlImageHost_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlImageHost.MouseUp
        BeendePanning()
    End Sub

    Private Sub frmMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        BeendePanning()

        If _istZeichnenAktiv AndAlso (_aktuellesWerkzeug = ToolMode.Linie OrElse _aktuellesWerkzeug = ToolMode.Rechteck) Then
            Dim bildPunkt As Point
            If HoleBildpunktAusAktuellerMausposition(bildPunkt) Then
                Select Case _aktuellesWerkzeug
                    Case ToolMode.Linie
                        ZeichneLinie(_zeichnenStartpunkt, bildPunkt)
                    Case ToolMode.Rechteck
                        ZeichneRechteck(_zeichnenStartpunkt, bildPunkt)
                End Select
            End If

            BeendeZeichnen()
        End If
    End Sub

    Private Sub pbImage_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbImage.MouseLeave
        If Not _istPanning Then
            lblXWert.Text = "-"
            lblYWert.Text = "-"
            lblGrauwertWert.Text = "-"

            sslX.Text = "X: -"
            sslY.Text = "Y: -"
            sslPixelwert.Text = "Pixel: -"
        End If
    End Sub

    Private Sub pbImage_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbImage.MouseEnter
        AktiviereFormFokus()
        AktualisierePanningCursor()
    End Sub

    Private Sub pnlImageHost_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlImageHost.MouseEnter
        AktiviereFormFokus()
        AktualisierePanningCursor()
    End Sub

    Private Sub lblDropHint_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDropHint.MouseEnter
        AktiviereFormFokus()
        AktualisierePanningCursor()
    End Sub

    Private Sub pnlImageHost_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlImageHost.Resize
        If _fitToWindow AndAlso _workingPgm IsNot Nothing Then
            AktualisiereBildAnzeige()
        End If
    End Sub

    Private Sub tabSide_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabSide.SelectedIndexChanged
        BeendeAlleInteraktionen()
        AktualisierePanningCursor()
        AktualisiereModusAnzeige()
    End Sub

    Private Sub ErstelleNeuesBild(ByVal breite As Integer,
                                  ByVal hoehe As Integer,
                                  ByVal dateiname As String,
                                  ByVal kommentar As String)
        If dateiname Is Nothing OrElse dateiname.Trim() = "" Then
            dateiname = "neues_bild"
        End If

        If Not dateiname.ToLower().EndsWith(".pgm") Then
            dateiname &= ".pgm"
        End If

        _originalPgm = PgmImage.CreateBlank(breite, hoehe, 255, "P2", 255)
        _originalPgm.FilePath = dateiname
        _originalPgm.Comment = kommentar

        _workingPgm = _originalPgm.CloneImage()

        _fitToWindow = False
        _zoomFactor = 1.0
        BeendeAlleInteraktionen()

        sfdBildSpeichern.FileName = dateiname

        AktualisiereBildAnzeige()
        AktualisiereDetails()
        AktualisiereStatusNachBildLaden()
    End Sub

    Private Sub BildDragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) _
        Handles Me.DragEnter, pnlImageHost.DragEnter, pbImage.DragEnter, lblDropHint.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim dateien() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

            If dateien IsNot Nothing AndAlso dateien.Length > 0 AndAlso IstPgmDatei(dateien(0)) Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub BildDragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) _
        Handles Me.DragDrop, pnlImageHost.DragDrop, pbImage.DragDrop, lblDropHint.DragDrop

        If Not e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Exit Sub
        End If

        Dim dateien() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        If dateien Is Nothing OrElse dateien.Length = 0 Then
            Exit Sub
        End If

        If Not IstPgmDatei(dateien(0)) Then
            MessageBox.Show("In dieser Version werden nur PGM-Dateien unterstützt.",
                            "Drag & Drop",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        LadeBild(dateien(0))
    End Sub

    Private Sub mnuInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInfo.Click
        MessageBox.Show("Graustufen Viewer" & Environment.NewLine &
                        "PGM-Viewer mit Basisfunktionen für Ansicht und Bearbeitung.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Protected Overrides Sub OnFormClosed(ByVal e As FormClosedEventArgs)
        VerwerfeDisplayBitmap()
        MyBase.OnFormClosed(e)
    End Sub

End Class