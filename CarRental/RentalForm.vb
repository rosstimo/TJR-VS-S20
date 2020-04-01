Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        MileageCharge(220)

        'verifyOdometer()
        'MsgBox(UserMessages(False, "", False))

    End Sub

    Sub verifyOdometer()
        Dim userMessage As String

        Try
            If CDec(BeginOdometerTextBox.Text) > CDec(EndOdometerTextBox.Text) Then
                'MsgBox("Yeah!")
                userMessage = "Begining Odometer Must Be Smaller Than Ending Odometer"
            End If
        Catch ex As Exception
            userMessage = "Odometer entries must be numbers"
        End Try
        UserMessages(True, userMessage, False)
    End Sub

    Function MileageCharge(ByRef miles As Decimal) As Decimal
        Dim mileCharge As Decimal

        Const RATE_REGULAR = 0.12D
        Const RATE_LOW = 0.1D
        Const RATE_FREE = 0D

        'Mileage Charge
        'First 200 miles driven are always free. 
        'All miles between 201 And 500 inclusive are .12 cents per mile. 
        'miles greater than 500 are charged at .10 cents per mile.

        Select Case miles
            Case <= 200
                mileCharge = miles * RATE_FREE
            Case > 500
                mileCharge = miles * RATE_LOW
            Case Else
                mileCharge = miles * RATE_REGULAR
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
