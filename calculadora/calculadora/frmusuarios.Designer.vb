<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmusuarios))
        Me.grbEdicionUsuario = New System.Windows.Forms.GroupBox()
        Me.btnBuscarUsuario = New System.Windows.Forms.Button()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnModificarUsuario = New System.Windows.Forms.Button()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.grbNavegacionUsuario = New System.Windows.Forms.GroupBox()
        Me.lblRegistroUsuario = New System.Windows.Forms.Label()
        Me.btnUltimoUsuario = New System.Windows.Forms.Button()
        Me.btnSiguienteUsuario = New System.Windows.Forms.Button()
        Me.btnAnteriorUsuario = New System.Windows.Forms.Button()
        Me.btnPrimeroUsuario = New System.Windows.Forms.Button()
        Me.grbDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.txtPrivilegioUsuario = New System.Windows.Forms.TextBox()
        Me.lblPrivilegioUsuario = New System.Windows.Forms.Label()
        Me.txtClaveUsuario = New System.Windows.Forms.TextBox()
        Me.lblClaveUsuario = New System.Windows.Forms.Label()
        Me.txtEmailUsuario = New System.Windows.Forms.TextBox()
        Me.txtTelefonoUsuario = New System.Windows.Forms.TextBox()
        Me.txtDireccionUsuario = New System.Windows.Forms.TextBox()
        Me.txtApellidoUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblEmailUsuario = New System.Windows.Forms.Label()
        Me.lblTelefonoUsuario = New System.Windows.Forms.Label()
        Me.lblDireccionUsuario = New System.Windows.Forms.Label()
        Me.lblApellidoUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.grbEdicionUsuario.SuspendLayout()
        Me.grbNavegacionUsuario.SuspendLayout()
        Me.grbDatosUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicionUsuario
        '
        Me.grbEdicionUsuario.Controls.Add(Me.btnBuscarUsuario)
        Me.grbEdicionUsuario.Controls.Add(Me.btnEliminarUsuario)
        Me.grbEdicionUsuario.Controls.Add(Me.btnModificarUsuario)
        Me.grbEdicionUsuario.Controls.Add(Me.btnAgregarUsuario)
        Me.grbEdicionUsuario.Location = New System.Drawing.Point(400, 422)
        Me.grbEdicionUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.grbEdicionUsuario.Name = "grbEdicionUsuario"
        Me.grbEdicionUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.grbEdicionUsuario.Size = New System.Drawing.Size(407, 81)
        Me.grbEdicionUsuario.TabIndex = 5
        Me.grbEdicionUsuario.TabStop = False
        Me.grbEdicionUsuario.Text = "Edicion"
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscarUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(307, 17)
        Me.btnBuscarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(83, 49)
        Me.btnBuscarUsuario.TabIndex = 4
        Me.btnBuscarUsuario.Text = "Buscar"
        Me.btnBuscarUsuario.UseVisualStyleBackColor = False
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(209, 18)
        Me.btnEliminarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(93, 48)
        Me.btnEliminarUsuario.TabIndex = 3
        Me.btnEliminarUsuario.Text = "Eliminar"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = False
        '
        'btnModificarUsuario
        '
        Me.btnModificarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificarUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarUsuario.Location = New System.Drawing.Point(96, 17)
        Me.btnModificarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarUsuario.Name = "btnModificarUsuario"
        Me.btnModificarUsuario.Size = New System.Drawing.Size(109, 48)
        Me.btnModificarUsuario.TabIndex = 2
        Me.btnModificarUsuario.Text = "Modificar"
        Me.btnModificarUsuario.UseVisualStyleBackColor = False
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(11, 17)
        Me.btnAgregarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(81, 48)
        Me.btnAgregarUsuario.TabIndex = 1
        Me.btnAgregarUsuario.Text = "Nuevo"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = False
        '
        'grbNavegacionUsuario
        '
        Me.grbNavegacionUsuario.Controls.Add(Me.lblRegistroUsuario)
        Me.grbNavegacionUsuario.Controls.Add(Me.btnUltimoUsuario)
        Me.grbNavegacionUsuario.Controls.Add(Me.btnSiguienteUsuario)
        Me.grbNavegacionUsuario.Controls.Add(Me.btnAnteriorUsuario)
        Me.grbNavegacionUsuario.Controls.Add(Me.btnPrimeroUsuario)
        Me.grbNavegacionUsuario.Location = New System.Drawing.Point(39, 422)
        Me.grbNavegacionUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionUsuario.Name = "grbNavegacionUsuario"
        Me.grbNavegacionUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionUsuario.Size = New System.Drawing.Size(342, 81)
        Me.grbNavegacionUsuario.TabIndex = 4
        Me.grbNavegacionUsuario.TabStop = False
        Me.grbNavegacionUsuario.Text = " Navegacion"
        '
        'lblRegistroUsuario
        '
        Me.lblRegistroUsuario.AutoSize = True
        Me.lblRegistroUsuario.Location = New System.Drawing.Point(147, 35)
        Me.lblRegistroUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegistroUsuario.Name = "lblRegistroUsuario"
        Me.lblRegistroUsuario.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroUsuario.TabIndex = 4
        Me.lblRegistroUsuario.Text = "x de n"
        '
        'btnUltimoUsuario
        '
        Me.btnUltimoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUltimoUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoUsuario.Location = New System.Drawing.Point(281, 17)
        Me.btnUltimoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUltimoUsuario.Name = "btnUltimoUsuario"
        Me.btnUltimoUsuario.Size = New System.Drawing.Size(56, 49)
        Me.btnUltimoUsuario.TabIndex = 3
        Me.btnUltimoUsuario.Text = ">|"
        Me.btnUltimoUsuario.UseVisualStyleBackColor = False
        '
        'btnSiguienteUsuario
        '
        Me.btnSiguienteUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSiguienteUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteUsuario.Location = New System.Drawing.Point(220, 17)
        Me.btnSiguienteUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguienteUsuario.Name = "btnSiguienteUsuario"
        Me.btnSiguienteUsuario.Size = New System.Drawing.Size(56, 49)
        Me.btnSiguienteUsuario.TabIndex = 2
        Me.btnSiguienteUsuario.Text = ">"
        Me.btnSiguienteUsuario.UseVisualStyleBackColor = False
        '
        'btnAnteriorUsuario
        '
        Me.btnAnteriorUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnteriorUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorUsuario.Location = New System.Drawing.Point(65, 17)
        Me.btnAnteriorUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnteriorUsuario.Name = "btnAnteriorUsuario"
        Me.btnAnteriorUsuario.Size = New System.Drawing.Size(56, 49)
        Me.btnAnteriorUsuario.TabIndex = 1
        Me.btnAnteriorUsuario.Text = "<"
        Me.btnAnteriorUsuario.UseVisualStyleBackColor = False
        '
        'btnPrimeroUsuario
        '
        Me.btnPrimeroUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrimeroUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroUsuario.Location = New System.Drawing.Point(4, 17)
        Me.btnPrimeroUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrimeroUsuario.Name = "btnPrimeroUsuario"
        Me.btnPrimeroUsuario.Size = New System.Drawing.Size(56, 49)
        Me.btnPrimeroUsuario.TabIndex = 0
        Me.btnPrimeroUsuario.Text = "|<"
        Me.btnPrimeroUsuario.UseVisualStyleBackColor = False
        '
        'grbDatosUsuario
        '
        Me.grbDatosUsuario.Controls.Add(Me.txtPrivilegioUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.lblPrivilegioUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.txtClaveUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.lblClaveUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.txtEmailUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.txtTelefonoUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.txtDireccionUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.txtApellidoUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.txtNombreUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.lblEmailUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.lblTelefonoUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.lblDireccionUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.lblApellidoUsuario)
        Me.grbDatosUsuario.Controls.Add(Me.Label2)
        Me.grbDatosUsuario.Controls.Add(Me.lblNombreUsuario)
        Me.grbDatosUsuario.Enabled = False
        Me.grbDatosUsuario.Location = New System.Drawing.Point(39, 12)
        Me.grbDatosUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.grbDatosUsuario.Name = "grbDatosUsuario"
        Me.grbDatosUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.grbDatosUsuario.Size = New System.Drawing.Size(764, 395)
        Me.grbDatosUsuario.TabIndex = 3
        Me.grbDatosUsuario.TabStop = False
        Me.grbDatosUsuario.Text = "Datos de usuarios"
        '
        'txtPrivilegioUsuario
        '
        Me.txtPrivilegioUsuario.Location = New System.Drawing.Point(166, 345)
        Me.txtPrivilegioUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrivilegioUsuario.Name = "txtPrivilegioUsuario"
        Me.txtPrivilegioUsuario.Size = New System.Drawing.Size(155, 20)
        Me.txtPrivilegioUsuario.TabIndex = 16
        '
        'lblPrivilegioUsuario
        '
        Me.lblPrivilegioUsuario.AutoSize = True
        Me.lblPrivilegioUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrivilegioUsuario.Location = New System.Drawing.Point(20, 344)
        Me.lblPrivilegioUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrivilegioUsuario.Name = "lblPrivilegioUsuario"
        Me.lblPrivilegioUsuario.Size = New System.Drawing.Size(91, 16)
        Me.lblPrivilegioUsuario.TabIndex = 15
        Me.lblPrivilegioUsuario.Text = "PRIVILEGIO:"
        '
        'txtClaveUsuario
        '
        Me.txtClaveUsuario.Location = New System.Drawing.Point(164, 124)
        Me.txtClaveUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClaveUsuario.Name = "txtClaveUsuario"
        Me.txtClaveUsuario.Size = New System.Drawing.Size(237, 20)
        Me.txtClaveUsuario.TabIndex = 14
        '
        'lblClaveUsuario
        '
        Me.lblClaveUsuario.AutoSize = True
        Me.lblClaveUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaveUsuario.Location = New System.Drawing.Point(18, 123)
        Me.lblClaveUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClaveUsuario.Name = "lblClaveUsuario"
        Me.lblClaveUsuario.Size = New System.Drawing.Size(56, 16)
        Me.lblClaveUsuario.TabIndex = 13
        Me.lblClaveUsuario.Text = "CLAVE:"
        '
        'txtEmailUsuario
        '
        Me.txtEmailUsuario.Location = New System.Drawing.Point(164, 167)
        Me.txtEmailUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailUsuario.Name = "txtEmailUsuario"
        Me.txtEmailUsuario.Size = New System.Drawing.Size(277, 20)
        Me.txtEmailUsuario.TabIndex = 12
        '
        'txtTelefonoUsuario
        '
        Me.txtTelefonoUsuario.Location = New System.Drawing.Point(166, 291)
        Me.txtTelefonoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefonoUsuario.Name = "txtTelefonoUsuario"
        Me.txtTelefonoUsuario.Size = New System.Drawing.Size(155, 20)
        Me.txtTelefonoUsuario.TabIndex = 11
        '
        'txtDireccionUsuario
        '
        Me.txtDireccionUsuario.Location = New System.Drawing.Point(164, 210)
        Me.txtDireccionUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccionUsuario.Multiline = True
        Me.txtDireccionUsuario.Name = "txtDireccionUsuario"
        Me.txtDireccionUsuario.Size = New System.Drawing.Size(274, 47)
        Me.txtDireccionUsuario.TabIndex = 10
        '
        'txtApellidoUsuario
        '
        Me.txtApellidoUsuario.Location = New System.Drawing.Point(164, 77)
        Me.txtApellidoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoUsuario.Name = "txtApellidoUsuario"
        Me.txtApellidoUsuario.Size = New System.Drawing.Size(237, 20)
        Me.txtApellidoUsuario.TabIndex = 9
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(164, 29)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(277, 20)
        Me.txtNombreUsuario.TabIndex = 8
        '
        'lblEmailUsuario
        '
        Me.lblEmailUsuario.AutoSize = True
        Me.lblEmailUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailUsuario.Location = New System.Drawing.Point(18, 166)
        Me.lblEmailUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailUsuario.Name = "lblEmailUsuario"
        Me.lblEmailUsuario.Size = New System.Drawing.Size(55, 16)
        Me.lblEmailUsuario.TabIndex = 6
        Me.lblEmailUsuario.Text = "EMAIL:"
        '
        'lblTelefonoUsuario
        '
        Me.lblTelefonoUsuario.AutoSize = True
        Me.lblTelefonoUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoUsuario.Location = New System.Drawing.Point(20, 290)
        Me.lblTelefonoUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonoUsuario.Name = "lblTelefonoUsuario"
        Me.lblTelefonoUsuario.Size = New System.Drawing.Size(87, 16)
        Me.lblTelefonoUsuario.TabIndex = 5
        Me.lblTelefonoUsuario.Text = "TELEFONO:"
        '
        'lblDireccionUsuario
        '
        Me.lblDireccionUsuario.AutoSize = True
        Me.lblDireccionUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionUsuario.Location = New System.Drawing.Point(17, 221)
        Me.lblDireccionUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccionUsuario.Name = "lblDireccionUsuario"
        Me.lblDireccionUsuario.Size = New System.Drawing.Size(90, 16)
        Me.lblDireccionUsuario.TabIndex = 4
        Me.lblDireccionUsuario.Text = "DIRECCION:"
        '
        'lblApellidoUsuario
        '
        Me.lblApellidoUsuario.AutoSize = True
        Me.lblApellidoUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoUsuario.Location = New System.Drawing.Point(18, 76)
        Me.lblApellidoUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellidoUsuario.Name = "lblApellidoUsuario"
        Me.lblApellidoUsuario.Size = New System.Drawing.Size(89, 16)
        Me.lblApellidoUsuario.TabIndex = 3
        Me.lblApellidoUsuario.Text = "APELLIDOS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 259)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 2
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(18, 29)
        Me.lblNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(75, 16)
        Me.lblNombreUsuario.TabIndex = 1
        Me.lblNombreUsuario.Text = "NOMBRE:"
        '
        'frmusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 514)
        Me.Controls.Add(Me.grbEdicionUsuario)
        Me.Controls.Add(Me.grbNavegacionUsuario)
        Me.Controls.Add(Me.grbDatosUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmusuarios"
        Me.Text = " Registro de usuarios"
        Me.grbEdicionUsuario.ResumeLayout(False)
        Me.grbNavegacionUsuario.ResumeLayout(False)
        Me.grbNavegacionUsuario.PerformLayout()
        Me.grbDatosUsuario.ResumeLayout(False)
        Me.grbDatosUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicionUsuario As GroupBox
    Friend WithEvents btnBuscarUsuario As Button
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents btnModificarUsuario As Button
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents grbNavegacionUsuario As GroupBox
    Friend WithEvents lblRegistroUsuario As Label
    Friend WithEvents btnUltimoUsuario As Button
    Friend WithEvents btnSiguienteUsuario As Button
    Friend WithEvents btnAnteriorUsuario As Button
    Friend WithEvents btnPrimeroUsuario As Button
    Friend WithEvents grbDatosUsuario As GroupBox
    Friend WithEvents txtClaveUsuario As TextBox
    Friend WithEvents lblClaveUsuario As Label
    Friend WithEvents txtEmailUsuario As TextBox
    Friend WithEvents txtTelefonoUsuario As TextBox
    Friend WithEvents txtDireccionUsuario As TextBox
    Friend WithEvents txtApellidoUsuario As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents lblEmailUsuario As Label
    Friend WithEvents lblTelefonoUsuario As Label
    Friend WithEvents lblDireccionUsuario As Label
    Friend WithEvents lblApellidoUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents txtPrivilegioUsuario As TextBox
    Friend WithEvents lblPrivilegioUsuario As Label
End Class
