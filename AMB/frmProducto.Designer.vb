<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.grilla_producto = New System.Windows.Forms.DataGridView()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_precioVU = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_precioCU = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_tipo_producto = New System.Windows.Forms.ComboBox()
        CType(Me.grilla_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(342, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Listado:"
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(485, 319)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(193, 23)
        Me.btn_modificar.TabIndex = 30
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(260, 319)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(205, 23)
        Me.btn_eliminar.TabIndex = 29
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'grilla_producto
        '
        Me.grilla_producto.AllowUserToAddRows = False
        Me.grilla_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_producto.Location = New System.Drawing.Point(346, 65)
        Me.grilla_producto.Name = "grilla_producto"
        Me.grilla_producto.ReadOnly = True
        Me.grilla_producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_producto.Size = New System.Drawing.Size(581, 228)
        Me.grilla_producto.TabIndex = 27
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(45, 319)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(193, 23)
        Me.btn_registrar.TabIndex = 26
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(149, 216)
        Me.txt_nombre.MaxLength = 30
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(171, 20)
        Me.txt_nombre.TabIndex = 25
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(149, 178)
        Me.txt_stock.MaxLength = 10
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(171, 20)
        Me.txt_stock.TabIndex = 24
        '
        'txt_precioVU
        '
        Me.txt_precioVU.Location = New System.Drawing.Point(149, 139)
        Me.txt_precioVU.MaxLength = 10
        Me.txt_precioVU.Name = "txt_precioVU"
        Me.txt_precioVU.Size = New System.Drawing.Size(171, 20)
        Me.txt_precioVU.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Precio Venta Unitario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tipo Procuto"
        '
        'txt_precioCU
        '
        Me.txt_precioCU.Location = New System.Drawing.Point(149, 246)
        Me.txt_precioCU.MaxLength = 10
        Me.txt_precioCU.Name = "txt_precioCU"
        Me.txt_precioCU.Size = New System.Drawing.Size(171, 20)
        Me.txt_precioCU.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Precio Compra Unitario"
        '
        'cbo_tipo_producto
        '
        Me.cbo_tipo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_producto.FormattingEnabled = True
        Me.cbo_tipo_producto.Location = New System.Drawing.Point(149, 105)
        Me.cbo_tipo_producto.Name = "cbo_tipo_producto"
        Me.cbo_tipo_producto.Size = New System.Drawing.Size(171, 21)
        Me.cbo_tipo_producto.TabIndex = 34
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.AE
        Me.ClientSize = New System.Drawing.Size(954, 374)
        Me.Controls.Add(Me.cbo_tipo_producto)
        Me.Controls.Add(Me.txt_precioCU)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.grilla_producto)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_precioVU)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmProducto"
        Me.Text = "ABMC Procuto"
        CType(Me.grilla_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents grilla_producto As System.Windows.Forms.DataGridView
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_stock As System.Windows.Forms.TextBox
    Friend WithEvents txt_precioVU As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_precioCU As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_producto As System.Windows.Forms.ComboBox
End Class
