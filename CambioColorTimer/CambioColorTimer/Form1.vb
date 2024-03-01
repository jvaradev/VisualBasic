Public Class Form1
    Dim colorInicial As Color = Color.Black
    Dim colorFinal As Color = Color.Pink
    Dim paso As Integer = 0
    Dim cantPasos As Integer = 100

    Private Sub BtColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtColor.Click
        Timer1.Start()
        BtColor.Visible = False
        If paso = cantPasos Then
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If paso < cantPasos Then
            ' Calcular el color intermedio
            Dim r As Integer = CInt(colorInicial.R + (colorFinal.R - colorInicial.R) * paso / cantPasos)
            Dim g As Integer = CInt(colorInicial.G + (colorFinal.G - colorInicial.G) * paso / cantPasos)
            Dim b As Integer = CInt(colorInicial.B + (colorFinal.B - colorInicial.B) * paso / cantPasos)

            ' Asignar el nuevo color al Texto1
            Texto1.ForeColor = Color.FromArgb(r, g, b)

            ' Incrementar el paso actual
            paso += 1
        Else
            ' Detener el Timer cuando se alcanza el color final
            Timer1.Stop()
            Texto1.ForeColor = Color.Red
            Texto1.Text = "TERMINADO"

            BtColor.Visible = True
            BtColor.Text = "CERRAR"
            BtColor.ForeColor = Color.Red
        End If
    End Sub

End Class
