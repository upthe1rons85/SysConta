<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeProveedores))
        Me.spBusProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.contabilidadDataSet4 = New WindowsApplication1.contabilidadDataSet4()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spBusProveedorTableAdapter = New WindowsApplication1.contabilidadDataSet4TableAdapters.spBusProveedorTableAdapter()
        CType(Me.spBusProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contabilidadDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spBusProveedorBindingSource
        '
        Me.spBusProveedorBindingSource.DataMember = "spBusProveedor"
        Me.spBusProveedorBindingSource.DataSource = Me.contabilidadDataSet4
        '
        'contabilidadDataSet4
        '
        Me.contabilidadDataSet4.DataSetName = "contabilidadDataSet4"
        Me.contabilidadDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.spBusProveedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInformeProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(733, 407)
        Me.ReportViewer1.TabIndex = 0
        '
        'spBusProveedorTableAdapter
        '
        Me.spBusProveedorTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 407)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInformeProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spBusProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contabilidadDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spBusProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents contabilidadDataSet4 As WindowsApplication1.contabilidadDataSet4
    Friend WithEvents spBusProveedorTableAdapter As WindowsApplication1.contabilidadDataSet4TableAdapters.spBusProveedorTableAdapter
End Class
