Public Class frmusuarios
    Dim objconexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("usuario")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idusuario")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Usuario
            txtNombreUsuario.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtApellidoUsuario.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtClaveUsuario.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtEmailUsuario.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtDireccionUsuario.Text = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtTelefonoUsuario.Text = dataTable.Rows(posicion).ItemArray(6).ToString()
            txtPrivilegioUsuario.Text = dataTable.Rows(posicion).ItemArray(7).ToString()

            lblRegistroUsuario.Text = posicion + 1 & " de" & dataTable.Rows.Count
        Else
            limpiarDatosUsuarios()
            MessageBox.Show("No hay Registros que mostrar", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosUsuarios()
        txtNombreUsuario.Text = ""
        txtApellidoUsuario.Text = ""
        txtClaveUsuario.Text = ""
        txtEmailUsuario.Text = ""
        txtDireccionUsuario.Text = ""
        txtTelefonoUsuario.Text = ""
        txtPrivilegioUsuario.Text = ""
    End Sub

    Private Sub btnPrimeroUsuario_Click(sender As Object, e As EventArgs) Handles btnPrimeroUsuario.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorUsuario_Click(sender As Object, e As EventArgs) Handles btnAnteriorUsuario.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub habDescontroles(ByVal estado As Boolean)
        grbDatosUsuario.Enabled = Not estado
        grbNavegacionUsuario.Enabled = estado
        btnEliminarUsuario.Enabled = estado
        btnBuscarUsuario.Enabled = estado
    End Sub

    Private Sub btnUltimoUsuario_Click(sender As Object, e As EventArgs) Handles btnUltimoUsuario.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteUsuario_Click(sender As Object, e As EventArgs) Handles btnSiguienteUsuario.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificarUsuario.Click
        If btnModificarUsuario.Text = "Modificar" Then
            btnAgregarUsuario.Text = "Guardar"
            btnModificarUsuario.Text = "Cancelar"
            accion = "modificar"
            habDescontroles(False)
        Else
            obtenerDatos()

            habDescontroles(True)
            btnAgregarUsuario.Text = "Nuevo"
            btnModificarUsuario.Text = "Modificar"
        End If
    End Sub
    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        If (MessageBox.Show("Estas seguro de borrar a usuario: " + txtNombreUsuario.Text, " Registro Uuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            objconexion.mantenimientoDatosUsuarios(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles btnBuscarUsuario.Click
        Dim objBuscarUsuarios As New frmBuscarUsuarios
        objBuscarUsuarios.ShowDialog()
        If objBuscarUsuarios._idU > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarUsuarios._idU))
            mostrarDatos()
        End If
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        If btnAgregarUsuario.Text = "Nuevo" Then 'Nuevo
            btnAgregarUsuario.Text = "Guardar"
            btnModificarUsuario.Text = "Cancelar"
            accion = "nuevo"

            habDescontroles(False)
            limpiarDatosUsuarios()
        Else 'Guardar
            Dim msg = objconexion.mantenimientoDatosUsuarios(New String() {
                 Me.Tag, txtNombreUsuario.Text, txtApellidoUsuario.Text, txtClaveUsuario.Text, txtEmailUsuario.Text, txtDireccionUsuario.Text, txtTelefonoUsuario.Text, txtPrivilegioUsuario.Text
            }, accion)
            If msg = "Error" Then
                MessageBox.Show("Error al instalar guardar el registro, por favor intente nuevamente.", "Registro de Usuarios",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                habDescontroles(True)
                btnAgregarUsuario.Text = "Nuevo"
                btnModificarUsuario.Text = "Modificar"
                MessageBox.Show(msg, "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class