<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame2))
        Me.imgGameBoard = New System.Windows.Forms.PictureBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblFunE = New System.Windows.Forms.Label()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.tmrWheel = New System.Windows.Forms.Timer(Me.components)
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblTotalAmountOfMoney = New System.Windows.Forms.Label()
        Me.lblFunX = New System.Windows.Forms.Label()
        Me.lblFunI = New System.Windows.Forms.Label()
        Me.lblFunH = New System.Windows.Forms.Label()
        Me.lblfunA3 = New System.Windows.Forms.Label()
        Me.lblFunL = New System.Windows.Forms.Label()
        Me.lblFunW = New System.Windows.Forms.Label()
        Me.lblFunE2 = New System.Windows.Forms.Label()
        Me.lblFunT2 = New System.Windows.Forms.Label()
        Me.lblFunA = New System.Windows.Forms.Label()
        Me.lblFunI2 = New System.Windows.Forms.Label()
        Me.lblFunR = New System.Windows.Forms.Label()
        Me.lblFunN = New System.Windows.Forms.Label()
        Me.lblFunT = New System.Windows.Forms.Label()
        Me.lblFunA2 = New System.Windows.Forms.Label()
        Me.lblFunL2 = New System.Windows.Forms.Label()
        Me.lblFunR2 = New System.Windows.Forms.Label()
        Me.lblFunG = New System.Windows.Forms.Label()
        Me.lblFunS = New System.Windows.Forms.Label()
        Me.lblFunI3 = New System.Windows.Forms.Label()
        Me.lblFunE3 = New System.Windows.Forms.Label()
        Me.lblFunD = New System.Windows.Forms.Label()
        CType(Me.imgGameBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgGameBoard
        '
        Me.imgGameBoard.BackgroundImage = CType(resources.GetObject("imgGameBoard.BackgroundImage"), System.Drawing.Image)
        Me.imgGameBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgGameBoard.Location = New System.Drawing.Point(40, 42)
        Me.imgGameBoard.Name = "imgGameBoard"
        Me.imgGameBoard.Size = New System.Drawing.Size(751, 497)
        Me.imgGameBoard.TabIndex = 1
        Me.imgGameBoard.TabStop = False
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.Location = New System.Drawing.Point(12, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(70, 86)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lblPhrase
        '
        Me.lblPhrase.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPhrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(232, 9)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(320, 61)
        Me.lblPhrase.TabIndex = 6
        Me.lblPhrase.Text = "Fun and Games"
        Me.lblPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunE
        '
        Me.lblFunE.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunE.Location = New System.Drawing.Point(136, 199)
        Me.lblFunE.Name = "lblFunE"
        Me.lblFunE.Size = New System.Drawing.Size(44, 73)
        Me.lblFunE.TabIndex = 7
        Me.lblFunE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSpin
        '
        Me.btnSpin.BackgroundImage = CType(resources.GetObject("btnSpin.BackgroundImage"), System.Drawing.Image)
        Me.btnSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSpin.Location = New System.Drawing.Point(736, 497)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(123, 127)
        Me.btnSpin.TabIndex = 8
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'tmrWheel
        '
        Me.tmrWheel.Interval = 2000
        '
        'lblNo
        '
        Me.lblNo.Font = New System.Drawing.Font("Matura MT Script Capitals", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.ForeColor = System.Drawing.Color.Crimson
        Me.lblNo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblNo.Location = New System.Drawing.Point(707, 9)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(34, 38)
        Me.lblNo.TabIndex = 21
        Me.lblNo.Text = "$"
        '
        'lblTotalAmountOfMoney
        '
        Me.lblTotalAmountOfMoney.Font = New System.Drawing.Font("Magneto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountOfMoney.ForeColor = System.Drawing.Color.Crimson
        Me.lblTotalAmountOfMoney.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblTotalAmountOfMoney.Location = New System.Drawing.Point(737, 9)
        Me.lblTotalAmountOfMoney.Name = "lblTotalAmountOfMoney"
        Me.lblTotalAmountOfMoney.Size = New System.Drawing.Size(122, 38)
        Me.lblTotalAmountOfMoney.TabIndex = 20
        Me.lblTotalAmountOfMoney.Text = "0"
        Me.lblTotalAmountOfMoney.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblFunX
        '
        Me.lblFunX.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunX.Location = New System.Drawing.Point(183, 199)
        Me.lblFunX.Name = "lblFunX"
        Me.lblFunX.Size = New System.Drawing.Size(44, 73)
        Me.lblFunX.TabIndex = 22
        Me.lblFunX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunI
        '
        Me.lblFunI.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunI.Location = New System.Drawing.Point(278, 199)
        Me.lblFunI.Name = "lblFunI"
        Me.lblFunI.Size = New System.Drawing.Size(44, 73)
        Me.lblFunI.TabIndex = 23
        Me.lblFunI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunH
        '
        Me.lblFunH.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunH.Location = New System.Drawing.Point(231, 199)
        Me.lblFunH.Name = "lblFunH"
        Me.lblFunH.Size = New System.Drawing.Size(44, 73)
        Me.lblFunH.TabIndex = 24
        Me.lblFunH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfunA3
        '
        Me.lblfunA3.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfunA3.Location = New System.Drawing.Point(183, 276)
        Me.lblfunA3.Name = "lblfunA3"
        Me.lblfunA3.Size = New System.Drawing.Size(44, 73)
        Me.lblfunA3.TabIndex = 25
        Me.lblfunA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunL
        '
        Me.lblFunL.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunL.Location = New System.Drawing.Point(325, 199)
        Me.lblFunL.Name = "lblFunL"
        Me.lblFunL.Size = New System.Drawing.Size(44, 73)
        Me.lblFunL.TabIndex = 26
        Me.lblFunL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunW
        '
        Me.lblFunW.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunW.Location = New System.Drawing.Point(136, 276)
        Me.lblFunW.Name = "lblFunW"
        Me.lblFunW.Size = New System.Drawing.Size(44, 73)
        Me.lblFunW.TabIndex = 27
        Me.lblFunW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunE2
        '
        Me.lblFunE2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunE2.Location = New System.Drawing.Point(278, 276)
        Me.lblFunE2.Name = "lblFunE2"
        Me.lblFunE2.Size = New System.Drawing.Size(44, 73)
        Me.lblFunE2.TabIndex = 28
        Me.lblFunE2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunT2
        '
        Me.lblFunT2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunT2.Location = New System.Drawing.Point(231, 276)
        Me.lblFunT2.Name = "lblFunT2"
        Me.lblFunT2.Size = New System.Drawing.Size(44, 73)
        Me.lblFunT2.TabIndex = 29
        Me.lblFunT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunA
        '
        Me.lblFunA.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunA.Location = New System.Drawing.Point(371, 199)
        Me.lblFunA.Name = "lblFunA"
        Me.lblFunA.Size = New System.Drawing.Size(44, 73)
        Me.lblFunA.TabIndex = 30
        Me.lblFunA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunI2
        '
        Me.lblFunI2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunI2.Location = New System.Drawing.Point(560, 199)
        Me.lblFunI2.Name = "lblFunI2"
        Me.lblFunI2.Size = New System.Drawing.Size(44, 73)
        Me.lblFunI2.TabIndex = 31
        Me.lblFunI2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunR
        '
        Me.lblFunR.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunR.Location = New System.Drawing.Point(418, 199)
        Me.lblFunR.Name = "lblFunR"
        Me.lblFunR.Size = New System.Drawing.Size(44, 73)
        Me.lblFunR.TabIndex = 32
        Me.lblFunR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunN
        '
        Me.lblFunN.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunN.Location = New System.Drawing.Point(607, 199)
        Me.lblFunN.Name = "lblFunN"
        Me.lblFunN.Size = New System.Drawing.Size(44, 73)
        Me.lblFunN.TabIndex = 33
        Me.lblFunN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunT
        '
        Me.lblFunT.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunT.Location = New System.Drawing.Point(513, 199)
        Me.lblFunT.Name = "lblFunT"
        Me.lblFunT.Size = New System.Drawing.Size(44, 73)
        Me.lblFunT.TabIndex = 34
        Me.lblFunT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunA2
        '
        Me.lblFunA2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunA2.Location = New System.Drawing.Point(466, 199)
        Me.lblFunA2.Name = "lblFunA2"
        Me.lblFunA2.Size = New System.Drawing.Size(44, 73)
        Me.lblFunA2.TabIndex = 35
        Me.lblFunA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunL2
        '
        Me.lblFunL2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunL2.Location = New System.Drawing.Point(466, 276)
        Me.lblFunL2.Name = "lblFunL2"
        Me.lblFunL2.Size = New System.Drawing.Size(44, 73)
        Me.lblFunL2.TabIndex = 36
        Me.lblFunL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunR2
        '
        Me.lblFunR2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunR2.Location = New System.Drawing.Point(325, 276)
        Me.lblFunR2.Name = "lblFunR2"
        Me.lblFunR2.Size = New System.Drawing.Size(44, 73)
        Me.lblFunR2.TabIndex = 37
        Me.lblFunR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunG
        '
        Me.lblFunG.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunG.Location = New System.Drawing.Point(655, 199)
        Me.lblFunG.Name = "lblFunG"
        Me.lblFunG.Size = New System.Drawing.Size(44, 73)
        Me.lblFunG.TabIndex = 38
        Me.lblFunG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunS
        '
        Me.lblFunS.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunS.Location = New System.Drawing.Point(419, 276)
        Me.lblFunS.Name = "lblFunS"
        Me.lblFunS.Size = New System.Drawing.Size(44, 73)
        Me.lblFunS.TabIndex = 39
        Me.lblFunS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunI3
        '
        Me.lblFunI3.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunI3.Location = New System.Drawing.Point(513, 276)
        Me.lblFunI3.Name = "lblFunI3"
        Me.lblFunI3.Size = New System.Drawing.Size(44, 73)
        Me.lblFunI3.TabIndex = 40
        Me.lblFunI3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunE3
        '
        Me.lblFunE3.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunE3.Location = New System.Drawing.Point(607, 277)
        Me.lblFunE3.Name = "lblFunE3"
        Me.lblFunE3.Size = New System.Drawing.Size(44, 73)
        Me.lblFunE3.TabIndex = 41
        Me.lblFunE3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFunD
        '
        Me.lblFunD.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunD.Location = New System.Drawing.Point(560, 277)
        Me.lblFunD.Name = "lblFunD"
        Me.lblFunD.Size = New System.Drawing.Size(44, 73)
        Me.lblFunD.TabIndex = 42
        Me.lblFunD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGame2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 636)
        Me.Controls.Add(Me.lblFunD)
        Me.Controls.Add(Me.lblFunE3)
        Me.Controls.Add(Me.lblFunI3)
        Me.Controls.Add(Me.lblFunS)
        Me.Controls.Add(Me.lblFunG)
        Me.Controls.Add(Me.lblFunR2)
        Me.Controls.Add(Me.lblFunL2)
        Me.Controls.Add(Me.lblFunA2)
        Me.Controls.Add(Me.lblFunT)
        Me.Controls.Add(Me.lblFunN)
        Me.Controls.Add(Me.lblFunR)
        Me.Controls.Add(Me.lblFunI2)
        Me.Controls.Add(Me.lblFunA)
        Me.Controls.Add(Me.lblFunT2)
        Me.Controls.Add(Me.lblFunE2)
        Me.Controls.Add(Me.lblFunW)
        Me.Controls.Add(Me.lblFunL)
        Me.Controls.Add(Me.lblfunA3)
        Me.Controls.Add(Me.lblFunH)
        Me.Controls.Add(Me.lblFunI)
        Me.Controls.Add(Me.lblFunX)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.lblTotalAmountOfMoney)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.lblFunE)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.imgGameBoard)
        Me.DoubleBuffered = True
        Me.Name = "frmGame2"
        Me.Text = "Game #2 "
        CType(Me.imgGameBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgGameBoard As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblPhrase As System.Windows.Forms.Label
    Friend WithEvents lblFunE As System.Windows.Forms.Label
    Friend WithEvents btnSpin As System.Windows.Forms.Button
    Friend WithEvents tmrWheel As System.Windows.Forms.Timer
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmountOfMoney As System.Windows.Forms.Label
    Friend WithEvents lblFunX As System.Windows.Forms.Label
    Friend WithEvents lblFunI As System.Windows.Forms.Label
    Friend WithEvents lblFunH As System.Windows.Forms.Label
    Friend WithEvents lblfunA3 As System.Windows.Forms.Label
    Friend WithEvents lblFunL As System.Windows.Forms.Label
    Friend WithEvents lblFunW As System.Windows.Forms.Label
    Friend WithEvents lblFunE2 As System.Windows.Forms.Label
    Friend WithEvents lblFunT2 As System.Windows.Forms.Label
    Friend WithEvents lblFunA As System.Windows.Forms.Label
    Friend WithEvents lblFunI2 As System.Windows.Forms.Label
    Friend WithEvents lblFunR As System.Windows.Forms.Label
    Friend WithEvents lblFunN As System.Windows.Forms.Label
    Friend WithEvents lblFunT As System.Windows.Forms.Label
    Friend WithEvents lblFunA2 As System.Windows.Forms.Label
    Friend WithEvents lblFunL2 As System.Windows.Forms.Label
    Friend WithEvents lblFunR2 As System.Windows.Forms.Label
    Friend WithEvents lblFunG As System.Windows.Forms.Label
    Friend WithEvents lblFunS As System.Windows.Forms.Label
    Friend WithEvents lblFunI3 As System.Windows.Forms.Label
    Friend WithEvents lblFunE3 As System.Windows.Forms.Label
    Friend WithEvents lblFunD As System.Windows.Forms.Label
End Class
