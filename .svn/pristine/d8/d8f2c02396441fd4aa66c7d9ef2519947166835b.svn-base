Imports WindowsApplication1.clsTools
Public Class frmEdoResultados

    Private Sub LblBancos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBancos.Click

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTEstadoResultado()
        frm.Mes = cbxMes.SelectedIndex + 1
        frm.Anio = cbxAnio.SelectedItem
        frm.Nivel = cbxNivel.SelectedIndex + 1
        frm.Show()
    End Sub

    Private Sub frmEdoResultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Estado de Resultados " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        cbxMes.SelectedIndex = Month(Now) - 1
        cbxAnio.Text = Year(Now)
    End Sub
End Class