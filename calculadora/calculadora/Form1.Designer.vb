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
        Me.lblTotalf1 = New System.Windows.Forms.Label()
        Me.lblTotalx1xf1 = New System.Windows.Forms.Label()
        Me.lblTotalx21xf1 = New System.Windows.Forms.Label()
        Me.grdEstadistica = New System.Windows.Forms.DataGridView()
        Me.X1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X1xF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X21xF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblRespuesta.Location = New System.Drawing.Point(143, 104)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuesta.TabIndex = 3
        Me.lblRespuesta.Text = "?"
        '
        'btnCalculosE
        '
        Me.btnCalculosE.Location = New System.Drawing.Point(106, 382)
        Me.btnCalculosE.Name = "btnCalculosE"
        Me.btnCalculosE.Size = New System.Drawing.Size(124, 39)
        Me.btnCalculosE.TabIndex = 4
        Me.btnCalculosE.Text = "Calculos Estadisticos"
        Me.btnCalculosE.UseVisualStyleBackColor = True
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(26, 104)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(39, 13)
        Me.lblMedia.TabIndex = 5
        Me.lblMedia.Text = "Media:"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(26, 134)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblVarianza.TabIndex = 6
        Me.lblVarianza.Text = "Varianza:"
        '
        'LblResV
        '
        Me.LblResV.AutoSize = True
        Me.LblResV.Location = New System.Drawing.Point(143, 134)
        Me.LblResV.Name = "LblResV"
        Me.LblResV.Size = New System.Drawing.Size(13, 13)
        Me.LblResV.TabIndex = 7
        Me.LblResV.Text = "?"
        '
        'lblDesviacionT
        '
        Me.lblDesviacionT.AutoSize = True
        Me.lblDesviacionT.Location = New System.Drawing.Point(29, 168)
        Me.lblDesviacionT.Name = "lblDesviacionT"
        Me.lblDesviacionT.Size = New System.Drawing.Size(95, 13)
        Me.lblDesviacionT.TabIndex = 8
        Me.lblDesviacionT.Text = "Desviacion Tipica:"
        '
        'lblResDesTipica
        '
        Me.lblResDesTipica.AutoSize = True
        Me.lblResDesTipica.Location = New System.Drawing.Point(143, 168)
        Me.lblResDesTipica.Name = "lblResDesTipica"
        Me.lblResDesTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblResDesTipica.TabIndex = 9
        Me.lblResDesTipica.Text = "?"
        '
        'lblTotalf1
        '
        Me.lblTotalf1.AutoSize = True
        Me.lblTotalf1.Location = New System.Drawing.Point(516, 455)
        Me.lblTotalf1.Name = "lblTotalf1"
        Me.lblTotalf1.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalf1.TabIndex = 11
        Me.lblTotalf1.Text = "0.0"
        '
        'lblTotalx1xf1
        '
        Me.lblTotalx1xf1.AutoSize = True
        Me.lblTotalx1xf1.Location = New System.Drawing.Point(686, 455)
        Me.lblTotalx1xf1.Name = "lblTotalx1xf1"
        Me.lblTotalx1xf1.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalx1xf1.TabIndex = 12
        Me.lblTotalx1xf1.Text = "0.0"
        '
        'lblTotalx21xf1
        '
        Me.lblTotalx21xf1.AutoSize = True
        Me.lblTotalx21xf1.Location = New System.Drawing.Point(791, 455)
        Me.lblTotalx21xf1.Name = "lblTotalx21xf1"
        Me.lblTotalx21xf1.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalx21xf1.TabIndex = 13
        Me.lblTotalx21xf1.Text = "0.0"
        '
        'grdEstadistica
        '
        Me.grdEstadistica.AllowUserToDeleteRows = False
        Me.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstadistica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.X1, Me.F1, Me.N1, Me.X1xF1, Me.X21xF1})
        Me.grdEstadistica.Location = New System.Drawing.Point(325, 42)
        Me.grdEstadistica.Name = "grdEstadistica"
        Me.grdEstadistica.Size = New System.Drawing.Size(545, 307)
        Me.grdEstadistica.TabIndex = 14
        '
        'X1
        '
        Me.X1.HeaderText = "X1"
        Me.X1.Name = "X1"
        '
        'F1
        '
        Me.F1.HeaderText = "F1"
        Me.F1.Name = "F1"
        '
        'N1
        '
        Me.N1.HeaderText = "N1"
        Me.N1.Name = "N1"
        '
        'X1xF1
        '
        Me.X1xF1.HeaderText = "X1xF1"
        Me.X1xF1.Name = "X1xF1"
        '
        'X21xF1
        '
        Me.X21xF1.HeaderText = "X21xF1"
        Me.X21xF1.Name = "X21xF1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 487)
        Me.Controls.Add(Me.grdEstadistica)
        Me.Controls.Add(Me.lblTotalx21xf1)
        Me.Controls.Add(Me.lblTotalx1xf1)
        Me.Controls.Add(Me.lblTotalf1)
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
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblTotalf1 As Label
    Friend WithEvents lblTotalx1xf1 As Label
    Friend WithEvents lblTotalx21xf1 As Label
    Friend WithEvents grdEstadistica As DataGridView
    Friend WithEvents X1 As DataGridViewTextBoxColumn
    Friend WithEvents F1 As DataGridViewTextBoxColumn
    Friend WithEvents N1 As DataGridViewTextBoxColumn
    Friend WithEvents X1xF1 As DataGridViewTextBoxColumn
    Friend WithEvents X21xF1 As DataGridViewTextBoxColumn
End Class
