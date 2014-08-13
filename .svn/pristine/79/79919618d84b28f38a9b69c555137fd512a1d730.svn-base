<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTProgramacionPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTProgramacionPagos))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.spInformeContrareciboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSProgramacionPagos = New WindowsApplication1.DSProgramacionPagos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spInformeContrareciboTableAdapter = New WindowsApplication1.DSProgramacionPagosTableAdapters.spInformeContrareciboTableAdapter()
        CType(Me.spInformeContrareciboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInformeContrareciboBindingSource
        '
        Me.spInformeContrareciboBindingSource.DataMember = "spInformeContrarecibo"
        Me.spInformeContrareciboBindingSource.DataSource = Me.DSProgramacionPagos
        '
        'DSProgramacionPagos
        '
        Me.DSProgramacionPagos.DataSetName = "DSProgramacionPagos"
        Me.DSProgramacionPagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        resources.ApplyResources(Me.ReportViewer1, "ReportViewer1")
        ReportDataSource1.Name = "DSProgramacionPagos"
        ReportDataSource1.Value = Me.spInformeContrareciboBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTProgramacionPagos.rdlc"
        Me.ReportViewer1.Name = "ReportViewer1"
        '
        'spInformeContrareciboTableAdapter
        '
        Me.spInformeContrareciboTableAdapter.ClearBeforeFill = True
        '
        'frmRPTProgramacionPagos
        '
        resources.ApplyResources(Me, "$this")
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmRPTProgramacionPagos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spInformeContrareciboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformeContrareciboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSProgramacionPagos As WindowsApplication1.DSProgramacionPagos
    Friend WithEvents spInformeContrareciboTableAdapter As WindowsApplication1.DSProgramacionPagosTableAdapters.spInformeContrareciboTableAdapter
End Class
