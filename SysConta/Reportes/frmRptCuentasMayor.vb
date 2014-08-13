Imports WindowsApplication1.clsTools
Public Class frmRptCuentasMayor

    Private Sub frmRptCuentasMayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'contabilidadDataSet.catCuentasdeMayor' Puede moverla o quitarla según sea necesario.
        Me.catCuentasdeMayorTableAdapter.Fill(Me.contabilidadDataSet.catCuentasdeMayor)
        Me.Text = "Informe Cuentas de Mayor" + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class