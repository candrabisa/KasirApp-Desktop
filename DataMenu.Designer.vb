<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataMenu
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.tbNamaMenu = New System.Windows.Forms.TextBox()
        Me.tbKodeMenu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDataMenu = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCaridata = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblRoles = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNip = New System.Windows.Forms.Label()
        Me.Db_sotobabaelonDataSet = New KasirApp.db_sotobabaelonDataSet()
        Me.TbldatamenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_data_menuTableAdapter = New KasirApp.db_sotobabaelonDataSetTableAdapters.tbl_data_menuTableAdapter()
        Me.KodemenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamamenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aksi = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TbldatamenuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDataMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldatamenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldatamenuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(348, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DATA MENU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.tbHarga)
        Me.Panel1.Controls.Add(Me.tbNamaMenu)
        Me.Panel1.Controls.Add(Me.tbKodeMenu)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(313, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 136)
        Me.Panel1.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Location = New System.Drawing.Point(291, 84)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(93, 31)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.YellowGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambah.Location = New System.Drawing.Point(291, 13)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(93, 31)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(94, 93)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(161, 20)
        Me.tbHarga.TabIndex = 5
        '
        'tbNamaMenu
        '
        Me.tbNamaMenu.Location = New System.Drawing.Point(94, 43)
        Me.tbNamaMenu.Multiline = True
        Me.tbNamaMenu.Name = "tbNamaMenu"
        Me.tbNamaMenu.Size = New System.Drawing.Size(161, 42)
        Me.tbNamaMenu.TabIndex = 4
        '
        'tbKodeMenu
        '
        Me.tbKodeMenu.Location = New System.Drawing.Point(93, 13)
        Me.tbKodeMenu.Name = "tbKodeMenu"
        Me.tbKodeMenu.Size = New System.Drawing.Size(162, 20)
        Me.tbKodeMenu.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "HARGA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NAMA MENU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "KODE MENU"
        '
        'dgvDataMenu
        '
        Me.dgvDataMenu.AllowUserToAddRows = False
        Me.dgvDataMenu.AllowUserToOrderColumns = True
        Me.dgvDataMenu.AutoGenerateColumns = False
        Me.dgvDataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodemenuDataGridViewTextBoxColumn, Me.NamamenuDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.aksi})
        Me.dgvDataMenu.DataSource = Me.TbldatamenuBindingSource
        Me.dgvDataMenu.Location = New System.Drawing.Point(84, 231)
        Me.dgvDataMenu.Name = "dgvDataMenu"
        Me.dgvDataMenu.ReadOnly = True
        Me.dgvDataMenu.Size = New System.Drawing.Size(633, 163)
        Me.dgvDataMenu.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCariData)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbCaridata)
        Me.GroupBox1.Location = New System.Drawing.Point(84, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 120)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CARI DATA"
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(6, 79)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(188, 23)
        Me.btnCariData.TabIndex = 9
        Me.btnCariData.Text = "Cari"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Masukan Nama/Kode Menu"
        '
        'tbCaridata
        '
        Me.tbCaridata.Location = New System.Drawing.Point(6, 51)
        Me.tbCaridata.Name = "tbCaridata"
        Me.tbCaridata.Size = New System.Drawing.Size(188, 20)
        Me.tbCaridata.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblRoles)
        Me.Panel2.Location = New System.Drawing.Point(124, 450)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(124, 35)
        Me.Panel2.TabIndex = 9
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblNip)
        Me.Panel3.Location = New System.Drawing.Point(0, 450)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(124, 35)
        Me.Panel3.TabIndex = 8
        '
        'lblNip
        '
        Me.lblNip.AutoSize = True
        Me.lblNip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNip.Location = New System.Drawing.Point(31, 7)
        Me.lblNip.Name = "lblNip"
        Me.lblNip.Size = New System.Drawing.Size(35, 20)
        Me.lblNip.TabIndex = 0
        Me.lblNip.Text = "NIP"
        Me.lblNip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Db_sotobabaelonDataSet
        '
        Me.Db_sotobabaelonDataSet.DataSetName = "db_sotobabaelonDataSet"
        Me.Db_sotobabaelonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbldatamenuBindingSource
        '
        Me.TbldatamenuBindingSource.DataMember = "tbl_data_menu"
        Me.TbldatamenuBindingSource.DataSource = Me.Db_sotobabaelonDataSet
        '
        'Tbl_data_menuTableAdapter
        '
        Me.Tbl_data_menuTableAdapter.ClearBeforeFill = True
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
        Me.NamamenuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        'aksi
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        Me.aksi.DefaultCellStyle = DataGridViewCellStyle3
        Me.aksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.aksi.HeaderText = ""
        Me.aksi.Name = "aksi"
        Me.aksi.ReadOnly = True
        Me.aksi.Text = "HAPUS"
        Me.aksi.UseColumnTextForButtonValue = True
        '
        'DataMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(800, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvDataMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "DataMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDataMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldatamenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldatamenuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents tbNamaMenu As TextBox
    Friend WithEvents tbKodeMenu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDataMenu As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCariData As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCaridata As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblRoles As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNip As Label
    Friend WithEvents TbldatamenuBindingSource1 As BindingSource
    Friend WithEvents Db_sotobabaelonDataSet As db_sotobabaelonDataSet
    Friend WithEvents TbldatamenuBindingSource As BindingSource
    Friend WithEvents Tbl_data_menuTableAdapter As db_sotobabaelonDataSetTableAdapters.tbl_data_menuTableAdapter
    Friend WithEvents KodemenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamamenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents aksi As DataGridViewButtonColumn
End Class
