Module SimpleCalculator

    Sub Main()
        Dim firstNumber As String
        Dim secondNumber As String
        Dim userChoice As String

        'prompt user for two numbers
        Console.WriteLine("Please enter a number...")
        firstNumber = Console.ReadLine()
        Console.WriteLine("Please enter a 2nd number...")
        secondNumber = Console.ReadLine()

        'prompt user for sum or product choice

        'perform proper operation
        Console.WriteLine("Please Choose an Option")
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Multiply")
        userChoice = Console.ReadLine()

        'Determine the user's choice
        If userChoice = "1" Then
            Try
                Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
            Catch ex As Exception
                Console.WriteLine("Please enter a whole number")
                'Console.WriteLine(ex.Message.ToString)
            End Try
        ElseIf userChoice = "2" Then
            Try
                Console.WriteLine(CInt(firstNumber) * CInt(secondNumber))
            Catch ex As Exception
                Console.WriteLine("Please enter a whole number")
            End Try
        Else
            Console.WriteLine("Invalid Selection")
        End If

        Console.WriteLine("Have a nice day...")
        'display result prompt to end
        Console.ReadLine()

    End Sub

End Module
