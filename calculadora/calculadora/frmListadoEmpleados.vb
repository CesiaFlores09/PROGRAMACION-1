Public Class frmListadoEmpleados
    Private Sub frmListadoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.ListadoEmpleados' Puede moverla o quitarla según sea necesario.
        Me.ListadoEmpleadosTableAdapter.FillListadoEmpleados(Me.bd_empresaDataSet.ListadoEmpleados)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class