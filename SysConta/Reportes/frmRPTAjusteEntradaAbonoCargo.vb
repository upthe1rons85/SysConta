Public Class frmRPTAjusteEntradaAbonoCargo
    Public cargoAbono As String
    Public ocEngorda As Integer

    Private Sub frmRPTAjusteEntradaAbonoCargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAjusteEntradaRecibo.spselAjusteEntradaRecibo' Puede moverla o quitarla según sea necesario.
        Me.spselAjusteEntradaReciboTableAdapter.Fill(Me.DSAjusteEntradaRecibo.spselAjusteEntradaRecibo, ocEngorda)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("cargoabono", cargoAbono))

        Me.ReportViewer1.LocalReport.SetParameters(parametros)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class