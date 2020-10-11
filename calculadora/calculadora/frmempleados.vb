Public Class frmempleados
    Dim objconexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"
    Private Sub frmempleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("empleados")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idempleados")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCodigo.Text = dataTable.Rows(posicion).ItemArray(1)
            txtNombre.Text = dataTable.Rows(posicion).ItemArray(2)
            txtPuestoLaboral.Text = dataTable.Rows(posicion).ItemArray(3)
            txtDireccion.Text = dataTable.Rows(posicion).ItemArray(4)
            txtTelefono.Text = dataTable.Rows(posicion).ItemArray(5)
            txtEmail.Text = dataTable.Rows(posicion).ItemArray(6)
            lblRegistroEmpleados.Text = posicion + 1 & " de" & dataTable.Rows.Count
        Else
            limpiarDatosEmpleados()
            MessageBox.Show("No hay Registros que mostrar", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub limpiarDatosEmpleados()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtPuestoLaboral.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
End Class