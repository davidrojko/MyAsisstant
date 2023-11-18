<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class odstrani_stranko
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ImeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriimekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NaslovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EpostaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StrankeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ma_databaseDataSet1 = New MyAsisstant.ma_databaseDataSet1()
        Me.StrankeTableAdapter = New MyAsisstant.ma_databaseDataSet1TableAdapters.strankeTableAdapter()
        Me.odstrani_btn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StrankeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ma_databaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImeDataGridViewTextBoxColumn, Me.PriimekDataGridViewTextBoxColumn, Me.NaslovDataGridViewTextBoxColumn, Me.EpostaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StrankeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(105, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 123
        Me.DataGridView1.RowTemplate.Height = 46
        Me.DataGridView1.Size = New System.Drawing.Size(1430, 528)
        Me.DataGridView1.TabIndex = 0
        '
        'ImeDataGridViewTextBoxColumn
        '
        Me.ImeDataGridViewTextBoxColumn.DataPropertyName = "ime"
        Me.ImeDataGridViewTextBoxColumn.HeaderText = "ime"
        Me.ImeDataGridViewTextBoxColumn.MinimumWidth = 15
        Me.ImeDataGridViewTextBoxColumn.Name = "ImeDataGridViewTextBoxColumn"
        '
        'PriimekDataGridViewTextBoxColumn
        '
        Me.PriimekDataGridViewTextBoxColumn.DataPropertyName = "priimek"
        Me.PriimekDataGridViewTextBoxColumn.HeaderText = "priimek"
        Me.PriimekDataGridViewTextBoxColumn.MinimumWidth = 15
        Me.PriimekDataGridViewTextBoxColumn.Name = "PriimekDataGridViewTextBoxColumn"
        '
        'NaslovDataGridViewTextBoxColumn
        '
        Me.NaslovDataGridViewTextBoxColumn.DataPropertyName = "naslov"
        Me.NaslovDataGridViewTextBoxColumn.HeaderText = "naslov"
        Me.NaslovDataGridViewTextBoxColumn.MinimumWidth = 15
        Me.NaslovDataGridViewTextBoxColumn.Name = "NaslovDataGridViewTextBoxColumn"
        '
        'EpostaDataGridViewTextBoxColumn
        '
        Me.EpostaDataGridViewTextBoxColumn.DataPropertyName = "eposta"
        Me.EpostaDataGridViewTextBoxColumn.HeaderText = "eposta"
        Me.EpostaDataGridViewTextBoxColumn.MinimumWidth = 15
        Me.EpostaDataGridViewTextBoxColumn.Name = "EpostaDataGridViewTextBoxColumn"
        '
        'StrankeBindingSource
        '
        Me.StrankeBindingSource.DataMember = "stranke"
        Me.StrankeBindingSource.DataSource = Me.Ma_databaseDataSet1
        '
        'Ma_databaseDataSet1
        '
        Me.Ma_databaseDataSet1.DataSetName = "ma_databaseDataSet1"
        Me.Ma_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StrankeTableAdapter
        '
        Me.StrankeTableAdapter.ClearBeforeFill = True
        '
        'odstrani_btn
        '
        Me.odstrani_btn.Location = New System.Drawing.Point(596, 662)
        Me.odstrani_btn.Name = "odstrani_btn"
        Me.odstrani_btn.Size = New System.Drawing.Size(401, 80)
        Me.odstrani_btn.TabIndex = 1
        Me.odstrani_btn.Text = "Odstrani"
        Me.odstrani_btn.UseVisualStyleBackColor = True
        '
        'odstrani_stranko
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1631, 791)
        Me.Controls.Add(Me.odstrani_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "odstrani_stranko"
        Me.Text = "Odstrani stranko"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StrankeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ma_databaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Ma_databaseDataSet1 As ma_databaseDataSet1
    Friend WithEvents StrankeBindingSource As BindingSource
    Friend WithEvents StrankeTableAdapter As ma_databaseDataSet1TableAdapters.strankeTableAdapter
    Friend WithEvents ImeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriimekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NaslovDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EpostaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents odstrani_btn As Button
End Class
