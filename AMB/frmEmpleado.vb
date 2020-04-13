Public Class frmEmpleado

    Dim id_Seleciconado As Integer

    Private Sub frmEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        txt_nombre.Clear()
        txt_apellido.Clear()
        txt_domicilio.Clear()
        txt_nroDNI.Clear()
        txt_salario.Clear()
        cbo_barrio.SelectedIndex = -1
        cbo_tipoDNI.SelectedIndex = -1
    End Sub
    Private Sub frmempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grilla_empleado.DataSource = leo_tabla("select e.idEmpleado,e.apellido,e.nombre,td.descripcion,e.nroDNI,e.salario,e.domicilio,b.nombre as nombreBarrio from empleado e inner join tipoDni td on (e.idTipoDNI=td.id) inner join barrio b on (e.idBarrio= b.id)")
        cargar_combo(cbo_barrio, "nombre", "id", "barrio")
        cargar_combo(cbo_tipoDNI, "descripcion", "id", "tipoDni")
        cbo_barrio.SelectedIndex = -1
        cbo_tipoDNI.SelectedIndex = -1
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False

    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If validar_usuario() = False Then
            Exit Sub
        End If

        txt_nroDNI.Text = txt_nroDNI.Text.Replace(" ", String.Empty)
        txt_salario.Text = txt_salario.Text.Replace(" ", String.Empty)

        If validar() = False Then
            Exit Sub
        End If

        Dim nombre As String = txt_nombre.Text
        Dim apellido As String = txt_apellido.Text
        Dim tipoDNI As String = cbo_tipoDNI.Text
        Dim numDNI As Integer = txt_nroDNI.Text
        Dim domicilio As String = txt_domicilio.Text
        Dim barrio As String = cbo_barrio.Text
        Dim salario As Integer = txt_salario.Text

        Dim idBarrio As Integer
        Dim subtabla As New DataTable
        subtabla = leo_tabla("select * from barrio where nombre= '" & barrio & "'")
        idBarrio = subtabla.Rows(0)(0)

        Dim dni_tipo As Integer
        Dim subtabla2 As New DataTable
        subtabla2 = leo_tabla("select * from tipoDni where descripcion= '" & tipoDNI & "'")
        dni_tipo = subtabla2(0)(0)

        comando.CommandType = CommandType.Text
        comando.Connection = conexion

        conexion.Open()
        sql = " INSERT INTO empleado (nombre,apellido,idTipoDNI,nroDNI,domicilio,idBarrio,salario) VALUES ('" & nombre & "','" & apellido & "'," & dni_tipo & "," & numDNI & ",'" & domicilio & "'," & idBarrio & "," & salario & " )"

        comando.CommandText = sql

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Se registro el Empleado correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        conexion.Close()

        'grilla_empleado.DataSource = leo_tabla("select e.idEmpleado,e.apellido,e.nombre,e.nroDNI,e.salario,e.domicilio,td.descripcion,b.nombre from empleado e inner join tipoDni td on (e.idTipoDNI=td.id) inner join barrio b on (e.idBarrio= b.id)")
        grilla_empleado.DataSource = leo_tabla("select e.idEmpleado,e.apellido,e.nombre,td.descripcion,e.nroDNI,e.salario,e.domicilio,b.nombre as nombreBarrio from empleado e inner join tipoDni td on (e.idTipoDNI=td.id) inner join barrio b on (e.idBarrio= b.id)")


        txt_apellido.Clear()
        txt_nombre.Clear()

        txt_nroDNI.Clear()
        txt_domicilio.Clear()

        txt_salario.Clear()

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

        sql = "delete from empleado where idEmpleado = " & id_Seleciconado & " "
        comando.CommandText = sql

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("El empleado fue elminado correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        conexion.Close()

        'grilla_empleado.DataSource = leo_tabla("select e.idEmpleado,e.apellido,e.nombre,e.nroDNI,e.salario,e.domicilio,td.descripcion,b.nombre from empleado e inner join tipoDni td on (e.idTipoDNI=td.id) inner join barrio b on (e.idBarrio= b.id)")
        grilla_empleado.DataSource = leo_tabla("select e.idEmpleado,e.apellido,e.nombre,td.descripcion,e.nroDNI,e.salario,e.domicilio,b.nombre as nombreBarrio from empleado e inner join tipoDni td on (e.idTipoDNI=td.id) inner join barrio b on (e.idBarrio= b.id)")


        txt_apellido.Clear()
        txt_nombre.Clear()
        cbo_tipoDNI.SelectedIndex = -1
        txt_nroDNI.Clear()
        txt_domicilio.Clear()
        cbo_barrio.SelectedIndex = -1
        txt_salario.Clear()


        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False

    End Sub


    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If validar_usuario() = False Then
            Exit Sub
        End If

        Dim mensaje As String
        mensaje = MsgBox("¿Estas seguro que deseas modificar los datos de este producto id:" & id_Seleciconado & "?", vbOKCancel, "Confirmacion")
        ' si el mensaje es 1 = Boton aceptar (boton de la izquierda) ,.... 2 seria boton cancelar (Boton de la derecha)

        If mensaje = 1 Then


            Dim nombre As String = txt_nombre.Text
            Dim apellido As String = txt_apellido.Text
            Dim tipoDNI As String = cbo_tipoDNI.Text
            Dim numDNI As Integer = txt_nroDNI.Text
            Dim domicilio As String = txt_domicilio.Text
            Dim barrio As String = cbo_barrio.Text
            Dim salario As Integer = txt_salario.Text


            Dim idBarrio As Integer
            Dim subtabla As New DataTable
            subtabla = leo_tabla("select * from barrio where nombre= '" & barrio & "'")
            idBarrio = subtabla.Rows(0)(0)

            Dim dni_tipo As Integer
            Dim subtabla2 As New DataTable
            subtabla2 = leo_tabla("select * from tipoDni where descripcion= '" & tipoDNI & "'")
            dni_tipo = subtabla2(0)(0)



            comando.CommandType = CommandType.Text
            comando.Connection = conexion

            conexion.Open()

            comando.CommandText = "UPDATE empleado SET nombre= '" & nombre & "',apellido= '" & apellido & "' ,idTipoDNI= " & dni_tipo & ",nroDNI= " & numDNI & ",domicilio = '" & domicilio & "',idBarrio = " & idBarrio & ",salario = " & salario & " WHERE  idEmpleado = " & id_Seleciconado

            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Se modificó el Empleado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

            conexion.Close()

            'grilla_empleado.DataSource = leo_tabla("select e.idEmpleado,e.apellido,e.nombre,e.nroDNI,e.salario,e.domicilio,td.descripcion,b.nombre from empleado e inner join tipoDni td on (e.idTipoDNI=td.id) inner join barrio b on (e.idBarrio= b.id)")
            grilla_empleado.DataSource = leo_tabla("select e.idEmpleado,e.apellido,e.nombre,td.descripcion,e.nroDNI,e.salario,e.domicilio,b.nombre as nombreBarrio from empleado e inner join tipoDni td on (e.idTipoDNI=td.id) inner join barrio b on (e.idBarrio= b.id)")


            txt_apellido.Clear()
            txt_nombre.Clear()

            txt_nroDNI.Clear()
            txt_domicilio.Clear()

            txt_salario.Clear()

            btn_modificar.Enabled = False
            btn_eliminar.Enabled = False
        Else
            Exit Sub
        End If


    End Sub

    Private Function validar() As Boolean

        If txt_nombre.Text = "" Then
            MessageBox.Show("ingrese el nombre")
            Return False
        End If
        If txt_apellido.Text = "" Then
            MessageBox.Show("ingrese el apellido")
            Return False
        End If
        If cbo_tipoDNI.Text = "" Then
            MessageBox.Show("ingrese el tipo de DNI")
            Return False
        End If
        If txt_nroDNI.Text = "" Then
            MessageBox.Show("ingrese el numero de DNI")
            Return False
        End If
        If txt_domicilio.Text = "" Then
            MessageBox.Show("ingrese el Domicilio")
            Return False
        End If
        If cbo_barrio.Text = "" Then
            MessageBox.Show("ingrese el barrio")
            Return False
        End If
        If txt_salario.Text = "" Then
            MessageBox.Show("ingrese el Salario")
            Return False
        End If
        Return True

    End Function

    Private Sub grilla_empleado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_empleado.CellDoubleClick
        If e.RowIndex >= 0 Then
            id_Seleciconado = grilla_empleado.Rows(e.RowIndex).Cells(0).Value.ToString()
            txt_apellido.Text = grilla_empleado.Rows(e.RowIndex).Cells(1).Value.ToString()
            txt_nombre.Text = grilla_empleado.Rows(e.RowIndex).Cells(2).Value.ToString()

            cbo_tipoDNI.Text = grilla_empleado.Rows(e.RowIndex).Cells(3).Value.ToString()
            txt_nroDNI.Text = grilla_empleado.Rows(e.RowIndex).Cells(4).Value.ToString()
            txt_salario.Text = grilla_empleado.Rows(e.RowIndex).Cells(5).Value.ToString()

            txt_domicilio.Text = grilla_empleado.Rows(e.RowIndex).Cells(6).Value.ToString()

            cbo_barrio.Text = grilla_empleado.Rows(e.RowIndex).Cells(7).Value.ToString()
            



            btn_modificar.Enabled = True
            btn_eliminar.Enabled = True
        End If
    End Sub


    Private Sub txt_nroDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nroDNI.KeyPress
        solo_numeros(sender, e)
    End Sub

    Private Sub txt_salario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_salario.KeyPress
        solo_numeros(sender, e)
    End Sub
End Class