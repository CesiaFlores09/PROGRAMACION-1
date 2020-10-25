Public Class frmBuscarcategorias
    Dim objConexion As New db_conexion
    Public _idct As Integer
    Private Sub frmBuscarcategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscarCategoria.DataSource = objConexion.obtenerDatos().Tables("categoria").DefaultView
    End Sub
    Private Sub filtrarDatosCategorias(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grbBuscarCategoria.DataSource
        bs.Filter = "categoria like '%" & valor & "%' "
        grbBuscarCategoria.DataSource = bs
    End Sub
    Private Sub seleccionarCategoria()
        _idct = grbBuscarCategoria.CurrentRow.Cells("idcategoria").Value.ToString()
        Close()
    End Sub

    Private Sub btnSeleccionarCategoria_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCategoria.Click
        _idct = grbBuscarCategoria.CurrentRow.Cells("idcategoria").Value.ToString()
        Close()
    End Sub

    Private Sub txtBuscarctegoria_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarctegoria.KeyUp
        filtrarDatosCategorias(txtBuscarctegoria.Text)
        If e.KeyCode = 13 Then
            seleccionarCategoria()
        End If
    End Sub

    Private Sub btnCancelarCateforia_Click(sender As Object, e As EventArgs) Handles btnCancelarCateforia.Click
        _idct = 0
        Close()
    End Sub
End Class