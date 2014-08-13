<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTEstadoResultado
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSEstadoResultado = New WindowsApplication1.DSEstadoResultado()
        Me.sp_InfEstadoResultado_OPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_InfEstadoResultado_OPTableAdapter = New WindowsApplication1.DSEstadoResultadoTableAdapters.sp_InfEstadoResultado_OPTableAdapter()
        CType(Me.DSEstadoResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_InfEstadoResultado_OPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSEstadoResultado"
        ReportDataSource1.Value = Me.sp_InfEstadoResultado_OPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTEstadoResultado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(966, 331)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSEstadoResultado
        '
        Me.DSEstadoResultado.DataSetName = "DSEstadoResultado"
        Me.DSEstadoResultado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sp_InfEstadoResultado_OPBindingSource
        '
        Me.sp_InfEstadoResultado_OPBindingSource.DataMember = "sp_InfEstadoResultado_OP"
        Me.sp_InfEstadoResultado_OPBindingSource.DataSource = Me.DSEstadoResultado
        '
        'sp_InfEstadoResultado_OPTableAdapter
        '
        Me.sp_InfEstadoResultado_OPTableAdapter.ClearBeforeFill = True
        '
        'frmRPTEstadoResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 331)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRPTEstadoResultado"
        Me.Text = "frmRPTEstadoResultado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSEstadoResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_InfEstadoResultado_OPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_InfEstadoResultado_OPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSEstadoResultado As WindowsApplication1.DSEstadoResultado
    Friend WithEvents sp_InfEstadoResultado_OPTableAdapter As WindowsApplication1.DSEstadoResultadoTableAdapters.sp_InfEstadoResultado_OPTableAdapter
End Class
