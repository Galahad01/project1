<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabbar
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
        Me.tab_panal = New System.Windows.Forms.Panel()
        Me.btnsmall = New System.Windows.Forms.Button()
        Me.btnlocation = New System.Windows.Forms.Button()
        Me.btnstator = New System.Windows.Forms.Button()
        Me.btnrotor = New System.Windows.Forms.Button()
        Me.btnactive = New System.Windows.Forms.Button()
        Me.btnray = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_main = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tab_panal.SuspendLayout()
        Me.Panel_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_panal
        '
        Me.tab_panal.BackColor = System.Drawing.Color.Transparent
        Me.tab_panal.BackgroundImage = Global.Holostock.My.Resources.Resources.passwords_back
        Me.tab_panal.Controls.Add(Me.btnsmall)
        Me.tab_panal.Controls.Add(Me.btnlocation)
        Me.tab_panal.Controls.Add(Me.btnstator)
        Me.tab_panal.Controls.Add(Me.btnrotor)
        Me.tab_panal.Controls.Add(Me.btnactive)
        Me.tab_panal.Controls.Add(Me.btnray)
        Me.tab_panal.Controls.Add(Me.Label1)
        Me.tab_panal.Location = New System.Drawing.Point(12, 12)
        Me.tab_panal.Name = "tab_panal"
        Me.tab_panal.Size = New System.Drawing.Size(145, 452)
        Me.tab_panal.TabIndex = 0
        '
        'btnsmall
        '
        Me.btnsmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsmall.Location = New System.Drawing.Point(3, 366)
        Me.btnsmall.Name = "btnsmall"
        Me.btnsmall.Size = New System.Drawing.Size(139, 28)
        Me.btnsmall.TabIndex = 1
        Me.btnsmall.Text = "ซ่อน"
        Me.btnsmall.UseVisualStyleBackColor = True
        '
        'btnlocation
        '
        Me.btnlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlocation.Location = New System.Drawing.Point(3, 247)
        Me.btnlocation.Name = "btnlocation"
        Me.btnlocation.Size = New System.Drawing.Size(139, 103)
        Me.btnlocation.TabIndex = 1
        Me.btnlocation.Text = "สถานที่, รีโมท, ภาพที่ใส่"
        Me.btnlocation.UseVisualStyleBackColor = True
        '
        'btnstator
        '
        Me.btnstator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstator.Location = New System.Drawing.Point(3, 203)
        Me.btnstator.Name = "btnstator"
        Me.btnstator.Size = New System.Drawing.Size(139, 28)
        Me.btnstator.TabIndex = 1
        Me.btnstator.Text = "สเตเตอร์"
        Me.btnstator.UseVisualStyleBackColor = True
        '
        'btnrotor
        '
        Me.btnrotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrotor.Location = New System.Drawing.Point(3, 158)
        Me.btnrotor.Name = "btnrotor"
        Me.btnrotor.Size = New System.Drawing.Size(139, 28)
        Me.btnrotor.TabIndex = 1
        Me.btnrotor.Text = "โรเตอร์"
        Me.btnrotor.UseVisualStyleBackColor = True
        '
        'btnactive
        '
        Me.btnactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactive.ForeColor = System.Drawing.Color.Maroon
        Me.btnactive.Location = New System.Drawing.Point(3, 65)
        Me.btnactive.Name = "btnactive"
        Me.btnactive.Size = New System.Drawing.Size(139, 28)
        Me.btnactive.TabIndex = 1
        Me.btnactive.Text = "ติดตั้ง"
        Me.btnactive.UseVisualStyleBackColor = True
        '
        'btnray
        '
        Me.btnray.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnray.Location = New System.Drawing.Point(3, 110)
        Me.btnray.Name = "btnray"
        Me.btnray.Size = New System.Drawing.Size(139, 28)
        Me.btnray.TabIndex = 1
        Me.btnray.Text = "เรย์"
        Me.btnray.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HYPERVSN"
        '
        'Panel_main
        '
        Me.Panel_main.AutoSize = True
        Me.Panel_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_main.BackColor = System.Drawing.Color.DarkGray
        Me.Panel_main.Controls.Add(Me.Label2)
        Me.Panel_main.Location = New System.Drawing.Point(164, 12)
        Me.Panel_main.Name = "Panel_main"
        Me.Panel_main.Size = New System.Drawing.Size(670, 501)
        Me.Panel_main.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(573, 488)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Power by Galahad"
        '
        'Tabbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(832, 513)
        Me.Controls.Add(Me.Panel_main)
        Me.Controls.Add(Me.tab_panal)
        Me.MinimizeBox = False
        Me.Name = "Tabbar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabbar"
        Me.tab_panal.ResumeLayout(False)
        Me.tab_panal.PerformLayout()
        Me.Panel_main.ResumeLayout(False)
        Me.Panel_main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tab_panal As Panel
    Friend WithEvents btnray As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_main As Panel
    Friend WithEvents btnsmall As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnrotor As Button
    Friend WithEvents btnstator As Button
    Friend WithEvents btnlocation As Button
    Friend WithEvents btnactive As Button
End Class
