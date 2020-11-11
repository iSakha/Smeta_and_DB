<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currencyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_currency = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_rusRub_rate = New System.Windows.Forms.Label()
        Me.lbl_Euro_rate = New System.Windows.Forms.Label()
        Me.lbl_USD_rate = New System.Windows.Forms.Label()
        Me.lbl_BYN_rate = New System.Windows.Forms.Label()
        Me.txt_USD_rate = New System.Windows.Forms.TextBox()
        Me.txt_Euro_rate = New System.Windows.Forms.TextBox()
        Me.txt_rusRub_rate = New System.Windows.Forms.TextBox()
        Me.txt_BYN_rate = New System.Windows.Forms.TextBox()
        Me.btn_setUSD = New System.Windows.Forms.Button()
        Me.btn_setEuro = New System.Windows.Forms.Button()
        Me.btn_setrusRub = New System.Windows.Forms.Button()
        Me.btn_setBYN = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_currency
        '
        Me.lbl_currency.AutoSize = True
        Me.lbl_currency.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_currency.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_currency.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_currency.Location = New System.Drawing.Point(3, 0)
        Me.lbl_currency.Name = "lbl_currency"
        Me.lbl_currency.Size = New System.Drawing.Size(51, 24)
        Me.lbl_currency.TabIndex = 20
        Me.lbl_currency.Text = "USD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(3, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Euro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(3, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Rub x 100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Info
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(3, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "BYN"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_rusRub_rate, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Euro_rate, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_USD_rate, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_currency, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_BYN_rate, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_USD_rate, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Euro_rate, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_rusRub_rate, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_BYN_rate, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_setUSD, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_setEuro, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_setrusRub, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_setBYN, 3, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(29, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(519, 188)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'lbl_rusRub_rate
        '
        Me.lbl_rusRub_rate.AutoSize = True
        Me.lbl_rusRub_rate.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_rusRub_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_rusRub_rate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_rusRub_rate.Location = New System.Drawing.Point(132, 94)
        Me.lbl_rusRub_rate.Name = "lbl_rusRub_rate"
        Me.lbl_rusRub_rate.Size = New System.Drawing.Size(49, 24)
        Me.lbl_rusRub_rate.TabIndex = 24
        Me.lbl_rusRub_rate.Text = "7.49"
        '
        'lbl_Euro_rate
        '
        Me.lbl_Euro_rate.AutoSize = True
        Me.lbl_Euro_rate.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_Euro_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_Euro_rate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_Euro_rate.Location = New System.Drawing.Point(132, 47)
        Me.lbl_Euro_rate.Name = "lbl_Euro_rate"
        Me.lbl_Euro_rate.Size = New System.Drawing.Size(49, 24)
        Me.lbl_Euro_rate.TabIndex = 22
        Me.lbl_Euro_rate.Text = "0.84"
        '
        'lbl_USD_rate
        '
        Me.lbl_USD_rate.AutoSize = True
        Me.lbl_USD_rate.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_USD_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_USD_rate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_USD_rate.Location = New System.Drawing.Point(132, 0)
        Me.lbl_USD_rate.Name = "lbl_USD_rate"
        Me.lbl_USD_rate.Size = New System.Drawing.Size(49, 24)
        Me.lbl_USD_rate.TabIndex = 21
        Me.lbl_USD_rate.Text = "1.00"
        '
        'lbl_BYN_rate
        '
        Me.lbl_BYN_rate.AutoSize = True
        Me.lbl_BYN_rate.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_BYN_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_BYN_rate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_BYN_rate.Location = New System.Drawing.Point(132, 141)
        Me.lbl_BYN_rate.Name = "lbl_BYN_rate"
        Me.lbl_BYN_rate.Size = New System.Drawing.Size(49, 24)
        Me.lbl_BYN_rate.TabIndex = 23
        Me.lbl_BYN_rate.Text = "2.60"
        '
        'txt_USD_rate
        '
        Me.txt_USD_rate.Location = New System.Drawing.Point(261, 3)
        Me.txt_USD_rate.Name = "txt_USD_rate"
        Me.txt_USD_rate.Size = New System.Drawing.Size(100, 20)
        Me.txt_USD_rate.TabIndex = 25
        '
        'txt_Euro_rate
        '
        Me.txt_Euro_rate.Location = New System.Drawing.Point(261, 50)
        Me.txt_Euro_rate.Name = "txt_Euro_rate"
        Me.txt_Euro_rate.Size = New System.Drawing.Size(100, 20)
        Me.txt_Euro_rate.TabIndex = 26
        '
        'txt_rusRub_rate
        '
        Me.txt_rusRub_rate.Location = New System.Drawing.Point(261, 97)
        Me.txt_rusRub_rate.Name = "txt_rusRub_rate"
        Me.txt_rusRub_rate.Size = New System.Drawing.Size(100, 20)
        Me.txt_rusRub_rate.TabIndex = 27
        '
        'txt_BYN_rate
        '
        Me.txt_BYN_rate.Location = New System.Drawing.Point(261, 144)
        Me.txt_BYN_rate.Name = "txt_BYN_rate"
        Me.txt_BYN_rate.Size = New System.Drawing.Size(100, 20)
        Me.txt_BYN_rate.TabIndex = 28
        '
        'btn_setUSD
        '
        Me.btn_setUSD.Location = New System.Drawing.Point(390, 3)
        Me.btn_setUSD.Name = "btn_setUSD"
        Me.btn_setUSD.Size = New System.Drawing.Size(75, 23)
        Me.btn_setUSD.TabIndex = 29
        Me.btn_setUSD.Text = "set USD"
        Me.btn_setUSD.UseVisualStyleBackColor = True
        '
        'btn_setEuro
        '
        Me.btn_setEuro.Location = New System.Drawing.Point(390, 50)
        Me.btn_setEuro.Name = "btn_setEuro"
        Me.btn_setEuro.Size = New System.Drawing.Size(75, 23)
        Me.btn_setEuro.TabIndex = 30
        Me.btn_setEuro.Text = "set Euro"
        Me.btn_setEuro.UseVisualStyleBackColor = True
        '
        'btn_setrusRub
        '
        Me.btn_setrusRub.Location = New System.Drawing.Point(390, 97)
        Me.btn_setrusRub.Name = "btn_setrusRub"
        Me.btn_setrusRub.Size = New System.Drawing.Size(75, 23)
        Me.btn_setrusRub.TabIndex = 31
        Me.btn_setrusRub.Text = "set rusRub"
        Me.btn_setrusRub.UseVisualStyleBackColor = True
        '
        'btn_setBYN
        '
        Me.btn_setBYN.Location = New System.Drawing.Point(390, 144)
        Me.btn_setBYN.Name = "btn_setBYN"
        Me.btn_setBYN.Size = New System.Drawing.Size(75, 23)
        Me.btn_setBYN.TabIndex = 32
        Me.btn_setBYN.Text = "set BYN"
        Me.btn_setBYN.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(192, 252)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirm.TabIndex = 22
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(308, 251)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'currencyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 314)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "currencyForm"
        Me.Text = "currencyForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_currency As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_rusRub_rate As Label
    Friend WithEvents lbl_Euro_rate As Label
    Friend WithEvents lbl_USD_rate As Label
    Friend WithEvents lbl_BYN_rate As Label
    Friend WithEvents txt_USD_rate As TextBox
    Friend WithEvents txt_Euro_rate As TextBox
    Friend WithEvents txt_rusRub_rate As TextBox
    Friend WithEvents txt_BYN_rate As TextBox
    Friend WithEvents btn_setUSD As Button
    Friend WithEvents btn_setEuro As Button
    Friend WithEvents btn_setrusRub As Button
    Friend WithEvents btn_setBYN As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents Button6 As Button
End Class
