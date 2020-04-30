<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txt_security_code = New System.Windows.Forms.TextBox()
        Me.lbl_security_code = New System.Windows.Forms.Label()
        Me.chk_remember = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_login.Location = New System.Drawing.Point(84, 261)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(82, 29)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Sign in"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exit.Location = New System.Drawing.Point(202, 261)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(82, 29)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(144, 75)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(111, 20)
        Me.txt_username.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(144, 133)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_password.Size = New System.Drawing.Size(111, 20)
        Me.txt_password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Vladimir Script", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(385, 61)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TS&C Coffee Login"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(272, 135)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "แสดง Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(25, 170)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(141, 37)
        Me.label4.TabIndex = 8
        Me.label4.Text = "รหัสยืนยันตัวตน"
        '
        'txt_security_code
        '
        Me.txt_security_code.Location = New System.Drawing.Point(173, 213)
        Me.txt_security_code.Name = "txt_security_code"
        Me.txt_security_code.Size = New System.Drawing.Size(111, 20)
        Me.txt_security_code.TabIndex = 3
        '
        'lbl_security_code
        '
        Me.lbl_security_code.BackColor = System.Drawing.Color.Transparent
        Me.lbl_security_code.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_security_code.Location = New System.Drawing.Point(173, 170)
        Me.lbl_security_code.Name = "lbl_security_code"
        Me.lbl_security_code.Size = New System.Drawing.Size(121, 37)
        Me.lbl_security_code.TabIndex = 10
        Me.lbl_security_code.Text = "SC"
        Me.lbl_security_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_remember
        '
        Me.chk_remember.AutoSize = True
        Me.chk_remember.BackColor = System.Drawing.Color.Transparent
        Me.chk_remember.Location = New System.Drawing.Point(272, 75)
        Me.chk_remember.Name = "chk_remember"
        Me.chk_remember.Size = New System.Drawing.Size(98, 17)
        Me.chk_remember.TabIndex = 11
        Me.chk_remember.Text = "จดจำUsername"
        Me.chk_remember.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AcceptButton = Me.btn_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_exit
        Me.ClientSize = New System.Drawing.Size(385, 302)
        Me.Controls.Add(Me.chk_remember)
        Me.Controls.Add(Me.lbl_security_code)
        Me.Controls.Add(Me.txt_security_code)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents label4 As Label
    Friend WithEvents txt_security_code As TextBox
    Friend WithEvents lbl_security_code As Label
    Friend WithEvents chk_remember As CheckBox
End Class
