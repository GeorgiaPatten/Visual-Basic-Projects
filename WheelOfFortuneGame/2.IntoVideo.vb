'Name-              Georgia Patten
'Date-              April 19, 2017
'Description-       This form will show up after the opening form and play a video into the actual game.
'___________________________________________________________________________________________________________


Public Class frmVideo

    Private Sub frmVideo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
    End Sub

    Private Sub tmrVideo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrVideo.Tick
        tmrVideo.Stop()
        Me.Hide()
        frmGame.Show()
    End Sub

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class