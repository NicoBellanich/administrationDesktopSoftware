Module Globales
    Public usuario_root As String = "admin"
    Public usuario_global As String
    Public idFactura_global As Integer
    Public conexion_string As String = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=axionF;Data Source=NICO-PC\SQLEXPRESS"

    Public sql As String = ""
    Public conexion As New OleDb.OleDbConnection(conexion_string)
    Public comando As New OleDb.OleDbCommand


    Public Function leo_tabla(ByVal sql As String) As DataTable
        Dim tabla As New DataTable
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        tabla.Load(comando.ExecuteReader)
        conexion.Close()
        Return tabla
    End Function

    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal displaym As String, ByVal valuem As String, ByVal tabla As String)
        combo.DataSource = leo_tabla("select * from " & tabla)
        combo.DisplayMember = displaym
        combo.ValueMember = valuem


    End Sub
    Public Sub cargargrilla(nombre_grilla, nombre_grilla_interfaz)

        Dim ds As New DataSet
        sql = "SELECT * FROM " & nombre_grilla

        Dim adap As New OleDb.OleDbDataAdapter(sql, conexion)
        ds.Tables.Add("tabla")
        adap.Fill(ds.Tables("tabla"))

        nombre_grilla_interfaz.DataSource = ds.Tables("tabla")

    End Sub


    'Invalidar numeros

    Public Sub solo_numeros(ByVal senderx As Object, ByVal ex As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(ex.KeyChar) Then
            ex.Handled = False
        ElseIf Char.IsControl(ex.KeyChar) Then
            ex.Handled = False
        ElseIf Char.IsSeparator(ex.KeyChar) Then
            ex.Handled = False
        Else
            ex.Handled = True
        End If
    End Sub

    Public Function validar_usuario()
        If usuario_global <> usuario_root Then
            MessageBox.Show("No tiene permisos de usuario", "Error")
            Return False
        End If
        Return True
    End Function

End Module
