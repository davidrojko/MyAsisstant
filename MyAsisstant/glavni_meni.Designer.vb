<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class glavni_meni
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StrankeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajStrankoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdstraniStrankoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PregledStrankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.izhod_btn = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StrankeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1806, 61)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StrankeToolStripMenuItem
        '
        Me.StrankeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajStrankoToolStripMenuItem, Me.OdstraniStrankoToolStripMenuItem, Me.PregledStrankToolStripMenuItem})
        Me.StrankeToolStripMenuItem.Name = "StrankeToolStripMenuItem"
        Me.StrankeToolStripMenuItem.Size = New System.Drawing.Size(166, 57)
        Me.StrankeToolStripMenuItem.Text = "Stranke"
        '
        'DodajStrankoToolStripMenuItem
        '
        Me.DodajStrankoToolStripMenuItem.Name = "DodajStrankoToolStripMenuItem"
        Me.DodajStrankoToolStripMenuItem.Size = New System.Drawing.Size(538, 66)
        Me.DodajStrankoToolStripMenuItem.Text = "Dodaj stranko"
        '
        'OdstraniStrankoToolStripMenuItem
        '
        Me.OdstraniStrankoToolStripMenuItem.Name = "OdstraniStrankoToolStripMenuItem"
        Me.OdstraniStrankoToolStripMenuItem.Size = New System.Drawing.Size(538, 66)
        Me.OdstraniStrankoToolStripMenuItem.Text = "Odstrani stranko"
        '
        'PregledStrankToolStripMenuItem
        '
        Me.PregledStrankToolStripMenuItem.Name = "PregledStrankToolStripMenuItem"
        Me.PregledStrankToolStripMenuItem.Size = New System.Drawing.Size(538, 66)
        Me.PregledStrankToolStripMenuItem.Text = "Pregled strank"
        '
        'izhod_btn
        '
        Me.izhod_btn.Location = New System.Drawing.Point(1449, 801)
        Me.izhod_btn.Name = "izhod_btn"
        Me.izhod_btn.Size = New System.Drawing.Size(345, 84)
        Me.izhod_btn.TabIndex = 1
        Me.izhod_btn.Text = "Izhod"
        Me.izhod_btn.UseVisualStyleBackColor = True
        '
        'glavni_meni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1806, 897)
        Me.Controls.Add(Me.izhod_btn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "glavni_meni"
        Me.Text = "Glavni meni"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StrankeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DodajStrankoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OdstraniStrankoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PregledStrankToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents izhod_btn As Button
End Class
