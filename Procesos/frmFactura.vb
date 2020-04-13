Public Class frmFactura


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            Me.txt_idproducto.Enabled = False
            Me.txt_nombreproduc.Enabled = False
            Me.txt_precioprod.Text = tabla.Rows(0)("precioVentaUnit")
            Me.txt_cantidadprod.Text = 0
            Me.txt_cantidadprod.Focus()
            Me.Label9.Text = tabla.Rows(0)("stock")
            Me.btm_agregar.Enabled = True
            txt_precioprod.Enabled = False

        End If
    End Sub

    Private Sub frmFactura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        limpiar()
        Me.dvg_detalle.Rows.Clear()
        txt_total.Text = 0
    End Sub

    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar_combo(Me.cmb_tipoFactura, "nombre", "idTipo", "tipoFactura")
        Me.btm_agregar.Enabled = False
        Me.btm_quitar.Enabled = False
        carga()

    End Sub

    Private Sub carga()
        Dim tabla As New DataTable
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = "select max(idFactura) from facturas"
        tabla.Load(comando.ExecuteReader)
        conexion.Close()
        Me.txt_numFactura.Text = tabla.Rows(0)(0) + 1
    End Sub

    Private Sub btm_agregar_Click(sender As Object, e As EventArgs) Handles btm_agregar.Click
        Dim c As Integer
        Dim encontro As Integer = -1

        For c = 0 To Me.dvg_detalle.RowCount - 1
            If Me.dvg_detalle.Rows(c).Cells(0).Value = Me.txt_idproducto.Text Then
                encontro = c
                Exit For
            End If
        Next
        If encontro = c Then
            MessageBox.Show("No se puede agregar un producto por duplicado", "Atencion", MessageBoxButtons.OK)
            limpiar()
            Exit Sub
        End If
        If IsNumeric(Me.txt_cantidadprod.Text) Then
            If Me.txt_cantidadprod.Text <= 0 Then
                MessageBox.Show("La cantidad a vender debe ser mayor a 0", "Atencion", MessageBoxButtons.OK)
                Exit Sub
            End If
        Else
            MessageBox.Show("La cantidad debe ser un numero", "Atencion", MessageBoxButtons.OK)
            Exit Sub
        End If
        'Nota no valido si la cantidad no es entera FALTA
        If IsNumeric(Me.txt_precioprod.Text) Then
            If Me.txt_precioprod.Text <= 0 Then
                MessageBox.Show("La precio a vender debe ser mayor a 0", "Atencion", MessageBoxButtons.OK)
                Exit Sub
            End If
        Else
            MessageBox.Show("La precio debe ser un numero", "Atencion", MessageBoxButtons.OK)
            Exit Sub
        End If

        If Me.txt_cantidadprod.Text > CType(Me.Label9.Text, Integer) Then
            MessageBox.Show("No se puede vender una cantidad mayor a la disponible", "Atencion", MessageBoxButtons.OK)
            Exit Sub
        End If
        dvg_detalle.Rows.Add(Me.txt_idproducto.Text,
                            Me.txt_nombreproduc.Text,
                            Me.txt_cantidadprod.Text,
                            Me.txt_precioprod.Text,
                            Me.txt_cantidadprod.Text * Me.txt_precioprod.Text,
                            Me.Label9.Text)
        limpiar()
        calcular_total()
        btm_quitar.Enabled = True
        txt_precioprod.Enabled = True
    End Sub
    Private Sub calcular_total()
        Dim c As Integer
        Dim calculo As Double
        calculo = 0
        For c = 0 To Me.dvg_detalle.RowCount - 1
            calculo = calculo + Convert.ToDouble(Me.dvg_detalle.Rows(c).Cells(4).Value)
        Next
        Me.txt_total.Text = calculo
    End Sub

    Private Sub btm_cancelar_Click(sender As Object, e As EventArgs) Handles btm_cancelar.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        Me.txt_idproducto.Text = ""
        Me.txt_nombreproduc.Text = ""
        Me.txt_cantidadprod.Text = ""
        Me.txt_precioprod.Text = ""
        Me.Label9.Text = "0"
        calcular_total()
        Me.txt_idproducto.Enabled = True
        Me.txt_nombreproduc.Enabled = True
        Me.btm_agregar.Enabled = False

    End Sub


    Private Sub btm_guardar_Click(sender As Object, e As EventArgs) Handles btm_guardar.Click
        If Me.dvg_detalle.Rows.Count = 0 Then
            MsgBox("Debe agregar un producto al menos")
            Exit Sub
        End If
        Dim consulta As String
        Dim consulta2, consulta3 As String
        consulta = "Insert into facturas( idFactura ,tipo  ,fecha, total, usuario) values ( " & Me.txt_numFactura.Text & " , '" & Me.cmb_tipoFactura.Text & "' , '" & dtp_fecha1.Value & "', " & Me.txt_total.Text & ", '" & usuario_global & "' )"
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text

        idFactura_global = Me.txt_numFactura.Text

        Try
            For i = 0 To Me.dvg_detalle.Rows.Count - 1
                If i = 0 Then
                    comando.CommandText = consulta
                    comando.ExecuteNonQuery()
                End If
                consulta3 = "UPDATE producto SET stock = " & Me.dvg_detalle.Rows(i).Cells(5).Value - Me.dvg_detalle.Rows(i).Cells(2).Value & " WHERE idProducto = " & Me.dvg_detalle.Rows(i).Cells(0).Value
                comando.CommandText = consulta3
                comando.ExecuteNonQuery()
                consulta2 = "INSERT INTO detalleXfactura (idfactura,idproducto,cantidad,precioventa) VALUES (" & Me.txt_numFactura.Text & " , " & Me.dvg_detalle.Rows(i).Cells(0).Value & " , " & Me.dvg_detalle.Rows(i).Cells(2).Value & " , " & Me.dvg_detalle.Rows(i).Cells(4).Value & ")"
                comando.CommandText = consulta2
                comando.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try

        MsgBox("La factura se ha resgistrado con exito")
        limpiar()

        conexion.Close()

        Dim Imprimir As New ImprimirFactura
        Imprimir.ShowDialog()
        Me.dvg_detalle.Rows.Clear()
        txt_total.Text = ""
        carga()


    End Sub

    Private Sub btm_buscar2_Click(sender As Object, e As EventArgs) Handles btm_buscar2.Click
        'Dim id As Integer
        'frmBuscarProductos.Show()
        Dim frm1 As New frmBuscarProductos
        frm1.ShowDialog()
        Dim idBuscar As Integer = frm1.buscar()

        If idBuscar > 0 Then

            Dim subtabla As New DataTable
            subtabla = leo_tabla("Select * from producto where idProducto=" & idBuscar)
            txt_idproducto.Text = subtabla.Rows(0)(0)
            txt_nombreproduc.Text = subtabla.Rows(0)(4)
            txt_precioprod.Text = subtabla.Rows(0)(2)
            Label9.Text = subtabla.Rows(0)(3)
            txt_idproducto.Enabled = False
            txt_nombreproduc.Enabled = False
            btm_agregar.Enabled = True
            txt_precioprod.Enabled = False

        End If

    End Sub

    Private Sub btm_quitar_Click(sender As Object, e As EventArgs) Handles btm_quitar.Click

        If MsgBox("Está seguno que desea borrar esta fila de la grilla", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Importante") = MsgBoxResult.Yes Then
            Me.dvg_detalle.Rows.RemoveAt(Me.dvg_detalle.CurrentRow.Index)
            calcular_total()
        End If

        If dvg_detalle.Rows.Count = 0 Then
            btm_quitar.Enabled = False
        End If

    End Sub

    Private Sub txt_numFactura_TextChanged(sender As Object, e As EventArgs)
        Try
            comando.ExecuteNonQuery()
            MsgBox("Se registro el Pedido correctamente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



    Private Sub txt_cantidadprod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadprod.KeyPress
        solo_numeros(sender, e)
    End Sub

    Private Sub txt_precioprod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precioprod.KeyPress
        solo_numeros(sender, e)
    End Sub

    Private Sub txt_idproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idproducto.KeyPress
        solo_numeros(sender, e)
    End Sub
End Class