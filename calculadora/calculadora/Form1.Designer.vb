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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lstEjercicios = New System.Windows.Forms.ListBox()
        Me.btnParImpar = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(269, 273)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(181, 23)
        Me.btnProcesar.TabIndex = 0
        Me.btnProcesar.Text = "Numero Pares e Impares"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.Location = New System.Drawing.Point(269, 55)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(181, 212)
        Me.lstEjercicios.TabIndex = 1
        '
        'btnParImpar
        '
        Me.btnParImpar.Location = New System.Drawing.Point(12, 220)
        Me.btnParImpar.Name = "btnParImpar"
        Me.btnParImpar.Size = New System.Drawing.Size(81, 47)
        Me.btnParImpar.TabIndex = 2
        Me.btnParImpar.Text = "Par o impar?"
        Me.btnParImpar.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(112, 110)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 3
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(33, 110)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(47, 13)
        Me.lblNum.TabIndex = 4
        Me.lblNum.Text = "Numero:"
        '
        'btnPrimo
        '
        Me.btnPrimo.Location = New System.Drawing.Point(99, 220)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(83, 47)
        Me.btnPrimo.TabIndex = 5
        Me.btnPrimo.Text = "Primo?"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'btnCajero
        '
        Me.btnCajero.Location = New System.Drawing.Point(188, 220)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(75, 47)
        Me.btnCajero.TabIndex = 6
        Me.btnCajero.Text = "Cajero"
        Me.btnCajero.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 327)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.btnParImpar)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.btnProcesar)
        Me.Name = "Form1"
        Me.Text = "Ejercicios con estructuras de control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcesar As Button
    Friend WithEvents lstEjercicios As ListBox
    Friend WithEvents btnParImpar As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents lblNum As Label
    Friend WithEvents btnPrimo As Button
    Friend WithEvents btnCajero As Button
End Class
