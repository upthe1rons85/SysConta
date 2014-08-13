<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTBalanzaComprobacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTBalanzaComprobacion))
        Me.spImformeBalanzaComprobacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBBalanzaComprobacion = New WindowsApplication1.DBBalanzaComprobacion()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spImformeBalanzaComprobacionTableAdapter = New WindowsApplication1.DBBalanzaComprobacionTableAdapters.spImformeBalanzaComprobacionTableAdapter()
        CType(Me.spImformeBalanzaComprobacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBBalanzaComprobacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spImformeBalanzaComprobacionBindingSource
        '
        Me.spImformeBalanzaComprobacionBindingSource.DataMember = "spImformeBalanzaComprobacion"
        Me.spImformeBalanzaComprobacionBindingSource.DataSource = Me.DBBalanzaComprobacion
        '
        'DBBalanzaComprobacion
        '
        Me.DBBalanzaComprobacion.DataSetName = "DBBalanzaComprobacion"
        Me.DBBalanzaComprobacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DBBalanzaComprobacion"
        ReportDataSource1.Value = Me.spImformeBalanzaComprobacionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTBalanzaComprobacion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(705, 348)
        Me.ReportViewer1.TabIndex = 0
        '
        'spImformeBalanzaComprobacionTableAdapter
        '
        Me.spImformeBalanzaComprobacionTableAdapter.ClearBeforeFill = True
        '
        'frmRPTBalanzaComprobacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 348)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTBalanzaComprobacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balanza de Comprobacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spImformeBalanzaComprobacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBBalanzaComprobacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spImformeBalanzaComprobacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DBBalanzaComprobacion As WindowsApplication1.DBBalanzaComprobacion
    Friend WithEvents spImformeBalanzaComprobacionTableAdapter As WindowsApplication1.DBBalanzaComprobacionTableAdapters.spImformeBalanzaComprobacionTableAdapter
End Class
