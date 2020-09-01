﻿Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.Drawing.Drawing2D
Imports System.IO

Module myFunc

    '===================================================================================
    '             === Write to labels ===
    '===================================================================================
#Region "WriteToLabels"
    Sub writeToLabel(_department As String, _sender As Object)
        mainForm.GroupBox1.Visible = True
        mainForm.GroupBox2.Visible = True
        mainForm.lbl_dpartmentValue.Text = _department
        mainForm.lbl_subsectionValue.Text = _sender.text
        mainForm.dgv.DataSource = Nothing
        sumForm.dgv_sum.DataSource = Nothing
    End Sub

    Sub writeToLabelCompany(_sender As Object)
        mainForm.GroupBox3.Visible = True
        mainForm.lbl_companyValue.Text = _sender.text
    End Sub
#End Region
    '===================================================================================
    '             === Create dataset ===
    '===================================================================================
    Sub create_dataset(_iDepartment As Integer, _iCategory As Integer)

        Dim dt As DataTable

        Dim xlTable As ExcelTable
        Dim adr As String
        Dim row As DataRow
        Dim ws As ExcelWorksheet
        Dim r_xlTable, c_xlTable As Integer
        Dim rng As ExcelRange


        mainForm.dts = New DataSet

        ws = mainForm.i_pivot_wsDict(_iDepartment)(_iCategory)
        Console.WriteLine(ws.Name)
        For k As Integer = 0 To ws.Tables.Count - 1

            xlTable = ws.Tables(k)
            c_xlTable = xlTable.Address.Columns
            r_xlTable = xlTable.Address.Rows

            adr = xlTable.Address.Address
            'Console.WriteLine(adr)
            rng = ws.Cells(adr)

            Select Case k

                Case = 0

                    dt = New DataTable
                    dt.TableName = xlTable.Name

                    'Adding the Columns
                    For i = 0 To c_xlTable - 1
                        dt.Columns.Add(rng.Value(0, i))
                    Next i

                    dt.Columns(0).DataType = System.Type.GetType("System.Int32")               ' Department
                    dt.Columns(1).DataType = System.Type.GetType("System.Int32")               ' Category
                    dt.Columns(2).DataType = System.Type.GetType("System.Int32")               ' ID
                    dt.Columns(3).DataType = System.Type.GetType("System.String")              ' Fixture
                    dt.Columns(4).DataType = System.Type.GetType("System.Int32")               ' Qty

                    dt.Columns(5).DataType = System.Type.GetType("System.Int32")               ' Qty BelImlight 
                    dt.Columns(6).DataType = System.Type.GetType("System.Int32")               ' Qty PRLightigTouring
                    dt.Columns(7).DataType = System.Type.GetType("System.Int32")               ' Qty BlackOut
                    dt.Columns(8).DataType = System.Type.GetType("System.Int32")               ' Qty Vision
                    dt.Columns(9).DataType = System.Type.GetType("System.Int32")               ' Qty Stage

                    dt.Columns(10).DataType = System.Type.GetType("System.Int32")               ' Weight
                    dt.Columns(11).DataType = System.Type.GetType("System.Int32")               ' Power/Length
                    dt.Columns(12).DataType = System.Type.GetType("System.Int32")               ' Price


                    dt.Columns(13).DataType = System.Type.GetType("System.Int32")               ' Result 
                    dt.Columns(14).DataType = System.Type.GetType("System.Int32")               ' R2
                    dt.Columns(15).DataType = System.Type.GetType("System.Int32")               ' R3
                    dt.Columns(16).DataType = System.Type.GetType("System.Int32")               ' R4
                    dt.Columns(17).DataType = System.Type.GetType("System.Int32")               ' R5 
                    dt.Columns(18).DataType = System.Type.GetType("System.Int32")               ' R6
                    dt.Columns(19).DataType = System.Type.GetType("System.Int32")               ' R7
                    dt.Columns(20).DataType = System.Type.GetType("System.Int32")               ' R8

                    dt.Columns(0).ColumnName = "Dep"
                    dt.Columns(1).ColumnName = "Cat"
                    dt.Columns(2).ColumnName = "ID"
                    dt.Columns(3).ColumnName = "Fixture"
                    dt.Columns(4).ColumnName = "Qty"

                    dt.Columns(10).ColumnName = "Weight"
                    dt.Columns(11).ColumnName = "Power/Length"
                    dt.Columns(12).ColumnName = "Price"

                    dt.Columns(13).ColumnName = "Result"
                    dt.Columns(14).ColumnName = "R2"
                    dt.Columns(15).ColumnName = "R3"
                    dt.Columns(16).ColumnName = "R4"
                    dt.Columns(17).ColumnName = "R5"
                    dt.Columns(18).ColumnName = "R6"
                    dt.Columns(19).ColumnName = "R7"
                    dt.Columns(20).ColumnName = "R8"

                    For i = 1 To r_xlTable - 1

                        row = dt.Rows.Add()

                        For j = 0 To c_xlTable - 1

                            row.Item(j) = rng.Value(i, j)

                        Next j

                        Dim val, val_bel, val_pr, val_black, val_vis, val_st As Integer

                        val = row.Item(4)
                        val_bel = row.Item(5)
                        val_pr = row.Item(6)
                        val_black = row.Item(7)
                        val_vis = row.Item(8)
                        val_st = row.Item(9)

                        row.Item(13) = val - (val_bel + val_pr + val_black + val_vis + val_st)

                    Next i

                Case > 0

                    dt = New DataTable
                    dt.TableName = xlTable.Name
                    Console.WriteLine(dt.TableName)
                    'Adding the Columns
                    For i = 0 To c_xlTable - 1
                        dt.Columns.Add(rng.Value(0, i))
                        'Console.WriteLine(rng.Value(0, i))
                    Next i

                    dt.Columns(0).DataType = System.Type.GetType("System.Int32")               ' Department
                    dt.Columns(1).DataType = System.Type.GetType("System.Int32")               ' Category
                    dt.Columns(2).DataType = System.Type.GetType("System.Int32")               ' ID
                    dt.Columns(3).DataType = System.Type.GetType("System.String")              ' Fixture
                    dt.Columns(4).DataType = System.Type.GetType("System.Int32")               ' Qty
                    dt.Columns(5).DataType = System.Type.GetType("System.String")              ' CompanyName_1
                    dt.Columns(6).DataType = System.Type.GetType("System.Int32")               ' Qty_1
                    dt.Columns(7).DataType = System.Type.GetType("System.String")              ' CompanyName_2
                    dt.Columns(8).DataType = System.Type.GetType("System.Int32")               ' Qty_2
                    dt.Columns(9).DataType = System.Type.GetType("System.String")              ' CompanyName_3
                    dt.Columns(10).DataType = System.Type.GetType("System.Int32")              ' Qty_3

                    dt.Columns(0).ColumnName = "Dep"
                    dt.Columns(1).ColumnName = "Cat"
                    dt.Columns(2).ColumnName = "ID"
                    dt.Columns(3).ColumnName = "Fixture"
                    dt.Columns(4).ColumnName = "Qty"
                    dt.Columns(5).ColumnName = "Name_1"
                    dt.Columns(6).ColumnName = "Qty_1"
                    dt.Columns(7).ColumnName = "Name_2"
                    dt.Columns(8).ColumnName = "Qty_2"
                    dt.Columns(9).ColumnName = "Name_3"
                    dt.Columns(10).ColumnName = "Qty_3"
                    'Add Rows from Excel table

                    For i = 1 To r_xlTable - 1
                        row = dt.Rows.Add()

                        For j = 0 To c_xlTable - 1

                            If rng.Value(i, j) = Nothing Then
                                Select Case j
                                    Case 3
                                        row.Item(j) = ""
                                    Case 4
                                        row.Item(j) = 0
                                    Case 5
                                        row.Item(j) = ""
                                    Case 6
                                        row.Item(j) = 0
                                    Case 7
                                        row.Item(j) = ""
                                    Case 8
                                        row.Item(j) = 0
                                    Case 9
                                        row.Item(j) = ""
                                    Case 10
                                        row.Item(j) = 0
                                End Select
                            Else
                                row.Item(j) = rng.Value(i, j)
                            End If

                        Next j
                    Next i

            End Select

            mainForm.dts.Tables.Add(dt)
        Next k

    End Sub

    '===================================================================================      
    '                === Format DataGridView ===
    '===================================================================================
