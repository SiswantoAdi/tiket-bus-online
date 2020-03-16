Imports MySql.Data.MySqlClient
Public Class FormRute
    Private Sub FormRute_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call TampilRute()
        Call customGridView()
        Call tampiTransportasiComboBox()
        enableButton()
        Call otomatis()
        TxtId.Enabled = False
    End Sub

    Sub tampiTransportasiComboBox()
        Try
            Call koneksi()

            cmd = New MySqlCommand("SELECT * FROM transportasi", conn)
            rd = cmd.ExecuteReader
            CboTrp.Items.Clear()
            Do While rd.Read
                CboTrp.Items.Add(rd.Item(0) & " | " & rd.Item(1) & " | " & rd.Item(2) & " | " & rd.Item(3))
            Loop
            cmd.Dispose()
            rd.Close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub otomatis()
        koneksi()
        cmd = New MySqlCommand("SELECT * FROM rute ORDER BY id_rute DESC", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            TxtId.Text = "R" + "0001"
        Else
            TxtId.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("id_rute").ToString, 4, 3)) + 1
            If Len(TxtId.Text) = 1 Then
                TxtId.Text = "R000" & TxtId.Text & ""
            ElseIf Len(TxtId.Text) = 2 Then
                TxtId.Text = "R00" & TxtId.Text & ""
            ElseIf Len(TxtId.Text) = 3 Then
                TxtId.Text = "R0" & TxtId.Text & ""
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
        TxtTujuan.Text = ""
        TxtRuteAwal.Text = ""
        TxtRuteAkhir.Text = ""
        TxtHarga.Text = ""
        CboTrp.Text = ""
    End Sub

    Sub customGridView()

        Me.DataGridView1.Columns(0).HeaderText = "id"
        Me.DataGridView1.Columns(1).HeaderText = "Tujuan"
        Me.DataGridView1.Columns(2).HeaderText = "Rute Awal"
        Me.DataGridView1.Columns(3).HeaderText = "Rute Akhir"
        Me.DataGridView1.Columns(4).HeaderText = "Harga"
        Me.DataGridView1.Columns(5).HeaderText = "Transportasi"
    End Sub

    Sub TampilRute()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT rute.id_rute,rute.tujuan,rute.rute_awal,rute.rute_akhir,rute.harga,transportasi.keterangan FROM rute JOIN transportasi ON rute.id_transportasi = transportasi.id_transportasi", conn)
        ds = New DataSet
        da.Fill(ds, "rute")
        DataGridView1.DataSource = ds.Tables("rute")

        DataGridView1.ReadOnly = True
        conn.Close()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TxtTujuan.Text = "" Or TxtRuteAwal.Text = "" Or TxtRuteAkhir.Text = "" Or TxtHarga.Text = "" Or CboTrp.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else
            Try
                Call koneksi()
                str = "INSERT INTO rute VALUES ('" & TxtId.Text & "', '" & TxtTujuan.Text & "', '" & TxtRuteAwal.Text & "','" & TxtRuteAkhir.Text & "',
                        '" & TxtHarga.Text & "',LEFT('" & CboTrp.Text & "',5) )"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                enableButton()
                cleanTextBox()
                TampilRute()
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
        Me.TxtTujuan.Text = row.Cells(1).Value.ToString()
        Me.TxtRuteAwal.Text = row.Cells(2).Value.ToString()
        Me.TxtRuteAkhir.Text = row.Cells(3).Value.ToString()
        Me.TxtHarga.Text = row.Cells(4).Value.ToString()
        Me.CboTrp.Text = row.Cells(5).Value.ToString()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TxtTujuan.Text = "" Or TxtRuteAwal.Text = "" Or TxtRuteAkhir.Text = "" Or TxtHarga.Text = "" Or CboTrp.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else
            Try
                Call koneksi()
                cmd = New MySqlCommand("UPDATE rute set  tujuan ='" & TxtTujuan.Text & "', rute_awal=('" & TxtRuteAwal.Text & "'),
                                        rute_akhir='" & TxtRuteAkhir.Text & "',harga='" & TxtHarga.Text & "',id_transportasi='" & CboTrp.Text & "'
                                        where id_petugas='" & TxtId.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil")
                enableButton()
                cleanTextBox()
                TampilRute()
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
            cmd = New MySqlCommand("DELETE FROM rute where id_rute = '" & TxtId.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil didelete")
            enableButton()
            cleanTextBox()
            TampilRute()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class