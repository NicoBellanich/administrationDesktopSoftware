<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_numFactura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_idproducto = New System.Windows.Forms.TextBox()
        Me.txt_nombreproduc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_precioprod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cantidadprod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dvg_detalle = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btm_agregar = New System.Windows.Forms.Button()
        Me.btm_quitar = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btm_guardar = New System.Windows.Forms.Button()
        Me.btm_buscar2 = New System.Windows.Forms.Button()
        Me.btm_cancelar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtp_fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.cmb_tipoFactura = New System.Windows.Forms.ComboBox()
        CType(Me.dvg_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_numFactura
        '
        Me.txt_numFactura.Enabled = False
        Me.txt_numFactura.Location = New System.Drawing.Point(125, 6)
        Me.txt_numFactura.MaxLength = 8
        Me.txt_numFactura.Name = "txt_numFactura"
        Me.txt_numFactura.Size = New System.Drawing.Size(100, 20)
        Me.txt_numFactura.TabIndex = 0
        Me.txt_numFactura.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Producto"
        '
        'txt_idproducto
        '
        Me.txt_idproducto.Location = New System.Drawing.Point(68, 149)
        Me.txt_idproducto.Name = "txt_idproducto"
        Me.txt_idproducto.Size = New System.Drawing.Size(51, 20)
        Me.txt_idproducto.TabIndex = 3
        '
        'txt_nombreproduc
        '
        Me.txt_nombreproduc.Location = New System.Drawing.Point(178, 150)
        Me.txt_nombreproduc.Name = "txt_nombreproduc"
        Me.txt_nombreproduc.Size = New System.Drawing.Size(148, 20)
        Me.txt_nombreproduc.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(341, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Precio: "
        '
        'txt_precioprod
        '
        Me.txt_precioprod.Location = New System.Drawing.Point(68, 187)
        Me.txt_precioprod.MaxLength = 6
        Me.txt_precioprod.Name = "txt_precioprod"
        Me.txt_precioprod.Size = New System.Drawing.Size(51, 20)
        Me.txt_precioprod.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cantidad "
        '
        'txt_cantidadprod
        '
        Me.txt_cantidadprod.Location = New System.Drawing.Point(248, 187)
        Me.txt_cantidadprod.MaxLength = 6
        Me.txt_cantidadprod.Name = "txt_cantidadprod"
        Me.txt_cantidadprod.Size = New System.Drawing.Size(51, 20)
        Me.txt_cantidadprod.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(324, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "0"
        '
        'dvg_detalle
        '
        Me.dvg_detalle.AllowUserToAddRows = False
        Me.dvg_detalle.AllowUserToDeleteRows = False
        Me.dvg_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dvg_detalle.Location = New System.Drawing.Point(15, 254)
        Me.dvg_detalle.Name = "dvg_detalle"
        Me.dvg_detalle.ReadOnly = True
        Me.dvg_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_detalle.Size = New System.Drawing.Size(542, 200)
        Me.dvg_detalle.TabIndex = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "IdProd"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio Venta"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Stock"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'btm_agregar
        '
        Me.btm_agregar.Location = New System.Drawing.Point(128, 225)
        Me.btm_agregar.Name = "btm_agregar"
        Me.btm_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btm_agregar.TabIndex = 21
        Me.btm_agregar.Text = "Agregar"
        Me.btm_agregar.UseVisualStyleBackColor = True
        '
        'btm_quitar
        '
        Me.btm_quitar.Location = New System.Drawing.Point(354, 225)
        Me.btm_quitar.Name = "btm_quitar"
        Me.btm_quitar.Size = New System.Drawing.Size(75, 23)
        Me.btm_quitar.TabIndex = 22
        Me.btm_quitar.Text = "Quitar"
        Me.btm_quitar.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(457, 474)
        Me.txt_total.MaxLength = 10
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 23
        Me.txt_total.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(390, 477)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "TOTAL:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(563, 477)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "$"
        '
        'btm_guardar
        '
        Me.btm_guardar.Location = New System.Drawing.Point(207, 477)
        Me.btm_guardar.Name = "btm_guardar"
        Me.btm_guardar.Size = New System.Drawing.Size(126, 23)
        Me.btm_guardar.TabIndex = 26
        Me.btm_guardar.Text = "Generar Factura"
        Me.btm_guardar.UseVisualStyleBackColor = True
        '
        'btm_buscar2
        '
        Me.btm_buscar2.Location = New System.Drawing.Point(128, 149)
        Me.btm_buscar2.Name = "btm_buscar2"
        Me.btm_buscar2.Size = New System.Drawing.Size(25, 23)
        Me.btm_buscar2.TabIndex = 4
        Me.btm_buscar2.Text = "..."
        Me.btm_buscar2.UseVisualStyleBackColor = True
        '
        'btm_cancelar
        '
        Me.btm_cancelar.Location = New System.Drawing.Point(422, 147)
        Me.btm_cancelar.Name = "btm_cancelar"
        Me.btm_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btm_cancelar.TabIndex = 28
        Me.btm_cancelar.Text = "Cancelar"
        Me.btm_cancelar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(306, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "/"
        '
        'dtp_fecha1
        '
        Me.dtp_fecha1.Enabled = False
        Me.dtp_fecha1.Location = New System.Drawing.Point(125, 59)
        Me.dtp_fecha1.Name = "dtp_fecha1"
        Me.dtp_fecha1.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha1.TabIndex = 2
        '
        'cmb_tipoFactura
        '
        Me.cmb_tipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoFactura.FormattingEnabled = True
        Me.cmb_tipoFactura.Location = New System.Drawing.Point(125, 32)
        Me.cmb_tipoFactura.Name = "cmb_tipoFactura"
        Me.cmb_tipoFactura.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoFactura.TabIndex = 1
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.AE
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(583, 518)
        Me.Controls.Add(Me.cmb_tipoFactura)
        Me.Controls.Add(Me.dtp_fecha1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btm_cancelar)
        Me.Controls.Add(Me.btm_buscar2)
        Me.Controls.Add(Me.btm_guardar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.btm_quitar)
        Me.Controls.Add(Me.btm_agregar)
        Me.Controls.Add(Me.dvg_detalle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_cantidadprod)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_precioprod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nombreproduc)
        Me.Controls.Add(Me.txt_idproducto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_numFactura)
        Me.Name = "frmFactura"
        Me.Text = "Facturación"
        CType(Me.dvg_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_numFactura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_idproducto As TextBox
    Friend WithEvents txt_nombreproduc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_precioprod As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cantidadprod As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dvg_detalle As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btm_agregar As Button
    Friend WithEvents btm_quitar As Button
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btm_guardar As Button
    Friend WithEvents btm_buscar2 As Button
    Friend WithEvents btm_cancelar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents dtp_fecha1 As DateTimePicker
    Friend WithEvents cmb_tipoFactura As ComboBox
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
