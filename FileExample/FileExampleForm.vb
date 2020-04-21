Public Class FileExampleForm
    'specific to this computer
    'Private fileName As String = "C:\Users\timro\Downloads\jnk.txt"

    'relative to the .exe same folder
    'Private fileName As String = "RelativePath.txt"

    'relative to the .exe ..\..\ two folders up from .exe
    'Private fileName As String = "..\..\TwoLevelUpRelativePath.txt"

    'best option for .NET. embeds within program files. handles paths for you.
    Private fileName As String = My.Resources.CrazyJunk

    'C:\Users\timro\OneDrive\Sync\github\TJR-VS-S20\FileExample\bin\Debug\RelativePath.txt
    'C:\Users\timro\OneDrive\Sync\github\TJR-VS-S20\FileExample\bin\Release\RelativePath.txt
    'C:\Users\timro\OneDrive\Sync\github\TJR-VS-S20\FileExample\RelativePath.txt

    Sub ChooseFile()
        OpenFileDialog1.ShowDialog()
        fileName = OpenFileDialog1.FileName()
    End Sub

    Sub SaveFile()
        SaveFileDialog1.DefaultExt = ".txt"
        SaveFileDialog1.Filter = "Show Me A Movie|*.mp4|Text files|*.txt|All files|*.*"
        SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        SaveFileDialog1.ShowDialog()


        FileCopy(fileName, SaveFileDialog1.FileName)
    End Sub

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
        'ReadFileToArray()
        ReadFileItemsToArray()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ChooseFile()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFile()
    End Sub

    Sub ReadFileItemsToArray()
        'Dim currentName As String
        'Dim fileDataString As String
        Dim userPointer As Integer = 0
        Dim userInfo(9, 1) As String 'Name and age

        Dim userFile As String = "../../UserData.txt"


        Try
            FileOpen(1, userFile, OpenMode.Input)
            Do While Not EOF(1)

                Input(1, userInfo(userPointer, 0))
                Input(1, userInfo(userPointer, 1))
                userPointer += 1
            Loop
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            FileClose(1)
        End Try


        'need to handle exceptions here
        For i = LBound(userInfo) To UBound(userInfo)
            MsgBox(userInfo(i, 0) & " is " & userInfo(i, 1) & " years old.")
            If userInfo(i, 0) = "Frank" Then
                MsgBox("Happy B-Day!!")
            End If
            If CInt(userInfo(i, 1)) < 18 Then
                MsgBox("You are too young to ride this ride..")
            End If
            'userInfo(i, 0)
        Next



        Console.WriteLine()
    End Sub




End Class
