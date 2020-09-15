Module advSmeta

    '===================================================================================
    '             === Select companies' queue ===
    '===================================================================================
    Sub disableSelected(_sender As Button)

        Dim index As Integer
        index = (mainForm.btnsAdvSmeta.IndexOf(_sender))
        _sender.BackColor = Color.DarkGray
        _sender.Enabled = False
        'Console.WriteLine(mainForm.btnsAdvSmeta.IndexOf(_sender))
        smetaMainForm.tbCtrl_smeta.TabPages.Add(mainForm.tabsSmeta(index))
    End Sub


End Module
