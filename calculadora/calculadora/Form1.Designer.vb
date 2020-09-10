<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblde = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.cbode = New System.Windows.Forms.ComboBox()
        Me.cboA = New System.Windows.Forms.ComboBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblde
        '
        Me.lblde.AutoSize = True
        Me.lblde.Location = New System.Drawing.Point(12, 75)
        Me.lblde.Name = "lblde"
        Me.lblde.Size = New System.Drawing.Size(24, 13)
        Me.lblde.TabIndex = 7
        Me.lblde.Text = "De:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(165, 23)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo"
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Monedas", "Longitud ", "Masa", "Almacenamiento", "Tiempo"})
        Me.cboTipo.Location = New System.Drawing.Point(199, 15)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 21)
        Me.cboTipo.TabIndex = 8
        '
        'cbode
        '
        Me.cbode.FormattingEnabled = True
        Me.cbode.Location = New System.Drawing.Point(42, 72)
        Me.cbode.Name = "cbode"
        Me.cbode.Size = New System.Drawing.Size(121, 21)
        Me.cbode.TabIndex = 9
        '
        'cboA
        '
        Me.cboA.FormattingEnabled = True
        Me.cboA.Location = New System.Drawing.Point(199, 72)
        Me.cboA.Name = "cboA"
        Me.cboA.Size = New System.Drawing.Size(121, 21)
        Me.cboA.TabIndex = 11
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(176, 78)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(17, 13)
        Me.lblA.TabIndex = 10
        Me.lblA.Text = "A:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(338, 78)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 12
        Me.lblCantidad.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(404, 75)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 13
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(297, 165)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(64, 13)
        Me.lblRespuesta.TabIndex = 14
        Me.lblRespuesta.Text = "Respuesta?"
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(87, 133)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(115, 77)
        Me.btnConvertir.TabIndex = 15
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 286)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.cboA)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.cbode)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.lblde)
        Me.Controls.Add(Me.lblTipo)
        Me.Name = "Form1"
        Me.Text = "Conversor de numeros decimales a Romanos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblde As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents cbode As ComboBox
    Friend WithEvents cboA As ComboBox
    Friend WithEvents lblA As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents btnConvertir As Button
End Class
