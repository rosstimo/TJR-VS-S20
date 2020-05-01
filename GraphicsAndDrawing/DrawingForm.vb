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

        Dim vi As Double
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim xOffset As Integer = DrawingPictureBox.Width \ 360
        Dim oldAngle As Integer
        Dim oldVi As Integer = yOffset

        getSinWave(4, 100, 360)

        For angle = 0 To 360

            vi = yOffset * Math.Sin((angle) * (Math.PI / 180)) + yOffset

            'Console.WriteLine("Angle: " & angle.ToString & "x: " & (angle * (DrawingPictureBox.Width / 360)).ToString & " Y: " & vi.ToString())

            graph.DrawLine(myPen, oldAngle * xOffset, oldVi, angle * xOffset, CInt(vi))

            oldAngle = angle
            oldVi = CInt(vi)
        Next

        'free up resources
        myPen.Dispose()
        graph.Dispose()

    End Sub

    Sub getSinWave(numberOfPoints As Integer, yMax As Integer, xMax As Integer)

        Dim y As Double
        Dim oldX As Double
        Dim oldY As Double
        Dim sinWaveData(numberOfPoints, 1) As Integer
        Dim xPerPoint As Double = xMax / numberOfPoints
        Dim degrees As Double

        For x = 0 To numberOfPoints
            degrees = (x * xPerPoint) * (Math.PI / 180)
            y = yMax * Math.Sin(degrees)
            sinWaveData(x, 0) = CInt(y)
            sinWaveData(x, 1) = CInt(x * xPerPoint)
            Console.WriteLine("X: " & (x * xPerPoint).ToString & " Y: " & y.ToString())
        Next
        Console.WriteLine()
    End Sub


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