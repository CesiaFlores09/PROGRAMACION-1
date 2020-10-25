Public Class frmCategoriavb
    Dim objconexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"
    Private Sub frmCategoriavb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("categoria")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idcategoria")}


        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()



            txtCate.Text = dataTable.Rows(posicion).ItemArray(1).ToString()

            lblRegistroCategoria.Text = posicion + 1 & " de" & dataTable.Rows.Count
        Else
            limpiarDatosCategoria()
            MessageBox.Show("No hay Registros que mostrar", "Registro de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub limpiarDatosCategoria()
        txtCate.Text = ""
    End Sub

    Private Sub btnPrimeroCategoria_Click(sender As Object, e As EventArgs) Handles btnPrimeroCategoria.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorCategoria_Click(sender As Object, e As EventArgs) Handles btnAnteriorCategoria.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro", "Registro de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteCategoria_Click(sender As Object, e As EventArgs) Handles btnSiguienteCategoria.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro", "Registro de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoCategoria_Click(sender As Object, e As EventArgs) Handles btnUltimoCategoria.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        If btnAgregarCategoria.Text = "Nuevo" Then
            btnAgregarCategoria.Text = "Guardar"
            btnModificarCategoria.Text = "Cancelar"
            accion = "nuevo"

            habDescontroles(False)
            limpiarDatosCategoria()
        Else
            Dim msg = objconexion.mantenimientoDatosCategoria(New String() {
                 Me.Tag, txtCate.Text
            }, accion)


            obtenerDatos()
            habDescontroles(True)
            btnAgregarCategoria.Text = "Nuevo"
            btnModificarCategoria.Text = "Modificar"
            MessageBox.Show(msg, "Registro de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub
    Private Sub habDescontroles(ByVal estado As Boolean)
        grbDatosCategorias.Enabled = Not estado
        grbNavegacionCategoria.Enabled = estado
        btnEliminarCategoria.Enabled = estado
        btnBuscarCategoria.Enabled = estado
    End Sub

    Private Sub btnModificarCategoria_Click(sender As Object, e As EventArgs) Handles btnModificarCategoria.Click
        If btnModificarCategoria.Text = "Modificar" Then
            btnAgregarCategoria.Text = "Guardar"
            btnModificarCategoria.Text = "Cancelar"
            accion = "modificar"
            habDescontroles(False)
        Else
            obtenerDatos()

            habDescontroles(True)
            btnAgregarCategoria.Text = "Nuevo"
            btnModificarCategoria.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarCategoria_Click(sender As Object, e As EventArgs) Handles btnEliminarCategoria.Click

        If (MessageBox.Show("Estas seguro de borrar " + txtCate.Text, " Registro de categorias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            Dim msg = objconexion.mantenimientoDatosCategoria(New String() {Me.Tag}, "eliminar")
            If msg = "error" >= 0 Then
                MessageBox.Show("No se pudo eliminar la categoria porque hay productos que dependen de ella", "Registro de Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If posicion > 0 Then
                posicion -= 1
            End If

            obtenerDatos()
            mostrarDatos()
        End If
        End If
    End Sub

    Private Sub btnBuscarCategoria_Click(sender As Object, e As EventArgs) Handles btnBuscarCategoria.Click
        Dim objBuscarCategoria As New frmBuscarcategorias
        objBuscarCategoria.ShowDialog()
        If objBuscarCategoria._idct > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarCategoria._idct))
            mostrarDatos()
        End If
    End Sub
End Class