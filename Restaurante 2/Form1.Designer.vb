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
        tboxTarjeta = New TextBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        btnNuevoPedido = New Button()
        btnOrdenarPedido = New Button()
        Label4 = New Label()
        lboxPlatillos = New ListBox()
        Label3 = New Label()
        tboxNombre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lboxPedidos = New ListBox()
        Label5 = New Label()
        btnRemoverPedido = New Button()
        Label6 = New Label()
        lblTotal = New Label()
        Label8 = New Label()
        lblTotalIVA = New Label()
        tboxDate = New TextBox()
        CType(pboxMesero, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pboxMesero
        ' 
        pboxMesero.BackgroundImage = My.Resources.Resources.Placeholder
        pboxMesero.BackgroundImageLayout = ImageLayout.Stretch
        pboxMesero.Location = New Point(14, 16)
        pboxMesero.Margin = New Padding(3, 4, 3, 4)
        pboxMesero.Name = "pboxMesero"
        pboxMesero.Size = New Size(250, 222)
        pboxMesero.TabIndex = 0
        pboxMesero.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cboxMesa)
        GroupBox1.Controls.Add(lblMesa)
        GroupBox1.Controls.Add(lblMesero)
        GroupBox1.Controls.Add(cboxMesero)
        GroupBox1.Location = New Point(14, 245)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 179)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Atención"
        ' 
        ' cboxMesa
        ' 
        cboxMesa.FormattingEnabled = True
        cboxMesa.Items.AddRange(New Object() {"Juan Daniel", "Armando", "Carlos", "Facundo", "Travesaño"})
        cboxMesa.Location = New Point(32, 118)
        cboxMesa.Margin = New Padding(3, 4, 3, 4)
        cboxMesa.Name = "cboxMesa"
        cboxMesa.Size = New Size(186, 28)
        cboxMesa.TabIndex = 8
        ' 
        ' lblMesa
        ' 
        lblMesa.AutoSize = True
        lblMesa.Location = New Point(32, 94)
        lblMesa.Name = "lblMesa"
        lblMesa.Size = New Size(44, 20)
        lblMesa.TabIndex = 7
        lblMesa.Text = "Mesa"
        ' 
        ' lblMesero
        ' 
        lblMesero.AutoSize = True
        lblMesero.Location = New Point(32, 32)
        lblMesero.Name = "lblMesero"
        lblMesero.Size = New Size(58, 20)
        lblMesero.TabIndex = 6
        lblMesero.Text = "Mesero"
        ' 
        ' cboxMesero
        ' 
        cboxMesero.FormattingEnabled = True
        cboxMesero.Items.AddRange(New Object() {"Juan Daniel", "Armando", "Carlos", "Facundo", "Travesaño"})
        cboxMesero.Location = New Point(32, 56)
        cboxMesero.Margin = New Padding(3, 4, 3, 4)
        cboxMesero.Name = "cboxMesero"
        cboxMesero.Size = New Size(186, 28)
        cboxMesero.TabIndex = 5
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(tboxDate)
        GroupBox2.Controls.Add(tboxTarjeta)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Controls.Add(btnNuevoPedido)
        GroupBox2.Controls.Add(btnOrdenarPedido)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(lboxPlatillos)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(tboxNombre)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(270, 16)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(632, 222)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pedido"
        ' 
        ' tboxTarjeta
        ' 
        tboxTarjeta.Location = New Point(424, 55)
        tboxTarjeta.Name = "tboxTarjeta"
        tboxTarjeta.Size = New Size(202, 27)
        tboxTarjeta.TabIndex = 18
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(479, 108)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(74, 24)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "Tarjeta"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(390, 108)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(83, 24)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "Efectivo"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' btnNuevoPedido
        ' 
        btnNuevoPedido.Location = New Point(390, 183)
        btnNuevoPedido.Name = "btnNuevoPedido"
        btnNuevoPedido.Size = New Size(236, 29)
        btnNuevoPedido.TabIndex = 14
        btnNuevoPedido.Text = "Nuevo Pedido"
        btnNuevoPedido.UseVisualStyleBackColor = True
        ' 
        ' btnOrdenarPedido
        ' 
        btnOrdenarPedido.Location = New Point(390, 148)
        btnOrdenarPedido.Name = "btnOrdenarPedido"
        btnOrdenarPedido.Size = New Size(236, 29)
        btnOrdenarPedido.TabIndex = 13
        btnOrdenarPedido.Text = "Ordenar Pedido"
        btnOrdenarPedido.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 12
        Label4.Text = "Platillos"
        ' 
        ' lboxPlatillos
        ' 
        lboxPlatillos.FormattingEnabled = True
        lboxPlatillos.Location = New Point(6, 108)
        lboxPlatillos.Name = "lboxPlatillos"
        lboxPlatillos.Size = New Size(378, 104)
        lboxPlatillos.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(424, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 10
        Label3.Text = "Tarjeta"
        ' 
        ' tboxNombre
        ' 
        tboxNombre.Location = New Point(6, 55)
        tboxNombre.Name = "tboxNombre"
        tboxNombre.Size = New Size(203, 27)
        tboxNombre.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(215, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 20)
        Label1.TabIndex = 7
        Label1.Text = "Fecha"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 6
        Label2.Text = "Nombre"
        ' 
        ' lboxPedidos
        ' 
        lboxPedidos.FormattingEnabled = True
        lboxPedidos.Location = New Point(270, 277)
        lboxPedidos.Name = "lboxPedidos"
        lboxPedidos.Size = New Size(378, 144)
        lboxPedidos.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(270, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 20)
        Label5.TabIndex = 15
        Label5.Text = "Pedidos en Cola"
        ' 
        ' btnRemoverPedido
        ' 
        btnRemoverPedido.Location = New Point(654, 392)
        btnRemoverPedido.Name = "btnRemoverPedido"
        btnRemoverPedido.Size = New Size(248, 29)
        btnRemoverPedido.TabIndex = 15
        btnRemoverPedido.Text = "Remover"
        btnRemoverPedido.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label6.Location = New Point(654, 277)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 20)
        Label6.TabIndex = 15
        Label6.Text = "Total SIN IVA"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(654, 297)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(36, 20)
        lblTotal.TabIndex = 16
        lblTotal.Text = "0.00"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label8.Location = New Point(654, 339)
        Label8.Name = "Label8"
        Label8.Size = New Size(109, 20)
        Label8.TabIndex = 17
        Label8.Text = "Total CON IVA"
        ' 
        ' lblTotalIVA
        ' 
        lblTotalIVA.AutoSize = True
        lblTotalIVA.Location = New Point(654, 363)
        lblTotalIVA.Name = "lblTotalIVA"
        lblTotalIVA.Size = New Size(36, 20)
        lblTotalIVA.TabIndex = 18
        lblTotalIVA.Text = "0.00"
        ' 
        ' tboxDate
        ' 
        tboxDate.Location = New Point(215, 55)
        tboxDate.Name = "tboxDate"
        tboxDate.Size = New Size(205, 27)
        tboxDate.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 443)
        Controls.Add(lblTotalIVA)
        Controls.Add(Label8)
        Controls.Add(lblTotal)
        Controls.Add(Label6)
        Controls.Add(btnRemoverPedido)
        Controls.Add(Label5)
        Controls.Add(lboxPedidos)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(pboxMesero)
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Private btnOrdenarPedido As Button
    Private btnNuevoPedido As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ListBox2 As ListBox
    Private lboxPedidos As ListBox
    Friend WithEvents Label5 As Label
    Private btnRemoverPedido As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Private lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalIVA As Label
    Friend WithEvents tboxTarjeta As TextBox
    Friend WithEvents tboxDate As TextBox
End Class
