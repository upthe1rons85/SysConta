<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeIVA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeIVA))
        Me.spInformeIvaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInformeIva = New WindowsApplication1.DSInformeIva()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spInformeIvaTableAdapter = New WindowsApplication1.DSInformeIvaTableAdapters.spInformeIvaTableAdapter()
        CType(Me.spInformeIvaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInformeIva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInformeIvaBindingSource
        '
        Me.spInformeIvaBindingSource.DataMember = "spInformeIva"
        Me.spInformeIvaBindingSource.DataSource = Me.DSInformeIva
        '
        'DSInformeIva
        '
        Me.DSInformeIva.DataSetName = "DSInformeIva"
        Me.DSInformeIva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "spInformeIva"
        ReportDataSource1.Value = Me.spInformeIvaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInformeIVA.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(955, 429)
        Me.ReportViewer1.TabIndex = 0
        '
        'spInformeIvaTableAdapter
        '
        Me.spInformeIvaTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 429)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInformeIVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reportes de Iva"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spInformeIvaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInformeIva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformeIvaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSInformeIva As WindowsApplication1.DSInformeIva
    Friend WithEvents spInformeIvaTableAdapter As WindowsApplication1.DSInformeIvaTableAdapters.spInformeIvaTableAdapter
End Class
