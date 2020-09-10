Public Class Form1
    Dim objEstadistica As New estadistica


    Private Sub btnCalculosE_Click(sender As Object, e As EventArgs) Handles btnCalculosE.Click
        lblRespuesta.Text = objEstadistica.calcularMedia(txtSerie.Text.Split(","))
        LblResV.Text = objEstadistica.calcularVarianza(txtSerie.Text.Split(","))
        lblResDesTipica.Text = objEstadistica.calcularDesviacionTipica(txtSerie.Text.Split(","))
    End Sub
End Class
