'Name: Average Project
'Purpose: Displays the average of 3 test scores
'Programmer: Paige Dietz 9/16/2017

Option Strict On

Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblAverage.Text = Format((Val(txtTest1.Text) + Val(txtTest2.Text) + Val(txtTest3.Text)) / 3, "fixed")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTest1.Text = String.Empty
        txtTest2.Text = String.Empty
        txtTest3.Text = String.Empty
        lblAverage.Text = String.Empty
        'Send the focus to Test 1 box
        txtTest1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
