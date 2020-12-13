Public Class frmListadoProductos
    Private Sub frmListadoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.ListadoProductos' Puede moverla o quitarla según sea necesario.
        Me.ListadoProductosTableAdapter.FillListadoProductos(Me.bd_empresaDataSet.ListadoProductos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class