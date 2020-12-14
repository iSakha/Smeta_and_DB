Imports System.IO

Public Class settingsForm

    '===================================================================================      
    '                === Set database path ===
    '===================================================================================
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        ' Show the FolderBrowserDialog.
        mainForm.FBD.SelectedPath = Directory.GetCurrentDirectory()
        Dim result As DialogResult = mainForm.FBD.ShowDialog()
        If (result = DialogResult.OK) Then

            txt_pathDB.Text = mainForm.FBD.SelectedPath

        Else
            mainForm.cancelFlag = True
        End If
    End Sub
    '===================================================================================      
    '                === Set SmetaDB path ===
    '===================================================================================
    Private Sub btn_browse_smetaDBpath_Click(sender As Object, e As EventArgs) Handles btn_browse_smetaDBpath.Click
        ' Show the FolderBrowserDialog.
        mainForm.FBD.SelectedPath = Directory.GetCurrentDirectory()
        Dim result As DialogResult = mainForm.FBD.ShowDialog()
        If (result = DialogResult.OK) Then
            txt_path_SmetaDB.Text = mainForm.FBD.SelectedPath
        Else
            mainForm.cancelFlag = True
        End If
    End Sub

    Private Sub btn_saveSettings_Click(sender As Object, e As EventArgs) Handles btn_saveSettings.Click

        mainForm.sDir = txt_pathDB.Text
        mainForm.sSmetaDir = txt_path_SmetaDB.Text
        My.Settings.databasePath = mainForm.sDir
        My.Settings.smetaDBpath = mainForm.sSmetaDir
        Me.Close()
        loginForm.logFormLoad()
    End Sub

    Private Sub settingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_pathDB.Text = My.Settings.databasePath
        mainForm.sDir = txt_pathDB.Text

        txt_path_SmetaDB.Text = My.Settings.smetaDBpath
        mainForm.sSmetaDir = txt_path_SmetaDB.Text

    End Sub


End Class