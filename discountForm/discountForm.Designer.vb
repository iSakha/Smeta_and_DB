﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_summary_light = New System.Windows.Forms.TextBox()
        Me.txt_summary_screen = New System.Windows.Forms.TextBox()
        Me.txt_summary_comm = New System.Windows.Forms.TextBox()
        Me.txt_summary_truss = New System.Windows.Forms.TextBox()
        Me.txt_summary_constr = New System.Windows.Forms.TextBox()
        Me.txt_summary_sound = New System.Windows.Forms.TextBox()
        Me.txt_summary_light_discount = New System.Windows.Forms.TextBox()
        Me.txt_summary_screen_discount = New System.Windows.Forms.TextBox()
        Me.txt_summary_comm_discount = New System.Windows.Forms.TextBox()
        Me.txt_summary_truss_discount = New System.Windows.Forms.TextBox()
        Me.txt_summary_constr_discount = New System.Windows.Forms.TextBox()
        Me.txt_summary_sound_discount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_cancel_discount
        '
        Me.btn_cancel_discount.Location = New System.Drawing.Point(240, 238)
        Me.btn_cancel_discount.Name = "btn_cancel_discount"
        Me.btn_cancel_discount.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel_discount.TabIndex = 21
        Me.btn_cancel_discount.Text = "Cancel"
        Me.btn_cancel_discount.UseVisualStyleBackColor = True
        '
        'btn_discount_OK
        '
        Me.btn_discount_OK.Location = New System.Drawing.Point(142, 239)
        Me.btn_discount_OK.Name = "btn_discount_OK"
        Me.btn_discount_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_discount_OK.TabIndex = 20
        Me.btn_discount_OK.Text = "OK"
        Me.btn_discount_OK.UseVisualStyleBackColor = True
        '
        'chbx_commutation
        '
        Me.chbx_commutation.AutoSize = True
        Me.chbx_commutation.Location = New System.Drawing.Point(12, 112)
        Me.chbx_commutation.Name = "chbx_commutation"
        Me.chbx_commutation.Size = New System.Drawing.Size(141, 17)
        Me.chbx_commutation.TabIndex = 13
        Me.chbx_commutation.Text = "Commutation discount,%"
        Me.chbx_commutation.UseVisualStyleBackColor = True
        '
        'chbx_sound
        '
        Me.chbx_sound.AutoSize = True
        Me.chbx_sound.Location = New System.Drawing.Point(12, 190)
        Me.chbx_sound.Name = "chbx_sound"
        Me.chbx_sound.Size = New System.Drawing.Size(57, 17)
        Me.chbx_sound.TabIndex = 14
        Me.chbx_sound.Text = "Sound"
        Me.chbx_sound.UseVisualStyleBackColor = True
        '
        'chbx_constr
        '
        Me.chbx_constr.AutoSize = True
        Me.chbx_constr.Location = New System.Drawing.Point(12, 164)
        Me.chbx_constr.Name = "chbx_constr"
        Me.chbx_constr.Size = New System.Drawing.Size(139, 17)
        Me.chbx_constr.TabIndex = 15
        Me.chbx_constr.Text = "Construction discount,%"
        Me.chbx_constr.UseVisualStyleBackColor = True
        '
        'chbx_truss
        '
        Me.chbx_truss.AutoSize = True
        Me.chbx_truss.Location = New System.Drawing.Point(12, 138)
        Me.chbx_truss.Name = "chbx_truss"
        Me.chbx_truss.Size = New System.Drawing.Size(161, 17)
        Me.chbx_truss.TabIndex = 16
        Me.chbx_truss.Text = "Truss and motors discount,%"
        Me.chbx_truss.UseVisualStyleBackColor = True
        '
        'chbx_screen
        '
        Me.chbx_screen.AutoSize = True
        Me.chbx_screen.Location = New System.Drawing.Point(12, 86)
        Me.chbx_screen.Name = "chbx_screen"
        Me.chbx_screen.Size = New System.Drawing.Size(114, 17)
        Me.chbx_screen.TabIndex = 17
        Me.chbx_screen.Text = "Screen discount,%"
        Me.chbx_screen.UseVisualStyleBackColor = True
        '
        'chbx_lighting
        '
        Me.chbx_lighting.AutoSize = True
        Me.chbx_lighting.Location = New System.Drawing.Point(12, 60)
        Me.chbx_lighting.Name = "chbx_lighting"
        Me.chbx_lighting.Size = New System.Drawing.Size(117, 17)
        Me.chbx_lighting.TabIndex = 18
        Me.chbx_lighting.Text = "Lighting discount,%"
        Me.chbx_lighting.UseVisualStyleBackColor = True
        '
        'txt_light_discount
        '
        Me.txt_light_discount.Location = New System.Drawing.Point(211, 60)
        Me.txt_light_discount.Name = "txt_light_discount"
        Me.txt_light_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_light_discount.TabIndex = 22
        Me.txt_light_discount.Text = "0"
        Me.txt_light_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_screen_discount
        '
        Me.txt_screen_discount.Location = New System.Drawing.Point(211, 85)
        Me.txt_screen_discount.Name = "txt_screen_discount"
        Me.txt_screen_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_screen_discount.TabIndex = 22
        Me.txt_screen_discount.Text = "0"
        Me.txt_screen_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_commut_discount
        '
        Me.txt_commut_discount.Location = New System.Drawing.Point(211, 110)
        Me.txt_commut_discount.Name = "txt_commut_discount"
        Me.txt_commut_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_commut_discount.TabIndex = 22
        Me.txt_commut_discount.Text = "0"
        Me.txt_commut_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_truss_discount
        '
        Me.txt_truss_discount.Location = New System.Drawing.Point(211, 135)
        Me.txt_truss_discount.Name = "txt_truss_discount"
        Me.txt_truss_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_truss_discount.TabIndex = 22
        Me.txt_truss_discount.Text = "0"
        Me.txt_truss_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_constr_discount
        '
        Me.txt_constr_discount.Location = New System.Drawing.Point(211, 160)
        Me.txt_constr_discount.Name = "txt_constr_discount"
        Me.txt_constr_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_constr_discount.TabIndex = 22
        Me.txt_constr_discount.Text = "0"
        Me.txt_constr_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sound_discount
        '
        Me.txt_sound_discount.Location = New System.Drawing.Point(211, 185)
        Me.txt_sound_discount.Name = "txt_sound_discount"
        Me.txt_sound_discount.Size = New System.Drawing.Size(48, 20)
        Me.txt_sound_discount.TabIndex = 22
        Me.txt_sound_discount.Text = "0"
        Me.txt_sound_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Сумма"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Сумма со скидкой"
        '
        'txt_summary_light
        '
        Me.txt_summary_light.Location = New System.Drawing.Point(291, 60)
        Me.txt_summary_light.Name = "txt_summary_light"
        Me.txt_summary_light.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_light.TabIndex = 22
        Me.txt_summary_light.Text = "0"
        Me.txt_summary_light.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_screen
        '
        Me.txt_summary_screen.Location = New System.Drawing.Point(291, 85)
        Me.txt_summary_screen.Name = "txt_summary_screen"
        Me.txt_summary_screen.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_screen.TabIndex = 22
        Me.txt_summary_screen.Text = "0"
        Me.txt_summary_screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_comm
        '
        Me.txt_summary_comm.Location = New System.Drawing.Point(291, 110)
        Me.txt_summary_comm.Name = "txt_summary_comm"
        Me.txt_summary_comm.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_comm.TabIndex = 22
        Me.txt_summary_comm.Text = "0"
        Me.txt_summary_comm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_truss
        '
        Me.txt_summary_truss.Location = New System.Drawing.Point(291, 135)
        Me.txt_summary_truss.Name = "txt_summary_truss"
        Me.txt_summary_truss.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_truss.TabIndex = 22
        Me.txt_summary_truss.Text = "0"
        Me.txt_summary_truss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_constr
        '
        Me.txt_summary_constr.Location = New System.Drawing.Point(291, 160)
        Me.txt_summary_constr.Name = "txt_summary_constr"
        Me.txt_summary_constr.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_constr.TabIndex = 22
        Me.txt_summary_constr.Text = "0"
        Me.txt_summary_constr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_sound
        '
        Me.txt_summary_sound.Location = New System.Drawing.Point(291, 185)
        Me.txt_summary_sound.Name = "txt_summary_sound"
        Me.txt_summary_sound.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_sound.TabIndex = 22
        Me.txt_summary_sound.Text = "0"
        Me.txt_summary_sound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_light_discount
        '
        Me.txt_summary_light_discount.Location = New System.Drawing.Point(402, 60)
        Me.txt_summary_light_discount.Name = "txt_summary_light_discount"
        Me.txt_summary_light_discount.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_light_discount.TabIndex = 22
        Me.txt_summary_light_discount.Text = "0"
        Me.txt_summary_light_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_screen_discount
        '
        Me.txt_summary_screen_discount.Location = New System.Drawing.Point(402, 85)
        Me.txt_summary_screen_discount.Name = "txt_summary_screen_discount"
        Me.txt_summary_screen_discount.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_screen_discount.TabIndex = 22
        Me.txt_summary_screen_discount.Text = "0"
        Me.txt_summary_screen_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_comm_discount
        '
        Me.txt_summary_comm_discount.Location = New System.Drawing.Point(402, 110)
        Me.txt_summary_comm_discount.Name = "txt_summary_comm_discount"
        Me.txt_summary_comm_discount.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_comm_discount.TabIndex = 22
        Me.txt_summary_comm_discount.Text = "0"
        Me.txt_summary_comm_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_truss_discount
        '
        Me.txt_summary_truss_discount.Location = New System.Drawing.Point(402, 135)
        Me.txt_summary_truss_discount.Name = "txt_summary_truss_discount"
        Me.txt_summary_truss_discount.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_truss_discount.TabIndex = 22
        Me.txt_summary_truss_discount.Text = "0"
        Me.txt_summary_truss_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_constr_discount
        '
        Me.txt_summary_constr_discount.Location = New System.Drawing.Point(402, 160)
        Me.txt_summary_constr_discount.Name = "txt_summary_constr_discount"
        Me.txt_summary_constr_discount.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_constr_discount.TabIndex = 22
        Me.txt_summary_constr_discount.Text = "0"
        Me.txt_summary_constr_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_summary_sound_discount
        '
        Me.txt_summary_sound_discount.Location = New System.Drawing.Point(402, 185)
        Me.txt_summary_sound_discount.Name = "txt_summary_sound_discount"
        Me.txt_summary_sound_discount.Size = New System.Drawing.Size(88, 20)
        Me.txt_summary_sound_discount.TabIndex = 22
        Me.txt_summary_sound_discount.Text = "0"
        Me.txt_summary_sound_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'discountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 273)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_summary_sound_discount)
        Me.Controls.Add(Me.txt_summary_constr_discount)
        Me.Controls.Add(Me.txt_summary_sound)
        Me.Controls.Add(Me.txt_summary_constr)
        Me.Controls.Add(Me.txt_summary_truss_discount)
        Me.Controls.Add(Me.txt_sound_discount)
        Me.Controls.Add(Me.txt_summary_truss)
        Me.Controls.Add(Me.txt_summary_comm_discount)
        Me.Controls.Add(Me.txt_constr_discount)
        Me.Controls.Add(Me.txt_summary_comm)
        Me.Controls.Add(Me.txt_summary_screen_discount)
        Me.Controls.Add(Me.txt_truss_discount)
        Me.Controls.Add(Me.txt_summary_screen)
        Me.Controls.Add(Me.txt_summary_light_discount)
        Me.Controls.Add(Me.txt_commut_discount)
        Me.Controls.Add(Me.txt_summary_light)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_summary_light As TextBox
    Friend WithEvents txt_summary_screen As TextBox
    Friend WithEvents txt_summary_comm As TextBox
    Friend WithEvents txt_summary_truss As TextBox
    Friend WithEvents txt_summary_constr As TextBox
    Friend WithEvents txt_summary_sound As TextBox
    Friend WithEvents txt_summary_light_discount As TextBox
    Friend WithEvents txt_summary_screen_discount As TextBox
    Friend WithEvents txt_summary_comm_discount As TextBox
    Friend WithEvents txt_summary_truss_discount As TextBox
    Friend WithEvents txt_summary_constr_discount As TextBox
    Friend WithEvents txt_summary_sound_discount As TextBox
End Class
