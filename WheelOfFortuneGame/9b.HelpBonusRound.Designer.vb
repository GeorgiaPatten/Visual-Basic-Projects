<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelpBonus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelpBonus))
        Me.lblHelpBonus = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHelpBonus
        '
        Me.lblHelpBonus.BackColor = System.Drawing.Color.SlateGray
        Me.lblHelpBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpBonus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHelpBonus.Location = New System.Drawing.Point(20, 50)
        Me.lblHelpBonus.Name = "lblHelpBonus"
        Me.lblHelpBonus.Size = New System.Drawing.Size(361, 242)
        Me.lblHelpBonus.TabIndex = 0
        Me.lblHelpBonus.Text = resources.GetString("lblHelpBonus.Text")
        Me.lblHelpBonus.Visible = False
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(244, 254)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(133, 31)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back to Game"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(20, 11)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(111, 29)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(137, 11)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(111, 29)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lblAbout
        '
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAbout.Location = New System.Drawing.Point(17, 50)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(207, 65)
        Me.lblAbout.TabIndex = 5
        Me.lblAbout.Text = "Wheel of Fortune" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Created by: Georgia Patten" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date: May 8th, 2017"
        Me.lblAbout.Visible = False
        '
        'frmHelpBonus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(388, 294)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblHelpBonus)
        Me.Name = "frmHelpBonus"
        Me.Text = "HELP!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHelpBonus As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents lblAbout As System.Windows.Forms.Label
End Class
