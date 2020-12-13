<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompras
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
        Me.components = New System.ComponentModel.Container()
        Dim NfacturaLabel As System.Windows.Forms.Label
        Dim Fecha_compraLabel As System.Windows.Forms.Label
        Dim IdTipoFLabel As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd_empresaDataSet = New calculadora.bd_empresaDataSet()
        Me.NfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_compraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTipoFComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.PagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdclienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.comprasTableAdapter()
        Me.TableAdapterManager = New calculadora.bd_empresaDataSetTableAdapters.TableAdapterManager()
        Me.DcomprasTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.dcomprasTableAdapter()
        Me.DcomprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DventasProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DventasProductoTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.DventasProductoTableAdapter()
        Me.DcomprasProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DcomprasProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DcomprasProductosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DcomprasProductosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DcomprasProductosBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DcomprasProductosTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.DcomprasProductosTableAdapter()
        Me.grbNavegacionCompras = New System.Windows.Forms.GroupBox()
        Me.lblRegistroCompras = New System.Windows.Forms.Label()
        Me.btnUltimoCompras = New System.Windows.Forms.Button()
        Me.btnSiguienteCompras = New System.Windows.Forms.Button()
        Me.btnAnteriorCompras = New System.Windows.Forms.Button()
        Me.btnPrimeroCompras = New System.Windows.Forms.Button()
        Me.ClienteTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.clienteTableAdapter()
        Me.ClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoFacturaTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.TipoFacturaTableAdapter()
        Me.PagTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.pagTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblResTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblResI = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblResS = New System.Windows.Forms.Label()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.grbEdicionCompras = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCompras = New System.Windows.Forms.Button()
        Me.btnEliminarCompras = New System.Windows.Forms.Button()
        Me.btnModificarCompras = New System.Windows.Forms.Button()
        Me.btnAgregarCompras = New System.Windows.Forms.Button()
        Me.grbdComprasProductos = New System.Windows.Forms.GroupBox()
        Me.btnQuitarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.lblIdCompras = New System.Windows.Forms.Label()
        Me.DcomprasProductosBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DcomprasProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NfacturaLabel = New System.Windows.Forms.Label()
        Fecha_compraLabel = New System.Windows.Forms.Label()
        IdTipoFLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        IdclienteLabel = New System.Windows.Forms.Label()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd_empresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DventasProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasProductosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasProductosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasProductosBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNavegacionCompras.SuspendLayout()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grbEdicionCompras.SuspendLayout()
        Me.grbdComprasProductos.SuspendLayout()
        CType(Me.DcomprasProductosBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(581, 21)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(66, 13)
        NfacturaLabel.TabIndex = 3
        NfacturaLabel.Text = "Factura No.:"
        '
        'Fecha_compraLabel
        '
        Fecha_compraLabel.AutoSize = True
        Fecha_compraLabel.Location = New System.Drawing.Point(26, 63)
        Fecha_compraLabel.Name = "Fecha_compraLabel"
        Fecha_compraLabel.Size = New System.Drawing.Size(75, 13)
        Fecha_compraLabel.TabIndex = 5
        Fecha_compraLabel.Text = "fecha compra:"
        '
        'IdTipoFLabel
        '
        IdTipoFLabel.AutoSize = True
        IdTipoFLabel.Location = New System.Drawing.Point(338, 67)
        IdTipoFLabel.Name = "IdTipoFLabel"
        IdTipoFLabel.Size = New System.Drawing.Size(70, 13)
        IdTipoFLabel.TabIndex = 9
        IdTipoFLabel.Text = "Tipo Factura:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(581, 67)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(66, 13)
        IdPagoLabel.TabIndex = 11
        IdPagoLabel.Text = "Forma pago:"
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(26, 21)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(42, 13)
        IdclienteLabel.TabIndex = 13
        IdclienteLabel.Text = "Cliente:"
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "compras"
        Me.ComprasBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'Bd_empresaDataSet
        '
        Me.Bd_empresaDataSet.DataSetName = "bd_empresaDataSet"
        Me.Bd_empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NfacturaTextBox
        '
        Me.NfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "nfactura", True))
        Me.NfacturaTextBox.Location = New System.Drawing.Point(653, 18)
        Me.NfacturaTextBox.Name = "NfacturaTextBox"
        Me.NfacturaTextBox.Size = New System.Drawing.Size(125, 20)
        Me.NfacturaTextBox.TabIndex = 4
        '
        'Fecha_compraDateTimePicker
        '
        Me.Fecha_compraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComprasBindingSource, "fecha_compra", True))
        Me.Fecha_compraDateTimePicker.Enabled = False
        Me.Fecha_compraDateTimePicker.Location = New System.Drawing.Point(107, 63)
        Me.Fecha_compraDateTimePicker.Name = "Fecha_compraDateTimePicker"
        Me.Fecha_compraDateTimePicker.Size = New System.Drawing.Size(214, 20)
        Me.Fecha_compraDateTimePicker.TabIndex = 6
        '
        'IdTipoFComboBox
        '
        Me.IdTipoFComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "idTipoF", True))
        Me.IdTipoFComboBox.DataSource = Me.TipoFacturaBindingSource
        Me.IdTipoFComboBox.DisplayMember = "tipo"
        Me.IdTipoFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdTipoFComboBox.Enabled = False
        Me.IdTipoFComboBox.FormattingEnabled = True
        Me.IdTipoFComboBox.Location = New System.Drawing.Point(414, 63)
        Me.IdTipoFComboBox.Name = "IdTipoFComboBox"
        Me.IdTipoFComboBox.Size = New System.Drawing.Size(126, 21)
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
        Me.IdPagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "idPago", True))
        Me.IdPagoComboBox.DataSource = Me.PagBindingSource
        Me.IdPagoComboBox.DisplayMember = "pago"
        Me.IdPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdPagoComboBox.Enabled = False
        Me.IdPagoComboBox.FormattingEnabled = True
        Me.IdPagoComboBox.Location = New System.Drawing.Point(653, 63)
        Me.IdPagoComboBox.Name = "IdPagoComboBox"
        Me.IdPagoComboBox.Size = New System.Drawing.Size(126, 21)
        Me.IdPagoComboBox.TabIndex = 12
        Me.IdPagoComboBox.ValueMember = "idPago"
        '
        'PagBindingSource
        '
        Me.PagBindingSource.DataMember = "pag"
        Me.PagBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'IdclienteComboBox
        '
        Me.IdclienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "idcliente", True))
        Me.IdclienteComboBox.DataSource = Me.ClienteBindingSource
        Me.IdclienteComboBox.DisplayMember = "nombre"
        Me.IdclienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdclienteComboBox.Enabled = False
        Me.IdclienteComboBox.FormattingEnabled = True
        Me.IdclienteComboBox.Location = New System.Drawing.Point(74, 18)
        Me.IdclienteComboBox.Name = "IdclienteComboBox"
        Me.IdclienteComboBox.Size = New System.Drawing.Size(269, 21)
        Me.IdclienteComboBox.TabIndex = 14
        Me.IdclienteComboBox.ValueMember = "idcliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Me.ComprasTableAdapter
        Me.TableAdapterManager.dcomprasTableAdapter = Me.DcomprasTableAdapter
        Me.TableAdapterManager.dpedidosTableAdapter = Nothing
        Me.TableAdapterManager.dventasTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.pagTableAdapter = Nothing
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.puestoTableAdapter = Nothing
        Me.TableAdapterManager.TipoFacturaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = calculadora.bd_empresaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'DcomprasTableAdapter
        '
        Me.DcomprasTableAdapter.ClearBeforeFill = True
        '
        'DcomprasBindingSource
        '
        Me.DcomprasBindingSource.DataMember = "dcompras"
        Me.DcomprasBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'DventasProductoBindingSource
        '
        Me.DventasProductoBindingSource.DataMember = "DventasProducto"
        Me.DventasProductoBindingSource.DataSource = Me.Bd_empresaDataSet
        '
        'DventasProductoTableAdapter
        '
        Me.DventasProductoTableAdapter.ClearBeforeFill = True
        '
        'DcomprasProductosBindingSource
        '
        Me.DcomprasProductosBindingSource.DataSource = Me.Bd_empresaDataSet
        Me.DcomprasProductosBindingSource.Position = 0
        '
        'DcomprasProductosBindingSource1
        '
        Me.DcomprasProductosBindingSource1.DataSource = Me.Bd_empresaDataSet
        Me.DcomprasProductosBindingSource1.Position = 0
        '
        'DcomprasProductosBindingSource2
        '
        Me.DcomprasProductosBindingSource2.DataSource = Me.Bd_empresaDataSet
        Me.DcomprasProductosBindingSource2.Position = 0
        '
        'DcomprasProductosBindingSource3
        '
        Me.DcomprasProductosBindingSource3.DataSource = Me.Bd_empresaDataSet
        Me.DcomprasProductosBindingSource3.Position = 0
        '
        'DcomprasProductosBindingSource4
        '
        Me.DcomprasProductosBindingSource4.DataMember = "DcomprasProductos"
        Me.DcomprasProductosBindingSource4.DataSource = Me.Bd_empresaDataSet
        '
        'DcomprasProductosTableAdapter
        '
        Me.DcomprasProductosTableAdapter.ClearBeforeFill = True
        '
        'grbNavegacionCompras
        '
        Me.grbNavegacionCompras.Controls.Add(Me.lblRegistroCompras)
        Me.grbNavegacionCompras.Controls.Add(Me.btnUltimoCompras)
        Me.grbNavegacionCompras.Controls.Add(Me.btnSiguienteCompras)
        Me.grbNavegacionCompras.Controls.Add(Me.btnAnteriorCompras)
        Me.grbNavegacionCompras.Controls.Add(Me.btnPrimeroCompras)
        Me.grbNavegacionCompras.Location = New System.Drawing.Point(29, 342)
        Me.grbNavegacionCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionCompras.Name = "grbNavegacionCompras"
        Me.grbNavegacionCompras.Padding = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionCompras.Size = New System.Drawing.Size(314, 81)
        Me.grbNavegacionCompras.TabIndex = 15
        Me.grbNavegacionCompras.TabStop = False
        Me.grbNavegacionCompras.Text = " Navegacion"
        '
        'lblRegistroCompras
        '
        Me.lblRegistroCompras.AutoSize = True
        Me.lblRegistroCompras.Location = New System.Drawing.Point(135, 39)
        Me.lblRegistroCompras.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegistroCompras.Name = "lblRegistroCompras"
        Me.lblRegistroCompras.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroCompras.TabIndex = 4
        Me.lblRegistroCompras.Text = "x de n"
        '
        'btnUltimoCompras
        '
        Me.btnUltimoCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUltimoCompras.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCompras.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_next_48px_3669229
        Me.btnUltimoCompras.Location = New System.Drawing.Point(246, 19)
        Me.btnUltimoCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUltimoCompras.Name = "btnUltimoCompras"
        Me.btnUltimoCompras.Size = New System.Drawing.Size(56, 52)
        Me.btnUltimoCompras.TabIndex = 3
        Me.btnUltimoCompras.UseVisualStyleBackColor = False
        '
        'btnSiguienteCompras
        '
        Me.btnSiguienteCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSiguienteCompras.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCompras.Image = Global.calculadora.My.Resources.Resources.iconfinder_next_right_arrow_botton_2203522
        Me.btnSiguienteCompras.Location = New System.Drawing.Point(186, 19)
        Me.btnSiguienteCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguienteCompras.Name = "btnSiguienteCompras"
        Me.btnSiguienteCompras.Size = New System.Drawing.Size(56, 52)
        Me.btnSiguienteCompras.TabIndex = 2
        Me.btnSiguienteCompras.UseVisualStyleBackColor = False
        '
        'btnAnteriorCompras
        '
        Me.btnAnteriorCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnteriorCompras.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCompras.Image = Global.calculadora.My.Resources.Resources.iconfinder_left_fill_3017916
        Me.btnAnteriorCompras.Location = New System.Drawing.Point(65, 19)
        Me.btnAnteriorCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnteriorCompras.Name = "btnAnteriorCompras"
        Me.btnAnteriorCompras.Size = New System.Drawing.Size(56, 52)
        Me.btnAnteriorCompras.TabIndex = 1
        Me.btnAnteriorCompras.UseVisualStyleBackColor = False
        '
        'btnPrimeroCompras
        '
        Me.btnPrimeroCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrimeroCompras.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCompras.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_previous_48px_3669228
        Me.btnPrimeroCompras.Location = New System.Drawing.Point(5, 19)
        Me.btnPrimeroCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrimeroCompras.Name = "btnPrimeroCompras"
        Me.btnPrimeroCompras.Size = New System.Drawing.Size(56, 52)
        Me.btnPrimeroCompras.TabIndex = 0
        Me.btnPrimeroCompras.UseVisualStyleBackColor = False
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ClienteBindingSource1
        '
        Me.ClienteBindingSource1.DataMember = "cliente"
        Me.ClienteBindingSource1.DataSource = Me.Bd_empresaDataSet
        '
        'TipoFacturaTableAdapter
        '
        Me.TipoFacturaTableAdapter.ClearBeforeFill = True
        '
        'PagTableAdapter
        '
        Me.PagTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblResTotal)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblResI)
        Me.Panel1.Controls.Add(Me.lblIva)
        Me.Panel1.Controls.Add(Me.lblResS)
        Me.Panel1.Controls.Add(Me.lblsuma)
        Me.Panel1.Location = New System.Drawing.Point(478, 447)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 100)
        Me.Panel1.TabIndex = 16
        '
        'lblResTotal
        '
        Me.lblResTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResTotal.Location = New System.Drawing.Point(149, 71)
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
        Me.lblResI.Location = New System.Drawing.Point(149, 44)
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
        Me.lblResS.Location = New System.Drawing.Point(149, 14)
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
        'grbEdicionCompras
        '
        Me.grbEdicionCompras.Controls.Add(Me.btnBuscarCompras)
        Me.grbEdicionCompras.Controls.Add(Me.btnEliminarCompras)
        Me.grbEdicionCompras.Controls.Add(Me.btnModificarCompras)
        Me.grbEdicionCompras.Controls.Add(Me.btnAgregarCompras)
        Me.grbEdicionCompras.Location = New System.Drawing.Point(29, 466)
        Me.grbEdicionCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.grbEdicionCompras.Name = "grbEdicionCompras"
        Me.grbEdicionCompras.Padding = New System.Windows.Forms.Padding(2)
        Me.grbEdicionCompras.Size = New System.Drawing.Size(379, 81)
        Me.grbEdicionCompras.TabIndex = 17
        Me.grbEdicionCompras.TabStop = False
        Me.grbEdicionCompras.Text = "Edicion"
        '
        'btnBuscarCompras
        '
        Me.btnBuscarCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscarCompras.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCompras.Location = New System.Drawing.Point(273, 23)
        Me.btnBuscarCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCompras.Name = "btnBuscarCompras"
        Me.btnBuscarCompras.Size = New System.Drawing.Size(92, 34)
        Me.btnBuscarCompras.TabIndex = 4
        Me.btnBuscarCompras.Text = "Buscar"
        Me.btnBuscarCompras.UseVisualStyleBackColor = False
        '
        'btnEliminarCompras
        '
        Me.btnEliminarCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminarCompras.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCompras.Location = New System.Drawing.Point(181, 23)
        Me.btnEliminarCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarCompras.Name = "btnEliminarCompras"
        Me.btnEliminarCompras.Size = New System.Drawing.Size(88, 34)
        Me.btnEliminarCompras.TabIndex = 3
        Me.btnEliminarCompras.Text = "Eliminar"
        Me.btnEliminarCompras.UseVisualStyleBackColor = False
        '
        'btnModificarCompras
        '
        Me.btnModificarCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarCompras.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCompras.Location = New System.Drawing.Point(87, 23)
        Me.btnModificarCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarCompras.Name = "btnModificarCompras"
        Me.btnModificarCompras.Size = New System.Drawing.Size(90, 34)
        Me.btnModificarCompras.TabIndex = 2
        Me.btnModificarCompras.Text = "Modificar"
        Me.btnModificarCompras.UseVisualStyleBackColor = False
        '
        'btnAgregarCompras
        '
        Me.btnAgregarCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarCompras.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCompras.Location = New System.Drawing.Point(5, 23)
        Me.btnAgregarCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarCompras.Name = "btnAgregarCompras"
        Me.btnAgregarCompras.Size = New System.Drawing.Size(78, 34)
        Me.btnAgregarCompras.TabIndex = 1
        Me.btnAgregarCompras.Text = "Nuevo"
        Me.btnAgregarCompras.UseVisualStyleBackColor = False
        '
        'grbdComprasProductos
        '
        Me.grbdComprasProductos.Controls.Add(Me.btnQuitarProducto)
        Me.grbdComprasProductos.Controls.Add(Me.btnAgregarProducto)
        Me.grbdComprasProductos.Location = New System.Drawing.Point(437, 342)
        Me.grbdComprasProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.grbdComprasProductos.Name = "grbdComprasProductos"
        Me.grbdComprasProductos.Padding = New System.Windows.Forms.Padding(2)
        Me.grbdComprasProductos.Size = New System.Drawing.Size(306, 81)
        Me.grbdComprasProductos.TabIndex = 18
        Me.grbdComprasProductos.TabStop = False
        Me.grbdComprasProductos.Visible = False
        '
        'btnQuitarProducto
        '
        Me.btnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnQuitarProducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarProducto.Image = Global.calculadora.My.Resources.Resources.iconfinder_ecommerce_30_4707191
        Me.btnQuitarProducto.Location = New System.Drawing.Point(206, 19)
        Me.btnQuitarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(68, 52)
        Me.btnQuitarProducto.TabIndex = 3
        Me.btnQuitarProducto.UseVisualStyleBackColor = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_add_shopping_cart_48px_3669464
        Me.btnAgregarProducto.Location = New System.Drawing.Point(74, 19)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(70, 52)
        Me.btnAgregarProducto.TabIndex = 2
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(348, 13)
        Me.btnAgregarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(141, 29)
        Me.btnAgregarCliente.TabIndex = 19
        Me.btnAgregarCliente.Text = "Nuevo Cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = False
        Me.btnAgregarCliente.Visible = False
        '
        'lblIdCompras
        '
        Me.lblIdCompras.AutoSize = True
        Me.lblIdCompras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "idcompra", True))
        Me.lblIdCompras.Location = New System.Drawing.Point(501, 21)
        Me.lblIdCompras.Name = "lblIdCompras"
        Me.lblIdCompras.Size = New System.Drawing.Size(39, 13)
        Me.lblIdCompras.TabIndex = 20
        Me.lblIdCompras.Text = "Label1"
        '
        'DcomprasProductosBindingSource5
        '
        Me.DcomprasProductosBindingSource5.DataMember = "FK_dcompras_compras1"
        Me.DcomprasProductosBindingSource5.DataSource = Me.ComprasBindingSource
        '
        'DcomprasProductosDataGridView
        '
        Me.DcomprasProductosDataGridView.AllowUserToAddRows = False
        Me.DcomprasProductosDataGridView.AllowUserToDeleteRows = False
        Me.DcomprasProductosDataGridView.AutoGenerateColumns = False
        Me.DcomprasProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DcomprasProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.idcompra, Me.idproducto, Me.codigo, Me.nombre, Me.cantidad, Me.precio, Me.subtotal, Me.marca, Me.medidas})
        Me.DcomprasProductosDataGridView.DataSource = Me.DcomprasProductosBindingSource5
        Me.DcomprasProductosDataGridView.Location = New System.Drawing.Point(50, 99)
        Me.DcomprasProductosDataGridView.Name = "DcomprasProductosDataGridView"
        Me.DcomprasProductosDataGridView.ReadOnly = True
        Me.DcomprasProductosDataGridView.Size = New System.Drawing.Size(693, 220)
        Me.DcomprasProductosDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idDetalle"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idDetalle"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'idcompra
        '
        Me.idcompra.DataPropertyName = "idcompra"
        Me.idcompra.HeaderText = "idcompra"
        Me.idcompra.Name = "idcompra"
        Me.idcompra.ReadOnly = True
        Me.idcompra.Visible = False
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
        Me.nombre.Width = 200
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad "
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        Me.precio.HeaderText = "PRECIO"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'subtotal
        '
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
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(799, 573)
        Me.Controls.Add(Me.DcomprasProductosDataGridView)
        Me.Controls.Add(Me.lblIdCompras)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.grbdComprasProductos)
        Me.Controls.Add(Me.grbEdicionCompras)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grbNavegacionCompras)
        Me.Controls.Add(NfacturaLabel)
        Me.Controls.Add(Me.NfacturaTextBox)
        Me.Controls.Add(Fecha_compraLabel)
        Me.Controls.Add(Me.Fecha_compraDateTimePicker)
        Me.Controls.Add(IdTipoFLabel)
        Me.Controls.Add(Me.IdTipoFComboBox)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Me.IdPagoComboBox)
        Me.Controls.Add(IdclienteLabel)
        Me.Controls.Add(Me.IdclienteComboBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompras"
        Me.Text = "Facturacion de compras"
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd_empresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DventasProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasProductosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasProductosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasProductosBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNavegacionCompras.ResumeLayout(False)
        Me.grbNavegacionCompras.PerformLayout()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grbEdicionCompras.ResumeLayout(False)
        Me.grbdComprasProductos.ResumeLayout(False)
        CType(Me.DcomprasProductosBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bd_empresaDataSet As bd_empresaDataSet
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasTableAdapter As bd_empresaDataSetTableAdapters.comprasTableAdapter
    Friend WithEvents TableAdapterManager As bd_empresaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DcomprasTableAdapter As bd_empresaDataSetTableAdapters.dcomprasTableAdapter
    Friend WithEvents NfacturaTextBox As TextBox
    Friend WithEvents Fecha_compraDateTimePicker As DateTimePicker
    Friend WithEvents IdTipoFComboBox As ComboBox
    Friend WithEvents IdPagoComboBox As ComboBox
    Friend WithEvents IdclienteComboBox As ComboBox
    Friend WithEvents DcomprasBindingSource As BindingSource
    Friend WithEvents DventasProductoBindingSource As BindingSource
    Friend WithEvents DventasProductoTableAdapter As bd_empresaDataSetTableAdapters.DventasProductoTableAdapter
    Friend WithEvents DcomprasProductosBindingSource As BindingSource
    Friend WithEvents DcomprasProductosBindingSource1 As BindingSource
    Friend WithEvents DcomprasProductosBindingSource2 As BindingSource
    Friend WithEvents DcomprasProductosBindingSource3 As BindingSource
    Friend WithEvents DcomprasProductosBindingSource4 As BindingSource
    Friend WithEvents DcomprasProductosTableAdapter As bd_empresaDataSetTableAdapters.DcomprasProductosTableAdapter
    Friend WithEvents grbNavegacionCompras As GroupBox
    Friend WithEvents lblRegistroCompras As Label
    Friend WithEvents btnUltimoCompras As Button
    Friend WithEvents btnSiguienteCompras As Button
    Friend WithEvents btnAnteriorCompras As Button
    Friend WithEvents btnPrimeroCompras As Button
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As bd_empresaDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents ClienteBindingSource1 As BindingSource
    Friend WithEvents TipoFacturaBindingSource As BindingSource
    Friend WithEvents TipoFacturaTableAdapter As bd_empresaDataSetTableAdapters.TipoFacturaTableAdapter
    Friend WithEvents PagBindingSource As BindingSource
    Friend WithEvents PagTableAdapter As bd_empresaDataSetTableAdapters.pagTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblResTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblResI As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblResS As Label
    Friend WithEvents lblsuma As Label
    Friend WithEvents grbEdicionCompras As GroupBox
    Friend WithEvents btnBuscarCompras As Button
    Friend WithEvents btnEliminarCompras As Button
    Friend WithEvents btnModificarCompras As Button
    Friend WithEvents btnAgregarCompras As Button
    Friend WithEvents grbdComprasProductos As GroupBox
    Friend WithEvents btnQuitarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents lblIdCompras As Label
    Friend WithEvents DcomprasProductosBindingSource5 As BindingSource
    Friend WithEvents DcomprasProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents idcompra As DataGridViewTextBoxColumn
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents medidas As DataGridViewTextBoxColumn
End Class
