Imports MySql.Data.MySqlClient
Public Class FormTransportasi
    Private Sub FormTransportasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call TampilTransportasi()
        Call customGridView()
        enableButton()
        Call otomatis()
        TxtId.Enabled = False
    End Sub

    Sub otomatis()
        koneksi()
        cmd = New MySqlCommand("SELECT * FROM transportasi ORDER BY id_transportasi DESC", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            TxtId.Text = "T" + "0001"
        Else
            TxtId.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("id_transportasi").ToString, 4, 3)) + 1
            If Len(TxtId.Text) = 1 Then
                TxtId.Text = "T000" & TxtId.Text & ""
            ElseIf Len(TxtId.Text) = 2 Then
                TxtId.Text = "T00" & TxtId.Text & ""
            ElseIf Len(TxtId.Text) = 3 Then
                TxtId.Text = "T0" & TxtId.Text & ""
            End If
        End If
        conn.Close()
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
        TxtKode.Text = ""
        TxtJmlKursi.Text = ""
        TxtKeterangan.Text = ""

    End Sub

    Sub customGridView()

        Me.DataGridView1.Columns(0).HeaderText = "id"
        Me.DataGridView1.Columns(1).HeaderText = "Kode Bis"
        Me.DataGridView1.Columns(2).HeaderText = "Jumlah Kursi"
        Me.DataGridView1.Columns(3).HeaderText = "Nama Bis"

    End Sub

    Sub TampilTransportasi()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM transportasi", conn)
        ds = New DataSet
        da.Fill(ds, "transportasi")
        DataGridView1.DataSource = ds.Tables("transportasi")
        DataGridView1.ReadOnly = True
        conn.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TxtKode.Text = "" Or TxtJmlKursi.Text = "" Or TxtKeterangan.Text = "" Or txtHarga.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else
            Try
                Call koneksi()
                str = "INSERT INTO transportasi VALUES ('""', '" & TxtKode.Text & "', '" & TxtJmlKursi.Text & "','" & TxtKeterangan.Text & "','" & txtHarga.Text & "' )"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                enableButton()
                cleanTextBox()
                TampilTransportasi()
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
        Me.TxtKode.Text = row.Cells(1).Value.ToString()
        Me.TxtJmlKursi.Text = row.Cells(2).Value.ToString()
        Me.TxtKeterangan.Text = row.Cells(3).Value.ToString()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TxtKode.Text = "" Or TxtJmlKursi.Text = "" Or TxtKeterangan.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else
            Try
                Call koneksi()
                cmd = New MySqlCommand("UPDATE petugas SET kode ='" & TxtKode.Text & "', password='" & TxtJmlKursi.Text & "',
                                        keterangan='" & TxtKeterangan.Text & "', harga = '" & txtHarga.Text & "'
                                        where id_petugas='" & TxtId.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil")
                enableButton()
                cleanTextBox()
                TampilTransportasi()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRefr_Click(sender As Object, e As EventArgs) Handles btnRefr.Click
        cleanTextBox()
        enableButton()
        Call otomatis()
        TxtId.Enabled = False
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Call koneksi()
            Dim pesan As Integer
            pesan = MsgBox("Apakah anda yakin akan menghapus Data pada server .. " + TxtId.Text, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub
            cmd = New MySqlCommand("DELETE FROM transportasi where id_transportasi = '" & TxtId.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil didelete")
            enableButton()
            cleanTextBox()
            TampilTransportasi()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class