Imports WindowsApplication1.clsTools
Public Class frmRPTEdoResultados
    Public Mes As Integer
    Public Anio As Integer
    Public Nivel As Integer
    Private Sub frmRPTEdoResultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSEstadoResultado.sp_InfEstadoResultado_OP' Puede moverla o quitarla según sea necesario.
        'Me.sp_InfEstadoResultado_OPTableAdapter.Fill(Me.DSEstadoResultado.sp_InfEstadoResultado_OP)

        Try
            Me.Text = "Estado de Resultados " + Space(5) + CStr(VersionCont())
            'TODO: esta línea de código carga datos en la tabla 'DSEdoResultados.spInfEdoResultados' Puede moverla o quitarla según sea necesario.
            Me.sp_InfEstadoResultado_OPTableAdapter.Fill(Me.DSEstadoResultado.sp_InfEstadoResultado_OP, Mes, Anio, Nivel)
            'Me.spInfEdoResultadosTableAdapter.Fill(Me.DSEdoResultados.spInfEdoResultados, Mes, Anio, Nivel)
            Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
            'If (Mes > 12) Then
            ' parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", "   "))
            ' Else
            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", StrConv(MonthName(Mes), VbStrConv.ProperCase)))
            'End If
            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("anio", Anio.ToString))

            Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("No se puede Consultar El Periodo Seleccionado", MsgBoxStyle.Information, "Error")
            Me.Close()
        End Try
    End Sub
End Class