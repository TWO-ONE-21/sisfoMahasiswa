Imports MySql.Data.MySqlClient

Public Class FormMataKuliah

    Private Sub FormMataKuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        'PosisiList()   SAYA MENGKOMENTARI FUNGSI INI, KARENA KOLOM TELAH SAYA ISI LANGSUNG DI DESIGNER. JADI AGAR TIDAK TERJADI DUPLIKASI KOLOM
        IsiList()
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        bersih()
        IsiList()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtKdMtk.Text = "" Or txtNamaMtk.Text = "" Or txtSKS.Text = "" Then
                MsgBox("Silahkan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Pesan Data Kosong")
                txtKdMtk.Focus()
            Else
                Query = "INSERT INTO tblmatakuliah VALUES('" & txtKdMtk.Text & "','" & txtNamaMtk.Text & "','" & txtSKS.Text & "')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "SAVE")
                IsiList()
                bersih()
                txtKdMtk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Kode Matakuliah ini sudah ada atau program anda bermasalah!", MsgBoxStyle.Exclamation, "Error")
            txtKdMtk.Focus()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtKdMtk.Text = "" Or txtNamaMtk.Text = "" Or txtSKS.Text = "" Then
                MsgBox("Silahkan Pilih Data Yang Akan Di Edit!", MsgBoxStyle.Critical, "Pesan Data Kosong")
                txtKdMtk.Focus()
            Else
                Query = "UPDATE tblmatakuliah SET nmmtk='" & txtNamaMtk.Text & "', sks='" & txtSKS.Text & "' WHERE kdmtk='" & txtKdMtk.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                IsiList()
                bersih()
                txtKdMtk.Focus()
                MsgBox("Data Berhasil Di Edit!", MsgBoxStyle.Information, "Edit Data")
            End If
        Catch ex As Exception
            MsgBox("Data gagal dikoreksi!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim A As String
            A = MsgBox("Benar data akan di delete?...", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
            Select Case A
                Case vbCancel
                    Exit Sub
                Case vbOK
                    If txtKdMtk.Text = "" Then
                        MsgBox("Input Kode Matakuliah Yang Akan Di Hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtKdMtk.Focus()
                    Else
                        Query = "DELETE FROM tblmatakuliah WHERE kdmtk='" & txtKdMtk.Text & "'"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        IsiList()
                        bersih()
                        MsgBox("Data Berhasil Di Delete!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Hapus Data")
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Data tidak bisa di delete, cek program anda", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        caridatamatakuliah()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        caridatamatakuliah()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDataDariListview()
    End Sub

    'SAYA KOMENTARI FUNGSI INI AGAR TIDAK TERJADI DUPLIKASI KOLOM DI LISTVIEW, KARENA KOLOM TELAH SAYA ISI LANGSUNG DI DESIGNER.
    '    Private Sub PosisiList()
    '    With ListView1.Columns
    '        .Add("Kode Matakuliah", 150)
    '        .Add("Nama Matakuliah", 160)
    '        .Add("SKS", 100)
    '    End With
    'End Sub

    Private Sub IsiList()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tblmatakuliah ORDER BY kdmtk"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bersih()
        txtKdMtk.Text = ""
        txtNamaMtk.Text = ""
        txtSKS.Text = ""
    End Sub

    Private Sub AmbilDataDariListview()
        With ListView1.SelectedItems(0)
            Try
                txtKdMtk.Text = .SubItems(0).Text
                txtNamaMtk.Text = .SubItems(1).Text
                txtSKS.Text = .SubItems(2).Text
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub caridatamatakuliah()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tblmatakuliah WHERE kdmtk like '%" & Trim(txtCari.Text) & "%' or nmmtk like '%" & Trim(txtCari.Text) & "%'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

End Class