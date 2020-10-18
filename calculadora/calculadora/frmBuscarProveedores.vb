Public Class frmBuscarProveedores
    Dim objConexion As New db_conexion
    Public _idp As Integer
    Private Sub frmBuscarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscarProveedores.DataSource = objConexion.obtenerDatos().Tables("proveedores").DefaultView
    End Sub
    Private Sub filtrarDatosProveedores(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grbBuscarProveedores.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or nombre like '%" & valor & "%'"
        grbBuscarProveedores.DataSource = bs
    End Sub
    Private Sub seleccionarProveedores()
        _idp = grbBuscarProveedores.CurrentRow.Cells("idProveedores").Value.ToString()
        Close()
    End Sub
    Private Sub txtBuscarProveedores_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarProveedores.KeyUp
        filtrarDatosProveedores(txtBuscarProveedores.Text)
        If e.KeyCode = 13 Then
            seleccionarProveedores()
        End If
    End Sub

    Private Sub btnSeleccionarProveedor_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProveedor.Click
        seleccionarProveedores()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idp = 0
        Close()
    End Sub
End Class
