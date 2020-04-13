Public Class FileExampleForm

    Dim fileName As String = "C:\Users\timro\Downloads\jnk.txt"

    Sub WriteToFile()

        'FileOpen(1, "MyTestFile.txt", OpenMode.Output)
        FileOpen(1, fileName, OpenMode.Output)
        WriteLine(1, "don't overwrite your file")
        FileClose(1)

    End Sub

    Sub AppendToFile()
        FileOpen(1, fileName, OpenMode.Append)
        WriteLine(1, "File was opened for append", "Some other info", Now, 255)
        FileClose(1)
    End Sub

    Sub ReadAFile()
        Dim tempString As String
        FileOpen(1, fileName, OpenMode.Input)

        Input(1, tempString)
        Console.WriteLine(tempString)

        Input(1, tempString)
        Console.WriteLine(tempString)

        FileClose(1)
    End Sub

    Sub ReadEntireFile()
        Dim tempString As String

        Try
            FileOpen(1, fileName, OpenMode.Input)
            Do While Not EOF(1)
                Input(1, tempString)
                Console.WriteLine(tempString)
            Loop
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            FileClose(1)
        End Try


    End Sub

    Sub ReadFileToArray()
        Dim currentFileRecord As String
        Dim fileDataString As String
        Dim fileDataArray() As String

        Try
            FileOpen(1, fileName, OpenMode.Input)
            Do While Not EOF(1)
                Input(1, currentFileRecord)
                fileDataString &= currentFileRecord & "$$"
            Loop
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            FileClose(1)
        End Try

        fileDataArray = Split(fileDataString, "$$")

        Console.WriteLine()
    End Sub


    Private Sub FileExampleForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'WriteToFile()
        'AppendToFile()
        'ReadAFile()
        'ReadEntireFile()
        ReadFileToArray()
    End Sub





End Class
