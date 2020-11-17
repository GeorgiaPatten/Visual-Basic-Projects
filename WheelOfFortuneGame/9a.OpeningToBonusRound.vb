'Name-          Georgia Patten
'Date-          May 29, 2017
'Description-   Just a short Gif to add visuals to my game!
'_____________________________________________________________________________________________


Public Class frmVideoBonus

    Private Sub tmrBonus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBonus.Tick
        tmrBonus.Stop()
        Me.Close()
        frmLettersFinal.Show()
    End Sub

    Private Sub imgFinalSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgFinalSpin.Click

    End Sub
End Class