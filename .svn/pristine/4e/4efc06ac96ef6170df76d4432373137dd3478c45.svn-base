Imports WindowsApplication1.clsTools
Public Class frmRTPEdoResulCecoN4
    Public Mes As Integer
    Public Anio As Integer
    Public Nivel As Integer
    Private Sub frmRTPEdoResulCecoN4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Estado de Resultados por CECO " + Space(5) + CStr(VersionCont())
            'TODO: esta línea de código carga datos en la tabla 'DSEdoResulCecoN4.spEdoResulCECOn4' Puede moverla o quitarla según sea necesario.
            Me.spEdoResulCECOn4TableAdapter.Fill(Me.DSEdoResulCecoN4.spEdoResulCECOn4, Anio, Mes)
            Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
            If (Mes > 12) Then
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", "   "))
            Else
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", StrConv(MonthName(Mes).Substring(0, 3), VbStrConv.ProperCase)))
            End If
            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("anio", Anio.ToString))

            Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("No se puede Consultar El Periodo Seleccionado", MsgBoxStyle.Information, "Error")
            Me.Close()
        End Try
    End Sub
End Class