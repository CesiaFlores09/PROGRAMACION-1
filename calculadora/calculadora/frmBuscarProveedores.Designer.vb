<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarProveedores))
        Me.txtBuscarProveedores = New System.Windows.Forms.TextBox()
        Me.grbBuscarProveedores = New System.Windows.Forms.DataGridView()
        Me.idproveedores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBuscarProveedores = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSeleccionarProveedor = New System.Windows.Forms.Button()
        CType(Me.grbBuscarProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarProveedores
        '
        Me.txtBuscarProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarProveedores.Location = New System.Drawing.Point(99, 25)
        Me.txtBuscarProveedores.Name = "txtBuscarProveedores"
        Me.txtBuscarProveedores.Size = New System.Drawing.Size(812, 20)
        Me.txtBuscarProveedores.TabIndex = 8
        '
        'grbBuscarProveedores
        '
        Me.grbBuscarProveedores.AllowUserToAddRows = False
        Me.grbBuscarProveedores.AllowUserToDeleteRows = False
        Me.grbBuscarProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbBuscarProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscarProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idproveedores, Me.codigo, Me.nombre, Me.nombre_empresa, Me.nombre_propietario, Me.direccion, Me.telefono, Me.email})
        Me.grbBuscarProveedores.Location = New System.Drawing.Point(22, 92)
        Me.grbBuscarProveedores.Name = "grbBuscarProveedores"
        Me.grbBuscarProveedores.ReadOnly = True
        Me.grbBuscarProveedores.Size = New System.Drawing.Size(889, 330)
        Me.grbBuscarProveedores.TabIndex = 9
        '
        'idproveedores
        '
        Me.idproveedores.DataPropertyName = "idproveedores"
        Me.idproveedores.HeaderText = "id"
        Me.idproveedores.Name = "idproveedores"
        Me.idproveedores.ReadOnly = True
        Me.idproveedores.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'nombre_empresa
        '
        Me.nombre_empresa.DataPropertyName = "nombre_empresa"
        Me.nombre_empresa.HeaderText = "NOMBRE EMPRESA"
        Me.nombre_empresa.Name = "nombre_empresa"
        Me.nombre_empresa.ReadOnly = True
        Me.nombre_empresa.Width = 150
        '
        'nombre_propietario
        '
        Me.nombre_propietario.DataPropertyName = "nombre_propietario"
        Me.nombre_propietario.HeaderText = "NOMBRE PROPIETARIO"
        Me.nombre_propietario.Name = "nombre_propietario"
        Me.nombre_propietario.ReadOnly = True
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 150
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'lblBuscarProveedores
        '
        Me.lblBuscarProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuscarProveedores.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarProveedores.Image = Global.calculadora.My.Resources.Resources.iconfinder_User_Interface_25_2044263
        Me.lblBuscarProveedores.Location = New System.Drawing.Point(28, 9)
        Me.lblBuscarProveedores.Name = "lblBuscarProveedores"
        Me.lblBuscarProveedores.Size = New System.Drawing.Size(55, 52)
        Me.lblBuscarProveedores.TabIndex = 11
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.calculadora.My.Resources.Resources.iconfinder_cancel_2467375
        Me.btnCancelar.Location = New System.Drawing.Point(135, 440)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(106, 44)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSeleccionarProveedor
        '
        Me.btnSeleccionarProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSeleccionarProveedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProveedor.Image = Global.calculadora.My.Resources.Resources.iconfinder_cursor_309088__1_
        Me.btnSeleccionarProveedor.Location = New System.Drawing.Point(22, 440)
        Me.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor"
        Me.btnSeleccionarProveedor.Size = New System.Drawing.Size(94, 44)
        Me.btnSeleccionarProveedor.TabIndex = 12
        Me.btnSeleccionarProveedor.UseVisualStyleBackColor = False
        '
        'frmBuscarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 507)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSeleccionarProveedor)
        Me.Controls.Add(Me.lblBuscarProveedores)
        Me.Controls.Add(Me.grbBuscarProveedores)
        Me.Controls.Add(Me.txtBuscarProveedores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscarProveedores"
        Me.Text = "Buscaqueda de Proveedores"
        CType(Me.grbBuscarProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarProveedores As TextBox
    Friend WithEvents grbBuscarProveedores As DataGridView
    Friend WithEvents idproveedores As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents nombre_empresa As DataGridViewTextBoxColumn
    Friend WithEvents nombre_propietario As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents lblBuscarProveedores As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSeleccionarProveedor As Button
End Class
