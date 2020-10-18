Public Class frmproveedores
    Dim objconexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("proveedores")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idproveedores")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCodigoProveedores.Text = dataTable.Rows(posicion).ItemArray(1)
            txtNombreProveedores.Text = dataTable.Rows(posicion).ItemArray(2)
            txtNombreEmpresa.Text = dataTable.Rows(posicion).ItemArray(3)
            txtNombrePropietario.Text = dataTable.Rows(posicion).ItemArray(4)
            txtDireccionProveedores.Text = dataTable.Rows(posicion).ItemArray(5)
            txtTelefonoProveedores.Text = dataTable.Rows(posicion).ItemArray(6)
            txtEmailProveedores.Text = dataTable.Rows(posicion).ItemArray(7)
            lblRegistroProveedores.Text = posicion + 1 & " de" & dataTable.Rows.Count
        Else
            limpiarDatosProveedores()
            MessageBox.Show("No hay Registros que mostrar", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosProveedores()
        txtCodigoProveedores.Text = ""
        txtNombreProveedores.Text = ""
        txtNombreEmpresa.Text = ""
        txtNombrePropietario.Text = ""
        txtDireccionProveedores.Text = ""
        txtTelefonoProveedores.Text = ""
        txtEmailProveedores.Text = ""
    End Sub

    Private Sub btnPrimeroProveedores_Click(sender As Object, e As EventArgs) Handles btnPrimeroProveedores.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorProveedores_Click(sender As Object, e As EventArgs) Handles btnAnteriorProveedores.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro", "Registro de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteProveedores_Click(sender As Object, e As EventArgs) Handles btnSiguienteProveedores.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro", "Registro de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoProveedores_Click(sender As Object, e As EventArgs) Handles btnUltimoProveedores.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub habDescontroles(ByVal estado As Boolean)
        grbDatosdeProveedores.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarProveedores.Enabled = estado
        btnBuscarProveedores.Enabled = estado
    End Sub

    Private Sub btnModificarProveedores_Click(sender As Object, e As EventArgs) Handles btnModificarProveedores.Click
        If btnModificarProveedores.Text = "Modificar" Then
            btnAgregarProveedores.Text = "Guardar"
            btnModificarProveedores.Text = "Cancelar"
            accion = "modificar"
            habDescontroles(False)
        Else
            obtenerDatos()

            habDescontroles(True)
            btnAgregarProveedores.Text = "Nuevo"
            btnModificarProveedores.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarProveedores_Click(sender As Object, e As EventArgs) Handles btnEliminarProveedores.Click
        If (MessageBox.Show("Estas seguro de borrar a empleado " + txtNombreProveedores.Text, " Registro de proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            Dim msg = objconexion.mantenimientoDatosProveedores(New String() {Me.Tag}, "eliminar")
            If msg = "error" Then
                MessageBox.Show(msg, "Registro de Proveedores",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub

    Private Sub btnBuscarProveedores_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedores.Click
        Dim objBuscarProveedores As New frmBuscarProveedores
        objBuscarProveedores.ShowDialog()
        If objBuscarProveedores._idp > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarProveedores._idp))
            mostrarDatos()
        End If
    End Sub

    Private Sub btnAgregarProveedores_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedores.Click
        If btnAgregarProveedores.Text = "Nuevo" Then
            btnAgregarProveedores.Text = "Guardar"
            btnModificarProveedores.Text = "Cancelar"
            accion = "nuevo"

            habDescontroles(False)
            limpiarDatosProveedores()
        Else
            Dim msg = objconexion.mantenimientoDatosProveedores(New String() {
                 Me.Tag, txtCodigoProveedores.Text, txtNombreProveedores.Text, txtNombreEmpresa.Text, txtNombrePropietario.Text, txtDireccionProveedores.Text, txtTelefonoProveedores.Text, txtEmailProveedores.Text
            }, accion)

            obtenerDatos()
            habDescontroles(True)
            btnAgregarProveedores.Text = "Nuevo"
            btnModificarProveedores.Text = "Modificar"
            MessageBox.Show(msg, "Registro de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class