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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Info = New System.Windows.Forms.Label()
        Me.MinBox = New System.Windows.Forms.ComboBox()
        Me.MaxBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(289, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SORTEO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.Location = New System.Drawing.Point(12, 18)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(289, 17)
        Me.Info.TabIndex = 1
        Me.Info.Text = "Introduce mínimo y máximo y pulsa SORTEO"
        '
        'MinBox
        '
        Me.MinBox.FormattingEnabled = True
        Me.MinBox.Location = New System.Drawing.Point(15, 60)
        Me.MinBox.Name = "MinBox"
        Me.MinBox.Size = New System.Drawing.Size(121, 24)
        Me.MinBox.TabIndex = 2
        '
        'MaxBox
        '
        Me.MaxBox.FormattingEnabled = True
        Me.MaxBox.Location = New System.Drawing.Point(177, 60)
        Me.MaxBox.Name = "MaxBox"
        Me.MaxBox.Size = New System.Drawing.Size(121, 24)
        Me.MaxBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 141)
        Me.Controls.Add(Me.MaxBox)
        Me.Controls.Add(Me.MinBox)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Info As System.Windows.Forms.Label
    Friend WithEvents MinBox As System.Windows.Forms.ComboBox
    Friend WithEvents MaxBox As System.Windows.Forms.ComboBox

End Class
