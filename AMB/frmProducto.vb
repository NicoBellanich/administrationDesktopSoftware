Public Class frmProducto

    Dim id_seleccionado As Integer
    Dim idTipoProducto_seleccionado As Integer

    Private Sub frmProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        cbo_tipo_producto.SelectedIndex = -1
        txt_nombre.Clear()
        txt_precioCU.Clear()
        txt_precioVU.Clear()
        txt_stock.Clear()

    End Sub
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        cargar_combo(cbo_tipo_producto, "descripcion", "id", "tipoProducto")
        grilla_producto.DataSource = leo_tabla("select p.idProducto,tp.descripcion,p.precioVentaUnit,p.stock,p.nombre,p.precioCompraUnit from producto p inner join tipoProducto tp on p.idTipoProducto = tp.id")
        cbo_tipo_producto.SelectedIndex = -1



    End Sub
    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If validar_usuario() = False Then
            Exit Sub
        End If

        If validar() = False Then
            Exit Sub
        End If


        Dim subtabla As New DataTable
        subtabla = leo_tabla("select * from tipoProducto where descripcion='" & cbo_tipo_producto.Text & "'")

        Dim iDtipoProducto As Integer = subtabla.Rows(0)("id")
        Dim precioVU As Integer = txt_precioVU.Text
        Dim stock As Integer = txt_stock.Text
        Dim nombre As String = txt_nombre.Text
        Dim precioCU As Integer = txt_precioCU.Text

        comando.CommandType = CommandType.Text
        comando.Connection = conexion
        conexion.Open()

        comando.CommandText = "INSERT INTO producto (idTipoProducto,precioVentaUnit,stock,nombre,precioCompraUnit) VALUES (" & iDtipoProducto & "," & precioVU & "," & stock & ",'" & nombre & "'," & precioCU & ")"

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Se registro el Prodcuto correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        conexion.Close()

        grilla_producto.DataSource = leo_tabla("select p.idProducto,tp.descripcion,p.precioVentaUnit,p.stock,p.nombre,p.precioCompraUnit from producto p inner join tipoProducto tp on p.idTipoProducto = tp.id")

        cbo_tipo_producto.SelectedIndex = -1
        txt_nombre.Clear()
        txt_precioCU.Clear()
        txt_precioVU.Clear()
        txt_stock.Clear()


    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If validar_usuario() = False Then
            Exit Sub
        End If
        Dim subtabla As DataTable
        subtabla = leo_tabla("select idproducto from detalleXfactura where idproducto = " & id_seleccionado)
        If subtabla.Rows.Count <> 0 Then
            MessageBox.Show("No se puede eliminar el producto, ya se encuentra en una factura.")
            Exit Sub
        End If

        comando.CommandType = CommandType.Text
        comando.Connection = conexion

        conexion.Open()

        sql = "delete from producto where idProducto = " & id_seleccionado & " AND idTipoProducto= " & idTipoProducto_seleccionado
        comando.CommandText = sql

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("El producto fue elminado correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        conexion.Close()

        grilla_producto.DataSource = leo_tabla("select p.idProducto,tp.descripcion,p.precioVentaUnit,p.stock,p.nombre,p.precioCompraUnit from producto p inner join tipoProducto tp on p.idTipoProducto = tp.id")

        txt_nombre.Clear()
        txt_precioCU.Clear()
        txt_precioVU.Clear()
        txt_stock.Clear()

        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False

        cbo_tipo_producto.SelectedIndex = -1

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If validar_usuario() = False Then
            Exit Sub
        End If


        'este es un mensaje con opciones Ok CANCEL
        Dim mensaje As String
        mensaje = MsgBox("¿Estas seguro que deseas modificar los datos de este producto id:" & id_seleccionado & "?", vbOKCancel, "Confirmacion")
        ' si el mensaje es 1 = Boton aceptar (boton de la izquierda) ,.... 2 seria boton cancelar (Boton de la derecha)
        If mensaje = 1 Then



            Dim precioVU As Integer = txt_precioVU.Text
            Dim stock As Integer = txt_stock.Text
            Dim nombre As String = txt_nombre.Text
            Dim precioCU As Integer = txt_precioCU.Text

            comando.CommandType = CommandType.Text
            comando.Connection = conexion

            conexion.Open()

            comando.CommandText = "UPDATE producto SET precioVentaUnit= " & precioVU & " ,stock= " & stock & ",nombre= '" & nombre & "',precioCompraUnit = " & precioCU & " WHERE  idProducto = " & id_seleccionado & " AND idTipoProducto= " & idTipoProducto_seleccionado

            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Se modificó el Producto correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

            conexion.Close()

            grilla_producto.DataSource = leo_tabla("select p.idProducto,tp.descripcion,p.precioVentaUnit,p.stock,p.nombre,p.precioCompraUnit from producto p inner join tipoProducto tp on p.idTipoProducto = tp.id")

            
            txt_nombre.Clear()
            txt_precioCU.Clear()
            txt_precioVU.Clear()
            txt_stock.Clear()
            btn_modificar.Enabled = False
            btn_eliminar.Enabled = False

            cbo_tipo_producto.SelectedIndex = -1
        Else
            Exit Sub
        End If


    End Sub
    Private Function validar() As Boolean
        If txt_nombre.Text = "" Then
            MessageBox.Show("ingrese el nombre")
            Return False
        End If
        If txt_precioVU.Text = "" Then
            MessageBox.Show("ingrese el precio Venta Unit")
            Return False
        End If
        If txt_stock.Text = "" Then
            MessageBox.Show("ingrese el stock")
            Return False
        End If
        If cbo_tipo_producto.Text = "" Then
            MessageBox.Show("ingrese el id del TipodeProd")
            Return False
        End If
        If txt_precioCU.Text = "" Then
            MessageBox.Show("ingrese el precio Compra Unit")
            Return False
        End If
        Return True
    End Function

    Private Sub grilla_producto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_producto.CellDoubleClick
        If e.RowIndex >= 0 Then

            cbo_tipo_producto.Text = grilla_producto.Rows(e.RowIndex).Cells(1).Value.ToString()

            txt_precioVU.Text = grilla_producto.Rows(e.RowIndex).Cells(2).Value.ToString()
            txt_stock.Text = grilla_producto.Rows(e.RowIndex).Cells(3).Value.ToString()

            txt_nombre.Text = grilla_producto.Rows(e.RowIndex).Cells(4).Value.ToString()
            txt_precioCU.Text = grilla_producto.Rows(e.RowIndex).Cells(5).Value.ToString()
            id_seleccionado = grilla_producto.Rows(e.RowIndex).Cells(0).Value.ToString()

            Dim subtabla As New DataTable
            subtabla = leo_tabla("select * from tipoProducto where descripcion='" & cbo_tipo_producto.Text & "'")
            idTipoProducto_seleccionado = subtabla.Rows(0)(0)

            btn_modificar.Enabled = True
            btn_eliminar.Enabled = True
        End If
    End Sub


    Private Sub txt_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock.KeyPress
        solo_numeros(sender, e)
    End Sub

    Private Sub txt_precioVU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precioVU.KeyPress
        solo_numeros(sender, e)
    End Sub

    Private Sub txt_precioCU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precioCU.KeyPress
        solo_numeros(sender, e)
    End Sub
End Class