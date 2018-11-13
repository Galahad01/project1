<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Rotor
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
        Me.chclaim = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnavailable = New System.Windows.Forms.Button()
        Me.btnsearch_active = New System.Windows.Forms.Button()
        Me.btnsearch_rotor = New System.Windows.Forms.Button()
        Me.chactive = New System.Windows.Forms.CheckBox()
        Me.chavailable = New System.Windows.Forms.CheckBox()
        Me.txtsearch_rotor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndelete_rotor = New System.Windows.Forms.Button()
        Me.btnedit_rotor = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.la_ray_sn = New System.Windows.Forms.Label()
        Me.txtnote_rotor = New System.Windows.Forms.TextBox()
        Me.txtdate_rotor = New System.Windows.Forms.TextBox()
        Me.txtname_rotor = New System.Windows.Forms.TextBox()
        Me.DataGrid_rotor = New System.Windows.Forms.DataGridView()
        Me.pic_rotor = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid_rotor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_rotor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chclaim
        '
        Me.chclaim.AutoSize = True
        Me.chclaim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chclaim.Location = New System.Drawing.Point(250, 14)
        Me.chclaim.Name = "chclaim"
        Me.chclaim.Size = New System.Drawing.Size(81, 28)
        Me.chclaim.TabIndex = 41
        Me.chclaim.Text = "ส่งเคลม"
        Me.chclaim.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chclaim)
        Me.GroupBox2.Controls.Add(Me.btnavailable)
        Me.GroupBox2.Controls.Add(Me.btnsearch_active)
        Me.GroupBox2.Controls.Add(Me.btnsearch_rotor)
        Me.GroupBox2.Controls.Add(Me.chactive)
        Me.GroupBox2.Controls.Add(Me.chavailable)
        Me.GroupBox2.Controls.Add(Me.txtsearch_rotor)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 126)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'btnavailable
        '
        Me.btnavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnavailable.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnavailable.Location = New System.Drawing.Point(119, 12)
        Me.btnavailable.Name = "btnavailable"
        Me.btnavailable.Size = New System.Drawing.Size(31, 32)
        Me.btnavailable.TabIndex = 25
        Me.btnavailable.UseVisualStyleBackColor = True
        '
        'btnsearch_active
        '
        Me.btnsearch_active.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch_active.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnsearch_active.Location = New System.Drawing.Point(5, 12)
        Me.btnsearch_active.Name = "btnsearch_active"
        Me.btnsearch_active.Size = New System.Drawing.Size(31, 32)
        Me.btnsearch_active.TabIndex = 25
        Me.btnsearch_active.UseVisualStyleBackColor = True
        '
        'btnsearch_rotor
        '
        Me.btnsearch_rotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch_rotor.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnsearch_rotor.Location = New System.Drawing.Point(214, 12)
        Me.btnsearch_rotor.Name = "btnsearch_rotor"
        Me.btnsearch_rotor.Size = New System.Drawing.Size(30, 31)
        Me.btnsearch_rotor.TabIndex = 39
        Me.btnsearch_rotor.UseVisualStyleBackColor = True
        '
        'chactive
        '
        Me.chactive.AutoSize = True
        Me.chactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chactive.Location = New System.Drawing.Point(42, 15)
        Me.chactive.Name = "chactive"
        Me.chactive.Size = New System.Drawing.Size(80, 28)
        Me.chactive.TabIndex = 23
        Me.chactive.Text = "Active"
        Me.chactive.UseVisualStyleBackColor = True
        '
        'chavailable
        '
        Me.chavailable.AutoSize = True
        Me.chavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chavailable.Location = New System.Drawing.Point(156, 14)
        Me.chavailable.Name = "chavailable"
        Me.chavailable.Size = New System.Drawing.Size(52, 28)
        Me.chavailable.TabIndex = 23
        Me.chavailable.Text = "ว่าง"
        Me.chavailable.UseVisualStyleBackColor = True
        '
        'txtsearch_rotor
        '
        Me.txtsearch_rotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_rotor.Location = New System.Drawing.Point(6, 78)
        Me.txtsearch_rotor.Name = "txtsearch_rotor"
        Me.txtsearch_rotor.Size = New System.Drawing.Size(222, 29)
        Me.txtsearch_rotor.TabIndex = 9
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
        'btndelete_rotor
        '
        Me.btndelete_rotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete_rotor.Location = New System.Drawing.Point(540, 221)
        Me.btndelete_rotor.Name = "btndelete_rotor"
        Me.btndelete_rotor.Size = New System.Drawing.Size(88, 30)
        Me.btndelete_rotor.TabIndex = 37
        Me.btndelete_rotor.Text = "Delete"
        Me.btndelete_rotor.UseVisualStyleBackColor = True
        '
        'btnedit_rotor
        '
        Me.btnedit_rotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit_rotor.Location = New System.Drawing.Point(540, 178)
        Me.btnedit_rotor.Name = "btnedit_rotor"
        Me.btnedit_rotor.Size = New System.Drawing.Size(88, 30)
        Me.btnedit_rotor.TabIndex = 38
        Me.btnedit_rotor.Text = "Update"
        Me.btnedit_rotor.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(540, 142)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(88, 30)
        Me.btnadd.TabIndex = 40
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(767, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "บันทึกลึกลับ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "วันส่งเคลม"
        '
        'la_ray_sn
        '
        Me.la_ray_sn.AutoSize = True
        Me.la_ray_sn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la_ray_sn.Location = New System.Drawing.Point(178, 7)
        Me.la_ray_sn.Name = "la_ray_sn"
        Me.la_ray_sn.Size = New System.Drawing.Size(91, 24)
        Me.la_ray_sn.TabIndex = 34
        Me.la_ray_sn.Text = "Rotor S/N"
        '
        'txtnote_rotor
        '
        Me.txtnote_rotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnote_rotor.Location = New System.Drawing.Point(634, 40)
        Me.txtnote_rotor.Multiline = True
        Me.txtnote_rotor.Name = "txtnote_rotor"
        Me.txtnote_rotor.Size = New System.Drawing.Size(350, 499)
        Me.txtnote_rotor.TabIndex = 29
        '
        'txtdate_rotor
        '
        Me.txtdate_rotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate_rotor.Location = New System.Drawing.Point(292, 50)
        Me.txtdate_rotor.Name = "txtdate_rotor"
        Me.txtdate_rotor.Size = New System.Drawing.Size(193, 29)
        Me.txtdate_rotor.TabIndex = 30
        '
        'txtname_rotor
        '
        Me.txtname_rotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname_rotor.Location = New System.Drawing.Point(292, 5)
        Me.txtname_rotor.Name = "txtname_rotor"
        Me.txtname_rotor.Size = New System.Drawing.Size(193, 29)
        Me.txtname_rotor.TabIndex = 32
        '
        'DataGrid_rotor
        '
        Me.DataGrid_rotor.AllowUserToAddRows = False
        Me.DataGrid_rotor.AllowUserToDeleteRows = False
        Me.DataGrid_rotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_rotor.Location = New System.Drawing.Point(9, 262)
        Me.DataGrid_rotor.Name = "DataGrid_rotor"
        Me.DataGrid_rotor.Size = New System.Drawing.Size(619, 277)
        Me.DataGrid_rotor.TabIndex = 28
        '
        'pic_rotor
        '
        Me.pic_rotor.Image = Global.Holostock.My.Resources.Resources.Rotor1
        Me.pic_rotor.Location = New System.Drawing.Point(9, 10)
        Me.pic_rotor.Name = "pic_rotor"
        Me.pic_rotor.Size = New System.Drawing.Size(164, 239)
        Me.pic_rotor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic_rotor.TabIndex = 43
        Me.pic_rotor.TabStop = False
        '
        'frm_Rotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 545)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btndelete_rotor)
        Me.Controls.Add(Me.btnedit_rotor)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.la_ray_sn)
        Me.Controls.Add(Me.txtnote_rotor)
        Me.Controls.Add(Me.txtdate_rotor)
        Me.Controls.Add(Me.txtname_rotor)
        Me.Controls.Add(Me.DataGrid_rotor)
        Me.Controls.Add(Me.pic_rotor)
        Me.Name = "frm_Rotor"
        Me.Text = "Rotor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGrid_rotor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_rotor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chclaim As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnsearch_active As Button
    Friend WithEvents chactive As CheckBox
    Friend WithEvents chavailable As CheckBox
    Friend WithEvents txtsearch_rotor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsearch_rotor As Button
    Friend WithEvents btndelete_rotor As Button
    Friend WithEvents btnedit_rotor As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents la_ray_sn As Label
    Friend WithEvents txtnote_rotor As TextBox
    Friend WithEvents txtdate_rotor As TextBox
    Friend WithEvents txtname_rotor As TextBox
    Friend WithEvents DataGrid_rotor As DataGridView
    Friend WithEvents pic_rotor As PictureBox
    Friend WithEvents btnavailable As Button
End Class
