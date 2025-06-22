Imports MySql.Data.MySqlClient
Module BukaKoneksi
    Public Conn As New MySql.Data.MySqlClient.MySqlConnection
    Public daData As New MySqlDataAdapter
    Public dsData As New DataSet
    Public Query As String
    Public RD As MySqlDataReader
    Public cmd As New MySqlCommand

    Public Sub KoneksiKeDatabase()
        Try
            Dim str As String = "Server=localhost;user id=root;database=dbnilai"
            Conn = New MySqlConnection(str)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox("Koneksi ke server gagal")
        End Try
    End Sub
End Module