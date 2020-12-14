Imports System.Data.SqlClient
Public Class frmPeddos
    Public _idPedido As Integer = 0
    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_empresaDataSet)

    End Sub

    Private Sub frmPeddos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarDs()
        totalizar()
    End Sub

    Private Sub actualizarDs()
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.pag' Puede moverla o quitarla según sea necesario.
        Me.PagTableAdapter.FillPag(Me.Bd_empresaDataSet.pag)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.TipoFactura' Puede moverla o quitarla según sea necesario.
        Me.TipoFacturaTableAdapter.FillTipoFactura(Me.Bd_empresaDataSet.TipoFactura)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fillproveedores(Me.Bd_empresaDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.DventasProducto' Puede moverla o quitarla según sea necesario.
        Me.DventasProductoTableAdapter.FillDventasProducto(Me.Bd_empresaDataSet.DventasProducto)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fillpedidos(Me.Bd_empresaDataSet.pedidos)

    End Sub
    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = DventasProductoDataGridView.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double

            For i As Integer = 0 To nfilas
                fila = DventasProductoDataGridView.Rows(i)
                subtotal = Double.Parse(fila.Cells("Cantidad").Value.ToString()) * Double.Parse(fila.Cells("Precio").Value.ToString())

                fila.Cells("subtotal").Value = subtotal.ToString()

                sumas += subtotal
            Next
            iva = If(IdTipoFComboBox.SelectedValue = 2, sumas * 0.13, 0)
            total = sumas + iva

            lblResS.Text = "$ " + Math.Round(sumas, 2).ToString()
            lblResI.Text = "$ " + Math.Round(iva, 2).ToString()
            lblResTotal.Text = "$ " + Math.Round(total, 2).ToString()

            lblRegistroPedidos.Text = (PedidosBindingSource.Position + 1) & " de " & PedidosBindingSource.Count

        Catch ex As Exception
            'MessageBox.Show("Error " + ex.Message)
        End Try
    End Sub

    Private Sub btnPrimeroPedidos_Click(sender As Object, e As EventArgs) Handles btnPrimeroPedidos.Click
        PedidosBindingSource.MoveFirst()
        totalizar()
    End Sub

    Private Sub btnAnteriorPedidos_Click(sender As Object, e As EventArgs) Handles btnAnteriorPedidos.Click
        PedidosBindingSource.MovePrevious()
        totalizar()
    End Sub

    Private Sub btnSiguientePedidos_Click(sender As Object, e As EventArgs) Handles btnSiguientePedidos.Click
        PedidosBindingSource.MoveNext()
        totalizar()

    End Sub

    Private Sub btnUltimoPedidos_Click(sender As Object, e As EventArgs) Handles btnUltimoPedidos.Click
        PedidosBindingSource.MoveLast()
        totalizar()
    End Sub

    Private Sub btnAgregarPedidos_Click(sender As Object, e As EventArgs) Handles btnAgregarPedidos.Click
        If btnAgregarPedidos.Text = "Nuevo" Then
            btnAgregarPedidos.Text = "Guardar"
            btnModificarPedidos.Text = "Cancelar"

            habdesh_controles(False)
            PedidosBindingSource.AddNew()

            IdproveedoresComboBox.SelectedValue = 1 'Proveedor por default Alfonso Juarez
            IdTipoFComboBox.SelectedValue = 1 'Tipo de factura por default consumidor final 
            IdPagoComboBox.SelectedValue = 1 'Tipo de pago por default efectivo
            FechaDateTimePicker.Value = Date.Now

        Else 'Guardar

            Try
                _idPedido = Integer.Parse(lblIdPedido.Text)
                Me.Validate()
                PedidosBindingSource.EndEdit()

                If _idPedido > 0 Then 'Modificando
                    eliminarPedido()
                Else 'Agregando Nuevas Facturas
                    PedidosTableAdapter.Connection.Open()
                    Dim comando As New SqlCommand
                    comando.Connection = PedidosTableAdapter.Connection
                    comando.CommandText = "SELECT ident_current('pedidos') + 1 As idpedidos"
                    _idPedido = Integer.Parse(comando.ExecuteScalar().ToString())
                    PedidosTableAdapter.Connection.Close()
                End If

                Dim nfilas As Integer = DventasProductoDataGridView.Rows.Count
                Dim valores(nfilas, 3) As String
                Dim fila As New DataGridViewRow

                For i = 0 To nfilas - 1
                    fila = DventasProductoDataGridView.Rows(i)
                    valores(i, 0) = fila.Cells("idproducto").Value.ToString()
                    valores(i, 1) = fila.Cells("Cantidad").Value.ToString()
                    valores(i, 2) = fila.Cells("Precio").Value.ToString()
                Next
                TableAdapterManager.UpdateAll(Bd_empresaDataSet)

                For i = 0 To nfilas - 1
                    DpedidosTableAdapter1.Insert(
                        _idPedido,
                        valores(i, 0),
                        valores(i, 1),
                        valores(i, 2)
                    )
                Next
                actualizarDs()
                PedidosBindingSource.MoveLast()

                habdesh_controles(True)
                btnAgregarPedidos.Text = "Nuevo"
                btnModificarPedidos.Text = "Modificar"

            Catch ex As Exception
                MessageBox.Show("Error al intentar guardar: " + ex.Message,
                            "Registro de Facturas de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub eliminarPedido()
        PedidosTableAdapter.Connection.Open()
        Dim comando As New SqlCommand
        comando.Connection = PedidosTableAdapter.Connection

        comando.CommandText = "delete from dpedidos where idpedidos=" + _idPedido.ToString()
        comando.ExecuteNonQuery()
        PedidosTableAdapter.Connection.Close()
    End Sub

    Private Sub btnModificarPedidos_Click(sender As Object, e As EventArgs) Handles btnModificarPedidos.Click
        If btnModificarPedidos.Text = "Modificar" Then
            btnAgregarPedidos.Text = "Guardar"
            btnModificarPedidos.Text = "Cancelar"

            habdesh_controles(False)

        Else 'Cancelar

            DventasProductoBindingSource.CancelEdit()
            PedidosBindingSource.CancelEdit()

            habdesh_controles(True)
            btnAgregarPedidos.Text = "Nuevo"
            btnModificarPedidos.Text = "Modificar"
        End If
    End Sub
    Private Sub habdesh_controles(ByVal valor As Boolean)
        NfacturaTextBox.ReadOnly = valor
        IdproveedoresComboBox.Enabled = Not valor
        FechaDateTimePicker.Enabled = Not valor
        IdTipoFComboBox.Enabled = Not valor
        IdPagoComboBox.Enabled = Not valor
        DventasProductoDataGridView.ReadOnly = valor

        grbdPedidosProductos.Visible = Not valor
        grbNavegacionPedidos.Visible = valor
        btnAgregarPedidos.Visible = Not valor

        btnEliminarPedidos.Enabled = valor
        btnBuscarPedidos.Enabled = valor
    End Sub

    Private Sub DventasProductoDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles DventasProductoDataGridView.KeyUp
        Try
            totalizar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarProductoPedidos_Click(sender As Object, e As EventArgs) Handles btnAgregarProductoPedidos.Click
        Dim objBuscarProductos As New frmBuacarProductovb
        objBuscarProductos.ShowDialog()
        If objBuscarProductos._idpr > 0 Then
            DventasProductoBindingSource.AddNew()
            DventasProductoDataGridView.CurrentRow.Cells("idproducto").Value = objBuscarProductos._idpr
            DventasProductoDataGridView.CurrentRow.Cells("codigo").Value = objBuscarProductos._codigoProducto
            DventasProductoDataGridView.CurrentRow.Cells("nombre").Value = objBuscarProductos._nombreProducto
            DventasProductoDataGridView.CurrentRow.Cells("marca").Value = ""
            DventasProductoDataGridView.CurrentRow.Cells("medidas").Value = ""

            DventasProductoDataGridView.CurrentRow.Cells("Cantidad").Value = 1
            DventasProductoDataGridView.CurrentRow.Cells("Precio").Value = 0

        End If
    End Sub

    Private Sub btnQuitarProductoPedidos_Click(sender As Object, e As EventArgs) Handles btnQuitarProductoPedidos.Click
        Try
            DventasProductoDataGridView.Rows.Remove(DventasProductoDataGridView.CurrentRow)
            totalizar()
        Catch ex As Exception
            MessageBox.Show("Error al intentar quitar la fila: " + ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarPedidos_Click(sender As Object, e As EventArgs) Handles btnEliminarPedidos.Click
        _idPedido = Integer.Parse(lblIdPedido.Text)
        eliminarPedido()

        PedidosBindingSource.RemoveAt(PedidosBindingSource.Position)
        PedidosBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Bd_empresaDataSet)

        actualizarDs()
    End Sub

    Private Sub btnImprimirPedido_Click(sender As Object, e As EventArgs) Handles btnImprimirPedido.Click
        Dim objImprimirPedidos As New frmImpresionPedidos
        objImprimirPedidos._idPedido = lblIdPedido.Text
        objImprimirPedidos.ShowDialog()
    End Sub

    Private Sub btnNuevoProveedor_Click(sender As Object, e As EventArgs) Handles btnNuevoProveedor.Click
        Dim objProveedores As New frmproveedores
        objProveedores.Show()
    End Sub
End Class