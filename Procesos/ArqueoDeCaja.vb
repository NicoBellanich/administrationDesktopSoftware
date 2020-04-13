Public Class ArqueoDeCaja
    Dim cancelar As Boolean = True
    Dim usuario As String



    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click



        If txtUser.Text = "" Then
            MessageBox.Show("Ingrese el usuario")
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Ingrese la contrasaña")
            Exit Sub
        End If
        If txtUser2.Text = "" Then
            MessageBox.Show("Ingrese el usuario")
            Exit Sub
        End If

        If txtPassword2.Text = "" Then
            MessageBox.Show("Ingrese la contrasaña")
            Exit Sub
        End If
        If txtUser2.Text = txtUser.Text Then
            MessageBox.Show("Usuarios Iguales")
            Exit Sub
        End If
        If String.IsNullOrEmpty(txt_cierreCaja.Text) Then
            MessageBox.Show("Ingrese el monto del arqueo")
            Exit Sub
        End If

        If (frmPrincipial.validarCredencial(txtUser.Text, txtPassword.Text)) Then
            If (frmPrincipial.validarCredencial(txtUser2.Text, txtPassword2.Text)) Then

                cancelar = False
                usuario = Me.txtUser.Text
                usuario_global = txtUser.Text

                'Hace el arqueo aca
                'if que valide que no hay arqueo con usuario saliente y fecha igual

                'calcular lo que hizo el saliente

                Dim subtablaA As DataTable = leo_tabla("select SUM(total) from facturas where usuario='" & txtUser.Text & "'")

                If subtablaA.Rows.Count <= 0 Then
                    MessageBox.Show("No hay facturas correspondientes al usuario saliente para fecha actual")
                    Exit Sub
                End If

                Dim salienteMonto As Integer = subtablaA.Rows(0)(0)

                'guardar todo

                Dim usuarioSaliente As String = txtUser.Text
                Dim usuarioEntrante As String = txtUser2.Text
                Dim cierreCaja As Integer = txt_cierreCaja.Text
                Dim cierreCajaCalc As Integer = salienteMonto
                Dim fecha As Date = DateTimePicker1.Value


                comando.CommandType = CommandType.Text
                comando.Connection = conexion

                Dim time As String = DateTime.Now.ToShortTimeString

                conexion.Open()
                sql = " INSERT INTO cierreCaja (usuarioSaliente,usuarioEntrante,cierreCaja,cierreCajaCalculado,fecha,hora) VALUES ('" & usuarioSaliente & "','" & usuarioEntrante & "'," & cierreCaja & "," & cierreCajaCalc & ",'" & fecha & "','" & time & "' )"

                comando.CommandText = sql

                Try
                    comando.ExecuteNonQuery()
                    MsgBox("Se registro el Cierre correctamente")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                conexion.Close()


                'informar si hubo diferencia de lo que se anoto con lo que se calculo

                Dim diferencia As Integer = cierreCajaCalc - cierreCaja

                If diferencia <> 0 Then
                    MessageBox.Show("Diferencia de $ " & diferencia)
                Else
                    MessageBox.Show("Igual resultado Caja y Calculado")
                End If

                usuario_global = usuarioEntrante

                txt_cierreCaja.Clear()
                txtPassword.Clear()
                txtPassword2.Clear()
                txtUser.Clear()
                txtUser2.Clear()

            Else
                txtPassword.Clear()
                txtUser.Clear()
                txtPassword2.Clear()
                txtUser2.Clear()
                MsgBox("Usuario o contraseña incorrectos")
                txtUser.Focus()
            End If
        End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub ArqueoDeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = usuario_global

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validar_usuario() = False Then
            Exit Sub
        End If
        Me.Size = New System.Drawing.Size(550, 600)
        Dim subtabla As DataTable = leo_tabla("select * from cierreCaja")
        dgv_arqueo.DataSource = subtabla
    End Sub

    Private Sub txt_cierreCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cierreCaja.KeyPress
        solo_numeros(sender, e)
    End Sub
End Class
