Public Class Form1

    Private Sub MinBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MinBox.Validating
        Dim minValor As Integer

        If Not Integer.TryParse(MinBox.Text, minValor) Then
            Result.ForeColor = Color.Red
            Result.Text = "Valores no válidos."
        End If
    End Sub

    Private Sub MaxBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MaxBox.Validating
        Dim maxValor As Integer
        Dim minValor As Integer

        If Integer.TryParse(MinBox.Text, minValor) AndAlso Integer.TryParse(MaxBox.Text, maxValor) Then
            If minValor > maxValor Then
                Result.ForeColor = Color.Red
                Result.Text = "El mínimo debe ser menor que el máximo."
            End If
        End If

        If Not Integer.TryParse(MaxBox.Text, maxValor) Then
            Result.ForeColor = Color.Red
            Result.Text = "Valores no válidos."
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim minValor As Integer
        Dim maxValor As Integer
        Dim random As New Random()
        Dim resultado As Integer

        If Integer.TryParse(MinBox.Text, minValor) AndAlso Integer.TryParse(MaxBox.Text, maxValor) Then
            If minValor < maxValor Then
                resultado = random.Next(minValor, maxValor + 1)
                Result.ForeColor = Color.Black
                Result.Text = "Resultado sorteo: " & resultado
            Else
                Result.ForeColor = Color.Red
                Result.Text = "El mínimo debe ser menor que el máximo."
            End If
        Else
            Result.ForeColor = Color.Red
            Result.Text = "Valores no válidos."
        End If
    End Sub
End Class
