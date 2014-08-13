Imports Microsoft.Reporting.WinForms
Public Class frmRPTProgramacionPagos
    Public folioContraRecibo As String

    Private Sub frmRPTProgramacionPagos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub frmRPTProgramacionPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSProgramacionPagos.spInformeContrarecibo' Puede moverla o quitarla según sea necesario.
        Me.WindowState = FormWindowState.Maximized
        Me.Focus()
        DSProgramacionPagos.EnforceConstraints = False
        Me.spInformeContrareciboTableAdapter.Fill(Me.DSProgramacionPagos.spInformeContrarecibo, folioContraRecibo)
        'Me.spInformeContrareciboTableAdapter.Fill(Me.DSProgramacionPagos.spInformeContrarecibo, 11)

        'Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 25
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class