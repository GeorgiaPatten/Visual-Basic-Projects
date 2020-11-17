'Name-          Georgia Patten
'Date-          May 25, 2017
'Description-   This is before the bonus round where you pick three constenants and one vowel.
'______________________________________________________________________________________________

Public Class frmLettersFinal
    Dim intNumber As Integer
    Dim intLetter As Integer

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnB.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            frmBonusRound.lblFinalC.Text = "C"
            btnC.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnD.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnF.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnG.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnH.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnH.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJ.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnJ.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnK.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnK.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            frmBonusRound.lblFinalL.Text = "L"
            btnL.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnM.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            frmBonusRound.lblFinalN.Text = "N"
            btnN.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnP.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnQ.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnR.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnR.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnS.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnT.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            frmBonusRound.lblFinalV.Text = "V"
            btnV.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnW.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            frmBonusRound.lblFinalW.Text = "W"
            btnW.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnX.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZ.Click
        intNumber = intNumber + 1
        If intNumber < 3 Then
            btnZ.Enabled = False
        ElseIf intNumber = 3 Then
            LetterHide()
            LetterStart()
        End If
    End Sub

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click


        btnA.Enabled = False
        Me.Hide()
        frmBonusRound.Show()
        frmBonusRound.tmrFinal.Start()
        frmBonusRound.tmrFinal.Start()
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click

        frmBonusRound.lblFinalE.Text = "E"
        frmBonusRound.lblFinalE2.Text = "E"
        frmBonusRound.lblFinalE3.Text = "E"
        btnE.Enabled = False
        Me.Hide()
        frmBonusRound.Show()
        frmBonusRound.tmrFinal.Start()
    End Sub

    Private Sub btnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnI.Click


        btnI.Enabled = False
        Me.Hide()
        frmBonusRound.Show()
        frmBonusRound.tmrFinal.Start()
    End Sub

    Private Sub btnO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnO.Click


        btnO.Enabled = False
        frmBonusRound.lblFinalO.Text = "O"

            Me.Hide()
            frmBonusRound.Show()
        frmBonusRound.tmrFinal.Start()
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click


        btnU.Enabled = False

        Me.Hide()
        frmBonusRound.Show()
        frmBonusRound.tmrFinal.Start()
    End Sub

    Private Sub btnY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnY.Click


        btnY.Enabled = False

        Me.Hide()
        frmBonusRound.Show()
        frmBonusRound.tmrFinal.Start()
    End Sub
End Class