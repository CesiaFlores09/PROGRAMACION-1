<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmproductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmproductos))
        Me.grbEdicionProducto = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPoducto = New System.Windows.Forms.Button()
        Me.btnEliminarPoducto = New System.Windows.Forms.Button()
        Me.btnModificarPoducto = New System.Windows.Forms.Button()
        Me.btnAgregarPoducto = New System.Windows.Forms.Button()
        Me.grbNavegacionProducto = New System.Windows.Forms.GroupBox()
        Me.lblRegistroProductos = New System.Windows.Forms.Label()
        Me.btnUltimoPoducto = New System.Windows.Forms.Button()
        Me.btnSiguientePoducto = New System.Windows.Forms.Button()
        Me.btnAnteriorPoducto = New System.Windows.Forms.Button()
        Me.btnPrimeroPoducto = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.lblCategoriaProducto = New System.Windows.Forms.Label()
        Me.txtMedidasProducto = New System.Windows.Forms.TextBox()
        Me.txtMarcaProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblMediasProducto = New System.Windows.Forms.Label()
        Me.lblMarcaProducto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.lblCodigoProducto = New System.Windows.Forms.Label()
        Me.grbEdicionProducto.SuspendLayout()
        Me.grbNavegacionProducto.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicionProducto
        '
        Me.grbEdicionProducto.Controls.Add(Me.btnBuscarPoducto)
        Me.grbEdicionProducto.Controls.Add(Me.btnEliminarPoducto)
        Me.grbEdicionProducto.Controls.Add(Me.btnModificarPoducto)
        Me.grbEdicionProducto.Controls.Add(Me.btnAgregarPoducto)
        Me.grbEdicionProducto.Location = New System.Drawing.Point(370, 455)
        Me.grbEdicionProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.grbEdicionProducto.Name = "grbEdicionProducto"
        Me.grbEdicionProducto.Padding = New System.Windows.Forms.Padding(2)
        Me.grbEdicionProducto.Size = New System.Drawing.Size(407, 81)
        Me.grbEdicionProducto.TabIndex = 8
        Me.grbEdicionProducto.TabStop = False
        Me.grbEdicionProducto.Text = "Edicion"
        '
        'btnBuscarPoducto
        '
        Me.btnBuscarPoducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscarPoducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPoducto.Location = New System.Drawing.Point(320, 17)
        Me.btnBuscarPoducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarPoducto.Name = "btnBuscarPoducto"
        Me.btnBuscarPoducto.Size = New System.Drawing.Size(83, 49)
        Me.btnBuscarPoducto.TabIndex = 4
        Me.btnBuscarPoducto.Text = "Buscar"
        Me.btnBuscarPoducto.UseVisualStyleBackColor = False
        '
        'btnEliminarPoducto
        '
        Me.btnEliminarPoducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEliminarPoducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPoducto.Location = New System.Drawing.Point(223, 18)
        Me.btnEliminarPoducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarPoducto.Name = "btnEliminarPoducto"
        Me.btnEliminarPoducto.Size = New System.Drawing.Size(93, 48)
        Me.btnEliminarPoducto.TabIndex = 3
        Me.btnEliminarPoducto.Text = "Eliminar"
        Me.btnEliminarPoducto.UseVisualStyleBackColor = False
        '
        'btnModificarPoducto
        '
        Me.btnModificarPoducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificarPoducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPoducto.Location = New System.Drawing.Point(110, 17)
        Me.btnModificarPoducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarPoducto.Name = "btnModificarPoducto"
        Me.btnModificarPoducto.Size = New System.Drawing.Size(109, 48)
        Me.btnModificarPoducto.TabIndex = 2
        Me.btnModificarPoducto.Text = "Modificar"
        Me.btnModificarPoducto.UseVisualStyleBackColor = False
        '
        'btnAgregarPoducto
        '
        Me.btnAgregarPoducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarPoducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPoducto.Location = New System.Drawing.Point(11, 17)
        Me.btnAgregarPoducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarPoducto.Name = "btnAgregarPoducto"
        Me.btnAgregarPoducto.Size = New System.Drawing.Size(95, 48)
        Me.btnAgregarPoducto.TabIndex = 1
        Me.btnAgregarPoducto.Text = "Nuevo"
        Me.btnAgregarPoducto.UseVisualStyleBackColor = False
        '
        'grbNavegacionProducto
        '
        Me.grbNavegacionProducto.Controls.Add(Me.lblRegistroProductos)
        Me.grbNavegacionProducto.Controls.Add(Me.btnUltimoPoducto)
        Me.grbNavegacionProducto.Controls.Add(Me.btnSiguientePoducto)
        Me.grbNavegacionProducto.Controls.Add(Me.btnAnteriorPoducto)
        Me.grbNavegacionProducto.Controls.Add(Me.btnPrimeroPoducto)
        Me.grbNavegacionProducto.Location = New System.Drawing.Point(24, 455)
        Me.grbNavegacionProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionProducto.Name = "grbNavegacionProducto"
        Me.grbNavegacionProducto.Padding = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionProducto.Size = New System.Drawing.Size(342, 81)
        Me.grbNavegacionProducto.TabIndex = 7
        Me.grbNavegacionProducto.TabStop = False
        Me.grbNavegacionProducto.Text = " Navegacion"
        '
        'lblRegistroProductos
        '
        Me.lblRegistroProductos.AutoSize = True
        Me.lblRegistroProductos.Location = New System.Drawing.Point(134, 51)
        Me.lblRegistroProductos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegistroProductos.Name = "lblRegistroProductos"
        Me.lblRegistroProductos.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroProductos.TabIndex = 4
        Me.lblRegistroProductos.Text = "x de n"
        '
        'btnUltimoPoducto
        '
        Me.btnUltimoPoducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUltimoPoducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoPoducto.Location = New System.Drawing.Point(281, 17)
        Me.btnUltimoPoducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUltimoPoducto.Name = "btnUltimoPoducto"
        Me.btnUltimoPoducto.Size = New System.Drawing.Size(56, 49)
        Me.btnUltimoPoducto.TabIndex = 3
        Me.btnUltimoPoducto.Text = ">|"
        Me.btnUltimoPoducto.UseVisualStyleBackColor = False
        '
        'btnSiguientePoducto
        '
        Me.btnSiguientePoducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSiguientePoducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientePoducto.Location = New System.Drawing.Point(220, 17)
        Me.btnSiguientePoducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguientePoducto.Name = "btnSiguientePoducto"
        Me.btnSiguientePoducto.Size = New System.Drawing.Size(56, 49)
        Me.btnSiguientePoducto.TabIndex = 2
        Me.btnSiguientePoducto.Text = ">"
        Me.btnSiguientePoducto.UseVisualStyleBackColor = False
        '
        'btnAnteriorPoducto
        '
        Me.btnAnteriorPoducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnteriorPoducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorPoducto.Location = New System.Drawing.Point(65, 17)
        Me.btnAnteriorPoducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnteriorPoducto.Name = "btnAnteriorPoducto"
        Me.btnAnteriorPoducto.Size = New System.Drawing.Size(56, 49)
        Me.btnAnteriorPoducto.TabIndex = 1
        Me.btnAnteriorPoducto.Text = "<"
        Me.btnAnteriorPoducto.UseVisualStyleBackColor = False
        '
        'btnPrimeroPoducto
        '
        Me.btnPrimeroPoducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrimeroPoducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroPoducto.Location = New System.Drawing.Point(4, 17)
        Me.btnPrimeroPoducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrimeroPoducto.Name = "btnPrimeroPoducto"
        Me.btnPrimeroPoducto.Size = New System.Drawing.Size(56, 49)
        Me.btnPrimeroPoducto.TabIndex = 0
        Me.btnPrimeroPoducto.Text = "|<"
        Me.btnPrimeroPoducto.UseVisualStyleBackColor = False
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.cboCategoria)
        Me.grbDatos.Controls.Add(Me.lblCategoriaProducto)
        Me.grbDatos.Controls.Add(Me.txtMedidasProducto)
        Me.grbDatos.Controls.Add(Me.txtMarcaProducto)
        Me.grbDatos.Controls.Add(Me.txtNombreProducto)
        Me.grbDatos.Controls.Add(Me.txtCodigoProducto)
        Me.grbDatos.Controls.Add(Me.lblMediasProducto)
        Me.grbDatos.Controls.Add(Me.lblMarcaProducto)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Controls.Add(Me.lblNombreProducto)
        Me.grbDatos.Controls.Add(Me.lblCodigoProducto)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(24, 9)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(2)
        Me.grbDatos.Size = New System.Drawing.Size(749, 395)
        Me.grbDatos.TabIndex = 6
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Productos"
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(160, 41)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(277, 21)
        Me.cboCategoria.TabIndex = 13
        '
        'lblCategoriaProducto
        '
        Me.lblCategoriaProducto.AutoSize = True
        Me.lblCategoriaProducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoriaProducto.Location = New System.Drawing.Point(22, 41)
        Me.lblCategoriaProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategoriaProducto.Name = "lblCategoriaProducto"
        Me.lblCategoriaProducto.Size = New System.Drawing.Size(92, 16)
        Me.lblCategoriaProducto.TabIndex = 12
        Me.lblCategoriaProducto.Text = "CATEGORIA:"
        '
        'txtMedidasProducto
        '
        Me.txtMedidasProducto.Location = New System.Drawing.Point(169, 334)
        Me.txtMedidasProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMedidasProducto.Name = "txtMedidasProducto"
        Me.txtMedidasProducto.Size = New System.Drawing.Size(155, 20)
        Me.txtMedidasProducto.TabIndex = 11
        '
        'txtMarcaProducto
        '
        Me.txtMarcaProducto.Location = New System.Drawing.Point(160, 230)
        Me.txtMarcaProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMarcaProducto.Multiline = True
        Me.txtMarcaProducto.Name = "txtMarcaProducto"
        Me.txtMarcaProducto.Size = New System.Drawing.Size(219, 31)
        Me.txtMarcaProducto.TabIndex = 10
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(160, 152)
        Me.txtNombreProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(277, 20)
        Me.txtNombreProducto.TabIndex = 8
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(160, 90)
        Me.txtCodigoProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigoProducto.TabIndex = 7
        '
        'lblMediasProducto
        '
        Me.lblMediasProducto.AutoSize = True
        Me.lblMediasProducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMediasProducto.Location = New System.Drawing.Point(22, 338)
        Me.lblMediasProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMediasProducto.Name = "lblMediasProducto"
        Me.lblMediasProducto.Size = New System.Drawing.Size(76, 16)
        Me.lblMediasProducto.TabIndex = 5
        Me.lblMediasProducto.Text = "MEDIDAS:"
        '
        'lblMarcaProducto
        '
        Me.lblMarcaProducto.AutoSize = True
        Me.lblMarcaProducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcaProducto.Location = New System.Drawing.Point(22, 245)
        Me.lblMarcaProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMarcaProducto.Name = "lblMarcaProducto"
        Me.lblMarcaProducto.Size = New System.Drawing.Size(63, 16)
        Me.lblMarcaProducto.TabIndex = 4
        Me.lblMarcaProducto.Text = "MARCA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(342, 184)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 2
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProducto.Location = New System.Drawing.Point(22, 152)
        Me.lblNombreProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(75, 16)
        Me.lblNombreProducto.TabIndex = 1
        Me.lblNombreProducto.Text = "NOMBRE:"
        '
        'lblCodigoProducto
        '
        Me.lblCodigoProducto.AutoSize = True
        Me.lblCodigoProducto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProducto.Location = New System.Drawing.Point(22, 90)
        Me.lblCodigoProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoProducto.Name = "lblCodigoProducto"
        Me.lblCodigoProducto.Size = New System.Drawing.Size(69, 16)
        Me.lblCodigoProducto.TabIndex = 0
        Me.lblCodigoProducto.Text = "CODIGO:"
        '
        'Frmproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.grbEdicionProducto)
        Me.Controls.Add(Me.grbNavegacionProducto)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmproductos"
        Me.Text = "Registro de Productos"
        Me.grbEdicionProducto.ResumeLayout(False)
        Me.grbNavegacionProducto.ResumeLayout(False)
        Me.grbNavegacionProducto.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicionProducto As GroupBox
    Friend WithEvents btnBuscarPoducto As Button
    Friend WithEvents btnEliminarPoducto As Button
    Friend WithEvents btnModificarPoducto As Button
    Friend WithEvents btnAgregarPoducto As Button
    Friend WithEvents grbNavegacionProducto As GroupBox
    Friend WithEvents lblRegistroProductos As Label
    Friend WithEvents btnUltimoPoducto As Button
    Friend WithEvents btnSiguientePoducto As Button
    Friend WithEvents btnAnteriorPoducto As Button
    Friend WithEvents btnPrimeroPoducto As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents lblCategoriaProducto As Label
    Friend WithEvents txtMedidasProducto As TextBox
    Friend WithEvents txtMarcaProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents lblMediasProducto As Label
    Friend WithEvents lblMarcaProducto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblCodigoProducto As Label
End Class
