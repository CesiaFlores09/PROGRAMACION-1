Public Class frmListadoCategorias
    Private Sub frmListadoCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.categoria' Puede moverla o quitarla según sea necesario.
        Me.categoriaTableAdapter.Fillcategoria(Me.bd_empresaDataSet.categoria)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class