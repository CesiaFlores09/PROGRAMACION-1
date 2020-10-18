<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproveedores
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
        Me.grbDatosdeProveedores = New System.Windows.Forms.GroupBox()
        Me.txtNombrePropietario = New System.Windows.Forms.TextBox()
        Me.lblNombrePropietario = New System.Windows.Forms.Label()
        Me.txtEmailProveedores = New System.Windows.Forms.TextBox()
        Me.txtTelefonoProveedores = New System.Windows.Forms.TextBox()
        Me.txtDireccionProveedores = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.txtNombreProveedores = New System.Windows.Forms.TextBox()
        Me.txtCodigoProveedores = New System.Windows.Forms.TextBox()
        Me.lblEmailProveedores = New System.Windows.Forms.Label()
        Me.lblTelefonoProveedores = New System.Windows.Forms.Label()
        Me.lblDireccionProveedores = New System.Windows.Forms.Label()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombreProveedores = New System.Windows.Forms.Label()
        Me.lblCodigoProveedores = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroProveedores = New System.Windows.Forms.Label()
        Me.btnUltimoProveedores = New System.Windows.Forms.Button()
        Me.btnSiguienteProveedores = New System.Windows.Forms.Button()
        Me.btnAnteriorProveedores = New System.Windows.Forms.Button()
        Me.btnPrimeroProveedores = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProveedores = New System.Windows.Forms.Button()
        Me.btnEliminarProveedores = New System.Windows.Forms.Button()
        Me.btnModificarProveedores = New System.Windows.Forms.Button()
        Me.btnAgregarProveedores = New System.Windows.Forms.Button()
        Me.grbDatosdeProveedores.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatosdeProveedores
        '
        Me.grbDatosdeProveedores.Controls.Add(Me.txtNombrePropietario)
        Me.grbDatosdeProveedores.Controls.Add(Me.lblNombrePropietario)
        Me.grbDatosdeProveedores.Controls.Add(Me.txtEmailProveedores)
        Me.grbDatosdeProveedores.Controls.Add(Me.txtTelefonoProveedores)
        Me.grbDatosdeProveedores.Controls.Add(Me.txtDireccionProveedores)
        Me.grbDatosdeProveedores.Controls.Add(Me.txtNombreEmpresa)
        Me.grbDatosdeProveedores.Controls.Add(Me.txtNombreProveedores)
        Me.grbDatosdeProveedores.Controls.Add(Me.txtCodigoProveedores)
        Me.grbDatosdeProveedores.Controls.Add(Me.lblEmailProveedores)
        Me.grbDatosdeProveedores.Controls.Add(Me.lblTelefonoProveedores)
        Me.grbDatosdeProveedores.Controls.Add(Me.lblDireccionProveedores)
        Me.grbDatosdeProveedores.Controls.Add(Me.lblNombreEmpresa)
        Me.grbDatosdeProveedores.Controls.Add(Me.Label2)
        Me.grbDatosdeProveedores.Controls.Add(Me.lblNombreProveedores)
        Me.grbDatosdeProveedores.Controls.Add(Me.lblCodigoProveedores)
        Me.grbDatosdeProveedores.Enabled = False
        Me.grbDatosdeProveedores.Location = New System.Drawing.Point(24, 11)
        Me.grbDatosdeProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.grbDatosdeProveedores.Name = "grbDatosdeProveedores"
        Me.grbDatosdeProveedores.Padding = New System.Windows.Forms.Padding(2)
        Me.grbDatosdeProveedores.Size = New System.Drawing.Size(753, 443)
        Me.grbDatosdeProveedores.TabIndex = 2
        Me.grbDatosdeProveedores.TabStop = False
        Me.grbDatosdeProveedores.Text = "Registro de proveedores"
        '
        'txtNombrePropietario
        '
        Me.txtNombrePropietario.Location = New System.Drawing.Point(182, 193)
        Me.txtNombrePropietario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombrePropietario.Name = "txtNombrePropietario"
        Me.txtNombrePropietario.Size = New System.Drawing.Size(237, 20)
        Me.txtNombrePropietario.TabIndex = 14
        '
        'lblNombrePropietario
        '
        Me.lblNombrePropietario.AutoSize = True
        Me.lblNombrePropietario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePropietario.Location = New System.Drawing.Point(14, 194)
        Me.lblNombrePropietario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombrePropietario.Name = "lblNombrePropietario"
        Me.lblNombrePropietario.Size = New System.Drawing.Size(172, 16)
        Me.lblNombrePropietario.TabIndex = 13
        Me.lblNombrePropietario.Text = "NOMBRE PROPIETARIO:"
        '
        'txtEmailProveedores
        '
        Me.txtEmailProveedores.Location = New System.Drawing.Point(160, 416)
        Me.txtEmailProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailProveedores.Name = "txtEmailProveedores"
        Me.txtEmailProveedores.Size = New System.Drawing.Size(277, 20)
        Me.txtEmailProveedores.TabIndex = 12
        '
        'txtTelefonoProveedores
        '
        Me.txtTelefonoProveedores.Location = New System.Drawing.Point(160, 364)
        Me.txtTelefonoProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefonoProveedores.Name = "txtTelefonoProveedores"
        Me.txtTelefonoProveedores.Size = New System.Drawing.Size(155, 20)
        Me.txtTelefonoProveedores.TabIndex = 11
        '
        'txtDireccionProveedores
        '
        Me.txtDireccionProveedores.Location = New System.Drawing.Point(160, 275)
        Me.txtDireccionProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccionProveedores.Multiline = True
        Me.txtDireccionProveedores.Name = "txtDireccionProveedores"
        Me.txtDireccionProveedores.Size = New System.Drawing.Size(219, 66)
        Me.txtDireccionProveedores.TabIndex = 10
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(160, 124)
        Me.txtNombreEmpresa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(237, 20)
        Me.txtNombreEmpresa.TabIndex = 9
        '
        'txtNombreProveedores
        '
        Me.txtNombreProveedores.Location = New System.Drawing.Point(160, 76)
        Me.txtNombreProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreProveedores.Name = "txtNombreProveedores"
        Me.txtNombreProveedores.Size = New System.Drawing.Size(277, 20)
        Me.txtNombreProveedores.TabIndex = 8
        '
        'txtCodigoProveedores
        '
        Me.txtCodigoProveedores.Location = New System.Drawing.Point(160, 34)
        Me.txtCodigoProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoProveedores.Name = "txtCodigoProveedores"
        Me.txtCodigoProveedores.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigoProveedores.TabIndex = 7
        '
        'lblEmailProveedores
        '
        Me.lblEmailProveedores.AutoSize = True
        Me.lblEmailProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailProveedores.Location = New System.Drawing.Point(14, 420)
        Me.lblEmailProveedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailProveedores.Name = "lblEmailProveedores"
        Me.lblEmailProveedores.Size = New System.Drawing.Size(55, 16)
        Me.lblEmailProveedores.TabIndex = 6
        Me.lblEmailProveedores.Text = "EMAIL:"
        '
        'lblTelefonoProveedores
        '
        Me.lblTelefonoProveedores.AutoSize = True
        Me.lblTelefonoProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoProveedores.Location = New System.Drawing.Point(14, 364)
        Me.lblTelefonoProveedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonoProveedores.Name = "lblTelefonoProveedores"
        Me.lblTelefonoProveedores.Size = New System.Drawing.Size(87, 16)
        Me.lblTelefonoProveedores.TabIndex = 5
        Me.lblTelefonoProveedores.Text = "TELEFONO:"
        '
        'lblDireccionProveedores
        '
        Me.lblDireccionProveedores.AutoSize = True
        Me.lblDireccionProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionProveedores.Location = New System.Drawing.Point(14, 303)
        Me.lblDireccionProveedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccionProveedores.Name = "lblDireccionProveedores"
        Me.lblDireccionProveedores.Size = New System.Drawing.Size(90, 16)
        Me.lblDireccionProveedores.TabIndex = 4
        Me.lblDireccionProveedores.Text = "DIRECCION:"
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(14, 123)
        Me.lblNombreEmpresa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(147, 16)
        Me.lblNombreEmpresa.TabIndex = 3
        Me.lblNombreEmpresa.Text = "NOMBRE EMPRESA:"
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
        'lblNombreProveedores
        '
        Me.lblNombreProveedores.AutoSize = True
        Me.lblNombreProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProveedores.Location = New System.Drawing.Point(14, 76)
        Me.lblNombreProveedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreProveedores.Name = "lblNombreProveedores"
        Me.lblNombreProveedores.Size = New System.Drawing.Size(75, 16)
        Me.lblNombreProveedores.TabIndex = 1
        Me.lblNombreProveedores.Text = "NOMBRE:"
        '
        'lblCodigoProveedores
        '
        Me.lblCodigoProveedores.AutoSize = True
        Me.lblCodigoProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProveedores.Location = New System.Drawing.Point(14, 34)
        Me.lblCodigoProveedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoProveedores.Name = "lblCodigoProveedores"
        Me.lblCodigoProveedores.Size = New System.Drawing.Size(69, 16)
        Me.lblCodigoProveedores.TabIndex = 0
        Me.lblCodigoProveedores.Text = "CODIGO:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroProveedores)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoProveedores)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProveedores)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProveedores)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroProveedores)
        Me.grbNavegacion.Location = New System.Drawing.Point(24, 458)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(2)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(2)
        Me.grbNavegacion.Size = New System.Drawing.Size(342, 74)
        Me.grbNavegacion.TabIndex = 3
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = " Navegacion"
        '
        'lblRegistroProveedores
        '
        Me.lblRegistroProveedores.AutoSize = True
        Me.lblRegistroProveedores.Location = New System.Drawing.Point(125, 36)
        Me.lblRegistroProveedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegistroProveedores.Name = "lblRegistroProveedores"
        Me.lblRegistroProveedores.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroProveedores.TabIndex = 4
        Me.lblRegistroProveedores.Text = "x de n"
        '
        'btnUltimoProveedores
        '
        Me.btnUltimoProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoProveedores.Location = New System.Drawing.Point(281, 17)
        Me.btnUltimoProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUltimoProveedores.Name = "btnUltimoProveedores"
        Me.btnUltimoProveedores.Size = New System.Drawing.Size(56, 49)
        Me.btnUltimoProveedores.TabIndex = 3
        Me.btnUltimoProveedores.Text = ">|"
        Me.btnUltimoProveedores.UseVisualStyleBackColor = True
        '
        'btnSiguienteProveedores
        '
        Me.btnSiguienteProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProveedores.Location = New System.Drawing.Point(220, 17)
        Me.btnSiguienteProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguienteProveedores.Name = "btnSiguienteProveedores"
        Me.btnSiguienteProveedores.Size = New System.Drawing.Size(56, 49)
        Me.btnSiguienteProveedores.TabIndex = 2
        Me.btnSiguienteProveedores.Text = ">"
        Me.btnSiguienteProveedores.UseVisualStyleBackColor = True
        '
        'btnAnteriorProveedores
        '
        Me.btnAnteriorProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProveedores.Location = New System.Drawing.Point(65, 17)
        Me.btnAnteriorProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnteriorProveedores.Name = "btnAnteriorProveedores"
        Me.btnAnteriorProveedores.Size = New System.Drawing.Size(56, 49)
        Me.btnAnteriorProveedores.TabIndex = 1
        Me.btnAnteriorProveedores.Text = "<"
        Me.btnAnteriorProveedores.UseVisualStyleBackColor = True
        '
        'btnPrimeroProveedores
        '
        Me.btnPrimeroProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroProveedores.Location = New System.Drawing.Point(4, 17)
        Me.btnPrimeroProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrimeroProveedores.Name = "btnPrimeroProveedores"
        Me.btnPrimeroProveedores.Size = New System.Drawing.Size(56, 49)
        Me.btnPrimeroProveedores.TabIndex = 0
        Me.btnPrimeroProveedores.Text = "|<"
        Me.btnPrimeroProveedores.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProveedores)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProveedores)
        Me.grbEdicion.Controls.Add(Me.btnModificarProveedores)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProveedores)
        Me.grbEdicion.Location = New System.Drawing.Point(370, 458)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(2)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(2)
        Me.grbEdicion.Size = New System.Drawing.Size(407, 74)
        Me.grbEdicion.TabIndex = 4
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProveedores
        '
        Me.btnBuscarProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProveedores.Location = New System.Drawing.Point(307, 17)
        Me.btnBuscarProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarProveedores.Name = "btnBuscarProveedores"
        Me.btnBuscarProveedores.Size = New System.Drawing.Size(83, 49)
        Me.btnBuscarProveedores.TabIndex = 4
        Me.btnBuscarProveedores.Text = "Buscar"
        Me.btnBuscarProveedores.UseVisualStyleBackColor = True
        '
        'btnEliminarProveedores
        '
        Me.btnEliminarProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProveedores.Location = New System.Drawing.Point(209, 18)
        Me.btnEliminarProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarProveedores.Name = "btnEliminarProveedores"
        Me.btnEliminarProveedores.Size = New System.Drawing.Size(93, 48)
        Me.btnEliminarProveedores.TabIndex = 3
        Me.btnEliminarProveedores.Text = "Eliminar"
        Me.btnEliminarProveedores.UseVisualStyleBackColor = True
        '
        'btnModificarProveedores
        '
        Me.btnModificarProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProveedores.Location = New System.Drawing.Point(96, 17)
        Me.btnModificarProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarProveedores.Name = "btnModificarProveedores"
        Me.btnModificarProveedores.Size = New System.Drawing.Size(109, 48)
        Me.btnModificarProveedores.TabIndex = 2
        Me.btnModificarProveedores.Text = "Modificar"
        Me.btnModificarProveedores.UseVisualStyleBackColor = True
        '
        'btnAgregarProveedores
        '
        Me.btnAgregarProveedores.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProveedores.Location = New System.Drawing.Point(11, 17)
        Me.btnAgregarProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarProveedores.Name = "btnAgregarProveedores"
        Me.btnAgregarProveedores.Size = New System.Drawing.Size(81, 48)
        Me.btnAgregarProveedores.TabIndex = 1
        Me.btnAgregarProveedores.Text = "Nuevo"
        Me.btnAgregarProveedores.UseVisualStyleBackColor = True
        '
        'frmproveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 533)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatosdeProveedores)
        Me.Name = "frmproveedores"
        Me.Text = "frmproveedores"
        Me.grbDatosdeProveedores.ResumeLayout(False)
        Me.grbDatosdeProveedores.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatosdeProveedores As GroupBox
    Friend WithEvents txtNombrePropietario As TextBox
    Friend WithEvents lblNombrePropietario As Label
    Friend WithEvents txtEmailProveedores As TextBox
    Friend WithEvents txtTelefonoProveedores As TextBox
    Friend WithEvents txtDireccionProveedores As TextBox
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents txtNombreProveedores As TextBox
    Friend WithEvents txtCodigoProveedores As TextBox
    Friend WithEvents lblEmailProveedores As Label
    Friend WithEvents lblTelefonoProveedores As Label
    Friend WithEvents lblDireccionProveedores As Label
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombreProveedores As Label
    Friend WithEvents lblCodigoProveedores As Label
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistroProveedores As Label
    Friend WithEvents btnUltimoProveedores As Button
    Friend WithEvents btnSiguienteProveedores As Button
    Friend WithEvents btnAnteriorProveedores As Button
    Friend WithEvents btnPrimeroProveedores As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarProveedores As Button
    Friend WithEvents btnEliminarProveedores As Button
    Friend WithEvents btnModificarProveedores As Button
    Friend WithEvents btnAgregarProveedores As Button
End Class
