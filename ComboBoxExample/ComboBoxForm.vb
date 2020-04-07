Public Class ComboBoxForm
    'up to 10 users Name, Age
    Dim userInfo(2, 1) As String 'Temp 3 users
    Dim userIndex As Integer = 0
    Const NAMEFIELDINDEX = 0I
    Const AGEFIELDINDEX = 1I
    'IndexOutOfRangeException
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        'Load Name into ComboBox
        MainComboBox.Items.Add(NameTextBox.Text)

        'Load Name and age into an array
        userIndex = CInt(MainComboBox.Items.Count) - 1

        'Add info to Array
        'Need to catch IndexOutOfRangeException when array is full
        Try
            userInfo(userIndex, NAMEFIELDINDEX) = NameTextBox.Text
            userInfo(userIndex, AGEFIELDINDEX) = AgeTextBox.Text
        Catch tooManyUsers As IndexOutOfRangeException
            'deal with problem
            MsgBox("Only 10 Users Please")
        End Try

        'AgeTextBox.Text = MainComboBox.Items.Count
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
    End Sub

    Private Sub MainComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainComboBox.SelectedIndexChanged
        Me.Text = MainComboBox.SelectedIndex
        userIndex = MainComboBox.SelectedIndex

        NameTextBox.Text = userInfo(userIndex, NAMEFIELDINDEX)
        AgeTextBox.Text = userInfo(userIndex, AGEFIELDINDEX)

    End Sub

    Private Sub ComboBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MainComboBox.Items.Add(NameTextBox.Text)
        'age
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dim tempItem As String
        tempItem = MainComboBox.SelectedItem.ToString

        'TODO align array with combo box

        For Each item In userInfo
            Console.WriteLine(item)
        Next

        'Console.WriteLine(MainComboBox.SelectedItem.ToString)

        'MainComboBox.Items.Remove(MainComboBox.SelectedItem)

    End Sub

End Class
