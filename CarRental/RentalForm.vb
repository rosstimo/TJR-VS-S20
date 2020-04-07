Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetAll()
        SummaryButton.Enabled = False
    End Sub

    Sub ResetAll()
        'Clear User input
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""
        MilesradioButton.Select()
        AAACheckbox.Checked = False
        SeniorCheckbox.Checked = False
        'Clear Output

    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetAll()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If AllChecksAreValid() Then
            'TODO proceed to calculations and updates
            'DailyCharge()
            'MileageCharge(201)'check and convert if kilo
            'Discount()
            'DislayOutput()
            'UpdateSummary()
            Console.WriteLine("Yep")
        Else
            'TODO alert user
            'MsgBox(UserMessages(False, "", False))
            Console.WriteLine("Nope")
        End If
    End Sub
    Function AllChecksAreValid() As Boolean
        Dim result As Boolean
        'TODO perform all validations return True if good
        'VerifyNoEmpty
        'VerifyOdometer()
        'VerifyNumberOfDays()

        result = False
        Return result
    End Function


    Function Discount(totalCharges As Decimal) As Decimal
        'Use the check boxes for AAA Member And Senior Citizen. 
        'AAA members receive a 5% discount
        'senior citizens get a 3% discount.
        'A person can receive both discounts. 
        'Do Not take the discount until the calculate button Is clicked.

        Const AAARATE = 0.05D
        Const SENIORRATE = 0.03D
        Dim totalDiscount As Decimal = 0

        If AAACheckbox.Checked = True Then
            totalDiscount += totalCharges * AAARATE
        End If

        If SeniorCheckbox.Checked = True Then
            totalDiscount += totalCharges * SENIORRATE
        End If

        Return totalDiscount

    End Function

    Sub verifyOdometer()
        Dim userMessage As String

        Try
            If CDec(BeginOdometerTextBox.Text) > CDec(EndOdometerTextBox.Text) Then
                'MsgBox("Yeah!")
                userMessage = "Beginning Odometer Must Be Smaller Than Ending Odometer"
            End If
        Catch ex As Exception
            userMessage = "Odometer entries must be numbers"
        End Try
        UserMessages(True, userMessage, False)
    End Sub

    Function MileageCharge(ByRef miles As Decimal) As Decimal
        'Mileage Charge
        'First 200 miles driven are always free. 
        'All miles between 201 And 500 inclusive are .12 cents per mile. 
        'miles greater than 500 are charged at .10 cents per mile.

        Dim mileCharge As Decimal

        Const RATE_REGULAR = 0.12D
        Const RATE_LOW = 0.1D
        Const RATE_FREE = 0D

        Select Case miles
            Case <= 200
                mileCharge = miles * RATE_FREE
            Case > 500
                mileCharge = 300 * RATE_REGULAR
                mileCharge += (miles - 500) * RATE_LOW
            Case Else
                mileCharge = (miles - 200) * RATE_REGULAR
        End Select

        Return mileCharge
    End Function


    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String

        If clearMessage = True Then
            formattedMessages = ""
        ElseIf addMessage = True Then
            formattedMessages &= message & vbNewLine
        End If

        Return formattedMessages

    End Function
    Function DoChecks() As Boolean
        'another way to do validation
        Dim result As Boolean
        Dim tempNum As Double
        Dim message As String = ""

        Try
            tempNum = CDbl(EndOdometerTextBox.Text)
            tempNum = CDbl(BeginOdometerTextBox.Text)
        Catch Except As Exception
            message &= "Odometer readings must be numbers" & vbNewLine
        End Try

        Try
            tempNum = CDbl(DaysTextBox.Text)
            If tempNum < 0 Or tempNum > 45 Then
                message &= "Number of days must be between 0 an 45" & vbNewLine
            End If
        Catch Except As Exception
            message &= "Number of days must be a number" & vbNewLine
        End Try

        'check for empties
        If ZipCodeTextBox.Text = "" Or StateTextBox.Text = "" Then
            message &= "Please complete all information fields" & vbNewLine
        End If

        If message <> "" Then
            'TODO Message box
            result = False
        Else
            result = True
        End If

        Return result
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'See https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.interaction.msgbox?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev16.query%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(Microsoft.VisualBasic.Interaction.MsgBox);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.7.2);k(DevLang-VB)%26rd%3Dtrue&view=netframework-4.8

        ' The following example requires that Option Infer be set to On.

        ' Define the message you want to see inside the message box.
        Dim msg = "Do you want to continue?"

        ' Display a simple message box.
        MsgBox(msg)

        ' Define a title for the message box.
        Dim title = "MsgBox Demonstration"

        ' Add the title to the display.
        MsgBox(msg, , title)

        ' Now define a style for the message box. In this example, the
        ' message box will have Yes and No buttons, the default will be
        ' the No button, and a Critical Message icon will be present.
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Question

        ' Display the message box and save the response, Yes or No.
        Dim response = MsgBox(msg, style, title)

        ' Take some action based on the response.
        If response = MsgBoxResult.Yes Then
            MsgBox("YES, continue!!", , title)
        Else
            MsgBox("NO, stop!!", , title)
        End If

        'This is another way to 
        Dim otherResult As DialogResult

        otherResult = MessageBox.Show("Are you sure??!!", "Title Here", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If otherResult = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
