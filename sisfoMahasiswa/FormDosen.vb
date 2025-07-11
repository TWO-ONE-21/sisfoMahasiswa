﻿Imports MySql.Data.MySqlClient

Public Class FormDosen

    Private Sub FormDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        PosisiList()
        IsiList()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        bersih()
        IsiList()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtNidn.Text = "" Or txtNamaDosen.Text = "" Or txtEmail.Text = "" Or txtTelp.Text = "" Then
                MsgBox("Silahkan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Pesan Data Kosong")
                txtNidn.Focus()
            Else
                Query = "INSERT INTO tbldosen VALUES('" & txtNidn.Text & "','" & txtNamaDosen.Text & "','" & txtEmail.Text & "','" & txtTelp.Text & "')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "SAVE")
                IsiList()
                bersih()
                txtNidn.Focus()
            End If
        Catch ex As Exception
            MsgBox("NIDN ini sudah ada!", MsgBoxStyle.Exclamation, "Error")
            txtNidn.Focus()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtNidn.Text = "" Or txtNamaDosen.Text = "" Or txtEmail.Text = "" Or txtTelp.Text = "" Then
                MsgBox("Silahkan Pilih Data Yang Akan Di Edit!", MsgBoxStyle.Critical, "Pesan Data Kosong")
                txtNidn.Focus()
            Else
                Query = "UPDATE tbldosen SET nmdosen='" & txtNamaDosen.Text & "',email='" & txtEmail.Text & "', telp='" & txtTelp.Text & "' WHERE nidn='" & txtNidn.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                IsiList()
                bersih()
                txtNidn.Focus()
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
                    If txtNidn.Text = "" Then
                        MsgBox("Input NIDN Yang Akan Di Hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtNidn.Focus()
                    Else
                        Query = "DELETE FROM tbldosen WHERE nidn='" & txtNidn.Text & "'"
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

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        caridadosen()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        caridadosen()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDataDariListview()
    End Sub

    Private Sub PosisiList()
        With ListView1.Columns
            .Add("NIDN", 100)
            .Add("Nama Dosen", 160)
            .Add("E-Mail", 160)
            .Add("Telepon", 120)
        End With
    End Sub

    Private Sub IsiList()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbldosen ORDER BY nidn"
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
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bersih()
        txtNidn.Text = ""
        txtNamaDosen.Text = ""
        txtEmail.Text = ""
        txtTelp.Text = ""
    End Sub

    Private Sub AmbilDataDariListview()
        With ListView1.SelectedItems(0)
            Try
                txtNidn.Text = .SubItems(0).Text
                txtNamaDosen.Text = .SubItems(1).Text
                txtEmail.Text = .SubItems(2).Text
                txtTelp.Text = .SubItems(3).Text
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub caridadosen()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbldosen WHERE nidn like '%" & Trim(txtCari.Text) & "%' or nmdosen like '%" & Trim(txtCari.Text) & "%'"
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
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

End Class