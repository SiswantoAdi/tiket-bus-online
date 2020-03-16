Imports MySql.Data.MySqlClient
Public Class FormPenumpang
    Private Sub FormPenumpang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Call TampilPenumpang()
        Call customGridView()
        Call tampiLevelComboBox()
        enableButton()
    End Sub
    Sub tampiLevelComboBox()
        Try
            Call koneksi()

            cmd = New MySqlCommand("SELECT * FROM level", conn)
            rd = cmd.ExecuteReader
            CboLevel.Items.Clear()
            Do While rd.Read
                CboLevel.Items.Add(rd.Item(0) & " | " & rd.Item(1))
            Loop
            cmd.Dispose()
            rd.Close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub enableButton()
        btnSave.Enabled = True
        btnDel.Enabled = False
        btnEdit.Enabled = False
        btnRefr.Enabled = True
    End Sub

    Private Sub disableButton()
        btnSave.Enabled = False
        btnDel.Enabled = True
        btnEdit.Enabled = True
        btnRefr.Enabled = True
    End Sub

    Private Sub cleanTextBox()
        TxtId.Text = ""
        TxtNama.Text = ""
        TxtPassword.Text = ""
        TxtUsername.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtNoTelp.Text = ""
        CboLevel.Text = ""
        CboGender.Text = ""
    End Sub


    Sub customGridView()

        Me.DataGridView1.Columns(0).HeaderText = "id"
        Me.DataGridView1.Columns(1).HeaderText = "Username"
        Me.DataGridView1.Columns(2).HeaderText = "Password"
        Me.DataGridView1.Columns(3).HeaderText = "Nama Penumpang"
        Me.DataGridView1.Columns(4).HeaderText = "Alamat"
        Me.DataGridView1.Columns(5).HeaderText = "Taanggal Lahir"
        Me.DataGridView1.Columns(6).HeaderText = "Gender"
        Me.DataGridView1.Columns(7).HeaderText = "No Telp"
        Me.DataGridView1.Columns(8).HeaderText = "level"
    End Sub

    Sub TampilPenumpang()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM penumpang", conn)
        ds = New DataSet
        da.Fill(ds, "penumpang")
        DataGridView1.DataSource = ds.Tables("penumpang")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TxtNama.Text = "" Or TxtPassword.Text = "" Or TxtUsername.Text = "" Or TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtNoTelp.Text = "" Or CboLevel.Text = "" Or CboGender.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else
            Try
                Call koneksi()
                str = "INSERT INTO penumpang VALUES ('""', '" & TxtUsername.Text & "', md5('" & TxtPassword.Text & "'),'" & TxtNama.Text & "',
                        '" & TxtAlamat.Text & "', '" & Format(TanggaLahir.Value, "yyyy-MM-dd") & "', '" & CboGender.Text & "', '" & TxtNoTelp.Text & "', LEFT('" & CboLevel.Text & "',1))"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                enableButton()
                cleanTextBox()
                TampilPenumpang()
                conn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        disableButton()
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Me.TxtId.Text = row.Cells(0).Value.ToString()
        Me.TxtUsername.Text = row.Cells(1).Value.ToString()
        Me.TxtNama.Text = row.Cells(3).Value.ToString()
        Me.TxtAlamat.Text = row.Cells(4).Value.ToString()
        Me.CboGender.Text = row.Cells(5).Value.ToString()
        Me.TxtNoTelp.Text = row.Cells(6).Value.ToString()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TxtNama.Text = "" Or TxtPassword.Text = "" Or TxtUsername.Text = "" Or TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtNoTelp.Text = "" Or CboLevel.Text = "" Or CboGender.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else
            Try
                Call koneksi()
                cmd = New MySqlCommand("UPDATE penumpang SET username = '" & TxtUsername.Text & "', password = md5('" & TxtPassword.Text & "'), nama_penumpang = '" & TxtNama.Text & "',
                        alamat_penumpang = '" & TxtAlamat.Text & "', tanggal_lahir = '" & Format(TanggaLahir.Value, "yyyy-MM-dd") & "', jenis_kelamin = '" & CboGender.Text & "', no_telp = '" & TxtNoTelp.Text & "'
                        , level = '" & CboLevel.Text & "' where id_penumpang = '" & TxtId.Text & "'")
                cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil")
                enableButton()
                cleanTextBox()
                TampilPenumpang()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRefr_Click(sender As Object, e As EventArgs) Handles btnRefr.Click
        cleanTextBox()
        enableButton()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Call koneksi()
            Dim pesan As Integer
            pesan = MsgBox("Apakah anda yakin akan menghapus Data pada server .. " + TxtId.Text, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub
            cmd = New MySqlCommand("DELETE FROM penumpang where id_penumpang = '" & TxtId.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil didelete")
            enableButton()
            cleanTextBox()
            TampilPenumpang()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class