<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHelp
        '
        Me.lblHelp.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHelp.Location = New System.Drawing.Point(31, 20)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(374, 496)
        Me.lblHelp.TabIndex = 0
        Me.lblHelp.Text = resources.GetString("lblHelp.Text")
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(272, 519)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(133, 31)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back to Game"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(442, 555)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblHelp)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Name = "frmHelp"
        Me.Text = "Help"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
