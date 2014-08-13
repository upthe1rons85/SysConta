<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInfCuentasContables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInfCuentasContables))
        Me.spSelCuentasInformeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInfCuentasContables = New WindowsApplication1.DSInfCuentasContables()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spSelCuentasInformeTableAdapter = New WindowsApplication1.DSInfCuentasContablesTableAdapters.spSelCuentasInformeTableAdapter()
        CType(Me.spSelCuentasInformeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInfCuentasContables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spSelCuentasInformeBindingSource
        '
        Me.spSelCuentasInformeBindingSource.DataMember = "spSelCuentasInforme"
        Me.spSelCuentasInformeBindingSource.DataSource = Me.DSInfCuentasContables
        '
        'DSInfCuentasContables
        '
        Me.DSInfCuentasContables.DataSetName = "DSInfCuentasContables"
        Me.DSInfCuentasContables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSInfCuentasContables"
        ReportDataSource1.Value = Me.spSelCuentasInformeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInfCuentasContables.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(720, 313)
        Me.ReportViewer1.TabIndex = 0
        '
        'spSelCuentasInformeTableAdapter
        '
        Me.spSelCuentasInformeTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInfCuentasContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 313)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInfCuentasContables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Polizas Contables"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spSelCuentasInformeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInfCuentasContables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spSelCuentasInformeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSInfCuentasContables As WindowsApplication1.DSInfCuentasContables
    Friend WithEvents spSelCuentasInformeTableAdapter As WindowsApplication1.DSInfCuentasContablesTableAdapters.spSelCuentasInformeTableAdapter
End Class
