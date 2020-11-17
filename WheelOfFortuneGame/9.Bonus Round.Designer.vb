<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBonusRound
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBonusRound))
        Me.imgFinalGamesBoard = New System.Windows.Forms.PictureBox()
        Me.btnHelpBonus = New System.Windows.Forms.Button()
        Me.lblFinalO = New System.Windows.Forms.Label()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblFinalC = New System.Windows.Forms.Label()
        Me.lblFinalE = New System.Windows.Forms.Label()
        Me.lblFinalA = New System.Windows.Forms.Label()
        Me.lblFinalN = New System.Windows.Forms.Label()
        Me.lblFinalS = New System.Windows.Forms.Label()
        Me.lblFinalT = New System.Windows.Forms.Label()
        Me.lblFinalW = New System.Windows.Forms.Label()
        Me.lblFinalE2 = New System.Windows.Forms.Label()
        Me.lblFinalL = New System.Windows.Forms.Label()
        Me.lblFinalV = New System.Windows.Forms.Label()
        Me.lblFinalE3 = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblPlease = New System.Windows.Forms.Label()
        Me.lblGivenLetters = New System.Windows.Forms.Label()
        Me.tmrFinal = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        CType(Me.imgFinalGamesBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgFinalGamesBoard
        '
        Me.imgFinalGamesBoard.BackColor = System.Drawing.SystemColors.Window
        Me.imgFinalGamesBoard.Image = CType(resources.GetObject("imgFinalGamesBoard.Image"), System.Drawing.Image)
        Me.imgFinalGamesBoard.Location = New System.Drawing.Point(25, 28)
        Me.imgFinalGamesBoard.Name = "imgFinalGamesBoard"
        Me.imgFinalGamesBoard.Size = New System.Drawing.Size(834, 528)
        Me.imgFinalGamesBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFinalGamesBoard.TabIndex = 0
        Me.imgFinalGamesBoard.TabStop = False
        '
        'btnHelpBonus
        '
        Me.btnHelpBonus.BackgroundImage = CType(resources.GetObject("btnHelpBonus.BackgroundImage"), System.Drawing.Image)
        Me.btnHelpBonus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelpBonus.Location = New System.Drawing.Point(3, 8)
        Me.btnHelpBonus.Name = "btnHelpBonus"
        Me.btnHelpBonus.Size = New System.Drawing.Size(79, 86)
        Me.btnHelpBonus.TabIndex = 1
        Me.btnHelpBonus.UseVisualStyleBackColor = True
        '
        'lblFinalO
        '
        Me.lblFinalO.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalO.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalO.Location = New System.Drawing.Point(322, 207)
        Me.lblFinalO.Name = "lblFinalO"
        Me.lblFinalO.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalO.TabIndex = 4
        Me.lblFinalO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhrase
        '
        Me.lblPhrase.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPhrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(330, 54)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(241, 52)
        Me.lblPhrase.TabIndex = 5
        Me.lblPhrase.Text = "Movie Title"
        Me.lblPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalC
        '
        Me.lblFinalC.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalC.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalC.Location = New System.Drawing.Point(363, 208)
        Me.lblFinalC.Name = "lblFinalC"
        Me.lblFinalC.Size = New System.Drawing.Size(35, 53)
        Me.lblFinalC.TabIndex = 6
        Me.lblFinalC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalE
        '
        Me.lblFinalE.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalE.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalE.Location = New System.Drawing.Point(404, 208)
        Me.lblFinalE.Name = "lblFinalE"
        Me.lblFinalE.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalE.TabIndex = 7
        Me.lblFinalE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalA
        '
        Me.lblFinalA.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalA.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalA.Location = New System.Drawing.Point(445, 208)
        Me.lblFinalA.Name = "lblFinalA"
        Me.lblFinalA.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalA.TabIndex = 8
        Me.lblFinalA.Text = "A"
        Me.lblFinalA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalN
        '
        Me.lblFinalN.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalN.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalN.Location = New System.Drawing.Point(485, 208)
        Me.lblFinalN.Name = "lblFinalN"
        Me.lblFinalN.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalN.TabIndex = 9
        Me.lblFinalN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalS
        '
        Me.lblFinalS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalS.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalS.Location = New System.Drawing.Point(525, 208)
        Me.lblFinalS.Name = "lblFinalS"
        Me.lblFinalS.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalS.TabIndex = 10
        Me.lblFinalS.Text = "S"
        Me.lblFinalS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalT
        '
        Me.lblFinalT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalT.Location = New System.Drawing.Point(322, 270)
        Me.lblFinalT.Name = "lblFinalT"
        Me.lblFinalT.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalT.TabIndex = 11
        Me.lblFinalT.Text = "T"
        Me.lblFinalT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalW
        '
        Me.lblFinalW.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalW.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalW.Location = New System.Drawing.Point(362, 270)
        Me.lblFinalW.Name = "lblFinalW"
        Me.lblFinalW.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalW.TabIndex = 12
        Me.lblFinalW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalE2
        '
        Me.lblFinalE2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalE2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalE2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalE2.Location = New System.Drawing.Point(404, 270)
        Me.lblFinalE2.Name = "lblFinalE2"
        Me.lblFinalE2.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalE2.TabIndex = 13
        Me.lblFinalE2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalL
        '
        Me.lblFinalL.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalL.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalL.Location = New System.Drawing.Point(444, 270)
        Me.lblFinalL.Name = "lblFinalL"
        Me.lblFinalL.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalL.TabIndex = 14
        Me.lblFinalL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalV
        '
        Me.lblFinalV.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalV.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalV.Location = New System.Drawing.Point(485, 270)
        Me.lblFinalV.Name = "lblFinalV"
        Me.lblFinalV.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalV.TabIndex = 15
        Me.lblFinalV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalE3
        '
        Me.lblFinalE3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFinalE3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalE3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalE3.Location = New System.Drawing.Point(525, 270)
        Me.lblFinalE3.Name = "lblFinalE3"
        Me.lblFinalE3.Size = New System.Drawing.Size(34, 54)
        Me.lblFinalE3.TabIndex = 16
        Me.lblFinalE3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGuess
        '
        Me.txtGuess.ForeColor = System.Drawing.Color.Blue
        Me.txtGuess.Location = New System.Drawing.Point(363, 475)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(146, 20)
        Me.txtGuess.TabIndex = 70
        Me.txtGuess.Tag = ""
        '
        'btnCheck
        '
        Me.btnCheck.ForeColor = System.Drawing.Color.Blue
        Me.btnCheck.Location = New System.Drawing.Point(464, 501)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(73, 19)
        Me.btnCheck.TabIndex = 73
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblPlease
        '
        Me.lblPlease.AutoSize = True
        Me.lblPlease.BackColor = System.Drawing.Color.MintCream
        Me.lblPlease.ForeColor = System.Drawing.Color.Blue
        Me.lblPlease.Location = New System.Drawing.Point(361, 452)
        Me.lblPlease.Name = "lblPlease"
        Me.lblPlease.Size = New System.Drawing.Size(149, 13)
        Me.lblPlease.TabIndex = 75
        Me.lblPlease.Text = "Please guess without capitals!"
        '
        'lblGivenLetters
        '
        Me.lblGivenLetters.AutoSize = True
        Me.lblGivenLetters.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGivenLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGivenLetters.Location = New System.Drawing.Point(333, 427)
        Me.lblGivenLetters.Name = "lblGivenLetters"
        Me.lblGivenLetters.Size = New System.Drawing.Size(204, 20)
        Me.lblGivenLetters.TabIndex = 76
        Me.lblGivenLetters.Text = "Your letters are RSTIBA"
        '
        'tmrFinal
        '
        Me.tmrFinal.Interval = 1000
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTimer.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Teal
        Me.lblTimer.Location = New System.Drawing.Point(674, 26)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(53, 34)
        Me.lblTimer.TabIndex = 77
        '
        'frmBonusRound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(859, 540)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblGivenLetters)
        Me.Controls.Add(Me.lblPlease)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblFinalE3)
        Me.Controls.Add(Me.lblFinalV)
        Me.Controls.Add(Me.lblFinalL)
        Me.Controls.Add(Me.lblFinalE2)
        Me.Controls.Add(Me.lblFinalW)
        Me.Controls.Add(Me.lblFinalT)
        Me.Controls.Add(Me.lblFinalS)
        Me.Controls.Add(Me.lblFinalN)
        Me.Controls.Add(Me.lblFinalA)
        Me.Controls.Add(Me.lblFinalE)
        Me.Controls.Add(Me.lblFinalC)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.lblFinalO)
        Me.Controls.Add(Me.btnHelpBonus)
        Me.Controls.Add(Me.imgFinalGamesBoard)
        Me.Name = "frmBonusRound"
        Me.Text = "Bonus Round"
        CType(Me.imgFinalGamesBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgFinalGamesBoard As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelpBonus As System.Windows.Forms.Button
    Friend WithEvents lblFinalO As System.Windows.Forms.Label
    Friend WithEvents lblPhrase As System.Windows.Forms.Label
    Friend WithEvents lblFinalC As System.Windows.Forms.Label
    Friend WithEvents lblFinalE As System.Windows.Forms.Label
    Friend WithEvents lblFinalA As System.Windows.Forms.Label
    Friend WithEvents lblFinalN As System.Windows.Forms.Label
    Friend WithEvents lblFinalS As System.Windows.Forms.Label
    Friend WithEvents lblFinalT As System.Windows.Forms.Label
    Friend WithEvents lblFinalW As System.Windows.Forms.Label
    Friend WithEvents lblFinalE2 As System.Windows.Forms.Label
    Friend WithEvents lblFinalL As System.Windows.Forms.Label
    Friend WithEvents lblFinalV As System.Windows.Forms.Label
    Friend WithEvents lblFinalE3 As System.Windows.Forms.Label
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents lblPlease As System.Windows.Forms.Label
    Friend WithEvents lblGivenLetters As System.Windows.Forms.Label
    Friend WithEvents tmrFinal As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
End Class
