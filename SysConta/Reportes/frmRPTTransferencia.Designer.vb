<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTTransferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTTransferencia))
        Me.spSelInfTransferenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSTransferencia = New WindowsApplication1.DSTransferencia()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spSelInfTransferenciaTableAdapter = New WindowsApplication1.DSTransferenciaTableAdapters.spSelInfTransferenciaTableAdapter()
        CType(Me.spSelInfTransferenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spSelInfTransferenciaBindingSource
        '
        Me.spSelInfTransferenciaBindingSource.DataMember = "spSelInfTransferencia"
        Me.spSelInfTransferenciaBindingSource.DataSource = Me.DSTransferencia
        '
        'DSTransferencia
        '
        Me.DSTransferencia.DataSetName = "DSTransferencia"
        Me.DSTransferencia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSTransferencia"
        ReportDataSource1.Value = Me.spSelInfTransferenciaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTTransferencia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(979, 663)
        Me.ReportViewer1.TabIndex = 0
        '
        'spSelInfTransferenciaTableAdapter
        '
        Me.spSelInfTransferenciaTableAdapter.ClearBeforeFill = True
        '
        'frmRPTTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 663)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Transferencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spSelInfTransferenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spSelInfTransferenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSTransferencia As WindowsApplication1.DSTransferencia
    Friend WithEvents spSelInfTransferenciaTableAdapter As WindowsApplication1.DSTransferenciaTableAdapters.spSelInfTransferenciaTableAdapter
End Class
