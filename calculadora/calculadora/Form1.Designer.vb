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
        Me.lblnTabla = New System.Windows.Forms.Label()
        Me.txtnTabla = New System.Windows.Forms.TextBox()
        Me.lstTablas = New System.Windows.Forms.ListBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnTabla
        '
        Me.lblnTabla.AutoSize = True
        Me.lblnTabla.Location = New System.Drawing.Point(76, 64)
        Me.lblnTabla.Name = "lblnTabla"
        Me.lblnTabla.Size = New System.Drawing.Size(34, 13)
        Me.lblnTabla.TabIndex = 0
        Me.lblnTabla.Text = "Tabla"
        '
        'txtnTabla
        '
        Me.txtnTabla.Location = New System.Drawing.Point(121, 61)
        Me.txtnTabla.Name = "txtnTabla"
        Me.txtnTabla.Size = New System.Drawing.Size(100, 20)
        Me.txtnTabla.TabIndex = 1
        '
        'lstTablas
        '
        Me.lstTablas.FormattingEnabled = True
        Me.lstTablas.Location = New System.Drawing.Point(325, 49)
        Me.lstTablas.Name = "lstTablas"
        Me.lstTablas.Size = New System.Drawing.Size(308, 173)
        Me.lstTablas.TabIndex = 2
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(79, 178)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(142, 75)
        Me.btnProcesar.TabIndex = 3
        Me.btnProcesar.Text = "Generar Tabla"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 450)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lstTablas)
        Me.Controls.Add(Me.txtnTabla)
        Me.Controls.Add(Me.lblnTabla)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnTabla As Label
    Friend WithEvents txtnTabla As TextBox
    Friend WithEvents lstTablas As ListBox
    Friend WithEvents btnProcesar As Button
End Class
