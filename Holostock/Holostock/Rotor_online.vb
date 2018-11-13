Imports System.Data.OleDb
Imports System.Data

Public Class Rotor_online

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

        Friend Sub cmd_database_to_object(obj As Object)
            connect()
            cmd = New OleDbCommand(acc, cn)
            rd = cmd.ExecuteReader
            obj.Items.clear()
            While rd.Read
                obj.Items.add(rd(0))
            End While
            rd.Close()
        End Sub

    Private Sub refresh_datagried_rotor_online()
        acc = "select * from online "
        DataGridView_rotor_online.DataSource = cmd_execuTodatatable()

    End Sub

    Private Sub Rotor_online_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_datagried_rotor_online()

    End Sub
End Class