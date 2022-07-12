Imports MySql.Data.MySqlClient
Public Class CariDataMenu
    Private Sub CariDataMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_data_menu' table. You can move, or remove it, as needed.
        Me.Tbl_data_menuTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_data_menu)

    End Sub

    Private Sub dgvCariDataPegawai_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCariDataPegawai.CellDoubleClick
        Call ambilKoneksi()
        Dim post As Integer
        post = dgvCariDataPegawai.CurrentRow.Index
        cmd = New MySqlCommand("select * from tbl_data_menu where kode_menu = '" & dgvCariDataPegawai.Item(0, post).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            dr.Close()
        Else
            Transaksi.tbKodeMenu.Text = dr.Item("kode_menu")
            Transaksi.tbNamaMenu.Text = dr.Item("nama_menu")
            Transaksi.tbHarga.Text = dr.Item("harga")
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dr.Close()
        cmd = New MySqlCommand("select * from tbl_data_menu where kode_menu like '%" & tbInputNama.Text & "%' || nama_menu like '%" & tbInputNama.Text & "' ", conn)
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
End Class