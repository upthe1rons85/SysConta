<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTEstadoResultadoCECO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTEstadoResultadoCECO))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSEstadoResultadoCECO = New WindowsApplication1.DSEstadoResultadoCECO()
        Me.spEsTadoResultadoCECOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spEsTadoResultadoCECOSTableAdapter = New WindowsApplication1.DSEstadoResultadoCECOTableAdapters.spEsTadoResultadoCECOSTableAdapter()
        CType(Me.DSEstadoResultadoCECO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spEsTadoResultadoCECOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSEstadoResuldadoCECO"
        ReportDataSource1.Value = Me.spEsTadoResultadoCECOSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTEstadoResultadoCECO.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(876, 436)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSEstadoResultadoCECO
        '
        Me.DSEstadoResultadoCECO.DataSetName = "DSEstadoResultadoCECO"
        Me.DSEstadoResultadoCECO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spEsTadoResultadoCECOSBindingSource
        '
        Me.spEsTadoResultadoCECOSBindingSource.DataMember = "spEsTadoResultadoCECOS"
        Me.spEsTadoResultadoCECOSBindingSource.DataSource = Me.DSEstadoResultadoCECO
        '
        'spEsTadoResultadoCECOSTableAdapter
        '
        Me.spEsTadoResultadoCECOSTableAdapter.ClearBeforeFill = True
        '
        'frmRPTEstadoResultadoCECO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 436)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTEstadoResultadoCECO"
        Me.Text = "Estado Resultado CECO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSEstadoResultadoCECO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spEsTadoResultadoCECOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spEsTadoResultadoCECOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSEstadoResultadoCECO As WindowsApplication1.DSEstadoResultadoCECO
    Friend WithEvents spEsTadoResultadoCECOSTableAdapter As WindowsApplication1.DSEstadoResultadoCECOTableAdapters.spEsTadoResultadoCECOSTableAdapter
End Class
