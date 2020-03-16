Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Call koneksi()
            Dim str As String
            str = "select * from petugas where username = '" & txtUser.Text & "' and password = md5('" & txtPass.Text & "')"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                FormUtama.Show()
                FormUtama.txtId.Text = rd.Item("id_petugas")
                FormUtama.Label8.Text = txtUser.Text
                Me.Hide()
            Else
                rd.Close()
                MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPass.Text = ""
                txtUser.Text = ""
                txtUser.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
