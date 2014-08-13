Imports WindowsApplication1.clsTools
Public Class frmRPTCuentasCECOS

    Private Sub frmRPTCuentasCECOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSCuentasCECOS_DEPTOS.deptos' Puede moverla o quitarla según sea necesario.
        Me.deptosTableAdapter.Fill(Me.DSCuentasCECOS_DEPTOS.deptos)
        Me.Text = "Informe Clasificacion" + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class