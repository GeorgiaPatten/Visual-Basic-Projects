'Name-              Georgia Patten
'Date-              April 22, 2017
'Description-       This part of my project is where you can pick if you would like to guess a vowel, constanant or guess the phrase.
'________________________________________________________________________________________________________________________________________

Public Class frmLetters

    Dim intbtnVowels As Integer

    Private Sub frmLetters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 703
        y = Screen.PrimaryScreen.WorkingArea.Height - 412
        Me.Location = New Point(715, 1)
    End Sub

    Private Sub btnConsonants_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsonants.Click
        btnB.Visible = True
        btnC.Visible = True
        btnD.Visible = True
        btnF.Visible = True
        btnG.Visible = True
        btnH.Visible = True
        btnJ.Visible = True
        btnK.Visible = True
        btnL.Visible = True
        btnM.Visible = True
        btnN.Visible = True
        btnP.Visible = True
        btnQ.Visible = True
        btnR.Visible = True
        btnS.Visible = True
        btnT.Visible = True
        btnV.Visible = True
        btnW.Visible = True
        btnX.Visible = True
        btnZ.Visible = True
        btnVowels.Enabled = False
        btnGuess.Enabled = False
    End Sub

    Private Sub btnVowels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVowels.Click
        If intMoney >= 250 Then
            intbtnVowels = MessageBox.Show("are you sure you would like to spend $250 on a vowel?", "", MessageBoxButtons.YesNo)
            btnA.Visible = True
            btnE.Visible = True
            btnI.Visible = True
            btnO.Visible = True
            btnU.Visible = True
            btnY.Visible = True
            btnGuess.Enabled = False
            btnConsonants.Enabled = False
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
    End Sub

    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        txtGuess.Visible = True
        btnCheck.Visible = True
        btnVowels.Enabled = False
        btnConsonants.Enabled = False
        lblPlease.Visible = True
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        If txtGuess.Text = "german rouladen" Then
            MsgBox("Congradulations thats correct")
            frmGame2.Show()
            Me.Close()
            frmGame.Close()
            intMoney = Val(frmGame.lblTotalAmountOfMoney.Text)
        Else : MsgBox("Thats incorrect, spin again")
            LetterReset()
            Me.Hide()
        End If
    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        MsgBox("Nice try,there is no B in the phrase")
        btnB.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Congradualtions.There is two A's in the phrase")
            frmGame.lblFoodA.Text = "A"
            frmGame.lblFoodA2.Text = "A"
            txtGuess.Text = ""
            btnA.Enabled = False
            frmGame.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        MsgBox("Congradulations there is one D in the phrase")
        frmGame.lblFoodD2.Text = "D"
        intMoney = intMoney + Val(lblSpun.Text)
        btnD.Enabled = False
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        MsgBox("Nice try,there is no F in the phrase")
        btnF.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        MsgBox("Congradulations there is one G in the phrase")
        frmGame.lblFoodG.Text = "G"
        intMoney = intMoney + Val(lblSpun.Text)
        btnG.Enabled = False
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnH.Click
        MsgBox("Nice try,there is no H in the phrase")
        btnH.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJ.Click
        MsgBox("Nice try,there is no J in the phrase")
        btnJ.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnK.Click
        MsgBox("Nice try,there is no K in the phrase")
        btnK.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        MsgBox("Congradulations there is one L in the phrase")
        frmGame.lblFoodL2.Text = "L"
        intMoney = intMoney + Val(lblSpun.Text)
        btnL.Enabled = False
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        MsgBox("Congradulations there is one M in the phrase")
        frmGame.lblFoodM.Text = "M"
        intMoney = intMoney + Val(lblSpun.Text)
        btnM.Enabled = False
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN.Click
        MsgBox("Congradulations there is two N's in the phrase")
        frmGame.lblFoodN.Text = "N"
        frmGame.lblFoodN2.Text = "N"
        intMoney = intMoney + Val(lblSpun.Text)
        btnN.Enabled = False
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP.Click
        MsgBox("Nice try,there is no P in the phrase")
        btnP.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ.Click
        MsgBox("Nice try,there is no Q in the phrase")
        btnQ.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnR.Click
        MsgBox("Congradulations there is two R's in the phrase")
        frmGame.lblFoodR.Text = "R"
        frmGame.lblFoodR2.Text = "R"
        intMoney = intMoney + Val(lblSpun.Text)
        btnR.Enabled = False
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        MsgBox("Nice try,there is no S in the phrase")
        btnS.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT.Click
        MsgBox("Nice try,there is no T in the phrase")
        btnT.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        MsgBox("Nice try,there is no V in the phrase")
        btnV.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnW.Click
        MsgBox("Nice try,there is no W in the phrase")
        btnW.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click
        MsgBox("Nice try,there is no X in the phrase")
        btnX.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZ.Click
        MsgBox("Nice try,there is no Z in the phrase")
        btnZ.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Congradualtions there is two E's in the phrase")
            frmGame.lblFoodE.Text = "E"
            frmGame.lblFoodE2.Text = "E"
            txtGuess.Text = ""
            btnE.Enabled = False
            frmGame.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnI.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Sorry there is no I's in the puzzle")
            txtGuess.Text = ""
            btnI.Enabled = False
            frmGame.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub lblSpun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSpun.Click
        lblSpun.Text = intMoney
        If lblSpun.Text = 0 Then
            MsgBox("You landed on a bankrupt space")
            intMoney = 0
            LetterReset()
            frmGame.lblTotalAmountOfMoney.Text = intMoney
            Me.Hide()
            LetterReset()
        End If
    End Sub

    Private Sub btnO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnO.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Congradualtions there is one O in the phrase")
            frmGame.lblFoodO2.Text = "O"
            txtGuess.Text = ""
            btnO.Enabled = False
            frmGame.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Congradualtions there is one U in the phrase")
            frmGame.lblFoodU2.Text = "U"
            txtGuess.Text = ""
            btnU.Enabled = False
            frmGame.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnY.Click
        
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Sorry there is no Y's in the puzzle")
            txtGuess.Text = ""
            btnY.Enabled = False
            frmGame.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset()
        Me.Hide()
    End Sub

    Private Sub btnC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        MsgBox("Nice try,there is no C in the phrase")
        btnC.Enabled = False
        intMoney = intMoney - 200
        frmGame.lblTotalAmountOfMoney.Text = intMoney
        txtGuess.Text = ""
        LetterReset()
        Me.Hide()
    End Sub
End Class