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
        Me.BtRojo = New System.Windows.Forms.Button()
        Me.BtAzul = New System.Windows.Forms.Button()
        Me.BtVerde = New System.Windows.Forms.Button()
        Me.TextRojo = New System.Windows.Forms.TextBox()
        Me.TextVerde = New System.Windows.Forms.TextBox()
        Me.TextAzul = New System.Windows.Forms.TextBox()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.TimerRojo = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAzul = New System.Windows.Forms.Timer(Me.components)
        Me.TimerVerde = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BtRojo
        '
        Me.BtRojo.Location = New System.Drawing.Point(24, 45)
        Me.BtRojo.Name = "BtRojo"
        Me.BtRojo.Size = New System.Drawing.Size(139, 41)
        Me.BtRojo.TabIndex = 0
        Me.BtRojo.Text = "ROJO - START"
        Me.BtRojo.UseVisualStyleBackColor = True
        '
        'BtAzul
        '
        Me.BtAzul.Location = New System.Drawing.Point(387, 45)
        Me.BtAzul.Name = "BtAzul"
        Me.BtAzul.Size = New System.Drawing.Size(139, 41)
        Me.BtAzul.TabIndex = 1
        Me.BtAzul.Text = "AZUL - START"
        Me.BtAzul.UseVisualStyleBackColor = True
        '
        'BtVerde
        '
        Me.BtVerde.Location = New System.Drawing.Point(208, 45)
        Me.BtVerde.Name = "BtVerde"
        Me.BtVerde.Size = New System.Drawing.Size(139, 41)
        Me.BtVerde.TabIndex = 2
        Me.BtVerde.Text = "VERDE - START"
        Me.BtVerde.UseVisualStyleBackColor = True
        '
        'TextRojo
        '
        Me.TextRojo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextRojo.Location = New System.Drawing.Point(24, 138)
        Me.TextRojo.Name = "TextRojo"
        Me.TextRojo.ReadOnly = True
        Me.TextRojo.Size = New System.Drawing.Size(139, 30)
        Me.TextRojo.TabIndex = 3
        Me.TextRojo.Text = "0"
        Me.TextRojo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextVerde
        '
        Me.TextVerde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextVerde.Location = New System.Drawing.Point(208, 138)
        Me.TextVerde.Name = "TextVerde"
        Me.TextVerde.ReadOnly = True
        Me.TextVerde.Size = New System.Drawing.Size(139, 30)
        Me.TextVerde.TabIndex = 4
        Me.TextVerde.Text = "0"
        Me.TextVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextAzul
        '
        Me.TextAzul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAzul.Location = New System.Drawing.Point(387, 138)
        Me.TextAzul.Name = "TextAzul"
        Me.TextAzul.ReadOnly = True
        Me.TextAzul.Size = New System.Drawing.Size(139, 30)
        Me.TextAzul.TabIndex = 6
        Me.TextAzul.Text = "0"
        Me.TextAzul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(24, 218)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(502, 41)
        Me.BtSalir.TabIndex = 7
        Me.BtSalir.Text = "SALIR"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'TimerRojo
        '
        Me.TimerRojo.Interval = 10
        '
        'TimerAzul
        '
        Me.TimerAzul.Interval = 10
        '
        'TimerVerde
        '
        Me.TimerVerde.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(553, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.TextAzul)
        Me.Controls.Add(Me.TextVerde)
        Me.Controls.Add(Me.TextRojo)
        Me.Controls.Add(Me.BtVerde)
        Me.Controls.Add(Me.BtAzul)
        Me.Controls.Add(Me.BtRojo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Examen DM2E Javier Vara Selgas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtRojo As System.Windows.Forms.Button
    Friend WithEvents BtAzul As System.Windows.Forms.Button
    Friend WithEvents BtVerde As System.Windows.Forms.Button
    Friend WithEvents TextRojo As System.Windows.Forms.TextBox
    Friend WithEvents TextVerde As System.Windows.Forms.TextBox
    Friend WithEvents TextAzul As System.Windows.Forms.TextBox
    Friend WithEvents BtSalir As System.Windows.Forms.Button
    Friend WithEvents TimerRojo As System.Windows.Forms.Timer
    Friend WithEvents TimerAzul As System.Windows.Forms.Timer
    Friend WithEvents TimerVerde As System.Windows.Forms.Timer

End Class
