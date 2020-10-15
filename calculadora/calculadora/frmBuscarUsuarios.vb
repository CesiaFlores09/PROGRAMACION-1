Public Class frmBuscarUsuarios
    Dim objConexion As New db_conexion
    Public _idU As Integer

    Private Sub frmBuscarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarUsuario.DataSource = objConexion.obtenerDatos().Tables("usuario").DefaultView
    End Sub

    Private Sub btnSeleccionarUsuario_Click(sender As Object, e As EventArgs) Handles btnSeleccionarUsuario.Click
        seleccionarUsuario()
    End Sub

    Private Sub filtrarDatosUsuarios(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarUsuario.DataSource
        bs.Filter = "nombres like '%" & valor & "%' or apellidos like '%" & valor & "%' or clave like '%" & valor & "%'"
        grdBuscarUsuario.DataSource = bs
    End Sub

    Private Sub seleccionarUsuario()
        _idU = grdBuscarUsuario.CurrentRow.Cells("idusuario").Value.ToString()
        Close()
    End Sub

    Private Sub btnCancelarUsuario_Click(sender As Object, e As EventArgs) Handles btnCancelarUsuario.Click
        _idU = 0
        Close()
    End Sub

    Private Sub txtBuscarUsuario_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarUsuario.KeyUp
        filtrarDatosUsuarios(txtBuscarUsuario.Text)
        If e.KeyCode = 13 Then
            seleccionarUsuario()
        End If
    End Sub

End Class