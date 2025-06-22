Imports MySql.Data.MySqlClient

Public Class FormMahasiswa
    Friend Property MainForm As Global.sisfoMahasiswa.FormMahasiswa



    Private Sub PosisiList()
            With ListView1.Columns
                .Add("Nim", 60)
                .Add("Nama", 100)
                .Add("Tempat Lahir", 100)
                .Add("Tanggal Lahir", 80)
                .Add("Usia", 90)
                .Add("Jenis Kelamin", 80)
                .Add("Agama", 70)
                .Add("Alamat", 150)
                .Add("Telp/Hp", 90)
            End With
        End Sub

        Private Sub IsiList()
            Dim a As Integer
            Try
                Query = "SELECT * FROM tblmahasiswa ORDER BY nim"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                ListView1.Items.Clear()
                For a = 0 To dsData.Tables(0).Rows.Count - 1
                    With ListView1
                        .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                        .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                        .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                        .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                        .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                        .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                        .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                        .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                        .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(8))
                    End With
                Next
            Catch ex As Exception
            End Try
        End Sub

        Private Sub FormMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                Call KoneksiKeDatabase()
                Call PosisiList()
                Call IsiList()
            Catch ex As Exception
            End Try
        End Sub

End Class