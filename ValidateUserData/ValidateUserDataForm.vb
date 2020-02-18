Public Class ValidateUserDataForm
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Dim userMessage As String

        'IsEmpty()
        If IsStringEmpty(TextBox3.Text) = True Then
            userMessage &= "please enter text in textbox 3" & vbNewLine
            TextBox3.Select()
        End If

        If IsStringEmpty(TextBox2.Text) = True Then
            userMessage &= "please enter text in textbox 2" & vbNewLine
            TextBox2.Select()
        End If

        If IsStringEmpty(TextBox1.Text) = True Then
            userMessage &= "please enter text in textbox 1" & vbNewLine
            TextBox1.Select()
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If

    End Sub

    Sub IsEmpty()
        'Check each if empty and alert user
        Dim userMessage As String

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

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If

        'Another way to check a condition
        'Select Case ""
        '    Case TextBox3.Text
        '        userMessage &= "please enter text in textbox 3" & vbNewLine
        '    Case TextBox2.Text
        '        userMessage &= "please enter text in textbox 2" & vbNewLine
        '    Case TextBox1.Text
        '        userMessage &= "please enter text in textbox 1" & vbNewLine
        '    Case Else

        'End Select

    End Sub

    Function IsStringEmpty(stringToTest As String) As Boolean
        Dim status As Boolean
        If stringToTest = "" Then
            status = True
        Else
            status = False
        End If
        Return status
    End Function

    Function RunningTotal(currentValue As Integer) As Integer
        Static total As Integer

        total += currentValue

        Return total
    End Function

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        Dim tempNumber As Integer
        Const VALUE As Integer = 5
        'Const VALUE = 5I

        For i = 1 To 10
            tempNumber = RunningTotal(VALUE)
        Next

        Console.WriteLine(tempNumber)
    End Sub
End Class
