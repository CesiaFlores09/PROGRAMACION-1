<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarcategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarcategorias))
        Me.btnCancelarCateforia = New System.Windows.Forms.Button()
        Me.btnSeleccionarCategoria = New System.Windows.Forms.Button()
        Me.txtBuscarctegoria = New System.Windows.Forms.TextBox()
        Me.lblBuscarCategoria = New System.Windows.Forms.Label()
        Me.grbBuscarCategoria = New System.Windows.Forms.DataGridView()
        Me.idcategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grbBuscarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarCateforia
        '
        Me.btnCancelarCateforia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarCateforia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancelarCateforia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCateforia.Image = Global.calculadora.My.Resources.Resources.iconfinder_cancel_2467375
        Me.btnCancelarCateforia.Location = New System.Drawing.Point(213, 460)
        Me.btnCancelarCateforia.Name = "btnCancelarCateforia"
        Me.btnCancelarCateforia.Size = New System.Drawing.Size(80, 43)
        Me.btnCancelarCateforia.TabIndex = 22
        Me.btnCancelarCateforia.UseVisualStyleBackColor = False
        '
        'btnSeleccionarCategoria
        '
        Me.btnSeleccionarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSeleccionarCategoria.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCategoria.Image = Global.calculadora.My.Resources.Resources.iconfinder_cursor_309088__1_
        Me.btnSeleccionarCategoria.Location = New System.Drawing.Point(104, 460)
        Me.btnSeleccionarCategoria.Name = "btnSeleccionarCategoria"
        Me.btnSeleccionarCategoria.Size = New System.Drawing.Size(76, 43)
        Me.btnSeleccionarCategoria.TabIndex = 21
        Me.btnSeleccionarCategoria.UseVisualStyleBackColor = False
        '
        'txtBuscarctegoria
        '
        Me.txtBuscarctegoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarctegoria.Location = New System.Drawing.Point(104, 30)
        Me.txtBuscarctegoria.Name = "txtBuscarctegoria"
        Me.txtBuscarctegoria.Size = New System.Drawing.Size(507, 20)
        Me.txtBuscarctegoria.TabIndex = 20
        '
        'lblBuscarCategoria
        '
        Me.lblBuscarCategoria.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarCategoria.Image = Global.calculadora.My.Resources.Resources.iconfinder_User_Interface_25_2044263
        Me.lblBuscarCategoria.Location = New System.Drawing.Point(43, 9)
        Me.lblBuscarCategoria.Name = "lblBuscarCategoria"
        Me.lblBuscarCategoria.Size = New System.Drawing.Size(55, 58)
        Me.lblBuscarCategoria.TabIndex = 19
        '
        'grbBuscarCategoria
        '
        Me.grbBuscarCategoria.AllowUserToAddRows = False
        Me.grbBuscarCategoria.AllowUserToDeleteRows = False
        Me.grbBuscarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbBuscarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscarCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcategoria, Me.categoria})
        Me.grbBuscarCategoria.Location = New System.Drawing.Point(104, 72)
        Me.grbBuscarCategoria.Name = "grbBuscarCategoria"
        Me.grbBuscarCategoria.ReadOnly = True
        Me.grbBuscarCategoria.RowHeadersWidth = 51
        Me.grbBuscarCategoria.Size = New System.Drawing.Size(507, 356)
        Me.grbBuscarCategoria.TabIndex = 18
        '
        'idcategoria
        '
        Me.idcategoria.DataPropertyName = "idcategoria"
        Me.idcategoria.FillWeight = 250.0!
        Me.idcategoria.HeaderText = "ID"
        Me.idcategoria.MinimumWidth = 6
        Me.idcategoria.Name = "idcategoria"
        Me.idcategoria.ReadOnly = True
        Me.idcategoria.Visible = False
        Me.idcategoria.Width = 450
        '
        'categoria
        '
        Me.categoria.DataPropertyName = "categoria"
        Me.categoria.FillWeight = 250.0!
        Me.categoria.HeaderText = "CATEGORIA"
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Width = 450
        '
        'frmBuscarcategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 521)
        Me.Controls.Add(Me.btnCancelarCateforia)
        Me.Controls.Add(Me.btnSeleccionarCategoria)
        Me.Controls.Add(Me.txtBuscarctegoria)
        Me.Controls.Add(Me.lblBuscarCategoria)
        Me.Controls.Add(Me.grbBuscarCategoria)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscarcategorias"
        Me.Text = "Busqueda de Categorias"
        CType(Me.grbBuscarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarCateforia As Button
    Friend WithEvents btnSeleccionarCategoria As Button
    Friend WithEvents txtBuscarctegoria As TextBox
    Friend WithEvents lblBuscarCategoria As Label
    Friend WithEvents grbBuscarCategoria As DataGridView
    Friend WithEvents idcategoria As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
End Class
