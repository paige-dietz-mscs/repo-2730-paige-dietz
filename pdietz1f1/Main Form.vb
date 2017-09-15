' Name:          Cranston Berries Project
' Purpose:       Calculates Projected Sales
' Programmer:    Paige Dietz 9/15/17

Option Strict On

Public Class frmMain
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblProjStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        lblProjBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        lblProjRasp.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRasp.Text), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtProjIncrease.Text = String.Empty
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRasp.Text = String.Empty
    End Sub
End Class
