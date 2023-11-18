<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pregled_strank
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
        Me.Ma_databaseDataSet = New MyAsisstant.ma_databaseDataSet()
        Me.MadatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ma_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MadatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.MadatabaseDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(71, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 123
        Me.DataGridView1.RowTemplate.Height = 46
        Me.DataGridView1.Size = New System.Drawing.Size(1471, 451)
        Me.DataGridView1.TabIndex = 0
        '
        'Ma_databaseDataSet
        '
        Me.Ma_databaseDataSet.DataSetName = "ma_databaseDataSet"
        Me.Ma_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MadatabaseDataSetBindingSource
        '
        Me.MadatabaseDataSetBindingSource.DataSource = Me.Ma_databaseDataSet
        Me.MadatabaseDataSetBindingSource.Position = 0
        '
        'pregled_strank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1614, 814)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "pregled_strank"
        Me.Text = "Pregled strank"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ma_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MadatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MadatabaseDataSetBindingSource As BindingSource
    Friend WithEvents Ma_databaseDataSet As ma_databaseDataSet
End Class
