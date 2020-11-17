'Name-              Georgia Patten
'Date-              April 19, 2017
'Description-       This is where all of the extra code for every form will come.
'_____________________________________________________________________________________


Module modDec
    Public strFirstName As String
    Public strLastName As String
    Public randomNumber As New Random
    Public intspin As Integer
    Public intMoney As Integer

    Public Sub LetterReset()
        frmLetters.btnA.Visible = False
        frmLetters.btnB.Visible = False
        frmLetters.btnC.Visible = False
        frmLetters.btnD.Visible = False
        frmLetters.btnE.Visible = False
        frmLetters.btnF.Visible = False
        frmLetters.btnG.Visible = False
        frmLetters.btnH.Visible = False
        frmLetters.btnI.Visible = False
        frmLetters.btnJ.Visible = False
        frmLetters.btnK.Visible = False
        frmLetters.btnL.Visible = False
        frmLetters.btnM.Visible = False
        frmLetters.btnN.Visible = False
        frmLetters.btnO.Visible = False
        frmLetters.btnP.Visible = False
        frmLetters.btnQ.Visible = False
        frmLetters.btnR.Visible = False
        frmLetters.btnS.Visible = False
        frmLetters.btnT.Visible = False
        frmLetters.btnU.Visible = False
        frmLetters.btnV.Visible = False
        frmLetters.btnW.Visible = False
        frmLetters.btnX.Visible = False
        frmLetters.btnY.Visible = False
        frmLetters.btnZ.Visible = False
        frmLetters.btnCheck.Visible = False
        frmLetters.txtGuess.Visible = False
        frmLetters.lblPlease.Visible = False
        frmLetters.btnConsonants.Enabled = True
        frmLetters.btnVowels.Enabled = True
        frmLetters.btnGuess.Enabled = True
    End Sub
    Public Sub LetterReset2()
        frmLetters2.btnA.Visible = False
        frmLetters2.btnB.Visible = False
        frmLetters2.btnC.Visible = False
        frmLetters2.btnD.Visible = False
        frmLetters2.btnE.Visible = False
        frmLetters2.btnF.Visible = False
        frmLetters2.btnG.Visible = False
        frmLetters2.btnH.Visible = False
        frmLetters2.btnI.Visible = False
        frmLetters2.btnJ.Visible = False
        frmLetters2.btnK.Visible = False
        frmLetters2.btnL.Visible = False
        frmLetters2.btnM.Visible = False
        frmLetters2.btnN.Visible = False
        frmLetters2.btnO.Visible = False
        frmLetters2.btnP.Visible = False
        frmLetters2.btnQ.Visible = False
        frmLetters2.btnR.Visible = False
        frmLetters2.btnS.Visible = False
        frmLetters2.btnT.Visible = False
        frmLetters2.btnU.Visible = False
        frmLetters2.btnV.Visible = False
        frmLetters2.btnW.Visible = False
        frmLetters2.btnX.Visible = False
        frmLetters2.btnY.Visible = False
        frmLetters2.btnZ.Visible = False
        frmLetters2.btnCheck.Visible = False
        frmLetters2.txtGuess.Visible = False
        frmLetters2.lblPlease.Visible = False
        frmLetters2.btnConsonants.Enabled = True
        frmLetters2.btnVowels.Enabled = True
        frmLetters2.btnGuess.Enabled = True
    End Sub
    Public Sub LetterHide()
        frmLettersFinal.btnB.Visible = False
        frmLettersFinal.btnC.Visible = False
        frmLettersFinal.btnD.Visible = False
        frmLettersFinal.btnF.Visible = False
        frmLettersFinal.btnG.Visible = False
        frmLettersFinal.btnH.Visible = False
        frmLettersFinal.btnJ.Visible = False
        frmLettersFinal.btnK.Visible = False
        frmLettersFinal.btnL.Visible = False
        frmLettersFinal.btnM.Visible = False
        frmLettersFinal.btnN.Visible = False
        frmLettersFinal.btnP.Visible = False
        frmLettersFinal.btnQ.Visible = False
        frmLettersFinal.btnR.Visible = False
        frmLettersFinal.btnS.Visible = False
        frmLettersFinal.btnT.Visible = False
        frmLettersFinal.btnV.Visible = False
        frmLettersFinal.btnW.Visible = False
        frmLettersFinal.btnX.Visible = False
        frmLettersFinal.btnZ.Visible = False
    End Sub
    Public Sub LetterStart()
        frmLettersFinal.btnA.Visible = True
        frmLettersFinal.btnE.Visible = True
        frmLettersFinal.btnI.Visible = True
        frmLettersFinal.btnO.Visible = True
        frmLettersFinal.btnU.Visible = True
        frmLettersFinal.btnY.Visible = True
    End Sub
End Module

