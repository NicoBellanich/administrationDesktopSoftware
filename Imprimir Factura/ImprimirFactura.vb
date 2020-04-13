Public Class ImprimirFactura

    Private Sub ImprimirFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet4.facturas' Puede moverla o quitarla según sea necesario.
        Me.facturasTableAdapter.Fill(Me.DataSet4.facturas, idFactura_global)
        'TODO: esta línea de código carga datos en la tabla 'DataSet4.detalleXfactura' Puede moverla o quitarla según sea necesario.
        Me.detalleXfacturaTableAdapter.Fill(Me.DataSet4.detalleXfactura, idFactura_global)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class