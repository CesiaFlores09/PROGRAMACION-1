Public Class frmListadoPuestoLaboralvb
    Private Sub frmListadoPuestoLaboralvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_empresaDataSet.puesto' Puede moverla o quitarla según sea necesario.
        Me.puestoTableAdapter.FillPuesto(Me.bd_empresaDataSet.puesto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class