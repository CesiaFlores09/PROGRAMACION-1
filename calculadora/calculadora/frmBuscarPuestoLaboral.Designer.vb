<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPuestoLaboral
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
        Me.txtBuscarPuesto = New System.Windows.Forms.TextBox()
        Me.lblBuscarPuesto = New System.Windows.Forms.Label()
        Me.grbBuscarPuesto = New System.Windows.Forms.DataGridView()
        Me.idpuestolaboral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelarPuesto = New System.Windows.Forms.Button()
        Me.btnSeleccionarPuesto = New System.Windows.Forms.Button()
        CType(Me.grbBuscarPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarPuesto
        '
        Me.txtBuscarPuesto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPuesto.Location = New System.Drawing.Point(151, 42)
        Me.txtBuscarPuesto.Name = "txtBuscarPuesto"
        Me.txtBuscarPuesto.Size = New System.Drawing.Size(507, 20)
        Me.txtBuscarPuesto.TabIndex = 23
        '
        'lblBuscarPuesto
        '
        Me.lblBuscarPuesto.AutoSize = True
        Me.lblBuscarPuesto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarPuesto.Location = New System.Drawing.Point(78, 41)
        Me.lblBuscarPuesto.Name = "lblBuscarPuesto"
        Me.lblBuscarPuesto.Size = New System.Drawing.Size(55, 16)
        Me.lblBuscarPuesto.TabIndex = 22
        Me.lblBuscarPuesto.Text = "Buscar:"
        '
        'grbBuscarPuesto
        '
        Me.grbBuscarPuesto.AllowUserToAddRows = False
        Me.grbBuscarPuesto.AllowUserToDeleteRows = False
        Me.grbBuscarPuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbBuscarPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscarPuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idpuestolaboral, Me.puesto})
        Me.grbBuscarPuesto.Location = New System.Drawing.Point(151, 82)
        Me.grbBuscarPuesto.Name = "grbBuscarPuesto"
        Me.grbBuscarPuesto.ReadOnly = True
        Me.grbBuscarPuesto.RowHeadersWidth = 51
        Me.grbBuscarPuesto.Size = New System.Drawing.Size(507, 284)
        Me.grbBuscarPuesto.TabIndex = 21
        '
        'idpuestolaboral
        '
        Me.idpuestolaboral.DataPropertyName = "idpuestolaboral"
        Me.idpuestolaboral.FillWeight = 250.0!
        Me.idpuestolaboral.HeaderText = "ID"
        Me.idpuestolaboral.MinimumWidth = 6
        Me.idpuestolaboral.Name = "idpuestolaboral"
        Me.idpuestolaboral.ReadOnly = True
        Me.idpuestolaboral.Visible = False
        Me.idpuestolaboral.Width = 450
        '
        'puesto
        '
        Me.puesto.DataPropertyName = "puesto"
        Me.puesto.FillWeight = 250.0!
        Me.puesto.HeaderText = "PUESTO"
        Me.puesto.Name = "puesto"
        Me.puesto.ReadOnly = True
        Me.puesto.Width = 450
        '
        'btnCancelarPuesto
        '
        Me.btnCancelarPuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancelarPuesto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarPuesto.Location = New System.Drawing.Point(425, 399)
        Me.btnCancelarPuesto.Name = "btnCancelarPuesto"
        Me.btnCancelarPuesto.Size = New System.Drawing.Size(196, 28)
        Me.btnCancelarPuesto.TabIndex = 25
        Me.btnCancelarPuesto.Text = "Cancelar"
        Me.btnCancelarPuesto.UseVisualStyleBackColor = False
        '
        'btnSeleccionarPuesto
        '
        Me.btnSeleccionarPuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSeleccionarPuesto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarPuesto.Location = New System.Drawing.Point(151, 399)
        Me.btnSeleccionarPuesto.Name = "btnSeleccionarPuesto"
        Me.btnSeleccionarPuesto.Size = New System.Drawing.Size(196, 24)
        Me.btnSeleccionarPuesto.TabIndex = 24
        Me.btnSeleccionarPuesto.Text = "Seleccionar Puesto"
        Me.btnSeleccionarPuesto.UseVisualStyleBackColor = False
        '
        'frmBuscarPuestoLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarPuesto)
        Me.Controls.Add(Me.btnSeleccionarPuesto)
        Me.Controls.Add(Me.txtBuscarPuesto)
        Me.Controls.Add(Me.lblBuscarPuesto)
        Me.Controls.Add(Me.grbBuscarPuesto)
        Me.Name = "frmBuscarPuestoLaboral"
        Me.Text = "Busqueda de Puesto Laboral"
        CType(Me.grbBuscarPuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarPuesto As TextBox
    Friend WithEvents lblBuscarPuesto As Label
    Friend WithEvents grbBuscarPuesto As DataGridView
    Friend WithEvents idpuestolaboral As DataGridViewTextBoxColumn
    Friend WithEvents puesto As DataGridViewTextBoxColumn
    Friend WithEvents btnCancelarPuesto As Button
    Friend WithEvents btnSeleccionarPuesto As Button
End Class
