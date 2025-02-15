Imports System.Xml

Public Class Form1
    Private imageList As ArrayList
    Private platillosList As List(Of Platillo)

    Public Class Platillo
        Public Property Nombre As String
        Public Property Precio As Integer

        Public Sub New(nombre As String, precio As Integer)
            Me.Nombre = nombre
            Me.Precio = precio
        End Sub

    End Class

    Public Function ObtenerPlatilloDesdeString(platilloString As String) As Platillo
        Dim partes As String() = platilloString.Split(" - ")

        If partes.Length = 2 Then
            Dim nombre As String = partes(0)
            Dim precio As Integer

            If Integer.TryParse(partes(1).Replace("$", ""), precio) Then
                For Each platillo As Platillo In platillosList
                    If platillo.Nombre = nombre AndAlso platillo.Precio = precio Then
                        Return platillo
                    End If
                Next
            End If
        End If

        Return Nothing
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageList = New ArrayList()
        platillosList = New List(Of Platillo)()

        ' Agregar imágenes al ArrayList
        imageList.Add(New Bitmap(My.Resources.Placeholder))
        imageList.Add(New Bitmap(My.Resources._1))
        imageList.Add(New Bitmap(My.Resources._2))
        imageList.Add(New Bitmap(My.Resources._3))
        imageList.Add(New Bitmap(My.Resources._4))
        imageList.Add(New Bitmap(My.Resources._5))


        pboxMesero.Image = CType(imageList(0), Bitmap)
        pboxMesero.SizeMode = PictureBoxSizeMode.StretchImage

        Dim fechaAct As Date = Date.Today
        tboxDate.Text = fechaAct.ToShortDateString()

        ' Agregar platillos a la lista
        platillosList.Add(New Platillo("Tacos", 50))
        platillosList.Add(New Platillo("Burritos", 75))
        platillosList.Add(New Platillo("Quesadillas", 45))
        platillosList.Add(New Platillo("Enchiladas", 60))
        platillosList.Add(New Platillo("Sopes", 40))

        ' Opcional: Mostrar los platillos en un ListBox (si tienes uno en el formulario)
        For Each platillo As Platillo In platillosList
            lboxPlatillos.Items.Add($"{platillo.Nombre} - ${platillo.Precio}")
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Puedes agregar funcionalidad aquí si es necesario
    End Sub

    Private Sub cboxMesero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMesero.SelectedIndexChanged
        If cboxMesero.SelectedIndex >= 0 AndAlso cboxMesero.SelectedIndex < imageList.Count Then
            pboxMesero.Image = CType(imageList.Item(cboxMesero.SelectedIndex + 1), Bitmap)
        End If
    End Sub

    Private Sub tboxTarjeta_TextChanged(sender As Object, e As EventArgs) Handles tboxTarjeta.TextChanged

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If lboxPlatillos.SelectedIndex < 0 Or lboxPlatillos.SelectedIndex >= platillosList.Count Then
            Return
        End If

        Dim platillo = platillosList.Item(lboxPlatillos.SelectedIndex)

        lboxPedidos.Items.Add($"{platillo.Nombre} - ${platillo.Precio}")

        lblTotal.Text = obtenerTotal(False)
        lblTotalIVA.Text = obtenerTotal(True)
    End Sub


    Private Function obtenerTotal(impuestos As Boolean)
        Dim total = 0

        For Each platillo In lboxPedidos.Items
            Dim own = ObtenerPlatilloDesdeString(platillo.ToString())
            total += own.Precio
        Next

        If (impuestos) Then
            Return total * 1.15
        End If

        Return total
    End Function


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lboxPedidos.SelectedIndex < 0 Or lboxPedidos.SelectedIndex >= lboxPedidos.Items.Count() Then
            Return
        End If

        lboxPedidos.Items.RemoveAt(lboxPedidos.SelectedIndex)
        lblTotal.Text = obtenerTotal(False)
        lblTotalIVA.Text = obtenerTotal(True)
    End Sub


    Private Sub btnNewPedido_Click(sender As Object, e As EventArgs) Handles btnNewPedido.Click
        lboxPedidos.Items.Clear()
        cboxMesero.SelectedIndex = -1
        pboxMesero.Image = CType(imageList.Item(0), Bitmap)

        cboxMesa.SelectedIndex = -1
        tboxNombre.Text = String.Empty
        tboxTarjeta.Text = String.Empty
        lblTotal.Text = "0"
        lblTotalIVA.Text = "0"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            tboxTarjeta.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            tboxTarjeta.Enabled = False
        End If
    End Sub

    Private Sub btnOrderPedido_Click(sender As Object, e As EventArgs) Handles btnOrderPedido.Click
        If (cboxMesero.SelectedIndex = -1) Then
            MessageBox.Show("No hay un mesero seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If (cboxMesa.SelectedIndex = -1) Then
            MessageBox.Show("No hay una mesa seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If (tboxNombre.Text = String.Empty) Then
            MessageBox.Show("No hay un nombre para el cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If (tboxDate.Text = String.Empty) Then
            MessageBox.Show("No hay una fecha establecida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If (RadioButton2.Checked And tboxTarjeta.Text = String.Empty) Then
            MessageBox.Show("Pago con tarjeta, necesita escribir la tarjeta del cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If (lboxPedidos.Items.Count() < 1) Then
            MessageBox.Show("No se ha agregado ningún platillo al pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim pago As String = If(RadioButton2.Checked, $"Pago con tarjeta: ${tboxTarjeta.Text}", "Pago en Efectivo")

        Dim platillos As String = String.Join(Environment.NewLine, lboxPedidos.Items.Cast(Of Object).Select(Function(item) item.ToString()))

        MessageBox.Show($"Resumen del pedido {Environment.NewLine} 
            Mesero: {cboxMesero.SelectedItem}{Environment.NewLine} 
            Mesa: {cboxMesa.SelectedItem}{Environment.NewLine}{Environment.NewLine}
            Fecha del Pedido: {tboxDate.Text}{Environment.NewLine}
            Nombre del cliente: {tboxNombre.Text}{Environment.NewLine}
            {pago}{Environment.NewLine}
            Platillos Ordenados:{Environment.NewLine}
            {platillos}{Environment.NewLine}{Environment.NewLine}
            Total: {lblTotal.Text}{Environment.NewLine} 
            Total con IVA: {lblTotalIVA.Text}", "Detalles del Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
