<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarClientes
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscarCliente = New System.Windows.Forms.Label()
        Me.btnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grbBuscarCliente = New System.Windows.Forms.DataGridView()
        Me.Idclientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grbBuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(124, 19)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(560, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'lblBuscarCliente
        '
        Me.lblBuscarCliente.AutoSize = True
        Me.lblBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarCliente.Location = New System.Drawing.Point(40, 22)
        Me.lblBuscarCliente.Name = "lblBuscarCliente"
        Me.lblBuscarCliente.Size = New System.Drawing.Size(62, 16)
        Me.lblBuscarCliente.TabIndex = 2
        Me.lblBuscarCliente.Text = "Buscar:"
        '
        'btnSeleccionarCliente
        '
        Me.btnSeleccionarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCliente.Location = New System.Drawing.Point(322, 382)
        Me.btnSeleccionarCliente.Name = "btnSeleccionarCliente"
        Me.btnSeleccionarCliente.Size = New System.Drawing.Size(173, 24)
        Me.btnSeleccionarCliente.TabIndex = 3
        Me.btnSeleccionarCliente.Text = "Seleccionar Cliente"
        Me.btnSeleccionarCliente.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(535, 382)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(149, 24)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grbBuscarCliente
        '
        Me.grbBuscarCliente.AllowUserToAddRows = False
        Me.grbBuscarCliente.AllowUserToDeleteRows = False
        Me.grbBuscarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idclientes, Me.codigo, Me.nombre, Me.direccion, Me.telefono, Me.email})
        Me.grbBuscarCliente.Location = New System.Drawing.Point(43, 67)
        Me.grbBuscarCliente.Name = "grbBuscarCliente"
        Me.grbBuscarCliente.ReadOnly = True
        Me.grbBuscarCliente.Size = New System.Drawing.Size(641, 289)
        Me.grbBuscarCliente.TabIndex = 5
        '
        'Idclientes
        '
        Me.Idclientes.DataPropertyName = "Idclientes"
        Me.Idclientes.HeaderText = "ID"
        Me.Idclientes.Name = "Idclientes"
        Me.Idclientes.ReadOnly = True
        Me.Idclientes.Visible = False
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
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 150
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.MinimumWidth = 12
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'FrmBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grbBuscarCliente)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSeleccionarCliente)
        Me.Controls.Add(Me.lblBuscarCliente)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "FrmBuscarClientes"
        Me.Text = "Busqueda registro de clientes"
        CType(Me.grbBuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblBuscarCliente As Label
    Friend WithEvents btnSeleccionarCliente As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents grbBuscarCliente As DataGridView
    Friend WithEvents Idclientes As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class
