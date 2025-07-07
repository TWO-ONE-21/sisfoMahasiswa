Imports MySql.Data.MySqlClient

Public Class LHS
    Inherits System.Windows.Forms.Form

    Private Sub LHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        SetDataMhs()
    End Sub

    Private Sub SetDataMhs()
        Try
            Query = "SELECT * FROM tblmahasiswa ORDER BY nim"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            CboNim.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                CboNim.Items.Add(dsData.Tables(0).Rows(a).Item("nim"))
            Next
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data NIM: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CboNim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNim.SelectedIndexChanged
        If CboNim.Text = "" Then
            txtNamaMhs.Text = ""
        Else
            Try
                Query = "SELECT * FROM tblmahasiswa WHERE nim='" & CboNim.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                If dsData.Tables(0).Rows.Count > 0 Then
                    txtNamaMhs.Text = dsData.Tables(0).Rows(0).Item("nama")
                Else
                    MessageBox.Show("Nim ini tidak ditemukan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CboNim.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal mencari nama: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        ' 1. Validasi input
        If String.IsNullOrEmpty(CboNim.Text) Then
            MessageBox.Show("Silakan pilih NIM terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Ambil NIM yang dipilih
        Dim nimToPrint As String = CboNim.Text

        ' 3. Tentukan path lengkap ke file .exe dari proyek laporan Anda
        ' PENTING: Ganti path di bawah ini dengan path di komputer Anda.
        Dim reportAppPath As String = "C:\Users\ACER\source\repos\TWO-ONE-21\sisfoMahasiswa\Laporan\bin\Debug\Laporan.exe"

        Try
            ' 4. Jalankan aplikasi laporan dan kirim NIM sebagai argumen
            System.Diagnostics.Process.Start(reportAppPath, nimToPrint)
        Catch ex As Exception
            MessageBox.Show("Gagal membuka aplikasi laporan. Pastikan path sudah benar." & vbCrLf & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

End Class