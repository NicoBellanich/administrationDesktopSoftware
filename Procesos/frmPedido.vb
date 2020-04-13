Public Class frmPedido

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrEmpty(txt_idproducto.Text) Then
            MessageBox.Show("Debe Ingresar Id", "Error")
            Exit Sub
        End If

        Dim tabla As New DataTable
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        If IsNumeric(Me.txt_idproducto.Text) = False Then
            MessageBox.Show("El id debe ser numerico", "Atencion", MessageBoxButtons.OK)
            Exit Sub
        End If

        comando.CommandText = "select * from producto where idProducto = " & Me.txt_idproducto.Text
        tabla.Load(comando.ExecuteReader)
        conexion.Close()

        If tabla.Rows.Count() = 0 Then
            MsgBox("Producto no encotrado")
        Else
            Me.txt_nombreproduc.Text = tabla.Rows(0)("nombre")
            Me.txt_precioprod.Text = tabla.Rows(0)("precioCompraUnit")
            Me.txt_cantidadprod.Text = 0
            Me.txt_cantidadprod.Focus()
            Me.Label9.Text = tabla.Rows(0)("stock")
            Me.btn_agregar.Enabled = True
            Me.txt_idproducto.Enabled = False
            Me.txt_nombreproduc.Enabled = False
        End If
    End Sub

   

    Private Sub frmPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgv_pedidos_enCurso.DataSource = leo_tabla("select * from pedido ")
        btn_agregar.Enabled = False
        btn_quitar.Enabled = False
        btn_terminar.Enabled = False
        btn_cancelar.Enabled = False

    End Sub

    Private Sub btm_buscar2_Click(sender As Object, e As EventArgs) Handles btm_buscar2.Click
        Dim frm1 As New frmBuscarProductos
        frm1.ShowDialog()
        Dim idBuscar As Integer = frm1.buscar()

        If idBuscar > 0 Then

            Dim subtabla As New DataTable
            subtabla = leo_tabla("Select * from producto where idProducto=" & idBuscar)
            txt_idproducto.Text = subtabla.Rows(0)(0)
            txt_nombreproduc.Text = subtabla.Rows(0)(4)
            txt_precioprod.Text = subtabla.Rows(0)(5)
            Label9.Text = subtabla.Rows(0)(3)
            txt_idproducto.Enabled = False
            txt_nombreproduc.Enabled = False
            btn_agregar.Enabled = True
            txt_precioprod.Enabled = False

        End If
    End Sub

    Private Sub btm_cancelar_Click(sender As Object, e As EventArgs) Handles btm_cancelar.Click
        txt_idproducto.Clear()
        txt_idproducto.Enabled = True
        txt_nombreproduc.Clear()
        txt_nombreproduc.Enabled = True
        txt_precioprod.Clear()
        txt_precioprod.Enabled = True
        txt_cantidadprod.Clear()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If String.IsNullOrEmpty(txt_cantidadprod.Text) Then
            txt_cantidadprod.Clear()
            txt_cantidadprod.Focus()
            MessageBox.Show("Debe agregar cantidad valida")
            Exit Sub
        End If

        If CType(txt_cantidadprod.Text, Integer) <= 0 Then
            txt_cantidadprod.Clear()
            txt_cantidadprod.Focus()
            MessageBox.Show("Debe agregar cantidad valida")
            Exit Sub
        End If


        For i = 0 To dgv_pedidos.RowCount - 1
            If txt_idproducto.Text = CStr(dgv_pedidos.Rows(i).Cells(0).Value) Then
                MessageBox.Show("El producto ya esta agregado")
                Exit Sub
            End If
        Next

        Dim subtotal As Integer = txt_cantidadprod.Text * txt_precioprod.Text

        Dim nuevaFila() As String = {txt_idproducto.Text, txt_nombreproduc.Text, txt_precioprod.Text, txt_cantidadprod.Text, Label9.Text, subtotal}

        dgv_pedidos.Rows.Add(nuevaFila)

        Dim sumatotal As Integer = 0
        For i = 0 To dgv_pedidos.RowCount - 1
            sumatotal = sumatotal + CStr(dgv_pedidos.Rows(i).Cells(5).Value)
        Next
        lbl_total.Text = sumatotal

    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        dgv_pedidos.Rows.Remove(dgv_pedidos.CurrentRow)
        Dim sumatotal As Integer = 0
        For i = 0 To dgv_pedidos.RowCount - 1
            sumatotal = sumatotal + CStr(dgv_pedidos.Rows(i).Cells(5).Value)
        Next
        lbl_total.Text = sumatotal

        If dgv_pedidos.Rows.Count = 0 Then
            btn_quitar.Enabled = False
        End If

    End Sub

    Private Sub dgv_pedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellClick
        If e.RowIndex >= 0 Then
            btn_quitar.Enabled = True
        End If
    End Sub

    Private Sub btn_realizarPedido_Click(sender As Object, e As EventArgs) Handles btn_realizarPedido.Click

        If dgv_pedidos.RowCount = 0 Then
            MessageBox.Show("No ha especificado ningun producto")
            Exit Sub
        End If

        'agregar pedido

        Dim fecha As Date = DateTime.Now


        comando.CommandType = CommandType.Text
        comando.Connection = conexion

        conexion.Open()
        sql = " INSERT INTO pedido (fecha,estado,usuario,total) values ('" & fecha & "','En Curso','" & usuario_global & "'," & lbl_total.Text & ")"
        comando.CommandText = sql

        Try
            comando.ExecuteNonQuery()
            MsgBox("Se registro el Pedido correctamente")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        conexion.Close()
        dgv_pedidos_enCurso.DataSource = leo_tabla("select * from pedido")

        Dim subtabla1 As DataTable = leo_tabla("select * from pedido")
        Dim ultimoid As Integer = subtabla1.Rows(subtabla1.Rows.Count - 1)(0)


        'for en el detalle

        For i = 0 To dgv_pedidos.RowCount - 1
            Dim id_prod As Integer = dgv_pedidos.Rows(i).Cells(0).Value
            'Dim nombre As String = dgv_pedidos.Rows(i).Cells(1).Value
            Dim precio As Integer = dgv_pedidos.Rows(i).Cells(2).Value
            Dim cantidad As Integer = dgv_pedidos.Rows(i).Cells(3).Value
            Dim subtotal As Integer = dgv_pedidos.Rows(i).Cells(2).Value * dgv_pedidos.Rows(i).Cells(3).Value

            comando.CommandType = CommandType.Text
            comando.Connection = conexion

            conexion.Open()
            sql = " INSERT INTO detallePedido (idPedido,idProducto,cantidad,precio,subtotal) values (" & ultimoid & "," & id_prod & "," & cantidad & "," & precio & "," & subtotal & ")"
            comando.CommandText = sql

            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            conexion.Close()
        Next

        txt_idproducto.Clear()
        txt_cantidadprod.Clear()
        txt_nombreproduc.Clear()
        txt_precioprod.Clear()
        dgv_pedidos.Rows.Clear()
        lbl_total.Text = 0
    End Sub




  
    Private Sub btn_terminar_Click(sender As Object, e As EventArgs) Handles btn_terminar.Click

        Dim result As Integer = MessageBox.Show("¿Seguro desea Terminar el pedido?", "Mensaje", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            comando.CommandType = CommandType.Text
            comando.Connection = conexion

            conexion.Open()

            comando.CommandText = "UPDATE pedido SET estado='Terminado' where idPedido=" & dgv_pedidos_enCurso.CurrentRow.Cells(0).Value

            Try
                comando.ExecuteNonQuery()
                MsgBox("Se modificó el Estado correctamente")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            conexion.Close()



            'Agregar lo que traia el pedido al stock

            Dim subtabla As DataTable = leo_tabla("select * from detallePedido where idPedido= " & dgv_pedidos_enCurso.CurrentRow.Cells(0).Value)


            For i = 0 To subtabla.Rows.Count - 1

                Dim idProducto As Integer = subtabla.Rows(i)(2)
                Dim cantidad As Integer = subtabla.Rows(i)(3)

                Dim subtabla2 As DataTable = leo_tabla("select * from producto where idProducto= " & idProducto)
                Dim stock As Integer = subtabla2.Rows(0)(3)
                Dim nuevoStock As Integer = stock + cantidad

                comando.CommandType = CommandType.Text
                comando.Connection = conexion

                conexion.Open()

                comando.CommandText = "UPDATE producto SET stock= " & nuevoStock & "  where idProducto=" & idProducto

                Try
                    comando.ExecuteNonQuery()
                    MsgBox("Se modificó el Stock correctamente")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                conexion.Close()

                dgv_pedidos_enCurso.DataSource = leo_tabla("select * from pedido ")

            Next
        End If




    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

        Dim result As Integer = MessageBox.Show("¿Seguro desea cancelar el pedido?", "Mensaje", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            comando.CommandType = CommandType.Text
            comando.Connection = conexion

            conexion.Open()

            comando.CommandText = "UPDATE pedido SET estado='Cancelado' where idPedido=" & dgv_pedidos_enCurso.CurrentRow.Cells(0).Value

            Try
                comando.ExecuteNonQuery()
                MsgBox("Se modificó el Estado correctamente")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            conexion.Close()

            dgv_pedidos_enCurso.DataSource = leo_tabla("select * from pedido ")
        End If



    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    '    If dgv_pedidos.Rows.Count = 0 Then
    '        Exit Sub
    '    End If

    '    txt_idproducto.Clear()
    '    txt_idproducto.Enabled = True
    '    txt_nombreproduc.Clear()
    '    txt_nombreproduc.Enabled = True
    '    txt_precioprod.Clear()
    '    txt_precioprod.Enabled = True
    '    txt_cantidadprod.Clear()

    '    For i = 0 To dgv_pedidos.Rows.Count - 1
    '        dgv_pedidos.Rows.Clear()
    '    Next

    '    lbl_total.Text = 0

    'End Sub

    Private Sub frmPedido_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing



        txt_idproducto.Clear()
        txt_idproducto.Enabled = True
        txt_nombreproduc.Clear()
        txt_nombreproduc.Enabled = True
        txt_precioprod.Clear()
        txt_precioprod.Enabled = True
        txt_cantidadprod.Clear()

        For i = 0 To dgv_pedidos.Rows.Count - 1
            dgv_pedidos.Rows.Clear()
        Next

        lbl_total.Text = 0
    End Sub

    Private Sub txt_cantidadprod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadprod.KeyPress
        solo_numeros(sender, e)
    End Sub

    Private Sub txt_idproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idproducto.KeyPress
        solo_numeros(sender, e)
    End Sub

    Private Sub txt_precioprod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precioprod.KeyPress
        solo_numeros(sender, e)
    End Sub

    'Private Sub dgv_pedidos_enCurso_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos_enCurso.CellContentClick
    '    If dgv_pedidos_enCurso.Rows(e.RowIndex).Cells(2).Value.ToString() = "En Curso" Then
    '        btn_cancelar.Enabled = True
    '        btn_terminar.Enabled = True
    '    End If
    'End Sub
    Private Sub dgv_pedidos_enCurso_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos_enCurso.CellClick
        'MessageBox.Show(dgv_pedidos_enCurso.CurrentRow.Cells(0).Value)
        dgv_detalle.DataSource = leo_tabla("select dp.numeroDetalle, dp.idPedido, p.nombre, dp.cantidad, dp.precio  from detallePedido dp inner join producto p on dp.idProducto=p.idProducto where idPedido= " & dgv_pedidos_enCurso.CurrentRow.Cells(0).Value)
        If dgv_pedidos_enCurso.Rows(e.RowIndex).Cells(2).Value.ToString().Trim() = "En Curso" Then
            btn_cancelar.Enabled = True
            btn_terminar.Enabled = True
        End If
        If dgv_pedidos_enCurso.Rows(e.RowIndex).Cells(2).Value.ToString().Trim() <> "En Curso" Then
            btn_cancelar.Enabled = False
            btn_terminar.Enabled = False
        End If
    End Sub
   
End Class