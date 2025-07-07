<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariMTK
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
        LabelCari = New Label()
        txtCariData = New TextBox()
        btnCariData = New Button()
        ListView1 = New ListView()
        ColumnHeaderKode = New ColumnHeader()
        ColumnHeaderNama = New ColumnHeader()
        ColumnHeaderSKS = New ColumnHeader()
        PanelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        PanelMain.Controls.Add(LabelCari)
        PanelMain.Controls.Add(txtCariData)
        PanelMain.Controls.Add(btnCariData)
        PanelMain.Controls.Add(ListView1)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Padding = New Padding(30)
        PanelMain.Size = New Size(900, 400)
        PanelMain.TabIndex = 0
        ' 
        ' LabelCari
        ' 
        LabelCari.Font = New Font("Segoe UI", 10.0F)
        LabelCari.ForeColor = Color.White
        LabelCari.Location = New Point(40, 35)
        LabelCari.Name = "LabelCari"
        LabelCari.Size = New Size(80, 25)
        LabelCari.TabIndex = 0
        LabelCari.Text = "Pencarian"
        LabelCari.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCariData
        ' 
        txtCariData.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        txtCariData.Font = New Font("Segoe UI", 10.0F)
        txtCariData.ForeColor = Color.White
        txtCariData.Location = New Point(130, 35)
        txtCariData.Name = "txtCariData"
        txtCariData.Size = New Size(250, 25)
        txtCariData.TabIndex = 1
        ' 
        ' btnCariData
        ' 
        btnCariData.BackColor = Color.FromArgb(CByte(60), CByte(63), CByte(65))
        btnCariData.FlatStyle = FlatStyle.Flat
        btnCariData.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCariData.ForeColor = Color.White
        btnCariData.Location = New Point(390, 33)
        btnCariData.Name = "btnCariData"
        btnCariData.Size = New Size(90, 28)
        btnCariData.TabIndex = 2
        btnCariData.Text = "Cari Data"
        btnCariData.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(60))
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeaderKode, ColumnHeaderNama, ColumnHeaderSKS})
        ListView1.Font = New Font("Segoe UI", 10.0F)
        ListView1.ForeColor = Color.White
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(40, 80)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(820, 280)
        ListView1.TabIndex = 3
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeaderKode
        ' 
        ColumnHeaderKode.Text = "Kode Mata Kuliah"
        ColumnHeaderKode.Width = 180
        ' 
        ' ColumnHeaderNama
        ' 
        ColumnHeaderNama.Text = "Nama Mata Kuliah"
        ColumnHeaderNama.Width = 400
        ' 
        ' ColumnHeaderSKS
        ' 
        ColumnHeaderSKS.Text = "SKS"
        ColumnHeaderSKS.Width = 100
        ' 
        ' FormCariMTK
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(36))
        ClientSize = New Size(900, 400)
        Controls.Add(PanelMain)
        Font = New Font("Segoe UI", 10.0F)
        ForeColor = Color.White
        Name = "FormCariMTK"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cari Data Matakuliah"
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents LabelCari As Label
    Friend WithEvents txtCariData As TextBox
    Friend WithEvents btnCariData As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderKode As ColumnHeader
    Friend WithEvents ColumnHeaderNama As ColumnHeader
    Friend WithEvents ColumnHeaderSKS As ColumnHeader
End Class
