<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeMovProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeMovProveedores))
        Me.spInformeMovProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMovimientosProveedores = New WindowsApplication1.DSMovimientosProveedores()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spInformeMovProveedoresTableAdapter = New WindowsApplication1.DSMovimientosProveedoresTableAdapters.spInformeMovProveedoresTableAdapter()
        CType(Me.spInformeMovProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMovimientosProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInformeMovProveedoresBindingSource
        '
        Me.spInformeMovProveedoresBindingSource.DataMember = "spInformeMovProveedores"
        Me.spInformeMovProveedoresBindingSource.DataSource = Me.DSMovimientosProveedores
        '
        'DSMovimientosProveedores
        '
        Me.DSMovimientosProveedores.DataSetName = "DSMovimientosProveedores"
        Me.DSMovimientosProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSMovimientosProveedor"
        ReportDataSource1.Value = Me.spInformeMovProveedoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTMovimientosProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(854, 393)
        Me.ReportViewer1.TabIndex = 0
        '
        'spInformeMovProveedoresTableAdapter
        '
        Me.spInformeMovProveedoresTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeMovProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 393)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInformeMovProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Movimiento a Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spInformeMovProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMovimientosProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformeMovProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSMovimientosProveedores As WindowsApplication1.DSMovimientosProveedores
    Friend WithEvents spInformeMovProveedoresTableAdapter As WindowsApplication1.DSMovimientosProveedoresTableAdapters.spInformeMovProveedoresTableAdapter
End Class
