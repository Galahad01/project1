Imports System.Data.OleDb
Imports System.Data


Public Class frm_Active
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

    Private Sub refresh_datagried()
        acc = "select * from Active"
        DataGrid_active.DataSource = cmd_execuTodatatable()
        '  change_alldatagrid_head()
    End Sub

    Private Sub frm_Active_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_datagried()
        getraytypenew_A()
        getraytypenew_A2()
        getraytypenew_B()
        getraytypenew_B2()
        getrotor()
        getstator()
        getremote()
        getlocation()
        getcontent()
    End Sub
    Private Sub getraytypenew_A()
        ' Select Case job_lvl, hire_date    'โครตเจ็งเลยอ่ะ เลือกcombo ค่าที่มาใส่ได้ตามต้องการ 
        'From employee
        'Where (job_lvl >= 200) Or
        '(hire_date < '01/01/1998')
        ' ***************************************
        'Select Case pub_id, title  
        'From titles
        'Where (pub_id = '0877') AND (title LIKE '%Cook%')
        '*************************************************
        ' WHERE(hire_date < '01/01/91' ) AND  
        ' (job_lvl = 100) Or
        '(job_lvl = 200)
        acc = "select ray_number,ray_available,type from Ray where (ray_available = true) and (type = 'A')"
        cmd_database_to_object(txt_comboraya1)

    End Sub

    Private Sub getraytypenew_A2()

        acc = "select ray_number,ray_available,type from Ray where (ray_available = true) and (type ='A')"
        cmd_database_to_object(txt_comboraya2)
    End Sub

    Private Sub getraytypenew_B()

        acc = "select ray_number,ray_available,type from Ray where (ray_available = true) and (type ='B')"
        cmd_database_to_object(txt_comborayb3)
    End Sub
    Private Sub getraytypenew_B2()

        acc = "select ray_number,ray_available,type from Ray where (ray_available = true) and (type ='B')"
        cmd_database_to_object(txt_comborayb4)
    End Sub
    Private Sub getrotor()

        acc = "select Rotor_Name,rotor_available from Rotor where (rotor_available = true)"
        cmd_database_to_object(txt_ComboBoxrotor)
    End Sub
    ' Private Sub Falsegetrotor()

    'cmd = New OleDbCommand("insert into Rotor(rotor_active,rotor_available)values('" & rdactive.Checked & "','" & rdavailable.Checked & "')", cn)
    ' cmd.ExecuteNonQuery()
    '  Using cmd = New OleDbCommand("Update Rotor Set rotor_active='" & rdactive.Checked & "',rotor_available='" & rdavailable.Checked & "'Where Rotor_ID=@Rotor_ID", cn)

    ' cmd.Parameters.Add("Rotor_ID", OleDbType.Integer).Value = DataGrid_active.CurrentRow.Cells(0).Value
    ' cmd.ExecuteNonQuery()

    'cn.Close()
    'End
    '  End Using

    ' End Sub
    Private Sub getstator()

        acc = "select Stator_Name,stator_available from Stator where (stator_available = true)"
        cmd_database_to_object(txt_ComboBoxstator)
    End Sub
    Private Sub getremote()

        acc = "select Remote_number from Remote"
        cmd_database_to_object(txt_ComboBoxremote)
    End Sub
    Private Sub getlocation()

        acc = "select Location_name from Location"
        cmd_database_to_object(txt_ComboBoxlocation)
    End Sub
    Private Sub getcontent()

        acc = "select Content from Location"
        cmd_database_to_object(txt_ComboBoxcontent)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim box = New frm_picturelocation
        box.Show()

    End Sub

    Private Sub btn_save_active_Click(sender As Object, e As EventArgs) Handles btn_save_active.Click, Button10.Click

        acc = "select count(*) from Active where Rotor_Name='" & txt_ComboBoxrotor.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("Rotor ซ้ำนะจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        acc = "select count(*) from Active where Stator_Name='" & txt_ComboBoxstator.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("Stator ซ้ำนะจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        acc = "select count(*) from Active where Ray_A1='" & txt_comboraya1.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("Ray A1 ซ้ำนะจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        acc = "select count(*) from Active where Ray_A2='" & txt_comboraya2.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("Ray A2 ซ้ำนะจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        acc = "select count(*) from Active where Ray_B1='" & txt_comborayb3.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("Ray B1 ซ้ำนะจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        acc = "select count(*) from Active where Ray_B2='" & txt_comborayb4.Text & "'"
        If cmd_executeScalar() > 0 Then
            MessageBox.Show("Ray B2 ซ้ำนะจ๊ะ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        cmd = New OleDbCommand("insert into Active(Rotor_Name,Stator_Name,Ray_A1,Ray_A2,Ray_B1,Ray_B2,Remote_number,Location_name,Content)values('" & txt_ComboBoxrotor.Text & "','" & txt_ComboBoxstator.Text & "','" & txt_comboraya1.Text & "','" & txt_comboraya2.Text & "','" & txt_comborayb3.Text & "','" & txt_comborayb4.Text & "','" & txt_ComboBoxremote.Text & "','" & txt_ComboBoxlocation.Text & "','" & txt_ComboBoxcontent.Text & "')", cn)


        'cmd = New OleDbCommand("Update Online Set rotor_active='" & rdactive.Checked & "',rotor_available='" & rdavailable.Checked & "'Where Rotor_ID=@Rotor_ID", cn)

        ' Try
        ' cmd.Parameters.Add("Rotor_ID", OleDbType.Integer).Value = txt_ComboBoxrotor.SelectedItem
        '  Catch ex As Exception

        '   End Try

        cmd.ExecuteNonQuery()

        MessageBox.Show("บันทึกแล้วนะจ๊ะ", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)

        refresh_datagried()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '  cmd = New OleDbCommand("Delete from Rotor where Rotor_ID=@Rotor_ID", cn)
        '  With cmd
        ' .Parameters.Add("Rotor_ID", OleDbType.Integer).Value = DataGrid_rotor.CurrentRow.Cells(0).Value
        ' .ExecuteNonQuery()
        '  End With
        '  cn.Close()
        '  MessageBox.Show("จะลบแน่นะจ๊ะ", "!!!!!!!!!!!!!!!!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '  refresh_datagried()
        cmd = New OleDbCommand("Delete from Rotor where Rotor_ID", cn)
        With cmd
            .Parameters.Add("Rotor_ID", OleDbType.Integer).Value = DataGrid_rotor.CurrentRow.Cells(0).Value
            .ExecuteNonQuery()
        End With
        cn.Close()
        MessageBox.Show("จะลบแน่นะจ๊ะ", "!!!!!!!!!!!!!!!!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refresh_datagried()

    End Sub
End Class