


Public Class FormControlsForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim displayText As String

        displayText = NameTextBox.Text & vbNewLine & StreetTextBox.Text & vbNewLine & StateTextBox.Text

        DisplayLabel.Text = displayText

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        If CheckBox1.Checked = True Then
            DisplayLabel.Text = NameTextBox.Text
        End If

        If CheckBox2.Checked = True Then
            MsgBox("Hello, Your Data is No Good!!!")
        End If

        If CheckBox3.Checked = True Then
            UserPictureBox.Image = My.Resources.kitty12
        Else
            UserPictureBox.Image = Nothing
        End If


    End Sub

    Private Sub FormControlsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetAllControls()
    End Sub

    Sub ResetAllControls()

        'clear all text boxes
        NameTextBox.text = ""
        StreetTextBox.text = ""
        StateTextBox.text = ""

        'start up selections
        RadioButton1.Checked = True
        RadioButton4.Checked = True

        'Disabled by default
        GoButton.Enabled = False
        UpdateButton.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False

    End Sub

    Private Sub AnyTextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged, StateTextBox.TextChanged, StreetTextBox.TextChanged
        EvaluateTextBoxes()
    End Sub

    Sub EvaluateTextBoxes()

        If NameTextBox.Text <> "" And StreetTextBox.Text <> "" And StateTextBox.Text <> "" Then
            'enable
            GoButton.Enabled = True
            UpdateButton.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
        Else
            GoButton.Enabled = False
            UpdateButton.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
        End If

    End Sub

    Private Sub AgeTextBox_validate(sender As Object, e As EventArgs) Handles AgeTextBox.Leave
        Dim tempNumber As Integer


        Try
            tempNumber = CInt(AgeTextBox.Text)
            If tempNumber > 15 And tempNumber < 27 Then
                MsgBox("Good Job")
            Else
                MsgBox("Sorry try the kiddy rides")
            End If

        Catch ex As Exception
            MsgBox("Please enter a valid age.")
            AgeTextBox.Text = ""
        End Try


    End Sub


End Class
