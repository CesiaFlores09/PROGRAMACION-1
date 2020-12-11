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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestoLaboralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosAProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ComprasToolStripMenuItem1, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_Folder_Paper_Files_File_Case_Browse_Folder_Archive_4265035__1_1
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_DeleteRed_34218
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.EmpresaToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_Map___Location_Solid_Style_09_2216349
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_person_man_1120619
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PuestoLaboralToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_hierarchy_1931214__1_
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'PuestoLaboralToolStripMenuItem
        '
        Me.PuestoLaboralToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_cv_job_seeker_employee_unemployee_work_2620524__1_
        Me.PuestoLaboralToolStripMenuItem.Name = "PuestoLaboralToolStripMenuItem"
        Me.PuestoLaboralToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.PuestoLaboralToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PuestoLaboralToolStripMenuItem.Text = "Puesto Laboral"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_User_Customers_1218712
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_user_61842
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriaToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_inventory_maintenance_49590
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_categories_4650511
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_deliverables_45506
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosAProveedoresToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_shopping_cart_326700
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.ComprasToolStripMenuItem.Text = "Pedidos"
        '
        'PedidosAProveedoresToolStripMenuItem
        '
        Me.PedidosAProveedoresToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_electronic_billing_machine_44639
        Me.PedidosAProveedoresToolStripMenuItem.Name = "PedidosAProveedoresToolStripMenuItem"
        Me.PedidosAProveedoresToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.PedidosAProveedoresToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.PedidosAProveedoresToolStripMenuItem.Text = "Facturacion Pedidos"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionComprasToolStripMenuItem1})
        Me.ComprasToolStripMenuItem1.Image = Global.calculadora.My.Resources.Resources.iconfinder__shopify_1249991__1_
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(87, 24)
        Me.ComprasToolStripMenuItem1.Text = "Compras"
        '
        'FacturacionComprasToolStripMenuItem1
        '
        Me.FacturacionComprasToolStripMenuItem1.Image = Global.calculadora.My.Resources.Resources.iconfinder_635_Bill_excel_file_invoice_statement_4017677
        Me.FacturacionComprasToolStripMenuItem1.Name = "FacturacionComprasToolStripMenuItem1"
        Me.FacturacionComprasToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FacturacionComprasToolStripMenuItem1.Size = New System.Drawing.Size(248, 22)
        Me.FacturacionComprasToolStripMenuItem1.Text = "Facturacion compras"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeClientesToolStripMenuItem, Me.ComprasPorClienteToolStripMenuItem, Me.ListadoDeEmpleadosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_report_service_statistics_call_performance_3709732__1_
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_13_Clipboard_290137
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'ComprasPorClienteToolStripMenuItem
        '
        Me.ComprasPorClienteToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_00_ELASTOFONT_STORE_READY_invoice_2703075
        Me.ComprasPorClienteToolStripMenuItem.Name = "ComprasPorClienteToolStripMenuItem"
        Me.ComprasPorClienteToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.ComprasPorClienteToolStripMenuItem.Text = "Compras por Cliente"
        '
        'ListadoDeEmpleadosToolStripMenuItem
        '
        Me.ListadoDeEmpleadosToolStripMenuItem.Image = Global.calculadora.My.Resources.Resources.iconfinder_preferences_contact_list_24249
        Me.ListadoDeEmpleadosToolStripMenuItem.Name = "ListadoDeEmpleadosToolStripMenuItem"
        Me.ListadoDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.ListadoDeEmpleadosToolStripMenuItem.Text = "Listado de Empleados"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.calculadora.My.Resources.Resources.diferentes_electrodomesticos_equipos_casa_electrica_tienda_minorista_moderna_sala_exposicion_interior_plano_horizontal_48369_26072
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosAProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FacturacionComprasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PuestoLaboralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasPorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeEmpleadosToolStripMenuItem As ToolStripMenuItem
End Class
