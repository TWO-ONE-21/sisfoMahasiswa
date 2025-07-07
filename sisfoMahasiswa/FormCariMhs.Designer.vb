<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariMhs
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
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.LabelCari = New System.Windows.Forms.Label()
        Me.txtCariData = New System.Windows.Forms.TextBox()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNim = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNama = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTempatLahir = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTglLahir = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderUsia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderJK = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAgama = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAlamat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTelp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(32, 33, 36)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Padding = New System.Windows.Forms.Padding(30)
        Me.PanelMain.Controls.Add(Me.LabelCari)
        Me.PanelMain.Controls.Add(Me.txtCariData)
        Me.PanelMain.Controls.Add(Me.btnCariData)
        Me.PanelMain.Controls.Add(Me.ListView1)
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(900, 400)
        Me.PanelMain.TabIndex = 0
        '
        'LabelCari
        '
        Me.LabelCari.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelCari.ForeColor = System.Drawing.Color.White
        Me.LabelCari.Location = New System.Drawing.Point(40, 35)
        Me.LabelCari.Name = "LabelCari"
        Me.LabelCari.Size = New System.Drawing.Size(80, 25)
        Me.LabelCari.TabIndex = 0
        Me.LabelCari.Text = "Pencarian"
        Me.LabelCari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCariData
        '
        Me.txtCariData.BackColor = System.Drawing.Color.FromArgb(55, 55, 60)
        Me.txtCariData.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCariData.ForeColor = System.Drawing.Color.White
        Me.txtCariData.Location = New System.Drawing.Point(130, 35)
        Me.txtCariData.Name = "txtCariData"
        Me.txtCariData.Size = New System.Drawing.Size(250, 25)
        Me.txtCariData.TabIndex = 1
        '
        'btnCariData
        '
        Me.btnCariData.BackColor = System.Drawing.Color.FromArgb(60, 63, 65)
        Me.btnCariData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariData.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCariData.ForeColor = System.Drawing.Color.White
        Me.btnCariData.Location = New System.Drawing.Point(390, 33)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(90, 28)
        Me.btnCariData.TabIndex = 2
        Me.btnCariData.Text = "Cari Data"
        Me.btnCariData.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(55, 55, 60)
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(40, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(820, 280)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {
            Me.ColumnHeaderNim,
            Me.ColumnHeaderNama,
            Me.ColumnHeaderTempatLahir,
            Me.ColumnHeaderTglLahir,
            Me.ColumnHeaderUsia,
            Me.ColumnHeaderJK,
            Me.ColumnHeaderAgama,
            Me.ColumnHeaderAlamat,
            Me.ColumnHeaderTelp
        })
        '
        'ColumnHeaderNim
        '
        Me.ColumnHeaderNim.Text = "NIM"
        Me.ColumnHeaderNim.Width = 100
        '
        'ColumnHeaderNama
        '
        Me.ColumnHeaderNama.Text = "Nama"
        Me.ColumnHeaderNama.Width = 150
        '
        'ColumnHeaderTempatLahir
        '
        Me.ColumnHeaderTempatLahir.Text = "Tempat Lahir"
        Me.ColumnHeaderTempatLahir.Width = 120
        '
        'ColumnHeaderTglLahir
        '
        Me.ColumnHeaderTglLahir.Text = "Tanggal Lahir"
        Me.ColumnHeaderTglLahir.Width = 110
        '
        'ColumnHeaderUsia
        '
        Me.ColumnHeaderUsia.Text = "Usia"
        Me.ColumnHeaderUsia.Width = 50
        '
        'ColumnHeaderJK
        '
        Me.ColumnHeaderJK.Text = "Jenis Kelamin"
        Me.ColumnHeaderJK.Width = 100
        '
        'ColumnHeaderAgama
        '
        Me.ColumnHeaderAgama.Text = "Agama"
        Me.ColumnHeaderAgama.Width = 90
        '
        'ColumnHeaderAlamat
        '
        Me.ColumnHeaderAlamat.Text = "Alamat"
        Me.ColumnHeaderAlamat.Width = 150
        '
        'ColumnHeaderTelp
        '
        Me.ColumnHeaderTelp.Text = "Telp/HP"
        Me.ColumnHeaderTelp.Width = 100
        '
        'FormCariMhs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(32, 33, 36)
        Me.ClientSize = New System.Drawing.Size(900, 400)
        Me.Controls.Add(Me.PanelMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FormCariMhs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Data Mahasiswa"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents LabelCari As Label
    Friend WithEvents txtCariData As TextBox
    Friend WithEvents btnCariData As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderNim As ColumnHeader
    Friend WithEvents ColumnHeaderNama As ColumnHeader
    Friend WithEvents ColumnHeaderTempatLahir As ColumnHeader
    Friend WithEvents ColumnHeaderTglLahir As ColumnHeader
    Friend WithEvents ColumnHeaderUsia As ColumnHeader
    Friend WithEvents ColumnHeaderJK As ColumnHeader
    Friend WithEvents ColumnHeaderAgama As ColumnHeader
    Friend WithEvents ColumnHeaderAlamat As ColumnHeader
    Friend WithEvents ColumnHeaderTelp As ColumnHeader
End Class
