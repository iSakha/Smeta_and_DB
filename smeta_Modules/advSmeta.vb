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

        clear_companyDGV()
        Dim row As DataGridViewRow
        'Dim dgv As DataGridView = smetaMainForm.dgv_belimlight

        For i As Integer = 0 To mainForm.companyDGV.Count - 1

            For Each drr As DataGridViewRow In smetaMainForm.dgv_advSmeta.Rows
                'For Each drr As DataGridViewRow In dgv.Rows

                If drr.Cells(i + 22).Value > 0 Then
                    row = CType(drr.Clone(), DataGridViewRow)
                    For j As Integer = 0 To drr.Cells.Count - 1
                        row.Cells(j).Value = drr.Cells(j).Value
                        row.DefaultCellStyle.BackColor = SystemColors.Window
                    Next
                    mainForm.companyDGV(i).Rows.Add(row)
                End If
            Next
            format_companyDGV(mainForm.companyDGV(i))
        Next
    End Sub

    Sub clear_companyDGV()
        For i As Integer = 0 To mainForm.companyDGV.Count - 1
            mainForm.companyDGV(i).Rows.Clear()
        Next
    End Sub

    Sub format_companyDGV(_DGV)

        Dim NRFormat As String = "### ### ##0"
        _DGV.RowHeadersVisible = False
        _DGV.Columns(0).Visible = False         ' Dep
        _DGV.Columns(1).Visible = False         ' Cat
        _DGV.Columns(2).Visible = False         ' ID

        For Each r As DataGridViewRow In _DGV.Rows
            Select Case r.Cells(0).Value
                Case 1
                    r.Cells(0).Style.BackColor = Color.LemonChiffon
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.LemonChiffon
                        r.Cells(2).Style.BackColor = Color.LemonChiffon
                    End If
                Case 2
                    r.Cells(0).Style.BackColor = Color.LightSteelBlue
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.LightSteelBlue
                        r.Cells(2).Style.BackColor = Color.LightSteelBlue
                    End If
                Case 3
                    r.Cells(0).Style.BackColor = Color.MistyRose
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.MistyRose
                        r.Cells(2).Style.BackColor = Color.MistyRose
                    End If
                Case 4
                    r.Cells(0).Style.BackColor = Color.Honeydew
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.Honeydew
                        r.Cells(2).Style.BackColor = Color.Honeydew
                    End If
                Case 5
                    r.Cells(0).Style.BackColor = Color.LightCyan
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.LightCyan
                        r.Cells(2).Style.BackColor = Color.LightCyan
                    End If
                Case 6
                    r.Cells(0).Style.BackColor = Color.Thistle
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.Thistle
                        r.Cells(2).Style.BackColor = Color.Thistle
                    End If
            End Select
            r.Cells(5).Style.BackColor = mainForm.color_belimlight
            r.Cells(6).Style.BackColor = mainForm.color_PRLighting
            r.Cells(7).Style.BackColor = mainForm.color_blackout
            r.Cells(8).Style.BackColor = mainForm.color_vision
            r.Cells(9).Style.BackColor = mainForm.color_stage

            _DGV.Columns(21).Visible = False

            r.Cells(22).Style.BackColor = mainForm.color_belimlight
            'r.Cells(22).Value = 0
            r.Cells(23).Style.BackColor = mainForm.color_PRLighting
            'r.Cells(23).Value = 0
            r.Cells(24).Style.BackColor = mainForm.color_blackout
            'r.Cells(24).Value = 0
            r.Cells(25).Style.BackColor = mainForm.color_vision
            'r.Cells(25).Value = 0
            r.Cells(26).Style.BackColor = mainForm.color_stage
            'r.Cells(26).Value = 0


        Next r



        _DGV.Columns(1).Width = 30
        _DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter                      ' Cat
        _DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(2).MinimumWidth = 80
        _DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(2).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)           ' ID
        _DGV.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(3).MinimumWidth = 430
        _DGV.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(242, 245, 245)
        _DGV.Columns(3).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)           ' Fixture
        _DGV.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(4).MinimumWidth = 50
        _DGV.Columns(4).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)           ' Q-ty
        _DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(5).Visible = True                                                                             ' BelImlight
        _DGV.Columns(5).Width = 50
        _DGV.Columns(5).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(6).Visible = True                                                                             ' PRLightigTouring
        _DGV.Columns(6).Width = 50
        _DGV.Columns(6).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(7).Visible = True                                                                             ' BlackOut
        _DGV.Columns(7).Width = 50
        _DGV.Columns(7).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(8).Visible = True                                                                             ' Vision
        _DGV.Columns(8).Width = 50
        _DGV.Columns(8).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(9).Visible = True                                                                             ' Stage
        _DGV.Columns(9).Width = 50
        _DGV.Columns(9).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(10).MinimumWidth = 60
        _DGV.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(10).Visible = False          ' Weight
        _DGV.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(11).MinimumWidth = 68
        _DGV.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(11).Visible = False          ' Power
        _DGV.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(12).MinimumWidth = 60
        _DGV.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(12).Visible = False          ' Price

        _DGV.Columns(12).DefaultCellStyle.Format = NRFormat

        _DGV.Columns(13).Visible = False                                                                            ' OrderQty
        _DGV.Columns(14).Visible = False                                                                            ' R2
        _DGV.Columns(15).Visible = False                                                                            ' R3
        _DGV.Columns(16).Visible = False                                                                            ' R4          
        _DGV.Columns(17).Visible = False                                                                            ' R5
        _DGV.Columns(18).Visible = False                                                                            ' R6
        _DGV.Columns(19).Visible = False                                                                            ' R7
        _DGV.Columns(20).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(20).MinimumWidth = 60
        _DGV.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(20).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)          ' R8

        _DGV.Columns(21).Visible = True                                                                             ' BelImlight
        _DGV.Columns(21).Width = 50
        _DGV.Columns(21).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(21).DefaultCellStyle.ForeColor = Color.Red
        _DGV.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(22).Visible = True                                                                             ' BelImlight
        _DGV.Columns(22).Width = 50
        _DGV.Columns(22).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(23).Visible = True                                                                             ' PRLightigTouring
        _DGV.Columns(23).Width = 50
        _DGV.Columns(23).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(24).Visible = True                                                                             ' BlackOut
        _DGV.Columns(24).Width = 50
        _DGV.Columns(24).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(25).Visible = True                                                                             ' Vision
        _DGV.Columns(25).Width = 50
        _DGV.Columns(25).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(26).Visible = True                                                                             ' Stage
        _DGV.Columns(26).Width = 50
        _DGV.Columns(26).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' _DGV.Rows(_DGV.Rows.Count - 1).Visible = False
        _DGV.ClearSelection()
    End Sub
End Module
