﻿'Name: Photo Project
'Purpose: Displays the gross pay, FWT, FICA, state income tax, and net pay
'Programmer: Paige Dietz 9/16/17

Option Strict On

Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate gross, witholdings, and net pay
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPayRate.Text), "fixed")
        lblFWT.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        lblFICA.Text = Format(Val(lblGross.Text) * 0.08, "fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        lblNet.Text = Format(Val(lblGross.Text) - Val(lblFWT.Text) - Val(lblFICA.Text) - Val(lblState.Text), "fixed")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = String.Empty
        txtHours.Text = String.Empty
        txtPayRate.Text = String.Empty
        lblGross.Text = String.Empty
        lblFWT.Text = String.Empty
        lblFICA.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty
        'Send the focus to the name box
        txtName.Focus()
    End Sub
End Class
