<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container
        Me.tmr_ghost = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.tmr_jump = New System.Windows.Forms.Timer(Me.components)
        Me.black_block11 = New System.Windows.Forms.PictureBox
        Me.black_block10 = New System.Windows.Forms.PictureBox
        Me.black_block9 = New System.Windows.Forms.PictureBox
        Me.ghost2 = New System.Windows.Forms.PictureBox
        Me.ghost4 = New System.Windows.Forms.PictureBox
        Me.ghost3 = New System.Windows.Forms.PictureBox
        Me.ghost1 = New System.Windows.Forms.PictureBox
        Me.black_block8 = New System.Windows.Forms.PictureBox
        Me.black_block7 = New System.Windows.Forms.PictureBox
        Me.black_block6 = New System.Windows.Forms.PictureBox
        Me.black_block5 = New System.Windows.Forms.PictureBox
        Me.black_block4 = New System.Windows.Forms.PictureBox
        Me.black_block3 = New System.Windows.Forms.PictureBox
        Me.black_block2 = New System.Windows.Forms.PictureBox
        Me.black_block1 = New System.Windows.Forms.PictureBox
        CType(Me.black_block11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ghost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ghost4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ghost3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ghost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr_ghost
        '
        Me.tmr_ghost.Interval = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(448, 63)
        Me.ProgressBar1.TabIndex = 9
        Me.ProgressBar1.Value = 100
        '
        'tmr_jump
        '
        Me.tmr_jump.Interval = 1
        '
        'black_block11
        '
        Me.black_block11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block11.Location = New System.Drawing.Point(1025, 595)
        Me.black_block11.Name = "black_block11"
        Me.black_block11.Size = New System.Drawing.Size(155, 342)
        Me.black_block11.TabIndex = 19
        Me.black_block11.TabStop = False
        '
        'black_block10
        '
        Me.black_block10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block10.Location = New System.Drawing.Point(112, 582)
        Me.black_block10.Name = "black_block10"
        Me.black_block10.Size = New System.Drawing.Size(116, 355)
        Me.black_block10.TabIndex = 18
        Me.black_block10.TabStop = False
        '
        'black_block9
        '
        Me.black_block9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block9.Location = New System.Drawing.Point(-8, 332)
        Me.black_block9.Name = "black_block9"
        Me.black_block9.Size = New System.Drawing.Size(138, 605)
        Me.black_block9.TabIndex = 17
        Me.black_block9.TabStop = False
        '
        'ghost2
        '
        Me.ghost2.BackColor = System.Drawing.Color.Transparent
        Me.ghost2.Image = Global._________.My.Resources.Resources.ghost_left
        Me.ghost2.Location = New System.Drawing.Point(1348, 160)
        Me.ghost2.Name = "ghost2"
        Me.ghost2.Size = New System.Drawing.Size(55, 107)
        Me.ghost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ghost2.TabIndex = 12
        Me.ghost2.TabStop = False
        '
        'ghost4
        '
        Me.ghost4.BackColor = System.Drawing.Color.Transparent
        Me.ghost4.Image = Global._________.My.Resources.Resources.ghost_left
        Me.ghost4.Location = New System.Drawing.Point(1519, 201)
        Me.ghost4.Name = "ghost4"
        Me.ghost4.Size = New System.Drawing.Size(55, 107)
        Me.ghost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ghost4.TabIndex = 11
        Me.ghost4.TabStop = False
        '
        'ghost3
        '
        Me.ghost3.BackColor = System.Drawing.Color.Transparent
        Me.ghost3.Image = Global._________.My.Resources.Resources.ghost_left
        Me.ghost3.Location = New System.Drawing.Point(1430, 179)
        Me.ghost3.Name = "ghost3"
        Me.ghost3.Size = New System.Drawing.Size(55, 107)
        Me.ghost3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ghost3.TabIndex = 10
        Me.ghost3.TabStop = False
        '
        'ghost1
        '
        Me.ghost1.BackColor = System.Drawing.Color.Transparent
        Me.ghost1.Image = Global._________.My.Resources.Resources.ghost_left
        Me.ghost1.Location = New System.Drawing.Point(1252, 201)
        Me.ghost1.Name = "ghost1"
        Me.ghost1.Size = New System.Drawing.Size(55, 107)
        Me.ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ghost1.TabIndex = 8
        Me.ghost1.TabStop = False
        '
        'black_block8
        '
        Me.black_block8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block8.Location = New System.Drawing.Point(1137, 332)
        Me.black_block8.Name = "black_block8"
        Me.black_block8.Size = New System.Drawing.Size(416, 605)
        Me.black_block8.TabIndex = 7
        Me.black_block8.TabStop = False
        '
        'black_block7
        '
        Me.black_block7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block7.Location = New System.Drawing.Point(909, 582)
        Me.black_block7.Name = "black_block7"
        Me.black_block7.Size = New System.Drawing.Size(155, 355)
        Me.black_block7.TabIndex = 6
        Me.black_block7.TabStop = False
        '
        'black_block6
        '
        Me.black_block6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block6.Location = New System.Drawing.Point(758, 595)
        Me.black_block6.Name = "black_block6"
        Me.black_block6.Size = New System.Drawing.Size(155, 342)
        Me.black_block6.TabIndex = 5
        Me.black_block6.TabStop = False
        '
        'black_block5
        '
        Me.black_block5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block5.Location = New System.Drawing.Point(639, 574)
        Me.black_block5.Name = "black_block5"
        Me.black_block5.Size = New System.Drawing.Size(127, 363)
        Me.black_block5.TabIndex = 4
        Me.black_block5.TabStop = False
        '
        'black_block4
        '
        Me.black_block4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block4.Location = New System.Drawing.Point(532, 564)
        Me.black_block4.Name = "black_block4"
        Me.black_block4.Size = New System.Drawing.Size(116, 373)
        Me.black_block4.TabIndex = 3
        Me.black_block4.TabStop = False
        '
        'black_block3
        '
        Me.black_block3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block3.Location = New System.Drawing.Point(424, 595)
        Me.black_block3.Name = "black_block3"
        Me.black_block3.Size = New System.Drawing.Size(116, 342)
        Me.black_block3.TabIndex = 2
        Me.black_block3.TabStop = False
        '
        'black_block2
        '
        Me.black_block2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block2.Location = New System.Drawing.Point(312, 582)
        Me.black_block2.Name = "black_block2"
        Me.black_block2.Size = New System.Drawing.Size(116, 355)
        Me.black_block2.TabIndex = 1
        Me.black_block2.TabStop = False
        '
        'black_block1
        '
        Me.black_block1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block1.Location = New System.Drawing.Point(201, 595)
        Me.black_block1.Name = "black_block1"
        Me.black_block1.Size = New System.Drawing.Size(116, 342)
        Me.black_block1.TabIndex = 0
        Me.black_block1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1252, 745)
        Me.Controls.Add(Me.black_block11)
        Me.Controls.Add(Me.black_block10)
        Me.Controls.Add(Me.black_block9)
        Me.Controls.Add(Me.ghost2)
        Me.Controls.Add(Me.ghost4)
        Me.Controls.Add(Me.ghost3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ghost1)
        Me.Controls.Add(Me.black_block8)
        Me.Controls.Add(Me.black_block7)
        Me.Controls.Add(Me.black_block6)
        Me.Controls.Add(Me.black_block5)
        Me.Controls.Add(Me.black_block4)
        Me.Controls.Add(Me.black_block3)
        Me.Controls.Add(Me.black_block2)
        Me.Controls.Add(Me.black_block1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.black_block11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ghost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ghost4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ghost3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ghost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents black_block1 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block2 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block3 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block4 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block5 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block6 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block7 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block8 As System.Windows.Forms.PictureBox
    Friend WithEvents ghost1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmr_ghost As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ghost3 As System.Windows.Forms.PictureBox
    Friend WithEvents ghost4 As System.Windows.Forms.PictureBox
    Friend WithEvents ghost2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmr_jump As System.Windows.Forms.Timer
    Friend WithEvents black_block9 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block10 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block11 As System.Windows.Forms.PictureBox
End Class
