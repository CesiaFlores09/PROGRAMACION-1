Public Class frmImpresionVentas
    Public _idVta As Integer
    Public Sub frmImpresionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.impresionVentas' Puede moverla o quitarla según sea necesario.
        Me.impresionVentasTableAdapter.FillImpresionVentas(Me.bd_empresaDataSet.impresionVentas, _idVta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class