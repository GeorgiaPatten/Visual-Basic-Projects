'Name-              Georgia Patten
'Date-              May 1, 2017
'Description-       This form will begin after of the first game is over, and will have the second phrase on it.
'______________________________________________________________________________________________________________

Public Class frmGame2

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        frmHelp.Show()

    End Sub

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
        frmWheel.Show()
        tmrWheel.Start()
        intspin = randomNumber.Next(0, 16) * 100
        frmLetters2.lblSpun.Text = intspin
        If Val(frmLetters2.lblSpun.Text) = 0 Then
            MsgBox("You landed on a bankrupt space")
            intMoney = 0
            LetterReset()
            lblTotalAmountOfMoney.Text = intMoney
            Me.Hide()
            LetterReset2()
        End If
    End Sub

    Private Sub tmrWheel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWheel.Tick
        tmrWheel.Stop()
        frmWheel.Hide()
        Me.Show()
        frmLetters2.Show()
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFunD.Click

    End Sub

    Private Sub lblTotalAmountOfMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalAmountOfMoney.Click

    End Sub

    Private Sub frmGame2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblTotalAmountOfMoney.Text = intMoney
    End Sub

    Private Sub lblFunL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFunL.Click

    End Sub
End Class