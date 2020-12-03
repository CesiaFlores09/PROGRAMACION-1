Public Class frmBuscarPuestoLaboral
    Dim objConexion As New db_conexion
    Public _idPL As Integer
    Private Sub frmBuscarPuestoLaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscarPuesto.DataSource = objConexion.obtenerDatos().Tables("puesto").DefaultView
    End Sub
    Private Sub filtrarDatosPuesto(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grbBuscarPuesto.DataSource
        bs.Filter = "puesto like '%" & valor & "%' "
        grbBuscarPuesto.DataSource = bs
    End Sub
    Private Sub seleccionarPuesto()
        _idPL = grbBuscarPuesto.CurrentRow.Cells("idpuestolaboral").Value.ToString()
        Close()
    End Sub

    Private Sub btnSeleccionarPuesto_Click(sender As Object, e As EventArgs) Handles btnSeleccionarPuesto.Click
        _idPL = grbBuscarPuesto.CurrentRow.Cells("idpuestolaboral").Value.ToString()
        Close()
    End Sub

    Private Sub btnCancelarPuesto_Click(sender As Object, e As EventArgs) Handles btnCancelarPuesto.Click
        _idPL = 0
        Close()
    End Sub

    Private Sub txtBuscarPuesto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarPuesto.KeyUp
        filtrarDatosPuesto(txtBuscarPuesto.Text)
        If e.KeyCode = 13 Then
            seleccionarPuesto()
        End If
    End Sub
End Class