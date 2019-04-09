<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kalkulator
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
        Me.Angka1 = New System.Windows.Forms.TextBox()
        Me.Angka2 = New System.Windows.Forms.TextBox()
        Me.Operasi = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Hasil = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Angka1
        '
        Me.Angka1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Angka1.Location = New System.Drawing.Point(86, 30)
        Me.Angka1.Name = "Angka1"
        Me.Angka1.Size = New System.Drawing.Size(100, 22)
        Me.Angka1.TabIndex = 0
        '
        'Angka2
        '
        Me.Angka2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Angka2.Location = New System.Drawing.Point(275, 30)
        Me.Angka2.Name = "Angka2"
        Me.Angka2.Size = New System.Drawing.Size(100, 22)
        Me.Angka2.TabIndex = 1
        '
        'Operasi
        '
        Me.Operasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operasi.FormattingEnabled = True
        Me.Operasi.Items.AddRange(New Object() {"+", "-", "x", ":"})
        Me.Operasi.Location = New System.Drawing.Point(206, 30)
        Me.Operasi.Name = "Operasi"
        Me.Operasi.Size = New System.Drawing.Size(41, 24)
        Me.Operasi.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(86, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Hasil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Hasil
        '
        Me.Hasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasil.Location = New System.Drawing.Point(206, 87)
        Me.Hasil.Name = "Hasil"
        Me.Hasil.Size = New System.Drawing.Size(169, 22)
        Me.Hasil.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(300, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Kalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Hasil)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Operasi)
        Me.Controls.Add(Me.Angka2)
        Me.Controls.Add(Me.Angka1)
        Me.Name = "Kalkulator"
        Me.Text = "Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Angka1 As TextBox
    Friend WithEvents Angka2 As TextBox
    Friend WithEvents Operasi As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Hasil As TextBox
    Friend WithEvents Button2 As Button
End Class
