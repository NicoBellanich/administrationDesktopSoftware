Public Class frmProveedor

    Dim id_Seleciconado As Integer

    Private Sub frmProveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        txt_nombre.Clear()
        txt_telefono.Clear()
        txt_domicilio.Clear()
        cbo_barrio.SelectedIndex = -1
    End Sub
    Private Sub RegProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grilla_proveedores.DataSource = leo_tabla("Select p.idProveedor,p.nombre,p.domicilio,p.telefono,b.nombre as Nombre_Barrio from proveedor p inner join barrio b on (p.idBarrio=b.id)")
        cargar_combo(cbo_barrio, "nombre", "id", "barrio")
        cbo_barrio.SelectedIndex = -1
        btn_eliminar.Enabled = False
        btn_modificar.Enabled = False

    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click

        If validar_usuario() = False Then
            Exit Sub
        End If

        If validar() = False Then
            Exit Sub
        End If

        Dim nombre As String = txt_nombre.Text
        Dim domicilio As String = txt_domicilio.Text
        Dim telefono As Integer = txt_telefono.Text
        Dim barrio As String = cbo_barrio.Text

        Dim idBarrio As Integer
        Dim subtabla As New DataTable
        subtabla = leo_tabla("select * from barrio where nombre= '" & barrio & "'")
        idBarrio = subtabla.Rows(0)(0)

        comando.CommandType = CommandType.Text
        comando.Connection = conexion

        conexion.Open()

        comando.CommandText = "INSERT INTO proveedor (nombre,domicilio,telefono,idBarrio) VALUES ('" & nombre & "' , '" & domicilio & "' ," & telefono & "," & idBarrio & ")"

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Se registro el Proveedor correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        conexion.Close()


        grilla_proveedores.DataSource = leo_tabla("Select p.idProveedor,p.nombre,p.domicilio,p.telefono,b.nombre as Nombre_Barrio from proveedor p inner join barrio b on (p.idBarrio=b.id)")


        'aca deja en limpio los textbox

        txt_domicilio.Clear()
        txt_nombre.Clear()
        txt_telefono.Clear()
        cbo_barrio.SelectedIndex = -1
    End Sub



    Private Sub btn_buscar_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If validar_usuario() = False Then
            Exit Sub
        End If

        comando.CommandType = CommandType.Text
        comando.Connection = conexion

        conexion.Open()

        sql = "delete from proveedor where idProveedor = " & id_Seleciconado & " "
        comando.CommandText = sql

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("El proveedor fue elminado correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        conexion.Close()

        grilla_proveedores.DataSource = leo_tabla("Select p.idProveedor,p.nombre,p.domicilio,p.telefono,b.nombre as Nombre_Barrio from proveedor p inner join barrio b on (p.idBarrio=b.id)")

        txt_domicilio.Clear()
        txt_nombre.Clear()
        txt_telefono.Clear()
        cbo_barrio.SelectedIndex = -1
        btn_eliminar.Enabled = False
        btn_modificar.Enabled = False

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If validar_usuario() = False Then
            Exit Sub
        End If
        'este es un mensaje con opciones Ok CANCEL
        Dim mensaje As String
        mensaje = MsgBox("¿Estas seguro que deseas modificar los datos de este proveedor id:" & id_Seleciconado & "?", vbOKCancel, "Confirmacion")
        ' si el mensaje es 1 = Boton aceptar (boton de la izquierda) ,.... 2 seria boton cancelar (Boton de la derecha)

        If mensaje = 1 Then

            Dim nombre As String = txt_nombre.Text
            Dim domicilio As String = txt_domicilio.Text
            Dim telefono As Integer = txt_telefono.Text
            Dim barrio As String = cbo_barrio.Text

            Dim idBarrio As Integer
            Dim subtabla As New DataTable
            subtabla = leo_tabla("select * from barrio where nombre= '" & barrio & "'")
            idBarrio = subtabla.Rows(0)(0)

            comando.CommandType = CommandType.Text
            comando.Connection = conexion

            conexion.Open()

            comando.CommandText = "UPDATE proveedor SET nombre = '" & nombre & "',domicilio= '" & domicilio & "' ,telefono= " & telefono & ",idBarrio= " & idBarrio & " WHERE  idProveedor = " & id_Seleciconado

            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Se modificó el Proveedor correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

            conexion.Close()

            grilla_proveedores.DataSource = leo_tabla("Select p.idProveedor,p.nombre,p.domicilio,p.telefono,b.nombre as Nombre_Barrio from proveedor p inner join barrio b on (p.idBarrio=b.id)")

            txt_domicilio.Clear()
            txt_nombre.Clear()
            txt_telefono.Clear()
            cbo_barrio.SelectedIndex = -1
            btn_eliminar.Enabled = False
            btn_modificar.Enabled = False
        Else
            Exit Sub
        End If

    End Sub

    Private Function validar() As Boolean

        If txt_nombre.Text = "" Then
            MessageBox.Show("ingrese el nombre")
            Return False
        End If
        If txt_domicilio.Text = "" Then
            MessageBox.Show("ingrese el domicilio")
            Return False
        End If
        If txt_telefono.Text = "" Then
            MessageBox.Show("ingrese el telefono")
            Return False
        End If
        If cbo_barrio.Text = "" Then
            MessageBox.Show("ingrese el barrio")
            Return False
        End If
        Return True
    End Function

    Private Sub grilla_proveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_proveedores.CellDoubleClick
        If e.RowIndex >= 0 Then
            id_Seleciconado = grilla_proveedores.Rows(e.RowIndex).Cells(0).Value.ToString()
            txt_nombre.Text = grilla_proveedores.Rows(e.RowIndex).Cells(1).Value.ToString()
            txt_domicilio.Text = grilla_proveedores.Rows(e.RowIndex).Cells(2).Value.ToString()
            txt_telefono.Text = grilla_proveedores.Rows(e.RowIndex).Cells(3).Value.ToString()
            cbo_barrio.Text = grilla_proveedores.Rows(e.RowIndex).Cells(4).Value.ToString()
            btn_eliminar.Enabled = True
            btn_modificar.Enabled = True

        End If
    End Sub

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class