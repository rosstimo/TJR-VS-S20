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

    Sub drawWave()

        'create graphics object
        Dim graph As Graphics
        graph = DrawingPictureBox.CreateGraphics

        'constructor for pen object
        Dim myPen As New Pen(Color.Black)

        Dim numberOfPoints As Integer = 20
        Dim waveWidth As Integer = DrawingPictureBox.Width
        Dim yCenter As Integer = DrawingPictureBox.Height \ 2
        Dim wavePeak As Integer = yCenter * 1

        Dim waveData(numberOfPoints, 1) As Integer

        Dim xOld As Integer
        Dim yOld As Integer = yCenter
        Dim xNew As Integer
        Dim yNew As Integer

        waveData = getSinWave(numberOfPoints, wavePeak, waveWidth)

        For i = LBound(waveData) To UBound(waveData)
            xNew = waveData(i, 0)
            yNew = waveData(i, 1) + yCenter
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

    Sub DrawDivisions()
        'create graphics object
        Dim graph As Graphics
        graph = DrawingPictureBox.CreateGraphics
        'constructor for pen object
        Dim myPen As New Pen(Color.Black)

        Dim Top As Integer
        Dim Bottom As Integer
        Dim Height As Integer = DrawingPictureBox.Height
        Dim Width As Integer = DrawingPictureBox.Width

        graph.Clear(BackColor)

        For Div = 0 To Width Step Width \ 10
            graph.DrawLine(myPen, Div, 0, Div, Height)
            For subDiv = 0 To Height Step Height \ 50
                graph.DrawLine(myPen, Div - 5, subDiv, Div + 5, subDiv)
            Next
        Next

        For Div = 0 To Height Step Height \ 10
            graph.DrawLine(myPen, 0, Div, Width, Div)
            For subDiv = 0 To Width Step Width \ 50
                graph.DrawLine(myPen, subDiv, Div - 5, subDiv, Div + 5)
            Next
        Next

        graph.DrawLine(myPen, Width - 1, 0, Width - 1, Height)
        graph.DrawLine(myPen, 0, Height - 1, Width, Height - 1)

        'free up resources
        myPen.Dispose()
        graph.Dispose()

    End Sub

    Private Sub DrawingForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'FixSize()
        'DrawingPictureBox.BackColor = Color.Blac
    End Sub

    Sub FixSize()
        GoButton.Top = DrawingPictureBox.Top + DrawingPictureBox.Height + 10
        GoButton.Left = DrawingPictureBox.Left
        ClearButton.Top = DrawingPictureBox.Top + DrawingPictureBox.Height + 10
        ClearButton.Left = DrawingPictureBox.Left + GoButton.Width + 10
        ExitButton.Top = DrawingPictureBox.Top + DrawingPictureBox.Height + 10
        ExitButton.Left = DrawingPictureBox.Left + GoButton.Width + 10 + ClearButton.Width + 10
        DrawingPictureBox.Height = 50 * (CInt(Me.Height - GoButton.Height - 50) \ 50)
        DrawingPictureBox.Width = DrawingPictureBox.Height
    End Sub
    Private Sub DrawingForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Me.Height = DrawingPictureBox.Height + GoButton.Height + 30
        ' Me.Width = Me.Height
        DrawingPictureBox.Refresh()
        FixSize()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        DrawDivisions()
        drawWave()
    End Sub
End Class
