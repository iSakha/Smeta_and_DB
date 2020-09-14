Module advSmeta

    '===================================================================================
    '             === Select companies' queue ===
    '===================================================================================
    Sub disableSelected(_sender As Button)
        _sender.BackColor = Color.DarkGray
        _sender.Enabled = False
    End Sub
End Module
