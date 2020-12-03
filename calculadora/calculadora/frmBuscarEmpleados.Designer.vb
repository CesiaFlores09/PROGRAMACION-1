<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEmpleados
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
        Me.txtBuscarEmpleados = New System.Windows.Forms.TextBox()
        Me.grbBuscar = New System.Windows.Forms.DataGridView()
        Me.idempleados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpuestolaboral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.lblBuscarEnpleados = New System.Windows.Forms.Label()
        CType(Me.grbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarEmpleados
        '
        Me.txtBuscarEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarEmpleados.Location = New System.Drawing.Point(70, 21)
        Me.txtBuscarEmpleados.Name = "txtBuscarEmpleados"
        Me.txtBuscarEmpleados.Size = New System.Drawing.Size(646, 20)
        Me.txtBuscarEmpleados.TabIndex = 5
        '
        'grbBuscar
        '
        Me.grbBuscar.AllowUserToAddRows = False
        Me.grbBuscar.AllowUserToDeleteRows = False
        Me.grbBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idempleados, Me.idpuestolaboral, Me.puesto, Me.codigo, Me.nombre, Me.direccion, Me.telefono, Me.email})
        Me.grbBuscar.Location = New System.Drawing.Point(24, 75)
        Me.grbBuscar.Name = "grbBuscar"
        Me.grbBuscar.ReadOnly = True
        Me.grbBuscar.Size = New System.Drawing.Size(692, 278)
        Me.grbBuscar.TabIndex = 9
        '
        'idempleados
        '
        Me.idempleados.DataPropertyName = "idempleados"
        Me.idempleados.HeaderText = "ID"
        Me.idempleados.Name = "idempleados"
        Me.idempleados.ReadOnly = True
        Me.idempleados.Visible = False
        '
        'idpuestolaboral
        '
        Me.idpuestolaboral.DataPropertyName = "idpuestolaboral"
        Me.idpuestolaboral.HeaderText = "IDPUESTOLABORAL"
        Me.idpuestolaboral.Name = "idpuestolaboral"
        Me.idpuestolaboral.ReadOnly = True
        Me.idpuestolaboral.Visible = False
        Me.idpuestolaboral.Width = 125
        '
        'puesto
        '
        Me.puesto.DataPropertyName = "puesto"
        Me.puesto.HeaderText = "PUESTO LABORAL"
        Me.puesto.Name = "puesto"
        Me.puesto.ReadOnly = True
        Me.puesto.Width = 150
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
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.calculadora.My.Resources.Resources.iconfinder_cancel_2467375
        Me.btnCancelar.Location = New System.Drawing.Point(180, 370)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 48)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSeleccionar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Image = Global.calculadora.My.Resources.Resources.iconfinder_cursor_309088__1_
        Me.btnSeleccionar.Location = New System.Drawing.Point(24, 370)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(77, 48)
        Me.btnSeleccionar.TabIndex = 6
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'lblBuscarEnpleados
        '
        Me.lblBuscarEnpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuscarEnpleados.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarEnpleados.Image = Global.calculadora.My.Resources.Resources.iconfinder_User_Interface_25_2044263
        Me.lblBuscarEnpleados.Location = New System.Drawing.Point(21, 9)
        Me.lblBuscarEnpleados.Name = "lblBuscarEnpleados"
        Me.lblBuscarEnpleados.Size = New System.Drawing.Size(67, 45)
        Me.lblBuscarEnpleados.TabIndex = 4
        '
        'frmBuscarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(822, 504)
        Me.Controls.Add(Me.grbBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.txtBuscarEmpleados)
        Me.Controls.Add(Me.lblBuscarEnpleados)
        Me.Name = "frmBuscarEmpleados"
        Me.Text = "Busqueda de Empleados"
        CType(Me.grbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarEmpleados As TextBox
    Friend WithEvents lblBuscarEnpleados As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents grbBuscar As DataGridView
    Friend WithEvents idempleados As DataGridViewTextBoxColumn
    Friend WithEvents idpuestolaboral As DataGridViewTextBoxColumn
    Friend WithEvents puesto As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class
