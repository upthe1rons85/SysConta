Public Class frmRPTGiroProveedores
    Public codigo As String
    Private Sub frmRPTGiroProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSGiroProv.spSelGiroComercial' Puede moverla o quitarla según sea necesario.
        Me.spSelGiroComercialTableAdapter.Fill(Me.DSGiroProv.spSelGiroComercial, codigo)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class