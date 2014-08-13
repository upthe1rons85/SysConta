Public Class frmRPTInformeMovCatProveedores

    Public FchIni As Date
    Public FchFin As Date
    Private Sub frmRPTInformeMovCatProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSMovimientoCatProveedores.spInformeMovProveedores1' Puede moverla o quitarla según sea necesario.
        Me.spInformeMovProveedores1TableAdapter.Fill(Me.DSMovimientoCatProveedores.spInformeMovProveedores1, FchIni, FchFin)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class