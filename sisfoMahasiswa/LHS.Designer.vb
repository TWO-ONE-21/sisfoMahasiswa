<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LHS
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblNim = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CboNim = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblNama = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtNamaMhs = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnCetak = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBatal = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(32, 21)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(248, 27)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Cetak Lembar Hasil Studi"
        '
        'LblNim
        '
        Me.LblNim.BackColor = System.Drawing.Color.Transparent
        Me.LblNim.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNim.ForeColor = System.Drawing.Color.LightGray
        Me.LblNim.Location = New System.Drawing.Point(32, 79)
        Me.LblNim.Name = "LblNim"
        Me.LblNim.Size = New System.Drawing.Size(111, 19)
        Me.LblNim.TabIndex = 1
        Me.LblNim.Text = "Pilih NIM Mahasiswa"
        '
        'CboNim
        '
        Me.CboNim.BackColor = System.Drawing.Color.Transparent
        Me.CboNim.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CboNim.BorderRadius = 6
        Me.CboNim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboNim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNim.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CboNim.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboNim.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CboNim.ForeColor = System.Drawing.Color.White
        Me.CboNim.ItemHeight = 30
        Me.CboNim.Location = New System.Drawing.Point(32, 104)
        Me.CboNim.Name = "CboNim"
        Me.CboNim.Size = New System.Drawing.Size(356, 36)
        Me.CboNim.TabIndex = 2
        '
        'LblNama
        '
        Me.LblNama.BackColor = System.Drawing.Color.Transparent
        Me.LblNama.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LblNama.ForeColor = System.Drawing.Color.LightGray
        Me.LblNama.Location = New System.Drawing.Point(32, 158)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(104, 19)
        Me.LblNama.TabIndex = 3
        Me.LblNama.Text = "Nama Mahasiswa"
        '
        'txtNamaMhs
        '
        Me.txtNamaMhs.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtNamaMhs.BorderRadius = 6
        Me.txtNamaMhs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaMhs.DefaultText = ""
        Me.txtNamaMhs.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtNamaMhs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaMhs.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaMhs.ForeColor = System.Drawing.Color.White
        Me.txtNamaMhs.Location = New System.Drawing.Point(32, 183)
        Me.txtNamaMhs.Name = "txtNamaMhs"
        Me.txtNamaMhs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaMhs.PlaceholderText = ""
        Me.txtNamaMhs.ReadOnly = True
        Me.txtNamaMhs.SelectedText = ""
        Me.txtNamaMhs.Size = New System.Drawing.Size(356, 36)
        Me.txtNamaMhs.TabIndex = 4
        '
        'BtnCetak
        '
        Me.BtnCetak.BorderRadius = 8
        Me.BtnCetak.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCetak.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetak.ForeColor = System.Drawing.Color.White
        Me.BtnCetak.Location = New System.Drawing.Point(268, 252)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(120, 40)
        Me.BtnCetak.TabIndex = 5
        Me.BtnCetak.Text = "Cetak"
        '
        'BtnBatal
        '
        Me.BtnBatal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnBatal.BorderRadius = 8
        Me.BtnBatal.BorderThickness = 1
        Me.BtnBatal.FillColor = System.Drawing.Color.Transparent
        Me.BtnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnBatal.ForeColor = System.Drawing.Color.White
        Me.BtnBatal.Location = New System.Drawing.Point(142, 252)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(120, 40)
        Me.BtnBatal.TabIndex = 6
        Me.BtnBatal.Text = "Batal"
        '
        'LHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 320)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.txtNamaMhs)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.CboNim)
        Me.Controls.Add(Me.LblNim)
        Me.Controls.Add(Me.LblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "LHS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Filter Laporan Hasil Studi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblNim As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CboNim As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblNama As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtNamaMhs As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnCetak As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBatal As Guna.UI2.WinForms.Guna2Button
End Class