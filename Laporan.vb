Imports MySql.Data.MySqlClient
Public Class Laporan
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub DataMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sotobabaelonDataSet.tbl_transaksi' table. You can move, or remove it, as needed.
        Me.Tbl_transaksiTableAdapter.Fill(Me.Db_sotobabaelonDataSet.tbl_transaksi)

        Call ambilKoneksi()
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "dd/MM/yyyy"

        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DataPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        DataPegawai.Show()
        Me.Close()
    End Sub

    Private Sub DataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem1.Click
        DataPengguna.Show()
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

    Private Sub btnFilterData_Click(sender As Object, e As EventArgs) Handles btnFilterData.Click
        Dim dtDate1 As DateTime = DateTime.Parse(dtpFrom.Text)
        Dim dtDate2 As DateTime = DateTime.Parse(dtpTo.Text)

        dr.Close()
        cmd = New MySqlCommand("select * from tbl_transaksi where tgl_transaksi >= '" & dtDate1 & "' and tgl_transaksi < '" & dtDate2.AddDays(1) & "' ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            adapter = New MySqlDataAdapter(cmd)
            ds = New DataSet
            adapter.Fill(ds, "ketemu")
            dgvLaporan.DataSource = ds.Tables("ketemu")
            dgvLaporan.ReadOnly = True
        Else
            MsgBox("Data tidak ditemukan", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")
            xlWorkSheet.Columns.AutoFit()
            For i = 0 To dgvLaporan.Rows.Count - 2
                For j = 0 To dgvLaporan.Columns.Count - 1
                    For k As Integer = 1 To dgvLaporan.Columns.Count
                        xlWorkSheet.Cells(1, k) = dgvLaporan.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = dgvLaporan(j, i).Value.ToString

                    Next
                Next
            Next
            Dim fName As String = "Laporan Penjualan"
            Using sfd As New SaveFileDialog
                sfd.Title = "Save As"
                sfd.OverwritePrompt = True
                sfd.FileName = fName
                sfd.DefaultExt = ".xlsx"
                sfd.Filter = "Excel Workbook(*.xlsx)|"
                sfd.AddExtension = True
                If sfd.ShowDialog() = DialogResult.OK Then
                    xlWorkSheet.SaveAs(sfd.FileName)
                    xlWorkBook.Close()
                    xlApp.Quit()
                    ReleaseObject(xlApp)
                    ReleaseObject(xlWorkBook)
                    ReleaseObject(xlWorkSheet)
                    MsgBox("Laporan berhasil dicetak !", MsgBoxStyle.Information, "Informasi")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Terjadi error! " & vbCrLf & "Kode error: " & ex.Message)
        End Try
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        Me.Close()
    End Sub
End Class