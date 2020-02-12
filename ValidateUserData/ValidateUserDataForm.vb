Public Class ValidateUserDataForm
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        IsEmpty()


    End Sub

    Sub IsEmpty()
        Dim userMessage As String
        If TextBox2.Text = "" Then
            userMessage &= "please enter text in textbox 2" & vbNewLine
            TextBox2.Select()
        End If
        If TextBox1.Text = "" Then
            userMessage &= "please enter text in textbox 1" & vbNewLine
            TextBox1.Select()
        End If


        MsgBox(userMessage)
    End Sub

End Class
