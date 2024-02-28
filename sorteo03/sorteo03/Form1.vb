Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For index As Integer = 1 To 10
            MinBox.Items.Add(index)
            MaxBox.Items.Add(index)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim minimo As Integer
        Dim maximo As Integer
        Dim random As New Random
        Dim resultado As Integer
        minimo = MinBox.Text
        maximo = MaxBox.Text
        If minimo < maximo Then
            resultado = random.Next(minimo, maximo + 1)
            Info.Text = "Resultado sorteo: " & resultado

        End If
    End Sub
End Class
