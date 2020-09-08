Public Class discountForm


    Private Sub btn_cancel_discount_Click(sender As Object, e As EventArgs) Handles btn_cancel_discount.Click
        Me.Close()
    End Sub

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