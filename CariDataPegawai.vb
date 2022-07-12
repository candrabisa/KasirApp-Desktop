Imports MySql.Data.MySqlClient
Public Class CariDataPegawai
    Private Sub CariDataPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_data_pegawai' table. You can move, or remove it, as needed.
        Me.Tbl_data_pegawaiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_pegawai)

    End Sub

    Private Sub dgvCariDataPegawai_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCariDataPegawai.CellDoubleClick
        Call ambilKoneksi()
        Dim post As Integer
        post = dgvCariDataPegawai.CurrentRow.Index
        cmd = New MySqlCommand("select * from tbl_data_pegawai where nama_pegawai = '" & dgvCariDataPegawai.Item(1, post).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            dr.Close()
        Else
            DataPengguna.tbNip.Text = dr.Item("nip")
            DataPengguna.tbNama.Text = dr.Item("nama_pegawai")
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dr.Close()
        cmd = New MySqlCommand("select * from tbl_data_pegawai where nama_pegawai like '%" & tbInputNama.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            adapter = New MySqlDataAdapter(cmd)
            ds = New DataSet
            adapter.Fill(ds, "ketemu")
            dgvCariDataPegawai.DataSource = ds.Tables("ketemu")
            dgvCariDataPegawai.ReadOnly = True
        Else
            tbInputNama.Focus()
            MsgBox("Data tidak ditemukan", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub dgvCariDataPegawai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCariDataPegawai.CellContentClick

    End Sub
End Class