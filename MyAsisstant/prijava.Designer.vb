<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prijava
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
        Me.username_vnos = New System.Windows.Forms.TextBox()
        Me.pass_vnos = New System.Windows.Forms.TextBox()
        Me.prijava_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Uporabniško ime:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Geslo:"
        '
        'username_vnos
        '
        Me.username_vnos.Location = New System.Drawing.Point(618, 210)
        Me.username_vnos.Name = "username_vnos"
        Me.username_vnos.Size = New System.Drawing.Size(507, 44)
        Me.username_vnos.TabIndex = 2
        '
        'pass_vnos
        '
        Me.pass_vnos.Location = New System.Drawing.Point(618, 279)
        Me.pass_vnos.Name = "pass_vnos"
        Me.pass_vnos.Size = New System.Drawing.Size(507, 44)
        Me.pass_vnos.TabIndex = 3
        '
        'prijava_btn
        '
        Me.prijava_btn.Location = New System.Drawing.Point(532, 388)
        Me.prijava_btn.Name = "prijava_btn"
        Me.prijava_btn.Size = New System.Drawing.Size(348, 90)
        Me.prijava_btn.TabIndex = 4
        Me.prijava_btn.Text = "Prijava"
        Me.prijava_btn.UseVisualStyleBackColor = True
        '
        'prijava
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 688)
        Me.Controls.Add(Me.prijava_btn)
        Me.Controls.Add(Me.pass_vnos)
        Me.Controls.Add(Me.username_vnos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "prijava"
        Me.Text = "Prijava"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username_vnos As TextBox
    Friend WithEvents pass_vnos As TextBox
    Friend WithEvents prijava_btn As Button
End Class
