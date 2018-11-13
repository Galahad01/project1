Imports System.Data.OleDb
Imports System.Data

Public Class frm_picturelocation
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\39667\Desktop\Setvbkingpower\Hologramdbfirst003.accdb")
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim rd As OleDbDataReader
    Dim acc As String = ""

    Friend Sub connect()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

        Catch ex As Exception
            MsgBox("ต่อฐานข้อมูลไม่ติดนะฮ่ะ")
        End Try
    End Sub

    Friend Function cmd_executeNoquery()
        connect()
        cmd = New OleDbCommand(acc, cn)
        Return cmd.ExecuteNonQuery

    End Function

    Friend Function cmd_executeScalar()
        connect()
        cmd = New OleDbCommand(acc, cn)
        Return cmd.ExecuteScalar

    End Function

    Friend Function cmd_execuTodatatable()
        connect()
        da = New OleDbDataAdapter(acc, cn)
        ds = New DataSet
        da.Fill(ds, "table") ' ระวังถ้าตารางไม่แสดงคือ ช่องไฟตรง วงเล็บออกมามากเกินไป
        Return ds.Tables("table")

    End Function
    Private Sub cbDateien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDateien.SelectedIndexChanged
        picBild.Image = Image.FromFile(cbDateien.Items(cbDateien.SelectedIndex))
    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        ' connect()
        '  Using cmd = New OleDbCommand("Update Location Set holo_pic = PictureBox_location   Where Location_ID=@Location_ID", cn)

        'cmd.Parameters.Add("Location_ID", OleDbType.Integer).Value = PictureBox_location
        'cmd.ExecuteNonQuery()
        'MessageBox.Show("Update สำเร็จ", "up up up up data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'cn.Close()

        ' End Using
        Dim antw As DialogResult
        antw = OpenFileDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            For Each element As String In OpenFileDialog1.FileNames
                cbDateien.Items.Add(element)
            Next
            cbDateien.SelectedIndex = 0
        End If


    End Sub

    Private Sub rdOriginal_CheckedChanged(sender As Object, e As EventArgs) Handles rdOriginal.CheckedChanged
        If rdProgramm.Checked = True Then
            picBild.SizeMode = PictureBoxSizeMode.Zoom
        ElseIf rdOriginal.Checked = True Then
            picBild.SizeMode = PictureBoxSizeMode.AutoSize
        End If
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        If cbDateien.SelectedIndex <> 0 And cbDateien.SelectedIndex <> -1 Then
            cbDateien.SelectedIndex -= 1
        End If
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If cbDateien.SelectedIndex <> cbDateien.Items.Count - 1 And cbDateien.SelectedIndex <> -1 Then
            cbDateien.SelectedIndex += 1
        End If
    End Sub
End Class