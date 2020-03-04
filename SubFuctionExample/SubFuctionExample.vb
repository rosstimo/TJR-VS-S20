Option Strict On
Option Explicit On

Module SubFuctionExample

    Sub Main()

        'Dim myNumber As Integer
        'myNumber = 7
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()


        Dim someNumberInMain As Integer
        someNumberInMain = 17
        MySub(someNumberInMain)

        Console.WriteLine("In Sub Main")
        Console.WriteLine(someNumberInMain)

        'myNumber = MyFunc(myNumber)
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)

        'doMath(7, 5, "Multiply")

        'For i = 1 To 80 Step 20
        'ShowPattern(40, "Tim")
        'Next
        'playSound()
        Console.ReadLine()
    End Sub

    'ByVal Creates a copy -- Safe
    'ByRef Points at the callers actual variable -- Less Safe

    'Sub MySub(ByRef myNumberInMySub As Integer)
    Sub MySub(ByVal myNumberInMySub As Integer)

        'Dim myNumber As Integer
        'myNumber = myNumber + 2
        myNumberInMySub += 2
        Console.WriteLine("In Sub MySub")
        Console.WriteLine(myNumberInMySub)
        'Console.ReadLine()
    End Sub

    Function MyFunc(myNumber As Integer) As Integer
        'Dim myNumber As Integer
        myNumber -= 3
        Console.WriteLine("In Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber
    End Function

    Sub DoMath(firstNumber As Integer, secondNumber As Integer, operatorChoice As String)
        Dim result As Double

        If operatorChoice = "Add" Then
            result = firstNumber + secondNumber
        ElseIf operatorChoice = "Subtract" Then
            result = firstNumber - secondNumber
        ElseIf operatorChoice = "Multiply" Then
            result = firstNumber * secondNumber
        ElseIf operatorChoice = "Divide" Then
            result = firstNumber / secondNumber
        End If

        Console.WriteLine(result)
    End Sub

    Sub ShowPattern(length As Integer, character As String)
        'Dim character As String
        Dim pattern As String
        Console.WriteLine(Len(character))
        'character = "*"
        pattern = ""
        For index = 1 To length Step 1
            pattern &= character
            Console.WriteLine(pattern)
        Next

        For index = length - 1 To 1 Step -1
            pattern = Left(pattern, index * Len(character))
            Console.WriteLine(pattern)
        Next

    End Sub

    Sub playSound()
        Console.Beep(392, 500) 'G4'
        Console.Beep(440, 500) 'A4'
        Console.Beep(349, 750) 'F4'
        Console.Beep(196, 750) 'G3'
        Console.Beep(262, 900) 'C4'
        Console.BackgroundColor = ConsoleColor.Blue
        Console.WriteLine("Oh no, you broke it!")
    End Sub

End Module
