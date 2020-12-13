Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO
Module smetaFunc

    Public targetRows As List(Of DataGridViewRow)
    Function createGlobal_dt()

        Dim dt As DataTable
        Dim row As DataRow

        Dim xlTable As ExcelTable
        Dim xlTable_Collection As Collection

        Dim adr As String
        Dim adr_Collection As Collection

        Dim ws As ExcelWorksheet

        Dim r_xlTable As Integer
        Dim r_xlTable_Collection As Collection

        Dim c_xlTable As Integer

        Dim rng As ExcelRange
        Dim rng_Collection As Collection

        dt = New DataTable
        dt.TableName = "Lighting"

        xlTable_Collection = New Collection
        adr_Collection = New Collection
        r_xlTable_Collection = New Collection
        c_xlTable = 21
        rng_Collection = New Collection



        For l As Integer = 0 To 5
            For i As Integer = 0 To mainForm.i_pivot_wsDict(l).Count - 1

                ws = mainForm.i_pivot_wsDict(l)(i)


                xlTable = ws.Tables(0)

                'Console.WriteLine(xlTable.Name)

                adr = xlTable.Address.Address
                r_xlTable = xlTable.Address.Rows
                rng = ws.Cells(adr)

                xlTable_Collection.Add(xlTable)
                adr_Collection.Add(adr)
                r_xlTable_Collection.Add(r_xlTable)
                rng_Collection.Add(rng)

            Next i
        Next l
        'Adding the Columns

        For i = 0 To c_xlTable - 1
            dt.Columns.Add(rng_Collection(1).Value(0, i))
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


        dt.Columns(13).DataType = System.Type.GetType("System.Int32")               ' R1 
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
        dt.Columns(14).ColumnName = "Qty_found"
        dt.Columns(15).ColumnName = "Ilya_Notes"
        dt.Columns(16).ColumnName = "R4"
        dt.Columns(17).ColumnName = "R5"
        dt.Columns(18).ColumnName = "R6"
        dt.Columns(19).ColumnName = "R7"
        dt.Columns(20).ColumnName = "OrderQty"



        Console.WriteLine(rng_Collection.Count)

        'Add Rows from Excel table

        For k As Integer = 1 To rng_Collection.Count            '   Categories
            'Console.WriteLine(k)
            For i = 1 To r_xlTable_Collection(k) - 1

                row = dt.Rows.Add()

                For j = 0 To c_xlTable - 1

                    row.Item(j) = rng_Collection(k).Value(i, j)

                Next j

            Next i

        Next k

        smetaMainForm.DGV_db.DataSource = dt

        Return (dt)

    End Function

    Sub setScroll(_value As Integer)
        Dim index As Integer

        For Each r As DataGridViewRow In smetaMainForm.DGV_db.Rows

            If r.Cells(2).Value = _value Then
                index = r.Index
                smetaMainForm.DGV_db.Rows(index).Selected = True
                smetaMainForm.DGV_db.FirstDisplayedScrollingRowIndex = index
                Exit Sub
            End If
        Next r
    End Sub
    '===================================================================================
    '             === Format DGV_smeta ===
    '===================================================================================
    Sub format_DGV_smeta(_DGV)
        Dim NRFormat As String = "### ### ##0"
        _DGV.RowHeadersVisible = False

        _DGV.Columns(0).Width = 30
        _DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter                      ' Dep

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
        _DGV.Columns(5).Visible = False                                                                             ' BelImlight
        _DGV.Columns(6).Visible = False                                                                             ' PRLightigTouring
        _DGV.Columns(7).Visible = False                                                                             ' BlackOut
        _DGV.Columns(8).Visible = False                                                                             ' Vision
        _DGV.Columns(9).Visible = False                                                                             ' Stage
        _DGV.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(10).MinimumWidth = 60
        _DGV.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(10).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)          ' Weight
        _DGV.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(11).MinimumWidth = 68
        _DGV.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(11).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)          ' Power
        _DGV.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DGV.Columns(12).MinimumWidth = 60
        _DGV.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(12).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)          ' Price

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


    End Sub
    '===================================================================================
    '             === Format advanced_smeta ===
    '===================================================================================
    Sub format_advanced_smeta(_DGV)
        Dim NRFormat As String = "### ### ##0"
        _DGV.RowHeadersVisible = False

        _DGV.Columns(0).Width = 30
        _DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter                      ' Dep

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

            r.Cells(21).Value = r.Cells(20).Value

            r.Cells(22).Style.BackColor = mainForm.color_belimlight
            r.Cells(22).Value = 0
            r.Cells(23).Style.BackColor = mainForm.color_PRLighting
            r.Cells(23).Value = 0
            r.Cells(24).Style.BackColor = mainForm.color_blackout
            r.Cells(24).Value = 0
            r.Cells(25).Style.BackColor = mainForm.color_vision
            r.Cells(25).Value = 0
            r.Cells(26).Style.BackColor = mainForm.color_stage
            r.Cells(26).Value = 0


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

        _DGV.Rows(_DGV.Rows.Count - 1).Visible = False
        _DGV.ClearSelection()


    End Sub

    Function odd_even(_value)
        Dim result As Boolean

        If _value Mod 2 = 0 Then
            result = False
        Else
            result = True
        End If
        Return result
    End Function
    '===================================================================================
    '             === DGV_smeta CellClick ===
    '===================================================================================
    Sub DGV_smeta_clickCell(_sender As Object, _e As DataGridViewCellEventArgs)
        enumRows()
        Dim index As Integer
        Dim row As DataGridViewRow
        index = _e.RowIndex
        row = _sender.Rows(index)
        mainForm.iDepartment = row.Cells(0).Value
        mainForm.iCategory = row.Cells(1).Value
        Dim color As Color
        color = row.Cells(0).Style.BackColor
        setLabels(color)

    End Sub

    Sub setLabels(_color)

        Dim departName As String
        departName = mainForm.fileNames(mainForm.iDepartment)
        departName = Right(departName, Len(departName) - 3)
        smetaMainForm.lbl_depart_value.Text = departName
        smetaMainForm.lbl_depart_value.BackColor = _color

        Dim catName As String
        catName = mainForm.i_pivot_wsDict(mainForm.iDepartment - 1)(mainForm.iCategory - 1).Name
        smetaMainForm.lbl_cat_value.Text = catName
        Console.WriteLine(catName)

    End Sub
    '===================================================================================
    '             === enumRows Function ===
    '===================================================================================
    Function enumRows()

        targetRows = New List(Of DataGridViewRow)

        Dim row As DataGridViewRow
        Dim totalPwr As Integer = 0
        Dim totalPrice As Integer = 0
        Dim totalWeight As Integer = 0

        mainForm.priceLighting = 0
        mainForm.priceScreen = 0
        mainForm.priceComm = 0
        mainForm.priceTruss = 0
        mainForm.priceConstr = 0
        mainForm.priceSound = 0

        mainForm.qtyLighting = 0
        mainForm.qtyScreen = 0
        mainForm.qtyComm = 0
        mainForm.qtyTruss = 0
        mainForm.qtyConstr = 0
        mainForm.qtySound = 0

        mainForm.weightLighting = 0
        mainForm.weightScreen = 0
        mainForm.weightComm = 0
        mainForm.weightTruss = 0
        mainForm.weightConstr = 0
        mainForm.weightSound = 0

        For Each row In smetaMainForm.DGV_db.Rows

            If row.Cells(20).Value > 0 Then

                row.DefaultCellStyle.BackColor = Color.Yellow
                targetRows.Add(row)

                ' Calculate department price,quantity and weight
                '---------------------------------------------------------------

                ' Calculate Lighting 

                If row.Cells(0).Value = 1 Then
                    mainForm.priceLighting = mainForm.priceLighting + (row.Cells(20).Value * row.Cells(12).Value)

                    mainForm.qtyLighting = mainForm.qtyLighting + row.Cells(20).Value
                    'Console.WriteLine(mainForm.qtyLighting)
                    mainForm.weightLighting = mainForm.weightLighting + (row.Cells(20).Value * row.Cells(10).Value)
                End If

                ' Calculate Screen 

                If row.Cells(0).Value = 2 Then
                    mainForm.priceScreen = mainForm.priceScreen + (row.Cells(20).Value * row.Cells(12).Value)
                    mainForm.qtyScreen = mainForm.qtyScreen + row.Cells(20).Value
                    mainForm.weightScreen = mainForm.weightScreen + (row.Cells(20).Value * row.Cells(10).Value)
                End If

                ' Calculate Commutation 

                If row.Cells(0).Value = 3 Then
                    mainForm.priceComm = mainForm.priceComm + (row.Cells(20).Value * row.Cells(12).Value)
                    mainForm.qtyComm = mainForm.qtyComm + row.Cells(20).Value
                    mainForm.weightComm = mainForm.weightComm + (row.Cells(20).Value * row.Cells(10).Value)
                End If

                ' Calculate Truss 

                If row.Cells(0).Value = 4 Then
                    mainForm.priceTruss = mainForm.priceTruss + (row.Cells(20).Value * row.Cells(12).Value)
                    mainForm.qtyTruss = mainForm.qtyTruss + row.Cells(20).Value
                    mainForm.weightTruss = mainForm.weightTruss + (row.Cells(20).Value * row.Cells(10).Value)
                End If

                ' Calculate Construction 

                If row.Cells(0).Value = 5 Then
                    mainForm.priceConstr = mainForm.priceConstr + (row.Cells(20).Value * row.Cells(12).Value)
                    mainForm.qtyConstr = mainForm.qtyConstr + row.Cells(20).Value
                    mainForm.weightConstr = mainForm.weightConstr + (row.Cells(20).Value * row.Cells(10).Value)
                End If

                ' Calculate Sound 

                If row.Cells(0).Value = 6 Then
                    mainForm.priceSound = mainForm.priceSound + (row.Cells(20).Value * row.Cells(12).Value)
                    mainForm.qtySound = mainForm.qtySound + row.Cells(20).Value
                    mainForm.weightSound = mainForm.weightSound + (row.Cells(20).Value * row.Cells(10).Value)
                End If


                '           Calculate total power for lighting,screen and sound
                If (row.Cells(0).Value = 1) Or (row.Cells(0).Value = 2) Or (row.Cells(0).Value = 6) Then
                    totalPwr = totalPwr + (row.Cells(11).Value) * (row.Cells(20).Value)
                End If

                '           Calculate total price
                totalPrice = totalPrice + (row.Cells(12).Value) * (row.Cells(20).Value)

                '           Calculate total weight

                totalWeight = totalWeight + (row.Cells(10).Value) * (row.Cells(20).Value)


            Else
                row.DefaultCellStyle.BackColor = SystemColors.Window
            End If

        Next row

        smetaMainForm.txt_pwr.Text = totalPwr
        smetaMainForm.txt_pwr.Text = Strings.Format(Val(smetaMainForm.txt_pwr.Text), "### ### ##0")

        smetaMainForm.txt_price.Text = mainForm.priceLighting + mainForm.priceScreen + mainForm.priceComm +
            mainForm.priceTruss + mainForm.priceConstr + mainForm.priceSound

        smetaMainForm.txt_price.Text = Strings.Format(Val(smetaMainForm.txt_price.Text), "### ### ##0")

        smetaMainForm.txt_weight.Text = totalWeight
        smetaMainForm.txt_weight.Text = Strings.Format(Val(smetaMainForm.txt_weight.Text), "### ### ##0")

        mainForm.qty(0) = mainForm.qtyLighting
        mainForm.qty(1) = mainForm.qtyScreen
        mainForm.qty(2) = mainForm.qtyComm
        mainForm.qty(3) = mainForm.qtyTruss
        mainForm.qty(4) = mainForm.qtyConstr
        mainForm.qty(5) = mainForm.qtySound

        mainForm.weight(0) = mainForm.weightLighting
        mainForm.weight(1) = mainForm.weightScreen
        mainForm.weight(2) = mainForm.weightComm
        mainForm.weight(3) = mainForm.weightTruss
        mainForm.weight(4) = mainForm.weightConstr
        mainForm.weight(5) = mainForm.weightSound

        mainForm.price(0) = mainForm.priceLighting
        mainForm.price(1) = mainForm.priceScreen
        mainForm.price(2) = mainForm.priceComm
        mainForm.price(3) = mainForm.priceTruss
        mainForm.price(4) = mainForm.priceConstr
        mainForm.price(5) = mainForm.priceSound

        Return (targetRows)

    End Function
    '===================================================================================
    '             === changeButtonStyle ===
    '===================================================================================
    Sub changeButtonStyle(_sender)

        smetaMainForm.DGV_db.ClearSelection()

        Dim departName As String = _sender.Text
        departName = Right(departName, Len(departName) - 3)

        smetaMainForm.lbl_depart_value.Text = departName
        smetaMainForm.lbl_depart_value.BackColor = _sender.BackColor

        smetaMainForm.lbl_cat_value.Text = ""

    End Sub

    '===================================================================================
    '             === changeCurrency function ===
    '===================================================================================
    Sub changeCurrency(_colCurrency As Collection)
        mainForm.priceLighting = 0
        mainForm.priceScreen = 0
        mainForm.priceComm = 0
        mainForm.priceTruss = 0
        mainForm.priceConstr = 0
        mainForm.priceSound = 0

        Dim totalPrice As Integer = 0

        For Each row As DataGridViewRow In smetaMainForm.DGV_smeta.Rows
            If row.Index < smetaMainForm.DGV_smeta.Rows.Count - 1 Then

                row.Cells(12).Value = _colCurrency(row.Index + 1)

                If row.Cells(0).Value = 1 Then
                    mainForm.priceLighting = mainForm.priceLighting + (row.Cells(20).Value * row.Cells(12).Value)
                End If

                If row.Cells(0).Value = 2 Then
                    mainForm.priceScreen = mainForm.priceScreen + (row.Cells(20).Value * row.Cells(12).Value)
                End If

                If row.Cells(0).Value = 3 Then
                    mainForm.priceComm = mainForm.priceComm + (row.Cells(20).Value * row.Cells(12).Value)
                End If

                If row.Cells(0).Value = 4 Then
                    mainForm.priceTruss = mainForm.priceTruss + (row.Cells(20).Value * row.Cells(12).Value)
                End If

                If row.Cells(0).Value = 5 Then
                    mainForm.priceConstr = mainForm.priceConstr + (row.Cells(20).Value * row.Cells(12).Value)
                End If

                If row.Cells(0).Value = 6 Then
                    mainForm.priceSound = mainForm.priceSound + (row.Cells(20).Value * row.Cells(12).Value)
                End If


                totalPrice = totalPrice + (row.Cells(12).Value) * (row.Cells(20).Value)
            End If
        Next row
        smetaMainForm.txt_price.Text = totalPrice

        For Each form In My.Application.OpenForms
            If (form.name = "discountForm") Then

                discountForm.txt_summary_light.Text = mainForm.priceLighting
                discountForm.txt_summary_screen.Text = mainForm.priceScreen
                discountForm.txt_summary_comm.Text = mainForm.priceComm
                discountForm.txt_summary_truss.Text = mainForm.priceTruss
                discountForm.txt_summary_constr.Text = mainForm.priceConstr
                discountForm.txt_summary_sound.Text = mainForm.priceSound

                discountForm.txt_summary_light_discount.Text = Math.Round(mainForm.priceLighting - mainForm.priceLighting * CInt(discountForm.txt_light_discount.Text) / 100)
                discountForm.txt_summary_screen_discount.Text = Math.Round(mainForm.priceScreen - mainForm.priceScreen * CInt(discountForm.txt_screen_discount.Text) / 100)
                discountForm.txt_summary_comm_discount.Text = Math.Round(mainForm.priceComm - mainForm.priceComm * CInt(discountForm.txt_commut_discount.Text) / 100)
                discountForm.txt_summary_truss_discount.Text = Math.Round(mainForm.priceTruss - mainForm.priceTruss * CInt(discountForm.txt_truss_discount.Text) / 100)
                discountForm.txt_summary_constr_discount.Text = Math.Round(mainForm.priceConstr - mainForm.priceConstr * CInt(discountForm.txt_constr_discount.Text) / 100)
                discountForm.txt_summary_sound_discount.Text = Math.Round(mainForm.priceSound - mainForm.priceSound * CInt(discountForm.txt_sound_discount.Text) / 100)

                discountForm.lbl_totalPrice.Text = mainForm.priceLighting + mainForm.priceScreen + mainForm.priceComm +
                mainForm.priceTruss + mainForm.priceConstr + mainForm.priceSound

                discountForm.lbl_totalPrice_discount.Text = CInt(discountForm.txt_summary_light_discount.Text) + CInt(discountForm.txt_summary_screen_discount.Text) +
                    CInt(discountForm.txt_summary_comm_discount.Text) + CInt(discountForm.txt_summary_truss_discount.Text) +
                    CInt(discountForm.txt_summary_constr_discount.Text) + CInt(discountForm.txt_summary_sound_discount.Text)

                discountForm.lbl_currency.Text = mainForm.selectedCurrency

            End If
        Next
        smetaMainForm.txt_price.Text = Strings.Format(Val(smetaMainForm.txt_price.Text), "### ### ##0")
    End Sub

    '===================================================================================
    '             === Show Qty by companies in dgvSmeta_qtyByCompany ===
    '===================================================================================
    Sub showSelectedRow(_sender As Object, _e As DataGridViewCellEventArgs)
        Dim index As Integer
        Dim row As DataGridViewRow
        index = _e.RowIndex
        row = _sender.Rows(index)
        mainForm.iDepartment = row.Cells(0).Value
        mainForm.iCategory = row.Cells(1).Value
        smetaMainForm.dgvSmeta_qtyByCompany.Rows(0).Cells(0).Value = row.Cells(5).Value
        smetaMainForm.dgvSmeta_qtyByCompany.Rows(0).Cells(1).Value = row.Cells(6).Value
        smetaMainForm.dgvSmeta_qtyByCompany.Rows(0).Cells(2).Value = row.Cells(7).Value
        smetaMainForm.dgvSmeta_qtyByCompany.Rows(0).Cells(3).Value = row.Cells(8).Value
        smetaMainForm.dgvSmeta_qtyByCompany.Rows(0).Cells(4).Value = row.Cells(9).Value
    End Sub
    '===================================================================================
    '             === Copy SmetaTemplate to SmetaOutput folder ===
    '===================================================================================

    Function copySmetaTemplate()

        Dim sourceFileName As String
        Dim destFileName As String
        Dim smetaName As String

        smetaName = InputBox("Введите название сметы", "Smeta Name")

        mainForm.sSmetaDir = My.Settings.smetaDBpath
        sourceFileName = mainForm.sSmetaDir & "\SmetaTemplate.xlsx"
        destFileName = mainForm.sSmetaDir & "\SmetaOutput\" & smetaName & ".xlsx"

        My.Computer.FileSystem.CopyFile(sourceFileName, destFileName)

        Return smetaName

    End Function
End Module
