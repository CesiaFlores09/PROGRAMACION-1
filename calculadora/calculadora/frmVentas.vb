Imports System.Data.SqlClient
Public Class frmVentas
    Public _idVta As Integer = 0

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet._dventasproducto' Puede moverla o quitarla según sea necesario.
        Me.DventasproductoTableAdapter1.Filldventasproducto(Me.Bd_empresaDataSet._dventasproducto)
        'TODO: esta línea de código carga datos en la tabla 'Bd_empresaDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fillventas(Me.Bd_empresaDataSet.ventas)

    End Sub

    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = DventasproductoDataGridView.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double

            For i As Integer = 0 To nfilas
                fila = DventasproductoDataGridView.Rows(i)
                subtotal = Double.Parse(fila.Cells("cantidad").Value.ToString()) * Double.Parse(fila.Cells("precio").Value.ToString())


                fila.Cells("subtotal").Value = subtotal.ToString()

                sumas += subtotal
            Next
            iva = If(IdTipofacturaComboBox.SelectedValue = 2, sumas * 0.13, 0)
            total = sumas + iva

            lblRespuestaSuma.Text = "$ " + Math.Round(sumas, 2).ToString()
            lblRespuestaIva.Text = "$ " + Math.Round(iva, 2).ToString()
            lblRespuestaTotal.Text = "$ " + Math.Round(total, 2).ToString()

            lblnregistros.Text = (VentasBindingSource.Position + 1) & " de " & VentasBindingSource.Count

        Catch ex As Exception
            'MessageBox.Show("Error " + ex.Message)
        End Try
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        VentasBindingSource.MoveFirst()
        totalizar()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        VentasBindingSource.MovePrevious()
        totalizar()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        VentasBindingSource.MoveNext()
        totalizar()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        VentasBindingSource.MoveLast()
        totalizar()
    End Sub

    Private Sub habdesh_controles(ByVal valor As Boolean)
        NfacturaTextBox.ReadOnly = valor
        IdClienteComboBox.Enabled = Not valor
        Fecha_vtaDateTimePicker.Enabled = Not valor
        IdTipofacturaComboBox.Enabled = Not valor
        IdPagoComboBox.Enabled = Not valor
        DventasproductoDataGridView.ReadOnly = valor

        grbVentasProductos.Visible = Not valor
        grbNavegacion.Visible = valor
        btnAgregarCliente.Visible = Not valor

        btnEliminar.Enabled = valor
        btnBuscar.Enabled = valor
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Nuevo" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"

            habdesh_controles(False)
            VentasBindingSource.AddNew()

            IdClienteComboBox.SelectedValue = 1 'Cliente por default Ventas a Publico
            IdTipofacturaComboBox.SelectedValue = 3 'Tipo de factura por default consumidor fiscal
            IdPagoComboBox.SelectedValue = 1 'Tipo de pago por default efectivo
            Fecha_vtaDateTimePicker.Value = Date.Now

        Else 'Guardar
            Try

                _idVta = Integer.Parse(lblIdVenta.Text)
                Me.Validate()
                VentasBindingSource.EndEdit()

                If _idVta > 0 Then 'Modificando
                    eliminarDetalle()
                Else 'Agregando Nuevas Facturas
                    VentasTableAdapter.Connection.Open()
                    Dim comando As New SqlCommand
                    comando.Connection = VentasTableAdapter.Connection
                    comando.CommandText = "SELECT ident_current('ventas') + 1 As idVenta"
                    _idVta = Integer.Parse(comando.ExecuteScalar().ToString())
                    VentasTableAdapter.Connection.Close()
                End If

                Dim nfilas As Integer = DventasproductoDataGridView.Rows.Count
                Dim valores(nfilas, 3) As String
                Dim fila As New DataGridViewRow

                For i = 0 To nfilas - 1
                    fila = DventasproductoDataGridView.Rows(i)
                    valores(i, 0) = fila.Cells("idproducto").Value.ToString()
                    valores(i, 1) = fila.Cells("cantidad").Value.ToString()
                    valores(i, 2) = fila.Cells("precio").Value.ToString()
                Next
                TableAdapterManager.UpdateAll(Bd_empresaDataSet)

                For i = 0 To nfilas - 1
                    DventasTableAdapter1.Insert(
                    _idVta,
                        valores(i, 0),
                        valores(i, 1),
                        valores(i, 2)
                        )
                Next
                actualizarDs()
                VentasBindingSource.MoveLast()

                habdesh_controles(True)
                btnAgregar.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            Catch ex As Exception
                MessageBox.Show("Error al intentar guardar: " + ex.Message,
                    "Registro de Facturas de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub eliminarDetalle()
        VentasTableAdapter.Connection.Open()
        Dim comando As New SqlCommand
        comando.Connection = VentasTableAdapter.Connection

        comando.CommandText = "delete from dventas where idVenta=" + _idVta.ToString()
        comando.ExecuteNonQuery()
        VentasTableAdapter.Connection.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"

            habdesh_controles(False)
        Else 'Cancelar
            DventasproductoBindingSource.CancelEdit()
            VentasBindingSource.CancelEdit()

            habdesh_controles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim objBuscarProductos As New frmBuacarProductovb
        objBuscarProductos.ShowDialog()
        If objBuscarProductos._idpr > 0 Then
            DventasproductoBindingSource.AddNew()
            DventasproductoDataGridView.CurrentRow.Cells("idproducto").Value = objBuscarProductos._idpr
            DventasproductoDataGridView.CurrentRow.Cells("codigo").Value = objBuscarProductos._codigoProducto
            DventasproductoDataGridView.CurrentRow.Cells("nombre").Value = objBuscarProductos._nombreProducto
            DventasproductoDataGridView.CurrentRow.Cells("marca").Value = ""
            DventasproductoDataGridView.CurrentRow.Cells("medidas").Value = ""

            DventasproductoDataGridView.CurrentRow.Cells("cantidad").Value = 1
            DventasproductoDataGridView.CurrentRow.Cells("precio").Value = 0

        End If
    End Sub

    Private Sub DventasproductoDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles DventasproductoDataGridView.KeyUp
        Try
            totalizar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnQuitarProductos_Click(sender As Object, e As EventArgs) Handles btnQuitarProductos.Click
        Try
            DventasproductoDataGridView.Rows.Remove(DventasproductoDataGridView.CurrentRow)
            totalizar()
        Catch ex As Exception
            MessageBox.Show("Error al intentar quitar la fila: " + ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim objClientes As New frmcliente
        objClientes.Show()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim objImprimirVta As New frmImpresionVentas
        objImprimirVta._idVta = lblIdVenta.Text
        objImprimirVta.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        _idVta = Integer.Parse(lblIdVenta.Text)
        eliminarDetalle()

        VentasBindingSource.RemoveAt(VentasBindingSource.Position)
        VentasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Bd_empresaDataSet)

        actualizarDs()
    End Sub
End Class