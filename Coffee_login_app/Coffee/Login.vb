Public Class Login
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_security_code.Text = rnd_security_code()
        txt_username.Text = My.Settings.username
        If My.Settings.username = "" Then
            chk_remember.Checked = False
        Else
            chk_remember.Checked = True
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If confirm("ต้องการออกจากโปรแกรมหรือไม่?") = vbYes Then End
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "" Or txt_password.Text = "" Or txt_security_code.Text = "" Then
            msg_error("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If
        If txt_security_code.Text <> lbl_security_code.Text Then
            msg_error("รหัสยืนยันตัวตนไม่ถูกต้อง")
            lbl_security_code.Text = rnd_security_code()
            lbl_security_code.Text = ""
            Return
        End If


        sql = "select count(*) from users where users_username='" & txt_username.Text & "' and users_password='" & txt_password.Text & "'"
        Dim count_user As Integer = cmd_excutescalar()

        If count_user <= 0 Then
            msg_error("login fail")
            txt_username.Text = ""
            txt_password.Text = ""
            txt_username.Select()
        Else
            msg_ok("login sucess")
            frm_main.Show()
            Me.Hide()

            sql = "select (*) from users where users_username='" & txt_username.Text & "' and users_password='" & txt_password.Text & "'"
            Dim dts As DataTable = cmd_excuteDataTabel()

            With frm_main
                .lbl_username.Text = dts.Rows(0)("users_username")
                .lbl_name.Text = dts.Rows(0)("users_username") & " " & dts.Rows(0)("users_lastname")
                .lbl_Tel.Text = dts.Rows(0)("users_tel")
                .lbl_Timelogin.Text = Date.Now
            End With
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "•"
        End If
    End Sub

    Private Sub lbl_security_code_DoubleClick(sender As Object, e As EventArgs) Handles lbl_security_code.DoubleClick
        lbl_security_code.Text = rnd_security_code()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_remember.CheckedChanged
        If chk_remember.Checked = True Then
            My.Settings.username = txt_username.Text
        Else
            My.Settings.username = ""
        End If
        My.Settings.Save()
    End Sub

End Class
