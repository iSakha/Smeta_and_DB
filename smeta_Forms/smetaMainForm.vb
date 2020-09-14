Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Public Class smetaMainForm

    Dim dt_Global As DataTable

    '===================================================================================
    '             === Load Smeta Form  ===
    '===================================================================================
    Private Sub smetaMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        createGlobal_dt()
        format_DGV_smeta(DGV_db)
        format_DGV_smeta(DGV_smeta)
        txt_pwr.Text = 0
        txt_price.Text = 0
        txt_weight.Text = 0

        Dim dateOne = DTP_start.Value
        Dim dateTwo = DTP_end.Value
        Dim diff As TimeSpan = dateTwo - dateOne
        Dim days = diff.Days

        txt_daysQty.Text = days

        '           Fill up cities combobox
        '----------------------------------------------------------------
        Dim sPath As String
        sPath = mainForm.sDir & "\Log.txt"
        Dim ws As ExcelWorksheet
        Dim excelFile = New FileInfo(sPath)
        Dim xlTbl As ExcelTable
        Dim city As String
        Dim endRow As Integer

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage(excelFile)

        ws = Excel.Workbook.Worksheets("Location")

        xlTbl = ws.Tables("Cities")
        endRow = xlTbl.Address.End.Row
        For i As Integer = 2 To endRow
            city = ws.Cells(i, 2).Value
            cmb_eventCity.Items().Add(city)
        Next i

        lbl_cat_value.Text = ""

        lbl_depart_value.Text = "Lighting"
        lbl_depart_value.BackColor = btn_lighting_smeta.BackColor
        DGV_db.ClearSelection()

        lbl_currency.Text = "USD"

        '   Save currency rate to settings
        '----------------------------------------
        mainForm.USD_rate = My.Settings.USD_rate
        mainForm.Euro_rate = My.Settings.Euro_rate
        mainForm.rusRub_rate = My.Settings.rusRub_rate
        mainForm.BYN_rate = My.Settings.BYN_rate

        '   Create List of companies' buttons
        '----------------------------------------
        mainForm.btnsAdvSmeta = New List(Of Control)

        For Each ctrl As Control In Me.tbCtrl_smeta.TabPages(3).Controls

            If ctrl.Tag = "adv" Then
                mainForm.btnsAdvSmeta.Add(ctrl)
            End If
        Next ctrl

    End Sub

    '           Fill up locations combobox
    '----------------------------------------------------------------
    Private Sub cmb_eventCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_eventCity.SelectedIndexChanged

        cmb_eventLocation.Items.Clear()
        cmb_eventLocation.Text = ""
        Dim sPath As String
        sPath = mainForm.sDir & "\Log.txt"
        Dim ws As ExcelWorksheet
        Dim excelFile = New FileInfo(sPath)
        Dim xlTbl As ExcelTable
        Dim city, location As String
        Dim endRow, startColumn As Integer

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage(excelFile)

        ws = Excel.Workbook.Worksheets("Location")
        city = "City_" & cmb_eventCity.SelectedIndex.ToString
        'Console.WriteLine(city)
        xlTbl = ws.Tables(city)
        startColumn = xlTbl.Address.Start.Column
        endRow = xlTbl.Address.End.Row

        For i As Integer = 2 To endRow
            location = ws.Cells(i, startColumn).Value
            cmb_eventLocation.Items().Add(location)
        Next i
    End Sub

    '===================================================================================
    '             === Select Department buttons ===
    '===================================================================================
#Region "Select Department buttons"
    '             === Lighting button ===
    '===================================================================================
    Private Sub btn_lighting_smeta_Click(sender As Object, e As EventArgs) Handles btn_lighting_smeta.Click
        setScroll(1001001)
        changeButtonStyle(sender)
    End Sub
    '             === Screen button ===
    '===================================================================================
    Private Sub btn_screen_smeta_Click(sender As Object, e As EventArgs) Handles btn_screen_smeta.Click
        setScroll(2001001)
        changeButtonStyle(sender)
    End Sub
    '             === Commutation button ===
    '===================================================================================
    Private Sub btn_commut_smeta_Click(sender As Object, e As EventArgs) Handles btn_commut_smeta.Click
        setScroll(3001001)
        changeButtonStyle(sender)
    End Sub
    '             === Trusses and motors button ===
    '===================================================================================
    Private Sub btn_truss_smeta_Click(sender As Object, e As EventArgs) Handles btn_truss_smeta.Click
        setScroll(4001001)
        changeButtonStyle(sender)
    End Sub
    '             === Construction button ===
    '===================================================================================
    Private Sub btn_construct_smeta_Click(sender As Object, e As EventArgs) Handles btn_construct_smeta.Click
        setScroll(5001001)
        changeButtonStyle(sender)
    End Sub
    '             === Sound button ===
    '===================================================================================
    Private Sub btn_sound_smeta_Click(sender As Object, e As EventArgs) Handles btn_sound_smeta.Click
        setScroll(6001001)
        changeButtonStyle(sender)
    End Sub
