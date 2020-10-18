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
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub habDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminar.Enabled = estado
        btnBuscar.Enabled = estado
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "modificar"
            habDescontroles(False)
        Else
            obtenerDatos()

            habDescontroles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("Estas seguro de borrar a empleado " + txtNombre.Text, " Registro empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            objconexion.mantenimientoDatosEmpleados(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If

            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objBuscarEmpleados As New frmBuscarEmpleados
        objBuscarEmpleados.ShowDialog()
        If objBuscarEmpleados._ide > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarEmpleados._ide))
            mostrarDatos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Nuevo" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "nuevo"

            habDescontroles(False)
            limpiarDatosEmpleados()
        Else
            Dim msg = objconexion.mantenimientoDatosEmpleados(New String() {
                 Me.Tag, txtCodigo.Text, txtNombre.Text, txtPuestoLaboral.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text
            }, accion)

            obtenerDatos()
            habDescontroles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
            MessageBox.Show(msg, "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grbDatos_Enter(sender As Object, e As EventArgs) Handles grbDatos.Enter

    End Sub
End Class