'Name-          Georgia Patten
'Date-          May 29, 2017
'Description-   This form is to help you and telkl you how to play that form.
'___________________________________________________________________________________________

Public Class frmHelpBonus

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        lblHelpBonus.Visible = True
        lblAbout.Visible = False
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        lblAbout.Visible = True
        lblHelpBonus.Visible = False
    End Sub
End Class