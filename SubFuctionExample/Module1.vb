Option Strict On
Option Explicit On

Module Module1

    Sub Main()

        Dim myNumber As Integer
        myNumber = 7
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()

        MySub(myNumber)
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)

        myNumber = MyFunc(myNumber)
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)


        Console.ReadLine()
    End Sub

    Sub MySub(myNumber As Integer)
        'Dim myNumber As Integer
        'myNumber = myNumber + 2
        myNumber += 2
        Console.WriteLine("In Sub MySub")
        Console.WriteLine(myNumber)
        Console.ReadLine()
    End Sub

    Function MyFunc(myNumber As Integer) As Integer
        'Dim myNumber As Integer
        myNumber -= 3
        Console.WriteLine("In Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber
    End Function

End Module
