<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRute
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRefr = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CboTrp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRuteAkhir = New System.Windows.Forms.TextBox()
        Me.TxtRuteAwal = New System.Windows.Forms.TextBox()
        Me.TxtTujuan = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(198, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Rute"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 32)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Bus Ticketing"
        '
        'btnRefr
        '
        Me.btnRefr.Location = New System.Drawing.Point(783, 254)
        Me.btnRefr.Name = "btnRefr"
        Me.btnRefr.Size = New System.Drawing.Size(80, 35)
        Me.btnRefr.TabIndex = 9
        Me.btnRefr.Text = "&Refresh"
        Me.btnRefr.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(186, 332)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 35)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "&Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(100, 332)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 35)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(14, 332)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 35)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CboTrp
        '
        Me.CboTrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTrp.FormattingEnabled = True
        Me.CboTrp.Items.AddRange(New Object() {"1", "2"})
        Me.CboTrp.Location = New System.Drawing.Point(633, 95)
        Me.CboTrp.Name = "CboTrp"
        Me.CboTrp.Size = New System.Drawing.Size(230, 24)
        Me.CboTrp.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Rute Akhir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Rute Awal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(490, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 28)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Transportasi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Tujuan"
        '
        'TxtRuteAkhir
        '
        Me.TxtRuteAkhir.Location = New System.Drawing.Point(177, 235)
        Me.TxtRuteAkhir.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtRuteAkhir.Multiline = True
        Me.TxtRuteAkhir.Name = "TxtRuteAkhir"
        Me.TxtRuteAkhir.Size = New System.Drawing.Size(383, 30)
        Me.TxtRuteAkhir.TabIndex = 3
        '
        'TxtRuteAwal
        '
        Me.TxtRuteAwal.Location = New System.Drawing.Point(177, 185)
        Me.TxtRuteAwal.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtRuteAwal.Multiline = True
        Me.TxtRuteAwal.Name = "TxtRuteAwal"
        Me.TxtRuteAwal.Size = New System.Drawing.Size(383, 30)
        Me.TxtRuteAwal.TabIndex = 2
        '
        'TxtTujuan
        '
        Me.TxtTujuan.Location = New System.Drawing.Point(177, 135)
        Me.TxtTujuan.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtTujuan.Multiline = True
        Me.TxtTujuan.Name = "TxtTujuan"
        Me.TxtTujuan.Size = New System.Drawing.Size(241, 30)
        Me.TxtTujuan.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 373)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(851, 193)
        Me.DataGridView1.TabIndex = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 49)
        Me.Panel1.TabIndex = 24
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(177, 284)
        Me.TxtHarga.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtHarga.Multiline = True
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(241, 30)
        Me.TxtHarga.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(14, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 28)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Harga"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(177, 91)
        Me.TxtId.Multiline = True
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(200, 31)
        Me.TxtId.TabIndex = 102
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(14, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 28)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "ID"
        '
        'FormRute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(875, 578)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRefr)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CboTrp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtRuteAkhir)
        Me.Controls.Add(Me.TxtRuteAwal)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.TxtTujuan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRute"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRefr As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents CboTrp As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRuteAkhir As TextBox
    Friend WithEvents TxtRuteAwal As TextBox
    Friend WithEvents TxtTujuan As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label8 As Label
End Class
