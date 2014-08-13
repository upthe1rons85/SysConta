Public Class frmRPTInformeProveedores
    Public codigo As Integer
    Private Sub frmRPTInformeProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'contabilidadDataSet4.spBusProveedor' Puede moverla o quitarla según sea necesario.
        Me.spBusProveedorTableAdapter.Fill(Me.contabilidadDataSet4.spBusProveedor, codigo)

   
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class