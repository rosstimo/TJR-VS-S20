Public Class ListBoxForm
    Private Sub ListBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'DataListBox
        FirstNameTextBox.Text = "Elmer"
        LastNameTextBox.Text = "Fudd"
        Tester()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click, AddItemToolStripMenuItem.Click
        DataListBox.Items.Add(FirstNameTextBox.Text & " " & LastNameTextBox.Text)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearAllToolStripMenuItem.Click
        DataListBox.Items.Clear()
    End Sub

    Private Sub ExitProgram(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure? All Data will lost and we will take your birthday away.", vbOKCancel)
        If result = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub DataListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListBox.SelectedIndexChanged
        Dim index As Integer

        Me.Text = DataListBox.SelectedIndex.ToString
        index = InStr(DataListBox.SelectedItem.ToString, " ")
        FirstNameTextBox.Text = Trim(Strings.Left(DataListBox.SelectedItem.ToString, index))
        LastNameTextBox.Text = Trim(Strings.Mid(DataListBox.SelectedItem.ToString, index, Len(DataListBox.SelectedItem.ToString)))

    End Sub

    Sub Tester()
        Dim someNumber As Double
        someNumber = 10 * Math.Sin(Math.PI / 2)
        Console.WriteLine(Math.PI)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("List Box Program Beta Version 1.0.001" & vbNewLine _
               & "Tim Rossiter" & vbNewLine _
               & "Spring 2020" & vbNewLine _
               & "RCET0265" & vbNewLine _
               & "In association with Elmer Fudd LLC.")
    End Sub
End Class
