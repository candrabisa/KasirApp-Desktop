Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Data.DataTable
Public Class Transaksi
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim t_harga As Long
    Dim t_qty As Long
    Dim panjangKertas As Integer
    Dim table As New DataTable("Table")
    Dim btn As New DataGridViewButtonColumn
    Sub txtClear()
        tbKodeMenu.Text = ""
        tbNamaMenu.Text = ""
        tbHarga.Text = ""
        tbJumlah.Text = ""
        tbTotal.Text = ""

    End Sub
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_transaksi' table. You can move, or remove it, as needed.
        Me.Tbl_transaksiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_transaksi)
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_transaksi' table. You can move, or remove it, as needed.
        Me.Tbl_transaksiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_transaksi)
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_transaksi' table. You can move, or remove it, as needed.
        Me.Tbl_transaksiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_transaksi)

        dr.Close()
        Call ambilKoneksi()
        cmd = New MySqlCommand("select * from tbl_user where username= '" & LoginForm.tbUsername.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblNip.Text = dr.Item("nip")
            lblRoles.Text = dr.Item("roles")
            tbPegawai.Text = dr.Item("nama_pegawai")
            If dr.Item("roles") = "KASIR" Then
                LaporanToolStripMenuItem.Visible = False
                DataToolStripMenuItem.Visible = False
            End If
        End If
        dr.Close()
        Dim random As New Random
        tbTransaksi.Text = "TRX" & Convert.ToString(random.Next())

        btnCetak.Enabled = False
        btnSimpan.Enabled = False
    End Sub

    Private Sub DataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem1.Click
        DataPengguna.Show()
        Me.Close()
    End Sub

    Private Sub DataPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        DataPegawai.Show()
        Me.Close()
    End Sub

    Private Sub DataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMenuToolStripMenuItem.Click
        DataMenu.Show()
        Me.Close()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tbTransaksi.Text = "" Or
           tbKodeMenu.Text = "" Or
           tbNamaMenu.Text = "" Or
           tbHarga.Text = "" Or
           tbJumlah.Text = "" Or
           tbTotal.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Information)
        Else
            dgvCetakStruk.Rows.Add(tbTransaksi.Text, dtpTransaksi.Value, tbKodeMenu.Text, tbNamaMenu.Text, tbHarga.Text, tbJumlah.Text, tbTotal.Text, lblNip.Text, tbPegawai.Text)
            btnCetak.Enabled = True
            btnSimpan.Enabled = True
            txtClear()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CariDataMenu.Show()
    End Sub

    Private Sub tbJumlah_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        dr.Close()
        cmd = New MySqlCommand("UPDATE tbl_transaksi set id_transaksi= '" & tbTransaksi.Text & "', tgl_transaksi= '" & dtpTransaksi.Value & "', kode_menu= '" & tbKodeMenu.Text & "', nama_menu= '" & tbNamaMenu.Text & "', harga= '" & tbHarga.Text & "', jumlah= '" & tbJumlah.Text & "', total_harga= '" & tbTotal.Text & "', nip= '" & lblNip.Text & "', nama_pegawai= '" & tbPegawai.Text & "' WHERE id_transaksi LIKE'%" & tbTransaksi.Text & "%' ", conn)
        Dim response = MsgBox("Apakah yakin ingin mengupdate data?", vbQuestion + vbYesNo, "Konfirmasi")
        If response = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Informasi")
            Me.Tbl_transaksiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_transaksi)
            Me.dgvTransaksi.DataSource = Me.TbltransaksiBindingSource
            Me.dgvTransaksi.Refresh()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If tbJumlah.Text = "" Then
            MsgBox("Masukan jumlah dengan benar", MsgBoxStyle.Critical, "Error")
        ElseIf tbJumlah.Text = 0.ToString Then
            MsgBox("Jumlah tidak boleh 0", MsgBoxStyle.Critical, "Error")
        Else
            Dim total = tbHarga.Text * tbJumlah.Text
            tbTotal.Text = total.ToString
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        dr.Close()
        cmd = New MySqlCommand("select * from tbl_transaksi where id_transaksi like '%" & tbFilterData.Text & "%' ||  tgl_transaksi like '%" & tbFilterData.Text & "%'  ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            adapter = New MySqlDataAdapter(cmd)
            ds = New DataSet
            adapter.Fill(ds, "ketemu")
            dgvTransaksi.DataSource = ds.Tables("ketemu")
            dgvTransaksi.ReadOnly = True
        Else
            MsgBox("Data tidak ditemukan", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub dgvTransaksi_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellDoubleClick
        dr.Close()
        Dim post As Integer
        post = dgvTransaksi.CurrentRow.Index
        cmd = New MySqlCommand("Select * from tbl_transaksi where id_transaksi='" & dgvTransaksi.Item(0, post).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            dr.Close()
        Else
            tbTransaksi.Text = dr.Item("id_transaksi")
            dtpTransaksi.Value = dr.Item("tgl_transaksi")
            tbKodeMenu.Text = dr.Item("kode_menu")
            tbNamaMenu.Text = dr.Item("nama_menu")
            tbHarga.Text = dr.Item("harga")
            tbJumlah.Text = dr.Item("jumlah")
            tbTotal.Text = dr.Item("total_harga")
            tbPegawai.Text = dr.Item("nama_pegawai")

            btnCetak.Enabled = True
            btnTambah.Enabled = False
        End If
        dr.Close()
    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pageSetup As New PageSettings
        pageSetup.PaperSize = New PaperSize("Custom", 250, panjangKertas)
        PD.DefaultPageSettings = pageSetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftMargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centerMargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightMargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-------------------------------------------------------------"

        e.Graphics.DrawString("Soto Baba Elon", f14, Brushes.Black, centerMargin, 5, tengah)
        e.Graphics.DrawString("Cabang Bekasi", f10, Brushes.Black, centerMargin, 25, tengah)

        e.Graphics.DrawString(dgvCetakStruk.Rows(0).Cells(1).Value.ToString, f10, Brushes.Black, 0, 60)

        e.Graphics.DrawString("ID Transaksi", f10, Brushes.Black, 0, 80)
        e.Graphics.DrawString(":", f10, Brushes.Black, 75, 80)
        e.Graphics.DrawString(dgvCetakStruk.Rows(0).Cells(0).Value.ToString, f10, Brushes.Black, 80, 80)

        e.Graphics.DrawString("Kasir", f10, Brushes.Black, 0, 95)
        e.Graphics.DrawString(":", f10, Brushes.Black, 75, 95)
        e.Graphics.DrawString(dgvCetakStruk.Rows(0).Cells(8).Value.ToString, f10, Brushes.Black, 80, 95)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 105)

        dgvTransaksi.AllowUserToAddRows = False

        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To dgvCetakStruk.Rows.Count - 1
            tinggi += 12
            e.Graphics.DrawString(dgvCetakStruk.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 35, 110 + tinggi)
            e.Graphics.DrawString(dgvCetakStruk.Rows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 0, 110 + tinggi)

            i = dgvCetakStruk.Rows(baris).Cells(4).Value
            dgvCetakStruk.Rows(baris).Cells(4).Value = Format(i, "##,##0")
            e.Graphics.DrawString(dgvCetakStruk.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, rightMargin, 110 + tinggi, kanan)
        Next
        tinggi = 115 + tinggi
        hitungTotal()
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 10 + tinggi)
        e.Graphics.DrawString("Total : " & Format(t_harga, "##,##0"), f10b, Brushes.Black, rightMargin, 25 + tinggi, kanan)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 25 + tinggi)

        e.Graphics.DrawString("#Terima kasih telah mampir#", f10, Brushes.Black, centerMargin, 55 + tinggi, tengah)
    End Sub
    Sub hitungTotal()
        Dim hitung As Long = 0
        For baris As Long = 0 To dgvCetakStruk.Rows.Count - 1
            hitung = hitung + dgvTransaksi.Rows(baris).Cells(4).Value
        Next
        t_harga = hitung

        Dim hitung2 As Long = 0
        For baris As Long = 0 To dgvCetakStruk.Rows.Count - 1
            hitung2 = hitung2 + dgvCetakStruk.Rows(baris).Cells(5).Value
        Next
        t_qty = hitung2
    End Sub

    Sub ubahPanjangKertas()
        Dim rowCount As Integer
        panjangKertas = 0

        rowCount = dgvTransaksi.Rows.Count
        panjangKertas = rowCount * 5
        panjangKertas = panjangKertas + 80
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnCetak_Click_1(sender As Object, e As EventArgs) Handles btnCetak.Click
        ubahPanjangKertas()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim response = MsgBox("Apakah yakin ingin menyimpan data?", vbQuestion + vbYesNo, "Konfirmasi")
        If response = vbYes Then
            Dim id_transaksi, tgl_transaksi, kode_menu, nama_menu, harga, jumlah, total_harga, nip_pegawai, nama_pegawai As Object
            For x As Integer = 0 To dgvCetakStruk.Rows.Count - 1

                id_transaksi = dgvCetakStruk.Rows(x).Cells(0).Value
                tgl_transaksi = dgvCetakStruk.Rows(x).Cells(1).Value
                kode_menu = dgvCetakStruk.Rows(x).Cells(2).Value
                nama_menu = dgvCetakStruk.Rows(x).Cells(3).Value
                harga = dgvCetakStruk.Rows(x).Cells(4).Value
                jumlah = dgvCetakStruk.Rows(x).Cells(5).Value
                total_harga = dgvCetakStruk.Rows(x).Cells(6).Value
                nip_pegawai = dgvCetakStruk.Rows(x).Cells(7).Value
                nama_pegawai = dgvCetakStruk.Rows(x).Cells(8).Value

                cmd = New MySqlCommand("insert into tbl_transaksi (id_transaksi, tgl_transaksi, kode_menu, nama_menu, harga, jumlah, total_harga, nip, nama_pegawai) values('" & id_transaksi & "', '" & tgl_transaksi & "', '" & kode_menu & "', '" & nama_menu & "', '" & harga & "', '" & jumlah & "', '" & total_harga & "', '" & nip_pegawai & "', '" & nama_pegawai & "')", conn)
                dr.Close()
                cmd.ExecuteNonQuery()
            Next
            txtClear()
            tbTransaksi.Text = ""
            Me.Tbl_transaksiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_transaksi)
            Me.dgvTransaksi.DataSource = Me.TbltransaksiBindingSource
            Me.dgvTransaksi.Refresh()

            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")

            dgvCetakStruk.Rows.Clear()
            Me.dgvCetakStruk.Refresh()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub dgvCetakStruk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCetakStruk.CellContentClick
        If e.ColumnIndex = 9 Then
            Dim response = MsgBox("Apakah yakin ingin menghapus data?", MsgBoxStyle.YesNo)
            If response = vbYes Then
                cmd = New MySqlCommand("delete from tbl_transaksi where id_transaksi = '" & dgvTransaksi.Item(0, dgvTransaksi.CurrentRow.Index).Value & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
                Me.Tbl_transaksiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_transaksi)
                Me.dgvTransaksi.DataSource = Me.TbltransaksiBindingSource
                Me.dgvCetakStruk.Refresh()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dgvTransaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellContentClick
        If e.ColumnIndex = 9 Then
            Dim response = MsgBox("Apakah yakin ingin menghapus data?", MsgBoxStyle.YesNo)
            If response = vbYes Then
                dgvCetakStruk.Rows.RemoveAt(dgvCetakStruk.CurrentRow.Index)
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
                Me.dgvCetakStruk.Refresh()
            Else
                Exit Sub
            End If
        End If
    End Sub
End Class