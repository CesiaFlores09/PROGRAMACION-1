Public Class frmListadoProveedores
    Private Sub frmListadoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.proveedoresTableAdapter.Fillproveedores(Me.bd_empresaDataSet.proveedores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class