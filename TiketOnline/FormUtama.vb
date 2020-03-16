Public Class FormUtama
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btnDtMaster_Click(sender As Object, e As EventArgs) Handles btnDtMaster.Click, btnDtMaster.Click
        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = False

        pnlDataMaster.Visible = True
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlTtgApk.Visible = False
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = False

        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = True
        pnlLaporan.Visible = False
        pnlTtgApk.Visible = False
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True
        Label5.Visible = False
        Label6.Visible = False
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = True
        pnlTtgApk.Visible = False
    End Sub



    Private Sub btnTtgApk_Click(sender As Object, e As EventArgs) Handles btnTtgApk.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = True
        Label6.Visible = False

        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlTtgApk.Visible = True
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = True

        Me.Close()
        FormLogin.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        pnlLeft.Visible = True
    End Sub

    Private Sub btnPenumpang_Click(sender As Object, e As EventArgs) Handles btnPenumpang.Click
        FormPenumpang.Show()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub btnPetugas_Click(sender As Object, e As EventArgs) Handles btnPetugas.Click
        FormPetugas.Show()
    End Sub

    Sub btnPanelDataMasterAktif()
        btnPenumpang.Enabled = True
        btnPetugas.Enabled = True
        btnTransportasi.Enabled = True
        btnRute.Enabled = True
        btnLevel.Enabled = True
    End Sub

    Sub btnPanelDataMasterNonAktif()
        btnPenumpang.Enabled = False
        btnPetugas.Enabled = False
        btnTransportasi.Enabled = False
        btnRute.Enabled = False
        btnLevel.Enabled = False
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnRute_Click(sender As Object, e As EventArgs) Handles btnRute.Click
        FormRute.Show()
    End Sub

    Private Sub btnTransportasi_Click(sender As Object, e As EventArgs) Handles btnTransportasi.Click
        FormTransportasi.Show()
    End Sub

    Private Sub btnLevel_Click(sender As Object, e As EventArgs) Handles btnLevel.Click
        FormLevel.Show()
    End Sub



    Private Sub btnDataTransaksi_Click(sender As Object, e As EventArgs) Handles btnDataTransaksi.Click
        FormDataTransaksi.Show()
    End Sub

    Private Sub TransaksiBus_Click(sender As Object, e As EventArgs) Handles TransaksiBus.Click
        FormTransaksi.Show()
        FormTransaksi.txtId.Text = txtId.Text
    End Sub

    Private Sub btnLpTiket_Click(sender As Object, e As EventArgs) Handles btnLpTiket.Click
        FormLaporanTransaksi.Show()
    End Sub
End Class