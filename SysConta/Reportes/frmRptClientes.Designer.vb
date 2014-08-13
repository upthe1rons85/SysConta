<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptClientes))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSCatClientes = New WindowsApplication1.DSCatClientes()
        Me.spSelCatClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spSelCatClientesTableAdapter = New WindowsApplication1.DSCatClientesTableAdapters.spSelCatClientesTableAdapter()
        CType(Me.DSCatClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spSelCatClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSCatClientes"
        ReportDataSource1.Value = Me.spSelCatClientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTCatClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(758, 334)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSCatClientes
        '
        Me.DSCatClientes.DataSetName = "DSCatClientes"
        Me.DSCatClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spSelCatClientesBindingSource
        '
        Me.spSelCatClientesBindingSource.DataMember = "spSelCatClientes"
        Me.spSelCatClientesBindingSource.DataSource = Me.DSCatClientes
        '
        'spSelCatClientesTableAdapter
        '
        Me.spSelCatClientesTableAdapter.ClearBeforeFill = True
        '
        'frmRptClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 334)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRptClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Catalogo Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSCatClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spSelCatClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spSelCatClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSCatClientes As WindowsApplication1.DSCatClientes
    Friend WithEvents spSelCatClientesTableAdapter As WindowsApplication1.DSCatClientesTableAdapters.spSelCatClientesTableAdapter
End Class
