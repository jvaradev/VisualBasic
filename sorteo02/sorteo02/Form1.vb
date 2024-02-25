Public Class Form1

    Private Sub PrimerBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimerBox.TextChanged, SegBox.TextChanged
        Dim valorMin As Integer
        Dim valorMax As Integer

        If Not Integer.TryParse(PrimerBox.Text, valorMin) OrElse Not Integer.TryParse(SegBox.Text, valorMax) Then
            Sorteo.Enabled = False
        Else
            Sorteo.Enabled = True
        End If
    End Sub

    Private Sub Sorteo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sorteo.Click
        Dim minValor As Integer
        Dim maxValor As Integer
        Dim random As New Random()
        Dim resultado As Integer

        ' Asegúrate de que los valores ingresados en los cuadros de texto son números antes de asignarlos.
        If Integer.TryParse(PrimerBox.Text, minValor) AndAlso Integer.TryParse(SegBox.Text, maxValor) Then
            ' Verifica que el valor mínimo no sea mayor o igual al valor máximo.
            If minValor < maxValor Then
                resultado = random.Next(minValor, maxValor + 1) ' El rango es [minValor, maxValor], por eso se suma 1.
                Info.Text = "Resultado sorteo: " & resultado
            End If
        End If
    End Sub
End Class
