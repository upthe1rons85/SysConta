Public Class frmRPTRelacionSaldosMayor
    Public mes As Integer
    Public anio As Integer
    Public nivel As Integer

    Private Sub frmRPTRelacionSaldosMayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'DSRelacionSaldosMayor.spInformeRelacionSaldos' Puede moverla o quitarla según sea necesario.
            DSRelacionSaldosMayor.EnforceConstraints = False
            Me.spInformeRelacionSaldosTableAdapter.Fill(Me.DSRelacionSaldosMayor.spInformeRelacionSaldos, mes, anio, nivel)
            Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", StrConv(MonthName(mes), VbStrConv.ProperCase)))
            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("anio", anio.ToString))
            Me.ReportViewer1.LocalReport.SetParameters(parametros)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("No se puede Consultar El Periodo Seleccionado " + ex.Message, MsgBoxStyle.Information, "Error")
            Me.Close()
        End Try
    End Sub
End Class