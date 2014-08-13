Imports WindowsApplication1.clsTools
Public Class frmRPTTrasSaldo

    'Dim folio As Integer
    'Dim referencia As String
    Private Sub frmRPTTrasSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSTrasSaldo.spInformeTransSaldos' Puede moverla o quitarla según sea necesario.
        Me.spInformeTransSaldosTableAdapter.Fill(Me.DSTrasSaldo.spInformeTransSaldos, folio, referencia)

        Me.ReportViewer1.RefreshReport()

        Me.Text = "Transferencia InterBancaria " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
    End Sub
End Class