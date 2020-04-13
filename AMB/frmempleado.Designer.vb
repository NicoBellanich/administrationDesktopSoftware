<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
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
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nroDNI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_salario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grilla_empleado = New System.Windows.Forms.DataGridView()
        Me.cbo_tipoDNI = New System.Windows.Forms.ComboBox()
        Me.cbo_barrio = New System.Windows.Forms.ComboBox()
        CType(Me.grilla_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(91, 180)
        Me.txt_domicilio.MaxLength = 50
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(171, 20)
        Me.txt_domicilio.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Domicilio"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(91, 35)
        Me.txt_nombre.MaxLength = 30
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(171, 20)
        Me.txt_nombre.TabIndex = 43
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(91, 73)
        Me.txt_apellido.MaxLength = 30
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(171, 20)
        Me.txt_apellido.TabIndex = 41
        '
        'txt_nroDNI
        '
        Me.txt_nroDNI.Location = New System.Drawing.Point(91, 147)
        Me.txt_nroDNI.MaxLength = 30
        Me.txt_nroDNI.Name = "txt_nroDNI"
        Me.txt_nroDNI.Size = New System.Drawing.Size(171, 20)
        Me.txt_nroDNI.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Tipo DNI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nro DNI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Barrio"
        '
        'txt_salario
        '
        Me.txt_salario.Location = New System.Drawing.Point(91, 255)
        Me.txt_salario.MaxLength = 10
        Me.txt_salario.Name = "txt_salario"
        Me.txt_salario.Size = New System.Drawing.Size(171, 20)
        Me.txt_salario.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Salario"
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(471, 324)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(193, 23)
        Me.btn_modificar.TabIndex = 52
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(242, 324)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(205, 23)
        Me.btn_eliminar.TabIndex = 51
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(27, 324)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(193, 23)
        Me.btn_registrar.TabIndex = 50
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(296, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Listado:"
        '
        'grilla_empleado
        '
        Me.grilla_empleado.AllowUserToAddRows = False
        Me.grilla_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_empleado.Location = New System.Drawing.Point(290, 50)
        Me.grilla_empleado.Name = "grilla_empleado"
        Me.grilla_empleado.ReadOnly = True
        Me.grilla_empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_empleado.Size = New System.Drawing.Size(668, 225)
        Me.grilla_empleado.TabIndex = 53
        '
        'cbo_tipoDNI
        '
        Me.cbo_tipoDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipoDNI.FormattingEnabled = True
        Me.cbo_tipoDNI.Location = New System.Drawing.Point(91, 111)
        Me.cbo_tipoDNI.Name = "cbo_tipoDNI"
        Me.cbo_tipoDNI.Size = New System.Drawing.Size(171, 21)
        Me.cbo_tipoDNI.TabIndex = 56
        '
        'cbo_barrio
        '
        Me.cbo_barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_barrio.FormattingEnabled = True
        Me.cbo_barrio.Location = New System.Drawing.Point(91, 215)
        Me.cbo_barrio.Name = "cbo_barrio"
        Me.cbo_barrio.Size = New System.Drawing.Size(171, 21)
        Me.cbo_barrio.TabIndex = 57
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.AE
        Me.ClientSize = New System.Drawing.Size(982, 360)
        Me.Controls.Add(Me.cbo_barrio)
        Me.Controls.Add(Me.cbo_tipoDNI)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.grilla_empleado)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_salario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nroDNI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmEmpleado"
        Me.Text = "ABMC Empleado"
        CType(Me.grilla_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nroDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_salario As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grilla_empleado As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_tipoDNI As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_barrio As System.Windows.Forms.ComboBox
End Class
