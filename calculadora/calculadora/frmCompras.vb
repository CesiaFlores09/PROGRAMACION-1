Imports System.Data.SqlClient
Public Class frmCompras
    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_empresaDataSet)

    End Sub

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarDs()
        totalizar()

    End Sub

    Private Sub actualizarDs()
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.pag' Puede moverla o quitarla según sea necesario.
        Me.PagTableAdapter.FillPag(Me.Bd_empresaDataSet.pag)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.TipoFactura' Puede moverla o quitarla según sea necesario.
        Me.TipoFacturaTableAdapter.FillTipoFactura(Me.Bd_empresaDataSet.TipoFactura)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Bd_empresaDataSet.cliente)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.DcomprasProductos' Puede moverla o quitarla según sea necesario.
        Me.DcomprasProductosTableAdapter.FillDcomprasProductos(Me.Bd_empresaDataSet.DcomprasProductos)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.dcomprasproductos' Puede moverla o quitarla según sea necesario.
        Me.DcomprasProductosTableAdapter.FillDcomprasProductos(Me.Bd_empresaDataSet.DcomprasProductos)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.DventasProducto' Puede moverla o quitarla según sea necesario.
        Me.DventasProductoTableAdapter.FillDventasProducto(Me.Bd_empresaDataSet.DventasProducto)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.dcompras' Puede moverla o quitarla según sea necesario.
        Me.DcomprasTableAdapter.Filldcompras(Me.Bd_empresaDataSet.dcompras)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fillcompras(Me.Bd_empresaDataSet.compras)

    End Sub

    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = DcomprasProductosDataGridView.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double

            For i As Integer = 0 To nfilas
                fila = DcomprasProductosDataGridView.Rows(i)
                subtotal = Double.Parse(fila.Cells("cantidad").Value.ToString()) * Double.Parse(fila.Cells("precio").Value.ToString())

                fila.Cells("subtotal").Value = subtotal.ToString()

                sumas += subtotal
            Next
            iva = If(IdTipoFComboBox.SelectedValue = 2, sumas * 0.13, 0)
            total = sumas + iva

            lblResS.Text = "$ " + Math.Round(sumas, 2).ToString()
            lblResI.Text = "$ " + Math.Round(iva, 2).ToString()
            lblResTotal.Text = "$ " + Math.Round(total, 2).ToString()

            lblRegistroCompras.Text = (ComprasBindingSource.Position + 1) & " de " & ComprasBindingSource.Count

        Catch ex As Exception
            'MessageBox.Show("Error " + ex.Message)
        End Try
    End Sub


    Private Sub btnPrimeroComprass_Click(sender As Object, e As EventArgs) Handles btnPrimeroCompras.Click
        ComprasBindingSource.MoveFirst()
        totalizar()
    End Sub

    Private Sub btnAnteriorCompras_Click(sender As Object, e As EventArgs) Handles btnAnteriorCompras.Click
        ComprasBindingSource.MovePrevious()
        totalizar()
    End Sub

    Private Sub btnSiguienteCompras_Click(sender As Object, e As EventArgs) Handles btnSiguienteCompras.Click
        ComprasBindingSource.MoveNext()
        totalizar()
    End Sub

    Private Sub btnUltimoCompras_Click(sender As Object, e As EventArgs) Handles btnUltimoCompras.Click
        ComprasBindingSource.MoveLast()
        totalizar()
    End Sub

    Private Sub habdesh_controles(ByVal valor As Boolean)
        NfacturaTextBox.ReadOnly = valor
        IdclienteComboBox.Enabled = Not valor
        Fecha_compraDateTimePicker.Enabled = Not valor
        IdTipoFComboBox.Enabled = Not valor
        IdPagoComboBox.Enabled = Not valor
        DcomprasProductosDataGridView.ReadOnly = valor

        grbdComprasProductos.Visible = Not valor
        grbNavegacionCompras.Visible = valor
        btnAgregarCliente.Visible = Not valor

        btnEliminarCompras.Enabled = valor
        btnBuscarCompras.Enabled = valor
    End Sub

    Private Sub btnAgregarCompras_Click(sender As Object, e As EventArgs) Handles btnAgregarCompras.Click
        If btnAgregarCompras.Text = "Nuevo" Then
            btnAgregarCompras.Text = "Guardar"
            btnModificarCompras.Text = "Cancelar"

            habdesh_controles(False)
            ComprasBindingSource.AddNew()

            IdclienteComboBox.SelectedValue = 1 'CLiente por default Carlos Lopez
            IdTipoFComboBox.SelectedValue = 1 'Tipo de factura por default consumidor final 
            IdPagoComboBox.SelectedValue = 1 'Tipo de pago por default efectivo
            Fecha_compraDateTimePicker.Value = Date.Now

        Else 'Guardar

            Try
                Dim _idCompras = Integer.Parse(lblIdCompras.Text)
                Me.Validate()
                ComprasBindingSource.EndEdit()

                ComprasTableAdapter.Connection.Open()
                Dim comando As New SqlCommand
                comando.Connection = ComprasTableAdapter.Connection

                If _idCompras > 0 Then 'Modificando
                    comando.CommandText = "delete from dcompras where idcompra=" + _idCompras.ToString()
                    comando.ExecuteNonQuery()
                Else 'Agregando Nuevas Facturas
                    comando.CommandText = "SELECT ident_current('compras') + 1 As idcompra"
                    _idCompras = Integer.Parse(comando.ExecuteScalar().ToString())
                End If
                ComprasTableAdapter.Connection.Close()

                Dim nfilas As Integer = DcomprasProductosDataGridView.Rows.Count
                Dim valores(nfilas, 3) As String
                Dim fila As New DataGridViewRow

                For i = 0 To nfilas - 1
                    fila = DcomprasProductosDataGridView.Rows(i)
                    valores(i, 0) = fila.Cells("idproducto").Value.ToString()
                    valores(i, 1) = fila.Cells("cantidad").Value.ToString()
                    valores(i, 2) = fila.Cells("precio").Value.ToString()
                Next
                TableAdapterManager.UpdateAll(Bd_empresaDataSet)

                For i = 0 To nfilas - 1
                    DcomprasTableAdapter.Insert(
                        _idCompras,
                        valores(i, 0),
                        valores(i, 1),
                        valores(i, 2)
                    )
                Next
                actualizarDs()
                ComprasBindingSource.MoveLast()

                habdesh_controles(True)
                btnAgregarCompras.Text = "Nuevo"
                btnModificarCompras.Text = "Modificar"

            Catch ex As Exception
                MessageBox.Show("Error al intentar guardar: " + ex.Message,
                            "Registro de Facturas de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnModificarCompras_Click(sender As Object, e As EventArgs) Handles btnModificarCompras.Click
        If btnModificarCompras.Text = "Modificar" Then
            btnAgregarCompras.Text = "Guardar"
            btnModificarCompras.Text = "Cancelar"

            habdesh_controles(False)

        Else 'Cancelar

            DcomprasProductosBindingSource5.CancelEdit()
            ComprasBindingSource.CancelEdit()

            habdesh_controles(True)
            btnAgregarCompras.Text = "Nuevo"
            btnModificarCompras.Text = "Modificar"
        End If
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim objBuscarProductos As New frmBuacarProductovb
        objBuscarProductos.ShowDialog()
        If objBuscarProductos._idpr > 0 Then
            DcomprasProductosBindingSource5.AddNew()
            DcomprasProductosDataGridView.CurrentRow.Cells("idproducto").Value = objBuscarProductos._idpr
            DcomprasProductosDataGridView.CurrentRow.Cells("codigo").Value = objBuscarProductos._codigoProducto
            DcomprasProductosDataGridView.CurrentRow.Cells("nombre").Value = objBuscarProductos._nombreProducto
            DcomprasProductosDataGridView.CurrentRow.Cells("marca").Value = ""
            DcomprasProductosDataGridView.CurrentRow.Cells("medidas").Value = ""

            DcomprasProductosDataGridView.CurrentRow.Cells("cantidad").Value = 1
            DcomprasProductosDataGridView.CurrentRow.Cells("precio").Value = 0

        End If
    End Sub

    Private Sub DcomprasProductosDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles DcomprasProductosDataGridView.KeyUp
        Try
            totalizar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnQuitarProducto_Click(sender As Object, e As EventArgs) Handles btnQuitarProducto.Click
        Try
            DcomprasProductosDataGridView.Rows.Remove(DcomprasProductosDataGridView.CurrentRow)
            totalizar()
        Catch ex As Exception
            MessageBox.Show("Error al intentar quitar la fila: " + ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim objClientes As New frmcliente
        objClientes.Show()
    End Sub

End Class