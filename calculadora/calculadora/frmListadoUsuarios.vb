Public Class frmListadoUsuarios
    Private Sub frmListadoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.usuarioTableAdapter.Fill(Me.bd_empresaDataSet.usuario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class