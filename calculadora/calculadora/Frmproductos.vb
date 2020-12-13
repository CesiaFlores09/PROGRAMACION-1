Public Class Frmproductos
    Dim objconexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"

    Private Sub Frmproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()

    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("producto")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idproducto")}

        cboCategoria.DataSource = objconexion.obtenerDatos().Tables("categoria").Defaultview()
        cboCategoria.DisplayMember = "categoria"
        cboCategoria.ValueMember = "categoria.idcategoria"

        cboCategoria.AutoCompleteMode = AutoCompleteMode.Suggest
        cboCategoria.AutoCompleteSource = AutoCompleteSource.ListItems
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()

            cboCategoria.SelectedValue = dataTable.Rows(posicion).ItemArray(1).ToString()

            txtCodigoProducto.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtNombreProducto.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtMarcaProducto.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtMedidasProducto.Text = dataTable.Rows(posicion).ItemArray(5).ToString()

            lblRegistroProductos.Text = posicion + 1 & " de" & dataTable.Rows.Count
        Else
            limpiarDatosProductos()
            MessageBox.Show("No hay Registros que mostrar", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub limpiarDatosProductos()
        txtCodigoProducto.Text = ""
        txtNombreProducto.Text = ""
        txtMarcaProducto.Text = ""
        txtMedidasProducto.Text = ""


    End Sub

    Private Sub btnPrimeroPoducto_Click(sender As Object, e As EventArgs) Handles btnPrimeroPoducto.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorPoducto_Click(sender As Object, e As EventArgs) Handles btnAnteriorPoducto.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguientePoducto_Click(sender As Object, e As EventArgs) Handles btnSiguientePoducto.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoPoducto_Click(sender As Object, e As EventArgs) Handles btnUltimoPoducto.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub habDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacionProducto.Enabled = estado
        btnEliminarPoducto.Enabled = estado
        btnBuscarPoducto.Enabled = estado
    End Sub

    Private Sub btnAgregarPoducto_Click(sender As Object, e As EventArgs) Handles btnAgregarPoducto.Click
        If btnAgregarPoducto.Text = "Nuevo" Then
            btnAgregarPoducto.Text = "Guardar"
            btnModificarPoducto.Text = "Cancelar"
            accion = "nuevo"

            habDescontroles(False)
            limpiarDatosProductos()
        Else
            Dim msg = objconexion.mantenimientoDatosProductos(New String() {
                 Me.Tag, cboCategoria.SelectedValue, txtCodigoProducto.Text, txtNombreProducto.Text, txtMarcaProducto.Text, txtMedidasProducto.Text
            }, accion)

            obtenerDatos()
            habDescontroles(True)
            btnAgregarPoducto.Text = "Nuevo"
            btnModificarPoducto.Text = "Modificar"
            MessageBox.Show(msg, "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnModificarPoducto_Click(sender As Object, e As EventArgs) Handles btnModificarPoducto.Click
        If btnModificarPoducto.Text = "Modificar" Then
            btnAgregarPoducto.Text = "Guardar"
            btnModificarPoducto.Text = "Cancelar"
            accion = "modificar"
            habDescontroles(False)
        Else
            obtenerDatos()

            habDescontroles(True)
            btnAgregarPoducto.Text = "Nuevo"
            btnModificarPoducto.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarPoducto_Click(sender As Object, e As EventArgs) Handles btnEliminarPoducto.Click
        If (MessageBox.Show("Estas seguro de borrar " + txtNombreProducto.Text, " Registro de productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            objconexion.mantenimientoDatosProductos(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If

            obtenerDatos()
            mostrarDatos()
        End If
    End Sub

    Private Sub btnBuscarPoducto_Click(sender As Object, e As EventArgs) Handles btnBuscarPoducto.Click
        Dim objBuscarProducto As New frmBuacarProductovb
        objBuscarProducto.ShowDialog()
        If objBuscarProducto._idpr > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarProducto._idpr))
            mostrarDatos()
        End If
    End Sub

    Private Sub grbDatos_Enter(sender As Object, e As EventArgs) Handles grbDatos.Enter

    End Sub
End Class