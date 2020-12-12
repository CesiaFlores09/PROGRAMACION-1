Public Class frmImpresionPedidos
    Public _idPedido As Integer
    Private Sub frmImpresionPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.ImpresionPedidos' Puede moverla o quitarla según sea necesario.
        Me.ImpresionPedidosTableAdapter.FillImpresionPedidos(Me.bd_empresaDataSet.ImpresionPedidos, _idPedido)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class