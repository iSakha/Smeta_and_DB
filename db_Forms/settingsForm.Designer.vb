<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pathDB = New System.Windows.Forms.TextBox()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_path_SmetaDB = New System.Windows.Forms.TextBox()
        Me.btn_browse_smetaDBpath = New System.Windows.Forms.Button()
        Me.btn_saveSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path to database"
        '
        'txt_pathDB
        '
        Me.txt_pathDB.Location = New System.Drawing.Point(183, 16)
        Me.txt_pathDB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_pathDB.Name = "txt_pathDB"
        Me.txt_pathDB.Size = New System.Drawing.Size(823, 22)
        Me.txt_pathDB.TabIndex = 1
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(1029, 15)
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(43, 25)
        Me.btn_browse.TabIndex = 2
        Me.btn_browse.Text = "..."
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Path to SmetaDB"
        '
        'txt_path_SmetaDB
        '
        Me.txt_path_SmetaDB.Location = New System.Drawing.Point(183, 48)
        Me.txt_path_SmetaDB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_path_SmetaDB.Name = "txt_path_SmetaDB"
        Me.txt_path_SmetaDB.Size = New System.Drawing.Size(823, 22)
        Me.txt_path_SmetaDB.TabIndex = 1
        '
        'btn_browse_smetaDBpath
        '
        Me.btn_browse_smetaDBpath.Location = New System.Drawing.Point(1029, 47)
        Me.btn_browse_smetaDBpath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_browse_smetaDBpath.Name = "btn_browse_smetaDBpath"
        Me.btn_browse_smetaDBpath.Size = New System.Drawing.Size(43, 25)
        Me.btn_browse_smetaDBpath.TabIndex = 2
        Me.btn_browse_smetaDBpath.Text = "..."
        Me.btn_browse_smetaDBpath.UseVisualStyleBackColor = True
        '
        'btn_saveSettings
        '
        Me.btn_saveSettings.Location = New System.Drawing.Point(498, 252)
        Me.btn_saveSettings.Name = "btn_saveSettings"
        Me.btn_saveSettings.Size = New System.Drawing.Size(75, 23)
        Me.btn_saveSettings.TabIndex = 3
        Me.btn_saveSettings.Text = "Save"
        Me.btn_saveSettings.UseVisualStyleBackColor = True
        '
        'settingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 370)
        Me.Controls.Add(Me.btn_saveSettings)
        Me.Controls.Add(Me.btn_browse_smetaDBpath)
        Me.Controls.Add(Me.txt_path_SmetaDB)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_pathDB)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "settingsForm"
        Me.Text = "settingsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pathDB As TextBox
    Friend WithEvents btn_browse As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_path_SmetaDB As TextBox
    Friend WithEvents btn_browse_smetaDBpath As Button
    Friend WithEvents btn_saveSettings As Button
End Class
