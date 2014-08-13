Public Class frmRPTRelacionSaldosNivel3
    Public mes As Integer
    Public anio As Integer
    Public nivel As Integer

    Private Sub frmRPTRelacionSaldosNivel3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.spInformeRelacionSaldosTableAdapter.Fill(Me.DSRelacionSaldosNivel3.spInformeRelacionSaldos, mes, anio, nivel)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("No se puede Consultar El Periodo Seleccionado", MsgBoxStyle.Information, "Error")
            Me.Close()
        End Try
    End Sub
End Class