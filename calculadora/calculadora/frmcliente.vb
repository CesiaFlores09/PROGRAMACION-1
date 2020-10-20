Public Class frmcliente
    Dim objconexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"
    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("cliente")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idcliente")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCodigoCliente.Text = dataTable.Rows(posicion).ItemArray(1)
            txtNombreCliente.Text = dataTable.Rows(posicion).ItemArray(2)
            txtDireccionCliente.Text = dataTable.Rows(posicion).ItemArray(3)
            txtTelefonoCliente.Text = dataTable.Rows(posicion).ItemArray(4)
            txtEmailCliente.Text = dataTable.Rows(posicion).ItemArray(5)
            lblRegistroCliente.Text = posicion + 1 & " de" & dataTable.Rows.Count
        Else
            limpiarDatosCliente()
            MessageBox.Show("No hay Registros que mostrar", "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub limpiarDatosCliente()
        txtCodigoCliente.Text = ""
        txtNombreCliente.Text = ""
        txtDireccionCliente.Text = ""
        txtTelefonoCliente.Text = ""
        txtEmailCliente.Text = ""

    End Sub

    Private Sub btnPrimeroCliente_Click(sender As Object, e As EventArgs) Handles btnPrimeroCliente.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnUltimoCliente_Click(sender As Object, e As EventArgs) Handles btnUltimoCliente.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorCliente_Click(sender As Object, e As EventArgs) Handles btnAnteriorCliente.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro", "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub habDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacionCliente.Enabled = estado
        btnEliminarCliente.Enabled = estado
        btnBuscarCliente.Enabled = estado
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        If btnModificarCliente.Text = "Modificar" Then
            btnAgregarCliente.Text = "Guardar"
            btnModificarCliente.Text = "Cancelar"
            accion = "modificar"
            habDescontroles(False)
        Else
            obtenerDatos()

            habDescontroles(True)
            btnAgregarCliente.Text = "Nuevo"
            btnModificarCliente.Text = "Modificar"
        End If
    End Sub

    Private Sub btnSiguienteCliente_Click(sender As Object, e As EventArgs) Handles btnSiguienteCliente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro", "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        If btnAgregarCliente.Text = "Nuevo" Then
            btnAgregarCliente.Text = "Guardar"
            btnModificarCliente.Text = "Cancelar"
            accion = "nuevo"

            habDescontroles(False)
            limpiarDatosCliente()
        Else
            Dim msg = objconexion.mantenimientoDatosClientes(New String() {
                 Me.Tag, txtCodigoCliente.Text, txtNombreCliente.Text, txtDireccionCliente.Text, txtTelefonoCliente.Text, txtEmailCliente.Text
            }, accion)

            obtenerDatos()
            habDescontroles(True)
            btnAgregarCliente.Text = "Nuevo"
            btnModificarCliente.Text = "Modificar"
            MessageBox.Show(msg, "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        If (MessageBox.Show("Estas seguro de borrar a cliente " + txtNombreCliente.Text, " Registro cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            objconexion.mantenimientoDatosClientes(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If

            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim objBuscarCliente As New frmbuscarcliente
        objBuscarCliente.ShowDialog()
        If objBuscarCliente._idcl > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarCliente._idcl))
            mostrarDatos()
        End If
    End Sub
End Class