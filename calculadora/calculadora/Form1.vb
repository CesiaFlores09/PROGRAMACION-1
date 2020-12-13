Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim objEmpleados As New frmempleados
        objEmpleados.MdiParent = Me
        objEmpleados.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim objUsuarios As New frmusuarios
        objUsuarios.MdiParent = Me
        objUsuarios.Show()
    End Sub
    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim objProveedores As New frmproveedores
        objProveedores.MdiParent = Me
        objProveedores.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim objcClientes As New frmcliente
        objcClientes.MdiParent = Me
        objcClientes.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim objProductos As New Frmproductos
        objProductos.MdiParent = Me
        objProductos.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Dim objcategoria As New frmCategoriavb
        objcategoria.MdiParent = Me
        objcategoria.Show()
    End Sub

    Private Sub PedidosAProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosAProveedoresToolStripMenuItem.Click
        Dim objfacturapedidos As New frmPeddos
        objfacturapedidos.MdiParent = Me
        objfacturapedidos.Show()
    End Sub

    Private Sub FacturacionComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacturacionComprasToolStripMenuItem1.Click
        Dim objfacturacompras As New frmCompras
        objfacturacompras.MdiParent = Me
        objfacturacompras.Show()
    End Sub

    Private Sub PuestoLaboralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestoLaboralToolStripMenuItem.Click
        Dim objPuestoLaboral As New frmPuestoLaboral
        objPuestoLaboral.MdiParent = Me
        objPuestoLaboral.Show()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Dim objListadoClientes As New frmListadoClientes
        objListadoClientes.MdiParent = Me
        objListadoClientes.Show()
    End Sub

    Private Sub ComprasPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorClienteToolStripMenuItem.Click
        Dim objComprasPorCliente As New frmComprasPorCliente
        objComprasPorCliente.MdiParent = Me
        objComprasPorCliente.Show()
    End Sub

    Private Sub ListadoDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeEmpleadosToolStripMenuItem.Click
        Dim objListadoEmpleados As New frmListadoEmpleados
        objListadoEmpleados.MdiParent = Me
        objListadoEmpleados.Show()
    End Sub

    Private Sub ListadoDeProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProvedoresToolStripMenuItem.Click
        Dim objListadoProveedores As New frmListadoProveedores
        objListadoProveedores.MdiParent = Me
        objListadoProveedores.Show()
    End Sub

    Private Sub ListadoDeCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeCategoriasToolStripMenuItem.Click
        Dim objListadoCategorias As New frmListadoCategorias
        objListadoCategorias.MdiParent = Me
        objListadoCategorias.Show()
    End Sub

    Private Sub ListadoPuestoLaboralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoPuestoLaboralToolStripMenuItem.Click
        Dim objListadoPuestoLaboral As New frmListadoPuestoLaboralvb
        objListadoPuestoLaboral.MdiParent = Me
        objListadoPuestoLaboral.Show()
    End Sub

    Private Sub ListadoDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeUsuariosToolStripMenuItem.Click
        Dim objListadoUsuarios As New frmListadoUsuarios
        objListadoUsuarios.MdiParent = Me
        objListadoUsuarios.Show()
    End Sub

    Private Sub ListadoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
        Dim objListadoProductos As New frmListadoProductos
        objListadoProductos.MdiParent = Me
        objListadoProductos.Show()
    End Sub
End Class
