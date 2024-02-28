Public Class Form1

    Dim contador As Integer = 20

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If contador >= 0 Then
            Reloj.Text = contador.ToString()
            contador -= 1
        Else
            Timer1.Stop() ' Detener el temporizador cuando alcanza 0
        End If
    End Sub

End Class
