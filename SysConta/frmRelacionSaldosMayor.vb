Imports WindowsApplication1.clsTools
Public Class frmRelacionSaldosMayor


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim nivel As Int32 = cbxNivel.SelectedIndex + 1
        If nivel = 1 Then
            Dim frm As New frmRPTRelacionSaldosMayor()
            frm.mes = cbxMes.SelectedIndex + 1
            frm.anio = cbxAnio.SelectedItem
            frm.nivel = cbxNivel.SelectedIndex + 1
            frm.Show()

        ElseIf nivel = 2 Then

            Dim frm As New frmRPTRelacionSaldosNivel2()
            frm.mes = cbxMes.SelectedIndex + 1
            frm.anio = cbxAnio.SelectedItem
            frm.nivel = cbxNivel.SelectedIndex + 1
            frm.Show()
        ElseIf nivel = 3 Then
            Dim frm As New frmRPTRelacionSaldosNivel3
            frm.mes = cbxMes.SelectedIndex + 1
            frm.anio = cbxAnio.SelectedItem
            frm.nivel = cbxNivel.SelectedIndex + 1
            frm.Show()
        ElseIf nivel = 4 Then
            Dim frm As New frmRPTRelacionSaldosNivel4()
            frm.mes = cbxMes.SelectedIndex + 1
            frm.anio = cbxAnio.SelectedItem
            frm.nivel = cbxNivel.SelectedIndex + 1
            frm.Show()
        End If

    End Sub

    Private Sub frmRelacionSaldosMayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Relacion de Saldos " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
    End Sub
End Class