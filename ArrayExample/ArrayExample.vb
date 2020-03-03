Module ArrayExample

    Sub Main()
        Dim myArray(3) As Integer

        myArray(1) = 5

        myArray = {1, 2, 3, 4}

        myArray(0) = 5
        ReDim Preserve myArray(15)

        AnotherArrayExample()

        Console.ReadLine()
    End Sub

    Private Sub InstantiateArrays()
        ' Declare a single-dimension array of 5 numbers.
        Dim numbers(4) As Integer
        numbers = {1, 2, 4, 8, 16}

        ' Declare a single-dimension array and set its 4 values.
        Dim moreNumbers = New Integer() {1, 2, 4, 8}

        ' Change the size of an existing array to 16 elements and retain the current values.
        ReDim Preserve numbers(15)

        ' Redefine the size of an existing array and reset the values.
        ReDim numbers(15)

        ' Declare a 6 x 6 multidimensional array.
        Dim matrix(5, 5) As Double

        ' Declare a 4 x 3 multidimensional array and set array element values.
        Dim anotherMatrix = New Integer(3, 2) {{1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {4, 5, 6}}

        ' Declare a jagged array - These are used when there are varing element lengths. The first element could be month.
        ' The next element could be day. Not all months have the same number of days. These are also referred to as array of arrays.
        Dim sales()() As Double = New Double(11)() {}
    End Sub

    Sub AnotherArrayExample()
        'no element definition
        Dim infoArray() As String

        infoArray = Split("Hello,Goodbye,   Pizza,Hungry,Ice Cream", ",")

        For Each thingy As String In infoArray
            Console.WriteLine(thingy)
        Next

        For i = LBound(infoArray) To UBound(infoArray)
            Console.WriteLine("At " & Str(i) & " Value is: " & infoArray(i))
        Next



        Console.ReadLine()

    End Sub


End Module
