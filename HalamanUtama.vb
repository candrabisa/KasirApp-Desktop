Imports MySql.Data.MySqlClient
Public Class HalamanUtama
    Private Sub DataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataPenggunaToolStripMenuItem.Click
        DataPengguna.Show()
        Me.Hide()
    End Sub

    Private Sub HalamanUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ambilKoneksi()
        cmd = New MySqlCommand("select * from tbl_user where username= '" & LoginForm.tbUsername.Text & "' ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblNip.Text = "NIP " & dr.Item("nip")
            lblRoles.Text = dr.Item("roles")
            If dr.Item("roles") = "KASIR" Then
                LaporanToolStripMenuItem.Visible = False
                DataToolStripMenuItem.Visible = False
            End If
        End If
        dr.Close()
    End Sub

    Private Sub DataPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        DataPegawai.Show()
        Me.Hide()
    End Sub

    Private Sub DataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMenuToolStripMenuItem.Click
        DataMenu.Show()
        Me.Close()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        Transaksi.Show()
        Me.Close()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click

    End Sub
End Class