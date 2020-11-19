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
End Class
