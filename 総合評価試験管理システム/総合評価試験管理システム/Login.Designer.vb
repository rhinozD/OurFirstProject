<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGETS0001
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
        Me.f_StaffCode = New System.Windows.Forms.TextBox()
        Me.f_StaffName = New System.Windows.Forms.TextBox()
        Me.f_Password = New System.Windows.Forms.TextBox()
        Me.f_Execute = New System.Windows.Forms.Button()
        Me.f_Exit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "作業者"
        '
        'f_StaffCode
        '
        Me.f_StaffCode.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.f_StaffCode.Location = New System.Drawing.Point(113, 29)
        Me.f_StaffCode.Multiline = True
        Me.f_StaffCode.Name = "f_StaffCode"
        Me.f_StaffCode.Size = New System.Drawing.Size(143, 32)
        Me.f_StaffCode.TabIndex = 1
        '
        'f_StaffName
        '
        Me.f_StaffName.Enabled = False
        Me.f_StaffName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.f_StaffName.Location = New System.Drawing.Point(262, 29)
        Me.f_StaffName.Multiline = True
        Me.f_StaffName.Name = "f_StaffName"
        Me.f_StaffName.Size = New System.Drawing.Size(260, 32)
        Me.f_StaffName.TabIndex = 3
        '
        'f_Password
        '
        Me.f_Password.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.f_Password.Location = New System.Drawing.Point(113, 96)
        Me.f_Password.MaxLength = 14
        Me.f_Password.Multiline = True
        Me.f_Password.Name = "f_Password"
        Me.f_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.f_Password.Size = New System.Drawing.Size(143, 32)
        Me.f_Password.TabIndex = 2
        '
        'f_Execute
        '
        Me.f_Execute.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.f_Execute.Location = New System.Drawing.Point(106, 162)
        Me.f_Execute.Name = "f_Execute"
        Me.f_Execute.Size = New System.Drawing.Size(106, 34)
        Me.f_Execute.TabIndex = 3
        Me.f_Execute.Text = "開始"
        Me.f_Execute.UseVisualStyleBackColor = True
        '
        'f_Exit
        '
        Me.f_Exit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.f_Exit.Location = New System.Drawing.Point(280, 162)
        Me.f_Exit.Name = "f_Exit"
        Me.f_Exit.Size = New System.Drawing.Size(106, 34)
        Me.f_Exit.TabIndex = 4
        Me.f_Exit.Text = "終了"
        Me.f_Exit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(95, 32)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(95, 32)
        Me.Panel2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "パスワード"
        '
        'frmGETS0001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 229)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.f_Exit)
        Me.Controls.Add(Me.f_Execute)
        Me.Controls.Add(Me.f_Password)
        Me.Controls.Add(Me.f_StaffName)
        Me.Controls.Add(Me.f_StaffCode)
        Me.Name = "frmGETS0001"
        Me.Text = "総合評価試験管理システムーログイン"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents f_StaffCode As System.Windows.Forms.TextBox
    Friend WithEvents f_StaffName As System.Windows.Forms.TextBox
    Friend WithEvents f_Password As System.Windows.Forms.TextBox
    Friend WithEvents f_Execute As System.Windows.Forms.Button
    Friend WithEvents f_Exit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
