Public Class frmRPTRelacionSaldosNivel2
    Public mes As Integer
    Public anio As Integer
    Public nivel As Integer

    Private Sub frmRPTRelacionSaldosNivel2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'DSRelacionSaldosNivel2.spInformeRelacionSaldos' Puede moverla o quitarla según sea necesario.
            Me.spInformeRelacionSaldosTableAdapter.Fill(Me.DSRelacionSaldosNivel2.spInformeRelacionSaldos, mes, anio, nivel)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("No se puede Consultar El Periodo Seleccionado", MsgBoxStyle.Information, "Error")
            Me.Close()
        End Try
    End Sub
End Class