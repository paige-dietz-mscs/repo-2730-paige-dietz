' Name:         Total Scores Project
' Purpose:      Displays the total of the scores entered by the user
' Programmer:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim decScore As Decimal
        Decimal.TryParse(txtScore.Text, decScore)
        decTotal = decTotal + decScore
        lblTotal.Text = Convert.ToString(decTotal)

        txtScore.Focus()
    End Sub
End Class
