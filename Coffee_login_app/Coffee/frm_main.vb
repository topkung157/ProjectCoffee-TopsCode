Public Class frm_main
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        If confirm("ต้องการออกจากระบบหรือไม่?") = vbNo Then Return
        Me.Close()
        Login.Show()
        With Login
            .txt_username.Text = ""
            .txt_password.Text = ""
            .txt_security_code.Text = ""
            .lbl_security_code.Text = rnd_security_code()
            .txt_password.Select()

        End With
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frm_manage_coffee.Show()
        frm_manage_coffee.MdiParent = Me


    End Sub
End Class