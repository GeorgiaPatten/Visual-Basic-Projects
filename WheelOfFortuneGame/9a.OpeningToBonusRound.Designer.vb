<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoBonus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoBonus))
        Me.imgFinalSpin = New System.Windows.Forms.PictureBox()
        Me.tmrBonus = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgFinalSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgFinalSpin
        '
        Me.imgFinalSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgFinalSpin.Image = CType(resources.GetObject("imgFinalSpin.Image"), System.Drawing.Image)
        Me.imgFinalSpin.Location = New System.Drawing.Point(0, 1)
        Me.imgFinalSpin.Name = "imgFinalSpin"
        Me.imgFinalSpin.Size = New System.Drawing.Size(765, 483)
        Me.imgFinalSpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFinalSpin.TabIndex = 0
        Me.imgFinalSpin.TabStop = False
        '
        'tmrBonus
        '
        Me.tmrBonus.Interval = 2500
        '
        'frmVideoBonus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 482)
        Me.Controls.Add(Me.imgFinalSpin)
        Me.Name = "frmVideoBonus"
        Me.Text = "BonusVideo"
        CType(Me.imgFinalSpin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgFinalSpin As System.Windows.Forms.PictureBox
    Friend WithEvents tmrBonus As System.Windows.Forms.Timer
End Class
