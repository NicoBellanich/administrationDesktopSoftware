Public Class InformeFacturas

    Private Sub InformeFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet3.facturas' Puede moverla o quitarla según sea necesario.
        Me.facturasTableAdapter.Fill(Me.DataSet3.facturas)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.facturasTableAdapter.FillBy(Me.DataSet3.facturas, DateTimePicker1.Value, DateTimePicker2.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class