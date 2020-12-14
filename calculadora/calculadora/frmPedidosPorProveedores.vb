Public Class frmPedidosPorProveedores
    Private Sub frmPedidosPorProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.PedidosPorProveedores' Puede moverla o quitarla según sea necesario.
        Me.PedidosPorProveedoresTableAdapter.FillPedidosPorProveedores(Me.bd_empresaDataSet.PedidosPorProveedores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class