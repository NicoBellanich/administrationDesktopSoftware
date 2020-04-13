<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProductos
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
        Me.dvg_buscaProduc = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btm_acceptar = New System.Windows.Forms.Button()
        CType(Me.dvg_buscaProduc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvg_buscaProduc
        '
        Me.dvg_buscaProduc.AllowUserToAddRows = False
        Me.dvg_buscaProduc.AllowUserToDeleteRows = False
        Me.dvg_buscaProduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_buscaProduc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dvg_buscaProduc.Location = New System.Drawing.Point(31, 38)
        Me.dvg_buscaProduc.Name = "dvg_buscaProduc"
        Me.dvg_buscaProduc.ReadOnly = True
        Me.dvg_buscaProduc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_buscaProduc.Size = New System.Drawing.Size(243, 212)
        Me.dvg_buscaProduc.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Producto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'btm_acceptar
        '
        Me.btm_acceptar.Location = New System.Drawing.Point(199, 256)
        Me.btm_acceptar.Name = "btm_acceptar"
        Me.btm_acceptar.Size = New System.Drawing.Size(75, 23)
        Me.btm_acceptar.TabIndex = 1
        Me.btm_acceptar.Text = "Aceptar"
        Me.btm_acceptar.UseVisualStyleBackColor = True
        '
        'frmBuscarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 291)
        Me.Controls.Add(Me.btm_acceptar)
        Me.Controls.Add(Me.dvg_buscaProduc)
        Me.Name = "frmBuscarProductos"
        Me.Text = "Listado Productos"
        CType(Me.dvg_buscaProduc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvg_buscaProduc As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btm_acceptar As Button
End Class