#Region "Format DGV"
    Sub format_dgv_dataset()

        Dim c() As Color = {Color.FromArgb(252, 228, 214), Color.FromArgb(221, 235, 247), Color.FromArgb(237, 237, 237),
            Color.FromArgb(226, 239, 218), Color.FromArgb(237, 226, 246)}


        mainForm.dgv.Columns(0).Visible = False           ' Department  
        mainForm.dgv.Columns(1).Visible = False           ' Category  
        mainForm.dgv.Columns(2).Width = 60                ' ID
        mainForm.dgv.Columns(3).MinimumWidth = 175               ' Fixture
        mainForm.dgv.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        mainForm.dgv.Columns(4).Width = 40                ' Q-ty
        mainForm.dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        mainForm.dgv.Columns(5).MinimumWidth = 230               ' BelImlight_1  (PRLightigTouring, BlackOut, Vision, Stage)
        mainForm.dgv.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        mainForm.dgv.Columns(6).Width = 40                ' Q-ty_1
        mainForm.dgv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        mainForm.dgv.Columns(7).MinimumWidth = 230               ' BelImlight_2  (PRLightigTouring, BlackOut, Vision, Stage)
        mainForm.dgv.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        mainForm.dgv.Columns(8).Width = 40                ' Q-ty_2
        mainForm.dgv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        mainForm.dgv.Columns(9).MinimumWidth = 180               ' BelImlight_3  (PRLightigTouring, BlackOut, Vision, Stage)
        mainForm.dgv.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        mainForm.dgv.Columns(10).Width = 40                ' Q-ty_3
        mainForm.dgv.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        For i = 0 To mainForm.dgv.Rows.Count - 2

            'mainForm.DGV_in.Rows(i).Cells(1).Value = Date.FromOADate(mainForm.DGV_in.Rows(i).Cells(1).Value)
            mainForm.dgv.RowsDefaultCellStyle.BackColor = c(mainForm.iCompany - 1)
            mainForm.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)

        Next i

        mainForm.dgv.RowHeadersVisible = False
        mainForm.dgv.CurrentCell = mainForm.dgv.Item(2, 0)

    End Sub

    '===================================================================================
    '             === Format sumDGV ===
    '===================================================================================

    Sub format_sumDGV()

        Dim col() As Color

        col = {Color.FromArgb(252, 228, 214), Color.FromArgb(221, 235, 247), Color.FromArgb(237, 237, 237),
            Color.FromArgb(226, 239, 218), Color.FromArgb(237, 226, 246)}



        sumForm.dgv_sum.Columns(0).Visible = False           ' Department
        sumForm.dgv_sum.Columns(1).Visible = False           ' Category
        sumForm.dgv_sum.Columns(2).Width = 55                ' ID
        sumForm.dgv_sum.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill                 ' Fixture
        sumForm.dgv_sum.Columns(3).MinimumWidth = 230
        sumForm.dgv_sum.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill                 ' Q-ty
        sumForm.dgv_sum.Columns(4).DefaultCellStyle.Font = New Font("Tahoma", 10)
        sumForm.dgv_sum.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill                 ' BelImlight
        sumForm.dgv_sum.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill                 ' PRLightigTouring
        sumForm.dgv_sum.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill                 ' BlackOut
        sumForm.dgv_sum.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill                 ' Vision
        sumForm.dgv_sum.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill                 ' Stage
        sumForm.dgv_sum.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        sumForm.dgv_sum.Columns(10).Visible = False     ' Weight
        sumForm.dgv_sum.Columns(11).Visible = False     ' Power/Length
        sumForm.dgv_sum.Columns(12).Visible = False     ' Price

        sumForm.dgv_sum.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        sumForm.dgv_sum.Columns(13).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

        sumForm.dgv_sum.Columns(14).Visible = False
        sumForm.dgv_sum.Columns(15).Visible = False
        sumForm.dgv_sum.Columns(16).Visible = False
        sumForm.dgv_sum.Columns(17).Visible = False
        sumForm.dgv_sum.Columns(18).Visible = False
        sumForm.dgv_sum.Columns(19).Visible = False
        sumForm.dgv_sum.Columns(20).Visible = False

        sumForm.dgv_sum.Columns(5).DefaultCellStyle.BackColor = col(0)      ' BelImlight
        sumForm.dgv_sum.Columns(6).DefaultCellStyle.BackColor = col(1)      ' PRLightigTouring
        sumForm.dgv_sum.Columns(7).DefaultCellStyle.BackColor = col(2)      ' BlackOut
        sumForm.dgv_sum.Columns(8).DefaultCellStyle.BackColor = col(3)      ' Vision
        sumForm.dgv_sum.Columns(9).DefaultCellStyle.BackColor = col(4)      ' Stage



        For i = 0 To sumForm.dgv_sum.Rows.Count - 2

            sumForm.dgv_sum.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
            If sumForm.dgv_sum.Item(13, i).Value = 0 Then
                sumForm.dgv_sum.Item(2, i).Style.BackColor = Color.FromArgb(216, 238, 192)
                sumForm.dgv_sum.Item(3, i).Style.BackColor = Color.FromArgb(216, 238, 192)
                sumForm.dgv_sum.Item(4, i).Style.BackColor = Color.FromArgb(216, 238, 192)
                sumForm.dgv_sum.Item(13, i).Style.BackColor = Color.FromArgb(216, 238, 192)
            Else
                sumForm.dgv_sum.Item(2, i).Style.BackColor = Color.FromArgb(255, 183, 183)
                sumForm.dgv_sum.Item(3, i).Style.BackColor = Color.FromArgb(255, 183, 183)
                sumForm.dgv_sum.Item(4, i).Style.BackColor = Color.FromArgb(255, 183, 183)
                sumForm.dgv_sum.Item(13, i).Style.BackColor = Color.FromArgb(255, 183, 183)
            End If
        Next i

        '
        '
        'sumForm.dgv_sum.Columns(10).Visible = False
        'sumForm.dgv_sum.Columns(11).Visible = False
        'sumForm.dgv_sum.Columns(12).Visible = False

    End Sub
