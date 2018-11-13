Imports System.Data.OleDb
Imports System.Data

Public Class frm_stator

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
        acc = "select * from Stator"
        DataGrid_stator.DataSource = cmd_execuTodatatable()

    End Sub

    Private Sub frm_stator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_datagried()
    End Sub

    Private Sub btnadd_stator_Click(sender As Object, e As EventArgs) Handles btnadd_stator.Click
        acc = "select count(*) from Stator where Stator_Name='" & txtname_stator.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("จะพิมซ้ำอาไรหนักหนาจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname_stator.Clear()
            txtdate_stator.Clear()
            txtnote_stator.Clear()
            Return

        End If
        cmd = New OleDbCommand("insert into Stator(Stator_Name,stator_active,stator_available,stator_claim,Date_claim,stator_note)values('" & txtname_stator.Text & "','" & sta_chactive.CheckState & "','" & sta_chavailable.CheckState & "','" & sta_chclaim.CheckState & "','" & txtdate_stator.Text & "','" & txtnote_stator.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("บันทึกแล้วนะจ๊ะ", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtname_stator.Clear()
        txtnote_stator.Clear()
        txtdate_stator.Clear()
        refresh_datagried()


    End Sub

    Private Sub btndelete_stator_Click(sender As Object, e As EventArgs) Handles btndelete_stator.Click

        cmd = New OleDbCommand("Delete from Stator where Stator_ID=@Stator_ID", cn)
        With cmd
            .Parameters.Add("Stator_ID", OleDbType.Integer).Value = DataGrid_stator.CurrentRow.Cells(0).Value
            .ExecuteNonQuery()
        End With
        cn.Close()
        MessageBox.Show("จะลบแน่นะจ๊ะ", "!!!!!!!!!!!!!!!!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refresh_datagried()

    End Sub

    Private Sub DataGrid_stator_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_stator.CellClick

        Using cmd = New OleDbCommand("Select * from Stator where Stator_ID=@Stator_ID", cn)
            cmd.Parameters.Add("Stator_ID", OleDbType.Integer).Value = DataGrid_stator.CurrentRow.Cells(0).Value

            Using rd As OleDbDataReader = cmd.ExecuteReader
                If rd.Read Then
                    txtname_stator.Text = rd.Item(1)
                    sta_chactive.Checked = rd.Item(2)
                    sta_chavailable.Checked = rd.Item(3)
                    sta_chclaim.Checked = rd.Item(4)
                    txtdate_stator.Text = rd.Item(5).ToString
                    txtnote_stator.Text = rd.Item(6).ToString
                End If


            End Using
        End Using

    End Sub

    Private Sub btnedit_stator_Click(sender As Object, e As EventArgs) Handles btnedit_stator.Click

        Using cmd = New OleDbCommand("Update Stator Set Stator_Name='" & txtname_stator.Text & "',stator_active='" & sta_chactive.CheckState & "',stator_available='" & sta_chavailable.CheckState & "',stator_claim ='" & sta_chclaim.CheckState & "',Date_claim='" & txtdate_stator.Text & "',stator_note='" & txtnote_stator.Text & "' Where Stator_ID=@Stator_ID", cn)
            cmd.Parameters.Add("Stator_ID", OleDbType.Integer).Value = DataGrid_stator.CurrentRow.Cells(0).Value
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update สำเร็จ", "up up up up data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()
            refresh_datagried()
        End Using
    End Sub

    Private Sub txtsearch_stator_TextChanged(sender As Object, e As EventArgs) Handles txtsearch_stator.TextChanged
        acc = "select Stator_ID,Stator_Name,stator_active,stator_available,stator_claim,Date_claim,stator_note from Stator where Stator_Name like '%" & txtsearch_stator.Text & "%'"
        DataGrid_stator.DataSource = cmd_execuTodatatable()
    End Sub

    Private Sub btnsearch_stator_Click(sender As Object, e As EventArgs) Handles btnsearch_stator.Click

        acc = "select Stator_ID,Stator_Name,stator_active,stator_available,stator_claim,Date_claim,stator_note from Stator where stator_claim like '%" & sta_chclaim.CheckState & "%'"
        DataGrid_stator.DataSource = cmd_execuTodatatable()
    End Sub

    Private Sub btnsearch_active_Click(sender As Object, e As EventArgs) Handles btnsearch_active.Click

        acc = "select Stator_ID,Stator_Name,stator_active,stator_available,stator_claim,Date_claim,stator_note from Stator where stator_active like '%" & sta_chactive.CheckState & "%'"
        DataGrid_stator.DataSource = cmd_execuTodatatable()
    End Sub

    Private Sub btnavailable_Click(sender As Object, e As EventArgs) Handles btnavailable.Click
        acc = "select Stator_ID,Stator_Name,stator_active,stator_available,stator_claim,Date_claim,stator_note from Stator where stator_available like '%" & sta_chavailable.CheckState & "%'"
        DataGrid_stator.DataSource = cmd_execuTodatatable()
    End Sub
End Class