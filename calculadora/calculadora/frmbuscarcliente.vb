Public Class frmbuscarcliente
    Dim objConexion As New db_conexion
    Public _idcl As Integer
    Private Sub frmbuscarcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscarCliente.DataSource = objConexion.obtenerDatos().Tables("cliente").DefaultView
    End Sub

    Private Sub btnSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCliente.Click
        seleccionarCliente()
    End Sub
    Private Sub filtrarDatosCliente(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grbBuscarCliente.DataSource
        bs.Filter = "codigo like '%" & valor & "%'  or nombre like '%" & valor & "%'"
        grbBuscarCliente.DataSource = bs
    End Sub
    Private Sub seleccionarCliente()
        _idcl = grbBuscarCliente.CurrentRow.Cells("idCliente").Value.ToString()
        Close()
    End Sub

    Private Sub btnCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnCancelarCliente.Click
        _idcl = 0
        Close()
    End Sub

    Private Sub txtBuscarCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarCliente.KeyUp
        filtrarDatosCliente(txtBuscarCliente.Text)
        If e.KeyCode = 13 Then
            seleccionarCliente()
        End If
    End Sub

End Class