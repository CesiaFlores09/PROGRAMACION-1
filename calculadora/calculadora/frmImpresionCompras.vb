Public Class frmImpresionCompras
    Public _idCompra As Integer
    Private Sub frmImpresionCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.ImpresionCompras' Puede moverla o quitarla según sea necesario.
        Me.ImpresionComprasTableAdapter.FillImpresionCompras(Me.bd_empresaDataSet.ImpresionCompras, _idCompra)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class