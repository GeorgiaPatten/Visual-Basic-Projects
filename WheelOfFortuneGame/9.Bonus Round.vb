'Name-          Georgia Patten
'Date-          May 29, 2017
'Description-   This is the final round to try and win a lot of money!
'__________________________________________________________________________

Public Class frmBonusRound

    Dim intTimer As Integer = 30

    Private Sub btnHelpBonus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelpBonus.Click
        frmHelpBonus.Show()
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        If txtGuess.Text = "oceans twelve" Then
            MsgBox("That's right!")
            intMoney = intMoney + 100000
            tmrFinal.Stop()
            Me.Hide()
            frmCheck.Show()
        Else
            txtGuess.Text = "Thats incorrect keep guessing"
        End If
    End Sub

    Private Sub tmrFinal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFinal.Tick
        intTimer = intTimer - 1
        lblTimer.Text = intTimer
        If intTimer = 0 Then
            Me.Hide()
            frmCheck.Show()
        End If
    End Sub

    Private Sub txtGuess_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuess.TextChanged

    End Sub

    Private Sub lblTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTimer.Click

    End Sub
End Class