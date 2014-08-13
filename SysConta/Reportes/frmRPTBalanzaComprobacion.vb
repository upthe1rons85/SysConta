Imports WindowsApplication1.clsTools
Public Class frmRPTBalanzaComprobacion
    Public Mes As Integer
    Public Anio As Integer
    Public nivel As Integer

    Private Sub frmRPTBalanzaComprobacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBBalanzaComprobacion.spImformeBalanzaComprobacion' Puede moverla o quitarla según sea necesario.
        'alaniz
        Try
            Me.Text = "Balanza de Comprobacion " + Space(5) + CStr(VersionCont())
            Me.spImformeBalanzaComprobacionTableAdapter.Fill(Me.DBBalanzaComprobacion.spImformeBalanzaComprobacion, Mes, Anio, nivel)
            Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
            If (Mes > 12) Then
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", "   "))
            Else
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", StrConv(MonthName(Mes), VbStrConv.ProperCase)))
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