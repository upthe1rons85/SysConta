Public Class frmRPTReporteCheques
    Public FechaIni As Date
    Public FechaFin As Date
    Public CodProveedor As Integer

    Private Sub frmRPTReporteCheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSRepCheques.spReporteCheque' Puede moverla o quitarla según sea necesario.
        Me.spReporteChequeTableAdapter.Fill(Me.DSRepCheques.spReporteCheque, FechaIni, FechaFin, CodProveedor)
        ''TODO: esta línea de código carga datos en la tabla 'DSRepC.spReporteCheque' Puede moverla o quitarla según sea necesario
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class