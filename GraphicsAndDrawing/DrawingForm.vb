Public Class DrawingForm
    'Crate a rescale method
    'Draw with new scaled units
    'Create move origin method
    'save and redraw stuff

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        Dim scaleFactor As Integer = 100
        Dim xScale As Decimal = scaleFactor
        Dim yScale As Decimal = scaleFactor

        Dim xPercent, yPercent As Decimal
        Me.Text = e.X.ToString & " " & e.Y.ToString
        ReScale(xScale, yScale)
        'position in pixels / pixels per unit
        xPercent = e.X / xScale
        yPercent = e.Y / yScale
        'Me.Text = xPercent.ToString("n2") & " " & yPercent.ToString("n2")
    End Sub

    Sub ReScale(ByRef xScale As Decimal, ByRef yScale As Decimal)

        xScale = DrawingPictureBox.Width / xScale
        yScale = DrawingPictureBox.Height / yScale

    End Sub
    Sub UnitsToPixels(ByRef xUnit As Decimal, ByRef yUnit As Decimal)
        'TODO store pixels per x & y unit
        'xUnit = pixels per xunit / xUnit
        'xUnit = pixels per yunit / xUnit

    End Sub

    Sub drawLine() Handles GoButton.Click

        'create graphics object
        Dim graph As Graphics
        graph = DrawingPictureBox.CreateGraphics

        'constructor for pen object
        Dim myPen As New Pen(Color.Black)

        Dim startX As Integer = 0
        Dim startY As Integer = DrawingPictureBox.Height \ 2
        Dim endX As Integer = DrawingPictureBox.Width
        Dim endY As Integer = DrawingPictureBox.Height \ 2

        'draw the line
        graph.DrawLine(myPen, startX, startY, endX, endY)

        'draw sin wave??
        'Vi = Vp*Sin(omega*time + theta) +DC
        'Vi = Vp*Sin(n(angle per point))

        'peak half height
        '1 cycle from 0 to total width
        '



        Dim numberOfPoints As Integer = 20
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim wavePeak As Integer = yOffset * 1

        Dim waveWidthInDegrees As Integer = 360
        Dim xOffset As Integer = DrawingPictureBox.Width \ waveWidthInDegrees

        Dim waveData(numberOfPoints, 1) As Integer

        Dim xOld As Integer
        Dim yOld As Integer = yOffset
        Dim xNew As Integer
        Dim yNew As Integer

        waveData = getSinWave(numberOfPoints, wavePeak, DrawingPictureBox.Width)

        For i = LBound(waveData) To UBound(waveData)
            xNew = waveData(i, 0)
            yNew = waveData(i, 1) + yOffset
            graph.DrawLine(myPen, xOld, yOld, xNew, yNew)
            xOld = xNew
            yOld = yNew
        Next

        'free up resources
        myPen.Dispose()
        graph.Dispose()

    End Sub

    Function getSinWave(numberOfPoints As Integer, yMax As Integer, xMax As Integer) As Integer(,)

        Dim sinWaveData(numberOfPoints, 1) As Integer
        Dim yCurrent As Double
        Dim xPerPoint As Double = xMax / numberOfPoints 'xMax / 360 'numberOfPoints
        Dim degreesPerPoint As Double = 360 / numberOfPoints
        Dim theta As Double

        For xCurrent = 0 To numberOfPoints
            theta = (xCurrent * degreesPerPoint) * (Math.PI / 180)
            yCurrent = yMax * Math.Sin(theta)
            sinWaveData(xCurrent, 1) = CInt(yCurrent)
            sinWaveData(xCurrent, 0) = CInt(xCurrent * xPerPoint)
            Console.WriteLine("X: " & sinWaveData(xCurrent, 0).ToString & " Y: " & sinWaveData(xCurrent, 1).ToString())
        Next

        Return sinWaveData
    End Function


End Class

'vi = 0 * (180 / Math.PI)
'vi = (Math.PI / 2) * (180 / Math.PI)
'vi = (Math.PI) * (180 / Math.PI)
'vi = ((3 * Math.PI) / 2) * (180 / Math.PI)

'vi = 0 * (Math.PI / 180)
'vi = 90 * (Math.PI / 180)
'vi = 180 * (Math.PI / 180)
'vi = 270 * (Math.PI / 180)
'vi = 57.29578 * (Math.PI / 180)