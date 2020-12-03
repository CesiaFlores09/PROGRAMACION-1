<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcliente))
        Me.grbEdicionCliente = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.grbNavegacionCliente = New System.Windows.Forms.GroupBox()
        Me.lblRegistroCliente = New System.Windows.Forms.Label()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.lblEmailCliente = New System.Windows.Forms.Label()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.btnUltimoCliente = New System.Windows.Forms.Button()
        Me.btnSiguienteCliente = New System.Windows.Forms.Button()
        Me.btnAnteriorCliente = New System.Windows.Forms.Button()
        Me.btnPrimeroCliente = New System.Windows.Forms.Button()
        Me.grbEdicionCliente.SuspendLayout()
        Me.grbNavegacionCliente.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicionCliente
        '
        Me.grbEdicionCliente.Controls.Add(Me.btnBuscarCliente)
        Me.grbEdicionCliente.Controls.Add(Me.btnEliminarCliente)
        Me.grbEdicionCliente.Controls.Add(Me.btnModificarCliente)
        Me.grbEdicionCliente.Controls.Add(Me.btnAgregarCliente)
        Me.grbEdicionCliente.Location = New System.Drawing.Point(359, 491)
        Me.grbEdicionCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.grbEdicionCliente.Name = "grbEdicionCliente"
        Me.grbEdicionCliente.Padding = New System.Windows.Forms.Padding(2)
        Me.grbEdicionCliente.Size = New System.Drawing.Size(469, 81)
        Me.grbEdicionCliente.TabIndex = 5
        Me.grbEdicionCliente.TabStop = False
        Me.grbEdicionCliente.Text = "Edicion"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.Location = New System.Drawing.Point(358, 17)
        Me.btnBuscarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 47)
        Me.btnBuscarCliente.TabIndex = 4
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.Location = New System.Drawing.Point(237, 17)
        Me.btnEliminarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(117, 47)
        Me.btnEliminarCliente.TabIndex = 3
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = False
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.Location = New System.Drawing.Point(124, 17)
        Me.btnModificarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(109, 47)
        Me.btnModificarCliente.TabIndex = 2
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = False
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(14, 17)
        Me.btnAgregarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(95, 47)
        Me.btnAgregarCliente.TabIndex = 1
        Me.btnAgregarCliente.Text = "Nuevo"
        Me.btnAgregarCliente.UseVisualStyleBackColor = False
        '
        'grbNavegacionCliente
        '
        Me.grbNavegacionCliente.Controls.Add(Me.lblRegistroCliente)
        Me.grbNavegacionCliente.Controls.Add(Me.btnUltimoCliente)
        Me.grbNavegacionCliente.Controls.Add(Me.btnSiguienteCliente)
        Me.grbNavegacionCliente.Controls.Add(Me.btnAnteriorCliente)
        Me.grbNavegacionCliente.Controls.Add(Me.btnPrimeroCliente)
        Me.grbNavegacionCliente.Location = New System.Drawing.Point(12, 491)
        Me.grbNavegacionCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionCliente.Name = "grbNavegacionCliente"
        Me.grbNavegacionCliente.Padding = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionCliente.Size = New System.Drawing.Size(342, 81)
        Me.grbNavegacionCliente.TabIndex = 4
        Me.grbNavegacionCliente.TabStop = False
        Me.grbNavegacionCliente.Text = " Navegacion"
        '
        'lblRegistroCliente
        '
        Me.lblRegistroCliente.AutoSize = True
        Me.lblRegistroCliente.Location = New System.Drawing.Point(146, 35)
        Me.lblRegistroCliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegistroCliente.Name = "lblRegistroCliente"
        Me.lblRegistroCliente.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroCliente.TabIndex = 4
        Me.lblRegistroCliente.Text = "x de n"
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtEmailCliente)
        Me.grbDatos.Controls.Add(Me.txtTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.txtDireccionCliente)
        Me.grbDatos.Controls.Add(Me.txtNombreCliente)
        Me.grbDatos.Controls.Add(Me.txtCodigoCliente)
        Me.grbDatos.Controls.Add(Me.lblEmailCliente)
        Me.grbDatos.Controls.Add(Me.lblTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.lblDireccionCliente)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Controls.Add(Me.lblNombreCliente)
        Me.grbDatos.Controls.Add(Me.lblCodigoCliente)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(12, 45)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(2)
        Me.grbDatos.Size = New System.Drawing.Size(749, 395)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de clientes"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(160, 336)
        Me.txtEmailCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(277, 20)
        Me.txtEmailCliente.TabIndex = 12
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(160, 258)
        Me.txtTelefonoCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(155, 20)
        Me.txtTelefonoCliente.TabIndex = 11
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Location = New System.Drawing.Point(160, 136)
        Me.txtDireccionCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccionCliente.Multiline = True
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(219, 66)
        Me.txtDireccionCliente.TabIndex = 10
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(160, 76)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(277, 20)
        Me.txtNombreCliente.TabIndex = 8
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(160, 34)
        Me.txtCodigoCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigoCliente.TabIndex = 7
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCliente.Location = New System.Drawing.Point(14, 335)
        Me.lblEmailCliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(55, 16)
        Me.lblEmailCliente.TabIndex = 6
        Me.lblEmailCliente.Text = "EMAIL:"
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(16, 260)
        Me.lblTelefonoCliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(87, 16)
        Me.lblTelefonoCliente.TabIndex = 5
        Me.lblTelefonoCliente.Text = "TELEFONO:"
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(14, 154)
        Me.lblDireccionCliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(90, 16)
        Me.lblDireccionCliente.TabIndex = 4
        Me.lblDireccionCliente.Text = "DIRECCION:"
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
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(14, 76)
        Me.lblNombreCliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(75, 16)
        Me.lblNombreCliente.TabIndex = 1
        Me.lblNombreCliente.Text = "NOMBRE:"
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCliente.Location = New System.Drawing.Point(14, 34)
        Me.lblCodigoCliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(69, 16)
        Me.lblCodigoCliente.TabIndex = 0
        Me.lblCodigoCliente.Text = "CODIGO:"
        '
        'btnUltimoCliente
        '
        Me.btnUltimoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUltimoCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCliente.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_next_48px_3669229
        Me.btnUltimoCliente.Location = New System.Drawing.Point(281, 17)
        Me.btnUltimoCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUltimoCliente.Name = "btnUltimoCliente"
        Me.btnUltimoCliente.Size = New System.Drawing.Size(56, 49)
        Me.btnUltimoCliente.TabIndex = 3
        Me.btnUltimoCliente.UseVisualStyleBackColor = False
        '
        'btnSiguienteCliente
        '
        Me.btnSiguienteCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSiguienteCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCliente.Image = Global.calculadora.My.Resources.Resources.iconfinder_next_right_arrow_botton_2203522
        Me.btnSiguienteCliente.Location = New System.Drawing.Point(220, 17)
        Me.btnSiguienteCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguienteCliente.Name = "btnSiguienteCliente"
        Me.btnSiguienteCliente.Size = New System.Drawing.Size(56, 49)
        Me.btnSiguienteCliente.TabIndex = 2
        Me.btnSiguienteCliente.UseVisualStyleBackColor = False
        '
        'btnAnteriorCliente
        '
        Me.btnAnteriorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnteriorCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCliente.Image = Global.calculadora.My.Resources.Resources.iconfinder_left_fill_3017916
        Me.btnAnteriorCliente.Location = New System.Drawing.Point(65, 17)
        Me.btnAnteriorCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnteriorCliente.Name = "btnAnteriorCliente"
        Me.btnAnteriorCliente.Size = New System.Drawing.Size(56, 49)
        Me.btnAnteriorCliente.TabIndex = 1
        Me.btnAnteriorCliente.UseVisualStyleBackColor = False
        '
        'btnPrimeroCliente
        '
        Me.btnPrimeroCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrimeroCliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCliente.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_previous_48px_3669228
        Me.btnPrimeroCliente.Location = New System.Drawing.Point(4, 17)
        Me.btnPrimeroCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrimeroCliente.Name = "btnPrimeroCliente"
        Me.btnPrimeroCliente.Size = New System.Drawing.Size(56, 49)
        Me.btnPrimeroCliente.TabIndex = 0
        Me.btnPrimeroCliente.UseVisualStyleBackColor = False
        '
        'frmcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(850, 631)
        Me.Controls.Add(Me.grbEdicionCliente)
        Me.Controls.Add(Me.grbNavegacionCliente)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmcliente"
        Me.Text = "Datos de clientes"
        Me.grbEdicionCliente.ResumeLayout(False)
        Me.grbNavegacionCliente.ResumeLayout(False)
        Me.grbNavegacionCliente.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicionCliente As GroupBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents grbNavegacionCliente As GroupBox
    Friend WithEvents lblRegistroCliente As Label
    Friend WithEvents btnUltimoCliente As Button
    Friend WithEvents btnSiguienteCliente As Button
    Friend WithEvents btnAnteriorCliente As Button
    Friend WithEvents btnPrimeroCliente As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents txtDireccionCliente As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents lblEmailCliente As Label
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents lblDireccionCliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblCodigoCliente As Label
End Class
