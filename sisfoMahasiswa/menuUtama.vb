Imports MySql.Data.MySqlClient


Public Class menuUtama
    Inherits System.Windows.Forms.Form
    Private Sub menuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuatDataDashboard()
    End Sub

    Private Sub MuatDataDashboard()
        Try
            Call KoneksiKeDatabase()

            Dim cmdMhs As New MySqlCommand("SELECT COUNT(*) FROM tblmahasiswa", Conn)
            Dim jumlahMhs As Integer = Convert.ToInt32(cmdMhs.ExecuteScalar())
            lblJumlahMahasiswa.Text = $"<b>{jumlahMhs}</b><br>Mahasiswa Terdaftar"

            Dim cmdMk As New MySqlCommand("SELECT COUNT(*) FROM tblmatakuliah", Conn)
            Dim jumlahMk As Integer = Convert.ToInt32(cmdMk.ExecuteScalar())
            lblJumlahMatakuliah.Text = $"<b>{jumlahMk}</b><br>Mata Kuliah"

            Dim cmdDosen As New MySqlCommand("SELECT COUNT(*) FROM tbldosen", Conn)
            Dim jumlahDosen As Integer = Convert.ToInt32(cmdDosen.ExecuteScalar())
            lblJumlahDosen.Text = $"<b>{jumlahDosen}</b><br>Dosen Pengajar"

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data dashboard: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnInputData_Click(sender As Object, e As EventArgs) Handles btnInputData.Click
        ContextMenuStrip1.Show(btnInputData, New Point(0, btnInputData.Height))
    End Sub

    Private Sub btnProsesNilai_Click(sender As Object, e As EventArgs) Handles btnProsesNilai.Click
        FormNilai.ShowDialog()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Dim reportAppPath As String = "C:\Users\ACER\source\repos\TWO-ONE-21\sisfoMahasiswa\Laporan\bin\Debug\Laporan.exe"

        Try
            ' Jalankan aplikasi laporan
            System.Diagnostics.Process.Start(reportAppPath)
        Catch ex As Exception
            MessageBox.Show("Gagal membuka aplikasi laporan: " & vbCrLf & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMahasiswaToolStripMenuItem.Click
        FormMahasiswa.ShowDialog()
    End Sub

    Private Sub DataMataKuliahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMataKuliahToolStripMenuItem.Click
        FormMataKuliah.ShowDialog()
    End Sub

    Private Sub DataDosenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDosenToolStripMenuItem.Click
        FormDosen.ShowDialog()
    End Sub

End Class