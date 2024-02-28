Public Class Form1

    Dim letra As String = "a"
    Dim num As Integer = 5

    Private Sub BtSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSalir.Click
        Me.Close()
    End Sub

    Private Sub BtLetras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLetras.Click
        Dim cantidad As Integer

        If Integer.TryParse(BoxCant.Text, cantidad) Then

            For i As Integer = 1 To cantidad
                TextBox1.Text += letra
            Next i
        Else
            MessageBox.Show("Ingrese un valor válido para la cantidad.")
        End If
    End Sub

    Private Sub BtNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNum.Click
        Dim cantidad As Integer

        If Integer.TryParse(BoxCant.Text, cantidad) Then

            For i As Integer = 1 To cantidad
                TextBox1.Text += num.ToString
            Next i
        Else
            MessageBox.Show("Ingrese un valor válido para la cantidad.")
        End If
    End Sub

    Private Sub BtColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtColor.Click
        Dim rand As New Random()
        Dim color As Color = color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
        TextBox1.BackColor = color
    End Sub
End Class
