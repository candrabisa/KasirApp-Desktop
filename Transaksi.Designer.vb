<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.tbPegawai = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbJumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNamaMenu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbKodeMenu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTransaksi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblRoles = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNip = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbFilterData = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.dgvCetakStruk = New System.Windows.Forms.DataGridView()
        Me.id_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pegawai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Db_sotobabaelonDataSet = New KasirApp.db_sotobabaelonDataSet()
        Me.TbltransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_transaksiTableAdapter = New KasirApp.db_sotobabaelonDataSetTableAdapters.tbl_transaksiTableAdapter()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.IdtransaksiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgltransaksiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodemenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamamenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalhargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCetakStruk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSAKSI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.tbPegawai)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtpTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbJumlah)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbHarga)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbNamaMenu)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbKodeMenu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(521, 39)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(54, 21)
        Me.btnHitung.TabIndex = 20
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'tbPegawai
        '
        Me.tbPegawai.Enabled = False
        Me.tbPegawai.Location = New System.Drawing.Point(409, 94)
        Me.tbPegawai.Name = "tbPegawai"
        Me.tbPegawai.Size = New System.Drawing.Size(159, 20)
        Me.tbPegawai.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(348, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "PEGAWAI"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.YellowGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambah.Location = New System.Drawing.Point(601, 86)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 28)
        Me.btnTambah.TabIndex = 15
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 20)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cari Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpTransaksi
        '
        Me.dtpTransaksi.Location = New System.Drawing.Point(116, 39)
        Me.dtpTransaksi.Name = "dtpTransaksi"
        Me.dtpTransaksi.Size = New System.Drawing.Size(201, 20)
        Me.dtpTransaksi.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "TGL. TRANSAKSI"
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.Location = New System.Drawing.Point(409, 65)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(159, 20)
        Me.tbTotal.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "TOTAL"
        '
        'tbJumlah
        '
        Me.tbJumlah.Location = New System.Drawing.Point(409, 39)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(106, 20)
        Me.tbJumlah.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(348, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "JUMLAH"
        '
        'tbHarga
        '
        Me.tbHarga.Enabled = False
        Me.tbHarga.Location = New System.Drawing.Point(409, 13)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(106, 20)
        Me.tbHarga.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "HARGA"
        '
        'tbNamaMenu
        '
        Me.tbNamaMenu.Enabled = False
        Me.tbNamaMenu.Location = New System.Drawing.Point(116, 91)
        Me.tbNamaMenu.Name = "tbNamaMenu"
        Me.tbNamaMenu.Size = New System.Drawing.Size(201, 20)
        Me.tbNamaMenu.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NAMA MENU"
        '
        'tbKodeMenu
        '
        Me.tbKodeMenu.Enabled = False
        Me.tbKodeMenu.Location = New System.Drawing.Point(116, 65)
        Me.tbKodeMenu.Name = "tbKodeMenu"
        Me.tbKodeMenu.Size = New System.Drawing.Size(126, 20)
        Me.tbKodeMenu.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KODE MENU"
        '
        'tbTransaksi
        '
        Me.tbTransaksi.Enabled = False
        Me.tbTransaksi.Location = New System.Drawing.Point(116, 13)
        Me.tbTransaksi.Name = "tbTransaksi"
        Me.tbTransaksi.Size = New System.Drawing.Size(201, 20)
        Me.tbTransaksi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID TRANSAKSI"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem1, Me.DataPegawaiToolStripMenuItem, Me.DataMenuToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DataToolStripMenuItem1
        '
        Me.DataToolStripMenuItem1.Name = "DataToolStripMenuItem1"
        Me.DataToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.DataToolStripMenuItem1.Text = "Data Pengguna"
        '
        'DataPegawaiToolStripMenuItem
        '
        Me.DataPegawaiToolStripMenuItem.Name = "DataPegawaiToolStripMenuItem"
        Me.DataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DataPegawaiToolStripMenuItem.Text = "Data Pegawai"
        '
        'DataMenuToolStripMenuItem
        '
        Me.DataMenuToolStripMenuItem.Name = "DataMenuToolStripMenuItem"
        Me.DataMenuToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DataMenuToolStripMenuItem.Text = "Data Menu"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblRoles)
        Me.Panel2.Location = New System.Drawing.Point(123, 627)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(124, 35)
        Me.Panel2.TabIndex = 7
        '
        'lblRoles
        '
        Me.lblRoles.AutoSize = True
        Me.lblRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoles.Location = New System.Drawing.Point(27, 7)
        Me.lblRoles.Name = "lblRoles"
        Me.lblRoles.Size = New System.Drawing.Size(64, 20)
        Me.lblRoles.TabIndex = 0
        Me.lblRoles.Text = "ROLES"
        Me.lblRoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblNip)
        Me.Panel1.Controls.Add(Me.label11)
        Me.Panel1.Location = New System.Drawing.Point(-1, 627)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 35)
        Me.Panel1.TabIndex = 6
        '
        'lblNip
        '
        Me.lblNip.AutoSize = True
        Me.lblNip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNip.Location = New System.Drawing.Point(65, 7)
        Me.lblNip.Name = "lblNip"
        Me.lblNip.Size = New System.Drawing.Size(0, 20)
        Me.lblNip.TabIndex = 1
        Me.lblNip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(31, 7)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(35, 20)
        Me.label11.TabIndex = 0
        Me.label11.Text = "NIP"
        Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCari)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbFilterData)
        Me.GroupBox2.Location = New System.Drawing.Point(53, 372)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 66)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Data Transaksi"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(169, 40)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 21)
        Me.btnCari.TabIndex = 10
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "ID / Tanggal Transaksi"
        '
        'tbFilterData
        '
        Me.tbFilterData.Location = New System.Drawing.Point(26, 40)
        Me.tbFilterData.Name = "tbFilterData"
        Me.tbFilterData.Size = New System.Drawing.Size(137, 20)
        Me.tbFilterData.TabIndex = 9
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.PrintToFile = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'dgvCetakStruk
        '
        Me.dgvCetakStruk.AllowUserToAddRows = False
        Me.dgvCetakStruk.AllowUserToOrderColumns = True
        Me.dgvCetakStruk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCetakStruk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_transaksi, Me.tgl_transaksi, Me.kode_menu, Me.nama_menu, Me.harga, Me.jumlah, Me.total_harga, Me.nip, Me.nama_pegawai, Me.delete})
        Me.dgvCetakStruk.Location = New System.Drawing.Point(53, 198)
        Me.dgvCetakStruk.Name = "dgvCetakStruk"
        Me.dgvCetakStruk.Size = New System.Drawing.Size(595, 134)
        Me.dgvCetakStruk.TabIndex = 12
        '
        'id_transaksi
        '
        Me.id_transaksi.HeaderText = "Id Transaksi"
        Me.id_transaksi.Name = "id_transaksi"
        '
        'tgl_transaksi
        '
        Me.tgl_transaksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tgl_transaksi.HeaderText = "Tgl. Transaksi"
        Me.tgl_transaksi.Name = "tgl_transaksi"
        Me.tgl_transaksi.Width = 91
        '
        'kode_menu
        '
        Me.kode_menu.HeaderText = "Kode Menu"
        Me.kode_menu.Name = "kode_menu"
        '
        'nama_menu
        '
        Me.nama_menu.HeaderText = "Nama Menu"
        Me.nama_menu.Name = "nama_menu"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'total_harga
        '
        Me.total_harga.HeaderText = "Total Harga"
        Me.total_harga.Name = "total_harga"
        '
        'nip
        '
        Me.nip.HeaderText = "NIP"
        Me.nip.Name = "nip"
        '
        'nama_pegawai
        '
        Me.nama_pegawai.HeaderText = "Nama Pegawai"
        Me.nama_pegawai.Name = "nama_pegawai"
        '
        'delete
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        Me.delete.DefaultCellStyle = DataGridViewCellStyle3
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete.HeaderText = ""
        Me.delete.Name = "delete"
        Me.delete.Text = "HAPUS"
        Me.delete.UseColumnTextForButtonValue = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(312, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "RIWAYAT TRANSAKSI"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Db_sotobabaelonDataSet
        '
        Me.Db_sotobabaelonDataSet.DataSetName = "db_sotobabaelonDataSet"
        Me.Db_sotobabaelonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbltransaksiBindingSource
        '
        Me.TbltransaksiBindingSource.DataMember = "tbl_transaksi"
        Me.TbltransaksiBindingSource.DataSource = Me.Db_sotobabaelonDataSet
        '
        'Tbl_transaksiTableAdapter
        '
        Me.Tbl_transaksiTableAdapter.ClearBeforeFill = True
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.AllowUserToAddRows = False
        Me.dgvTransaksi.AllowUserToOrderColumns = True
        Me.dgvTransaksi.AutoGenerateColumns = False
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtransaksiDataGridViewTextBoxColumn, Me.TgltransaksiDataGridViewTextBoxColumn, Me.KodemenuDataGridViewTextBoxColumn, Me.NamamenuDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn, Me.TotalhargaDataGridViewTextBoxColumn, Me.NipDataGridViewTextBoxColumn, Me.NamapegawaiDataGridViewTextBoxColumn, Me.hapus})
        Me.dgvTransaksi.DataSource = Me.TbltransaksiBindingSource
        Me.dgvTransaksi.Location = New System.Drawing.Point(53, 444)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.ReadOnly = True
        Me.dgvTransaksi.Size = New System.Drawing.Size(688, 177)
        Me.dgvTransaksi.TabIndex = 14
        '
        'IdtransaksiDataGridViewTextBoxColumn
        '
        Me.IdtransaksiDataGridViewTextBoxColumn.DataPropertyName = "id_transaksi"
        Me.IdtransaksiDataGridViewTextBoxColumn.HeaderText = "id_transaksi"
        Me.IdtransaksiDataGridViewTextBoxColumn.Name = "IdtransaksiDataGridViewTextBoxColumn"
        Me.IdtransaksiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TgltransaksiDataGridViewTextBoxColumn
        '
        Me.TgltransaksiDataGridViewTextBoxColumn.DataPropertyName = "tgl_transaksi"
        Me.TgltransaksiDataGridViewTextBoxColumn.HeaderText = "tgl_transaksi"
        Me.TgltransaksiDataGridViewTextBoxColumn.Name = "TgltransaksiDataGridViewTextBoxColumn"
        Me.TgltransaksiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KodemenuDataGridViewTextBoxColumn
        '
        Me.KodemenuDataGridViewTextBoxColumn.DataPropertyName = "kode_menu"
        Me.KodemenuDataGridViewTextBoxColumn.HeaderText = "kode_menu"
        Me.KodemenuDataGridViewTextBoxColumn.Name = "KodemenuDataGridViewTextBoxColumn"
        Me.KodemenuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamamenuDataGridViewTextBoxColumn
        '
        Me.NamamenuDataGridViewTextBoxColumn.DataPropertyName = "nama_menu"
        Me.NamamenuDataGridViewTextBoxColumn.HeaderText = "nama_menu"
        Me.NamamenuDataGridViewTextBoxColumn.Name = "NamamenuDataGridViewTextBoxColumn"
        Me.NamamenuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        Me.JumlahDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalhargaDataGridViewTextBoxColumn
        '
        Me.TotalhargaDataGridViewTextBoxColumn.DataPropertyName = "total_harga"
        Me.TotalhargaDataGridViewTextBoxColumn.HeaderText = "total_harga"
        Me.TotalhargaDataGridViewTextBoxColumn.Name = "TotalhargaDataGridViewTextBoxColumn"
        Me.TotalhargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NipDataGridViewTextBoxColumn
        '
        Me.NipDataGridViewTextBoxColumn.DataPropertyName = "nip"
        Me.NipDataGridViewTextBoxColumn.HeaderText = "nip"
        Me.NipDataGridViewTextBoxColumn.Name = "NipDataGridViewTextBoxColumn"
        Me.NipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamapegawaiDataGridViewTextBoxColumn
        '
        Me.NamapegawaiDataGridViewTextBoxColumn.DataPropertyName = "nama_pegawai"
        Me.NamapegawaiDataGridViewTextBoxColumn.HeaderText = "nama_pegawai"
        Me.NamapegawaiDataGridViewTextBoxColumn.Name = "NamapegawaiDataGridViewTextBoxColumn"
        Me.NamapegawaiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'hapus
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        Me.hapus.DefaultCellStyle = DataGridViewCellStyle4
        Me.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hapus.HeaderText = ""
        Me.hapus.Name = "hapus"
        Me.hapus.ReadOnly = True
        Me.hapus.Text = "HAPUS"
        Me.hapus.UseColumnTextForButtonValue = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSimpan)
        Me.GroupBox3.Controls.Add(Me.btnCetak)
        Me.GroupBox3.Location = New System.Drawing.Point(654, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(87, 108)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aksi"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Cyan
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Location = New System.Drawing.Point(6, 65)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 30)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCetak.Location = New System.Drawing.Point(6, 19)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 30)
        Me.btnCetak.TabIndex = 0
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(800, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvTransaksi)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvCetakStruk)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCetakStruk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpTransaksi As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbJumlah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNamaMenu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbKodeMenu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTransaksi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblRoles As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents label11 As Label
    Friend WithEvents tbPegawai As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNip As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents tbFilterData As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents dgvCetakStruk As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Db_sotobabaelonDataSet As db_sotobabaelonDataSet
    Friend WithEvents TbltransaksiBindingSource As BindingSource
    Friend WithEvents Tbl_transaksiTableAdapter As db_sotobabaelonDataSetTableAdapters.tbl_transaksiTableAdapter
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents IdtransaksiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TgltransaksiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodemenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamamenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalhargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamapegawaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents hapus As DataGridViewButtonColumn
    Friend WithEvents id_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents tgl_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents kode_menu As DataGridViewTextBoxColumn
    Friend WithEvents nama_menu As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents total_harga As DataGridViewTextBoxColumn
    Friend WithEvents nip As DataGridViewTextBoxColumn
    Friend WithEvents nama_pegawai As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewButtonColumn
    Friend WithEvents btnSimpan As Button
End Class
