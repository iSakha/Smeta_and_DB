﻿Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO



Public Class mainForm

    Public sDir, sSmetaDir As String
    Public sFilePath, sSmetaDB_Path As String
    Public sFileName As String

    Public fileNames As Collection
    Public filePath As Collection


    ' Dictionaries with Integer key
    Public i_wsDict As Dictionary(Of Integer, ExcelWorksheet)
    Public i_xlTableDict As Dictionary(Of Integer, ExcelTable)
    Public i_pivot_wsDict As Dictionary(Of Integer, Dictionary(Of Integer, ExcelWorksheet))
    Public i_pivotTableDict As Dictionary(Of Integer, Dictionary(Of Integer, ExcelTable))

    '   Allow to get any excel table by number of iDepartment, iCategory, iCompany
    '   for Console.WriteLine(example i_superPivotDict(0)(0)(0).name) - movHeads_tbl
    Public i_superPivotDict As Dictionary(Of Integer, Dictionary(Of Integer, Dictionary(Of Integer, ExcelTable)))

    Public iDepartment, iCategory, iCompany As Integer

    Public dts As DataSet
    Public selIndex As Integer      ' Selected index

    Public sCompany() As String = {"belimlight", "PRLighting", "blackout", "vision", "stage"}

    Public color_belimlight, color_PRLighting, color_blackout, color_vision, color_stage As Color
    Public companyColors(5) As Color
    Public delta As Integer     ' to increase or decrease table when push Add or Delete 

    Public exportDir As String

    Public cancelFlag As Boolean = False
    Public sumFormFlag As Boolean = False
    Public editFormFlag As Boolean = False

    Public light_dscnt_status, screen_dscnt_status, comm_dscnt_status, truss_dscnt_status,
        constr_dscnt_status, sound_dscnt_status As Boolean
    Public light_dscnt_val, screen_dscnt_val, comm_dscnt_val, truss_dscnt_val,
        constr_dscnt_val, sound_dscnt_val As Integer
    Public discountStatus(6) As Boolean
    Public discountValue(6) As Integer

    Public priceLighting, priceScreen, priceComm, priceTruss, priceConstr, priceSound As Integer

    Public qtyLighting, qtyScreen, qtyComm, qtyTruss, qtyConstr, qtySound As Integer
    Public weightLighting, weightScreen, weightComm, weightTruss, weightConstr, weightSound As Integer

    Public price(6) As Integer
    Public discountPrice(6) As Integer
    Public qty(6) As Integer
    Public weight(6) As Integer

    Public USD_val, Euro_val, rusRub_val, BYN_val As Collection
    Public USD_rate, Euro_rate, rusRub_rate, BYN_rate As Single

    Public selectedCurrency As String = "USD"

    Public btnsAdvSmeta As List(Of Control)
    Public tabsSmeta As List(Of TabPage)
    Public companyDGV As List(Of DataGridView)

    '===================================================================================
    '             === mainForm_Load ===
    '===================================================================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkExpirationDate()
        settingsForm.txt_pathDB.Text = My.Settings.databasePath

        If settingsForm.txt_pathDB.Text = "" Then
            MsgBox("Нужно указать путь к базе данных File => Load DB from")
        Else
            setParameters()
            load_db()

            iDepartment = 0
            iCategory = 0
            iCompany = 1

            menuItem_department.Enabled = True
            menuItem_company.Enabled = True

            cancelFlag = False

        End If

    End Sub
    '===================================================================================
    '             === File => Load DB from => Backup ===
    '===================================================================================
    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        loadFromBackup()
    End Sub
    '===================================================================================
    '             === File => Load DB from => Saved location ===
    '===================================================================================
    Private Sub SavedLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavedLocationToolStripMenuItem.Click
        Dim response = MsgBox("Последний бэкап был создан " & My.Settings.dateLastBackUp & vbCr & "Создать новый?", vbYesNo)
        If response = MsgBoxResult.Yes Then
            createBackup(timeStampFolder())
        Else

            setParameters()

            'sDir = My.Settings.databasePath


            'filePath = New Collection
            'fileNames = New Collection
            'Try
            '    For Each foundFile In My.Computer.FileSystem.GetFiles _
            '    (sDir, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.omdb")
            '        'Console.WriteLine(foundFile)
            '        filePath.Add(foundFile)

            '        Dim dIndex = StrReverse(foundFile).IndexOf("\")

            '        Dim name As String

            '        '   !!!!!!!!!!!!!!!!!!!!!!!!!!!!   хз почему не работают функции Right и Left в этом модуле !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            '        name = myRight(foundFile, dIndex)
            '        'Console.WriteLine(name)
            '        name = myLeft(name)
            '        'Console.WriteLine(name)
            '        fileNames.Add(name)

            '    Next

            'Catch
            'End Try

        End If
        load_db()

        iDepartment = 0
        iCategory = 0
        iCompany = 1

        menuItem_department.Enabled = True
        menuItem_company.Enabled = True

        cancelFlag = False

    End Sub
    '===================================================================================
    '             === Message after form was loaded  ===
    '===================================================================================
    Private Sub mainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MsgBox("База загружена!")
    End Sub
    '===================================================================================
    '             === Run settings ===
    '===================================================================================
    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        settingsForm.Show()
        settingsForm.btn_browse.Select()
    End Sub
    '===================================================================================
    '             === File => Load DB from => Specified location ===
    '===================================================================================
    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem.Click

        Dim response = MsgBox("Последний бэкап был создан " & My.Settings.dateLastBackUp & vbCr & "Создать новый?", vbYesNo)
        If response = MsgBoxResult.Yes Then
            createBackup(timeStampFolder())
        Else
            ' Show the FolderBrowserDialog.
            FBD.SelectedPath = Directory.GetCurrentDirectory()
            Dim result As DialogResult = FBD.ShowDialog()
            If (result = DialogResult.OK) Then
                sDir = FBD.SelectedPath

                My.Settings.databasePath = sDir
                settingsForm.txt_pathDB.Text = My.Settings.databasePath

            Else
                cancelFlag = True
            End If

            filePath = New Collection
            fileNames = New Collection
            Try
                For Each foundFile In My.Computer.FileSystem.GetFiles _
                (sDir, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.omdb")
                    'Console.WriteLine(foundFile)
                    filePath.Add(foundFile)

                    Dim dIndex = StrReverse(foundFile).IndexOf("\")

                    Dim name As String

                    '   !!!!!!!!!!!!!!!!!!!!!!!!!!!!   хз почему не работают функции Right и Left в этом модуле !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    name = myRight(foundFile, dIndex)
                    'Console.WriteLine(name)
                    name = myLeft(name)
                    'Console.WriteLine(name)
                    fileNames.Add(name)

                Next

            Catch
            End Try

        End If
        load_db()

        iDepartment = 0
        iCategory = 0
        iCompany = 1

        menuItem_department.Enabled = True
        menuItem_company.Enabled = True

        cancelFlag = False

    End Sub
    '===================================================================================
    '             === Export to Excel ===
    '===================================================================================
    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        exportExcel.Show()
    End Sub

#Region "select Lighting"
    Private Sub item_movHeads_Click(sender As Object, e As EventArgs) Handles item_movHeads.Click

        iDepartment = 0
        iCategory = 0
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_strobes_Click(sender As Object, e As EventArgs) Handles item_strobes.Click

        iDepartment = 0
        iCategory = 1
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_blinders_Click(sender As Object, e As EventArgs) Handles item_blinders.Click

        iDepartment = 0
        iCategory = 2
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_arch_Click(sender As Object, e As EventArgs) Handles item_arch.Click

        iDepartment = 0
        iCategory = 3
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_LED_Click(sender As Object, e As EventArgs) Handles item_LED.Click

        iDepartment = 0
        iCategory = 4
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_smoke_Click(sender As Object, e As EventArgs) Handles item_smoke.Click

        iDepartment = 0
        iCategory = 5
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_consoles_Click(sender As Object, e As EventArgs) Handles item_consoles.Click

        iDepartment = 0
        iCategory = 6
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_intercom_Click(sender As Object, e As EventArgs) Handles item_intercom.Click

        iDepartment = 0
        iCategory = 7
        writeToLabel("Lighting", sender)

    End Sub
#End Region

#Region "select Screen"
    Private Sub item_modules_Click(sender As Object, e As EventArgs) Handles item_modules.Click
        iDepartment = 1
        iCategory = 0
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_servers_Click(sender As Object, e As EventArgs) Handles item_servers.Click
        iDepartment = 1
        iCategory = 1
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_controllers1_Click(sender As Object, e As EventArgs) Handles item_controllers1.Click
        iDepartment = 1
        iCategory = 2
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_controllers2_Click(sender As Object, e As EventArgs) Handles item_controllers2.Click
        iDepartment = 1
        iCategory = 3
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_projectors_Click(sender As Object, e As EventArgs) Handles item_projectors.Click
        iDepartment = 1
        iCategory = 4
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_scr_construction_Click(sender As Object, e As EventArgs) Handles item_scr_construction.Click
        iDepartment = 1
        iCategory = 5
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_lightDesks_Click(sender As Object, e As EventArgs) Handles item_lightDesks.Click
        iDepartment = 1
        iCategory = 6
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_cameras_Click(sender As Object, e As EventArgs) Handles item_cameras.Click
        iDepartment = 1
        iCategory = 7
        writeToLabel("Screen", sender)
    End Sub
#End Region

#Region "Select Commutation"
    Private Sub item_pwrdistr_Click(sender As Object, e As EventArgs) Handles item_pwrdistr.Click
        iDepartment = 2
        iCategory = 0
        writeToLabel("Commutation", sender)
    End Sub

    Private Sub item_comm_Click(sender As Object, e As EventArgs) Handles item_comm.Click
        iDepartment = 2
        iCategory = 1
        writeToLabel("Commutation", sender)
    End Sub

    Private Sub item_pwrcomm_Click(sender As Object, e As EventArgs) Handles item_pwrcomm.Click
        iDepartment = 2
        iCategory = 2
        writeToLabel("Commutation", sender)
    End Sub

    Private Sub item_rest_Click(sender As Object, e As EventArgs) Handles item_rest.Click
        iDepartment = 2
        iCategory = 3
        writeToLabel("Commutation", sender)
    End Sub




#End Region

#Region "Select Truss and motors"
    Private Sub item_truss30x30_Click(sender As Object, e As EventArgs) Handles item_truss30x30.Click
        iDepartment = 3
        iCategory = 0
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_truss40x40_Click(sender As Object, e As EventArgs) Handles item_truss40x40.Click
        iDepartment = 3
        iCategory = 1
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_truss50x60_Click(sender As Object, e As EventArgs) Handles item_truss50x60.Click
        iDepartment = 3
        iCategory = 2
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_motors_Click(sender As Object, e As EventArgs) Handles item_motors.Click
        iDepartment = 3
        iCategory = 3
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_rigging_Click(sender As Object, e As EventArgs) Handles item_rigging.Click
        iDepartment = 3
        iCategory = 4
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_diff_Click(sender As Object, e As EventArgs) Handles item_diff.Click
        iDepartment = 3
        iCategory = 5
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_completeConstr_Click(sender As Object, e As EventArgs) Handles item_completeConstr.Click
        iDepartment = 3
        iCategory = 6
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_stagelifts_Click(sender As Object, e As EventArgs) Handles item_stagelifts.Click
        iDepartment = 3
        iCategory = 7
        writeToLabel("Trusses and motors", sender)
    End Sub
#End Region

#Region "Select Construction"
    Private Sub item_stageModules_Click(sender As Object, e As EventArgs) Handles item_stageModules.Click
        iDepartment = 4
        iCategory = 0
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_scaffold_J001_Click(sender As Object, e As EventArgs) Handles item_scaffold_J001.Click
        iDepartment = 4
        iCategory = 1
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_scaffold_J004_Click(sender As Object, e As EventArgs) Handles item_scaffold_J004.Click
        iDepartment = 4
        iCategory = 2
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_scaffold_steps_Click(sender As Object, e As EventArgs) Handles item_scaffold_steps.Click
        iDepartment = 4
        iCategory = 3
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_barricades_Click(sender As Object, e As EventArgs) Handles item_barricades.Click
        iDepartment = 4
        iCategory = 4
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_details_Click(sender As Object, e As EventArgs) Handles item_details.Click
        iDepartment = 4
        iCategory = 5
        writeToLabel("Construction", sender)
    End Sub
#End Region

#Region "Select Sound"
    Private Sub item_speakers_Click(sender As Object, e As EventArgs) Handles item_speakers.Click
        iDepartment = 5
        iCategory = 0
        writeToLabel("Sound", sender)
    End Sub

    Private Sub item_ampracks_Click(sender As Object, e As EventArgs) Handles item_ampracks.Click
        iDepartment = 5
        iCategory = 1
        writeToLabel("Sound", sender)
    End Sub

    Private Sub item_monitors_Click(sender As Object, e As EventArgs) Handles item_monitors.Click
        iDepartment = 5
        iCategory = 2
        writeToLabel("Sound", sender)
    End Sub

    Private Sub item_mixdesks_Click(sender As Object, e As EventArgs) Handles item_mixdesks.Click
        iDepartment = 5
        iCategory = 3
        writeToLabel("Sound", sender)
    End Sub

    Private Sub item_dj_stage_Click(sender As Object, e As EventArgs) Handles item_dj_stage.Click
        iDepartment = 5
        iCategory = 4
        writeToLabel("Sound", sender)
    End Sub

#End Region

#Region "select Company"
    Private Sub item_belimlight_Click(sender As Object, e As EventArgs) Handles item_belimlight.Click
        iCompany = 1
        writeToLabelCompany(sender)
        companyFunction()
    End Sub

    Private Sub item_PRLighting_Click(sender As Object, e As EventArgs) Handles item_PRLighting.Click
        iCompany = 2
        writeToLabelCompany(sender)
        companyFunction()
    End Sub

    Private Sub item_blackout_Click(sender As Object, e As EventArgs) Handles item_blackout.Click
        iCompany = 3
        writeToLabelCompany(sender)
        companyFunction()
    End Sub

    Private Sub item_vision_Click(sender As Object, e As EventArgs) Handles item_vision.Click
        iCompany = 4
        writeToLabelCompany(sender)
        companyFunction()
    End Sub

    Private Sub item_stage_Click(sender As Object, e As EventArgs) Handles item_stage.Click
        iCompany = 5
        writeToLabelCompany(sender)
        companyFunction()
    End Sub
    Private Sub item_summary_Click(sender As Object, e As EventArgs) Handles item_summary.Click

        sumForm.Show()
        sumFormFlag = True
        sumForm.dgv_sum.DataSource = dts.Tables(0)
        'sumForm.dgv_sum.Columns(8).Visible = False
        'sumForm.dgv_sum.Columns(9).Visible = False
        'sumForm.dgv_sum.Columns(10).Visible = False
        format_sumDGV()

    End Sub

#End Region

    '===================================================================================      
    '                === Up,Down,Select DGV row ===
    '===================================================================================

#Region "select DGV row"
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        dgv_clickCell(sender, e)
        calcQuantity()
    End Sub
    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        prevRecord()
        calcQuantity()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        nextRecord()
        calcQuantity()
    End Sub
#End Region
    '===================================================================================      
    '                === CRUD buttons ===
    '===================================================================================
#Region "CRUD buttons"
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        delta = 1
        editForm.Show()
        editForm.btn_add_addform.Visible = True
        editForm.btn_update_addform.Visible = False
        blockButtons()
        btn_save.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        delta = 0
        editForm.Show()
        editFormFlag = True
        editForm.btn_add_addform.Visible = False
        editForm.btn_update_addform.Visible = True
        showData(selIndex)
        btn_save.Enabled = True
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        deleteRow()
        delta = -1
        blockButtons()
        btn_save.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        saveButton(delta)
        load_db()
        unBlockButtons()
        btn_save.Enabled = False

    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        companyFunction()
        calcQuantity()
        If editFormFlag Then
            showData(0)
        End If
        Dim c As Color
        Select Case iCompany
            Case 1
                c = Color.FromArgb(252, 228, 214)
            Case 2
                c = Color.FromArgb(221, 235, 247)
            Case 3
                c = Color.FromArgb(237, 237, 237)
            Case 4
                c = Color.FromArgb(226, 239, 218)
            Case 5
                c = Color.FromArgb(237, 226, 246)
        End Select
        dgv.DataSource = dts.Tables(iCompany)

        sumForm.dgv_sum.DataSource = dts.Tables(0)
        format_sumDGV()
        unBlockButtons()
        btn_save.Enabled = False
    End Sub

#End Region

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    '===================================================================================      
    '                === Run paramForm ===
    '===================================================================================
    Private Sub CustomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomizeToolStripMenuItem.Click

        paramForm.Show()
        paramForm.lbl_dpartmentValue.Text = Me.lbl_dpartmentValue.Text
        paramForm.lbl_subsectionValue.Text = Me.lbl_subsectionValue.Text

        create_dataset(iDepartment, iCategory)
        paramForm.dgv.DataSource = dts.Tables(0)

        '                === Format dgv ===
        '===================================================================================

        paramForm.dgv.Columns(0).Visible = False           ' Department
        paramForm.dgv.Columns(1).Visible = False           ' Category
        paramForm.dgv.Columns(2).Width = 55                ' ID
        paramForm.dgv.Columns(3).MinimumWidth = 230               ' Fixture
        paramForm.dgv.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill               ' Fixture
        paramForm.dgv.Columns(4).Width = 65                ' Q-ty
        paramForm.dgv.Columns(5).Visible = False
        paramForm.dgv.Columns(6).Visible = False
        paramForm.dgv.Columns(7).Visible = False
        paramForm.dgv.Columns(8).Visible = False
        paramForm.dgv.Columns(9).Visible = False
        paramForm.dgv.Columns(10).Width = 65               ' Weight
        paramForm.dgv.Columns(11).Width = 65               ' Power/Length
        paramForm.dgv.Columns(12).Width = 65               ' Price
        paramForm.dgv.Columns(13).Visible = False          ' Result
        paramForm.dgv.Columns(14).Width = 65               ' Reserve 2
        paramForm.dgv.Columns(15).Width = 65               ' Reserve 3
        paramForm.dgv.Columns(16).Width = 65               ' Reserve 4
        paramForm.dgv.Columns(17).Width = 65               ' Reserve 5
        paramForm.dgv.Columns(18).Width = 65               ' Reserve 6
        paramForm.dgv.Columns(19).Width = 65               ' Reserve 7
        paramForm.dgv.Columns(20).Width = 65               ' Reserve 8

        paramForm.dgv.DefaultCellStyle.BackColor = Color.White
        paramForm.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 245, 240)

    End Sub

    '===================================================================================      
    '                === Run lost_n_foundForm ===
    '===================================================================================
    Private Sub LostAndFoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LostAndFoundToolStripMenuItem.Click
        lost_n_foundForm.Show()
    End Sub

    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        loginForm.Close()
    End Sub

    '===================================================================================      
    '                === Test button ===
    '===================================================================================
    Private Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        'copySmetaTemplate()
    End Sub

    '=================================================================================== 
    '===================================================================================      
    '                === SMETA SECTION ===
    '===================================================================================
    '=================================================================================== 
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        smetaMainForm.Show()
    End Sub


End Class
