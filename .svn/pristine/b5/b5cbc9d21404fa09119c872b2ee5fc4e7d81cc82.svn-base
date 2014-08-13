Public Class frmRPTTransferenciaSaldos
    Dim folio As Integer
    Dim referencia As String
    Private Sub frmRPTTransferenciaSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DStransferencia.spInformeTransSaldos' Puede moverla o quitarla según sea necesario.
        Me.spInformeTransSaldosTableAdapter.Fill(Me.DStransferencia.spInformeTransSaldos, folio, referencia)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class