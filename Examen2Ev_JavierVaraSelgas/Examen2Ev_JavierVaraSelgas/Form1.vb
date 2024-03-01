Public Class Form1

    Dim pasoRojo As Integer = 0
    Dim pasoAzul As Integer = 0
    Dim pasoVerde As Integer = 0
    Dim incrementoRojo As Integer = 1
    Dim incrementoAzul As Integer = 1
    Dim incrementoVerde As Integer = 1

    Private Sub BtRojo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRojo.Click
        If BtRojo.Text = "ROJO - START" Then
            BtRojo.Text = "ROJO - STOP"
            TimerRojo.Start()
            TimerVerde.Stop()
            TimerAzul.Stop()
        Else
            BtRojo.Text = "ROJO - START"
            TimerRojo.Stop()
            TimerVerde.Stop()
            TimerAzul.Stop()
        End If
    End Sub


    Private Sub BtVerde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVerde.Click
        If BtVerde.Text = "VERDE - START" Then
            BtVerde.Text = "VERDE - STOP"
            TimerRojo.Stop()
            TimerVerde.Start()
            TimerAzul.Stop()
        Else
            BtVerde.Text = "VERDE - START"
            TimerRojo.Stop()
            TimerVerde.Stop()
            TimerAzul.Stop()
        End If
    End Sub

    Private Sub BtAzul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAzul.Click
        If BtAzul.Text = "AZUL - START" Then
            BtAzul.Text = "AZUL - STOP"
            TimerRojo.Stop()
            TimerVerde.Stop()
            TimerAzul.Start()
        Else
            BtAzul.Text = "AZUL - START"
            TimerRojo.Stop()
            TimerVerde.Stop()
            TimerAzul.Stop()
        End If
    End Sub

    Private Sub BtSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSalir.Click
        Me.Close()
    End Sub

    Private Sub TimerRojo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRojo.Tick
        pasoRojo += incrementoRojo
        TextRojo.Text = pasoRojo.ToString()

        If pasoRojo >= 255 Or pasoRojo <= 0 Then
            incrementoRojo *= -1
        End If

        Dim colorFondo As Color = Color.FromArgb(TextRojo.Text, TextVerde.Text, TextAzul.Text)
        Me.BackColor = colorFondo
    End Sub

    Private Sub TimerAzul_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAzul.Tick
        pasoAzul += incrementoAzul
        TextAzul.Text = pasoAzul.ToString()

        If pasoAzul >= 255 Or pasoAzul <= 0 Then
            incrementoAzul *= -1
        End If

        Dim colorFondo As Color = Color.FromArgb(TextRojo.Text, TextVerde.Text, TextAzul.Text)
        Me.BackColor = colorFondo
    End Sub

    Private Sub TimerVerde_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerVerde.Tick
        pasoVerde += incrementoVerde
        TextVerde.Text = pasoVerde.ToString()

        If pasoVerde >= 255 Or pasoVerde <= 0 Then
            incrementoVerde *= -1
        End If

        Dim colorFondo As Color = Color.FromArgb(TextRojo.Text, TextVerde.Text, TextAzul.Text)
        Me.BackColor = colorFondo
    End Sub

End Class
