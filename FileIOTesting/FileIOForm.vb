
'<Remarks>
'The FileOpen() functions allows for various file read/write options.

'FileOpen(<FileNumber>, <FileName>, <OpenMode>)

'FileNumber:Int32
'Required. Any valid file number. Use the FreeFile function to obtain the next
'available file number.

'FileName: String
'Required.A String expression that specifies a file name - may include
'directory Or folder, And drive.

'Mode: OpenMode
'Required.Enumeration specifying the file mode: Append, Binary, Input,
'Output, Or Random.For more information, see OpenMode.

'FreeFile() returns the next available file number. It is used to refer to
'the to the file by the FileOpen function. 

'File IO can Throw a variety Of exceptions so Try/Catch Is used. 
'Open file For input Or read mode and assigned a file number. 
'Loop through all the records/lines until end of file or EOF().

'Input reads Each record from File into currentRecord. 

'Always close the file To avoid file In use IOException. FileClose(<FileNumber>)

'Note: large files can be cumbersome When the whole thing Is read into RAM. 
'Options? Check target file size attribute prior to read all and/or read one
'line at a time. 

'Dim MySize As Long
'' Returns file length (bytes).
'MySize = FileLen("TESTFILE")

'length = LOF(1)   ' Get length of file.


'</Remarks>

Public Class FileIOForm

    Dim filename As String = "C:\Users\timro\Downloads\jnk.txt"

    'Store data in file from text boxes
    Private Sub OutputFile()
        FileOpen(1, filename, OpenMode.Output) 'Open the file for append
        WriteLine(1, "File was opened for output", "text 2", Now)
        FileClose(1)
    End Sub

    Private Sub AppendFile()

        FileOpen(1, filename, OpenMode.Append) 'Open the file for append
        WriteLine(1, "File was opened for append", "text 2", Now)
        FileClose(1)
    End Sub
    Private Sub InputFile()
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

    '<Remarks>
    'ReadFile() allows user to choose text file then reads file into TempArray
    '</Remarks>
    Private Sub ReadWholeFile()
        Dim currentRecord As String
        Dim fileData As String
        Dim fileNumber As Integer = FreeFile()
        Dim fileDataArray() As String

        Try
            FileOpen(fileNumber, filename, OpenMode.Input)
            Do While Not EOF(fileNumber)
                Input(fileNumber, currentRecord)
                fileData &= currentRecord
            Loop
        Catch ex As Exception
            'TODO: user select file if it doesn't exist
            Console.WriteLine(ex.Message)
        Finally
            FileClose(fileNumber)
        End Try

        fileDataArray = Split(fileData, "vbNewline") ' "," or "vbNewline" or "$$"

    End Sub


End Class
