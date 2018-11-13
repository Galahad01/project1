Public Class Tabbar
    Private Sub Load_frmactive_intopanal()
        Panel_main.Controls.Clear()
        Dim frm_active As New frm_Active()
        frm_active.TopLevel = False
        frm_active.Parent = Panel_main
        frm_active.Show()

    End Sub
    Private Sub Load_frmray_intopanal()
        Panel_main.Controls.Clear()
        Dim frm_ray As New frm_ray()
        frm_ray.TopLevel = False
        frm_ray.Parent = Panel_main
        frm_ray.Show()

    End Sub
    Private Sub Load_frmrotor_intopanal()
        Panel_main.Controls.Clear()
        Dim frm_rotor As New frm_Rotor()
        frm_rotor.TopLevel = False
        frm_rotor.Parent = Panel_main
        frm_rotor.Show()

    End Sub
    Private Sub Load_frmstator_intopanal()
        Panel_main.Controls.Clear()
        Dim frm_stator As New frm_stator()
        frm_stator.TopLevel = False
        frm_stator.Parent = Panel_main
        frm_stator.Show()

    End Sub
    Private Sub Load_frmlocation_intopanal()
        Panel_main.Controls.Clear()
        Dim frm_location As New frm_location()
        frm_location.TopLevel = False
        frm_location.Parent = Panel_main
        frm_location.Show()

    End Sub

    Private Sub Load_tabbar_intopanal()
        Panel_main.Controls.Clear()
        Dim frm_tab As New Tabbar()
        frm_tab.Size = Panel_main.Size
        frm_tab.TopLevel = True
        Panel_main.Show()
    End Sub

    Private Sub btnsmall_Click(sender As Object, e As EventArgs) Handles btnsmall.Click
        Load_tabbar_intopanal()
    End Sub
    Private Sub btnactive_Click(sender As Object, e As EventArgs) Handles btnactive.Click
        Load_frmactive_intopanal()
    End Sub

    Private Sub btnray_Click(sender As Object, e As EventArgs) Handles btnray.Click
        Load_frmray_intopanal()
    End Sub

    Private Sub btnrotor_Click(sender As Object, e As EventArgs) Handles btnrotor.Click
        Load_frmrotor_intopanal()
    End Sub

    Private Sub btnstator_Click(sender As Object, e As EventArgs) Handles btnstator.Click
        Load_frmstator_intopanal()
    End Sub
    Private Sub btnlocation_Click(sender As Object, e As EventArgs) Handles btnlocation.Click
        Load_frmlocation_intopanal()
    End Sub
End Class