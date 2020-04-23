Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AboutLabel.Text = "Stan's Grocery App" & vbNewLine _
                        & "Version Alpha 0.001" & vbNewLine _
                        & "RCET0265" & vbNewLine _
                        & "by Tim Rossiter" & vbNewLine _
                        & "Copyright 2020" & vbNewLine
    End Sub

    Private Sub AboutForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StansGroceryForm.Show()
    End Sub
End Class