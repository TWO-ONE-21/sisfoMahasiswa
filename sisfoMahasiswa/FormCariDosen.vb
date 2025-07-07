Imports MySql.Data.MySqlClient

Public Class FormCariDosen

    Private Sub PosisiList()
        With ListView1.Columns
            .Clear()
            .Add("NIDN", 120)
            .Add("Nama Dosen", 250)
            .Add("Email", 200)
            .Add("Telepon", 120)
        End With
    End Sub

    Private Sub IsiList()
        RemoveHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
        ListView1.Items.Clear()

        Dim a As Integer
        Query = "SELECT * FROM tbldosen ORDER BY nidn"
        dsData = New DataSet
        daData = New MySqlDataAdapter(Query, Conn)
        daData.Fill(dsData)

        For a = 0 To dsData.Tables(0).Rows.Count - 1
            With ListView1.Items.Add(dsData.Tables(0).Rows(a).Item("nidn"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("nmdosen"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("email"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("telp"))
            End With
        Next

        AddHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
    End Sub

    Private Sub caridadosen()
        RemoveHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
        ListView1.Items.Clear()

        Dim a As Integer
        Query = "SELECT * FROM tbldosen WHERE nidn LIKE '%" & Trim(txtCariData.Text) & "%' OR nmdosen LIKE '%" & Trim(txtCariData.Text) & "%'"
        dsData = New DataSet
        daData = New MySqlDataAdapter(Query, Conn)
        daData.Fill(dsData)

        For a = 0 To dsData.Tables(0).Rows.Count - 1
            With ListView1.Items.Add(dsData.Tables(0).Rows(a).Item("nidn"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("nmdosen"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("email"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("telp"))
            End With
        Next

        AddHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
    End Sub

    Private Sub AmbilDataDariListview()
        Try
            FormNilai.txtNIDN.Text = ListView1.SelectedItems(0).SubItems(0).Text
            FormNilai.txtNamaDosen.Text = ListView1.SelectedItems(0).SubItems(1).Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormCariDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PosisiList()
        IsiList()
    End Sub

    Private Sub txtCariData_TextChanged(sender As Object, e As EventArgs) Handles txtCariData.TextChanged
        caridadosen()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            AmbilDataDariListview()
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

End Class