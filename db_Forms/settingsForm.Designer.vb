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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path to database"
        '
        'txt_pathDB
        '
        Me.txt_pathDB.Location = New System.Drawing.Point(137, 13)
        Me.txt_pathDB.Name = "txt_pathDB"
        Me.txt_pathDB.Size = New System.Drawing.Size(618, 20)
        Me.txt_pathDB.TabIndex = 1
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(772, 12)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(32, 20)
        Me.btn_browse.TabIndex = 2
        Me.btn_browse.Text = "..."
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Path to SmetaDB"
        '
        'txt_path_SmetaDB
        '
        Me.txt_path_SmetaDB.Location = New System.Drawing.Point(137, 39)
        Me.txt_path_SmetaDB.Name = "txt_path_SmetaDB"
        Me.txt_path_SmetaDB.Size = New System.Drawing.Size(618, 20)
        Me.txt_path_SmetaDB.TabIndex = 1
        '
        'btn_browse_smetaDBpath
        '
        Me.btn_browse_smetaDBpath.Location = New System.Drawing.Point(772, 38)
        Me.btn_browse_smetaDBpath.Name = "btn_browse_smetaDBpath"
        Me.btn_browse_smetaDBpath.Size = New System.Drawing.Size(32, 20)
        Me.btn_browse_smetaDBpath.TabIndex = 2
        Me.btn_browse_smetaDBpath.Text = "..."
        Me.btn_browse_smetaDBpath.UseVisualStyleBackColor = True
        '
        'settingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 618)
        Me.Controls.Add(Me.btn_browse_smetaDBpath)
        Me.Controls.Add(Me.txt_path_SmetaDB)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_pathDB)
        Me.Controls.Add(Me.Label1)
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
End Class
