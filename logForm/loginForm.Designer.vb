<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_login = New System.Windows.Forms.ComboBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.btn_registr = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NF4.My.Resources.Resources.comein
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'cmb_login
        '
        Me.cmb_login.FormattingEnabled = True
        Me.cmb_login.Location = New System.Drawing.Point(291, 16)
        Me.cmb_login.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_login.Name = "cmb_login"
        Me.cmb_login.Size = New System.Drawing.Size(232, 24)
        Me.cmb_login.TabIndex = 3
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(291, 80)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(232, 22)
        Me.txt_pass.TabIndex = 4
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'btn_registr
        '
        Me.btn_registr.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_registr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_registr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_registr.Location = New System.Drawing.Point(16, 148)
        Me.btn_registr.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_registr.Name = "btn_registr"
        Me.btn_registr.Size = New System.Drawing.Size(127, 47)
        Me.btn_registr.TabIndex = 5
        Me.btn_registr.Text = "Registration"
        Me.btn_registr.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_login.Location = New System.Drawing.Point(143, 148)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(127, 47)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(269, 148)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(127, 47)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(396, 148)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(127, 47)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 257)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.btn_registr)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.cmb_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "loginForm"
        Me.Text = "loginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_login As ComboBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents btn_registr As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_exit As Button
End Class
