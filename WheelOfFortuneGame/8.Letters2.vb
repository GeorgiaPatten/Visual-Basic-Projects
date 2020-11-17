'Name-              Georgia Patten
'Date-              May 1, 2017
'Description-       This part of my project is where you can pick if you would like to guess a vowel, constanant or guess the phrase.
'________________________________________________________________________________________________________________________________________

Public Class frmLetters2

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
        If txtGuess.Text = "exhilarating water slide" Then
            MsgBox("Congradulations thats correct")
            frmVideoBonus.Show()
            Me.Close()
            frmGame2.Close()
            frmVideoBonus.tmrBonus.Start()
        Else : MsgBox("Thats incorrect, spin again")
            LetterReset2()
            Me.Hide()
        End If
    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        MsgBox("Nice try,there is no B in the phrase")
        btnB.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Congradualtions.There is three A's in the phrase")
            frmGame2.lblFunA2.Text = "A"
            frmGame2.lblFunA.Text = "A"
            frmGame2.lblfunA3.Text = "A"
            txtGuess.Text = ""
            btnA.Enabled = False
            frmGame2.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        MsgBox("Congradulations there is one D in the phrase")
        frmGame2.lblFunD.Text = "D"
        intMoney = intMoney + Val(lblSpun.Text)
        btnD.Enabled = False
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        MsgBox("Nice try,there is no F in the phrase")
        btnF.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        MsgBox("Congradulations there is one G in the phrase")
        frmGame2.lblFunG.Text = "G"
        intMoney = intMoney + Val(lblSpun.Text)
        btnG.Enabled = False
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnH.Click
        MsgBox("Congradulations there is one H in the phrase")
        frmGame2.lblFunH.Text = "H"
        btnH.Enabled = False
        intMoney = intMoney + Val(lblSpun.Text)
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJ.Click
        MsgBox("Nice try,there is no J in the phrase")
        btnJ.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnK.Click
        MsgBox("Nice try,there is no K in the phrase")
        btnK.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        MsgBox("Congradulations there is two L's in the phrase")
        frmGame2.lblFunL.Text = "L"
        frmGame2.lblFunL2.Text = "L"
        intMoney = intMoney + Val(lblSpun.Text)
        btnL.Enabled = False
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        MsgBox("Nice try,there is no M in the phrase")
        btnM.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN.Click
        MsgBox("Congradulations there is one N in the phrase")
        frmGame2.lblFunN.Text = "N"
        intMoney = intMoney + Val(lblSpun.Text)
        btnN.Enabled = False
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP.Click
        MsgBox("Nice try,there is no P in the phrase")
        btnP.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ.Click
        MsgBox("Nice try,there is no Q in the phrase")
        btnQ.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnR.Click
        MsgBox("Congradulations there is two R's in the phrase")
        frmGame2.lblFunR.Text = "R"
        frmGame2.lblFunR2.Text = "R"
        intMoney = intMoney + Val(lblSpun.Text)
        btnR.Enabled = False
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        MsgBox("Congradulations there is one S in the phrase")
        frmGame2.lblFunS.Text = "S"
        btnS.Enabled = False
        intMoney = intMoney + Val(lblSpun.Text)
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT.Click
        MsgBox("Congradulations there is two T's in the phrase")
        frmGame2.lblFunT.Text = "T"
        frmGame2.lblFunT2.Text = "T"
        btnT.Enabled = False
        intMoney = intMoney + Val(lblSpun.Text)
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        MsgBox("Nice try,there is no V in the phrase")
        btnV.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnW.Click
        MsgBox("Congradulations there is one W in the phrase")
        frmGame2.lblFunW.Text = "W"
        intMoney = intMoney + Val(lblSpun.Text)
        btnW.Enabled = False
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click
        MsgBox("Congradulations there is one X in the phrase")
        frmGame2.lblFunX.Text = "X"
        intMoney = intMoney + Val(lblSpun.Text)
        btnX.Enabled = False
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZ.Click
        MsgBox("Nice try,there is no Z in the phrase")
        btnZ.Enabled = False
        intMoney = intMoney - 200
        txtGuess.Text = ""
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Congradualtions there is three E's in the phrase")
            frmGame2.lblFunE.Text = "E"
            frmGame2.lblFunE2.Text = "E"
            frmGame2.lblFunE3.Text = "E"
            txtGuess.Text = ""
            btnE.Enabled = False
            frmGame2.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnI.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Congradualtions there is three I's in the phrase")
            frmGame2.lblFunI.Text = "I"
            frmGame2.lblFunI2.Text = "I"
            frmGame2.lblFunI3.Text = "I"
            txtGuess.Text = ""
            btnI.Enabled = False
            frmGame2.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnO.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Sorry there is no O's in the puzzle")
            txtGuess.Text = ""
            btnO.Enabled = False
            frmGame2.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Sorry there is no U's in the puzzle")
            txtGuess.Text = ""
            btnU.Enabled = False
            frmGame2.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnY.Click

        If intMoney >= 250 Then
            intMoney = intMoney - 250
            MsgBox("Sorry there is no Y's in the puzzle")
            txtGuess.Text = ""
            btnY.Enabled = False
            frmGame2.lblTotalAmountOfMoney.Text = intMoney
        Else : MsgBox("Sorry you dont have enough money. Please spin and get more money to guess this letter")
        End If
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub btnC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        MsgBox("Nice try,there is no C in the phrase")
        btnC.Enabled = False
        intMoney = intMoney - 200
        frmGame2.lblTotalAmountOfMoney.Text = intMoney
        txtGuess.Text = ""
        LetterReset2()
        Me.Hide()
    End Sub

    Private Sub txtGuess_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuess.TextChanged

    End Sub
End Class