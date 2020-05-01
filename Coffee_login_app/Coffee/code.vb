Imports System.Data.Sql
Imports System.Data.SqlClient


Module code
    'DATA BASE
    Friend cn As New SqlConnection("Data Source=.\SQLEXPRESS; Initial Catalog=coffee; Integrated Security=SSPI;")
    'CMD Sql Command
    Friend cmd As New SqlCommand
    'DA sqldataadapter
    Friend DA As New SqlDataAdapter
    'Sql = command
    Friend sql As String
    'SQL DATA Set
    Friend DS As DataSet
    'Function open() database
    Friend Sub connect_open()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub
    ''ฟังชั่นท์รีเทิร์นค่าบางอย่างจากฐานข้อมูล
    Friend Function cmd_excutescalar()
        connect_open()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar
    End Function
    'ฟังชันท์รีเทิร์น Datatableจากฐานข้อมูล
    Friend Function cmd_excuteDataTabel()
        connect_open()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS.Tables("table")
    End Function
    'ฟังชั่นท์เลขยืนยันตัวตน
    Friend Function rnd_security_code()
        Randomize()
        Dim i As Integer = 999999 * Rnd()
        Return i.ToString.PadLeft(6, "0")
    End Function

    Friend Function cmd_excuteNonquery()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery

    End Function


    Friend Sub msg_error(text As String, Optional title As String = "ผิดพลาด")
        MsgBox(text, vbCritical + vbOKOnly, title)
    End Sub
    Friend Sub msg_ok(text As String, Optional title As String = "สำเร็จ")
        MsgBox(text, vbInformation + vbOKOnly, title)
    End Sub

    Friend Function confirm(text As String, Optional title As String = "ยืนยัน")
        Return MsgBox(text, vbQuestion + vbYesNo, title)
    End Function
End Module
