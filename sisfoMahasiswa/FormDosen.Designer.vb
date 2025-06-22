<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDosen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelMain = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        txtNim = New TextBox()
        Label3 = New Label()
        txtNamaMhs = New TextBox()
        Label4 = New Label()
        txtTemplhr = New TextBox()
        Label5 = New Label()
        dtpTglLhr = New DateTimePicker()
        Label6 = New Label()
        txtUsia = New TextBox()
        Label11 = New Label()
        rdbLaki_laki = New RadioButton()
        rdbPerempuan = New RadioButton()
        Label10 = New Label()
        cboAgama = New ComboBox()
        Label8 = New Label()
        txtAlmt = New TextBox()
        Label7 = New Label()
        txtTelp = New TextBox()
        btnSave = New Button()
        btnRefresh = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnExit = New Button()
        Label9 = New Label()
        txtCariData = New TextBox()
        btnCariData = New Button()
        ListView1 = New ListView()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        PanelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        PanelMain.Controls.Add(Label1)
        PanelMain.Controls.Add(Label2)
        PanelMain.Controls.Add(txtNim)
        PanelMain.Controls.Add(Label3)
        PanelMain.Controls.Add(txtNamaMhs)
        PanelMain.Controls.Add(Label4)
        PanelMain.Controls.Add(txtTemplhr)
        PanelMain.Controls.Add(Label5)
        PanelMain.Controls.Add(dtpTglLhr)
        PanelMain.Controls.Add(Label6)
        PanelMain.Controls.Add(txtUsia)
        PanelMain.Controls.Add(Label11)
        PanelMain.Controls.Add(rdbLaki_laki)
        PanelMain.Controls.Add(rdbPerempuan)
        PanelMain.Controls.Add(Label10)
        PanelMain.Controls.Add(cboAgama)
        PanelMain.Controls.Add(Label8)
        PanelMain.Controls.Add(txtAlmt)
        PanelMain.Controls.Add(Label7)
        PanelMain.Controls.Add(txtTelp)
        PanelMain.Controls.Add(btnSave)
        PanelMain.Controls.Add(btnRefresh)
        PanelMain.Controls.Add(btnEdit)
        PanelMain.Controls.Add(btnDelete)
        PanelMain.Controls.Add(btnExit)
        PanelMain.Controls.Add(Label9)
        PanelMain.Controls.Add(txtCariData)
        PanelMain.Controls.Add(btnCariData)
        PanelMain.Controls.Add(ListView1)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Padding = New Padding(30)
        PanelMain.Size = New Size(900, 600)
        PanelMain.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(30, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(333, 32)
        Label1.TabIndex = 0
        Label1.Text = "Form Input Data Mahasiswa"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 10.0F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(30, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 25)
        Label2.TabIndex = 1
        Label2.Text = "NIM"
        ' 
        ' txtNim
        ' 
        txtNim.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNim.Font = New Font("Segoe UI", 10.0F)
        txtNim.ForeColor = Color.White
        txtNim.Location = New Point(150, 70)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(104, 25)
        txtNim.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 10.0F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(30, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 25)
        Label3.TabIndex = 3
        Label3.Text = "Nama Mahasiswa"
        ' 
        ' txtNamaMhs
        ' 
        txtNamaMhs.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNamaMhs.Font = New Font("Segoe UI", 10.0F)
        txtNamaMhs.ForeColor = Color.White
        txtNamaMhs.Location = New Point(150, 105)
        txtNamaMhs.Name = "txtNamaMhs"
        txtNamaMhs.Size = New Size(200, 25)
        txtNamaMhs.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 10.0F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(30, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 25)
        Label4.TabIndex = 5
        Label4.Text = "Tempat Lahir"
        ' 
        ' txtTemplhr
        ' 
        txtTemplhr.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtTemplhr.Font = New Font("Segoe UI", 10.0F)
        txtTemplhr.ForeColor = Color.White
        txtTemplhr.Location = New Point(150, 140)
        txtTemplhr.Name = "txtTemplhr"
        txtTemplhr.Size = New Size(200, 25)
        txtTemplhr.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 10.0F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(30, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 25)
        Label5.TabIndex = 7
        Label5.Text = "Tanggal Lahir"
        ' 
        ' dtpTglLhr
        ' 
        dtpTglLhr.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        dtpTglLhr.CalendarForeColor = Color.White
        dtpTglLhr.CalendarMonthBackground = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        dtpTglLhr.CalendarTitleBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        dtpTglLhr.CalendarTitleForeColor = Color.White
        dtpTglLhr.Font = New Font("Segoe UI", 10.0F)
        dtpTglLhr.ForeColor = Color.White
        dtpTglLhr.Format = DateTimePickerFormat.Short
        dtpTglLhr.Location = New Point(150, 175)
        dtpTglLhr.Name = "dtpTglLhr"
        dtpTglLhr.Size = New Size(104, 25)
        dtpTglLhr.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 10.0F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(30, 210)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 25)
        Label6.TabIndex = 9
        Label6.Text = "Usia"
        ' 
        ' txtUsia
        ' 
        txtUsia.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtUsia.Font = New Font("Segoe UI", 10.0F)
        txtUsia.ForeColor = Color.White
        txtUsia.Location = New Point(150, 210)
        txtUsia.Name = "txtUsia"
        txtUsia.Size = New Size(43, 25)
        txtUsia.TabIndex = 10
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 10.0F)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(480, 70)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 25)
        Label11.TabIndex = 11
        Label11.Text = "Jenis Kelamin"
        ' 
        ' rdbLaki_laki
        ' 
        rdbLaki_laki.BackColor = Color.Transparent
        rdbLaki_laki.Font = New Font("Segoe UI", 10.0F)
        rdbLaki_laki.ForeColor = Color.White
        rdbLaki_laki.Location = New Point(600, 70)
        rdbLaki_laki.Name = "rdbLaki_laki"
        rdbLaki_laki.Size = New Size(90, 25)
        rdbLaki_laki.TabIndex = 12
        rdbLaki_laki.Text = "Laki-laki"
        rdbLaki_laki.UseVisualStyleBackColor = False
        ' 
        ' rdbPerempuan
        ' 
        rdbPerempuan.BackColor = Color.Transparent
        rdbPerempuan.Font = New Font("Segoe UI", 10.0F)
        rdbPerempuan.ForeColor = Color.White
        rdbPerempuan.Location = New Point(700, 70)
        rdbPerempuan.Name = "rdbPerempuan"
        rdbPerempuan.Size = New Size(110, 25)
        rdbPerempuan.TabIndex = 13
        rdbPerempuan.Text = "Perempuan"
        rdbPerempuan.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 10.0F)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(480, 105)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 25)
        Label10.TabIndex = 14
        Label10.Text = "Agama"
        ' 
        ' cboAgama
        ' 
        cboAgama.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        cboAgama.DropDownStyle = ComboBoxStyle.DropDownList
        cboAgama.Font = New Font("Segoe UI", 10.0F)
        cboAgama.ForeColor = Color.White
        cboAgama.Items.AddRange(New Object() {"Islam", "Kristen", "Budha", "Hindu", "Kong Hu Chu"})
        cboAgama.Location = New Point(600, 105)
        cboAgama.Name = "cboAgama"
        cboAgama.Size = New Size(150, 25)
        cboAgama.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 10.0F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(480, 140)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 25)
        Label8.TabIndex = 16
        Label8.Text = "Alamat"
        ' 
        ' txtAlmt
        ' 
        txtAlmt.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtAlmt.Font = New Font("Segoe UI", 10.0F)
        txtAlmt.ForeColor = Color.White
        txtAlmt.Location = New Point(600, 140)
        txtAlmt.Multiline = True
        txtAlmt.Name = "txtAlmt"
        txtAlmt.Size = New Size(250, 60)
        txtAlmt.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 10.0F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(480, 210)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 25)
        Label7.TabIndex = 18
        Label7.Text = "Telpon/HP"
        ' 
        ' txtTelp
        ' 
        txtTelp.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtTelp.Font = New Font("Segoe UI", 10.0F)
        txtTelp.ForeColor = Color.White
        txtTelp.Location = New Point(600, 210)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(200, 25)
        txtTelp.TabIndex = 19
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(185, 266)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(90, 32)
        btnSave.TabIndex = 20
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(291, 266)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(90, 32)
        btnRefresh.TabIndex = 21
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(397, 266)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(90, 32)
        btnEdit.TabIndex = 22
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(503, 266)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 32)
        btnDelete.TabIndex = 23
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(609, 266)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(90, 32)
        btnExit.TabIndex = 24
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 10.0F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(30, 320)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 25)
        Label9.TabIndex = 25
        Label9.Text = "Pencarian"
        ' 
        ' txtCariData
        ' 
        txtCariData.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtCariData.Font = New Font("Segoe UI", 10.0F)
        txtCariData.ForeColor = Color.White
        txtCariData.Location = New Point(120, 320)
        txtCariData.Name = "txtCariData"
        txtCariData.Size = New Size(250, 25)
        txtCariData.TabIndex = 26
        ' 
        ' btnCariData
        ' 
        btnCariData.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnCariData.FlatStyle = FlatStyle.Flat
        btnCariData.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCariData.ForeColor = Color.White
        btnCariData.Location = New Point(380, 318)
        btnCariData.Name = "btnCariData"
        btnCariData.Size = New Size(80, 28)
        btnCariData.TabIndex = 27
        btnCariData.Text = "Cari"
        btnCariData.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader2, ColumnHeader1, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9})
        ListView1.Font = New Font("Segoe UI", 10.0F)
        ListView1.ForeColor = Color.White
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(30, 360)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(820, 200)
        ListView1.TabIndex = 28
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "NIM"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Nama"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Tempat Lahir"
        ColumnHeader3.Width = 120
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Tanggal Lahir"
        ColumnHeader4.Width = 110
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Usia"
        ColumnHeader5.Width = 50
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Jenis Kelamin"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Agama"
        ColumnHeader7.Width = 90
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Alamat"
        ColumnHeader8.Width = 150
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Telp/HP"
        ColumnHeader9.Width = 100
        ' 
        ' FormMahasiswa
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        ClientSize = New Size(900, 600)
        Controls.Add(PanelMain)
        Font = New Font("Segoe UI", 10.0F)
        ForeColor = Color.White
        Name = "FormMahasiswa"
        Text = "FormMahasiswa"
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamaMhs As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTemplhr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpTglLhr As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsia As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents rdbLaki_laki As RadioButton
    Friend WithEvents rdbPerempuan As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cboAgama As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAlmt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCariData As TextBox
    Friend WithEvents btnCariData As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
End Class
