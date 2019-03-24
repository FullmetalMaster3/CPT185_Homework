Public Class frmTechFair
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        lblDate.Visible = True
        lblLocation.Visible = True
        lblRoom.Visible = True
        btnDetails.Enabled = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
