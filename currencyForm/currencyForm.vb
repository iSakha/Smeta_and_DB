Public Class currencyForm
    Private Sub currencyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_USD_rate.Text = My.Settings.USD_rate
        lbl_Euro_rate.Text = My.Settings.Euro_rate
        lbl_rusRub_rate.Text = My.Settings.rusRub_rate
        lbl_BYN_rate.Text = My.Settings.BYN_rate
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub btn_setUSD_Click(sender As Object, e As EventArgs) Handles btn_setUSD.Click
        lbl_USD_rate.Text = txt_USD_rate.Text
    End Sub

    Private Sub btn_setEuro_Click(sender As Object, e As EventArgs) Handles btn_setEuro.Click
        lbl_Euro_rate.Text = txt_Euro_rate.Text
    End Sub

    Private Sub btn_setrusRub_Click(sender As Object, e As EventArgs) Handles btn_setrusRub.Click
        lbl_rusRub_rate.Text = txt_rusRub_rate.Text
    End Sub

    Private Sub btn_setBYN_Click(sender As Object, e As EventArgs) Handles btn_setBYN.Click
        lbl_BYN_rate.Text = txt_BYN_rate.Text
    End Sub


    '===================================================================================
    '             === Confirm button ===
    '===================================================================================
    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        mainForm.USD_rate = CSng(lbl_USD_rate.Text)
        mainForm.Euro_rate = CSng(lbl_Euro_rate.Text)
        mainForm.rusRub_rate = CSng(lbl_rusRub_rate.Text)
        mainForm.BYN_rate = CSng(lbl_BYN_rate.Text)

        My.Settings.USD_rate = mainForm.USD_rate
        My.Settings.Euro_rate = mainForm.Euro_rate
        My.Settings.rusRub_rate = mainForm.rusRub_rate
        My.Settings.BYN_rate = mainForm.BYN_rate

        mainForm.USD_val = New Collection
        mainForm.Euro_val = New Collection
        mainForm.rusRub_val = New Collection
        mainForm.BYN_val = New Collection

        For Each row As DataGridViewRow In targetRows

            mainForm.USD_val.Add(row.Cells(12).Value * mainForm.USD_rate)
            mainForm.Euro_val.Add(row.Cells(12).Value * mainForm.Euro_rate)
            mainForm.rusRub_val.Add(row.Cells(12).Value * mainForm.rusRub_rate * 100)
            mainForm.BYN_val.Add(row.Cells(12).Value * mainForm.BYN_rate)

        Next row

        smetaMainForm.rbtn_usd.Checked = True
        changeCurrency(mainForm.USD_val)

        Me.Close()

    End Sub

End Class