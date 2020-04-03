Public Class ComboBoxForm
    'up to 10 users Name, Age
    Dim userInfo(9, 1) As String
    Dim userIndex As Integer = 0
    Const NAMEFIELDINDEX = 0I
    Const AGEFIELDINDEX = 1I

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        'Load Name into ComboBox
        MainComboBox.Items.Add(NameTextBox.Text)

        'Load Name and age into an array
        userIndex = CInt(MainComboBox.Items.Count) - 1
        userInfo(userIndex, NAMEFIELDINDEX) = NameTextBox.Text
        userInfo(userIndex, AGEFIELDINDEX) = AgeTextBox.Text

        AgeTextBox.Text = MainComboBox.Items.Count
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
    End Sub

    Private Sub MainComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainComboBox.SelectedIndexChanged
        Me.Text = MainComboBox.SelectedIndex
        userIndex = MainComboBox.SelectedIndex

        NameTextBox.Text = userInfo(userIndex, NAMEFIELDINDEX)
        AgeTextBox.Text = userInfo(userIndex, AGEFIELDINDEX)
    End Sub
End Class
