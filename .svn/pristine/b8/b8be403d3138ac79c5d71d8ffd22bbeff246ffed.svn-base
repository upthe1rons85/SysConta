Imports WindowsApplication1.clsTools
Public Class frmRptCuentasN2

    Private Sub frmRptCuentasN2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSCtaNivel2.spInfCtaNivel2' Puede moverla o quitarla según sea necesario.
        Me.spInfCtaNivel2TableAdapter.Fill(Me.DSCtaNivel2.spInfCtaNivel2)
        'TODO: esta línea de código carga datos en la tabla 'contabilidadDataSet2.catCuentasNivel2' Puede moverla o quitarla según sea necesario.
        Me.Text = "Informe Cuenta Nivel 2  " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class