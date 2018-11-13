Imports System.Data.OleDb
Imports System.Data

Public Class frm_location
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\39667\Desktop\Setvbkingpower\Hologramsdb.accdb")
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

    Private Sub refresh_datagried_location()
        acc = "select * from Location"
        DataGrid_location.DataSource = cmd_execuTodatatable()

    End Sub

    Private Sub refresh_datagried_remote()
        acc = "select * from Remote"
        DataGrid_remote.DataSource = cmd_execuTodatatable()

    End Sub

    Private Sub frm_location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_datagried_remote()
        refresh_datagried_location()
    End Sub

    Private Sub btnlocationadd_Click(sender As Object, e As EventArgs) Handles btnlocationadd.Click

        cmd = New OleDbCommand("insert into location(Location_name,Content)values('" & txtlocation.Text & "','" & txtcontent.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("บันทึกแล้วนะจ๊ะ", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtlocation.Clear()
        txtcontent.Clear()
        refresh_datagried_location()

    End Sub

    Private Sub btndeletelocation_Click(sender As Object, e As EventArgs) Handles btndeletelocation.Click
        cmd = New OleDbCommand("Delete from Location where Location_ID=@Location_ID", cn)
        With cmd
            .Parameters.Add("Location_ID", OleDbType.Integer).Value = DataGrid_location.CurrentRow.Cells(0).Value
            .ExecuteNonQuery()
        End With
        cn.Close()
        MessageBox.Show("จะลบแน่นะจ๊ะ", "!!!!!!!!!!!!!!!!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refresh_datagried_location()
    End Sub

    Private Sub DataGrid_location_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_location.CellClick

        Using cmd = New OleDbCommand("Select * from  Location where Location_ID=@Location_ID", cn)
            cmd.Parameters.Add("Location_ID", OleDbType.Integer).Value = DataGrid_location.CurrentRow.Cells(0).Value

            Using rd As OleDbDataReader = cmd.ExecuteReader
                If rd.Read Then
                    txtlocation.Text = rd.Item(1)
                    txtcontent.Text = rd.Item(2).ToString

                End If


            End Using
        End Using
    End Sub
    Private Sub btneditlocation_Click(sender As Object, e As EventArgs) Handles btneditlocation.Click
        Using cmd = New OleDbCommand("Update Location Set Location_name='" & txtlocation.Text & "',Content='" & txtcontent.Text & "' Where Location_ID=@Location_ID", cn)

            cmd.Parameters.Add("Location_ID", OleDbType.Integer).Value = DataGrid_location.CurrentRow.Cells(0).Value
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update สำเร็จ", "up up up up data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()
            refresh_datagried_location()
        End Using
    End Sub

    Private Sub btnremoteadd_Click(sender As Object, e As EventArgs) Handles btnremoteadd.Click

        acc = "select count(*) from Remote where Remote_number='" & txtremote.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("จะพิมซ้ำอาไรหนักหนาจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtremote.Clear()

            Return

        End If
        cmd = New OleDbCommand("insert into Remote(Remote_number)values('" & txtremote.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("บันทึกแล้วนะจ๊ะ", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtremote.Clear()
        refresh_datagried_remote()
    End Sub

    Private Sub btndelete_remote_Click(sender As Object, e As EventArgs) Handles btndelete_remote.Click
        cmd = New OleDbCommand("Delete from Remote where Remote_ID=@Remote_ID", cn)
        With cmd
            .Parameters.Add("Remote_ID", OleDbType.Integer).Value = DataGrid_remote.CurrentRow.Cells(0).Value
            .ExecuteNonQuery()
        End With
        cn.Close()
        MessageBox.Show("จะลบแน่นะจ๊ะ", "!!!!!!!!!!!!!!!!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refresh_datagried_remote()
    End Sub

    Private Sub btnedit_remote_Click(sender As Object, e As EventArgs) Handles btnedit_remote.Click

        Using cmd = New OleDbCommand("Update Remote Set Remote_number='" & txtremote.Text & "' Where Remote_ID=@Remote_ID", cn)

            cmd.Parameters.Add("Remote_ID", OleDbType.Integer).Value = DataGrid_remote.CurrentRow.Cells(0).Value
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update สำเร็จ", "up up up up data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()
            refresh_datagried_remote()
        End Using
    End Sub

    Private Sub DataGrid_remote_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_remote.CellClick
        Using cmd = New OleDbCommand("Select * from  Remote where Remote_ID=@Remote_ID", cn)
            cmd.Parameters.Add("Remote_ID", OleDbType.Integer).Value = DataGrid_remote.CurrentRow.Cells(0).Value

            Using rd As OleDbDataReader = cmd.ExecuteReader
                If rd.Read Then
                    txtremote.Text = rd.Item(1)


                End If


            End Using
        End Using
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        acc = "select Remote_ID,Remote_number from Remote where Remote_number like '%" & txtsearch.Text & "%'"
        DataGrid_remote.DataSource = cmd_execuTodatatable()
    End Sub

    Private Sub btnpic_Click(sender As Object, e As EventArgs) Handles btnpic.Click

        Dim box = New frm_picturelocation
        box.Show()

    End Sub
End Class