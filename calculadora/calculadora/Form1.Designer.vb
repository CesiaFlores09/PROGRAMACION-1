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
        Me.lblIMun = New System.Windows.Forms.Label()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.cboDepto = New System.Windows.Forms.ComboBox()
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblIMun
        '
        Me.lblIMun.AutoSize = True
        Me.lblIMun.Location = New System.Drawing.Point(209, 39)
        Me.lblIMun.Name = "lblIMun"
        Me.lblIMun.Size = New System.Drawing.Size(28, 13)
        Me.lblIMun.TabIndex = 7
        Me.lblIMun.Text = "Mun"
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Location = New System.Drawing.Point(12, 39)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(36, 13)
        Me.lblDepto.TabIndex = 0
        Me.lblDepto.Text = "Depto"
        '
        'cboDepto
        '
        Me.cboDepto.FormattingEnabled = True
        Me.cboDepto.Location = New System.Drawing.Point(63, 36)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Size = New System.Drawing.Size(121, 21)
        Me.cboDepto.TabIndex = 8
        '
        'cboMun
        '
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(243, 36)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(121, 21)
        Me.cboMun.TabIndex = 9
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(398, 44)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(29, 13)
        Me.lblArea.TabIndex = 10
        Me.lblArea.Text = "Area"
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(451, 36)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(121, 21)
        Me.cboArea.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 218)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.cboMun)
        Me.Controls.Add(Me.cboDepto)
        Me.Controls.Add(Me.lblIMun)
        Me.Controls.Add(Me.lblDepto)
        Me.Name = "Form1"
        Me.Text = "Conversor de numeros decimales a Romanos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIMun As Label
    Friend WithEvents lblDepto As Label
    Friend WithEvents cboDepto As ComboBox
    Friend WithEvents cboMun As ComboBox
    Friend WithEvents lblArea As Label
    Friend WithEvents cboArea As ComboBox
End Class
