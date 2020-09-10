Public Class Form1
    Dim objEstadistica As New estadistica


    Private Sub btnCalculosE_Click(sender As Object, e As EventArgs) Handles btnCalculosE.Click
        lblRespuesta.Text = objEstadistica.calcularMedia(txtSerie.Text.Split(","))
        LblResV.Text = objEstadistica.calcularVarianza(txtSerie.Text.Split(","))
        lblResDesTipica.Text = objEstadistica.calcularDesviacionTipica(txtSerie.Text.Split(","))
    End Sub

    Private Sub grdEstadistica_KeyUp(sender As Object, e As KeyEventArgs) Handles grdEstadistica.KeyUp

        Dim nfilas = grdEstadistica.Rows.Count - 1,
            totalf1 = 0,
        totalx1xf1 = 0.0,
        totalx21xf1 = 0.0
            Dim fila As New DataGridViewRow
        For i = 0 To nfilas - 1
            fila = grdEstadistica.Rows(i)
            Dim x1 = 0, f1 = 0
            If fila.Cells("x1").Value <> "" Then
                x1 = Integer.Parse(fila.Cells("x1").Value.ToString())
            End If
            If fila.Cells("f1").Value <> "" Then
                f1 = Integer.Parse(fila.Cells("f1").Value.ToString())
            End If
            totalf1 += f1
            totalx1xf1 += x1 * f1
            totalx21xf1 += x1 ^ 2 * f1

            fila.Cells("n1").Value = totalf1.ToString()
            fila.Cells("x1xf1").Value = (x1 * f1).ToString()
            fila.Cells("x21xf1").Value = (x1 ^ 2 * f1).ToString()

        Next
        lblTotalf1.Text = totalf1.ToString()
        lblTotalx1xf1.Text = totalx1xf1.ToString()
        lblTotalx21xf1.Text = totalx21xf1.ToString()


        Dim media = Math.Round(totalx1xf1 / totalf1, 2),
      Varianza = Math.Round(totalx21xf1 / totalf1 - media ^ 2, 2)
        lblRespuesta.Text = media.ToString()
        LblResV.Text = Varianza.ToString()
        lblResDesTipica.Text = Math.Round(Math.Sqrt(Varianza).ToString())


    End Sub
End Class
