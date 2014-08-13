Public Class frmRTPEdoResulCecoN2V2
    Public Mes As Integer
    Public Anio As Integer
    Public Nivel As Integer

    Private Sub frmRTPEdoResulCecoN2V2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSEdoResulCecoN2V2.spEdoResulCECOn2V2' Puede moverla o quitarla según sea necesario.
        Me.spEdoResulCECOn2V2TableAdapter.Fill(Me.DSEdoResulCecoN2V2.spEdoResulCECOn2V2, Anio, Mes)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        If (Mes > 12) Then
            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", "   "))
        Else
            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", StrConv(MonthName(Mes).Substring(0, 3), VbStrConv.ProperCase)))
        End If
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("anio", Anio.ToString))

        Me.ReportViewer1.LocalReport.SetParameters(parametros)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class