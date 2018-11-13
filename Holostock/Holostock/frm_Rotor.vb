Imports System.Data.OleDb
Imports System.Data

Public Class frm_Rotor
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
        acc = "select * from Rotor"
        DataGrid_rotor.DataSource = cmd_execuTodatatable()
        '  change_alldatagrid_head()
    End Sub

    Private Sub frm_Rotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_datagried()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        acc = "select count(*) from Rotor where Rotor_Name='" & txtname_rotor.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("จะพิมซ้ำอาไรหนักหนาจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname_rotor.Clear()
            txtdate_rotor.Clear()
            txtnote_rotor.Clear()
            Return

        End If
        cmd = New OleDbCommand("insert into Rotor(Rotor_Name,rotor_active,rotor_available,rotor_claim,Date_claim,rotor_note)values('" & txtname_rotor.Text & "','" & chactive.CheckState & "','" & chavailable.CheckState & "','" & chclaim.CheckState & "','" & txtdate_rotor.Text & "','" & txtnote_rotor.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("บันทึกแล้วนะจ๊ะ", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtname_rotor.Clear()
        txtnote_rotor.Clear()
        txtdate_rotor.Clear()
        refresh_datagried()


    End Sub

    Private Sub btndelete_rotor_Click(sender As Object, e As EventArgs) Handles btndelete_rotor.Click

        cmd = New OleDbCommand("Delete from Rotor where Rotor_ID=@Rotor_ID", cn)
        With cmd
            .Parameters.Add("Rotor_ID", OleDbType.Integer).Value = DataGrid_rotor.CurrentRow.Cells(0).Value
            .ExecuteNonQuery()
        End With
        cn.Close()
        MessageBox.Show("จะลบแน่นะจ๊ะ", "!!!!!!!!!!!!!!!!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refresh_datagried()

    End Sub

    Private Sub DataGrid_rotor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_rotor.CellClick

        Using cmd = New OleDbCommand("Select * from Rotor where Rotor_ID=@Rotor_ID", cn)
            cmd.Parameters.Add("Rotor_ID", OleDbType.Integer).Value = DataGrid_rotor.CurrentRow.Cells(0).Value

            Using rd As OleDbDataReader = cmd.ExecuteReader
                If rd.Read Then
                    txtname_rotor.Text = rd.Item(1)
                    chactive.Checked = rd.Item(2)
                    chavailable.Checked = rd.Item(3)
                    chclaim.Checked = rd.Item(4)
                    txtdate_rotor.Text = rd.Item(5).ToString
                    txtnote_rotor.Text = rd.Item(6).ToString
                End If

            End Using
        End Using


    End Sub

    Private Sub btnedit_rotor_Click(sender As Object, e As EventArgs) Handles btnedit_rotor.Click

        Using cmd = New OleDbCommand("Update Rotor Set Rotor_Name='" & txtname_rotor.Text & "', rotor_active='" & chactive.CheckState & "',rotor_available='" & chavailable.CheckState & "',rotor_claim ='" & chclaim.CheckState & "',Date_claim='" & txtdate_rotor.Text & "',rotor_note='" & txtnote_rotor.Text & "' Where Rotor_ID=@Rotor_ID", cn)

            cmd.Parameters.Add("Rotor_ID", OleDbType.Integer).Value = DataGrid_rotor.CurrentRow.Cells(0).Value
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update สำเร็จ", "up up up up data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()
            refresh_datagried()
        End Using
    End Sub

    Private Sub txtsearch_rotor_TextChanged(sender As Object, e As EventArgs) Handles txtsearch_rotor.TextChanged
        acc = "select Rotor_ID,Rotor_Name,rotor_active,rotor_available,rotor_claim,Date_claim,rotor_note from Rotor where Rotor_Name like '%" & txtsearch_rotor.Text & "%'"
        DataGrid_rotor.DataSource = cmd_execuTodatatable()
    End Sub

    Private Sub btnsearch_rotor_Click(sender As Object, e As EventArgs) Handles btnsearch_rotor.Click
        acc = "select Rotor_ID,Rotor_Name,rotor_active,rotor_available,rotor_claim,Date_claim,rotor_note from Rotor where rotor_claim like '%" & chclaim.CheckState & "%'"
        DataGrid_rotor.DataSource = cmd_execuTodatatable()
    End Sub

    Private Sub btnsearch_active_Click(sender As Object, e As EventArgs) Handles btnsearch_active.Click
        acc = "select Rotor_ID,Rotor_Name,rotor_active,rotor_available,rotor_claim,Date_claim,rotor_note from Rotor where rotor_active like '%" & chactive.CheckState & "%'"
        DataGrid_rotor.DataSource = cmd_execuTodatatable()
    End Sub

    Private Sub btnavailable_Click(sender As Object, e As EventArgs) Handles btnavailable.Click
        acc = "select Rotor_ID,Rotor_Name,rotor_active,rotor_available,rotor_claim,Date_claim,rotor_note from Rotor where rotor_available like '%" & chavailable.CheckState & "%'"
        DataGrid_rotor.DataSource = cmd_execuTodatatable()
    End Sub


End Class