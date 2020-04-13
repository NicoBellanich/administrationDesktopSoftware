Public Class frmABMUsuarios


    
    Private Sub btm_salir_Click(sender As Object, e As EventArgs) Handles btm_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_nombre_LostFocus(sender As Object, e As EventArgs) Handles txt_nombre.LostFocus
        Me.lbl_nombre.Visible = True
        If IsNumeric(Me.txt_nombre.Text) Then
            lbl_nombre.Text = "Nombre Invalido"
            Me.lbl_nombre.ForeColor = Color.Red
            Me.txt_nombre.Focus()
            Exit Sub
        ElseIf (Me.txt_nombre.Text) = "" Then
            lbl_nombre.Text = "Ingresar un nombre"
            Me.lbl_nombre.ForeColor = Color.Red
            Me.txt_nombre.Focus()
            Exit Sub
        Else
            Me.lbl_nombre.ForeColor = Color.Green
            lbl_nombre.Text = "Nombre valido"
        End If
        Dim tabla As New DataTable
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text

        comando.CommandText = "Select id from usuario where nombre= '" & Me.txt_nombre.Text & "'"
        tabla.Load(comando.ExecuteReader)
        conexion.Close()
        If tabla.Rows.Count = 0 Then
            lbl_nombre.Text = "( Valido )"
            txt_contraseña.Focus()
            Me.lbl_nombre.ForeColor = Color.Green
        Else
            Me.lbl_nombre.Enabled = True
            lbl_nombre.Text = "Nombre Invalido"
            Me.lbl_nombre.ForeColor = Color.Red
            Me.txt_nombre.Focus()
        End If
    End Sub

    Private Sub txt_contraseña1_2_LostFocus(sender As Object, e As EventArgs)
        Me.lbl_contraseña2.Enabled = True
        If Me.txt_contraseña.Text <> txt_contraseña1_2.Text Then
            Me.lbl_contraseña2.Text = "Contraseña distintas"
        Else
            Me.txt_contraseña2.Focus()
            Me.lbl_contraseña2.Text = " Valido"
        End If
    End Sub

    Private Sub btm_acceptar1_Click(sender As Object, e As EventArgs) Handles btm_acceptar1.Click
        If validar_usuario() = False Then
            Exit Sub
        End If

        If Me.txt_contraseña.Text = Me.txt_contraseña1_2.Text Then
            conexion.Open()
            Dim id As Integer
            Dim consulta As String
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            Dim tabla2 As New DataTable
            comando.CommandText = "Select max(id) from usuario "
            tabla2.Load(comando.ExecuteReader)
            id = 1 + tabla2.Rows(0)(0)
            consulta = "Insert into usuario ( id , nombre , contraseña ) values ( " & id & ", '" & Me.txt_nombre.Text & "' , '" & Me.txt_contraseña.Text & "' )"
            comando.CommandText = consulta
            Try
                comando.ExecuteNonQuery()
                MsgBox("Se registro el Usuario correctamente")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            conexion.Close()
            txt_nombre.Clear()
            txt_contraseña.Clear()
            txt_contraseña1_2.Clear()
            lbl_nombre.Text = "-"
        Else
            MessageBox.Show("Las contraseñas deben ser iguales", "Atencion", MessageBoxButtons.OK)
        End If

    End Sub


    Private Sub btm_aceptar2_Click(sender As Object, e As EventArgs) Handles btm_aceptar2.Click
        If validar_usuario() = False Then
            MessageBox.Show("Solo el Root/Administrador puede eliminar")
            Exit Sub
        End If

        Dim tabla As New DataTable
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text

        comando.CommandText = "Select * from usuario where nombre= '" & Me.txt_usuario2.Text & "' and contraseña = '" & Me.txt_contraseña2.Text & "'"
        tabla.Load(comando.ExecuteReader)
        If tabla.Rows.Count = 0 Then
            MsgBox("El Usuario y/o la contraseña son incorectos")
        Else
            If MessageBox.Show("¿Seguro que desea borrar el usuario:  " & Me.txt_usuario2.Text & "?", "Atencion", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                comando.CommandText = "DELETE From usuario Where nombre= '" & Me.txt_usuario2.Text & "' and contraseña = '" & Me.txt_contraseña2.Text & "'"
                comando.ExecuteNonQuery()
                txt_usuario2.Text = ""
                txt_contraseña2.Text = ""
            End If
        End If
        conexion.Close()
    End Sub


    Private Sub frmABMUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        txt_contraseña.Clear()
        txt_contraseña1_2.Clear()
        txt_contraseña2.Clear()
        txt_nombre.Clear()
        txt_usuario2.Clear()

    End Sub
End Class