Public Class frmRPTInformeMovProveedores
    Public codigo As Integer
    Public FchIni As Date
    Public FchFin As Date
    Private Sub frmRPTInformeMovProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSMovimientosProveedores.spInformeMovProveedores' Puede moverla o quitarla según sea necesario.
        Me.spInformeMovProveedoresTableAdapter.Fill(Me.DSMovimientosProveedores.spInformeMovProveedores, codigo, FchIni, FchFin)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class