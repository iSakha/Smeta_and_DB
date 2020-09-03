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
            mainForm.sDir = mainForm.FBD.SelectedPath

            My.Settings.databasePath = mainForm.sDir
            txt_pathDB.Text = My.Settings.databasePath

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
            mainForm.sSmetaDir = mainForm.FBD.SelectedPath

            My.Settings.smetaDBpath = mainForm.sSmetaDir
            txt_path_SmetaDB.Text = My.Settings.smetaDBpath

        Else
            mainForm.cancelFlag = True
        End If
    End Sub
End Class