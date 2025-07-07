Imports MySql.Data.MySqlClient

Public Class FormCariMTK

    Private Sub PosisiList()
        With ListView1.Columns
            .Clear()
            .Add("Kode Mata Kuliah", 180)
            .Add("Nama Mata Kuliah", 400)
            .Add("SKS", 100)
        End With
    End Sub

    Private Sub IsiList()
        RemoveHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
        ListView1.Items.Clear()

        Dim a As Integer
        Query = "SELECT * FROM tblmatakuliah ORDER BY kdmtk"
        dsData = New DataSet
        daData = New MySqlDataAdapter(Query, Conn)
        daData.Fill(dsData)

        For a = 0 To dsData.Tables(0).Rows.Count - 1
            With ListView1.Items.Add(dsData.Tables(0).Rows(a).Item("kdmtk"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("nmmtk"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("sks"))
            End With
        Next

        AddHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
    End Sub

    Private Sub caridatamtk()
        RemoveHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
        ListView1.Items.Clear()

        Dim a As Integer
        Query = "SELECT * FROM tblmatakuliah WHERE kdmtk like '%" & Trim(txtCariData.Text) & "%' or nmmtk like '%" & Trim(txtCariData.Text) & "%'"
        dsData = New DataSet
        daData = New MySqlDataAdapter(Query, Conn)
        daData.Fill(dsData)

        For a = 0 To dsData.Tables(0).Rows.Count - 1
            With ListView1.Items.Add(dsData.Tables(0).Rows(a).Item("kdmtk"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("nmmtk"))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item("sks"))
            End With
        Next

        AddHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
    End Sub

    Private Sub AmbilDataDariListview()
        Try
            FormNilai.txtKdMtk.Text = ListView1.SelectedItems(0).SubItems(0).Text
            FormNilai.txtNamaMtk.Text = ListView1.SelectedItems(0).SubItems(1).Text
            FormNilai.txtSKS.Text = ListView1.SelectedItems(0).SubItems(2).Text
        Catch ex As Exception
        End Try
    End Sub


    Private Sub FormCariMTK_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PosisiList()
        IsiList()
    End Sub

    Private Sub txtCariData_TextChanged(sender As Object, e As EventArgs) Handles txtCariData.TextChanged
        caridatamtk()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            AmbilDataDariListview()
            Me.DialogResult = DialogResult.OK
        End If
    End Sub


End Class