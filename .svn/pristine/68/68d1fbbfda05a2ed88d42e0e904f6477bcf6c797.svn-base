Imports WindowsApplication1.clsTools
Public Class frmRPTBancos

    Private Sub frmRPTBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInfBancos.spInfBancos' Puede moverla o quitarla según sea necesario.
        Me.spInfBancosTableAdapter.Fill(Me.DSInfBancos.spInfBancos)
        Me.Text = "Informe de Bancos " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class