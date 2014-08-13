Imports Microsoft.Reporting.WinForms
Public Class frmRPTImprimirNC
    Public nFolio As Integer
    Private Sub frmRPTImprimirNC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSImprimirNC.spSelNotaCred' Puede moverla o quitarla según sea necesario.
        Me.WindowState = FormWindowState.Maximized
        Me.Focus()
        DSImprimirNC.EnforceConstraints = False
        Me.spSelNotaCredTableAdapter.Fill(Me.DSImprimirNC.spSelNotaCred, 2, nFolio)
        'Me.spInformeContrareciboTableAdapter.Fill(Me.DSProgramacionPagos.spInformeContrarecibo, 11)

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 25
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class