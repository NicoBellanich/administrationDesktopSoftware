Public Class frmPrincipial

    Private Sub frmPrincipial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Dim frm2 As New frmPrincipial
        frm2.Show()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmLogin As New frmLoguin
        frmLogin.ShowDialog()
        labelUsuario.Text = frmLogin.devolverUsuario()
        usuario_global = labelUsuario.Text

    End Sub



    Private Sub btn_regProveedor_Click(sender As Object, e As EventArgs)
        frmProveedor.Show()
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs)
        frmProducto.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmEmpleado.Show()
    End Sub

    Private Sub btm_factura_Click(sender As Object, e As EventArgs)
        frmFactura.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmPedido.Show()
    End Sub

    Private Sub btm_abmusuario_Click(sender As Object, e As EventArgs)
        frmABMUsuarios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UsusariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsusariosToolStripMenuItem.Click

    End Sub

    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        frmPedido.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedor.ShowDialog()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        frmProducto.ShowDialog()
    End Sub

    Private Sub EmpreadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpreadoToolStripMenuItem.Click
        frmEmpleado.ShowDialog()
    End Sub

    Private Sub PedidosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem1.Click
        Dim infopedidos As New InformePedidos
        infopedidos.Show()
        infopedidos.Hide()
        infopedidos.ShowDialog()


    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        InformeProductos.ShowDialog()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem.Click
        InformeFacturas.ShowDialog()
    End Sub

    Private Sub AdministrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarToolStripMenuItem.Click
        frmABMUsuarios.ShowDialog()
    End Sub



    Public Function validarCredencial(pUsuario As String, pPassword As String) As Boolean
        Dim tabla As New Data.DataTable
        Dim consulta As String
        consulta = "Select * from usuario where nombre= '" & pUsuario & "' and contraseña = '" & pPassword & "'"

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = consulta
        tabla.Load(comando.ExecuteReader)
        conexion.Close()

        If tabla.Rows.Count = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AgregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregaToolStripMenuItem.Click
        frmFactura.ShowDialog()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        VerFacturas.ShowDialog()
    End Sub

    Private Sub ArqueoDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArqueoDeCajaToolStripMenuItem.Click
        Dim arqueo As New ArqueoDeCaja
        arqueo.ShowDialog()
        labelUsuario.Text = usuario_global
    End Sub
End Class