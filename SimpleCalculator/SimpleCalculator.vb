'Tim Rossiter
'RCET0265
'Spring 2020
'Simple Calculator Example Program
'https://github.com/rosstimo/TJR-VS-S20.git

Option Explicit On
Option Strict On
Option Compare Text

'Refactor for a better user experience

Module SimpleCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userChoice As String
        Dim quitProgram As Boolean
        Dim promtUser As Boolean

        promtUser = True
        quitProgram = False

        Do While quitProgram = False

            'prompt user for two numbers


            Console.WriteLine("Please enter a number...")
            Do While promtUser = True
                Try
                    firstNumber = CInt(Console.ReadLine())
                    promtUser = False
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole number")
                    promtUser = True
                End Try
            Loop

            Console.WriteLine("Please enter a 2nd number...")
            Try
                secondNumber = CInt(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Please enter a whole number")
            End Try

            'prompt user for sum or product choice

            'perform proper operation
            Console.WriteLine("Please Choose an Option")
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Multiply")
            userChoice = Console.ReadLine()

            'Determine the user's choice
            If userChoice = "1" Then

                'Try
                Console.WriteLine(firstNumber + secondNumber)
                'Catch ex As InvalidCastException
                '    Console.WriteLine("Please enter a whole number")
                'Catch ex As Exception
                '    Console.WriteLine("You broke it")
                'End Try

            ElseIf userChoice = "2" Then

                'Try
                Console.WriteLine(firstNumber * secondNumber)
                'Catch ex As InvalidCastException
                '    Console.WriteLine("Please enter a whole number")
                'Catch ex As Exception
                '    Console.WriteLine("You broke it")
                'End Try

            Else

                Console.WriteLine("Invalid Selection")

            End If

            'display result prompt to end
            Console.WriteLine("Have a nice day...")
            Console.WriteLine("Press Enter To Run Again. Enter Q to quit.")

            If Console.ReadLine() = "q" Then
                quitProgram = True
            Else
                quitProgram = False
            End If

            Console.Clear()
        Loop
    End Sub

End Module
