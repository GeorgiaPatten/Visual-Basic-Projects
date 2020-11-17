'Name-              Georgia Patten
'Date-              April 7, 2017
'Description-       This is the first form, and you must put in your name and password.
'_________________________________________________________________________________________


Public Class frmOpening

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        If txtPassword.Text = "WoF2017!" Then
            frmGame.Show()
            Me.Hide()
            'frmVideo.tmrVideo.Start()
        Else
            lblPleaseTryAgain.Visible = True
            lblPleaseTryAgain.Text = "That is incorrect.Please type in the correct password!"
        End If
    End Sub

    Private Sub frmOpening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources._1d069951c6f1fa0f71724c42ef11_orig, AudioPlayMode.Background)
    End Sub
End Class
