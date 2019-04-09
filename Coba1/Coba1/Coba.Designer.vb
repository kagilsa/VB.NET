<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Coba
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Angka1 = New System.Windows.Forms.TextBox()
        Me.Angka2 = New System.Windows.Forms.TextBox()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.Operasi = New System.Windows.Forms.ComboBox()
        Me.Hasil = New System.Windows.Forms.TextBox()
        Me.Jam = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TeksJalan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Hasil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Angka1
        '
        Me.Angka1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Angka1.Location = New System.Drawing.Point(12, 74)
        Me.Angka1.Name = "Angka1"
        Me.Angka1.Size = New System.Drawing.Size(100, 22)
        Me.Angka1.TabIndex = 1
        '
        'Angka2
        '
        Me.Angka2.Location = New System.Drawing.Point(175, 77)
        Me.Angka2.Name = "Angka2"
        Me.Angka2.Size = New System.Drawing.Size(100, 20)
        Me.Angka2.TabIndex = 2
        '
        'Hapus
        '
        Me.Hapus.Location = New System.Drawing.Point(175, 138)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Hapus.TabIndex = 3
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Operasi
        '
        Me.Operasi.FormattingEnabled = True
        Me.Operasi.Items.AddRange(New Object() {"+", "-", "x", ":"})
        Me.Operasi.Location = New System.Drawing.Point(118, 76)
        Me.Operasi.Name = "Operasi"
        Me.Operasi.Size = New System.Drawing.Size(51, 21)
        Me.Operasi.TabIndex = 4
        '
        'Hasil
        '
        Me.Hasil.Location = New System.Drawing.Point(100, 103)
        Me.Hasil.Name = "Hasil"
        Me.Hasil.Size = New System.Drawing.Size(100, 20)
        Me.Hasil.TabIndex = 5
        '
        'Jam
        '
        Me.Jam.AutoSize = True
        Me.Jam.Location = New System.Drawing.Point(115, 31)
        Me.Jam.Name = "Jam"
        Me.Jam.Size = New System.Drawing.Size(39, 13)
        Me.Jam.TabIndex = 6
        Me.Jam.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TeksJalan
        '
        Me.TeksJalan.AutoSize = True
        Me.TeksJalan.Location = New System.Drawing.Point(97, 204)
        Me.TeksJalan.Name = "TeksJalan"
        Me.TeksJalan.Size = New System.Drawing.Size(76, 13)
        Me.TeksJalan.TabIndex = 7
        Me.TeksJalan.Text = "MuterMuterAja"
        '
        'Coba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 272)
        Me.Controls.Add(Me.TeksJalan)
        Me.Controls.Add(Me.Jam)
        Me.Controls.Add(Me.Hasil)
        Me.Controls.Add(Me.Operasi)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Angka2)
        Me.Controls.Add(Me.Angka1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Coba"
        Me.Text = "Coba"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Angka1 As TextBox
    Friend WithEvents Angka2 As TextBox
    Friend WithEvents Hapus As Button
    Friend WithEvents Operasi As ComboBox
    Friend WithEvents Hasil As TextBox
    Friend WithEvents Jam As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TeksJalan As Label
    Friend WithEvents Login As Button
    Friend WithEvents Keluar As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
