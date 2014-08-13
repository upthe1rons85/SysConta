<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeMovCatProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeMovCatProveedores))
        Me.spInformeMovProveedores1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMovimientoCatProveedores = New WindowsApplication1.DSMovimientoCatProveedores()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spInformeMovProveedores1TableAdapter = New WindowsApplication1.DSMovimientoCatProveedoresTableAdapters.spInformeMovProveedores1TableAdapter()
        CType(Me.spInformeMovProveedores1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMovimientoCatProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInformeMovProveedores1BindingSource
        '
        Me.spInformeMovProveedores1BindingSource.DataMember = "spInformeMovProveedores1"
        Me.spInformeMovProveedores1BindingSource.DataSource = Me.DSMovimientoCatProveedores
        '
        'DSMovimientoCatProveedores
        '
        Me.DSMovimientoCatProveedores.DataSetName = "DSMovimientoCatProveedores"
        Me.DSMovimientoCatProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSMovCatProveedores"
        ReportDataSource1.Value = Me.spInformeMovProveedores1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTMovCatProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(844, 379)
        Me.ReportViewer1.TabIndex = 0
        '
        'spInformeMovProveedores1TableAdapter
        '
        Me.spInformeMovProveedores1TableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeMovCatProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 379)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInformeMovCatProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Movimiento de Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spInformeMovProveedores1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMovimientoCatProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformeMovProveedores1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSMovimientoCatProveedores As WindowsApplication1.DSMovimientoCatProveedores
    Friend WithEvents spInformeMovProveedores1TableAdapter As WindowsApplication1.DSMovimientoCatProveedoresTableAdapters.spInformeMovProveedores1TableAdapter
End Class
