Imports WindowsApplication1.clsTools
Public Class frmRPTBalanceGeneral
    Public Mes As Integer
    Public Anio As Integer
    Public Nivel As Integer

    Private Sub frmRPTBalanceGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSBalanceGeneralOP.sp_InfBanalceGeneral' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DSBalanceGeneral.spInformeBalanceGeneral' Puede moverla o quitarla según sea necesario.
        Try
            Me.Text = "Balance General " + Space(5) + CStr(VersionCont())
            Me.sp_InfBanalceGeneralTableAdapter.Fill(Me.DSBalanceGeneralOP.sp_InfBanalceGeneral, Mes, Anio, Nivel)
            'Me.spInformeBalanceGeneralTableAdapter.Fill(Me.DSBalanceGeneral.spInformeBalanceGeneral, Mes, Anio, Nivel)
            Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", StrConv(MonthName(Mes), VbStrConv.ProperCase)))
            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("anio", Anio.ToString))

            Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("No se puede Consultar El Periodo Seleccionado", MsgBoxStyle.Information, "Error")
            Me.Close()
        End Try
    End Sub
End Class