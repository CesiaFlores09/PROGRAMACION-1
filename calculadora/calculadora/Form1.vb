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

    Private Sub cboMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMun.SelectedIndexChanged
        cboArea.Items.Clear()
        cboArea.Text = ""
        cboArea.Items.AddRange(objdirecciones.area(cboMun.SelectedIndex))
    End Sub

End Class
Class direcciones
    Public depto() As String = {"Seleccione un depto", "Usulutan", "San Miguel", "La union ", "Morazan", "La Paz", "San Salvador", "La libertad", "Sonsonate"}

    Public area()() As String = {
        New String() {"Seleccione un mun"},
        New String() {"Seleccione una area", "Buena Vista", "El Cerrito", "Santa Barbara", "La Presa"},
        New String() {" "},
        New String() {" "},
        New String() {" "},
        New String() {" "},
        New String() {" "},
        New String() {" "},
        New String() {" "},
        New String() {" "}
        }
    Public mun()() As String = {
        New String() {"Seleccione un depto"},
        New String() {"Seleccioen un Mun", "Usulutan", "Jiquilisco", "Santa Elena", "Santa Maria"},'Usulutan
        New String() {"Seleccioen un Mun", "San Miguel", "El Transito", "San Rafael Ote", "San Jorgue"},'San Miguel
        New String() {"Seleccioen un Mun", "La Union", "SRl", "Anamoros", "Bolivar"},'La Union
        New String() {"Seleccioen un Mun", "Arambala", "Perquin", "Corinto", "Cacaopera"}, 'Morazan 
        New String() {"Seleccioen un Mun", "Zacatecoluca", "El Rosario", "Santiago Nonualco", "Olocuilta"}, 'La Paz
        New String() {"Seleccioen un Mun", "San Salvador", "Aguilares", "Apopa", "Ilopango"},'San Salvador
        New String() {"Seleccioen un Mun", "Santa Tecla", "Ciudad Arce", "Colon", "La Libertad"}, 'La Libertad
        New String() {"Seleccioen un Mun", "Sonsonate", "Acajjutla", "Izalco", "Juayua"} 'San Salvador
    }




End Class

