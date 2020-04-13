<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.facturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet4 = New WindowsApplication1.DataSet4()
        Me.detalleXfacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.facturasTableAdapter = New WindowsApplication1.DataSet4TableAdapters.facturasTableAdapter()
        Me.detalleXfacturaTableAdapter = New WindowsApplication1.DataSet4TableAdapters.detalleXfacturaTableAdapter()
        CType(Me.facturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detalleXfacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'facturasBindingSource
        '
        Me.facturasBindingSource.DataMember = "facturas"
        Me.facturasBindingSource.DataSource = Me.DataSet4
        '
        'DataSet4
        '
        Me.DataSet4.DataSetName = "DataSet4"
        Me.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'detalleXfacturaBindingSource
        '
        Me.detalleXfacturaBindingSource.DataMember = "detalleXfactura"
        Me.detalleXfacturaBindingSource.DataSource = Me.DataSet4
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.facturasBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.detalleXfacturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report10.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(658, 548)
        Me.ReportViewer1.TabIndex = 0
        '
        'facturasTableAdapter
        '
        Me.facturasTableAdapter.ClearBeforeFill = True
        '
        'detalleXfacturaTableAdapter
        '
        Me.detalleXfacturaTableAdapter.ClearBeforeFill = True
        '
        'ImprimirFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 572)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ImprimirFactura"
        Me.Text = "ImprimirFactura"
        CType(Me.facturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detalleXfacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents facturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet4 As WindowsApplication1.DataSet4
    Friend WithEvents detalleXfacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents facturasTableAdapter As WindowsApplication1.DataSet4TableAdapters.facturasTableAdapter
    Friend WithEvents detalleXfacturaTableAdapter As WindowsApplication1.DataSet4TableAdapters.detalleXfacturaTableAdapter
End Class
