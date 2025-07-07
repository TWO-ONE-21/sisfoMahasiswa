<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNilai
    Inherits System.Windows.Forms.Form

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
        LabelTitle = New Label()
        LabelTA = New Label()
        CboTA = New ComboBox()
        LabelSem = New Label()
        CboSem = New ComboBox()
        PanelMhs = New Panel()
        LabelNim = New Label()
        txtNim = New TextBox()
        LabelNamaMhs = New Label()
        txtNamaMhs = New TextBox()
        BtnCariMhs = New Button()
        PanelDosen = New Panel()
        LabelNIDN = New Label()
        txtNIDN = New TextBox()
        LabelNamaDosen = New Label()
        txtNamaDosen = New TextBox()
        BtnCariDosen = New Button()
        PanelMtk = New Panel()
        LabelKdMtk = New Label()
        txtKdMtk = New TextBox()
        LabelNamaMtk = New Label()
        txtNamaMtk = New TextBox()
        LabelSKS = New Label()
        txtSKS = New TextBox()
        BtnCariMtk = New Button()
        PanelNilai = New Panel()
        LabelNilaiAkhir = New Label()
        txtNilaiAkhir = New TextBox()
        LabelNilaiHuruf = New Label()
        txtNilaiHuruf = New TextBox()
        LabelBobot = New Label()
        txtBobot = New TextBox()
        LabelJmlNilai = New Label()
        txtJmlNilai = New TextBox()
        LabelKet = New Label()
        txtKet = New TextBox()
        BtnProses = New Button()
        btnRefresh = New Button()
        btnSave = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnExit = New Button()
        txtCariData = New TextBox()
        btnCariData = New Button()
        ListView1 = New ListView()
        PanelMain.SuspendLayout()
        PanelMhs.SuspendLayout()
        PanelDosen.SuspendLayout()
        PanelMtk.SuspendLayout()
        PanelNilai.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        PanelMain.Controls.Add(LabelTitle)
        PanelMain.Controls.Add(LabelTA)
        PanelMain.Controls.Add(CboTA)
        PanelMain.Controls.Add(LabelSem)
        PanelMain.Controls.Add(CboSem)
        PanelMain.Controls.Add(PanelMhs)
        PanelMain.Controls.Add(PanelDosen)
        PanelMain.Controls.Add(PanelMtk)
        PanelMain.Controls.Add(PanelNilai)
        PanelMain.Controls.Add(btnRefresh)
        PanelMain.Controls.Add(btnSave)
        PanelMain.Controls.Add(btnEdit)
        PanelMain.Controls.Add(btnDelete)
        PanelMain.Controls.Add(btnExit)
        PanelMain.Controls.Add(txtCariData)
        PanelMain.Controls.Add(btnCariData)
        PanelMain.Controls.Add(ListView1)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1264, 681)
        PanelMain.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        LabelTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.RoyalBlue
        LabelTitle.Location = New Point(0, 0)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(1264, 27)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Form Input Data Nilai"
        LabelTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LabelTA
        ' 
        LabelTA.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTA.ForeColor = Color.White
        LabelTA.Location = New Point(60, 41)
        LabelTA.Name = "LabelTA"
        LabelTA.Size = New Size(110, 23)
        LabelTA.TabIndex = 1
        LabelTA.Text = "Tahun Akademik"
        LabelTA.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CboTA
        ' 
        CboTA.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        CboTA.DropDownStyle = ComboBoxStyle.DropDownList
        CboTA.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CboTA.ForeColor = Color.DimGray
        CboTA.Items.AddRange(New Object() {"2019/2020", "2020/2021", "2021/2022", "2022/2023", "2023/2024", "2024/2025"})
        CboTA.Location = New Point(180, 41)
        CboTA.Name = "CboTA"
        CboTA.Size = New Size(140, 22)
        CboTA.TabIndex = 2
        ' 
        ' LabelSem
        ' 
        LabelSem.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSem.ForeColor = Color.White
        LabelSem.Location = New Point(843, 41)
        LabelSem.Name = "LabelSem"
        LabelSem.Size = New Size(70, 23)
        LabelSem.TabIndex = 3
        LabelSem.Text = "Semester"
        LabelSem.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CboSem
        ' 
        CboSem.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        CboSem.DropDownStyle = ComboBoxStyle.DropDownList
        CboSem.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CboSem.ForeColor = Color.DimGray
        CboSem.Items.AddRange(New Object() {"Ganjil", "Genap"})
        CboSem.Location = New Point(923, 41)
        CboSem.Name = "CboSem"
        CboSem.Size = New Size(100, 22)
        CboSem.TabIndex = 4
        ' 
        ' PanelMhs
        ' 
        PanelMhs.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        PanelMhs.BorderStyle = BorderStyle.FixedSingle
        PanelMhs.Controls.Add(LabelNim)
        PanelMhs.Controls.Add(txtNim)
        PanelMhs.Controls.Add(LabelNamaMhs)
        PanelMhs.Controls.Add(txtNamaMhs)
        PanelMhs.Controls.Add(BtnCariMhs)
        PanelMhs.Location = New Point(60, 81)
        PanelMhs.Name = "PanelMhs"
        PanelMhs.Size = New Size(350, 130)
        PanelMhs.TabIndex = 5
        ' 
        ' LabelNim
        ' 
        LabelNim.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNim.ForeColor = Color.White
        LabelNim.Location = New Point(15, 20)
        LabelNim.Name = "LabelNim"
        LabelNim.Size = New Size(100, 23)
        LabelNim.TabIndex = 0
        LabelNim.Text = "NIM"
        LabelNim.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNim
        ' 
        txtNim.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNim.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNim.ForeColor = Color.DimGray
        txtNim.Location = New Point(120, 20)
        txtNim.Name = "txtNim"
        txtNim.ReadOnly = True
        txtNim.Size = New Size(130, 21)
        txtNim.TabIndex = 1
        ' 
        ' LabelNamaMhs
        ' 
        LabelNamaMhs.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNamaMhs.ForeColor = Color.White
        LabelNamaMhs.Location = New Point(15, 55)
        LabelNamaMhs.Name = "LabelNamaMhs"
        LabelNamaMhs.Size = New Size(100, 23)
        LabelNamaMhs.TabIndex = 2
        LabelNamaMhs.Text = "Nama Mahasiswa"
        LabelNamaMhs.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNamaMhs
        ' 
        txtNamaMhs.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNamaMhs.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaMhs.ForeColor = Color.DimGray
        txtNamaMhs.Location = New Point(120, 55)
        txtNamaMhs.Name = "txtNamaMhs"
        txtNamaMhs.ReadOnly = True
        txtNamaMhs.Size = New Size(200, 21)
        txtNamaMhs.TabIndex = 3
        ' 
        ' BtnCariMhs
        ' 
        BtnCariMhs.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        BtnCariMhs.FlatStyle = FlatStyle.System
        BtnCariMhs.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCariMhs.Location = New Point(120, 90)
        BtnCariMhs.Name = "BtnCariMhs"
        BtnCariMhs.Size = New Size(100, 26)
        BtnCariMhs.TabIndex = 4
        BtnCariMhs.Text = "Cari Data"
        BtnCariMhs.UseVisualStyleBackColor = False
        ' 
        ' PanelDosen
        ' 
        PanelDosen.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        PanelDosen.BorderStyle = BorderStyle.FixedSingle
        PanelDosen.Controls.Add(LabelNIDN)
        PanelDosen.Controls.Add(txtNIDN)
        PanelDosen.Controls.Add(LabelNamaDosen)
        PanelDosen.Controls.Add(txtNamaDosen)
        PanelDosen.Controls.Add(BtnCariDosen)
        PanelDosen.Location = New Point(843, 82)
        PanelDosen.Name = "PanelDosen"
        PanelDosen.Size = New Size(350, 130)
        PanelDosen.TabIndex = 6
        ' 
        ' LabelNIDN
        ' 
        LabelNIDN.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNIDN.ForeColor = Color.White
        LabelNIDN.Location = New Point(15, 20)
        LabelNIDN.Name = "LabelNIDN"
        LabelNIDN.Size = New Size(100, 23)
        LabelNIDN.TabIndex = 0
        LabelNIDN.Text = "NIDN"
        LabelNIDN.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNIDN
        ' 
        txtNIDN.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNIDN.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNIDN.ForeColor = Color.DimGray
        txtNIDN.Location = New Point(120, 20)
        txtNIDN.Name = "txtNIDN"
        txtNIDN.ReadOnly = True
        txtNIDN.Size = New Size(130, 21)
        txtNIDN.TabIndex = 1
        ' 
        ' LabelNamaDosen
        ' 
        LabelNamaDosen.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNamaDosen.ForeColor = Color.White
        LabelNamaDosen.Location = New Point(15, 55)
        LabelNamaDosen.Name = "LabelNamaDosen"
        LabelNamaDosen.Size = New Size(100, 23)
        LabelNamaDosen.TabIndex = 2
        LabelNamaDosen.Text = "Nama Dosen"
        LabelNamaDosen.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNamaDosen
        ' 
        txtNamaDosen.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNamaDosen.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaDosen.ForeColor = Color.DimGray
        txtNamaDosen.Location = New Point(120, 55)
        txtNamaDosen.Name = "txtNamaDosen"
        txtNamaDosen.ReadOnly = True
        txtNamaDosen.Size = New Size(200, 21)
        txtNamaDosen.TabIndex = 3
        ' 
        ' BtnCariDosen
        ' 
        BtnCariDosen.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        BtnCariDosen.FlatStyle = FlatStyle.System
        BtnCariDosen.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCariDosen.Location = New Point(120, 90)
        BtnCariDosen.Name = "BtnCariDosen"
        BtnCariDosen.Size = New Size(100, 26)
        BtnCariDosen.TabIndex = 4
        BtnCariDosen.Text = "Cari Data"
        BtnCariDosen.UseVisualStyleBackColor = False
        ' 
        ' PanelMtk
        ' 
        PanelMtk.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        PanelMtk.BorderStyle = BorderStyle.FixedSingle
        PanelMtk.Controls.Add(LabelKdMtk)
        PanelMtk.Controls.Add(txtKdMtk)
        PanelMtk.Controls.Add(LabelNamaMtk)
        PanelMtk.Controls.Add(txtNamaMtk)
        PanelMtk.Controls.Add(LabelSKS)
        PanelMtk.Controls.Add(txtSKS)
        PanelMtk.Controls.Add(BtnCariMtk)
        PanelMtk.Location = New Point(60, 231)
        PanelMtk.Name = "PanelMtk"
        PanelMtk.Size = New Size(350, 210)
        PanelMtk.TabIndex = 7
        ' 
        ' LabelKdMtk
        ' 
        LabelKdMtk.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelKdMtk.ForeColor = Color.White
        LabelKdMtk.Location = New Point(15, 20)
        LabelKdMtk.Name = "LabelKdMtk"
        LabelKdMtk.Size = New Size(100, 23)
        LabelKdMtk.TabIndex = 0
        LabelKdMtk.Text = "Kode MTK"
        LabelKdMtk.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtKdMtk
        ' 
        txtKdMtk.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtKdMtk.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtKdMtk.ForeColor = Color.DimGray
        txtKdMtk.Location = New Point(120, 20)
        txtKdMtk.Name = "txtKdMtk"
        txtKdMtk.ReadOnly = True
        txtKdMtk.Size = New Size(130, 21)
        txtKdMtk.TabIndex = 1
        ' 
        ' LabelNamaMtk
        ' 
        LabelNamaMtk.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNamaMtk.ForeColor = Color.White
        LabelNamaMtk.Location = New Point(15, 55)
        LabelNamaMtk.Name = "LabelNamaMtk"
        LabelNamaMtk.Size = New Size(100, 23)
        LabelNamaMtk.TabIndex = 2
        LabelNamaMtk.Text = "Nama MTK"
        LabelNamaMtk.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNamaMtk
        ' 
        txtNamaMtk.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNamaMtk.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaMtk.ForeColor = Color.DimGray
        txtNamaMtk.Location = New Point(120, 55)
        txtNamaMtk.Name = "txtNamaMtk"
        txtNamaMtk.ReadOnly = True
        txtNamaMtk.Size = New Size(200, 21)
        txtNamaMtk.TabIndex = 3
        ' 
        ' LabelSKS
        ' 
        LabelSKS.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSKS.ForeColor = Color.White
        LabelSKS.Location = New Point(15, 90)
        LabelSKS.Name = "LabelSKS"
        LabelSKS.Size = New Size(100, 23)
        LabelSKS.TabIndex = 4
        LabelSKS.Text = "SKS"
        LabelSKS.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtSKS
        ' 
        txtSKS.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtSKS.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSKS.ForeColor = Color.DimGray
        txtSKS.Location = New Point(120, 90)
        txtSKS.Name = "txtSKS"
        txtSKS.ReadOnly = True
        txtSKS.Size = New Size(60, 21)
        txtSKS.TabIndex = 5
        ' 
        ' BtnCariMtk
        ' 
        BtnCariMtk.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        BtnCariMtk.FlatStyle = FlatStyle.System
        BtnCariMtk.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCariMtk.Location = New Point(120, 125)
        BtnCariMtk.Name = "BtnCariMtk"
        BtnCariMtk.Size = New Size(100, 26)
        BtnCariMtk.TabIndex = 6
        BtnCariMtk.Text = "Cari Data"
        BtnCariMtk.UseVisualStyleBackColor = False
        ' 
        ' PanelNilai
        ' 
        PanelNilai.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        PanelNilai.BorderStyle = BorderStyle.FixedSingle
        PanelNilai.Controls.Add(LabelNilaiAkhir)
        PanelNilai.Controls.Add(txtNilaiAkhir)
        PanelNilai.Controls.Add(LabelNilaiHuruf)
        PanelNilai.Controls.Add(txtNilaiHuruf)
        PanelNilai.Controls.Add(LabelBobot)
        PanelNilai.Controls.Add(txtBobot)
        PanelNilai.Controls.Add(LabelJmlNilai)
        PanelNilai.Controls.Add(txtJmlNilai)
        PanelNilai.Controls.Add(LabelKet)
        PanelNilai.Controls.Add(txtKet)
        PanelNilai.Controls.Add(BtnProses)
        PanelNilai.Location = New Point(843, 232)
        PanelNilai.Name = "PanelNilai"
        PanelNilai.Size = New Size(350, 210)
        PanelNilai.TabIndex = 8
        ' 
        ' LabelNilaiAkhir
        ' 
        LabelNilaiAkhir.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNilaiAkhir.ForeColor = Color.White
        LabelNilaiAkhir.Location = New Point(15, 15)
        LabelNilaiAkhir.Name = "LabelNilaiAkhir"
        LabelNilaiAkhir.Size = New Size(100, 23)
        LabelNilaiAkhir.TabIndex = 0
        LabelNilaiAkhir.Text = "Nilai Akhir"
        LabelNilaiAkhir.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNilaiAkhir.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNilaiAkhir.ForeColor = Color.White
        txtNilaiAkhir.Location = New Point(120, 15)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(60, 21)
        txtNilaiAkhir.TabIndex = 1
        ' 
        ' LabelNilaiHuruf
        ' 
        LabelNilaiHuruf.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNilaiHuruf.ForeColor = Color.White
        LabelNilaiHuruf.Location = New Point(15, 45)
        LabelNilaiHuruf.Name = "LabelNilaiHuruf"
        LabelNilaiHuruf.Size = New Size(100, 23)
        LabelNilaiHuruf.TabIndex = 2
        LabelNilaiHuruf.Text = "Nilai Huruf"
        LabelNilaiHuruf.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNilaiHuruf
        ' 
        txtNilaiHuruf.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNilaiHuruf.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNilaiHuruf.ForeColor = Color.DimGray
        txtNilaiHuruf.Location = New Point(120, 45)
        txtNilaiHuruf.Name = "txtNilaiHuruf"
        txtNilaiHuruf.ReadOnly = True
        txtNilaiHuruf.Size = New Size(60, 21)
        txtNilaiHuruf.TabIndex = 3
        ' 
        ' LabelBobot
        ' 
        LabelBobot.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelBobot.ForeColor = Color.White
        LabelBobot.Location = New Point(15, 75)
        LabelBobot.Name = "LabelBobot"
        LabelBobot.Size = New Size(100, 23)
        LabelBobot.TabIndex = 4
        LabelBobot.Text = "Bobot"
        LabelBobot.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBobot
        ' 
        txtBobot.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtBobot.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBobot.ForeColor = Color.DimGray
        txtBobot.Location = New Point(120, 75)
        txtBobot.Name = "txtBobot"
        txtBobot.ReadOnly = True
        txtBobot.Size = New Size(60, 21)
        txtBobot.TabIndex = 5
        ' 
        ' LabelJmlNilai
        ' 
        LabelJmlNilai.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelJmlNilai.ForeColor = Color.White
        LabelJmlNilai.Location = New Point(15, 105)
        LabelJmlNilai.Name = "LabelJmlNilai"
        LabelJmlNilai.Size = New Size(100, 23)
        LabelJmlNilai.TabIndex = 6
        LabelJmlNilai.Text = "Jumlah Nilai"
        LabelJmlNilai.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtJmlNilai
        ' 
        txtJmlNilai.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtJmlNilai.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJmlNilai.ForeColor = Color.DimGray
        txtJmlNilai.Location = New Point(120, 105)
        txtJmlNilai.Name = "txtJmlNilai"
        txtJmlNilai.ReadOnly = True
        txtJmlNilai.Size = New Size(60, 21)
        txtJmlNilai.TabIndex = 7
        ' 
        ' LabelKet
        ' 
        LabelKet.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelKet.ForeColor = Color.White
        LabelKet.Location = New Point(15, 135)
        LabelKet.Name = "LabelKet"
        LabelKet.Size = New Size(100, 23)
        LabelKet.TabIndex = 8
        LabelKet.Text = "Keterangan"
        LabelKet.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtKet
        ' 
        txtKet.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtKet.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtKet.ForeColor = Color.DimGray
        txtKet.Location = New Point(120, 135)
        txtKet.Name = "txtKet"
        txtKet.ReadOnly = True
        txtKet.Size = New Size(200, 21)
        txtKet.TabIndex = 9
        ' 
        ' BtnProses
        ' 
        BtnProses.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        BtnProses.FlatStyle = FlatStyle.System
        BtnProses.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnProses.Location = New Point(120, 165)
        BtnProses.Name = "BtnProses"
        BtnProses.Size = New Size(100, 26)
        BtnProses.TabIndex = 10
        BtnProses.Text = "Proses"
        BtnProses.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnRefresh.FlatStyle = FlatStyle.Popup
        btnRefresh.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0), True)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Image = My.Resources.Resources.refresh
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(579, 324)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(110, 36)
        btnRefresh.TabIndex = 9
        btnRefresh.Text = "REFRESH"
        btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0), True)
        btnSave.ForeColor = Color.White
        btnSave.Image = My.Resources.Resources.save
        btnSave.Location = New Point(579, 81)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(110, 36)
        btnSave.TabIndex = 10
        btnSave.Text = "SAVE"
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0), True)
        btnEdit.ForeColor = Color.White
        btnEdit.Image = My.Resources.Resources.edit1
        btnEdit.Location = New Point(579, 162)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(110, 36)
        btnEdit.TabIndex = 11
        btnEdit.Text = "EDIT"
        btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0), True)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.Location = New Point(579, 243)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(110, 36)
        btnDelete.TabIndex = 12
        btnDelete.Text = "DELETE"
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0), True)
        btnExit.ForeColor = Color.White
        btnExit.Image = My.Resources.Resources._exit
        btnExit.Location = New Point(579, 405)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(110, 36)
        btnExit.TabIndex = 13
        btnExit.Text = "EXIT"
        btnExit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtCariData
        ' 
        txtCariData.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtCariData.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCariData.ForeColor = Color.White
        txtCariData.Location = New Point(60, 468)
        txtCariData.Name = "txtCariData"
        txtCariData.Size = New Size(272, 21)
        txtCariData.TabIndex = 15
        ' 
        ' btnCariData
        ' 
        btnCariData.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnCariData.FlatStyle = FlatStyle.Popup
        btnCariData.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0), True)
        btnCariData.ForeColor = Color.White
        btnCariData.Location = New Point(350, 466)
        btnCariData.Name = "btnCariData"
        btnCariData.Size = New Size(60, 23)
        btnCariData.TabIndex = 16
        btnCariData.Text = "Cari"
        btnCariData.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        ListView1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.ForeColor = Color.White
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(60, 515)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1133, 154)
        ListView1.TabIndex = 17
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' FormNilai
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        ClientSize = New Size(1264, 681)
        Controls.Add(PanelMain)
        Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "FormNilai"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Input Data Nilai"
        WindowState = FormWindowState.Maximized
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        PanelMhs.ResumeLayout(False)
        PanelMhs.PerformLayout()
        PanelDosen.ResumeLayout(False)
        PanelDosen.PerformLayout()
        PanelMtk.ResumeLayout(False)
        PanelMtk.PerformLayout()
        PanelNilai.ResumeLayout(False)
        PanelNilai.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelTA As Label
    Friend WithEvents CboTA As ComboBox
    Friend WithEvents LabelSem As Label
    Friend WithEvents CboSem As ComboBox
    Friend WithEvents PanelMhs As Panel
    Friend WithEvents LabelNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents LabelNamaMhs As Label
    Friend WithEvents txtNamaMhs As TextBox
    Friend WithEvents BtnCariMhs As Button
    Friend WithEvents PanelDosen As Panel
    Friend WithEvents LabelNIDN As Label
    Friend WithEvents txtNIDN As TextBox
    Friend WithEvents LabelNamaDosen As Label
    Friend WithEvents txtNamaDosen As TextBox
    Friend WithEvents BtnCariDosen As Button
    Friend WithEvents PanelMtk As Panel
    Friend WithEvents LabelKdMtk As Label
    Friend WithEvents txtKdMtk As TextBox
    Friend WithEvents LabelNamaMtk As Label
    Friend WithEvents txtNamaMtk As TextBox
    Friend WithEvents LabelSKS As Label
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents BtnCariMtk As Button
    Friend WithEvents PanelNilai As Panel
    Friend WithEvents LabelNilaiAkhir As Label
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents LabelNilaiHuruf As Label
    Friend WithEvents txtNilaiHuruf As TextBox
    Friend WithEvents LabelBobot As Label
    Friend WithEvents txtBobot As TextBox
    Friend WithEvents LabelJmlNilai As Label
    Friend WithEvents txtJmlNilai As TextBox
    Friend WithEvents LabelKet As Label
    Friend WithEvents txtKet As TextBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtCariData As TextBox
    Friend WithEvents btnCariData As Button
    Friend WithEvents ListView1 As ListView
End Class