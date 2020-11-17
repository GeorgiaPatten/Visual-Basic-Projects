<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpening
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpening))
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblPleaseTryAgain = New System.Windows.Forms.Label()
        Me.imgOpening = New System.Windows.Forms.PictureBox()
        CType(Me.imgOpening, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(70, 16)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(135, 29)
        Me.txtFirstName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(669, 16)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(142, 29)
        Me.txtPassword.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(376, 16)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(147, 29)
        Me.txtLastName.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.BackgroundImage = CType(resources.GetObject("btnStart.BackgroundImage"), System.Drawing.Image)
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.Location = New System.Drawing.Point(743, 513)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(116, 111)
        Me.btnStart.TabIndex = 3
        Me.btnStart.TabStop = False
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFirstName.Location = New System.Drawing.Point(70, 5)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLastName.Location = New System.Drawing.Point(376, 4)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPassword.Location = New System.Drawing.Point(669, 4)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'lblPleaseTryAgain
        '
        Me.lblPleaseTryAgain.Location = New System.Drawing.Point(364, 264)
        Me.lblPleaseTryAgain.Name = "lblPleaseTryAgain"
        Me.lblPleaseTryAgain.Size = New System.Drawing.Size(170, 106)
        Me.lblPleaseTryAgain.TabIndex = 7
        Me.lblPleaseTryAgain.Visible = False
        '
        'imgOpening
        '
        Me.imgOpening.Image = CType(resources.GetObject("imgOpening.Image"), System.Drawing.Image)
        Me.imgOpening.Location = New System.Drawing.Point(0, 0)
        Me.imgOpening.Name = "imgOpening"
        Me.imgOpening.Size = New System.Drawing.Size(873, 636)
        Me.imgOpening.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgOpening.TabIndex = 8
        Me.imgOpening.TabStop = False
        '
        'frmOpening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 636)
        Me.Controls.Add(Me.lblPleaseTryAgain)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.imgOpening)
        Me.DoubleBuffered = True
        Me.Name = "frmOpening"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.imgOpening, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblPleaseTryAgain As System.Windows.Forms.Label
    Friend WithEvents imgOpening As System.Windows.Forms.PictureBox

End Class
