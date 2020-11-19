Public Class frmPeddos
    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_empresaDataSet)

    End Sub

    Private Sub frmPeddos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        totalizar()
    End Sub
    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = DventasProductoDataGridView.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double
            For i As Integer = 0 To nfilas
                fila = DventasProductoDataGridView.Rows(i)
                subtotal = Double.Parse(fila.Cells("cantidad").Value.ToString()) * Double.Parse(fila.Cells("precio").Value.ToString())

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
            MessageBox.Show("Error " + ex.Message)
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
End Class