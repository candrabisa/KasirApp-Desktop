<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariDataMenu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbInputNama = New System.Windows.Forms.TextBox()
        Me.dgvCariDataPegawai = New System.Windows.Forms.DataGridView()
        Me.KodemenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamamenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbldatamenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sotobabaelonDataSet = New KasirApp.db_sotobabaelonDataSet()
        Me.Tbl_data_menuTableAdapter = New KasirApp.db_sotobabaelonDataSetTableAdapters.tbl_data_menuTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCariDataPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldatamenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.tbInputNama)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 82)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukan kode atau nama menu"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(15, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cari Menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tbInputNama
        '
        Me.tbInputNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbInputNama.Location = New System.Drawing.Point(15, 20)
        Me.tbInputNama.Name = "tbInputNama"
        Me.tbInputNama.Size = New System.Drawing.Size(234, 20)
        Me.tbInputNama.TabIndex = 1
        '
        'dgvCariDataPegawai
        '
        Me.dgvCariDataPegawai.AllowUserToAddRows = False
        Me.dgvCariDataPegawai.AllowUserToDeleteRows = False
        Me.dgvCariDataPegawai.AllowUserToOrderColumns = True
        Me.dgvCariDataPegawai.AutoGenerateColumns = False
        Me.dgvCariDataPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCariDataPegawai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodemenuDataGridViewTextBoxColumn, Me.NamamenuDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn})
        Me.dgvCariDataPegawai.DataSource = Me.TbldatamenuBindingSource
        Me.dgvCariDataPegawai.Location = New System.Drawing.Point(12, 100)
        Me.dgvCariDataPegawai.Name = "dgvCariDataPegawai"
        Me.dgvCariDataPegawai.ReadOnly = True
        Me.dgvCariDataPegawai.Size = New System.Drawing.Size(566, 262)
        Me.dgvCariDataPegawai.TabIndex = 2
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
        'TbldatamenuBindingSource
        '
        Me.TbldatamenuBindingSource.DataMember = "tbl_data_menu"
        Me.TbldatamenuBindingSource.DataSource = Me.Db_sotobabaelonDataSet
        '
        'Db_sotobabaelonDataSet
        '
        Me.Db_sotobabaelonDataSet.DataSetName = "db_sotobabaelonDataSet"
        Me.Db_sotobabaelonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_data_menuTableAdapter
        '
        Me.Tbl_data_menuTableAdapter.ClearBeforeFill = True
        '
        'CariDataMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 373)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvCariDataPegawai)
        Me.Name = "CariDataMenu"
        Me.Text = "Cari Data Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCariDataPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldatamenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sotobabaelonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tbInputNama As TextBox
    Friend WithEvents dgvCariDataPegawai As DataGridView
    Friend WithEvents Db_sotobabaelonDataSet As db_sotobabaelonDataSet
    Friend WithEvents TbldatamenuBindingSource As BindingSource
    Friend WithEvents Tbl_data_menuTableAdapter As db_sotobabaelonDataSetTableAdapters.tbl_data_menuTableAdapter
    Friend WithEvents KodemenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamamenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
