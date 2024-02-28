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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtColor = New System.Windows.Forms.Button()
        Me.Texto1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'BtColor
        '
        Me.BtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtColor.Location = New System.Drawing.Point(12, 179)
        Me.BtColor.Name = "BtColor"
        Me.BtColor.Size = New System.Drawing.Size(246, 62)
        Me.BtColor.TabIndex = 0
        Me.BtColor.Text = "CAMBIA COLOR"
        Me.BtColor.UseVisualStyleBackColor = True
        '
        'Texto1
        '
        Me.Texto1.AutoSize = True
        Me.Texto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto1.Location = New System.Drawing.Point(68, 85)
        Me.Texto1.Name = "Texto1"
        Me.Texto1.Size = New System.Drawing.Size(135, 29)
        Me.Texto1.TabIndex = 1
        Me.Texto1.Text = "COLORES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.Texto1)
        Me.Controls.Add(Me.BtColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtColor As System.Windows.Forms.Button
    Friend WithEvents Texto1 As System.Windows.Forms.Label

End Class
