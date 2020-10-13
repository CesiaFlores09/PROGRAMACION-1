<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_person_man_1120619
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_hierarchy_1931214__1_
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_users_4172317
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
End Class
