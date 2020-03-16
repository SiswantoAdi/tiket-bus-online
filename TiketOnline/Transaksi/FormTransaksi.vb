Imports MySql.Data.MySqlClient
Public Class FormTransaksi
    Dim hargaRute As Integer
    Dim hargaTransportasi As Integer
    Dim id_rute As Char
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilPelangganComboBox()
        tampilRuteComboBox()
        tampiTransportasiComboBox()
        otomatis()

    End Sub

    Sub otomatis()
        koneksi()
        cmd = New MySqlCommand("SELECT * FROM pemesanan ORDER BY kode_pemesanan DESC", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            TxtKdPemesanan.Text = "P" + "0001"
        Else
            TxtKdPemesanan.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("kode_pemesanan").ToString, 4, 3)) + 1
            If Len(TxtKdPemesanan.Text) = 1 Then
                TxtKdPemesanan.Text = "P000" & TxtKdPemesanan.Text & ""
            ElseIf Len(TxtKdPemesanan.Text) = 2 Then
                TxtKdPemesanan.Text = "P00" & TxtKdPemesanan.Text & ""
            ElseIf Len(TxtKdPemesanan.Text) = 3 Then
                TxtKdPemesanan.Text = "P0" & TxtKdPemesanan.Text & ""
            End If
        End If
        conn.Close()
    End Sub

    Sub tampilPelangganComboBox()

        koneksi()
            cmd = New MySqlCommand("SELECT * FROM penumpang", conn)
        rd = cmd.ExecuteReader
        cboPelanggan.Items.Clear()
        Do While rd.Read
            cboPelanggan.Items.Add(rd.Item(0) & " | " & rd.Item(1))
        Loop
        cmd.Dispose()
        rd.Close()
        conn.Close()

    End Sub

    Sub tampilRuteComboBox()

        koneksi()

        cmd = New MySqlCommand("SELECT * FROM rute", conn)
        rd = cmd.ExecuteReader
        cboRute.Items.Clear()
        Do While rd.Read
            cboRute.Items.Add(rd.Item(0) & " | " & rd.Item(1))
        Loop
        cmd.Dispose()
        rd.Close()
        conn.Close()

    End Sub

    Sub tampiTransportasiComboBox()

        koneksi()

        cmd = New MySqlCommand("SELECT * FROM transportasi", conn)
        rd = cmd.ExecuteReader
        cboTransportasi.Items.Clear()
        Do While rd.Read
            cboTransportasi.Items.Add(rd.Item(0) & " | " & rd.Item(3))
        Loop
        cmd.Dispose()
        rd.Close()
        conn.Close()
    End Sub

    Private Sub cboRute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRute.SelectedIndexChanged
        Call koneksi()

        cmd = New MySqlCommand("Select * from rute where id_rute='" & Microsoft.VisualBasic.Left(cboRute.Text, 5) & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TxtTujuan.Text = rd.Item("tujuan")
            hargaRute = rd.Item("harga")
        End If
        conn.Close()
    End Sub

    Private Sub cboTransportasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransportasi.SelectedIndexChanged
        Call koneksi()

        cmd = New MySqlCommand("Select * from transportasi where id_transportasi='" & Microsoft.VisualBasic.Left(cboTransportasi.Text, 5) & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            hargaTransportasi = rd.Item("harga")
        End If
        conn.Close()
    End Sub



    Sub cleanText()
        TxtKdPemesanan.Text = ""
        TxtTujuan.Text = ""
        TxtJmlTiket.Text = ""
        cboPelanggan.Text = ""
        cboRute.Text = ""
        cboTransportasi.Text = ""
        TxtJmlTiket.Text = ""
        TxtTotBayar.Text = 0

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TxtKdPemesanan.Text = "" Or cboPelanggan.Text = "" Or cboRute.Text = "" Or cboTransportasi.Text = "" Or TxtJmlTiket.Text = "" Then
            MessageBox.Show("Isi semua form terlebih dahulu", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        ElseIf TxtTotBayar.Text = 0 Then
            MessageBox.Show("Anda belum mentotalkan harga!", "Form Error", MessageBoxButtons.OK,
                MessageBoxIcon.Stop)
        Else

            Call koneksi()
            str = "INSERT INTO pemesanan VALUES ('""','" & TxtKdPemesanan.Text & "', '" & Format(dtpTglPesan.Value, "yyyy-MM-dd") & "','" & TxtTempatPesan.Text & "',LEFT('" & cboPelanggan.Text & "',1), Left('" & cboRute.Text & "',5)  ,LEFT('" & cboTransportasi.Text & "',5), '" & TxtTujuan.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(dtpCekin.Value, "yyyy-MM-dd HH:mm:ss") & "', '" & Format(dtpBerangkat.Value, "yyyy-MM-dd HH:mm:ss") & "', '" & TxtJmlTiket.Text & "','" & TxtTotBayar.Text & "', '" & txtId.Text & "')"
            cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                cleanText()
                conn.Close()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer
        total = hargaTransportasi + hargaRute
        TxtTotBayar.Text = Val(TxtJmlTiket.Text) * total
    End Sub
End Class