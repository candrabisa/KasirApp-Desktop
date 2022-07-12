Imports MySql.Data.MySqlClient
Public Class DataPegawai

    Sub txtClear()
        tbNip.Text = ""
        tbNama.Text = ""
        tbAlamat.Text = ""
        tbNoHP.Text = ""
        cbJekel.Text = ""
        cbStatus.Text = ""
        btnUpdate.Enabled = False
        btnTambah.Enabled = True
    End Sub
    Private Sub DataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem1.Click
        DataPengguna.Show()
        Me.Close()
    End Sub

    Private Sub DataPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_data_pegawai' table. You can move, or remove it, as needed.
        Me.Tbl_data_pegawaiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_pegawai)

        dr.Close()
        Call ambilKoneksi()
        cmd = New MySqlCommand("select * from tbl_user where username= '" & LoginForm.tbUsername.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblNipDataPegawai.Text = "NIP " & dr.Item("nip")
            lblRolesDataPegawai.Text = dr.Item("roles")
        End If
        dr.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call ambilKoneksi()
        cmd = New MySqlCommand("select * from tbl_data_pegawai where nip in (select max(nip) from tbl_data_pegawai)", conn)
        Dim hitung As Integer
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            hitung = Microsoft.VisualBasic.Right(dr.GetInt32(0), 3) + 1
        End If
        tbNip.Text = hitung
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tbNip.Text = "" Or
           tbNama.Text = "" Or
           tbAlamat.Text = "" Or
           tbNoHP.Text = "" Or
           cbJekel.Text = "" Or
           cbStatus.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Information)
        Else
            dr.Close()
            cmd = New MySqlCommand("insert into tbl_data_pegawai values('" & tbNip.Text & "', '" & tbNama.Text & "', '" & dtpTglLahir.Text & "', '" & cbJekel.Text & "', '" & tbAlamat.Text & "', '" & cbStatus.Text & "', '" & tbNoHP.Text & "', '" & dtpTglJoin.Text & "')", conn)
            Dim response = MsgBox("Apakah yakin ingin menyimpan data?", vbQuestion + vbYesNo, "Konfirmasi")
            If response = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
                Call txtClear()
                Me.Tbl_data_pegawaiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_pegawai)
                Me.dgvDataPegawai.DataSource = Me.TbldatapegawaiBindingSource
                Me.dgvDataPegawai.Refresh()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dgvDataPegawai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataPegawai.CellContentClick
        If e.ColumnIndex = 8 Then
            Dim response = MsgBox("Apakah yakin ingin menghapus data?", MsgBoxStyle.YesNo)
            If response = vbYes Then
                cmd = New MySqlCommand("delete from tbl_user where nip = '" & dgvDataPegawai.Item(0, dgvDataPegawai.CurrentRow.Index).Value & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
                Me.Tbl_data_pegawaiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_pegawai)
                Me.dgvDataPegawai.DataSource = Me.TbldatapegawaiBindingSource
                Me.dgvDataPegawai.Refresh()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dgvDataPegawai_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataPegawai.CellDoubleClick
        Dim post As Integer
        Call ambilKoneksi()
        post = dgvDataPegawai.CurrentRow.Index
        cmd = New MySqlCommand("Select * from tbl_data_pegawai where nip='" & dgvDataPegawai.Item(0, post).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            dr.Close()
        Else
            tbNip.Text = dr.Item("nip")
            tbNama.Text = dr.Item("nama_pegawai")
            tbAlamat.Text = dr.Item("alamat")
            tbNoHP.Text = dr.Item("no_hp")
            cbJekel.Text = dr.Item("jenis_kelamin")
            cbStatus.Text = dr.Item("status")
            dtpTglLahir.Value = dr.Item("tgl_lahir")
            dtpTglJoin.Value = dr.Item("tgl_join")
            btnUpdate.Enabled = True
            btnTambah.Enabled = False
        End If
        dr.Close()
    End Sub

    Private Sub tbNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNoHP.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        dr.Close()
        cmd = New MySqlCommand("UPDATE tbl_data_pegawai set nama_pegawai= '" & tbNama.Text & "', alamat= '" & tbAlamat.Text & "', jenis_kelamin= '" & cbJekel.Text & "', status= '" & cbStatus.Text & "', no_hp= '" & tbNoHP.Text & "', tgl_lahir= '" & dtpTglLahir.Text & "', tgl_join= '" & dtpTglJoin.Text & "' WHERE nip LIKE'%" & tbNip.Text & "%' ", conn)
        Dim response = MsgBox("Apakah yakin ingin mengupdate data?", vbQuestion + vbYesNo, "Konfirmasi")
        If response = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Informasi")
            Me.Tbl_data_pegawaiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_pegawai)
            Me.dgvDataPegawai.DataSource = Me.TbldatapegawaiBindingSource
            Me.dgvDataPegawai.Refresh()
            Call txtClear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub DataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Laporan.Show()
        Me.Close()
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
End Class