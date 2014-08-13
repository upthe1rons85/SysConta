Imports WindowsApplication1.clsTools
Public Class frmBalanzaComprobacion

    Private Sub frmBalanzaComptobacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Balanza de Comprobacion " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        cbxMes.SelectedIndex = Month(Now) - 1
        cbxAnio.Text = Year(Now)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim frm As New frmRPTBalanzaComprobacion()
        frm.Mes = cbxMes.SelectedIndex + 1
        frm.Anio = cbxAnio.SelectedItem
        frm.nivel = cbxNivel.SelectedIndex + 1
        frm.Show()

    End Sub
End Class