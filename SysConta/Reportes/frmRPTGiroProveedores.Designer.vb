<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTGiroProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTGiroProveedores))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSGiroProv = New WindowsApplication1.DSGiroProv()
        Me.spSelGiroComercialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spSelGiroComercialTableAdapter = New WindowsApplication1.DSGiroProvTableAdapters.spSelGiroComercialTableAdapter()
        CType(Me.DSGiroProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spSelGiroComercialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSGiroProveedores"
        ReportDataSource1.Value = Me.spSelGiroComercialBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTGiroProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(829, 406)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSGiroProv
        '
        Me.DSGiroProv.DataSetName = "DSGiroProv"
        Me.DSGiroProv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spSelGiroComercialBindingSource
        '
        Me.spSelGiroComercialBindingSource.DataMember = "spSelGiroComercial"
        Me.spSelGiroComercialBindingSource.DataSource = Me.DSGiroProv
        '
        'spSelGiroComercialTableAdapter
        '
        Me.spSelGiroComercialTableAdapter.ClearBeforeFill = True
        '
        'frmRPTGiroProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 406)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTGiroProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Giro Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSGiroProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spSelGiroComercialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spSelGiroComercialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSGiroProv As WindowsApplication1.DSGiroProv
    Friend WithEvents spSelGiroComercialTableAdapter As WindowsApplication1.DSGiroProvTableAdapters.spSelGiroComercialTableAdapter
End Class
