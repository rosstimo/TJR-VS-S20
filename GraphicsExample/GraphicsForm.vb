Public Class GraphicsForm



    Sub drawLine()

        'create graphics object
        Dim graph As Graphics
        graph = Me.CreateGraphics

        'constructor for pen object
        Dim myPen As New Pen(Color.Black)

        'draw the line
        graph.DrawLine(myPen, 10, 10, 200, 200)

        'free up resources
        myPen.Dispose()
        graph.Dispose()

    End Sub

    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'drawLine()
        'DrawEllipse()
        'DrawRectangle()
        'DrawString()
    End Sub

    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Me.Text = "x: " & e.X & " y: " & e.Y & " Mouse Button: " & e.Button.ToString

        'create graphics object
        Dim graph As Graphics
        graph = Me.CreateGraphics

        Static penColor As Color
        If penColor.IsEmpty = True Then
            penColor = Color.Black
        End If

        'constructor for pen object
        Dim myPen As New Pen(penColor)

        Static oldX As Integer
        Static oldY As Integer

        'File name location
        Dim fileName As String = "../../Draw.log"
        Dim fileNumber As Integer = FreeFile()


        If e.Button.ToString = "Left" Then
            'draw the line
            graph.DrawLine(myPen, oldX, oldY, e.X, e.Y)
            Try
                'Open file for append
                FileOpen(fileNumber, fileName, OpenMode.Append)
                'Append line segment data
                'start point old x , y end point current x , y
                WriteLine(fileNumber, oldX, oldY, e.X, e.Y)
                'maybe color later
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        ElseIf e.Button.ToString = "Right" Then
            graph.Clear(Color.LightGray)
            DrawRectangle(e.X, e.Y)
        ElseIf e.Button.ToString = "Middle" Then
            ColorDialog1.ShowDialog()
            penColor = ColorDialog1.Color
            myPen.Color = penColor
        End If

        'store position
        oldX = e.X
        oldY = e.Y

        'free up resources
        myPen.Dispose()
        graph.Dispose()
        'Close the file
        FileClose(fileNumber)

    End Sub

    Private Sub GraphicsForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.Text = e.Button.ToString
    End Sub

    Sub DrawEllipse()
        'instantiate graphics object
        Dim graph As Graphics = Me.CreateGraphics
        Dim myPen As New Pen(Color.FromArgb(255, 0, 0, 0))

        graph.DrawEllipse(myPen, New Rectangle(50, 50, 100, 100))

        myPen.Dispose()
        graph.Dispose()

    End Sub
    Sub DrawRectangle(positionX As Integer, positionY As Integer)
        'instantiate graphics object
        Dim graph As Graphics = Me.CreateGraphics
        Dim myPen As New Pen(Color.FromArgb(255, 0, 255, 0))

        graph.DrawRectangle(myPen, New Rectangle(positionX, positionY, 100, 100))

        myPen.Dispose()
        graph.Dispose()

    End Sub

    Public Sub DrawString()
        Dim formGraphics As System.Drawing.Graphics = Me.CreateGraphics()
        Dim drawString As String = "Sample Text"
        Dim drawFont As New System.Drawing.Font("Arial", 20)
        Dim drawBrush As New _
           System.Drawing.SolidBrush(System.Drawing.Color.Black)
        Dim x As Single = 150.0
        Dim y As Single = 50.0
        Dim drawFormat As New System.Drawing.StringFormat
        formGraphics.DrawString(drawString, drawFont, drawBrush,
            x, y, drawFormat)

        drawFont.Dispose()
        drawBrush.Dispose()
        formGraphics.Dispose()
    End Sub


    Sub DrawFromFile()
        'grab data from file
        'draw point

        'instantiate graphics object
        Dim graph As Graphics = Me.CreateGraphics
        Dim myPen As New Pen(Color.FromArgb(255, 0, 0, 0))

        'File name location
        Dim fileName As String = "../../Draw.log"
        Dim fileNumber As Integer = FreeFile()


        Try
            'Open file for append
            FileOpen(fileNumber, fileName, OpenMode.Input)

            'TODO fix
            ' graph.DrawLine(myPen, CSng(Input(fileNumber)), Input(fileNumber), Input(fileNumber), Input(fileNumber))

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        myPen.Dispose()
        graph.Dispose()
        'Close the file
        FileClose(fileNumber)

    End Sub

End Class
