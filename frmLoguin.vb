Public Class frmLoguin
    Dim cancelar As Boolean = True
    Dim usuario As String
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If MessageBox.Show("De verdad desea salir", "salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
        e.Cancel = cancelar

        'Else
        '    End
        'End If
    End Sub


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click



        If txtUser.Text = "" Then
            MessageBox.Show("Ingrese el usuario")
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Ingrese la contrasaña")
            Exit Sub
        End If

        If (frmPrincipial.validarCredencial(txtUser.Text, txtPassword.Text)) Then
            ' MsgBox("BRAVO INGRESO AL SISTEMA!")
            cancelar = False
            usuario = Me.txtUser.Text
            Me.Close()
        Else
            txtPassword.Clear()
            txtUser.Clear()
            MsgBox("User o contraseña incorrectos")
            txtUser.Focus()
        End If



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Me.Close()
        End
    End Sub

    Private Sub frmLoguin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function devolverUsuario()

        Return usuario
    End Function
End Class
