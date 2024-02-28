Public Class Form1

    Dim progresoActual As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If progresoActual < ProgressBar1.Maximum Then
            progresoActual += 1
            ProgressBar1.Value = progresoActual
        Else
            Timer1.Stop() ' Detener el temporizador cuando alcanza el máximo
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        progresoActual = 0
        ProgressBar1.Value = progresoActual
        Timer1.Start() ' Iniciar el temporizador cuando se hace clic en el botón
    End Sub

End Class

