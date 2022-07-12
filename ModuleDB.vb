Imports MySql.Data.MySqlClient
Module ModuleDB
    Public conn As MySqlConnection
    Public cmd As New MySqlCommand
    Public ds As DataSet
    Public adapter As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public conString As String

    Public Sub ambilKoneksi()
        conString = "server=localhost; user id=root; password=; database=db_sotobabaelon"
        Try
            conn = New MySqlConnection(conString)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
