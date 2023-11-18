<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodaj_stranko
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ime_vnos = New System.Windows.Forms.TextBox()
        Me.priimek_vnos = New System.Windows.Forms.TextBox()
        Me.naslov_vnos = New System.Windows.Forms.TextBox()
        Me.eposta_vnos = New System.Windows.Forms.TextBox()
        Me.vnesi_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ime:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Priimek:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Naslov:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-pošta:"
        '
        'ime_vnos
        '
        Me.ime_vnos.Location = New System.Drawing.Point(280, 53)
        Me.ime_vnos.Name = "ime_vnos"
        Me.ime_vnos.Size = New System.Drawing.Size(782, 44)
        Me.ime_vnos.TabIndex = 4
        '
        'priimek_vnos
        '
        Me.priimek_vnos.Location = New System.Drawing.Point(280, 134)
        Me.priimek_vnos.Name = "priimek_vnos"
        Me.priimek_vnos.Size = New System.Drawing.Size(782, 44)
        Me.priimek_vnos.TabIndex = 5
        '
        'naslov_vnos
        '
        Me.naslov_vnos.Location = New System.Drawing.Point(280, 215)
        Me.naslov_vnos.Name = "naslov_vnos"
        Me.naslov_vnos.Size = New System.Drawing.Size(782, 44)
        Me.naslov_vnos.TabIndex = 6
        '
        'eposta_vnos
        '
        Me.eposta_vnos.Location = New System.Drawing.Point(280, 296)
        Me.eposta_vnos.Name = "eposta_vnos"
        Me.eposta_vnos.Size = New System.Drawing.Size(782, 44)
        Me.eposta_vnos.TabIndex = 7
        '
        'vnesi_btn
        '
        Me.vnesi_btn.Location = New System.Drawing.Point(12, 862)
        Me.vnesi_btn.Name = "vnesi_btn"
        Me.vnesi_btn.Size = New System.Drawing.Size(419, 74)
        Me.vnesi_btn.TabIndex = 8
        Me.vnesi_btn.Text = "Vnesi"
        Me.vnesi_btn.UseVisualStyleBackColor = True
        '
        'dodaj_stranko
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1840, 948)
        Me.Controls.Add(Me.vnesi_btn)
        Me.Controls.Add(Me.eposta_vnos)
        Me.Controls.Add(Me.naslov_vnos)
        Me.Controls.Add(Me.priimek_vnos)
        Me.Controls.Add(Me.ime_vnos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "dodaj_stranko"
        Me.Text = "Dodaj stranko"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ime_vnos As TextBox
    Friend WithEvents priimek_vnos As TextBox
    Friend WithEvents naslov_vnos As TextBox
    Friend WithEvents eposta_vnos As TextBox
    Friend WithEvents vnesi_btn As Button
End Class
