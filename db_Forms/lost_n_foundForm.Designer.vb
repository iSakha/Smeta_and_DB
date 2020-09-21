<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lost_n_foundForm
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
        Me.btn_sound_smeta = New System.Windows.Forms.Button()
        Me.btn_construct_smeta = New System.Windows.Forms.Button()
        Me.btn_truss_smeta = New System.Windows.Forms.Button()
        Me.btn_commut_smeta = New System.Windows.Forms.Button()
        Me.btn_screen_smeta = New System.Windows.Forms.Button()
        Me.btn_lighting_smeta = New System.Windows.Forms.Button()
        Me.DGV_db = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_db, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_sound_smeta
        '
        Me.btn_sound_smeta.BackColor = System.Drawing.Color.Thistle
        Me.btn_sound_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_sound_smeta.FlatAppearance.BorderSize = 2
        Me.btn_sound_smeta.Location = New System.Drawing.Point(12, 167)
        Me.btn_sound_smeta.Name = "btn_sound_smeta"
        Me.btn_sound_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_sound_smeta.TabIndex = 2
        Me.btn_sound_smeta.Text = "06 Sound"
        Me.btn_sound_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sound_smeta.UseVisualStyleBackColor = False
        '
        'btn_construct_smeta
        '
        Me.btn_construct_smeta.BackColor = System.Drawing.Color.LightCyan
        Me.btn_construct_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_construct_smeta.FlatAppearance.BorderSize = 2
        Me.btn_construct_smeta.Location = New System.Drawing.Point(12, 138)
        Me.btn_construct_smeta.Name = "btn_construct_smeta"
        Me.btn_construct_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_construct_smeta.TabIndex = 3
        Me.btn_construct_smeta.Text = "05 Construction"
        Me.btn_construct_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_construct_smeta.UseVisualStyleBackColor = False
        '
        'btn_truss_smeta
        '
        Me.btn_truss_smeta.BackColor = System.Drawing.Color.Honeydew
        Me.btn_truss_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_truss_smeta.FlatAppearance.BorderSize = 2
        Me.btn_truss_smeta.Location = New System.Drawing.Point(12, 109)
        Me.btn_truss_smeta.Name = "btn_truss_smeta"
        Me.btn_truss_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_truss_smeta.TabIndex = 4
        Me.btn_truss_smeta.Text = "04 Truss and motors"
        Me.btn_truss_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_truss_smeta.UseVisualStyleBackColor = False
        '
        'btn_commut_smeta
        '
        Me.btn_commut_smeta.BackColor = System.Drawing.Color.MistyRose
        Me.btn_commut_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_commut_smeta.FlatAppearance.BorderSize = 2
        Me.btn_commut_smeta.Location = New System.Drawing.Point(12, 80)
        Me.btn_commut_smeta.Name = "btn_commut_smeta"
        Me.btn_commut_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_commut_smeta.TabIndex = 5
        Me.btn_commut_smeta.Text = "03 Commutation"
        Me.btn_commut_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_commut_smeta.UseVisualStyleBackColor = False
        '
        'btn_screen_smeta
        '
        Me.btn_screen_smeta.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_screen_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_screen_smeta.FlatAppearance.BorderSize = 2
        Me.btn_screen_smeta.Location = New System.Drawing.Point(12, 51)
        Me.btn_screen_smeta.Name = "btn_screen_smeta"
        Me.btn_screen_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_screen_smeta.TabIndex = 6
        Me.btn_screen_smeta.Text = "02 Screen"
        Me.btn_screen_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_screen_smeta.UseVisualStyleBackColor = False
        '
        'btn_lighting_smeta
        '
        Me.btn_lighting_smeta.BackColor = System.Drawing.Color.LemonChiffon
        Me.btn_lighting_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_lighting_smeta.FlatAppearance.BorderSize = 2
        Me.btn_lighting_smeta.Location = New System.Drawing.Point(12, 22)
        Me.btn_lighting_smeta.Name = "btn_lighting_smeta"
        Me.btn_lighting_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_lighting_smeta.TabIndex = 7
        Me.btn_lighting_smeta.Text = "01 Lighting"
        Me.btn_lighting_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_lighting_smeta.UseVisualStyleBackColor = False
        '
        'DGV_db
        '
        Me.DGV_db.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_db.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_db.Location = New System.Drawing.Point(163, 22)
        Me.DGV_db.Name = "DGV_db"
        Me.DGV_db.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_db.Size = New System.Drawing.Size(908, 603)
        Me.DGV_db.TabIndex = 8
        '
        'lost_n_foundForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 736)
        Me.Controls.Add(Me.DGV_db)
        Me.Controls.Add(Me.btn_sound_smeta)
        Me.Controls.Add(Me.btn_construct_smeta)
        Me.Controls.Add(Me.btn_truss_smeta)
        Me.Controls.Add(Me.btn_commut_smeta)
        Me.Controls.Add(Me.btn_screen_smeta)
        Me.Controls.Add(Me.btn_lighting_smeta)
        Me.Name = "lost_n_foundForm"
        Me.Text = "lost_n_foundForm"
        CType(Me.DGV_db, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_sound_smeta As Button
    Friend WithEvents btn_construct_smeta As Button
    Friend WithEvents btn_truss_smeta As Button
    Friend WithEvents btn_commut_smeta As Button
    Friend WithEvents btn_screen_smeta As Button
    Friend WithEvents btn_lighting_smeta As Button
    Friend WithEvents DGV_db As DataGridView
End Class
