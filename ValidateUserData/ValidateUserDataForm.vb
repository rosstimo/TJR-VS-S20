Public Class ValidateUserDataForm
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        IsEmpty()


    End Sub

    Sub IsEmpty()
        'Check each if empty and alert user
        Dim userMessage As String

        'Another way to check a condition
        Select Case ""
            Case TextBox3.Text
                userMessage &= "please enter text in textbox 3" & vbNewLine
            Case TextBox2.Text
                userMessage &= "please enter text in textbox 2" & vbNewLine
            Case TextBox1.Text
                userMessage &= "please enter text in textbox 1" & vbNewLine
            Case Else

        End Select

        If TextBox3.Text = "" Then
            userMessage &= "please enter text in textbox 3" & vbNewLine
            TextBox3.Select()
        End If

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
