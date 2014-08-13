<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTEdoResultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTEdoResultados))
        Me.spInfEdoResultadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSEdoResultados = New WindowsApplication1.DSEdoResultados()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spInfEdoResultadosTableAdapter = New WindowsApplication1.DSEdoResultadosTableAdapters.spInfEdoResultadosTableAdapter()
        Me.DSEstadoResultado = New WindowsApplication1.DSEstadoResultado()
        Me.sp_InfEstadoResultado_OPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_InfEstadoResultado_OPTableAdapter = New WindowsApplication1.DSEstadoResultadoTableAdapters.sp_InfEstadoResultado_OPTableAdapter()
        CType(Me.spInfEdoResultadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSEdoResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSEstadoResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_InfEstadoResultado_OPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInfEdoResultadosBindingSource
        '
        Me.spInfEdoResultadosBindingSource.DataMember = "spInfEdoResultados"
        Me.spInfEdoResultadosBindingSource.DataSource = Me.DSEdoResultados
        '
        'DSEdoResultados
        '
        Me.DSEdoResultados.DataSetName = "DSEdoResultados"
        Me.DSEdoResultados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.ReportViewer1.Size = New System.Drawing.Size(719, 404)
        Me.ReportViewer1.TabIndex = 0
        '
        'spInfEdoResultadosTableAdapter
        '
        Me.spInfEdoResultadosTableAdapter.ClearBeforeFill = True
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
        'frmRPTEdoResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 404)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTEdoResultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Resultados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spInfEdoResultadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSEdoResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSEstadoResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_InfEstadoResultado_OPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInfEdoResultadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSEdoResultados As WindowsApplication1.DSEdoResultados
    Friend WithEvents spInfEdoResultadosTableAdapter As WindowsApplication1.DSEdoResultadosTableAdapters.spInfEdoResultadosTableAdapter
    Friend WithEvents sp_InfEstadoResultado_OPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSEstadoResultado As WindowsApplication1.DSEstadoResultado
    Friend WithEvents sp_InfEstadoResultado_OPTableAdapter As WindowsApplication1.DSEstadoResultadoTableAdapters.sp_InfEstadoResultado_OPTableAdapter
End Class
