Public Class frmRPTInfCuentasContables

    Private Sub frmRPTInfCuentasContables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'TODO: esta línea de código carga datos en la tabla 'DSInfCuentasContables.spSelCuentasInforme' Puede moverla o quitarla según sea necesario.
        Me.spSelCuentasInformeTableAdapter.Fill(Me.DSInfCuentasContables.spSelCuentasInforme, "")

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class