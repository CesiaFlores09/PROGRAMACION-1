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
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.btnCalculosE = New System.Windows.Forms.Button()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.lblVarianza = New System.Windows.Forms.Label()
        Me.LblResV = New System.Windows.Forms.Label()
        Me.lblDesviacionT = New System.Windows.Forms.Label()
        Me.lblResDesTipica = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(66, 58)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(253, 20)
        Me.txtSerie.TabIndex = 1
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(26, 61)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(34, 13)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Serie:"
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(143, 108)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuesta.TabIndex = 3
        Me.lblRespuesta.Text = "?"
        '
        'btnCalculosE
        '
        Me.btnCalculosE.Location = New System.Drawing.Point(66, 218)
        Me.btnCalculosE.Name = "btnCalculosE"
        Me.btnCalculosE.Size = New System.Drawing.Size(124, 39)
        Me.btnCalculosE.TabIndex = 4
        Me.btnCalculosE.Text = "Calculos Estadisticos"
        Me.btnCalculosE.UseVisualStyleBackColor = True
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(26, 108)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(39, 13)
        Me.lblMedia.TabIndex = 5
        Me.lblMedia.Text = "Media:"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(26, 138)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblVarianza.TabIndex = 6
        Me.lblVarianza.Text = "Varianza:"
        '
        'LblResV
        '
        Me.LblResV.AutoSize = True
        Me.LblResV.Location = New System.Drawing.Point(143, 138)
        Me.LblResV.Name = "LblResV"
        Me.LblResV.Size = New System.Drawing.Size(13, 13)
        Me.LblResV.TabIndex = 7
        Me.LblResV.Text = "?"
        '
        'lblDesviacionT
        '
        Me.lblDesviacionT.AutoSize = True
        Me.lblDesviacionT.Location = New System.Drawing.Point(29, 172)
        Me.lblDesviacionT.Name = "lblDesviacionT"
        Me.lblDesviacionT.Size = New System.Drawing.Size(95, 13)
        Me.lblDesviacionT.TabIndex = 8
        Me.lblDesviacionT.Text = "Desviacion Tipica:"
        '
        'lblResDesTipica
        '
        Me.lblResDesTipica.AutoSize = True
        Me.lblResDesTipica.Location = New System.Drawing.Point(143, 172)
        Me.lblResDesTipica.Name = "lblResDesTipica"
        Me.lblResDesTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblResDesTipica.TabIndex = 9
        Me.lblResDesTipica.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 347)
        Me.Controls.Add(Me.lblResDesTipica)
        Me.Controls.Add(Me.lblDesviacionT)
        Me.Controls.Add(Me.LblResV)
        Me.Controls.Add(Me.lblVarianza)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.btnCalculosE)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.txtSerie)
        Me.Name = "Form1"
        Me.Text = "Matrices Y POO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents lblSerie As Label
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents btnCalculosE As Button
    Friend WithEvents lblMedia As Label
    Friend WithEvents lblVarianza As Label
    Friend WithEvents LblResV As Label
    Friend WithEvents lblDesviacionT As Label
    Friend WithEvents lblResDesTipica As Label
End Class
