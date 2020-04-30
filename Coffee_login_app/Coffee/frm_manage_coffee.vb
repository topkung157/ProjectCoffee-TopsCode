Public Class frm_manage_coffee
    Public Sub refresh_coffee()
        sql = "selcet coffee_id, coffee_name, coffee_image from coffee"
        DataGrid_coffee.DataSource = cmd_excuteDataTabel()
        change_datagrid_column()
    End Sub
    Public Sub change_datagrid_column()
        Dim column_text() As String = {"ID", "Name", "Pictures"}
        For i As Integer = 0 To DataGrid_coffee.ColumnCount - 1
            DataGrid_coffee.Columns(i).HeaderText = column_text(i)
        Next
    End Sub

    Public Sub clear_form()
        txt_add_price_ice.Text = ""
        txt_add_price_hot.Text = ""
        txt_add_id.Text = ""
        txt_add_name.Text = ""
        txt_add_pricr_smoot.Text = ""
        txt_search.Text = ""
        pic_add.Image = Nothing

    End Sub
    Private Sub frm_manage_coffee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coffee()
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        If confirm("ต้องการเพิ่มกาแฟหรือไม่") = vbNo Then
            Return
        End If

        If txt_add_id.Text = "" Or txt_add_name.Text = "" Or txt_add_price_hot.Text = "" Or txt_add_price_ice.Text = "" Or txt_add_pricr_smoot.Text = "" Then
            msg_error("กรุณาขอข้อมูล")
            Return
        End If

        If Not IsNumeric(txt_add_price_hot.Text) Or Not IsNumeric(txt_add_price_ice.Text) Or Not IsNumeric(txt_add_pricr_smoot.Text) Then
            msg_error("กรอกเป็นตัวเลขเท่านั้น")
            Return
        End If
        If pic_add.Image Is Nothing Then
            sql = "insert into coffee(coffee_in, coffee_name, coffee_hot, coffee_ice, coffee_smoot) value(@id,@name,@hot,@ice,@smoot)"
        Else
            sql = "insert into coffee(coffee_in, coffee_name, coffee_hot, coffee_ice, coffee_smoot, coffee_image) value(@id,@name,@hot,@ice,@smoot,@image)"
        End If
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txt_add_id.Text)
        cmd.Parameters.AddWithValue("name", txt_add_name.Text)
        cmd.Parameters.AddWithValue("hot", txt_add_price_hot.Text)
        cmd.Parameters.AddWithValue("ice", txt_add_price_ice.Text)
        cmd.Parameters.AddWithValue("smoot", txt_add_pricr_smoot.Text)
        If Not pic_add.Image Is Nothing Then
            ''Add Imag
            Dim mem As New IO.MemoryStream
            pic_add.Image.Save(mem, Imaging.ImageFormat.Bmp)
            Dim pic_for_add() As Byte
            pic_for_add = mem.ToArray()
            cmd.Parameters.AddWithValue("img", pic_for_add)
        End If
        If cmd.ExecuteNonQuery = 0 Then
            msg_error("เพิ่มไม่สำเร็จ")
        Else
            msg_ok("เพิ่มสำเร็จ")
            refresh_coffee()
            clear_form()
        End If

    End Sub

    Private Sub btn_select_Pictures_Click(sender As Object, e As EventArgs) Handles btn_select_Pictures.Click
        If OpenFile_coffee.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim img As Image
            img = Image.FromFile(OpenFile_coffee.FileName)
            pic_add.Image = img
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        sql = "select coffee_id, coffee_name, coffee_image from coffee where coffee_id like '%" & txt_search.Text & "%' or coffee_name like '%" & txt_search.Text & "%'"
        DataGrid_coffee.DataSource = cmd_excuteDataTabel()
        change_datagrid_column()
    End Sub

    Private Sub DataGrid_coffee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_coffee.CellContentClick

    End Sub

    Private Sub DataGrid_coffee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_coffee.CellClick
        Dim select_row As Integer = DataGrid_coffee.CurrentRow.Index
        Dim coffee_id As String = DataGrid_coffee.Item(0, select_row).Value
        sql = "select * from coffee where coffee_id='" & coffee_id & "'"
        Dim data_keep As DataTable = cmd_excuteDataTabel()
        txt_Edit_id.Text = data_keep.Rows(0)("coffee_id")
        txt_Edit_name.Text = data_keep.Rows(0)("coffee_name")
        txt_Edit_hot.Text = data_keep.Rows(0)("coffee_hot")
        txt_Edit_ice.Text = data_keep.Rows(0)("coffee_ice")
        txt_Edit_smoot.Text = data_keep.Rows(0)("coffee_smoot")
        Dim img() As Byte = data_keep.Rows(0)("coffee_image")
        pic_Edit.Image = Image.FromStream(New IO.MemoryStream(CType(img, Byte())))


    End Sub

    Private Sub btn_save_Edit_Click(sender As Object, e As EventArgs) Handles btn_save_Edit.Click
        If confirm("คุณต้องการแก้ไขกาแฟหรือไม่ ?") = vbNo Then Return
        If txt_Edit_ice.Text = "" Or txt_Edit_hot.Text = "" Or txt_Edit_id.Text = "" Or txt_Edit_name.Text = "" Or txt_Edit_smoot.Text = "" Then
            msg_error("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If pic_Edit.Image Is Nothing Then
            sql = "update coffee set coffee_name=@name, coffee_hot=@hot, coffee_ice=@ice, coffee_smoot=@smoot where coffee_id=@id"
        Else
            sql = "update coffee set coffee_name=@name, coffee_hot=@hot, coffee_ice=@ice, coffee_smoot=@smoot, coffee_image=@img where coffee_id=@id"

        End If

        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("name", txt_Edit_name.Text)
        cmd.Parameters.AddWithValue("hot", txt_Edit_hot.Text)
        cmd.Parameters.AddWithValue("ice", txt_Edit_ice.Text)
        cmd.Parameters.AddWithValue("smoot", txt_Edit_smoot.Text)
        cmd.Parameters.AddWithValue("id", txt_Edit_id.Text)
        If Not pic_Edit.Image Is Nothing Then

            Dim mem As New IO.MemoryStream
            pic_Edit.Image.Save(mem, Imaging.ImageFormat.Bmp)
            Dim pic_for_add() As Byte
            pic_for_add = mem.ToArray()
            cmd.Parameters.AddWithValue("img", pic_for_add)
        End If
        If cmd.ExecuteNonQuery() = 0 Then
            msg_error("ไม่สามารถแก้ไขได้")
        Else
            msg_ok("แก้ไขสำเร็จ")
            refresh_coffee()
            txt_confirm.Text = ""
            frm_coffeeSale.refresh__coffee()
        End If

    End Sub

    Private Sub btn_select_Edit_picture_Click(sender As Object, e As EventArgs) Handles btn_select_Edit_picture.Click
        If OpenFile_coffee.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim img As Image
            img = Image.FromFile(OpenFile_coffee.FileName)
            pic_Edit.Image = img
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_confirm.Text <> "ยืนยันการลบ" Then
            msg_error("กรุณาพิมพ์ คำว่า ยืนยัน ในช่องว่างใหม่อีกครั้ง")
            txt_confirm.Text = ""
            txt_confirm.Select()
            Return
        End If
        Dim select_id As Integer = DataGrid_coffee.CurrentRow.Index
        Dim coffee_id As String = DataGrid_coffee.Item(0, select_id).Value

        sql = "delete from coffee where coffee_id = '" & coffee_id & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("ไม่สามารถลบได้")
        Else
            msg_ok("สามารถลบได้")
            refresh_coffee()

        End If
    End Sub
End Class