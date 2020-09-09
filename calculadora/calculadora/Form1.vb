Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntbla, i As Int64
        ntbla = txtnTabla.Text
        i = 1
        lstTablas.Items.Clear()

        Do While i <= 10
            lstTablas.Items.Add(ntbla.ToString() + "X" + i.ToString() + "=" + (ntbla * i).ToString())
            i = i + 1
        Loop

    End Sub
End Class
