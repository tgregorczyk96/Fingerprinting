Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class PgmImage
    Public Property Comment As String
    Public Property Width As Integer
    Public Property Height As Integer
    Public Property MaxGrayValue As Integer
    Public Property MagicNumber As String
    Public Property FilePath As String

    Private _pixels(,) As Integer

    Public Sub New(ByVal width As Integer, ByVal height As Integer, ByVal maxGrayValue As Integer, ByVal magicNumber As String)
        Me.Width = width
        Me.Height = height
        Me.MaxGrayValue = maxGrayValue
        Me.MagicNumber = magicNumber

        ReDim _pixels(width - 1, height - 1)
    End Sub

    Public Function GetPixel(ByVal x As Integer, ByVal y As Integer) As Integer
        Return _pixels(x, y)
    End Function

    Public Sub SetPixel(ByVal x As Integer, ByVal y As Integer, ByVal grayValue As Integer)
        If grayValue < 0 Then grayValue = 0
        If grayValue > MaxGrayValue Then grayValue = MaxGrayValue

        _pixels(x, y) = grayValue
    End Sub

    Public Function CloneImage() As PgmImage
        Dim copy As New PgmImage(Me.Width, Me.Height, Me.MaxGrayValue, Me.MagicNumber)
        copy.FilePath = Me.FilePath
        copy.Comment = Me.Comment

        Dim x As Integer
        Dim y As Integer

        For y = 0 To Me.Height - 1
            For x = 0 To Me.Width - 1
                copy.SetPixel(x, y, Me.GetPixel(x, y))
            Next
        Next

        Return copy
    End Function

    Public Shared Function CreateBlank(ByVal width As Integer,
                                   ByVal height As Integer,
                                   ByVal maxGrayValue As Integer,
                                   ByVal magicNumber As String,
                                   Optional ByVal fillValue As Integer = 255) As PgmImage
        Dim img As New PgmImage(width, height, maxGrayValue, magicNumber)

        Dim x As Integer
        Dim y As Integer

        If fillValue < 0 Then fillValue = 0
        If fillValue > maxGrayValue Then fillValue = maxGrayValue

        For y = 0 To height - 1
            For x = 0 To width - 1
                img.SetPixel(x, y, fillValue)
            Next
        Next

        Return img
    End Function

    Public Function ToBitmap() As Bitmap
        Dim bmp As New Bitmap(Me.Width, Me.Height)

        Dim x As Integer
        Dim y As Integer

        For y = 0 To Me.Height - 1
            For x = 0 To Me.Width - 1
                Dim scaledGray As Integer = CInt(Math.Round((Me.GetPixel(x, y) / CDbl(Me.MaxGrayValue)) * 255.0))

                If scaledGray < 0 Then scaledGray = 0
                If scaledGray > 255 Then scaledGray = 255

                bmp.SetPixel(x, y, Color.FromArgb(scaledGray, scaledGray, scaledGray))
            Next
        Next

        Return bmp
    End Function

    Public Sub FlipHorizontal()
        Dim x As Integer
        Dim y As Integer

        For y = 0 To Me.Height - 1
            For x = 0 To (Me.Width \ 2) - 1
                Dim oppositeX As Integer = Me.Width - 1 - x
                Dim temp As Integer = _pixels(x, y)
                _pixels(x, y) = _pixels(oppositeX, y)
                _pixels(oppositeX, y) = temp
            Next
        Next
    End Sub

    Public Sub FlipVertical()
        Dim x As Integer
        Dim y As Integer

        For x = 0 To Me.Width - 1
            For y = 0 To (Me.Height \ 2) - 1
                Dim oppositeY As Integer = Me.Height - 1 - y
                Dim temp As Integer = _pixels(x, y)
                _pixels(x, y) = _pixels(x, oppositeY)
                _pixels(x, oppositeY) = temp
            Next
        Next
    End Sub

    Public Sub SaveAsP2(ByVal filePath As String)
        Using sw As New StreamWriter(filePath, False, Encoding.ASCII)
            sw.WriteLine("P2")

            If Me.Comment IsNot Nothing AndAlso Me.Comment.Trim() <> "" Then
                Dim lines() As String = Me.Comment.Replace(vbCrLf, vbLf).Split(ControlChars.Lf)

                Dim i As Integer
                For i = 0 To lines.Length - 1
                    sw.WriteLine("# " & lines(i))
                Next
            End If

            sw.WriteLine(Me.Width.ToString() & " " & Me.Height.ToString())
            sw.WriteLine(Me.MaxGrayValue.ToString())

            Dim x As Integer
            Dim y As Integer

            For y = 0 To Me.Height - 1
                Dim line As New StringBuilder()

                For x = 0 To Me.Width - 1
                    line.Append(Me.GetPixel(x, y).ToString())

                    If x < Me.Width - 1 Then
                        line.Append(" ")
                    End If
                Next

                sw.WriteLine(line.ToString())
            Next
        End Using
    End Sub

    Public Shared Function LoadFromFile(ByVal filePath As String) As PgmImage
        Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
            Dim magicNumber As String = ReadNextToken(fs)

            If magicNumber <> "P2" AndAlso magicNumber <> "P5" Then
                Throw New Exception("Nur P2- und P5-PGM-Dateien werden unterstützt.")
            End If

            Dim width As Integer = Integer.Parse(ReadNextToken(fs))
            Dim height As Integer = Integer.Parse(ReadNextToken(fs))
            Dim maxGrayValue As Integer = Integer.Parse(ReadNextToken(fs))

            If maxGrayValue <= 0 Then
                Throw New Exception("Ungültiger Maximalwert in der PGM-Datei.")
            End If

            Dim img As New PgmImage(width, height, maxGrayValue, magicNumber)
            img.FilePath = filePath

            If magicNumber = "P2" Then
                LoadP2Data(fs, img)
            Else
                LoadP5Data(fs, img)
            End If

            Return img
        End Using
    End Function

    Private Shared Sub LoadP2Data(ByVal fs As Stream, ByVal img As PgmImage)
        Dim x As Integer
        Dim y As Integer

        For y = 0 To img.Height - 1
            For x = 0 To img.Width - 1
                Dim token As String = ReadNextToken(fs)

                If String.IsNullOrEmpty(token) Then
                    Throw New Exception("Die PGM-Datei ist unvollständig.")
                End If

                img.SetPixel(x, y, Integer.Parse(token))
            Next
        Next
    End Sub

    Private Shared Sub LoadP5Data(ByVal fs As Stream, ByVal img As PgmImage)
        If img.MaxGrayValue > 255 Then
            Throw New Exception("P5 mit Maximalwert > 255 wird in dieser Version noch nicht unterstützt.")
        End If

        SkipWhitespaceAndComments(fs)

        Dim x As Integer
        Dim y As Integer

        For y = 0 To img.Height - 1
            For x = 0 To img.Width - 1
                Dim value As Integer = fs.ReadByte()

                If value = -1 Then
                    Throw New Exception("Die PGM-Datei ist unvollständig.")
                End If

                img.SetPixel(x, y, value)
            Next
        Next
    End Sub

    Private Shared Function ReadNextToken(ByVal fs As Stream) As String
        Dim sb As New StringBuilder()
        Dim b As Integer

        Do
            b = fs.ReadByte()

            If b = -1 Then
                Return Nothing
            End If

            Dim ch As Char = ChrW(b)

            If Char.IsWhiteSpace(ch) Then
                ' weiter
            ElseIf ch = "#"c Then
                SkipComment(fs)
            Else
                sb.Append(ch)
                Exit Do
            End If
        Loop

        Do
            b = fs.ReadByte()

            If b = -1 Then
                Exit Do
            End If

            Dim ch As Char = ChrW(b)

            If Char.IsWhiteSpace(ch) Then
                Exit Do
            ElseIf ch = "#"c Then
                SkipComment(fs)
                Exit Do
            Else
                sb.Append(ch)
            End If
        Loop

        Return sb.ToString()
    End Function

    Private Shared Sub SkipComment(ByVal fs As Stream)
        Dim b As Integer

        Do
            b = fs.ReadByte()
            If b = -1 OrElse b = 10 OrElse b = 13 Then
                Exit Do
            End If
        Loop
    End Sub

    Private Shared Sub SkipWhitespaceAndComments(ByVal fs As Stream)
        Dim b As Integer

        Do
            b = fs.ReadByte()

            If b = -1 Then
                Exit Do
            End If

            Dim ch As Char = ChrW(b)

            If Char.IsWhiteSpace(ch) Then
                ' weiter
            ElseIf ch = "#"c Then
                SkipComment(fs)
            Else
                fs.Position = fs.Position - 1
                Exit Do
            End If
        Loop
    End Sub

End Class
