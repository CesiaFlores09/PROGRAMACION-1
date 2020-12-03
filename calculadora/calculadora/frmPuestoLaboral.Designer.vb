<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuestoLaboral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPuestoLaboral))
        Me.grbDatosPuesto = New System.Windows.Forms.GroupBox()
        Me.txtpuestoLaboral = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbNavegacionPuesto = New System.Windows.Forms.GroupBox()
        Me.lblRegistroPuesto = New System.Windows.Forms.Label()
        Me.grbEdicionPuesto = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPuesto = New System.Windows.Forms.Button()
        Me.btnEliminarPuesto = New System.Windows.Forms.Button()
        Me.btnModificarPuesto = New System.Windows.Forms.Button()
        Me.btnAgregarPuesto = New System.Windows.Forms.Button()
        Me.btnUltimoPuesto = New System.Windows.Forms.Button()
        Me.btnSiguientePuesto = New System.Windows.Forms.Button()
        Me.btnAnteriorCategoria = New System.Windows.Forms.Button()
        Me.btnPrimeroPuesto = New System.Windows.Forms.Button()
        Me.grbDatosPuesto.SuspendLayout()
        Me.grbNavegacionPuesto.SuspendLayout()
        Me.grbEdicionPuesto.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatosPuesto
        '
        Me.grbDatosPuesto.Controls.Add(Me.txtpuestoLaboral)
        Me.grbDatosPuesto.Controls.Add(Me.Label1)
        Me.grbDatosPuesto.Enabled = False
        Me.grbDatosPuesto.Location = New System.Drawing.Point(25, 31)
        Me.grbDatosPuesto.Name = "grbDatosPuesto"
        Me.grbDatosPuesto.Size = New System.Drawing.Size(734, 100)
        Me.grbDatosPuesto.TabIndex = 19
        Me.grbDatosPuesto.TabStop = False
        Me.grbDatosPuesto.Text = "Datos Puesto Laboral"
        '
        'txtpuestoLaboral
        '
        Me.txtpuestoLaboral.Location = New System.Drawing.Point(166, 39)
        Me.txtpuestoLaboral.Name = "txtpuestoLaboral"
        Me.txtpuestoLaboral.Size = New System.Drawing.Size(326, 20)
        Me.txtpuestoLaboral.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "PUESTO LABORAL:"
        '
        'grbNavegacionPuesto
        '
        Me.grbNavegacionPuesto.Controls.Add(Me.lblRegistroPuesto)
        Me.grbNavegacionPuesto.Controls.Add(Me.btnUltimoPuesto)
        Me.grbNavegacionPuesto.Controls.Add(Me.btnSiguientePuesto)
        Me.grbNavegacionPuesto.Controls.Add(Me.btnAnteriorCategoria)
        Me.grbNavegacionPuesto.Controls.Add(Me.btnPrimeroPuesto)
        Me.grbNavegacionPuesto.Location = New System.Drawing.Point(25, 173)
        Me.grbNavegacionPuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionPuesto.Name = "grbNavegacionPuesto"
        Me.grbNavegacionPuesto.Padding = New System.Windows.Forms.Padding(2)
        Me.grbNavegacionPuesto.Size = New System.Drawing.Size(316, 81)
        Me.grbNavegacionPuesto.TabIndex = 20
        Me.grbNavegacionPuesto.TabStop = False
        Me.grbNavegacionPuesto.Text = " Navegacion"
        '
        'lblRegistroPuesto
        '
        Me.lblRegistroPuesto.AutoSize = True
        Me.lblRegistroPuesto.Location = New System.Drawing.Point(134, 51)
        Me.lblRegistroPuesto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegistroPuesto.Name = "lblRegistroPuesto"
        Me.lblRegistroPuesto.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroPuesto.TabIndex = 4
        Me.lblRegistroPuesto.Text = "x de n"
        '
        'grbEdicionPuesto
        '
        Me.grbEdicionPuesto.Controls.Add(Me.btnBuscarPuesto)
        Me.grbEdicionPuesto.Controls.Add(Me.btnEliminarPuesto)
        Me.grbEdicionPuesto.Controls.Add(Me.btnModificarPuesto)
        Me.grbEdicionPuesto.Controls.Add(Me.btnAgregarPuesto)
        Me.grbEdicionPuesto.Location = New System.Drawing.Point(356, 173)
        Me.grbEdicionPuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.grbEdicionPuesto.Name = "grbEdicionPuesto"
        Me.grbEdicionPuesto.Padding = New System.Windows.Forms.Padding(2)
        Me.grbEdicionPuesto.Size = New System.Drawing.Size(407, 81)
        Me.grbEdicionPuesto.TabIndex = 21
        Me.grbEdicionPuesto.TabStop = False
        Me.grbEdicionPuesto.Text = "Edicion"
        '
        'btnBuscarPuesto
        '
        Me.btnBuscarPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscarPuesto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPuesto.Location = New System.Drawing.Point(320, 17)
        Me.btnBuscarPuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarPuesto.Name = "btnBuscarPuesto"
        Me.btnBuscarPuesto.Size = New System.Drawing.Size(83, 49)
        Me.btnBuscarPuesto.TabIndex = 4
        Me.btnBuscarPuesto.Text = "Buscar"
        Me.btnBuscarPuesto.UseVisualStyleBackColor = False
        '
        'btnEliminarPuesto
        '
        Me.btnEliminarPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminarPuesto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPuesto.Location = New System.Drawing.Point(223, 18)
        Me.btnEliminarPuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarPuesto.Name = "btnEliminarPuesto"
        Me.btnEliminarPuesto.Size = New System.Drawing.Size(93, 48)
        Me.btnEliminarPuesto.TabIndex = 3
        Me.btnEliminarPuesto.Text = "Eliminar"
        Me.btnEliminarPuesto.UseVisualStyleBackColor = False
        '
        'btnModificarPuesto
        '
        Me.btnModificarPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarPuesto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPuesto.Location = New System.Drawing.Point(110, 17)
        Me.btnModificarPuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarPuesto.Name = "btnModificarPuesto"
        Me.btnModificarPuesto.Size = New System.Drawing.Size(109, 48)
        Me.btnModificarPuesto.TabIndex = 2
        Me.btnModificarPuesto.Text = "Modificar"
        Me.btnModificarPuesto.UseVisualStyleBackColor = False
        '
        'btnAgregarPuesto
        '
        Me.btnAgregarPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarPuesto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPuesto.Location = New System.Drawing.Point(11, 17)
        Me.btnAgregarPuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarPuesto.Name = "btnAgregarPuesto"
        Me.btnAgregarPuesto.Size = New System.Drawing.Size(95, 48)
        Me.btnAgregarPuesto.TabIndex = 1
        Me.btnAgregarPuesto.Text = "Nuevo"
        Me.btnAgregarPuesto.UseVisualStyleBackColor = False
        '
        'btnUltimoPuesto
        '
        Me.btnUltimoPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUltimoPuesto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoPuesto.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_next_48px_3669229
        Me.btnUltimoPuesto.Location = New System.Drawing.Point(253, 17)
        Me.btnUltimoPuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUltimoPuesto.Name = "btnUltimoPuesto"
        Me.btnUltimoPuesto.Size = New System.Drawing.Size(56, 49)
        Me.btnUltimoPuesto.TabIndex = 3
        Me.btnUltimoPuesto.UseVisualStyleBackColor = False
        '
        'btnSiguientePuesto
        '
        Me.btnSiguientePuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSiguientePuesto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientePuesto.Image = Global.calculadora.My.Resources.Resources.iconfinder_next_right_arrow_botton_2203522
        Me.btnSiguientePuesto.Location = New System.Drawing.Point(183, 18)
        Me.btnSiguientePuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguientePuesto.Name = "btnSiguientePuesto"
        Me.btnSiguientePuesto.Size = New System.Drawing.Size(56, 49)
        Me.btnSiguientePuesto.TabIndex = 2
        Me.btnSiguientePuesto.Text = ">"
        Me.btnSiguientePuesto.UseVisualStyleBackColor = False
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
        Me.btnAnteriorCategoria.UseVisualStyleBackColor = False
        '
        'btnPrimeroPuesto
        '
        Me.btnPrimeroPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrimeroPuesto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroPuesto.Image = Global.calculadora.My.Resources.Resources.iconfinder_ic_skip_previous_48px_3669228
        Me.btnPrimeroPuesto.Location = New System.Drawing.Point(4, 17)
        Me.btnPrimeroPuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrimeroPuesto.Name = "btnPrimeroPuesto"
        Me.btnPrimeroPuesto.Size = New System.Drawing.Size(56, 49)
        Me.btnPrimeroPuesto.TabIndex = 0
        Me.btnPrimeroPuesto.UseVisualStyleBackColor = False
        '
        'frmPuestoLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 262)
        Me.Controls.Add(Me.grbEdicionPuesto)
        Me.Controls.Add(Me.grbNavegacionPuesto)
        Me.Controls.Add(Me.grbDatosPuesto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPuestoLaboral"
        Me.Text = "Registro de Puesto Laboral"
        Me.grbDatosPuesto.ResumeLayout(False)
        Me.grbDatosPuesto.PerformLayout()
        Me.grbNavegacionPuesto.ResumeLayout(False)
        Me.grbNavegacionPuesto.PerformLayout()
        Me.grbEdicionPuesto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatosPuesto As GroupBox
    Friend WithEvents txtpuestoLaboral As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grbNavegacionPuesto As GroupBox
    Friend WithEvents lblRegistroPuesto As Label
    Friend WithEvents btnUltimoPuesto As Button
    Friend WithEvents btnSiguientePuesto As Button
    Friend WithEvents btnAnteriorCategoria As Button
    Friend WithEvents btnPrimeroPuesto As Button
    Friend WithEvents grbEdicionPuesto As GroupBox
    Friend WithEvents btnBuscarPuesto As Button
    Friend WithEvents btnEliminarPuesto As Button
    Friend WithEvents btnModificarPuesto As Button
    Friend WithEvents btnAgregarPuesto As Button
End Class
