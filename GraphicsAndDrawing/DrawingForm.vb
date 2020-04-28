Public Class DrawingForm
    'Crate a rescale method
    'Create move origin method
    'save and redraw stuff
    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        Dim scaleFactor As Integer = 100
        Dim xScale As Decimal = scaleFactor
        Dim yScale As Decimal = scaleFactor

        Dim xPercent, yPercent As Decimal
        'Me.Text = e.X.ToString & " " & e.Y.ToString
        ReScale(xScale, yScale)
        'position in pixels / pixels per unit
        xPercent = e.X / xScale
        yPercent = e.Y / yScale
        Me.Text = xPercent.ToString() & " " & yPercent.ToString()
    End Sub

    Sub ReScale(ByRef xScale As Decimal, ByRef yScale As Decimal)

        xScale = DrawingPictureBox.Width / xScale
        yScale = DrawingPictureBox.Height / xScale

    End Sub


End Class
