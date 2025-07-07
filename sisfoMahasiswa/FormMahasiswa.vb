Imports MySql.Data.MySqlClient

Public Class FormMahasiswa

    Friend Property MainForm As Global.sisfoMahasiswa.FormMahasiswa
    Dim agama As String


    Private Sub FormMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call KoneksiKeDatabase()
            Call PosisiList()
            Call IsiList()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim jenkel As String
            If rdbLaki_laki.Checked = True Then
                jenkel = "Laki-Laki"
            Else
                jenkel = "Perempuan"
            End If

            If txtNim.Text = "" Or txtNamaMhs.Text = "" Or txtTemplhr.Text = "" Or txtUsia.Text = "" Or txtAlmt.Text = "" Or txtTelp.Text = "" Then
                MsgBox("Silahkan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Pesan Data Kosong")
                txtNim.Focus()
            Else
                Query = "INSERT INTO tblmahasiswa VALUES('" & txtNim.Text & "','" & txtNamaMhs.Text & "','" & txtTemplhr.Text & "','" & Format(dtpTglLhr.Value, "yyyy/MM/dd") & "','" & txtUsia.Text & "','" & jenkel & "','" & agama & "','" & txtAlmt.Text & "','" & txtTelp.Text & "')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data berhasil disimpan!", MsgBoxStyle.Critical, "SAVE")
                txtNim.Focus()
                IsiList()
                bersih()
            End If
        Catch ex As Exception
            MsgBox("NIM ini sudah ada! / kesalahan kode program!", MsgBoxStyle.Exclamation, "Error")
            txtNim.Focus()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim jenkel As String
            If rdbLaki_laki.Checked = True Then
                jenkel = "Laki-Laki"
            Else
                jenkel = "Perempuan"
            End If

            If txtNim.Text = "" Or txtNamaMhs.Text = "" Or txtTemplhr.Text = "" Or txtUsia.Text = "" Or txtAlmt.Text = "" Or txtTelp.Text = "" Then
                MsgBox("Silahkan Pilih Data Yang Akan Di Edit!", MsgBoxStyle.Critical, "Pesan Data Kosong")
                txtNim.Focus()
            Else
                Query = "UPDATE tblmahasiswa SET nama='" & txtNamaMhs.Text & "', tlhr='" & txtTemplhr.Text & "', tgllhr='" & Format(dtpTglLhr.Value, "yyyy/MM/dd") & "', usia='" & txtUsia.Text & "', jenkel='" & jenkel & "', agama='" & agama & "', almt='" & txtAlmt.Text & "', telp='" & txtTelp.Text & "' WHERE nim='" & txtNim.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data Berhasil Di Edit!", MsgBoxStyle.Critical, "Edit Data")
                IsiList()
                bersih()
                txtNim.Focus()
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
                    If txtNim.Text = "" Then
                        MsgBox("Input Nim Yang Akan Di Hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtNim.Focus()
                    Else
                        Query = "DELETE FROM tblmahasiswa WHERE nim='" & txtNim.Text & "'"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        IsiList()
                        bersih()
                        MsgBox("Data Berhasil Di Delete!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Data tidak bisa di delete, cek program anda", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        bersih()
        IsiList()
    End Sub

    Private Sub btnCariData_Click(sender As Object, e As EventArgs) Handles btnCariData.Click
        caridataMhs()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDataDariListview()
    End Sub

    Private Sub txtCariData_TextChanged(sender As Object, e As EventArgs) Handles txtCariData.TextChanged
        caridataMhs()
    End Sub

    Private Sub dtptgllhr_ValueChanged(sender As Object, e As EventArgs) Handles dtpTglLhr.ValueChanged
        Usia()
    End Sub

    Private Sub cbIslam_CheckedChanged(sender As Object, e As EventArgs) Handles cboIslam.CheckedChanged
        If cboIslam.Checked = True Then
            cboKristen.Checked = False
            agama = "Islam"
        End If
    End Sub

    Private Sub cbKristen_CheckedChanged(sender As Object, e As EventArgs) Handles cboKristen.CheckedChanged
        If cboKristen.Checked = True Then
            cboIslam.Checked = False
            agama = "Kristen"
        End If
    End Sub


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

    Private Sub caridataMhs()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tblmahasiswa WHERE nim like '%" & Trim(txtCariData.Text) & "%' or nama like '%" & Trim(txtCariData.Text) & "%'"
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

    Private Sub bersih()
        txtNim.Text = ""
        txtNamaMhs.Text = ""
        txtTemplhr.Text = ""
        txtUsia.Text = ""
        rdbLaki_laki.Checked = False
        rdbPerempuan.Checked = False
        cboIslam.Checked = False
        cboKristen.Checked = False
        txtAlmt.Text = ""
        txtTelp.Text = ""
    End Sub

    Private Sub AmbilDataDariListview()
        With ListView1.SelectedItems(0)
            Try
                txtNim.Text = .SubItems(0).Text
                txtNamaMhs.Text = .SubItems(1).Text
                txtTemplhr.Text = .SubItems(2).Text
                dtpTglLhr.Text = .SubItems(3).Text
                txtUsia.Text = .SubItems(4).Text

                Dim jenkel As String
                jenkel = .SubItems(5).Text
                If jenkel = "Laki-Laki" Then
                    rdbLaki_laki.Checked = True
                Else
                    rdbPerempuan.Checked = True
                End If

                Dim agamahs As String
                agamahs = .SubItems(6).Text
                If agamahs = "Islam" Then
                    cboIslam.Checked = True
                Else
                    cboKristen.Checked = True
                End If

                txtAlmt.Text = .SubItems(7).Text
                txtTelp.Text = .SubItems(8).Text
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub Usia()
        Dim thn, bln As String
        thn = Year(Now) - Year(dtpTglLhr.Value)
        bln = Month(Now) - Month(dtpTglLhr.Value)
        txtUsia.Text = thn & " Tahun, " & bln & " Bulan"
    End Sub

End Class