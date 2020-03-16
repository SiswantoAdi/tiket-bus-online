Imports MySql.Data.MySqlClient
Public Class FormLevel
    Private Sub FormLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        enableButton()
        TampilLevel()
        customGridView()
        TxtId.Focus()
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
        TxtId.Enabled = True
        TxtId.Text = ""
        TxtLevel.Text = ""
    End Sub

    Sub customGridView()
        Me.DataGridView1.Columns(0).HeaderText = "Id"
        Me.DataGridView1.Columns(1).HeaderText = "Level"
    End Sub

    Sub TampilLevel()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM level", conn)
        ds = New DataSet
        da.Fill(ds, "level")
        DataGridView1.DataSource = ds.Tables("level")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TxtId.Text = "" Or TxtLevel.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else
            Try
                Call koneksi()
                str = "INSERT INTO level VALUES ('" & TxtId.Text & "', '" & TxtLevel.Text & "' )"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                enableButton()
                cleanTextBox()
                TampilLevel()
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        disableButton()
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Me.TxtId.Text = row.Cells(0).Value.ToString()
        Me.TxtLevel.Text = row.Cells(1).Value.ToString()
        TxtId.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TxtId.Text = "" Or TxtLevel.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else
            Try
                Call koneksi()
                cmd = New MySqlCommand("UPDATE level set nama_level ='" & TxtLevel.Text & "' where id_level='" & TxtId.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil")
                enableButton()
                cleanTextBox()
                TampilLevel()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Call koneksi()
            Dim pesan As Integer
            pesan = MsgBox("Apakah anda yakin akan menghapus Data pada server .. " + TxtId.Text, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub
            cmd = New MySqlCommand("DELETE FROM level where id_level = '" & TxtId.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil didelete")
            enableButton()
            cleanTextBox()
            TampilLevel()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class