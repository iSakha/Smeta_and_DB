Public Class discountForm
    '===================================================================================
    '             === Form load ===
    '===================================================================================
    Private Sub discountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_summary_light.Text = mainForm.priceLighting
        txt_summary_screen.Text = mainForm.priceScreen
        txt_summary_comm.Text = mainForm.priceComm
        txt_summary_truss.Text = mainForm.priceTruss
        txt_summary_constr.Text = mainForm.priceConstr
        txt_summary_sound.Text = mainForm.priceSound

        txt_summary_light_discount.Text = txt_summary_light.Text
        txt_summary_screen_discount.Text = txt_summary_screen.Text
        txt_summary_comm_discount.Text = txt_summary_comm.Text
        txt_summary_truss_discount.Text = txt_summary_truss.Text
        txt_summary_constr_discount.Text = txt_summary_constr.Text

        lbl_totalPrice.Text = mainForm.priceLighting + mainForm.priceScreen + mainForm.priceComm +
                mainForm.priceTruss + mainForm.priceConstr + mainForm.priceSound

        lbl_totalPrice_discount.Text = CInt(txt_summary_light_discount.Text) + CInt(txt_summary_screen_discount.Text) +
                    CInt(txt_summary_comm_discount.Text) + CInt(txt_summary_truss_discount.Text) +
                    CInt(txt_summary_constr_discount.Text) + CInt(txt_summary_sound_discount.Text)

        lbl_currency.Text = "USD"

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

        mainForm.discountPrice(0) = CInt(txt_summary_light_discount.Text)
        mainForm.discountPrice(1) = CInt(txt_summary_screen_discount.Text)
        mainForm.discountPrice(2) = CInt(txt_summary_comm_discount.Text)
        mainForm.discountPrice(3) = CInt(txt_summary_truss_discount.Text)
        mainForm.discountPrice(4) = CInt(txt_summary_constr_discount.Text)
        mainForm.discountPrice(5) = CInt(txt_summary_sound_discount.Text)

        Me.Close()

    End Sub

    Private Sub txt_light_discount_TextChanged_1(sender As Object, e As EventArgs) Handles txt_light_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If IsNumeric(txt_light_discount.Text) Then
                    txt_summary_light_discount.Text = Math.Round(CInt(txt_summary_light.Text) - (CInt(txt_summary_light.Text) * CInt(txt_light_discount.Text) / 100))
                    If CInt(txt_light_discount.Text) > 0 Then
                        chbx_lighting.Checked = True
                    Else
                        chbx_lighting.Checked = False
                    End If
                    lbl_totalPrice_discount.Text = CInt(txt_summary_light_discount.Text) + CInt(txt_summary_screen_discount.Text) +
                    CInt(txt_summary_comm_discount.Text) + CInt(txt_summary_truss_discount.Text) +
                    CInt(txt_summary_constr_discount.Text) + CInt(txt_summary_sound_discount.Text)
                Else
                    txt_light_discount.Clear()
                    txt_summary_light_discount.Clear()
                    chbx_lighting.Checked = False
                End If
            End If

        Next
    End Sub

    Private Sub txt_screen_discount_TextChanged_1(sender As Object, e As EventArgs) Handles txt_screen_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If IsNumeric(txt_screen_discount.Text) Then
                    txt_summary_screen_discount.Text = Math.Round(CInt(txt_summary_screen.Text) - (CInt(txt_summary_screen.Text) * CInt(txt_screen_discount.Text) / 100))
                    If CInt(txt_screen_discount.Text) > 0 Then
                        chbx_screen.Checked = True
                    Else
                        chbx_screen.Checked = False
                    End If
                    lbl_totalPrice_discount.Text = CInt(txt_summary_light_discount.Text) + CInt(txt_summary_screen_discount.Text) +
                    CInt(txt_summary_comm_discount.Text) + CInt(txt_summary_truss_discount.Text) +
                    CInt(txt_summary_constr_discount.Text) + CInt(txt_summary_sound_discount.Text)
                Else
                    txt_screen_discount.Clear()
                    txt_summary_screen_discount.Clear()
                    chbx_screen.Checked = False
                End If
            End If

        Next
    End Sub

    Private Sub txt_commut_discount_TextChanged_1(sender As Object, e As EventArgs) Handles txt_commut_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If IsNumeric(txt_commut_discount.Text) Then
                    txt_summary_comm_discount.Text = Math.Round(CInt(txt_summary_comm.Text) - (CInt(txt_summary_comm.Text) * CInt(txt_commut_discount.Text) / 100))
                    If CInt(txt_commut_discount.Text) > 0 Then
                        chbx_commutation.Checked = True
                    Else
                        chbx_commutation.Checked = False
                    End If
                    lbl_totalPrice_discount.Text = CInt(txt_summary_light_discount.Text) + CInt(txt_summary_screen_discount.Text) +
                    CInt(txt_summary_comm_discount.Text) + CInt(txt_summary_truss_discount.Text) +
                    CInt(txt_summary_constr_discount.Text) + CInt(txt_summary_sound_discount.Text)
                Else
                    txt_commut_discount.Clear()
                    txt_summary_comm_discount.Clear()
                    chbx_commutation.Checked = False
                End If
            End If

        Next
    End Sub

    Private Sub txt_truss_discount_TextChanged_1(sender As Object, e As EventArgs) Handles txt_truss_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If IsNumeric(txt_truss_discount.Text) Then
                    txt_summary_truss_discount.Text = Math.Round(CInt(txt_summary_truss.Text) - (CInt(txt_summary_truss.Text) * CInt(txt_truss_discount.Text) / 100))
                    If CInt(txt_truss_discount.Text) > 0 Then
                        chbx_truss.Checked = True
                    Else
                        chbx_truss.Checked = False
                    End If
                    lbl_totalPrice_discount.Text = CInt(txt_summary_light_discount.Text) + CInt(txt_summary_screen_discount.Text) +
                    CInt(txt_summary_comm_discount.Text) + CInt(txt_summary_truss_discount.Text) +
                    CInt(txt_summary_constr_discount.Text) + CInt(txt_summary_sound_discount.Text)
                Else
                    txt_truss_discount.Clear()
                    txt_summary_truss_discount.Clear()
                    chbx_truss.Checked = False
                End If
            End If

        Next
    End Sub

    Private Sub txt_constr_discount_TextChanged_1(sender As Object, e As EventArgs) Handles txt_constr_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If IsNumeric(txt_constr_discount.Text) Then
                    txt_summary_constr_discount.Text = Math.Round(CInt(txt_summary_constr.Text) - (CInt(txt_summary_constr.Text) * CInt(txt_constr_discount.Text) / 100))
                    If CInt(txt_constr_discount.Text) > 0 Then
                        chbx_constr.Checked = True
                    Else
                        chbx_constr.Checked = False
                    End If
                    lbl_totalPrice_discount.Text = CInt(txt_summary_light_discount.Text) + CInt(txt_summary_screen_discount.Text) +
                    CInt(txt_summary_comm_discount.Text) + CInt(txt_summary_truss_discount.Text) +
                    CInt(txt_summary_constr_discount.Text) + CInt(txt_summary_sound_discount.Text)
                Else
                    txt_constr_discount.Clear()
                    txt_summary_constr_discount.Clear()
                    chbx_constr.Checked = False
                End If
            End If
        Next
    End Sub

    Private Sub txt_sound_discount_TextChanged_1(sender As Object, e As EventArgs) Handles txt_sound_discount.TextChanged
        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then
                If IsNumeric(txt_sound_discount.Text) Then
                    txt_summary_sound_discount.Text = Math.Round(CInt(txt_summary_sound.Text) - (CInt(txt_summary_sound.Text) * CInt(txt_sound_discount.Text) / 100))
                    If CInt(txt_sound_discount.Text) > 0 Then
                        chbx_sound.Checked = True
                    Else
                        chbx_sound.Checked = False
                    End If
                    lbl_totalPrice_discount.Text = CInt(txt_summary_light_discount.Text) + CInt(txt_summary_screen_discount.Text) +
                    CInt(txt_summary_comm_discount.Text) + CInt(txt_summary_truss_discount.Text) +
                    CInt(txt_summary_constr_discount.Text) + CInt(txt_summary_sound_discount.Text)
                Else
                    txt_sound_discount.Clear()
                    txt_summary_sound_discount.Clear()
                    chbx_sound.Checked = False
                End If
            End If
        Next
    End Sub
End Class