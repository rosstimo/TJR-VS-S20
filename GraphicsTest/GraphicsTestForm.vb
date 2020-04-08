Public Class GraphicsTestForm


    Public Sub DrawString()
        Dim formGraphics As System.Drawing.Graphics = Me.CreateGraphics()
        Dim drawString As String = "Sample Text"
        Dim drawFont As New System.Drawing.Font("Arial", 16)
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

    Private Sub GraphicsTestForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'DrawString()
        'DrawPicture()
        'DrawLine()
        'DrawEllipse()
    End Sub

    Private Sub DrawPicture()
        Dim g As Graphics = Me.CreateGraphics
        ' Create image.
        Dim newImage As Image = Image.FromFile("C:\Users\rosstimo\OneDrive\Cloud\Pictures\profile\profile.jpg")
        ' Create coordinates for upper-left corner of image.
        Dim x As Single = 200.0F
        Dim y As Single = 100.0F
        Dim width As Single = 450.0F
        Dim height As Single = 200.0F

        ' Create rectangle for source image.
        Dim srcRect As New RectangleF(50.0F, 50.0F, 150.0F, 150.0F)
        Dim units As GraphicsUnit = GraphicsUnit.Pixel
        g.DrawImage(newImage, x, y, width, height)
        newImage.Dispose()
        g.Dispose()
    End Sub
    Private Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawLine(pen, 20, 10, 300, 100)
        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub DrawEllipse()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawEllipse(pen, New Rectangle(0, 0, 200, 300))
        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawRectangle(pen, New Rectangle(0, 0, 200, 300))
        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub GraphicsTestForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim g As Graphics = Me.CreateGraphics
        Dim newcolor As Color = Color.Black
        Dim pen As New Pen(newcolor, 3)

        Static x1, y1 As Single

        If x1 = 0 And y1 = 0 Then
            x1 = e.X
            y1 = e.Y
            newcolor = Color.Cyan
        End If

        If e.Button.ToString = "Left" Then
            g.DrawLine(pen, x1, y1, e.X, e.Y)
        End If

        x1 = e.X : y1 = e.Y
        Me.Text = "x : " & e.X & " y : " & e.Y & " Button State: " & e.Button.ToString

        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub GraphicsTestForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Text = Me.Height & Me.Width
    End Sub

End Class
