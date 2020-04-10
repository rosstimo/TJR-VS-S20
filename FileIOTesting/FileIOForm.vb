Public Class FileIOForm

    Dim filename As String = "C:\Users\timro\Downloads\jnk.txt"
    'Store data in file from text boxes
    Private Sub filCreateFile()

        FileOpen(1, filename, OpenMode.Append) 'Open the file for append
        WriteLine(1, "text 1", "text 2", Now)
        FileClose(1)
    End Sub

    Sub ReadFile() Handles Me.Click
        Dim tempString As String

        FileOpen(1, filename, OpenMode.Input)

        Input(1, tempString)
        Console.WriteLine(tempString)

        Input(1, tempString)
        Console.WriteLine(tempString)

        Input(1, tempString)
        Console.WriteLine(tempString)

        FileClose(1)
    End Sub

End Class
