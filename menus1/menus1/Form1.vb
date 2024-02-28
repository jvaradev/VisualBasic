Public Class Form1

    Dim progresoActual As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.BackColor = Color.Gray
        Button1.Text = "PULSADO"
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If progresoActual < ToolStripProgressBar1.Maximum Then
            progresoActual += 1
            Contador.Text = progresoActual
            ToolStripProgressBar1.Value = progresoActual
            BarraOculta.Value = progresoActual
        End If
    End Sub

    Private Sub ApagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApagarToolStripMenuItem.Click
        Timer1.Stop()
    End Sub

    Private Sub EncenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncenderToolStripMenuItem.Click
        Timer1.Start()
    End Sub
    Private Sub BarProgressToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarProgressToolStripMenuItem.Click
        BarraOculta.Visible = True
        Texto.Visible = False
    End Sub
   
    Private Sub TextoHolaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoHolaToolStripMenuItem.Click
        Texto.Visible = True
        Texto.Text = "Hola"
    End Sub

    Private Sub TextoAdiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoAdiosToolStripMenuItem.Click
        Texto.Visible = True
        Texto.Text = "Adiós"
    End Sub

    Private Sub GGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GGToolStripMenuItem.Click
        If progresoActual < 50 Then
            Contador.ForeColor = Color.Coral
        Else
            Texto.Visible = False
            Contador.Visible = False
        End If
    End Sub

    Private Sub NoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoToolStripMenuItem.Click
        Contador.ForeColor = Color.Black
        Texto.Text = "No"
    End Sub
End Class