#End Region
    '===================================================================================
    '             === Select company function  ===
    '===================================================================================
    Sub companyFunction()
        create_dataset(mainForm.iDepartment, mainForm.iCategory)
        mainForm.dgv.DataSource = mainForm.dts.Tables(mainForm.iCompany)
        format_dgv_dataset()

        '   Check is form running
        If mainForm.sumFormFlag Then
            sumForm.dgv_sum.DataSource = mainForm.dts.Tables(0)
            format_sumDGV()
        End If
        mainForm.item_summary.Enabled = True
    End Sub
    '===================================================================================
    '             === CellClick on DGV ===
    '===================================================================================
    Sub dgv_clickCell(_sender As Object, _e As DataGridViewCellEventArgs)

        Dim index As Integer
        index = _e.RowIndex
        mainForm.selIndex = index
        'Console.WriteLine(_e)
        Dim selectedRow As DataGridViewRow
        selectedRow = _sender.Rows(index)

        mainForm.rtb_fixtureName.Text = selectedRow.Cells(3).Value.ToString
        mainForm.txt_qty.Text = selectedRow.Cells(4).Value.ToString
        mainForm.rtb_FirstName.Text = selectedRow.Cells(5).Value.ToString
        mainForm.txt_qty1.Text = selectedRow.Cells(6).Value.ToString
        mainForm.rtb_SecondName.Text = selectedRow.Cells(7).Value.ToString
        mainForm.txt_qty2.Text = selectedRow.Cells(8).Value.ToString
        mainForm.rtb_ThirdName.Text = selectedRow.Cells(9).Value.ToString
        mainForm.txt_qty3.Text = selectedRow.Cells(10).Value.ToString

        mainForm.dgv.Rows(index).Selected = True
        '   Check is form running
        If mainForm.sumFormFlag Then
            sumForm.dgv_sum.ClearSelection()
            sumForm.dgv_sum.Rows(index).Selected = True
        End If
        If mainForm.editFormFlag Then
            showData(index)
        End If
    End Sub
