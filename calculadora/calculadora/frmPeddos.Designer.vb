<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeddos
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
        Dim IdproveedoresLabel As System.Windows.Forms.Label
        Dim NfacturaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim IdTipoFLabel As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPeddos))
        Me.Bd_empresaDataSet = New calculadora.bd_empresaDataSet()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.pedidosTableAdapter()
        Me.TableAdapterManager = New calculadora.bd_empresaDataSetTableAdapters.TableAdapterManager()
        Me.PagTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.pagTableAdapter()
        Me.ProveedoresTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.proveedoresTableAdapter()
        Me.TipoFacturaTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.TipoFacturaTableAdapter()
        Me.IdproveedoresComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTipoFComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.PagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DventasProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DventasProductoTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.DventasProductoTableAdapter()
        Me.DventasProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.idpedidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoFacturaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblResTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblResI = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblResS = New System.Windows.Forms.Label()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.ProveedoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grbNavegacionPedidos = New System.Windows.Forms.GroupBox()
        Me.lblRegistroPedidos = New System.Windows.Forms.Label()
        Me.btnUltimoPedidos = New System.Windows.Forms.Button()
        Me.btnSiguientePedidos = New System.Windows.Forms.Button()
        Me.btnAnteriorPedidos = New System.Windows.Forms.Button()
        Me.btnPrimeroPedidos = New System.Windows.Forms.Button()
        Me.grbEdicionPedidos = New System.Windows.Forms.GroupBox()
        Me.btnAgregarPedidos = New System.Windows.Forms.Button()
        Me.btnImprimirPedido = New System.Windows.Forms.Button()
        Me.btnBuscarPedidos = New System.Windows.Forms.Button()
        Me.btnEliminarPedidos = New System.Windows.Forms.Button()
        Me.btnModificarPedidos = New System.Windows.Forms.Button()
        Me.DpedidosTableAdapter1 = New calculadora.bd_empresaDataSetTableAdapters.dpedidosTableAdapter()
        Me.lblIdPedido = New System.Windows.Forms.Label()
        Me.grbdPedidosProductos = New System.Windows.Forms.GroupBox()
        Me.btnQuitarProductoPedidos = New System.Windows.Forms.Button()
        Me.btnAgregarProductoPedidos = New System.Windows.Forms.Button()
        Me.btnNuevoProveedor = New System.Windows.Forms.Button()
        IdproveedoresLabel = New System.Windows.Forms.Label()
        NfacturaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        IdTipoFLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        CType(Me.Bd_empresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DventasProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DventasProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoFacturaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNavegacionPedidos.SuspendLayout()
        Me.grbEdicionPedidos.SuspendLayout()
        Me.grbdPedidosProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdproveedoresLabel
        '
        IdproveedoresLabel.AutoSize = True
        IdproveedoresLabel.Location = New System.Drawing.Point(34, 12)
        IdproveedoresLabel.Name = "IdproveedoresLabel"
        IdproveedoresLabel.Size = New System.Drawing.Size(59, 13)
        IdproveedoresLabel.TabIndex = 3
        IdproveedoresLabel.Text = "Proveedor:"
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(596, 19)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(61, 13)
        NfacturaLabel.TabIndex = 5
        NfacturaLabel.Text = "N° Factura:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(34, 70)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(81, 13)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha Pedidos:"
        '
        'IdTipoFLabel
        '
        IdTipoFLabel.AutoSize = True
        IdTipoFLabel.Location = New System.Drawing.Point(327, 70)
        IdTipoFLabel.Name = "IdTipoFLabel"
        IdTipoFLabel.Size = New System.Drawing.Size(70, 13)
        IdTipoFLabel.TabIndex = 9
        IdTipoFLabel.Text = "Tipo Factura:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(565, 70)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(74, 13)
        IdPagoLabel.TabIndex = 11
        IdPagoLabel.Text = "Metodo Pago:"
        '
        'Bd_empresaDataSet
        '
        Me.Bd_empresaDataSet.DataSetName = "bd_empresaDataSet"
        Me.Bd_empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.dcomprasTableAdapter = Nothing
        Me.TableAdapterManager.dpedidosTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.pagTableAdapter = Me.PagTableAdapter
        Me.TableAdapterManager.pedidosTableAdapter = Me.PedidosTableAdapter
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.puestoTableAdapter = Nothing
        Me.TableAdapterManager.TipoFacturaTableAdapter = Me.TipoFacturaTableAdapter
        Me.TableAdapterManager.UpdateOrder = calculadora.bd_empresaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'PagTableAdapter
        '
        Me.PagTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TipoFacturaTableAdapter
        '
        Me.TipoFacturaTableAdapter.ClearBeforeFill = True
        '
        'IdproveedoresComboBox
        '
        Me.IdproveedoresComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidosBindingSource, "idproveedores", True))
        Me.IdproveedoresComboBox.DataSource = Me.ProveedoresBindingSource
        Me.IdproveedoresComboBox.DisplayMember = "nombre"
        Me.IdproveedoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdproveedoresComboBox.Enabled = False
        Me.IdproveedoresComboBox.FormattingEnabled = True
        Me.IdproveedoresComboBox.Location = New System.Drawing.Point(99, 12)
        Me.IdproveedoresComboBox.Name = "IdproveedoresComboBox"
        Me.IdproveedoresComboBox.Size = New System.Drawing.Size(298, 21)
        Me.IdproveedoresComboBox.TabIndex = 4
        Me.IdproveedoresComboBox.ValueMember = "idproveedores"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'NfacturaTextBox
        '
        Me.NfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "nfactura", True))
        Me.NfacturaTextBox.Location = New System.Drawing.Point(663, 16)
        Me.NfacturaTextBox.Name = "NfacturaTextBox"
        Me.NfacturaTextBox.Size = New System.Drawing.Size(127, 20)
        Me.NfacturaTextBox.TabIndex = 6
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(121, 63)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 8
        '
        'IdTipoFComboBox
        '
        Me.IdTipoFComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidosBindingSource, "idTipoF", True))
        Me.IdTipoFComboBox.DataSource = Me.TipoFacturaBindingSource
        Me.IdTipoFComboBox.DisplayMember = "tipo"
        Me.IdTipoFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdTipoFComboBox.Enabled = False
        Me.IdTipoFComboBox.FormattingEnabled = True
        Me.IdTipoFComboBox.Location = New System.Drawing.Point(403, 62)
        Me.IdTipoFComboBox.Name = "IdTipoFComboBox"
        Me.IdTipoFComboBox.Size = New System.Drawing.Size(155, 21)
        Me.IdTipoFComboBox.TabIndex = 10
        Me.IdTipoFComboBox.ValueMember = "idTipoF"
        '
        'TipoFacturaBindingSource
        '
        Me.TipoFacturaBindingSource.DataMember = "TipoFactura"
        Me.TipoFacturaBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'IdPagoComboBox
        '
        Me.IdPagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidosBindingSource, "idPago", True))
        Me.IdPagoComboBox.DataSource = Me.PagBindingSource
        Me.IdPagoComboBox.DisplayMember = "pago"
        Me.IdPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdPagoComboBox.Enabled = False
        Me.IdPagoComboBox.FormattingEnabled = True
        Me.IdPagoComboBox.Location = New System.Drawing.Point(645, 62)
        Me.IdPagoComboBox.Name = "IdPagoComboBox"
        Me.IdPagoComboBox.Size = New System.Drawing.Size(134, 21)
        Me.IdPagoComboBox.TabIndex = 12
        Me.IdPagoComboBox.ValueMember = "idPago"
        '
        'PagBindingSource
        '
        Me.PagBindingSource.DataMember = "pag"
        Me.PagBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'DventasProductoBindingSource
        '
        Me.DventasProductoBindingSource.DataMember = "FK_dpedidos_pedidos1"
        Me.DventasProductoBindingSource.DataSource = Me.PedidosBindingSource
        '
        'DventasProductoTableAdapter
        '
        Me.DventasProductoTableAdapter.ClearBeforeFill = True
        '
        'DventasProductoDataGridView
        '
        Me.DventasProductoDataGridView.AllowUserToAddRows = False
        Me.DventasProductoDataGridView.AllowUserToDeleteRows = False
        Me.DventasProductoDataGridView.AutoGenerateColumns = False
        Me.DventasProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DventasProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idpedidos, Me.idproducto, Me.codigo, Me.nombre, Me.cantidad, Me.precio, Me.marca, Me.medidas, Me.subtotal})
        Me.DventasProductoDataGridView.DataSource = Me.DventasProductoBindingSource
        Me.DventasProductoDataGridView.Location = New System.Drawing.Point(37, 111)
        Me.DventasProductoDataGridView.Name = "DventasProductoDataGridView"
        Me.DventasProductoDataGridView.ReadOnly = True
        Me.DventasProductoDataGridView.Size = New System.Drawing.Size(742, 220)
        Me.DventasProductoDataGridView.TabIndex = 12
        '
        'idpedidos
        '
        Me.idpedidos.DataPropertyName = "idpedidos"
        Me.idpedidos.HeaderText = "idpedidos"
        Me.idpedidos.Name = "idpedidos"
        Me.idpedidos.ReadOnly = True
        Me.idpedidos.Visible = False
        '
        'idproducto
        '
        Me.idproducto.DataPropertyName = "idproducto"
        Me.idproducto.HeaderText = "idproducto"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.ReadOnly = True
        Me.idproducto.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 250
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precio
        '
        Me.precio.DataPropertyName = "Precio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.precio.DefaultCellStyle = DataGridViewCellStyle2
        Me.precio.HeaderText = "PRECIO"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'subtotal
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'marca
        '
        Me.marca.DataPropertyName = "marca"
        Me.marca.HeaderText = "marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Visible = False
        '
        'medidas
        '
        Me.medidas.DataPropertyName = "medidas"
        Me.medidas.HeaderText = "medidas"
        Me.medidas.Name = "medidas"
        Me.medidas.ReadOnly = True
        Me.medidas.Visible = False
        '
        'PedidosBindingSource1
        '
        Me.PedidosBindingSource1.DataMember = "pedidos"
        Me.PedidosBindingSource1.DataSource = Me.Bd_empresaDataSet
        '
        'TipoFacturaBindingSource1
        '
        Me.TipoFacturaBindingSource1.DataMember = "TipoFactura"
        Me.TipoFacturaBindingSource1.DataSource = Me.Bd_empresaDataSet
        '
        'PagBindingSource1
        '
        Me.PagBindingSource1.DataMember = "pag"
        Me.PagBindingSource1.DataSource = Me.Bd_empresaDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblResTotal)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblResI)
        Me.Panel1.Controls.Add(Me.lblIva)
        Me.Panel1.Controls.Add(Me.lblResS)
        Me.Panel1.Controls.Add(Me.lblsuma)
        Me.Panel1.Location = New System.Drawing.Point(568, 461)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 91)
        Me.Panel1.TabIndex = 13
        '
        'lblResTotal
        '
        Me.lblResTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResTotal.Location = New System.Drawing.Point(83, 71)
        Me.lblResTotal.Name = "lblResTotal"
        Me.lblResTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblResTotal.Size = New System.Drawing.Size(100, 14)
        Me.lblResTotal.TabIndex = 5
        Me.lblResTotal.Text = "00.00"
        Me.lblResTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(15, 71)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(46, 14)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "TOTAL:"
        '
        'lblResI
        '
        Me.lblResI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResI.Location = New System.Drawing.Point(83, 44)
        Me.lblResI.Name = "lblResI"
        Me.lblResI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblResI.Size = New System.Drawing.Size(100, 14)
        Me.lblResI.TabIndex = 3
        Me.lblResI.Text = "00.00"
        Me.lblResI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.Location = New System.Drawing.Point(15, 44)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(28, 14)
        Me.lblIva.TabIndex = 2
        Me.lblIva.Text = "IVA:"
        '
        'lblResS
        '
        Me.lblResS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResS.Location = New System.Drawing.Point(83, 14)
        Me.lblResS.Name = "lblResS"
        Me.lblResS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblResS.Size = New System.Drawing.Size(100, 14)
        Me.lblResS.TabIndex = 1
        Me.lblResS.Text = "00.00"
        Me.lblResS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsuma
        '
        Me.lblsuma.AutoSize = True
        Me.lblsuma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuma.Location = New System.Drawing.Point(15, 14)
        Me.lblsuma.Name = "lblsuma"
        Me.lblsuma.Size = New System.Drawing.Size(42, 14)
        Me.lblsuma.TabIndex = 0
        Me.lblsuma.Text = "SUMA:"
        '
        'ProveedoresBindingSource1
        '
        Me.ProveedoresBindingSource1.DataMember = "proveedores"
        Me.ProveedoresBindingSource1.DataSource = Me.Bd_empresaDataSet
        '
        'grbNavegacionPedidos
        '
        Me.grbNavegacionPedidos.Controls.Add(Me.lblRegistroPedidos)
        Me.grbNavegacionPedidos.Controls.Add(Me.btnUltimoPedidos)
        Me.grbNavegacionPedidos.Controls.Add(Me.btnSiguientePedidos)
        Me.grbNavegacionPedidos.Controls.Add(Me.btnAnteriorPedidos)
        Me.grbNavegacionPedidos.Controls.Add(Me.btnPrimeroPedidos)
        Me.grbNavegacionPedidos.Location = New System.Drawing.Point(37, 363)
        Me.grbNavegacionPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionPedidos.Name = "grbNavegacionPedidos"
        Me.grbNavegacionPedidos.Padding = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionPedidos.Size = New System.Drawing.Size(324, 81)
        Me.grbNavegacionPedidos.TabIndex = 14
        Me.grbNavegacionPedidos.TabStop = False
        Me.grbNavegacionPedidos.Text = " Navegacion"
        '
        'lblRegistroPedidos
        '
        Me.lblRegistroPedidos.AutoSize = True
        Me.lblRegistroPedidos.Location = New System.Drawing.Point(134, 35)
        Me.lblRegistroPedidos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegistroPedidos.Name = "lblRegistroPedidos"
        Me.lblRegistroPedidos.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroPedidos.TabIndex = 4
        Me.lblRegistroPedidos.Text = "x de n"
        '
        'btnUltimoPedidos
        '
        Me.btnUltimoPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUltimoPedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoPedidos.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_next_48px_3669229
        Me.btnUltimoPedidos.Location = New System.Drawing.Point(247, 17)
        Me.btnUltimoPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUltimoPedidos.Name = "btnUltimoPedidos"
        Me.btnUltimoPedidos.Size = New System.Drawing.Size(56, 49)
        Me.btnUltimoPedidos.TabIndex = 3
        Me.btnUltimoPedidos.UseVisualStyleBackColor = False
        '
        'btnSiguientePedidos
        '
        Me.btnSiguientePedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSiguientePedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientePedidos.Image = Global.calculadora.My.Resources.Resources.iconfinder_next_right_arrow_botton_2203522
        Me.btnSiguientePedidos.Location = New System.Drawing.Point(187, 17)
        Me.btnSiguientePedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguientePedidos.Name = "btnSiguientePedidos"
        Me.btnSiguientePedidos.Size = New System.Drawing.Size(56, 49)
        Me.btnSiguientePedidos.TabIndex = 2
        Me.btnSiguientePedidos.UseVisualStyleBackColor = False
        '
        'btnAnteriorPedidos
        '
        Me.btnAnteriorPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnteriorPedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorPedidos.Image = Global.calculadora.My.Resources.Resources.iconfinder_left_fill_3017916
        Me.btnAnteriorPedidos.Location = New System.Drawing.Point(62, 17)
        Me.btnAnteriorPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnteriorPedidos.Name = "btnAnteriorPedidos"
        Me.btnAnteriorPedidos.Size = New System.Drawing.Size(56, 49)
        Me.btnAnteriorPedidos.TabIndex = 1
        Me.btnAnteriorPedidos.UseVisualStyleBackColor = False
        '
        'btnPrimeroPedidos
        '
        Me.btnPrimeroPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrimeroPedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroPedidos.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_previous_48px_3669228
        Me.btnPrimeroPedidos.Location = New System.Drawing.Point(4, 17)
        Me.btnPrimeroPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrimeroPedidos.Name = "btnPrimeroPedidos"
        Me.btnPrimeroPedidos.Size = New System.Drawing.Size(56, 49)
        Me.btnPrimeroPedidos.TabIndex = 0
        Me.btnPrimeroPedidos.UseVisualStyleBackColor = False
        '
        'grbEdicionPedidos
        '
        Me.grbEdicionPedidos.Controls.Add(Me.btnAgregarPedidos)
        Me.grbEdicionPedidos.Controls.Add(Me.btnImprimirPedido)
        Me.grbEdicionPedidos.Controls.Add(Me.btnBuscarPedidos)
        Me.grbEdicionPedidos.Controls.Add(Me.btnEliminarPedidos)
        Me.grbEdicionPedidos.Controls.Add(Me.btnModificarPedidos)
        Me.grbEdicionPedidos.Location = New System.Drawing.Point(37, 471)
        Me.grbEdicionPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.grbEdicionPedidos.Name = "grbEdicionPedidos"
        Me.grbEdicionPedidos.Padding = New System.Windows.Forms.Padding(2)
        Me.grbEdicionPedidos.Size = New System.Drawing.Size(486, 81)
        Me.grbEdicionPedidos.TabIndex = 18
        Me.grbEdicionPedidos.TabStop = False
        Me.grbEdicionPedidos.Text = "Edicion"
        '
        'btnAgregarPedidos
        '
        Me.btnAgregarPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarPedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPedidos.Location = New System.Drawing.Point(10, 23)
        Me.btnAgregarPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarPedidos.Name = "btnAgregarPedidos"
        Me.btnAgregarPedidos.Size = New System.Drawing.Size(88, 37)
        Me.btnAgregarPedidos.TabIndex = 1
        Me.btnAgregarPedidos.Text = "Nuevo"
        Me.btnAgregarPedidos.UseVisualStyleBackColor = False
        '
        'btnImprimirPedido
        '
        Me.btnImprimirPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImprimirPedido.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirPedido.Location = New System.Drawing.Point(384, 23)
        Me.btnImprimirPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImprimirPedido.Name = "btnImprimirPedido"
        Me.btnImprimirPedido.Size = New System.Drawing.Size(92, 37)
        Me.btnImprimirPedido.TabIndex = 5
        Me.btnImprimirPedido.Text = "Imprimir"
        Me.btnImprimirPedido.UseVisualStyleBackColor = False
        '
        'btnBuscarPedidos
        '
        Me.btnBuscarPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscarPedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPedidos.Location = New System.Drawing.Point(288, 23)
        Me.btnBuscarPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarPedidos.Name = "btnBuscarPedidos"
        Me.btnBuscarPedidos.Size = New System.Drawing.Size(92, 37)
        Me.btnBuscarPedidos.TabIndex = 4
        Me.btnBuscarPedidos.Text = "Buscar"
        Me.btnBuscarPedidos.UseVisualStyleBackColor = False
        '
        'btnEliminarPedidos
        '
        Me.btnEliminarPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminarPedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPedidos.Location = New System.Drawing.Point(196, 23)
        Me.btnEliminarPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarPedidos.Name = "btnEliminarPedidos"
        Me.btnEliminarPedidos.Size = New System.Drawing.Size(88, 37)
        Me.btnEliminarPedidos.TabIndex = 3
        Me.btnEliminarPedidos.Text = "Eliminar"
        Me.btnEliminarPedidos.UseVisualStyleBackColor = False
        '
        'btnModificarPedidos
        '
        Me.btnModificarPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarPedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPedidos.Location = New System.Drawing.Point(102, 23)
        Me.btnModificarPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarPedidos.Name = "btnModificarPedidos"
        Me.btnModificarPedidos.Size = New System.Drawing.Size(90, 37)
        Me.btnModificarPedidos.TabIndex = 2
        Me.btnModificarPedidos.Text = "Modificar"
        Me.btnModificarPedidos.UseVisualStyleBackColor = False
        '
        'DpedidosTableAdapter1
        '
        Me.DpedidosTableAdapter1.ClearBeforeFill = True
        '
        'lblIdPedido
        '
        Me.lblIdPedido.AutoSize = True
        Me.lblIdPedido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "idpedidos", True))
        Me.lblIdPedido.Location = New System.Drawing.Point(551, 20)
        Me.lblIdPedido.Name = "lblIdPedido"
        Me.lblIdPedido.Size = New System.Drawing.Size(39, 13)
        Me.lblIdPedido.TabIndex = 19
        Me.lblIdPedido.Text = "Label1"
        '
        'grbdPedidosProductos
        '
        Me.grbdPedidosProductos.Controls.Add(Me.btnQuitarProductoPedidos)
        Me.grbdPedidosProductos.Controls.Add(Me.btnAgregarProductoPedidos)
        Me.grbdPedidosProductos.Location = New System.Drawing.Point(431, 363)
        Me.grbdPedidosProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.grbdPedidosProductos.Name = "grbdPedidosProductos"
        Me.grbdPedidosProductos.Padding = New System.Windows.Forms.Padding(2)
        Me.grbdPedidosProductos.Size = New System.Drawing.Size(348, 81)
        Me.grbdPedidosProductos.TabIndex = 20
        Me.grbdPedidosProductos.TabStop = False
        Me.grbdPedidosProductos.Visible = False
        '
        'btnQuitarProductoPedidos
        '
        Me.btnQuitarProductoPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnQuitarProductoPedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarProductoPedidos.Image = Global.calculadora.My.Resources.Resources.iconfinder_ecommerce_30_4707191
        Me.btnQuitarProductoPedidos.Location = New System.Drawing.Point(207, 17)
        Me.btnQuitarProductoPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuitarProductoPedidos.Name = "btnQuitarProductoPedidos"
        Me.btnQuitarProductoPedidos.Size = New System.Drawing.Size(71, 48)
        Me.btnQuitarProductoPedidos.TabIndex = 3
        Me.btnQuitarProductoPedidos.UseVisualStyleBackColor = False
        '
        'btnAgregarProductoPedidos
        '
        Me.btnAgregarProductoPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarProductoPedidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProductoPedidos.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_add_shopping_cart_48px_3669464
        Me.btnAgregarProductoPedidos.Location = New System.Drawing.Point(70, 17)
        Me.btnAgregarProductoPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarProductoPedidos.Name = "btnAgregarProductoPedidos"
        Me.btnAgregarProductoPedidos.Size = New System.Drawing.Size(68, 48)
        Me.btnAgregarProductoPedidos.TabIndex = 2
        Me.btnAgregarProductoPedidos.UseVisualStyleBackColor = False
        '
        'btnNuevoProveedor
        '
        Me.btnNuevoProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNuevoProveedor.Location = New System.Drawing.Point(431, 12)
        Me.btnNuevoProveedor.Name = "btnNuevoProveedor"
        Me.btnNuevoProveedor.Size = New System.Drawing.Size(75, 43)
        Me.btnNuevoProveedor.TabIndex = 21
        Me.btnNuevoProveedor.Text = "Nuevo Proveedor"
        Me.btnNuevoProveedor.UseVisualStyleBackColor = False
        '
        'frmPeddos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(932, 569)
        Me.Controls.Add(Me.btnNuevoProveedor)
        Me.Controls.Add(Me.grbdPedidosProductos)
        Me.Controls.Add(Me.lblIdPedido)
        Me.Controls.Add(Me.grbEdicionPedidos)
        Me.Controls.Add(Me.grbNavegacionPedidos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DventasProductoDataGridView)
        Me.Controls.Add(IdproveedoresLabel)
        Me.Controls.Add(Me.IdproveedoresComboBox)
        Me.Controls.Add(NfacturaLabel)
        Me.Controls.Add(Me.NfacturaTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(IdTipoFLabel)
        Me.Controls.Add(Me.IdTipoFComboBox)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Me.IdPagoComboBox)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPeddos"
        Me.Text = "Facturacion de Pedidos"
        CType(Me.Bd_empresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DventasProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DventasProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoFacturaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNavegacionPedidos.ResumeLayout(False)
        Me.grbNavegacionPedidos.PerformLayout()
        Me.grbEdicionPedidos.ResumeLayout(False)
        Me.grbdPedidosProductos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bd_empresaDataSet As bd_empresaDataSet
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As bd_empresaDataSetTableAdapters.pedidosTableAdapter
    Friend WithEvents TableAdapterManager As bd_empresaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdproveedoresComboBox As ComboBox
    Friend WithEvents NfacturaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents IdTipoFComboBox As ComboBox
    Friend WithEvents IdPagoComboBox As ComboBox
    Friend WithEvents DventasProductoBindingSource As BindingSource
    Friend WithEvents DventasProductoTableAdapter As bd_empresaDataSetTableAdapters.DventasProductoTableAdapter
    Friend WithEvents ProveedoresTableAdapter As bd_empresaDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents PedidosBindingSource1 As BindingSource
    Friend WithEvents DventasProductoDataGridView As DataGridView
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents TipoFacturaTableAdapter As bd_empresaDataSetTableAdapters.TipoFacturaTableAdapter
    Friend WithEvents TipoFacturaBindingSource As BindingSource
    Friend WithEvents TipoFacturaBindingSource1 As BindingSource
    Friend WithEvents PagTableAdapter As bd_empresaDataSetTableAdapters.pagTableAdapter
    Friend WithEvents PagBindingSource As BindingSource
    Friend WithEvents PagBindingSource1 As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblResTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblResI As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblResS As Label
    Friend WithEvents lblsuma As Label
    Friend WithEvents ProveedoresBindingSource1 As BindingSource
    Friend WithEvents grbNavegacionPedidos As GroupBox
    Friend WithEvents lblRegistroPedidos As Label
    Friend WithEvents btnUltimoPedidos As Button
    Friend WithEvents btnSiguientePedidos As Button
    Friend WithEvents btnAnteriorPedidos As Button
    Friend WithEvents btnPrimeroPedidos As Button
    Friend WithEvents grbEdicionPedidos As GroupBox
    Friend WithEvents btnBuscarPedidos As Button
    Friend WithEvents btnEliminarPedidos As Button
    Friend WithEvents btnModificarPedidos As Button
    Friend WithEvents DpedidosTableAdapter1 As bd_empresaDataSetTableAdapters.dpedidosTableAdapter
    Friend WithEvents lblIdPedido As Label
    Friend WithEvents grbdPedidosProductos As GroupBox
    Friend WithEvents btnQuitarProductoPedidos As Button
    Friend WithEvents btnAgregarProductoPedidos As Button
    Friend WithEvents btnImprimirPedido As Button
    Friend WithEvents btnAgregarPedidos As Button
    Friend WithEvents idpedidos As DataGridViewTextBoxColumn
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents medidas As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevoProveedor As Button
End Class
