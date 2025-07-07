Imports MySql.Data.MySqlClient

Public Class FormCariMhs

    Private Sub PosisiList()
        With ListView1.Columns
            .Clear()
            .Add("NIM", 100)
            .Add("Nama", 100)
            .Add("Tempat Lahir", 100)
            .Add("Tanggal Lahir", 90)
            .Add("Usia", 80)
            .Add("Jenis Kelamin", 80)
            .Add("Agama", 70)
            .Add("Alamat", 150)
            .Add("Telp/Hp", 90)
        End With
    End Sub

    Private Sub IsiList()
        ' ini untuk menghindari error saat tidak ada item yang dipilih 
        RemoveHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
        ListView1.Items.Clear()

        Dim a As Integer
        Query = "SELECT * FROM tblmahasiswa ORDER BY nim"
        dsData = New DataSet
        daData = New MySqlDataAdapter(Query, Conn)
        daData.Fill(dsData)

        For a = 0 To dsData.Tables(0).Rows.Count - 1
            With ListView1.Items.Add(dsData.Tables(0).Rows(a).Item(0))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(8))
            End With
        Next

        AddHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
    End Sub

    Private Sub caridatamhs()
        'ini juga sama seperti di atas, untuk menghindari error saat tidak ada item yang dipilih
        RemoveHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
        ListView1.Items.Clear()

        Dim a As Integer
        Query = "SELECT * FROM tblmahasiswa WHERE nim like '%" & Trim(txtCariData.Text) & "%' or nama like '%" & Trim(txtCariData.Text) & "%'"
        dsData = New DataSet
        daData = New MySqlDataAdapter(Query, Conn)
        daData.Fill(dsData)

        For a = 0 To dsData.Tables(0).Rows.Count - 1
            With ListView1.Items.Add(dsData.Tables(0).Rows(a).Item(0))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                .SubItems.Add(dsData.Tables(0).Rows(a).Item(8))
            End With
        Next

        'saya tambahkan ini untuk menghindari error saat tidak ada data yang ditemukan karena tidak ada item yang dipilih, pak
        AddHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
    End Sub

    Private Sub AmbilDataDariListview()
        Try
            FormNilai.txtNim.Text = ListView1.SelectedItems(0).SubItems(0).Text
            FormNilai.txtNamaMhs.Text = ListView1.SelectedItems(0).SubItems(1).Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormCariMhs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        PosisiList()
        IsiList()
    End Sub

    Private Sub txtCariData_TextChanged(sender As Object, e As EventArgs) Handles txtCariData.TextChanged
        caridatamhs()
    End Sub

    Private Sub btnCariData_Click(sender As Object, e As EventArgs) Handles btnCariData.Click
        caridatamhs()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            AmbilDataDariListview()

            ' saya sempat pusing mencari solusi, karena dengan kode 'FormCariMhs.Show' di FormNilai dan Me.Close() disini,
            ' selalu tertampil error yang kira-kira mengatakan, tidak bisa memilih item dengan index -1, jadi setelah mencari
            ' tau sana sini, saya menemukan solusi terbaik di SO adalah dengan mengubahnya menjadi FormDialog, dan beginilah
            ' cara menutupnya
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

End Class