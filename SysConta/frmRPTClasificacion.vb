Imports WindowsApplication1.clsTools
Public Class frmRPTClasificacion

    Private Sub frmRPTClasificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInfClasificacion.spInfClasificacion' Puede moverla o quitarla según sea necesario.
        Me.spInfClasificacionTableAdapter.Fill(Me.DSInfClasificacion.spInfClasificacion)
        Me.Text = "Informe Clasificacion" + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class