#End Region
    Private Sub DGV_smeta_Scroll(sender As Object, e As ScrollEventArgs) _
     Handles DGV_db.Scroll

        'Console.WriteLine(DGV_db.FirstDisplayedScrollingRowIndex)

    End Sub
    '===================================================================================
    '             === DGV_smeta CellClick ===
    '===================================================================================
    Private Sub DGV_smeta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_db.CellClick
        DGV_smeta_clickCell(sender, e)
    End Sub

    Private Sub DGV_smeta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV_db.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            enumRows()
        End If
    End Sub
    '===================================================================================
    '             === Go to smeta button ===
    '===================================================================================
    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click

        mainForm.USD_val = New Collection
        mainForm.Euro_val = New Collection
        mainForm.rusRub_val = New Collection
        mainForm.BYN_val = New Collection

        Dim targetRows = enumRows()

        DGV_smeta.Rows.Clear()

        For Each drr As DataGridViewRow In enumRows()
            Dim row As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
            For i As Integer = 0 To drr.Cells.Count - 1
                row.Cells(i).Value = drr.Cells(i).Value
                row.DefaultCellStyle.BackColor = SystemColors.Window
            Next

            mainForm.USD_val.Add(Math.Round(row.Cells(12).Value * mainForm.USD_rate))
            mainForm.Euro_val.Add(Math.Round(row.Cells(12).Value * mainForm.Euro_rate))
            mainForm.rusRub_val.Add(Math.Round(row.Cells(12).Value * mainForm.rusRub_rate * 100))
            mainForm.BYN_val.Add(Math.Round(row.Cells(12).Value * mainForm.BYN_rate))

            DGV_smeta.Rows.Add(row)
        Next

        tbCtrl_smeta.SelectedIndex = 1
        DGV_smeta.ClearSelection()
        rbtn_usd.Checked = True

    End Sub

    Private Sub btn_clr_filter_Click(sender As Object, e As EventArgs) Handles btn_clr_filter.Click
        tbCtrl_smeta.SelectedIndex = 0
    End Sub

    Private Sub DTP_start_ValueChanged(sender As Object, e As EventArgs) Handles DTP_start.ValueChanged
        Dim dateOne = DTP_start.Value
        Dim dateTwo = DTP_end.Value
        Dim diff As TimeSpan = dateTwo - dateOne
        Dim days = diff.Days
        txt_daysQty.Text = days

        DTP_end.Visible = True
    End Sub

    Private Sub DTP_end_ValueChanged(sender As Object, e As EventArgs) Handles DTP_end.ValueChanged
        Dim dateOne = DTP_start.Value
        Dim dateTwo = DTP_end.Value
        Dim diff As TimeSpan = dateTwo - dateOne
        Dim days = diff.Days
        txt_daysQty.Text = days
    End Sub
    '===================================================================================
    '             === Write Smeta to Excel file ===
    '===================================================================================
    Private Sub btn_writeToExcel_Click(sender As Object, e As EventArgs) Handles btn_writeToExcel.Click

        Dim dgv As DataGridView = DGV_smeta
        Dim row As DataGridViewRow
        Dim startRow As Integer = 7
        Dim xlTbl As ExcelTable

        Dim sDepartmentName As List(Of String)
        Dim sCategoryName As List(Of String)

        Dim currentDepartment, currentCategory As Integer

        Dim colFont As Color = Color.FromArgb(0, 32, 96)
        Dim colBack As Color = Color.FromArgb(242, 245, 245)
        Dim colBorder As Color = Color.FromArgb(200, 200, 220)
        Dim colQtyFont As Color = Color.FromArgb(255, 102, 0)
        Dim colBackQty As Color = Color.FromArgb(255, 204, 153)
        Dim colBackReserv As Color = Color.FromArgb(217, 217, 217)

        Dim rng As ExcelRange

        currentDepartment = 0
        currentCategory = 0

        mainForm.sSmetaDir = My.Settings.smetaDBpath
        Dim path As String
        path = mainForm.sSmetaDir & "\SmetaTemplate.xlsx"

        Dim wsSmeta, wsServ As ExcelWorksheet
        Dim excelFile = New FileInfo(path)

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage(excelFile)

        wsServ = Excel.Workbook.Worksheets("Serv")
        wsSmeta = Excel.Workbook.Worksheets("Smeta")

        xlTbl = wsServ.Tables("Department")

        sDepartmentName = New List(Of String)

        '   Create List of DepartmentNames
        '----------------------------------------------------------------------------
        For i As Integer = 0 To xlTbl.Address.End.Row
            sDepartmentName.Add(wsServ.Cells(i + 3, 2).Value)
            'Console.WriteLine(sDepartmentName(i))
        Next i

        '   Copy rows from Smeta datagridview to Excel sheet "Smeta"
        '----------------------------------------------------------------------------

        Dim rowsQty As Integer = DGV_smeta.Rows.Count - 1


        For i As Integer = 0 To rowsQty

            row = DGV_smeta.Rows(i)

            If row.Cells(0).Value > 0 Then

                If row.Cells(0).Value = currentDepartment Then
                    '    Nothing
                    If row.Cells(1).Value = currentCategory Then
                        '    Nothing
                    Else
                        '   write CATEGORY name
                        currentCategory = row.Cells(1).Value
                        sCategoryName = loadCategoryName(wsServ, currentDepartment)
                        wsSmeta.Cells(startRow, 3, startRow, 6).Merge = True
                        wsSmeta.Cells(startRow, 3).Value = sCategoryName(currentCategory - 1)
                        wsSmeta.Cells(startRow, 3).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        wsSmeta.Cells(startRow, 3).Style.Font.Size = 12
                        wsSmeta.Cells(startRow, 3).Style.Font.Bold = True
                        wsSmeta.Cells(startRow, 3).Style.Font.Italic = True
                        startRow = startRow + 1
                    End If
                Else
                    '   write DEPARTMENT name
                    currentDepartment = row.Cells(0).Value
                    wsSmeta.Cells(startRow, 3, startRow, 7).Merge = True
                    wsSmeta.Cells(startRow, 3).Value = sDepartmentName(currentDepartment - 1)
                    wsSmeta.Cells(startRow, 3).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    wsSmeta.Cells(startRow, 3).Style.Font.Size = 13
                    wsSmeta.Cells(startRow, 3).Style.Font.Bold = True
                    wsSmeta.Cells(startRow, 3).Style.Font.Color.SetColor(colFont)

                    startRow = startRow + 1
                    createDepHeader(startRow, wsSmeta)
                    startRow = startRow + 1
                    currentCategory = 0
                    sCategoryName = loadCategoryName(wsServ, currentDepartment)
                    If row.Cells(1).Value = currentCategory Then
                    Else
                        '   write CATEGORY name
                        currentCategory = row.Cells(1).Value
                        wsSmeta.Cells(startRow, 3, startRow, 6).Merge = True
                        wsSmeta.Cells(startRow, 3).Value = sCategoryName(currentCategory - 1)
                        wsSmeta.Cells(startRow, 3).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        wsSmeta.Cells(startRow, 3).Style.Font.Size = 12
                        wsSmeta.Cells(startRow, 3).Style.Font.Bold = True
                        wsSmeta.Cells(startRow, 3).Style.Font.Italic = True
                        startRow = startRow + 1
                    End If
                End If

                '   write data to excel row (fixture,price, qty etc...)

                wsSmeta.Cells(startRow, 3).Value = row.Cells(3).Value                                 ' Наименование, name
                wsSmeta.Cells(startRow, 4).Value = row.Cells(4).Value                                 ' Кол-во всего, qtt
                wsSmeta.Cells(startRow, 5).Value = row.Cells(10).Value                                ' Вес, weight
                wsSmeta.Cells(startRow, 6).Value = row.Cells(11).Value                                ' Мощность, power
                wsSmeta.Cells(startRow, 7).Value = (row.Cells(10).Value) * (row.Cells(20).Value)      ' Вес общ, weight total
                wsSmeta.Cells(startRow, 8).Value = row.Cells(20).Value                                ' заказанное кол-во, to take
                wsSmeta.Cells(startRow, 9).Value = 0                                                  ' Резерв
                wsSmeta.Cells(startRow, 10).Value = row.Cells(12).Value                               ' аренда 1 прибора, price per unit
                wsSmeta.Cells(startRow, 11).Value = (row.Cells(12).Value) * (row.Cells(20).Value)     ' Стоимость общая, total cost

                ' format data

                rng = wsSmeta.Cells(startRow, 3, startRow, 11)

                wsSmeta.Row(startRow).Style.Font.Italic = True

                wsSmeta.Row(startRow).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                wsSmeta.Cells(startRow, 3).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left

                wsSmeta.Cells(startRow, 3).Style.Font.Bold = True
                wsSmeta.Cells(startRow, 8, startRow, 11).Style.Font.Bold = True
                wsSmeta.Cells(startRow, 8).Style.Font.Color.SetColor(colQtyFont)


                wsSmeta.Cells(startRow, 3).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                wsSmeta.Cells(startRow, 7).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                wsSmeta.Cells(startRow, 10).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                wsSmeta.Cells(startRow, 11).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                wsSmeta.Cells(startRow, 8).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                wsSmeta.Cells(startRow, 9).Style.Fill.PatternType = Style.ExcelFillStyle.Solid


                wsSmeta.Cells(startRow, 3).Style.Fill.BackgroundColor.SetColor(colBack)
                wsSmeta.Cells(startRow, 7).Style.Fill.BackgroundColor.SetColor(colBack)
                wsSmeta.Cells(startRow, 10).Style.Fill.BackgroundColor.SetColor(colBack)
                wsSmeta.Cells(startRow, 11).Style.Fill.BackgroundColor.SetColor(colBack)
                wsSmeta.Cells(startRow, 8).Style.Fill.BackgroundColor.SetColor(colBackQty)
                wsSmeta.Cells(startRow, 9).Style.Fill.BackgroundColor.SetColor(colBackReserv)

                rng.Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
                rng.Style.Border.Top.Color.SetColor(colBorder)
                rng.Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
                rng.Style.Border.Left.Color.SetColor(colBorder)
                rng.Style.Border.Right.Style = Style.ExcelBorderStyle.Thin
                rng.Style.Border.Right.Color.SetColor(colBorder)
                rng.Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin
                rng.Style.Border.Bottom.Color.SetColor(colBorder)

                '   Add discount and summary

                If DGV_smeta.Rows(i).Cells(0).Value < DGV_smeta.Rows(i + 1).Cells(0).Value Then         'Check that this is last row in department (i.e. department changed)
                    startRow = startRow + 1
                    startRow = writeSummary(startRow, wsSmeta, DGV_smeta.Rows(i).Cells(0).Value)
                    startRow = discount(startRow, wsSmeta, DGV_smeta.Rows(i).Cells(0).Value)
                Else
                    If DGV_smeta.Rows(i + 1).Cells(0).Value = 0 Then
                        startRow = startRow + 1
                        startRow = writeSummary(startRow, wsSmeta, DGV_smeta.Rows(i).Cells(0).Value)
                        startRow = discount(startRow, wsSmeta, DGV_smeta.Rows(i).Cells(0).Value)
                    End If
                    startRow = startRow + 1
                End If
            End If
        Next i
        Excel.Save()

    End Sub
    '===================================================================================
    '             === Load list of Categories ===
    '===================================================================================
    Function loadCategoryName(_ws As ExcelWorksheet, _currentDepartment As Integer)
        Dim catName As List(Of String)
        Dim xlTbl As ExcelTable

        xlTbl = _ws.Tables(_currentDepartment)

        catName = New List(Of String)

        For i As Integer = 0 To xlTbl.Address.End.Row
            catName.Add(_ws.Cells(i + 2, xlTbl.Address.Start.Column).Value)

        Next i

        Return (catName)
    End Function
    '===================================================================================
    '          === Create Header of Department in Excel sheet "Smeta" ===
    '===================================================================================
    Sub createDepHeader(_rowIndex As Integer, _ws As ExcelWorksheet)

        Dim col_1 As Color = Color.FromArgb(242, 245, 245)
        Dim col_2 As Color = Color.FromArgb(200, 200, 220)
        Dim col_3 As Color = Color.FromArgb(217, 217, 217)
        Dim col_4 As Color = Color.FromArgb(255, 102, 0)
        Dim rng As ExcelRange = _ws.Cells(_rowIndex, 3, _rowIndex, 11)

        _ws.Cells(_rowIndex, 3).Value = "Наименование, name"
        _ws.Cells(_rowIndex, 4).Value = "Кол-во всего, qtt"
        _ws.Cells(_rowIndex, 5).Value = "Вес, weight"
        _ws.Cells(_rowIndex, 6).Value = "Мощность, power"
        _ws.Cells(_rowIndex, 7).Value = "Вес общ, weight total"
        _ws.Cells(_rowIndex, 8).Value = "заказанное кол-во, to take"
        _ws.Cells(_rowIndex, 9).Value = "Резерв"
        _ws.Cells(_rowIndex, 10).Value = "аренда 1 прибора, price per unit"
        _ws.Cells(_rowIndex, 11).Value = "Стоимость общая, total cost"

        _ws.Row(_rowIndex).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
        _ws.Row(_rowIndex).Style.VerticalAlignment = Style.ExcelVerticalAlignment.Center
        _ws.Row(_rowIndex).Style.WrapText = True
        _ws.Row(_rowIndex).Height = 36
        _ws.Row(_rowIndex).Style.Font.Size = 9
        _ws.Cells(_rowIndex, 3).Style.Font.Size = 10
        rng.Style.Fill.PatternType = Style.ExcelFillStyle.Solid
        rng.Style.Fill.BackgroundColor.SetColor(col_1)
        _ws.Cells(_rowIndex, 8).Style.Font.Color.SetColor(col_4)
        _ws.Cells(_rowIndex, 9).Style.Fill.BackgroundColor.SetColor(col_3)
        _ws.Cells(_rowIndex, 3).Style.Font.Bold = True
        _ws.Cells(_rowIndex, 10).Style.Font.Bold = True
        _ws.Cells(_rowIndex, 11).Style.Font.Bold = True

        rng.Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
        rng.Style.Border.Top.Color.SetColor(col_2)
        rng.Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
        rng.Style.Border.Left.Color.SetColor(col_2)
        rng.Style.Border.Right.Style = Style.ExcelBorderStyle.Thin
        rng.Style.Border.Right.Color.SetColor(col_2)
        rng.Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin
        rng.Style.Border.Bottom.Color.SetColor(col_2)

    End Sub
    '===================================================================================
    '             === Write summary values to Excel ===
    '===================================================================================
    Function writeSummary(_rowIndex As Integer, _ws As ExcelWorksheet, _depIndex As Integer)
        Dim rng As ExcelRange

        _ws.Row(_rowIndex).Height = 30
        _ws.Cells(_rowIndex, 3).Value = "ИТОГО:"
        _ws.Cells(_rowIndex, 3).Style.Font.Size = 14
        _ws.Cells(_rowIndex, 3).Style.Font.Bold = True
        _ws.Cells(_rowIndex, 3).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
        _ws.Cells(_rowIndex, 3).Style.VerticalAlignment = Style.ExcelVerticalAlignment.Center

        _ws.Cells(_rowIndex, 7).Value = mainForm.weight(_depIndex - 1)
        _ws.Cells(_rowIndex, 8).Value = mainForm.qty(_depIndex - 1)
        _ws.Cells(_rowIndex, 9).Value = 0
        _ws.Cells(_rowIndex, 11).Value = mainForm.price(_depIndex - 1)

        rng = _ws.Cells(_rowIndex, 7, _rowIndex, 11)
        rng.Style.Font.Size = 12
        rng.Style.Font.Bold = True

        rng.Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
        rng.Style.VerticalAlignment = Style.ExcelVerticalAlignment.Center

        _rowIndex = _rowIndex + 3

        Return (_rowIndex)

    End Function


    '===================================================================================
    '             === Discount function ===
    '===================================================================================
    Function discount(_rowIndex As Integer, _ws As ExcelWorksheet, _depIndex As Integer)
        If mainForm.discountStatus(_depIndex - 1) Then
            _ws.Cells(_rowIndex, 3).Value = "Скидка,%"
            _ws.Cells(_rowIndex, 3).Style.Font.Size = 14
            _ws.Cells(_rowIndex, 3).Style.Font.Color.SetColor(Color.Red)
            _ws.Cells(_rowIndex, 3).Style.Font.Bold = True

            _ws.Cells(_rowIndex, 4).Value = mainForm.discountValue(_depIndex - 1)
            _ws.Cells(_rowIndex, 4).Style.Font.Size = 14
            _ws.Cells(_rowIndex, 4).Style.Font.Color.SetColor(Color.Red)
            _ws.Cells(_rowIndex, 4).Style.Font.Bold = True

            _rowIndex = _rowIndex + 1

            _ws.Cells(_rowIndex, 3).Value = "Цена со скидкой"
            _ws.Cells(_rowIndex, 3).Style.Font.Size = 14
            _ws.Cells(_rowIndex, 3).Style.Font.Bold = True
            _ws.Cells(_rowIndex, 3).Style.Font.UnderLine = True

            _ws.Cells(_rowIndex, 5).Value = mainForm.discountPrice(_depIndex - 1)
            _ws.Cells(_rowIndex, 5).Style.Font.Size = 14
            _ws.Cells(_rowIndex, 5).Style.Font.Bold = True


        End If
        _rowIndex = _rowIndex + 3
        Return (_rowIndex)
    End Function

    Private Sub btn_discount_Click(sender As Object, e As EventArgs) Handles btn_discount.Click
        discountForm.Show()
    End Sub
    '===================================================================================
    '             === Currency select ===
    '===================================================================================
    Private Sub rbtn_usd_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_usd.CheckedChanged
        If DGV_smeta.Rows.Count > 1 Then
            lbl_currency.Text = "USD"
            mainForm.selectedCurrency = "USD"
            changeCurrency(mainForm.USD_val)
        End If
    End Sub

    Private Sub rbtn_euro_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_euro.CheckedChanged
        If DGV_smeta.Rows.Count > 1 Then
            lbl_currency.Text = "Euro"
            mainForm.selectedCurrency = "Euro"
            changeCurrency(mainForm.Euro_val)
        End If
    End Sub

    Private Sub rbtn_rub_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_rub.CheckedChanged
        If DGV_smeta.Rows.Count > 1 Then
            lbl_currency.Text = "Rub"
            mainForm.selectedCurrency = "rusRub"
            changeCurrency(mainForm.rusRub_val)
        End If
    End Sub

    Private Sub rbtn_byn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_byn.CheckedChanged
        If DGV_smeta.Rows.Count > 1 Then
            lbl_currency.Text = "BYN"
            mainForm.selectedCurrency = "BYN"
            changeCurrency(mainForm.BYN_val)
        End If
    End Sub
    '===================================================================================
    '             === Show currency rate ===
    '===================================================================================
    Private Sub btn_show_curRates_Click(sender As Object, e As EventArgs) Handles btn_show_curRates.Click
        currencyForm.Show()
    End Sub
    '===================================================================================
    '             === Personnel ===
    '===================================================================================
    Private Sub btn_pers_Click(sender As Object, e As EventArgs) Handles btn_pers.Click
        tbCtrl_smeta.SelectedIndex = 2
    End Sub

    '===================================================================================
    '             === Advanced smeta ===
    '===================================================================================
    Private Sub btn_advSmeta_Click(sender As Object, e As EventArgs) Handles btn_advSmeta.Click

    End Sub

    '===================================================================================
    '             === Belimlight button ===
    '===================================================================================

    Private Sub btn_belimlight_Click(sender As Object, e As EventArgs) Handles btn_belimlight.Click
        disableSelected(sender)
    End Sub
    '===================================================================================
    '             === PRLighting button ===
    '===================================================================================

    Private Sub btn_prlighting_Click(sender As Object, e As EventArgs) Handles btn_prlighting.Click
        disableSelected(sender)
    End Sub
    '===================================================================================
    '             === Blackout button ===
    '===================================================================================

    Private Sub btn_blackout_Click(sender As Object, e As EventArgs) Handles btn_blackout.Click
        disableSelected(sender)
    End Sub
    '===================================================================================
    '             === Multivision button ===
    '===================================================================================

    Private Sub btn_vision_Click(sender As Object, e As EventArgs) Handles btn_vision.Click
        disableSelected(sender)
    End Sub
    '===================================================================================
    '             === Stage Engineering button ===
    '===================================================================================

    Private Sub btn_stage_Click(sender As Object, e As EventArgs) Handles btn_stage.Click
        disableSelected(sender)
    End Sub
    '===================================================================================
    '             === Reset button ===
    '===================================================================================
    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click

        For Each btn In mainForm.btnsAdvSmeta
            Console.WriteLine(btn.Name)
            btn.Enabled = True
            Select Case btn.Name
                Case "btn_belimlight"
                    btn.BackColor = Color.FromArgb(252, 228, 214)
                Case "btn_prlighting"
                    btn.BackColor = Color.FromArgb(221, 235, 247)
                Case "btn_blackout"
                    btn.BackColor = Color.FromArgb(237, 237, 237)
                Case "btn_vision"
                    btn.BackColor = Color.FromArgb(226, 239, 218)
                Case "btn_stage"
                    btn.BackColor = Color.FromArgb(237, 226, 246)
            End Select
        Next btn
    End Sub



End Class