Imports WindowsApplication1.clsTools
Public Class frmEdoResultadosCECO

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'If (cbxNivel.SelectedIndex + 1) = 1 Then
        '    Dim frm As New frmRPTedoResulCecoN1()
        '    frm.Mes = cbxMes.SelectedIndex + 1
        '    frm.Anio = cbxAnio.SelectedItem
        '    frm.Nivel = cbxNivel.SelectedIndex + 1
        '    frm.Show()
        'ElseIf (cbxNivel.SelectedIndex + 1) = 2 Then
        '    Dim frm As New frmRTPEdoResulCecoN2vb()
        '    frm.Mes = cbxMes.SelectedIndex + 1
        '    frm.Anio = cbxAnio.SelectedItem
        '    frm.Nivel = cbxNivel.SelectedIndex + 1
        '    frm.Show()
        'ElseIf (cbxNivel.SelectedIndex + 1) = 3 Then
        '    Dim frm As New frmRTPEdoResulCecoN3()
        '    frm.Mes = cbxMes.SelectedIndex + 1
        '    frm.Anio = cbxAnio.SelectedItem
        '    frm.Nivel = cbxNivel.SelectedIndex + 1
        '    frm.Show()
        'ElseIf (cbxNivel.SelectedIndex + 1) = 4 Then
        '    Dim frm As New frmRTPEdoResulCecoN4()
        '    frm.Mes = cbxMes.SelectedIndex + 1
        '    frm.Anio = cbxAnio.SelectedItem
        '    frm.Nivel = cbxNivel.SelectedIndex + 1
        '    frm.Show()
        'End If
        Dim frm As New frmRPTEstadoResultadoCECO()
        frm.Mes = cbxMes.SelectedIndex + 1
        frm.Anio = cbxAnio.SelectedItem
        frm.Nivel = cbxNivel.SelectedIndex + 1
        frm.Show()
    End Sub

    Private Sub frmEdoResultadosCECO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Estado de Resultados " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        cbxMes.SelectedIndex = Month(Now) - 1
        cbxAnio.Text = Year(Now)
    End Sub
End Class