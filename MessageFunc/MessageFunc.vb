Option Explicit On
Option Strict On
Option Compare Binary

Module MessageFunc

    Sub Main()
        TestUserMessages()
        Console.ReadLine()
    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String

        'your code here

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
            saveMessage = False
            clearMessage = False

            'Change Arguments
            If testCounter Mod 3 = 0 Then
                control = ""
                clearMessage = True
            ElseIf testCounter < 5 Or testCounter > 8 Then
                saveMessage = True
                control &= testString & vbNewLine
            End If

            'Run Test
            Console.WriteLine("Testing: " & vbNewLine _
                    & "Save message flag is:     " & saveMessage & vbNewLine _
                    & "Message Text is:         " & Chr(34) & testString & Chr(34) & vbNewLine _
                    & "Clear message flag is:    " & clearMessage)

            evaluate = UserMessages(saveMessage, testString, clearMessage)

            'Evaluate Test Display Test Results
            If evaluate = control Then
                Console.WriteLine("Test" & Str(testCounter) _
                        & "......PASS" & vbNewLine)
                successCounter += 1
            Else
                Console.WriteLine("Test" & Str(testCounter) _
                        & "......FAIL" & vbNewLine & vbNewLine _
                        & "Expected: " & vbNewLine & control & vbNewLine _
                        & "Actual: " & vbNewLine & evaluate & vbNewLine)
            End If

        Next

        'Display Summary
        Console.WriteLine(vbNewLine & seperator & seperator & vbNewLine _
                & Str(successCounter) & " of" & Str(testCounter - 1) _
                & " tests passed" & vbNewLine & vbNewLine & seperator & seperator)
    End Sub

End Module
