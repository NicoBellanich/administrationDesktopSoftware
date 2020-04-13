<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMUsuarios
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
        Me.tb_usuarios = New System.Windows.Forms.TabControl()
        Me.Alta = New System.Windows.Forms.TabPage()
        Me.lbl_contraseña2 = New System.Windows.Forms.Label()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btm_acceptar1 = New System.Windows.Forms.Button()
        Me.txt_contraseña1_2 = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Baja = New System.Windows.Forms.TabPage()
        Me.btm_aceptar2 = New System.Windows.Forms.Button()
        Me.txt_contraseña2 = New System.Windows.Forms.TextBox()
        Me.txt_usuario2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btm_salir = New System.Windows.Forms.Button()
        Me.tb_usuarios.SuspendLayout()
        Me.Alta.SuspendLayout()
        Me.Baja.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_usuarios
        '
        Me.tb_usuarios.Controls.Add(Me.Alta)
        Me.tb_usuarios.Controls.Add(Me.Baja)
        Me.tb_usuarios.Location = New System.Drawing.Point(27, 25)
        Me.tb_usuarios.Name = "tb_usuarios"
        Me.tb_usuarios.SelectedIndex = 0
        Me.tb_usuarios.Size = New System.Drawing.Size(364, 170)
        Me.tb_usuarios.TabIndex = 0
        '
        'Alta
        '
        Me.Alta.Controls.Add(Me.lbl_contraseña2)
        Me.Alta.Controls.Add(Me.lbl_contraseña)
        Me.Alta.Controls.Add(Me.lbl_nombre)
        Me.Alta.Controls.Add(Me.btm_acceptar1)
        Me.Alta.Controls.Add(Me.txt_contraseña1_2)
        Me.Alta.Controls.Add(Me.txt_contraseña)
        Me.Alta.Controls.Add(Me.txt_nombre)
        Me.Alta.Controls.Add(Me.Label3)
        Me.Alta.Controls.Add(Me.Label2)
        Me.Alta.Controls.Add(Me.Label1)
        Me.Alta.Location = New System.Drawing.Point(4, 22)
        Me.Alta.Name = "Alta"
        Me.Alta.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta.Size = New System.Drawing.Size(356, 144)
        Me.Alta.TabIndex = 0
        Me.Alta.Text = "Alta"
        Me.Alta.UseVisualStyleBackColor = True
        '
        'lbl_contraseña2
        '
        Me.lbl_contraseña2.AutoSize = True
        Me.lbl_contraseña2.Location = New System.Drawing.Point(238, 69)
        Me.lbl_contraseña2.Name = "lbl_contraseña2"
        Me.lbl_contraseña2.Size = New System.Drawing.Size(10, 13)
        Me.lbl_contraseña2.TabIndex = 15
        Me.lbl_contraseña2.Text = "-"
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Location = New System.Drawing.Point(238, 43)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(10, 13)
        Me.lbl_contraseña.TabIndex = 14
        Me.lbl_contraseña.Text = "-"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(238, 17)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(10, 13)
        Me.lbl_nombre.TabIndex = 13
        Me.lbl_nombre.Text = "-"
        '
        'btm_acceptar1
        '
        Me.btm_acceptar1.Location = New System.Drawing.Point(145, 105)
        Me.btm_acceptar1.Name = "btm_acceptar1"
        Me.btm_acceptar1.Size = New System.Drawing.Size(75, 23)
        Me.btm_acceptar1.TabIndex = 12
        Me.btm_acceptar1.Text = "Registrar"
        Me.btm_acceptar1.UseVisualStyleBackColor = True
        '
        'txt_contraseña1_2
        '
        Me.txt_contraseña1_2.Location = New System.Drawing.Point(132, 66)
        Me.txt_contraseña1_2.MaxLength = 10
        Me.txt_contraseña1_2.Name = "txt_contraseña1_2"
        Me.txt_contraseña1_2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña1_2.Size = New System.Drawing.Size(100, 20)
        Me.txt_contraseña1_2.TabIndex = 11
        Me.txt_contraseña1_2.UseSystemPasswordChar = True
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(132, 40)
        Me.txt_contraseña.MaxLength = 10
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(100, 20)
        Me.txt_contraseña.TabIndex = 10
        Me.txt_contraseña.UseSystemPasswordChar = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(132, 14)
        Me.txt_nombre.MaxLength = 10
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Repita contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contraseña "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre Usuario"
        '
        'Baja
        '
        Me.Baja.Controls.Add(Me.btm_aceptar2)
        Me.Baja.Controls.Add(Me.txt_contraseña2)
        Me.Baja.Controls.Add(Me.txt_usuario2)
        Me.Baja.Controls.Add(Me.Label4)
        Me.Baja.Controls.Add(Me.Label5)
        Me.Baja.Location = New System.Drawing.Point(4, 22)
        Me.Baja.Name = "Baja"
        Me.Baja.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja.Size = New System.Drawing.Size(356, 144)
        Me.Baja.TabIndex = 1
        Me.Baja.Text = "Baja"
        Me.Baja.UseVisualStyleBackColor = True
        '
        'btm_aceptar2
        '
        Me.btm_aceptar2.Location = New System.Drawing.Point(158, 94)
        Me.btm_aceptar2.Name = "btm_aceptar2"
        Me.btm_aceptar2.Size = New System.Drawing.Size(75, 23)
        Me.btm_aceptar2.TabIndex = 15
        Me.btm_aceptar2.Text = "Aceptar"
        Me.btm_aceptar2.UseVisualStyleBackColor = True
        '
        'txt_contraseña2
        '
        Me.txt_contraseña2.Location = New System.Drawing.Point(133, 48)
        Me.txt_contraseña2.MaxLength = 10
        Me.txt_contraseña2.Name = "txt_contraseña2"
        Me.txt_contraseña2.Size = New System.Drawing.Size(100, 20)
        Me.txt_contraseña2.TabIndex = 14
        Me.txt_contraseña2.UseSystemPasswordChar = True
        '
        'txt_usuario2
        '
        Me.txt_usuario2.Location = New System.Drawing.Point(133, 22)
        Me.txt_usuario2.MaxLength = 10
        Me.txt_usuario2.Name = "txt_usuario2"
        Me.txt_usuario2.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuario2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Contraseña "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nombre Usuario"
        '
        'btm_salir
        '
        Me.btm_salir.Location = New System.Drawing.Point(176, 218)
        Me.btm_salir.Name = "btm_salir"
        Me.btm_salir.Size = New System.Drawing.Size(75, 23)
        Me.btm_salir.TabIndex = 13
        Me.btm_salir.Text = "Salir"
        Me.btm_salir.UseVisualStyleBackColor = True
        '
        'frmABMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 253)
        Me.Controls.Add(Me.btm_salir)
        Me.Controls.Add(Me.tb_usuarios)
        Me.Name = "frmABMUsuarios"
        Me.Text = "Administracion Usuarios"
        Me.tb_usuarios.ResumeLayout(False)
        Me.Alta.ResumeLayout(False)
        Me.Alta.PerformLayout()
        Me.Baja.ResumeLayout(False)
        Me.Baja.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tb_usuarios As System.Windows.Forms.TabControl
    Friend WithEvents Alta As System.Windows.Forms.TabPage
    Friend WithEvents txt_contraseña1_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Baja As System.Windows.Forms.TabPage
    Friend WithEvents btm_acceptar1 As System.Windows.Forms.Button
    Friend WithEvents btm_aceptar2 As System.Windows.Forms.Button
    Friend WithEvents txt_contraseña2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btm_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_contraseña2 As System.Windows.Forms.Label
    Friend WithEvents lbl_contraseña As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
End Class
