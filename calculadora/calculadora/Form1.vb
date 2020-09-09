Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntbla, i As SByte
        ntbla = txtnTabla.Text
        lstTablas.Items.Clear()
        If ntbla <= 12 Then
            For i = 1 To 10
                lstTablas.Items.Add(ntbla.ToString() + "X" + i.ToString() + "=" + (ntbla * i).ToString())
            Next
        Else
            lstTablas.Items.Add("Por favor ingrese solo tablas menores o iguales a 12.")
        End If
    End Sub
End Class
