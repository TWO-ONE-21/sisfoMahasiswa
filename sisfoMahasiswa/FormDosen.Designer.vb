﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDosen
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
        LabelNidn = New Label()
        txtNidn = New TextBox()
        LabelNamaDosen = New Label()
        txtNamaDosen = New TextBox()
        LabelEmail = New Label()
        txtEmail = New TextBox()
        LabelTelp = New Label()
        txtTelp = New TextBox()
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
        ColumnHeader4 = New ColumnHeader()
        PanelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        PanelMain.Controls.Add(LabelTitle)
        PanelMain.Controls.Add(LabelNidn)
        PanelMain.Controls.Add(txtNidn)
        PanelMain.Controls.Add(LabelNamaDosen)
        PanelMain.Controls.Add(txtNamaDosen)
        PanelMain.Controls.Add(LabelEmail)
        PanelMain.Controls.Add(txtEmail)
        PanelMain.Controls.Add(LabelTelp)
        PanelMain.Controls.Add(txtTelp)
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
        PanelMain.Size = New Size(788, 701)
        PanelMain.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.RoyalBlue
        LabelTitle.Location = New Point(30, 20)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(315, 37)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Form Input Data Dosen"
        ' 
        ' LabelNidn
        ' 
        LabelNidn.Font = New Font("Segoe UI", 11F)
        LabelNidn.ForeColor = Color.White
        LabelNidn.Location = New Point(30, 90)
        LabelNidn.Name = "LabelNidn"
        LabelNidn.Size = New Size(120, 30)
        LabelNidn.TabIndex = 1
        LabelNidn.Text = "NIDN"
        LabelNidn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNidn
        ' 
        txtNidn.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNidn.Font = New Font("Segoe UI", 11F)
        txtNidn.ForeColor = Color.White
        txtNidn.Location = New Point(182, 90)
        txtNidn.Name = "txtNidn"
        txtNidn.Size = New Size(250, 27)
        txtNidn.TabIndex = 2
        ' 
        ' LabelNamaDosen
        ' 
        LabelNamaDosen.Font = New Font("Segoe UI", 11F)
        LabelNamaDosen.ForeColor = Color.White
        LabelNamaDosen.Location = New Point(30, 135)
        LabelNamaDosen.Name = "LabelNamaDosen"
        LabelNamaDosen.Size = New Size(146, 30)
        LabelNamaDosen.TabIndex = 3
        LabelNamaDosen.Text = "Nama Dosen"
        LabelNamaDosen.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNamaDosen
        ' 
        txtNamaDosen.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtNamaDosen.Font = New Font("Segoe UI", 11F)
        txtNamaDosen.ForeColor = Color.White
        txtNamaDosen.Location = New Point(182, 135)
        txtNamaDosen.Name = "txtNamaDosen"
        txtNamaDosen.Size = New Size(350, 27)
        txtNamaDosen.TabIndex = 4
        ' 
        ' LabelEmail
        ' 
        LabelEmail.Font = New Font("Segoe UI", 11F)
        LabelEmail.ForeColor = Color.White
        LabelEmail.Location = New Point(30, 180)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(120, 30)
        LabelEmail.TabIndex = 5
        LabelEmail.Text = "E-Mail"
        LabelEmail.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtEmail.Font = New Font("Segoe UI", 11F)
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(182, 180)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(350, 27)
        txtEmail.TabIndex = 6
        ' 
        ' LabelTelp
        ' 
        LabelTelp.Font = New Font("Segoe UI", 11F)
        LabelTelp.ForeColor = Color.White
        LabelTelp.Location = New Point(30, 225)
        LabelTelp.Name = "LabelTelp"
        LabelTelp.Size = New Size(136, 30)
        LabelTelp.TabIndex = 7
        LabelTelp.Text = "Telepon/HP"
        LabelTelp.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtTelp
        ' 
        txtTelp.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtTelp.Font = New Font("Segoe UI", 11F)
        txtTelp.ForeColor = Color.White
        txtTelp.Location = New Point(182, 225)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(250, 27)
        txtTelp.TabIndex = 8
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Image = My.Resources.Resources.save
        btnSave.Location = New Point(180, 280)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(110, 36)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Image = My.Resources.Resources.refresh
        btnRefresh.Location = New Point(538, 280)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(110, 36)
        btnRefresh.TabIndex = 10
        btnRefresh.Text = "Refresh"
        btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnEdit.ForeColor = Color.White
        btnEdit.Image = My.Resources.Resources.edit1
        btnEdit.Location = New Point(300, 280)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(110, 36)
        btnEdit.TabIndex = 11
        btnEdit.Text = "Edit"
        btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.Location = New Point(420, 280)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(110, 36)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnExit.ForeColor = Color.White
        btnExit.Image = My.Resources.Resources._exit
        btnExit.Location = New Point(658, 280)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(110, 36)
        btnExit.TabIndex = 13
        btnExit.Text = "Exit"
        btnExit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' LabelCari
        ' 
        LabelCari.Font = New Font("Segoe UI", 11F)
        LabelCari.ForeColor = Color.White
        LabelCari.Location = New Point(30, 340)
        LabelCari.Name = "LabelCari"
        LabelCari.Size = New Size(120, 30)
        LabelCari.TabIndex = 14
        LabelCari.Text = "Pencarian"
        LabelCari.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCari
        ' 
        txtCari.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtCari.Font = New Font("Segoe UI", 11F)
        txtCari.ForeColor = Color.White
        txtCari.Location = New Point(170, 340)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(350, 27)
        txtCari.TabIndex = 15
        ' 
        ' btnCari
        ' 
        btnCari.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnCari.FlatStyle = FlatStyle.Popup
        btnCari.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnCari.ForeColor = Color.White
        btnCari.Location = New Point(530, 338)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(100, 36)
        btnCari.TabIndex = 16
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ListView1.Font = New Font("Segoe UI", 11F)
        ListView1.ForeColor = Color.White
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(30, 400)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(724, 300)
        ListView1.TabIndex = 17
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "NIDN"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nama Dosen"
        ColumnHeader2.Width = 200
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "E-Mail"
        ColumnHeader3.Width = 200
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Telepon/HP"
        ColumnHeader4.Width = 120
        ' 
        ' FormDosen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        ClientSize = New Size(788, 701)
        Controls.Add(PanelMain)
        Font = New Font("Segoe UI", 11F)
        ForeColor = Color.White
        Name = "FormDosen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Input Data Dosen"
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelNidn As Label
    Friend WithEvents txtNidn As TextBox
    Friend WithEvents LabelNamaDosen As Label
    Friend WithEvents txtNamaDosen As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents LabelTelp As Label
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents LabelCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
