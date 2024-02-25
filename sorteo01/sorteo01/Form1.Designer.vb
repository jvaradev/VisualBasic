<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Minimo = New System.Windows.Forms.Label()
        Me.Maximo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.Label()
        Me.MinBox = New System.Windows.Forms.TextBox()
        Me.MaxBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Minimo
        '
        Me.Minimo.AutoSize = True
        Me.Minimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimo.Location = New System.Drawing.Point(12, 18)
        Me.Minimo.Name = "Minimo"
        Me.Minimo.Size = New System.Drawing.Size(198, 29)
        Me.Minimo.TabIndex = 0
        Me.Minimo.Text = "Introduce mínimo"
        '
        'Maximo
        '
        Me.Maximo.AutoSize = True
        Me.Maximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maximo.Location = New System.Drawing.Point(12, 59)
        Me.Maximo.Name = "Maximo"
        Me.Maximo.Size = New System.Drawing.Size(203, 29)
        Me.Maximo.TabIndex = 1
        Me.Maximo.Text = "Introduce máximo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 70)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ejecutar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result.Location = New System.Drawing.Point(20, 115)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(0, 29)
        Me.Result.TabIndex = 3
        '
        'MinBox
        '
        Me.MinBox.Location = New System.Drawing.Point(236, 25)
        Me.MinBox.Name = "MinBox"
        Me.MinBox.Size = New System.Drawing.Size(100, 22)
        Me.MinBox.TabIndex = 4
        '
        'MaxBox
        '
        Me.MaxBox.Location = New System.Drawing.Point(236, 66)
        Me.MaxBox.Name = "MaxBox"
        Me.MaxBox.Size = New System.Drawing.Size(100, 22)
        Me.MaxBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 172)
        Me.Controls.Add(Me.MaxBox)
        Me.Controls.Add(Me.MinBox)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Maximo)
        Me.Controls.Add(Me.Minimo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Minimo As System.Windows.Forms.Label
    Friend WithEvents Maximo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Result As System.Windows.Forms.Label
    Friend WithEvents MinBox As System.Windows.Forms.TextBox
    Friend WithEvents MaxBox As System.Windows.Forms.TextBox

End Class
