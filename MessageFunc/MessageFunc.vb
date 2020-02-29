Module MessageFunc

    Sub Main()
        'MsgBox(UserMessages(True, "hello", False))
        'Console.WriteLine(UserMessages(True, "hello 1", False))
        'Console.WriteLine(UserMessages(True, "hello 2", False))
        'Console.WriteLine(UserMessages(True, "hello 3", False))
        'MsgBox(UserMessages(False, "", False))
        TestUserMessages()
        Console.ReadLine()
    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String

        formattedMessages &= message & vbNewLine

        Return formattedMessages

    End Function

    Sub TestUserMessages()
        Dim testString, control, evaluate As String
        Dim saveMessage, clearMessage As Boolean
        Dim testCounter, successCounter As Integer
        Dim seperator As String = StrDup(40, "*") & vbNewLine

        For testCounter = 1 To 12
            'Initialize
            testString = "Test " & Str(testCounter)
            control &= testString & vbNewLine
            saveMessage = True
            clearMessage = False

            'Change Arguments
            If testCounter Mod 3 = 0 Then
                control = ""
                clearMessage = True
            ElseIf testCounter > 5 And testCounter < 8 Then
                saveMessage = False
            End If

            'Run Test
            evaluate = UserMessages(saveMessage, testString, clearMessage)

            'Evaluate Test Display Test Results
            If evaluate = control Then
                Console.WriteLine("Test" & Str(testCounter) & " PASS")
                successCounter += 1
            Else
                Console.WriteLine(seperator & seperator _
                                & "Test" & Str(testCounter) & " FAIL" & vbNewLine _
                                & seperator _
                                & "Expected: " & vbNewLine & control & vbNewLine _
                                & seperator _
                                & "Actual: " & vbNewLine & evaluate)
            End If
        Next

        'Display Summary
        Console.WriteLine(seperator & seperator & vbNewLine _
                          & Str(successCounter) & " of " & Str(testCounter) _
                          & "tests passed." & vbNewLine & vbNewLine & seperator & seperator)

    End Sub



End Module
