Public Class InformePedidos

    Private Sub ListadoPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cbo_filtroEstados.Text = "Todos"
        Me.pedidoTableAdapter.Fill(Me.DataSet1.pedido)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        If cbo_filtroEstados.Text = "Todos" Then
            Me.pedidoTableAdapter.Fill(Me.DataSet1.pedido)
            Me.ReportViewer1.RefreshReport()
            Exit Sub
        End If
        Me.pedidoTableAdapter.FillBy(DataSet1.pedido, cbo_filtroEstados.Text)
        Me.ReportViewer1.RefreshReport()

    End Sub



    Private Sub ReportViewer2_Load(sender As Object, e As EventArgs) Handles ReportViewer2.Load

    End Sub
End Class