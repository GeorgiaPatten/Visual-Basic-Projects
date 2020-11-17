<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.imgGameBoard = New System.Windows.Forms.PictureBox()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.lblFoodG = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblFoodE = New System.Windows.Forms.Label()
        Me.lblFoodR = New System.Windows.Forms.Label()
        Me.lblFoodN = New System.Windows.Forms.Label()
        Me.lblFoodA = New System.Windows.Forms.Label()
        Me.lblFoodM = New System.Windows.Forms.Label()
        Me.lblFoodR2 = New System.Windows.Forms.Label()
        Me.lblFoodO2 = New System.Windows.Forms.Label()
        Me.lblFoodU2 = New System.Windows.Forms.Label()
        Me.lblFoodL2 = New System.Windows.Forms.Label()
        Me.lblFoodA2 = New System.Windows.Forms.Label()
        Me.lblFoodD2 = New System.Windows.Forms.Label()
        Me.lblFoodE2 = New System.Windows.Forms.Label()
        Me.lblFoodN2 = New System.Windows.Forms.Label()
        Me.tmrWheel = New System.Windows.Forms.Timer(Me.components)
        Me.lblTotalAmountOfMoney = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        CType(Me.imgGameBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgGameBoard
        '
        Me.imgGameBoard.BackgroundImage = CType(resources.GetObject("imgGameBoard.BackgroundImage"), System.Drawing.Image)
        Me.imgGameBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgGameBoard.Location = New System.Drawing.Point(36, 45)
        Me.imgGameBoard.Name = "imgGameBoard"
        Me.imgGameBoard.Size = New System.Drawing.Size(751, 497)
        Me.imgGameBoard.TabIndex = 0
        Me.imgGameBoard.TabStop = False
        '
        'lblPhrase
        '
        Me.lblPhrase.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPhrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(251, 24)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(320, 61)
        Me.lblPhrase.TabIndex = 1
        Me.lblPhrase.Text = "Types of Food"
        Me.lblPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSpin
        '
        Me.btnSpin.BackgroundImage = CType(resources.GetObject("btnSpin.BackgroundImage"), System.Drawing.Image)
        Me.btnSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSpin.Location = New System.Drawing.Point(736, 497)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(123, 127)
        Me.btnSpin.TabIndex = 2
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'lblFoodG
        '
        Me.lblFoodG.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodG.Location = New System.Drawing.Point(274, 199)
        Me.lblFoodG.Name = "lblFoodG"
        Me.lblFoodG.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodG.TabIndex = 3
        Me.lblFoodG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.Location = New System.Drawing.Point(12, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(70, 86)
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lblFoodE
        '
        Me.lblFoodE.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodE.Location = New System.Drawing.Point(321, 199)
        Me.lblFoodE.Name = "lblFoodE"
        Me.lblFoodE.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodE.TabIndex = 5
        Me.lblFoodE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodR
        '
        Me.lblFoodR.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodR.Location = New System.Drawing.Point(368, 199)
        Me.lblFoodR.Name = "lblFoodR"
        Me.lblFoodR.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodR.TabIndex = 6
        Me.lblFoodR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodN
        '
        Me.lblFoodN.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodN.Location = New System.Drawing.Point(509, 199)
        Me.lblFoodN.Name = "lblFoodN"
        Me.lblFoodN.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodN.TabIndex = 7
        Me.lblFoodN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodA
        '
        Me.lblFoodA.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodA.Location = New System.Drawing.Point(462, 199)
        Me.lblFoodA.Name = "lblFoodA"
        Me.lblFoodA.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodA.TabIndex = 8
        Me.lblFoodA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodM
        '
        Me.lblFoodM.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodM.Location = New System.Drawing.Point(415, 199)
        Me.lblFoodM.Name = "lblFoodM"
        Me.lblFoodM.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodM.TabIndex = 9
        Me.lblFoodM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodR2
        '
        Me.lblFoodR2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodR2.Location = New System.Drawing.Point(227, 276)
        Me.lblFoodR2.Name = "lblFoodR2"
        Me.lblFoodR2.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodR2.TabIndex = 10
        Me.lblFoodR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodO2
        '
        Me.lblFoodO2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodO2.Location = New System.Drawing.Point(274, 276)
        Me.lblFoodO2.Name = "lblFoodO2"
        Me.lblFoodO2.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodO2.TabIndex = 11
        Me.lblFoodO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodU2
        '
        Me.lblFoodU2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodU2.Location = New System.Drawing.Point(321, 276)
        Me.lblFoodU2.Name = "lblFoodU2"
        Me.lblFoodU2.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodU2.TabIndex = 12
        Me.lblFoodU2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodL2
        '
        Me.lblFoodL2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodL2.Location = New System.Drawing.Point(368, 276)
        Me.lblFoodL2.Name = "lblFoodL2"
        Me.lblFoodL2.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodL2.TabIndex = 13
        Me.lblFoodL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodA2
        '
        Me.lblFoodA2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodA2.Location = New System.Drawing.Point(415, 276)
        Me.lblFoodA2.Name = "lblFoodA2"
        Me.lblFoodA2.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodA2.TabIndex = 14
        Me.lblFoodA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodD2
        '
        Me.lblFoodD2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodD2.Location = New System.Drawing.Point(462, 276)
        Me.lblFoodD2.Name = "lblFoodD2"
        Me.lblFoodD2.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodD2.TabIndex = 15
        Me.lblFoodD2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodE2
        '
        Me.lblFoodE2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodE2.Location = New System.Drawing.Point(509, 276)
        Me.lblFoodE2.Name = "lblFoodE2"
        Me.lblFoodE2.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodE2.TabIndex = 16
        Me.lblFoodE2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodN2
        '
        Me.lblFoodN2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodN2.Location = New System.Drawing.Point(556, 276)
        Me.lblFoodN2.Name = "lblFoodN2"
        Me.lblFoodN2.Size = New System.Drawing.Size(44, 73)
        Me.lblFoodN2.TabIndex = 17
        Me.lblFoodN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrWheel
        '
        Me.tmrWheel.Interval = 2000
        '
        'lblTotalAmountOfMoney
        '
        Me.lblTotalAmountOfMoney.Font = New System.Drawing.Font("Magneto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountOfMoney.ForeColor = System.Drawing.Color.Crimson
        Me.lblTotalAmountOfMoney.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblTotalAmountOfMoney.Location = New System.Drawing.Point(735, 4)
        Me.lblTotalAmountOfMoney.Name = "lblTotalAmountOfMoney"
        Me.lblTotalAmountOfMoney.Size = New System.Drawing.Size(122, 38)
        Me.lblTotalAmountOfMoney.TabIndex = 18
        Me.lblTotalAmountOfMoney.Text = "0"
        Me.lblTotalAmountOfMoney.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblNo
        '
        Me.lblNo.Font = New System.Drawing.Font("Matura MT Script Capitals", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.ForeColor = System.Drawing.Color.Crimson
        Me.lblNo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblNo.Location = New System.Drawing.Point(705, 4)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(34, 38)
        Me.lblNo.TabIndex = 19
        Me.lblNo.Text = "$"
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 636)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.lblTotalAmountOfMoney)
        Me.Controls.Add(Me.lblFoodN2)
        Me.Controls.Add(Me.lblFoodE2)
        Me.Controls.Add(Me.lblFoodD2)
        Me.Controls.Add(Me.lblFoodA2)
        Me.Controls.Add(Me.lblFoodL2)
        Me.Controls.Add(Me.lblFoodU2)
        Me.Controls.Add(Me.lblFoodO2)
        Me.Controls.Add(Me.lblFoodR2)
        Me.Controls.Add(Me.lblFoodM)
        Me.Controls.Add(Me.lblFoodA)
        Me.Controls.Add(Me.lblFoodN)
        Me.Controls.Add(Me.lblFoodR)
        Me.Controls.Add(Me.lblFoodE)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblFoodG)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.imgGameBoard)
        Me.DoubleBuffered = True
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actual Game"
        CType(Me.imgGameBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgGameBoard As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhrase As System.Windows.Forms.Label
    Friend WithEvents btnSpin As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblFoodG As System.Windows.Forms.Label
    Friend WithEvents lblFoodE As System.Windows.Forms.Label
    Friend WithEvents lblFoodR As System.Windows.Forms.Label
    Friend WithEvents lblFoodN As System.Windows.Forms.Label
    Friend WithEvents lblFoodA As System.Windows.Forms.Label
    Friend WithEvents lblFoodM As System.Windows.Forms.Label
    Friend WithEvents lblFoodR2 As System.Windows.Forms.Label
    Friend WithEvents lblFoodO2 As System.Windows.Forms.Label
    Friend WithEvents lblFoodU2 As System.Windows.Forms.Label
    Friend WithEvents lblFoodL2 As System.Windows.Forms.Label
    Friend WithEvents lblFoodA2 As System.Windows.Forms.Label
    Friend WithEvents lblFoodD2 As System.Windows.Forms.Label
    Friend WithEvents lblFoodE2 As System.Windows.Forms.Label
    Friend WithEvents lblFoodN2 As System.Windows.Forms.Label
    Friend WithEvents tmrWheel As System.Windows.Forms.Timer
    Friend WithEvents lblTotalAmountOfMoney As System.Windows.Forms.Label
    Friend WithEvents lblNo As System.Windows.Forms.Label
End Class
