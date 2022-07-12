<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPegawai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblRolesDataPegawai = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNipDataPegawai = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dtpTglJoin = New System.Windows.Forms.DateTimePicker()
        Me.tbNoHP = New System.Windows.Forms.TextBox()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbJekel = New System.Windows.Forms.ComboBox()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbNip = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDataPegawai = New System.Windows.Forms.DataGridView()
        Me.NipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgllahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NohpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgljoinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TbldatapegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sotobabaelonDataSet = New KasirApp.db_sotobabaelonDataSet()
        Me.Tbl_data_pegawaiTableAdapter = New KasirApp.db_sotobabaelonDataSetTableAdapters.tbl_data_pegawaiTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDataPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldatapegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pegawai"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
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
        Me.Panel2.Controls.Add(Me.lblRolesDataPegawai)
        Me.Panel2.Location = New System.Drawing.Point(123, 525)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(124, 35)
        Me.Panel2.TabIndex = 5
        '
        'lblRolesDataPegawai
        '
        Me.lblRolesDataPegawai.AutoSize = True
        Me.lblRolesDataPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRolesDataPegawai.Location = New System.Drawing.Point(27, 7)
        Me.lblRolesDataPegawai.Name = "lblRolesDataPegawai"
        Me.lblRolesDataPegawai.Size = New System.Drawing.Size(64, 20)
        Me.lblRolesDataPegawai.TabIndex = 0
        Me.lblRolesDataPegawai.Text = "ROLES"
        Me.lblRolesDataPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblNipDataPegawai)
        Me.Panel1.Location = New System.Drawing.Point(-1, 525)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 35)
        Me.Panel1.TabIndex = 4
        '
        'lblNipDataPegawai
        '
        Me.lblNipDataPegawai.AutoSize = True
        Me.lblNipDataPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNipDataPegawai.Location = New System.Drawing.Point(31, 7)
        Me.lblNipDataPegawai.Name = "lblNipDataPegawai"
        Me.lblNipDataPegawai.Size = New System.Drawing.Size(35, 20)
        Me.lblNipDataPegawai.TabIndex = 0
        Me.lblNipDataPegawai.Text = "NIP"
        Me.lblNipDataPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.dtpTglJoin)
        Me.Panel3.Controls.Add(Me.tbNoHP)
        Me.Panel3.Controls.Add(Me.dtpTglLahir)
        Me.Panel3.Controls.Add(Me.cbStatus)
        Me.Panel3.Controls.Add(Me.cbJekel)
        Me.Panel3.Controls.Add(Me.tbAlamat)
        Me.Panel3.Controls.Add(Me.tbNama)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.tbNip)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(33, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(731, 169)
        Me.Panel3.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(613, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 141)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AKSI"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Location = New System.Drawing.Point(17, 82)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 36)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.YellowGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambah.Location = New System.Drawing.Point(17, 31)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 36)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'dtpTglJoin
        '
        Me.dtpTglJoin.Location = New System.Drawing.Point(457, 136)
        Me.dtpTglJoin.Name = "dtpTglJoin"
        Me.dtpTglJoin.Size = New System.Drawing.Size(140, 20)
        Me.dtpTglJoin.TabIndex = 16
        '
        'tbNoHP
        '
        Me.tbNoHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNoHP.Location = New System.Drawing.Point(457, 107)
        Me.tbNoHP.Name = "tbNoHP"
        Me.tbNoHP.Size = New System.Drawing.Size(140, 20)
        Me.tbNoHP.TabIndex = 15
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Checked = False
        Me.dtpTglLahir.Location = New System.Drawing.Point(457, 76)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(140, 20)
        Me.dtpTglLahir.TabIndex = 14
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Kontrak", "Tetap"})
        Me.cbStatus.Location = New System.Drawing.Point(457, 44)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(140, 21)
        Me.cbStatus.TabIndex = 13
        '
        'cbJekel
        '
        Me.cbJekel.FormattingEnabled = True
        Me.cbJekel.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbJekel.Location = New System.Drawing.Point(457, 15)
        Me.cbJekel.Name = "cbJekel"
        Me.cbJekel.Size = New System.Drawing.Size(140, 21)
        Me.cbJekel.TabIndex = 12
        '
        'tbAlamat
        '
        Me.tbAlamat.Location = New System.Drawing.Point(63, 79)
        Me.tbAlamat.Multiline = True
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbAlamat.Size = New System.Drawing.Size(184, 77)
        Me.tbAlamat.TabIndex = 11
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(63, 46)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(184, 20)
        Me.tbNama.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Location = New System.Drawing.Point(185, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 20)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'tbNip
        '
        Me.tbNip.Enabled = False
        Me.tbNip.Location = New System.Drawing.Point(63, 15)
        Me.tbNip.Name = "tbNip"
        Me.tbNip.Size = New System.Drawing.Size(116, 20)
        Me.tbNip.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Location = New System.Drawing.Point(364, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "TGL. JOIN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "NO.HP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "TGL. LAHIR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "STATUS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "JENIS KELAMIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ALAMAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIP"
        '
        'dgvDataPegawai
        '
        Me.dgvDataPegawai.AllowUserToAddRows = False
        Me.dgvDataPegawai.AllowUserToOrderColumns = True
        Me.dgvDataPegawai.AutoGenerateColumns = False
        Me.dgvDataPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataPegawai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NipDataGridViewTextBoxColumn, Me.NamapegawaiDataGridViewTextBoxColumn, Me.TgllahirDataGridViewTextBoxColumn, Me.JeniskelaminDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.NohpDataGridViewTextBoxColumn, Me.TgljoinDataGridViewTextBoxColumn, Me.delete})
        Me.dgvDataPegawai.DataSource = Me.TbldatapegawaiBindingSource
        Me.dgvDataPegawai.Location = New System.Drawing.Point(33, 257)
        Me.dgvDataPegawai.Name = "dgvDataPegawai"
        Me.dgvDataPegawai.ReadOnly = True
        Me.dgvDataPegawai.Size = New System.Drawing.Size(731, 237)
        Me.dgvDataPegawai.TabIndex = 7
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
        Me.NamapegawaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NamapegawaiDataGridViewTextBoxColumn.DataPropertyName = "nama_pegawai"
        Me.NamapegawaiDataGridViewTextBoxColumn.HeaderText = "nama_pegawai"
        Me.NamapegawaiDataGridViewTextBoxColumn.Name = "NamapegawaiDataGridViewTextBoxColumn"
        Me.NamapegawaiDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamapegawaiDataGridViewTextBoxColumn.Width = 104
        '
        'TgllahirDataGridViewTextBoxColumn
        '
        Me.TgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir"
        Me.TgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir"
        Me.TgllahirDataGridViewTextBoxColumn.Name = "TgllahirDataGridViewTextBoxColumn"
        Me.TgllahirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JeniskelaminDataGridViewTextBoxColumn
        '
        Me.JeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.Name = "JeniskelaminDataGridViewTextBoxColumn"
        Me.JeniskelaminDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NohpDataGridViewTextBoxColumn
        '
        Me.NohpDataGridViewTextBoxColumn.DataPropertyName = "no_hp"
        Me.NohpDataGridViewTextBoxColumn.HeaderText = "no_hp"
        Me.NohpDataGridViewTextBoxColumn.Name = "NohpDataGridViewTextBoxColumn"
        Me.NohpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TgljoinDataGridViewTextBoxColumn
        '
        Me.TgljoinDataGridViewTextBoxColumn.DataPropertyName = "tgl_join"
        Me.TgljoinDataGridViewTextBoxColumn.HeaderText = "tgl_join"
        Me.TgljoinDataGridViewTextBoxColumn.Name = "TgljoinDataGridViewTextBoxColumn"
        Me.TgljoinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'delete
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Red
        Me.delete.DefaultCellStyle = DataGridViewCellStyle1
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete.HeaderText = ""
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Text = "HAPUS"
        Me.delete.UseColumnTextForButtonValue = True
        '
        'TbldatapegawaiBindingSource
        '
        Me.TbldatapegawaiBindingSource.DataMember = "tbl_data_pegawai"
        Me.TbldatapegawaiBindingSource.DataSource = Me.Db_sotobabaelonDataSet
        '
        'Db_sotobabaelonDataSet
        '
        Me.Db_sotobabaelonDataSet.DataSetName = "db_sotobabaelonDataSet"
        Me.Db_sotobabaelonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_data_pegawaiTableAdapter
        '
        Me.Tbl_data_pegawaiTableAdapter.ClearBeforeFill = True
        '
        'DataPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(800, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvDataPegawai)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataPegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDataPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldatapegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblRolesDataPegawai As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNipDataPegawai As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbJekel As ComboBox
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents tbNip As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dtpTglJoin As DateTimePicker
    Friend WithEvents tbNoHP As TextBox
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgvDataPegawai As DataGridView
    Friend WithEvents Db_sotobabaelonDataSet As db_sotobabaelonDataSet
    Friend WithEvents TbldatapegawaiBindingSource As BindingSource
    Friend WithEvents Tbl_data_pegawaiTableAdapter As db_sotobabaelonDataSetTableAdapters.tbl_data_pegawaiTableAdapter
    Friend WithEvents NipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamapegawaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TgllahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JeniskelaminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NohpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TgljoinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewButtonColumn
End Class