#Region "next/prev buttons"
    '===================================================================================
    '             === Prev record ===
    '===================================================================================
    Sub prevRecord()

        Dim index As Integer
        Dim selectedRow As DataGridViewRow


        index = mainForm.dgv.CurrentRow.Index
        mainForm.selIndex = index
        mainForm.dgv.ClearSelection()

        mainForm.dgv.CurrentCell = mainForm.dgv.Item(2, index)
        mainForm.dgv.Rows(index).Selected = True


        If index = 0 Then
            index = mainForm.dgv.Rows.Count - 1
        End If



        index = index - 1
        mainForm.dgv.CurrentCell = mainForm.dgv.Item(2, index)
        mainForm.dgv.Rows(index).Selected = True
        '   Check is form running
        If mainForm.sumFormFlag Then
            sumForm.dgv_sum.ClearSelection()
            sumForm.dgv_sum.Rows(index).Selected = True
        End If
        If mainForm.editFormFlag Then
            showData(index)
        End If

        selectedRow = mainForm.dgv.Rows(index)

        mainForm.rtb_fixtureName.Text = selectedRow.Cells(1).Value.ToString
        mainForm.txt_qty.Text = selectedRow.Cells(2).Value.ToString
        mainForm.rtb_FirstName.Text = selectedRow.Cells(3).Value.ToString
        mainForm.txt_qty1.Text = selectedRow.Cells(4).Value.ToString
        mainForm.rtb_SecondName.Text = selectedRow.Cells(5).Value.ToString
        mainForm.txt_qty2.Text = selectedRow.Cells(6).Value.ToString
        mainForm.rtb_ThirdName.Text = selectedRow.Cells(7).Value.ToString
        mainForm.txt_qty3.Text = selectedRow.Cells(8).Value.ToString


        'calcQuantity()

    End Sub

    '===================================================================================
    '             === Next record ===
    '===================================================================================
    Sub nextRecord()
        Dim index As Integer
        Dim selectedRow As DataGridViewRow

        index = mainForm.dgv.CurrentRow.Index
        mainForm.selIndex = index
        mainForm.dgv.ClearSelection()


        mainForm.dgv.CurrentCell = mainForm.dgv.Item(2, index)
        mainForm.dgv.Rows(index).Selected = True

        If index = mainForm.dgv.Rows.Count - 2 Then
            index = -1
        End If



        index = index + 1
        mainForm.dgv.CurrentCell = mainForm.dgv.Item(2, index)
        mainForm.dgv.Rows(index).Selected = True
        '   Check is form running

        If mainForm.sumFormFlag Then
            sumForm.dgv_sum.ClearSelection()
            sumForm.dgv_sum.Rows(index).Selected = True
        End If
        If mainForm.editFormFlag Then
            showData(index)
        End If


        selectedRow = mainForm.dgv.Rows(index)

        mainForm.rtb_fixtureName.Text = selectedRow.Cells(1).Value.ToString
        mainForm.txt_qty.Text = selectedRow.Cells(2).Value.ToString
        mainForm.rtb_FirstName.Text = selectedRow.Cells(3).Value.ToString
        mainForm.txt_qty1.Text = selectedRow.Cells(4).Value.ToString
        mainForm.rtb_SecondName.Text = selectedRow.Cells(5).Value.ToString
        mainForm.txt_qty2.Text = selectedRow.Cells(6).Value.ToString
        mainForm.rtb_ThirdName.Text = selectedRow.Cells(7).Value.ToString
        mainForm.txt_qty3.Text = selectedRow.Cells(8).Value.ToString

    End Sub
