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
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.lblTiempoenA = New System.Windows.Forms.Label()
        Me.lblInteresS = New System.Windows.Forms.Label()
        Me.lblInteresC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(21, 24)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(39, 13)
        Me.lblCapital.TabIndex = 0
        Me.lblCapital.Text = "Capital"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(81, 21)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(171, 161)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(106, 45)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(244, 25)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(76, 20)
        Me.txtInteres.TabIndex = 4
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Location = New System.Drawing.Point(199, 28)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(39, 13)
        Me.lblInteres.TabIndex = 3
        Me.lblInteres.Text = "Interes"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(419, 29)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(76, 20)
        Me.txtTiempo.TabIndex = 6
        '
        'lblTiempoenA
        '
        Me.lblTiempoenA.AutoSize = True
        Me.lblTiempoenA.Location = New System.Drawing.Point(338, 32)
        Me.lblTiempoenA.Name = "lblTiempoenA"
        Me.lblTiempoenA.Size = New System.Drawing.Size(75, 13)
        Me.lblTiempoenA.TabIndex = 5
        Me.lblTiempoenA.Text = "Tiempo (Años)"
        '
        'lblInteresS
        '
        Me.lblInteresS.AutoSize = True
        Me.lblInteresS.Location = New System.Drawing.Point(52, 110)
        Me.lblInteresS.Name = "lblInteresS"
        Me.lblInteresS.Size = New System.Drawing.Size(79, 13)
        Me.lblInteresS.TabIndex = 7
        Me.lblInteresS.Text = "Interes Simple?"
        '
        'lblInteresC
        '
        Me.lblInteresC.AutoSize = True
        Me.lblInteresC.Location = New System.Drawing.Point(312, 110)
        Me.lblInteresC.Name = "lblInteresC"
        Me.lblInteresC.Size = New System.Drawing.Size(101, 13)
        Me.lblInteresC.TabIndex = 8
        Me.lblInteresC.Text = "Interes Compuesto?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 218)
        Me.Controls.Add(Me.lblInteresC)
        Me.Controls.Add(Me.lblInteresS)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.lblTiempoenA)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.lblCapital)
        Me.Name = "Form1"
        Me.Text = "Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCapital As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents lblInteres As Label
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents lblTiempoenA As Label
    Friend WithEvents lblInteresS As Label
    Friend WithEvents lblInteresC As Label
End Class
