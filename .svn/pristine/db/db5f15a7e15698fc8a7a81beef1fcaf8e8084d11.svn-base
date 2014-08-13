Imports WindowsApplication1.clsTools
Public Class frmInformesContabilidad

    Private Sub frmInformesContabilidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Estado de Resultados " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        cbxMes.SelectedIndex = Month(Now) - 1
        cbxAnio.Text = Year(Now)
    End Sub

    Private Sub rResultado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rResultado.CheckedChanged
        If rResultado.Checked = True Then
            chCECO.Enabled = True
        Else
            chCECO.Enabled = False
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If rBanalce.Checked = True Then
            Dim frm As New frmRPTBalanceGeneral()
            frm.mes = cbxMes.SelectedIndex + 1
            frm.Anio = cbxAnio.SelectedItem
            If cbxNivel.SelectedIndex + 1 < 5 Then
                frm.Nivel = cbxNivel.SelectedIndex + 1
                frm.Show()
            Else
                MsgBox("Informe no se puede mostrar por este nivel ", MsgBoxStyle.Information, "Sistemas Contabilidad")
            End If
        End If

        If rComprobacion.Checked = True Then
            Dim frm As New frmRPTBalanzaComprobacion
            frm.Mes = cbxMes.SelectedIndex + 1
            frm.Anio = cbxAnio.SelectedItem
            frm.nivel = cbxNivel.SelectedIndex + 1
            frm.Show()
        End If
        If rResultado.Checked = True Then
            If chCECO.Checked = False Then
                Dim frm As New frmRPTEstadoResultado()
                frm.mes = cbxMes.SelectedIndex + 1
                frm.anio = cbxAnio.SelectedItem
                frm.nivel = cbxNivel.SelectedIndex + 1
                frm.Show()
            Else
                Dim frm As New frmRPTEstadoResultadoCECO()
                frm.Mes = cbxMes.SelectedIndex + 1
                frm.Anio = cbxAnio.SelectedItem
                frm.Nivel = cbxNivel.SelectedIndex + 1
                frm.Show()
            End If
        End If
        If rSaldo.Checked = True Then
            Dim frm As New frmRPTRelacionSaldosMayor()
            frm.mes = cbxMes.SelectedIndex + 1
            frm.anio = cbxAnio.SelectedItem
            frm.nivel = cbxNivel.SelectedIndex + 1
            frm.Show()
        End If
    End Sub
End Class