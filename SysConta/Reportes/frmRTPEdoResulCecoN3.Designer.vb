<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRTPEdoResulCecoN3
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
        Me.DSEdoResulCECOn3 = New WindowsApplication1.DSEdoResulCECOn3()
        Me.spEdoResulCECOn3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spEdoResulCECOn3TableAdapter = New WindowsApplication1.DSEdoResulCECOn3TableAdapters.spEdoResulCECOn3TableAdapter()
        CType(Me.DSEdoResulCECOn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spEdoResulCECOn3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSEdoResulCECOn3"
        ReportDataSource1.Value = Me.spEdoResulCECOn3BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTedoResulCecoN3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(533, 290)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSEdoResulCECOn3
        '
        Me.DSEdoResulCECOn3.DataSetName = "DSEdoResulCECOn3"
        Me.DSEdoResulCECOn3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spEdoResulCECOn3BindingSource
        '
        Me.spEdoResulCECOn3BindingSource.DataMember = "spEdoResulCECOn3"
        Me.spEdoResulCECOn3BindingSource.DataSource = Me.DSEdoResulCECOn3
        '
        'spEdoResulCECOn3TableAdapter
        '
        Me.spEdoResulCECOn3TableAdapter.ClearBeforeFill = True
        '
        'frmRTPEdoResulCecoN3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 290)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRTPEdoResulCecoN3"
        Me.Text = "frmRTPEdoResulCecoN3"
        CType(Me.DSEdoResulCECOn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spEdoResulCECOn3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spEdoResulCECOn3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSEdoResulCECOn3 As WindowsApplication1.DSEdoResulCECOn3
    Friend WithEvents spEdoResulCECOn3TableAdapter As WindowsApplication1.DSEdoResulCECOn3TableAdapters.spEdoResulCECOn3TableAdapter
End Class
