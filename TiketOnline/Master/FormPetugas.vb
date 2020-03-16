Imports MySql.Data.MySqlClient
Public Class FormPetugas
    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Call TampilPetugas()
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
        CboLevel.Text = ""

    End Sub


    Sub customGridView()

        Me.DataGridView1.Columns(0).HeaderText = "id"
        Me.DataGridView1.Columns(1).HeaderText = "Username"
        Me.DataGridView1.Columns(2).HeaderText = "Password"
        Me.DataGridView1.Columns(3).HeaderText = "Nama Petugas"
        Me.DataGridView1.Columns(4).HeaderText = "Level"
    End Sub

    Sub TampilPetugas()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM petugas", conn)
        ds = New DataSet
        da.Fill(ds, "petugas")
        DataGridView1.DataSource = ds.Tables("petugas")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TxtNama.Text = "" Or TxtUsername.Text = "" Or TxtPassword.Text = "" Or CboLevel.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else
            Try
                Call koneksi()
                str = "INSERT INTO petugas VALUES ('""', '" & TxtUsername.Text & "', md5('" & TxtPassword.Text & "'),'" & TxtNama.Text & "',LEFT('" & CboLevel.Text & "',1) )"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                enableButton()
                cleanTextBox()
                TampilPetugas()
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
        Me.CboLevel.Text = row.Cells(4).Value.ToString()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TxtNama.Text = "" Or TxtUsername.Text = "" Or TxtPassword.Text = "" Or CboLevel.Text = "" Then
            MessageBox.Show("Isi semua formnya")
        Else
            Try
                Call koneksi()
                cmd = New MySqlCommand("UPDATE petugas SET username ='" & TxtUsername.Text & "', password=md5('" & TxtPassword.Text & "'),
                                        nama_petugas='" & TxtNama.Text & "',id_level='" & CboLevel.Text & "' where id_petugas='" & TxtId.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil")
                enableButton()
                cleanTextBox()
                TampilPetugas()
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
            cmd = New MySqlCommand("DELETE FROM petugas where id_petugas = '" & TxtId.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil didelete")
            enableButton()
            cleanTextBox()
            TampilPetugas()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class