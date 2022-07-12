Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.Security.Cryptography
Public Class DataPengguna
    Sub txtClear()
        tbNip.Text = ""
        tbNama.Text = ""
        tbUsername.Text = ""
        tbPassword.Text = ""
        cbRoles.Text = ""
        btnUpdate.Enabled = False
        btnTambah.Enabled = True
    End Sub

    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted

        Catch ex As Exception

        End Try
    End Function

    Private Sub DataPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_user' table. You can move, or remove it, as needed.
        Me.Tbl_userTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_user)
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_user' table. You can move, or remove it, as needed.
        Me.Tbl_userTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_user)
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_user' table. You can move, or remove it, as needed.
        Me.Tbl_userTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_user)
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_user' table. You can move, or remove it, as needed.
        Me.Tbl_userTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_user)
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_user' table. You can move, or remove it, as needed.
        Me.Tbl_userTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_user)
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_user' table. You can move, or remove it, as needed.
        Me.Tbl_userTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_user)

        dr.Close()
        cmd = New MySqlCommand("select * from tbl_user where username= '" & LoginForm.tbUsername.Text & "' ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblNipDataPengguna.Text = "NIP " & dr.Item("nip")
            lblRolesDataPengguna.Text = dr.Item("roles")
        End If
        dr.Close()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tbNip.Text = "" Or
            tbNama.Text = "" Or
            tbUsername.Text = "" Or
            tbPassword.Text = "" Or
            cbRoles.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Information)
        Else
            dr.Close()
            Dim intReturn As Integer
            Dim getNip As MySqlCommand = New MySqlCommand("select * from tbl_user where nip = '" & tbNip.Text & "'", conn)
            intReturn = getNip.ExecuteScalar
            If intReturn > 0 Then
                MsgBox("Data sudah ada!", MsgBoxStyle.Critical, "Error")
            Else
                dr.Close()
                cmd = New MySqlCommand("insert into tbl_user values('" & tbNip.Text & "', '" & tbNama.Text & "', '" & tbUsername.Text & "', '" & AES_Encrypt(tbPassword.Text, tbPassword.Text) & "', '" & cbRoles.Text & "')", conn)
                Dim response = MsgBox("Apakah yakin ingin menyimpan data?", vbQuestion + vbYesNo, "Konfirmasi")
                If response = vbYes Then
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
                    Call txtClear()
                    Me.Tbl_userTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_user)
                    Me.dgvDataPengguna.DataSource = Me.TbluserBindingSource
                    Me.dgvDataPengguna.Refresh()
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub dgvDataPengguna_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataPengguna.CellDoubleClick
        Dim post As Integer
        post = dgvDataPengguna.CurrentRow.Index
        cmd = New MySqlCommand("Select * from tbl_user where nip='" & dgvDataPengguna.Item(0, post).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            dr.Close()
        Else
            tbNip.Text = dr.Item("nip")
            tbNama.Text = dr.Item("nama_pegawai")
            tbUsername.Text = dr.Item("username")
            tbPassword.Text = dr.Item("password")
            cbRoles.Text = dr.Item("roles")
            btnUpdate.Enabled = True
            btnTambah.Enabled = False
        End If
        dr.Close()
    End Sub

    Private Sub btnCariUser_Click(sender As Object, e As EventArgs) Handles btnCariUser.Click
        CariDataPegawai.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dr.Close()
        cmd = New MySqlCommand("select * from tbl_user where nip like '%" & tbFilterData.Text & "%' ||  nama_pegawai like '%" & tbFilterData.Text & "%'  ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            adapter = New MySqlDataAdapter(cmd)
            ds = New DataSet
            adapter.Fill(ds, "ketemu")
            dgvDataPengguna.DataSource = ds.Tables("ketemu")
            dgvDataPengguna.ReadOnly = True
        Else
            MsgBox("Data tidak ditemukan", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub dgvDataPengguna_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataPengguna.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim response = MsgBox("Apakah yakin ingin menghapus data?", MsgBoxStyle.YesNo)
            If response = vbYes Then
                cmd = New MySqlCommand("delete from tbl_user where nip = '" & dgvDataPengguna.Item(0, dgvDataPengguna.CurrentRow.Index).Value & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
                Me.Tbl_userTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_user)
                Me.dgvDataPengguna.DataSource = Me.TbluserBindingSource
                Me.dgvDataPengguna.Refresh()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        dr.Close()
        cmd = New MySqlCommand("UPDATE tbl_user set username= '" & tbUsername.Text & "', password= '" & AES_Encrypt(tbPassword.Text, tbPassword.Text) & "', roles= '" & cbRoles.Text & "' WHERE nip LIKE'%" & tbNip.Text & "%' ", conn)
        Dim response = MsgBox("Apakah yakin ingin mengupdate data?", vbQuestion + vbYesNo, "Konfirmasi")
        If response = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Informasi")
            Me.Tbl_userTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_user)
            Me.dgvDataPengguna.DataSource = Me.TbluserBindingSource
            Me.dgvDataPengguna.Refresh()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub DataPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        DataPegawai.Show()
        Me.Close
    End Sub

    Private Sub DataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMenuToolStripMenuItem.Click
        DataMenu.Show()
        Me.Close()
    End Sub

    Private Sub DataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Laporan.Show()
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
End Class