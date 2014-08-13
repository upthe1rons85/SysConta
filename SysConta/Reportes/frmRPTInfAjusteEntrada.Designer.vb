<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInfAjusteEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInfAjusteEntrada))
        Me.spinfAjusteEntradaCArgoAbonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInfAjusteEntrada = New WindowsApplication1.DSInfAjusteEntrada()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spinfAjusteEntradaCArgoAbonoTableAdapter = New WindowsApplication1.DSInfAjusteEntradaTableAdapters.spinfAjusteEntradaCArgoAbonoTableAdapter()
        CType(Me.spinfAjusteEntradaCArgoAbonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInfAjusteEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spinfAjusteEntradaCArgoAbonoBindingSource
        '
        Me.spinfAjusteEntradaCArgoAbonoBindingSource.DataMember = "spinfAjusteEntradaCArgoAbono"
        Me.spinfAjusteEntradaCArgoAbonoBindingSource.DataSource = Me.DSInfAjusteEntrada
        '
        'DSInfAjusteEntrada
        '
        Me.DSInfAjusteEntrada.DataSetName = "DSInfAjusteEntrada"
        Me.DSInfAjusteEntrada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSInfAjusteEntrada"
        ReportDataSource1.Value = Me.spinfAjusteEntradaCArgoAbonoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTinfAjusteEntrada.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(882, 303)
        Me.ReportViewer1.TabIndex = 0
        '
        'spinfAjusteEntradaCArgoAbonoTableAdapter
        '
        Me.spinfAjusteEntradaCArgoAbonoTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInfAjusteEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 303)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInfAjusteEntrada"
        Me.Text = "Reporte Cierre de Entradas"
        CType(Me.spinfAjusteEntradaCArgoAbonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInfAjusteEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spinfAjusteEntradaCArgoAbonoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSInfAjusteEntrada As WindowsApplication1.DSInfAjusteEntrada
    Friend WithEvents spinfAjusteEntradaCArgoAbonoTableAdapter As WindowsApplication1.DSInfAjusteEntradaTableAdapters.spinfAjusteEntradaCArgoAbonoTableAdapter
End Class
