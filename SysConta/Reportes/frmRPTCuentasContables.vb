Public Class FrmRPTCuentasContables

    Private Sub FrmRPTCuentasContables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'contabilidadDataSet3.spCuentaContable' Puede moverla o quitarla según sea necesario.
        Me.spCuentaContableTableAdapter.Fill(Me.contabilidadDataSet3.spCuentaContable)
    End Sub
End Class