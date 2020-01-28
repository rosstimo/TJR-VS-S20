Option Explicit On
Option Strict On
Option Compare Binary
Module Module1

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        firstNumber = 5
        secondNumber = 7

        result = 0 'firstNumber + secondNumber

        For i = 0 To 25 Step 2
            result = result + 1
            Console.WriteLine(i)
        Next

        Console.WriteLine(result)
        Console.ReadLine()


    End Sub

End Module
