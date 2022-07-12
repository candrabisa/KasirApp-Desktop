<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariDataPegawai
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
        Me.dgvCariDataPegawai = New System.Windows.Forms.DataGridView()
        Me.NipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgllahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NohpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgljoinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbldatapegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sotobabaelonDataSet = New KasirApp.db_sotobabaelonDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbInputNama = New System.Windows.Forms.TextBox()
        Me.Tbl_data_pegawaiTableAdapter = New KasirApp.db_sotobabaelonDataSetTableAdapters.tbl_data_pegawaiTableAdapter()
        CType(Me.dgvCariDataPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldatapegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCariDataPegawai
        '
        Me.dgvCariDataPegawai.AllowUserToAddRows = False
        Me.dgvCariDataPegawai.AllowUserToDeleteRows = False
        Me.dgvCariDataPegawai.AutoGenerateColumns = False
        Me.dgvCariDataPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCariDataPegawai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NipDataGridViewTextBoxColumn, Me.NamapegawaiDataGridViewTextBoxColumn, Me.TgllahirDataGridViewTextBoxColumn, Me.JeniskelaminDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.NohpDataGridViewTextBoxColumn, Me.TgljoinDataGridViewTextBoxColumn})
        Me.dgvCariDataPegawai.DataSource = Me.TbldatapegawaiBindingSource
        Me.dgvCariDataPegawai.Location = New System.Drawing.Point(12, 100)
        Me.dgvCariDataPegawai.Name = "dgvCariDataPegawai"
        Me.dgvCariDataPegawai.Size = New System.Drawing.Size(776, 338)
        Me.dgvCariDataPegawai.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.tbInputNama)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 82)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukan nama pegawai"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(15, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cari data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tbInputNama
        '
        Me.tbInputNama.Location = New System.Drawing.Point(15, 20)
        Me.tbInputNama.Name = "tbInputNama"
        Me.tbInputNama.Size = New System.Drawing.Size(234, 20)
        Me.tbInputNama.TabIndex = 2
        '
        'Tbl_data_pegawaiTableAdapter
        '
        Me.Tbl_data_pegawaiTableAdapter.ClearBeforeFill = True
        '
        'CariDataPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvCariDataPegawai)
        Me.Name = "CariDataPegawai"
        Me.Text = "Cari Data Pegawai"
        CType(Me.dgvCariDataPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldatapegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCariDataPegawai As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tbInputNama As TextBox
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
End Class
