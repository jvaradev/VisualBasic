Imports System.IO

Public Class Form1
    Dim textoEscribir As String
    Dim rutaArchivo As String = "C:\Users\javiv\Documents\Visual Studio 2010\Projects\Examen\escribirArchivoTexto\texto.txt"

    Private Sub BtCrearDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCrearDoc.Click
        ' Obtener el texto a escribir desde el TextBox
        textoEscribir = TextBox1.Text
        ' Utilizar un bloque Try-Catch para manejar excepciones
        Try
            ' Crear un StreamWriter y abrir el archivo para escritura
            Using swEscritor As New StreamWriter(rutaArchivo, True) ' El segundo parámetro indica si se añadirá al final del archivo (True)
                ' Escribir el contenido en el archivo
                swEscritor.WriteLine(textoEscribir)
            End Using

            Label1.Text = "Documento creado exitosamente."
        Catch ex As Exception
            Label1.ForeColor = Color.Red
            Label1.Text = "Error al crear el archivo"
        End Try
    End Sub

    Private Sub BtLeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLeer.Click
        TextBox1.Clear()
        ' Utilizar un bloque Try-Catch para manejar excepciones
        Try
            ' Verificar si el archivo existe antes de intentar leerlo
            If File.Exists(rutaArchivo) Then
                ' Crear un StreamReader y abrir el archivo para lectura
                Using srLector As New StreamReader(rutaArchivo)
                    ' Leer el contenido completo del archivo y mostrarlo en un TextBox
                    TextBox1.Text = srLector.ReadToEnd()
                End Using

                Label1.Text = "Documento leído exitosamente."
            Else
                Label1.ForeColor = Color.Red
                Label1.Text = "El documento no existe."
            End If
        Catch ex As Exception
            Label1.ForeColor = Color.Red
            Label1.Text = "Error al leer el documento."
        End Try
    End Sub
End Class
