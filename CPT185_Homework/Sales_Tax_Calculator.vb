'Program Sales Tax Calculator
'Author: Jovi Thomas
'Date: 2/16/19
'Purpose This application will compute the sales tax and final cost of a purchased item.

Option Strict On

Public Class Sales_Tax_Calculator
    'Tax Rate used in multiple procedures'
    Const _cdecTaxRate As Decimal = 8.75D

    Private Sub lblStore_Click(sender As Object, e As EventArgs) Handles lblStore.Click

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub lblFinalCostLabel_Click(sender As Object, e As EventArgs) Handles lblFinalCostLabel.Click

    End Sub

    Private Sub lblTax_Click(sender As Object, e As EventArgs) Handles lblTax.Click

    End Sub

    Private Sub Sales_Tax_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim decTax As Decimal
        Dim strStartCost As String
        Dim decStartCost As Decimal

        strStartCost = txtPrice.Text
        decStartCost = Convert.ToDecimal(strStartCost)

        decTax = decStartCost * (_cdecTaxRate / 100)

        Dim decFinalCost As Decimal
        decFinalCost = decStartCost + decTax

        lblOriginalCost.Text = decStartCost.ToString("C")
        lblTaxCost.Text = decTax.ToString("c")
        lblFinalCost.Text = decFinalCost.ToString("c")



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItemName.Clear()
        txtPrice.Clear()
        lblOriginalCost.Text = ""
        lblTaxCost.Text = ""
        lblFinalCost.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class