<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTRelacionSaldosNivel4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTRelacionSaldosNivel4))
        Me.spInformeRelacionSaldosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRelacionSaldosNivel4 = New WindowsApplication1.DSRelacionSaldosNivel4()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spInformeRelacionSaldosTableAdapter = New WindowsApplication1.DSRelacionSaldosNivel4TableAdapters.spInformeRelacionSaldosTableAdapter()
        CType(Me.spInformeRelacionSaldosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRelacionSaldosNivel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInformeRelacionSaldosBindingSource
        '
        Me.spInformeRelacionSaldosBindingSource.DataMember = "spInformeRelacionSaldos"
        Me.spInformeRelacionSaldosBindingSource.DataSource = Me.DSRelacionSaldosNivel4
        '
        'DSRelacionSaldosNivel4
        '
        Me.DSRelacionSaldosNivel4.DataSetName = "DSRelacionSaldosNivel4"
        Me.DSRelacionSaldosNivel4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSRelacionSaldosNivel4"
        ReportDataSource1.Value = Me.spInformeRelacionSaldosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTRelacionSaldosNivel4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(546, 340)
        Me.ReportViewer1.TabIndex = 0
        '
        'spInformeRelacionSaldosTableAdapter
        '
        Me.spInformeRelacionSaldosTableAdapter.ClearBeforeFill = True
        '
        'frmRPTRelacionSaldosNivel4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 340)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTRelacionSaldosNivel4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relacion Saldos Nivel 4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spInformeRelacionSaldosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRelacionSaldosNivel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformeRelacionSaldosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSRelacionSaldosNivel4 As WindowsApplication1.DSRelacionSaldosNivel4
    Friend WithEvents spInformeRelacionSaldosTableAdapter As WindowsApplication1.DSRelacionSaldosNivel4TableAdapters.spInformeRelacionSaldosTableAdapter
End Class
