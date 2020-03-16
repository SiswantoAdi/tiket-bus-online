<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtKdPemesanan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTglPesan = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTempatPesan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPelanggan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboRute = New System.Windows.Forms.ComboBox()
        Me.TxtTujuan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpCekin = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpBerangkat = New System.Windows.Forms.DateTimePicker()
        Me.TxtJmlTiket = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTotBayar = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboTransportasi = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(197, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 32)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Bus Ticketing"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 49)
        Me.Panel1.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 28)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Kode Pesan"
        '
        'TxtKdPemesanan
        '
        Me.TxtKdPemesanan.Enabled = False
        Me.TxtKdPemesanan.Location = New System.Drawing.Point(200, 76)
        Me.TxtKdPemesanan.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtKdPemesanan.Multiline = True
        Me.TxtKdPemesanan.Name = "TxtKdPemesanan"
        Me.TxtKdPemesanan.Size = New System.Drawing.Size(241, 30)
        Me.TxtKdPemesanan.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 28)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Tanggal Pesan"
        '
        'dtpTglPesan
        '
        Me.dtpTglPesan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglPesan.Location = New System.Drawing.Point(200, 131)
        Me.dtpTglPesan.Name = "dtpTglPesan"
        Me.dtpTglPesan.Size = New System.Drawing.Size(241, 22)
        Me.dtpTglPesan.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 28)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Tempat Pesan"
        '
        'TxtTempatPesan
        '
        Me.TxtTempatPesan.Enabled = False
        Me.TxtTempatPesan.Location = New System.Drawing.Point(200, 180)
        Me.TxtTempatPesan.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtTempatPesan.Multiline = True
        Me.TxtTempatPesan.Name = "TxtTempatPesan"
        Me.TxtTempatPesan.Size = New System.Drawing.Size(241, 30)
        Me.TxtTempatPesan.TabIndex = 30
        Me.TxtTempatPesan.Text = "Parungpanjang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 28)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Pelanggan"
        '
        'cboPelanggan
        '
        Me.cboPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPelanggan.FormattingEnabled = True
        Me.cboPelanggan.Location = New System.Drawing.Point(200, 236)
        Me.cboPelanggan.Name = "cboPelanggan"
        Me.cboPelanggan.Size = New System.Drawing.Size(241, 24)
        Me.cboPelanggan.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 28)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Rute"
        '
        'cboRute
        '
        Me.cboRute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRute.FormattingEnabled = True
        Me.cboRute.Location = New System.Drawing.Point(200, 287)
        Me.cboRute.Name = "cboRute"
        Me.cboRute.Size = New System.Drawing.Size(241, 24)
        Me.cboRute.TabIndex = 33
        '
        'TxtTujuan
        '
        Me.TxtTujuan.Enabled = False
        Me.TxtTujuan.Location = New System.Drawing.Point(200, 335)
        Me.TxtTujuan.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtTujuan.Multiline = True
        Me.TxtTujuan.Name = "TxtTujuan"
        Me.TxtTujuan.Size = New System.Drawing.Size(241, 30)
        Me.TxtTujuan.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 28)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Tujuan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(9, 382)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 28)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Tanggal Berangkat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(508, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 28)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Jam Cekin"
        '
        'dtpCekin
        '
        Me.dtpCekin.Checked = False
        Me.dtpCekin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCekin.Location = New System.Drawing.Point(699, 80)
        Me.dtpCekin.Name = "dtpCekin"
        Me.dtpCekin.ShowUpDown = True
        Me.dtpCekin.Size = New System.Drawing.Size(241, 22)
        Me.dtpCekin.TabIndex = 32
        Me.dtpCekin.Value = New Date(2019, 12, 12, 20, 2, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(508, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 28)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Jam Berangkat"
        '
        'dtpBerangkat
        '
        Me.dtpBerangkat.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpBerangkat.Location = New System.Drawing.Point(699, 130)
        Me.dtpBerangkat.Name = "dtpBerangkat"
        Me.dtpBerangkat.ShowUpDown = True
        Me.dtpBerangkat.Size = New System.Drawing.Size(241, 22)
        Me.dtpBerangkat.TabIndex = 32
        '
        'TxtJmlTiket
        '
        Me.TxtJmlTiket.Location = New System.Drawing.Point(699, 180)
        Me.TxtJmlTiket.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtJmlTiket.Multiline = True
        Me.TxtJmlTiket.Name = "TxtJmlTiket"
        Me.TxtJmlTiket.Size = New System.Drawing.Size(241, 30)
        Me.TxtJmlTiket.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(508, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 28)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Jumlah Tiket"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(508, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 28)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Total Bayar"
        '
        'TxtTotBayar
        '
        Me.TxtTotBayar.AutoSize = True
        Me.TxtTotBayar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotBayar.ForeColor = System.Drawing.Color.White
        Me.TxtTotBayar.Location = New System.Drawing.Point(694, 280)
        Me.TxtTotBayar.Name = "TxtTotBayar"
        Me.TxtTotBayar.Size = New System.Drawing.Size(24, 28)
        Me.TxtTotBayar.TabIndex = 31
        Me.TxtTotBayar.Text = "0"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(840, 318)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 44)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "Input"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(9, 427)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 28)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Transportasi"
        '
        'cboTransportasi
        '
        Me.cboTransportasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransportasi.FormattingEnabled = True
        Me.cboTransportasi.Location = New System.Drawing.Point(200, 434)
        Me.cboTransportasi.Name = "cboTransportasi"
        Me.cboTransportasi.Size = New System.Drawing.Size(241, 24)
        Me.cboTransportasi.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(699, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 44)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Totalkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.White
        Me.txtId.Location = New System.Drawing.Point(694, 388)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(0, 28)
        Me.txtId.TabIndex = 31
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(200, 388)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(241, 22)
        Me.DateTimePicker1.TabIndex = 36
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1108, 514)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboTransportasi)
        Me.Controls.Add(Me.cboRute)
        Me.Controls.Add(Me.cboPelanggan)
        Me.Controls.Add(Me.dtpBerangkat)
        Me.Controls.Add(Me.dtpCekin)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpTglPesan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.TxtTotBayar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtJmlTiket)
        Me.Controls.Add(Me.TxtTujuan)
        Me.Controls.Add(Me.TxtTempatPesan)
        Me.Controls.Add(Me.TxtKdPemesanan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtKdPemesanan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpTglPesan As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTempatPesan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboPelanggan As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboRute As ComboBox
    Friend WithEvents TxtTujuan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpCekin As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpBerangkat As DateTimePicker
    Friend WithEvents TxtJmlTiket As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtTotBayar As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cboTransportasi As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtId As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
