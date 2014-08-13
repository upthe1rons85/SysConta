Imports WindowsApplication1.clsTools
Public Class frmRPTInfDepreciacionContable
    Public Mes As Integer
    Public Año As Integer
    Private Sub frmRPTInfDepreciacionContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSDepreContable.spDepreciacionContable' Puede moverla o quitarla según sea necesario.
        Me.spDepreciacionContableTableAdapter.Fill(Me.DSDepreContable.spDepreciacionContable, Mes, Año)
        Me.Text = "Informe Depreciacion Contable" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class