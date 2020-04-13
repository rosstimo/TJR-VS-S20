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
        DrawString()
        DrawPicture()
        DrawLine()
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
        g.Dispose()
    End Sub
    Private Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawLine(pen, 20, 10, 300, 100)
        g.Dispose()
    End Sub

End Class
