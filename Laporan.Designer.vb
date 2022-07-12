<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laporan
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
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.IdtransaksiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgltransaksiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodemenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamamenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalhargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbltransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sotobabaelonDataSet = New KasirApp.db_sotobabaelonDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFilterData = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_transaksiTableAdapter = New KasirApp.db_sotobabaelonDataSetTableAdapters.tbl_transaksiTableAdapter()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLaporan
        '
        Me.dgvLaporan.AllowUserToAddRows = False
        Me.dgvLaporan.AllowUserToOrderColumns = True
        Me.dgvLaporan.AutoGenerateColumns = False
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtransaksiDataGridViewTextBoxColumn, Me.TgltransaksiDataGridViewTextBoxColumn, Me.KodemenuDataGridViewTextBoxColumn, Me.NamamenuDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn, Me.TotalhargaDataGridViewTextBoxColumn, Me.NipDataGridViewTextBoxColumn, Me.NamapegawaiDataGridViewTextBoxColumn})
        Me.dgvLaporan.DataSource = Me.TbltransaksiBindingSource
        Me.dgvLaporan.Location = New System.Drawing.Point(12, 179)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.ReadOnly = True
        Me.dgvLaporan.Size = New System.Drawing.Size(776, 259)
        Me.dgvLaporan.TabIndex = 0
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
        'TbltransaksiBindingSource
        '
        Me.TbltransaksiBindingSource.DataMember = "tbl_transaksi"
        Me.TbltransaksiBindingSource.DataSource = Me.Db_sotobabaelonDataSet
        '
        'Db_sotobabaelonDataSet
        '
        Me.Db_sotobabaelonDataSet.DataSetName = "db_sotobabaelonDataSet"
        Me.Db_sotobabaelonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LAPORAN"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(23, 35)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(133, 20)
        Me.dtpFrom.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnFilterData)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 93)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "From"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(180, 35)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(133, 20)
        Me.dtpTo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To"
        '
        'btnFilterData
        '
        Me.btnFilterData.Location = New System.Drawing.Point(238, 65)
        Me.btnFilterData.Name = "btnFilterData"
        Me.btnFilterData.Size = New System.Drawing.Size(75, 23)
        Me.btnFilterData.TabIndex = 4
        Me.btnFilterData.Text = "Filter"
        Me.btnFilterData.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCetak.Location = New System.Drawing.Point(668, 145)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(120, 28)
        Me.btnCetak.TabIndex = 4
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 5
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
        'Tbl_transaksiTableAdapter
        '
        Me.Tbl_transaksiTableAdapter.ClearBeforeFill = True
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLaporan)
        Me.Name = "Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFilterData As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Db_sotobabaelonDataSet As db_sotobabaelonDataSet
    Friend WithEvents TbltransaksiBindingSource As BindingSource
    Friend WithEvents Tbl_transaksiTableAdapter As db_sotobabaelonDataSetTableAdapters.tbl_transaksiTableAdapter
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents IdtransaksiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TgltransaksiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodemenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamamenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalhargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamapegawaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
