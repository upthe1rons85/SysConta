Public Class frmRPTInformeHistorialCuentas
    Public TotalCuentas As String
    Public dFechaIni As Date
    Public dFechaFin As Date


    Private Sub frmRPTInformeHistorialCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInformeHistorialCuenta.spInformePolizasxCuenta' Puede moverla o quitarla según sea necesario.
        Me.spInformePolizasxCuentaTableAdapter.Fill(Me.DSInformeHistorialCuenta.spInformePolizasxCuenta, TotalCuentas, dFechaIni, dFechaFin)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Cuentas", TotalCuentas.ToString))
        Me.ReportViewer1.LocalReport.SetParameters(parametros)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class