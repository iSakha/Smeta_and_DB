Public Class discountForm
    Private Sub discountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_summary_light.Text = mainForm.priceLighting
        txt_summary_screen.Text = mainForm.priceScreen
        txt_summary_comm.Text = mainForm.priceComm
        txt_summary_truss.Text = mainForm.priceTruss
        txt_summary_constr.Text = mainForm.priceConstr
        txt_summary_sound.Text = mainForm.priceSound
    End Sub

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

    Private Sub txt_light_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_light_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If checkIsNumber() Then
                    txt_summary_light_discount.Text = Math.Round(CInt(txt_summary_light.Text) - (CInt(txt_summary_light.Text) * CInt(txt_light_discount.Text) / 100))
                End If
            End If
        Next
    End Sub

    Private Sub txt_screen_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_screen_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If checkIsNumber() Then
                    txt_summary_screen_discount.Text = Math.Round(CInt(txt_summary_screen.Text) - (CInt(txt_summary_screen.Text) * CInt(txt_screen_discount.Text) / 100))
                End If
            End If
        Next
    End Sub

    Private Sub txt_commut_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_commut_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If checkIsNumber() Then
                    txt_summary_comm_discount.Text = Math.Round(CInt(txt_summary_comm.Text) - (CInt(txt_summary_comm.Text) * CInt(txt_commut_discount.Text) / 100))
                End If
            End If
        Next
    End Sub

    Private Sub txt_truss_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_truss_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If checkIsNumber() Then
                    txt_summary_truss_discount.Text = Math.Round(CInt(txt_summary_truss.Text) - (CInt(txt_summary_truss.Text) * CInt(txt_truss_discount.Text) / 100))
                End If
            End If
        Next
    End Sub

    Private Sub txt_constr_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_constr_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If checkIsNumber() Then
                    txt_summary_constr_discount.Text = Math.Round(CInt(txt_summary_constr.Text) - (CInt(txt_summary_constr.Text) * CInt(txt_constr_discount.Text) / 100))
                End If
            End If
        Next
    End Sub

    Private Sub txt_sound_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_sound_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If checkIsNumber() Then
                    txt_summary_sound_discount.Text = Math.Round(CInt(txt_summary_sound.Text) - (CInt(txt_summary_sound.Text) * CInt(txt_sound_discount.Text) / 100))
                End If
            End If
        Next
    End Sub

    Function checkIsNumber()
        Return (True)
    End Function
End Class