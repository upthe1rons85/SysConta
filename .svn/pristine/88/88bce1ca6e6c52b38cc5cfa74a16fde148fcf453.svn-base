<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeDepreciacionFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeDepreciacionFiscal))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSDepreFiscal = New WindowsApplication1.DSDepreFiscal()
        Me.spDepreciacionFiscalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spDepreciacionFiscalTableAdapter = New WindowsApplication1.DSDepreFiscalTableAdapters.spDepreciacionFiscalTableAdapter()
        CType(Me.DSDepreFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spDepreciacionFiscalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSDepFiscal"
        ReportDataSource1.Value = Me.spDepreciacionFiscalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTDepreciacionFiscal.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(969, 395)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSDepreFiscal
        '
        Me.DSDepreFiscal.DataSetName = "DSDepreFiscal"
        Me.DSDepreFiscal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spDepreciacionFiscalBindingSource
        '
        Me.spDepreciacionFiscalBindingSource.DataMember = "spDepreciacionFiscal"
        Me.spDepreciacionFiscalBindingSource.DataSource = Me.DSDepreFiscal
        '
        'spDepreciacionFiscalTableAdapter
        '
        Me.spDepreciacionFiscalTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeDepreciacionFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 395)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInformeDepreciacionFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Depreciacion Fiscal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSDepreFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spDepreciacionFiscalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spDepreciacionFiscalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSDepreFiscal As WindowsApplication1.DSDepreFiscal
    Friend WithEvents spDepreciacionFiscalTableAdapter As WindowsApplication1.DSDepreFiscalTableAdapters.spDepreciacionFiscalTableAdapter
End Class
