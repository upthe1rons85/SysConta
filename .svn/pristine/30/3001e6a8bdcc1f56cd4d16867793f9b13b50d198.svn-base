Public Class frmRPTEstadoResultadoCECO
    Public Mes As Integer
    Public Anio As Integer
    Public Nivel As Integer
    Private Sub frmRPTEstadoResultadoCECO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSEstadoResultadoCECO.spEsTadoResultadoCECOS' Puede moverla o quitarla según sea necesario.
        Me.spEsTadoResultadoCECOSTableAdapter.Fill(Me.DSEstadoResultadoCECO.spEsTadoResultadoCECOS, Anio, Mes, Nivel)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", StrConv(MonthName(Mes), VbStrConv.ProperCase)))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("anio", Anio.ToString))
        Me.ReportViewer1.LocalReport.SetParameters(parametros)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class