#End Region

    '===================================================================================
    '             === Calculate quantity ===
    '===================================================================================
    Sub calcQuantity()

        Dim index As Integer
        Dim j, qty, sum As Integer

        index = mainForm.dgv.CurrentRow.Index
        mainForm.selIndex = index

        For j = 1 To mainForm.dts.Tables.Count - 1

            'Console.WriteLine(mainForm.dts.Tables(j).TableName)

            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(0))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(1))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(2))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(3))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(4))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(5))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(6))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(7))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(8))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(9))
            'Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(10))


            sum = 0
            qty = mainForm.dts.Tables(j).Rows(index).Item(6)

            sum = sum + qty
            Console.WriteLine(sum)

            qty = mainForm.dts.Tables(j).Rows(index).Item(8)
            Console.WriteLine(mainForm.dts.Tables(j).Rows(index).Item(8))
            sum = sum + qty
            Console.WriteLine(sum)
            qty = mainForm.dts.Tables(j).Rows(index).Item(10)
            sum = sum + qty
            Console.WriteLine(sum)
            mainForm.dgv_result.Rows(0).Cells(j).Value = sum
            editForm.dgv_result.Rows(0).Cells(j).Value = sum
        Next j

        Dim smetaQty As Integer = mainForm.dts.Tables(0).Rows(index).Item(4)

        Dim companiesQty As Integer = mainForm.dgv_result.Rows(0).Cells(1).Value +
        mainForm.dgv_result.Rows(0).Cells(2).Value +
        mainForm.dgv_result.Rows(0).Cells(3).Value +
        mainForm.dgv_result.Rows(0).Cells(4).Value +
        mainForm.dgv_result.Rows(0).Cells(5).Value

        mainForm.dgv_result.Rows(0).Cells(0).Value = smetaQty
        editForm.dgv_result.Rows(0).Cells(0).Value = smetaQty
        mainForm.dgv_result.Rows(0).Cells(6).Value = smetaQty - companiesQty
        editForm.dgv_result.Rows(0).Cells(6).Value = smetaQty - companiesQty

        If (smetaQty - companiesQty = 0) Then
            mainForm.dgv_result.Item(6, 0).Style.BackColor = Color.LightGreen
            editForm.dgv_result.Item(6, 0).Style.BackColor = Color.LightGreen
        Else
            mainForm.dgv_result.Item(6, 0).Style.BackColor = Color.LightPink
            editForm.dgv_result.Item(6, 0).Style.BackColor = Color.LightPink
        End If
    End Sub
    '===================================================================================
    '             === DELETE data from DB ===
    '===================================================================================
    Sub deleteRow()

        Dim index As Integer = mainForm.dgv.CurrentRow.Index
        Dim row As DataRow

        For Each dt As DataTable In mainForm.dts.Tables
            row = dt.Rows(index)
            row.Delete()
        Next dt
    End Sub
    '===================================================================================
    '             === SAVE data to DB ===
    '===================================================================================

    Sub saveButton(_delta As Integer)

        Dim oldAddr As OfficeOpenXml.ExcelAddressBase
        Dim newAddr As OfficeOpenXml.ExcelAddressBase

        Dim dt As DataTable
        Dim ws As ExcelWorksheet

        Dim xlTable As ExcelTable
        Dim startCellAddress As String

        Dim excelFile = New FileInfo(mainForm.filePath(mainForm.iDepartment + 1))

        'Console.WriteLine(mainForm.filePath(mainForm.iDepartment + 1))

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage(excelFile)

        'Console.WriteLine(mainForm.iCategory)

        ws = Excel.Workbook.Worksheets(mainForm.iCategory)

        For i As Integer = 1 To mainForm.sCompany.Count

            dt = mainForm.dts.Tables(i)

            xlTable = ws.Tables(i)
            oldAddr = xlTable.Address
            xlTable.Range.Clear()
            newAddr = New ExcelAddressBase(oldAddr.Start.Row, oldAddr.Start.Column, oldAddr.End.Row + _delta, oldAddr.End.Column)
            xlTable.TableXml.InnerXml = xlTable.TableXml.InnerXml.Replace(oldAddr.ToString(), newAddr.ToString())

            startCellAddress = xlTable.Range.Start.Address

            ws.Cells(startCellAddress).LoadFromDataTable(dt, True)

        Next i

        '   Write to pivot Exceltable
        dt = mainForm.dts.Tables(0)

        xlTable = ws.Tables(0)
        oldAddr = xlTable.Address
        newAddr = New ExcelAddressBase(oldAddr.Start.Row, oldAddr.Start.Column, oldAddr.End.Row + _delta, oldAddr.End.Column)
        xlTable.TableXml.InnerXml = xlTable.TableXml.InnerXml.Replace(oldAddr.ToString(), newAddr.ToString())

        startCellAddress = xlTable.Range.Start.Address

        xlTable.Range.Clear()
        ws.Cells(startCellAddress).LoadFromDataTable(dt, True)



        formatXl_table(Excel, excelFile, mainForm.filePath(mainForm.iDepartment + 1), mainForm.iCategory)

        Excel.SaveAs(excelFile)



    End Sub

    '===================================================================================
    '             === block CDUDbuttons ===
    '===================================================================================
    Sub blockButtons()

        mainForm.btn_add.Enabled = False
        mainForm.btn_update.Enabled = False
        mainForm.btn_delete.Enabled = False
        mainForm.btn_next.Enabled = False
        mainForm.btn_prev.Enabled = False

        mainForm.menuItem_department.Enabled = False
        mainForm.menuItem_company.Enabled = False

        mainForm.btn_save.FlatStyle = FlatStyle.Flat
        mainForm.btn_cancel.FlatStyle = FlatStyle.Flat
    End Sub
    '===================================================================================
    '             === unblock CDUDbuttons ===
    '===================================================================================
    Sub unBlockButtons()

        mainForm.btn_add.Enabled = True
        mainForm.btn_update.Enabled = True
        mainForm.btn_delete.Enabled = True
        mainForm.btn_next.Enabled = True
        mainForm.btn_prev.Enabled = True

        mainForm.menuItem_department.Enabled = True
        mainForm.menuItem_company.Enabled = True

        mainForm.btn_save.FlatStyle = FlatStyle.Standard
        mainForm.btn_cancel.FlatStyle = FlatStyle.Standard

    End Sub

    Sub showData(_index)
        'Console.WriteLine(_index)
        'Console.WriteLine(mainForm.dts.Tables(0).TableName)

        Dim sRow(4, 7) As String

        sRow = New String(4, 7) {
            {editForm.fxtName, editForm.fxtQty, editForm.name_belimlight1, editForm.qty_belimlight1, editForm.
            name_belimlight2, editForm.qty_belimlight2, editForm.name_belimlight3, editForm.qty_belimlight3},
            {editForm.fxtName, editForm.fxtQty, editForm.name_PRlighting1, editForm.qty_PRlighting1, editForm.
            name_PRlighting2, editForm.qty_PRlighting2, editForm.name_PRlighting3, editForm.qty_PRlighting3},
            {editForm.fxtName, editForm.fxtQty, editForm.name_blackout1, editForm.qty_blackout1, editForm.
            name_blackout2, editForm.qty_blackout2, editForm.name_blackout3, editForm.qty_blackout3},
            {editForm.fxtName, editForm.fxtQty, editForm.name_vision1, editForm.qty_vision1, editForm.
            name_vision2, editForm.qty_vision2, editForm.name_vision3, editForm.qty_vision3},
            {editForm.fxtName, editForm.fxtQty, editForm.name_stage1, editForm.qty_stage1, editForm.
            name_stage2, editForm.qty_stage2, editForm.name_stage3, editForm.qty_stage3}
        }

        For i As Integer = 0 To mainForm.dts.Tables.Count - 2
            For j As Integer = 0 To 7
                sRow(i, j) = mainForm.dts.Tables(i + 1).Rows(_index).Item(j + 3)
                editForm.writeIntoTxtbxs(sRow(i, j), i, j)
            Next j
        Next i

    End Sub

    Sub updateData()
        mainForm.dgv.DataSource = mainForm.dts
    End Sub
    '===================================================================================
    '             === Format Excel table ===
    '===================================================================================

    Sub formatXl_table(_Excel As Object, _excelFile As Object, _sPath As String, _worksheetNumber As Integer)

        Dim rngHeader, rngSide, rngTbl_0(5) As ExcelRange

        Dim rngTbl_0_to_center As ExcelRange                ' For summary table

        Dim rngTbl_to_center As ExcelRange                  ' For company's table
        Dim rngTbl_to_center_1 As ExcelRange
        Dim rngTbl_to_center_2 As ExcelRange
        Dim rngTbl_to_center_3 As ExcelRange


        Dim startRow, startColumn, endRow As Integer
        Dim sideBackColor As Color = Color.FromArgb(242, 245, 245)
        Dim ws As ExcelWorksheet
        ws = _Excel.Workbook.Worksheets(_worksheetNumber)

        Dim col() As Color

        col = {Color.FromArgb(252, 228, 214), Color.FromArgb(221, 235, 247), Color.FromArgb(237, 237, 237),
            Color.FromArgb(226, 239, 218), Color.FromArgb(237, 226, 246)}

        Dim i As Integer = 0

        For Each tbl As ExcelTable In ws.Tables

            startRow = tbl.Address.Start.Row
            endRow = tbl.Address.End.Row
            startColumn = tbl.Address.Start.Column

            rngHeader = ws.Cells(startRow, startColumn + 3, startRow, startColumn + 8)

            rngSide = ws.Cells(startRow + 1, startColumn + 1, endRow, startColumn + 1)

            rngTbl_to_center = ws.Cells(startRow, startColumn + 2, endRow, startColumn + 2)
            rngTbl_to_center_1 = ws.Cells(startRow, startColumn + 4, endRow, startColumn + 4)
            rngTbl_to_center_2 = ws.Cells(startRow, startColumn + 6, endRow, startColumn + 6)
            rngTbl_to_center_3 = ws.Cells(startRow, startColumn + 8, endRow, startColumn + 8)

            rngTbl_0(0) = ws.Cells(startRow, startColumn + 3, endRow, startColumn + 3)
            rngTbl_0(1) = ws.Cells(startRow, startColumn + 4, endRow, startColumn + 4)
            rngTbl_0(2) = ws.Cells(startRow, startColumn + 5, endRow, startColumn + 5)
            rngTbl_0(3) = ws.Cells(startRow, startColumn + 6, endRow, startColumn + 6)
            rngTbl_0(4) = ws.Cells(startRow, startColumn + 7, endRow, startColumn + 7)

            rngTbl_0_to_center = ws.Cells(startRow, startColumn + 2, endRow, startColumn + 11)

            rngSide.Style.Fill.PatternType = Style.ExcelFillStyle.Solid
            rngSide.Style.Fill.BackgroundColor.SetColor(sideBackColor)

            rngSide.Style.Font.Size = 11
            rngSide.Style.Font.Italic = True
            rngSide.Style.Font.Bold = True
            rngSide.Style.Font.Name = "Calibri"

            Select Case i
                Case 0

                    For j As Integer = 0 To 4
                        rngTbl_0(j).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                        rngTbl_0(j).Style.Fill.BackgroundColor.SetColor(col(j))
                        rngTbl_0_to_center.Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    Next j

                Case <> 0

                    rngHeader.Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                    rngHeader.Style.Fill.BackgroundColor.SetColor(col(i - 1))

                    rngTbl_to_center.Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    rngTbl_to_center_1.Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    rngTbl_to_center_2.Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    rngTbl_to_center_3.Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center

                    rngTbl_to_center.Style.Font.Size = 11
                    rngTbl_to_center.Style.Font.Italic = True
                    rngTbl_to_center.Style.Font.Bold = True
                    rngTbl_to_center.Style.Font.Name = "Calibri"

            End Select

            i = i + 1

        Next tbl

        _Excel.SaveAs(_excelFile)

    End Sub
    '===================================================================================
    '             === Export dataset ===
    '===================================================================================
    Sub exportDataset(_iDepartment As Integer, _timeStampDir As String)

        Dim columnWidth(12) As Integer
        columnWidth = {4, 52, 9, 42, 25, 37, 11, 44, 13, 13, 13, 13}
        columnWidth = {4, 4, 9, 52, 9, 42, 25, 37, 11, 44, 13, 13, 13, 13, 13, 13, 13, 13}
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage()
        Dim objExcel, objExcelFile As Object
        objExcel = Excel

        Dim ws As ExcelWorksheet
        Dim xlTable As ExcelTable
        Dim xlTableName As String
        Dim startRow(6) As Integer
        Dim rng As ExcelRange
        Dim startColumn, endRow, endColumn, tiltShift As Integer
        Dim exportSheetName As String
        Dim exportFileName() As String = {"LightingExport", "ScreenExport", "CommutationExport" _
        , "Truss_and_motorsExport", "ConstructionExport", "SoundExport"}

        My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory() & "\ExcelExport\" & _timeStampDir)

        mainForm.exportDir = Directory.GetCurrentDirectory() & "\ExcelExport\" & _timeStampDir

        Dim sPath As String = mainForm.exportDir & "\" & exportFileName(_iDepartment) & ".xlsx"

        'Console.WriteLine(mainForm.i_pivot_wsDict(_iDepartment).Count - 1)

        For j As Integer = 0 To mainForm.i_pivot_wsDict(_iDepartment).Count - 1
            create_dataset(_iDepartment, j)
            tiltShift = 5
            startColumn = 3
            startRow(6) = New Integer()

            startRow(0) = 3
            endRow = startRow(0) + mainForm.dts.Tables(0).Rows.Count
            startRow(1) = endRow + tiltShift
            endRow = startRow(1) + mainForm.dts.Tables(1).Rows.Count
            startRow(2) = endRow + tiltShift
            endRow = startRow(2) + mainForm.dts.Tables(2).Rows.Count
            startRow(3) = endRow + tiltShift
            endRow = startRow(3) + mainForm.dts.Tables(2).Rows.Count
            startRow(4) = endRow + tiltShift
            endRow = startRow(4) + mainForm.dts.Tables(2).Rows.Count
            startRow(5) = endRow + tiltShift

            exportSheetName = mainForm.i_pivot_wsDict(_iDepartment)(j).Name
            ws = Excel.Workbook.Worksheets.Add(exportSheetName)

            For k As Integer = 0 To 11
                ws.Column(k + 3).Width = columnWidth(k)
            Next k

            For i As Integer = 0 To mainForm.dts.Tables.Count - 1

                endRow = startRow(i) + mainForm.dts.Tables(i).Rows.Count
                endColumn = startColumn + mainForm.dts.Tables(i).Columns.Count - 1
                xlTableName = mainForm.dts.Tables(i).TableName
                rng = ws.Cells(startRow(i), startColumn, endRow, endColumn)

                xlTable = ws.Tables.Add(rng, xlTableName)
                ws.Cells("C" & startRow(i)).LoadFromDataTable(mainForm.dts.Tables(i), True)
                xlTable.TableStyle = TableStyles.Light15

            Next i
            objExcelFile = New FileInfo(sPath)
            formatXl_table(objExcel, objExcelFile, sPath, j)
        Next j
        Excel.SaveAs(New FileInfo(sPath))
    End Sub

    '=================================================================================== 
    '===================================================================================      
    '                === I don't understand why !!! ===
    '===================================================================================
    '=================================================================================== 
    Function myRight(_foundFile, _dIndex)
        Dim name As String
        name = Right(_foundFile, _dIndex)
        Return name
    End Function

    Function myLeft(_name)
        Dim name As String
        name = Left(_name, Len(_name) - 5)
        Return name
    End Function

End Module
