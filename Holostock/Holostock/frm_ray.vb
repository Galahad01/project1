Imports System.Data.OleDb
Imports System.Data

Public Class frm_ray
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

    Private Sub refresh_datagried()
        acc = "select * from Ray"
        DataGridView_ray.DataSource = cmd_execuTodatatable()
        '  change_alldatagrid_head()
    End Sub

    '  Friend Sub change_column_datagrid(datagrid As DataGridView, header() As String)  'เปลี่ยนหัว datagridview เป้นภาษาไทย
    '  Dim datagrid_total As Integer = datagrid.Columns.Count
    ' For i As Integer = 0 To datagrid_total - 1
    '          datagrid.Columns(i).HeaderText = header(i)
    '  Next
    '   End Sub

    '  Private Sub change_alldatagrid_head()
    '  Dim header() As String = {"หมายเลข ID"} 'ต้องใส่ให้ครบนะ 
    '      change_column_datagrid(DataGridView_ray, header)
    '  End Sub
    Private Sub frm_ray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_datagried()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        acc = "select count(*) from Ray where Ray_Number='" & txtname.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("จะพิมซ้ำอาไรหนักหนาจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname.Clear()
            txttype.Clear()
            txtdate.Clear()
            txtnote.Clear()
            txtname.Select()
            Return

        End If

        cmd = New OleDbCommand("insert into Ray(Ray_Number,Type,ray_active,ray_available,ray_claim,Date_claim,ray_note)values('" & txtname.Text & "' ,'" & txttype.Text & "' ,'" & chactive.CheckState & "','" & txt_chrayavailable.CheckState & "','" & chclaim1.CheckState & "','" & txtdate.Text & "','" & txtnote.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("บันทึกแล้วนะจ๊ะ", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtname.Clear()
        txttype.Clear()
        txtnote.Clear()
        txtdate.Clear()
        refresh_datagried()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        cmd = New OleDbCommand("Delete from Ray where Ray_ID=@Ray_ID", cn)
        With cmd
            .Parameters.Add("Ray_ID", OleDbType.Integer).Value = DataGridView_ray.CurrentRow.Cells(0).Value
            .ExecuteNonQuery()
        End With
        cn.Close()
        MessageBox.Show("จะลบแน่นะจ๊ะ", "!!!!!!!!!!!!!!!!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refresh_datagried()


    End Sub

    Private Sub DataGridView_ray_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ray.CellClick

        Using cmd = New OleDbCommand("Select * from Ray where Ray_ID=@Ray_ID", cn)
            cmd.Parameters.Add("Ray_ID", OleDbType.Integer).Value = DataGridView_ray.CurrentRow.Cells(0).Value

            Using rd As OleDbDataReader = cmd.ExecuteReader
                If rd.Read Then
                    txtname.Text = rd.Item(1)
                    txttype.Text = rd.Item(2)
                    chactive.Checked = rd.Item(3)
                    txt_chrayavailable.Checked = rd.Item(4)
                    chclaim1.Checked = rd.Item(5)
                    txtdate.Text = rd.Item(6).ToString
                    txtnote.Text = rd.Item(7)
                End If


            End Using
        End Using
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        Using cmd = New OleDbCommand("Update Ray Set Ray_Number='" & txtname.Text & "',Type='" & txttype.Text & "',ray_active='" & chactive.CheckState & "',ray_available='" & txt_chrayavailable.CheckState & "',ray_claim='" & chclaim1.CheckState & "',Date_claim='" & txtdate.Text & "',ray_note='" & txtnote.Text & "' Where Ray_ID=@Ray_ID", cn)

            cmd.Parameters.Add("Ray_ID", OleDbType.Integer).Value = DataGridView_ray.CurrentRow.Cells(0).Value
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update สำเร็จ", "up up up up data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()
            refresh_datagried()
        End Using
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        acc = "select Ray_ID,Ray_Number,Ray_Number,Type,ray_active,ray_available,ray_claim,Date_claim,ray_note from Ray where type like '%" & txtsearch.Text & "%' or Ray_Number like '%" & txtsearch.Text & "%'"
        DataGridView_ray.DataSource = cmd_execuTodatatable()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        acc = "select Ray_ID,Ray_Number,Type,ray_active,ray_available,ray_claim,Date_claim,ray_note from Ray where ray_claim like '%" & chclaim1.CheckState & "%'"
        DataGridView_ray.DataSource = cmd_execuTodatatable()


    End Sub

    Private Sub btnsearch_active_Click(sender As Object, e As EventArgs) Handles btnsearch_active.Click
        acc = "select Ray_ID,Ray_Number,Type,ray_active,ray_available,ray_claim,Date_claim,ray_note from Ray where ray_active like '%" & chactive.CheckState & "%'"
        DataGridView_ray.DataSource = cmd_execuTodatatable()
    End Sub

    Private Sub btnrayavailable_Click(sender As Object, e As EventArgs) Handles btnrayavailable.Click
        acc = "select Ray_ID,Ray_Number,Type,ray_active,ray_available,ray_claim,Date_claim,ray_note from Ray where ray_available like '%" & txt_chrayavailable.CheckState & "%'"
        DataGridView_ray.DataSource = cmd_execuTodatatable()
    End Sub
End Class