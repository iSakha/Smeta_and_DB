Public Class discountForm


    Private Sub btn_cancel_discount_Click(sender As Object, e As EventArgs) Handles btn_cancel_discount.Click
        Me.Close()
    End Sub
#Region "Set discount"
    Private Sub txt_plus_light_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_plus_light.MouseClick
        txt_light_discount.Text = CInt(txt_light_discount.Text) + 1
        If CInt(txt_light_discount.Text) = 0 Then
            chbx_lighting.Checked = False
        Else
            chbx_lighting.Checked = True
        End If
    End Sub
    Private Sub txt_minus_light_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_minus_light.MouseClick
        txt_light_discount.Text = CInt(txt_light_discount.Text) - 1
        If CInt(txt_light_discount.Text) = 0 Then
            chbx_lighting.Checked = False
        Else
            chbx_lighting.Checked = True
        End If
    End Sub

    Private Sub txt_plus_screen_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_plus_screen.MouseClick
        txt_screen_discount.Text = CInt(txt_screen_discount.Text) + 1
        If CInt(txt_screen_discount.Text) = 0 Then
            chbx_screen.Checked = False
        Else
            chbx_screen.Checked = True
        End If
    End Sub

    Private Sub txt_minus_screen_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_minus_screen.MouseClick
        txt_screen_discount.Text = CInt(txt_screen_discount.Text) - 1
        If CInt(txt_screen_discount.Text) = 0 Then
            chbx_screen.Checked = False
        Else
            chbx_screen.Checked = True
        End If
    End Sub

    Private Sub txt_plus_commut_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_plus_commut.MouseClick
        txt_commut_discount.Text = CInt(txt_commut_discount.Text) + 1
        If CInt(txt_commut_discount.Text) = 0 Then
            chbx_commutation.Checked = False
        Else
            chbx_commutation.Checked = True
        End If
    End Sub

    Private Sub txt_minus_commut_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_minus_commut.MouseClick
        txt_commut_discount.Text = CInt(txt_commut_discount.Text) - 1
        If CInt(txt_commut_discount.Text) = 0 Then
            chbx_commutation.Checked = False
        Else
            chbx_commutation.Checked = True
        End If
    End Sub

    Private Sub txt_plus_truss_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_plus_truss.MouseClick
        txt_truss_discount.Text = CInt(txt_truss_discount.Text) + 1
        If CInt(txt_truss_discount.Text) = 0 Then
            chbx_truss.Checked = False
        Else
            chbx_truss.Checked = True
        End If
    End Sub

    Private Sub txt_minus_truss_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_minus_truss.MouseClick
        txt_truss_discount.Text = CInt(txt_truss_discount.Text) - 1
        If CInt(txt_truss_discount.Text) = 0 Then
            chbx_truss.Checked = False
        Else
            chbx_truss.Checked = True
        End If
    End Sub

    Private Sub txt_plus_constr_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_plus_constr.MouseClick
        txt_constr_discount.Text = CInt(txt_constr_discount.Text) + 1
        If CInt(txt_constr_discount.Text) = 0 Then
            chbx_constr.Checked = False
        Else
            chbx_constr.Checked = True
        End If
    End Sub

    Private Sub txt_minus_constr_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_minus_constr.MouseClick
        txt_constr_discount.Text = CInt(txt_constr_discount.Text) - 1
        If CInt(txt_constr_discount.Text) = 0 Then
            chbx_constr.Checked = False
        Else
            chbx_constr.Checked = True
        End If
    End Sub

    Private Sub txt_plus_sound_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_plus_sound.MouseClick
        txt_sound_discount.Text = CInt(txt_sound_discount.Text) + 1
        If CInt(txt_sound_discount.Text) = 0 Then
            chbx_sound.Checked = False
        Else
            chbx_sound.Checked = True
        End If
    End Sub

    Private Sub txt_minus_sound_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_minus_sound.MouseClick
        txt_sound_discount.Text = CInt(txt_sound_discount.Text) - 1
        If CInt(txt_sound_discount.Text) = 0 Then
            chbx_sound.Checked = False
        Else
            chbx_sound.Checked = True
        End If
    End Sub
#End Region
    '===================================================================================
    '             === OK button ===
    '===================================================================================
    Private Sub btn_discount_OK_Click(sender As Object, e As EventArgs) Handles btn_discount_OK.Click

        mainForm.light_dscnt_status = chbx_lighting.CheckState
        mainForm.screen_dscnt_status = chbx_screen.CheckState
        mainForm.comm_dscnt_status = chbx_commutation.CheckState
        mainForm.truss_dscnt_status = chbx_truss.CheckState
        mainForm.constr_dscnt_status = chbx_constr.CheckState
        mainForm.sound_dscnt_status = chbx_sound.CheckState

        mainForm.light_dscnt_val = CInt(txt_light_discount.Text)
        mainForm.screen_dscnt_val = CInt(txt_screen_discount.Text)
        mainForm.comm_dscnt_val = CInt(txt_commut_discount.Text)
        mainForm.truss_dscnt_val = CInt(txt_truss_discount.Text)
        mainForm.constr_dscnt_val = CInt(txt_constr_discount.Text)
        mainForm.sound_dscnt_val = CInt(txt_sound_discount.Text)

        mainForm.discountStatus(0) = mainForm.light_dscnt_status
        mainForm.discountStatus(1) = mainForm.screen_dscnt_status
        mainForm.discountStatus(2) = mainForm.comm_dscnt_status
        mainForm.discountStatus(3) = mainForm.truss_dscnt_status
        mainForm.discountStatus(4) = mainForm.constr_dscnt_status
        mainForm.discountStatus(5) = mainForm.sound_dscnt_status

        mainForm.discountValue(0) = mainForm.light_dscnt_val
        mainForm.discountValue(1) = mainForm.screen_dscnt_val
        mainForm.discountValue(2) = mainForm.comm_dscnt_val
        mainForm.discountValue(3) = mainForm.truss_dscnt_val
        mainForm.discountValue(4) = mainForm.constr_dscnt_val
        mainForm.discountValue(5) = mainForm.sound_dscnt_val

        Me.Close()

    End Sub
End Class