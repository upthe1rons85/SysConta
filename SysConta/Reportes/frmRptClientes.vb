Public Class frmRptClientes
    Public codigo As String
    Private Sub frmRptClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSCatClientes.spSelCatClientes' Puede moverla o quitarla según sea necesario.
        Me.spSelCatClientesTableAdapter.Fill(Me.DSCatClientes.spSelCatClientes, codigo)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class