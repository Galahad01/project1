<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ray
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.la_ray_sn = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtnote = New System.Windows.Forms.TextBox()
        Me.DataGridView_ray = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_chrayavailable = New System.Windows.Forms.CheckBox()
        Me.chclaim1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnrayavailable = New System.Windows.Forms.Button()
        Me.btnsearch_active = New System.Windows.Forms.Button()
        Me.chactive = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_ray, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Holostock.My.Resources.Resources.Ray2
        Me.PictureBox1.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(770, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "บันทึกลึกลับ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "วันส่งเคลม"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ray type"
        '
        'la_ray_sn
        '
        Me.la_ray_sn.AutoSize = True
        Me.la_ray_sn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la_ray_sn.Location = New System.Drawing.Point(181, 9)
        Me.la_ray_sn.Name = "la_ray_sn"
        Me.la_ray_sn.Size = New System.Drawing.Size(78, 24)
        Me.la_ray_sn.TabIndex = 14
        Me.la_ray_sn.Text = "Ray S/N"
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(295, 90)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(193, 29)
        Me.txtdate.TabIndex = 9
        '
        'txttype
        '
        Me.txttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.Location = New System.Drawing.Point(295, 47)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(52, 29)
        Me.txttype.TabIndex = 11
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(295, 7)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(193, 29)
        Me.txtname.TabIndex = 12
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(543, 219)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(88, 30)
        Me.btndelete.TabIndex = 19
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(543, 176)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(88, 30)
        Me.btnedit.TabIndex = 20
        Me.btnedit.Text = "Update"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnsearch.Location = New System.Drawing.Point(234, 12)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(25, 28)
        Me.btnsearch.TabIndex = 21
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(543, 140)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(88, 30)
        Me.btnadd.TabIndex = 22
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtnote
        '
        Me.txtnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnote.Location = New System.Drawing.Point(637, 42)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(350, 499)
        Me.txtnote.TabIndex = 8
        '
        'DataGridView_ray
        '
        Me.DataGridView_ray.AllowUserToAddRows = False
        Me.DataGridView_ray.AllowUserToDeleteRows = False
        Me.DataGridView_ray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ray.Location = New System.Drawing.Point(12, 264)
        Me.DataGridView_ray.Name = "DataGridView_ray"
        Me.DataGridView_ray.ReadOnly = True
        Me.DataGridView_ray.Size = New System.Drawing.Size(619, 277)
        Me.DataGridView_ray.TabIndex = 1
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(6, 78)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(222, 29)
        Me.txtsearch.TabIndex = 9
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
        'txt_chrayavailable
        '
        Me.txt_chrayavailable.AutoSize = True
        Me.txt_chrayavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chrayavailable.Location = New System.Drawing.Point(176, 12)
        Me.txt_chrayavailable.Name = "txt_chrayavailable"
        Me.txt_chrayavailable.Size = New System.Drawing.Size(52, 28)
        Me.txt_chrayavailable.TabIndex = 23
        Me.txt_chrayavailable.Text = "ว่าง"
        Me.txt_chrayavailable.UseVisualStyleBackColor = True
        '
        'chclaim1
        '
        Me.chclaim1.AutoSize = True
        Me.chclaim1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chclaim1.Location = New System.Drawing.Point(265, 13)
        Me.chclaim1.Name = "chclaim1"
        Me.chclaim1.Size = New System.Drawing.Size(81, 28)
        Me.chclaim1.TabIndex = 25
        Me.chclaim1.Text = "ส่งเคลม"
        Me.chclaim1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnrayavailable)
        Me.GroupBox2.Controls.Add(Me.btnsearch_active)
        Me.GroupBox2.Controls.Add(Me.chclaim1)
        Me.GroupBox2.Controls.Add(Me.chactive)
        Me.GroupBox2.Controls.Add(Me.txt_chrayavailable)
        Me.GroupBox2.Controls.Add(Me.btnsearch)
        Me.GroupBox2.Controls.Add(Me.txtsearch)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(185, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 133)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'btnrayavailable
        '
        Me.btnrayavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrayavailable.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnrayavailable.Location = New System.Drawing.Point(143, 14)
        Me.btnrayavailable.Name = "btnrayavailable"
        Me.btnrayavailable.Size = New System.Drawing.Size(27, 26)
        Me.btnrayavailable.TabIndex = 25
        Me.btnrayavailable.UseVisualStyleBackColor = True
        '
        'btnsearch_active
        '
        Me.btnsearch_active.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch_active.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnsearch_active.Location = New System.Drawing.Point(24, 12)
        Me.btnsearch_active.Name = "btnsearch_active"
        Me.btnsearch_active.Size = New System.Drawing.Size(27, 26)
        Me.btnsearch_active.TabIndex = 25
        Me.btnsearch_active.UseVisualStyleBackColor = True
        '
        'chactive
        '
        Me.chactive.AutoSize = True
        Me.chactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chactive.Location = New System.Drawing.Point(57, 12)
        Me.chactive.Name = "chactive"
        Me.chactive.Size = New System.Drawing.Size(80, 28)
        Me.chactive.TabIndex = 23
        Me.chactive.Text = "Active"
        Me.chactive.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(595, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'frm_ray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 545)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.la_ray_sn)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.DataGridView_ray)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_ray"
        Me.Text = "frm_ray"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_ray, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents la_ray_sn As Label
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txttype As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents txtnote As TextBox
    Friend WithEvents DataGridView_ray As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chclaim As RadioButton
    Friend WithEvents chold As RadioButton
    Friend WithEvents chnew As RadioButton
    Friend WithEvents txt_chrayavailable As CheckBox
    Friend WithEvents chclaim1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chactive As CheckBox
    Friend WithEvents btnsearch_active As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnrayavailable As Button
End Class
