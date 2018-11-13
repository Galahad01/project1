<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_picturelocation
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
        Me.picBild = New System.Windows.Forms.PictureBox()
        Me.btnupload = New System.Windows.Forms.Button()
        Me.GroupBox_Zoom = New System.Windows.Forms.GroupBox()
        Me.rdProgramm = New System.Windows.Forms.RadioButton()
        Me.rdOriginal = New System.Windows.Forms.RadioButton()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cbDateien = New System.Windows.Forms.ComboBox()
        CType(Me.picBild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Zoom.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBild
        '
        Me.picBild.Location = New System.Drawing.Point(12, 81)
        Me.picBild.Name = "picBild"
        Me.picBild.Size = New System.Drawing.Size(662, 419)
        Me.picBild.TabIndex = 0
        Me.picBild.TabStop = False
        '
        'btnupload
        '
        Me.btnupload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupload.Location = New System.Drawing.Point(12, 24)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(91, 32)
        Me.btnupload.TabIndex = 1
        Me.btnupload.Text = "โหลดภาพ"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'GroupBox_Zoom
        '
        Me.GroupBox_Zoom.Controls.Add(Me.rdProgramm)
        Me.GroupBox_Zoom.Controls.Add(Me.rdOriginal)
        Me.GroupBox_Zoom.Location = New System.Drawing.Point(439, 12)
        Me.GroupBox_Zoom.Name = "GroupBox_Zoom"
        Me.GroupBox_Zoom.Size = New System.Drawing.Size(96, 63)
        Me.GroupBox_Zoom.TabIndex = 2
        Me.GroupBox_Zoom.TabStop = False
        '
        'rdProgramm
        '
        Me.rdProgramm.AutoSize = True
        Me.rdProgramm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdProgramm.Location = New System.Drawing.Point(6, 12)
        Me.rdProgramm.Name = "rdProgramm"
        Me.rdProgramm.Size = New System.Drawing.Size(68, 24)
        Me.rdProgramm.TabIndex = 1
        Me.rdProgramm.TabStop = True
        Me.rdProgramm.Text = "ซูมเข้า"
        Me.rdProgramm.UseVisualStyleBackColor = True
        '
        'rdOriginal
        '
        Me.rdOriginal.AutoSize = True
        Me.rdOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOriginal.Location = New System.Drawing.Point(6, 33)
        Me.rdOriginal.Name = "rdOriginal"
        Me.rdOriginal.Size = New System.Drawing.Size(71, 24)
        Me.rdOriginal.TabIndex = 0
        Me.rdOriginal.TabStop = True
        Me.rdOriginal.Text = "ซูมออก"
        Me.rdOriginal.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(245, 24)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(91, 32)
        Me.cmdBack.TabIndex = 1
        Me.cmdBack.Text = "<"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(342, 24)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(91, 32)
        Me.cmdNext.TabIndex = 1
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cbDateien
        '
        Me.cbDateien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDateien.FormattingEnabled = True
        Me.cbDateien.Location = New System.Drawing.Point(110, 26)
        Me.cbDateien.Name = "cbDateien"
        Me.cbDateien.Size = New System.Drawing.Size(121, 28)
        Me.cbDateien.TabIndex = 3
        '
        'frm_picturelocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(685, 513)
        Me.Controls.Add(Me.cbDateien)
        Me.Controls.Add(Me.GroupBox_Zoom)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.btnupload)
        Me.Controls.Add(Me.picBild)
        Me.Name = "frm_picturelocation"
        Me.Text = "frm_picturelocation"
        CType(Me.picBild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Zoom.ResumeLayout(False)
        Me.GroupBox_Zoom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBild As PictureBox
    Friend WithEvents btnupload As Button
    Friend WithEvents GroupBox_Zoom As GroupBox
    Friend WithEvents rdProgramm As RadioButton
    Friend WithEvents rdOriginal As RadioButton
    Friend WithEvents cmdBack As Button
    Friend WithEvents cmdNext As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cbDateien As ComboBox
End Class
