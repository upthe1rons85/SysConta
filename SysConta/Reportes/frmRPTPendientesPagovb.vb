Imports Microsoft.Reporting.WinForms
Public Class frmRPTPendientesPagovb
    Public FechaIni As Date
    Public FechaFin As Date
    Public Proveedor As String
    Public FolCot As String
    Public FolSol As Integer

    Private Sub frmRPTPendientesPagovb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized
        Me.Focus()
        DSPendientesPago.EnforceConstraints = False
        Me.spSPPendienteProgramarPagoTableAdapter.Fill(Me.DSPendientesPago.spSPPendienteProgramarPago, FolSol, FolCot, Proveedor, FechaIni, FechaFin)
        'Me.spInformeContrareciboTableAdapter.Fill(Me.DSProgramacionPagos.spInformeContrarecibo, 11)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 25
    End Sub
End Class