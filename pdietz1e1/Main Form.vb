'Name: Richardson County Property Tax Project 
'Purpose: Calculates Property Tax
'Programmer: Paige Dietz, 9/15/17


Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAssessed.Text = String.Empty
        lblTax.Text = String.Empty
        ' Send the focus to the Assessed Value box
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblTax.Text = Val(txtAssessed.Text) * 0.015
        lblTax.Text = Format(lblTax.Text, "Currency")
    End Sub
End Class
