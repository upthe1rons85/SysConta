﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTBalanceGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTBalanceGeneral))
        Me.spInformeBalanceGeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.DSBalanceGeneral = New WindowsApplication1.DSBalanceGeneral()
        Me.sp_InfBanalceGeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBalanceGeneralOP = New WindowsApplication1.DSBalanceGeneralOP()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        'Me.spInformeBalanceGeneralTableAdapter = New WindowsApplication1.DSBalanceGeneralTableAdapters.spInformeBalanceGeneralTableAdapter()
        Me.sp_InfBanalceGeneralTableAdapter = New WindowsApplication1.DSBalanceGeneralOPTableAdapters.sp_InfBanalceGeneralTableAdapter()
        CType(Me.spInformeBalanceGeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.DSBalanceGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_InfBanalceGeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBalanceGeneralOP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInformeBalanceGeneralBindingSource
        '
        Me.spInformeBalanceGeneralBindingSource.DataMember = "spInformeBalanceGeneral"
        'Me.spInformeBalanceGeneralBindingSource.DataSource = Me.DSBalanceGeneral
        '
        'DSBalanceGeneral
        '
        'Me.DSBalanceGeneral.DataSetName = "DSBalanceGeneral"
        'Me.DSBalanceGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sp_InfBanalceGeneralBindingSource
        '
        Me.sp_InfBanalceGeneralBindingSource.DataMember = "sp_InfBanalceGeneral"
        Me.sp_InfBanalceGeneralBindingSource.DataSource = Me.DSBalanceGeneralOP
        '
        'DSBalanceGeneralOP
        '
        Me.DSBalanceGeneralOP.DataSetName = "DSBalanceGeneralOP"
        Me.DSBalanceGeneralOP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSBalanceGeneralOP"
        ReportDataSource1.Value = Me.sp_InfBanalceGeneralBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTBalanceGeneralOP.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(693, 427)
        Me.ReportViewer1.TabIndex = 0
        '
        'spInformeBalanceGeneralTableAdapter
        '
        'Me.spInformeBalanceGeneralTableAdapter.ClearBeforeFill = True
        '
        'sp_InfBanalceGeneralTableAdapter
        '
        Me.sp_InfBanalceGeneralTableAdapter.ClearBeforeFill = True
        '
        'frmRPTBalanceGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 427)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTBalanceGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance General"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spInformeBalanceGeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.DSBalanceGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_InfBanalceGeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBalanceGeneralOP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformeBalanceGeneralBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents DSBalanceGeneral As WindowsApplication1.DSBalanceGeneral
    'Friend WithEvents spInformeBalanceGeneralTableAdapter As WindowsApplication1.DSBalanceGeneralTableAdapters.spInformeBalanceGeneralTableAdapter
    Friend WithEvents sp_InfBanalceGeneralBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSBalanceGeneralOP As WindowsApplication1.DSBalanceGeneralOP
    Friend WithEvents sp_InfBanalceGeneralTableAdapter As WindowsApplication1.DSBalanceGeneralOPTableAdapters.sp_InfBanalceGeneralTableAdapter
End Class
