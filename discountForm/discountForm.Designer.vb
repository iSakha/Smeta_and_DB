<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class discountForm
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
        Me.btn_cancel_discount = New System.Windows.Forms.Button()
        Me.btn_discount_OK = New System.Windows.Forms.Button()
        Me.chbx_commutation = New System.Windows.Forms.CheckBox()
        Me.chbx_sound = New System.Windows.Forms.CheckBox()
        Me.chbx_constr = New System.Windows.Forms.CheckBox()
        Me.chbx_truss = New System.Windows.Forms.CheckBox()
        Me.chbx_screen = New System.Windows.Forms.CheckBox()
        Me.chbx_lighting = New System.Windows.Forms.CheckBox()
        Me.txt_light_discount = New System.Windows.Forms.TextBox()
        Me.txt_screen_discount = New System.Windows.Forms.TextBox()
        Me.txt_commut_discount = New System.Windows.Forms.TextBox()
        Me.txt_truss_discount = New System.Windows.Forms.TextBox()
        Me.txt_constr_discount = New System.Windows.Forms.TextBox()
        Me.txt_sound_discount = New System.Windows.Forms.TextBox()
        Me.txt_plus_light = New System.Windows.Forms.TextBox()
        Me.txt_minus_light = New System.Windows.Forms.TextBox()
        Me.txt_plus_screen = New System.Windows.Forms.TextBox()
        Me.txt_minus_screen = New System.Windows.Forms.TextBox()
        Me.txt_plus_commut = New System.Windows.Forms.TextBox()
        Me.txt_minus_commut = New System.Windows.Forms.TextBox()
        Me.txt_plus_truss = New System.Windows.Forms.TextBox()
        Me.txt_minus_truss = New System.Windows.Forms.TextBox()
        Me.txt_plus_constr = New System.Windows.Forms.TextBox()
        Me.txt_minus_constr = New System.Windows.Forms.TextBox()
        Me.txt_plus_sound = New System.Windows.Forms.TextBox()
        Me.txt_minus_sound = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_cancel_discount
        '
        Me.btn_cancel_discount.Location = New System.Drawing.Point(161, 209)
        Me.btn_cancel_discount.Name = "btn_cancel_discount"
        Me.btn_cancel_discount.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel_discount.TabIndex = 21
        Me.btn_cancel_discount.Text = "Cancel"
        Me.btn_cancel_discount.UseVisualStyleBackColor = True
        '
        'btn_discount_OK
        '
        Me.btn_discount_OK.Location = New System.Drawing.Point(63, 210)
        Me.btn_discount_OK.Name = "btn_discount_OK"
        Me.btn_discount_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_discount_OK.TabIndex = 20
        Me.btn_discount_OK.Text = "OK"
        Me.btn_discount_OK.UseVisualStyleBackColor = True
        '
        'chbx_commutation
        '
        Me.chbx_commutation.AutoSize = True
        Me.chbx_commutation.Location = New System.Drawing.Point(12, 64)
        Me.chbx_commutation.Name = "chbx_commutation"
        Me.chbx_commutation.Size = New System.Drawing.Size(141, 17)
        Me.chbx_commutation.TabIndex = 13
        Me.chbx_commutation.Text = "Commutation discount,%"
        Me.chbx_commutation.UseVisualStyleBackColor = True
        '
        'chbx_sound
        '
        Me.chbx_sound.AutoSize = True
        Me.chbx_sound.Location = New System.Drawing.Point(12, 142)
        Me.chbx_sound.Name = "chbx_sound"
        Me.chbx_sound.Size = New System.Drawing.Size(57, 17)
        Me.chbx_sound.TabIndex = 14
        Me.chbx_sound.Text = "Sound"
        Me.chbx_sound.UseVisualStyleBackColor = True
        '
        'chbx_constr
        '
        Me.chbx_constr.AutoSize = True
        Me.chbx_constr.Location = New System.Drawing.Point(12, 116)
        Me.chbx_constr.Name = "chbx_constr"
        Me.chbx_constr.Size = New System.Drawing.Size(139, 17)
        Me.chbx_constr.TabIndex = 15
        Me.chbx_constr.Text = "Construction discount,%"
        Me.chbx_constr.UseVisualStyleBackColor = True
        '
        'chbx_truss
        '
        Me.chbx_truss.AutoSize = True
        Me.chbx_truss.Location = New System.Drawing.Point(12, 90)
        Me.chbx_truss.Name = "chbx_truss"
        Me.chbx_truss.Size = New System.Drawing.Size(161, 17)
        Me.chbx_truss.TabIndex = 16
        Me.chbx_truss.Text = "Truss and motors discount,%"
        Me.chbx_truss.UseVisualStyleBackColor = True
        '
        'chbx_screen
        '
        Me.chbx_screen.AutoSize = True
        Me.chbx_screen.Location = New System.Drawing.Point(12, 38)
        Me.chbx_screen.Name = "chbx_screen"
        Me.chbx_screen.Size = New System.Drawing.Size(114, 17)
        Me.chbx_screen.TabIndex = 17
        Me.chbx_screen.Text = "Screen discount,%"
        Me.chbx_screen.UseVisualStyleBackColor = True
        '
        'chbx_lighting
        '
        Me.chbx_lighting.AutoSize = True
        Me.chbx_lighting.Location = New System.Drawing.Point(12, 12)
        Me.chbx_lighting.Name = "chbx_lighting"
        Me.chbx_lighting.Size = New System.Drawing.Size(117, 17)
        Me.chbx_lighting.TabIndex = 18
        Me.chbx_lighting.Text = "Lighting discount,%"
        Me.chbx_lighting.UseVisualStyleBackColor = True
        '
        'txt_light_discount
        '
        Me.txt_light_discount.Location = New System.Drawing.Point(211, 12)
        Me.txt_light_discount.Name = "txt_light_discount"
        Me.txt_light_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_light_discount.TabIndex = 22
        Me.txt_light_discount.Text = "0"
        Me.txt_light_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_screen_discount
        '
        Me.txt_screen_discount.Location = New System.Drawing.Point(211, 37)
        Me.txt_screen_discount.Name = "txt_screen_discount"
        Me.txt_screen_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_screen_discount.TabIndex = 22
        Me.txt_screen_discount.Text = "0"
        Me.txt_screen_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_commut_discount
        '
        Me.txt_commut_discount.Location = New System.Drawing.Point(211, 62)
        Me.txt_commut_discount.Name = "txt_commut_discount"
        Me.txt_commut_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_commut_discount.TabIndex = 22
        Me.txt_commut_discount.Text = "0"
        Me.txt_commut_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_truss_discount
        '
        Me.txt_truss_discount.Location = New System.Drawing.Point(211, 87)
        Me.txt_truss_discount.Name = "txt_truss_discount"
        Me.txt_truss_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_truss_discount.TabIndex = 22
        Me.txt_truss_discount.Text = "0"
        Me.txt_truss_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_constr_discount
        '
        Me.txt_constr_discount.Location = New System.Drawing.Point(211, 112)
        Me.txt_constr_discount.Name = "txt_constr_discount"
        Me.txt_constr_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_constr_discount.TabIndex = 22
        Me.txt_constr_discount.Text = "0"
        Me.txt_constr_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sound_discount
        '
        Me.txt_sound_discount.Location = New System.Drawing.Point(211, 137)
        Me.txt_sound_discount.Name = "txt_sound_discount"
        Me.txt_sound_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_sound_discount.TabIndex = 22
        Me.txt_sound_discount.Text = "0"
        Me.txt_sound_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_plus_light
        '
        Me.txt_plus_light.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_plus_light.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_plus_light.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_plus_light.Location = New System.Drawing.Point(185, 12)
        Me.txt_plus_light.Name = "txt_plus_light"
        Me.txt_plus_light.ReadOnly = True
        Me.txt_plus_light.Size = New System.Drawing.Size(20, 20)
        Me.txt_plus_light.TabIndex = 23
        Me.txt_plus_light.Text = "+"
        Me.txt_plus_light.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_minus_light
        '
        Me.txt_minus_light.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_minus_light.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_minus_light.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_minus_light.Location = New System.Drawing.Point(265, 12)
        Me.txt_minus_light.Name = "txt_minus_light"
        Me.txt_minus_light.ReadOnly = True
        Me.txt_minus_light.Size = New System.Drawing.Size(20, 20)
        Me.txt_minus_light.TabIndex = 23
        Me.txt_minus_light.Text = "-"
        Me.txt_minus_light.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_plus_screen
        '
        Me.txt_plus_screen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_plus_screen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_plus_screen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_plus_screen.Location = New System.Drawing.Point(185, 37)
        Me.txt_plus_screen.Name = "txt_plus_screen"
        Me.txt_plus_screen.ReadOnly = True
        Me.txt_plus_screen.Size = New System.Drawing.Size(20, 20)
        Me.txt_plus_screen.TabIndex = 23
        Me.txt_plus_screen.Text = "+"
        Me.txt_plus_screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_minus_screen
        '
        Me.txt_minus_screen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_minus_screen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_minus_screen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_minus_screen.Location = New System.Drawing.Point(265, 37)
        Me.txt_minus_screen.Name = "txt_minus_screen"
        Me.txt_minus_screen.ReadOnly = True
        Me.txt_minus_screen.Size = New System.Drawing.Size(20, 20)
        Me.txt_minus_screen.TabIndex = 23
        Me.txt_minus_screen.Text = "-"
        Me.txt_minus_screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_plus_commut
        '
        Me.txt_plus_commut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_plus_commut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_plus_commut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_plus_commut.Location = New System.Drawing.Point(185, 63)
        Me.txt_plus_commut.Name = "txt_plus_commut"
        Me.txt_plus_commut.ReadOnly = True
        Me.txt_plus_commut.Size = New System.Drawing.Size(20, 20)
        Me.txt_plus_commut.TabIndex = 23
        Me.txt_plus_commut.Text = "+"
        Me.txt_plus_commut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_minus_commut
        '
        Me.txt_minus_commut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_minus_commut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_minus_commut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_minus_commut.Location = New System.Drawing.Point(265, 63)
        Me.txt_minus_commut.Name = "txt_minus_commut"
        Me.txt_minus_commut.ReadOnly = True
        Me.txt_minus_commut.Size = New System.Drawing.Size(20, 20)
        Me.txt_minus_commut.TabIndex = 23
        Me.txt_minus_commut.Text = "-"
        Me.txt_minus_commut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_plus_truss
        '
        Me.txt_plus_truss.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_plus_truss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_plus_truss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_plus_truss.Location = New System.Drawing.Point(185, 87)
        Me.txt_plus_truss.Name = "txt_plus_truss"
        Me.txt_plus_truss.ReadOnly = True
        Me.txt_plus_truss.Size = New System.Drawing.Size(20, 20)
        Me.txt_plus_truss.TabIndex = 23
        Me.txt_plus_truss.Text = "+"
        Me.txt_plus_truss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_minus_truss
        '
        Me.txt_minus_truss.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_minus_truss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_minus_truss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_minus_truss.Location = New System.Drawing.Point(265, 87)
        Me.txt_minus_truss.Name = "txt_minus_truss"
        Me.txt_minus_truss.ReadOnly = True
        Me.txt_minus_truss.Size = New System.Drawing.Size(20, 20)
        Me.txt_minus_truss.TabIndex = 23
        Me.txt_minus_truss.Text = "-"
        Me.txt_minus_truss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_plus_constr
        '
        Me.txt_plus_constr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_plus_constr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_plus_constr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_plus_constr.Location = New System.Drawing.Point(185, 112)
        Me.txt_plus_constr.Name = "txt_plus_constr"
        Me.txt_plus_constr.ReadOnly = True
        Me.txt_plus_constr.Size = New System.Drawing.Size(20, 20)
        Me.txt_plus_constr.TabIndex = 23
        Me.txt_plus_constr.Text = "+"
        Me.txt_plus_constr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_minus_constr
        '
        Me.txt_minus_constr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_minus_constr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_minus_constr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_minus_constr.Location = New System.Drawing.Point(265, 112)
        Me.txt_minus_constr.Name = "txt_minus_constr"
        Me.txt_minus_constr.ReadOnly = True
        Me.txt_minus_constr.Size = New System.Drawing.Size(20, 20)
        Me.txt_minus_constr.TabIndex = 23
        Me.txt_minus_constr.Text = "-"
        Me.txt_minus_constr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_plus_sound
        '
        Me.txt_plus_sound.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_plus_sound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_plus_sound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_plus_sound.Location = New System.Drawing.Point(185, 137)
        Me.txt_plus_sound.Name = "txt_plus_sound"
        Me.txt_plus_sound.ReadOnly = True
        Me.txt_plus_sound.Size = New System.Drawing.Size(20, 20)
        Me.txt_plus_sound.TabIndex = 23
        Me.txt_plus_sound.Text = "+"
        Me.txt_plus_sound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_minus_sound
        '
        Me.txt_minus_sound.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_minus_sound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_minus_sound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_minus_sound.Location = New System.Drawing.Point(265, 137)
        Me.txt_minus_sound.Name = "txt_minus_sound"
        Me.txt_minus_sound.ReadOnly = True
        Me.txt_minus_sound.Size = New System.Drawing.Size(20, 20)
        Me.txt_minus_sound.TabIndex = 23
        Me.txt_minus_sound.Text = "-"
        Me.txt_minus_sound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'discountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 273)
        Me.Controls.Add(Me.txt_minus_sound)
        Me.Controls.Add(Me.txt_plus_sound)
        Me.Controls.Add(Me.txt_minus_constr)
        Me.Controls.Add(Me.txt_plus_constr)
        Me.Controls.Add(Me.txt_minus_truss)
        Me.Controls.Add(Me.txt_plus_truss)
        Me.Controls.Add(Me.txt_minus_commut)
        Me.Controls.Add(Me.txt_plus_commut)
        Me.Controls.Add(Me.txt_minus_screen)
        Me.Controls.Add(Me.txt_plus_screen)
        Me.Controls.Add(Me.txt_minus_light)
        Me.Controls.Add(Me.txt_plus_light)
        Me.Controls.Add(Me.txt_sound_discount)
        Me.Controls.Add(Me.txt_constr_discount)
        Me.Controls.Add(Me.txt_truss_discount)
        Me.Controls.Add(Me.txt_commut_discount)
        Me.Controls.Add(Me.txt_screen_discount)
        Me.Controls.Add(Me.txt_light_discount)
        Me.Controls.Add(Me.btn_cancel_discount)
        Me.Controls.Add(Me.btn_discount_OK)
        Me.Controls.Add(Me.chbx_commutation)
        Me.Controls.Add(Me.chbx_sound)
        Me.Controls.Add(Me.chbx_constr)
        Me.Controls.Add(Me.chbx_truss)
        Me.Controls.Add(Me.chbx_screen)
        Me.Controls.Add(Me.chbx_lighting)
        Me.Name = "discountForm"
        Me.Text = "discountForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel_discount As Button
    Friend WithEvents btn_discount_OK As Button
    Friend WithEvents chbx_commutation As CheckBox
    Friend WithEvents chbx_sound As CheckBox
    Friend WithEvents chbx_constr As CheckBox
    Friend WithEvents chbx_truss As CheckBox
    Friend WithEvents chbx_screen As CheckBox
    Friend WithEvents chbx_lighting As CheckBox
    Friend WithEvents txt_light_discount As TextBox
    Friend WithEvents txt_screen_discount As TextBox
    Friend WithEvents txt_commut_discount As TextBox
    Friend WithEvents txt_truss_discount As TextBox
    Friend WithEvents txt_constr_discount As TextBox
    Friend WithEvents txt_sound_discount As TextBox
    Friend WithEvents txt_plus_light As TextBox
    Friend WithEvents txt_minus_light As TextBox
    Friend WithEvents txt_plus_screen As TextBox
    Friend WithEvents txt_minus_screen As TextBox
    Friend WithEvents txt_plus_commut As TextBox
    Friend WithEvents txt_minus_commut As TextBox
    Friend WithEvents txt_plus_truss As TextBox
    Friend WithEvents txt_minus_truss As TextBox
    Friend WithEvents txt_plus_constr As TextBox
    Friend WithEvents txt_minus_constr As TextBox
    Friend WithEvents txt_plus_sound As TextBox
    Friend WithEvents txt_minus_sound As TextBox
End Class
