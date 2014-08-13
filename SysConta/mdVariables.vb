Module mdVariables
    Public LoginUsuario As String
    Public VPCatCuentasPuente As String
    Public tipocuenta As String
    Public Perfilesusuario As String
    Public folio As Integer
    Public referencia As String
    Public fecha As String
    Public ConexionBD As String = "Data Source=SERVERCONTA;Initial Catalog=Contabilidad;User ID=controlnomina;Password=Denes1257"

    Public Sub NoRepetirInstancia()
        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
            MessageBox.Show("Ya existe una instancia de la aplicación", "Error de Instancia de Proceso", _
                  MessageBoxButtons.OK, _
                 MessageBoxIcon.Exclamation)
            Application.Exit()
        End If
    End Sub
End Module
