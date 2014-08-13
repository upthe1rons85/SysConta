Public Class frmRPTInformeIVA
    Public fechainicio As Date
    Public fechafin As Date
    Public nEstatus As String
    Public nBanco As String
    Public nPoliza As String
    Private Sub frmRPTInformeIVA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInformeIva.spInformeIva' Puede moverla o quitarla según sea necesario.
        Me.spInformeIvaTableAdapter.Fill(Me.DSInformeIva.spInformeIva, nEstatus, fechainicio, fechafin, nBanco, nPoliza)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class