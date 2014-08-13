<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTPolizasManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTPolizasManual))
        Me.spSelPolizaContableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPolizasContables = New WindowsApplication1.DSPolizasContables()
        Me.RVPolizaContable = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spSelPolizaContableTableAdapter = New WindowsApplication1.DSPolizasContablesTableAdapters.spSelPolizaContableTableAdapter()
        CType(Me.spSelPolizaContableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPolizasContables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spSelPolizaContableBindingSource
        '
        Me.spSelPolizaContableBindingSource.DataMember = "spSelPolizaContable"
        Me.spSelPolizaContableBindingSource.DataSource = Me.DSPolizasContables
        '
        'DSPolizasContables
        '
        Me.DSPolizasContables.DataSetName = "DSPolizasContables"
        Me.DSPolizasContables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RVPolizaContable
        '
        Me.RVPolizaContable.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CDPolizasContables"
        ReportDataSource1.Value = Me.spSelPolizaContableBindingSource
        Me.RVPolizaContable.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVPolizaContable.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTPolizasContables.rdlc"
        Me.RVPolizaContable.Location = New System.Drawing.Point(0, 0)
        Me.RVPolizaContable.Name = "RVPolizaContable"
        Me.RVPolizaContable.Size = New System.Drawing.Size(667, 391)
        Me.RVPolizaContable.TabIndex = 0
        '
        'spSelPolizaContableTableAdapter
        '
        Me.spSelPolizaContableTableAdapter.ClearBeforeFill = True
        '
        'frmRPTPolizasManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 391)
        Me.Controls.Add(Me.RVPolizaContable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRPTPolizasManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Poliza Contable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spSelPolizaContableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPolizasContables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RVPolizaContable As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spSelPolizaContableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSPolizasContables As WindowsApplication1.DSPolizasContables
    Friend WithEvents spSelPolizaContableTableAdapter As WindowsApplication1.DSPolizasContablesTableAdapters.spSelPolizaContableTableAdapter
End Class
