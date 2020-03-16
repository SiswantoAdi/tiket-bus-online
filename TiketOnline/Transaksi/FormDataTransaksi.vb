Imports MySql.Data.MySqlClient
Public Class FormDataTransaksi
    Dim id As Char
    Private Sub FormDataTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilTransaksi()
    End Sub

    Sub TampilTransaksi()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM pemesanan", conn)
        ds = New DataSet
        da.Fill(ds, "pemesanan")
        DataGridView1.DataSource = ds.Tables("pemesanan")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Call koneksi()
            If id = "" Then
                MessageBox.Show("Anda belum memilih data untuk dihapus!", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
            Else
                Dim pesan As Integer
                pesan = MsgBox("Apakah anda yakin akan menghapus Data pada server .. " + id, vbExclamation + vbYesNo, "Perhatian")
                If pesan = vbNo Then Exit Sub
                cmd = New MySqlCommand("DELETE FROM pemesanan where id_pemesanan = '" & id & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil didelete")
                TampilTransaksi()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow


        id = row.Cells(0).Value.ToString()
    End Sub
End Class