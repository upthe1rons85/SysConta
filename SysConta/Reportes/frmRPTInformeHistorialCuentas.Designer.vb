<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeHistorialCuentas
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSInformeHistorialCuenta = New WindowsApplication1.DSInformeHistorialCuenta()
        Me.spInformePolizasxCuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spInformePolizasxCuentaTableAdapter = New WindowsApplication1.DSInformeHistorialCuentaTableAdapters.spInformePolizasxCuentaTableAdapter()
        CType(Me.DSInformeHistorialCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spInformePolizasxCuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSInformeHistorialCuenta"
        ReportDataSource1.Value = Me.spInformePolizasxCuentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInformeHistorialCuenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(829, 414)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSInformeHistorialCuenta
        '
        Me.DSInformeHistorialCuenta.DataSetName = "DSInformeHistorialCuenta"
        Me.DSInformeHistorialCuenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spInformePolizasxCuentaBindingSource
        '
        Me.spInformePolizasxCuentaBindingSource.DataMember = "spInformePolizasxCuenta"
        Me.spInformePolizasxCuentaBindingSource.DataSource = Me.DSInformeHistorialCuenta
        '
        'spInformePolizasxCuentaTableAdapter
        '
        Me.spInformePolizasxCuentaTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeHistorialCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 414)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRPTInformeHistorialCuentas"
        Me.Text = "frmRPTInformeHistorialCuentas"
        CType(Me.DSInformeHistorialCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spInformePolizasxCuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformePolizasxCuentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSInformeHistorialCuenta As WindowsApplication1.DSInformeHistorialCuenta
    Friend WithEvents spInformePolizasxCuentaTableAdapter As WindowsApplication1.DSInformeHistorialCuentaTableAdapters.spInformePolizasxCuentaTableAdapter
End Class
