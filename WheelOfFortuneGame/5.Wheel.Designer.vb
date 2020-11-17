<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWheel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWheel))
        Me.imgWheel = New System.Windows.Forms.PictureBox()
        CType(Me.imgWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgWheel
        '
        Me.imgWheel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgWheel.Image = CType(resources.GetObject("imgWheel.Image"), System.Drawing.Image)
        Me.imgWheel.Location = New System.Drawing.Point(0, 0)
        Me.imgWheel.Name = "imgWheel"
        Me.imgWheel.Size = New System.Drawing.Size(788, 449)
        Me.imgWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgWheel.TabIndex = 0
        Me.imgWheel.TabStop = False
        '
        'frmWheel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(787, 449)
        Me.Controls.Add(Me.imgWheel)
        Me.DoubleBuffered = True
        Me.Name = "frmWheel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wheel"
        CType(Me.imgWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgWheel As System.Windows.Forms.PictureBox
End Class
