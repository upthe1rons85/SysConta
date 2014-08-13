<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTPendientesPagovb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTPendientesPagovb))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.spSPPendienteProgramarPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPendientesPago = New WindowsApplication1.DSPendientesPago()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spSPPendienteProgramarPagoTableAdapter = New WindowsApplication1.DSPendientesPagoTableAdapters.spSPPendienteProgramarPagoTableAdapter()
        CType(Me.spSPPendienteProgramarPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPendientesPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spSPPendienteProgramarPagoBindingSource
        '
        Me.spSPPendienteProgramarPagoBindingSource.DataMember = "spSPPendienteProgramarPago"
        Me.spSPPendienteProgramarPagoBindingSource.DataSource = Me.DSPendientesPago
        '
        'DSPendientesPago
        '
        Me.DSPendientesPago.DataSetName = "DSPendientesPago"
        Me.DSPendientesPago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        resources.ApplyResources(Me.ReportViewer1, "ReportViewer1")
        ReportDataSource1.Name = "DSPendientePago"
        ReportDataSource1.Value = Me.spSPPendienteProgramarPagoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTPendientesPagoProg.rdlc"
        Me.ReportViewer1.Name = "ReportViewer1"
        '
        'spSPPendienteProgramarPagoTableAdapter
        '
        Me.spSPPendienteProgramarPagoTableAdapter.ClearBeforeFill = True
        '
        'frmRPTPendientesPagovb
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRPTPendientesPagovb"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spSPPendienteProgramarPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPendientesPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spSPPendienteProgramarPagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSPendientesPago As WindowsApplication1.DSPendientesPago
    Friend WithEvents spSPPendienteProgramarPagoTableAdapter As WindowsApplication1.DSPendientesPagoTableAdapters.spSPPendienteProgramarPagoTableAdapter
End Class
