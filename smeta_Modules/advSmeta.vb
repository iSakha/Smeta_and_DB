Module advSmeta

    '===================================================================================
    '             === Select companies' queue ===
    '===================================================================================
    Sub disableSelected(_sender As Button)

        Dim index As Integer
        index = (mainForm.btnsAdvSmeta.IndexOf(_sender))
        _sender.BackColor = Color.DarkGray
        _sender.Enabled = False

        smetaMainForm.tbCtrl_smeta.TabPages.Add(mainForm.tabsSmeta(index))
    End Sub

    Sub calculateFixturesByCompanies(_sender As Button)

        '************************************************************************
        '   index - button index in btnsAdvSmeta list
        '   Cells(index + 5) - fixture qty in corresponding companies
        '   Cells(index + 22) - fixture qty taken from corresponding company
        '   Cells(27) - last column named "Company"
        '   Cells(20) - column named "OrderQty"
        '   Cells(21) - column named "Rest"
        '   Cells(22),(23),(24),(25),(26) - how many taken from companies
        '************************************************************************

        Dim index As Integer
        index = (mainForm.btnsAdvSmeta.IndexOf(_sender))
        For Each r As DataGridViewRow In smetaMainForm.dgv_advSmeta.Rows

            If (r.Cells(index + 5).Value > 0) And (r.Cells(21).Value > 0) Then
                r.Cells(27).Value = _sender.Name

                ' How many fixtures taken
                If r.Cells(index + 5).Value > r.Cells(21).Value Then
                    r.Cells(index + 22).Value = r.Cells(21).Value
                Else
                    r.Cells(index + 22).Value = r.Cells(index + 5).Value
                End If

                '   How many rest to take
                r.Cells(21).Value = r.Cells(20).Value - (r.Cells(22).Value + r.Cells(23).Value + r.Cells(24).Value +
                r.Cells(25).Value + r.Cells(26).Value)
            End If

        Next r
        'copyRowToCompanySmeta(index, _sender.Name)

    End Sub

    Sub copyRowToCompanySmeta()

        Dim row As DataGridViewRow

        For Each dgv As DataGridView In mainForm.companyDGV
            For Each drr As DataGridViewRow In smetaMainForm.dgv_advSmeta.Rows
                If drr.Cells(27).Value = dgv.Name Then
                    row = CType(drr.Clone(), DataGridViewRow)
                    For i As Integer = 0 To drr.Cells.Count - 1
                        row.Cells(i).Value = drr.Cells(i).Value
                        row.DefaultCellStyle.BackColor = SystemColors.Window
                    Next
                    dgv.Rows.Add(row)
                End If
            Next
        Next
    End Sub

End Module
