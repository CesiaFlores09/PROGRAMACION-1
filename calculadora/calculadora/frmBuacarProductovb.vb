Public Class frmBuacarProductovb
    Dim objConexion As New db_conexion
    Public _idpr As Integer
    Private Sub frmBuacarProductovb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscarProducto.DataSource = objConexion.obtenerDatos().Tables("producto").DefaultView
    End Sub
    Private Sub filtrarDatosProductos(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grbBuscarProducto.DataSource
        bs.Filter = "codigo like '%" & valor & "%'  or nombre like '%" & valor & "%' or categoria like '%" & valor & "%'"
        grbBuscarProducto.DataSource = bs
    End Sub

    Private Sub btnSeleccionarProducto_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProducto.Click
        _idpr = grbBuscarProducto.CurrentRow.Cells("idproducto").Value.ToString()
        Close()
    End Sub

    Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
        _idpr = 0
        Close()
    End Sub
    Private Sub seleccionarProducto()
        _idpr = grbBuscarProducto.CurrentRow.Cells("idproducto").Value.ToString()
        Close()
    End Sub


    Private Sub txtBuscarProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarProducto.KeyUp
        filtrarDatosProductos(txtBuscarProducto.Text)
        If e.KeyCode = 13 Then
            seleccionarProducto()
        End If
    End Sub


End Class