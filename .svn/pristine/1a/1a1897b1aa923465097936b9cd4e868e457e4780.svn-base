<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeDepreciacionContable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeDepreciacionContable))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSDepreContable = New WindowsApplication1.DSDepreContable()
        Me.spDepreciacionContableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spDepreciacionContableTableAdapter = New WindowsApplication1.DSDepreContableTableAdapters.spDepreciacionContableTableAdapter()
        CType(Me.DSDepreContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spDepreciacionContableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSDepConta"
        ReportDataSource1.Value = Me.spDepreciacionContableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInformeDepreciacionContable.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1121, 415)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSDepreContable
        '
        Me.DSDepreContable.DataSetName = "DSDepreContable"
        Me.DSDepreContable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spDepreciacionContableBindingSource
        '
        Me.spDepreciacionContableBindingSource.DataMember = "spDepreciacionContable"
        Me.spDepreciacionContableBindingSource.DataSource = Me.DSDepreContable
        '
        'spDepreciacionContableTableAdapter
        '
        Me.spDepreciacionContableTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeDepreciacionContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 415)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInformeDepreciacionContable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Depreciacion Contable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSDepreContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spDepreciacionContableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spDepreciacionContableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSDepreContable As WindowsApplication1.DSDepreContable
    Friend WithEvents spDepreciacionContableTableAdapter As WindowsApplication1.DSDepreContableTableAdapters.spDepreciacionContableTableAdapter
End Class
