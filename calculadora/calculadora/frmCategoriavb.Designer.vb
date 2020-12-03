<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoriavb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoriavb))
        Me.grbEdicionCategoria = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCategoria = New System.Windows.Forms.Button()
        Me.btnEliminarCategoria = New System.Windows.Forms.Button()
        Me.btnModificarCategoria = New System.Windows.Forms.Button()
        Me.btnAgregarCategoria = New System.Windows.Forms.Button()
        Me.grbNavegacionCategoria = New System.Windows.Forms.GroupBox()
        Me.lblRegistroCategoria = New System.Windows.Forms.Label()
        Me.btnUltimoCategoria = New System.Windows.Forms.Button()
        Me.btnSiguienteCategoria = New System.Windows.Forms.Button()
        Me.btnAnteriorCategoria = New System.Windows.Forms.Button()
        Me.btnPrimeroCategoria = New System.Windows.Forms.Button()
        Me.grbDatosCategorias = New System.Windows.Forms.GroupBox()
        Me.txtCate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbEdicionCategoria.SuspendLayout()
        Me.grbNavegacionCategoria.SuspendLayout()
        Me.grbDatosCategorias.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicionCategoria
        '
        Me.grbEdicionCategoria.Controls.Add(Me.btnBuscarCategoria)
        Me.grbEdicionCategoria.Controls.Add(Me.btnEliminarCategoria)
        Me.grbEdicionCategoria.Controls.Add(Me.btnModificarCategoria)
        Me.grbEdicionCategoria.Controls.Add(Me.btnAgregarCategoria)
        Me.grbEdicionCategoria.Location = New System.Drawing.Point(370, 185)
        Me.grbEdicionCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.grbEdicionCategoria.Name = "grbEdicionCategoria"
        Me.grbEdicionCategoria.Padding = New System.Windows.Forms.Padding(2)
        Me.grbEdicionCategoria.Size = New System.Drawing.Size(407, 81)
        Me.grbEdicionCategoria.TabIndex = 17
        Me.grbEdicionCategoria.TabStop = False
        Me.grbEdicionCategoria.Text = "Edicion"
        '
        'btnBuscarCategoria
        '
        Me.btnBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscarCategoria.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCategoria.Location = New System.Drawing.Point(320, 17)
        Me.btnBuscarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCategoria.Name = "btnBuscarCategoria"
        Me.btnBuscarCategoria.Size = New System.Drawing.Size(83, 49)
        Me.btnBuscarCategoria.TabIndex = 4
        Me.btnBuscarCategoria.Text = "Buscar"
        Me.btnBuscarCategoria.UseVisualStyleBackColor = False
        '
        'btnEliminarCategoria
        '
        Me.btnEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminarCategoria.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCategoria.Location = New System.Drawing.Point(223, 18)
        Me.btnEliminarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarCategoria.Name = "btnEliminarCategoria"
        Me.btnEliminarCategoria.Size = New System.Drawing.Size(93, 48)
        Me.btnEliminarCategoria.TabIndex = 3
        Me.btnEliminarCategoria.Text = "Eliminar"
        Me.btnEliminarCategoria.UseVisualStyleBackColor = False
        '
        'btnModificarCategoria
        '
        Me.btnModificarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarCategoria.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCategoria.Location = New System.Drawing.Point(110, 17)
        Me.btnModificarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarCategoria.Name = "btnModificarCategoria"
        Me.btnModificarCategoria.Size = New System.Drawing.Size(109, 48)
        Me.btnModificarCategoria.TabIndex = 2
        Me.btnModificarCategoria.Text = "Modificar"
        Me.btnModificarCategoria.UseVisualStyleBackColor = False
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarCategoria.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(11, 17)
        Me.btnAgregarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(95, 48)
        Me.btnAgregarCategoria.TabIndex = 1
        Me.btnAgregarCategoria.Text = "Nuevo"
        Me.btnAgregarCategoria.UseVisualStyleBackColor = False
        '
        'grbNavegacionCategoria
        '
        Me.grbNavegacionCategoria.Controls.Add(Me.lblRegistroCategoria)
        Me.grbNavegacionCategoria.Controls.Add(Me.btnUltimoCategoria)
        Me.grbNavegacionCategoria.Controls.Add(Me.btnSiguienteCategoria)
        Me.grbNavegacionCategoria.Controls.Add(Me.btnAnteriorCategoria)
        Me.grbNavegacionCategoria.Controls.Add(Me.btnPrimeroCategoria)
        Me.grbNavegacionCategoria.Location = New System.Drawing.Point(24, 185)
        Me.grbNavegacionCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionCategoria.Name = "grbNavegacionCategoria"
        Me.grbNavegacionCategoria.Padding = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionCategoria.Size = New System.Drawing.Size(342, 81)
        Me.grbNavegacionCategoria.TabIndex = 16
        Me.grbNavegacionCategoria.TabStop = False
        Me.grbNavegacionCategoria.Text = " Navegacion"
        '
        'lblRegistroCategoria
        '
        Me.lblRegistroCategoria.AutoSize = True
        Me.lblRegistroCategoria.Location = New System.Drawing.Point(134, 51)
        Me.lblRegistroCategoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegistroCategoria.Name = "lblRegistroCategoria"
        Me.lblRegistroCategoria.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroCategoria.TabIndex = 4
        Me.lblRegistroCategoria.Text = "x de n"
        '
        'btnUltimoCategoria
        '
        Me.btnUltimoCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUltimoCategoria.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCategoria.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_next_48px_3669229
        Me.btnUltimoCategoria.Location = New System.Drawing.Point(281, 17)
        Me.btnUltimoCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUltimoCategoria.Name = "btnUltimoCategoria"
        Me.btnUltimoCategoria.Size = New System.Drawing.Size(56, 49)
        Me.btnUltimoCategoria.TabIndex = 3
        Me.btnUltimoCategoria.UseVisualStyleBackColor = False
        '
        'btnSiguienteCategoria
        '
        Me.btnSiguienteCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSiguienteCategoria.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCategoria.Image = Global.calculadora.My.Resources.Resources.iconfinder_next_right_arrow_botton_2203522
        Me.btnSiguienteCategoria.Location = New System.Drawing.Point(220, 17)
        Me.btnSiguienteCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguienteCategoria.Name = "btnSiguienteCategoria"
        Me.btnSiguienteCategoria.Size = New System.Drawing.Size(56, 49)
        Me.btnSiguienteCategoria.TabIndex = 2
        Me.btnSiguienteCategoria.Text = ">"
        Me.btnSiguienteCategoria.UseVisualStyleBackColor = False
        '
        'btnAnteriorCategoria
        '
        Me.btnAnteriorCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnteriorCategoria.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCategoria.Image = Global.calculadora.My.Resources.Resources.iconfinder_left_fill_3017916
        Me.btnAnteriorCategoria.Location = New System.Drawing.Point(65, 17)
        Me.btnAnteriorCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnteriorCategoria.Name = "btnAnteriorCategoria"
        Me.btnAnteriorCategoria.Size = New System.Drawing.Size(56, 49)
        Me.btnAnteriorCategoria.TabIndex = 1
        Me.btnAnteriorCategoria.Text = "<"
        Me.btnAnteriorCategoria.UseVisualStyleBackColor = False
        '
        'btnPrimeroCategoria
        '
        Me.btnPrimeroCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrimeroCategoria.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCategoria.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_previous_48px_3669228
        Me.btnPrimeroCategoria.Location = New System.Drawing.Point(4, 17)
        Me.btnPrimeroCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrimeroCategoria.Name = "btnPrimeroCategoria"
        Me.btnPrimeroCategoria.Size = New System.Drawing.Size(56, 49)
        Me.btnPrimeroCategoria.TabIndex = 0
        Me.btnPrimeroCategoria.UseVisualStyleBackColor = False
        '
        'grbDatosCategorias
        '
        Me.grbDatosCategorias.Controls.Add(Me.txtCate)
        Me.grbDatosCategorias.Controls.Add(Me.Label1)
        Me.grbDatosCategorias.Enabled = False
        Me.grbDatosCategorias.Location = New System.Drawing.Point(28, 12)
        Me.grbDatosCategorias.Name = "grbDatosCategorias"
        Me.grbDatosCategorias.Size = New System.Drawing.Size(589, 100)
        Me.grbDatosCategorias.TabIndex = 18
        Me.grbDatosCategorias.TabStop = False
        Me.grbDatosCategorias.Text = "Datos Categorias"
        '
        'txtCate
        '
        Me.txtCate.Location = New System.Drawing.Point(148, 39)
        Me.txtCate.Name = "txtCate"
        Me.txtCate.Size = New System.Drawing.Size(326, 20)
        Me.txtCate.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CATEGORIA:"
        '
        'frmCategoriavb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 274)
        Me.Controls.Add(Me.grbDatosCategorias)
        Me.Controls.Add(Me.grbEdicionCategoria)
        Me.Controls.Add(Me.grbNavegacionCategoria)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCategoriavb"
        Me.Text = "Registro de Categrias"
        Me.grbEdicionCategoria.ResumeLayout(False)
        Me.grbNavegacionCategoria.ResumeLayout(False)
        Me.grbNavegacionCategoria.PerformLayout()
        Me.grbDatosCategorias.ResumeLayout(False)
        Me.grbDatosCategorias.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbEdicionCategoria As GroupBox
    Friend WithEvents btnBuscarCategoria As Button
    Friend WithEvents btnEliminarCategoria As Button
    Friend WithEvents btnModificarCategoria As Button
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents grbNavegacionCategoria As GroupBox
    Friend WithEvents lblRegistroCategoria As Label
    Friend WithEvents btnUltimoCategoria As Button
    Friend WithEvents btnSiguienteCategoria As Button
    Friend WithEvents btnAnteriorCategoria As Button
    Friend WithEvents btnPrimeroCategoria As Button
    Friend WithEvents grbDatosCategorias As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCate As TextBox
End Class
