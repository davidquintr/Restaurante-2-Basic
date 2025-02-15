<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pboxMesero = New PictureBox()
        GroupBox1 = New GroupBox()
        cboxMesa = New ComboBox()
        lblMesa = New Label()
        lblMesero = New Label()
        cboxMesero = New ComboBox()
        GroupBox2 = New GroupBox()
        btnAgregar = New Button()
        tboxDate = New TextBox()
        tboxTarjeta = New TextBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label4 = New Label()
        lboxPlatillos = New ListBox()
        Label3 = New Label()
        tboxNombre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lboxPedidos = New ListBox()
        Label5 = New Label()
        Label6 = New Label()
        lblTotal = New Label()
        Label8 = New Label()
        lblTotalIVA = New Label()
        btnRemove = New Button()
        btnNewPedido = New Button()
        btnOrderPedido = New Button()
        CType(pboxMesero, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pboxMesero
        ' 
        pboxMesero.BackgroundImage = My.Resources.Resources.Placeholder
        pboxMesero.BackgroundImageLayout = ImageLayout.Stretch
        pboxMesero.Location = New Point(12, 12)
        pboxMesero.Name = "pboxMesero"
        pboxMesero.Size = New Size(219, 166)
        pboxMesero.TabIndex = 0
        pboxMesero.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cboxMesa)
        GroupBox1.Controls.Add(lblMesa)
        GroupBox1.Controls.Add(lblMesero)
        GroupBox1.Controls.Add(cboxMesero)
        GroupBox1.Location = New Point(12, 184)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(219, 138)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Atención"
        ' 
        ' cboxMesa
        ' 
        cboxMesa.FormattingEnabled = True
        cboxMesa.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboxMesa.Location = New Point(28, 88)
        cboxMesa.Name = "cboxMesa"
        cboxMesa.Size = New Size(163, 23)
        cboxMesa.TabIndex = 8
        ' 
        ' lblMesa
        ' 
        lblMesa.AutoSize = True
        lblMesa.Location = New Point(28, 70)
        lblMesa.Name = "lblMesa"
        lblMesa.Size = New Size(35, 15)
        lblMesa.TabIndex = 7
        lblMesa.Text = "Mesa"
        ' 
        ' lblMesero
        ' 
        lblMesero.AutoSize = True
        lblMesero.Location = New Point(28, 24)
        lblMesero.Name = "lblMesero"
        lblMesero.Size = New Size(46, 15)
        lblMesero.TabIndex = 6
        lblMesero.Text = "Mesero"
        ' 
        ' cboxMesero
        ' 
        cboxMesero.FormattingEnabled = True
        cboxMesero.Items.AddRange(New Object() {"Juan Daniel", "Armando", "Carlos", "Facundo", "Travesaño"})
        cboxMesero.Location = New Point(28, 42)
        cboxMesero.Name = "cboxMesero"
        cboxMesero.Size = New Size(163, 23)
        cboxMesero.TabIndex = 5
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnAgregar)
        GroupBox2.Controls.Add(tboxDate)
        GroupBox2.Controls.Add(tboxTarjeta)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(lboxPlatillos)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(tboxNombre)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(236, 12)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(553, 178)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pedido"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(341, 138)
        btnAgregar.Margin = New Padding(3, 2, 3, 2)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(206, 22)
        btnAgregar.TabIndex = 20
        btnAgregar.Text = "Agregar al Pedido"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' tboxDate
        ' 
        tboxDate.Location = New Point(188, 41)
        tboxDate.Margin = New Padding(3, 2, 3, 2)
        tboxDate.Name = "tboxDate"
        tboxDate.Size = New Size(180, 23)
        tboxDate.TabIndex = 19
        ' 
        ' tboxTarjeta
        ' 
        tboxTarjeta.Enabled = False
        tboxTarjeta.Location = New Point(371, 41)
        tboxTarjeta.Margin = New Padding(3, 2, 3, 2)
        tboxTarjeta.Name = "tboxTarjeta"
        tboxTarjeta.Size = New Size(177, 23)
        tboxTarjeta.TabIndex = 18
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(342, 85)
        RadioButton2.Margin = New Padding(3, 2, 3, 2)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(60, 19)
        RadioButton2.TabIndex = 16
        RadioButton2.Text = "Tarjeta"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(408, 85)
        RadioButton1.Margin = New Padding(3, 2, 3, 2)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(67, 19)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "Efectivo"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 12
        Label4.Text = "Platillos"
        ' 
        ' lboxPlatillos
        ' 
        lboxPlatillos.FormattingEnabled = True
        lboxPlatillos.ItemHeight = 15
        lboxPlatillos.Location = New Point(5, 81)
        lboxPlatillos.Margin = New Padding(3, 2, 3, 2)
        lboxPlatillos.Name = "lboxPlatillos"
        lboxPlatillos.Size = New Size(331, 79)
        lboxPlatillos.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(371, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 10
        Label3.Text = "Tarjeta"
        ' 
        ' tboxNombre
        ' 
        tboxNombre.Location = New Point(5, 41)
        tboxNombre.Margin = New Padding(3, 2, 3, 2)
        tboxNombre.Name = "tboxNombre"
        tboxNombre.Size = New Size(178, 23)
        tboxNombre.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(188, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 7
        Label1.Text = "Fecha"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nombre"
        ' 
        ' lboxPedidos
        ' 
        lboxPedidos.FormattingEnabled = True
        lboxPedidos.ItemHeight = 15
        lboxPedidos.Location = New Point(235, 213)
        lboxPedidos.Margin = New Padding(3, 2, 3, 2)
        lboxPedidos.Name = "lboxPedidos"
        lboxPedidos.Size = New Size(331, 109)
        lboxPedidos.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(235, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 15)
        Label5.TabIndex = 15
        Label5.Text = "Pedidos en Cola"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label6.Location = New Point(572, 214)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 15)
        Label6.TabIndex = 15
        Label6.Text = "Total SIN IVA"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(572, 229)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(28, 15)
        lblTotal.TabIndex = 16
        lblTotal.Text = "0.00"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label8.Location = New Point(699, 211)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 15)
        Label8.TabIndex = 17
        Label8.Text = "Total CON IVA"
        ' 
        ' lblTotalIVA
        ' 
        lblTotalIVA.AutoSize = True
        lblTotalIVA.Location = New Point(699, 229)
        lblTotalIVA.Name = "lblTotalIVA"
        lblTotalIVA.Size = New Size(28, 15)
        lblTotalIVA.TabIndex = 18
        lblTotalIVA.Text = "0.00"
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(572, 300)
        btnRemove.Margin = New Padding(3, 2, 3, 2)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(216, 22)
        btnRemove.TabIndex = 19
        btnRemove.Text = "Remover del Pedido"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnNewPedido
        ' 
        btnNewPedido.Location = New Point(572, 276)
        btnNewPedido.Margin = New Padding(3, 2, 3, 2)
        btnNewPedido.Name = "btnNewPedido"
        btnNewPedido.Size = New Size(216, 22)
        btnNewPedido.TabIndex = 21
        btnNewPedido.Text = "Reiniciar Pedido"
        btnNewPedido.UseVisualStyleBackColor = True
        ' 
        ' btnOrderPedido
        ' 
        btnOrderPedido.Location = New Point(572, 250)
        btnOrderPedido.Margin = New Padding(3, 2, 3, 2)
        btnOrderPedido.Name = "btnOrderPedido"
        btnOrderPedido.Size = New Size(216, 22)
        btnOrderPedido.TabIndex = 22
        btnOrderPedido.Text = "Terminar Pedido"
        btnOrderPedido.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 338)
        Controls.Add(btnOrderPedido)
        Controls.Add(btnNewPedido)
        Controls.Add(btnRemove)
        Controls.Add(lblTotalIVA)
        Controls.Add(Label8)
        Controls.Add(lblTotal)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lboxPedidos)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(pboxMesero)
        Name = "Form1"
        Text = "Form1"
        CType(pboxMesero, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Private pboxMesero As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboxMesa As ComboBox
    Friend WithEvents lblMesa As Label
    Friend WithEvents lblMesero As Label
    Friend WithEvents cboxMesero As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tboxFecha As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Private lboxPlatillos As ListBox
    Friend WithEvents tboxNombre As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ListBox2 As ListBox
    Private lboxPedidos As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Private lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalIVA As Label
    Friend WithEvents tboxTarjeta As TextBox
    Friend WithEvents tboxDate As TextBox
    Private WithEvents btnAgregar As Button
    Private WithEvents btnRemove As Button
    Private WithEvents btnOrderPedido As Button
    Private WithEvents btnNewPedido As Button
End Class
