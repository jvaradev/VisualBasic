Public Class Form1
    Dim valor1 As Double = 0
    Dim valor2 As Double = 0
    Dim operador As String

    Private Sub Numerico_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt0.Click, Bt1.Click, Bt2.Click, Bt3.Click, Bt4.Click, Bt5.Click, Bt6.Click, Bt7.Click, Bt8.Click, Bt9.Click
        Dim boton As Button = DirectCast(sender, Button)

        If TextBox1.Text = "0" Then
            TextBox1.Clear()
        End If

        TextBox1.Text += boton.Text
    End Sub

    Private Sub BtC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtC.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub BtDot_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtDot.Click
        If Not TextBox1.Text.Contains(",") Then
            TextBox1.Text += ","
        End If
    End Sub

    Private Sub Operacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtSuma.Click, BtResta.Click, BtMult.Click, BtDiv.Click
        Dim boton As Button = DirectCast(sender, Button)

        If Double.TryParse(TextBox1.Text, valor1) Then
            LastResult.Text = valor1.ToString()
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If

        TextBox1.Clear()
        operador = boton.Text
    End Sub

    Private Sub BtIgual_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtIgual.Click
        If Double.TryParse(TextBox1.Text, valor2) Then
            Select Case operador
                Case "+"
                    TextBox1.Clear()
                    LastResult.Text = (valor1 + valor2).ToString()
                Case "-"
                    TextBox1.Clear()
                    LastResult.Text = (valor1 - valor2).ToString()
                Case "x"
                    TextBox1.Clear()
                    LastResult.Text = (valor1 * valor2).ToString()
                Case "/"
                    If valor2 <> 0 Then
                        TextBox1.Clear()
                        LastResult.Text = (valor1 / valor2).ToString()
                    Else
                        TextBox1.Clear()
                        LastResult.Text = "ERROR"
                    End If
                Case Else
                    MessageBox.Show("Operador no válido.")
            End Select

        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

End Class