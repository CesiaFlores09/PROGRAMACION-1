Public Class frmPuestoLaboral
    Dim objconexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"
    Private Sub frmPuestoLaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("puesto")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idpuestolaboral")}


        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()



            txtpuestoLaboral.Text = dataTable.Rows(posicion).ItemArray(1).ToString()

            lblRegistroPuesto.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosPuesto()
            MessageBox.Show("No hay Registros que mostrar", "Registro de Puesto Laboral", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub limpiarDatosPuesto()
        txtpuestoLaboral.Text = ""
    End Sub

    Private Sub btnPrimeroPuesto_Click(sender As Object, e As EventArgs) Handles btnPrimeroPuesto.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorCategoria_Click(sender As Object, e As EventArgs) Handles btnAnteriorCategoria.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro", "Registro de Puesto Laboral", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguientePuesto_Click(sender As Object, e As EventArgs) Handles btnSiguientePuesto.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro", "Registro de Puesto Laboral", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoPuesto_Click(sender As Object, e As EventArgs) Handles btnUltimoPuesto.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarPuesto_Click(sender As Object, e As EventArgs) Handles btnAgregarPuesto.Click
        If btnAgregarPuesto.Text = "Nuevo" Then
            btnAgregarPuesto.Text = "Guardar"
            btnModificarPuesto.Text = "Cancelar"
            accion = "nuevo"

            habDescontroles(False)
            limpiarDatosPuesto()
        Else
            Dim msg = objconexion.mantenimientoDatosPuesto(New String() {
                 Me.Tag, txtpuestoLaboral.Text
            }, accion)


            obtenerDatos()
            habDescontroles(True)
            btnAgregarPuesto.Text = "Nuevo"
            btnModificarPuesto.Text = "Modificar"
            MessageBox.Show(msg, "Registro de Puesto Laboral", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub
    Private Sub habDescontroles(ByVal estado As Boolean)
        grbDatosPuesto.Enabled = Not estado
        grbNavegacionPuesto.Enabled = estado
        btnEliminarPuesto.Enabled = estado
        btnBuscarPuesto.Enabled = estado

    End Sub

    Private Sub btnModificarPuesto_Click(sender As Object, e As EventArgs) Handles btnModificarPuesto.Click
        If btnModificarPuesto.Text = "Modificar" Then
            btnAgregarPuesto.Text = "Guardar"
            btnModificarPuesto.Text = "Cancelar"
            accion = "modificar"
            habDescontroles(False)
        Else
            obtenerDatos()

            habDescontroles(True)
            btnAgregarPuesto.Text = "Nuevo"
            btnModificarPuesto.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarPuesto_Click(sender As Object, e As EventArgs) Handles btnEliminarPuesto.Click


        If (MessageBox.Show("Estas seguro de borrar " + txtpuestoLaboral.Text, " Registro de Puesto Laboral", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            Dim msg = objconexion.mantenimientoDatosPuesto(New String() {Me.Tag}, "eliminar")
            If msg = "error" >= 0 Then
                MessageBox.Show("No se pudo eliminar el Puesto Laboral porque hay empleados que dependen de el", "Registro de Puesto Laboral", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If posicion > 0 Then
                    posicion -= 1
                End If

                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub

    Private Sub btnBuscarPuesto_Click(sender As Object, e As EventArgs) Handles btnBuscarPuesto.Click
        Dim objBuscarPuestoLaboral As New frmBuscarPuestoLaboral
        objBuscarPuestoLaboral.ShowDialog()
        If objBuscarPuestoLaboral._idPL > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarPuestoLaboral._idPL))
            mostrarDatos()
        End If
    End Sub
End Class