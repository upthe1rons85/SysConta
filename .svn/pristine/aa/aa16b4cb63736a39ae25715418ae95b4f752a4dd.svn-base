Public Class frmDepreciacionContable

    Private Sub frmDepreciacionContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTInfDepreciacionContable
        frm.Mes = DtpFecha.Value.Month
        frm.Año = DtpFecha.Value.Year
        frm.Show()
    End Sub
End Class