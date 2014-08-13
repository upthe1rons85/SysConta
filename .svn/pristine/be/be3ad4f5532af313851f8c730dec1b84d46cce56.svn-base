Imports WindowsApplication1.clsTools
Public Class frmRPTAreas

    Private Sub frmRPTAreas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInfAreas.spInfAreas' Puede moverla o quitarla según sea necesario.
        Me.spInfAreasTableAdapter.Fill(Me.DSInfAreas.spInfAreas)
        Me.Text = "Informe Areas" + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class