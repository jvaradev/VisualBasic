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
        Me.Info = New System.Windows.Forms.Label()
        Me.Sorteo = New System.Windows.Forms.Button()
        Me.PrimerBox = New System.Windows.Forms.TextBox()
        Me.SegBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.Location = New System.Drawing.Point(13, 10)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(265, 17)
        Me.Info.TabIndex = 0
        Me.Info.Text = "Introduce dos números y pulsa SORTEO"
        '
        'Sorteo
        '
        Me.Sorteo.Location = New System.Drawing.Point(16, 76)
        Me.Sorteo.Name = "Sorteo"
        Me.Sorteo.Size = New System.Drawing.Size(262, 23)
        Me.Sorteo.TabIndex = 1
        Me.Sorteo.Text = "SORTEO"
        Me.Sorteo.UseVisualStyleBackColor = True
        '
        'PrimerBox
        '
        Me.PrimerBox.Location = New System.Drawing.Point(17, 39)
        Me.PrimerBox.Name = "PrimerBox"
        Me.PrimerBox.Size = New System.Drawing.Size(120, 22)
        Me.PrimerBox.TabIndex = 2
        Me.PrimerBox.Text = "primer numero"
        Me.PrimerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SegBox
        '
        Me.SegBox.Location = New System.Drawing.Point(153, 39)
        Me.SegBox.Name = "SegBox"
        Me.SegBox.Size = New System.Drawing.Size(125, 22)
        Me.SegBox.TabIndex = 3
        Me.SegBox.Text = "segundo numero"
        Me.SegBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 104)
        Me.Controls.Add(Me.SegBox)
        Me.Controls.Add(Me.PrimerBox)
        Me.Controls.Add(Me.Sorteo)
        Me.Controls.Add(Me.Info)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Info As System.Windows.Forms.Label
    Friend WithEvents Sorteo As System.Windows.Forms.Button
    Friend WithEvents PrimerBox As System.Windows.Forms.TextBox
    Friend WithEvents SegBox As System.Windows.Forms.TextBox

End Class
