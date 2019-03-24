'Program: Code Fest
'Author: Jovi Thomas
'Purpose: This application calculates and displays the total cost of attending a conference based on the number
'         of attendees.  Returning visitors will get a 15% discount.
Public Class frmCodeFest
    '15% discount - Used in multiple procedures
    Const _cdecDiscount As Decimal = 0.15

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intAttenNum As Integer
        Dim decTotalCost As Decimal
        Dim decFinalCost As Decimal

        If IsNumeric(txtAttendNum.Text) Then
            intAttenNum = Integer.Parse(txtAttendNum.Text)
        Else
            MsgBox("Please Enter a number")
            txtAttendNum.Clear()
            lblTotalCost.Text = ""
        End If
        If intAttenNum > 16 Then
            MsgBox("Sorry, No more than 16 attendees per company!")
            txtAttendNum.Clear()
            lblTotalCost.Text = ""
        End If

        Select Case txtAttendNum.Text
            Case 1
                decTotalCost = 795

            Case 2 To 4
                decTotalCost = intAttenNum * 645

            Case 5 To 7
                decTotalCost = intAttenNum * 475

            Case 8 To 16
                decTotalCost = intAttenNum * 385


        End Select

        lblTotalCost.Text = decTotalCost.ToString("C")

        If radYes.Checked Then
            decFinalCost = decTotalCost - (decTotalCost * _cdecDiscount)
            lblTotalCost.Text = decFinalCost.ToString("c")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAttendNum.Clear()
        lblTotalCost.Text = ""
        radYes.Checked = False
        radNo.Checked = True
        txtAttendNum.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class