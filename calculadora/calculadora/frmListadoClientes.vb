Public Class frmListadoClientes
    Private Sub frmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.clienteTableAdapter.Fill(Me.bd_empresaDataSet.cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class