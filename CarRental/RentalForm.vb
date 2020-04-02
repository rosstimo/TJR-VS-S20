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
        'ValidateAll()
        'DailyCharge()
        'Discount()
        Console.WriteLine(MileageCharge(201)) 'check and convert if kilo
        'DislayOutput()
        '


        'verifyOdometer()
        'MsgBox(UserMessages(False, "", False))

    End Sub

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


End Class
