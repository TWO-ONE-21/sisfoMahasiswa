<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMataKuliah
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PanelMain = New Panel()
        LabelTitle = New Label()
        LabelKdMtk = New Label()
        txtKdMtk = New TextBox()
        LabelNamaMtk = New Label()
        txtNamaMtk = New TextBox()
        LabelSKS = New Label()
        txtSKS = New TextBox()
        btnSave = New Button()
        btnRefresh = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnExit = New Button()
        LabelCari = New Label()
        txtCari = New TextBox()
        btnCari = New Button()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        PanelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        PanelMain.Controls.Add(LabelTitle)
        PanelMain.Controls.Add(LabelKdMtk)
        PanelMain.Controls.Add(txtKdMtk)
        PanelMain.Controls.Add(LabelNamaMtk)
        PanelMain.Controls.Add(txtNamaMtk)
        PanelMain.Controls.Add(LabelSKS)
        PanelMain.Controls.Add(txtSKS)
        PanelMain.Controls.Add(btnSave)
        PanelMain.Controls.Add(btnRefresh)
        PanelMain.Controls.Add(btnEdit)
        PanelMain.Controls.Add(btnDelete)
        PanelMain.Controls.Add(btnExit)
        PanelMain.Controls.Add(LabelCari)
        PanelMain.Controls.Add(txtCari)
        PanelMain.Controls.Add(btnCari)
        PanelMain.Controls.Add(ListView1)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Padding = New Padding(30)
        PanelMain.Size = New Size(1200, 600)
        PanelMain.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.RoyalBlue
        LabelTitle.Location = New Point(30, 20)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(263, 25)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Form Input Data Matakuliah"
        ' 
        ' LabelKdMtk
        ' 
        LabelKdMtk.Font = New Font("Segoe UI", 11.0F)
        LabelKdMtk.ForeColor = Color.White
        LabelKdMtk.Location = New Point(30, 80)
        LabelKdMtk.Name = "LabelKdMtk"
        LabelKdMtk.Size = New Size(120, 30)
        LabelKdMtk.TabIndex = 1
        LabelKdMtk.Text = "Kode MTK"
        LabelKdMtk.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtKdMtk
        ' 
        txtKdMtk.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtKdMtk.Font = New Font("Segoe UI", 11.0F)
        txtKdMtk.ForeColor = Color.White
        txtKdMtk.Location = New Point(170, 80)
        txtKdMtk.Name = "txtKdMtk"
        txtKdMtk.PlaceholderText = "Masukkan Kode Mata Kuliah"
        txtKdMtk.Size = New Size(200, 27)
        txtKdMtk.TabIndex = 2
        ' 
        ' LabelNamaMtk
        ' 
        LabelNamaMtk.Font = New Font("Segoe UI", 11.0F)
        LabelNamaMtk.ForeColor = Color.White
        LabelNamaMtk.Location = New Point(30, 125)
        LabelNamaMtk.Name = "LabelNamaMtk"
        LabelNamaMtk.Size = New Size(120, 30)
        LabelNamaMtk.TabIndex = 3
        LabelNamaMtk.Text = "Nama MTK"
        LabelNamaMtk.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNamaMtk
        ' 
        txtNamaMtk.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNamaMtk.Font = New Font("Segoe UI", 11.0F)
        txtNamaMtk.ForeColor = Color.White
        txtNamaMtk.Location = New Point(170, 125)
        txtNamaMtk.Name = "txtNamaMtk"
        txtNamaMtk.PlaceholderText = "Masukkan Nama Mata Kuliah"
        txtNamaMtk.Size = New Size(350, 27)
        txtNamaMtk.TabIndex = 4
        ' 
        ' LabelSKS
        ' 
        LabelSKS.Font = New Font("Segoe UI", 11.0F)
        LabelSKS.ForeColor = Color.White
        LabelSKS.Location = New Point(30, 170)
        LabelSKS.Name = "LabelSKS"
        LabelSKS.Size = New Size(120, 30)
        LabelSKS.TabIndex = 5
        LabelSKS.Text = "SKS"
        LabelSKS.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtSKS
        ' 
        txtSKS.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtSKS.Font = New Font("Segoe UI", 11.0F)
        txtSKS.ForeColor = Color.White
        txtSKS.Location = New Point(170, 170)
        txtSKS.Name = "txtSKS"
        txtSKS.PlaceholderText = "SKS"
        txtSKS.Size = New Size(80, 27)
        txtSKS.TabIndex = 6
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Image = My.Resources.Resources.save
        btnSave.Location = New Point(170, 220)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(97, 36)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Image = My.Resources.Resources.refresh
        btnRefresh.Location = New Point(485, 220)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(97, 36)
        btnRefresh.TabIndex = 8
        btnRefresh.Text = "Refresh"
        btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnEdit.ForeColor = Color.White
        btnEdit.Image = My.Resources.Resources.edit1
        btnEdit.Location = New Point(275, 220)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(97, 36)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.Location = New Point(380, 220)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(97, 36)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnExit.ForeColor = Color.White
        btnExit.Image = My.Resources.Resources._exit
        btnExit.Location = New Point(590, 220)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(97, 36)
        btnExit.TabIndex = 11
        btnExit.Text = "Exit"
        btnExit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' LabelCari
        ' 
        LabelCari.Font = New Font("Segoe UI", 11.0F)
        LabelCari.ForeColor = Color.White
        LabelCari.Location = New Point(30, 280)
        LabelCari.Name = "LabelCari"
        LabelCari.Size = New Size(100, 30)
        LabelCari.TabIndex = 12
        LabelCari.Text = "Pencarian"
        LabelCari.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCari
        ' 
        txtCari.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtCari.Font = New Font("Segoe UI", 11.0F)
        txtCari.ForeColor = Color.White
        txtCari.Location = New Point(170, 280)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(350, 27)
        txtCari.TabIndex = 13
        ' 
        ' btnCari
        ' 
        btnCari.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnCari.FlatStyle = FlatStyle.Flat
        btnCari.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnCari.ForeColor = Color.White
        btnCari.Location = New Point(530, 278)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(100, 36)
        btnCari.TabIndex = 14
        btnCari.Text = "Cari Data"
        btnCari.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        ListView1.Font = New Font("Segoe UI", 11.0F)
        ListView1.ForeColor = Color.White
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(30, 340)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(630, 220)
        ListView1.TabIndex = 15
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Kode Mata Kuliah"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nama Mata Kuliah"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 400
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "SKS"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 80
        ' 
        ' FormMataKuliah
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        ClientSize = New Size(1200, 600)
        Controls.Add(PanelMain)
        Font = New Font("Segoe UI", 11.0F)
        ForeColor = Color.White
        Name = "FormMataKuliah"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Input Data Matakuliah"
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelKdMtk As Label
    Friend WithEvents txtKdMtk As TextBox
    Friend WithEvents LabelNamaMtk As Label
    Friend WithEvents txtNamaMtk As TextBox
    Friend WithEvents LabelSKS As Label
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents LabelCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnEdit As Button
End Class
