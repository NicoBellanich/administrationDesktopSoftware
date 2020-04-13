Public Class frmBuscarProductos

    Dim idGlobal As Integer = -3

    Private Sub dvg_buscaProduc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvg_buscaProduc.CellClick
        idGlobal = dvg_buscaProduc.CurrentRow.Cells(0).Value
    End Sub


    Private Sub buscarProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tabla As New DataTable
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = "select idProducto, nombre from producto "
        tabla.Load(comando.ExecuteReader)
        conexion.Close()
        Dim i As Integer
        For i = 0 To tabla.Rows.Count() - 1
            Me.dvg_buscaProduc.Rows.Add(tabla.Rows(i)("idProducto"), tabla.Rows(i)("nombre"))
        Next
    End Sub

    Private Sub btm_acceptar_Click(sender As Object, e As EventArgs) Handles btm_acceptar.Click
        Me.Close()
    End Sub

    Public Function buscar() As Integer
        If idGlobal < 0 Then
            'MessageBox.Show("Debe seleccionar algun producto")
            Return -3
            Exit Function
        End If
        Return idGlobal
    End Function




End Class