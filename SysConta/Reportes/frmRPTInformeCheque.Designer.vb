<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeCheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeCheque))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.spInformeChequeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInfCheques = New WindowsApplication1.DSInfCheques()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spInformeChequeTableAdapter = New WindowsApplication1.DSInfChequesTableAdapters.spInformeChequeTableAdapter()
        CType(Me.spInformeChequeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInfCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInformeChequeBindingSource
        '
        Me.spInformeChequeBindingSource.DataMember = "spInformeCheque"
        Me.spInformeChequeBindingSource.DataSource = Me.DSInfCheques
        '
        'DSInfCheques
        '
        Me.DSInfCheques.DataSetName = "DSInfCheques"
        Me.DSInfCheques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        resources.ApplyResources(Me.ReportViewer1, "ReportViewer1")
        ReportDataSource1.Name = "DSInfCheques"
        ReportDataSource1.Value = Me.spInformeChequeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInfCheque.rdlc"
        Me.ReportViewer1.Name = "ReportViewer1"
        '
        'spInformeChequeTableAdapter
        '
        Me.spInformeChequeTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeCheque
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmRPTInformeCheque"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.spInformeChequeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInfCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformeChequeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSInfCheques As WindowsApplication1.DSInfCheques
    Friend WithEvents spInformeChequeTableAdapter As WindowsApplication1.DSInfChequesTableAdapters.spInformeChequeTableAdapter
End Class
