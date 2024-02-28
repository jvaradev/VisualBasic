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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtLetras = New System.Windows.Forms.Button()
        Me.BtNum = New System.Windows.Forms.Button()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.BoxCant = New System.Windows.Forms.TextBox()
        Me.BtColor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 314)
        Me.TextBox1.TabIndex = 0
        '
        'BtLetras
        '
        Me.BtLetras.Location = New System.Drawing.Point(13, 12)
        Me.BtLetras.Name = "BtLetras"
        Me.BtLetras.Size = New System.Drawing.Size(131, 37)
        Me.BtLetras.TabIndex = 1
        Me.BtLetras.Text = "LETRAS"
        Me.BtLetras.UseVisualStyleBackColor = True
        '
        'BtNum
        '
        Me.BtNum.Location = New System.Drawing.Point(12, 69)
        Me.BtNum.Name = "BtNum"
        Me.BtNum.Size = New System.Drawing.Size(131, 37)
        Me.BtNum.TabIndex = 2
        Me.BtNum.Text = "NUMEROS"
        Me.BtNum.UseVisualStyleBackColor = True
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(12, 289)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(131, 37)
        Me.BtSalir.TabIndex = 4
        Me.BtSalir.Text = "SALIR"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'BoxCant
        '
        Me.BoxCant.Location = New System.Drawing.Point(12, 122)
        Me.BoxCant.Name = "BoxCant"
        Me.BoxCant.Size = New System.Drawing.Size(30, 22)
        Me.BoxCant.TabIndex = 5
        Me.BoxCant.Text = "10"
        '
        'BtColor
        '
        Me.BtColor.Location = New System.Drawing.Point(12, 161)
        Me.BtColor.Name = "BtColor"
        Me.BtColor.Size = New System.Drawing.Size(131, 33)
        Me.BtColor.TabIndex = 6
        Me.BtColor.Text = "COLOR"
        Me.BtColor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 338)
        Me.Controls.Add(Me.BtColor)
        Me.Controls.Add(Me.BoxCant)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtNum)
        Me.Controls.Add(Me.BtLetras)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtLetras As System.Windows.Forms.Button
    Friend WithEvents BtNum As System.Windows.Forms.Button
    Friend WithEvents BtSalir As System.Windows.Forms.Button
    Friend WithEvents BoxCant As System.Windows.Forms.TextBox
    Friend WithEvents BtColor As System.Windows.Forms.Button

End Class
