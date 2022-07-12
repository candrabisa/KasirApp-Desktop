Imports MySql.Data.MySqlClient
Public Class DataMenu

    Sub txtClear()
        tbHarga.Text = ""
        tbNamaMenu.Text = ""
        tbKodeMenu.Text = ""
        btnUpdate.Enabled = False
        btnTambah.Enabled = True
    End Sub
    Private Sub DataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Laporan.Show()
        Me.Close()
    End Sub

    Private Sub DataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem1.Click
        DataPengguna.Show()
        Me.Close()
    End Sub

    Private Sub DataPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        DataPegawai.Show()
        Me.Close()
    End Sub

    Private Sub DataMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_data_menu' table. You can move, or remove it, as needed.
        Me.Tbl_data_menuTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_menu)

        dr.Close()
        Call ambilKoneksi()
        cmd = New MySqlCommand("select * from tbl_user where username= '" & LoginForm.tbUsername.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblNip.Text = "NIP " & dr.Item("nip")
            lblRoles.Text = dr.Item("roles")
        End If
        dr.Close()
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tbKodeMenu.Text = "" Or
            tbNamaMenu.Text = "" Or
            tbHarga.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Information, "Informasi")
        Else
            dr.Close()
            Dim stringReturn As String
            Dim getKodeMenu As MySqlCommand = New MySqlCommand("select * from tbl_data_menu where kode_menu = '" & tbKodeMenu.Text & "'", conn)
            stringReturn = getKodeMenu.ExecuteScalar
            If stringReturn = tbKodeMenu.Text Then
                MsgBox("Data sudah ada!", MsgBoxStyle.Critical, "Error")
            Else
                cmd = New MySqlCommand("insert into tbl_data_menu values('" & tbKodeMenu.Text & "', '" & tbNamaMenu.Text & "',  '" & tbHarga.Text & "')", conn)
                Dim response = MsgBox("Apakah yakin ingin menyimpan data?", vbQuestion + vbYesNo, "Konfirmasi")
                If response = vbYes Then
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
                    Call txtClear()
                    Me.Tbl_data_menuTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_menu)
                    Me.dgvDataMenu.DataSource = Me.TbldatamenuBindingSource
                    Me.dgvDataMenu.Refresh()
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        dr.Close()
        cmd = New MySqlCommand("UPDATE tbl_data_menu set nama_menu= '" & tbNamaMenu.Text & "', harga= '" & tbHarga.Text & "' WHERE kode_menu LIKE'%" & tbKodeMenu.Text & "%'  ", conn)
        Dim response = MsgBox("Apakah yakin ingin mengupdate data?", vbQuestion + vbYesNo, "Konfirmasi")
        If response = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Informasi")
            Me.Tbl_data_menuTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_menu)
            Me.dgvDataMenu.DataSource = Me.TbldatamenuBindingSource
            Me.dgvDataMenu.Refresh()
            tbKodeMenu.Enabled = True
            Call txtClear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCariData_Click(sender As Object, e As EventArgs) Handles btnCariData.Click
        Call ambilKoneksi()
        dr.Close()
        cmd = New MySqlCommand("select * from tbl_data_menu where kode_menu like '%" & tbCaridata.Text & "%' ||  nama_menu like '%" & tbCaridata.Text & "%'  ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            adapter = New MySqlDataAdapter(cmd)
            ds = New DataSet
            adapter.Fill(ds, "ketemu")
            dgvDataMenu.DataSource = ds.Tables("ketemu")
            dgvDataMenu.ReadOnly = True
        Else
            MsgBox("Data tidak ditemukan", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub dgvDataMenu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataMenu.CellDoubleClick
        Dim post As Integer
        post = dgvDataMenu.CurrentRow.Index
        cmd = New MySqlCommand("Select * from tbl_data_menu where kode_menu='" & dgvDataMenu.Item(0, post).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            dr.Close()
        Else
            tbKodeMenu.Text = dr.Item("kode_menu")
            tbNamaMenu.Text = dr.Item("nama_menu")
            tbHarga.Text = dr.Item("harga")
            tbKodeMenu.Enabled = False
            btnUpdate.Enabled = True
            btnTambah.Enabled = False
        End If
        dr.Close()
    End Sub

    Private Sub dgvDataMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataMenu.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim response = MsgBox("Apakah yakin ingin menghapus data?", MsgBoxStyle.YesNo)
            If response = vbYes Then
                cmd = New MySqlCommand("delete from tbl_data_menu where kode_menu = '" & dgvDataMenu.Item(0, dgvDataMenu.CurrentRow.Index).Value & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
                Me.Tbl_data_menuTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_menu)
                Me.dgvDataMenu.DataSource = Me.Tbl_data_menuTableAdapter
                Me.dgvDataMenu.Refresh()
            Else
                Exit Sub
            End If
        End If
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
        Me.Close()
        LoginForm.Show()
    End Sub
End Class