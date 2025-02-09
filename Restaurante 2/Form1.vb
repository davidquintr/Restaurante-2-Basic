Public Class Form1
    Private imageList As ArrayList

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageList = New ArrayList()

        ' Agregar imágenes al ArrayList
        imageList.Add(New Bitmap(My.Resources.Placeholder))
        imageList.Add(New Bitmap(My.Resources._1))
        imageList.Add(New Bitmap(My.Resources._2))
        imageList.Add(New Bitmap(My.Resources._3))
        imageList.Add(New Bitmap(My.Resources._4))
        imageList.Add(New Bitmap(My.Resources._5))

        ' Agregar ítems al ComboBox para pruebas

        ' Mostrar la primera imagen por defecto
        pboxMesero.Image = CType(imageList(0), Bitmap)
        pboxMesero.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Puedes agregar funcionalidad aquí si es necesario
    End Sub

    Private Sub cboxMesero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMesero.SelectedIndexChanged
        ' Verificar que haya una selección válida
        If cboxMesero.SelectedIndex >= 0 AndAlso cboxMesero.SelectedIndex < imageList.Count Then
            pboxMesero.Image = CType(imageList.Item(cboxMesero.SelectedIndex + 1), Bitmap)
        End If
    End Sub
End Class
