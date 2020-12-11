Public Class frmComprasPorCliente
    Private Sub frmComprasPorCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.ImpresionCompras' Puede moverla o quitarla según sea necesario.
        Me.ComprasPorClienteTableAdapter.FillComprasPorCliente(Me.bd_empresaDataSet.ComprasPorCliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class