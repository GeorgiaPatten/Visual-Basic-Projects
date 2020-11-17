<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheck))
        Me.imgCheck = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDollarValue = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.imgSignature = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.imgCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgCheck
        '
        Me.imgCheck.Image = CType(resources.GetObject("imgCheck.Image"), System.Drawing.Image)
        Me.imgCheck.Location = New System.Drawing.Point(-2, -3)
        Me.imgCheck.Name = "imgCheck"
        Me.imgCheck.Size = New System.Drawing.Size(530, 265)
        Me.imgCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCheck.TabIndex = 0
        Me.imgCheck.TabStop = False
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(94, 90)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(282, 22)
        Me.lblName.TabIndex = 2
        '
        'lblDollarValue
        '
        Me.lblDollarValue.Location = New System.Drawing.Point(406, 94)
        Me.lblDollarValue.Name = "lblDollarValue"
        Me.lblDollarValue.Size = New System.Drawing.Size(88, 22)
        Me.lblDollarValue.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(308, 59)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(151, 18)
        Me.lblDate.TabIndex = 4
        '
        'lblNames
        '
        Me.lblNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNames.Location = New System.Drawing.Point(23, 45)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(148, 17)
        Me.lblNames.TabIndex = 6
        Me.lblNames.Text = "Georgia Patten"
        '
        'imgSignature
        '
        Me.imgSignature.Image = CType(resources.GetObject("imgSignature.Image"), System.Drawing.Image)
        Me.imgSignature.Location = New System.Drawing.Point(290, 156)
        Me.imgSignature.Name = "imgSignature"
        Me.imgSignature.Size = New System.Drawing.Size(204, 45)
        Me.imgSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSignature.TabIndex = 7
        Me.imgSignature.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Vineta BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CONGRATS"
        '
        'frmCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 255)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgSignature)
        Me.Controls.Add(Me.lblNames)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDollarValue)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgCheck)
        Me.Name = "frmCheck"
        Me.Text = "Check"
        CType(Me.imgCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgCheck As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDollarValue As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblNames As System.Windows.Forms.Label
    Friend WithEvents imgSignature As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
