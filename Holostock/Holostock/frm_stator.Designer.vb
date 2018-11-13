<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stator
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
        Me.sta_chclaim = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sta_chactive = New System.Windows.Forms.CheckBox()
        Me.sta_chavailable = New System.Windows.Forms.CheckBox()
        Me.txtsearch_stator = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndelete_stator = New System.Windows.Forms.Button()
        Me.btnedit_stator = New System.Windows.Forms.Button()
        Me.btnadd_stator = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.la_ray_sn = New System.Windows.Forms.Label()
        Me.txtnote_stator = New System.Windows.Forms.TextBox()
        Me.txtdate_stator = New System.Windows.Forms.TextBox()
        Me.txtname_stator = New System.Windows.Forms.TextBox()
        Me.DataGrid_stator = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnavailable = New System.Windows.Forms.Button()
        Me.btnsearch_active = New System.Windows.Forms.Button()
        Me.btnsearch_stator = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid_stator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sta_chclaim
        '
        Me.sta_chclaim.AutoSize = True
        Me.sta_chclaim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sta_chclaim.Location = New System.Drawing.Point(248, 11)
        Me.sta_chclaim.Name = "sta_chclaim"
        Me.sta_chclaim.Size = New System.Drawing.Size(81, 28)
        Me.sta_chclaim.TabIndex = 55
        Me.sta_chclaim.Text = "ส่งเคลม"
        Me.sta_chclaim.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sta_chclaim)
        Me.GroupBox2.Controls.Add(Me.btnavailable)
        Me.GroupBox2.Controls.Add(Me.btnsearch_active)
        Me.GroupBox2.Controls.Add(Me.btnsearch_stator)
        Me.GroupBox2.Controls.Add(Me.sta_chactive)
        Me.GroupBox2.Controls.Add(Me.sta_chavailable)
        Me.GroupBox2.Controls.Add(Me.txtsearch_stator)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 126)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'sta_chactive
        '
        Me.sta_chactive.AutoSize = True
        Me.sta_chactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sta_chactive.Location = New System.Drawing.Point(45, 12)
        Me.sta_chactive.Name = "sta_chactive"
        Me.sta_chactive.Size = New System.Drawing.Size(80, 28)
        Me.sta_chactive.TabIndex = 23
        Me.sta_chactive.Text = "Active"
        Me.sta_chactive.UseVisualStyleBackColor = True
        '
        'sta_chavailable
        '
        Me.sta_chavailable.AutoSize = True
        Me.sta_chavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sta_chavailable.Location = New System.Drawing.Point(155, 12)
        Me.sta_chavailable.Name = "sta_chavailable"
        Me.sta_chavailable.Size = New System.Drawing.Size(52, 28)
        Me.sta_chavailable.TabIndex = 23
        Me.sta_chavailable.Text = "ว่าง"
        Me.sta_chavailable.UseVisualStyleBackColor = True
        '
        'txtsearch_stator
        '
        Me.txtsearch_stator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_stator.Location = New System.Drawing.Point(6, 78)
        Me.txtsearch_stator.Name = "txtsearch_stator"
        Me.txtsearch_stator.Size = New System.Drawing.Size(222, 29)
        Me.txtsearch_stator.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ค้นหา"
        '
        'btndelete_stator
        '
        Me.btndelete_stator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete_stator.Location = New System.Drawing.Point(540, 221)
        Me.btndelete_stator.Name = "btndelete_stator"
        Me.btndelete_stator.Size = New System.Drawing.Size(88, 30)
        Me.btndelete_stator.TabIndex = 51
        Me.btndelete_stator.Text = "Delete"
        Me.btndelete_stator.UseVisualStyleBackColor = True
        '
        'btnedit_stator
        '
        Me.btnedit_stator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit_stator.Location = New System.Drawing.Point(540, 178)
        Me.btnedit_stator.Name = "btnedit_stator"
        Me.btnedit_stator.Size = New System.Drawing.Size(88, 30)
        Me.btnedit_stator.TabIndex = 52
        Me.btnedit_stator.Text = "Update"
        Me.btnedit_stator.UseVisualStyleBackColor = True
        '
        'btnadd_stator
        '
        Me.btnadd_stator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd_stator.Location = New System.Drawing.Point(540, 142)
        Me.btnadd_stator.Name = "btnadd_stator"
        Me.btnadd_stator.Size = New System.Drawing.Size(88, 30)
        Me.btnadd_stator.TabIndex = 54
        Me.btnadd_stator.Text = "Add"
        Me.btnadd_stator.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(767, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 24)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "บันทึกลึกลับ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "วันส่งเคลม"
        '
        'la_ray_sn
        '
        Me.la_ray_sn.AutoSize = True
        Me.la_ray_sn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la_ray_sn.Location = New System.Drawing.Point(178, 7)
        Me.la_ray_sn.Name = "la_ray_sn"
        Me.la_ray_sn.Size = New System.Drawing.Size(93, 24)
        Me.la_ray_sn.TabIndex = 48
        Me.la_ray_sn.Text = "Stator S/N"
        '
        'txtnote_stator
        '
        Me.txtnote_stator.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnote_stator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnote_stator.Location = New System.Drawing.Point(634, 40)
        Me.txtnote_stator.Multiline = True
        Me.txtnote_stator.Name = "txtnote_stator"
        Me.txtnote_stator.Size = New System.Drawing.Size(350, 499)
        Me.txtnote_stator.TabIndex = 45
        '
        'txtdate_stator
        '
        Me.txtdate_stator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate_stator.Location = New System.Drawing.Point(292, 50)
        Me.txtdate_stator.Name = "txtdate_stator"
        Me.txtdate_stator.Size = New System.Drawing.Size(193, 29)
        Me.txtdate_stator.TabIndex = 46
        '
        'txtname_stator
        '
        Me.txtname_stator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname_stator.Location = New System.Drawing.Point(292, 5)
        Me.txtname_stator.Name = "txtname_stator"
        Me.txtname_stator.Size = New System.Drawing.Size(193, 29)
        Me.txtname_stator.TabIndex = 47
        '
        'DataGrid_stator
        '
        Me.DataGrid_stator.AllowUserToAddRows = False
        Me.DataGrid_stator.AllowUserToDeleteRows = False
        Me.DataGrid_stator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_stator.Location = New System.Drawing.Point(9, 262)
        Me.DataGrid_stator.Name = "DataGrid_stator"
        Me.DataGrid_stator.ReadOnly = True
        Me.DataGrid_stator.Size = New System.Drawing.Size(619, 277)
        Me.DataGrid_stator.TabIndex = 44
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Holostock.My.Resources.Resources.stator1
        Me.PictureBox1.Location = New System.Drawing.Point(9, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'btnavailable
        '
        Me.btnavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnavailable.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnavailable.Location = New System.Drawing.Point(120, 9)
        Me.btnavailable.Name = "btnavailable"
        Me.btnavailable.Size = New System.Drawing.Size(29, 32)
        Me.btnavailable.TabIndex = 25
        Me.btnavailable.UseVisualStyleBackColor = True
        '
        'btnsearch_active
        '
        Me.btnsearch_active.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch_active.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnsearch_active.Location = New System.Drawing.Point(10, 9)
        Me.btnsearch_active.Name = "btnsearch_active"
        Me.btnsearch_active.Size = New System.Drawing.Size(29, 32)
        Me.btnsearch_active.TabIndex = 25
        Me.btnsearch_active.UseVisualStyleBackColor = True
        '
        'btnsearch_stator
        '
        Me.btnsearch_stator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch_stator.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnsearch_stator.Location = New System.Drawing.Point(213, 8)
        Me.btnsearch_stator.Name = "btnsearch_stator"
        Me.btnsearch_stator.Size = New System.Drawing.Size(29, 32)
        Me.btnsearch_stator.TabIndex = 53
        Me.btnsearch_stator.UseVisualStyleBackColor = True
        '
        'frm_stator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(990, 545)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btndelete_stator)
        Me.Controls.Add(Me.btnedit_stator)
        Me.Controls.Add(Me.btnadd_stator)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.la_ray_sn)
        Me.Controls.Add(Me.txtnote_stator)
        Me.Controls.Add(Me.txtdate_stator)
        Me.Controls.Add(Me.txtname_stator)
        Me.Controls.Add(Me.DataGrid_stator)
        Me.Name = "frm_stator"
        Me.Text = "frm_stator"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGrid_stator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sta_chclaim As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnsearch_active As Button
    Friend WithEvents sta_chactive As CheckBox
    Friend WithEvents sta_chavailable As CheckBox
    Friend WithEvents txtsearch_stator As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsearch_stator As Button
    Friend WithEvents btndelete_stator As Button
    Friend WithEvents btnedit_stator As Button
    Friend WithEvents btnadd_stator As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents la_ray_sn As Label
    Friend WithEvents txtnote_stator As TextBox
    Friend WithEvents txtdate_stator As TextBox
    Friend WithEvents txtname_stator As TextBox
    Friend WithEvents DataGrid_stator As DataGridView
    Friend WithEvents btnavailable As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
