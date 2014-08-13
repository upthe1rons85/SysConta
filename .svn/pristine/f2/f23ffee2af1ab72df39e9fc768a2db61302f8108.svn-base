Imports WindowsApplication1.clsTools
Public Class frmRPTInfCuentas

    Private Sub frmRPTInfCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInfCtaContables.spCuentaContable' Puede moverla o quitarla según sea necesario.
        Me.spCuentaContableTableAdapter.Fill(Me.DSInfCtaContables.spCuentaContable)
        'TODO: esta línea de código carga datos en la tabla 'DSInfCuentas.spCuentaContable' Puede moverla o quitarla según sea necesario
        Me.Text = "Informe Cuentas Contables" + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class