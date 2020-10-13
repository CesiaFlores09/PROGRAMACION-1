<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmempleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmempleados))
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtPuestoLaboral = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblPuestoLaboral = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroEmpleados = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtEmail)
        Me.grbDatos.Controls.Add(Me.txtTelefono)
        Me.grbDatos.Controls.Add(Me.txtDireccion)
        Me.grbDatos.Controls.Add(Me.txtPuestoLaboral)
        Me.grbDatos.Controls.Add(Me.txtNombre)
        Me.grbDatos.Controls.Add(Me.txtCodigo)
        Me.grbDatos.Controls.Add(Me.lblEmail)
        Me.grbDatos.Controls.Add(Me.lblTelefono)
        Me.grbDatos.Controls.Add(Me.lblDireccion)
        Me.grbDatos.Controls.Add(Me.lblPuestoLaboral)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Controls.Add(Me.lblNombre)
        Me.grbDatos.Controls.Add(Me.lblCodigo)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(57, 38)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbDatos.Size = New System.Drawing.Size(724, 395)
        Me.grbDatos.TabIndex = 0
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de empleados"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(160, 336)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(277, 20)
        Me.txtEmail.TabIndex = 12
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(160, 278)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(155, 20)
        Me.txtTelefono.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(160, 184)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(219, 66)
        Me.txtDireccion.TabIndex = 10
        '
        'txtPuestoLaboral
        '
        Me.txtPuestoLaboral.Location = New System.Drawing.Point(160, 124)
        Me.txtPuestoLaboral.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPuestoLaboral.Name = "txtPuestoLaboral"
        Me.txtPuestoLaboral.Size = New System.Drawing.Size(237, 20)
        Me.txtPuestoLaboral.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(160, 76)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(277, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(160, 34)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigo.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(14, 335)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(55, 16)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "EMAIL:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(14, 277)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(87, 16)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "TELEFONO:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(14, 197)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(90, 16)
        Me.lblDireccion.TabIndex = 4
        Me.lblDireccion.Text = "DIRECCION:"
        '
        'lblPuestoLaboral
        '
        Me.lblPuestoLaboral.AutoSize = True
        Me.lblPuestoLaboral.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuestoLaboral.Location = New System.Drawing.Point(14, 123)
        Me.lblPuestoLaboral.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPuestoLaboral.Name = "lblPuestoLaboral"
        Me.lblPuestoLaboral.Size = New System.Drawing.Size(137, 16)
        Me.lblPuestoLaboral.TabIndex = 3
        Me.lblPuestoLaboral.Text = "PUESTO LABORAL:"
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
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(14, 76)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(75, 16)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "NOMBRE:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(14, 34)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(69, 16)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "CODIGO:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroEmpleados)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(57, 478)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbNavegacion.Size = New System.Drawing.Size(342, 81)
        Me.grbNavegacion.TabIndex = 1
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = " Navegacion"
        '
        'lblRegistroEmpleados
        '
        Me.lblRegistroEmpleados.AutoSize = True
        Me.lblRegistroEmpleados.Location = New System.Drawing.Point(134, 51)
        Me.lblRegistroEmpleados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegistroEmpleados.Name = "lblRegistroEmpleados"
        Me.lblRegistroEmpleados.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroEmpleados.TabIndex = 4
        Me.lblRegistroEmpleados.Text = "x de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(281, 17)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(56, 49)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(220, 17)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(56, 49)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(65, 17)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(56, 49)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(4, 17)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(56, 49)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscar)
        Me.grbEdicion.Controls.Add(Me.btnEliminar)
        Me.grbEdicion.Controls.Add(Me.btnModificar)
        Me.grbEdicion.Controls.Add(Me.btnAgregar)
        Me.grbEdicion.Location = New System.Drawing.Point(418, 478)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbEdicion.Size = New System.Drawing.Size(407, 81)
        Me.grbEdicion.TabIndex = 2
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(307, 17)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(83, 49)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(209, 18)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 48)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(96, 17)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 48)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(11, 17)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(66, 48)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmempleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 609)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmempleados"
        Me.Text = "Registro empleados"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblPuestoLaboral As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtPuestoLaboral As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistroEmpleados As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
End Class
