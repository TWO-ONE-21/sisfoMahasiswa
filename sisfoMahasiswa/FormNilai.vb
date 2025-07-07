Imports MySql.Data.MySqlClient
Public Class FormNilai
    Dim sks As Integer
    Dim nilaiakhir As Double
    Dim bobot, jumlahnilai As Integer
    Dim nilaihuruf, keterangan As String
    Dim idnilai As String

    Private Sub FormNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        PosisiList()
        IsiList()
    End Sub

    Private Sub BtnCariMhs_Click(sender As Object, e As EventArgs) Handles BtnCariMhs.Click
        FormCariMhs.ShowDialog()
    End Sub

    Private Sub BtnCariDosen_Click(sender As Object, e As EventArgs) Handles BtnCariDosen.Click
        FormCariDosen.ShowDialog()
    End Sub

    Private Sub BtnCariMtk_Click(sender As Object, e As EventArgs) Handles BtnCariMtk.Click
        FormCariMTK.ShowDialog()
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        prosesnilai()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If CboTA.Text = "" Or CboSem.Text = "" Or txtNim.Text = "" Or txtNIDN.Text = "" Or txtKdMtk.Text = "" Or txtNilaiAkhir.Text = "" Or txtNilaiHuruf.Text = "" Or txtBobot.Text = "" Or txtJmlNilai.Text = "" Or txtKet.Text = "" Then
                MsgBox("Silahkan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Pesan Data Kosong")
            Else
                Call KoneksiKeDatabase()
                cmd = New MySqlCommand("select * from tblnilai where nim='" & txtNim.Text & "' and kdmtk='" & txtKdMtk.Text & "'", Conn)
                RD = cmd.ExecuteReader
                RD.Read()
                If RD.HasRows = True Then
                    MsgBox("Nim dan Kode mtk ini sudah ada!", MsgBoxStyle.Critical, "Pesan Ganda")
                Else
                    Call KoneksiKeDatabase()
                    Query = "insert into tblnilai(ta,sem,nim,nidn,kdmtk,na,nh,bbt,jml,ket) values ('" & CboTA.Text & "','" & CboSem.Text & "','" & txtNim.Text & "','" & txtNIDN.Text & "','" & txtKdMtk.Text & "','" & txtNilaiAkhir.Text & "','" & txtNilaiHuruf.Text & "','" & txtBobot.Text & "','" & txtJmlNilai.Text & "','" & txtKet.Text & "')"
                    daData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    daData.Fill(dsData)
                    MsgBox("Data berhasil disimpan!", MsgBoxStyle.Critical, "SAVE")
                    CboTA.Focus()
                    IsiList()
                    txtNIDN.Text = ""
                    txtNamaDosen.Text = ""
                    txtKdMtk.Text = ""
                    txtNamaMtk.Text = ""
                    txtSKS.Text = ""
                    txtNilaiAkhir.Text = ""
                    txtNilaiHuruf.Text = ""
                    txtBobot.Text = ""
                    txtJmlNilai.Text = ""
                    txtKet.Text = ""
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If String.IsNullOrWhiteSpace(idnilai) Then
                MsgBox("Pilih data dari daftar terlebih dahulu sebelum mengedit", "Pesan Peringatan")
            Else
                Call KoneksiKeDatabase()
                Query = "UPDATE tblnilai SET ta='" & CboTA.Text & "',sem='" & CboSem.Text & "',nim='" & txtNim.Text & "',nidn='" & txtNIDN.Text & "',kdmtk='" & txtKdMtk.Text & "',na='" & txtNilaiAkhir.Text & "',nh='" & txtNilaiHuruf.Text & "',bbt='" & txtBobot.Text & "',jml='" & txtJmlNilai.Text & "',ket='" & txtKet.Text & "' WHERE id_nilai=" & idnilai

                cmd = New MySqlCommand(Query, Conn)
                cmd.ExecuteNonQuery()

                ' ## PERBAIKAN FINAL ADA DI BARIS INI ##
                MsgBox("Data berhasil di edit!", MsgBoxStyle.Information, "Edit")

                bersihkandata()
                IsiList()
                CboTA.Focus()
            End If
        Catch ex As Exception
            ' Sekarang Catch ini akan menampilkan pesan error yang sesungguhnya
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Galat")
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
                    Query = "DELETE from tblnilai where id_nilai='" & idnilai & "'"
                    daData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    daData.Fill(dsData)
                    IsiList()
                    bersihkandata()
                    MsgBox("Data Berhasil Di Delete", MsgBoxStyle.OkOnly, "Hapus Data")
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        bersihkandata()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub PosisiList()
        With ListView1.Columns
            .Add("Id Nilai", 60)
            .Add("Tahun Akademik", 100)
            .Add("Semester", 70)
            .Add("Nim", 70)
            .Add("Nama Mahasiswa", 130)
            .Add("NIDN", 80)
            .Add("Nama Dosen", 130)
            .Add("Kode MTK", 70)
            .Add("Nama Matakuliah", 130)
            .Add("SKS", 70)
            .Add("Nilai Akhir", 70)
            .Add("Nilai Huruf", 70)
            .Add("Bobot", 70)
            .Add("Jumlah", 70)
            .Add("Keterangan", 130)
        End With
    End Sub

    Private Sub IsiList()
        Dim a As Integer
        Try
            Query = "Select * from querynilai Order by Nim"
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
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(11))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(12))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(15))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(16))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(17))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(18))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(19))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(20))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(21))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(22))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AmbilDataDariListview()
        With ListView1.SelectedItems(0)
            idnilai = .SubItems(0).Text
            CboTA.Text = .SubItems(1).Text
            CboSem.Text = .SubItems(2).Text
            txtNim.Text = .SubItems(3).Text
            txtNamaMhs.Text = .SubItems(4).Text
            txtNIDN.Text = .SubItems(5).Text
            txtNamaDosen.Text = .SubItems(6).Text
            txtKdMtk.Text = .SubItems(7).Text
            txtNamaMtk.Text = .SubItems(8).Text
            txtSKS.Text = .SubItems(9).Text
            txtNilaiAkhir.Text = .SubItems(10).Text
            txtNilaiHuruf.Text = .SubItems(11).Text
            txtBobot.Text = .SubItems(12).Text
            txtJmlNilai.Text = .SubItems(13).Text
            txtKet.Text = .SubItems(14).Text
        End With
    End Sub

    Private Sub prosesnilai()
        sks = txtSKS.Text
        nilaiakhir = txtNilaiAkhir.Text

        If (nilaiakhir >= 80) And (nilaiakhir <= 100) Then
            nilaihuruf = "A"
            bobot = 4
            jumlahnilai = sks * bobot
            keterangan = "Sangat Memuaskan"
        ElseIf (nilaiakhir >= 70) And (nilaiakhir < 80) Then
            nilaihuruf = "B"
            bobot = 3
            jumlahnilai = sks * bobot
            keterangan = "Memuaskan"
        ElseIf (nilaiakhir >= 60) And (nilaiakhir < 70) Then
            nilaihuruf = "C"
            bobot = 2
            jumlahnilai = sks * bobot
            keterangan = "Cukup"
        ElseIf (nilaiakhir >= 45) And (nilaiakhir < 60) Then
            nilaihuruf = "D"
            bobot = 1
            jumlahnilai = sks * bobot
            keterangan = "Kurang"
        ElseIf (nilaiakhir >= 0) And (nilaiakhir < 45) Then
            nilaihuruf = "E"
            bobot = 0
            jumlahnilai = sks * bobot
            keterangan = "Gagal"
        Else
            nilaihuruf = "Error"
        End If

        txtNilaiHuruf.Text = nilaihuruf
        txtBobot.Text = bobot
        txtJmlNilai.Text = jumlahnilai
        txtKet.Text = keterangan
    End Sub

    Private Sub btnCariData_Click(sender As Object, e As EventArgs) Handles btnCariData.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDataDariListview()
    End Sub

    Private Sub bersihkandata()
        CboTA.Text = ""
        CboSem.Text = ""
        txtNim.Text = ""
        txtNamaMhs.Text = ""
        txtNIDN.Text = ""
        txtNamaDosen.Text = ""
        txtKdMtk.Text = ""
        txtNamaMtk.Text = ""
        txtSKS.Text = ""
        txtNilaiAkhir.Text = ""
        txtNilaiHuruf.Text = ""
        txtBobot.Text = ""
        txtJmlNilai.Text = ""
        txtKet.Text = ""
        txtCariData.Text = ""
    End Sub

    'agar ketika trkan enter pada txtNilaiAkhir, proses nilai langsung dilakukan
    Private Sub txtNilaiAkhir_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNilaiAkhir.KeyDown
        If e.KeyCode = Keys.Enter Then
            prosesnilai()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class