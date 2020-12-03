<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarUsuarios))
        Me.btnCancelarUsuario = New System.Windows.Forms.Button()
        Me.btnSeleccionarUsuario = New System.Windows.Forms.Button()
        Me.grdBuscarUsuario = New System.Windows.Forms.DataGridView()
        Me.idusuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.privilegio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.lblBuscarUsuario = New System.Windows.Forms.Label()
        CType(Me.grdBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarUsuario
        '
        Me.btnCancelarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancelarUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarUsuario.Image = Global.calculadora.My.Resources.Resources.iconfinder_cancel_2467375
        Me.btnCancelarUsuario.Location = New System.Drawing.Point(116, 395)
        Me.btnCancelarUsuario.Name = "btnCancelarUsuario"
        Me.btnCancelarUsuario.Size = New System.Drawing.Size(90, 47)
        Me.btnCancelarUsuario.TabIndex = 0
        Me.btnCancelarUsuario.UseVisualStyleBackColor = False
        '
        'btnSeleccionarUsuario
        '
        Me.btnSeleccionarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSeleccionarUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarUsuario.Image = Global.calculadora.My.Resources.Resources.iconfinder_cursor_309088__1_
        Me.btnSeleccionarUsuario.Location = New System.Drawing.Point(29, 395)
        Me.btnSeleccionarUsuario.Name = "btnSeleccionarUsuario"
        Me.btnSeleccionarUsuario.Size = New System.Drawing.Size(81, 47)
        Me.btnSeleccionarUsuario.TabIndex = 1
        Me.btnSeleccionarUsuario.UseVisualStyleBackColor = False
        '
        'grdBuscarUsuario
        '
        Me.grdBuscarUsuario.AllowUserToAddRows = False
        Me.grdBuscarUsuario.AllowUserToDeleteRows = False
        Me.grdBuscarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idusuario, Me.nombres, Me.apellidos, Me.clave, Me.email, Me.direccion, Me.telefono, Me.privilegio})
        Me.grdBuscarUsuario.Location = New System.Drawing.Point(29, 83)
        Me.grdBuscarUsuario.Name = "grdBuscarUsuario"
        Me.grdBuscarUsuario.ReadOnly = True
        Me.grdBuscarUsuario.Size = New System.Drawing.Size(744, 289)
        Me.grdBuscarUsuario.TabIndex = 2
        '
        'idusuario
        '
        Me.idusuario.DataPropertyName = "idusuario"
        Me.idusuario.HeaderText = "ID"
        Me.idusuario.Name = "idusuario"
        Me.idusuario.ReadOnly = True
        Me.idusuario.Visible = False
        '
        'nombres
        '
        Me.nombres.DataPropertyName = "nombres"
        Me.nombres.HeaderText = "NOMBRES"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "apellidos"
        Me.apellidos.HeaderText = "APELLIDOS"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        '
        'clave
        '
        Me.clave.DataPropertyName = "clave"
        Me.clave.HeaderText = "CLAVE"
        Me.clave.Name = "clave"
        Me.clave.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
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
        '
        'privilegio
        '
        Me.privilegio.DataPropertyName = "privilegio"
        Me.privilegio.HeaderText = "PRIVILEGIO"
        Me.privilegio.Name = "privilegio"
        Me.privilegio.ReadOnly = True
        '
        'txtBuscarUsuario
        '
        Me.txtBuscarUsuario.Location = New System.Drawing.Point(93, 27)
        Me.txtBuscarUsuario.Name = "txtBuscarUsuario"
        Me.txtBuscarUsuario.Size = New System.Drawing.Size(680, 20)
        Me.txtBuscarUsuario.TabIndex = 3
        '
        'lblBuscarUsuario
        '
        Me.lblBuscarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarUsuario.Image = Global.calculadora.My.Resources.Resources.iconfinder_User_Interface_25_2044263
        Me.lblBuscarUsuario.Location = New System.Drawing.Point(26, 9)
        Me.lblBuscarUsuario.Name = "lblBuscarUsuario"
        Me.lblBuscarUsuario.Size = New System.Drawing.Size(61, 55)
        Me.lblBuscarUsuario.TabIndex = 4
        '
        'frmBuscarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(837, 450)
        Me.Controls.Add(Me.lblBuscarUsuario)
        Me.Controls.Add(Me.txtBuscarUsuario)
        Me.Controls.Add(Me.grdBuscarUsuario)
        Me.Controls.Add(Me.btnSeleccionarUsuario)
        Me.Controls.Add(Me.btnCancelarUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscarUsuarios"
        Me.Text = "Busqueda de registro de usuarios"
        CType(Me.grdBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarUsuario As Button
    Friend WithEvents btnSeleccionarUsuario As Button
    Friend WithEvents grdBuscarUsuario As DataGridView
    Friend WithEvents txtBuscarUsuario As TextBox
    Friend WithEvents lblBuscarUsuario As Label
    Friend WithEvents idusuario As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents clave As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents privilegio As DataGridViewTextBoxColumn
End Class
