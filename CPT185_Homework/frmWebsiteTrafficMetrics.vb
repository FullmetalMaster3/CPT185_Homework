' Program Name: Website Traffic Metrics
' Author:       Jovi Thomas
' Date:         3/23/19
' Purpose:      The Website Traffic Metrics website will enter the
'               the number of seconds spent in a website.  After a
'               total of 12 values is entered, it displays the average
'               weight loss for the time.
Public Class frmWebsiteTrafficMetrics

    Private Sub btnAnalytics_Click(sender As Object, e As EventArgs) Handles btnAnalytics.Click
        Dim strMetric As String
        Dim decMetric As Decimal
        Dim decAverageTime As Decimal
        Dim decTotalTime As Decimal = 0D

        Dim strInputMessage As String = "Enter the amount of time for Visitor #"
        Dim strInputHeading As String = "Visitor Time"
        Dim strNormalMessage As String = "Enter the amount of time for Visitor #"
        Dim strNonNumericError As String = "Error - Enter a number for Visitor #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight loss of team member #"

        'Declare and initialize loop variables

        Dim strCancelClicked As String = " "
        Dim intMaxNumberofEntries As Integer = 12
        Dim intNumberofEntries As Integer = 1

        strMetric = InputBox(strInputMessage & intNumberofEntries, strInputHeading)

        Do Until intNumberofEntries > intMaxNumberofEntries Or strMetric = strCancelClicked
            If IsNumeric(strMetric) Then
                decMetric = Convert.ToDecimal(strMetric)
                If decMetric > 0 Then
                    lstMetric.Items.Add(decMetric)
                    decTotalTime += decMetric
                    intNumberofEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberofEntries <= intMaxNumberofEntries Then
                strMetric = InputBox(strInputMessage & intNumberofEntries, strInputHeading, " ")

            End If
        Loop
        If intNumberofEntries > 1 Then
            lblTimeSpent.Visible = True
            decAverageTime = decTotalTime / (intNumberofEntries - 1)
            lblTimeSpent.Text = "Average Time Spent: " &
                decAverageTime.ToString("F") & " Seconds"
        Else
            MsgBox("No Analytics entered")
        End If

        btnAnalytics.Enabled = False
    End Sub
End Class