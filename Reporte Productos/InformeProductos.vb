Public Class InformeProductos

    Private Sub ListadoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.masVendidoTableAdapter.Fill(Me.DataSet2.masVendido)
        Me.ProductoTableAdapter.Fill(Me.DataSet2.Producto)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
        Me.ReportViewer3.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        txt_filtro.Text = txt_filtro.Text.Replace(" ", String.Empty)
        If txt_filtro.Text = "" Then
            MessageBox.Show("Inserte un valor para comparar")
            Exit Sub
        End If
        Me.ProductoTableAdapter.FillBy(Me.DataSet2.Producto, txt_filtro.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub txt_filtro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_filtro.KeyPress
        solo_numeros(sender, e)
    End Sub


End Class