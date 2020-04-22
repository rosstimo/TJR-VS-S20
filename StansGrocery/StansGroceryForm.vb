Public Class StansGroceryForm
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayListBox.Items.Add("Apples")
        DisplayListBox.Items.Add("Bananas")
        DisplayComboBox.Items.Add("Apples")
        DisplayComboBox.Items.Add("Bananas")


    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchTopMenuItem.Click, SearchToolStripMenuItem1.Click
        DisplayListBox.SelectedIndex = -1
        DisplayComboBox.SelectedIndex = -1
        SearchTextBox.Text = ""
        Tester()
    End Sub

    Private Sub DisplayComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayComboBox.SelectedIndexChanged
        If DisplayComboBox.SelectedIndex <> -1 Then
            DisplayListBox.SelectedIndex = -1
            SearchTextBox.Text = DisplayComboBox.SelectedItem.ToString
        End If

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        If DisplayListBox.SelectedIndex <> -1 Then
            DisplayComboBox.SelectedIndex = -1
            SearchTextBox.Text = DisplayListBox.SelectedItem.ToString
        End If
    End Sub

    Sub DataKeeper(ByRef tempData As String, ByVal Row As Integer, ByVal column As Integer, ByRef errorFlag As Boolean)
        Static dataArray(3, 1) As String

        dataArray(0, 0) = "Apples"
        dataArray(1, 0) = "Bananas"
        dataArray(2, 0) = "Tuna Fish"
        dataArray(3, 0) = "BBQ Chips"

        tempData = dataArray(Row, column)
    End Sub

    Sub Tester()
        Dim tempData As String
        Dim searchError As Boolean = False
        'get a item put in tempData
        'point to item 4 rows (0-3) and 2 colums (0-1)
        'did something go wrong?

        DataKeeper(tempData, 4, 0, searchError)

        Console.Write(tempData & " ")
        Console.WriteLine(searchError)

    End Sub



End Class
