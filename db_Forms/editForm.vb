﻿Public Class editForm

    Public fxtName As String
    Public fxtQty As Integer

    Public qty_belimlight1, qty_belimlight2, qty_belimlight3 As Integer
    Public qty_belimlight As Integer
    Public qty_PRlighting1, qty_PRlighting2, qty_PRlighting3 As Integer
    Public qty_PRlighting As Integer
    Public qty_blackout1, qty_blackout2, qty_blackout3 As Integer
    Public qty_blackout As Integer
    Public qty_vision1, qty_vision2, qty_vision3 As Integer
    Public qty_vision As Integer
    Public qty_stage1, qty_stage2, qty_stage3 As Integer
    Public qty_stage As Integer
    Public name_belimlight1, name_belimlight2, name_belimlight3 As String
    Public name_PRlighting1, name_PRlighting2, name_PRlighting3 As String
    Public name_blackout1, name_blackout2, name_blackout3 As String
    Public name_vision1, name_vision2, name_vision3 As String
    Public name_stage1, name_stage2, name_stage3 As String

    Dim add_update_mode As Boolean = False

    Dim txtBxs(4, 7) As Object

    Private Sub addForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBxs = New Object(4, 7) {
            {txt_name_addform, txt_qty_addform, txt_belimlight1_addform, txt_qty_belimlight1_addform,
            txt_belimlight2_addform, txt_qty_belimlight2_addform, txt_belimlight3_addform, txt_qty_belimlight3_addform},
            {txt_name_addform, txt_qty_addform, txt_PRlighting1_addform, txt_qty_PRlighting1_addform,
            txt_PRlighting2_addform, txt_qty_PRlighting2_addform, txt_PRlighting3_addform, txt_qty_PRlighting3_addform},
            {txt_name_addform, txt_qty_addform, txt_blackout1_addform, txt_qty_blackout1_addform,
            txt_blackout2_addform, txt_qty_blackout2_addform, txt_blackout3_addform, txt_qty_blackout3_addform},
            {txt_name_addform, txt_qty_addform, txt_vision1_addform, txt_qty_vision1_addform,
            txt_vision2_addform, txt_qty_vision2_addform, txt_vision3_addform, txt_qty_vision3_addform},
            {txt_name_addform, txt_qty_addform, txt_stage1_addform, txt_qty_stage1_addform,
            txt_stage2_addform, txt_qty_stage2_addform, txt_stage3_addform, txt_qty_stage3_addform}
        }

    End Sub
    Private Sub btn_update_addform_Click(sender As Object, e As EventArgs) Handles btn_update_addform.Click
        add_update_mode = False
        writeInto_dts()
    End Sub
    Private Sub btn_add_addform_Click(sender As Object, e As EventArgs) Handles btn_add_addform.Click
        add_update_mode = True
        writeInto_dts()
    End Sub
    Private Sub btn_close_addform_Click(sender As Object, e As EventArgs) Handles btn_close_addform.Click
        Me.Close()
    End Sub

    Sub writeIntoTxtbxs(_sRow As String, _i As Integer, _j As Integer)

        txtBxs(_i, _j).text = _sRow
        calculate()

    End Sub

    Sub calculate()

        qty_belimlight1 = Integer.Parse(txt_qty_belimlight1_addform.Text)
        qty_belimlight2 = Integer.Parse(txt_qty_belimlight2_addform.Text)
        qty_belimlight3 = Integer.Parse(txt_qty_belimlight3_addform.Text)

        qty_belimlight = qty_belimlight1 + qty_belimlight2 + qty_belimlight3

        qty_PRlighting1 = Integer.Parse(txt_qty_PRlighting1_addform.Text)
        qty_PRlighting2 = Integer.Parse(txt_qty_PRlighting2_addform.Text)
        qty_PRlighting3 = Integer.Parse(txt_qty_PRlighting3_addform.Text)

        qty_PRlighting = qty_PRlighting1 + qty_PRlighting2 + qty_PRlighting3

        qty_blackout1 = Integer.Parse(txt_qty_blackout1_addform.Text)
        qty_blackout2 = Integer.Parse(txt_qty_blackout2_addform.Text)
        qty_blackout3 = Integer.Parse(txt_qty_blackout3_addform.Text)

        qty_blackout = qty_blackout1 + qty_blackout2 + qty_blackout3

        qty_vision1 = Integer.Parse(txt_qty_vision1_addform.Text)
        qty_vision2 = Integer.Parse(txt_qty_vision2_addform.Text)
        qty_vision3 = Integer.Parse(txt_qty_vision3_addform.Text)

        qty_vision = qty_vision1 + qty_vision2 + qty_vision3

        qty_stage1 = Integer.Parse(txt_qty_stage1_addform.Text)
        qty_stage2 = Integer.Parse(txt_qty_stage2_addform.Text)
        qty_stage3 = Integer.Parse(txt_qty_stage3_addform.Text)

        qty_stage = qty_stage1 + qty_stage2 + qty_stage3

        txt_qty_belimlight.Text = qty_belimlight
        txt_qty_PRlighting.Text = qty_PRlighting
        txt_qty_blackout.Text = qty_blackout
        txt_qty_vision.Text = qty_vision
        txt_qty_stage.Text = qty_stage

    End Sub

    '===================================================================================
    '             === UPDATE data in DB ===
    '===================================================================================
    Sub writeInto_dts()

        fxtQty = Integer.Parse(txt_qty_addform.Text)

        qty_belimlight1 = Integer.Parse(txt_qty_belimlight1_addform.Text)
        qty_belimlight2 = Integer.Parse(txt_qty_belimlight2_addform.Text)
        qty_belimlight3 = Integer.Parse(txt_qty_belimlight3_addform.Text)

        qty_belimlight = qty_belimlight1 + qty_belimlight2 + qty_belimlight3

        qty_PRlighting1 = Integer.Parse(txt_qty_PRlighting1_addform.Text)
        qty_PRlighting2 = Integer.Parse(txt_qty_PRlighting2_addform.Text)
        qty_PRlighting3 = Integer.Parse(txt_qty_PRlighting3_addform.Text)

        qty_PRlighting = qty_PRlighting1 + qty_PRlighting2 + qty_PRlighting3

        qty_blackout1 = Integer.Parse(txt_qty_blackout1_addform.Text)
        qty_blackout2 = Integer.Parse(txt_qty_blackout2_addform.Text)
        qty_blackout3 = Integer.Parse(txt_qty_blackout3_addform.Text)

        qty_blackout = qty_blackout1 + qty_blackout2 + qty_blackout3

        qty_vision1 = Integer.Parse(txt_qty_vision1_addform.Text)
        qty_vision2 = Integer.Parse(txt_qty_vision2_addform.Text)
        qty_vision3 = Integer.Parse(txt_qty_vision3_addform.Text)

        qty_vision = qty_vision1 + qty_vision2 + qty_vision3

        qty_stage1 = Integer.Parse(txt_qty_stage1_addform.Text)
        qty_stage2 = Integer.Parse(txt_qty_stage2_addform.Text)
        qty_stage3 = Integer.Parse(txt_qty_stage3_addform.Text)

        qty_stage = qty_stage1 + qty_stage2 + qty_stage3

        txt_qty_belimlight.Text = qty_belimlight
        txt_qty_PRlighting.Text = qty_PRlighting
        txt_qty_blackout.Text = qty_blackout
        txt_qty_vision.Text = qty_vision
        txt_qty_stage.Text = qty_stage

        name_belimlight1 = txt_belimlight1_addform.Text
        name_belimlight2 = txt_belimlight2_addform.Text
        name_belimlight3 = txt_belimlight3_addform.Text

        name_PRlighting1 = txt_PRlighting1_addform.Text
        name_PRlighting2 = txt_PRlighting2_addform.Text
        name_PRlighting3 = txt_PRlighting3_addform.Text

        name_blackout1 = txt_blackout1_addform.Text
        name_blackout2 = txt_blackout2_addform.Text
        name_blackout3 = txt_blackout3_addform.Text

        name_vision1 = txt_vision1_addform.Text
        name_vision2 = txt_vision2_addform.Text
        name_vision3 = txt_vision3_addform.Text

        name_stage1 = txt_stage1_addform.Text
        name_stage2 = txt_stage2_addform.Text
        name_stage3 = txt_stage3_addform.Text

        fxtName = txt_name_addform.Text
        fxtQty = Integer.Parse(txt_qty_addform.Text)

        Dim sRow(4, 7) As String
        Dim row As DataRow
        Dim dt As DataTable

        'Console.WriteLine(index)
        sRow = New String(4, 7) {
            {fxtName, fxtQty, name_belimlight1, qty_belimlight1, name_belimlight2, qty_belimlight2, name_belimlight3, qty_belimlight3},
            {fxtName, fxtQty, name_PRlighting1, qty_PRlighting1, name_PRlighting2, qty_PRlighting2, name_PRlighting3, qty_PRlighting3},
            {fxtName, fxtQty, name_blackout1, qty_blackout1, name_blackout2, qty_blackout2, name_blackout3, qty_blackout3},
            {fxtName, fxtQty, name_vision1, qty_vision1, name_vision2, qty_vision2, name_vision3, qty_vision3},
            {fxtName, fxtQty, name_stage1, qty_stage1, name_stage2, qty_stage2, name_stage3, qty_stage3}
        }

        Select Case add_update_mode
            Case True
                ' Add function
                For i As Integer = 0 To mainForm.dts.Tables.Count - 2
                    dt = mainForm.dts.Tables(i + 1)
                    row = dt.Rows.Add()

                    row.Item(0) = dt.Rows(dt.Rows.Count - 2).Item(0)
                    row.Item(1) = dt.Rows(dt.Rows.Count - 2).Item(1)
                    row.Item(2) = dt.Rows(dt.Rows.Count - 2).Item(2) + 1

                    For j As Integer = 0 To 7
                        row.Item(j + 3) = sRow(i, j)
                    Next j
                    row.Item(0) = dt.Rows(dt.Rows.Count - 2).Item(0) + 1
                Next i
                ' add data to summary table
                dt = mainForm.dts.Tables(0)
                row = dt.Rows.Add()

                row.Item(0) = dt.Rows(dt.Rows.Count - 2).Item(0)
                row.Item(1) = dt.Rows(dt.Rows.Count - 2).Item(1)
                row.Item(2) = dt.Rows(dt.Rows.Count - 2).Item(2) + 1
                row.Item(3) = fxtName
                row.Item(4) = fxtQty
                row.Item(5) = qty_belimlight
                row.Item(6) = qty_PRlighting
                row.Item(7) = qty_blackout
                row.Item(8) = qty_vision
                row.Item(9) = qty_stage
                row.Item(10) = 0
                row.Item(11) = 0
                row.Item(12) = 0
                row.Item(13) = row.Item(4) - (row.Item(5) + row.Item(6) + row.Item(7) + row.Item(8) + row.Item(9))
                row.Item(14) = 0
                row.Item(15) = 0
                row.Item(16) = 0
                row.Item(17) = 0
                row.Item(18) = 0
                row.Item(19) = 0
                row.Item(20) = 0

            Case False
                Dim index As Integer = mainForm.dgv.CurrentRow.Index
                ' Update function
                For i As Integer = 0 To mainForm.dts.Tables.Count - 2
                    dt = mainForm.dts.Tables(i + 1)
                    row = dt.Rows(index)
                    For j As Integer = 0 To 7
                        dt.Rows(index).Item(j + 3) = sRow(i, j)
                    Next j
                Next i



                mainForm.dts.Tables(0).Rows(index).Item(mainForm.iCompany + 4) = fxtQty

                mainForm.dts.Tables(0).Rows(index).Item(5) = qty_belimlight
                mainForm.dts.Tables(0).Rows(index).Item(6) = qty_PRlighting
                mainForm.dts.Tables(0).Rows(index).Item(7) = qty_blackout
                mainForm.dts.Tables(0).Rows(index).Item(8) = qty_vision
                mainForm.dts.Tables(0).Rows(index).Item(9) = qty_stage
                Dim result As Integer
                result = fxtQty - (qty_belimlight + qty_PRlighting + qty_blackout + qty_vision + qty_stage)
                mainForm.dts.Tables(0).Rows(index).Item(13) = result
                mainForm.dts.AcceptChanges()
                mainForm.dgv.DataSource = mainForm.dts.Tables(mainForm.iCompany)

                sumForm.dgv_sum.DataSource = mainForm.dts.Tables(0)

        End Select

        'format_sumDGV()
        calcQuantity()
        blockButtons()

    End Sub
    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        mainForm.btn_next.PerformClick()
    End Sub
    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        mainForm.btn_prev.PerformClick()
    End Sub
    Private Sub editForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mainForm.editFormFlag = False
    End Sub
End Class