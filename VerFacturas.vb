Public Class VerFacturas

    Private Sub FormFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_facturas.DataSource = leo_tabla("select * from facturas")
    End Sub


    Private Sub dgv_facturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_facturas.CellDoubleClick
        If e.RowIndex >= 0 Then
            idFactura_global = dgv_facturas.Rows(e.RowIndex).Cells(0).Value.ToString()
            ImprimirFactura.ShowDialog()
        End If
    End Sub
End Class