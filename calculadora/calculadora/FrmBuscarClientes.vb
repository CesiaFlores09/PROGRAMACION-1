Public Class FrmBuscarClientes
    Dim objConexion As New db_conexion
    Public _idc As Integer
    Private Sub FrmBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscarCliente.DataSource = objConexion.obtenerDatos().Tables("clientes").DefaultView
    End Sub

    Private Sub btnSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCliente.Click
        seleccionarCliente()
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp

        filtrarDatosClientes(txtBuscar.Text)
        If e.KeyCode = 13 Then
            seleccionarCliente()
        End If
    End Sub
    Private Sub seleccionarCliente()
        _idc = grbBuscarCliente.CurrentRow.Cells("Idclientes").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatosClientes(ByVal valor As String)
        Dim bs As New BindingSource
        bs.DataSource = grbBuscarCliente.DataSource
        bs.Filter = "codigo like '%" & valor & "%'  or nombre like '%" & valor & "%'"
        grbBuscarCliente.DataSource = bs
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idc = 0
        Close()
    End Sub
End Class