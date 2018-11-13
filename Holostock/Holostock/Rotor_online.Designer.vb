<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rotor_online
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
        Me.DataGridView_rotor_online = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView_rotor_online, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_rotor_online
        '
        Me.DataGridView_rotor_online.AllowUserToAddRows = False
        Me.DataGridView_rotor_online.AllowUserToDeleteRows = False
        Me.DataGridView_rotor_online.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_rotor_online.Location = New System.Drawing.Point(6, 36)
        Me.DataGridView_rotor_online.Name = "DataGridView_rotor_online"
        Me.DataGridView_rotor_online.ReadOnly = True
        Me.DataGridView_rotor_online.Size = New System.Drawing.Size(245, 258)
        Me.DataGridView_rotor_online.TabIndex = 0
        '
        'Rotor_online
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 297)
        Me.Controls.Add(Me.DataGridView_rotor_online)
        Me.Name = "Rotor_online"
        Me.Text = "frm_online"
        CType(Me.DataGridView_rotor_online, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_rotor_online As DataGridView
End Class
