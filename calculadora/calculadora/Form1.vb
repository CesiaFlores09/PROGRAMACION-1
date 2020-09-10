Public Class Form1
    Dim objdirecciones = New direcciones

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDepto.Items.AddRange(objdirecciones.depto)
    End Sub

    Private Sub cboDepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepto.SelectedIndexChanged
        cboMun.Items.Clear()
        cboMun.Text = ""
        cboMun.Items.AddRange(objdirecciones.mun(cboDepto.SelectedIndex))
    End Sub
End Class
Class direcciones
    Public depto() As String = {"Seleccione un depto", "Usulutan", "San Miguel", "La union ", "Morazan"}
    Public mun()() As String = {
        New String() {"Seleccione un depto"},
         New String() {"Seleccioen un Mun", "Usulutan", "Jiquilisco", "Santa Elena", "Santa Maria"},'Uaulutan
         New String() {"Seleccioen un Mun", "San Miguel", "El Transito", "San Rafael Ote", "San Jorgue"},'San Miguel
         New String() {"Seleccioen un Mun", "La Union", "SRl", "Anamoros", "Bolivar"},'La Union
        New String() {"Seleccioen un Mun", "Arambala", "Perquin", "Corinto", "Cacaopera"}'Morazan 
    }




End Class

