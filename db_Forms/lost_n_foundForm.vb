Public Class lost_n_foundForm
    Private Sub lost_n_foundForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_db.DataSource = createGlobal_dt()
        format_DGV_lost_n_found()
    End Sub
End Class