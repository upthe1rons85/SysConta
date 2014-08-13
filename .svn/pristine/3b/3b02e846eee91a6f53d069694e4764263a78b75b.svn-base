Public Class frmInformeAjusteEntrada

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTInfAjusteEntrada()
        frm.fechafin = Nothing
        frm.fechainicio = Nothing
        If chkfecha.Checked = True Then
            frm.fechainicio = dtpFchIni.Value
            frm.fechafin = dtpFchFin.Value
        End If
        If TxtOcEngorda.Text <> "" Then
            frm.ocengorda = TxtOcEngorda.Text
        End If
        If txtFolioEntrada.Text <> "" Then
            frm.folioentrada = txtFolioEntrada.Text
        End If
        frm.codigoProveedor = 0
        frm.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfecha.CheckedChanged
        If (chkfecha.Checked = True) Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If

    End Sub

    Private Sub txtFolioEntrada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioEntrada.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtOcEngorda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOcEngorda.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub frmInformeAjusteEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
    End Sub
End Class