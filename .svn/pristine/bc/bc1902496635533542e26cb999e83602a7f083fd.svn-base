Public Class frmRPTEstadoResultado
    Public mes As String
    Public anio As String
    Public nivel As String
    Private Sub frmRPTEstadoResultado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSEstadoResultado.sp_InfEstadoResultado_OP' Puede moverla o quitarla según sea necesario.
        Me.sp_InfEstadoResultado_OPTableAdapter.Fill(Me.DSEstadoResultado.sp_InfEstadoResultado_OP, mes, anio, nivel)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", StrConv(MonthName(mes).Substring(0, 3), VbStrConv.ProperCase)))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("anio", anio.ToString))
        Me.ReportViewer1.LocalReport.SetParameters(parametros)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class