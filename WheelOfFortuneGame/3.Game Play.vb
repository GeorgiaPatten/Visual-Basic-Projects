'Name-              Georgia Patten
'Date-              April 19, 2017
'Description-       This form will be at the beggining of the game, and will have the first phrase on it.
'______________________________________________________________________________________________________________

Public Class frmGame

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        frmHelp.Show()

    End Sub

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
        frmWheel.Show()
        tmrWheel.Start()
        intspin = randomNumber.Next(0, 16) * 100
        frmLetters.lblSpun.Text = intspin
        If intspin = 0 Then
            MsgBox("You landed on a bankrupt space")
            intMoney = 0
            LetterReset()
            lblTotalAmountOfMoney.Text = intMoney
            frmLetters.Hide()
            LetterReset()
        End If
    End Sub

    Private Sub tmrWheel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWheel.Tick
        tmrWheel.Stop()
        frmWheel.Hide()
        Me.Show()
        frmLetters.Show()
    End Sub

    Private Sub lblTotalAmountOfMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalAmountOfMoney.Click

    End Sub

    Private Sub frmGame_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources._1d069951c6f1fa0f71724c42ef11_orig, AudioPlayMode.Background)

    End Sub
End Class