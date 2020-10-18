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
End Class
