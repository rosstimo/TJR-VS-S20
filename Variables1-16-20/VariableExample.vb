Option Strict On

'Tim Rossiter
'RCET0265
'Spring 2020
'Variable Example

'Module names PascalCase
Module VariableExample

    'Method names PascalCase
    Sub Main()

        'name variables in camelCase
        Dim appleCount As Integer
        Dim fruitName As String

        fruitName = "apples" '& " Banana"
        'Console.WriteLine(fruitName)

        appleCount = 4
        Console.WriteLine("You have " & appleCount & " " & fruitName & "!")

        Console.ReadLine()
    End Sub

End Module
