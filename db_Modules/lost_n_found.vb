Module lost_n_found
    Sub format_DGV_lost_n_found()
        Dim dgv As DataGridView = lost_n_foundForm.DGV_db
        dgv.RowHeadersVisible = False

        dgv.Columns(0).Visible = False
        dgv.Columns(1).Visible = False
        dgv.Columns(2).Width = 80
        dgv.Columns(3).Width = 430
        dgv.Columns(4).Width = 50
        dgv.Columns(5).Width = 50                                                                            ' BelImlight
        dgv.Columns(6).Width = 50                                                                             ' PRLightigTouring
        dgv.Columns(7).Width = 50                                                                             ' BlackOut
        dgv.Columns(8).Width = 50                                                                             ' Vision
        dgv.Columns(9).Width = 50
        dgv.Columns(10).Visible = False
        dgv.Columns(11).Visible = False
        dgv.Columns(12).Visible = False
        dgv.Columns(13).Visible = False

    End Sub
End Module
