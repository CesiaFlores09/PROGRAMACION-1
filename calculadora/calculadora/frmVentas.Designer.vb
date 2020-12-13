<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NfacturaLabel As System.Windows.Forms.Label
        Dim Fecha_vtaLabel As System.Windows.Forms.Label
        Dim Fecha_hora_registroLabel As System.Windows.Forms.Label
        Dim IdTipofacturaLabel As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Me.Bd_empresaDataSet = New calculadora.bd_empresaDataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.ventasTableAdapter()
        Me.TableAdapterManager = New calculadora.bd_empresaDataSetTableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.clienteTableAdapter()
        Me.PagTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.pagTableAdapter()
        Me.TipoFacturaTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.TipoFacturaTableAdapter()
        Me.NfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_vtaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTipofacturaComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.PagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DventasproductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DventasproductoTableAdapter1 = New calculadora.bd_empresaDataSetTableAdapters.dventasproductoTableAdapter1()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.lblIdVenta = New System.Windows.Forms.Label()
        Me.grbVentasProductos = New System.Windows.Forms.GroupBox()
        Me.btnQuitarProductos = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.lblnregistros = New System.Windows.Forms.Label()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRespuestaTotal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblRespuestaIva = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.lblRespuestaSuma = New System.Windows.Forms.Label()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.DventasTableAdapter1 = New calculadora.bd_empresaDataSetTableAdapters.dventasTableAdapter()
        Me.DventasproductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DventasproductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DventasProductoTableAdapter2 = New calculadora.bd_empresaDataSetTableAdapters.DventasProductoTableAdapter()
        Me.DventasproductoTableAdapter11 = New calculadora.bd_empresaDataSetTableAdapters.dventasproductoTableAdapter1()
        Me.DventasTableAdapter2 = New calculadora.bd_empresaDataSetTableAdapters.dventasTableAdapter()
        NfacturaLabel = New System.Windows.Forms.Label()
        Fecha_vtaLabel = New System.Windows.Forms.Label()
        Fecha_hora_registroLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        CType(Me.Bd_empresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DventasproductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbVentasProductos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DventasproductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DventasproductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(601, 38)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(66, 13)
        NfacturaLabel.TabIndex = 3
        NfacturaLabel.Text = "Factura: No."
        '
        'Fecha_vtaLabel
        '
        Fecha_vtaLabel.AutoSize = True
        Fecha_vtaLabel.Location = New System.Drawing.Point(12, 84)
        Fecha_vtaLabel.Name = "Fecha_vtaLabel"
        Fecha_vtaLabel.Size = New System.Drawing.Size(59, 13)
        Fecha_vtaLabel.TabIndex = 5
        Fecha_vtaLabel.Text = "Fecha Vta:"
        '
        'Fecha_hora_registroLabel
        '
        Fecha_hora_registroLabel.AutoSize = True
        Fecha_hora_registroLabel.Location = New System.Drawing.Point(227, 197)
        Fecha_hora_registroLabel.Name = "Fecha_hora_registroLabel"
        Fecha_hora_registroLabel.Size = New System.Drawing.Size(0, 13)
        Fecha_hora_registroLabel.TabIndex = 7
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(279, 84)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(67, 13)
        IdTipofacturaLabel.TabIndex = 9
        IdTipofacturaLabel.Text = "Tipo factura:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(472, 85)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(67, 13)
        IdPagoLabel.TabIndex = 11
        IdPagoLabel.Text = "Forma Pago:"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(12, 42)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(42, 13)
        IdClienteLabel.TabIndex = 13
        IdClienteLabel.Text = "Cliente:"
        '
        'Bd_empresaDataSet
        '
        Me.Bd_empresaDataSet.DataSetName = "bd_empresaDataSet"
        Me.Bd_empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.dcomprasTableAdapter = Nothing
        Me.TableAdapterManager.dpedidosTableAdapter = Nothing
        Me.TableAdapterManager.dventasTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.pagTableAdapter = Me.PagTableAdapter
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.puestoTableAdapter = Nothing
        Me.TableAdapterManager.TipoFacturaTableAdapter = Me.TipoFacturaTableAdapter
        Me.TableAdapterManager.UpdateOrder = calculadora.bd_empresaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Me.VentasTableAdapter
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'PagTableAdapter
        '
        Me.PagTableAdapter.ClearBeforeFill = True
        '
        'TipoFacturaTableAdapter
        '
        Me.TipoFacturaTableAdapter.ClearBeforeFill = True
        '
        'NfacturaTextBox
        '
        Me.NfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "nfactura", True))
        Me.NfacturaTextBox.Location = New System.Drawing.Point(676, 35)
        Me.NfacturaTextBox.Name = "NfacturaTextBox"
        Me.NfacturaTextBox.ReadOnly = True
        Me.NfacturaTextBox.Size = New System.Drawing.Size(112, 20)
        Me.NfacturaTextBox.TabIndex = 4
        '
        'Fecha_vtaDateTimePicker
        '
        Me.Fecha_vtaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fecha_vta", True))
        Me.Fecha_vtaDateTimePicker.Location = New System.Drawing.Point(73, 78)
        Me.Fecha_vtaDateTimePicker.Name = "Fecha_vtaDateTimePicker"
        Me.Fecha_vtaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_vtaDateTimePicker.TabIndex = 6
        '
        'IdTipofacturaComboBox
        '
        Me.IdTipofacturaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "idTipofactura", True))
        Me.IdTipofacturaComboBox.DataSource = Me.TipoFacturaBindingSource
        Me.IdTipofacturaComboBox.DisplayMember = "tipo"
        Me.IdTipofacturaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdTipofacturaComboBox.FormattingEnabled = True
        Me.IdTipofacturaComboBox.Location = New System.Drawing.Point(352, 81)
        Me.IdTipofacturaComboBox.Name = "IdTipofacturaComboBox"
        Me.IdTipofacturaComboBox.Size = New System.Drawing.Size(114, 21)
        Me.IdTipofacturaComboBox.TabIndex = 10
        Me.IdTipofacturaComboBox.ValueMember = "idTipoF"
        '
        'TipoFacturaBindingSource
        '
        Me.TipoFacturaBindingSource.DataMember = "TipoFactura"
        Me.TipoFacturaBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'IdPagoComboBox
        '
        Me.IdPagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "idPago", True))
        Me.IdPagoComboBox.DataSource = Me.PagBindingSource
        Me.IdPagoComboBox.DisplayMember = "pago"
        Me.IdPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdPagoComboBox.FormattingEnabled = True
        Me.IdPagoComboBox.Location = New System.Drawing.Point(545, 82)
        Me.IdPagoComboBox.Name = "IdPagoComboBox"
        Me.IdPagoComboBox.Size = New System.Drawing.Size(122, 21)
        Me.IdPagoComboBox.TabIndex = 12
        Me.IdPagoComboBox.ValueMember = "idPago"
        '
        'PagBindingSource
        '
        Me.PagBindingSource.DataMember = "pag"
        Me.PagBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'IdClienteComboBox
        '
        Me.IdClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "idCliente", True))
        Me.IdClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.IdClienteComboBox.DisplayMember = "nombre"
        Me.IdClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdClienteComboBox.FormattingEnabled = True
        Me.IdClienteComboBox.Location = New System.Drawing.Point(73, 39)
        Me.IdClienteComboBox.Name = "IdClienteComboBox"
        Me.IdClienteComboBox.Size = New System.Drawing.Size(200, 21)
        Me.IdClienteComboBox.TabIndex = 14
        Me.IdClienteComboBox.ValueMember = "idcliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'DventasproductoBindingSource
        '
        Me.DventasproductoBindingSource.DataMember = "dventasproducto"
        Me.DventasproductoBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'DventasproductoTableAdapter1
        '
        Me.DventasproductoTableAdapter1.ClearBeforeFill = True
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(291, 39)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(97, 23)
        Me.btnAgregarCliente.TabIndex = 15
        Me.btnAgregarCliente.Text = "Nuevo Cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'lblIdVenta
        '
        Me.lblIdVenta.AutoSize = True
        Me.lblIdVenta.Location = New System.Drawing.Point(394, 44)
        Me.lblIdVenta.Name = "lblIdVenta"
        Me.lblIdVenta.Size = New System.Drawing.Size(39, 13)
        Me.lblIdVenta.TabIndex = 16
        Me.lblIdVenta.Text = "Label1"
        '
        'grbVentasProductos
        '
        Me.grbVentasProductos.Controls.Add(Me.btnQuitarProductos)
        Me.grbVentasProductos.Controls.Add(Me.btnAgregarProducto)
        Me.grbVentasProductos.Location = New System.Drawing.Point(12, 444)
        Me.grbVentasProductos.Name = "grbVentasProductos"
        Me.grbVentasProductos.Size = New System.Drawing.Size(273, 51)
        Me.grbVentasProductos.TabIndex = 17
        Me.grbVentasProductos.TabStop = False
        '
        'btnQuitarProductos
        '
        Me.btnQuitarProductos.Location = New System.Drawing.Point(122, 20)
        Me.btnQuitarProductos.Name = "btnQuitarProductos"
        Me.btnQuitarProductos.Size = New System.Drawing.Size(102, 23)
        Me.btnQuitarProductos.TabIndex = 1
        Me.btnQuitarProductos.Text = "Quitar Productos"
        Me.btnQuitarProductos.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(7, 20)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(108, 23)
        Me.btnAgregarProducto.TabIndex = 0
        Me.btnAgregarProducto.Text = "Agregar Productos"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.lblnregistros)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(12, 521)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(273, 73)
        Me.grbNavegacion.TabIndex = 18
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(200, 35)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(55, 23)
        Me.btnUltimo.TabIndex = 19
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(154, 35)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(52, 23)
        Me.btnSiguiente.TabIndex = 19
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'lblnregistros
        '
        Me.lblnregistros.AutoSize = True
        Me.lblnregistros.Location = New System.Drawing.Point(112, 40)
        Me.lblnregistros.Name = "lblnregistros"
        Me.lblnregistros.Size = New System.Drawing.Size(36, 13)
        Me.lblnregistros.TabIndex = 3
        Me.lblnregistros.Text = "x de n"
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(54, 35)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(52, 23)
        Me.btnAnterior.TabIndex = 2
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(7, 35)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(52, 23)
        Me.btnPrimero.TabIndex = 1
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnImprimir)
        Me.grbEdicion.Controls.Add(Me.btnBuscar)
        Me.grbEdicion.Controls.Add(Me.btnEliminar)
        Me.grbEdicion.Controls.Add(Me.btnModificar)
        Me.grbEdicion.Controls.Add(Me.btnAgregar)
        Me.grbEdicion.Location = New System.Drawing.Point(301, 521)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(366, 73)
        Me.grbEdicion.TabIndex = 19
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(281, 35)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(214, 35)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(146, 35)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(77, 35)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(6, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblRespuestaTotal)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.lblRespuestaIva)
        Me.Panel1.Controls.Add(Me.lbliva)
        Me.Panel1.Controls.Add(Me.lblRespuestaSuma)
        Me.Panel1.Controls.Add(Me.lblsuma)
        Me.Panel1.Location = New System.Drawing.Point(688, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 160)
        Me.Panel1.TabIndex = 21
        '
        'lblRespuestaTotal
        '
        Me.lblRespuestaTotal.AutoSize = True
        Me.lblRespuestaTotal.Location = New System.Drawing.Point(132, 122)
        Me.lblRespuestaTotal.Name = "lblRespuestaTotal"
        Me.lblRespuestaTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblRespuestaTotal.TabIndex = 5
        Me.lblRespuestaTotal.Text = "00:00"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(3, 122)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(42, 13)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "TOTAL"
        '
        'lblRespuestaIva
        '
        Me.lblRespuestaIva.AutoSize = True
        Me.lblRespuestaIva.Location = New System.Drawing.Point(132, 77)
        Me.lblRespuestaIva.Name = "lblRespuestaIva"
        Me.lblRespuestaIva.Size = New System.Drawing.Size(34, 13)
        Me.lblRespuestaIva.TabIndex = 3
        Me.lblRespuestaIva.Text = "00:00"
        '
        'lbliva
        '
        Me.lbliva.AutoSize = True
        Me.lbliva.Location = New System.Drawing.Point(5, 77)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(24, 13)
        Me.lbliva.TabIndex = 2
        Me.lbliva.Text = "IVA"
        '
        'lblRespuestaSuma
        '
        Me.lblRespuestaSuma.AutoSize = True
        Me.lblRespuestaSuma.Location = New System.Drawing.Point(132, 20)
        Me.lblRespuestaSuma.Name = "lblRespuestaSuma"
        Me.lblRespuestaSuma.Size = New System.Drawing.Size(34, 13)
        Me.lblRespuestaSuma.TabIndex = 1
        Me.lblRespuestaSuma.Text = "00:00"
        '
        'lblsuma
        '
        Me.lblsuma.AutoSize = True
        Me.lblsuma.Location = New System.Drawing.Point(3, 20)
        Me.lblsuma.Name = "lblsuma"
        Me.lblsuma.Size = New System.Drawing.Size(41, 13)
        Me.lblsuma.TabIndex = 0
        Me.lblsuma.Text = "SUMA:"
        '
        'DventasTableAdapter1
        '
        Me.DventasTableAdapter1.ClearBeforeFill = True
        '
        'DventasproductoBindingSource1
        '
        Me.DventasproductoBindingSource1.DataMember = "FK_dventas_ventas1"
        Me.DventasproductoBindingSource1.DataSource = Me.VentasBindingSource
        '
        'DventasproductoDataGridView
        '
        Me.DventasproductoDataGridView.AutoGenerateColumns = False
        Me.DventasproductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DventasproductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.codigo, Me.nombre, Me.CANT, Me.DataGridViewTextBoxColumn5, Me.subtotal, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DventasproductoDataGridView.DataSource = Me.DventasproductoBindingSource1
        Me.DventasproductoDataGridView.Location = New System.Drawing.Point(127, 109)
        Me.DventasproductoDataGridView.Name = "DventasproductoDataGridView"
        Me.DventasproductoDataGridView.Size = New System.Drawing.Size(735, 334)
        Me.DventasproductoDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idDetalle"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idDetalle"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idVenta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idVenta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idProducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idProducto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 250
        '
        'CANT
        '
        Me.CANT.DataPropertyName = "cantidad"
        Me.CANT.HeaderText = "CANTIDAD"
        Me.CANT.Name = "CANT"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PRECIO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "idDetalle"
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn8.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "medidas"
        Me.DataGridViewTextBoxColumn9.HeaderText = "medidas"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DventasProductoTableAdapter2
        '
        Me.DventasProductoTableAdapter2.ClearBeforeFill = True
        '
        'DventasproductoTableAdapter11
        '
        Me.DventasproductoTableAdapter11.ClearBeforeFill = True
        '
        'DventasTableAdapter2
        '
        Me.DventasTableAdapter2.ClearBeforeFill = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 624)
        Me.Controls.Add(Me.DventasproductoDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbVentasProductos)
        Me.Controls.Add(Me.lblIdVenta)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(NfacturaLabel)
        Me.Controls.Add(Me.NfacturaTextBox)
        Me.Controls.Add(Fecha_vtaLabel)
        Me.Controls.Add(Me.Fecha_vtaDateTimePicker)
        Me.Controls.Add(Fecha_hora_registroLabel)
        Me.Controls.Add(IdTipofacturaLabel)
        Me.Controls.Add(Me.IdTipofacturaComboBox)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Me.IdPagoComboBox)
        Me.Controls.Add(IdClienteLabel)
        Me.Controls.Add(Me.IdClienteComboBox)
        Me.Name = "frmVentas"
        Me.Text = "Facturacion de ventas"
        CType(Me.Bd_empresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DventasproductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbVentasProductos.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DventasproductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DventasproductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bd_empresaDataSet As bd_empresaDataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As bd_empresaDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents TableAdapterManager As bd_empresaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NfacturaTextBox As TextBox
    Friend WithEvents Fecha_vtaDateTimePicker As DateTimePicker
    Friend WithEvents IdTipofacturaComboBox As ComboBox
    Friend WithEvents IdPagoComboBox As ComboBox
    Friend WithEvents IdClienteComboBox As ComboBox
    Friend WithEvents DventasproductoBindingSource As BindingSource
    Friend WithEvents DventasproductoTableAdapter1 As bd_empresaDataSetTableAdapters.dventasproductoTableAdapter1
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents lblIdVenta As Label
    Friend WithEvents grbVentasProductos As GroupBox
    Friend WithEvents btnQuitarProductos As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents lblnregistros As Label
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ClienteTableAdapter As bd_empresaDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRespuestaTotal As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblRespuestaIva As Label
    Friend WithEvents lbliva As Label
    Friend WithEvents lblRespuestaSuma As Label
    Friend WithEvents lblsuma As Label
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents TipoFacturaTableAdapter As bd_empresaDataSetTableAdapters.TipoFacturaTableAdapter
    Friend WithEvents TipoFacturaBindingSource As BindingSource
    Friend WithEvents PagTableAdapter As bd_empresaDataSetTableAdapters.pagTableAdapter
    Friend WithEvents PagBindingSource As BindingSource
    Friend WithEvents DventasTableAdapter1 As bd_empresaDataSetTableAdapters.dventasTableAdapter
    Friend WithEvents DventasproductoBindingSource1 As BindingSource
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents DventasproductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents CANT As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
    Friend WithEvents DventasProductoTableAdapter2 As bd_empresaDataSetTableAdapters.DventasProductoTableAdapter
    Friend WithEvents DventasproductoTableAdapter11 As bd_empresaDataSetTableAdapters.dventasproductoTableAdapter1
    Friend WithEvents DventasTableAdapter2 As bd_empresaDataSetTableAdapters.dventasTableAdapter
End Class
