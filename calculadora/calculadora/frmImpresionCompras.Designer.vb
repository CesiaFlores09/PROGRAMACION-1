<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpresionCompras
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpresionCompras))
        Me.ImpresionComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bd_empresaDataSet = New calculadora.bd_empresaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ImpresionComprasTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.ImpresionComprasTableAdapter()
        CType(Me.ImpresionComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_empresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImpresionComprasBindingSource
        '
        Me.ImpresionComprasBindingSource.DataMember = "ImpresionCompras"
        Me.ImpresionComprasBindingSource.DataSource = Me.bd_empresaDataSet
        '
        'bd_empresaDataSet
        '
        Me.bd_empresaDataSet.DataSetName = "bd_empresaDataSet"
        Me.bd_empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsImpresionCompras"
        ReportDataSource1.Value = Me.ImpresionComprasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "calculadora.InfmCompras.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 426)
        Me.ReportViewer1.TabIndex = 0
        '
        'ImpresionComprasTableAdapter
        '
        Me.ImpresionComprasTableAdapter.ClearBeforeFill = True
        '
        'frmImpresionCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImpresionCompras"
        Me.Text = "Impresion de la Compra"
        CType(Me.ImpresionComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_empresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ImpresionComprasBindingSource As BindingSource
    Friend WithEvents bd_empresaDataSet As bd_empresaDataSet
    Friend WithEvents ImpresionComprasTableAdapter As bd_empresaDataSetTableAdapters.ImpresionComprasTableAdapter
End Class
