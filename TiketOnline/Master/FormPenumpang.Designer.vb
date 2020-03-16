<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenumpang
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
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.btnRefr = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CboGender = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TanggaLahir = New System.Windows.Forms.DateTimePicker()
        Me.TxtNoTelp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CboLevel = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
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
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Penumpang"
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
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(212, 80)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 22)
        Me.TxtId.TabIndex = 21
        Me.TxtId.Visible = False
        '
        'btnRefr
        '
        Me.btnRefr.Location = New System.Drawing.Point(896, 415)
        Me.btnRefr.Name = "btnRefr"
        Me.btnRefr.Size = New System.Drawing.Size(80, 35)
        Me.btnRefr.TabIndex = 12
        Me.btnRefr.Text = "&Refresh"
        Me.btnRefr.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(184, 415)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 35)
        Me.btnDel.TabIndex = 11
        Me.btnDel.Text = "&Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(98, 415)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 35)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 415)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 35)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CboGender
        '
        Me.CboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGender.FormattingEnabled = True
        Me.CboGender.Items.AddRange(New Object() {"L", "P"})
        Me.CboGender.Location = New System.Drawing.Point(790, 115)
        Me.CboGender.Name = "CboGender"
        Me.CboGender.Size = New System.Drawing.Size(77, 24)
        Me.CboGender.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nama "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(675, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 28)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Username"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(212, 214)
        Me.TxtNama.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtNama.Multiline = True
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(383, 30)
        Me.TxtNama.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(212, 164)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtPassword.Multiline = True
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(383, 30)
        Me.TxtPassword.TabIndex = 2
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(212, 115)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtUsername.Multiline = True
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(241, 30)
        Me.TxtUsername.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 456)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(964, 193)
        Me.DataGridView1.TabIndex = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 49)
        Me.Panel1.TabIndex = 24
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(212, 264)
        Me.TxtAlamat.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(383, 63)
        Me.TxtAlamat.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tanggal Lahir"
        '
        'TanggaLahir
        '
        Me.TanggaLahir.Location = New System.Drawing.Point(212, 352)
        Me.TanggaLahir.Name = "TanggaLahir"
        Me.TanggaLahir.Size = New System.Drawing.Size(200, 22)
        Me.TanggaLahir.TabIndex = 5
        '
        'TxtNoTelp
        '
        Me.TxtNoTelp.Location = New System.Drawing.Point(790, 164)
        Me.TxtNoTelp.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TxtNoTelp.Multiline = True
        Me.TxtNoTelp.Name = "TxtNoTelp"
        Me.TxtNoTelp.Size = New System.Drawing.Size(186, 30)
        Me.TxtNoTelp.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(675, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 28)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "No Telp"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(675, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 28)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Level"
        '
        'CboLevel
        '
        Me.CboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLevel.FormattingEnabled = True
        Me.CboLevel.Location = New System.Drawing.Point(790, 218)
        Me.CboLevel.Name = "CboLevel"
        Me.CboLevel.Size = New System.Drawing.Size(186, 24)
        Me.CboLevel.TabIndex = 8
        '
        'BackgroundWorker1
        '
        '
        'FormPenumpang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(988, 661)
        Me.Controls.Add(Me.TanggaLahir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.btnRefr)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CboLevel)
        Me.Controls.Add(Me.CboGender)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNoTelp)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormPenumpang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents btnRefr As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents CboGender As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TanggaLahir As DateTimePicker
    Friend WithEvents TxtNoTelp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CboLevel As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
