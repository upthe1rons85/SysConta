<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTReporteCheques
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTReporteCheques))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSRepCheques = New WindowsApplication1.DSRepCheques()
        Me.spReporteChequeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spReporteChequeTableAdapter = New WindowsApplication1.DSRepChequesTableAdapters.spReporteChequeTableAdapter()
        CType(Me.DSRepCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spReporteChequeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSRepCheques"
        ReportDataSource1.Value = Me.spReporteChequeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTReporteCheques.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(928, 377)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSRepCheques
        '
        Me.DSRepCheques.DataSetName = "DSRepCheques"
        Me.DSRepCheques.EnforceConstraints = False
        Me.DSRepCheques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spReporteChequeBindingSource
        '
        Me.spReporteChequeBindingSource.DataMember = "spReporteCheque"
        Me.spReporteChequeBindingSource.DataSource = Me.DSRepCheques
        '
        'spReporteChequeTableAdapter
        '
        Me.spReporteChequeTableAdapter.ClearBeforeFill = True
        '
        'frmRPTReporteCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 377)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTReporteCheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Cheques"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSRepCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spReporteChequeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spReporteChequeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSRepCheques As WindowsApplication1.DSRepCheques
    Friend WithEvents spReporteChequeTableAdapter As WindowsApplication1.DSRepChequesTableAdapters.spReporteChequeTableAdapter
End Class
