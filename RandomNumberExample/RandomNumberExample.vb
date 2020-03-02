Option Explicit On
Option Strict On
Option Compare Binary

Module RandomNumberExample

    Sub Main()
        ' Initialize the random-number generator.
        ' Generate random value between 1 and 6.
        'Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Dim aRandomInteger As Integer

        'Randomize()
        'For i = 1 To 10
        '    aRandomInteger = CInt((6 * Rnd()) + 1)
        '    Console.WriteLine(aRandomInteger)
        'Next



        'Randomize(System.DateTime.Now.Millisecond)
        'Console.WriteLine(Timer)
        'For i = 1 To 1000
        '    Console.WriteLine(getRandomInteger())
        'Next


        'test GetRandomInteger()
        Dim test As Integer
        For j = 1 To 1000
            test = GetRandomInteger(6, 3)
            If test > 6 Or test < 3 Then
                MsgBox("oops" & Str(test))
            End If
        Next

        'Console.WriteLine(GetRandomInteger(6, 3))

        Console.ReadLine()

    End Sub

    Function GetRandomInteger(maximum As Integer, minimum As Integer) As Integer
        Dim tempInteger As Integer
        Randomize()
        tempInteger = CInt(((maximum - minimum) * Rnd()) + minimum)
        Return tempInteger
    End Function




    Private Function getRandomOther() As Integer
        'https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netframework-4.8

        Dim randomNumber As New Random
        getRandomOther = randomNumber.Next(1, 10)

        'found to change about 2 times per millisecond
        'Dim newNum As Integer
        'Static oldNum
        'newNum = randomNumber.Next(1, 10)
        'If oldNum <> newNum Then
        '    Console.WriteLine(System.DateTime.Now.Millisecond)
        '    Console.WriteLine(newNum)
        '    oldNum = newNum
        'End If
        'getRandomOther = newNum

    End Function

    'from some old code of mine
    'returns a random number from 1 to 10
    Private Function getRandomIntegerOneToTen() As Integer
        Dim maxSingle As Single : maxSingle = 9
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
        getRandomIntegerOneToTen = Convert.ToInt32(tempSingle) 'return the number
    End Function



End Module
