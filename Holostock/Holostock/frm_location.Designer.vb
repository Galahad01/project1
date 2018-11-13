<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_location
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpic = New System.Windows.Forms.Button()
        Me.btndeletelocation = New System.Windows.Forms.Button()
        Me.btneditlocation = New System.Windows.Forms.Button()
        Me.btnlocationadd = New System.Windows.Forms.Button()
        Me.txtcontent = New System.Windows.Forms.TextBox()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.DataGrid_location = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsearch_stator = New System.Windows.Forms.Button()
        Me.btndelete_remote = New System.Windows.Forms.Button()
        Me.btnedit_remote = New System.Windows.Forms.Button()
        Me.btnremoteadd = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.txtremote = New System.Windows.Forms.TextBox()
        Me.DataGrid_remote = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid_location, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid_remote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnpic)
        Me.GroupBox1.Controls.Add(Me.btndeletelocation)
        Me.GroupBox1.Controls.Add(Me.btneditlocation)
        Me.GroupBox1.Controls.Add(Me.btnlocationadd)
        Me.GroupBox1.Controls.Add(Me.txtcontent)
        Me.GroupBox1.Controls.Add(Me.txtlocation)
        Me.GroupBox1.Controls.Add(Me.DataGrid_location)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 543)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Content"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Location"
        '
        'btnpic
        '
        Me.btnpic.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpic.Location = New System.Drawing.Point(35, 302)
        Me.btnpic.Name = "btnpic"
        Me.btnpic.Size = New System.Drawing.Size(88, 30)
        Me.btnpic.TabIndex = 41
        Me.btnpic.Text = "รูปภาพ"
        Me.btnpic.UseVisualStyleBackColor = True
        '
        'btndeletelocation
        '
        Me.btndeletelocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletelocation.Location = New System.Drawing.Point(370, 374)
        Me.btndeletelocation.Name = "btndeletelocation"
        Me.btndeletelocation.Size = New System.Drawing.Size(88, 30)
        Me.btndeletelocation.TabIndex = 41
        Me.btndeletelocation.Text = "Delete"
        Me.btndeletelocation.UseVisualStyleBackColor = True
        '
        'btneditlocation
        '
        Me.btneditlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditlocation.Location = New System.Drawing.Point(370, 338)
        Me.btneditlocation.Name = "btneditlocation"
        Me.btneditlocation.Size = New System.Drawing.Size(88, 30)
        Me.btneditlocation.TabIndex = 42
        Me.btneditlocation.Text = "Update"
        Me.btneditlocation.UseVisualStyleBackColor = True
        '
        'btnlocationadd
        '
        Me.btnlocationadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlocationadd.Location = New System.Drawing.Point(370, 302)
        Me.btnlocationadd.Name = "btnlocationadd"
        Me.btnlocationadd.Size = New System.Drawing.Size(88, 30)
        Me.btnlocationadd.TabIndex = 43
        Me.btnlocationadd.Text = "Add"
        Me.btnlocationadd.UseVisualStyleBackColor = True
        '
        'txtcontent
        '
        Me.txtcontent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontent.Location = New System.Drawing.Point(159, 372)
        Me.txtcontent.Multiline = True
        Me.txtcontent.Name = "txtcontent"
        Me.txtcontent.Size = New System.Drawing.Size(182, 32)
        Me.txtcontent.TabIndex = 1
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(159, 302)
        Me.txtlocation.Multiline = True
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(182, 32)
        Me.txtlocation.TabIndex = 1
        '
        'DataGrid_location
        '
        Me.DataGrid_location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_location.Location = New System.Drawing.Point(15, 9)
        Me.DataGrid_location.Name = "DataGrid_location"
        Me.DataGrid_location.Size = New System.Drawing.Size(464, 260)
        Me.DataGrid_location.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnsearch_stator)
        Me.GroupBox2.Controls.Add(Me.btndelete_remote)
        Me.GroupBox2.Controls.Add(Me.btnedit_remote)
        Me.GroupBox2.Controls.Add(Me.btnremoteadd)
        Me.GroupBox2.Controls.Add(Me.txtsearch)
        Me.GroupBox2.Controls.Add(Me.txtremote)
        Me.GroupBox2.Controls.Add(Me.DataGrid_remote)
        Me.GroupBox2.Location = New System.Drawing.Point(504, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 543)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnsearch_stator
        '
        Me.btnsearch_stator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch_stator.Image = Global.Holostock.My.Resources.Resources.icons8_google_web_search_64
        Me.btnsearch_stator.Location = New System.Drawing.Point(260, 121)
        Me.btnsearch_stator.Name = "btnsearch_stator"
        Me.btnsearch_stator.Size = New System.Drawing.Size(39, 37)
        Me.btnsearch_stator.TabIndex = 54
        Me.btnsearch_stator.UseVisualStyleBackColor = True
        '
        'btndelete_remote
        '
        Me.btndelete_remote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete_remote.Location = New System.Drawing.Point(368, 156)
        Me.btndelete_remote.Name = "btndelete_remote"
        Me.btndelete_remote.Size = New System.Drawing.Size(88, 30)
        Me.btndelete_remote.TabIndex = 41
        Me.btndelete_remote.Text = "Delete"
        Me.btndelete_remote.UseVisualStyleBackColor = True
        '
        'btnedit_remote
        '
        Me.btnedit_remote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit_remote.Location = New System.Drawing.Point(368, 113)
        Me.btnedit_remote.Name = "btnedit_remote"
        Me.btnedit_remote.Size = New System.Drawing.Size(88, 30)
        Me.btnedit_remote.TabIndex = 42
        Me.btnedit_remote.Text = "Update"
        Me.btnedit_remote.UseVisualStyleBackColor = True
        '
        'btnremoteadd
        '
        Me.btnremoteadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremoteadd.Location = New System.Drawing.Point(368, 67)
        Me.btnremoteadd.Name = "btnremoteadd"
        Me.btnremoteadd.Size = New System.Drawing.Size(88, 30)
        Me.btnremoteadd.TabIndex = 43
        Me.btnremoteadd.Text = "Add"
        Me.btnremoteadd.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(72, 126)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(182, 32)
        Me.txtsearch.TabIndex = 1
        '
        'txtremote
        '
        Me.txtremote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremote.Location = New System.Drawing.Point(72, 181)
        Me.txtremote.Multiline = True
        Me.txtremote.Name = "txtremote"
        Me.txtremote.Size = New System.Drawing.Size(182, 32)
        Me.txtremote.TabIndex = 1
        '
        'DataGrid_remote
        '
        Me.DataGrid_remote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_remote.Location = New System.Drawing.Point(6, 273)
        Me.DataGrid_remote.Name = "DataGrid_remote"
        Me.DataGrid_remote.Size = New System.Drawing.Size(472, 264)
        Me.DataGrid_remote.TabIndex = 0
        '
        'frm_location
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 545)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_location"
        Me.Text = "frm_location"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid_location, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGrid_remote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGrid_location As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGrid_remote As DataGridView
    Friend WithEvents txtcontent As TextBox
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents txtremote As TextBox
    Friend WithEvents btndeletelocation As Button
    Friend WithEvents btneditlocation As Button
    Friend WithEvents btnlocationadd As Button
    Friend WithEvents btndelete_remote As Button
    Friend WithEvents btnedit_remote As Button
    Friend WithEvents btnremoteadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsearch_stator As Button
    Friend WithEvents btnpic As Button
End Class
