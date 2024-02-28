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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EncenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarProgressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextoHolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextoAdiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Texto = New System.Windows.Forms.Label()
        Me.Contador = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BarraOculta = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MenuStrip1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-1, -2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(330, 61)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncenderToolStripMenuItem, Me.ApagarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EncenderToolStripMenuItem
        '
        Me.EncenderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarProgressToolStripMenuItem, Me.TextoHolaToolStripMenuItem, Me.TextoAdiosToolStripMenuItem})
        Me.EncenderToolStripMenuItem.Name = "EncenderToolStripMenuItem"
        Me.EncenderToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.EncenderToolStripMenuItem.Text = "Encender"
        '
        'BarProgressToolStripMenuItem
        '
        Me.BarProgressToolStripMenuItem.Name = "BarProgressToolStripMenuItem"
        Me.BarProgressToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.BarProgressToolStripMenuItem.Text = "BarProgress"
        '
        'TextoHolaToolStripMenuItem
        '
        Me.TextoHolaToolStripMenuItem.Name = "TextoHolaToolStripMenuItem"
        Me.TextoHolaToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.TextoHolaToolStripMenuItem.Text = "Texto:Hola"
        '
        'TextoAdiosToolStripMenuItem
        '
        Me.TextoAdiosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GGToolStripMenuItem, Me.NoToolStripMenuItem})
        Me.TextoAdiosToolStripMenuItem.Name = "TextoAdiosToolStripMenuItem"
        Me.TextoAdiosToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.TextoAdiosToolStripMenuItem.Text = "Texto:Adios"
        '
        'GGToolStripMenuItem
        '
        Me.GGToolStripMenuItem.Name = "GGToolStripMenuItem"
        Me.GGToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.GGToolStripMenuItem.Text = "GG"
        '
        'NoToolStripMenuItem
        '
        Me.NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        Me.NoToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.NoToolStripMenuItem.Text = "No"
        '
        'ApagarToolStripMenuItem
        '
        Me.ApagarToolStripMenuItem.Name = "ApagarToolStripMenuItem"
        Me.ApagarToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.ApagarToolStripMenuItem.Text = "Apagar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripProgressBar1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(330, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 22)
        '
        'Texto
        '
        Me.Texto.AutoSize = True
        Me.Texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto.Location = New System.Drawing.Point(23, 105)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(102, 39)
        Me.Texto.TabIndex = 1
        Me.Texto.Text = "Texto"
        '
        'Contador
        '
        Me.Contador.AutoSize = True
        Me.Contador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contador.Location = New System.Drawing.Point(225, 105)
        Me.Contador.Name = "Contador"
        Me.Contador.Size = New System.Drawing.Size(36, 39)
        Me.Contador.TabIndex = 2
        Me.Contador.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(80, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "INICIAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BarraOculta
        '
        Me.BarraOculta.Location = New System.Drawing.Point(13, 76)
        Me.BarraOculta.Name = "BarraOculta"
        Me.BarraOculta.Size = New System.Drawing.Size(301, 23)
        Me.BarraOculta.TabIndex = 4
        Me.BarraOculta.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 216)
        Me.Controls.Add(Me.BarraOculta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Contador)
        Me.Controls.Add(Me.Texto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EncenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarProgressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextoHolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextoAdiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Texto As System.Windows.Forms.Label
    Friend WithEvents Contador As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BarraOculta As System.Windows.Forms.ProgressBar

End Class
